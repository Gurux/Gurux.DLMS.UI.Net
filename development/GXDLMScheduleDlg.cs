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
using Gurux.DLMS.Objects.Enums;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMScheduleDlg : Form
    {
        GXScheduleEntry entry;
        public GXDLMScheduleDlg(
            GXScheduleEntry e,
            GXDLMSObjectCollection objects, int index)
        {
            entry = e;
            if (entry.SwitchTime == null)
            {
                entry.SwitchTime = new GXTime();
            }
            if (entry.BeginDate == null)
            {
                entry.BeginDate = new GXDate(-1, 1, 1);
            }
            if (entry.EndDate == null)
            {
                entry.EndDate = new GXDate(-1, 1, 1);
            }
            InitializeComponent();
            foreach (GXDLMSObject it in objects.GetObjects(ObjectType.ScriptTable))
            {
                ScriptTb.Items.Add(it);
            }
            ScriptTb.SelectedItem = entry.Script;
            IndexTB.Text = entry.Index.ToString();
            EnabledCb.Checked = entry.Enable;
            SelectorTb.Text = entry.ScriptSelector.ToString();
            TimeTb.Text = entry.SwitchTime.ToFormatString();
            MondayCb.Checked = (entry.ExecWeekdays & Weekdays.Monday) != 0;
            TuesdayCb.Checked = (entry.ExecWeekdays & Weekdays.Tuesday) != 0;
            WednesdayCb.Checked = (entry.ExecWeekdays & Weekdays.Wednesday) != 0;
            ThursdayCb.Checked = (entry.ExecWeekdays & Weekdays.Thursday) != 0;
            FridayCb.Checked = (entry.ExecWeekdays & Weekdays.Friday) != 0;
            SaturdayCb.Checked = (entry.ExecWeekdays & Weekdays.Saturday) != 0;
            SundayCb.Checked = (entry.ExecWeekdays & Weekdays.Sunday) != 0;
            ValidityWindowTb.Text = entry.ValidityWindow.ToString();
            ExecSpecDaysTb.Text = entry.ExecSpecDays;
            BeginTb.Text = entry.BeginDate.ToFormatString();
            EndTb.Text = entry.EndDate.ToFormatString();
            //Enable/Disable
            if (index == 1)
            {
                this.Text = "Enable/Disable schedule entry";
                ScriptTb.Enabled = false;
                IndexTB.ReadOnly = true;
                EnabledCb.Enabled = true;
                SelectorTb.ReadOnly = true;
                TimeTb.ReadOnly = true;
                MondayCb.Enabled = false;
                TuesdayCb.Enabled = false;
                WednesdayCb.Enabled = false;
                ThursdayCb.Enabled = false;
                FridayCb.Enabled = false;
                SaturdayCb.Enabled = false;
                SundayCb.Enabled = false;
                ValidityWindowTb.ReadOnly = true;
                ExecSpecDaysTb.ReadOnly = true;
                BeginTb.ReadOnly = true;
                EndTb.ReadOnly = true;
            }
            else if (index == 2)
            {
                this.Text = "Add schedule entry";
            }
            //Remove
            else if (index == 3)
            {
                this.Text = "Remove schedule entry";
                ScriptTb.Enabled = false;
                IndexTB.ReadOnly = true;
                EnabledCb.Enabled = false;
                SelectorTb.ReadOnly = true;
                TimeTb.ReadOnly = true;
                MondayCb.Enabled = false;
                TuesdayCb.Enabled = false;
                WednesdayCb.Enabled = false;
                ThursdayCb.Enabled = false;
                FridayCb.Enabled = false;
                SaturdayCb.Enabled = false;
                SundayCb.Enabled = false;
                ValidityWindowTb.ReadOnly = true;
                ExecSpecDaysTb.ReadOnly = true;
                BeginTb.ReadOnly = true;
                EndTb.ReadOnly = true;
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ScriptTb.SelectedItem == null)
                {
                    throw new Exception("Target is not selected.");
                }
                entry.Index = Convert.ToUInt16(IndexTB.Text);
                if (entry.Index == 0)
                {
                    throw new Exception("Invalid index. Index is one based.");
                }
                entry.Enable = EnabledCb.Checked;
                entry.Script = (GXDLMSScriptTable)ScriptTb.SelectedItem;
                entry.ScriptSelector = Convert.ToUInt16(SelectorTb.Text);
                entry.SwitchTime = new GXTime(TimeTb.Text);
                entry.ExecWeekdays = Weekdays.None;
                if (MondayCb.Checked)
                {
                    entry.ExecWeekdays |= Weekdays.Monday;
                }
                if (TuesdayCb.Checked)
                {
                    entry.ExecWeekdays |= Weekdays.Tuesday;
                }
                if (WednesdayCb.Checked)
                {
                    entry.ExecWeekdays |= Weekdays.Wednesday;
                }
                if (ThursdayCb.Checked)
                {
                    entry.ExecWeekdays |= Weekdays.Thursday;
                }
                if (FridayCb.Checked)
                {
                    entry.ExecWeekdays |= Weekdays.Friday;
                }
                if (SaturdayCb.Checked)
                {
                    entry.ExecWeekdays |= Weekdays.Saturday;
                }
                if (SundayCb.Checked)
                {
                    entry.ExecWeekdays |= Weekdays.Sunday;
                }
                entry.ValidityWindow = Convert.ToUInt16(ValidityWindowTb.Text);
                entry.ExecSpecDays = ExecSpecDaysTb.Text;
                entry.BeginDate = new GXDate(BeginTb.Text);
                entry.EndDate = new GXDate(EndTb.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
