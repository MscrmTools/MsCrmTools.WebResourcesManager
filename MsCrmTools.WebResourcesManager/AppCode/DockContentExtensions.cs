using System.Net.Mime;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.WebresourcesManager.AppCode
{
    internal static class DockContentExtensions
    {
        public static void ShowDocked(this DockContent content, DockState forcedState = DockState.Unknown)
        {
            if (forcedState != DockState.Unknown)
            {
                content.Show(content.DockPanel, forcedState);
                return;
            }

            DockState newState;
            switch (content.DockState)
            {
                case DockState.DockBottom:
                case DockState.DockBottomAutoHide:
                    newState = DockState.DockBottom;
                    break;

                case DockState.DockTop:
                case DockState.DockTopAutoHide:
                    newState = DockState.DockTop;
                    break;

                case DockState.DockLeft:
                case DockState.DockLeftAutoHide:
                    newState = DockState.DockLeft;
                    break;

                case DockState.DockRight:
                case DockState.DockRightAutoHide:
                    newState = DockState.DockRight;
                    break;

                default:
                    newState = DockState.DockRight;
                    break;
            }

            content.Show(content.DockPanel, newState);
        }
    }
}