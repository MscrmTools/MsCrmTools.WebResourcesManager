using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class ConcurrencySummaryDialog : Form
    {
        public ConcurrencySummaryDialog(List<Webresource> oldersList, List<Webresource> inErrorList)
        {
            InitializeComponent();

            if (oldersList.Any())
            {
                lvConcurrency.Items.AddRange(oldersList.Select(r => new ListViewItem(r.Name) { Tag = r, Checked = true }).ToArray());
                splitContainer1.Panel1Collapsed = false;
            }
            else
            {
                btnForceUpdate.Visible = false;
                lblDesc.Visible = false;
                splitContainer1.Panel1Collapsed = true;
            }

            if (inErrorList.Any())
            {
                lvErrors.Items.AddRange(inErrorList.Select(r => new ListViewItem(r.Name) { SubItems = { r.LastException.ToString() } }).ToArray());
                splitContainer1.Panel2Collapsed = false;
            }
            else
            {
                splitContainer1.Panel2Collapsed = true;
            }
        }

        public List<Webresource> WebresourcesForceUpdate
        {
            get { return lvConcurrency.CheckedItems.Cast<ListViewItem>().Select(i => (Webresource)i.Tag).ToList(); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnForceUpdate_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}