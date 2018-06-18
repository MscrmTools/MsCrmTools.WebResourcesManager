using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class DataNode : WebresourceNode
    {
        private const int DraftImageIndex = 19;
        private const int SyncedImageIndex = 5;

        public DataNode(Webresource resource) : base(resource, DraftImageIndex, SyncedImageIndex)
        {
        }
    }
}