using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.CustomControls
{
    internal class JavaScriptNode : WebresourceNode
    {
        private const int DraftImageIndex = 18;
        private const int SyncedImageIndex = 4;

        public JavaScriptNode(Webresource resource, Settings settings) : base(resource, DraftImageIndex, SyncedImageIndex, settings)
        {
        }
    }
}