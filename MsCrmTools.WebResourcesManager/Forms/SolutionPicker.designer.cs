namespace MscrmTools.WebresourcesManager.Forms
{
    partial class SolutionPicker
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
            this.btnSolutionPickerCancel = new System.Windows.Forms.Button();
            this.btnSolutionPickerValidate = new System.Windows.Forms.Button();
            this.chkLoadAllWebResources = new System.Windows.Forms.CheckBox();
            this.chkFilterByLcid = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbSolutionNameFilter = new System.Windows.Forms.TextBox();
            this.lblHeaderDesc = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lstSolutions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSolutionPickerCancel
            // 
            this.btnSolutionPickerCancel.Location = new System.Drawing.Point(824, 13);
            this.btnSolutionPickerCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSolutionPickerCancel.Name = "btnSolutionPickerCancel";
            this.btnSolutionPickerCancel.Size = new System.Drawing.Size(150, 44);
            this.btnSolutionPickerCancel.TabIndex = 4;
            this.btnSolutionPickerCancel.Text = "Cancel";
            this.btnSolutionPickerCancel.UseVisualStyleBackColor = true;
            this.btnSolutionPickerCancel.Click += new System.EventHandler(this.btnSolutionPickerCancel_Click);
            // 
            // btnSolutionPickerValidate
            // 
            this.btnSolutionPickerValidate.Enabled = false;
            this.btnSolutionPickerValidate.Location = new System.Drawing.Point(660, 13);
            this.btnSolutionPickerValidate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSolutionPickerValidate.Name = "btnSolutionPickerValidate";
            this.btnSolutionPickerValidate.Size = new System.Drawing.Size(150, 44);
            this.btnSolutionPickerValidate.TabIndex = 3;
            this.btnSolutionPickerValidate.Text = "OK";
            this.btnSolutionPickerValidate.UseVisualStyleBackColor = true;
            this.btnSolutionPickerValidate.Click += new System.EventHandler(this.btnSolutionPickerValidate_Click);
            // 
            // chkLoadAllWebResources
            // 
            this.chkLoadAllWebResources.AutoSize = true;
            this.chkLoadAllWebResources.Checked = true;
            this.chkLoadAllWebResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoadAllWebResources.Location = new System.Drawing.Point(14, 4);
            this.chkLoadAllWebResources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLoadAllWebResources.Name = "chkLoadAllWebResources";
            this.chkLoadAllWebResources.Size = new System.Drawing.Size(482, 29);
            this.chkLoadAllWebResources.TabIndex = 2;
            this.chkLoadAllWebResources.Text = "Load all web resources from selected solution";
            this.chkLoadAllWebResources.UseVisualStyleBackColor = true;
            this.chkLoadAllWebResources.CheckedChanged += new System.EventHandler(this.chkLoadAllWebResources_CheckedChanged);
            // 
            // chkFilterByLcid
            // 
            this.chkFilterByLcid.AutoSize = true;
            this.chkFilterByLcid.Location = new System.Drawing.Point(494, 4);
            this.chkFilterByLcid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFilterByLcid.Name = "chkFilterByLcid";
            this.chkFilterByLcid.Size = new System.Drawing.Size(333, 29);
            this.chkFilterByLcid.TabIndex = 11;
            this.chkFilterByLcid.Text = "Filter by provisioned language";
            this.chkFilterByLcid.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSolutionPickerCancel);
            this.panel2.Controls.Add(this.btnSolutionPickerValidate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 596);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 75);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkFilterByLcid);
            this.panel3.Controls.Add(this.chkLoadAllWebResources);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 559);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 37);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txbSolutionNameFilter);
            this.panel1.Controls.Add(this.lblHeaderDesc);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 173);
            this.panel1.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(809, 95);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSolutionNameFilter
            // 
            this.txbSolutionNameFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSolutionNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txbSolutionNameFilter.Location = new System.Drawing.Point(14, 102);
            this.txbSolutionNameFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSolutionNameFilter.Name = "txbSolutionNameFilter";
            this.txbSolutionNameFilter.Size = new System.Drawing.Size(783, 32);
            this.txbSolutionNameFilter.TabIndex = 13;
            this.txbSolutionNameFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSolutionNameFilter_KeyPress);
            // 
            // lblHeaderDesc
            // 
            this.lblHeaderDesc.AutoSize = true;
            this.lblHeaderDesc.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lblHeaderDesc.Location = new System.Drawing.Point(18, 60);
            this.lblHeaderDesc.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeaderDesc.Name = "lblHeaderDesc";
            this.lblHeaderDesc.Size = new System.Drawing.Size(607, 37);
            this.lblHeaderDesc.TabIndex = 12;
            this.lblHeaderDesc.Text = "Web resources will be added to the selected solution";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lblHeader.Location = new System.Drawing.Point(6, 12);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(278, 51);
            this.lblHeader.TabIndex = 11;
            this.lblHeader.Text = "Select a solution";
            // 
            // lstSolutions
            // 
            this.lstSolutions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstSolutions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSolutions.Enabled = false;
            this.lstSolutions.FullRowSelect = true;
            this.lstSolutions.GridLines = true;
            this.lstSolutions.HideSelection = false;
            this.lstSolutions.Location = new System.Drawing.Point(0, 173);
            this.lstSolutions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstSolutions.MultiSelect = false;
            this.lstSolutions.Name = "lstSolutions";
            this.lstSolutions.Size = new System.Drawing.Size(974, 386);
            this.lstSolutions.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstSolutions.TabIndex = 16;
            this.lstSolutions.UseCompatibleStateImageBehavior = false;
            this.lstSolutions.View = System.Windows.Forms.View.Details;
            this.lstSolutions.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstSolutions_ColumnClick);
            this.lstSolutions.DoubleClick += new System.EventHandler(this.lstSolutions_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Display Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Version";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Publisher";
            this.columnHeader3.Width = 200;
            // 
            // SolutionPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 671);
            this.ControlBox = false;
            this.Controls.Add(this.lstSolutions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SolutionPicker";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.SolutionPicker_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSolutionPickerCancel;
        private System.Windows.Forms.Button btnSolutionPickerValidate;
        private System.Windows.Forms.CheckBox chkLoadAllWebResources;
        private System.Windows.Forms.CheckBox chkFilterByLcid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeaderDesc;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ListView lstSolutions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox txbSolutionNameFilter;
        private System.Windows.Forms.Button btnSearch;
    }
}