// PROJECT : MsCrmTools.WebResourcesManager
// This project was developed by Tanguy Touzard
// CODEPLEX: http://xrmtoolbox.codeplex.com
// BLOG: http://mscrmtools.blogspot.com

using System;
using MsCrmTools.WebResourcesManager.AppCode;

namespace MsCrmTools.WebResourcesManager.UserControls
{
    internal interface IWebResourceControl
    {
        string GetBase64WebResourceContent();

        WebResource Resource { get; }

        Enumerations.WebResourceType GetWebResourceType();

        void ReplaceWithNewFile(string filename);

        event EventHandler<WebResourceUpdatedEventArgs> WebResourceUpdated;
    }
}