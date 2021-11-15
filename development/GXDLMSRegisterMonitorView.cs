//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSRegisterMonitorView.cs $
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

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSRegisterMonitor
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSRegisterMonitor))]
    partial class GXDLMSRegisterMonitorView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSRegisterMonitorView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        private void UpdateMonitoredValueTargets()
        {
            GXDLMSRegisterMonitor target = Target as GXDLMSRegisterMonitor;
            this.MonitoredValueCb.SelectedIndexChanged -= new System.EventHandler(this.MonitoredValueCb_SelectedIndexChanged);
            try
            {
                MonitoredValueCb.Items.Clear();
                if (target.Parent != null)
                {
                    if (ShowAllTargetsCb.Checked)
                    {
                        foreach (GXDLMSObject it in target.Parent)
                        {
                            MonitoredValueCb.Items.Add(it);
                        }
                    }
                    else
                    {
                        foreach (GXDLMSObject it in target.Parent.GetObjects(
                            new ObjectType[] { ObjectType.Data, ObjectType.Register, ObjectType.ExtendedRegister, ObjectType.DemandRegister }))
                        {
                            MonitoredValueCb.Items.Add(it);
                        }
                    }
                }
                else if (target.MonitoredValue != null && target.MonitoredValue.ObjectType != ObjectType.None)
                {
                    GXDLMSObject obj = GXDLMSClient.CreateObject(target.MonitoredValue.ObjectType);
                    obj.LogicalName = target.MonitoredValue.LogicalName;
                    MonitoredValueCb.Items.Add(obj);
                }
                if (target.MonitoredValue != null && target.MonitoredValue.ObjectType != ObjectType.None)
                {
                    if (target.Parent != null)
                    {
                        MonitoredValueCb.SelectedItem = target.Parent.FindByLN(target.MonitoredValue.ObjectType, target.MonitoredValue.LogicalName);
                    }
                    else
                    {
                        GXDLMSObject it = GXDLMSClient.CreateObject(target.MonitoredValue.ObjectType);
                        it.LogicalName = target.MonitoredValue.LogicalName;
                        MonitoredValueCb.SelectedItem = it;
                    }
                    AttributeIndexTB.Text = target.MonitoredValue.AttributeIndex.ToString();
                }
                else
                {
                    MonitoredValueCb.SelectedItem = null;
                    AttributeIndexTB.Text = "";
                }
            }
            finally
            {
                this.MonitoredValueCb.SelectedIndexChanged += new System.EventHandler(this.MonitoredValueCb_SelectedIndexChanged);
            }
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSRegisterMonitor target = Target as GXDLMSRegisterMonitor;
            if (index == 2)
            {
            }
            else if (index == 3)
            {
                UpdateMonitoredValueTargets();
            }
            else if (index == 4)
            {
                ActionsLV.Items.Clear();
                if (target.Actions != null)
                {
                    int pos = 0;
                    foreach (GXDLMSActionSet it in target.Actions)
                    {
                        string threshold = "";
                        if (target.Thresholds != null && target.Thresholds.Length > pos)
                        {
                            threshold = Convert.ToString(target.Thresholds[pos]);
                        }
                        ++pos;
                        ListViewItem li = ActionsLV.Items.Add(threshold);
                        li.SubItems.AddRange(new string[] {it.ActionUp.LogicalName, it.ActionUp.ScriptSelector.ToString(),
                                                        it.ActionDown.LogicalName, it.ActionDown.ScriptSelector.ToString()
                                                      });
                    }
                    //Add extra Thresholds.
                    if (target.Thresholds != null && pos < target.Thresholds.Length)
                    {
                        for (; pos != target.Thresholds.Length; ++pos)
                        {
                            string threshold = Convert.ToString(target.Thresholds[pos]);
                            ListViewItem li = ActionsLV.Items.Add(threshold);
                            li.SubItems.AddRange(new string[] {"", "",
                                                        "", ""});
                        }
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 2)
            {
            }
            else if (index == 3)
            {
                MonitoredValueCb.Enabled = enabled;
                AttributeIndexTB.ReadOnly = !enabled;
            }
            else if (index == 4)
            {
                ActionAddBtn.Enabled = ActionEditBtn.Enabled = ActionRemoveBtn.Enabled = enabled;
            }
            else
            {
                throw new ArgumentException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        public void PreAction(GXActionArgs arg)
        {
            throw new ArgumentException("index");
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
                return DescriptionTB.Text;
            }
            set
            {
                DescriptionTB.Text = value;
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {
            switch (index)
            {
                case 2:
                    //Threadsholds are saved to actions list.
                    errorProvider1.SetError(ActionsLV, Properties.Resources.ValueChangedTxt);
                    break;
                case 3:
                    errorProvider1.SetError(MonitoredValueCb, Properties.Resources.ValueChangedTxt);
                    errorProvider1.SetError(AttributeIndexTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 4:
                    errorProvider1.SetError(ActionsLV, Properties.Resources.ValueChangedTxt);
                    break;
                default:
                    errorProvider1.Clear();
                    break;
            }
        }

        #endregion

        /// <summary>
        /// User changes attribute index of monitored value.
        /// </summary>
        private void AttributeIndexTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v = byte.Parse(AttributeIndexTB.Text);
                (Target as GXDLMSRegisterMonitor).MonitoredValue.AttributeIndex = v;
                Target.UpdateDirty(3, v);
                errorProvider1.SetError(AttributeIndexTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonitoredValueCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (MonitoredValueCb.SelectedItem != null)
                {
                    GXDLMSObject obj = (GXDLMSObject)MonitoredValueCb.SelectedItem;
                    (Target as GXDLMSRegisterMonitor).MonitoredValue.LogicalName = obj.LogicalName;
                    (Target as GXDLMSRegisterMonitor).MonitoredValue.ObjectType = obj.ObjectType;
                }
                else
                {
                    (Target as GXDLMSRegisterMonitor).MonitoredValue.LogicalName = null;
                    (Target as GXDLMSRegisterMonitor).MonitoredValue.ObjectType = ObjectType.None;
                }
                Target.UpdateDirty(3, MonitoredValueCb.SelectedItem);
                errorProvider1.SetError(MonitoredValueCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///Add new action script and threshold.
        /// </summary>
        private void ActionAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSRegisterMonitor target = Target as GXDLMSRegisterMonitor;
                GXRegisterMonitorTargetDlg dlg = new GXRegisterMonitorTargetDlg(target, target.Thresholds.Length, false);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    errorProvider1.SetError(ActionsLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.Thresholds);
                    Target.UpdateDirty(4, target.Actions);
                    GXDLMSActionSet it = target.Actions[target.Actions.Length - 1];
                    ListViewItem li = ActionsLV.Items.Add(Convert.ToString(target.Thresholds[target.Thresholds.Length - 1]));
                    li.SubItems.AddRange(new string[] {it.ActionUp.LogicalName, it.ActionUp.ScriptSelector.ToString(),
                                                        it.ActionDown.LogicalName, it.ActionDown.ScriptSelector.ToString()
                                                      });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///Edit action script and threshold.
        /// </summary>
        private void ActionEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActionsLV.SelectedItems.Count == 1)
                {
                    ListViewItem li = ActionsLV.SelectedItems[0];
                    int index = ActionsLV.Items.IndexOf(li);
                    GXDLMSRegisterMonitor target = Target as GXDLMSRegisterMonitor;
                    GXRegisterMonitorTargetDlg dlg = new GXRegisterMonitorTargetDlg(target, index, false);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        errorProvider1.SetError(ActionsLV, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(2, target.Thresholds);
                        Target.UpdateDirty(4, target.Actions);
                        GXDLMSActionSet it = target.Actions[index];
                        li.SubItems[0].Text = Convert.ToString(target.Thresholds[index]);
                        li.SubItems[1].Text = it.ActionUp.LogicalName;
                        li.SubItems[2].Text = it.ActionUp.ScriptSelector.ToString();
                        li.SubItems[3].Text = it.ActionDown.LogicalName;
                        li.SubItems[4].Text = it.ActionDown.ScriptSelector.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///Remove action script and threshold.
        /// </summary>
        private void ActionRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSRegisterMonitor target = Target as GXDLMSRegisterMonitor;
                List<object> thresholds = new List<object>();
                if (target.Thresholds != null)
                {
                    thresholds.AddRange(target.Thresholds);
                }
                List<GXDLMSActionSet> actions = new List<GXDLMSActionSet>();
                if (target.Actions != null)
                {
                    actions.AddRange(target.Actions);
                }
                List<ListViewItem> list = new List<ListViewItem>();
                foreach (ListViewItem it in ActionsLV.SelectedItems)
                {
                    list.Add(it);
                }
                foreach (ListViewItem it in list)
                {
                    int index = ActionsLV.SelectedItems.IndexOf(it);
                    ActionsLV.Items.RemoveAt(index);
                    errorProvider1.SetError(ActionsLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.Thresholds);
                    Target.UpdateDirty(4, target.Actions);
                    thresholds.RemoveAt(index);
                    actions.RemoveAt(index);
                }
                target.Thresholds = thresholds.ToArray();
                target.Actions = actions.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowAllTargetsCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateMonitoredValueTargets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
