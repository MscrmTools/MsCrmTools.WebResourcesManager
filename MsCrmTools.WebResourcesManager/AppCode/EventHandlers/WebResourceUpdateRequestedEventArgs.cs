using MsCrmTools.WebResourcesManager.Forms;
using System.Collections.Generic;

namespace MsCrmTools.WebResourcesManager.AppCode.EventHandlers
{
    public class WebResourceUpdateRequestedEventArgs
    {
        public List<WebResource> WebResources { get; set; }

        public WebResourceUpdateOption Action { get; set; }
    }
}