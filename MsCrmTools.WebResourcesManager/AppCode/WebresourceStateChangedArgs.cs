using System;

namespace MsCrmTools.WebResourcesManager.AppCode
{
    public class WebresourceStateChangedArgs : EventArgs
    {
        public WebresourceStateChangedArgs(WebresourceState newState)
        {
            NewState = newState;
        }

        public WebresourceState NewState { get; private set; }
    }
}