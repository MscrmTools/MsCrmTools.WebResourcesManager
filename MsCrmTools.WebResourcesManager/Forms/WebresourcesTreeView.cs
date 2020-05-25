using Microsoft.Xrm.Sdk;
using MscrmTools.WebresourcesManager.AppCode;
using MscrmTools.WebresourcesManager.AppCode.Args;
using MscrmTools.WebresourcesManager.AppCode.Exceptions;
using MscrmTools.WebresourcesManager.CustomControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DirectoryInfo = System.IO.DirectoryInfo;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class WebresourcesTreeView : DockContent
    {
        private readonly MyPluginControl mainControl;
        private bool lastSearchBarPositionSetting;
        private Entity solution;

        public WebresourcesTreeView()
        {
            InitializeComponent();

            ToolTip tip = new ToolTip();
            tip.SetToolTip(chkSearchInContent, "Search also in files content");
            tip.SetToolTip(chkDisplayExpanded, "Display results as expanded");

            SetNotSyncedImageLayout();

            tv.TreeViewNodeSorter = new NodeSorter();
        }

        public WebresourcesTreeView(MyPluginControl mainControl) : this()
        {
            this.mainControl = mainControl;
            mainControl.WebresourcesCache.CollectionChanged += WebresourcesCache_CollectionChanged;
        }

        public event EventHandler<NodeSelectedEventArgs> ContextMenuRequested;

        public event EventHandler<ResourceEventArgs> ResourceDisplayRequested;

        public event EventHandler<ResourceEventArgs> ResourceSelected;

        public event EventHandler<InvalidFilesEventArgs> ShowInvalidFilesRequested;

        public event EventHandler ShowPendingUpdatesRequested;

        public int OrganizationMajorVersion { get; set; }

        public IOrganizationService Service { get; set; }

        private void llDismissPendingUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show(this, @"Are you sure you want to dismiss pending updates?

Webresources will be considered has unchanged", @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            foreach (var webresource in mainControl.WebresourcesCache)
            {
                webresource.ResetState();
            }
        }

        private void llSynchronize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPendingUpdatesRequested?.Invoke(this, new EventArgs());
        }

        private void tv_DragDrop(object sender, DragEventArgs e)
        {
            var invalidFilesList = new List<string>();

            // Retrieve the current selected node
            var treeview = (TreeView)sender;
            var location = tv.PointToScreen(Point.Empty);
            var currentNode = treeview.GetNodeAt(e.X - location.X, e.Y - location.Y);

            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (var file in files.OrderBy(f => !File.GetAttributes(f).HasFlag(FileAttributes.Directory)).ThenBy(f => Path.GetFileName(f)))
            {
                if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                {
                    var di = new DirectoryInfo(file);

                    AddSingleFolder((FolderNode)currentNode, di.Name, di);

                    continue;
                }

                var fi = new FileInfo(file);

                AddFilesAsNodes((FolderNode)currentNode, new List<string> { fi.FullName }, invalidFilesList);

                // Create file if the current node has a filepath in its tag
                // this means, wen resources come from disk
                if (Directory.Exists(((FolderNode)currentNode).FolderPath))
                {
                    var resultingFileName = Path.Combine(((FolderNode)currentNode).FolderPath, fi.Name);
                    if (resultingFileName.ToLower() != fi.FullName.ToLower())
                    {
                        if (DialogResult.Yes == MessageBox.Show(
                                $@"Would you like to also copy this file to folder '{((FolderNode)currentNode).FolderPath}'?",
                                @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            File.WriteAllBytes(resultingFileName, File.ReadAllBytes(file));
                        }
                    }
                }
            }

            if (invalidFilesList.Any())
            {
                ShowInvalidFilesRequested?.Invoke(this, new InvalidFilesEventArgs(invalidFilesList));
            }

            tv.Sort();
        }

        private void tv_DragOver(object sender, DragEventArgs e)
        {
            // Retrieve the current selected node
            var treeview = (TreeView)sender;
            var treeViewLocation = treeview.PointToScreen(Point.Empty);
            var currentNode = treeview.GetNodeAt(e.X - treeViewLocation.X, e.Y - treeViewLocation.Y);

            if (e.Data.GetDataPresent(DataFormats.FileDrop) && currentNode is FolderNode)
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // File must be an expected file format
                // or a folder
                bool isExtensionValid = files.All(f => Webresource.IsValidExtension(Path.GetExtension(f)) || File.GetAttributes(f).HasFlag(FileAttributes.Directory));

                // Destination node must be a Root or Folder node
                treeview.SelectedNode = currentNode;

                e.Effect = files.Length > 0 && isExtensionValid
                    ? DragDropEffects.All
                    : DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void WebresourcesCache_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var resource in e.NewItems.OfType<Webresource>())
                {
                    resource.StateChanged += (s, evt) =>
                    {
                        DisplayWaitingForUpdatePanel();
                    };
                }
            }
        }

        private void WebresourcesTreeView_Enter(object sender, EventArgs e)
        {
            if (lastSearchBarPositionSetting != Settings.Instance.DisplayExplorerSearchBarOnTop)
            {
                lastSearchBarPositionSetting = Settings.Instance.DisplayExplorerSearchBarOnTop;

                pnlSearch.Dock = Settings.Instance.DisplayExplorerSearchBarOnTop ? DockStyle.Top : DockStyle.Bottom;

                Invalidate();
            }
        }

        private void WebresourcesTreeView_Load(object sender, EventArgs e)
        {
        }

        #region Treeview Display

        public WebresourceNode AddSingleNode(Webresource resource, string[] nameParts, FolderNode folder = null)
        {
            var fileName = nameParts.Last();
            WebresourceType type = WebresourceType.Auto;

            if (resource.Type != 0)
            {
                type = (WebresourceType)resource.Type;
            }

            if (type == WebresourceType.Auto)
            {
                if (fileName.IndexOf(".", StringComparison.Ordinal) < 0)
                {
                    if (resource.Type == 0)
                    {
                        return null;
                    }

                    type = (WebresourceType)resource.Type;
                }
                else
                {
                    type = Webresource.GetTypeFromExtension(fileName
                        .Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Last());
                }
            }

            WebresourceNode node = null;

            switch (type)
            {
                case WebresourceType.WebPage:
                    node = new WebpageNode(resource);
                    break;

                case WebresourceType.Css:
                    node = new CssNode(resource);
                    break;

                case WebresourceType.Data:
                    node = new DataNode(resource);
                    break;

                case WebresourceType.Gif:
                    node = new GifNode(resource);
                    break;

                case WebresourceType.Ico:
                    node = new IcoNode(resource);
                    break;

                case WebresourceType.Jpg:
                    node = new JpgNode(resource);
                    break;

                case WebresourceType.Png:
                    node = new PngNode(resource);
                    break;

                case WebresourceType.Resx:
                    node = new ResxNode(resource);
                    break;

                case WebresourceType.Script:
                    node = new JavaScriptNode(resource);
                    break;

                case WebresourceType.Silverlight:
                    node = new SilverlightNode(resource);
                    break;

                case WebresourceType.Vector:
                    node = new VectorNode(resource);
                    break;

                case WebresourceType.Xsl:
                    node = new XslNode(resource);
                    break;
            }

            resource.Node = node;

            if (folder != null && node != null)
            {
                folder.Nodes.Add(node);
            }

            return node;
        }

        public void DisplayNodes(IEnumerable<Webresource> resources, Entity theSolution = null, bool expanded = false)
        {
            Invoke(new Action(() =>
            {
                //pnlTop.Visible = false;

                solution = theSolution;
                if (solution != null)
                {
                    lblSolution.Text =
                        $@"{solution.GetAttributeValue<string>("friendlyname")} ({solution.GetAttributeValue<string>("version")})";
                    pnlSolution.Visible = true;
                }
            }));

            var resourcesToDisplay = mainControl.WebresourcesCache.Where(w => txtSearch.Text.Length == 0
                                                                || w.ToString().ToLower()
                                                                    .Contains(txtSearch.Text.ToLower())
                                                                || chkSearchInContent.Checked
                                                                && w.UpdatedStringContent.ToLower()
                                                                    .Contains(txtSearch.Text.ToLower())).ToList();

            if (!resourcesToDisplay.Any() && txtSearch.Text.Length > 0)
            {
                txtSearch.BackColor = Color.LightCoral;
                return;
            }

            var rootNodes = new List<TreeNode>();

            var invalidFilesList = new List<string>();

            var orderedResources = resourcesToDisplay.OrderBy(r => r.Name.ToLower());
            foreach (var resource in orderedResources)
            {
                if (Webresource.IsNameValid(resource.Name, OrganizationMajorVersion) &&
                    Webresource.IsValidExtension(Path.GetExtension(resource.Name)))
                {
                    var nameParts = resource.Name.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                    if (nameParts.Length == 1)
                    {
                        var node = AddSingleNode(resource, nameParts);
                        if (node != null)
                        {
                            rootNodes.Add(node);
                        }
                    }
                    else
                    {
                        AddFolderNode(resource, nameParts, rootNodes);
                    }
                }
                else
                {
                    invalidFilesList.Add(resource.Name);
                }
            }

            if (invalidFilesList.Any())
            {
                ShowInvalidFilesRequested?.Invoke(this, new InvalidFilesEventArgs(invalidFilesList));
            }

            tv.Nodes.Clear();
            tv.Nodes.AddRange(rootNodes.ToArray());
            tv.Sort();

            if (expanded)
            {
                tv.ExpandAll();
            }
        }

        internal void AddFilesAsNodes(FolderNode parentNode, List<string> files, List<string> invalidFileNames)
        {
            foreach (string fileName in files)
            {
                var fi = new FileInfo(fileName);
                var ext = fi.Extension;
                if (ext.Length > 0)
                {
                    ext = ext.Remove(0, 1);
                }

                //Test valid characters
                if (Webresource.IsNameValid(fi.Name, OrganizationMajorVersion) && Webresource.IsValidExtension(ext))
                {
                    var name = $"{parentNode.ResourceFullPath}/{fi.Name}";

                    var resource = new Webresource(name, fi.FullName, WebresourceType.Auto, mainControl);
                    if (mainControl.WebresourcesCache.All(w => w.Name != resource.Name))
                    {
                        mainControl.WebresourcesCache.Add(resource);
                    }

                    AddSingleNode(resource, resource.Name.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries),
                        parentNode);
                    parentNode.Expand();
                }
                else
                {
                    invalidFileNames?.Add(fileName);
                }
            }

            tv.Sort();
        }

        internal void AddNewWebresource(FolderNode parentNode, WebresourceType type)
        {
            var map = WebresourceMapper.Instance.Items.First(i => i.Type == type);

            var nwrDialog = new NewWebResourceDialog(map.Extension, OrganizationMajorVersion);
            if (nwrDialog.ShowDialog(mainControl) == DialogResult.OK)
            {
                var name = $"{parentNode.ResourceFullPath}/{nwrDialog.WebresourceName}";

                var resource = new Webresource(name, null, type, mainControl);
                if (mainControl.WebresourcesCache.All(w => w.Name != resource.Name))
                {
                    mainControl.WebresourcesCache.Add(resource);
                }

                AddSingleNode(resource, name.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries), parentNode);

                parentNode.Expand();
            }
        }

        internal void AddSingleFolder(FolderNode node, string folderName, DirectoryInfo di = null, List<string> invalidFileNames = null)
        {
            var folderNode = new FolderNode(false, $"{node.ResourceFullPath}/{folderName}", di?.FullName);
            node.Nodes.Add(folderNode);

            if (di != null && Directory.Exists(di.FullName))
            {
                foreach (var subdirectory in di.GetDirectories())
                {
                    AddSingleFolder(folderNode, subdirectory.Name, subdirectory, invalidFileNames);
                }

                AddFilesAsNodes(folderNode, di.GetFiles().Select(f => f.FullName).ToList(), invalidFileNames);
            }
        }

        internal void RefreshFolderNodeContent(FolderNode folderNode, List<string> invalidFilenames, List<string> extensionsToLoad)
        {
            var path = folderNode.FolderPath;
            if (string.IsNullOrEmpty(path) || !Directory.Exists(path)) return;

            var di = new DirectoryInfo(path);
            var subNodes = folderNode.Nodes;
            var subFolders = di.GetDirectories();

            foreach (var subFolder in subFolders)
            {
                if (!subNodes.ContainsKey(subFolder.Name) || !(subNodes[subFolder.Name] is FolderNode fn))
                {
                    var newFolderNode = new FolderNode(false, subFolder.FullName, subFolder.FullName);
                    folderNode.Nodes.Add(newFolderNode);

                    RefreshFolderNodeContent(newFolderNode, invalidFilenames, extensionsToLoad);
                }
                else
                {
                    fn.FolderPath = subFolder.FullName;
                    RefreshFolderNodeContent(fn, invalidFilenames, extensionsToLoad);
                }
            }

            foreach (FileInfo fiChild in di.GetFiles("*.*", SearchOption.TopDirectoryOnly))
            {
                if (Webresource.IsNameValid(fiChild.Name, OrganizationMajorVersion) && Webresource.IsValidExtension(fiChild.Extension))
                {
                    if (extensionsToLoad == null || extensionsToLoad.Contains(fiChild.Extension))
                    {
                        if (!subNodes.ContainsKey(fiChild.Name) || !(subNodes[fiChild.Name] is WebresourceNode wn))
                        {
                            try
                            {
                                var name = $"{folderNode.ResourceFullPath}/{fiChild.Name}";

                                var resource = new Webresource(name, fiChild.FullName, WebresourceType.Auto,
                                    mainControl);
                                AddSingleNode(resource,
                                    resource.Name.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries),
                                    folderNode);
                            }
                            catch (UnknownExtensionException)
                            {
                                invalidFilenames.Add(fiChild.FullName);
                            }
                        }
                        else
                        {
                            wn.Resource.ReplaceContent(Convert.ToBase64String(File.ReadAllBytes(fiChild.FullName)), fiChild.FullName);
                        }
                    }
                }
                else if (!Webresource.IsNameValid(fiChild.Name, OrganizationMajorVersion) || !Webresource.SkipErrorForInvalidExtension(fiChild.Extension))
                {
                    invalidFilenames.Add(fiChild.FullName);
                }
            }
        }

        private void AddFolderNode(Webresource resource, string[] nameParts, object parent)
        {
            var nextParts = nameParts.Skip(1).ToList();
            var pathWithoutCurrent = string.Join("/", nextParts);
            var fullPath = resource.Name.Replace(pathWithoutCurrent, "");
            fullPath = fullPath.Remove(fullPath.Length - 1);

            FolderNode existingNode = null;
            if (parent is List<TreeNode> list)
            {
                existingNode = list.OfType<FolderNode>().FirstOrDefault(n => n.ResourceFullPath == fullPath);
            }
            else if (parent is FolderNode folder)
            {
                existingNode = folder.Nodes.OfType<FolderNode>().FirstOrDefault(n => n.ResourceFullPath == fullPath);
            }

            if (existingNode != null)
            {
                if (nextParts.Count > 1)
                {
                    AddFolderNode(resource, nextParts.ToArray(), existingNode);
                }
                else
                {
                    AddSingleNode(resource, nextParts.ToArray(), existingNode);
                }

                return;
            }

            FolderNode node = null;
            if (parent is List<TreeNode> rootList)
            {
                node = new FolderNode(true, fullPath);
                rootList.Add(node);
            }
            else if (parent is FolderNode folder)
            {
                node = new FolderNode(false, fullPath, folder.FolderPath != null ? Path.Combine(folder.FolderPath, fullPath) : null);
                folder.Nodes.Add(node);
            }

            if (nextParts.Count > 1)
            {
                AddFolderNode(resource, nextParts.ToArray(), node);
            }
            else
            {
                AddSingleNode(resource, nextParts.ToArray(), node);
            }
        }

        #endregion Treeview Display

        #region Search bar

        private Thread searchThread;

        private void chkDisplayExpanded_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDisplayExpanded.Checked)
            {
                tsbExpandAll_Click(tsbExpandAll, new EventArgs());
            }
            else
            {
                tsbCollapseAll_Click(tsbCollapseAll, new EventArgs());
            }
        }

        private void chkSearchInContent_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.BackColor = SystemColors.Window;
            searchThread?.Abort();
            searchThread = new Thread(DisplayWrs);
            searchThread.Start();
        }

        private void DisplayWrs()
        {
            tv.Invoke(new Action(() =>
            {
                DisplayNodes(mainControl.WebresourcesCache, solution, chkDisplayExpanded.Checked);
            }));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.BackColor = SystemColors.Window;
            searchThread?.Abort();
            searchThread = new Thread(DisplayWrs);
            searchThread.Start();
        }

        #endregion Search bar

        #region Menu events

        private void tsbCheckAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in tv.Nodes)
                node.Checked = true;
        }

        private void tsbClearAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in tv.Nodes)
                node.Checked = false;
        }

        private void tsbCollapseAll_Click(object sender, EventArgs e)
        {
            tv.CollapseAll();
        }

        private void tsbExpandAll_Click(object sender, EventArgs e)
        {
            tv.ExpandAll();
        }

        private void tsbNewRoot_Click(object sender, EventArgs e)
        {
            var nrd = new NewRootDialog { StartPosition = FormStartPosition.CenterParent };

            if (nrd.ShowDialog(ParentForm) == DialogResult.OK)
            {
                var rootNode = new FolderNode(true, nrd.RootName);

                tv.Nodes.Add(rootNode);

                tv.TreeViewNodeSorter = new NodeSorter();
                tv.Sort();
            }
        }

        #endregion Menu events

        #region Treeview events

        private void tv_AfterCheck(object sender, TreeViewEventArgs e)
        {
            (e.Node as FolderNode)?.SetChildsCheckState();
        }

        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tv.SelectedNode = e.Node;
            ResourceSelected?.Invoke(this, new ResourceEventArgs((e.Node as WebresourceNode)?.Resource));

            ResourceDisplayRequested?.Invoke(this, new ResourceEventArgs((e.Node as WebresourceNode)?.Resource));
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuRequested?.Invoke(this, new NodeSelectedEventArgs(e.Node, new Point(e.Location.X, e.Location.Y + pnlSolution.Height + (Settings.Instance.DisplayExplorerSearchBarOnTop ? pnlSearch.Height : 0))));
            }
        }

        #endregion Treeview events

        #region Other methods

        public void DisplayWaitingForUpdatePanel()
        {
            var waitingUpdateResources = mainControl.WebresourcesCache.Where(r => r.State == WebresourceState.Saved).ToList();

            Invoke(new Action(() =>
            {
                if (waitingUpdateResources.Any())
                {
                    lblWaitingUpdate.Text = string.Format(lblWaitingUpdate.Tag.ToString(),
                        waitingUpdateResources.Count,
                        waitingUpdateResources.Count > 1 ? "s" : "",
                        waitingUpdateResources.Count > 1 ? "" : "s");

                    pnlTop.Visible = true;
                }
                else
                {
                    pnlTop.Visible = false;
                }
            }));
        }

        private void SetNotSyncedImageLayout()
        {
            for (var i = 0; i < 14; i++)
            {
                var image = (Image)ilWebResourceTypes.Images[i].Clone();
                Bitmap bmp = new Bitmap(image.Width, image.Height);

                using (Graphics gfx = Graphics.FromImage(bmp))
                {
                    //create a color matrix object
                    ColorMatrix matrix = new ColorMatrix();

                    //set the opacity
                    matrix.Matrix33 = 0.5f;

                    //create image attributes
                    ImageAttributes attributes = new ImageAttributes();

                    //set the color(opacity) of the image
                    attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    //now draw the image
                    gfx.DrawImage(image, new Rectangle(0, 0, 16, 16), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel,
                        attributes);
                }

                ilWebResourceTypes.Images[i + 14] = bmp;
            }
        }

        #endregion Other methods
    }
}