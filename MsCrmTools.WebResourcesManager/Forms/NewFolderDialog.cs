using System;
using System.Windows.Forms;
using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class NewFolderDialog : Form
    {
        public NewFolderDialog()
        {
            InitializeComponent();
        }

        public string FolderName { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtFolderName.Text.Length > 0 && !Webresource.InValidWrNameRegex.IsMatch(txtFolderName.Text))
            {
                FolderName = txtFolderName.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, @"Please type a valid folder name!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtFolderName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnValidate_Click(null, null);
            }
        }
    }
}