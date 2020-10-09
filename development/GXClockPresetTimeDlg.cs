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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXClockPresetTimeDlg : Form
    {
        /// <summary>
        /// Preset time.
        /// </summary>
        internal GXDateTime PresetTime
        {
            get;
            private set;
        }

        /// <summary>
        /// Interval start.
        /// </summary>
        internal GXDateTime IntervalStart
        {
            get;
            private set;
        }

        /// <summary>
        /// Interval end.
        /// </summary>
        internal GXDateTime IntervalEnd
        {
            get;
            private set;
        }

        public GXClockPresetTimeDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Accept changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PresetTime = new GXDateTime(PresetTimeTb.Text);
                IntervalStart = new GXDateTime(IntervalStartTb.Text);
                IntervalEnd = new GXDateTime(IntervalEndTb.Text);
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NowPresetBtn_Click(object sender, EventArgs e)
        {
            PresetTimeTb.Text = DateTime.Now.ToString();
        }

        private void NowStartBtn_Click(object sender, EventArgs e)
        {
            IntervalStartTb.Text = DateTime.Now.ToString();
        }

        private void NowEndBtn_Click(object sender, EventArgs e)
        {
            IntervalEndTb.Text = DateTime.Now.ToString();
        }
    }
}
