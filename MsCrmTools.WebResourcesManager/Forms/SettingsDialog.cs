using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class SettingsDialog : DockContent
    {
        public SettingsDialog()
        {
            InitializeComponent();
        }

        public event EventHandler OnSettingsChanged;

        public Settings Settings
        {
            set => propertyGrid1.SelectedObject = value;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            OnSettingsChanged?.Invoke(this, new EventArgs());
        }
    }
}