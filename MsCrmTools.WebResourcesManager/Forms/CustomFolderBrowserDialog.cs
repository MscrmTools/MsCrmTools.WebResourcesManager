﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class CustomFolderBrowserDialog : Form
    {
        public CustomFolderBrowserDialog(int majorVersion, bool isLoadFromDisk, bool showExtensionOptions = true)
        {
            InitializeComponent();

            webResourceTypePicker1.ShowV9Types = majorVersion >= 9;

            if (!isLoadFromDisk)
            {
                webResourceTypePicker1.Visible = false;
                Size = new Size(500, 200);
                lblTitle.Text = @"Save folder";
                Text = @"Save web resources";

                Invalidate();
            }
            else if (!showExtensionOptions)
            {
                webResourceTypePicker1.Visible = false;
                lblTitle.Text = @"Folder";

                Invalidate();
            }
        }

        public List<string> ExtensionsToLoad { get; private set; }

        public string FolderPath { get; set; }

        public override sealed string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog
            {
                Description = @"Select the folder where the files are located",
                ShowNewFolderButton = true
            })
            {
                if (fbd.ShowDialog(this) == DialogResult.OK)
                {
                    txtFolderPath.Text = fbd.SelectedPath;
                    FolderPath = fbd.SelectedPath;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtFolderPath.Text))
            {
                MessageBox.Show(this, @"Invalid folder specified!", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FolderPath = txtFolderPath.Text;

            ExtensionsToLoad = webResourceTypePicker1.CheckedExtensions;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void CustomFolderBrowserDialog_Load(object sender, EventArgs e)
        {
            txtFolderPath.Text = FolderPath;
        }
    }
}