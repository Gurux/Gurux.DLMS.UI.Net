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

using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSNtpDlg : Form
    {
        /// <summary>
        /// Id
        /// </summary>
        internal UInt32 Id
        {
            get;
            private set;
        }

        /// <summary>
        /// Key
        /// </summary>
        internal byte[] Key
        {
            get;
            private set;
        }

        public GXDLMSNtpDlg(UInt32 id, byte[] key, bool remove)
        {
            Id = id;
            InitializeComponent();
            IdTb.Text = id.ToString();
            KeyTb.Text = GXDLMSTranslator.ToHex(key);
            IdTb.ReadOnly = KeyTb.ReadOnly = remove;
        }

        /// <summary>
        /// Accept changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Id = UInt32.Parse(IdTb.Text);
                Key = GXDLMSTranslator.HexToBytes(KeyTb.Text);
                if (Key.Length == 0)
                {
                    throw new Exception("Invalid key.");
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
