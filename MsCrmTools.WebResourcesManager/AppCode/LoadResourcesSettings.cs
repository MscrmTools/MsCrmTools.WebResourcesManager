using Microsoft.Xrm.Sdk;
using System.Collections.Generic;

namespace MscrmTools.WebresourcesManager.AppCode
{
    internal class LoadResourcesSettings
    {
        public bool FilterByLcid { get; set; }
        public bool LoadAllWebresources { get; set; }
        public Entity Solution { get; internal set; }
        public List<int> TypesToload { get; set; } = new List<int>();
    }
}