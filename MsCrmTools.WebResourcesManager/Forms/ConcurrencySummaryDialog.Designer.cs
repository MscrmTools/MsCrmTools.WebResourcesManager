namespace MscrmTools.WebresourcesManager.Forms
{
    partial class ConcurrencySummaryDialog
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
            this.lbleHeaderDesc = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnForceUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbConcurrency = new System.Windows.Forms.GroupBox();
            this.lvConcurrency = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbErrors = new System.Windows.Forms.GroupBox();
            this.lvErrors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbConcurrency.SuspendLayout();
            this.gbErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lbleHeaderDesc);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(961, 120);
            this.pnlTop.TabIndex = 0;
            // 
            // lbleHeaderDesc
            // 
            this.lbleHeaderDesc.AutoSize = true;
            this.lbleHeaderDesc.Location = new System.Drawing.Point(20, 61);
            this.lbleHeaderDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbleHeaderDesc.Name = "lbleHeaderDesc";
            this.lbleHeaderDesc.Size = new System.Drawing.Size(541, 25);
            this.lbleHeaderDesc.TabIndex = 1;
            this.lbleHeaderDesc.Text = "Some webresources were not updated for the reasons below.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblTitle.Location = new System.Drawing.Point(17, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Something goes wrong...";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblDesc);
            this.pnlBottom.Controls.Add(this.btnForceUpdate);
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 552);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(961, 151);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(17, 9);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(924, 78);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Whereas we found some webresources that have a newer version on the connected org" +
    "anization, you can decide to overwrite them by checking them and clicking on but" +
    "ton \"Overwrite webresource(s)\"";
            // 
            // btnForceUpdate
            // 
            this.btnForceUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForceUpdate.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnForceUpdate.Location = new System.Drawing.Point(552, 92);
            this.btnForceUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnForceUpdate.Name = "btnForceUpdate";
            this.btnForceUpdate.Size = new System.Drawing.Size(246, 42);
            this.btnForceUpdate.TabIndex = 4;
            this.btnForceUpdate.Text = "Overwrite resource(s)";
            this.btnForceUpdate.UseVisualStyleBackColor = true;
            this.btnForceUpdate.Click += new System.EventHandler(this.btnForceUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(807, 92);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(138, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 120);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbConcurrency);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbErrors);
            this.splitContainer1.Size = new System.Drawing.Size(961, 432);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // gbConcurrency
            // 
            this.gbConcurrency.Controls.Add(this.lvConcurrency);
            this.gbConcurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConcurrency.Location = new System.Drawing.Point(0, 0);
            this.gbConcurrency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConcurrency.Name = "gbConcurrency";
            this.gbConcurrency.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConcurrency.Size = new System.Drawing.Size(493, 432);
            this.gbConcurrency.TabIndex = 0;
            this.gbConcurrency.TabStop = false;
            this.gbConcurrency.Text = "Resources newer in target organization";
            // 
            // lvConcurrency
            // 
            this.lvConcurrency.CheckBoxes = true;
            this.lvConcurrency.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvConcurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConcurrency.Location = new System.Drawing.Point(4, 26);
            this.lvConcurrency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvConcurrency.Name = "lvConcurrency";
            this.lvConcurrency.Size = new System.Drawing.Size(485, 402);
            this.lvConcurrency.TabIndex = 0;
            this.lvConcurrency.UseCompatibleStateImageBehavior = false;
            this.lvConcurrency.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 350;
            // 
            // gbErrors
            // 
            this.gbErrors.Controls.Add(this.lvErrors);
            this.gbErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbErrors.Location = new System.Drawing.Point(0, 0);
            this.gbErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbErrors.Name = "gbErrors";
            this.gbErrors.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbErrors.Size = new System.Drawing.Size(462, 432);
            this.gbErrors.TabIndex = 0;
            this.gbErrors.TabStop = false;
            this.gbErrors.Text = "Resources not updated due to an error";
            // 
            // lvErrors
            // 
            this.lvErrors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvErrors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvErrors.Location = new System.Drawing.Point(4, 26);
            this.lvErrors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvErrors.Name = "lvErrors";
            this.lvErrors.Size = new System.Drawing.Size(454, 402);
            this.lvErrors.TabIndex = 1;
            this.lvErrors.UseCompatibleStateImageBehavior = false;
            this.lvErrors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Error";
            this.columnHeader2.Width = 140;
            // 
            // ConcurrencySummaryDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 703);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(970, 721);
            this.Name = "ConcurrencySummaryDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Webresource(s) update result";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbConcurrency.ResumeLayout(false);
            this.gbErrors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbleHeaderDesc;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbConcurrency;
        private System.Windows.Forms.ListView lvConcurrency;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.GroupBox gbErrors;
        private System.Windows.Forms.ListView lvErrors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnForceUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}