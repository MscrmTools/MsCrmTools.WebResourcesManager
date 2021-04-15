using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class ResxNode : WebresourceNode
    {
        private const int DraftImageIndex = 27;
        private const int SyncedImageIndex = 13;

        public ResxNode(Webresource resource, Settings settings) : base(resource, DraftImageIndex, SyncedImageIndex, settings)
        {
        }
    }
}