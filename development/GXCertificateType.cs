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

using Gurux.DLMS.Objects.Enums;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXCertificateType : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="caption">Window caption.</param>
        public GXCertificateType(string caption)
        {
            InitializeComponent();
            this.Text = caption;
        }

        public CertificateType GetValue()
        {
            if (DigitalSignatureKeyPairRb.Checked)
            {
                return CertificateType.DigitalSignature;
            }
            else if (KeyAgreementKeyPairRb.Checked)
            {
                return CertificateType.KeyAgreement;
            }
            return CertificateType.TLS;
        }
    }
}
