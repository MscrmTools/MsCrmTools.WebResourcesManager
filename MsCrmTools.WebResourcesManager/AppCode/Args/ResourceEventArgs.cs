using System;

namespace MscrmTools.WebresourcesManager.AppCode.Args
{
    public class ResourceEventArgs : EventArgs
    {
        public ResourceEventArgs(Webresource resource)
        {
            Resource = resource;
        }

        public Webresource Resource { get; }
    }
}