namespace MsCrmTools.WebResourcesManager.Forms
{
    partial class UpdateOptionsDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gbActions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbUpdatePublishAdd = new System.Windows.Forms.RadioButton();
            this.rdbUpdatePublish = new System.Windows.Forms.RadioButton();
            this.rdbUpdate = new System.Windows.Forms.RadioButton();
            this.gbWebresources = new System.Windows.Forms.GroupBox();
            this.lvWebresources = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbActions.SuspendLayout();
            this.gbWebresources.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 92);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the action to perform to upate web resources to the CRM organization";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an update action";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(834, 529);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOK.Location = new System.Drawing.Point(714, 529);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // gbActions
            // 
            this.gbActions.Controls.Add(this.label5);
            this.gbActions.Controls.Add(this.label4);
            this.gbActions.Controls.Add(this.label3);
            this.gbActions.Controls.Add(this.rdbUpdatePublishAdd);
            this.gbActions.Controls.Add(this.rdbUpdatePublish);
            this.gbActions.Controls.Add(this.rdbUpdate);
            this.gbActions.Location = new System.Drawing.Point(12, 100);
            this.gbActions.Name = "gbActions";
            this.gbActions.Size = new System.Drawing.Size(224, 416);
            this.gbActions.TabIndex = 13;
            this.gbActions.TabStop = false;
            this.gbActions.Text = "Action";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 85);
            this.label5.TabIndex = 5;
            this.label5.Text = "Update the web resources to the CRM organization, publish them and add them to a " +
    "solution";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 64);
            this.label4.TabIndex = 4;
            this.label4.Text = "Update the web resources to the CRM organization and publish them";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 64);
            this.label3.TabIndex = 3;
            this.label3.Text = "Only update the web resources to the CRM organization";
            // 
            // rdbUpdatePublishAdd
            // 
            this.rdbUpdatePublishAdd.AutoSize = true;
            this.rdbUpdatePublishAdd.Location = new System.Drawing.Point(12, 288);
            this.rdbUpdatePublishAdd.Name = "rdbUpdatePublishAdd";
            this.rdbUpdatePublishAdd.Size = new System.Drawing.Size(205, 24);
            this.rdbUpdatePublishAdd.TabIndex = 2;
            this.rdbUpdatePublishAdd.Text = "Update & Publish & Add";
            this.rdbUpdatePublishAdd.UseMnemonic = false;
            this.rdbUpdatePublishAdd.UseVisualStyleBackColor = true;
            // 
            // rdbUpdatePublish
            // 
            this.rdbUpdatePublish.AutoSize = true;
            this.rdbUpdatePublish.Location = new System.Drawing.Point(6, 154);
            this.rdbUpdatePublish.Name = "rdbUpdatePublish";
            this.rdbUpdatePublish.Size = new System.Drawing.Size(157, 24);
            this.rdbUpdatePublish.TabIndex = 1;
            this.rdbUpdatePublish.Text = "Update & Publish";
            this.rdbUpdatePublish.UseMnemonic = false;
            this.rdbUpdatePublish.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            this.rdbUpdate.AutoSize = true;
            this.rdbUpdate.Checked = true;
            this.rdbUpdate.Location = new System.Drawing.Point(13, 25);
            this.rdbUpdate.Name = "rdbUpdate";
            this.rdbUpdate.Size = new System.Drawing.Size(87, 24);
            this.rdbUpdate.TabIndex = 0;
            this.rdbUpdate.TabStop = true;
            this.rdbUpdate.Text = "Update";
            this.rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // gbWebresources
            // 
            this.gbWebresources.Controls.Add(this.lvWebresources);
            this.gbWebresources.Location = new System.Drawing.Point(242, 100);
            this.gbWebresources.Name = "gbWebresources";
            this.gbWebresources.Size = new System.Drawing.Size(710, 416);
            this.gbWebresources.TabIndex = 14;
            this.gbWebresources.TabStop = false;
            this.gbWebresources.Text = "Web resources to update";
            // 
            // lvWebresources
            // 
            this.lvWebresources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvWebresources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWebresources.GridLines = true;
            this.lvWebresources.Location = new System.Drawing.Point(3, 22);
            this.lvWebresources.Name = "lvWebresources";
            this.lvWebresources.Size = new System.Drawing.Size(704, 391);
            this.lvWebresources.TabIndex = 0;
            this.lvWebresources.UseCompatibleStateImageBehavior = false;
            this.lvWebresources.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 400;
            // 
            // UpdateOptionsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(964, 583);
            this.Controls.Add(this.gbWebresources);
            this.Controls.Add(this.gbActions);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateOptionsDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbActions.ResumeLayout(false);
            this.gbActions.PerformLayout();
            this.gbWebresources.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox gbActions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbUpdatePublishAdd;
        private System.Windows.Forms.RadioButton rdbUpdatePublish;
        private System.Windows.Forms.RadioButton rdbUpdate;
        private System.Windows.Forms.GroupBox gbWebresources;
        private System.Windows.Forms.ListView lvWebresources;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}