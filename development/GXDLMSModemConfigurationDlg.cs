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

using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSModemConfigurationDlg : Form
    {
        public GXDLMSModemInitialisation Data
        {
            get;
            private set;
        }

        public GXDLMSModemConfigurationDlg(GXDLMSModemInitialisation item)
        {
            InitializeComponent();
            Data = item;
            RequestTb.Text = item.Request;
            ResponseTb.Text = item.Response;
            DelayTb.Text = item.Delay.ToString();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RequestTb.Text))
                {
                    throw new Exception("Request is not selected.");
                }
                if (string.IsNullOrEmpty(ResponseTb.Text))
                {
                    throw new Exception("Response is not selected.");
                }
                Data.Request = RequestTb.Text;
                Data.Response = ResponseTb.Text;
                Data.Delay = UInt16.Parse(DelayTb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
