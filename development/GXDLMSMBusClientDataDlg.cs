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
    public partial class GXDLMSMBusClientDataDlg : Form
    {
        public GXMBusClientData Data
        {
            get;
            private set;
        }

        public GXDLMSMBusClientDataDlg(GXMBusClientData data)
        {
            InitializeComponent();
            Data = data;
            foreach (DataType it in Enum.GetValues(typeof(DataType)))
            {
                if (it != DataType.None && it != DataType.Array && it != DataType.Structure)
                {
                    DataTypeCb.Items.Add(it);
                }
            }
            ValueInformationTb.Text = GXDLMSTranslator.ToHex(data.ValueInformation);
            DataInformationTb.Text = GXDLMSTranslator.ToHex(data.DataInformation);
            if (data.Data is byte[])
            {
                DataTb.Text = GXDLMSTranslator.ToHex((byte[])data.Data);
            }
            else
            {
                DataTb.Text = Convert.ToString(data.Data);
            }
            DataTypeCb.SelectedItem = GXDLMSConverter.GetDLMSDataType(data.Data);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataTypeCb.SelectedItem == null)
                {
                    throw new Exception("Data type is not selected.");
                }
                if (DataTb.Text == "")
                {
                    throw new Exception("Invalid data.");
                }
                Data.ValueInformation = GXDLMSTranslator.HexToBytes(ValueInformationTb.Text);
                Data.DataInformation = GXDLMSTranslator.HexToBytes(DataInformationTb.Text);
                Data.Data = Convert.ChangeType(DataTb.Text, GXDLMSConverter.GetDataType((DataType)DataTypeCb.SelectedItem));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
