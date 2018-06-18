using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using MscrmTools.WebresourcesManager.AppCode.Args;
using MscrmTools.WebresourcesManager.AppCode.Editors;
using MscrmTools.WebresourcesManager.AppCode.Exceptions;
using MscrmTools.WebresourcesManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.AppCode
{
    public enum WebresourceState
    {
        New,
        Draft,
        Saved,
        None
    }

    public enum WebresourceType
    {
        WebPage = 1,
        Css = 2,
        Script = 3,
        Data = 4,
        Png = 5,
        Jpg = 6,
        Gif = 7,
        Silverlight = 8,
        Xsl = 9,
        Ico = 10,
        Vector = 11,
        Resx = 12,
        Auto = 99
    }

    public partial class Webresource
    {
        #region Variables

        private readonly DateTime loadedOn;
        private string filePath;
        private Entity record;
        private WebresourceState state;
        private string stringContent;
        private string updatedBase64Content;
        private string updatedStringContent;

        #endregion Variables

        #region Constructors

        public Webresource(string name, string filePath, WebresourceType type, MyPluginControl parent)
        {
            Map extMap = null;

            if (type == WebresourceType.Auto)
            {
                var extension = Path.GetExtension(filePath);

                extMap = WebresourceMapper.Instance.Items.FirstOrDefault(i => i.Extension == extension?.Remove(0, 1).ToLower());
                if (extMap != null)
                {
                    type = extMap.Type;
                }
            }

            record = new Entity("webresource")
            {
                ["name"] = name,
                ["webresourcetype"] = new OptionSetValue((int)type),
            };

            if (filePath == null)
            {
                stringContent = string.Empty;
            }
            else
            {
                record["content"] = Convert.ToBase64String(File.ReadAllBytes(filePath));
                stringContent = GetPlainText();
            }

            var map = extMap ?? WebresourceMapper.Instance.Items.FirstOrDefault(i => i.CrmValue == (int)type);
            if (map != null)
            {
                record.FormattedValues["webresourcetype"] = map.Label;
            }

            this.filePath = filePath;
            State = WebresourceState.None;
            loadedOn = DateTime.Now;
            Plugin = parent;

            LoadAssociatedResources();
        }

        public Webresource(Entity record, MyPluginControl parent)
        {
            this.record = record;

            stringContent = GetPlainText();
            updatedStringContent = stringContent;

            Synced = true;
            State = WebresourceState.None;
            loadedOn = DateTime.Now;
            Plugin = parent;
        }

        public Webresource(string filePath, MyPluginControl parent)
        {
            var fi = new FileInfo(filePath);

            var resourceName = string.Empty;
            var parts = fi.FullName.Split('\\');
            for (var i = parts.Length - 1; i >= 0; i--)
            {
                resourceName = resourceName == string.Empty ? parts[i] : $"{parts[i]}/{resourceName}";

                if (parts[i].EndsWith("_")) break;
            }

            // If the same, then we did not find any root folder
            // similar to a customization prefix and the file does
            // not come from a locally saved web resources list
            if (resourceName.Replace("/", "\\") == fi.FullName)
            {
                resourceName = fi.Name;
            }

            record = new Entity("webresource")
            {
                ["name"] = resourceName,
                ["webresourcetype"] = new OptionSetValue((int)GetTypeFromExtension(fi.Extension.Remove(0, 1))),
                ["content"] = Convert.ToBase64String(File.ReadAllBytes(filePath))
            };

            stringContent = GetPlainText();

            var map = WebresourceMapper.Instance.Items.FirstOrDefault(i => i.Extension.ToLower() == Path.GetExtension(filePath).ToLower().Remove(0, 1));
            if (map != null)
            {
                record.FormattedValues["webresourcetype"] = map.Label;
            }

            State = WebresourceState.None;
            loadedOn = DateTime.Now;
            Plugin = parent;
            this.filePath = filePath;

            LoadAssociatedResources();
        }

        #endregion Constructors

        #region Properties

        [Browsable(false)]
        public List<Webresource> AssociatedResources { get; set; }

        [Browsable(false)]
        public string Content
        {
            get => record?.GetAttributeValue<string>("content");
            set
            {
                record["content"] = value;
                State = WebresourceState.Draft;
            }
        }

        [Category("Dates")]
        [DisplayName("Created By")]
        [Description("User who created this webresource")]
        [ReadOnly(true)]
        public string CreatedBy => record.GetAttributeValue<EntityReference>("createdby")?.Id.ToString("B");

        [Category("Dates")]
        [DisplayName("Created On")]
        [Description("Date of creation")]
        [ReadOnly(true)]
        public string CreatedOn => record.Contains("createdon") ? record.FormattedValues["createdon"] : "";

        [Category("Attributes")]
        [DisplayName("Dependencies")]
        [Description("List of dependencies for this webresource")]
        [Editor(typeof(DependencyXmlEditor), typeof(UITypeEditor))]
        public string DependencyXml
        {
            get => record?.GetAttributeValue<string>("dependencyxml");
            set
            {
                record["dependencyxml"] = value;
                State = WebresourceState.Saved;
            }
        }

        [Category("Attributes")]
        [DisplayName("Description")]
        [Description("Description of the webresource")]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Description
        {
            get => record?.GetAttributeValue<string>("description");
            set
            {
                record["description"] = value;
                State = WebresourceState.Saved;
            }
        }

        [Category("Attributes")]
        [DisplayName("Display name")]
        [Description("Display name of the webresource")]
        public string DisplayName
        {
            get => record?.GetAttributeValue<string>("displayname");
            set
            {
                record["displayname"] = value;
                State = WebresourceState.Saved;
            }
        }

        [Category("Properties")]
        [DisplayName("File path")]
        [Description("Location of the webresource on disk")]
        [ReadOnly(true)]
        public string FilePath
        {
            get => filePath;
            set
            {
                filePath = value;
                SavedToDisk?.Invoke(this, new ResourceEventArgs(this));
            }
        }

        [Category("Attributes")]
        [DisplayName("Type")]
        [Description("Type of the webresource")]
        [ReadOnly(true)]
        public string FormattedType => record?.FormattedValues["webresourcetype"];

        [Category("Attributes")]
        [DisplayName("Unique identifier")]
        [Description("Unique identifier of the webresource")]
        [ReadOnly(true)]
        public Guid Id => record?.Id ?? Guid.Empty;

        [Category("Attributes")]
        [DisplayName("Language code")]
        [Description("Language of the web resource")]
        public int? LanguageCode
        {
            get => record?.GetAttributeValue<int>("languagecode") == 0 ? null : record?.GetAttributeValue<int>("languagecode");
            set
            {
                if (value == 0)
                {
                    record["languagecode"] = null;
                }
                else
                {
                    record["languagecode"] = value;
                }
                State = WebresourceState.Saved;
            }
        }

        [Browsable(false)]
        public Exception LastException { get; set; }

        [Category("Dates")]
        [DisplayName("Loaded on")]
        [Description("Date when this webresource was loaded in Webresources Manager")]
        [ReadOnly(true)]
        public string LoadedOn => loadedOn.ToString(CultureInfo.CurrentUICulture);

        [Category("Dates")]
        [DisplayName("Modified By")]
        [Description("User who last modified this webresource")]
        [ReadOnly(true)]
        public string ModifiedBy => record.GetAttributeValue<EntityReference>("modifiedby")?.Id.ToString("B");

        [Category("Dates")]
        [DisplayName("Modified On")]
        [Description("Date of last update")]
        [ReadOnly(true)]
        public string ModifiedOn => record.Contains("modifiedon") ? record.FormattedValues["modifiedon"] : "";

        [Category("Attributes")]
        [DisplayName("Name")]
        [Description("Name of the webresource")]
        [ReadOnly(true)]
        public string Name
        {
            get => record?.GetAttributeValue<string>("name");
            set
            {
                record["name"] = value;
                State = WebresourceState.Saved;
            }
        }

        [Browsable(false)]
        public TreeNode Node { get; set; }

        [Browsable(false)]
        public MyPluginControl Plugin { get; }

        [Category("Properties")]
        [DisplayName("State")]
        [Description("State of the webresource in this XrmToolBox plugin")]
        [ReadOnly(true)]
        public WebresourceState State
        {
            get => state;
            private set
            {
                state = value;
                StateChanged?.Invoke(this, new StateEventArgs(value));
            }
        }

        [Browsable(false)]
        public string StringContent => stringContent;

        [Category("Properties")]
        [DisplayName("Synced")]
        [Description("Defines if this webresource is synced between this XrmToolBox plugin and the connected organization")]
        [ReadOnly(true)]
        public bool Synced { get; set; }

        [Browsable(false)]
        public int Type => record?.GetAttributeValue<OptionSetValue>("webresourcetype")?.Value ?? 0;

        [Browsable(false)]
        public string UpdatedStringContent
        {
            get => updatedStringContent;
            set
            {
                updatedStringContent = value;
                updatedBase64Content = Convert.ToBase64String(Encoding.UTF8.GetBytes(updatedStringContent));
                State = updatedStringContent != stringContent ? WebresourceState.Draft : WebresourceState.None;
            }
        }

        #endregion Properties

        #region Events

        public event EventHandler<ResourceEventArgs> ContentReplaced;

        public event EventHandler<ResourceEventArgs> SavedToDisk;

        public event EventHandler<StateEventArgs> StateChanged;

        #endregion Events

        #region Methods

        public void CancelChanges()
        {
            UpdatedStringContent = StringContent;
            State = WebresourceState.None;
            Plugin.DisplayWaitingForUpdatePanel();
        }

        public void Create(IOrganizationService service)
        {
            record.Id = service.Create(record);

            Synced = true;
            State = WebresourceState.None;
        }

        public void Delete(IOrganizationService service)
        {
            if (Id == Guid.Empty)
            {
                return;
            }

            service.Delete(record.LogicalName, record.Id);
        }

        public void GetLatestVersion(bool fromUpdate = false)
        {
            var latestRecord = RetrieveWebresource(Name, Plugin.Service);

            if (fromUpdate)
            {
                record.RowVersion = latestRecord.RowVersion;

                //if (record.GetAttributeValue<string>("content") != latestRecord.GetAttributeValue<string>("content"))
                //{
                //    Plugin.ShowContentNotUpdated();
                //}
            }
            else
            {
                record = latestRecord ??
                         throw new Exception($"Webresource {Name} does not exist on the connected organization");

                if (updatedBase64Content != latestRecord.GetAttributeValue<string>("content"))
                {
                    stringContent = GetPlainText();
                    ContentReplaced?.Invoke(this, new ResourceEventArgs(this));
                }
            }

            Synced = true;
            State = WebresourceState.None;
            Plugin.DisplayWaitingForUpdatePanel();
        }

        public string GetPlainText()
        {
            if (!record.Contains("content"))
            {
                return string.Empty;
            }

            byte[] binary = Convert.FromBase64String(record.GetAttributeValue<string>("content"));
            string resourceContent = Encoding.UTF8.GetString(binary);
            string byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
            if (resourceContent.StartsWith("\""))
            {
                resourceContent = resourceContent.Remove(0, byteOrderMarkUtf8.Length);
            }

            return resourceContent;

            //byte[] b = Convert.FromBase64String(record.GetAttributeValue<string>("content"));
            //return Encoding.Default.GetString(b);
        }

        public bool HasDependencies(IOrganizationService service)
        {
            var request = new RetrieveDependenciesForDeleteRequest
            {
                ComponentType = 61, // Webresource
                ObjectId = Id
            };

            var response = (RetrieveDependenciesForDeleteResponse)service.Execute(request);
            return response.EntityCollection.Entities.Count != 0;
        }

        public void RefreshFromDisk()
        {
            if (FilePath == null) return;

            ReplaceContent(Convert.ToBase64String(File.ReadAllBytes(FilePath)));
        }

        public void ReplaceContent(string base64Content)
        {
            if (base64Content != record.GetAttributeValue<string>("content"))
            {
                record["content"] = base64Content;
                State = WebresourceState.Saved;
                ContentReplaced?.Invoke(this, new ResourceEventArgs(this));
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public void Update(IOrganizationService service, bool overwrite = false)
        {
            if (Id == Guid.Empty)
            {
                var remoteRecord = RetrieveWebresource(Name, service);
                if (remoteRecord == null)
                {
                    Create(service);
                    State = WebresourceState.None;
                    return;
                }

                record.Id = remoteRecord.Id;

                if (remoteRecord.Contains("displayname") && string.IsNullOrEmpty(DisplayName))
                {
                    DisplayName = remoteRecord.GetAttributeValue<string>("displayname");
                }

                if (remoteRecord.Contains("description") && string.IsNullOrEmpty(Description))
                {
                    Description = remoteRecord.GetAttributeValue<string>("description");
                }

                if (remoteRecord.Contains("dependencyxml") && string.IsNullOrEmpty(DependencyXml))
                {
                    DependencyXml = remoteRecord.GetAttributeValue<string>("dependencyxml");
                }

                if (remoteRecord.Contains("languagecode") && LanguageCode == 0)
                {
                    LanguageCode = remoteRecord.GetAttributeValue<int>("languagecode");
                }
            }

            // Concurrency Behavior has a bug for webresources
            // Cannot implemen that
            //var request = new UpdateRequest
            //{
            //    Target = record,
            //    ConcurrencyBehavior =
            //        overwrite ? ConcurrencyBehavior.AlwaysOverwrite : ConcurrencyBehavior.IfRowVersionMatches
            //};

            //service.Execute(request);

            if (!Settings.Instance.ForceResourceUpdate)
            {
                if (overwrite == false)
                {
                    var existingRecord = service.Retrieve("webresource", record.Id, new ColumnSet());
                    if (!string.IsNullOrEmpty(existingRecord.RowVersion) && !string.IsNullOrEmpty(record.RowVersion) && int.Parse(existingRecord.RowVersion) > int.Parse(record.RowVersion))
                    {
                        throw new MoreRecentRecordExistsException();
                    }
                }
            }

            service.Update(record);

            GetLatestVersion(true);

            Synced = true;
            State = WebresourceState.None;
        }

        internal void Rename(string newName)
        {
            // Check if resource with the same name already exists
            var query = new QueryExpression("webresource");
            query.Criteria.AddCondition("name", ConditionOperator.Equal, newName);

            var result = Plugin.Service.RetrieveMultiple(query).Entities.Count;
            if (result > 0)
            {
                throw new Exception($"A webresource with the name '{newName}' already exists on this organisation");
            }

            // Find if the web resource is attached to solutions
            var solutions = Plugin.Service.RetrieveMultiple(new QueryExpression("solution")
            {
                ColumnSet = new ColumnSet(true),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("uniquename", ConditionOperator.NotEqual, "Active"),
                        new ConditionExpression("uniquename", ConditionOperator.NotEqual, "Default")
                    }
                },
                LinkEntities =
                {
                    new LinkEntity
                    {
                        LinkFromEntityName = "solution",
                        LinkFromAttributeName = "solutionid",
                        LinkToAttributeName = "solutionid",
                        LinkToEntityName = "solutioncomponent",
                        LinkCriteria = new FilterExpression
                        {
                            Conditions =
                            {
                                new ConditionExpression("objectid", ConditionOperator.Equal, Id)
                            }
                        }
                    }
                }
            }).Entities;

            // It's safe to update web resource. Direct rename is not possible,
            // but deletion with different name, but same ID will have same result
            Plugin.Service.Delete("webresource", Id);
            if (DisplayName == Name)
            {
                DisplayName = newName;
            }
            Name = newName;

            Node.TreeView.Invoke(new Action(() => { Node.Text = newName.Split('/').First(); }));

            Create(Plugin.Service);

            // Add new web resource to solutions as before
            foreach (var solution in solutions)
            {
                //  bw.ReportProgress(0, $"Adding back the web resource to solution '{solution.GetAttributeValue<string>("friendlyname")}'...");

                var request = new AddSolutionComponentRequest
                {
                    AddRequiredComponents = false,
                    ComponentId = Id,
                    ComponentType = 61,
                    SolutionUniqueName = solution.GetAttributeValue<string>("uniquename")
                };

                Plugin.Service.Execute(request);
            }
        }

        internal void Save()
        {
            record["content"] = Convert.ToBase64String(Encoding.UTF8.GetBytes(updatedStringContent));
            stringContent = UpdatedStringContent;
            State = WebresourceState.Saved;

            Plugin.DisplayWaitingForUpdatePanel();

            if (Settings.Instance.SaveOnDisk)
            {
                if (string.IsNullOrEmpty(Settings.Instance.LastFolderUsed))
                {
                    var cfb = new CustomFolderBrowserDialog(true, false);
                    if (cfb.ShowDialog(Plugin) != DialogResult.OK)
                    {
                        return;
                    }

                    Settings.Instance.LastFolderUsed = cfb.FolderPath;
                }

                var path = Path.Combine(Settings.Instance.LastFolderUsed, Name);
                SaveToDisk(path);
            }
        }

        internal string SaveToDisk(string folder)
        {
            var path = Path.Combine(folder, Name);

            if (string.IsNullOrEmpty(Path.GetExtension(path))
                && Settings.Instance.AddMissingExtensionOnDiskWrite)
            {
                var map = WebresourceMapper.Instance.Items.FirstOrDefault(i => (int)i.Type == Type);
                if (map != null)
                {
                    path = $"{path}.{map.Extension}";
                }
            }

            File.WriteAllText(path, StringContent);
            return path;
        }

        private void LoadAssociatedResources()
        {
            if (!Settings.Instance.PushTsMapFiles || string.IsNullOrWhiteSpace(FilePath) || !Path.HasExtension(FilePath) || Path.GetExtension(FilePath).ToLower() != ".js")
            {
                // Not loaded from Disk, not Extension, not Javascript
                return;
            }

            var mapPath = FilePath + ".map";
            if (File.Exists(mapPath))
            {
                AssociatedResources.Add(LoadWebResourceFromDisk(mapPath, Name + ".map", DisplayName + ".map"));
            }
            var tsPath = Path.ChangeExtension(FilePath, "ts");
            if (File.Exists(tsPath))
            {
                AssociatedResources.Add(LoadWebResourceFromDisk(tsPath, Path.ChangeExtension(Name, "ts"), Path.ChangeExtension(DisplayName, "ts")));
            }
        }

        private Webresource LoadWebResourceFromDisk(string fileName, string name, string displayName = null)
        {
            var mapItem = WebresourceMapper.Instance.Items.FirstOrDefault(i => i.Extension.ToLower() == Path.GetExtension(fileName)?.ToLower().Remove(0, 1));
            if (mapItem == null)
            {
                throw new Exception($"Unable to map extension ({Path.GetExtension(fileName)}) with a webresource type");
            }

            var entity = new Entity("webresource");
            entity["content"] = Convert.ToBase64String(File.ReadAllBytes(fileName));
            entity["webresourcetype"] = new OptionSetValue(mapItem.CrmValue);
            entity["name"] = name;
            entity["displayname"] = displayName ?? name;
            return new Webresource(entity, Plugin);
        }

        #endregion Methods
    }
}