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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tDisplay = new System.Windows.Forms.TabPage();
            this.chkExandAllNodes = new System.Windows.Forms.CheckBox();
            this.tpFiles = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAutoSaveEnabled = new System.Windows.Forms.CheckBox();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkStyleRemoveComments = new System.Windows.Forms.CheckBox();
            this.chkObfuscateJavaScript = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAddMissingFileExtensions = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tDisplay.SuspendLayout();
            this.tpFiles.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 60);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Resources Manager Settings";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(679, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.Location = new System.Drawing.Point(597, 6);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "OK";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPushMapAndTsFiles);
            this.groupBox1.Controls.Add(this.chkSaveOnDisk);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options when loaded from / saved to disk";
            // 
            // chkPushMapAndTsFiles
            // 
            this.chkPushMapAndTsFiles.AutoSize = true;
            this.chkPushMapAndTsFiles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkPushMapAndTsFiles.Location = new System.Drawing.Point(6, 63);
            this.chkPushMapAndTsFiles.Name = "chkPushMapAndTsFiles";
            this.chkPushMapAndTsFiles.Size = new System.Drawing.Size(275, 17);
            this.chkPushMapAndTsFiles.TabIndex = 13;
            this.chkPushMapAndTsFiles.Text = "Push \".js.map\" and \".ts\" files when pushing \".js\" files";
            this.chkPushMapAndTsFiles.UseVisualStyleBackColor = true;
            // 
            // chkSaveOnDisk
            // 
            this.chkSaveOnDisk.AutoSize = true;
            this.chkSaveOnDisk.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSaveOnDisk.Location = new System.Drawing.Point(6, 40);
            this.chkSaveOnDisk.Name = "chkSaveOnDisk";
            this.chkSaveOnDisk.Size = new System.Drawing.Size(387, 17);
            this.chkSaveOnDisk.TabIndex = 12;
            this.chkSaveOnDisk.Text = "Save file content to disk when saving web resource content in the text editor";
            this.chkSaveOnDisk.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(738, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "These option applies only for web resources that have been loaded from disk or lo" +
    "aded from CRM organization and saved to disk";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPublishEvent);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUpdateEvent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 125);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update and Publish events";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(714, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "Events are executed after having saved of published a web resource on the Dynamic" +
    "s CRM organization. You can use the keywork {FilePath} that reflects the locatio" +
    "n of the web resource on your computer";
            // 
            // txtPublishEvent
            // 
            this.txtPublishEvent.Location = new System.Drawing.Point(92, 51);
            this.txtPublishEvent.Name = "txtPublishEvent";
            this.txtPublishEvent.Size = new System.Drawing.Size(652, 20);
            this.txtPublishEvent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publish event";
            // 
            // txtUpdateEvent
            // 
            this.txtUpdateEvent.Location = new System.Drawing.Point(92, 25);
            this.txtUpdateEvent.Name = "txtUpdateEvent";
            this.txtUpdateEvent.Size = new System.Drawing.Size(652, 20);
            this.txtUpdateEvent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Update event";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnValidate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 40);
            this.panel2.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tDisplay);
            this.tabControl1.Controls.Add(this.tpFiles);
            this.tabControl1.Controls.Add(this.tpEvents);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 304);
            this.tabControl1.TabIndex = 16;
            // 
            // tDisplay
            // 
            this.tDisplay.Controls.Add(this.chkExandAllNodes);
            this.tDisplay.Location = new System.Drawing.Point(4, 22);
            this.tDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.tDisplay.Name = "tDisplay";
            this.tDisplay.Padding = new System.Windows.Forms.Padding(2);
            this.tDisplay.Size = new System.Drawing.Size(748, 278);
            this.tDisplay.TabIndex = 2;
            this.tDisplay.Text = "Display";
            this.tDisplay.UseVisualStyleBackColor = true;
            // 
            // chkExandAllNodes
            // 
            this.chkExandAllNodes.AutoSize = true;
            this.chkExandAllNodes.Location = new System.Drawing.Point(5, 5);
            this.chkExandAllNodes.Margin = new System.Windows.Forms.Padding(2);
            this.chkExandAllNodes.Name = "chkExandAllNodes";
            this.chkExandAllNodes.Size = new System.Drawing.Size(245, 17);
            this.chkExandAllNodes.TabIndex = 0;
            this.chkExandAllNodes.Text = "Expand all nodes when loading web resources";
            this.chkExandAllNodes.UseVisualStyleBackColor = true;
            // 
            // tpFiles
            // 
            this.tpFiles.Controls.Add(this.groupBox4);
            this.tpFiles.Controls.Add(this.groupBox3);
            this.tpFiles.Controls.Add(this.groupBox1);
            this.tpFiles.Location = new System.Drawing.Point(4, 22);
            this.tpFiles.Margin = new System.Windows.Forms.Padding(2);
            this.tpFiles.Name = "tpFiles";
            this.tpFiles.Padding = new System.Windows.Forms.Padding(2);
            this.tpFiles.Size = new System.Drawing.Size(748, 278);
            this.tpFiles.TabIndex = 0;
            this.tpFiles.Text = "Files";
            this.tpFiles.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAutoSaveEnabled);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(2, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(744, 65);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auto-save ";
            // 
            // chkAutoSaveEnabled
            // 
            this.chkAutoSaveEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoSaveEnabled.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAutoSaveEnabled.Location = new System.Drawing.Point(9, 18);
            this.chkAutoSaveEnabled.Name = "chkAutoSaveEnabled";
            this.chkAutoSaveEnabled.Size = new System.Drawing.Size(726, 32);
            this.chkAutoSaveEnabled.TabIndex = 14;
            this.chkAutoSaveEnabled.Text = "Save automatically local content when selecting a webresource and the displayed o" +
    "ne has not been saved (this does not update webresource to CRM organization)";
            this.chkAutoSaveEnabled.UseVisualStyleBackColor = true;
            // 
            // tpEvents
            // 
            this.tpEvents.Controls.Add(this.groupBox2);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Margin = new System.Windows.Forms.Padding(2);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(2);
            this.tpEvents.Size = new System.Drawing.Size(748, 278);
            this.tpEvents.TabIndex = 1;
            this.tpEvents.Text = "Events";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkStyleRemoveComments);
            this.tabPage1.Controls.Add(this.chkObfuscateJavaScript);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 278);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Minifying";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkStyleRemoveComments
            // 
            this.chkStyleRemoveComments.AutoSize = true;
            this.chkStyleRemoveComments.Location = new System.Drawing.Point(4, 24);
            this.chkStyleRemoveComments.Margin = new System.Windows.Forms.Padding(2);
            this.chkStyleRemoveComments.Name = "chkStyleRemoveComments";
            this.chkStyleRemoveComments.Size = new System.Drawing.Size(147, 17);
            this.chkStyleRemoveComments.TabIndex = 3;
            this.chkStyleRemoveComments.Text = "CSS : Remove comments";
            this.chkStyleRemoveComments.UseVisualStyleBackColor = true;
            // 
            // chkObfuscateJavaScript
            // 
            this.chkObfuscateJavaScript.AutoSize = true;
            this.chkObfuscateJavaScript.Location = new System.Drawing.Point(5, 5);
            this.chkObfuscateJavaScript.Margin = new System.Windows.Forms.Padding(2);
            this.chkObfuscateJavaScript.Name = "chkObfuscateJavaScript";
            this.chkObfuscateJavaScript.Size = new System.Drawing.Size(161, 17);
            this.chkObfuscateJavaScript.TabIndex = 2;
            this.chkObfuscateJavaScript.Text = "JavaScript : Obfuscate code";
            this.chkObfuscateJavaScript.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAddMissingFileExtensions);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(2, 159);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(744, 65);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File extensions";
            // 
            // chkAddMissingFileExtensions
            // 
            this.chkAddMissingFileExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAddMissingFileExtensions.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAddMissingFileExtensions.Location = new System.Drawing.Point(9, 18);
            this.chkAddMissingFileExtensions.Name = "chkAddMissingFileExtensions";
            this.chkAddMissingFileExtensions.Size = new System.Drawing.Size(726, 32);
            this.chkAddMissingFileExtensions.TabIndex = 14;
            this.chkAddMissingFileExtensions.Text = "Add default file extensions when missing";
            this.chkAddMissingFileExtensions.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkAddMissingFileExtensions.UseVisualStyleBackColor = true;
            // 
            // OptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(756, 404);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "OptionsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.OptionsDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tDisplay.ResumeLayout(false);
            this.tDisplay.PerformLayout();
            this.tpFiles.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAutoSaveEnabled;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.TabPage tDisplay;
        private System.Windows.Forms.CheckBox chkExandAllNodes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkStyleRemoveComments;
        private System.Windows.Forms.CheckBox chkObfuscateJavaScript;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkAddMissingFileExtensions;
    }
}