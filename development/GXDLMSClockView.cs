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

        public void OnValueChanged(int index, object value, bool user)
        {
            GXDLMSClock target = Target as GXDLMSClock;
            if (index == 5)
            {
                BeginTB.Value = value;
            }
            else if (index == 6)
            {
                EndTB.Value = value;
            }
            else if (index == 7)
            {
                DeviationTB.Value = value;
            }
            else if (index == 8)
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

        public void OnAccessRightsChange(int index, AccessMode access)
        {
            if (index == 5)
            {
                BeginTB.Enabled = access > AccessMode.Read;
            }
            else if (index == 6)
            {
                EndTB.Enabled = access > AccessMode.Read;
            }
            else if (index == 7)
            {
                DeviationTB.Enabled = access > AccessMode.Read;
            }
            else if (index == 8)
            {
                EnabledCB.Enabled = access > AccessMode.Read;
            }
            else
            {
                throw new NotImplementedException();
            }
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
            Target.UpdateDirty(8, BeginTB.ReadOnly);
            errorProvider1.SetError(EnabledCB, Properties.Resources.ValueChangedTxt);
        }

    }
}
