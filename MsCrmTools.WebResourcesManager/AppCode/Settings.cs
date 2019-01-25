using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using WeifenLuo.WinFormsUI.Docking;
using XrmToolBox.Extensibility;

namespace MscrmTools.WebresourcesManager.AppCode
{
    public class Settings
    {
        private static Settings instance;

        private Settings()
        {
        }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    if (!SettingsManager.Instance.TryLoad(typeof(Settings), out instance))
                    {
                        instance = new Settings();
                    }
                }

                return instance;
            }
        }

        [Category("Local Sync Settings")]
        [DisplayName("Add missing extension")]
        [Description("Add missing extension when saving webresource to local file")]
        public bool AddMissingExtensionOnDiskWrite { get; set; }

        [Category("Post events Settings")]
        [DisplayName("After publish command")]
        [Description("Command to execute after a webresource is published. You can use {FilePath} tag to get webresource location")]
        public string AfterPublishCommand { get; set; }

        [Category("Post events Settings")]
        [DisplayName("After update command")]
        [Description("Command to execute after a webresource is updated on connected organization. You can use {FilePath} tag to get webresource location")]
        public string AfterUpdateCommand { get; set; }

        [Category("Miscellaneous Settings")]
        [DisplayName("Auto save when leaving")]
        [Description("TBD")]
        public bool AutoSaveWhenLeaving { get; set; }

        [Category("Compare Settings")]
        [DisplayName("Tool arguments")]
        [Description("Arguments to use with the tool specified")]
        public string CompareToolArgs { get; set; }

        [Category("Compare Settings")]
        [DisplayName("Tool path")]
        [Description("Path of the tool to use to compare content")]
        [Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
        public string CompareToolPath { get; set; }

        [Category("Display Settings")]
        [DisplayName("Display search bar on top")]
        [Description("Specify where the search bar is displayed in webresources explorer")]
        public bool DisplayExplorerSearchBarOnTop { get; set; }

        [Category("Loading Settings")]
        [DisplayName("Customization prefix to exclude")]
        [Description("List customization prefix that won't be loaded. Comma separated (example:adx_,msdyn_)")]
        public string ExcludedPrefixes { get; set; } = "msdyn_,adx_,cc_MscrmControls";

        [Category("Display Settings")]
        [DisplayName("Expand webresources treeview")]
        [Description("Specifiy to expand all treeview nodes when loading webresources")]
        public bool ExpandAllOnLoadingResources { get; set; }

        [Category("Miscellaneous Settings")]
        [DisplayName("Force webresource update")]
        [Description("If false, a more recent version is searched on the connected organization. If so, you will be prompted before updating this webresource.")]
        public bool ForceResourceUpdate { get; set; }

        [Category("Local Files")]
        [DisplayName("Ignored Files")]
        [Description("Files to ignore and not display an error for loading from disk")]
        [Editor(@"System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter(typeof(ListConverter))]
        public List<string> IgnoredLocalFiles { get; set; } = new List<string>();

        [Category("Miscellaneous Settings")]
        [DisplayName("Last folder used")]
        [Description("Location of the folder used to save/load webresources")]
        [ReadOnly(true)]
        public string LastFolderUsed { get; set; }

        [Category("Loading Settings")]
        [DisplayName("Load managed webresources")]
        [Description("Defines if managed webresources must be loaded")]
        public bool LoadManaged { get; set; } = false;

        [Category("Loading Settings")]
        [DisplayName("Load only resources with valid extension")]
        [Description("Check the extension of a webresource name and load it only if valid")]
        public bool LoadOnlyValidExtensions { get; set; } = false;

        [Category("Loading Settings")]
        [DisplayName("Load Hidden system webresources")]
        [Description("Specify wether to load system webresources that are normaly hidden. Only works when loading webresources without specifying a solution to load")]
        public bool LoadSystemHiddenResources { get; set; }

        [Category("Local Sync Settings")]
        [DisplayName("Local files out of date on load")]
        [Description("Treats local files as out of date when they are initially loaded.  Setting to false will only track future changes.")]
        public bool LocalFilesOutOfDateOnLoad { get; set; } = true;

        [Browsable(false)]
        public bool ObfuscateJavascript { get; set; }

        [Browsable(false)] public DockState PendingUpdatesDockState { get; set; } = DockState.DockLeftAutoHide;

        [Browsable(false)] public DockState PropertiesDockState { get; set; } = DockState.DockRightAutoHide;

        [Category("Miscellaneous Settings")]
        [DisplayName("Push TypeScript files")]
        [Description("Specify wether to push map and ts files if existing on disk")]
        public bool PushTsMapFiles { get; set; }

        [Browsable(false)]
        public bool RemoveCssComments { get; set; }

        [Category("Local Sync Settings")]
        [DisplayName("Save content on local files")]
        [Description("Only available for webresources loaded from disk or saved to disk")]
        public bool SaveOnDisk { get; set; }

        [Browsable(false)] public DockState SettingsDockState { get; set; } = DockState.DockRightAutoHide;

        [Category("Local Sync Settings")]
        [DisplayName("Sync matching files as extensionless")]
        [Description("CRM doesn't enforce adding an extension to a webresource.  If there is a local file \"new_a\" and another \"new_a.js\", \"new_a.js\" will be pushed as \"new_a\"")]
        public bool SyncMatchingJsFilesAsExtensionless { get; set; } = true;

        [Browsable(false)] public DockState TreeviewDockState { get; set; } = DockState.DockLeft;

        public void Save()
        {
            for (var i = 0; i < IgnoredLocalFiles.Count; i++)
            {
                IgnoredLocalFiles[i] = IgnoredLocalFiles[i].Trim();
            }
            SettingsManager.Instance.Save(GetType(), instance);
        }
    }
}