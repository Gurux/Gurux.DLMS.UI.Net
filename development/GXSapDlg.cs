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
    public partial class GXSapDlg : Form
    {
        /// <summary>
        /// Id
        /// </summary>
        internal UInt16 SapId
        {
            get;
            private set;
        }

        /// <summary>
        /// Logical device Name.
        /// </summary>
        internal string LogicalDeviceName
        {
            get;
            private set;
        }

        public GXSapDlg(UInt16 id, string name, bool remove)
        {
            SapId = id;
            LogicalDeviceName = name;
            InitializeComponent();
            if (SapId != 0)
            {
                Text = "Remove SAP assigment";
                NameTb.ReadOnly = IdTb.ReadOnly = true;
                IdTb.Text = SapId.ToString();
            }
            else
            {
                Text = "Add new SAP assigment";
            }
            NameTb.Text = LogicalDeviceName;
            IdTb.ReadOnly = NameTb.ReadOnly = remove;
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
                SapId = UInt16.Parse(IdTb.Text);
                LogicalDeviceName = NameTb.Text;
                if (LogicalDeviceName.Trim().Length == 0)
                {
                    throw new Exception("Logical device name is invalid.");
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
