using System;

namespace MscrmTools.WebresourcesManager.AppCode
{
    public partial class Webresource
    {
        public static WebresourceType GetTypeFromExtension(string extension)
        {
            switch (extension.ToLower())
            {
                case "html":
                case "htm":
                    return WebresourceType.WebPage;

                case "css":
                    return WebresourceType.Css;

                case "js":
                    return WebresourceType.Script;

                case "xml":
                    return WebresourceType.Data;

                case "png":
                    return WebresourceType.Png;

                case "jpg":
                case "jpeg":
                    return WebresourceType.Jpg;

                case "gif":
                    return WebresourceType.Gif;

                case "xap":
                    return WebresourceType.Silverlight;

                case "xsl":
                case "xslt":
                    return WebresourceType.Xsl;

                case "ico":
                    return WebresourceType.Ico;

                case "svg":
                    return WebresourceType.Vector;

                case "resx":
                    return WebresourceType.Resx;
            }

            throw new ArgumentException(@"Field extension cannot be mapped to a webresource type", nameof(extension));
        }

        public static bool IsValidExtension(string ext)
        {
            ext = ext.StartsWith(".") ? ext.Remove(0, 1).ToLower() : ext.ToLower();
            return ValidExtensions.Contains(ext);
        }

        public static bool SkipErrorForInvalidExtension(string ext)
        {
            ext = ext.StartsWith(".") ? ext.Remove(0, 1).ToLower() : ext.ToLower();
            return ValidExtensions.Contains(ext) || (Settings.Instance.PushTsMapFiles && ExtensionsToSkipLoadingErrorMessage.Contains(ext));
        }
    }
}