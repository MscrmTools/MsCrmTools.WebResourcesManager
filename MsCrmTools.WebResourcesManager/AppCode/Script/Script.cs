using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Xml;

namespace MsCrmTools.WebResourcesManager.AppCode.Script
{
    public enum ScriptAction
    {
        None,
        Create,
        Update,
        Delete
    }

    public class Script
    {
        #region Properties

        public ScriptAction Action { get; set; } = ScriptAction.None;
        public string Attribute { get; set; }
        public string AttributeLogicalName { get; set; }
        public bool? Enabled { get; set; }
        public string EntityLogicalName { get; set; }
        public string EntityName { get; set; }
        public string Event { get; set; }
        public string FormState { get; set; }
        public string FormType { get; internal set; }
        public bool HasProblem { get; set; }
        public string ItemAttribute => Type.Contains("Homepage") ? "eventsxml" : Type.Contains("Icon") ? "layoutxml" : "formxml";
        public string ItemName { get; set; }
        public string ItemUpdateAttribute => Type.Contains("Homepage") ? "updatedeventsxml" : Type.Contains("Icon") ? "updatedlayoutxml" : "updatedformxml";
        public string Library { get; set; }
        public string MethodCalled { get; set; }
        public bool? NewEnabled { get; set; }
        public string NewLibrary { get; set; }
        public string NewMethodCalled { get; set; }
        public int? NewOrder { get; internal set; }
        public string NewParameters { get; set; }
        public bool? NewPassExecutionContext { get; set; }
        public int Order { get; internal set; }
        public string Parameters { get; set; }
        public bool? PassExecutionContext { get; set; }

        public string Problem { get; internal set; }

        public bool RequiresUpdate =>
                    !string.IsNullOrEmpty(NewParameters) && NewParameters != Parameters
            || !string.IsNullOrEmpty(NewMethodCalled) && NewMethodCalled != MethodCalled
            || UiItem != null && UiItem.Contains(ItemUpdateAttribute) &&
            UiItem.GetAttributeValue<string>(ItemUpdateAttribute) != UiItem.GetAttributeValue<string>(ItemAttribute)
            || NewEnabled.HasValue && NewEnabled.Value != (Enabled ?? false)
            || NewPassExecutionContext.HasValue && NewPassExecutionContext.Value !=
            (PassExecutionContext ?? false)
            || NewOrder.HasValue && NewOrder.Value != Order
            || !string.IsNullOrEmpty(NewLibrary) &&
            NewLibrary.ToLower() != Library.ToLower();

        public string Type { get; set; }
        public Entity UiItem { get; set; }
        public string UpdateErrorMessage { get; set; }

        #endregion Properties

        #region Method

