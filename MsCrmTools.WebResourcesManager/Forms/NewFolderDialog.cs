using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class NewFolderDialog : Form
    {
        private readonly int organizationMajorVersion;

        public NewFolderDialog(int organizationMajorVersion)
        {
            InitializeComponent();
            this.organizationMajorVersion = organizationMajorVersion;
        }

        public string FolderName { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtFolderName.Text.Length > 0 &&
                (organizationMajorVersion < 9 && organizationMajorVersion > 0 && !Webresource.InValidWrNameRegex.IsMatch(txtFolderName.Text)
                 || (organizationMajorVersion <= 0 || organizationMajorVersion >= 9) && !Webresource.InValidWrNameRegexForV9.IsMatch(txtFolderName.Text)))
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