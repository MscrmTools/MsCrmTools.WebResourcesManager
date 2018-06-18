namespace MscrmTools.WebresourcesManager
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsddCrmMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsmiLoadWebResources = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiLoadWebResourcesFromASpecificSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReloadFromCurrentSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUpdateWebresources = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePublishWebresources = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePublishAddWebresources = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddFileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiLoadFromDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveToDiskWithRoots = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveToDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddWindow = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiWebresourcesExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPendingUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMainProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddTools = new System.Windows.Forms.ToolStripDropDownButton();
            this.findWebresourcesWithoutDependenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dpMain = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.cmsWebresourceTreeview = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddExistingFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddNewResource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewHtml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewCss = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewScript = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewXsl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewResx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddNewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFolder1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCollapse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExpand = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFolder2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUpdateFolderFromDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenameWebresource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshFileFromDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGetLatest = new System.Windows.Forms.ToolStripMenuItem();
            this.tssResource1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePublish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePublishAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tssResource2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tssResource3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOpenInCrm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopyNameToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.tssResource4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSetDependencies = new System.Windows.Forms.ToolStripMenuItem();
            this.tssResource5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTabs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTabsCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTabsCloseThis = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTabsCloseExceptThis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenu.SuspendLayout();
            this.cmsWebresourceTreeview.SuspendLayout();
            this.cmsTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddCrmMenu,
            this.toolStripSeparator1,
            this.tsddFileMenu,
            this.toolStripSeparator2,
            this.tsddWindow,
            this.toolStripSeparator3,
            this.tsddTools});
            this.toolStripMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1024, 37);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "mainToolStrip";
            // 
            // tsddCrmMenu
            // 
            this.tsddCrmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiLoadWebResources,
            this.TsmiLoadWebResourcesFromASpecificSolution,
            this.tsmiReloadFromCurrentSolution,
            this.toolStripSeparator9,
            this.tsmiUpdateWebresources,
            this.tsmiUpdatePublishWebresources,
            this.tsmiUpdatePublishAddWebresources});
            this.tsddCrmMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsddCrmMenu.Image")));
            this.tsddCrmMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddCrmMenu.Name = "tsddCrmMenu";
            this.tsddCrmMenu.Size = new System.Drawing.Size(107, 34);
            this.tsddCrmMenu.Text = "CRM";
            this.tsddCrmMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddCrmMenu_DropDownItemClicked);
            // 
            // TsmiLoadWebResources
            // 
            this.TsmiLoadWebResources.Image = ((System.Drawing.Image)(resources.GetObject("TsmiLoadWebResources.Image")));
            this.TsmiLoadWebResources.Name = "TsmiLoadWebResources";
            this.TsmiLoadWebResources.Size = new System.Drawing.Size(656, 34);
            this.TsmiLoadWebResources.Text = "Load Web resources";
            // 
            // TsmiLoadWebResourcesFromASpecificSolution
            // 
            this.TsmiLoadWebResourcesFromASpecificSolution.Name = "TsmiLoadWebResourcesFromASpecificSolution";
            this.TsmiLoadWebResourcesFromASpecificSolution.Size = new System.Drawing.Size(656, 34);
            this.TsmiLoadWebResourcesFromASpecificSolution.Text = "Load Web resources from a specific solution";
            // 
            // tsmiReloadFromCurrentSolution
            // 
            this.tsmiReloadFromCurrentSolution.Name = "tsmiReloadFromCurrentSolution";
            this.tsmiReloadFromCurrentSolution.Size = new System.Drawing.Size(656, 34);
            this.tsmiReloadFromCurrentSolution.Tag = "Reload from {0} ({1})";
            this.tsmiReloadFromCurrentSolution.Text = "Reload";
            this.tsmiReloadFromCurrentSolution.Visible = false;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(653, 6);
            // 
            // tsmiUpdateWebresources
            // 
            this.tsmiUpdateWebresources.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdateWebresources.Image")));
            this.tsmiUpdateWebresources.Name = "tsmiUpdateWebresources";
            this.tsmiUpdateWebresources.Size = new System.Drawing.Size(656, 34);
            this.tsmiUpdateWebresources.Text = "Update checked Web resources";
            // 
            // tsmiUpdatePublishWebresources
            // 
            this.tsmiUpdatePublishWebresources.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdatePublishWebresources.Image")));
            this.tsmiUpdatePublishWebresources.Name = "tsmiUpdatePublishWebresources";
            this.tsmiUpdatePublishWebresources.Size = new System.Drawing.Size(656, 34);
            this.tsmiUpdatePublishWebresources.Text = "Update and publish checked Web resources";
            // 
            // tsmiUpdatePublishAddWebresources
            // 
            this.tsmiUpdatePublishAddWebresources.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdatePublishAddWebresources.Image")));
            this.tsmiUpdatePublishAddWebresources.Name = "tsmiUpdatePublishAddWebresources";
            this.tsmiUpdatePublishAddWebresources.Size = new System.Drawing.Size(656, 34);
            this.tsmiUpdatePublishAddWebresources.Text = "Update, publish and add to solution checked web resources";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsddFileMenu
            // 
            this.tsddFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadFromDisk,
            this.tsmiSaveToDiskWithRoots,
            this.tsmiSaveToDisk});
            this.tsddFileMenu.Image = ((System.Drawing.Image)(resources.GetObject("tsddFileMenu.Image")));
            this.tsddFileMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddFileMenu.Name = "tsddFileMenu";
            this.tsddFileMenu.Size = new System.Drawing.Size(93, 34);
            this.tsddFileMenu.Text = "File";
            this.tsddFileMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddFileMenu_DropDownItemClicked);
            // 
            // tsmiLoadFromDisk
            // 
            this.tsmiLoadFromDisk.Image = ((System.Drawing.Image)(resources.GetObject("tsmiLoadFromDisk.Image")));
            this.tsmiLoadFromDisk.Name = "tsmiLoadFromDisk";
            this.tsmiLoadFromDisk.Size = new System.Drawing.Size(548, 34);
            this.tsmiLoadFromDisk.Text = "Load Web resources";
            // 
            // tsmiSaveToDiskWithRoots
            // 
            this.tsmiSaveToDiskWithRoots.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveToDiskWithRoots.Image")));
            this.tsmiSaveToDiskWithRoots.Name = "tsmiSaveToDiskWithRoots";
            this.tsmiSaveToDiskWithRoots.Size = new System.Drawing.Size(548, 34);
            this.tsmiSaveToDiskWithRoots.Text = "Save checked Web resources (with roots) to disk";
            // 
            // tsmiSaveToDisk
            // 
            this.tsmiSaveToDisk.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSaveToDisk.Image")));
            this.tsmiSaveToDisk.Name = "tsmiSaveToDisk";
            this.tsmiSaveToDisk.Size = new System.Drawing.Size(548, 34);
            this.tsmiSaveToDisk.Text = "Save checked Web resources to disk";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsddWindow
            // 
            this.tsddWindow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWebresourcesExplorer,
            this.tsmiPendingUpdates,
            this.tsmiMainProperties,
            this.tsmiSettings});
            this.tsddWindow.Image = ((System.Drawing.Image)(resources.GetObject("tsddWindow.Image")));
            this.tsddWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddWindow.Name = "tsddWindow";
            this.tsddWindow.Size = new System.Drawing.Size(110, 34);
            this.tsddWindow.Text = "Window";
            this.tsddWindow.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddWindow_DropDownItemClicked);
            // 
            // tsmiWebresourcesExplorer
            // 
            this.tsmiWebresourcesExplorer.Name = "tsmiWebresourcesExplorer";
            this.tsmiWebresourcesExplorer.Size = new System.Drawing.Size(315, 34);
            this.tsmiWebresourcesExplorer.Text = "Webresources Explorer";
            // 
            // tsmiPendingUpdates
            // 
            this.tsmiPendingUpdates.Name = "tsmiPendingUpdates";
            this.tsmiPendingUpdates.Size = new System.Drawing.Size(315, 34);
            this.tsmiPendingUpdates.Text = "Pending Updates";
            // 
            // tsmiMainProperties
            // 
            this.tsmiMainProperties.Name = "tsmiMainProperties";
            this.tsmiMainProperties.Size = new System.Drawing.Size(315, 34);
            this.tsmiMainProperties.Text = "Properties";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(315, 34);
            this.tsmiSettings.Text = "Settings";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // tsddTools
            // 
            this.tsddTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findWebresourcesWithoutDependenciesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.tsddTools.Image = ((System.Drawing.Image)(resources.GetObject("tsddTools.Image")));
            this.tsddTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddTools.Name = "tsddTools";
            this.tsddTools.Size = new System.Drawing.Size(81, 34);
            this.tsddTools.Text = "Tools";
            this.tsddTools.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddTools_DropDownItemClicked);
            // 
            // findWebresourcesWithoutDependenciesToolStripMenuItem
            // 
            this.findWebresourcesWithoutDependenciesToolStripMenuItem.Name = "findWebresourcesWithoutDependenciesToolStripMenuItem";
            this.findWebresourcesWithoutDependenciesToolStripMenuItem.Size = new System.Drawing.Size(485, 34);
            this.findWebresourcesWithoutDependenciesToolStripMenuItem.Text = "Find webresources without dependencies";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toCSVToolStripMenuItem,
            this.toClipboardToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(485, 34);
            this.toolStripMenuItem1.Text = "Export selected webresources";
            this.toolStripMenuItem1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddTools_DropDownItemClicked);
            // 
            // toCSVToolStripMenuItem
            // 
            this.toCSVToolStripMenuItem.Name = "toCSVToolStripMenuItem";
            this.toCSVToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.toCSVToolStripMenuItem.Text = "To CSV";
            // 
            // toClipboardToolStripMenuItem
            // 
            this.toClipboardToolStripMenuItem.Name = "toClipboardToolStripMenuItem";
            this.toClipboardToolStripMenuItem.Size = new System.Drawing.Size(220, 34);
            this.toClipboardToolStripMenuItem.Text = "To Clipboard";
            // 
            // dpMain
            // 
            this.dpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dpMain.DockBackColor = System.Drawing.Color.White;
            this.dpMain.DocumentStyle = WeifenLuo.WinFormsUI.Docking.DocumentStyle.DockingWindow;
            this.dpMain.Location = new System.Drawing.Point(0, 37);
            this.dpMain.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dpMain.Name = "dpMain";
            this.dpMain.Size = new System.Drawing.Size(1024, 517);
            this.dpMain.TabIndex = 5;
            // 
            // cmsWebresourceTreeview
            // 
            this.cmsWebresourceTreeview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddExistingFile,
            this.tsmiAddNewResource,
            this.tsmiAddNewFolder,
            this.tssFolder1,
            this.tsmiCollapse,
            this.tsmiExpand,
            this.tssFolder2,
            this.tsmiUpdateFolderFromDisk,
            this.tsmiRenameWebresource,
            this.tsmiRefreshFileFromDisk,
            this.tsmiGetLatest,
            this.tssResource1,
            this.tsmiUpdate,
            this.tsmiUpdatePublish,
            this.tsmiUpdatePublishAdd,
            this.tssResource2,
            this.tsmiDelete,
            this.tssResource3,
            this.tsmiOpenInCrm,
            this.tsmiCopyNameToClipboard,
            this.tssResource4,
            this.tsmiSetDependencies,
            this.tssResource5,
            this.tsmiProperties});
            this.cmsWebresourceTreeview.Name = "contextMenuStripTreeView";
            this.cmsWebresourceTreeview.Size = new System.Drawing.Size(551, 624);
            this.cmsWebresourceTreeview.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsWebresourceTreeview_ItemClicked);
            // 
            // tsmiAddExistingFile
            // 
            this.tsmiAddExistingFile.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddExistingFile.Image")));
            this.tsmiAddExistingFile.Name = "tsmiAddExistingFile";
            this.tsmiAddExistingFile.Size = new System.Drawing.Size(562, 34);
            this.tsmiAddExistingFile.Text = "Add existing file(s) as Web resource(s)";
            // 
            // tsmiAddNewResource
            // 
            this.tsmiAddNewResource.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewHtml,
            this.tsmiNewCss,
            this.tsmiNewScript,
            this.tsmiNewData,
            this.tsmiNewXsl,
            this.tsmiNewResx});
            this.tsmiAddNewResource.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddNewResource.Image")));
            this.tsmiAddNewResource.Name = "tsmiAddNewResource";
            this.tsmiAddNewResource.Size = new System.Drawing.Size(562, 34);
            this.tsmiAddNewResource.Text = "Add new empty web resource";
            this.tsmiAddNewResource.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsWebresourceTreeview_ItemClicked);
            // 
            // tsmiNewHtml
            // 
            this.tsmiNewHtml.Name = "tsmiNewHtml";
            this.tsmiNewHtml.Size = new System.Drawing.Size(270, 34);
            this.tsmiNewHtml.Text = "Web Page (HTML)";
            // 
            // tsmiNewCss
            // 
            this.tsmiNewCss.Name = "tsmiNewCss";
            this.tsmiNewCss.Size = new System.Drawing.Size(270, 34);
            this.tsmiNewCss.Text = "Style Sheet (CSS)";
            // 
            // tsmiNewScript
            // 
            this.tsmiNewScript.Name = "tsmiNewScript";
            this.tsmiNewScript.Size = new System.Drawing.Size(270, 34);
            this.tsmiNewScript.Text = "Script (JScript)";
            // 
            // tsmiNewData
            // 
            this.tsmiNewData.Name = "tsmiNewData";
            this.tsmiNewData.Size = new System.Drawing.Size(270, 34);
            this.tsmiNewData.Text = "Data (XML)";
            // 
            // tsmiNewXsl
            // 
            this.tsmiNewXsl.Name = "tsmiNewXsl";
            this.tsmiNewXsl.Size = new System.Drawing.Size(270, 34);
            this.tsmiNewXsl.Text = "Style Sheet (XSL)";
            // 
            // tsmiNewResx
            // 
            this.tsmiNewResx.Name = "tsmiNewResx";
            this.tsmiNewResx.Size = new System.Drawing.Size(270, 34);
            this.tsmiNewResx.Text = "Resources (RESX)";
            // 
            // tsmiAddNewFolder
            // 
            this.tsmiAddNewFolder.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddNewFolder.Image")));
            this.tsmiAddNewFolder.Name = "tsmiAddNewFolder";
            this.tsmiAddNewFolder.Size = new System.Drawing.Size(562, 34);
            this.tsmiAddNewFolder.Text = "Add new folder";
            // 
            // tssFolder1
            // 
            this.tssFolder1.Name = "tssFolder1";
            this.tssFolder1.Size = new System.Drawing.Size(559, 6);
            // 
            // tsmiCollapse
            // 
            this.tsmiCollapse.Name = "tsmiCollapse";
            this.tsmiCollapse.Size = new System.Drawing.Size(562, 34);
            this.tsmiCollapse.Text = "Collapse (including childrens)";
            // 
            // tsmiExpand
            // 
            this.tsmiExpand.Name = "tsmiExpand";
            this.tsmiExpand.Size = new System.Drawing.Size(562, 34);
            this.tsmiExpand.Text = "Expand (including childrens)";
            // 
            // tssFolder2
            // 
            this.tssFolder2.Name = "tssFolder2";
            this.tssFolder2.Size = new System.Drawing.Size(559, 6);
            // 
            // tsmiUpdateFolderFromDisk
            // 
            this.tsmiUpdateFolderFromDisk.Name = "tsmiUpdateFolderFromDisk";
            this.tsmiUpdateFolderFromDisk.Size = new System.Drawing.Size(562, 34);
            this.tsmiUpdateFolderFromDisk.Text = "Update web resources in this folder with local files";
            // 
            // tsmiRenameWebresource
            // 
            this.tsmiRenameWebresource.Name = "tsmiRenameWebresource";
            this.tsmiRenameWebresource.Size = new System.Drawing.Size(562, 34);
            this.tsmiRenameWebresource.Text = "Rename web resource";
            // 
            // tsmiRefreshFileFromDisk
            // 
            this.tsmiRefreshFileFromDisk.Name = "tsmiRefreshFileFromDisk";
            this.tsmiRefreshFileFromDisk.Size = new System.Drawing.Size(562, 34);
            this.tsmiRefreshFileFromDisk.Text = "Refresh from disk";
            // 
            // tsmiGetLatest
            // 
            this.tsmiGetLatest.Image = ((System.Drawing.Image)(resources.GetObject("tsmiGetLatest.Image")));
            this.tsmiGetLatest.Name = "tsmiGetLatest";
            this.tsmiGetLatest.Size = new System.Drawing.Size(562, 34);
            this.tsmiGetLatest.Text = "Get latest version";
            this.tsmiGetLatest.ToolTipText = "Get latest version from Microsoft Dynamics CRM connected organization";
            // 
            // tssResource1
            // 
            this.tssResource1.Name = "tssResource1";
            this.tssResource1.Size = new System.Drawing.Size(559, 6);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdate.Image")));
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(562, 34);
            this.tsmiUpdate.Text = "Save to CRM server";
            // 
            // tsmiUpdatePublish
            // 
            this.tsmiUpdatePublish.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdatePublish.Image")));
            this.tsmiUpdatePublish.Name = "tsmiUpdatePublish";
            this.tsmiUpdatePublish.Size = new System.Drawing.Size(562, 34);
            this.tsmiUpdatePublish.Text = "Save and Publish to CRM server";
            // 
            // tsmiUpdatePublishAdd
            // 
            this.tsmiUpdatePublishAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiUpdatePublishAdd.Image")));
            this.tsmiUpdatePublishAdd.Name = "tsmiUpdatePublishAdd";
            this.tsmiUpdatePublishAdd.Size = new System.Drawing.Size(562, 34);
            this.tsmiUpdatePublishAdd.Text = "Save, publish and add to solution";
            // 
            // tssResource2
            // 
            this.tssResource2.Name = "tssResource2";
            this.tssResource2.Size = new System.Drawing.Size(559, 6);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsmiDelete.Image")));
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(562, 34);
            this.tsmiDelete.Text = "Delete";
            // 
            // tssResource3
            // 
            this.tssResource3.Name = "tssResource3";
            this.tssResource3.Size = new System.Drawing.Size(559, 6);
            // 
            // tsmiOpenInCrm
            // 
            this.tsmiOpenInCrm.Image = ((System.Drawing.Image)(resources.GetObject("tsmiOpenInCrm.Image")));
            this.tsmiOpenInCrm.Name = "tsmiOpenInCrm";
            this.tsmiOpenInCrm.Size = new System.Drawing.Size(562, 34);
            this.tsmiOpenInCrm.Text = "Open web resource record in CRM application";
            // 
            // tsmiCopyNameToClipboard
            // 
            this.tsmiCopyNameToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCopyNameToClipboard.Image")));
            this.tsmiCopyNameToClipboard.Name = "tsmiCopyNameToClipboard";
            this.tsmiCopyNameToClipboard.Size = new System.Drawing.Size(562, 34);
            this.tsmiCopyNameToClipboard.Text = "Copy web resource name to clipboard ";
            // 
            // tssResource4
            // 
            this.tssResource4.Name = "tssResource4";
            this.tssResource4.Size = new System.Drawing.Size(559, 6);
            // 
            // tsmiSetDependencies
            // 
            this.tsmiSetDependencies.Name = "tsmiSetDependencies";
            this.tsmiSetDependencies.Size = new System.Drawing.Size(562, 34);
            this.tsmiSetDependencies.Text = "Set dependencies";
            // 
            // tssResource5
            // 
            this.tssResource5.Name = "tssResource5";
            this.tssResource5.Size = new System.Drawing.Size(559, 6);
            // 
            // tsmiProperties
            // 
            this.tsmiProperties.Image = ((System.Drawing.Image)(resources.GetObject("tsmiProperties.Image")));
            this.tsmiProperties.Name = "tsmiProperties";
            this.tsmiProperties.Size = new System.Drawing.Size(562, 34);
            this.tsmiProperties.Text = "Properties";
            // 
            // cmsTabs
            // 
            this.cmsTabs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTabsCloseThis,
            this.cmsTabsCloseExceptThis,
            this.cmsTabsCloseAll});
            this.cmsTabs.Name = "cmsTabs";
            this.cmsTabs.Size = new System.Drawing.Size(306, 144);
            this.cmsTabs.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsTabs_ItemClicked);
            // 
            // cmsTabsCloseAll
            // 
            this.cmsTabsCloseAll.Name = "cmsTabsCloseAll";
            this.cmsTabsCloseAll.Size = new System.Drawing.Size(305, 34);
            this.cmsTabsCloseAll.Text = "Close all tabs";
            // 
            // cmsTabsCloseThis
            // 
            this.cmsTabsCloseThis.Name = "cmsTabsCloseThis";
            this.cmsTabsCloseThis.Size = new System.Drawing.Size(305, 34);
            this.cmsTabsCloseThis.Text = "Close this tab";
            // 
            // cmsTabsCloseExceptThis
            // 
            this.cmsTabsCloseExceptThis.Name = "cmsTabsCloseExceptThis";
            this.cmsTabsCloseExceptThis.Size = new System.Drawing.Size(305, 34);
            this.cmsTabsCloseExceptThis.Text = "Close all except this tab";
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpMain);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1024, 554);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.cmsWebresourceTreeview.ResumeLayout(false);
            this.cmsTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dpMain;
        private System.Windows.Forms.ToolStripDropDownButton tsddCrmMenu;
        private System.Windows.Forms.ToolStripMenuItem TsmiLoadWebResources;
        private System.Windows.Forms.ToolStripMenuItem TsmiLoadWebResourcesFromASpecificSolution;
        private System.Windows.Forms.ToolStripMenuItem tsmiReloadFromCurrentSolution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateWebresources;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePublishWebresources;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePublishAddWebresources;
        private System.Windows.Forms.ToolStripDropDownButton tsddFileMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFromDisk;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveToDiskWithRoots;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveToDisk;
        private System.Windows.Forms.ContextMenuStrip cmsWebresourceTreeview;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddExistingFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewResource;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewHtml;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewCss;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewScript;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewData;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewXsl;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewResx;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddNewFolder;
        private System.Windows.Forms.ToolStripSeparator tssFolder1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenameWebresource;
        private System.Windows.Forms.ToolStripSeparator tssFolder2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCollapse;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpand;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateFolderFromDisk;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshFileFromDisk;
        private System.Windows.Forms.ToolStripMenuItem tsmiGetLatest;
        private System.Windows.Forms.ToolStripSeparator tssResource1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePublish;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePublishAdd;
        private System.Windows.Forms.ToolStripSeparator tssResource2;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripSeparator tssResource3;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenInCrm;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopyNameToClipboard;
        private System.Windows.Forms.ToolStripSeparator tssResource4;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetDependencies;
        private System.Windows.Forms.ToolStripSeparator tssResource5;
        private System.Windows.Forms.ToolStripMenuItem tsmiProperties;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsddWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmiWebresourcesExplorer;
        private System.Windows.Forms.ToolStripMenuItem tsmiPendingUpdates;
        private System.Windows.Forms.ToolStripMenuItem tsmiMainProperties;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton tsddTools;
        private System.Windows.Forms.ToolStripMenuItem findWebresourcesWithoutDependenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toClipboardToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsTabs;
        private System.Windows.Forms.ToolStripMenuItem cmsTabsCloseAll;
        private System.Windows.Forms.ToolStripMenuItem cmsTabsCloseThis;
        private System.Windows.Forms.ToolStripMenuItem cmsTabsCloseExceptThis;
    }
}
