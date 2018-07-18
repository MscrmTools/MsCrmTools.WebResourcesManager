
namespace MscrmTools.WebresourcesManager.Forms
{
    partial class WebresourcesTreeView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebresourcesTreeView));
            this.tsTvMain = new System.Windows.Forms.ToolStrip();
            this.tsbNewRoot = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCheckAll = new System.Windows.Forms.ToolStripButton();
            this.tsbClearAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbExpandAll = new System.Windows.Forms.ToolStripButton();
            this.tsbCollapseAll = new System.Windows.Forms.ToolStripButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.llSynchronize = new System.Windows.Forms.LinkLabel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkDisplayExpanded = new System.Windows.Forms.CheckBox();
            this.chkSearchInContent = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tv = new System.Windows.Forms.TreeView();
            this.ilWebResourceTypes = new System.Windows.Forms.ImageList(this.components);
            this.pnlSolution = new System.Windows.Forms.Panel();
            this.lblSolution = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWaitingUpdate = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.llDismissPendingUpdates = new System.Windows.Forms.LinkLabel();
            this.tsTvMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlSolution.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsTvMain
            // 
            this.tsTvMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTvMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewRoot,
            this.toolStripSeparator1,
            this.tsbCheckAll,
            this.tsbClearAll,
            this.toolStripSeparator2,
            this.tsbExpandAll,
            this.tsbCollapseAll});
            this.tsTvMain.Location = new System.Drawing.Point(0, 0);
            this.tsTvMain.Name = "tsTvMain";
            this.tsTvMain.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsTvMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTvMain.Size = new System.Drawing.Size(584, 37);
            this.tsTvMain.TabIndex = 8;
            // 
            // tsbNewRoot
            // 
            this.tsbNewRoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewRoot.Image = global::MscrmTools.WebresourcesManager.Properties.Resources.component;
            this.tsbNewRoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewRoot.Name = "tsbNewRoot";
            this.tsbNewRoot.Size = new System.Drawing.Size(32, 34);
            this.tsbNewRoot.Text = "Add a new root";
            this.tsbNewRoot.Click += new System.EventHandler(this.tsbNewRoot_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbCheckAll
            // 
            this.tsbCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCheckAll.Image = global::MscrmTools.WebresourcesManager.Properties.Resources.check_box;
            this.tsbCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCheckAll.Name = "tsbCheckAll";
            this.tsbCheckAll.Size = new System.Drawing.Size(32, 34);
            this.tsbCheckAll.Text = "Check all";
            this.tsbCheckAll.ToolTipText = "Check all webresources";
            this.tsbCheckAll.Click += new System.EventHandler(this.tsbCheckAll_Click);
            // 
            // tsbClearAll
            // 
            this.tsbClearAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClearAll.Image = global::MscrmTools.WebresourcesManager.Properties.Resources.check_box_uncheck;
            this.tsbClearAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClearAll.Name = "tsbClearAll";
            this.tsbClearAll.Size = new System.Drawing.Size(32, 34);
            this.tsbClearAll.Text = "Clear all";
            this.tsbClearAll.ToolTipText = "Uncheck all webresources";
            this.tsbClearAll.Click += new System.EventHandler(this.tsbClearAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbExpandAll
            // 
            this.tsbExpandAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExpandAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbExpandAll.Image")));
            this.tsbExpandAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExpandAll.Name = "tsbExpandAll";
            this.tsbExpandAll.Size = new System.Drawing.Size(112, 34);
            this.tsbExpandAll.Text = "Expand all";
            this.tsbExpandAll.Click += new System.EventHandler(this.tsbExpandAll_Click);
            // 
            // tsbCollapseAll
            // 
            this.tsbCollapseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCollapseAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbCollapseAll.Image")));
            this.tsbCollapseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCollapseAll.Name = "tsbCollapseAll";
            this.tsbCollapseAll.Size = new System.Drawing.Size(122, 34);
            this.tsbCollapseAll.Text = "Collapse all";
            this.tsbCollapseAll.Click += new System.EventHandler(this.tsbCollapseAll_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Info;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblWaitingUpdate);
            this.pnlTop.Controls.Add(this.panel1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 74);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(584, 80);
            this.pnlTop.TabIndex = 9;
            this.pnlTop.Visible = false;
            // 
            // llSynchronize
            // 
            this.llSynchronize.AutoSize = true;
            this.llSynchronize.Dock = System.Windows.Forms.DockStyle.Right;
            this.llSynchronize.Location = new System.Drawing.Point(370, 0);
            this.llSynchronize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.llSynchronize.Name = "llSynchronize";
            this.llSynchronize.Size = new System.Drawing.Size(212, 25);
            this.llSynchronize.TabIndex = 1;
            this.llSynchronize.TabStop = true;
            this.llSynchronize.Text = "Show pending updates";
            this.llSynchronize.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.llSynchronize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSynchronize_LinkClicked);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 1162);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(584, 92);
            this.pnlBottom.TabIndex = 10;
            this.pnlBottom.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.chkDisplayExpanded);
            this.pnlSearch.Controls.Add(this.chkSearchInContent);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(0, 1121);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(584, 41);
            this.pnlSearch.TabIndex = 86;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(75, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(429, 29);
            this.txtSearch.TabIndex = 92;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // chkDisplayExpanded
            // 
            this.chkDisplayExpanded.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDisplayExpanded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDisplayExpanded.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkDisplayExpanded.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chkDisplayExpanded.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.chkDisplayExpanded.Image = ((System.Drawing.Image)(resources.GetObject("chkDisplayExpanded.Image")));
            this.chkDisplayExpanded.Location = new System.Drawing.Point(504, 0);
            this.chkDisplayExpanded.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkDisplayExpanded.Name = "chkDisplayExpanded";
            this.chkDisplayExpanded.Size = new System.Drawing.Size(40, 41);
            this.chkDisplayExpanded.TabIndex = 91;
            this.chkDisplayExpanded.UseVisualStyleBackColor = true;
            this.chkDisplayExpanded.CheckedChanged += new System.EventHandler(this.chkDisplayExpanded_CheckedChanged);
            // 
            // chkSearchInContent
            // 
            this.chkSearchInContent.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSearchInContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSearchInContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkSearchInContent.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chkSearchInContent.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.chkSearchInContent.Image = ((System.Drawing.Image)(resources.GetObject("chkSearchInContent.Image")));
            this.chkSearchInContent.Location = new System.Drawing.Point(544, 0);
            this.chkSearchInContent.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.chkSearchInContent.Name = "chkSearchInContent";
            this.chkSearchInContent.Size = new System.Drawing.Size(40, 41);
            this.chkSearchInContent.TabIndex = 89;
            this.chkSearchInContent.UseVisualStyleBackColor = true;
            this.chkSearchInContent.CheckedChanged += new System.EventHandler(this.chkSearchInContent_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 7, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lblSearch.Size = new System.Drawing.Size(75, 32);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // tv
            // 
            this.tv.AllowDrop = true;
            this.tv.CheckBoxes = true;
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.HideSelection = false;
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.ilWebResourceTypes;
            this.tv.Location = new System.Drawing.Point(0, 154);
            this.tv.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.Size = new System.Drawing.Size(584, 967);
            this.tv.TabIndex = 87;
            this.tv.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterCheck);
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            this.tv.DragDrop += new System.Windows.Forms.DragEventHandler(this.tv_DragDrop);
            this.tv.DragOver += new System.Windows.Forms.DragEventHandler(this.tv_DragOver);
            // 
            // ilWebResourceTypes
            // 
            this.ilWebResourceTypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilWebResourceTypes.ImageStream")));
            this.ilWebResourceTypes.TransparentColor = System.Drawing.Color.Transparent;
            this.ilWebResourceTypes.Images.SetKeyName(0, "component.png");
            this.ilWebResourceTypes.Images.SetKeyName(1, "folder.png");
            this.ilWebResourceTypes.Images.SetKeyName(2, "html.png");
            this.ilWebResourceTypes.Images.SetKeyName(3, "css.png");
            this.ilWebResourceTypes.Images.SetKeyName(4, "script.png");
            this.ilWebResourceTypes.Images.SetKeyName(5, "database.png");
            this.ilWebResourceTypes.Images.SetKeyName(6, "picture.png");
            this.ilWebResourceTypes.Images.SetKeyName(7, "picture.png");
            this.ilWebResourceTypes.Images.SetKeyName(8, "picture.png");
            this.ilWebResourceTypes.Images.SetKeyName(9, "silverlight.jpg");
            this.ilWebResourceTypes.Images.SetKeyName(10, "xsl.png");
            this.ilWebResourceTypes.Images.SetKeyName(11, "updateicons_16.png");
            this.ilWebResourceTypes.Images.SetKeyName(12, "svg.png");
            this.ilWebResourceTypes.Images.SetKeyName(13, "resx.png");
            this.ilWebResourceTypes.Images.SetKeyName(14, "component_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(15, "folder_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(16, "html_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(17, "css_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(18, "script_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(19, "database_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(20, "picture_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(21, "picture_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(22, "picture_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(23, "silverlight_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(24, "xsl_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(25, "icon_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(26, "resx.png");
            this.ilWebResourceTypes.Images.SetKeyName(27, "svg.png");
            // 
            // pnlSolution
            // 
            this.pnlSolution.BackColor = System.Drawing.SystemColors.Control;
            this.pnlSolution.Controls.Add(this.lblSolution);
            this.pnlSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolution.Location = new System.Drawing.Point(0, 37);
            this.pnlSolution.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlSolution.Name = "pnlSolution";
            this.pnlSolution.Size = new System.Drawing.Size(584, 37);
            this.pnlSolution.TabIndex = 88;
            this.pnlSolution.Visible = false;
            // 
            // lblSolution
            // 
            this.lblSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSolution.Location = new System.Drawing.Point(0, 0);
            this.lblSolution.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(584, 37);
            this.lblSolution.TabIndex = 0;
            this.lblSolution.Text = "[solution loaded]";
            this.lblSolution.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llDismissPendingUpdates);
            this.panel1.Controls.Add(this.lblSplit);
            this.panel1.Controls.Add(this.llSynchronize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 24);
            this.panel1.TabIndex = 3;
            // 
            // lblWaitingUpdate
            // 
            this.lblWaitingUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWaitingUpdate.Location = new System.Drawing.Point(0, 0);
            this.lblWaitingUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWaitingUpdate.Name = "lblWaitingUpdate";
            this.lblWaitingUpdate.Size = new System.Drawing.Size(582, 54);
            this.lblWaitingUpdate.TabIndex = 4;
            this.lblWaitingUpdate.Tag = "{0} resource{1} need{2} to be updated and published on the organization";
            this.lblWaitingUpdate.Text = "[lblWaitingUpdate]";
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSplit.Location = new System.Drawing.Point(353, 0);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(17, 25);
            this.lblSplit.TabIndex = 2;
            this.lblSplit.Text = "|";
            // 
            // llDismissPendingUpdates
            // 
            this.llDismissPendingUpdates.AutoSize = true;
            this.llDismissPendingUpdates.Dock = System.Windows.Forms.DockStyle.Right;
            this.llDismissPendingUpdates.Location = new System.Drawing.Point(123, 0);
            this.llDismissPendingUpdates.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.llDismissPendingUpdates.Name = "llDismissPendingUpdates";
            this.llDismissPendingUpdates.Size = new System.Drawing.Size(230, 25);
            this.llDismissPendingUpdates.TabIndex = 3;
            this.llDismissPendingUpdates.TabStop = true;
            this.llDismissPendingUpdates.Text = "Dismiss pending updates";
            this.llDismissPendingUpdates.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.llDismissPendingUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDismissPendingUpdates_LinkClicked);
            // 
            // WebresourcesTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 1254);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.tv);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlSolution);
            this.Controls.Add(this.tsTvMain);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "WebresourcesTreeView";
            this.Text = "Webresources Explorer";
            this.Load += new System.EventHandler(this.WebresourcesTreeView_Load);
            this.Enter += new System.EventHandler(this.WebresourcesTreeView_Enter);
            this.tsTvMain.ResumeLayout(false);
            this.tsTvMain.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlSolution.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTvMain;
        private System.Windows.Forms.ToolStripButton tsbNewRoot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCheckAll;
        private System.Windows.Forms.ToolStripButton tsbClearAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbExpandAll;
        private System.Windows.Forms.ToolStripButton tsbCollapseAll;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkDisplayExpanded;
        private System.Windows.Forms.CheckBox chkSearchInContent;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ImageList ilWebResourceTypes;
        private System.Windows.Forms.LinkLabel llSynchronize;
        private System.Windows.Forms.Panel pnlSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Label lblWaitingUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel llDismissPendingUpdates;
        private System.Windows.Forms.Label lblSplit;
    }
}