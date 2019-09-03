using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class NewWebResourceDialog : Form
    {
        private readonly string extension;
        private readonly int organizationMajorVersion;

        public NewWebResourceDialog(string extension, int organizationMajorVersion)
        {
            InitializeComponent();

            this.extension = extension;
            this.organizationMajorVersion = organizationMajorVersion;
        }

        public string WebresourceName { get; private set; }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnValidateClick(object sender, EventArgs e)
        {
            if (txtWebResourceName.Text.Length > 0
                && (organizationMajorVersion < 9 && organizationMajorVersion > 0 && !Webresource.InValidWrNameRegex.IsMatch(txtWebResourceName.Text)
                    || (organizationMajorVersion <= 0 || organizationMajorVersion >= 9) && !Webresource.InValidWrNameRegexForV9.IsMatch(txtWebResourceName.Text))
                && txtWebResourceName.Text.Split('/').All(x => x.Length != 0))
            {
                WebresourceName = $@"{txtWebResourceName.Text}.{extension}";

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show(this, @"Please type a valid webresource name!", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtWebResourceNameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnValidateClick(null, null);
            }
        }

        private void TxtWebResourceNameTextChanged(object sender, EventArgs e)
        {
            label2.Text = $@"Final file name: {txtWebResourceName.Text}.{extension}";
        }
    }
}