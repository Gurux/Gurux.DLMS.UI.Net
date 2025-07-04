﻿//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSActivityCalendarView.cs $
//
// Version:         $Revision: 8933 $,
//                  $Date: 2016-11-23 09:20:07 +0200 (ke, 23 marras 2016) $
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
using Gurux.DLMS.Objects;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSActivityCalendarActionDlg : Form
    {
        GXDLMSDayProfileAction Target;
        public GXDLMSActivityCalendarActionDlg(GXDLMSDayProfileAction target, GXDLMSObjectCollection scripts)
        {
            InitializeComponent();
            Target = target;
            if (target.StartTime != DateTime.MinValue)
            {
                TimeTb.Text = target.StartTime.ToFormatString();
            }
            else
            {
                //Add default value.
                TimeTb.Text = new GXTime(0, 0, 0, 0).ToFormatString();
            }
            int pos, selected = -1;
            foreach (GXDLMSObject it in scripts)
            {
                pos = ScriptCb.Items.Add(it);
                if (it.LogicalName == target.ScriptLogicalName)
                {
                    selected = pos;
                }
            }
            if (selected != -1)
            {
                ScriptCb.SelectedIndex = selected;
            }
            SelectorTb.Text = target.ScriptSelector.ToString();
            OkBtn.Enabled = scripts.Count != 0;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Target.ScriptSelector = UInt16.Parse(SelectorTb.Text);
                if (Target.ScriptSelector < 1)
                {
                    throw new Exception("Invalid script selector.");
                }
                if (ScriptCb.SelectedIndex == -1)
                {
                    throw new Exception("Select script to execute.");
                }
                Target.ScriptLogicalName = (ScriptCb.SelectedItem as GXDLMSScriptTable).LogicalName;
                Target.StartTime = new GXTime(TimeTb.Text);
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
