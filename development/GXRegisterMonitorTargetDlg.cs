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
    public partial class GXRegisterMonitorTargetDlg : Form
    {
        GXDLMSRegisterMonitor Target;
        int Index;

        public GXRegisterMonitorTargetDlg(GXDLMSRegisterMonitor target, int index, bool remove)
        {
            Target = target;
            Index = index;
            InitializeComponent();
            foreach (DataType it in Enum.GetValues(typeof(DataType)))
            {
                if (it != DataType.None && it != DataType.Array && it != DataType.Structure)
                {
                    ValueTypeTb.Items.Add(it);
                }
            }
            foreach (var it in target.Parent.GetObjects(Enums.ObjectType.ScriptTable))
            {
                UpNameCb.Items.Add(it);
                DownNameCb.Items.Add(it);
            }
            if (remove)
            {
                Text = "Remove Threshold";
                DownNameCb.Enabled = UpNameCb.Enabled = false;
                DownSelectorTb.ReadOnly = UpSelectorTb.ReadOnly = ValueTb.ReadOnly = true;
            }
            else
            {
                Text = "Add new Threshold";
            }
            if (target.Thresholds != null &&index < target.Thresholds.Length)
            {
                ValueTb.Text = Convert.ToString(target.Thresholds[index]);
            }
            if (target.Thresholds != null && target.Thresholds.Length != 0)
            {
                ValueTypeTb.SelectedItem = GXDLMSConverter.GetDLMSDataType(target.Thresholds[0]);
            }
            if (target.Actions != null && index < target.Actions.Length)
            {
                GXDLMSActionSet set1 = target.Actions[index];
                UpNameCb.SelectedItem = target.Parent.FindByLN(Enums.ObjectType.ScriptTable, set1.ActionUp.LogicalName);
                UpSelectorTb.Text = Convert.ToString(set1.ActionUp.ScriptSelector);
                DownNameCb.SelectedItem = target.Parent.FindByLN(Enums.ObjectType.ScriptTable, set1.ActionDown.LogicalName);
                DownSelectorTb.Text = Convert.ToString(set1.ActionDown.ScriptSelector);
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
                if (ValueTypeTb.SelectedItem == null ||(DataType) ValueTypeTb.SelectedItem == DataType.None)
                {
                    throw new Exception("Invalid value type.");
                }
                if (ValueTb.Text.Length == 0)
                {
                    throw new Exception("Invalid value.");
                }
                byte up, down;
                if (!byte.TryParse(UpSelectorTb.Text, out up))
                {
                    throw new Exception("Invalid action up selector.");
                }
                if (!byte.TryParse(DownSelectorTb.Text, out down))
                {
                    throw new Exception("Invalid action down selector.");
                }
                if (UpNameCb.SelectedItem == null)
                {
                    throw new Exception("Invalid action up script.");
                }
                if (DownNameCb.SelectedItem == null)
                {
                    throw new Exception("Invalid action down script.");
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
                GXDLMSActionSet set1;
                if (Target.Actions != null && Index < Target.Actions.Length)
                {
                    set1 = Target.Actions[Index];
                }
                else
                {
                    //We are adding new item.
                    List<GXDLMSActionSet> actions = new List<GXDLMSActionSet>();
                    if (Target.Actions != null)
                    {
                        actions.AddRange(Target.Actions);
                    }
                    set1 = new GXDLMSActionSet();
                    actions.Add(set1);
                    Target.Actions = actions.ToArray();
                }
                set1.ActionUp.LogicalName = ((GXDLMSObject)UpNameCb.SelectedItem).LogicalName;
                set1.ActionUp.ScriptSelector = up;
                set1.ActionDown.LogicalName = ((GXDLMSObject)DownNameCb.SelectedItem).LogicalName;
                set1.ActionDown.ScriptSelector = down;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpSelectorLbl_Click(object sender, EventArgs e)
        {

        }

        private void UpSelectorTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