        public void ProcessChanges()
        {
            var xml = UiItem.GetAttributeValue<string>(ItemUpdateAttribute) ?? UiItem.GetAttributeValue<string>(ItemAttribute);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            if (Type == "Form event" || Type == "Subgrid event")
            {
                if (Action == ScriptAction.Create)
                {
                    XmlNode eventNode = null;
                    XmlNode eventsNode;

                    if (Event == "ontabstatechange")
                    {
                        var tabNode = doc.SelectSingleNode("//tab[@id='" + AttributeLogicalName + "']");
                        if (tabNode == null)
                        {
                            throw new Exception($"Unable to find tab Node with id {AttributeLogicalName}");
                        }

                        eventsNode = tabNode.GetOrCreateNode("events");
                        eventNode = eventsNode.SelectSingleNode("event[@application='false' and @name='tabstatechange']");
                    }
                    else
                    {
                        eventsNode = doc.FirstChild.GetOrCreateNode("events");

                        if (Event == "onchange")
                        {
                            if (Type == "Form event")
                            {
                                eventNode = eventsNode.SelectSingleNode(
                                    "event[@application='false' and @name='onchange' and @attribute='" +
                                    AttributeLogicalName + "']");
                            }
                            else
                            {
                                var parts = AttributeLogicalName.Split(':');
                                eventNode = eventsNode.SelectSingleNode(
                                    "event[@application='false' and @name='onchange' and @attribute='" +
                                    parts[1] + "' and @control='" + parts[0] + "']");
                            }
                        }
                        else if (Event == "onload" || Event == "onsave" || Event == "onrecordselect")
                        {
                            if (Type == "Form event")
                            {
                                eventNode = eventsNode.SelectSingleNode(
                                    "event[@application='false' and @name='" + Event + "']");
                            }
                            else
                            {
                                eventNode = eventsNode.SelectSingleNode(
                                    "event[@application='false' and @name='" + Event + "' and @control='" +
                                    AttributeLogicalName + "']");
                            }
                        }
                    }

                    if (eventNode == null)
                    {
                        eventNode = eventsNode.AppendNewNode("event",
                            new Dictionary<string, string>
                            {
                                {"name", Event == "ontabstatechange" ? "tabstatechange" : Event},
                                {"application","false"},
                                {"active","false"}
                            }
                        );

                        if (Type == "Form event" && Event == "onchange")
                        {
                            eventNode.AddAttribute("attribute", AttributeLogicalName);
                        }

                        if (Type == "Subgrid event")
                        {
                            var parts = AttributeLogicalName.Split(':');

                            eventNode.AddAttribute("relationship", "");
                            eventNode.AddAttribute("control", parts[0]);

                            if (Event == "onchange")
                            {
                                eventNode.AddAttribute("attribute", parts[1]);
                            };
                        }

                        eventsNode.AppendChild(eventNode);
                    }

                    var handlersNode = eventNode.GetOrCreateNode("Handlers");

                    handlersNode.AppendNewNodeAtIndex("Handler",
                        new Dictionary<string, string>
                        {
                            {"functionName", MethodCalled},
                            {"libraryName", Library},
                            {"handlerUniqueId", Guid.NewGuid().ToString("B").ToLower()},
                            {"enabled", (Enabled ?? false).ToString().ToLower()},
                            {"parameters", Parameters},
                            {"passExecutionContext", (PassExecutionContext ?? false).ToString().ToLower()}
                        },
                        NewOrder ?? Order);
                }
            }
            else if (Type == "Form Library")
            {
                if (Action == ScriptAction.Create)
                {
                    var librariesNode = doc.FirstChild.GetOrCreateNode("formLibraries");

                    if (librariesNode.SelectSingleNode("Library[@name='" + Library + "']") == null)
                    {
                        librariesNode.AppendNewNodeAtIndex("Library",
                            new Dictionary<string, string>
                            {
                            {"name", Library},
                            {"libraryUniqueId", Guid.NewGuid().ToString("B").ToLower()},
                            }, NewOrder ?? Order);
                    }
                }
            }
            else if (Type == "Homepage Grid event")
            {
                if (Action == ScriptAction.Create)
                {
                    XmlNode eventNode = null;
                    XmlNode eventsNode = doc.FirstChild.GetOrCreateNode("events");

                    if (Event == "onchange")
                    {
                        eventNode = eventsNode.SelectSingleNode(
                            "event[@application='false' and @name='onchange' and @attribute='" +
                            AttributeLogicalName + "']");
                    }
                    else if (Event == "onsave" || Event == "onrecordselect")
                    {
                        eventNode = eventsNode.SelectSingleNode(
                            "event[@application='false' and @name='" + Event + "']");
                    }

                    if (eventNode == null)
                    {
                        eventNode = eventsNode.AppendNewNode("event",
                            new Dictionary<string, string>
                            {
                                {"name",Event.ToLower() },
                                {"application","false" },
                                {"active","false" },
                                {"control","Grids" },
                                {"relationship","" }
                            }
                        );

                        if (Event == "onchange")
                        {
                            eventNode.AddAttribute("attribute", AttributeLogicalName);
                        }
                    }

                    var handlersNode = eventNode.GetOrCreateNode("Handlers");
                    handlersNode.AppendNewNodeAtIndex("Handler",
                        new Dictionary<string, string>
                        {
                            {"functionName", MethodCalled},
                            {"libraryName", Library},
                            {"handlerUniqueId", Guid.NewGuid().ToString("B").ToLower()},
                            {"enabled", (Enabled ?? false).ToString().ToLower()},
                            {"parameters", Parameters},
                            {"passExecutionContext", (PassExecutionContext ?? false).ToString().ToLower()}
                        },
                        NewOrder ?? Order
                    );
                }
            }
            else if (Type == "Homepage Grid Library")
            {
                if (Action == ScriptAction.Create)
                {
                    var formLibrariesNode = doc.FirstChild.GetOrCreateNode("formLibraries");
                    formLibrariesNode.AppendNewNodeAtIndex("Library",
                        new Dictionary<string, string>
                        {
                            {"name", Library },
                            {"libraryUniqueId", Guid.NewGuid().ToString("B").ToLower() }
                        },
                        NewOrder ?? Order
                    );
                }
            }
            else if (Type == "Grid Icon")
            {
                var node = doc.DocumentElement?.SelectSingleNode("row/cell[@name='" + AttributeLogicalName + "']");
                if (node == null)
                {
                    throw new Exception($"Unable to find cell node for attribute {AttributeLogicalName}");
                }

                if (Action == ScriptAction.Update || Action == ScriptAction.Create)
                {
                    if (!string.IsNullOrEmpty(NewLibrary))
                    {
                        if (node.Attributes["imageproviderwebresource"] == null)
                        {
                            node.AddAttribute("imageproviderwebresource", $"$webresource:{NewLibrary}");
                        }
                        else
                        {
                            node.Attributes["imageproviderwebresource"].Value = $"$webresource:{NewLibrary}";
                        }
                    }

                    if (!string.IsNullOrEmpty(NewMethodCalled))
                    {
                        if (node.Attributes["imageproviderfunctionname"] == null)
                        {
                            node.AddAttribute("imageproviderfunctionname", NewMethodCalled);
                        }
                        else
                        {
                            node.Attributes["imageproviderfunctionname"].Value = NewMethodCalled;
                        }
                    }
                }
            }
            else
            {
                return;
            }

            UiItem[ItemUpdateAttribute] = doc.OuterXml;
        }

        #endregion Method
    }
}