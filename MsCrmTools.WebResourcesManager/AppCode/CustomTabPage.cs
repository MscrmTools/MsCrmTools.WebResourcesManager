using System.Drawing;
using System.Windows.Forms;
using MsCrmTools.WebResourcesManager.UserControls;

namespace MsCrmTools.WebResourcesManager.AppCode
{
    public class CustomTabControl : TabControl
    {
        const int LEADING_SPACE = 12;
        const int CLOSE_AREA = 15;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            var wr = TabPages[e.Index].Tag as WebResource;
            if (wr == null)
            {
                base.OnDrawItem(e);
                return;
            }

            var color = wr.State == WebresourceState.Draft ? Color.Red : wr.State == WebresourceState.Saved ? Color.Blue : Color.Black;

            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - CLOSE_AREA, e.Bounds.Top + 4);
            e.Graphics.DrawString(wr.Entity.GetAttributeValue<string>("name"), e.Font, new SolidBrush(color), e.Bounds.Left + LEADING_SPACE, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            RectangleF tabTextArea = GetTabRect(SelectedIndex);
            tabTextArea = new RectangleF(tabTextArea.X + tabTextArea.Width- CLOSE_AREA, tabTextArea.Y, 13,13);
            Point pt = new Point(e.X,e.Y);
            if (tabTextArea.Contains(pt))
            {
                var wr = SelectedTab.Tag as WebResource;
                if (wr == null)
                {
                    TabPages.Remove(SelectedTab);
                    return;
                }

                if (wr.State == WebresourceState.Draft)
                {
                    if (Options.Instance.AutoSaveWhenLeaving)
                    {
                        wr.Save();
                    }
                    else
                    {
                        var message = "You did not save your changes. Are you sure you want to close this tab?";
                        if (
                            MessageBox.Show(this, message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                            DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            wr.CancelChange();
                        }
                    }
                }

                TabPages.Remove(SelectedTab);
            }
        }
    }
}
