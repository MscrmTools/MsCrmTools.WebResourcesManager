using System;

namespace MscrmTools.WebresourcesManager.AppCode.Exceptions
{
    internal class UnknownExtensionException : Exception
    {
        public UnknownExtensionException(string message) : base(message)
        {
        }
    }
}