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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSClock
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

        private void UpdateTimeZone(GXDLMSClock target, bool connected, int value)
        {
            if (target.TimeZone == -32768)//0x8000
            {
                value = -1;
                TimeZoneTB.Value = "";
            }
            //If time zone is not used.
            TimeZoneCb.CheckedChanged -= new System.EventHandler(TimeZoneCb_CheckedChanged);
            TimeZoneCb.Checked = value != -1;
            TimeZoneCb.CheckedChanged += new System.EventHandler(TimeZoneCb_CheckedChanged);
            TimeZoneTB.ReadOnly = connected || value == -1;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSClock target = Target as GXDLMSClock;
            if (arg.Index == 2)
            {
                //This is handled before.
            }
            else if (arg.Index == 3)
            {
                UpdateTimeZone(target, arg.Connected, (int)arg.Value);
            }
            else if (arg.Index == 5)
            {
                BeginTB.Value = arg.Value;
            }
            else if (arg.Index == 6)
            {
                EndTB.Value = arg.Value;
            }
            else if (arg.Index == 7)
            {
                DeviationTB.Value = arg.Value;
            }
            else if (arg.Index == 8)
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

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            bool enabled = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
            if (arg.Index == 2)
            {
                TimeTB.ReadOnly = !enabled;
                UpdateTimeBtn.Enabled = enabled;
            }
            else if (arg.Index == 3)
            {
                GXDLMSClock target = Target as GXDLMSClock;
                TimeZoneCb.Enabled = enabled;
                CurrentTimeZoneBtn.Enabled = enabled;
                if (enabled)
                {
                    UpdateTimeZone(target, arg.Connected && arg.Client.CanWrite(Target, arg.Index), target.TimeZone);
                }
            }
            else if (arg.Index == 5)
            {
                BeginTB.ReadOnly = !enabled;
            }
            else if (arg.Index == 6)
            {
                EndTB.ReadOnly = !enabled;
            }
            else if (arg.Index == 7)
            {
                DeviationTB.ReadOnly = !enabled;
            }
            else if (arg.Index == 8)
            {
                EnabledCB.Enabled = enabled;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }
        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
        {
        }

        delegate void ShowDlgEventHandler(GXActionArgs arg);

        void OnShowDlg(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDlgEventHandler(OnShowDlg), arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                if (arg.Index == 5)
                {
                    GXClockPresetTimeDlg dlg = new GXClockPresetTimeDlg();
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        GXByteBuffer bb = new GXByteBuffer();
                        bb.SetUInt8((byte) DataType.Structure);
                        bb.SetUInt8(4);
                        //Add data type and length.
                        bb.SetUInt8((byte)DataType.OctetString);
                        bb.SetUInt8(12);
                        bb.Set(GXDLMSTranslator.HexToBytes(dlg.PresetTime.ToHex(false, GXDlmsUi.UseMeterTimeZone)));
                        //Add data type and length.
                        bb.SetUInt8((byte)DataType.OctetString);
                        bb.SetUInt8(12);
                        bb.Set(GXDLMSTranslator.HexToBytes(dlg.IntervalStart.ToHex(false, GXDlmsUi.UseMeterTimeZone)));
                        //Add data type and length.
                        bb.SetUInt8((byte)DataType.OctetString);
                        bb.SetUInt8(12);
                        bb.Set(GXDLMSTranslator.HexToBytes(dlg.IntervalEnd.ToHex(false, GXDlmsUi.UseMeterTimeZone)));
                        arg.Value = bb.Array();
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 6)
                {
                    GXTextDlg dlg = new GXTextDlg("Shift Time", "Shift Time (s):", "", typeof(Int16));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        arg.Value = Int16.Parse(dlg.GetValue());
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else
                {
                    arg.Handled = true;
                }
            }
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
                        if (arg.Client.UseUtc2NormalTime)
                        {
                            (Target as GXDLMSClock).TimeZone = (int)TimeZoneInfo.Local.BaseUtcOffset.TotalMinutes;
                        }
                        else
                        {
                            (Target as GXDLMSClock).TimeZone = -(int)TimeZoneInfo.Local.BaseUtcOffset.TotalMinutes;
                        }
                        Target.UpdateDirty(3, (Target as GXDLMSClock).TimeZone);
                    }
                    arg.Handled = ret != DialogResult.Yes;
                }
            }
            else if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 5 || arg.Index == 6)
                {
                    OnShowDlg(arg);
                }
                else
                {
                    arg.Value = (sbyte)0;
                }
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
                    ErrorProvider.SetIconAlignment(ClockBaseTB, ErrorIconAlignment.TopRight);
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
