namespace MsCrmTools.WebResourcesManager.New.UserControls
{
    partial class WebresourceTreeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebresourceTreeView));
            this.ilWebResourceTypes = new System.Windows.Forms.ImageList(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.llCollapseAll = new System.Windows.Forms.LinkLabel();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.llExpandAll = new System.Windows.Forms.LinkLabel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlWaitingPublish = new System.Windows.Forms.Panel();
            this.llUpdateResources = new System.Windows.Forms.LinkLabel();
            this.lblWaitingPublish = new System.Windows.Forms.Label();
            this.tv = new System.Windows.Forms.TreeView();
            this.chkSearchInContent = new System.Windows.Forms.CheckBox();
            this.chkDisplayExpanded = new System.Windows.Forms.CheckBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlBottom.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlWaitingPublish.SuspendLayout();
            this.SuspendLayout();
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
            this.ilWebResourceTypes.Images.SetKeyName(12, "component_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(13, "folder_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(14, "html_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(15, "css_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(16, "script_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(17, "database_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(18, "picture_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(19, "picture_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(20, "picture_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(21, "silverlight_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(22, "xsl_notsynced.png");
            this.ilWebResourceTypes.Images.SetKeyName(23, "icon_notsynced.png");
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.llCollapseAll);
            this.pnlBottom.Controls.Add(this.lblSeparator);
            this.pnlBottom.Controls.Add(this.llExpandAll);
            this.pnlBottom.Controls.Add(this.chkSelectAll);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBottom.Location = new System.Drawing.Point(0, 0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(409, 17);
            this.pnlBottom.TabIndex = 85;
            // 
            // llCollapseAll
            // 
            this.llCollapseAll.AutoSize = true;
            this.llCollapseAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.llCollapseAll.Location = new System.Drawing.Point(284, 0);
            this.llCollapseAll.Name = "llCollapseAll";
            this.llCollapseAll.Size = new System.Drawing.Size(60, 13);
            this.llCollapseAll.TabIndex = 87;
            this.llCollapseAll.TabStop = true;
            this.llCollapseAll.Text = "Collapse all";
            this.llCollapseAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCollapseAll_LinkClicked);
            // 
            // lblSeparator
            // 
            this.lblSeparator.AutoSize = true;
            this.lblSeparator.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSeparator.Location = new System.Drawing.Point(344, 0);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(9, 13);
            this.lblSeparator.TabIndex = 86;
            this.lblSeparator.Text = "|";
            // 
            // llExpandAll
            // 
            this.llExpandAll.AutoSize = true;
            this.llExpandAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.llExpandAll.Location = new System.Drawing.Point(353, 0);
            this.llExpandAll.Name = "llExpandAll";
            this.llExpandAll.Size = new System.Drawing.Size(56, 13);
            this.llExpandAll.TabIndex = 85;
            this.llExpandAll.TabStop = true;
            this.llExpandAll.Text = "Expand all";
            this.llExpandAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExpandAll_LinkClicked);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkSelectAll.Location = new System.Drawing.Point(0, 0);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(116, 17);
            this.chkSelectAll.TabIndex = 84;
            this.chkSelectAll.Text = "Select/Unselect all";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.Click += new System.EventHandler(this.chkSelectAll_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.chkDisplayExpanded);
            this.pnlSearch.Controls.Add(this.chkSearchInContent);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSearch.Location = new System.Drawing.Point(0, 648);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(409, 22);
            this.pnlSearch.TabIndex = 85;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Location = new System.Drawing.Point(0, 0);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblSearch.Size = new System.Drawing.Size(41, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // pnlWaitingPublish
            // 
            this.pnlWaitingPublish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlWaitingPublish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWaitingPublish.Controls.Add(this.llUpdateResources);
            this.pnlWaitingPublish.Controls.Add(this.lblWaitingPublish);
            this.pnlWaitingPublish.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWaitingPublish.Location = new System.Drawing.Point(0, 17);
            this.pnlWaitingPublish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlWaitingPublish.Name = "pnlWaitingPublish";
            this.pnlWaitingPublish.Size = new System.Drawing.Size(409, 33);
            this.pnlWaitingPublish.TabIndex = 87;
            this.pnlWaitingPublish.Visible = false;
            // 
            // llUpdateResources
            // 
            this.llUpdateResources.AutoSize = true;
            this.llUpdateResources.Dock = System.Windows.Forms.DockStyle.Right;
            this.llUpdateResources.Location = new System.Drawing.Point(365, 15);
            this.llUpdateResources.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llUpdateResources.Name = "llUpdateResources";
            this.llUpdateResources.Size = new System.Drawing.Size(42, 13);
            this.llUpdateResources.TabIndex = 1;
            this.llUpdateResources.TabStop = true;
            this.llUpdateResources.Text = "Update";
            this.llUpdateResources.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llUpdateResources_LinkClicked);
            // 
            // lblWaitingPublish
            // 
            this.lblWaitingPublish.AutoEllipsis = true;
            this.lblWaitingPublish.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWaitingPublish.Location = new System.Drawing.Point(0, 0);
            this.lblWaitingPublish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaitingPublish.Name = "lblWaitingPublish";
            this.lblWaitingPublish.Size = new System.Drawing.Size(407, 15);
            this.lblWaitingPublish.TabIndex = 0;
            this.lblWaitingPublish.Text = "label";
            // 
            // tv
            // 
            this.tv.AllowDrop = true;
            this.tv.CheckBoxes = true;
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.HideSelection = false;
            this.tv.ImageIndex = 0;
            this.tv.ImageList = this.ilWebResourceTypes;
            this.tv.Location = new System.Drawing.Point(0, 50);
            this.tv.Name = "tv";
            this.tv.SelectedImageIndex = 0;
            this.tv.Size = new System.Drawing.Size(409, 598);
            this.tv.TabIndex = 88;
            this.tv.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterCheck);
            this.tv.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tv_BeforeSelect);
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            this.tv.DragDrop += new System.Windows.Forms.DragEventHandler(this.tv_DragDrop);
            this.tv.DragOver += new System.Windows.Forms.DragEventHandler(this.tv_DragOver);
            this.tv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tv_MouseDown);
            // 
            // chkSearchInContent
            // 
            this.chkSearchInContent.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSearchInContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSearchInContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkSearchInContent.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chkSearchInContent.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.chkSearchInContent.Image = ((System.Drawing.Image)(resources.GetObject("chkSearchInContent.Image")));
            this.chkSearchInContent.Location = new System.Drawing.Point(387, 0);
            this.chkSearchInContent.Name = "chkSearchInContent";
            this.chkSearchInContent.Size = new System.Drawing.Size(22, 22);
            this.chkSearchInContent.TabIndex = 89;
            this.chkSearchInContent.UseVisualStyleBackColor = true;
            this.chkSearchInContent.CheckedChanged += new System.EventHandler(this.chkSearchInContent_CheckedChanged);
            // 
            // chkDisplayExpanded
            // 
            this.chkDisplayExpanded.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDisplayExpanded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDisplayExpanded.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkDisplayExpanded.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chkDisplayExpanded.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.chkDisplayExpanded.Image = ((System.Drawing.Image)(resources.GetObject("chkDisplayExpanded.Image")));
            this.chkDisplayExpanded.Location = new System.Drawing.Point(365, 0);
            this.chkDisplayExpanded.Name = "chkDisplayExpanded";
            this.chkDisplayExpanded.Size = new System.Drawing.Size(22, 22);
            this.chkDisplayExpanded.TabIndex = 91;
            this.chkDisplayExpanded.UseVisualStyleBackColor = true;
            this.chkDisplayExpanded.CheckedChanged += new System.EventHandler(this.chkDisplayExpanded_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(41, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 20);
            this.txtSearch.TabIndex = 92;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // WebresourceTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tv);
            this.Controls.Add(this.pnlWaitingPublish);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlSearch);
            this.Name = "WebresourceTreeView";
            this.Size = new System.Drawing.Size(409, 670);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlWaitingPublish.ResumeLayout(false);
            this.pnlWaitingPublish.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList ilWebResourceTypes;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.LinkLabel llCollapseAll;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.LinkLabel llExpandAll;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Panel pnlWaitingPublish;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.LinkLabel llUpdateResources;
        private System.Windows.Forms.Label lblWaitingPublish;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.CheckBox chkSearchInContent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkDisplayExpanded;
    }
}
