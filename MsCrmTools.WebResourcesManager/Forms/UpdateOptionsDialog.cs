// PROJECT : MsCrmTools.WebResourcesManager
// This project was developed by Tanguy Touzard
// CODEPLEX: http://xrmtoolbox.codeplex.com
// BLOG: http://mscrmtools.blogspot.com

using MsCrmTools.WebResourcesManager.AppCode;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MsCrmTools.WebResourcesManager.Forms
{
    public enum WebResourceUpdateOption
    {
        Update,
        UpdateAndPublish,
        UpdateAndPublishAndAdd
    }

    public partial class UpdateOptionsDialog : Form
    {
        public UpdateOptionsDialog(List<WebResource> webresources)
        {
            InitializeComponent();

            foreach (var webresource in webresources)
            {
                lvWebresources.Items.Add(webresource.Entity.GetAttributeValue<string>("name"));
            }
        }

        public WebResourceUpdateOption SelectedOption {get;set;}

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbUpdate.Checked)
            {
                SelectedOption = WebResourceUpdateOption.Update;
            }
            else if(rdbUpdatePublish.Checked)
            {
                SelectedOption = WebResourceUpdateOption.UpdateAndPublish;
            }
            else if (rdbUpdatePublishAdd.Checked)
            {
                SelectedOption = WebResourceUpdateOption.UpdateAndPublishAndAdd;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}