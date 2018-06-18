using System.Collections.Generic;

namespace MscrmTools.WebresourcesManager.AppCode
{
    internal class UpdateResourcesResult
    {
        public IEnumerable<Webresource> FaultedResources { get; internal set; }
        public bool Publish { get; internal set; }
        public bool AddToSolution { get; internal set; }
        public string SolutionUniqueName { get; set; }
    }
}