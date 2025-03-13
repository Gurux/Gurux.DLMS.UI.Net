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

using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXRegisterMonitorThresholdDlg : Form
    {
        GXDLMSRegisterMonitor Target;
        int Index;

        public GXRegisterMonitorThresholdDlg(GXDLMSRegisterMonitor target,
            int index,
            bool remove)
        {
            InitializeComponent();
            Target = target;
            Index = index;
            foreach (DataType it in Enum.GetValues(typeof(DataType)))
            {
                if (it != DataType.None && it != DataType.Array && it != DataType.Structure)
                {
                    ValueTypeTb.Items.Add(it);
                }
            }
            if (remove)
            {
                Text = "Remove Threshold";
            }
            else
            {
                Text = "Add new Threshold";
            }
            if (target.Thresholds != null && index < target.Thresholds.Length)
            {
                ValueTb.Text = Convert.ToString(target.Thresholds[index]);
            }
            if (target.Thresholds != null && target.Thresholds.Length != 0)
            {
                ValueTypeTb.SelectedItem = GXDLMSConverter.GetDLMSDataType(target.Thresholds[0]);
            }
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
                if (ValueTypeTb.SelectedItem == null || (DataType)ValueTypeTb.SelectedItem == DataType.None)
                {
                    throw new Exception("Invalid value type.");
                }
                if (ValueTb.Text.Length == 0)
                {
                    throw new Exception("Invalid value.");
                }
                if (Target.Thresholds != null && Index < Target.Thresholds.Length)
                {
                    Target.Thresholds[Index] = GXDLMSConverter.ChangeType(ValueTb.Text, (DataType)ValueTypeTb.SelectedItem, null);
                }
                else
                {
                    //We are adding new item.
                    List<object> thresholds = new List<object>();
                    if (Target.Thresholds != null)
                    {
                        thresholds.AddRange(Target.Thresholds);
                    }
                    thresholds.Add(GXDLMSConverter.ChangeType(ValueTb.Text, (DataType)ValueTypeTb.SelectedItem, null));
                    Target.Thresholds = thresholds.ToArray();
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
