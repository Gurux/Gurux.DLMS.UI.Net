//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: $
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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.Objects;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSSpecialDaysTableDlg : Form
    {
        /// <summary>
        /// Selected item.
        /// </summary>
        internal GXDLMSSpecialDay Item;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="readOnly"></param>
        public GXDLMSSpecialDaysTableDlg(GXDLMSSpecialDay item, bool readOnly)
        {
            InitializeComponent();
            Item = item;      
            if (readOnly)
            {
                IndexTb.ReadOnly = DateTb.ReadOnly = DayIdTb.ReadOnly = true;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item.Index = UInt16.Parse(IndexTb.Text);
                Item.Date = new GXDate(DateTb.Text);
                Item.DayId = byte.Parse(DayIdTb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GXDLMSSpecialDaysTableDlg_Load(object sender, EventArgs e)
        {
            IndexTb.Text = Item.Index.ToString();
            if (Item.Date == null)
            {
                Item.Date = new GXDate(DateTime.Now);
            }
            DateTb.Text = Item.Date.ToFormatString();
            DayIdTb.Text = Item.DayId.ToString();
        }
    }
}
