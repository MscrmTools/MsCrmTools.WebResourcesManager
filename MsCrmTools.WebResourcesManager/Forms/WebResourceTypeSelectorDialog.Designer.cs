namespace MsCrmTools.WebResourcesManager.Forms
{
    partial class WebResourceTypeSelectorDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkFilterByLcid = new System.Windows.Forms.CheckBox();
            this.chkLoadResourcesFromMicrosoft = new System.Windows.Forms.CheckBox();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.webResourceTypePicker1 = new MsCrmTools.WebResourcesManager.UserControls.WebResourceTypePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 92);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(27, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(369, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Type of web resources to load";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(610, 50);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(488, 50);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkFilterByLcid);
            this.panel2.Controls.Add(this.chkLoadResourcesFromMicrosoft);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 94);
            this.panel2.TabIndex = 6;
            // 
            // chkFilterByLcid
            // 
            this.chkFilterByLcid.AutoSize = true;
            this.chkFilterByLcid.Location = new System.Drawing.Point(322, 9);
            this.chkFilterByLcid.Name = "chkFilterByLcid";
            this.chkFilterByLcid.Size = new System.Drawing.Size(253, 24);
            this.chkFilterByLcid.TabIndex = 12;
            this.chkFilterByLcid.Text = "Filter by provisionned language";
            this.chkFilterByLcid.UseVisualStyleBackColor = true;
            // 
            // chkLoadResourcesFromMicrosoft
            // 
            this.chkLoadResourcesFromMicrosoft.AutoSize = true;
            this.chkLoadResourcesFromMicrosoft.Checked = true;
            this.chkLoadResourcesFromMicrosoft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLoadResourcesFromMicrosoft.Location = new System.Drawing.Point(14, 9);
            this.chkLoadResourcesFromMicrosoft.Name = "chkLoadResourcesFromMicrosoft";
            this.chkLoadResourcesFromMicrosoft.Size = new System.Drawing.Size(302, 24);
            this.chkLoadResourcesFromMicrosoft.TabIndex = 5;
            this.chkLoadResourcesFromMicrosoft.Text = "Load CRM 2016+ OOB webresources";
            this.chkLoadResourcesFromMicrosoft.UseVisualStyleBackColor = true;
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.LightYellow;
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFilter.Location = new System.Drawing.Point(0, 301);
            this.pnlFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(6);
            this.pnlFilter.Size = new System.Drawing.Size(726, 65);
            this.pnlFilter.TabIndex = 8;
            // 
            // lblFilter
            // 
            this.lblFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilter.Location = new System.Drawing.Point(6, 6);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(714, 53);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Webresources with name starting with {0} won\'t be loaded. See Settings to change " +
    "this behavior";
            // 
            // webResourceTypePicker1
            // 
            this.webResourceTypePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webResourceTypePicker1.Location = new System.Drawing.Point(0, 92);
            this.webResourceTypePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.webResourceTypePicker1.Name = "webResourceTypePicker1";
            this.webResourceTypePicker1.ShowV9Types = false;
            this.webResourceTypePicker1.Size = new System.Drawing.Size(726, 209);
            this.webResourceTypePicker1.TabIndex = 9;
            // 
            // WebResourceTypeSelectorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(726, 460);
            this.Controls.Add(this.webResourceTypePicker1);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WebResourceTypeSelectorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Web resources types";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkLoadResourcesFromMicrosoft;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblFilter;
        private UserControls.WebResourceTypePicker webResourceTypePicker1;
        private System.Windows.Forms.CheckBox chkFilterByLcid;
    }
}