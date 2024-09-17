//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSSecuritySetupView.cs $
//
// Version:         $Revision: 5795 $,
//                  $Date: 2012-10-02 13:22:54 +0300 (ti, 02 loka 2012) $
//                  $Author: kurumi $
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

using System;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Collections.Generic;
using Gurux.DLMS.Objects.Enums;
using System.IO;
using Gurux.DLMS.ASN;
using Gurux.DLMS.UI.Ecdsa;
using System.Text;
using Gurux.DLMS.ASN.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSSecuritySetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSSecuritySetup), 1)]
    partial class GXDLMSSecuritySetupView : Form, IGXDLMSView
    {
        string path = null;

        /// <summary>
        /// Generate certificate request type is saved to this.
        /// </summary>
        CertificateType _certificateType = CertificateType.DigitalSignature;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSSecuritySetupView()
        {
            InitializeComponent();
            // SecurityCb.ite
            SecurityPolicyTB.Items.Add(SecurityPolicy.AuthenticatedRequest);
            SecurityPolicyTB.Items.Add(SecurityPolicy.EncryptedRequest);
            SecurityPolicyTB.Items.Add(SecurityPolicy.DigitallySignedRequest);
            SecurityPolicyTB.Items.Add(SecurityPolicy.AuthenticatedResponse);
            SecurityPolicyTB.Items.Add(SecurityPolicy.EncryptedResponse);
            SecurityPolicyTB.Items.Add(SecurityPolicy.DigitallySignedResponse);
            SecurityCb.Items.Add(SecurityPolicy.None);
            SecurityCb.Items.Add(SecurityPolicy.Authenticated);
            SecurityCb.Items.Add(SecurityPolicy.Encrypted);
            SecurityCb.Items.Add(SecurityPolicy.AuthenticatedEncrypted);
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSSecuritySetup target = (GXDLMSSecuritySetup)Target;
            if (arg.Index == 6)
            {
                CertificatesLv.Items.Clear();
                if (target.Certificates != null)
                {
                    foreach (GXDLMSCertificateInfo it in target.Certificates)
                    {
                        ListViewItem li = CertificatesLv.Items.Add(it.Entity.ToString());
                        li.SubItems.Add(it.Type.ToString());
                        li.SubItems.Add(it.SerialNumber.ToString());
                        li.SubItems.Add(it.Issuer);
                        li.SubItems.Add(it.Subject);
                        li.SubItems.Add(it.SubjectAltName);
                        li.Tag = it;
                    }
                }
            }
            else if (arg.Index == 2)
            {
                SecurityCb.Visible = Target.Version == 0;
                SecurityPolicyTB.Visible = Target.Version == 1;
                if (Target.Version == 0)
                {
                    SecurityCb.SelectedItem = target.SecurityPolicy;
                }
                else
                {
                    SecurityPolicyTB.SetItemChecked(0, (target.SecurityPolicy & SecurityPolicy.AuthenticatedRequest) != 0);
                    SecurityPolicyTB.SetItemChecked(1, (target.SecurityPolicy & SecurityPolicy.EncryptedRequest) != 0);
                    SecurityPolicyTB.SetItemChecked(2, (target.SecurityPolicy & SecurityPolicy.DigitallySignedRequest) != 0);
                    SecurityPolicyTB.SetItemChecked(3, (target.SecurityPolicy & SecurityPolicy.AuthenticatedResponse) != 0);
                    SecurityPolicyTB.SetItemChecked(4, (target.SecurityPolicy & SecurityPolicy.EncryptedResponse) != 0);
                    SecurityPolicyTB.SetItemChecked(5, (target.SecurityPolicy & SecurityPolicy.DigitallySignedResponse) != 0);
                }
            }
            else if (arg.Index == 5)
            {
                SystemTitleDescriptionTb.Text = GXDLMSConverter.SystemTitleToString(Standard.DLMS, target.ServerSystemTitle, true);
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        delegate void GetValueEventHandler(GXActionArgs arg);
        void OnGetValue(GXActionArgs arg)
        {
            try
            {
                if (arg.Index == 1)
                {
                    if (Target.Version == 1)
                    {
                        byte value = 0;
                        foreach (SecurityPolicy it in SecurityPolicyTB.CheckedItems)
                        {
                            value |= Convert.ToByte(it);
                        }
                        arg.Value = new GXEnum(value);

                    }
                    else
                    {
                        //Version 0.
                        arg.Value = new GXEnum((byte)SecurityCb.SelectedItem);
                    }
                }
                else if (arg.Index == 2)
                {
                    GXSecuritySetupKeyDlg dlg = new GXSecuritySetupKeyDlg(0);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        List<KeyValuePair<GlobalKeyType, byte[]>> list = new List<KeyValuePair<GlobalKeyType, byte[]>>();
                        list.Add(new KeyValuePair<GlobalKeyType, byte[]>(dlg.Type, dlg.Key));
                        arg.Value = (Target as GXDLMSSecuritySetup).GlobalKeyTransfer(arg.Client, dlg.Kek, list);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 4)
                {
                    GXCertificateType dlg = new GXCertificateType("Generate key pair");
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        arg.Value = (Target as GXDLMSSecuritySetup).GenerateKeyPair(arg.Client, dlg.GetValue());
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 5)
                {
                    GXCertificateType dlg = new GXCertificateType("Generate certificate request");
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        _certificateType = dlg.GetValue();
                        arg.Value = (Target as GXDLMSSecuritySetup).GenerateCertificate(arg.Client, _certificateType);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 7)
                {
                    if (CertificatesLv.SelectedItems.Count == 0)
                    {
                        throw new Exception("Failed to export certificate. Select certificate to export.");
                    }
                    GXDLMSCertificateInfo cert = (GXDLMSCertificateInfo)CertificatesLv.SelectedItems[0].Tag;
                    arg.Value = (Target as GXDLMSSecuritySetup).ExportCertificateBySerial(arg.Client, cert.SerialNumber,
                        cert.IssuerRaw);
                }
                else if (arg.Index == 8)
                {
                    if (CertificatesLv.SelectedItems.Count == 0)
                    {
                        throw new Exception("Failed to remove certificate. Select certificate to remove.");
                    }
                    GXDLMSCertificateInfo cert = (GXDLMSCertificateInfo)CertificatesLv.SelectedItems[0].Tag;
                    CertificatesLv.SelectedItems[0].Remove();
                    arg.Value = (Target as GXDLMSSecuritySetup).RemoveCertificateBySerial(arg.Client, 
                        cert.SerialNumber, cert.IssuerRaw);
                }
            }
            catch (Exception ex)
            {
                arg.Handled = true;
                MessageBox.Show(Parent, ex.Message);
            }
        }

        void ImportCertificate(GXActionArgs arg)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = false;
                if (string.IsNullOrEmpty(path))
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    FileInfo fi = new FileInfo(path);
                    dlg.InitialDirectory = fi.DirectoryName;
                    dlg.FileName = fi.Name;
                }
                dlg.Filter = Properties.Resources.PemFilterTxt;
                dlg.DefaultExt = ".pem";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    foreach (string fileName in dlg.FileNames)
                    {
                        GXx509Certificate cert = GXx509Certificate.Load(fileName);
                        arg.Value = ((GXDLMSSecuritySetup)arg.Target).ImportCertificate(arg.Client, cert);
                    }
                }
                else
                {
                    arg.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        void SaveCertificateRequest(GXActionArgs arg)
        {
            try
            {
                GXPkcs10 csr = new GXPkcs10((byte[])arg.Value);
                GXCertifigateGenerationForm dlg2 = new GXCertifigateGenerationForm(GXDlmsUi.GeneratorAddress,
                    csr, _certificateType, arg.Client.SourceSystemTitle);
                if (dlg2.ShowDialog(Parent) == DialogResult.OK)
                {
                    SaveFileDialog dlg = new SaveFileDialog();
                    if (string.IsNullOrEmpty(path))
                    {
                        dlg.InitialDirectory = Directory.GetCurrentDirectory();
                    }
                    else
                    {
                        FileInfo fi = new FileInfo(path);
                        dlg.InitialDirectory = fi.DirectoryName;
                    }
                    int pos = dlg2.Certificate.Subject.IndexOf("CN=");
                    if (pos == -1)
                    {
                        throw new Exception("System title isn't included in Common name.");
                    }
                    string name;
                    if (dlg2.Certificate.KeyUsage == KeyUsage.DigitalSignature)
                    {
                        name = "D";
                    }
                    else if (dlg2.Certificate.KeyUsage == KeyUsage.KeyAgreement)
                    {
                        name = "A";
                    }
                    else if (dlg2.Certificate.KeyUsage == (KeyUsage)(KeyUsage.KeyAgreement | KeyUsage.DigitalSignature))
                    {
                        name = "T";
                    }
                    else
                    {
                        name = "";
                    }
                    name += dlg2.Certificate.Subject.Substring(pos + 3, 16) + ".pem";
                    dlg.FileName = name;
                    dlg.Filter = Properties.Resources.PemFilterTxt;
                    dlg.DefaultExt = ".pem";
                    dlg.ValidateNames = true;
                    if (dlg.ShowDialog(Parent) == DialogResult.OK)
                    {
                        dlg2.Certificate.Save(dlg.FileName);
                        path = dlg.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        void SaveCertificate(GXActionArgs arg)
        {
            try
            {
                GXx509Certificate csr = new GXx509Certificate((byte[])arg.Value);
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = Properties.Resources.PemFilterTxt;
                dlg.DefaultExt = ".pem";
                if (string.IsNullOrEmpty(path))
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    FileInfo fi = new FileInfo(path);
                    dlg.InitialDirectory = fi.DirectoryName;
                    dlg.FileName = fi.Name;
                }
                dlg.FileName = "";
                int pos = csr.Subject.IndexOf("CN=");
                if (pos != -1)
                {
                    string name;
                    if (csr.KeyUsage == ASN.Enums.KeyUsage.DigitalSignature)
                    {
                        name = "D";
                    }
                    else if (csr.KeyUsage == ASN.Enums.KeyUsage.KeyAgreement)
                    {
                        name = "A";
                    }
                    else
                    {
                        name = "";
                    }
                    dlg.FileName = name + csr.Subject.Substring(pos + 3, 16);
                }
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    csr.Save(dlg.FileName);
                    path = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
                else if (arg.Index == 2)
                {
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
                else if (arg.Index == 4)
                {
                    //generate_key_pair
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
                else if (arg.Index == 5)
                {
                    //generate_certificate_request.
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
                else if (arg.Index == 6)
                {
                    //import_certificate
                    BeginInvoke(new GetValueEventHandler(ImportCertificate), arg).AsyncWaitHandle.WaitOne();
                }
                else if (arg.Index == 7)
                {
                    //export_certificate
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
                else if (arg.Index == 8)
                {
                    //remove_certificate
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            if (arg.Exception == null && arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    arg.Action = ActionType.Read;
                    arg.Index = 2;
                }
                else
                {
                    if (arg.Index == 2)
                    {
                        GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (arg.Index == 4)
                    {
                        GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (arg.Index == 5)
                    {
                        BeginInvoke(new GetValueEventHandler(SaveCertificateRequest), arg).AsyncWaitHandle.WaitOne();
                    }
                    else if (arg.Index == 6)
                    {
                        GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (arg.Index == 7)
                    {
                        BeginInvoke(new GetValueEventHandler(SaveCertificate), arg).AsyncWaitHandle.WaitOne();
                    }
                    else if (arg.Index == 8)
                    {
                        GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    arg.Action = ActionType.None;
                }
            }
            else
            {
                arg.Action = ActionType.None;
            }
        }

        public System.Windows.Forms.ErrorProvider ErrorProvider
        {
            get
            {
                return errorProvider1;
            }
        }

        public string Description
        {
            get
            {
                return DescriptionTB.Text;
            }
            set
            {
                DescriptionTB.Text = value;
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {
            if (!Dirty)
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            if (arg.Index == 2)
            {
                SecurityPolicyTB.Enabled = !(!arg.Connected || !arg.Client.CanWrite(Target, 1));
            }
            else if (arg.Index == 5)
            {
            }
            else if (arg.Index != 6)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
        {
        }

        #endregion

        private void ValueTB_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void ValueTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }
    }
}
