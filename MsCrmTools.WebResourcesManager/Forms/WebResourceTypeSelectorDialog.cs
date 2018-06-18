using MscrmTools.WebresourcesManager.AppCode;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms
{
    public partial class WebResourceTypeSelectorDialog : Form
    {
        public WebResourceTypeSelectorDialog(int majorVersion)
        {
            InitializeComponent();

            webResourceTypePicker1.ShowV9Types = majorVersion >= 9;

            if (!string.IsNullOrEmpty(Settings.Instance.ExcludedPrefixes))
            {
                lblFilter.Text = string.Format(lblFilter.Text, string.Join(" or ", Settings.Instance.ExcludedPrefixes.Split(',')));
            }
            else
            {
                pnlFilter.Visible = false;
            }
        }

        public bool FilterByLcid { get; private set; }
        public List<int> TypesToLoad { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TypesToLoad = new List<int>();
            FilterByLcid = chkFilterByLcid.Checked;

            foreach (string s in webResourceTypePicker1.CheckedExtensions)
            {
                switch (s.ToLower())
                {
                    case ".html":
                        {
                            TypesToLoad.Add(1);
                            break;
                        }
                    case ".css":
                        {
                            TypesToLoad.Add(2);
                            break;
                        }
                    case ".js":
                        {
                            TypesToLoad.Add(3);
                            break;
                        }
                    case ".xml":
                        {
                            TypesToLoad.Add(4);
                            break;
                        }
                    case ".png":
                        {
                            TypesToLoad.Add(5);
                            break;
                        }
                    case ".jpg":
                    case ".jpeg":
                        {
                            TypesToLoad.Add(6);
                            break;
                        }
                    case ".gif":
                        {
                            TypesToLoad.Add(7);
                            break;
                        }
                    case ".xap":
                        {
                            TypesToLoad.Add(8);
                            break;
                        }
                    case ".xsl":
                        {
                            TypesToLoad.Add(9);
                            break;
                        }
                    case ".ico":
                        {
                            TypesToLoad.Add(10);
                            break;
                        }
                    case ".svg":
                        {
                            TypesToLoad.Add(11);
                            break;
                        }
                    case ".resx":
                        {
                            TypesToLoad.Add(12);
                            break;
                        }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}