using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class VectorNode : WebresourceNode
    {
        private const int DraftImageIndex = 26;
        private const int SyncedImageIndex = 12;

        public VectorNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}