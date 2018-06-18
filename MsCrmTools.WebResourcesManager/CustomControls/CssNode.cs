using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class CssNode : WebresourceNode
    {
        private const int DraftImageIndex = 17;
        private const int SyncedImageIndex = 3;

        public CssNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}