using Gurux.DLMS.ASN;
using Gurux.DLMS.ASN.Enums;
using Gurux.DLMS.Objects.Enums;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{
    public partial class GXEcdsaKeysDlg : Form, IGXUpdater
    {
        private readonly string _address;
        byte[] _systemTitle;
        GXCertificateForm cf;
        GXKeyForm kf;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="address">Gurux certificate generator address.</param>
        /// <param name="privateKeysFolder">Private keys folder.</param>
        /// <param name="certificatesFolder">Certificates folder.</param>
        /// <param name="title">Dialog title.</param>
        /// <param name="securitySuite">Security Suite level.</param>
        /// <param name="systemTitle">System title.</param>
        public GXEcdsaKeysDlg(string address, string privateKeysFolder,
            string certificatesFolder,
            string title,
            SecuritySuite securitySuite,
            byte[] systemTitle)
        {
            InitializeComponent();
            _address = address;
            if (systemTitle != null && systemTitle.Length != 8)
            {
                throw new ArgumentOutOfRangeException("Invalid system title.");
            }
            _systemTitle = systemTitle;
            if (!Directory.Exists(certificatesFolder))
            {
                Directory.CreateDirectory(certificatesFolder);
            }
            if (!Directory.Exists(privateKeysFolder))
            {
                Directory.CreateDirectory(privateKeysFolder);
            }
            cf = new GXCertificateForm(this, _address, certificatesFolder, title, _systemTitle);
            // Certificate is not generated if the certificate is found for the given system title.
            if (_systemTitle != null && cf.Certificates.FindBySystemTitle(_systemTitle, KeyUsage.None) != null)
            {
                _systemTitle = null;
            }
            kf = new GXKeyForm(this, _address, privateKeysFolder, certificatesFolder, title, securitySuite, _systemTitle);
            while (kf.Controls.Count != 0)
            {
                Control ctr = kf.Controls[0];
                KeysView.Controls.Add(ctr);
                ctr.Visible = true;
            }
            if (_systemTitle != null)
            {
                cf.RefreshCertificates();
            }
            while (cf.Controls.Count != 0)
            {
                Control ctr = cf.Controls[0];
                CertificatesView.Controls.Add(ctr);
                ctr.Visible = true;
            }
        }

        public void UpdateUI()
        {
            ((IGXUpdater) cf).UpdateUI();
        }

        internal void ShowInfo(GXx509Certificate cert)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Public key info:");
            sb.AppendLine(cert.ToString());
            MessageBox.Show(Parent, sb.ToString());
        }
    }
}
