using Microsoft.VisualBasic.CompilerServices;
using MscrmTools.WebresourcesManager.AppCode;
using MscrmTools.WebresourcesManager.AppCode.Args;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class PendingUpdatesDialog : DockContent
    {
        private readonly MyPluginControl mainControl;

        private IEnumerable<string> ignoredFiles = new string[0];
        public IEnumerable<string> IgnoredFiles
        {
            get => ignoredFiles;
            set
            {
                ignoredFiles = value;

                Invoke(new Action(() => refreshWebResource()));
            }
        }
        public PendingUpdatesDialog(MyPluginControl control)
        {
            InitializeComponent();

            mainControl = control;

            control.WebresourcesCache.CollectionChanged += WebresourcesCache_CollectionChanged;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var us = new UpdateResourcesSettings
            {
                Webresources = clbWebresources.CheckedItems.Cast<Webresource>(),
                Publish = rdbUpdatePublish.Checked || rdbUpdatePublishAdd.Checked,
                AddToSolution = rdbUpdatePublishAdd.Checked
            };

            mainControl.PerformUpdate(us);
        }

        private void clbWebresources_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                btnApply.Enabled = true;
            }
            else if (e.NewValue == CheckState.Unchecked)
            {
                btnApply.Enabled = clbWebresources.CheckedItems.Count > 1;
            }
        }

        private void llItemsAction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (sender == llCheckAll)
            {
                for (var i = 0; i < clbWebresources.Items.Count; i++)
                {
                    clbWebresources.SetItemChecked(i, true);
                }
            }
            else if (sender == llCheckNone)
            {
                for (var i = 0; i < clbWebresources.Items.Count; i++)
                {
                    clbWebresources.SetItemChecked(i, false);
                }
            }
            else
            {
                for (var i = 0; i < clbWebresources.Items.Count; i++)
                {
                    clbWebresources.SetItemChecked(i, !clbWebresources.GetItemChecked(i));
                }
            }
        }

        private void PendingUpdatesDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void Resource_StateChanged(object sender, StateEventArgs e)
        {
            Invoke(new Action(() =>
            {
                refreshWebResource();
            }));
        }

        private void refreshWebResource()
        {
            clbWebresources.Items.Clear();

            foreach (var resource in mainControl.WebresourcesCache.Where(savedAndNotIgnored))
            {
                clbWebresources.Items.Add(resource);
                clbWebresources.SetItemChecked(clbWebresources.Items.Count - 1, true);
            }

            btnApply.Enabled = clbWebresources.Items.Count > 0;

            TabText = $"Pending Updates {(clbWebresources.Items.Count > 0 ? $" ({clbWebresources.Items.Count})" : "")}";

            bool savedAndNotIgnored(Webresource r) =>
                r.State == WebresourceState.Saved
                && !isIgnored(r);

            bool isIgnored(Webresource r)
            {
                if (IgnoredFiles.Any(i => LikeOperator.LikeString(r.Name, i, Microsoft.VisualBasic.CompareMethod.Text)))
                {
                    return true;
                }

                return false;
            }
        }

        private void WebresourcesCache_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (var resource in e.NewItems.OfType<Webresource>())
                {
                    resource.StateChanged += Resource_StateChanged;
                }
            }
        }
    }
}