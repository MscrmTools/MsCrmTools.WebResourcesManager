using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MscrmTools.WebresourcesManager.Forms;

namespace MscrmTools.WebresourcesManager.AppCode.Editors
{
    internal class DependencyXmlEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            if (provider?.GetService(typeof(IWindowsFormsEditorService)) is IWindowsFormsEditorService svc)
            {
                var plugin = ((Webresource)context?.Instance)?.Plugin;

                using (DependencyDialog form = new DependencyDialog((Webresource)context?.Instance, plugin))
                {
                    if (svc.ShowDialog(form) == DialogResult.OK)
                    {
                        value = form.UpdatedDependencyXml; // update object
                    }
                }
            }
            return value; // can also replace the wrapper object here
        }
    }
}