using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class XslNode : WebresourceNode
    {
        private const int DraftImageIndex = 24;
        private const int SyncedImageIndex = 10;

        public XslNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}