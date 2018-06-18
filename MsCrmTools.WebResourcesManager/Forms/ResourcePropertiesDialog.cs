using MscrmTools.WebresourcesManager.AppCode;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class ResourcePropertiesDialog : DockContent
    {
        public ResourcePropertiesDialog()
        {
            InitializeComponent();
        }

        public Webresource Resource
        {
            set
            {
                if (value == null)
                {
                    propertyGrid.Visible = false;
                    lblHelp.Visible = true;
                }
                else
                {
                    propertyGrid.SelectedObject = value;
                    propertyGrid.Visible = true;
                    lblHelp.Visible = false;
                }
            }
        }
    }
}