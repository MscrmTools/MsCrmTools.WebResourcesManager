﻿using MsCrmTools.WebResourcesManager.AppCode;
using System;
using System.Windows.Forms;

namespace MsCrmTools.WebResourcesManager.Forms
{
    public partial class OptionsDialog : Form
    {
        public OptionsDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            Options.Instance.SaveOnDisk = chkSaveOnDisk.Checked;
            Options.Instance.PushTsMapFiles = chkPushMapAndTsFiles.Checked;
            Options.Instance.AutoSaveWhenLeaving = chkAutoSaveEnabled.Checked;
            Options.Instance.AfterUpdateCommand = txtUpdateEvent.Text;
            Options.Instance.AfterPublishCommand = txtPublishEvent.Text;
            Options.Instance.ExpandAllOnLoadingResources = chkExandAllNodes.Checked;
            Options.Instance.ObfuscateJavascript = chkObfuscateJavaScript.Checked;
            Options.Instance.RemoveCssComments = chkStyleRemoveComments.Checked;
            Options.Instance.AddMissingFileExtensions = chkAddMissingFileExtensions.Checked;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OptionsDialog_Load(object sender, EventArgs e)
        {
            chkSaveOnDisk.Checked = Options.Instance.SaveOnDisk;
            chkPushMapAndTsFiles.Checked = Options.Instance.PushTsMapFiles;
            chkAutoSaveEnabled.Checked = Options.Instance.AutoSaveWhenLeaving;
            txtPublishEvent.Text = Options.Instance.AfterPublishCommand;
            txtPublishEvent.Text = Options.Instance.AfterPublishCommand;
            chkExandAllNodes.Checked = Options.Instance.ExpandAllOnLoadingResources;
            chkObfuscateJavaScript.Checked = Options.Instance.ObfuscateJavascript;
            chkStyleRemoveComments.Checked = Options.Instance.RemoveCssComments;
            chkAddMissingFileExtensions.Checked = Options.Instance.AddMissingFileExtensions;
        }
    }
}