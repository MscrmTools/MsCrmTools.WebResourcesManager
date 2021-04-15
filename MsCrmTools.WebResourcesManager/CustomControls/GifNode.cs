using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class GifNode : WebresourceNode
    {
        private const int DraftImageIndex = 20;
        private const int SyncedImageIndex = 6;

        public GifNode(Webresource resource, Settings settings) : base(resource, DraftImageIndex, SyncedImageIndex, settings)
        {
        }
    }
}