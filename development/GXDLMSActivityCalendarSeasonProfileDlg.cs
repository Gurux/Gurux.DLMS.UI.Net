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
using Gurux.DLMS.Objects;
using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSActivityCalendarSeasonProfileDlg : Form
    {
        GXDLMSSeasonProfile Target;
        GXDLMSWeekProfile[] WeekProfile;
        public GXDLMSActivityCalendarSeasonProfileDlg(GXDLMSSeasonProfile target, GXDLMSWeekProfile[] weekProfiles)
        {
            InitializeComponent();
            Target = target;
            WeekProfile = weekProfiles;
            AsciiBtn.Checked = GXHelpers.IsAscii(Target.Name);
            NameTb.Text = GXHelpers.GetString(Target.Name);
            if (Target.Start != DateTime.MinValue)
            {
                StartTb.Text = Target.Start.ToFormatString();
            }
            int pos, selected = -1;
            if (weekProfiles != null)
            {
                foreach (GXDLMSWeekProfile it in weekProfiles)
                {
                    pos = WeekNameCb.Items.Add(it);
                    if (selected == -1 && StructuralComparisons.StructuralEqualityComparer.Equals(Target.WeekName, it.Name))
                    {
                        selected = pos;
                    }
                }
                if (selected != -1)
                {
                    WeekNameCb.SelectedIndex = selected;
                }
            }
            OkBtn.Enabled = weekProfiles != null && weekProfiles.Length != 0;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (WeekNameCb.SelectedIndex == -1)
                {
                    throw new Exception("Week profile is not selected.");
                }
                if (AsciiBtn.Checked)
                {
                    Target.Name = ASCIIEncoding.ASCII.GetBytes(NameTb.Text);
                }
                else
                {
                    Target.Name = GXDLMSTranslator.HexToBytes(NameTb.Text);
                }
                if (Target.Name.Length == 0)
                {
                    throw new Exception("Invalid name.");
                }
                Target.Start = new GXDateTime(StartTb.Text);
                Target.WeekName = (WeekNameCb.SelectedItem as GXDLMSWeekProfile).Name;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
