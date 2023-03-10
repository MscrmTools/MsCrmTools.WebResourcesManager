using Microsoft.Xrm.Sdk;
using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class UnusedWebResourcesListDialog : Form
    {
        private readonly IOrganizationService service;

        public UnusedWebResourcesListDialog(IEnumerable<Webresource> unusedWebResources, IOrganizationService service)
        {
            InitializeComponent();

            this.service = service;

            foreach (var wr in unusedWebResources)
            {
                var item = new ListViewItem(wr.Name) { Tag = wr };
                lvWebResources.Items.Add(item);
            }
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            if (lvWebResources.SelectedItems.Count == 0)
                return;

            if (DialogResult.No ==
                MessageBox.Show(this,
                                @"Are your sure you want to delete selected web resources?

Even web resources without any dependencies could be used by other web resources",
                                @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;

            var list = (from ListViewItem item in lvWebResources.SelectedItems select (Webresource)item.Tag).ToList();
            pbDelete.Visible = true;

            var bwDelete = new BackgroundWorker();
            bwDelete.DoWork += BwDeleteDoWork;
            bwDelete.ProgressChanged += BwDeleteProgressChanged;
            bwDelete.RunWorkerCompleted += BwDeleteRunWorkerCompleted;
            bwDelete.WorkerReportsProgress = true;
            bwDelete.RunWorkerAsync(list);
        }

        private void BwDeleteDoWork(object sender, DoWorkEventArgs e)
        {
            var bw = (BackgroundWorker)sender;
            var wrs = (List<Webresource>)e.Argument;

            int i = 1;
            foreach (var wr in wrs)
            {
                bw.ReportProgress((i * 100) / wrs.Count, "Deleting web resource " + wr.Name + "...");

                try
                {
                    service.Delete("webresource", wr.Id);
                }
                finally
                {
                    // Do nothing
                }

                i++;
            }
        }

        private void BwDeleteProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbDelete.Value = e.ProgressPercentage;
        }

        private void BwDeleteRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbDelete.Value = 0;
            pbDelete.Visible = false;
        }

        private void CopySelectedValuesToClipboard()
        {
            var builder = new StringBuilder();
            foreach (ListViewItem item in lvWebResources.SelectedItems)
                builder.AppendLine(item.Text);

            Clipboard.SetText(builder.ToString());
        }

        private void lvWebResources_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lvWebResources.Sorting == SortOrder.Ascending)
            {
                lvWebResources.Sorting = SortOrder.Descending;
            }
            else
            {
                lvWebResources.Sorting = SortOrder.Ascending;
            }

            lvWebResources.ListViewItemSorter = new ListViewItemComparer(e.Column, lvWebResources.Sorting);
        }

        private void lvWebResources_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender != lvWebResources) return;

            if (e.Control && e.KeyCode == Keys.C)
                CopySelectedValuesToClipboard();
        }
    }
}