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
    public partial class GXTextDlg : Form
    {
        Type type = null;
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="caption">Window caption.</param>
        /// <param name="label">Text label.</param>
        /// <param name="value">Text Value.</param>
        public GXTextDlg(string caption, string label, string value)
        {
            InitializeComponent();
            this.Text = caption;
            TextLbl.Text = label;
            TextTb.Text = value;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="caption">Window caption.</param>
        /// <param name="label">Text label.</param>
        /// <param name="value">Text Value.</param>
        /// <param name="type">Data type.</param>
        public GXTextDlg(string caption, string label, string value, Type type)
        {
            InitializeComponent();
            this.Text = caption;
            TextLbl.Text = label;
            TextTb.Text = value;
            this.type = type;
        }

        public string GetValue()
        {
            return TextTb.Text;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextTb.Text.Length == 0)
                {
                    throw new ArgumentOutOfRangeException(TextLbl.Text + " is invalid.");
                }
                if (type != null)
                {
                    if (type == typeof(byte[]))
                    {
                        GXDLMSTranslator.HexToBytes(TextTb.Text);
                    }
                    else
                    {
                        Convert.ChangeType(TextTb.Text, type);
                    }
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
