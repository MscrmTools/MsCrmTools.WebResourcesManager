using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class SilverlightNode : WebresourceNode
    {
        private const int DraftImageIndex = 23;
        private const int SyncedImageIndex = 9;

        public SilverlightNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}