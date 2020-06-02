//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSLimiterView.cs $
//
// Version:         $Revision: 5795 $,
//                  $Date: 2012-10-02 13:22:54 +0300 (ti, 02 loka 2012) $
//                  $Author: kurumi $
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// file is a part of Gurux Device Framework.
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
// code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSLimiter
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSLimiter))]
    partial class GXDLMSLimiterView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSLimiterView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            if (index == 2)
            {
                MonitoredValueTB.Items.Clear();
                int pos, selected = -1;
                if (Target.Parent != null)
                {
                    foreach (object it in Target.Parent)
                    {
                        pos = MonitoredValueTB.Items.Add(it);
                        if (it == ((GXDLMSLimiter)Target).MonitoredValue)
                        {
                            selected = pos;
                        }
                    }
                }
                if (selected != -1)
                {
                    MonitoredValueTB.SelectedIndexChanged -= new System.EventHandler(MonitoredValueTB_SelectedIndexChanged);
                    MonitoredValueTB.SelectedIndex = selected;
                    MonitoredValueTB.SelectedIndexChanged += new System.EventHandler(MonitoredValueTB_SelectedIndexChanged);
                }
                MonitoredIndexTB.Leave -= new System.EventHandler(MonitoredIndexTB_Leave);
                MonitoredIndexTB.Text = ((GXDLMSLimiter)Target).MonitoredAttributeIndex.ToString();
                MonitoredIndexTB.Leave += new System.EventHandler(MonitoredIndexTB_Leave);
            }
            else if (index == 8)
            {
                IdTb.Leave -= new System.EventHandler(IdTb_Leave);
                IdTb.Text = ((GXDLMSLimiter)Target).EmergencyProfile.ID.ToString();
                IdTb.Leave += new System.EventHandler(IdTb_Leave);

                ActivationTimeTb.Leave -= new System.EventHandler(ActivationTimeTb_Leave);
                if (((GXDLMSLimiter)Target).EmergencyProfile.ActivationTime == null)
                {
                    ActivationTimeTb.Text = "";
                }
                else
                {
                    ActivationTimeTb.Text = ((GXDLMSLimiter)Target).EmergencyProfile.ActivationTime.ToFormatString();
                }
                ActivationTimeTb.Leave += new System.EventHandler(ActivationTimeTb_Leave);

                DurationTb.Leave -= new System.EventHandler(DurationTb_Leave);
                DurationTb.Text = ((GXDLMSLimiter)Target).EmergencyProfile.Duration.ToString();
                DurationTb.Leave += new System.EventHandler(DurationTb_Leave);
            }
            else if (index == 9)
            {
                if (((GXDLMSLimiter)Target).EmergencyProfileGroupIDs != null)
                {
                    EmergencyProfileGroupIDsTB.Leave -= new System.EventHandler(EmergencyProfileGroupIDsTB_Leave);
                    EmergencyProfileGroupIDsTB.Text = string.Join(",", ((GXDLMSLimiter)Target).EmergencyProfileGroupIDs);
                    EmergencyProfileGroupIDsTB.Leave += new System.EventHandler(EmergencyProfileGroupIDsTB_Leave);
                }
            }
            else if (index == 8)
            {
                IdTb.Text = ((GXDLMSLimiter)Target).EmergencyProfile.ID.ToString();
                if (((GXDLMSLimiter)Target).EmergencyProfile.ActivationTime == null)
                {
                    ActivationTimeTb.Text = "";
                }
                else
                {
                    ActivationTimeTb.Text = ((GXDLMSLimiter)Target).EmergencyProfile.ActivationTime.ToFormatString();
                }
                DurationTb.Text = ((GXDLMSLimiter)Target).EmergencyProfile.Duration.ToString();
            }
            else if (index == 9)
            {
                if (((GXDLMSLimiter)Target).EmergencyProfileGroupIDs != null)
                {
                    EmergencyProfileGroupIDsTB.Text = string.Join(",", ((GXDLMSLimiter)Target).EmergencyProfileGroupIDs);
                }
            }
            else if (index == 10)
            {
                EmergencyProfileActiveCB.CheckedChanged -= new System.EventHandler(EmergencyProfileActiveCB_CheckedChanged);
                EmergencyProfileActiveCB.Checked = (bool)value;
                EmergencyProfileActiveCB.CheckedChanged += new System.EventHandler(EmergencyProfileActiveCB_CheckedChanged);
            }
            else if (index == 11)
            {
                ActionOverScript.Items.Clear();
                int pos, selected = -1;
                GXDLMSObjectCollection scripts = null;
                if (Target.Parent != null)
                {
                    scripts = Target.Parent.GetObjects(ObjectType.ScriptTable);
                }
                if (scripts != null)
                {
                    foreach (GXDLMSObject it in scripts)
                    {
                        pos = ActionOverScript.Items.Add(it);
                        if (it.LogicalName == ((GXDLMSLimiter)Target).ActionOverThreshold.LogicalName)
                        {
                            selected = pos;
                        }
                    }
                }
                else if (Target != null)
                {
                    selected = ActionOverScript.Items.Add(new GXDLMSScriptTable(((GXDLMSLimiter)Target).ActionOverThreshold.LogicalName));
                }
                if (selected != -1)
                {
                    ActionOverScript.SelectedIndexChanged -= new System.EventHandler(ActionOverScript_SelectedIndexChanged);
                    ActionOverScript.SelectedIndex = selected;
                    ActionOverScript.SelectedIndexChanged += new System.EventHandler(ActionOverScript_SelectedIndexChanged);
                }

                ActionOverThresholdIndexTB.Leave -= new System.EventHandler(ActionOverThresholdIndexTB_Leave);
                ActionOverThresholdIndexTB.Text = (Target as GXDLMSLimiter).ActionOverThreshold.ScriptSelector.ToString();
                ActionOverThresholdIndexTB.Leave += new System.EventHandler(ActionOverThresholdIndexTB_Leave);

                ActionUnderScript.Items.Clear();
                selected = -1;
                if (scripts != null)
                {
                    foreach (GXDLMSObject it in scripts)
                    {
                        pos = ActionUnderScript.Items.Add(it);
                        if (it.LogicalName == ((GXDLMSLimiter)Target).ActionUnderThreshold.LogicalName)
                        {
                            selected = pos;
                        }
                    }
                }
                else if (Target != null)
                {
                    selected = ActionUnderScript.Items.Add(new GXDLMSScriptTable(((GXDLMSLimiter)Target).ActionUnderThreshold.LogicalName));
                }
                if (selected != -1)
                {
                    ActionUnderScript.SelectedIndexChanged -= new System.EventHandler(ActionUnderScript_SelectedIndexChanged);
                    ActionUnderScript.SelectedIndex = selected;
                    ActionUnderScript.SelectedIndexChanged += new System.EventHandler(ActionUnderScript_SelectedIndexChanged);
                }
                ActionUnderThresholdIndexTB.Leave -= new System.EventHandler(ActionUnderThresholdIndexTB_Leave);
                ActionUnderThresholdIndexTB.Text = (Target as GXDLMSLimiter).ActionUnderThreshold.ScriptSelector.ToString();
                ActionUnderThresholdIndexTB.Leave += new System.EventHandler(ActionUnderThresholdIndexTB_Leave);
            }
            else if (index == 11)
            {
                ActionOverScript.Items.Clear();
                int pos, selected = -1;
                GXDLMSObjectCollection scripts = Target.Parent.GetObjects(ObjectType.ScriptTable);
                foreach (GXDLMSObject it in scripts)
                {
                    pos = ActionOverScript.Items.Add(it);
                    if (it.LogicalName == ((GXDLMSLimiter)Target).ActionOverThreshold.LogicalName)
                    {
                        selected = pos;
                    }
                }
                if (selected != -1)
                {
                    this.ActionOverScript.SelectedIndexChanged -= new System.EventHandler(this.ActionOverScript_SelectedIndexChanged);
                    ActionOverScript.SelectedIndex = selected;
                    this.ActionOverScript.SelectedIndexChanged += new System.EventHandler(this.ActionOverScript_SelectedIndexChanged);
                }

                ActionOverThresholdIndexTB.Text = (Target as GXDLMSLimiter).ActionOverThreshold.ScriptSelector.ToString();

                ActionUnderScript.Items.Clear();
                selected = -1;
                foreach (GXDLMSObject it in scripts)
                {
                    pos = ActionUnderScript.Items.Add(it);
                    if (it.LogicalName == ((GXDLMSLimiter)Target).ActionUnderThreshold.LogicalName)
                    {
                        selected = pos;
                    }
                }
                if (selected != -1)
                {
                    this.ActionUnderScript.SelectedIndexChanged -= new System.EventHandler(this.ActionUnderScript_SelectedIndexChanged);
                    ActionUnderScript.SelectedIndex = selected;
                    this.ActionUnderScript.SelectedIndexChanged += new System.EventHandler(this.ActionUnderScript_SelectedIndexChanged);
                }
                ActionUnderThresholdIndexTB.Text = (Target as GXDLMSLimiter).ActionUnderThreshold.ScriptSelector.ToString();
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
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
                return DescriptionTB.Text;
            }
            set
            {
                DescriptionTB.Text = value;
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {
            if (Dirty && index == 2)
            {
                errorProvider1.SetError(MonitoredValueTB, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 10)
            {
                errorProvider1.SetError(EmergencyProfileActiveCB, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 11)
            {
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 2)
            {
                MonitoredValueTB.Enabled = (access & AccessMode.Write) != 0;
                MonitoredIndexTB.ReadOnly = (access & AccessMode.Write) == 0;
            }
            else if (index == 8)
            {
                DurationTb.ReadOnly = ActivationTimeTb.ReadOnly = IdTb.ReadOnly = (access & AccessMode.Write) == 0;
            }
            else if (index == 9)
            {
                EmergencyProfileGroupIDsTB.ReadOnly = (access & AccessMode.Write) == 0;
            }
            else if (index == 10)
            {
                EmergencyProfileActiveCB.Enabled = (access & AccessMode.Write) != 0;
            }
            else if (index == 11)
            {
                ActionOverScript.Enabled = ActionUnderScript.Enabled = ActionOverScript.Enabled = (access & AccessMode.Write) != 0;
                ActionUnderThresholdIndexTB.ReadOnly = ActionOverThresholdIndexTB.ReadOnly = (access & AccessMode.Write) == 0;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }



        #endregion

        private void EmergencyProfileActiveCB_CheckedChanged(object sender, EventArgs e)
        {
            bool check = EmergencyProfileActiveCB.Checked;
            (Target as GXDLMSLimiter).EmergencyProfileActive = check;
            Target.UpdateDirty(8, check);
            errorProvider1.SetError(EmergencyProfileActiveCB, Properties.Resources.ValueChangedTxt);
        }

        private void MonitoredIndexTB_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(MonitoredIndexTB.Text);
                (Target as GXDLMSLimiter).MonitoredAttributeIndex = index;
                Target.UpdateDirty(2, index);
                errorProvider1.SetError(MonitoredIndexTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionOverThresholdIndexTB_Leave(object sender, EventArgs e)
        {
            try
            {
                ushort index = ushort.Parse(ActionOverThresholdIndexTB.Text);
                (Target as GXDLMSLimiter).ActionOverThreshold.ScriptSelector = index;
                Target.UpdateDirty(11, index);
                errorProvider1.SetError(ActionOverThresholdIndexTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionUnderThresholdIndexTB_Leave(object sender, EventArgs e)
        {
            try
            {
                ushort selector = ushort.Parse(ActionUnderThresholdIndexTB.Text);
                (Target as GXDLMSLimiter).ActionUnderThreshold.ScriptSelector = selector;
                Target.UpdateDirty(11, selector);
                errorProvider1.SetError(ActionUnderThresholdIndexTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MonitoredValueTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSObject mv = (GXDLMSObject)MonitoredValueTB.SelectedItem;
                (Target as GXDLMSLimiter).MonitoredValue = mv;
                Target.UpdateDirty(2, mv);
                errorProvider1.SetError(MonitoredValueTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionOverScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSObject mv = (GXDLMSObject)ActionOverScript.SelectedItem;
                if (mv == null)
                {
                    (Target as GXDLMSLimiter).ActionOverThreshold.LogicalName = null;
                }
                else
                {
                    (Target as GXDLMSLimiter).ActionOverThreshold.LogicalName = mv.LogicalName;
                }
                Target.UpdateDirty(11, mv);
                errorProvider1.SetError(ActionOverScript, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActionUnderScript_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSObject mv = (GXDLMSObject)ActionUnderScript.SelectedItem;
                if (mv == null)
                {
                    (Target as GXDLMSLimiter).ActionUnderThreshold.LogicalName = null;
                }
                else
                {
                    (Target as GXDLMSLimiter).ActionUnderThreshold.LogicalName = mv.LogicalName;
                }
                Target.UpdateDirty(11, mv);
                errorProvider1.SetError(ActionUnderScript, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmergencyProfileGroupIDsTB_Leave(object sender, EventArgs e)
        {
            try
            {
                List<UInt16> list = new List<UInt16>();
                string[] arr = EmergencyProfileGroupIDsTB.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string it in arr)
                {
                    list.Add(UInt16.Parse(it));
                }
                (Target as GXDLMSLimiter).EmergencyProfileGroupIDs = list.ToArray();
                Target.UpdateDirty(9, (Target as GXDLMSLimiter).EmergencyProfileGroupIDs);
                errorProvider1.SetError(EmergencyProfileGroupIDsTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void IdTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSLimiter).EmergencyProfile.ID = UInt16.Parse(IdTb.Text);
                Target.UpdateDirty(8, (Target as GXDLMSLimiter).EmergencyProfile);
                errorProvider1.SetError(IdTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivationTimeTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSLimiter).EmergencyProfile.ActivationTime = new GXDateTime(ActivationTimeTb.Text);
                Target.UpdateDirty(8, (Target as GXDLMSLimiter).EmergencyProfile);
                errorProvider1.SetError(ActivationTimeTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DurationTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSLimiter).EmergencyProfile.Duration = UInt16.Parse(DurationTb.Text);
                Target.UpdateDirty(8, (Target as GXDLMSLimiter).EmergencyProfile);
                errorProvider1.SetError(DurationTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
