using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace MsCrmTools.WebResourcesManager.AppCode.Script
{
    public class CdsHomePageGrid : IUiUtem
    {
        private readonly XmlDocument _doc;

        public CdsHomePageGrid(Entity homePageGrid)
        {
            Item = homePageGrid;

            var xml = Item.GetAttributeValue<string>("eventsxml");
            _doc = new XmlDocument();

            if (xml == null)
            {
                xml = "<customControlDefaultConfig></customControlDefaultConfig>";
                Item["eventsxml"] = xml;
            }
            _doc.LoadXml(xml);
        }

        public string Entity => Item.GetAttributeValue<string>("primaryentitytypecode");
        public Entity Item { get; }

        public List<string> Libraries => _doc.SelectNodes("//formLibraries/Library")?.Cast<XmlNode>()
            .Select(n => n.Attributes?["name"].Value).ToList();

        public List<CdsFormControl> GetControls(int userLcid)
        {
            var returnedControls = new List<CdsFormControl>
            {
                new CdsFormControl {Name = "Homepage Grid", Id = "Homepage Grid", Type = CdsFormControlType.HomepageGrid}
            };

            return returnedControls;
        }

        public override string ToString()
        {
            return "Homepage Grid";
        }
    }
}