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
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSActivityCalendarWeekProfileDlg : Form
    {
        GXDLMSWeekProfile Target;
        public GXDLMSActivityCalendarWeekProfileDlg(GXDLMSWeekProfile target, GXDLMSDayProfile[] days)
        {
            InitializeComponent();
            Target = target;
            AsciiBtn.Checked = GXHelpers.IsAscii(Target.Name);
            NameTb.Text = GXHelpers.GetString(Target.Name);
            if (days == null || days.Length == 0)
            {
                MondayCb.Enabled = TuesdayCb.Enabled = WednesdayCb.Enabled = ThursdayCb.Enabled =
                FridayCb.Enabled = SaturdayCb.Enabled = SundayCb.Enabled = OkBtn.Enabled = false;
            }
            else
            {
                MondayCb.Items.AddRange(days);
                TuesdayCb.Items.AddRange(days);
                WednesdayCb.Items.AddRange(days);
                ThursdayCb.Items.AddRange(days);
                FridayCb.Items.AddRange(days);
                SaturdayCb.Items.AddRange(days);
                SundayCb.Items.AddRange(days);

                foreach (GXDLMSDayProfile it in days)
                {
                    if (it.DayId == Target.Monday)
                    {
                        MondayCb.SelectedItem = it;
                        break;
                    }
                }
                foreach (GXDLMSDayProfile it in days)
                {
                    if (it.DayId == Target.Tuesday)
                    {
                        TuesdayCb.SelectedItem = it;
                        break;
                    }
                }
                foreach (GXDLMSDayProfile it in days)
                {
                    if (it.DayId == Target.Wednesday)
                    {
                        WednesdayCb.SelectedItem = it;
                        break;
                    }
                }
                foreach (GXDLMSDayProfile it in days)
                {
                    if (it.DayId == Target.Thursday)
                    {
                        ThursdayCb.SelectedItem = it;
                        break;
                    }
                }
                foreach (GXDLMSDayProfile it in days)
                {
                    if (it.DayId == Target.Friday)
                    {
                        FridayCb.SelectedItem = it;
                        break;
                    }
                }
                foreach (GXDLMSDayProfile it in days)
                {
                    if (it.DayId == Target.Saturday)
                    {
                        SaturdayCb.SelectedItem = it;
                        break;
                    }
                }
                foreach (GXDLMSDayProfile it in days)
                {
                    if (it.DayId == Target.Sunday)
                    {
                        SundayCb.SelectedItem = it;
                        break;
                    }
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTb.Text.Length == 0)
                {
                    throw new Exception("Invalid name.");
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
                Target.Monday = ((GXDLMSDayProfile)MondayCb.SelectedItem).DayId;
                Target.Tuesday = ((GXDLMSDayProfile)TuesdayCb.SelectedItem).DayId;
                Target.Wednesday = ((GXDLMSDayProfile)WednesdayCb.SelectedItem).DayId;
                Target.Thursday = ((GXDLMSDayProfile)ThursdayCb.SelectedItem).DayId;
                Target.Friday = ((GXDLMSDayProfile)FridayCb.SelectedItem).DayId;
                Target.Saturday = ((GXDLMSDayProfile)SaturdayCb.SelectedItem).DayId;
                Target.Sunday = ((GXDLMSDayProfile)SundayCb.SelectedItem).DayId;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GXDLMSActivityCalendarWeekProfileDlg_Load(object sender, EventArgs e)
        {

        }
    }
}
