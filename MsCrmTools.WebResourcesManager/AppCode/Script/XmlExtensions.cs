using System.Collections.Generic;
using System.Xml;

namespace MsCrmTools.WebResourcesManager.AppCode.Script
{
    public static class XmlExtensions
    {
        public static void AddAttribute(this XmlNode node, string name, string value)
        {
            if (node.OwnerDocument == null) return;
            if (node.Attributes == null) return;

            var attr = node.OwnerDocument.CreateAttribute(name);
            attr.Value = value;
            node.Attributes.Append(attr);
        }

        public static XmlNode AppendNewNode(this XmlNode node, string name, Dictionary<string, string> attributes)
        {
            if (node.OwnerDocument == null) return null;

            var newNode = node.OwnerDocument.CreateElement(name);

            foreach (var key in attributes.Keys)
            {
                var attr = node.OwnerDocument.CreateAttribute(key);
                attr.Value = attributes[key];
                newNode.Attributes.Append(attr);
            }

            node.AppendChild(newNode);

            return newNode;
        }

        public static XmlNode AppendNewNodeAtIndex(this XmlNode node, string name, Dictionary<string, string> attributes, int index)
        {
            if (node.OwnerDocument == null) return null;

            var newNode = node.OwnerDocument.CreateElement(name);

            foreach (var key in attributes.Keys)
            {
                var attr = node.OwnerDocument.CreateAttribute(key);
                attr.Value = attributes[key];
                newNode.Attributes.Append(attr);
            }

            if (node.ChildNodes.Count >= index)
            {
                var previousNode = node.ChildNodes[index - 1];
                node.InsertAfter(newNode, previousNode);
            }
            else
            {
                node.AppendChild(newNode);
            }

            return newNode;
        }

        public static XmlNode GetOrCreateNode(this XmlNode node, string nodeName)
        {
            var searchedNode = node.SelectSingleNode(nodeName);
            if (searchedNode == null)
            {
                if (node.OwnerDocument == null) return null;
                searchedNode = node.OwnerDocument.CreateElement(nodeName);
                node.AppendChild(searchedNode);
            }

            return searchedNode;
        }
    }
}