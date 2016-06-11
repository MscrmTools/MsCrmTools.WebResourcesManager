namespace MsCrmTools.WebResourcesManager.Forms
{
    partial class OptionsDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPushMapAndTsFiles = new System.Windows.Forms.CheckBox();
            this.chkSaveOnDisk = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublishEvent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateEvent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAutoSaveEnabled = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 92);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Resources Manager Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1004, 572);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Location = new System.Drawing.Point(882, 572);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(112, 35);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "OK";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkPushMapAndTsFiles);
            this.groupBox1.Controls.Add(this.chkSaveOnDisk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(0, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1134, 142);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options when loaded from / saved to disk";
            // 
            // chkPushMapAndTsFiles
            // 
            this.chkPushMapAndTsFiles.AutoSize = true;
            this.chkPushMapAndTsFiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPushMapAndTsFiles.Location = new System.Drawing.Point(9, 97);
            this.chkPushMapAndTsFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPushMapAndTsFiles.Name = "chkPushMapAndTsFiles";
            this.chkPushMapAndTsFiles.Size = new System.Drawing.Size(398, 24);
            this.chkPushMapAndTsFiles.TabIndex = 13;
            this.chkPushMapAndTsFiles.Text = "Push \".js.map\" and \".ts\" files when pushing \".js\" files";
            this.chkPushMapAndTsFiles.UseVisualStyleBackColor = true;
            // 
            // chkSaveOnDisk
            // 
            this.chkSaveOnDisk.AutoSize = true;
            this.chkSaveOnDisk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSaveOnDisk.Location = new System.Drawing.Point(9, 62);
            this.chkSaveOnDisk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSaveOnDisk.Name = "chkSaveOnDisk";
            this.chkSaveOnDisk.Size = new System.Drawing.Size(568, 24);
            this.chkSaveOnDisk.TabIndex = 12;
            this.chkSaveOnDisk.Text = "Save file content to disk when saving web resource content in the text editor";
            this.chkSaveOnDisk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1126, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "These option applies only for web resources that have been loaded from disk or lo" +
    "aded from CRM organization and saved to disk";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPublishEvent);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUpdateEvent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 363);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1134, 192);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update and Publish events";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1090, 65);
            this.label4.TabIndex = 4;
            this.label4.Text = "Events are executed after having saved of published a web resource on the Dynamic" +
    "s CRM organization. You can use the keywork {FilePath} that reflects the locatio" +
    "n of the web resource on your computer";
            // 
            // txtPublishEvent
            // 
            this.txtPublishEvent.Location = new System.Drawing.Point(138, 78);
            this.txtPublishEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPublishEvent.Name = "txtPublishEvent";
            this.txtPublishEvent.Size = new System.Drawing.Size(976, 26);
            this.txtPublishEvent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publish event";
            // 
            // txtUpdateEvent
            // 
            this.txtUpdateEvent.Location = new System.Drawing.Point(138, 38);
            this.txtUpdateEvent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUpdateEvent.Name = "txtUpdateEvent";
            this.txtUpdateEvent.Size = new System.Drawing.Size(976, 26);
            this.txtUpdateEvent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Update event";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkAutoSaveEnabled);
            this.groupBox3.Location = new System.Drawing.Point(0, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1134, 100);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto-save ";
            // 
            // chkAutoSaveEnabled
            // 
            this.chkAutoSaveEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoSaveEnabled.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAutoSaveEnabled.Location = new System.Drawing.Point(13, 27);
            this.chkAutoSaveEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoSaveEnabled.Name = "chkAutoSaveEnabled";
            this.chkAutoSaveEnabled.Size = new System.Drawing.Size(1108, 49);
            this.chkAutoSaveEnabled.TabIndex = 14;
            this.chkAutoSaveEnabled.Text = "Save automatically local content when selecting a webresource and the displayed o" +
    "ne has not been saved (this does not update webresource to CRM organization)";
            this.chkAutoSaveEnabled.UseVisualStyleBackColor = true;
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1134, 621);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.OptionsDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.CheckBox chkSaveOnDisk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublishEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPushMapAndTsFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAutoSaveEnabled;
    }
}