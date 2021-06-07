//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL:  $
//
// Version:         $Revision: $,
//                  $Date: $
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

using Gurux.DLMS.ASN.Enums;
using Gurux.DLMS.Objects.Enums;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{
    public partial class GXCertificateSigningRequestDlg : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXCertificateSigningRequestDlg(byte[] value)
        {
            InitializeComponent();
            SystemTitleTb.Text = GXDLMSTranslator.ToHex(value);
        }

        public byte[] SystemTitle
        {
            get;
            private set;
        }

        /// <summary>
        /// Selected certificate type.
        /// </summary>
        public CertificateType CertificateType
        {
            get;
            private set;
        }

        /// <summary>
        /// Is TLS for the server or the client.
        /// </summary>
        public ExtendedKeyUsage ExtendedKeyUsage
        {
            get;
            private set;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SystemTitle = GXDLMSTranslator.HexToBytes(SystemTitleTb.Text);
                if (SystemTitle.Length != 8)
                {
                    throw new ArgumentOutOfRangeException("Invalid system title.");
                }
                if (DigitalSignatureCb.Checked)
                {
                    CertificateType = CertificateType.DigitalSignature;
                }
                else if (KeyAgreementCb.Checked)
                {
                    CertificateType = CertificateType.KeyAgreement;
                }
                else
                {
                    if (ServerTlsCb.Checked)
                    {
                        ExtendedKeyUsage = ExtendedKeyUsage.ServerAuth;
                    }
                    else
                    {
                        ExtendedKeyUsage = ExtendedKeyUsage.ClientAuth;
                    }
                    CertificateType = CertificateType.TLS;
                }
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
