//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
//
// Version:         $Revision: 10624 $,
//                  $Date: 2019-04-24 13:56:09 +0300 (ke, 24 huhti 2019) $
//                  $Author: gurux01 $
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License for more details.
//
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.ASN;
using Gurux.DLMS.ASN.Enums;
using Gurux.DLMS.Ecdsa;
using Gurux.DLMS.Objects.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{
    public partial class GXCertifigateGenerationForm : Form
    {
        private string _path;
        private readonly string _address;

        public GXx509Certificate Certificate
        {
            get;
            set;
        }

        public GXCertifigateGenerationForm(string path, string address)
        {
            InitializeComponent();
            _address = address;
            _path = path;
        }

        public GXCertifigateGenerationForm(string address, GXPkcs10 pkc10, CertificateType type, byte[] systemTitle)
        {
            InitializeComponent();
            _address = address;
            SystemTitleTb.Text = GXDLMSTranslator.ToHex(systemTitle, false);
            LoadBtn.Enabled = CSRBtn.Enabled = false;
            Pkcs10Tb.Text = pkc10.ToPem();
            Pkcs10Tb.AppendText(Environment.NewLine);
            Pkcs10Tb.AppendText(pkc10.ToString());
            if (type == CertificateType.DigitalSignature)
            {
                DigitalSignatureCb.Checked = true;
            }
            else if (type == CertificateType.KeyAgreement)
            {
                KeyAgreementCb.Checked = true;
            }
            else
            {
                ServerTlsCb.Checked = true;
            }
            ServerTlsCb.Enabled = KeyAgreementCb.Enabled = DigitalSignatureCb.Enabled = false;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = false;
                if (string.IsNullOrEmpty(_path))
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(_path);
                    dlg.InitialDirectory = fi.DirectoryName;
                    dlg.FileName = fi.Name;
                }
                dlg.Filter = Properties.Resources.CertificateFilterTxt;
                dlg.DefaultExt = ".csr";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    //Try to load Pkcs #10 file.
                    GXPkcs10 key = GXPkcs10.Load(dlg.FileName);
                    Pkcs10Tb.Text = key.ToPem();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<GXCertificateRequest> certificates = new List<GXCertificateRequest>();
                GXCertificateRequest it = new GXCertificateRequest();
                it.Certificate = GXPkcs10.FromPem(Pkcs10Tb.Text);
                if (DigitalSignatureCb.Checked)
                {
                    it.CertificateType = CertificateType.DigitalSignature;
                }
                else if (KeyAgreementCb.Checked)
                {
                    it.CertificateType = CertificateType.KeyAgreement;
                }
                else
                {
                    if (ServerTlsCb.Checked)
                    {
                        it.ExtendedKeyUsage = ExtendedKeyUsage.ServerAuth;
                    }
                    else
                    {
                        it.ExtendedKeyUsage = ExtendedKeyUsage.ClientAuth;
                    }
                    it.CertificateType = CertificateType.TLS;
                }
                certificates.Add(it);
                Certificate = GXPkcs10.GetCertificate(_address, certificates)[0];
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Generate Certificate Signing Request (CSR) from private key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CSRBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SystemTitleTb.Text == "")
                {
                    throw new Exception("Invalid system title.");
                }
                byte[] st = GXDLMSTranslator.HexToBytes(SystemTitleTb.Text);
                if (st.Length != 8)
                {
                    throw new Exception("Invalid system title.");
                }

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = false;
                if (string.IsNullOrEmpty(_path))
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(_path);
                    dlg.InitialDirectory = fi.DirectoryName;
                    dlg.FileName = fi.Name;
                }
                dlg.Filter = Properties.Resources.PemFilterTxt;
                dlg.DefaultExt = ".pem";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    string path = dlg.FileName;
                    GXPkcs8 pk = GXPkcs8.Load(path);
                    KeyValuePair<GXPublicKey, GXPrivateKey> kp = new KeyValuePair<GXPublicKey, GXPrivateKey>(pk.PublicKey, pk.PrivateKey);
                    //Generate certificate request and ask new x509Certificate.
                    GXPkcs10 pkc10 = GXPkcs10.CreateCertificateSigningRequest(kp, GXAsn1Converter.SystemTitleToSubject(st));
                    Pkcs10Tb.Text = pkc10.ToPem();
                    Pkcs10Tb.AppendText(Environment.NewLine);
                    Pkcs10Tb.AppendText(pkc10.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }
        /// <summary>
        /// Save certificate.
        /// </summary>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXPkcs10 csr = GXPkcs10.FromPem(Pkcs10Tb.Text);
                SaveFileDialog dlg = new SaveFileDialog();
                if (string.IsNullOrEmpty(_path))
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    FileInfo fi = new FileInfo(_path);
                    dlg.InitialDirectory = fi.DirectoryName;
                    dlg.FileName = fi.Name;
                }
                dlg.Filter = Properties.Resources.CertificateFilterTxt;
                dlg.DefaultExt = ".csr";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    csr.Save(dlg.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }
    }
}
