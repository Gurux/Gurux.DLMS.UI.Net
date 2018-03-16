//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
//
// Version:         $Revision: 9442 $,
//                  $Date: 2017-05-23 15:21:03 +0300 (ti, 23 touko 2017) $
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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using System.Text;
using Gurux.DLMS.Objects.Enums;

namespace Gurux.DLMS.UI
{
    public partial class GXSecuritySetupKeyDlg : Form
    {
        public GXSecuritySetupKeyDlg(int version)
        {
            InitializeComponent();
            GlobalKeyType type = (GlobalKeyType)Properties.Settings.Default.SecurityType;
            foreach (GlobalKeyType it in Enum.GetValues(typeof(GlobalKeyType)))
            {
                if (version == 0 && it == GlobalKeyType.Kek)
                {
                    break;
                }
                SecurityPolicyTB.Items.Add(it);
                if (it == type)
                {
                    SecurityPolicyTB.SelectedItem = it;
                }
            }
            byte[] key = GXDLMSTranslator.HexToBytes(Properties.Settings.Default.SecurityKey);
            if (key != null)
            {
                if (GXByteBuffer.IsAsciiString(key))
                {
                    KeyTb.Text = ASCIIEncoding.ASCII.GetString(key);
                    KeyAsciiCb.Checked = true;
                }
                else
                {
                    KeyTb.Text = GXDLMSTranslator.ToHex(key);
                }
            }
            //Update KEK.
            key = GXDLMSTranslator.HexToBytes(Properties.Settings.Default.SecurityKek);
            if (key != null)
            {
                if (GXByteBuffer.IsAsciiString(key))
                {
                    KekTb.Text = ASCIIEncoding.ASCII.GetString(key);
                    KekAsciiCb.Checked = true;
                }
                else
                {
                    KekTb.Text = GXDLMSTranslator.ToHex(key);
                }
            }
            
        }

        /// <summary>
        /// Updated key type.
        /// </summary>
        public GlobalKeyType Type
        {
            get;
            private set;
        }

        /// <summary>
        /// Updated key.
        /// </summary>
        public byte[] Key
        {
            get;
            private set;
        }

        /// <summary>
        /// Key Encryption Key.
        /// </summary>
        public byte[] Kek
        {
            get;
            private set;
        }

        /// <summary>
        /// Accept changes.
        /// </summary>
        private void OKBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (KekAsciiCb.Checked)
                {
                    Kek = ASCIIEncoding.ASCII.GetBytes(KekTb.Text);
                }
                else
                {
                    Kek = GXDLMSTranslator.HexToBytes(KekTb.Text);
                }
                if (Kek.Length != 16)
                {
                    throw new Exception("Key Encryption Key is invalid.");
                }
                if (KeyAsciiCb.Checked)
                {
                    Key = ASCIIEncoding.ASCII.GetBytes(KeyTb.Text);
                }
                else
                {
                    Key = GXDLMSTranslator.HexToBytes(KeyTb.Text);
                }
                if (Key.Length != 16)
                {
                    throw new Exception("Key is invalid.");
                }

                Type = (GlobalKeyType)SecurityPolicyTB.SelectedItem;
                Properties.Settings.Default.SecurityKey = GXDLMSTranslator.ToHex(Key, false);
                Properties.Settings.Default.SecurityKek = GXDLMSTranslator.ToHex(Kek, false);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message);
                DialogResult = DialogResult.None;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
