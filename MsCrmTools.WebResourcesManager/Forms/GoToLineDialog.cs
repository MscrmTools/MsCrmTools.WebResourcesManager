using ICSharpCode.AvalonEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsCrmTools.WebResourcesManager.Forms
{
    public partial class GoToLineDialog : Form
    {
        private readonly TextEditor editor;

        public GoToLineDialog(TextEditor editor)
        {
            this.editor = editor;
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
            editor.ScrollTo(lineNumber, 0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}