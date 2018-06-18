using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class DependencyDialog : Form
    {
        private string dependencyXml;
        private readonly MyPluginControl mainControl;
        private readonly bool isCompatible;

        public DependencyDialog(Webresource resource, MyPluginControl control)
        {
            dependencyXml = resource.DependencyXml;
            isCompatible = resource.Plugin.GetOrgMajorVersion() >= 9;
            mainControl = control;

            InitializeComponent();
        }

        public string UpdatedDependencyXml => dependencyXml;

        private void DependencyDialog_Load(object sender, EventArgs e)
        {
            if (!isCompatible)
            {
                MessageBox.Show(this, @"This property can be edited only with Microsoft Dynamics 365 v9+", @"Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            toolStripLabel1.Overflow = ToolStripItemOverflow.Never;
            toolStripComboBox1.Overflow = ToolStripItemOverflow.Never;

            toolStripComboBox1.Items.AddRange(mainControl.WebresourcesCache.ToArray());
            toolStripComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            toolStripComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (!string.IsNullOrEmpty(dependencyXml))
            {
                var xDoc = XDocument.Parse(dependencyXml);

                foreach (XElement elt in xDoc.Descendants("Library"))
                {
                    var name = elt.Attribute("name")?.Value;
                    var displayName = elt.Attribute("displayName")?.Value;
                    var languageCode = elt.Attribute("languagecode")?.Value;
                    var description = elt.Attribute("description")?.Value;

                    var foundResource = mainControl.WebresourcesCache.First(r => r.ToString() == name);

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
                                new XAttribute("name", ((Webresource)i.Tag).ToString()),
                                new XAttribute("displayName",
                                    ((Webresource)i.Tag).DisplayName ?? ""),
                                new XAttribute("languagecode",
                                    ((Webresource)i.Tag).LanguageCode == 0 ? "" : ((Webresource)i.Tag).LanguageCode.ToString()),
                                new XAttribute("description",
                                    ((Webresource)i.Tag).Description ?? ""),
                                new XAttribute("libraryUniqueId", Guid.NewGuid().ToString("B"))
                            )
                        )
                    )
                )
            );

            dependencyXml = doc.ToString();
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
            var addedResource = mainControl.WebresourcesCache.First(r => r.ToString() == text);

            if (lvDependencies.Items.Cast<ListViewItem>().All(i => i.Text != text))
            {
                var item = new ListViewItem(text) { Tag = addedResource };
                item.SubItems.Add(addedResource.DisplayName);
                item.SubItems.Add(addedResource.LanguageCode == 0 ? "" : CultureInfo.GetCultureInfo(addedResource.LanguageCode ?? 1033).EnglishName);
                item.SubItems.Add(addedResource.Description);
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