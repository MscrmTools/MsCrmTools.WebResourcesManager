namespace MscrmTools.WebResourcesManager.UserControls
{
    partial class CodeEditorScintilla
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.scintilla = new ScintillaNET.Scintilla();
            this.SuspendLayout();
            // 
            // scintilla
            // 
            this.scintilla.AutomaticFold = ((ScintillaNET.AutomaticFold)(((ScintillaNET.AutomaticFold.Show | ScintillaNET.AutomaticFold.Click) 
            | ScintillaNET.AutomaticFold.Change)));
            this.scintilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scintilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla.Location = new System.Drawing.Point(0, 0);
            this.scintilla.Margin = new System.Windows.Forms.Padding(6);
            this.scintilla.Name = "scintilla";
            this.scintilla.Size = new System.Drawing.Size(1270, 985);
            this.scintilla.TabIndex = 0;
            this.scintilla.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.scintilla_CharAdded);
            this.scintilla.TextChanged += new System.EventHandler(this.scintilla_TextChanged);
            // 
            // CodeEditorScintilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scintilla);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CodeEditorScintilla";
            this.Size = new System.Drawing.Size(1270, 985);
            this.Load += new System.EventHandler(this.CodeEditor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla scintilla;
    }
}
