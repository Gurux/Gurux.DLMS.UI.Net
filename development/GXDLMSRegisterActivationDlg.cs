//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL$
//
// Version:         $Revision$,
//                  $Date$
//                  $Author$
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
// More information of Gurux products: https://www.gurux.org
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSRegisterActivationDlg : Form
    {
        public byte[] MaskName
        {
            get;
            set;
        }
        public byte[] IndexArray
        {
            get;
            set;
        }

        public static string GetAsHex(string value, bool ascii)
        {
            if (ascii)
            {
                return GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(value), false);
            }
            return GXDLMSTranslator.ToHex(GXDLMSTranslator.HexToBytes(value), false);
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="caption">Window caption.</param>
        /// <param name="target">Selected objects.</param>
        /// <param name="indexArray">Register activation indexes.</param>
        /// <param name="objects">List of COSEM objects.</param>
        public GXDLMSRegisterActivationDlg(string caption, byte[] maskName, byte[] indexArray)
        {
            InitializeComponent();
            Text = caption;
            if (IsAscii(maskName))
            {
                SystemTitleAsciiCb.CheckedChanged -= SystemTitleAsciiCb_CheckedChanged;
                SystemTitleAsciiCb.Checked = true;
                SystemTitleAsciiCb.CheckedChanged += SystemTitleAsciiCb_CheckedChanged;
                if (maskName != null)
                {
                    NameTb.Text = ASCIIEncoding.ASCII.GetString(maskName);
                }
            }
            else
            {
                SystemTitleAsciiCb.CheckedChanged -= SystemTitleAsciiCb_CheckedChanged;
                SystemTitleAsciiCb.Checked = false;
                SystemTitleAsciiCb.CheckedChanged += SystemTitleAsciiCb_CheckedChanged;
                NameTb.Text = GXDLMSTranslator.ToHex(maskName);
            }
            if (indexArray != null)
            {
                bool empty = true;
                foreach(byte it in indexArray)
                {
                    if (empty)
                    {
                        empty = false;
                    }
                    else
                    {
                        IndexTB.AppendText(", ");
                    }
                    IndexTB.AppendText(it.ToString());
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MaskName = GXDLMSTranslator.HexToBytes(GetAsHex(NameTb.Text, SystemTitleAsciiCb.Checked));
                if (MaskName.Length == 0)
                {
                    throw new Exception("Invalid mask name.");
                }
                string[] values = IndexTB.Text.Split(new char[] { ' ', ';', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
                List<byte> arr = new List<byte>();
                foreach (string it in values)
                {
                    arr.Add(byte.Parse(it));
                }
                IndexArray = arr.ToArray();
                if (IndexArray.Length == 0)
                {
                    throw new Exception("Invalid index array.");
                }
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool IsAscii(byte[] value)
        {
            if (value != null)
            {
                foreach (byte it in value)
                {
                    if (it < 0x21 || it > 0x7E)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void SystemTitleAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (SystemTitleAsciiCb.Checked)
                {
                    if (!IsAscii(GXDLMSTranslator.HexToBytes(NameTb.Text)))
                    {
                        SystemTitleAsciiCb.CheckedChanged -= SystemTitleAsciiCb_CheckedChanged;
                        SystemTitleAsciiCb.Checked = !SystemTitleAsciiCb.Checked;
                        SystemTitleAsciiCb.CheckedChanged += SystemTitleAsciiCb_CheckedChanged;
                        throw new ArgumentOutOfRangeException("There are non ASCII chars.");
                    }
                    NameTb.Text = ASCIIEncoding.ASCII.GetString(GXDLMSTranslator.HexToBytes(NameTb.Text));
                }
                else
                {
                    NameTb.Text = GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(NameTb.Text), true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }
    }
}
