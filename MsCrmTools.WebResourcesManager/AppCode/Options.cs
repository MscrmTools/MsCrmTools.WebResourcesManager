using System.IO;
using System.Reflection;
using System.Xml;
using XrmToolBox.Extensibility;

namespace MsCrmTools.WebResourcesManager.AppCode
{
    public class Options
    {
        private static Options instance;

        private Options()
        {
        }

        public static Options Instance
        {
            get
            {
                if (instance == null)
                {
                    var currentPath = Assembly.GetExecutingAssembly().Location;
                    var fi = new FileInfo(currentPath);
                    var optionFile = fi.FullName.Replace(fi.Extension, ".xml");

                    if (File.Exists(optionFile))
                    {
                        var document = new XmlDocument();
                        document.Load(optionFile);

                        instance = (Options)XmlSerializerHelper.Deserialize(document.OuterXml, typeof(Options));

                        SettingsManager.Instance.Save(typeof(Options), instance);
                        try { File.Delete(optionFile); } catch { }
                    }
                    else
                    {
                        if (!SettingsManager.Instance.TryLoad(typeof(Options), out instance))
                        {
                            instance = new Options();
                        }
                    }
                }

                return instance;
            }
        }

        public string AfterPublishCommand { get; set; }
        public string AfterUpdateCommand { get; set; }
        public string CompareToolArgs { get; set; }
        public string CompareToolPath { get; set; }
        public string LastFolderUsed { get; set; }
        public bool SaveOnDisk { get; set; }
        public bool PushTsMapFiles { get; set; }
        public bool AutoSaveWhenLeaving { get; set; }
        public bool ExpandAllOnLoadingResources { get; set; }
        public bool ObfuscateJavascript { get; set; }
        public bool RemoveCssComments { get; set; }
        public string ExcludedPrefixes { get; set; }

        public void Save()
        {
            SettingsManager.Instance.Save(GetType(), instance);
        }
    }
}