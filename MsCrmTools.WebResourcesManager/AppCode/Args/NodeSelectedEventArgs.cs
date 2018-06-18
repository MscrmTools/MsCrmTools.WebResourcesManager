using System;
using System.Drawing;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.AppCode.Args
{
    public class NodeSelectedEventArgs : EventArgs
    {
        public NodeSelectedEventArgs(TreeNode node, Point location)
        {
            Location = location;
            Node = node;
        }

        public Point Location { get; }
        public TreeNode Node { get; }
    }
}