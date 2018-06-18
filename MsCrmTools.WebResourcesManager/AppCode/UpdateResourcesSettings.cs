using System.Collections.Generic;

namespace MscrmTools.WebresourcesManager.AppCode
{
    public class UpdateResourcesSettings
    {
        public IEnumerable<Webresource> Webresources { get; internal set; }
        public bool AddToSolution { get; internal set; }
        public bool Publish { get; internal set; }
        public string SolutionUniqueName { get; internal set; }
        public bool Overwrite { get; internal set; }
    }
}