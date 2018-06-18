using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class IcoNode : WebresourceNode
    {
        private const int DraftImageIndex = 25;
        private const int SyncedImageIndex = 11;

        public IcoNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}