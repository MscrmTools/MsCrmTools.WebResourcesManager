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
            set
            {
                if (propertyGrid1.SelectedObject != value)
                {
                    if (propertyGrid1.SelectedObject != null)
                    {
                        (propertyGrid1.SelectedObject as Settings).SettingChangedCustom -= onSettingChangedCustom;
                    }

                    propertyGrid1.SelectedObject = value;

                    if (propertyGrid1.SelectedObject != null)
                    {
                        (propertyGrid1.SelectedObject as Settings).SettingChangedCustom += onSettingChangedCustom;
                    }
                }
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            raiseOnSettingsChanged();
        }

        private void raiseOnSettingsChanged()
        {
            OnSettingsChanged?.Invoke(this, new EventArgs());
        }

        private void onSettingChangedCustom(object s, EventArgs e)
        {
            raiseOnSettingsChanged();
        }
    }
}