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
                WsWdIntervalTariff1Cb.Items.Add(it);
                WsSdIntervalTariff1Cb.Items.Add(it);
                WsHdIntervalTariff1Cb.Items.Add(it);
                SsWdIntervalTariff1Cb.Items.Add(it);
                SsSdIntervalTariff1Cb.Items.Add(it);
                SsHdIntervalTariff1Cb.Items.Add(it);

                WsWdIntervalTariff2Cb.Items.Add(it);
                WsSdIntervalTariff2Cb.Items.Add(it);
                WsHdIntervalTariff2Cb.Items.Add(it);
                SsWdIntervalTariff2Cb.Items.Add(it);
                SsSdIntervalTariff2Cb.Items.Add(it);
                SsHdIntervalTariff2Cb.Items.Add(it);

                WsWdIntervalTariff3Cb.Items.Add(it);
                WsSdIntervalTariff3Cb.Items.Add(it);
                WsHdIntervalTariff3Cb.Items.Add(it);
                SsWdIntervalTariff3Cb.Items.Add(it);
                SsSdIntervalTariff3Cb.Items.Add(it);
                SsHdIntervalTariff3Cb.Items.Add(it);

                WsWdIntervalTariff4Cb.Items.Add(it);
                WsSdIntervalTariff4Cb.Items.Add(it);
                WsHdIntervalTariff4Cb.Items.Add(it);
                SsWdIntervalTariff4Cb.Items.Add(it);
                SsSdIntervalTariff4Cb.Items.Add(it);
                SsHdIntervalTariff4Cb.Items.Add(it);

                WsWdIntervalTariff5Cb.Items.Add(it);
                WsSdIntervalTariff5Cb.Items.Add(it);
                WsHdIntervalTariff5Cb.Items.Add(it);
                SsWdIntervalTariff5Cb.Items.Add(it);
                SsSdIntervalTariff5Cb.Items.Add(it);
                SsHdIntervalTariff5Cb.Items.Add(it);

            }
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSTariffPlan target = Target as GXDLMSTariffPlan;
            if (arg.Index == 3)
            {
                EnabledCB.Checked = target.Enabled;
            }
            else if (arg.Index == 4)
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
                WsWdStartHour1Tb.Text = target.Plan.WinterSeason.WorkingDayIntervals[0].StartHour.ToString();
                WsWdStartHour2Tb.Text = target.Plan.WinterSeason.WorkingDayIntervals[1].StartHour.ToString();
                WsWdStartHour3Tb.Text = target.Plan.WinterSeason.WorkingDayIntervals[2].StartHour.ToString();
                WsWdStartHour4Tb.Text = target.Plan.WinterSeason.WorkingDayIntervals[3].StartHour.ToString();
                WsWdStartHour5Tb.Text = target.Plan.WinterSeason.WorkingDayIntervals[4].StartHour.ToString();

                WsWdIntervalTariff1Cb.SelectedIndexChanged -= new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff1Cb.SelectedItem = target.Plan.WinterSeason.WorkingDayIntervals[0].IntervalTariff;
                WsWdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff2Cb.SelectedIndexChanged -= new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff2Cb.SelectedItem = target.Plan.WinterSeason.WorkingDayIntervals[1].IntervalTariff;
                WsWdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff3Cb.SelectedIndexChanged -= new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff3Cb.SelectedItem = target.Plan.WinterSeason.WorkingDayIntervals[2].IntervalTariff;
                WsWdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff4Cb.SelectedIndexChanged -= new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff4Cb.SelectedItem = target.Plan.WinterSeason.WorkingDayIntervals[3].IntervalTariff;
                WsWdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff5Cb.SelectedIndexChanged -= new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
                WsWdIntervalTariff5Cb.SelectedItem = target.Plan.WinterSeason.WorkingDayIntervals[4].IntervalTariff;
                WsWdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);

                WsWdIntervalCb1.CheckedChanged -= new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb1.Checked = target.Plan.WinterSeason.WorkingDayIntervals[0].UseInterval;
                WsWdIntervalCb1.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb2.CheckedChanged -= new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb2.Checked = target.Plan.WinterSeason.WorkingDayIntervals[1].UseInterval;
                WsWdIntervalCb2.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb3.CheckedChanged -= new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb3.Checked = target.Plan.WinterSeason.WorkingDayIntervals[2].UseInterval;
                WsWdIntervalCb3.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb4.CheckedChanged -= new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb4.Checked = target.Plan.WinterSeason.WorkingDayIntervals[3].UseInterval;
                WsWdIntervalCb4.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb5.CheckedChanged -= new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
                WsWdIntervalCb5.Checked = target.Plan.WinterSeason.WorkingDayIntervals[4].UseInterval;
                WsWdIntervalCb5.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);

                //Saturday intervals.
                WsSiStartHour1Tb.Text = target.Plan.WinterSeason.SaturdayIntervals[0].StartHour.ToString();
                WsSiStartHour2Tb.Text = target.Plan.WinterSeason.SaturdayIntervals[1].StartHour.ToString();
                WsSiStartHour3Tb.Text = target.Plan.WinterSeason.SaturdayIntervals[2].StartHour.ToString();
                WsSiStartHour4Tb.Text = target.Plan.WinterSeason.SaturdayIntervals[3].StartHour.ToString();
                WsSiStartHour5Tb.Text = target.Plan.WinterSeason.SaturdayIntervals[4].StartHour.ToString();

                WsSdIntervalTariff1Cb.SelectedIndexChanged -= new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff1Cb.SelectedItem = target.Plan.WinterSeason.SaturdayIntervals[0].IntervalTariff;
                WsSdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff2Cb.SelectedIndexChanged -= new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff2Cb.SelectedItem = target.Plan.WinterSeason.SaturdayIntervals[1].IntervalTariff;
                WsSdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff3Cb.SelectedIndexChanged -= new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff3Cb.SelectedItem = target.Plan.WinterSeason.SaturdayIntervals[2].IntervalTariff;
                WsSdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff4Cb.SelectedIndexChanged -= new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff4Cb.SelectedItem = target.Plan.WinterSeason.SaturdayIntervals[3].IntervalTariff;
                WsSdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff5Cb.SelectedIndexChanged -= new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
                WsSdIntervalTariff5Cb.SelectedItem = target.Plan.WinterSeason.SaturdayIntervals[4].IntervalTariff;
                WsSdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);


                WsSdInterval1Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval1Cb.Checked = target.Plan.WinterSeason.SaturdayIntervals[0].UseInterval;
                WsSdInterval1Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval2Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval2Cb.Checked = target.Plan.WinterSeason.SaturdayIntervals[1].UseInterval;
                WsSdInterval2Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval3Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval3Cb.Checked = target.Plan.WinterSeason.SaturdayIntervals[2].UseInterval;
                WsSdInterval3Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval4Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval4Cb.Checked = target.Plan.WinterSeason.SaturdayIntervals[3].UseInterval;
                WsSdInterval4Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval5Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsSdInterval5Cb.Checked = target.Plan.WinterSeason.SaturdayIntervals[4].UseInterval;
                WsSdInterval5Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);

                //Holiday intervals.
                WsHiStartHour1Tb.Text = target.Plan.WinterSeason.HolidayIntervals[0].StartHour.ToString();
                WsHiStartHour2Tb.Text = target.Plan.WinterSeason.HolidayIntervals[1].StartHour.ToString();
                WsHiStartHour3Tb.Text = target.Plan.WinterSeason.HolidayIntervals[2].StartHour.ToString();
                WsHiStartHour4Tb.Text = target.Plan.WinterSeason.HolidayIntervals[3].StartHour.ToString();
                WsHiStartHour5Tb.Text = target.Plan.WinterSeason.HolidayIntervals[4].StartHour.ToString();

                WsHdIntervalTariff1Cb.SelectedIndexChanged -= new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff1Cb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals[0].IntervalTariff;
                WsHdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);

                WsHdIntervalTariff1Cb.SelectedIndexChanged -= new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff1Cb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals[0].IntervalTariff;
                WsHdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff2Cb.SelectedIndexChanged -= new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff2Cb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals[1].IntervalTariff;
                WsHdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff3Cb.SelectedIndexChanged -= new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff3Cb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals[2].IntervalTariff;
                WsHdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff4Cb.SelectedIndexChanged -= new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff4Cb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals[3].IntervalTariff;
                WsHdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff5Cb.SelectedIndexChanged -= new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);
                WsHdIntervalTariff5Cb.SelectedItem = target.Plan.WinterSeason.HolidayIntervals[4].IntervalTariff;
                WsHdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.WsHdIntervalTariffCb_SelectedIndexChanged);

                WsHdInterval1Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval1Cb.Checked = target.Plan.WinterSeason.HolidayIntervals[0].UseInterval;
                WsHdInterval1Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval2Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval2Cb.Checked = target.Plan.WinterSeason.HolidayIntervals[1].UseInterval;
                WsHdInterval2Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval3Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval3Cb.Checked = target.Plan.WinterSeason.HolidayIntervals[2].UseInterval;
                WsHdInterval3Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval4Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval4Cb.Checked = target.Plan.WinterSeason.HolidayIntervals[3].UseInterval;
                WsHdInterval4Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval5Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                WsHdInterval5Cb.Checked = target.Plan.WinterSeason.HolidayIntervals[4].UseInterval;
                WsHdInterval5Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);

                //Summer
                t = new GXDateTime(-1, target.Plan.SummerSeason.Month != 0 ? target.Plan.SummerSeason.Month : 1,
                    target.Plan.SummerSeason.DayOfMonth != 0 ? target.Plan.SummerSeason.DayOfMonth : 1, -1, -1, -1, -1);
                SummerActivateTb.Text = t.ToString();

                //Working days.
                SSWdStartHour1Tb.Text = target.Plan.SummerSeason.WorkingDayIntervals[0].StartHour.ToString();
                SSWdStartHour2Tb.Text = target.Plan.SummerSeason.WorkingDayIntervals[1].StartHour.ToString();
                SSWdStartHour3Tb.Text = target.Plan.SummerSeason.WorkingDayIntervals[2].StartHour.ToString();
                SSWdStartHour4Tb.Text = target.Plan.SummerSeason.WorkingDayIntervals[3].StartHour.ToString();
                SSWdStartHour5Tb.Text = target.Plan.SummerSeason.WorkingDayIntervals[4].StartHour.ToString();

                SsWdIntervalTariff1Cb.SelectedIndexChanged -= new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff1Cb.SelectedItem = target.Plan.SummerSeason.WorkingDayIntervals[0].IntervalTariff;
                SsWdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff2Cb.SelectedIndexChanged -= new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff2Cb.SelectedItem = target.Plan.SummerSeason.WorkingDayIntervals[1].IntervalTariff;
                SsWdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff3Cb.SelectedIndexChanged -= new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff3Cb.SelectedItem = target.Plan.SummerSeason.WorkingDayIntervals[2].IntervalTariff;
                SsWdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff4Cb.SelectedIndexChanged -= new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff4Cb.SelectedItem = target.Plan.SummerSeason.WorkingDayIntervals[3].IntervalTariff;
                SsWdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff5Cb.SelectedIndexChanged -= new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
                SsWdIntervalTariff5Cb.SelectedItem = target.Plan.SummerSeason.WorkingDayIntervals[4].IntervalTariff;
                SsWdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);

                SsWdInterval1Cb.CheckedChanged -= new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval1Cb.Checked = target.Plan.SummerSeason.WorkingDayIntervals[0].UseInterval;
                SsWdInterval1Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval2Cb.CheckedChanged -= new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval2Cb.Checked = target.Plan.SummerSeason.WorkingDayIntervals[1].UseInterval;
                SsWdInterval2Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval3Cb.CheckedChanged -= new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval3Cb.Checked = target.Plan.SummerSeason.WorkingDayIntervals[2].UseInterval;
                SsWdInterval3Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval4Cb.CheckedChanged -= new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval4Cb.Checked = target.Plan.SummerSeason.WorkingDayIntervals[3].UseInterval;
                SsWdInterval4Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval5Cb.CheckedChanged -= new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
                SsWdInterval5Cb.Checked = target.Plan.SummerSeason.WorkingDayIntervals[4].UseInterval;
                SsWdInterval5Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);

                //Saturday intervals.
                SSSiStartHour1Tb.Text = target.Plan.SummerSeason.SaturdayIntervals[0].StartHour.ToString();
                SSSiStartHour2Tb.Text = target.Plan.SummerSeason.SaturdayIntervals[1].StartHour.ToString();
                SSSiStartHour3Tb.Text = target.Plan.SummerSeason.SaturdayIntervals[2].StartHour.ToString();
                SSSiStartHour4Tb.Text = target.Plan.SummerSeason.SaturdayIntervals[3].StartHour.ToString();
                SSSiStartHour5Tb.Text = target.Plan.SummerSeason.SaturdayIntervals[4].StartHour.ToString();

                SsSdIntervalTariff1Cb.SelectedIndexChanged -= new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff1Cb.SelectedItem = target.Plan.SummerSeason.SaturdayIntervals[0].IntervalTariff;
                SsSdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff2Cb.SelectedIndexChanged -= new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff2Cb.SelectedItem = target.Plan.SummerSeason.SaturdayIntervals[1].IntervalTariff;
                SsSdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff3Cb.SelectedIndexChanged -= new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff3Cb.SelectedItem = target.Plan.SummerSeason.SaturdayIntervals[2].IntervalTariff;
                SsSdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff4Cb.SelectedIndexChanged -= new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff4Cb.SelectedItem = target.Plan.SummerSeason.SaturdayIntervals[3].IntervalTariff;
                SsSdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff5Cb.SelectedIndexChanged -= new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
                SsSdIntervalTariff5Cb.SelectedItem = target.Plan.SummerSeason.SaturdayIntervals[4].IntervalTariff;
                SsSdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);

                SsSdInterval1Cb.CheckedChanged -= new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval1Cb.Checked = target.Plan.SummerSeason.SaturdayIntervals[0].UseInterval;
                SsSdInterval1Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval2Cb.CheckedChanged -= new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval2Cb.Checked = target.Plan.SummerSeason.SaturdayIntervals[1].UseInterval;
                SsSdInterval2Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval3Cb.CheckedChanged -= new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval3Cb.Checked = target.Plan.SummerSeason.SaturdayIntervals[2].UseInterval;
                SsSdInterval3Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval4Cb.CheckedChanged -= new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval4Cb.Checked = target.Plan.SummerSeason.SaturdayIntervals[3].UseInterval;
                SsSdInterval4Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval5Cb.CheckedChanged -= new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
                SsSdInterval5Cb.Checked = target.Plan.SummerSeason.SaturdayIntervals[4].UseInterval;
                SsSdInterval5Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);

                //Holiday intervals.
                SSHiStartHour1Tb.Text = target.Plan.SummerSeason.HolidayIntervals[0].StartHour.ToString();
                SSHiStartHour2Tb.Text = target.Plan.SummerSeason.HolidayIntervals[1].StartHour.ToString();
                SSHiStartHour3Tb.Text = target.Plan.SummerSeason.HolidayIntervals[2].StartHour.ToString();
                SSHiStartHour4Tb.Text = target.Plan.SummerSeason.HolidayIntervals[3].StartHour.ToString();
                SSHiStartHour5Tb.Text = target.Plan.SummerSeason.HolidayIntervals[4].StartHour.ToString();

                SsHdIntervalTariff1Cb.SelectedIndexChanged -= new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff1Cb.SelectedItem = target.Plan.SummerSeason.HolidayIntervals[0].IntervalTariff;
                SsHdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff2Cb.SelectedIndexChanged -= new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff2Cb.SelectedItem = target.Plan.SummerSeason.HolidayIntervals[1].IntervalTariff;
                SsHdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff3Cb.SelectedIndexChanged -= new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff3Cb.SelectedItem = target.Plan.SummerSeason.HolidayIntervals[2].IntervalTariff;
                SsHdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff4Cb.SelectedIndexChanged -= new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff4Cb.SelectedItem = target.Plan.SummerSeason.HolidayIntervals[3].IntervalTariff;
                SsHdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff5Cb.SelectedIndexChanged -= new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
                SsHdIntervalTariff5Cb.SelectedItem = target.Plan.SummerSeason.HolidayIntervals[4].IntervalTariff;
                SsHdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);

                SsHdInterval1Cb.CheckedChanged -= new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SsHdInterval1Cb.Checked = target.Plan.SummerSeason.HolidayIntervals[0].UseInterval;
                SsHdInterval1Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SsHdInterval2Cb.CheckedChanged -= new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SsHdInterval2Cb.Checked = target.Plan.SummerSeason.HolidayIntervals[1].UseInterval;
                SsHdInterval2Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SsHdInterval3Cb.CheckedChanged -= new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SsHdInterval3Cb.Checked = target.Plan.SummerSeason.HolidayIntervals[2].UseInterval;
                SsHdInterval3Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SsHdInterval4Cb.CheckedChanged -= new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
                SsHdInterval4Cb.Checked = target.Plan.SummerSeason.HolidayIntervals[3].UseInterval;
                SsHdInterval4Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                SsHdInterval5Cb.CheckedChanged -= new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
                SsHdInterval5Cb.Checked = target.Plan.SummerSeason.HolidayIntervals[4].UseInterval;
                SsHdInterval5Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
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

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
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
                MessageBox.Show(Parent, ex.Message, "Error",
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
                MessageBox.Show(Parent, ex.Message, "Error",
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
                MessageBox.Show(Parent, ex.Message, "Error",
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
                if (sender == WsWdStartHour1Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[0].StartHour = byte.Parse(WsWdStartHour1Tb.Text);
                }
                else if (sender == WsWdStartHour2Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[1].StartHour = byte.Parse(WsWdStartHour2Tb.Text);
                }
                else if (sender == WsWdStartHour3Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[2].StartHour = byte.Parse(WsWdStartHour3Tb.Text);
                }
                else if (sender == WsWdStartHour4Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[3].StartHour = byte.Parse(WsWdStartHour4Tb.Text);
                }
                else if (sender == WsWdStartHour5Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[4].StartHour = byte.Parse(WsWdStartHour5Tb.Text);
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
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

        private void WsSdStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (sender == WsSiStartHour1Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[0].StartHour = byte.Parse(WsSiStartHour1Tb.Text);
                }
                else if (sender == WsSiStartHour2Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[1].StartHour = byte.Parse(WsSiStartHour2Tb.Text);
                }
                else if (sender == WsSiStartHour3Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[2].StartHour = byte.Parse(WsSiStartHour3Tb.Text);
                }
                else if (sender == WsSiStartHour4Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[3].StartHour = byte.Parse(WsSiStartHour4Tb.Text);
                }
                else if (sender == WsSiStartHour5Tb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[4].StartHour = byte.Parse(WsSiStartHour5Tb.Text);
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsSdStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsSdStartHourTb_Leave(null, null);
            }
        }

        private void WsWdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == WsWdIntervalTariff1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[0].IntervalTariff = (DefaultTariffBand)WsWdIntervalTariff1Cb.SelectedItem;
                }
                else if (sender == WsWdIntervalTariff2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[1].IntervalTariff = (DefaultTariffBand)WsWdIntervalTariff2Cb.SelectedItem;
                }
                else if (sender == WsWdIntervalTariff3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[2].IntervalTariff = (DefaultTariffBand)WsWdIntervalTariff3Cb.SelectedItem;
                }
                else if (sender == WsWdIntervalTariff4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[3].IntervalTariff = (DefaultTariffBand)WsWdIntervalTariff4Cb.SelectedItem;
                }
                else if (sender == WsWdIntervalTariff5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[4].IntervalTariff = (DefaultTariffBand)WsWdIntervalTariff5Cb.SelectedItem;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsSdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == WsSdIntervalTariff1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[0].IntervalTariff = (DefaultTariffBand)WsSdIntervalTariff1Cb.SelectedItem;
                }
                else if (sender == WsSdIntervalTariff2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[1].IntervalTariff = (DefaultTariffBand)WsSdIntervalTariff2Cb.SelectedItem;
                }
                else if (sender == WsSdIntervalTariff3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[2].IntervalTariff = (DefaultTariffBand)WsSdIntervalTariff3Cb.SelectedItem;
                }
                else if (sender == WsSdIntervalTariff4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[3].IntervalTariff = (DefaultTariffBand)WsSdIntervalTariff4Cb.SelectedItem;
                }
                else if (sender == WsSdIntervalTariff5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[4].IntervalTariff = (DefaultTariffBand)WsSdIntervalTariff5Cb.SelectedItem;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsHdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == WsHdIntervalTariff1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[0].IntervalTariff = (DefaultTariffBand)WsHdIntervalTariff1Cb.SelectedItem;
                }
                else if (sender == WsHdIntervalTariff2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[1].IntervalTariff = (DefaultTariffBand)WsHdIntervalTariff2Cb.SelectedItem;
                }
                else if (sender == WsHdIntervalTariff3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[2].IntervalTariff = (DefaultTariffBand)WsHdIntervalTariff3Cb.SelectedItem;
                }
                else if (sender == WsHdIntervalTariff4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[3].IntervalTariff = (DefaultTariffBand)WsHdIntervalTariff4Cb.SelectedItem;
                }
                else if (sender == WsHdIntervalTariff5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[4].IntervalTariff = (DefaultTariffBand)WsHdIntervalTariff5Cb.SelectedItem;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SsWdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == SsWdIntervalTariff1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[0].IntervalTariff = (DefaultTariffBand)WsWdIntervalTariff1Cb.SelectedItem;
                }
                else if (sender == SsWdIntervalTariff2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[1].IntervalTariff = (DefaultTariffBand)SsWdIntervalTariff2Cb.SelectedItem;
                }
                else if (sender == SsWdIntervalTariff3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[2].IntervalTariff = (DefaultTariffBand)SsWdIntervalTariff3Cb.SelectedItem;
                }
                else if (sender == SsWdIntervalTariff4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[3].IntervalTariff = (DefaultTariffBand)SsWdIntervalTariff4Cb.SelectedItem;
                }
                else if (sender == SsWdIntervalTariff5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[4].IntervalTariff = (DefaultTariffBand)SsWdIntervalTariff5Cb.SelectedItem;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SsSdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == SsSdIntervalTariff1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[0].IntervalTariff = (DefaultTariffBand)SsSdIntervalTariff1Cb.SelectedItem;
                }
                else if (sender == SsSdIntervalTariff2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[1].IntervalTariff = (DefaultTariffBand)SsSdIntervalTariff2Cb.SelectedItem;
                }
                else if (sender == SsSdIntervalTariff3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[2].IntervalTariff = (DefaultTariffBand)SsSdIntervalTariff3Cb.SelectedItem;
                }
                else if (sender == SsSdIntervalTariff4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[3].IntervalTariff = (DefaultTariffBand)SsSdIntervalTariff4Cb.SelectedItem;
                }
                else if (sender == SsSdIntervalTariff5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[4].IntervalTariff = (DefaultTariffBand)SsSdIntervalTariff5Cb.SelectedItem;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SsHdIntervalTariffCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == SsHdIntervalTariff1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[0].IntervalTariff = (DefaultTariffBand)SsHdIntervalTariff1Cb.SelectedItem;
                }
                else if (sender == SsHdIntervalTariff2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[1].IntervalTariff = (DefaultTariffBand)SsHdIntervalTariff2Cb.SelectedItem;
                }
                else if (sender == SsHdIntervalTariff3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[2].IntervalTariff = (DefaultTariffBand)SsHdIntervalTariff3Cb.SelectedItem;
                }
                else if (sender == SsHdIntervalTariff4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[3].IntervalTariff = (DefaultTariffBand)SsHdIntervalTariff4Cb.SelectedItem;
                }
                else if (sender == SsHdIntervalTariff5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[4].IntervalTariff = (DefaultTariffBand)SsHdIntervalTariff5Cb.SelectedItem;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsSiIntervalEnabled_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (sender == WsSdInterval1Cb)
                    {
                        (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[0].UseInterval = WsSdInterval1Cb.Checked;
                    }
                    else if (sender == WsSdInterval2Cb)
                    {
                        (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[1].UseInterval = WsSdInterval2Cb.Checked;
                    }
                    else if (sender == WsSdInterval3Cb)
                    {
                        (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[2].UseInterval = WsSdInterval3Cb.Checked;
                    }
                    else if (sender == WsSdInterval4Cb)
                    {
                        (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[3].UseInterval = WsSdInterval4Cb.Checked;
                    }
                    else if (sender == WsSdInterval5Cb)
                    {
                        (Target as GXDLMSTariffPlan).Plan.WinterSeason.SaturdayIntervals[4].UseInterval = WsSdInterval5Cb.Checked;
                    }
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                    errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Parent, ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsWdIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == WsWdIntervalCb1)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[0].UseInterval = WsWdIntervalCb1.Checked;
                }
                else if (sender == WsWdIntervalCb2)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[1].UseInterval = WsWdIntervalCb2.Checked;
                }
                else if (sender == WsWdIntervalCb3)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[2].UseInterval = WsWdIntervalCb3.Checked;
                }
                else if (sender == WsWdIntervalCb4)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[3].UseInterval = WsWdIntervalCb4.Checked;
                }
                else if (sender == WsWdIntervalCb5)
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.WorkingDayIntervals[4].UseInterval = WsWdIntervalCb5.Checked;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SsWdIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == SsWdInterval1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[0].UseInterval = SsWdInterval1Cb.Checked;
                }
                else if (sender == SsWdInterval2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[0].UseInterval = SsWdInterval2Cb.Checked;
                }
                else if (sender == SsWdInterval3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[0].UseInterval = SsWdInterval3Cb.Checked;
                }
                else if (sender == SsWdInterval4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[0].UseInterval = SsWdInterval4Cb.Checked;
                }
                else if (sender == SsWdInterval5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[0].UseInterval = SsWdInterval5Cb.Checked;
                }

                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSSiUseIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == SsSdInterval1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[0].UseInterval = SsSdInterval1Cb.Checked;
                }
                else if (sender == SsSdInterval2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[1].UseInterval = SsSdInterval2Cb.Checked;
                }
                else if (sender == SsSdInterval3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[2].UseInterval = SsSdInterval3Cb.Checked;
                }
                else if (sender == SsSdInterval4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[3].UseInterval = SsSdInterval4Cb.Checked;
                }
                else if (sender == SsSdInterval5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[4].UseInterval = SsSdInterval5Cb.Checked;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SSHiUseIntervalCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == SsHdInterval1Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[0].UseInterval = SsHdInterval1Cb.Checked;
                }
                else if (sender == SsHdInterval2Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[1].UseInterval = SsHdInterval2Cb.Checked;
                }
                else if (sender == SsHdInterval3Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[2].UseInterval = SsHdInterval3Cb.Checked;
                }
                else if (sender == SsHdInterval4Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[3].UseInterval = SsHdInterval4Cb.Checked;
                }
                else if (sender == SsHdInterval5Cb)
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[4].UseInterval = SsHdInterval5Cb.Checked;
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
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
                MessageBox.Show(Parent, ex.Message, "Error",
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
                if (sender == SSWdStartHour1Tb && SSWdStartHour1Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[0].StartHour = byte.Parse(SSWdStartHour1Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSWdStartHour1Tb, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSWdStartHour2Tb && SSWdStartHour2Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[1].StartHour = byte.Parse(SSWdStartHour2Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSWdStartHour2Tb, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSWdStartHour3Tb && SSWdStartHour3Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[2].StartHour = byte.Parse(SSWdStartHour3Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSWdStartHour3Tb, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSWdStartHour4Tb && SSWdStartHour4Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[3].StartHour = byte.Parse(SSWdStartHour4Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSWdStartHour4Tb, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSWdStartHour5Tb && SSWdStartHour5Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.WorkingDayIntervals[4].StartHour = byte.Parse(SSWdStartHour5Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError(SSWdStartHour5Tb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
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
                if (sender == SSSiStartHour1Tb && SSWdStartHour1Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[0].StartHour = byte.Parse(SSSiStartHour1Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSSiStartHour2Tb && SSSiStartHour2Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[0].StartHour = byte.Parse(SSSiStartHour2Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSSiStartHour3Tb && SSSiStartHour3Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[0].StartHour = byte.Parse(SSSiStartHour3Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSSiStartHour4Tb && SSSiStartHour4Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[0].StartHour = byte.Parse(SSSiStartHour4Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
                }
                else if (sender == SSSiStartHour5Tb && SSSiStartHour5Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.SaturdayIntervals[0].StartHour = byte.Parse(SSSiStartHour5Tb.Text);
                    Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                    errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
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
                if (sender == SSHiStartHour1Tb && SSHiStartHour1Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour1Tb.Text);
                }
                else if (sender == SSHiStartHour2Tb && SSHiStartHour2Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour2Tb.Text);
                }
                else if (sender == SSHiStartHour3Tb && SSHiStartHour3Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour3Tb.Text);
                }
                else if (sender == SSHiStartHour4Tb && SSHiStartHour4Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour4Tb.Text);
                }
                else if (sender == SSHiStartHour5Tb && SSHiStartHour5Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.SummerSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour5Tb.Text);
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.SummerSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
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

        private void WsHdStartHourTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (sender == WsHiStartHour1Tb && WsHiStartHour1Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[0].StartHour = byte.Parse(WsHiStartHour1Tb.Text);
                }
                else if (sender == SSHiStartHour2Tb && SSHiStartHour2Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour2Tb.Text);
                }
                else if (sender == SSHiStartHour3Tb && SSHiStartHour3Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour3Tb.Text);
                }
                else if (sender == SSHiStartHour4Tb && SSHiStartHour4Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour4Tb.Text);
                }
                else if (sender == SSHiStartHour5Tb && SSHiStartHour5Tb.Text != "")
                {
                    (Target as GXDLMSTariffPlan).Plan.WinterSeason.HolidayIntervals[0].StartHour = byte.Parse(SSHiStartHour5Tb.Text);
                }
                Target.UpdateDirty(4, (Target as GXDLMSTariffPlan).Plan.WinterSeason);
                errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WsHdStartHourTb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                WsHdStartHourTb_Leave(null, null);
            }
        }
    }
}
