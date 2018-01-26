// PROJECT : MsCrmTools.WebResourcesManager
// This project was developed by Tanguy Touzard
// CODEPLEX: http://xrmtoolbox.codeplex.com
// BLOG: http://mscrmtools.blogspot.com

using Microsoft.Xrm.Sdk;
using MsCrmTools.WebResourcesManager.AppCode;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace MsCrmTools.WebResourcesManager.Forms
{
    internal partial class UpdateForm : Form
    {
        #region Variables

        /// <summary>
        /// Current script
        /// </summary>
        private readonly WebResource currentWebResource;

        /// <summary>
        /// Current Prefix for names depending on selected solution
        /// </summary>
        private string currentPrefix = string.Empty;

        /// <summary>
        /// Xrm Organization Service
        /// </summary>
        private IOrganizationService innerService;

        #endregion Variables

        #region Constructor

        /// <summary>
        /// Initializes a new instance of class UpdateForm
        /// </summary>
        /// <param name="script">Script to display or to create</param>
        /// <param name="lcids">List of available languages</param>
        /// <param name="service">Xrm Organization Service</param>
        public UpdateForm(WebResource script, int[] lcids, IOrganizationService service)
        {
            InitializeComponent();

            innerService = service;
            currentWebResource = script;

            cbbLanguage.Items.AddRange(lcids.Select(l => new Language(l)).ToArray());

            FillControls();
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Script to update
        /// </summary>
        internal WebResource WebRessource
        {
            get
            {
                return currentWebResource;
            }
        }

        #endregion Properties

        #region Methods

        private void FillControls()
        {
            if (!string.IsNullOrEmpty(currentWebResource.FilePath))
                txtPath.Text = currentWebResource.FilePath;

            txtName.Text = currentWebResource.ToString();
            txtDisplayName.Text = currentWebResource.EntityDisplayName;
            txtDescription.Text = currentWebResource.EntityDescription;
            cbbLanguage.SelectedItem = cbbLanguage.Items.Cast<Language>()
                .FirstOrDefault(l => l.Lcid == currentWebResource.EntityLanguageCode);

            chkSynced.Checked = currentWebResource.SyncedWithCrm;
        }

        #endregion Methods

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            currentWebResource.EntityDisplayName = txtDisplayName.Text;
            currentWebResource.EntityDescription = txtDescription.Text;
            currentWebResource.EntityLanguageCode = ((Language)cbbLanguage.SelectedItem)?.Lcid ?? 0;

            DialogResult = DialogResult.OK;
        }
    }

    public class Language
    {
        private readonly string name;

        public Language(int lcid)
        {
            Lcid = lcid;
            name = CultureInfo.GetCultureInfo(lcid).EnglishName;
        }

        public int Lcid { get; private set; }

        public override string ToString()
        {
            return name;
        }
    }
}