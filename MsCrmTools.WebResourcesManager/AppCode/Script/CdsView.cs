using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace MsCrmTools.WebResourcesManager.AppCode.Script
{
    public class CdsView : IUiUtem
    {
        private readonly XmlDocument _doc;
        private readonly EntityMetadata _emd;

        public CdsView(Entity view, EntityMetadata emd)
        {
            Item = view;
            _emd = emd;

            var xml = Item.GetAttributeValue<string>("layoutxml");
            _doc = new XmlDocument();
            _doc.LoadXml(xml);
        }

        public string Entity => Item.GetAttributeValue<string>("returnedtypecode");
        public Entity Item { get; }

        public List<string> Libraries => _doc.SelectNodes("//cell")?.Cast<XmlNode>()
            .Select(n => n.Attributes?["imageproviderwebresource"]?.Value.Split(':').Last()).Distinct().ToList();

        public List<CdsFormControl> GetControls(int userLcid)
        {
            var returnedControls = new List<CdsFormControl>();
            var nodes = _doc.DocumentElement?.SelectNodes("row/cell");
            if (nodes == null) return returnedControls;

            foreach (XmlNode node in nodes)
            {
                if (node.Attributes?["name"].Value.IndexOf('.') > 0)
                    continue;

                var attr = _emd.Attributes.First(a => a.LogicalName == node.Attributes?["name"].Value);

                returnedControls.Add(new CdsFormControl { Name = attr.DisplayName?.UserLocalizedLabel?.Label, Id = attr.LogicalName, Type = CdsFormControlType.View });
            }

            return returnedControls;
        }

        public override string ToString()
        {
            return $"View : {Item.GetAttributeValue<string>("name")}";
        }
    }
}