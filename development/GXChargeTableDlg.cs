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
    public partial class GXChargeTableDlg : Form
    {
        /// <summary>
        /// Index.
        /// </summary>
        internal byte[] Index
        {
            get;
            private set;
        }

        /// <summary>
        /// Charge per unit.
        /// </summary>
        internal Int16 ChargePerUnit
        {
            get;
            private set;
        }

        public GXChargeTableDlg(byte[] index, Int16 chargePerUnit, bool remove)
        {
            Index = index;
            ChargePerUnit = chargePerUnit;
            InitializeComponent();
            IndexTb.Text = GXDLMSTranslator.ToHex(Index);
            ChargePerUnitTb.Text = ChargePerUnit.ToString();
            IndexTb.ReadOnly = ChargePerUnitTb.ReadOnly = remove;
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
                Index = GXDLMSTranslator.HexToBytes(IndexTb.Text);
                ChargePerUnit = Int16.Parse(ChargePerUnitTb.Text);
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
