namespace MscrmTools.WebresourcesManager.Forms.Contents
{
    partial class BaseContentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseContentForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsddbFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdatePublish = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefreshFromDisk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSeparatorEdit = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiEditorFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditorReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoToLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsddbCompare = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCompare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCompareSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbMinifyJS = new System.Windows.Forms.ToolStripButton();
            this.tsbBeautify = new System.Windows.Forms.ToolStripButton();
            this.tsbGetLatestVersion = new System.Windows.Forms.ToolStripButton();
            this.tssComments = new System.Windows.Forms.ToolStripSeparator();
            this.tsbComment = new System.Windows.Forms.ToolStripButton();
            this.tsbnUncomment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslWebresource = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbFile,
            this.tsSeparatorEdit,
            this.tsddbEdit,
            this.tsddbCompare,
            this.tsbMinifyJS,
            this.tsbBeautify,
            this.tsbGetLatestVersion,
            this.tssComments,
            this.tsbComment,
            this.tsbnUncomment,
            this.toolStripSeparator1,
            this.tslWebresource});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(1365, 37);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsddbFile
            // 
            this.tsddbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSave,
            this.tsmiUpdatePublish,
            this.tsmiRefreshFromDisk,
            this.tsmiReplace});
            this.tsddbFile.Image = ((System.Drawing.Image)(resources.GetObject("tsddbFile.Image")));
            this.tsddbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbFile.Name = "tsddbFile";
            this.tsddbFile.Size = new System.Drawing.Size(65, 34);
            this.tsddbFile.Text = "File";
            this.tsddbFile.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbFile_DropDownItemClicked);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Enabled = false;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(375, 34);
            this.tsmiSave.Text = "Save (Ctrl + S)";
            // 
            // tsmiUpdatePublish
            // 
            this.tsmiUpdatePublish.Name = "tsmiUpdatePublish";
            this.tsmiUpdatePublish.Size = new System.Drawing.Size(375, 34);
            this.tsmiUpdatePublish.Text = "Update and Publish (Ctrl + U)";
            // 
            // tsmiRefreshFromDisk
            // 
            this.tsmiRefreshFromDisk.Name = "tsmiRefreshFromDisk";
            this.tsmiRefreshFromDisk.Size = new System.Drawing.Size(375, 34);
            this.tsmiRefreshFromDisk.Text = "Refresh from disk (Ctrl + R)";
            // 
            // tsmiReplace
            // 
            this.tsmiReplace.Name = "tsmiReplace";
            this.tsmiReplace.Size = new System.Drawing.Size(375, 34);
            this.tsmiReplace.Text = "Replace with new file";
            // 
            // tsSeparatorEdit
            // 
            this.tsSeparatorEdit.Name = "tsSeparatorEdit";
            this.tsSeparatorEdit.Size = new System.Drawing.Size(6, 37);
            // 
            // tsddbEdit
            // 
            this.tsddbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditorFind,
            this.tsmiEditorReplace,
            this.tsmiGoToLine});
            this.tsddbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsddbEdit.Image")));
            this.tsddbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbEdit.Name = "tsddbEdit";
            this.tsddbEdit.Size = new System.Drawing.Size(69, 34);
            this.tsddbEdit.Text = "Edit";
            this.tsddbEdit.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbEdit_DropDownItemClicked);
            // 
            // tsmiEditorFind
            // 
            this.tsmiEditorFind.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditorFind.Image")));
            this.tsmiEditorFind.Name = "tsmiEditorFind";
            this.tsmiEditorFind.Size = new System.Drawing.Size(279, 34);
            this.tsmiEditorFind.Text = "Find (Ctrl+F)";
            // 
            // tsmiEditorReplace
            // 
            this.tsmiEditorReplace.Image = ((System.Drawing.Image)(resources.GetObject("tsmiEditorReplace.Image")));
            this.tsmiEditorReplace.Name = "tsmiEditorReplace";
            this.tsmiEditorReplace.Size = new System.Drawing.Size(279, 34);
            this.tsmiEditorReplace.Text = "Replace (Ctrl+H)";
            // 
            // tsmiGoToLine
            // 
            this.tsmiGoToLine.Name = "tsmiGoToLine";
            this.tsmiGoToLine.Size = new System.Drawing.Size(279, 34);
            this.tsmiGoToLine.Text = "Go To Line (Ctrl+G)";
            // 
            // tsddbCompare
            // 
            this.tsddbCompare.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCompare,
            this.tsmiCompareSettings});
            this.tsddbCompare.Image = ((System.Drawing.Image)(resources.GetObject("tsddbCompare.Image")));
            this.tsddbCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbCompare.Name = "tsddbCompare";
            this.tsddbCompare.Size = new System.Drawing.Size(146, 34);
            this.tsddbCompare.Text = "Compare";
            this.tsddbCompare.ToolTipText = "Compare the web resource in CRM with a local webresource";
            this.tsddbCompare.Visible = false;
            this.tsddbCompare.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsddbCompare_DropDownItemClicked);
            // 
            // tsmiCompare
            // 
            this.tsmiCompare.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCompare.Image")));
            this.tsmiCompare.Name = "tsmiCompare";
            this.tsmiCompare.Size = new System.Drawing.Size(288, 34);
            this.tsmiCompare.Text = "Select web resource";
            this.tsmiCompare.ToolTipText = "Compare the web resource in CRM with a local webresource";
            // 
            // tsmiCompareSettings
            // 
            this.tsmiCompareSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCompareSettings.Image")));
            this.tsmiCompareSettings.Name = "tsmiCompareSettings";
            this.tsmiCompareSettings.Size = new System.Drawing.Size(288, 34);
            this.tsmiCompareSettings.Text = "Settings";
            this.tsmiCompareSettings.ToolTipText = "Select the compare tool to use when comparing webresources";
            // 
            // tsbMinifyJS
            // 
            this.tsbMinifyJS.Image = ((System.Drawing.Image)(resources.GetObject("tsbMinifyJS.Image")));
            this.tsbMinifyJS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMinifyJS.Name = "tsbMinifyJS";
            this.tsbMinifyJS.Size = new System.Drawing.Size(136, 34);
            this.tsbMinifyJS.Text = "Compress";
            this.tsbMinifyJS.ToolTipText = "This feature compress/minify a script web resource. It may obfuscate the code dep" +
    "ending on settings.\r\nBe careful when using this feature! There is no way to beau" +
    "tify minified JavaScript";
            this.tsbMinifyJS.Visible = false;
            this.tsbMinifyJS.Click += new System.EventHandler(this.tsbMinifyJS_Click);
            // 
            // tsbBeautify
            // 
            this.tsbBeautify.Image = ((System.Drawing.Image)(resources.GetObject("tsbBeautify.Image")));
            this.tsbBeautify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBeautify.Name = "tsbBeautify";
            this.tsbBeautify.Size = new System.Drawing.Size(120, 34);
            this.tsbBeautify.Text = "Beautify";
            this.tsbBeautify.ToolTipText = "This feature make uglified JavaScript readable \r\n\r\nThanks to ghost6991 for his wo" +
    "rk on the beautifier in C# : https://github.com/ghost6991/Jsbeautifier";
            this.tsbBeautify.Visible = false;
            this.tsbBeautify.Click += new System.EventHandler(this.tsbBeautify_Click);
            // 
            // tsbGetLatestVersion
            // 
            this.tsbGetLatestVersion.Image = ((System.Drawing.Image)(resources.GetObject("tsbGetLatestVersion.Image")));
            this.tsbGetLatestVersion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGetLatestVersion.Name = "tsbGetLatestVersion";
            this.tsbGetLatestVersion.Size = new System.Drawing.Size(138, 34);
            this.tsbGetLatestVersion.Text = "Get Latest";
            this.tsbGetLatestVersion.Click += new System.EventHandler(this.tsbGetLatestVersion_Click);
            // 
            // tssComments
            // 
            this.tssComments.Name = "tssComments";
            this.tssComments.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbComment
            // 
            this.tsbComment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbComment.Image = ((System.Drawing.Image)(resources.GetObject("tsbComment.Image")));
            this.tsbComment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbComment.Name = "tsbComment";
            this.tsbComment.Size = new System.Drawing.Size(32, 34);
            this.tsbComment.Text = "Comment";
            this.tsbComment.Click += new System.EventHandler(this.tsbComment_Click);
            // 
            // tsbnUncomment
            // 
            this.tsbnUncomment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbnUncomment.Image = ((System.Drawing.Image)(resources.GetObject("tsbnUncomment.Image")));
            this.tsbnUncomment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnUncomment.Name = "tsbnUncomment";
            this.tsbnUncomment.Size = new System.Drawing.Size(32, 34);
            this.tsbnUncomment.Text = "Uncomment";
            this.tsbnUncomment.Click += new System.EventHandler(this.tsbnUncomment_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tslWebresource
            // 
            this.tslWebresource.Name = "tslWebresource";
            this.tslWebresource.Size = new System.Drawing.Size(200, 34);
            this.tslWebresource.Text = "[webresource name]";
            // 
            // BaseContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 293);
            this.Controls.Add(this.toolStrip);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseContentForm";
            this.Text = "BaseContentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseContentForm_FormClosing);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton tsddbFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdatePublish;
        private System.Windows.Forms.ToolStripMenuItem tsmiReplace;
        private System.Windows.Forms.ToolStripSeparator tsSeparatorEdit;
        private System.Windows.Forms.ToolStripDropDownButton tsddbEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditorFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditorReplace;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoToLine;
        private System.Windows.Forms.ToolStripDropDownButton tsddbCompare;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompare;
        private System.Windows.Forms.ToolStripMenuItem tsmiCompareSettings;
        private System.Windows.Forms.ToolStripButton tsbBeautify;
        private System.Windows.Forms.ToolStripButton tsbGetLatestVersion;
        private System.Windows.Forms.ToolStripSeparator tssComments;
        private System.Windows.Forms.ToolStripButton tsbComment;
        private System.Windows.Forms.ToolStripButton tsbnUncomment;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefreshFromDisk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslWebresource;
        private System.Windows.Forms.ToolStripButton tsbMinifyJS;
    }
}