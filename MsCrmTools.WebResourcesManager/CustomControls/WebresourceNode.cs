using MscrmTools.WebresourcesManager.AppCode;
using MscrmTools.WebresourcesManager.AppCode.Args;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    public class WebresourceNode : TreeNode
    {
        private readonly int draftImageIndex;
        private readonly int syncedImageIndex;

        public WebresourceNode(Webresource resource, int draftImageIndex, int syncedImageIndex)
        {

            this.draftImageIndex = draftImageIndex;
            this.syncedImageIndex = syncedImageIndex;

            Resource = resource;
            Resource.StateChanged += Resource_StateChanged;

            ImageIndex = Resource.Synced ? syncedImageIndex : draftImageIndex;
            SelectedImageIndex = Resource.Synced ? syncedImageIndex : draftImageIndex;
            Text = resource.Name.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries).Last();
            if (resource.HasExtensionlessMappingFile && Settings.Instance.SyncMatchingJsFilesAsExtensionless)
            {
                Text = System.IO.Path.GetFileNameWithoutExtension(Text ?? string.Empty);
            }
            Name = Text;
        }

        public Webresource Resource { get; }

        private void Resource_StateChanged(object sender, StateEventArgs e)
        {
            ((Webresource)sender).Node.TreeView.Invoke(new Action(() =>
            {
                ImageIndex = Resource.Synced ? syncedImageIndex : draftImageIndex;
                SelectedImageIndex = Resource.Synced ? syncedImageIndex : draftImageIndex;

                ForeColor = e.State == WebresourceState.Saved ? Color.Blue :
                    e.State == WebresourceState.Draft ? Color.Red : Color.Black;

                (Parent as FolderNode)?.SetFolderColor();
            }));
        }
    }
}