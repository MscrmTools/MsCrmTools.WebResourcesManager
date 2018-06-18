using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class JpgNode : WebresourceNode
    {
        private const int DraftImageIndex = 20;
        private const int SyncedImageIndex = 6;

        public JpgNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}