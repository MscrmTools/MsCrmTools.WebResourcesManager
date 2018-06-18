using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MscrmTools.WebresourcesManager.AppCode
{
    internal class WebresourceMapper
    {
        private static WebresourceMapper instance;

        private WebresourceMapper()
        {
            Items.Add(new Map("htm", WebresourceType.WebPage, 1, "Webpage"));
            Items.Add(new Map("html", WebresourceType.WebPage, 1, "Webpage"));
            Items.Add(new Map("css", WebresourceType.Css, 2, "Style"));
            Items.Add(new Map("js", WebresourceType.Script, 3, "Script"));
            Items.Add(new Map("ts", WebresourceType.Script, 3, "Script"));
            Items.Add(new Map("map", WebresourceType.Script, 3, "Script"));
            Items.Add(new Map("xml", WebresourceType.Data, 4, "Data"));
            Items.Add(new Map("png", WebresourceType.Png, 5, "PNG"));
            Items.Add(new Map("jpg", WebresourceType.Jpg, 6, "JPG"));
            Items.Add(new Map("jpeg", WebresourceType.Jpg, 6, "JPG"));
            Items.Add(new Map("gif", WebresourceType.Gif, 7, "GIF"));
            Items.Add(new Map("xap", WebresourceType.Silverlight, 8, "Silverlight"));
            Items.Add(new Map("xsl", WebresourceType.Xsl, 9, "XSL"));
            Items.Add(new Map("xslt", WebresourceType.Xsl, 9, "XSL"));
            Items.Add(new Map("ico", WebresourceType.Ico, 10, "ICO"));
            Items.Add(new Map("svg", WebresourceType.Vector, 11, "Vector"));
            Items.Add(new Map("resx", WebresourceType.Resx, 12, "Resource"));
        }

        public static WebresourceMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WebresourceMapper();
                }

                return instance;
            }
        }

        public List<Map> Items { get; } = new List<Map>();
    }

    internal class Map
    {
        public Map(string extension, WebresourceType type, int crmValue, string label)
        {
            Extension = extension;
            Type = type;
            CrmValue = crmValue;
            Label = label;
        }

        public string Extension { get; }
        public WebresourceType Type { get; }
        public int CrmValue { get; }
        public string Label { get; }
    }
}