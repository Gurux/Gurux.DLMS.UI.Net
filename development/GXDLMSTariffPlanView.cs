//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSTariffPlanView.cs $
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
using Gurux.DLMS.Objects.Italy;
using Gurux.DLMS.Objects.Italy.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSTariffPlan
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSTariffPlan))]
    partial class GXDLMSTariffPlanView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSTariffPlanView()
        {
            InitializeComponent();
            foreach (object it in Enum.GetValues(typeof(DefaultTariffBand)))
            {
                WsWdIntervalTariffCb.Items.Add(it);
                WsSiIntervalTariffTb.Items.Add(it);
                WsHiIntervalTarifCb.Items.Add(it);
                SSWdIntervalTariffCb.Items.Add(it);
                SSSiIntrvalTarifCb.Items.Add(it);
                SSHiIntervalTarifCb.Items.Add(it);
            }

            foreach (object it in Enum.GetValues(typeof(WeeklyActivation)))
            {
                WsWdWeeklyActivationCb.Items.Add(it);
                WsSiWeeklyActivationCb.Items.Add(it);
                WsHiWeeklyActivationCb.Items.Add(it);
                SSWdWeeklyActivationCb.Items.Add(it);
                SSSiWeeklyActivationCb.Items.Add(it);
                SSHiWeeklyActivationCb.Items.Add(it);
            }
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSTariffPlan target = Target as GXDLMSTariffPlan;
            if (index == 3)
            {
                EnabledCB.Checked = target.Enabled;
            }
            else if (index == 4)
            {
                DefaultTariffBandTb.Text = target.Plan.DefaultTariffBand.ToString();
                WeeklyActivationTb.Text = target.Plan.WeeklyActivation;
                SpecialDaysLv.Items.Clear();
                if (target.Plan.SpecialDays != null)
                {
                    foreach (UInt16 it in target.Plan.SpecialDays)
                    {
                        SpecialDaysLv.Items.Add(it.ToString()).Tag = it;
                    }
                }
                //Winter
                GXDateTime t = new GXDateTime(-1, target.Plan.WinterSeason.Month != 0 ? target.Plan.WinterSeason.Month : 1,
                    target.Plan.WinterSeason.DayOfMonth != 0 ? target.Plan.WinterSeason.DayOfMonth : 1, -1, -1, -1, -1);
                WinterDActivateTb.Text = t.ToString();

                //Working days.
                WsWdStartHourTb.Text = target.Plan.WinterSeason.WorkingDayIntervals.StartHour.ToString();
                WsWdIntervalTariffCb.SelectedIndexChanged -= new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariffCb.SelectedItem = target.Plan.WinterSeason.WorkingDayIntervals.IntervalTariff;
                WsWdIntervalTariffCb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);

                WsWdIntervalCb.CheckedChanged -= new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb.Checked = target.Plan.WinterSeason.WorkingDayIntervals.UseInterval;
                WsWdIntervalCb.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdWeeklyActivationCb.SelectedIndexChanged -= new System.EventHandler(this.WsWdWeeklyActivationCb_SelectedIndexChanged);
                WsWdWeeklyActivationCb.SelectedItem = target.Plan.WinterSeason.WorkingDayIntervals.WeeklyActivation;
                WsWdWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.WsWdWeeklyActivationCb_SelectedIndexChanged);

                WsWdSpecialDayTb.Text = target.Plan.WinterSeason.WorkingDayIntervals.SpecialDay.ToString();
                WsWdSpecialDayEnabled.CheckedChanged -= new System.EventHandler(this.WsWdSpecialDayEnabled_CheckedChanged);
                WsWdSpecialDayEnabled.Checked = target.Plan.WinterSeason.WorkingDayIntervals.SpecialDayEnabled;
                WsWdSpecialDayEnabled.CheckedChanged += new System.EventHandler(this.WsWdSpecialDayEnabled_CheckedChanged);

                //Saturday intervals.
                WsSiStartHourTb.Text = target.Plan.WinterSeason.SaturdayIntervals.StartHour.ToString();
                WsSiIntervalTariffTb.SelectedIndexChanged -= new System.EventHandler(this.WsSiIntervalTariffTb_SelectedIndexChanged);
                WsSiIntervalTariffTb.SelectedItem = target.Plan.WinterSeason.SaturdayIntervals.IntervalTariff;
                WsSiIntervalTariffTb.SelectedIndexChanged += new System.EventHandler(this.WsSiIntervalTariffTb_SelectedIndexChanged);
                this.WsSiIntervalEnabled.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSiIntervalEnabled.Checked = target.Plan.WinterSeason.SaturdayIntervals.UseInterval;
                this.WsSiIntervalEnabled.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                this.WsSiWeeklyActivationCb.SelectedIndexChanged -= new System.EventHandler(this.WsSiWeeklyActivationCb_SelectedIndexChanged);
                WsSiWeeklyActivationCb.SelectedItem = target.Plan.WinterSeason.SaturdayIntervals.WeeklyActivation;
                this.WsSiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.WsSiWeeklyActivationCb_SelectedIndexChanged);

                WsSiSpecialDayTb.Text = target.Plan.WinterSeason.SaturdayIntervals.SpecialDay.ToString();
                this.WsSiSpecialDayCb.CheckedChanged -= new System.EventHandler(this.WsSiSpecialDayCb_CheckedChanged);
                WsSiSpecialDayCb.Checked = target.Plan.WinterSeason.SaturdayIntervals.SpecialDayEnabled;
                this.WsSiSpecialDayCb.CheckedChanged += new System.EventHandler(this.WsSiSpecialDayCb_CheckedChanged);
                //Holiday intervals.
                WsHiStartHourTb.Text = target.Plan.WinterSeason.HolidayIntervals.StartHour.ToString();
                this.WsHiIntervalTarifCb.SelectedIndexChanged -= new System.EventHandler(this.WsHiIntervalTarifCb_SelectedIndexChanged);
                WsHiIntervalTarifCb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals.IntervalTariff;
                this.WsHiIntervalTarifCb.SelectedIndexChanged += new System.EventHandler(this.WsHiIntervalTarifCb_SelectedIndexChanged);
                this.WsHiUseIntervalCb.CheckedChanged -= new System.EventHandler(this.WsHiUseIntervalCb_CheckedChanged);
                WsHiUseIntervalCb.Checked = target.Plan.WinterSeason.HolidayIntervals.UseInterval;
                this.WsHiUseIntervalCb.CheckedChanged += new System.EventHandler(this.WsHiUseIntervalCb_CheckedChanged);
                this.WsHiWeeklyActivationCb.SelectedIndexChanged -= new System.EventHandler(this.WsHiWeeklyActivationCb_SelectedIndexChanged);
                WsHiWeeklyActivationCb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals.WeeklyActivation;
                this.WsHiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.WsHiWeeklyActivationCb_SelectedIndexChanged);

                WsHiSpecialDayTb.Text = target.Plan.WinterSeason.HolidayIntervals.SpecialDay.ToString();
                this.WsHiSpecialDayCb.CheckedChanged -= new System.EventHandler(this.WsHiSpecialDayCb_CheckedChanged);
                WsHiSpecialDayCb.Checked = target.Plan.WinterSeason.HolidayIntervals.SpecialDayEnabled;
                this.WsHiSpecialDayCb.CheckedChanged += new System.EventHandler(this.WsHiSpecialDayCb_CheckedChanged);


                //Summer
                t = new GXDateTime(-1, target.Plan.SummerSeason.Month != 0 ? target.Plan.SummerSeason.Month : 1,
                    target.Plan.SummerSeason.DayOfMonth != 0 ? target.Plan.SummerSeason.DayOfMonth : 1, -1, -1, -1, -1);
                SummerActivateTb.Text = t.ToString();

                //Working days.
                SSWdStartHourTb.Text = target.Plan.SummerSeason.WorkingDayIntervals.StartHour.ToString();
                this.SSWdIntervalTariffCb.SelectedIndexChanged -= new System.EventHandler(this.SSWdIntervalTariffCb_SelectedIndexChanged);
                SSWdIntervalTariffCb.SelectedItem = target.Plan.SummerSeason.WorkingDayIntervals.IntervalTariff;
                this.SSWdIntervalTariffCb.SelectedIndexChanged += new System.EventHandler(this.SSWdIntervalTariffCb_SelectedIndexChanged);
                this.checkBox1.CheckedChanged -= new System.EventHandler(this.checkBox1_CheckedChanged);
                checkBox1.Checked = target.Plan.SummerSeason.WorkingDayIntervals.UseInterval;
                this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
                this.SSWdWeeklyActivationCb.SelectedIndexChanged -= new System.EventHandler(this.SSWdWeeklyActivationCb_SelectedIndexChanged);
                SSWdWeeklyActivationCb.SelectedItem = target.Plan.SummerSeason.WorkingDayIntervals.WeeklyActivation;
                this.SSWdWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.SSWdWeeklyActivationCb_SelectedIndexChanged);
                SSWdSpecialDayTb.Text = target.Plan.SummerSeason.WorkingDayIntervals.SpecialDay.ToString();
                this.SSWdSpecialDayCb.CheckedChanged -= new System.EventHandler(this.SSWdSpecialDayCb_CheckedChanged);
                SSWdSpecialDayCb.Checked = target.Plan.SummerSeason.WorkingDayIntervals.SpecialDayEnabled;
                this.SSWdSpecialDayCb.CheckedChanged += new System.EventHandler(this.SSWdSpecialDayCb_CheckedChanged);

                //Saturday intervals.
                SSSiStartHourTb.Text = target.Plan.SummerSeason.SaturdayIntervals.StartHour.ToString();
                this.SSSiIntrvalTarifCb.SelectedIndexChanged -= new System.EventHandler(this.SSSiIntrvalTarifCb_SelectedIndexChanged);
                SSSiIntrvalTarifCb.SelectedItem = target.Plan.SummerSeason.SaturdayIntervals.IntervalTariff;
                this.SSSiIntrvalTarifCb.SelectedIndexChanged += new System.EventHandler(this.SSSiIntrvalTarifCb_SelectedIndexChanged);

                this.SSSiUseIntervalCb.CheckedChanged -= new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SSSiUseIntervalCb.Checked = target.Plan.SummerSeason.SaturdayIntervals.UseInterval;
                this.SSSiUseIntervalCb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);

                this.SSSiWeeklyActivationCb.SelectedIndexChanged -= new System.EventHandler(this.SSSiWeeklyActivationCb_SelectedIndexChanged);
                SSSiWeeklyActivationCb.SelectedItem = target.Plan.SummerSeason.SaturdayIntervals.WeeklyActivation;
                this.SSSiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.SSSiWeeklyActivationCb_SelectedIndexChanged);

                SSSiSpecialDayTb.Text = target.Plan.SummerSeason.SaturdayIntervals.SpecialDay.ToString();
                this.SSSiSpecialDayCb.CheckedChanged -= new System.EventHandler(this.SSSiSpecialDayCb_CheckedChanged);
                SSSiSpecialDayCb.Checked = target.Plan.SummerSeason.SaturdayIntervals.SpecialDayEnabled;
                this.SSSiSpecialDayCb.CheckedChanged += new System.EventHandler(this.SSSiSpecialDayCb_CheckedChanged);

                //Holiday intervals.
                SSHiStartHourTb.Text = target.Plan.SummerSeason.HolidayIntervals.StartHour.ToString();
                this.SSHiIntervalTarifCb.SelectedIndexChanged -= new System.EventHandler(this.SSHiIntervalTarifCb_SelectedIndexChanged);
                SSHiIntervalTarifCb.SelectedItem = target.Plan.SummerSeason.HolidayIntervals.IntervalTariff;
                this.SSHiIntervalTarifCb.SelectedIndexChanged += new System.EventHandler(this.SSHiIntervalTarifCb_SelectedIndexChanged);
                this.SSHiUseIntervalCb.CheckedChanged -= new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SSHiUseIntervalCb.Checked = target.Plan.SummerSeason.HolidayIntervals.UseInterval;
                this.SSHiUseIntervalCb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);

                this.SSHiWeeklyActivationCb.SelectedIndexChanged -= new System.EventHandler(this.SSHiWeeklyActivationCb_SelectedIndexChanged);
                SSHiWeeklyActivationCb.SelectedItem = target.Plan.SummerSeason.HolidayIntervals.WeeklyActivation;
                this.SSHiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.SSHiWeeklyActivationCb_SelectedIndexChanged);

                SSHiSpecialDayTb.Text = target.Plan.SummerSeason.HolidayIntervals.SpecialDay.ToString();
                this.SSHiSpecialDayCb.CheckedChanged -= new System.EventHandler(this.SSHiSpecialDayCb_CheckedChanged);
                SSHiSpecialDayCb.Checked = target.Plan.SummerSeason.HolidayIntervals.SpecialDayEnabled;
                this.SSHiSpecialDayCb.CheckedChanged += new System.EventHandler(this.SSHiSpecialDayCb_CheckedChanged);

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
            if (Dirty && index == 3)
            {
                errorProvider1.SetError(CalendarNameTb, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
            throw new IndexOutOfRangeException("index");
        }
        #endregion




        private void ValueTB_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void ValueTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void EnabledCB_CheckedChanged(object sender, EventArgs e)
        {
            (Target as GXDLMSTariffPlan).Enabled = EnabledCB.Checked;
            Target.UpdateDirty(3, (Target as GXDLMSTariffPlan).Enabled);
            errorProvider1.SetError(EnabledCB, Properties.Resources.ValueChangedTxt);
        }

        private void DefaultTariffBandTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.DefaultTariffBand = byte.Parse(DefaultTariffBandTb.Text);
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.DefaultTariffBand);
                errorProvider1.SetError(DefaultTariffBandTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefaultTariffBandTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DefaultTariffBandTb_Leave(null, null);
            }
        }

        private void WeeklyActivationTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WeeklyActivation = WeeklyActivationTb.Text;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WeeklyActivation);
                errorProvider1.SetError(WeeklyActivationTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WeeklyActivationTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WeeklyActivationTb_Leave(null, null);
            }
        }

        private void WinterDActivateTb_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = new GXDateTime(WinterDActivateTb.Text);
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.DayOfMonth = (byte)dt.Day;
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.Month = (byte)dt.Month;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WinterDActivateTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WinterDActivateTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WinterDActivateTb_Leave(null, null);
            }
        }

        private void SummerActivateTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SummerActivateTb_Leave(null, null);
            }
        }

        private void DefaultTariffBandTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void WsWdStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals.StartHour = byte.Parse(WsWdStartHourTb.Text);
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsWdStartHourTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsWdStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsWdStartHourTb_Leave(null, null);
            }
        }

        private void WsSiStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals.StartHour = byte.Parse(WsSiStartHourTb.Text);
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsSiStartHourTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsSiStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsWdStartHourTb_Leave(null, null);
            }
        }

        private void WsHiStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals.StartHour = byte.Parse(WsHiStartHourTb.Text);
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsHiStartHourTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsHiStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsHiStartHourTb_Leave(null, null);
            }
        }

        private void WsWdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals.IntervalTariff = (DefaultTariffBand)WsWdIntervalTariffCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsWdIntervalTariffCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsSiIntervalTariffTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals.IntervalTariff = (DefaultTariffBand)WsSiIntervalTariffTb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsSiIntervalTariffTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsHiIntervalTarifCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals.IntervalTariff = (DefaultTariffBand)WsHiIntervalTarifCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsHiIntervalTarifCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSWdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals.IntervalTariff = (DefaultTariffBand)SSWdIntervalTariffCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSWdIntervalTariffCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSSiIntrvalTarifCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals.IntervalTariff = (DefaultTariffBand)SSSiIntrvalTarifCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSSiIntrvalTarifCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSHiIntervalTarifCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals.IntervalTariff = (DefaultTariffBand)SSHiIntervalTarifCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSHiIntervalTarifCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsWdWeeklyActivationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals.WeeklyActivation = (WeeklyActivation)WsWdWeeklyActivationCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsWdWeeklyActivationCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsSiWeeklyActivationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals.WeeklyActivation = (WeeklyActivation)WsSiWeeklyActivationCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(WsSiWeeklyActivationCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WsHiWeeklyActivationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals.WeeklyActivation = (WeeklyActivation)WsHiWeeklyActivationCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(WsHiWeeklyActivationCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSWdWeeklyActivationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals.WeeklyActivation = (WeeklyActivation)SSWdWeeklyActivationCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSWdWeeklyActivationCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SSSiWeeklyActivationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals.WeeklyActivation = (WeeklyActivation)SSSiWeeklyActivationCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSSiWeeklyActivationCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SSHiWeeklyActivationCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals.WeeklyActivation = (WeeklyActivation)SSHiWeeklyActivationCb.SelectedItem;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSHiWeeklyActivationCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsHiUseIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals.UseInterval = WsHiUseIntervalCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsHiUseIntervalCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WsSiIntervalEnabled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals.UseInterval = WsSiIntervalEnabled.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsSiIntervalEnabled, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsWdIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals.UseInterval = WsWdIntervalCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsWdIntervalCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals.UseInterval = checkBox1.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(checkBox1, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSSiUseIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals.UseInterval = SSSiUseIntervalCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSSiUseIntervalCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSHiUseIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals.UseInterval = SSHiUseIntervalCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSHiUseIntervalCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WsWdSpecialDayTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals.SpecialDay = byte.Parse(WsWdSpecialDayTb.Text);
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsWdSpecialDayTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsWdSpecialDayTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsWdSpecialDayTb_Leave(null, null);
            }
        }

        private void WsSiSpecialDayTb_Leave(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals.SpecialDay = byte.Parse(WsSiSpecialDayTb.Text);
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsSiSpecialDayTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WsSiSpecialDayTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsSiSpecialDayTb_Leave(null, null);
            }
        }

        private void WsHiSpecialDayTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (WsHiSpecialDayTb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals.SpecialDay = byte.Parse(WsHiSpecialDayTb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                    errorProvider1.SetError(WsHiSpecialDayTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WsHiSpecialDayTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsHiSpecialDayTb_Leave(null, null);
            }
        }

        private void WsHiSpecialDayTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SSWdSpecialDayTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (SSWdSpecialDayTb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals.SpecialDay = byte.Parse(SSWdSpecialDayTb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                    errorProvider1.SetError(SSWdSpecialDayTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSWdSpecialDayTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SSWdSpecialDayTb_Leave(null, null);
            }
        }

        private void SSSiSpecialDayTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (SSWdSpecialDayTb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals.SpecialDay = byte.Parse(SSSiSpecialDayTb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                    errorProvider1.SetError(SSSiSpecialDayTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSSiSpecialDayTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SSWdSpecialDayTb_Leave(null, null);
            }
        }

        private void SSHiSpecialDayTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (SSHiSpecialDayTb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals.SpecialDay = byte.Parse(SSHiSpecialDayTb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                    errorProvider1.SetError(SSHiSpecialDayTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSHiSpecialDayTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SSWdSpecialDayTb_Leave(null, null);
            }
        }

        private void SSHiSpecialDayCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals.SpecialDayEnabled = SSHiSpecialDayCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(SSHiSpecialDayCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsWdSpecialDayEnabled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals.SpecialDayEnabled = WsWdSpecialDayEnabled.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsWdSpecialDayEnabled, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsSiSpecialDayCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals.SpecialDayEnabled = WsSiSpecialDayCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsSiSpecialDayCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsHiSpecialDayCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals.SpecialDayEnabled = WsHiSpecialDayCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError(WsHiSpecialDayCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSWdSpecialDayCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals.SpecialDayEnabled = SSWdSpecialDayCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSWdSpecialDayCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSSiSpecialDayCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals.SpecialDayEnabled = SSSiSpecialDayCb.Checked;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SSSiSpecialDayCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SummerActivateTb_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime dt = new GXDateTime(SummerActivateTb.Text);
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.DayOfMonth = (byte)dt.Day;
                (Target as GXDLMSTariffPlan).Plan.SummerSeason.Month = (byte)dt.Month;
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError(SummerActivateTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSWdStartHourTb_DragLeave(object sender, EventArgs e)
        {

        }

        private void SSWdStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (SSWdStartHourTb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals.StartHour = byte.Parse(SSWdStartHourTb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSWdStartHourTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSWdStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SSWdStartHourTb_Leave(null, null);
            }
        }

        private void SSSiStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (SSSiStartHourTb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals.StartHour = byte.Parse(SSSiStartHourTb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSSiStartHourTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSSiStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SSSiStartHourTb_Leave(null, null);
            }
        }

        private void SSHiStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (SSHiStartHourTb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals.StartHour = byte.Parse(SSHiStartHourTb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSHiStartHourTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSHiStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SSHiStartHourTb_Leave(null, null);
            }
        }
    }
}
