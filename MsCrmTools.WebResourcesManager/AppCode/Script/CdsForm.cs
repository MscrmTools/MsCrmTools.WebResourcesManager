using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace MsCrmTools.WebResourcesManager.AppCode.Script
{
    public class CdsForm : IUiUtem
    {
        private readonly XmlDocument _doc;

        public CdsForm(Entity form)
        {
            Item = form;

            var xml = Item.GetAttributeValue<string>("formxml");
            _doc = new XmlDocument();
            _doc.LoadXml(xml);
        }

        public Entity Item { get; }

        public List<string> Libraries => _doc.SelectNodes("//formLibraries/Library")?.Cast<XmlNode>()
            .Select(n => n.Attributes?["name"].Value).ToList();

        public List<CdsFormControl> GetControls(int userLcid)
        {
            var returnedControls = new List<CdsFormControl>
            {
                new CdsFormControl {Name = "Form", Id = "Form", Type = CdsFormControlType.Form}
            };

            var tabs = _doc.SelectNodes("//tab");
            if (tabs != null)
            {
                foreach (XmlNode tabNode in tabs)
                {
                    if (tabNode.Attributes == null) continue;

                    returnedControls.Add(new CdsFormControl
                    {
                        Id = tabNode.Attributes["id"].Value,
                        Name = tabNode.Attributes["name"]?.Value ?? tabNode.SelectSingleNode("labels/label[@languagecode='" + userLcid + "']")?.Attributes?[
                                   "description"]?.Value ?? "N/A",
                        Type = CdsFormControlType.Tab
                    });
                }
            }

            var controls = _doc.SelectNodes("//control");
            if (controls == null) return returnedControls;

            foreach (XmlNode controlNode in controls)
            {
                if (controlNode.Attributes == null) continue;
                if (returnedControls.Any(c => c.Id == controlNode.Attributes["id"].Value)) continue;

                returnedControls.Add(new CdsFormControl
                {
                    Name = controlNode.ParentNode?.SelectSingleNode("labels/label[@languagecode='" + userLcid + "']")?.Attributes?[
                    "description"]?.Value ?? "N/A",
                    Id = controlNode.Attributes["id"].Value,
                    Type = controlNode.Attributes["classid"].Value == "{E7A81278-8635-4d9e-8D4D-59480B391C5B}" || controlNode.Attributes["indicationOfSubgrid"] != null && controlNode.Attributes["indicationOfSubgrid"].Value == "true" ? CdsFormControlType.Grid : CdsFormControlType.Attribute
                });
            }

            return returnedControls;
        }

        public override string ToString()
        {
            return $"Form: {Item.GetAttributeValue<string>("name")}";
        }
    }
}