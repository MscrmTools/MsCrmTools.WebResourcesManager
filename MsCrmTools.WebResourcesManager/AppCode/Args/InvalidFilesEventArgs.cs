using System;
using System.Collections.Generic;

namespace MscrmTools.WebresourcesManager.AppCode.Args
{
    public class InvalidFilesEventArgs : EventArgs
    {
        public InvalidFilesEventArgs(List<string> invalidFilesList)
        {
            InvalidFilesList = invalidFilesList;
        }

        public List<string> InvalidFilesList { get; }
    }
}