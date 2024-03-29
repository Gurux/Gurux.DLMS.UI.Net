//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSActionScheduleView.cs $
//
// Version:         $Revision: 4781 $,
//                  $Date: 2012-03-19 10:23:38 +0200 (ma, 19 maalis 2012) $
//                  $Author: kurumi $
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
using System.Collections.Generic;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Runtime.Remoting.Messaging;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSActionSchedule
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSActionSchedule))]
    partial class GXDLMSActionScheduleView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSActionScheduleView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSActionSchedule schedule = Target as GXDLMSActionSchedule;
            if (arg.Index == 2)
            {
                ScriptNameTB.Items.Clear();
                if (schedule.Parent != null)
                {
                    foreach (var it in schedule.Parent.GetObjects(ObjectType.ScriptTable))
                    {
                        ScriptNameTB.Items.Add(it);
                        if (schedule.Target == it)
                        {
                            ScriptNameTB.SelectedItem = it;
                        }
                    }
                }
                else if (schedule.Target != null)
                {
                    ScriptNameTB.Items.Add(schedule.Target);
                    ScriptNameTB.SelectedItem = schedule.Target;
                }
                ScriptSelectorTB.Text = schedule.ExecutedScriptSelector.ToString();
            }
            else if (arg.Index == 4)
            {
                Time.Items.Clear();
                if (schedule.ExecutionTime != null)
                {
                    foreach (GXDateTime it in schedule.ExecutionTime)
                    {
                        //Execution time doesn't have deviation. For that reason meter time is not shown.
                        ListViewItem li = Time.Items.Add(it.ToFormatString());
                        li.Tag = it;
                    }
                }
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            bool enabled = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
            if (arg.Index == 2)
            {
                ScriptSelectorTB.ReadOnly = !enabled;
                ScriptNameTB.Enabled = enabled;
            }
            else if (arg.Index == 4)
            {
                TimeAddBtn.Enabled = TimeEditBtn.Enabled = TimeRemoveBtn.Enabled = Time.Enabled = enabled;
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
        {
        }

        public void PreAction(GXActionArgs arg)
        {
        }

        public void PostAction(GXActionArgs arg)
        {
            arg.Action = ActionType.None;
        }

        public System.Windows.Forms.ErrorProvider ErrorProvider
        {
            get
            {
                return errorProvider1;
            }
        }

        public string Description
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {
            switch (index)
            {
                case 2:
                    errorProvider1.SetError(ScriptNameTB, Properties.Resources.ValueChangedTxt);
                    errorProvider1.SetError(ScriptSelectorTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 3:
                    errorProvider1.SetError(ScriptTypeTb, Properties.Resources.ValueChangedTxt);
                    break;
                case 4:
                    errorProvider1.SetError(Time, Properties.Resources.ValueChangedTxt);
                    break;
                default:
                    errorProvider1.Clear();
                    break;
            }
        }



        #endregion

        /// <summary>
        /// Add execution time.
        /// </summary>
        private void TimeAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActionSchedule target = Target as GXDLMSActionSchedule;
                List<GXDateTime> entries = new List<GXDateTime>();
                if (target.ExecutionTime != null)
                {
                    entries.AddRange(target.ExecutionTime);
                }
                GXDateTime it = new GXDateTime(DateTime.Now);
                GXDateTimeDlg dlg = new GXDateTimeDlg(it);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    ListViewItem li = Time.Items.Add(it.ToFormatString());
                    li.Tag = it;
                    entries.Add(it);
                    errorProvider1.SetError(Time, Properties.Resources.ValueChangedTxt);
                    target.ExecutionTime = entries.ToArray();
                    Target.UpdateDirty(4, target.ExecutionTime);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit execution time.
        /// </summary>
        private void TimeEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Time.SelectedItems.Count == 1)
                {
                    GXDLMSActionSchedule target = Target as GXDLMSActionSchedule;
                    List<GXDateTime> entries = new List<GXDateTime>();
                    if (target.ExecutionTime != null)
                    {
                        entries.AddRange(target.ExecutionTime);
                    }
                    ListViewItem li = Time.SelectedItems[0];
                    GXDateTime it = (GXDateTime)li.Tag;
                    GXDateTimeDlg dlg = new GXDateTimeDlg(it);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = it.ToFormatString();
                        errorProvider1.SetError(Time, Properties.Resources.ValueChangedTxt);
                        target.ExecutionTime = entries.ToArray();
                        Target.UpdateDirty(4, target.ExecutionTime);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove execution time.
        /// </summary>
        private void TimeRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActionSchedule target = Target as GXDLMSActionSchedule;
                List<GXDateTime> entries = new List<GXDateTime>();
                if (target.ExecutionTime != null)
                {
                    entries.AddRange(target.ExecutionTime);
                }
                while (Time.SelectedItems.Count != 0)
                {
                    GXDateTime item = (GXDateTime)Time.SelectedItems[0].Tag;
                    Time.Items.Remove(Time.SelectedItems[0]);
                    errorProvider1.SetError(Time, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.ExecutionTime);
                    entries.Remove(item);
                }
                target.ExecutionTime = entries.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScriptNameTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Target as GXDLMSActionSchedule).Target != ScriptNameTB.SelectedItem)
                {
                    (Target as GXDLMSActionSchedule).Target = ScriptNameTB.SelectedItem as GXDLMSScriptTable;
                    Target.UpdateDirty(2, (Target as GXDLMSActionSchedule).Target);
                    errorProvider1.SetError(ScriptNameTB, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Update script selector.
        /// </summary>
        private void ScriptSelectorTB_Leave(object sender, EventArgs e)
        {
            try
            {
                UInt16 v;
                if (UInt16.TryParse(ScriptSelectorTB.Text, out v) && (Target as GXDLMSActionSchedule).ExecutedScriptSelector != v)
                {
                    (Target as GXDLMSActionSchedule).ExecutedScriptSelector = v;
                    Target.UpdateDirty(2, v);
                    errorProvider1.SetError(ScriptSelectorTB, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
