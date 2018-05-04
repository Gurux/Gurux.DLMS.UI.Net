//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSClockView.cs $
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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSClock
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSClock))]
    partial class GXDLMSClockView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSClockView()
        {
            InitializeComponent();
            this.EnabledCB.Checked = false;
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSClock target = Target as GXDLMSClock;
            if (index == 2)
            {
                //This is handled before.
            }
            else if (index == 3)
            {
                int v = (int)value;
                if (target.TimeZone == -32768)//0x8000
                {
                    v = -1;
                    TimeZoneTB.Value = "";
                }
                //If time zone is not used.
                TimeZoneCb.CheckedChanged -= new System.EventHandler(TimeZoneCb_CheckedChanged);
                TimeZoneCb.Checked = v != -1;
                TimeZoneCb.CheckedChanged += new System.EventHandler(TimeZoneCb_CheckedChanged);
                TimeZoneTB.ReadOnly = !connected || v == -1;
            }
            else if (index == 5)
            {
                BeginTB.Value = value;
            }
            else if (index == 6)
            {
                EndTB.Value = value;
            }
            else if (index == 7)
            {
                DeviationTB.Value = value;
            }
            else if (index == 8)
            {
                EnabledCB.CheckedChanged -= new System.EventHandler(EnabledCB_CheckedChanged);
                this.EnabledCB.Checked = target.Enabled;
                BeginTB.ReadOnly = EndTB.ReadOnly = DeviationTB.ReadOnly = !EnabledCB.Checked;
                EnabledCB.CheckedChanged += new System.EventHandler(EnabledCB_CheckedChanged);
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 2)
            {
                TimeTB.ReadOnly = !enabled;
                UpdateTimeBtn.Enabled = enabled;
            }
            else if (index == 3)
            {
                TimeZoneCb.Enabled = enabled;
                CurrentTimeZoneBtn.Enabled = enabled;
            }
            else if (index == 5)
            {
                BeginTB.ReadOnly = !enabled;
            }
            else if (index == 6)
            {
                EndTB.ReadOnly = !enabled;
            }
            else if (index == 7)
            {
                DeviationTB.ReadOnly = !enabled;
            }
            else if (index == 8)
            {
                EnabledCB.Enabled = enabled;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        public void PreAction(GXActionArgs arg)
        {
            DialogResult ret;
            if (arg.Action == ActionType.Write)
            {
                if (arg.Index == 2)
                {
                    //Update current time
                    ret = GXHelpers.ShowMessageBox(this, Properties.Resources.TimeSetWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        (Target as GXDLMSClock).Time = DateTime.Now;
                    }
                    arg.Handled = ret != DialogResult.Yes;
                }
                else if (arg.Index == 3)
                {
                    //Update current time zone.
                    ret = GXHelpers.ShowMessageBox(this, Properties.Resources.TimeZoneSetWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        (Target as GXDLMSClock).TimeZone = -(int)TimeZoneInfo.Local.BaseUtcOffset.TotalMinutes;
                        Target.UpdateDirty(3, (Target as GXDLMSClock).TimeZone);
                    }
                    arg.Handled = ret != DialogResult.Yes;
                }
            }
            else if (arg.Action == ActionType.Action)
            {
                arg.Value = (sbyte)0;
            }
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
                    errorProvider1.SetError(TimeTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 3:
                    errorProvider1.SetError(TimeZoneTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 4:
                    errorProvider1.SetError(StatusTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 5:
                    errorProvider1.SetError(BeginTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 6:
                    errorProvider1.SetError(EndTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 7:
                    errorProvider1.SetError(DeviationTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 8:
                    errorProvider1.SetError(EnabledCB, Properties.Resources.ValueChangedTxt);
                    break;
                case 9:
                    errorProvider1.SetError(ClockBaseTB, Properties.Resources.ValueChangedTxt);
                    break;
                default:
                    errorProvider1.Clear();
                    break;
            }
        }

        #endregion

        /// <summary>
        /// User has change summer time enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnabledCB_CheckedChanged(object sender, EventArgs e)
        {
            BeginTB.ReadOnly = EndTB.ReadOnly = DeviationTB.ReadOnly = !EnabledCB.Checked;
            bool check = EnabledCB.Checked;
            (Target as GXDLMSClock).Enabled = check;
            Target.UpdateDirty(8, check);
            errorProvider1.SetError(EnabledCB, Properties.Resources.ValueChangedTxt);
        }

        private void TimeZoneCb_CheckedChanged(object sender, EventArgs e)
        {
            TimeZoneTB.ReadOnly = !TimeZoneCb.Checked;
            CurrentTimeZoneBtn.Enabled = TimeZoneCb.Checked;
            if (!TimeZoneCb.Checked)
            {
                (Target as GXDLMSClock).TimeZone = 0x8000;
            }
            else
            {
                (Target as GXDLMSClock).TimeZone = -(int)TimeZoneInfo.Local.BaseUtcOffset.TotalMinutes;
                TimeZoneTB.Value = (Target as GXDLMSClock).TimeZone.ToString();
            }
            Target.UpdateDirty(3, (Target as GXDLMSClock).TimeZone);
        }
    }
}
