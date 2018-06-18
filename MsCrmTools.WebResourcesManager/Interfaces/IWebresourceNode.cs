using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MscrmTools.WebresourcesManager.AppCode;

namespace MscrmTools.WebresourcesManager.Interfaces
{
    internal interface IWebresourceNode
    {
        int DraftImageIndex { get; }
        int SyncedImageIndex { get; }
    }
}