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
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSActivityCalendarWeekProfileDlg : Form
    {
        GXDLMSWeekProfile Target;
        public GXDLMSActivityCalendarWeekProfileDlg(GXDLMSWeekProfile target)
        {
            InitializeComponent();
            Target = target;
            AsciiBtn.Checked = GXHelpers.IsAscii(Target.Name);
            NameTb.Text = GXHelpers.GetString(Target.Name);
            MondayCb.Checked = Target.Monday != 0;
            TuesdayCb.Checked = Target.Tuesday != 0;
            WednesdayCb.Checked = Target.Wednesday != 0;
            ThursdayCb.Checked = Target.Thursday != 0;
            FridayCb.Checked = Target.Friday != 0;
            SaturdayCb.Checked = Target.Saturday != 0;
            SundayCb.Checked = Target.Sunday != 0;
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
                Target.Monday = MondayCb.Checked ? 1 : 0;
                Target.Tuesday = TuesdayCb.Checked ? 1 : 0;
                Target.Wednesday = WednesdayCb.Checked ? 1 : 0;
                Target.Thursday = ThursdayCb.Checked ? 1 : 0;
                Target.Friday = FridayCb.Checked ? 1 : 0;
                Target.Saturday = SaturdayCb.Checked ? 1 : 0;
                Target.Sunday = SundayCb.Checked ? 1 : 0;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
