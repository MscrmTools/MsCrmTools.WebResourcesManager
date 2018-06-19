using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms.Contents
{
    public partial class ResxContentForm : BaseContentForm
    {
        private ResXResourceReader rsxr;
        private DataTable table;

        public ResxContentForm()
        {
            InitializeComponent();
        }

        public ResxContentForm(MyPluginControl control, Webresource resource) : base(control, resource)
        {
            InitializeComponent();

            resource.ContentReplaced += Resource_ContentReplaced;

            Text = resource.Name;
        }

        protected override void ClearEvents()
        {
            Resource.ContentReplaced -= Resource_ContentReplaced;
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Resource.Content = Encoding.UTF8.GetString(Convert.FromBase64String(GetBase64WebResourceContent()));
        }

        private void dgv_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Resource.Content = Encoding.UTF8.GetString(Convert.FromBase64String(GetBase64WebResourceContent()));
        }

        private void DisplayResx()
        {
            if (Resource == null)
            {
                return;
            }

            byte[] b = Convert.FromBase64String(Resource.Content);

            Stream stream = new MemoryStream(b);

            table = new DataTable();
            table.Columns.Add(new DataColumn("Key"));
            table.Columns.Add(new DataColumn("Value"));

            rsxr = new ResXResourceReader(stream);
            foreach (DictionaryEntry d in rsxr)
            {
                if (string.IsNullOrEmpty(d.Key?.ToString()))
                {
                    continue;
                }
                table.Rows.Add(d.Key.ToString(), d.Value?.ToString());
            }
            rsxr.Close();

            dgv.DataSource = table;

            dgv.CellValueChanged += dgv_CellValueChanged;
            dgv.UserDeletedRow += dgv_UserDeletedRow;
        }

        private string GetBase64WebResourceContent()
        {
            using (var ms = new MemoryStream())
            {
                var rsxw = new ResXResourceWriter(ms);

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells.Count == 0
                        || row.Cells[0].Value == null
                        && row.Cells[1].Value == null)
                    {
                        continue;
                    }

                    rsxw.AddResource(row.Cells[0].Value?.ToString(), row.Cells[1].Value?.ToString());
                }

                rsxw.Close();

                return Convert.ToBase64String(ms.ToArray());
            }
        }

        private void Resource_ContentReplaced(object sender, AppCode.Args.ResourceEventArgs e)
        {
            DisplayResx();
        }

        private void ResxContentForm_Load(object sender, EventArgs e)
        {
            DisplayResx();
        }
    }
}