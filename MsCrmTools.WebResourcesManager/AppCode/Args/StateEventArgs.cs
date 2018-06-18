using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MscrmTools.WebresourcesManager.AppCode.Args
{
    public class StateEventArgs : EventArgs
    {
        public StateEventArgs(WebresourceState state)
        {
            State = state;
        }

        public WebresourceState State { get; set; }
    }
}