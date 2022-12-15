
namespace MscrmTools.WebresourcesManager.Forms
{
    partial class UpdateEntityImageDialog
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lvTables = new System.Windows.Forms.ListView();
            this.chTableDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTableLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlValidation = new System.Windows.Forms.Panel();
            this.pnlSubValidation = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.llCloseValidation = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlValidation.SuspendLayout();
            this.pnlSubValidation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(709, 74);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add icon to table";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnApply);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 559);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(709, 60);
            this.pnlBottom.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(317, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(187, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(510, 14);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(187, 34);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlValidation);
            this.pnlMain.Controls.Add(this.lvTables);
            this.pnlMain.Controls.Add(this.lblProgress);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 74);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMain.Size = new System.Drawing.Size(709, 485);
            this.pnlMain.TabIndex = 4;
            // 
            // lblProgress
            // 
            this.lblProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProgress.Location = new System.Drawing.Point(10, 418);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(689, 57);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvTables
            // 
            this.lvTables.CheckBoxes = true;
            this.lvTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTableDisplayName,
            this.chTableLogicalName});
            this.lvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTables.FullRowSelect = true;
            this.lvTables.HideSelection = false;
            this.lvTables.Location = new System.Drawing.Point(10, 10);
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(689, 408);
            this.lvTables.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTables.TabIndex = 4;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.View = System.Windows.Forms.View.Details;
            this.lvTables.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTables_ColumnClick);
            // 
            // chTableDisplayName
            // 
            this.chTableDisplayName.Text = "Table";
            this.chTableDisplayName.Width = 300;
            // 
            // chTableLogicalName
            // 
            this.chTableLogicalName.Text = "Logical name";
            this.chTableLogicalName.Width = 200;
            // 
            // pnlValidation
            // 
            this.pnlValidation.BackColor = System.Drawing.Color.Green;
            this.pnlValidation.Controls.Add(this.pnlSubValidation);
            this.pnlValidation.Location = new System.Drawing.Point(112, 146);
            this.pnlValidation.Name = "pnlValidation";
            this.pnlValidation.Padding = new System.Windows.Forms.Padding(1);
            this.pnlValidation.Size = new System.Drawing.Size(441, 100);
            this.pnlValidation.TabIndex = 5;
            this.pnlValidation.Visible = false;
            // 
            // pnlSubValidation
            // 
            this.pnlSubValidation.BackColor = System.Drawing.Color.LightGreen;
            this.pnlSubValidation.Controls.Add(this.llCloseValidation);
            this.pnlSubValidation.Controls.Add(this.lblValidation);
            this.pnlSubValidation.Controls.Add(this.pictureBox1);
            this.pnlSubValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubValidation.Location = new System.Drawing.Point(1, 1);
            this.pnlSubValidation.Name = "pnlSubValidation";
            this.pnlSubValidation.Size = new System.Drawing.Size(439, 98);
            this.pnlSubValidation.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MscrmTools.WebresourcesManager.Properties.Resources.check__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblValidation
            // 
            this.lblValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblValidation.ForeColor = System.Drawing.Color.Green;
            this.lblValidation.Location = new System.Drawing.Point(97, 0);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(342, 98);
            this.lblValidation.TabIndex = 1;
            this.lblValidation.Text = "Icon added to table(s) successfully!";
            this.lblValidation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llCloseValidation
            // 
            this.llCloseValidation.ActiveLinkColor = System.Drawing.Color.Green;
            this.llCloseValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llCloseValidation.AutoSize = true;
            this.llCloseValidation.DisabledLinkColor = System.Drawing.Color.Green;
            this.llCloseValidation.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llCloseValidation.LinkColor = System.Drawing.Color.Green;
            this.llCloseValidation.Location = new System.Drawing.Point(416, 4);
            this.llCloseValidation.Name = "llCloseValidation";
            this.llCloseValidation.Size = new System.Drawing.Size(20, 20);
            this.llCloseValidation.TabIndex = 2;
            this.llCloseValidation.TabStop = true;
            this.llCloseValidation.Text = "X";
            this.llCloseValidation.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llCloseValidation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCloseValidation_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(124, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(187, 34);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UpdateEntityImageDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 619);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateEntityImageDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.UpdateEntityImageDialog_Load);
            this.Resize += new System.EventHandler(this.UpdateEntityImageDialog_Resize);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlValidation.ResumeLayout(false);
            this.pnlSubValidation.ResumeLayout(false);
            this.pnlSubValidation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ColumnHeader chTableDisplayName;
        private System.Windows.Forms.ColumnHeader chTableLogicalName;
        private System.Windows.Forms.Panel pnlValidation;
        private System.Windows.Forms.Panel pnlSubValidation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.LinkLabel llCloseValidation;
        private System.Windows.Forms.Button btnCancel;
    }
}