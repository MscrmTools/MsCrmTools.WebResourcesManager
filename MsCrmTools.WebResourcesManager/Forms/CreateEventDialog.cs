using Microsoft.Xrm.Sdk;
using MsCrmTools.WebResourcesManager.AppCode.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MsCrmTools.WebResourcesManager.Forms
{
    public partial class CreateEventDialog : Form
    {
        private readonly IOrganizationService _service;
        private readonly string _webResourceName;

        private ScriptsManager sm;
        private ToolTip tooltip;

        public CreateEventDialog(string webResourceName, IOrganizationService service)
        {
            InitializeComponent();

            _service = service;
            _webResourceName = webResourceName;

            lblHeaderTitle.Text = string.Format(lblHeaderTitle.Text, webResourceName);

            tooltip = new ToolTip();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var uiItem = cbbUiItems.SelectedItem as IUiUtem ?? cbbUiItems.SelectedItem as IUiUtem;
            if (uiItem == null) return;

            var logicalName = cbbEntity.SelectedItem.ToString().Split('(')[1];
            logicalName = logicalName.Substring(0, logicalName.Length - 1);

            Script eventScript = null;
            Script libraryScript = null;

            if (rdbRegisterLibrary.Checked)
            {
                eventScript = new Script
                {
                    Action = ScriptAction.Create,
                    UiItem = uiItem.Item,
                    ItemName = uiItem is CdsForm form ? form.Item.GetAttributeValue<string>("name") : "",
                    FormType = uiItem is CdsForm cdsForm ? cdsForm.Item.FormattedValues["type"] : "",
                    FormState = uiItem is CdsForm item ? (item.Item.FormattedValues.Contains("formactivationstate") ? item.Item.FormattedValues["formactivationstate"] : "") : "",
                    NewLibrary = _webResourceName,
                    Library = _webResourceName,
                    Type = uiItem is CdsForm ? "Form Library" : "Homepage Grid Library",
                    EntityLogicalName = logicalName,
                    EntityName = sm.Metadata.First(emd => emd.LogicalName == logicalName).DisplayName
                        ?.UserLocalizedLabel?.Label,
                    Order = 999
                };
            }
            else
            {
                var control = (CdsFormControl)cbbControl.SelectedItem;
                eventScript = new Script
                {
                    Action = ScriptAction.Create,
                    UiItem = uiItem.Item,
                    ItemName = uiItem is CdsForm || uiItem is CdsView
                        ? uiItem.Item.GetAttributeValue<string>("name")
                        : "",
                    FormType = uiItem is CdsForm ? uiItem.Item.FormattedValues["type"] : "",
                    FormState = uiItem is CdsForm ? (uiItem.Item.FormattedValues.Contains("formactivationstate") ? uiItem.Item.FormattedValues["formactivationstate"] : "") : "",
                    Event = cbbEvent.SelectedItem.ToString().ToLower(),
                    NewLibrary = _webResourceName,
                    Library = _webResourceName,
                    NewParameters = uiItem is CdsView ? "" : txtParameters.Text,
                    Parameters = uiItem is CdsView ? "" : txtParameters.Text,
                    NewEnabled = chkEnabled.Checked,
                    Enabled = chkEnabled.Checked,
                    NewMethodCalled = txtMethod.Text,
                    MethodCalled = txtMethod.Text,
                    NewPassExecutionContext = chkPassExecutionContext.Checked,
                    PassExecutionContext = chkPassExecutionContext.Checked,
                    AttributeLogicalName = "",
                    Attribute = "",
                    Order = 999,
                    Type = control.Type == CdsFormControlType.Grid ? "Subgrid event" :
                        control.Type == CdsFormControlType.HomepageGrid ? "Homepage Grid event" :
                        control.Type == CdsFormControlType.View ? "Grid Icon" : "Form event",
                    EntityLogicalName = logicalName,
                    EntityName = sm.Metadata.First(emd => emd.LogicalName == logicalName).DisplayName
                        ?.UserLocalizedLabel?.Label
                };

                if (eventScript.Type == "Subgrid event")
                {
                    if (eventScript.Event == "onchange")
                    {
                        eventScript.AttributeLogicalName = $"{control.Id}:{txtField.Text}";
                        eventScript.Attribute = $"{control.Name} / {txtField.Text}";
                    }
                    else
                    {
                        eventScript.AttributeLogicalName = $"{control.Id}";
                        eventScript.Attribute = $"{control.Name}";
                    }
                }
                else if (eventScript.Event == "ontabstatechange")
                {
                    eventScript.AttributeLogicalName = control.Id;
                    eventScript.Attribute = control.Name;
                }
                else if (eventScript.Event == "n/a")
                {
                    eventScript.AttributeLogicalName = control.Id;
                    eventScript.Attribute = control.Name;
                }
                else
                {
                    if (eventScript.Event == "onchange")
                    {
                        eventScript.AttributeLogicalName = string.IsNullOrEmpty(txtField.Text) ? control.Id : txtField.Text;
                        eventScript.Attribute = sm.Metadata.FirstOrDefault(emd => emd.LogicalName == logicalName)?.Attributes
                            .FirstOrDefault(a => a.LogicalName == eventScript.AttributeLogicalName)?.DisplayName
                            ?.UserLocalizedLabel?.Label;

                        if (eventScript.Attribute == null)
                        {
                            MessageBox.Show(this, @"Please ensure the attribute logical name is correct", @"Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                if (uiItem is CdsView) return;

                if (!uiItem.Libraries.Select(l => l?.ToLower()).Contains(_webResourceName.ToLower()))
                {
                    libraryScript = new Script
                    {
                        Action = ScriptAction.Create,
                        UiItem = uiItem.Item,
                        NewLibrary = _webResourceName,
                        Library = _webResourceName,
                        ItemName = uiItem is CdsForm form ? form.Item.GetAttributeValue<string>("name") : "",
                        FormType = uiItem is CdsForm cdsForm ? cdsForm.Item.FormattedValues["type"] : "",
                        FormState = uiItem is CdsForm item
                            ? (uiItem.Item.FormattedValues.Contains("formactivationstate") ? uiItem.Item.FormattedValues["formactivationstate"] : "")
                            : "",
                        Type = uiItem is CdsForm ? "Form Library" : "Homepage Grid Library",
                        EntityName = eventScript.EntityName,
                        EntityLogicalName = eventScript.EntityLogicalName,
                        Order = 999
                    };
                }
            }

            if (libraryScript != null)
            {
                if (lvNewScripts.Items.Cast<ListViewItem>().Select(i => (Script)i.Tag).Any(s =>
                       s.Type == "Form Library" && s.UiItem.Id == libraryScript.UiItem.Id && s.Library == libraryScript.Library))
                {
                }
                else
                {
                    var item = new ListViewItem(libraryScript.Type) { Tag = libraryScript };
                    item.SubItems.Add(libraryScript.EntityName);
                    item.SubItems.Add(libraryScript.ItemName);
                    item.SubItems.Add(libraryScript.Event?.ToLower());
                    item.SubItems.Add(libraryScript.Attribute);
                    item.SubItems.Add(libraryScript.Library);
                    item.SubItems.Add(libraryScript.MethodCalled);
                    item.SubItems.Add(libraryScript.PassExecutionContext?.ToString() ?? "");
                    item.SubItems.Add(libraryScript.Parameters);
                    item.SubItems.Add(libraryScript.Enabled?.ToString() ?? "");
                    item.Tag = libraryScript;

                    lvNewScripts.Items.Add(item);
                }
            }

            if (eventScript != null)
            {
                var item = new ListViewItem(eventScript.Type) { Tag = libraryScript };
                item.SubItems.Add(eventScript.EntityName);
                item.SubItems.Add(eventScript.ItemName);
                item.SubItems.Add(eventScript.Event?.ToLower());
                item.SubItems.Add(eventScript.Attribute);
                item.SubItems.Add(eventScript.Library);
                item.SubItems.Add(eventScript.MethodCalled);
                item.SubItems.Add(eventScript.PassExecutionContext?.ToString() ?? "");
                item.SubItems.Add(eventScript.Parameters);
                item.SubItems.Add(eventScript.Enabled?.ToString() ?? "");
                item.Tag = eventScript;

                lvNewScripts.Items.Add(item);
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            lblProgress.Text = "Processing...";
            SetWorkingState(true);
            var scripts = lvNewScripts.Items.Cast<ListViewItem>().Select(i => (Script)i.Tag).ToList();

            var bwMain = new BackgroundWorker() { WorkerReportsProgress = true };
            bwMain.DoWork += (bw, evt) =>
            {
                int index = 1;
                foreach (var script in scripts)
                {
                    ((BackgroundWorker)bw).ReportProgress(0, $"Processing {index++}/{scripts.Count}...");
                    script.ProcessChanges();
                }

                sm.UpdateForms(scripts);
            };
            bwMain.ProgressChanged += (bw, evt) =>
            {
            };
            bwMain.RunWorkerCompleted += (bw, evt) =>
            {
                lblProgress.Text = "";
                SetWorkingState(false);
                if (evt.Error != null)
                {
                    MessageBox.Show(this, $"An error occured when processing:\n\n{evt.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pnlValidation.Visible = true;
                pnlValidation.Location = new Point((pnlMain.Width + lvNewScripts.Width) / 2 - pnlValidation.Width / 2, pnlMain.Height / 2 - pnlValidation.Height / 2);
            };
            bwMain.RunWorkerAsync();
        }

        private void cbbControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var control = (CdsFormControl)cbbControl.SelectedItem;

            cbbEvent.Items.Clear();
            cbbEvent.Items.AddRange(control.GetEvents().Cast<object>().ToArray());
            cbbEvent.SelectedIndex = 0;
        }

        private void cbbEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var logicalName = cbbEntity.SelectedItem.ToString().Split('(')[1];
            logicalName = logicalName.Substring(0, logicalName.Length - 1);
            var emd = sm.Metadata.First(em => em.LogicalName == logicalName);

            var forms = sm.Forms.Where(f => f.GetAttributeValue<string>("objecttypecode") == logicalName
                                          && (f.GetAttributeValue<OptionSetValue>("type").Value == 2
                                          || f.GetAttributeValue<OptionSetValue>("type").Value == 7));

            var homepageGrids =
                sm.HomePageGrids.Where(h => h.GetAttributeValue<string>("primaryentitytypecode") == logicalName);

            var views = sm.Views.Where(v => v.GetAttributeValue<string>("returnedtypecode") == logicalName);

            cbbUiItems.Items.Clear();
            cbbUiItems.Items.AddRange(forms.Select(f => new CdsForm(f)).Cast<object>().ToArray());
            cbbUiItems.Items.AddRange(homepageGrids.Select(h => new CdsHomePageGrid(h)).Cast<object>().ToArray());
            cbbUiItems.Items.AddRange(views.Where(v => !string.IsNullOrEmpty(v.GetAttributeValue<string>("layoutxml"))).Select(v => new CdsView(v, emd)).Cast<object>().ToArray());
            cbbUiItems.SelectedIndex = 0;
        }

        private void cbbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var control = (CdsFormControl)cbbControl.SelectedItem;
            var eventName = cbbEvent.SelectedItem.ToString();
            var showFieldControls = eventName == "OnChange" && (control.Type == CdsFormControlType.Grid || control.Type == CdsFormControlType.HomepageGrid);

            txtField.Visible = showFieldControls;
            lblField.Visible = showFieldControls;
        }

        private void cbbForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbControl.Items.Clear();
            cbbControl.Items.AddRange(((IUiUtem)cbbUiItems.SelectedItem).GetControls(sm.UserLcid).Cast<object>().ToArray());
            cbbControl.SelectedIndex = 0;

            var isView = cbbUiItems.SelectedItem is CdsView;
            lblEvent.Visible = !isView;
            cbbEvent.Visible = !isView;
            lblPassExecutionContext.Visible = !isView;
            chkPassExecutionContext.Visible = !isView;
            lblParameters.Visible = !isView;
            txtParameters.Visible = !isView;
            lblEnabled.Visible = !isView;
            chkEnabled.Visible = !isView;
        }

        private void CreateEventDialog_Load(object sender, EventArgs e)
        {
            lblProgress.Text = "Loading tables...";
            SetWorkingState(true);

            var bwMain = new BackgroundWorker() { WorkerReportsProgress = true };
            bwMain.DoWork += (bw, evt) =>
            {
                sm = new ScriptsManager(_service, (BackgroundWorker)bw);
                sm.Find(new List<Entity>(), true, new Version(9, 2, 0, 0));
            };
            bwMain.ProgressChanged += (bw, evt) =>
            {
            };
            bwMain.RunWorkerCompleted += (bw, evt) =>
            {
                lblProgress.Text = "";
                SetWorkingState(false);
                if (evt.Error != null)
                {
                    MessageBox.Show(this, $"An error occured when processing:\n\n{evt.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cbbEntity.Items.AddRange(sm.Metadata.Select(emd => $"{emd.DisplayName?.UserLocalizedLabel?.Label ?? "N/A"} ({emd.LogicalName})").Cast<object>().ToArray());
                cbbEntity.SelectedIndex = 0;
                rdbRegisterEvent_CheckedChanged(rdbRegisterEvent, new EventArgs());
            };
            bwMain.RunWorkerAsync();
        }

        private void CreateEventDialog_Resize(object sender, EventArgs e)
        {
            pnlValidation.Location = new Point((pnlMain.Width + lvNewScripts.Width) / 2 - pnlValidation.Width / 2, pnlMain.Height / 2 - pnlValidation.Height / 2);
        }

        private void llCloseValidation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlValidation.Visible = false;
        }

        private void lvNewScripts_DoubleClick(object sender, EventArgs e)
        {
            var lvi = lvNewScripts.SelectedItems.Cast<ListViewItem>().FirstOrDefault();
            if (lvi == null) return;

            lvNewScripts.Items.Remove(lvi);
        }

        private void lvNewScripts_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
            if (((Script)e.Item.Tag).HasProblem)
            {
                tooltip.SetToolTip(lvNewScripts, ((Script)e.Item.Tag).UpdateErrorMessage);
            }
            else
            {
                tooltip.SetToolTip(lvNewScripts, "");
            }
        }

        private void rdbRegisterEvent_CheckedChanged(object sender, EventArgs e)
        {
            var isEvent = ((RadioButton)sender).Checked;

            var control = (CdsFormControl)cbbControl.SelectedItem;
            var eventName = cbbEvent.SelectedItem?.ToString();
            var showFieldControls = eventName == "OnChange" && (control.Type == CdsFormControlType.Grid || control.Type == CdsFormControlType.HomepageGrid);

            lblControl.Visible = isEvent;
            cbbControl.Visible = isEvent;
            lblEvent.Visible = isEvent;
            cbbEvent.Visible = isEvent;
            txtField.Visible = isEvent && showFieldControls;
            lblField.Visible = isEvent && showFieldControls;
            lblMethod.Visible = isEvent;
            txtMethod.Visible = isEvent;
            lblPassExecutionContext.Visible = isEvent;
            chkPassExecutionContext.Visible = isEvent;
            lblParameters.Visible = isEvent;
            txtParameters.Visible = isEvent;
            lblEnabled.Visible = isEvent;
            chkEnabled.Visible = isEvent;
        }

        private void SetWorkingState(bool working)
        {
            pnlMain.Enabled = !working;
            lvNewScripts.Enabled = !working;
        }
    }
}