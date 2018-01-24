using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using MsCrmTools.WebResourcesManager.AppCode;

namespace MsCrmTools.WebResourcesManager.Forms
{
    public partial class DependencyDialog : Form
    {
        private readonly WebResource resource;
        private readonly List<WebResource> allResources;

        public DependencyDialog(WebResource resource, List<WebResource> allResources)
        {
            this.resource = resource;
            this.allResources = allResources;

            InitializeComponent();
        }

        private void DependencyDialog_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Overflow = ToolStripItemOverflow.Never;
            toolStripComboBox1.Overflow = ToolStripItemOverflow.Never;

            toolStripComboBox1.Items.AddRange(allResources.ToArray());
            toolStripComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (!string.IsNullOrEmpty(resource.DependencyXml))
            {
                var xDoc = XDocument.Parse(resource.DependencyXml);

                foreach (XElement elt in xDoc.Descendants("Library"))
                {
                    var name = elt.Attribute("name")?.Value;
                    var displayName = elt.Attribute("displayName")?.Value;
                    var languageCode = elt.Attribute("languagecode")?.Value;
                    var description = elt.Attribute("description")?.Value;

                    var foundResource = allResources.First(r => r.ToString() == name);

                    var item = new ListViewItem(name) { Tag = foundResource };
                    item.SubItems.Add(displayName);
                    item.SubItems.Add(string.IsNullOrEmpty(languageCode)
                        ? ""
                        : CultureInfo.GetCultureInfo(int.Parse(languageCode)).EnglishName);
                    item.SubItems.Add(description);
                    lvDependencies.Items.Add(item);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var doc = new XDocument(
                new XElement("Dependencies",
                    new XElement("Dependency",
                        new XAttribute("componentType", "WebResource"),
                        lvDependencies.Items.Cast<ListViewItem>().Select(i =>
                            new XElement("Library",
                                new XAttribute("name", ((WebResource)i.Tag).ToString()),
                                new XAttribute("displayName",
                                    ((WebResource)i.Tag).Entity.GetAttributeValue<string>("displayname") ?? ""),
                                new XAttribute("languagecode",
                                    ((WebResource)i.Tag).Entity.GetAttributeValue<int>("languagecode") == 0 ? "" : ((WebResource)i.Tag).Entity.GetAttributeValue<int>("languagecode").ToString()),
                                new XAttribute("description",
                                    ((WebResource)i.Tag).Entity.GetAttributeValue<string>("description") ?? "")
                            )
                        )
                    )
                )
            );

            resource.DependencyXml = doc.ToString();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem == null)
            {
                return;
            }

            var text = toolStripComboBox1.SelectedItem.ToString();
            var addedResource = allResources.First(r => r.ToString() == text);

            if (lvDependencies.Items.Cast<ListViewItem>().All(i => i.Text != text))
            {
                var item = new ListViewItem(text) { Tag = addedResource };
                item.SubItems.Add(addedResource.Entity.GetAttributeValue<string>("displayname"));
                item.SubItems.Add(addedResource.Entity.GetAttributeValue<int>("languagecode") == 0 ? "" : CultureInfo.GetCultureInfo(addedResource.Entity.GetAttributeValue<int>("languagecode")).EnglishName);
                item.SubItems.Add(addedResource.Entity.GetAttributeValue<string>("description"));
                lvDependencies.Items.Add(item);
            }

            btnOK.Enabled = true;
        }

        private void tsbRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvDependencies.SelectedItems)
            {
                lvDependencies.Items.Remove(item);

                btnOK.Enabled = true;
            }
        }
    }
}