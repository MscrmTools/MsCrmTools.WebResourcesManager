using MscrmTools.WebresourcesManager.AppCode;
using MscrmTools.WebresourcesManager.AppCode.Args;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using XrmToolBox.Extensibility;

namespace MscrmTools.WebresourcesManager.Forms.Contents
{
    public abstract partial class BaseContentForm : DockContent
    {
        protected Size SavedSize;
        private const string OpenfileTitleMask = "Select the {0} to replace the existing webresource";
        private readonly MyPluginControl mainControl;

        public BaseContentForm()
        {
        }

        public BaseContentForm(MyPluginControl mainControl, bool isCode = false, bool isImage = false)
        {
            InitializeComponent();

            this.mainControl = mainControl;

            tsddbEdit.Visible = isCode;
            tsddbCompare.Visible = isCode;
            tsbBeautify.Visible = isCode;
            tsbMinifyJS.Visible = isCode;
            tsbComment.Visible = isCode;
            tsbnUncomment.Visible = isCode;
            tssComments.Visible = isCode;

            tsmiSave.Visible = !isImage;
            tsmiUpdatePublish.Visible = !isImage;
        }

        public BaseContentForm(MyPluginControl mainControl, Webresource resource, bool isCode = false, bool isImage = false) : this(mainControl, isCode, isImage)
        {
            Resource = resource;
            Resource.StateChanged += Resource_StateChanged;
            Resource.SavedToDisk += Resource_SavedToDisk;

            tsmiRefreshFromDisk.Enabled = !string.IsNullOrEmpty(resource.FilePath);
            tsbGetLatestVersion.Enabled = resource.Synced;

            tslWebresource.Text = resource.Name;
            if (resource.State == WebresourceState.Draft)
            {
                tslWebresource.Text += @" (not saved)";
                tslWebresource.ForeColor = Color.Red;
            }
            else if (resource.State == WebresourceState.Saved)
            {
                tslWebresource.Text += @" (not published)";
                tslWebresource.ForeColor = Color.Blue;
            }
        }

        public Webresource Resource { get; }

        protected abstract void ClearEvents();

        private void BaseContentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Resource.State == WebresourceState.Draft)
            {
                if (Settings.Instance.AutoSaveWhenLeaving)
                {
                    Resource.Save();
                }
                else
                {
                    var message =
                        @"This webresource has some unsaved changes.

Are you sure you want to close this window and lose the changes?";
                    if (MessageBox.Show(this, message, @"Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                        DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Resource.CancelChanges();
                    }
                }
            }

            Resource.StateChanged -= Resource_StateChanged;
            Resource.SavedToDisk -= Resource_SavedToDisk;
            ClearEvents();
        }

        private void CleanCompareFolder()
        {
            var path = Path.Combine(Paths.XrmToolBoxPath, "CompareTemp");
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }

