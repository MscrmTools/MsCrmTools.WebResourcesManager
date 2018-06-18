using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class PngNode : WebresourceNode
    {
        private const int DraftImageIndex = 20;
        private const int SyncedImageIndex = 6;

        public PngNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}