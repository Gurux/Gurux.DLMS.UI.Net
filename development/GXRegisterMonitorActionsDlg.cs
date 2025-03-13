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
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXRegisterMonitorActionsDlg : Form
    {
        GXDLMSActionSet _set;
        GXDLMSRegisterMonitor _target;

        public GXRegisterMonitorActionsDlg(GXDLMSRegisterMonitor target,
            GXDLMSActionSet set,
            bool remove)
        {
            InitializeComponent();
            _target = target;
            _set = set;
            foreach (var it in target.Parent.GetObjects(ObjectType.ScriptTable))
            {
                DownNameCb.Items.Add(it);
                UpNameCb.Items.Add(it);
            }
            if (remove)
            {
                Text = "Remove Threshold";
                DownNameCb.Enabled = UpNameCb.Enabled = false;
                DownSelectorTb.ReadOnly = UpSelectorTb.ReadOnly = true;
            }
            else
            {
                Text = "Add new Threshold";
            }
            UpNameCb.SelectedItem = target.Parent.FindByLN(ObjectType.ScriptTable, _set.ActionUp.LogicalName);
            UpSelectorTb.Text = Convert.ToString(_set.ActionUp.ScriptSelector);
            DownNameCb.SelectedItem = target.Parent.FindByLN(ObjectType.ScriptTable, _set.ActionDown.LogicalName);
            DownSelectorTb.Text = Convert.ToString(_set.ActionDown.ScriptSelector);
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
                byte up, down;
                if (!byte.TryParse(UpSelectorTb.Text, out up))
                {
                    throw new Exception("Invalid action up selector.");
                }
                if (!byte.TryParse(DownSelectorTb.Text, out down))
                {
                    throw new Exception("Invalid action down selector.");
                }               
                _set.ActionUp.LogicalName = ((GXDLMSObject)UpNameCb.SelectedItem).LogicalName;
                _set.ActionUp.ScriptSelector = up;
                _set.ActionDown.LogicalName = ((GXDLMSObject)DownNameCb.SelectedItem).LogicalName;
                _set.ActionDown.ScriptSelector = down;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
