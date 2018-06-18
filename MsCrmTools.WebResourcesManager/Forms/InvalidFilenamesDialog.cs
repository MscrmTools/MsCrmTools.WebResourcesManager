using System;
using System.Collections.Generic;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class InvalidFilenamesDialog : DockContent
    {
        private List<string> invalidFiles;

        public InvalidFilenamesDialog()
        {
            InitializeComponent();
        }

        public List<string> InvalidFiles
        {
            get => invalidFiles;
            set
            {
                invalidFiles = value;
                ShowItems();
            }
        }

        private void InvalidFilenamesDialog_Load(object sender, System.EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            textBox1.Text = $@"Following files have not been loaded due to invalid name or extension:{Environment.NewLine}{string.Join(Environment.NewLine, invalidFiles)}";
        }
    }
}