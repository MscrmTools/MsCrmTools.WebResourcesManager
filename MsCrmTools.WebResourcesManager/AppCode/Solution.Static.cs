using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MscrmTools.WebresourcesManager.AppCode
{
    public static partial class Solution
    {
        public static ColumnSet Columns = new ColumnSet("solutionid", "friendlyname", "version", "publisherid", "uniquename");
    }
}
