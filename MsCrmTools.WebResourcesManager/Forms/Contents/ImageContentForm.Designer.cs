namespace MscrmTools.WebresourcesManager.Forms.Contents
{
    partial class ImageContentForm
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
            this.pnlError = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlError.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlError
            // 
            this.pnlError.BackColor = System.Drawing.SystemColors.Info;
            this.pnlError.Controls.Add(this.lblError);
            this.pnlError.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlError.Location = new System.Drawing.Point(0, 0);
            this.pnlError.Name = "pnlError";
            this.pnlError.Size = new System.Drawing.Size(633, 50);
            this.pnlError.TabIndex = 0;
            this.pnlError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(13, 13);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(82, 20);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "[message]";
            // 
            // ImageContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 584);
            this.Controls.Add(this.pnlError);
            this.Name = "ImageContentForm";
            this.Text = "ImageContentForm";
            this.Load += new System.EventHandler(this.ImageContentForm_Load);
            this.Resize += new System.EventHandler(this.ImageContentForm_Resize);
            this.pnlError.ResumeLayout(false);
            this.pnlError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlError;
        private System.Windows.Forms.Label lblError;
    }
}