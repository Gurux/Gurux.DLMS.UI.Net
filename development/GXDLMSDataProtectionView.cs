//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL:
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

using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSDataProtection
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSDataProtection))]
    partial class GXDLMSDataProtectionView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSDataProtectionView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSDataProtection target = Target as GXDLMSDataProtection;
            if (arg.Index == 3)
            {
                ObjectsLv.Items.Clear();
                foreach (var it in target.Objects)
                {
                    ListViewItem li = ObjectsLv.Items.Add(it.Key.ObjectType.ToString());
                    li.SubItems.Add(it.Key.LogicalName);
                    li.SubItems.Add(it.Value.AttributeIndex.ToString());
                    li.SubItems.Add(it.Value.DataIndex.ToString());
                    li.Tag = it;
                }
            }
            else if (arg.Index == 4)
            {
                GetLv.Items.Clear();
                foreach (var it in target.GetParameters)
                {
                    ListViewItem li = GetLv.Items.Add(it.ProtectionType.ToString());
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.TransactionId));
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.OriginatorSystemTitle));
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.RecipientSystemTitle));
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.OtherInformation));
                    li.SubItems.Add(it.KeyInfo.DataProtectionKeyType.ToString());
                    li.Tag = it;
                }

            }
            else if (arg.Index == 5)
            {
                SetLv.Items.Clear();
                foreach (var it in target.SetParameters)
                {
                    ListViewItem li = SetLv.Items.Add(it.ProtectionType.ToString());
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.TransactionId));
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.OriginatorSystemTitle));
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.RecipientSystemTitle));
                    li.SubItems.Add(GXDLMSTranslator.ToHex(it.OtherInformation));
                    li.SubItems.Add(it.KeyInfo.DataProtectionKeyType.ToString());
                    li.Tag = it;
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
                errorProvider1.SetError(ProtectionBufferTb, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            bool enabled = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
            if (arg.Index == 3)
            {
                //MIKKO TimeTB.ReadOnly = !enabled;
                //MIKKO UpdateTimeBtn.Enabled = enabled;
            }
            else if (arg.Index == 4)
            {
                //MIKKO TimeTB.ReadOnly = !enabled;
                //MIKKO UpdateTimeBtn.Enabled = enabled;
            }
            else if (arg.Index == 5)
            {
                //MIKKO TimeTB.ReadOnly = !enabled;
                //MIKKO UpdateTimeBtn.Enabled = enabled;
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




        private void ValueTB_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void ValueTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }
    }
}