        private void Compare()
        {
            if (string.IsNullOrWhiteSpace(Settings.Instance.CompareToolPath))
            {
                MessageBox.Show(this, @"Please define Compare tool before using this feature", @"Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mainControl.ShowSettings();
                return;
            }

            CleanCompareFolder();

            var file1Path = Resource.SaveToDisk(Path.Combine(Paths.XrmToolBoxPath, "CompareTemp"));

            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var file2Path = ofd.FileName;

                    var startInfo = new ProcessStartInfo(Settings.Instance.CompareToolPath)
                    {
                        Arguments = $"{Settings.Instance.CompareToolArgs} \"{file1Path}\" \"{file2Path}\""
                    };
                    Process.Start(startInfo);
                }
            }
        }

        private void OpenFileDialogSettings(OpenFileDialog ofd)
        {
            switch (Resource.Type)
            {
                case (int)WebresourceType.Gif:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "image");
                        ofd.Filter = @"GIF file (*.gif)|*.gif";
                    }
                    break;

                case (int)WebresourceType.Jpg:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "image");
                        ofd.Filter = @"JPG file (*.jpg)|*.jpg";
                    }
                    break;

                case (int)WebresourceType.Png:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "image");
                        ofd.Filter = @"PNG file (*.png)|*.png";
                    }
                    break;

                case (int)WebresourceType.Ico:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "icon");
                        ofd.Filter = @"ICO file (*.ico)|*.ico";
                    }
                    break;

                case (int)WebresourceType.Script:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "script file");
                        ofd.Filter = @"Javascript file (*.js)|*.js";
                    }
                    break;

                case (int)WebresourceType.WebPage:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "web page");
                        ofd.Filter = @"Web page (*.html,*.htm)|*.html;*.htm";
                    }
                    break;

                case (int)WebresourceType.Css:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "css file");
                        ofd.Filter = @"Stylesheet (*.css)|*.css";
                    }
                    break;

                case (int)WebresourceType.Xsl:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "xslt file");
                        ofd.Filter = @"Transformation file (*.xslt)|*.xslt";
                    }
                    break;

                case (int)WebresourceType.Silverlight:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "Silverlight application");
                        ofd.Filter = @"Silverlight application file (*.xap)|*.xap";
                    }
                    break;

                case (int)WebresourceType.Vector:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "vectorial image");
                        ofd.Filter = @"Vectorial image file (*.svg)|*.svg";
                    }
                    break;

                case (int)WebresourceType.Resx:
                    {
                        ofd.Title = string.Format(OpenfileTitleMask, "resource file");
                        ofd.Filter = @"Resource file (*.resx)|*.resx";
                    }
                    break;
            }
        }

        private void ReplaceWithNewFile()
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    OpenFileDialogSettings(ofd);

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        var content = Convert.ToBase64String(File.ReadAllBytes(ofd.FileName));

                        Resource.ReplaceContent(content);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(mainControl, $@"An error occured while replacing new file: {error.Message}",
                    @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Resource_SavedToDisk(object sender, ResourceEventArgs e)
        {
            if (IsDisposed || Disposing)
            {
                return;
            }

            Invoke(new Action(() =>
            {
                tsmiRefreshFromDisk.Enabled = true;
            }));
        }

        private void Resource_StateChanged(object sender, StateEventArgs e)
        {
            Invoke(new Action(() =>
            {
                tsmiSave.Enabled = e.State == WebresourceState.Draft;
                tsbGetLatestVersion.Enabled = Resource.Synced;

                if (e.State == WebresourceState.Draft)
                {
                    Text = $@"{Resource.Name} *";
                    tslWebresource.Text = $@"{Resource.Name} (not saved)";
                    tslWebresource.ForeColor = Color.Red;
                }
                else if (e.State == WebresourceState.Saved)
                {
                    Text = $@"{Resource.Name} !";
                    tslWebresource.Text = $@"{Resource.Name} (not published)";
                    tslWebresource.ForeColor = Color.Blue;
                }
                else
                {
                    Text = Resource.Name;
                    tslWebresource.Text = Resource.Name;
                    tslWebresource.ForeColor = Color.Black;
                }
            }));
        }

        private void tsbBeautify_Click(object sender, EventArgs e)
        {
            if (this is CodeEditorForm cef)
            {
                cef.Beautify();
            }
        }

        private void tsbComment_Click(object sender, EventArgs e)
        {
            if (this is CodeEditorForm cef)
            {
                cef.CommentSelectedLines();
            }
        }

        private void tsbGetLatestVersion_Click(object sender, EventArgs e)
        {
            Resource.GetLatestVersion();
        }

        private void tsbMinifyJS_Click(object sender, EventArgs e)
        {
            if (this is CodeEditorForm cef)
            {
                cef.Minify();
            }
        }

        private void tsbnUncomment_Click(object sender, EventArgs e)
        {
            if (this is CodeEditorForm cef)
            {
                cef.UncommentSelectedLines();
            }
        }

        private void tsddbCompare_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiCompareSettings)
            {
                mainControl.ShowSettings();
            }
            else if (e.ClickedItem == tsmiCompare)
            {
                Compare();
            }
        }

        private void tsddbEdit_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (this is CodeEditorForm cef)
            {
                if (e.ClickedItem == tsmiGoToLine)
                {
                    cef.GoToLine();
                }
                else if (e.ClickedItem == tsmiEditorFind)
                {
                    cef.Find(false);
                }
                else if (e.ClickedItem == tsmiEditorReplace)
                {
                    cef.Find(true);
                }
            }
        }

        private void tsddbFile_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == tsmiSave)
            {
                Resource.Save();
                tsmiSave.Enabled = false;
            }
            else if (e.ClickedItem == tsmiUpdatePublish)
            {
                var us = new UpdateResourcesSettings
                {
                    Webresources = new List<Webresource> { Resource },
                    Publish = true
                };

                mainControl.PerformUpdate(us);
            }
            else if (e.ClickedItem == tsmiRefreshFromDisk)
            {
                Resource.RefreshFromDisk();
            }
            else if (e.ClickedItem == tsmiReplace)
            {
                ReplaceWithNewFile();
            }
        }
    }
}