using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MsCrmTools.WebResourcesManager.AppCode;

namespace MsCrmTools.WebResourcesManager.UserControls
{
    public partial class ResourceControl : UserControl, IWebResourceControl
    {
        #region Variables

        /// <summary>
        /// Type of web resource
        /// </summary>
        private readonly Enumerations.WebResourceType innerType;

        /// <summary>
        /// Base64 content of the web resource when loading this control
        /// </summary>
        private readonly string originalContent;

        //  private string content;
        private string innerContent;

        private DataTable table;

        #endregion Variables

        private ResXResourceReader rsxr;

        public ResourceControl(string content)
        {
            InitializeComponent();

            byte[] b = Convert.FromBase64String(content);
            innerContent = Encoding.UTF8.GetString(b);
            originalContent = innerContent;
            innerType = Enumerations.WebResourceType.Resx;

            Stream stream = new MemoryStream(b);

            table = new DataTable();
            table.Columns.Add(new DataColumn("Key"));
            table.Columns.Add(new DataColumn("Value"));

            Dictionary<string, string> resourceMap = new Dictionary<string, string>();
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
            dgv.UserDeletedRow += dgv_UserDeletedRow; ;
        }

        #region Event Handlers

        public event EventHandler<WebResourceUpdatedEventArgs> WebResourceUpdated;

        #endregion Event Handlers

        public string GetBase64WebResourceContent()
        {
            using (var ms = new MemoryStream())
            {
                var rsxw = new ResXResourceWriter(ms);

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells.Count == 0)
                    {
                        continue;
                    }

                    rsxw.AddResource(row.Cells[0].Value?.ToString(), row.Cells[1].Value?.ToString());
                }

                rsxw.Close();

                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public Enumerations.WebResourceType GetWebResourceType()
        {
            return innerType;
        }

        public void ReplaceWithNewFile(string filename)
        {
            try
            {
                using (var reader = new StreamReader(filename))
                {
                    innerContent = reader.ReadToEnd();
                }

                SendSavedMessage();
            }
            catch (Exception error)
            {
                MessageBox.Show(ParentForm, "Error while updating file: " + error.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendSavedMessage()
        {
            byte[] bytes = Encoding.UTF8.GetBytes(innerContent);

            var wrueArgs = new WebResourceUpdatedEventArgs
            {
                Base64Content = Convert.ToBase64String(bytes),
                IsDirty = innerContent != originalContent,
                Type = innerType
            };

            WebResourceUpdated?.Invoke(this, wrueArgs);
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            innerContent = Encoding.UTF8.GetString(Convert.FromBase64String(GetBase64WebResourceContent()));
            SendSavedMessage();
        }

        private void dgv_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            innerContent = Encoding.UTF8.GetString(Convert.FromBase64String(GetBase64WebResourceContent()));
            SendSavedMessage();
        }
    }
}