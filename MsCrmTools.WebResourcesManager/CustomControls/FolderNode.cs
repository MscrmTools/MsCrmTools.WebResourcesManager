using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    public class FolderNode : TreeNode
    {
        private static int DraftFolderImageIndex = 15;
        private static int DraftRootImageIndex = 14;
        private static int SyncedFolderImageIndex = 1;
        private static int SyncedRootImageIndex = 0;
        private bool synced = true;

        public FolderNode(bool isRoot, string resourcefullPath, string folderPath = null)
        {
            FolderPath = folderPath;
            ResourceFullPath = resourcefullPath;
            IsRoot = isRoot;

            Text = resourcefullPath.Split(new[] { '/', '\\' }, StringSplitOptions.RemoveEmptyEntries).Last();
            Name = Text;
            SetImageIndexes();
        }

        public string FolderPath { get; set; }
        public bool IsRoot { get; }
        public string ResourceFullPath { get; }

        public bool Synced
        {
            get => synced;
            set
            {
                synced = value;
                SetImageIndexes();

                if (Parent is FolderNode parent)
                {
                    parent.Synced = value;
                }
            }
        }

        public void SetChildsCheckState()
        {
            foreach (TreeNode node in Nodes)
            {
                node.Checked = Checked;

                if (node is FolderNode folder)
                {
                    folder.SetChildsCheckState();
                }
            }
        }

        public void SetFolderColor()
        {
            // Search in child webresource nodes
            if (Nodes.OfType<WebresourceNode>().Any(n => n.Resource.State == WebresourceState.Draft))
            {
                ForeColor = Color.Red;
            }
            else if (Nodes.OfType<WebresourceNode>().Any(n => n.Resource.State == WebresourceState.Saved))
            {
                ForeColor = Color.Blue;
            }
            // Search in subfolders
            else if (Nodes.OfType<FolderNode>().Any(n => n.ForeColor == Color.Red))
            {
                ForeColor = Color.Red;
            }
            else if (Nodes.OfType<FolderNode>().Any(n => n.ForeColor == Color.Blue))
            {
                ForeColor = Color.Blue;
            }
            else
            {
                ForeColor = Color.Black;
            }

            if (Parent is FolderNode parent)
            {
                parent.SetFolderColor();
            }
        }

        private void SetImageIndexes()
        {
            if (IsRoot)
            {
                ImageIndex = synced ? SyncedRootImageIndex : DraftRootImageIndex;
                SelectedImageIndex = synced ? SyncedRootImageIndex : DraftRootImageIndex;
            }
            else
            {
                ImageIndex = synced ? SyncedFolderImageIndex : DraftFolderImageIndex;
                SelectedImageIndex = synced ? SyncedFolderImageIndex : DraftFolderImageIndex;
            }
        }
    }
}