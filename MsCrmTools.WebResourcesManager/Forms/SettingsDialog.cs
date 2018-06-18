using System.Windows.Forms;
using MscrmTools.WebresourcesManager.AppCode;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class SettingsDialog : DockContent
    {
        public SettingsDialog()
        {
            InitializeComponent();

            propertyGrid1.SelectedObject = Settings.Instance;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            Settings.Instance.Save();
        }
    }
}