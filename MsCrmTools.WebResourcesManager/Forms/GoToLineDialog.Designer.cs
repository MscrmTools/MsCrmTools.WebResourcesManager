namespace MsCrmTools.WebResourcesManager.Forms
{
    partial class GoToLineDialog
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
            this.lblLineNumber = new System.Windows.Forms.Label();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.btnGotoLine = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLineNumber
            // 
            this.lblLineNumber.AutoSize = true;
            this.lblLineNumber.Location = new System.Drawing.Point(12, 9);
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(93, 17);
            this.lblLineNumber.TabIndex = 0;
            this.lblLineNumber.Text = "Line Number:";
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(15, 29);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(176, 22);
            this.txtLineNumber.TabIndex = 1;
            // 
            // btnGotoLine
            // 
            this.btnGotoLine.Location = new System.Drawing.Point(90, 78);
            this.btnGotoLine.Name = "btnGotoLine";
            this.btnGotoLine.Size = new System.Drawing.Size(85, 31);
            this.btnGotoLine.TabIndex = 2;
            this.btnGotoLine.Text = "Go To";
            this.btnGotoLine.UseVisualStyleBackColor = true;
            this.btnGotoLine.Click += new System.EventHandler(this.btnGotoLine_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 31);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GoToLineDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 119);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGotoLine);
            this.Controls.Add(this.txtLineNumber);
            this.Controls.Add(this.lblLineNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoToLineDialog";
            this.ShowInTaskbar = false;
            this.Text = "Go To Line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLineNumber;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.Button btnGotoLine;
        private System.Windows.Forms.Button btnCancel;
    }
}