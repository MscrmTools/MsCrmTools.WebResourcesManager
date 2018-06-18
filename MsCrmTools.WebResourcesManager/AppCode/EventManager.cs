using System;
using System.Diagnostics;

namespace MscrmTools.WebresourcesManager.AppCode
{
    internal class EventManager
    {
        public static void ActAfterPublish(Webresource resource, Settings settings)
        {
            if (settings.AfterPublishCommand.Contains("{FilePath}") && string.IsNullOrEmpty(resource.FilePath))
            {
                throw new Exception("It is required that the web resource has a file path in its properties to use a command referencing the tag {FilePath}");
            }

            RunCommand(settings.AfterPublishCommand.Replace("{FilePath}", resource.FilePath));
        }

        public static void ActAfterUpdate(Webresource resource, Settings settings)
        {
            if (settings.AfterUpdateCommand.Contains("{FilePath}") && string.IsNullOrEmpty(resource.FilePath))
            {
                throw new Exception("It is required that the web resource has a file path in its properties to use a command referencing the tag {FilePath}");
            }

            RunCommand(settings.AfterUpdateCommand.Replace("{FilePath}", resource.FilePath));
        }

        private static void RunCommand(string command)
        {
            Process process = Process.Start(new ProcessStartInfo(command)
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false,
                WindowStyle = ProcessWindowStyle.Hidden
            });

            string stderr = process?.StandardError.ReadToEnd();
            process?.WaitForExit();

            if (!string.IsNullOrEmpty(stderr))
            {
                throw new Exception($"An error occured when executing additional action ({command}):\r\n\r\n{stderr}");
            }
        }
    }
}