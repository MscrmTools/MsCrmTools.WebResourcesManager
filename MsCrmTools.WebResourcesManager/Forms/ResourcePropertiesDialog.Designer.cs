namespace MscrmTools.WebresourcesManager.Forms
{
    partial class ResourcePropertiesDialog
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
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.lblHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(462, 482);
            this.propertyGrid.TabIndex = 0;
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.White;
            this.lblHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHelp.Location = new System.Drawing.Point(0, 0);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(462, 482);
            this.lblHelp.TabIndex = 1;
            this.lblHelp.Text = "Please select a web resource to display its properties";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResourcePropertiesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 482);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.propertyGrid);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ResourcePropertiesDialog";
            this.Text = "Properties";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.Label lblHelp;
    }
}