using System;
using System.Linq;
using System.Windows.Forms;
using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class NewWebResourceDialog : Form
    {
        private readonly string extension;

        public NewWebResourceDialog(string extension)
        {
            InitializeComponent();

            this.extension = extension;
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
                && !Webresource.InValidWrNameRegex.IsMatch(txtWebResourceName.Text)
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