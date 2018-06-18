using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class WebpageNode : WebresourceNode
    {
        private const int DraftImageIndex = 16;
        private const int SyncedImageIndex = 2;

        public WebpageNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}