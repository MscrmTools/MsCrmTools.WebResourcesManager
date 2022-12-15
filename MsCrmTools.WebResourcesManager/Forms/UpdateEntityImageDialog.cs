using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Query;
using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class UpdateEntityImageDialog : Form
    {
        private readonly IOrganizationService _service;
        private readonly string _webresourceName;
        private BackgroundWorker bw;
        private int currentSortedColumnIndex = -1;

        public UpdateEntityImageDialog(IOrganizationService service, string webresourceName)
        {
            InitializeComponent();

            _service = service;
            _webresourceName = webresourceName;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (lvTables.CheckedItems.Count == 0)
            {
                MessageBox.Show(this, "Please check at least one table", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var emds = lvTables.CheckedItems.Cast<ListViewItem>().Select(i => (EntityMetadata)i.Tag).ToList();
            SetWorkingState(true);

            bw = new BackgroundWorker { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            bw.DoWork += (s, evt) =>
            {
                foreach (var emd in emds)
                {
                    evt.Result = true;
                    if (((BackgroundWorker)s).CancellationPending)
                    {
                        evt.Result = false;
                        return;
                    }

                    ((BackgroundWorker)s).ReportProgress(0, $"Retrieving table {emd.DisplayName?.UserLocalizedLabel.Label ?? emd.SchemaName}...");

                    var response = (RetrieveEntityResponse)_service.Execute(new RetrieveEntityRequest
                    {
                        EntityFilters = EntityFilters.Entity,
                        LogicalName = emd.LogicalName
                    });

                    ((BackgroundWorker)s).ReportProgress(0, $"Updating table {emd.DisplayName?.UserLocalizedLabel.Label ?? emd.SchemaName}...");
                    response.EntityMetadata.IconVectorName = _webresourceName;

                    _service.Execute(new UpdateEntityRequest
                    {
                        Entity = response.EntityMetadata
                    });
                }

                if (((BackgroundWorker)s).CancellationPending)
                {
                    evt.Result = false;
                    return;
                }

                ((BackgroundWorker)s).ReportProgress(0, $"Publishing table(s)...");
                _service.Execute(new PublishXmlRequest
                {
                    ParameterXml = $"<importexportxml><entities><entity>{string.Join("</entity><entity>", emds.Select(emd => emd.LogicalName))}</entity></entities><nodes/><securityroles/><settings/><workflows/></importexportxml>"
                });
            };
            bw.ProgressChanged += (s, evt) =>
            {
                lblProgress.Text = evt.UserState.ToString();
            };
            bw.RunWorkerCompleted += (s, evt) =>
            {
                SetWorkingState(false);
                lblProgress.Text = string.Empty;
                if (evt.Error != null)
                {
                    MessageBox.Show(this, $"An error occured when updating table(s):\n\n{evt.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if ((bool)evt.Result)
                {
                    lblProgress.Text = "";
                    pnlValidation.Visible = true;
                    pnlValidation.Location = new Point(pnlMain.Width / 2 - pnlValidation.Width / 2, pnlMain.Height / 2 - pnlValidation.Height / 2);
                }
                else
                {
                    lblProgress.Text = "Canceled";
                }
            };
            bw.RunWorkerAsync();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bw?.CancelAsync();
            lblProgress.Text = "Cancelling will occur after current operation";
        }

        private void llCloseValidation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlValidation.Visible = false;
        }

        private void lvTables_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != currentSortedColumnIndex)
            {
                currentSortedColumnIndex = e.Column;
                lvTables.ListViewItemSorter = new ListViewItemComparer(e.Column, SortOrder.Ascending);
            }
            else
            {
                lvTables.ListViewItemSorter = new ListViewItemComparer(e.Column, lvTables.Sorting == SortOrder.Descending ? SortOrder.Ascending : SortOrder.Descending);
            }
            lvTables.Sort();
        }

        private void SetWorkingState(bool isWorking)
        {
            lvTables.Enabled = !isWorking;
            btnApply.Enabled = !isWorking;
            btnCancel.Visible = isWorking;
        }

        private void UpdateEntityImageDialog_Load(object sender, EventArgs e)
        {
            lblProgress.Text = "Loading tables...";

            SetWorkingState(true);

            bw = new BackgroundWorker { WorkerReportsProgress = true };
            bw.DoWork += (s, evt) =>
            {
                EntityQueryExpression entityQueryExpression = new EntityQueryExpression
                {
                    Criteria = new MetadataFilterExpression(LogicalOperator.And)
                    {
                        Conditions =
                        {
                            new MetadataConditionExpression("IsCustomEntity", MetadataConditionOperator.Equals, true),
                        }
                    },
                    Properties = new MetadataPropertiesExpression
                    {
                        AllProperties = true,
                        PropertyNames = { "DisplayName", "SchemaName", "LogicalName", "IconVectorName" }
                    }
                };
                RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest
                {
                    Query = entityQueryExpression,
                    ClientVersionStamp = null
                };
                var response = (RetrieveMetadataChangesResponse)_service.Execute(retrieveMetadataChangesRequest);

                evt.Result = response.EntityMetadata.ToList();
            };
            bw.ProgressChanged += (s, evt) =>
            {
                lblProgress.Text = evt.UserState.ToString();
            };
            bw.RunWorkerCompleted += (s, evt) =>
            {
                SetWorkingState(false);

                lblProgress.Text = string.Empty;
                if (evt.Error != null)
                {
                    MessageBox.Show(this, $"An error occured when loading tables:\n\n{evt.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lvTables.Items.AddRange(((List<EntityMetadata>)evt.Result).Select(emd => new ListViewItem(emd.DisplayName?.UserLocalizedLabel?.Label ?? "N/A")
                {
                    Tag = emd,
                    SubItems =
                    {
                        new ListViewItem.ListViewSubItem{Text = emd.LogicalName}
                    }
                }).ToArray());
            };
            bw.RunWorkerAsync();
        }

        private void UpdateEntityImageDialog_Resize(object sender, EventArgs e)
        {
            pnlValidation.Location = new Point(pnlMain.Width / 2 - pnlValidation.Width / 2, pnlMain.Height / 2 - pnlValidation.Height / 2);
        }
    }
}