//
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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
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
    [GXDLMSViewAttribute(typeof(GXDLMSActivityCalendar))]
    partial class GXDLMSActivityCalendarView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSActivityCalendarView()
        {
            InitializeComponent();
        }
        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user)
        {
            GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
            if (index == 3)
            {
                SeasonProfileActiveLV.Items.Clear();
                if (target.SeasonProfileActive != null)
                {
                    foreach (GXDLMSSeasonProfile it in target.SeasonProfileActive)
                    {
                        ListViewItem li = SeasonProfileActiveLV.Items.Add(it.Name);
                        li.SubItems.AddRange(new string[] { "", "", "", "", "", "" });
                        li.SubItems[this.YearHeader.Index].Text = it.Start.Value.Year.ToString();
                        li.SubItems[this.MonthHeader.Index].Text = it.Start.Value.Month.ToString();
                        li.SubItems[this.DayHeader.Index].Text = it.Start.Value.Day.ToString();
                        li.SubItems[this.StartHeader.Index].Text = it.Start.ToString();
                        li.SubItems[this.WeekNameHeader.Index].Text = it.WeekName;
                    }
                }
            }
            else if (index == 4)
            {
                AWeekProfileLV.Items.Clear();
                if (target.WeekProfileTableActive != null)
                {
                    foreach (GXDLMSWeekProfile it in target.WeekProfileTableActive)
                    {
                        ListViewItem li = AWeekProfileLV.Items.Add(it.Name);
                        li.SubItems.AddRange(new string[] { it.Monday.ToString(), it.Tuesday.ToString(), it.Wednesday.ToString(), it.Thursday.ToString(), it.Friday.ToString(), it.Saturday.ToString(), it.Sunday.ToString() });
                    }
                }
            }
            else if (index == 5)
            {
                ADayProfileTC.TabPages.Clear();
                if (target.DayProfileTableActive != null)
                {
                    System.Globalization.CultureInfo culture = System.Globalization.CultureInfo.CurrentUICulture;
                    foreach (GXDLMSDayProfile it in target.DayProfileTableActive)
                    {
                        TabPage pg = new TabPage("Day " + it.DayId);
                        ListView lv = new ListView();
                        lv.Dock = DockStyle.Fill;
                        lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                        lv.View = View.Details;
                        lv.Columns.Add("Start");
                        lv.Columns.Add("Script table");
                        lv.Columns.Add("Script Selector");
                        pg.Controls.Add(lv);
                        ADayProfileTC.TabPages.Add(pg);
                        foreach (GXDLMSDayProfileAction day in it.DaySchedules)
                        {
                            ListViewItem li = lv.Items.Add(day.StartTime.ToString());
                            li.SubItems.Add(day.ScriptLogicalName);
                            li.SubItems.Add(day.ScriptSelector.ToString());
                        }
                    }
                }
            }
            else if (index == 7)
            {
                SeasonProfilePassiveLV.Items.Clear();
                if (target.SeasonProfilePassive != null)
                {
                    foreach (GXDLMSSeasonProfile it in target.SeasonProfilePassive)
                    {
                        ListViewItem li = SeasonProfilePassiveLV.Items.Add(it.Name);
                        li.SubItems.AddRange(new string[] { "", "", "", "", "", "" });
                        li.SubItems[this.YearHeader.Index].Text = it.Start.Value.Year.ToString();
                        li.SubItems[this.MonthHeader.Index].Text = it.Start.Value.Month.ToString();
                        li.SubItems[this.DayHeader.Index].Text = it.Start.Value.Day.ToString();
                        li.SubItems[this.StartHeader.Index].Text = it.Start.ToString();
                        li.SubItems[this.WeekNameHeader.Index].Text = it.WeekName;
                    }
                }
            }
            else if (index == 8)
            {
                PWeekProfileLV.Items.Clear();
                if (target.WeekProfileTablePassive != null)
                {
                    foreach (GXDLMSWeekProfile it in target.WeekProfileTablePassive)
                    {
                        ListViewItem li = PWeekProfileLV.Items.Add(it.Name);
                        li.SubItems.AddRange(new string[] { it.Monday.ToString(), it.Tuesday.ToString(), it.Wednesday.ToString(), it.Thursday.ToString(), it.Friday.ToString(), it.Saturday.ToString(), it.Sunday.ToString() });
                    }
                }
            }
            else if (index == 9)
            {
                PDayProfileTC.TabPages.Clear();
                if (target.DayProfileTablePassive != null)
                {
                    foreach (GXDLMSDayProfile it in target.DayProfileTablePassive)
                    {
                        TabPage pg = new TabPage("Day " + it.DayId);
                        ListView lv = new ListView();
                        lv.Dock = DockStyle.Fill;
                        lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                        lv.View = View.Details;
                        lv.Columns.Add("Start");
                        lv.Columns.Add("Script table");
                        lv.Columns.Add("Script Selector");
                        pg.Controls.Add(lv);
                        PDayProfileTC.TabPages.Add(pg);
                        foreach (GXDLMSDayProfileAction day in it.DaySchedules)
                        {
                            ListViewItem li = lv.Items.Add(day.StartTime.ToString());
                            li.SubItems.Add(day.ScriptLogicalName);
                            li.SubItems.Add(day.ScriptSelector.ToString());
                        }
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access)
        {
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

        }

        #endregion




    }
}
