using MscrmTools.WebresourcesManager.CustomControls;
using System;
using System.Collections;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.AppCode
{
    // Create a node sorter that implements the IComparer interface.
    public class NodeSorter : IComparer
    {
        private static int _firstAfterSecond = -1;
        private static int _folder = 1;
        private static int _root = 0;
        private static int _secondAfterFirst = 1;

        // Compare the length of the strings, or the strings
        // themselves, if they are the same length.
        public int Compare(object x, object y)
        {
            var tx = x as TreeNode;
            var ty = y as TreeNode;

            if (tx != null && ty != null)
            {
                if (tx is FolderNode && !(ty is FolderNode))
                {
                    return _firstAfterSecond;
                }

                if (ty is FolderNode && !(tx is FolderNode))
                {
                    return _secondAfterFirst;
                }

                if (tx.ImageIndex == ty.ImageIndex)
                {
                    return string.Compare(tx.Text, ty.Text, StringComparison.InvariantCultureIgnoreCase);
                }

                if (tx.ImageIndex == _root)
                {
                    return _secondAfterFirst;
                }

                if (ty.ImageIndex == _root)
                {
                    return _firstAfterSecond;
                }

                if (tx.ImageIndex == _folder && tx.ImageIndex < ty.ImageIndex)
                {
                    return _secondAfterFirst;
                }

                if (ty.ImageIndex == _folder && ty.ImageIndex < tx.ImageIndex)
                {
                    return _firstAfterSecond;
                }

                return string.Compare(tx.Text, ty.Text, StringComparison.InvariantCultureIgnoreCase);
            }

            return 0;
        }
    }
}