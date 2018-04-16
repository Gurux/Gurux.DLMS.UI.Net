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
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSActivityCalendar
    /// </summary>
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

        private void UpdateSeasonProfile(GXDLMSSeasonProfile it, ListViewItem li, ListView target)
        {
            string str;
            if (GXHelpers.IsAscii(it.Name))
            {
                str = ASCIIEncoding.ASCII.GetString(it.Name);
            }
            else
            {
                str = GXDLMSTranslator.ToHex(it.Name);
            }
            if (li == null)
            {
                li = target.Items.Add(str);
                li.SubItems.AddRange(new string[] { "", "" });
                li.Tag = it;
            }
            else
            {
                li.SubItems[0].Text = str;
            }
            li.SubItems[1].Text = it.Start.ToFormatString();
            if (GXHelpers.IsAscii(it.WeekName))
            {
                li.SubItems[2].Text = ASCIIEncoding.ASCII.GetString(it.WeekName);
            }
            else
            {
                li.SubItems[2].Text = GXDLMSTranslator.ToHex(it.WeekName);
            }

        }

        private void UpdateWeekProfile(GXDLMSWeekProfile it, ListViewItem li, ListView list)
        {
            string str;
            if (GXHelpers.IsAscii(it.Name))
            {
                str = ASCIIEncoding.ASCII.GetString(it.Name);
            }
            else
            {
                str = GXDLMSTranslator.ToHex(it.Name);
            }
            if (li == null)
            {
                li = list.Items.Add(str);
                li.SubItems.AddRange(new string[] { it.Monday.ToString(), it.Tuesday.ToString(),
                it.Wednesday.ToString(),it.Thursday.ToString(), it.Friday.ToString(),
                    it.Saturday.ToString(), it.Sunday.ToString() });
                li.Tag = it;
            }
            else
            {
                li.SubItems[0].Text = str;
                li.SubItems[1].Text = it.Monday.ToString();
                li.SubItems[2].Text = it.Tuesday.ToString();
                li.SubItems[3].Text = it.Wednesday.ToString();
                li.SubItems[4].Text = it.Thursday.ToString();
                li.SubItems[5].Text = it.Friday.ToString();
                li.SubItems[6].Text = it.Saturday.ToString();
                li.SubItems[7].Text = it.Sunday.ToString();
            }
        }

        private void UpdateDayProfile(GXDLMSDayProfile it, ListViewItem li, int index)
        {
            ListView list;
            if (index == 5)
            {
                list = ActiveDaysList;
            }
            else
            {
                list = PassiveDaysList;
            }

            if (li == null)
            {
                li = list.Items.Add(it.DayId.ToString());
                li.Tag = it;
            }
            else
            {
                li.SubItems[0].Text = it.DayId.ToString();
            }
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
            if (index == 3)
            {
                SeasonProfileActiveLV.Items.Clear();
                if (target.SeasonProfileActive != null)
                {
                    foreach (GXDLMSSeasonProfile it in target.SeasonProfileActive)
                    {
                        UpdateSeasonProfile(it, null, SeasonProfileActiveLV);
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
                        UpdateWeekProfile(it, null, AWeekProfileLV);
                    }
                }
            }
            else if (index == 5)
            {
                ActiveDaysList.Items.Clear();
                if (target.DayProfileTableActive != null)
                {
                    foreach (GXDLMSDayProfile it in target.DayProfileTableActive)
                    {
                        UpdateDayProfile(it, null, index);
                    }
                }
                //Select first item.
                if (ActiveDaysList.Items.Count != 0)
                {
                    ActiveDaysList.Items[0].Selected = true;
                }
            }
            else if (index == 7)
            {
                SeasonProfilePassiveLV.Items.Clear();
                if (target.SeasonProfilePassive != null)
                {
                    foreach (GXDLMSSeasonProfile it in target.SeasonProfilePassive)
                    {
                        UpdateSeasonProfile(it, null, SeasonProfilePassiveLV);
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
                        UpdateWeekProfile(it, null, PWeekProfileLV);
                    }
                }
            }
            else if (index == 9)
            {
                PassiveDaysList.Items.Clear();
                if (target.DayProfileTablePassive != null)
                {
                    foreach (GXDLMSDayProfile it in target.DayProfileTablePassive)
                    {
                        UpdateDayProfile(it, null, index);
                    }
                }
                //Select first item.
                if (PassiveDaysList.Items.Count != 0)
                {
                    PassiveDaysList.Items[0].Selected = true;
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 3)
            {
                SeasonProfileActiveRemoveBtn.Enabled = SeasonProfileActiveEditBtn.Enabled = SeasonProfileActiveAddBtn.Enabled = enabled;
            }
            else if (index == 4)
            {
                WeekProfileActiveRemoveBtn.Enabled = WeekProfileActiveEditBtn.Enabled = WeekProfileActiveAddBtn.Enabled = enabled;
            }
            else if (index == 5)
            {
                AddDayActiveBtn.Enabled = DayProfileActiveRemoveBtn.Enabled = DayProfileActiveEditBtn.Enabled = ActiveActionAddBtn.Enabled = enabled;
            }
            else if (index == 7)
            {
                SeasonProfilePassiveRemoveBtn.Enabled = SeasonProfilePassiveEditBtn.Enabled = SeasonProfilePassiveAddBtn.Enabled = enabled;
            }
            else if (index == 8)
            {
                WeekProfilePassiveRemoveBtn.Enabled = WeekProfilePassiveEditBtn.Enabled = WeekProfilePassiveAddBtn.Enabled = enabled;
            }
            else if (index == 9)
            {
                AddDayPassiveBtn.Enabled = DayProfilePassiveRemoveBtn.Enabled = DayProfilePassiveEditBtn.Enabled = PassiveActionAddBtn.Enabled = enabled;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        public void PreAction(GXActionArgs arg)
        {
            if (GXHelpers.ShowMessageBox(this, Properties.Resources.ActivatePassiveCalendar, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                arg.Value = (sbyte)0;
            }
            else
            {
                arg.Action = ActionType.None;
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        #endregion

        private void AddSeasonProfile(GXDLMSActivityCalendar target, int index, ListView li)
        {
            GXDLMSSeasonProfile item = new GXDLMSSeasonProfile();
            GXDLMSSeasonProfile[] list;
            if (index == 3)
            {
                list = target.SeasonProfileActive;
            }
            else
            {
                list = target.SeasonProfilePassive;
            }
            GXDLMSActivityCalendarSeasonProfileDlg dlg = new GXDLMSActivityCalendarSeasonProfileDlg(item, index == 3 ? target.WeekProfileTableActive : target.WeekProfileTablePassive);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                List<GXDLMSSeasonProfile> items = new List<GXDLMSSeasonProfile>();
                if (list != null)
                {
                    items.AddRange(list);
                }
                items.Add(item);
                if (index == 3)
                {
                    target.SeasonProfileActive = items.ToArray();
                }
                else
                {
                    target.SeasonProfilePassive = items.ToArray();
                }
                UpdateSeasonProfile(item, null, li);
                errorProvider1.SetError(li, Properties.Resources.ValueChangedTxt);
                target.UpdateDirty(index, list);
            }
        }

        private void EditSeasonProfile(GXDLMSActivityCalendar target, GXDLMSSeasonProfile[] list, int index, ListViewItem li, ListView lv)
        {
            GXDLMSSeasonProfile item = (GXDLMSSeasonProfile)li.Tag;
            GXDLMSActivityCalendarSeasonProfileDlg dlg = new GXDLMSActivityCalendarSeasonProfileDlg(item, index == 3 ? target.WeekProfileTableActive : target.WeekProfileTablePassive);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                UpdateSeasonProfile(item, li, lv);
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(index, list);
            }
        }

        private void RemoveSeasonProfile(GXDLMSActivityCalendar target, int index, ListView lv)
        {
            List<GXDLMSSeasonProfile> entries = new List<GXDLMSSeasonProfile>();
            if (index == 3)
            {
                if (target.SeasonProfileActive != null)
                {
                    entries.AddRange(target.SeasonProfileActive);
                }
            }
            else
            {
                if (target.SeasonProfilePassive != null)
                {
                    entries.AddRange(target.SeasonProfilePassive);
                }
            }

            while (lv.SelectedItems.Count != 0)
            {
                ListViewItem li = lv.SelectedItems[0];
                GXDLMSSeasonProfile item = (GXDLMSSeasonProfile)li.Tag;
                li.Remove();
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                if (index == 3)
                {
                    Target.UpdateDirty(index, target.SeasonProfileActive);
                }
                else
                {
                    Target.UpdateDirty(index, target.SeasonProfilePassive);
                }
                entries.Remove(item);
            }
            if (index == 3)
            {
                target.SeasonProfileActive = entries.ToArray();
            }
            else
            {
                target.SeasonProfilePassive = entries.ToArray();
            }
        }

        private void AddWeekProfile(GXDLMSActivityCalendar target, int index, ListView li)
        {
            GXDLMSWeekProfile item = new GXDLMSWeekProfile();
            GXDLMSWeekProfile[] list;
            GXDLMSDayProfile[] days;
            if (index == 3)
            {
                list = target.WeekProfileTableActive;
                days = target.DayProfileTableActive;
            }
            else
            {
                list = target.WeekProfileTablePassive;
                days = target.DayProfileTablePassive;
            }

            GXDLMSActivityCalendarWeekProfileDlg dlg = new GXDLMSActivityCalendarWeekProfileDlg(item, days);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                List<GXDLMSWeekProfile> items = new List<GXDLMSWeekProfile>();
                if (list != null)
                {
                    items.AddRange(list);
                }
                items.Add(item);
                if (index == 4)
                {
                    target.WeekProfileTableActive = items.ToArray();
                }
                else
                {
                    target.WeekProfileTablePassive = items.ToArray();
                }
                UpdateWeekProfile(item, null, li);
                errorProvider1.SetError(li, Properties.Resources.ValueChangedTxt);
                target.UpdateDirty(index, list);
            }
        }

        private void EditWeekProfile(GXDLMSActivityCalendar target, GXDLMSWeekProfile[] list, int index, ListViewItem li, ListView lv)
        {
            GXDLMSWeekProfile item = (GXDLMSWeekProfile)li.Tag;
            GXDLMSDayProfile[] days;
            if (index == 3)
            {
                days = target.DayProfileTableActive;
            }
            else
            {
                days = target.DayProfileTablePassive;
            }

            GXDLMSActivityCalendarWeekProfileDlg dlg = new GXDLMSActivityCalendarWeekProfileDlg(item, days);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                UpdateWeekProfile(item, li, lv);
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(index, list);
            }
        }

        private void RemoveWeekProfile(GXDLMSActivityCalendar target, int index, ListView lv)
        {
            List<GXDLMSWeekProfile> entries = new List<GXDLMSWeekProfile>();
            if (index == 3)
            {
                if (target.WeekProfileTableActive != null)
                {
                    entries.AddRange(target.WeekProfileTableActive);
                }
            }
            else
            {
                if (target.WeekProfileTablePassive != null)
                {
                    entries.AddRange(target.WeekProfileTablePassive);
                }
            }

            while (lv.SelectedItems.Count != 0)
            {
                ListViewItem li = lv.SelectedItems[0];
                GXDLMSWeekProfile item = (GXDLMSWeekProfile)li.Tag;
                li.Remove();
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                if (index == 3)
                {
                    Target.UpdateDirty(index, target.WeekProfileTableActive);
                }
                else
                {
                    Target.UpdateDirty(index, target.WeekProfileTablePassive);
                }
                entries.Remove(item);
            }
            if (index == 3)
            {
                target.WeekProfileTableActive = entries.ToArray();
            }
            else
            {
                target.WeekProfileTablePassive = entries.ToArray();
            }
        }


        private void AddDayId(GXDLMSActivityCalendar target, int index, ListView li)
        {
            GXDLMSDayProfile item = new GXDLMSDayProfile();
            GXDLMSDayProfile[] list;
            if (index == 5)
            {
                list = target.DayProfileTableActive;
            }
            else
            {
                list = target.DayProfileTablePassive;
            }
            GXDLMSActivityCalendarDayProfileDlg dlg = new GXDLMSActivityCalendarDayProfileDlg(item);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                List<GXDLMSDayProfile> items = new List<GXDLMSDayProfile>();
                if (list != null)
                {
                    items.AddRange(list);
                }
                items.Add(item);
                if (index == 5)
                {
                    target.DayProfileTableActive = items.ToArray();
                }
                else
                {
                    target.DayProfileTablePassive = items.ToArray();
                }
                UpdateDayProfile(item, null, index);
                errorProvider1.SetError(li, Properties.Resources.ValueChangedTxt);
                target.UpdateDirty(index, list);
            }
        }

        private void EditDayId(GXDLMSActivityCalendar target, GXDLMSDayProfile[] list, int index, ListViewItem li, ListView lv)
        {
            GXDLMSDayProfile item = (GXDLMSDayProfile)li.Tag;
            GXDLMSActivityCalendarDayProfileDlg dlg = new GXDLMSActivityCalendarDayProfileDlg(item);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                UpdateDayProfile(item, li, index);
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(index, list);
            }
        }

        private void RemoveDayId(GXDLMSActivityCalendar target, int index, ListView lv)
        {
            List<GXDLMSDayProfile> entries = new List<GXDLMSDayProfile>();
            if (index == 5)
            {
                if (target.DayProfileTableActive != null)
                {
                    entries.AddRange(target.DayProfileTableActive);
                }
            }
            else
            {
                if (target.DayProfileTablePassive != null)
                {
                    entries.AddRange(target.DayProfileTablePassive);
                }
            }

            while (lv.SelectedItems.Count != 0)
            {
                ListViewItem li = lv.SelectedItems[0];
                GXDLMSDayProfile item = (GXDLMSDayProfile)li.Tag;
                li.Remove();
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                if (index == 5)
                {
                    Target.UpdateDirty(index, target.DayProfileTableActive);
                }
                else
                {
                    Target.UpdateDirty(index, target.DayProfileTablePassive);
                }
                entries.Remove(item);
            }
            if (index == 5)
            {
                target.DayProfileTableActive = entries.ToArray();
            }
            else
            {
                target.DayProfileTablePassive = entries.ToArray();
            }
        }



        private void AddDayAction(GXDLMSActivityCalendar c, GXDLMSDayProfile target, int index, ListView li)
        {
            GXDLMSDayProfileAction item = new GXDLMSDayProfileAction();
            GXDLMSActivityCalendarActionDlg dlg = new GXDLMSActivityCalendarActionDlg(item, Target.Parent.GetObjects(ObjectType.ScriptTable));
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                List<GXDLMSDayProfileAction> items = new List<GXDLMSDayProfileAction>();
                if (target.DaySchedules != null)
                {
                    items.AddRange(target.DaySchedules);
                }
                items.Add(item);
                target.DaySchedules = items.ToArray();
                if (index == 5)
                {
                    ActiveDaysList_SelectedIndexChanged(null, null);
                }
                else
                {
                    PassiveDaysList_SelectedIndexChanged(null, null);
                }
                errorProvider1.SetError(li, Properties.Resources.ValueChangedTxt);
                c.UpdateDirty(index, target.DaySchedules);
            }
        }

        private void EditDayAction(int index, ListViewItem li, ListView lv)
        {
            GXDLMSDayProfileAction item = (GXDLMSDayProfileAction)li.Tag;
            GXDLMSActivityCalendarActionDlg dlg = new GXDLMSActivityCalendarActionDlg(item, Target.Parent.GetObjects(ObjectType.ScriptTable));
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (index == 5)
                {
                    ActiveDaysList_SelectedIndexChanged(null, null);
                }
                else
                {
                    PassiveDaysList_SelectedIndexChanged(null, null);
                }
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(index, item);
            }
        }

        private void RemoveDayAction(GXDLMSDayProfile target, int index, ListView lv)
        {
            List<GXDLMSDayProfileAction> entries = new List<GXDLMSDayProfileAction>();
            entries.AddRange(target.DaySchedules);

            while (lv.SelectedItems.Count != 0)
            {
                ListViewItem li = lv.SelectedItems[0];
                GXDLMSDayProfileAction item = (GXDLMSDayProfileAction)li.Tag;
                li.Remove();
                errorProvider1.SetError(lv, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(index, target.DaySchedules);
                entries.Remove(item);
            }
            target.DaySchedules = entries.ToArray();
        }


        /// <summary>
        /// Add new season profile.
        /// </summary>
        private void SeasonProfileActiveAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl2.SelectedTab == SeasonProfileActiveTab)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    AddSeasonProfile(target, 3, SeasonProfileActiveLV);
                }
                else if (tabControl2.SelectedTab == WeekProfileActiveTab)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    AddSeasonProfile(target, 3, SeasonProfileActiveLV);
                }
                else if (tabControl2.SelectedTab == DayProfileActiveTab)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    AddSeasonProfile(target, 3, SeasonProfileActiveLV);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit season profile.
        /// </summary>
        private void SeasonProfileActiveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeasonProfileActiveLV.SelectedItems.Count == 1)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    ListViewItem li = SeasonProfileActiveLV.SelectedItems[0];
                    EditSeasonProfile(target, target.SeasonProfileActive, 3, li, SeasonProfileActiveLV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove season profile.
        /// </summary>
        private void SeasonProfileActiveRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                RemoveSeasonProfile(target, 3, SeasonProfileActiveLV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeasonProfilePassiveAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                AddSeasonProfile(target, 7, SeasonProfilePassiveLV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeasonProfilePassiveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeasonProfilePassiveLV.SelectedItems.Count == 1)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    ListViewItem li = SeasonProfilePassiveLV.SelectedItems[0];
                    EditSeasonProfile(target, target.SeasonProfilePassive, 7, li, SeasonProfilePassiveLV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeasonProfilePassiveRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                RemoveSeasonProfile(target, 7, SeasonProfilePassiveLV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DayProfilePassiveAddBtn_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add new active week profile.
        /// </summary>
        private void WeekProfileActiveAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                AddWeekProfile(target, 4, AWeekProfileLV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit active week profile.
        /// </summary>
        private void WeekProfileActiveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AWeekProfileLV.SelectedItems.Count == 1)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    ListViewItem li = AWeekProfileLV.SelectedItems[0];
                    EditWeekProfile(target, target.WeekProfileTableActive, 4, li, AWeekProfileLV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove active week profile.
        /// </summary>
        private void WeekProfileActiveRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                RemoveWeekProfile(target, 4, AWeekProfileLV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add new passive week profile.
        /// </summary>
        private void WeekProfilePassiveAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                AddWeekProfile(target, 8, PWeekProfileLV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Edit passive week profile.
        /// </summary>
        private void WeekProfilePassiveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PWeekProfileLV.SelectedItems.Count == 1)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    ListViewItem li = PWeekProfileLV.SelectedItems[0];
                    EditWeekProfile(target, target.WeekProfileTablePassive, 8, li, PWeekProfileLV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // <summary>
        /// Remove passive week profile.
        /// </summary>
        private void WeekProfilePassiveRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                RemoveWeekProfile(target, 8, PWeekProfileLV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActiveDaysList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveActionList.Items.Clear();
            if (ActiveDaysList.SelectedItems.Count == 1)
            {
                GXDLMSDayProfile it = (GXDLMSDayProfile)ActiveDaysList.SelectedItems[0].Tag;
                if (it.DaySchedules != null)
                {
                    ListViewItem li;
                    foreach (GXDLMSDayProfileAction day in it.DaySchedules)
                    {
                        li = ActiveActionList.Items.Add(day.StartTime.ToFormatString());
                        li.SubItems.Add(day.ScriptLogicalName);
                        li.SubItems.Add(day.ScriptSelector.ToString());
                        li.Tag = day;
                    }
                }
            }
        }

        private void PassiveDaysList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PassiveActionList.Items.Clear();
            if (PassiveDaysList.SelectedItems.Count == 1)
            {
                GXDLMSDayProfile it = (GXDLMSDayProfile)PassiveDaysList.SelectedItems[0].Tag;
                if (it.DaySchedules != null)
                {
                    ListViewItem li;
                    foreach (GXDLMSDayProfileAction day in it.DaySchedules)
                    {
                        li = PassiveActionList.Items.Add(day.StartTime.ToFormatString());
                        li.SubItems.Add(day.ScriptLogicalName);
                        li.SubItems.Add(day.ScriptSelector.ToString());
                        li.Tag = day;
                    }
                }
            }
        }

        /// <summary>
        /// Add new active day.
        /// </summary>
        private void AddDayActiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                AddDayId(target, 5, ActiveDaysList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add new active action.
        /// </summary>
        private void ActiveActionAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveDaysList.SelectedItems.Count == 1)
                {
                    GXDLMSDayProfile it = (GXDLMSDayProfile)ActiveDaysList.SelectedItems[0].Tag;
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    AddDayAction(target, it, 5, ActiveDaysList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit selected active day.
        /// </summary>
        private void DayProfileActiveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveActionList.SelectedItems.Count == 0)
                {
                    if (ActiveDaysList.SelectedItems.Count == 1)
                    {
                        GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                        EditDayId(target, target.DayProfileTableActive, 5, ActiveDaysList.SelectedItems[0], ActiveDaysList);
                    }
                }
                else
                {
                    if (ActiveActionList.SelectedItems.Count == 1)
                    {
                        ListViewItem li = ActiveActionList.SelectedItems[0];
                        EditDayAction(5, li, ActiveActionList);
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
        /// Remove selected active day.
        /// </summary>
        private void DayProfileActiveRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveActionList.SelectedItems.Count == 0)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    while (ActiveDaysList.SelectedItems.Count == 1)
                    {
                        RemoveDayId(target, 5, ActiveDaysList);
                    }
                }
                else
                {
                    GXDLMSDayProfile target = ActiveDaysList.SelectedItems[0].Tag as GXDLMSDayProfile;
                    if (ActiveActionList.SelectedItems.Count != 0)
                    {
                        RemoveDayAction(target, 5, ActiveActionList);
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
        /// Add new passive day.
        /// </summary>
        private void AddDayPassiveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                AddDayId(target, 9, PassiveDaysList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add new passive action.
        /// </summary>
        private void PassiveActionAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassiveDaysList.SelectedItems.Count == 1)
                {
                    GXDLMSDayProfile it = (GXDLMSDayProfile)PassiveDaysList.SelectedItems[0].Tag;
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    AddDayAction(target, it, 9, PassiveDaysList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit selected active day.
        /// </summary>
        private void DayProfilePassiveEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassiveActionList.SelectedItems.Count == 0)
                {
                    if (PassiveDaysList.SelectedItems.Count == 1)
                    {
                        GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                        EditDayId(target, target.DayProfileTableActive, 9, PassiveDaysList.SelectedItems[0], PassiveDaysList);
                    }
                }
                else
                {
                    if (PassiveActionList.SelectedItems.Count == 1)
                    {
                        ListViewItem li = PassiveActionList.SelectedItems[0];
                        EditDayAction(9, li, PassiveActionList);
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
        /// Remove selected active day or actions.
        /// </summary>
        private void DayProfilePassiveRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassiveActionList.SelectedItems.Count == 0)
                {
                    GXDLMSActivityCalendar target = Target as GXDLMSActivityCalendar;
                    while (PassiveDaysList.SelectedItems.Count == 1)
                    {
                        RemoveDayId(target, 9, PassiveDaysList);
                    }
                }
                else
                {
                    GXDLMSDayProfile target = PassiveDaysList.SelectedItems[0].Tag as GXDLMSDayProfile;
                    if (PassiveActionList.SelectedItems.Count != 0)
                    {
                        RemoveDayAction(target, 9, PassiveActionList);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
