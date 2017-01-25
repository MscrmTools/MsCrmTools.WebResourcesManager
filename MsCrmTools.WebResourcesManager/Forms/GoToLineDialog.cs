using ICSharpCode.AvalonEdit;
using System;
using System.Windows.Forms;

namespace MsCrmTools.WebResourcesManager.Forms
{
    public partial class GoToLineDialog : Form
    {
        private readonly TextEditor textEditor;

        public GoToLineDialog(TextEditor editor)
        {
            textEditor = editor;
            InitializeComponent();
        }

        private void btnGotoLine_Click(object sender, EventArgs e)
        {            
            int lineNumber = 0;
            bool isInt = int.TryParse(txtLineNumber.Text, out lineNumber);
            if (!isInt)
            {
                txtLineNumber.SelectAll();
                return;
            }
            textEditor.ScrollTo(lineNumber, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GoToLineDialog_Activated(object sender, EventArgs e)
        {
            lblLineNumber.Text = $"Line Number (1 - {textEditor.LineCount}) :";
        }
    }
}