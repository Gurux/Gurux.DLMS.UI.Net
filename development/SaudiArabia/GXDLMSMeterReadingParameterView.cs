//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSMeterReadingParameterView.cs $
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
using System.Text;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Custom UI for Meter reading parameter.
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSData), 0, "0.96.15.128.0.255", Standard.SaudiArabia)]
    partial class GXDLMSMeterReadingParameterView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSMeterReadingParameterView()
        {
            InitializeComponent();
            ValuesLb.Items.Add("reserved");
            ValuesLb.Items.Add("Program change");
            ValuesLb.Items.Add("By date-time change");
            ValuesLb.Items.Add("On command via the communication interfaces");
            ValuesLb.Items.Add("By internal clock schedule");
            ValuesLb.Items.Add("Pass a date (or a month)");
            ValuesLb.Items.Add("reserved");
            ValuesLb.Items.Add("reserved");
            ValuesLb.Items.Add("By manual push-button");
            ValuesLb.Items.Add("Program change");
            ValuesLb.Items.Add("By date-time change");
            ValuesLb.Items.Add("On command via the communication interfaces");
            ValuesLb.Items.Add("By internal clock schedule");
            ValuesLb.Items.Add("Pass a month");
            ValuesLb.Items.Add("reserved");
            ValuesLb.Items.Add("reserved");
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            if (arg.Index == 2)
            {
                if (arg.Value is byte[] && (arg.Value as byte[]).Length == 6)
                {
                    GXBitString bs = new GXBitString((byte[])arg.Value, 0);
                    int val = Convert.ToUInt16(bs);
                    ValuesLb.ItemCheck -= ValuesLb_ItemCheck;
                    for (int pos = 0; pos != 16; ++pos)
                    {
                        ValuesLb.SetItemChecked(pos, bs.Value[pos] == '1');
                    }
                    ValuesLb.ItemCheck += ValuesLb_ItemCheck;
                    GXByteBuffer bb = new GXByteBuffer((byte[])arg.Value);
                    bb.Position = 2;
                    DurationTb.Text = bb.GetUInt32().ToString();
                    HexTb.Text = bb.ToString();
                }
                else
                {
                    DurationTb.Text = HexTb.Text = "";
                    ValuesLb.ItemCheck -= ValuesLb_ItemCheck;
                    for (int pos = 0; pos != 16; ++pos)
                    {
                        ValuesLb.SetItemChecked(pos, false);
                    }
                    ValuesLb.ItemCheck += ValuesLb_ItemCheck;

                }
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
            if (Dirty && index == 2)
            {
                errorProvider1.SetError(DurationTb, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            if (arg.Index == 2)
            {
                bool writable = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
                ValuesLb.Enabled = writable;
                DurationTb.ReadOnly = !writable;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
        {
        }
        #endregion

        private void ValuesLb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (DurationTb.Text != "")
                {
                    UInt32 dur = UInt32.Parse(DurationTb.Text);
                    StringBuilder sb = new StringBuilder();
                    for (int pos = 0; pos != 16; ++pos)
                    {
                        if (e != null && e.Index == pos)
                        {
                            sb.Append(e.NewValue == CheckState.Checked ? "1" : "0");
                        }
                        else
                        {
                            if (ValuesLb.GetItemChecked(pos))
                            {
                                sb.Append("1");
                            }
                            else
                            {
                                sb.Append("0");
                            }
                        }
                    }
                    GXBitString bs = new GXBitString(sb.ToString());
                    GXByteBuffer bb = new GXByteBuffer();
                    bb.SetUInt16(Convert.ToUInt16(bs));
                    bb.SetUInt32(dur);
                    (Target as GXDLMSData).Value = bb.Array();
                    errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, bb.Array());
                    HexTb.Text = bb.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DurationTb_Leave(object sender, EventArgs e)
        {
            ValuesLb_ItemCheck(sender, null);
        }
    }
}
