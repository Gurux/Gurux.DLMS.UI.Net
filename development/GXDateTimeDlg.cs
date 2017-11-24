//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL:  $
//
// Version:         $Revision: $,
//                  $Date: $
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

namespace Gurux.DLMS.UI
{
    public partial class GXDateTimeDlg : Form
    {
        private GXDateTime StartTime;
        private GXDateTime EndTime;


        public GXDateTimeDlg(GXDateTime startTime, GXDateTime endTime)
        {
            InitializeComponent();
            StartTime = startTime;
            EndTime = endTime;
            StartTimeTb.Text = StartTime.ToFormatString();
            EndTimeTb.Text = EndTime.ToFormatString();
        }

        public GXDateTimeDlg(GXDateTime time)
        {
            InitializeComponent();
            StartTime = time;
            StartTimeTb.Text = StartTime.ToFormatString();
            EndTimeLbl.Visible = NowEndBtn.Visible = EndTimeTb.Visible = false;
        }

        private void NowBtn_Click(object sender, EventArgs e)
        {
            if (StartTime is GXDate)
            {
                StartTimeTb.Text = new GXDate(DateTime.Now).ToString();
            }
            else if (StartTime is GXTime)
            {
                StartTimeTb.Text = new GXTime(DateTime.Now).ToString();
            }
            else
            {
                StartTimeTb.Text = DateTime.Now.ToString();
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDateTime tmp;
                if (StartTime is GXDate)
                {
                    tmp = new GXDate(StartTimeTb.Text);
                }
                else if (StartTime is GXTime)
                {
                    tmp = new GXTime(StartTimeTb.Text);
                }
                else
                {
                    tmp = new GXDateTime(StartTimeTb.Text);
                }
                StartTime.Value = tmp.Value;
                StartTime.Skip = tmp.Skip;
                if (EndTime != null)
                {
                    if (EndTime is GXDate)
                    {
                        tmp = new GXDate(EndTimeTb.Text);
                    }
                    else if (EndTime is GXTime)
                    {
                        tmp = new GXTime(EndTimeTb.Text);
                    }
                    else
                    {
                        tmp = new GXDateTime(EndTimeTb.Text);
                    }
                    EndTime.Value = tmp.Value;
                    EndTime.Skip = tmp.Skip;
                }
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NowEndBtn_Click(object sender, EventArgs e)
        {
            if (EndTime is GXDate)
            {
                EndTimeTb.Text = new GXDate(DateTime.Now).ToString();
            }
            else if (EndTime is GXTime)
            {
                EndTimeTb.Text = new GXTime(DateTime.Now).ToString();
            }
            else
            {
                EndTimeTb.Text = DateTime.Now.ToString();
            }
        }
    }
}
