using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class NewRootDialog : Form
    {
        private readonly Regex inValidWrNameRegex = new Regex("[^a-z0-9A-Z_\\./]|[/]{2,}", (RegexOptions.Compiled | RegexOptions.CultureInvariant));

        private string rootName;

        public NewRootDialog()
        {
            InitializeComponent();
        }

        public string RootName => rootName;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtRootName.Text.Length > 0 && !inValidWrNameRegex.IsMatch(txtRootName.Text))
            {
                rootName = $"{txtRootName.Text}_";

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, @"Please provide a valid root name!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFolderName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnValidate_Click(null, null);
            }
        }

        private void txtFolderName_TextChanged(object sender, EventArgs e)
        {
            label2.Text = $@"Final root name: {txtRootName.Text}_";
        }
    }
}