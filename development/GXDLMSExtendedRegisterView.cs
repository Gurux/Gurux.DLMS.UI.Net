//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSExtendedRegisterView.cs $
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
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSExtendedRegister
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSExtendedRegister))]
    partial class GXDLMSExtendedRegisterView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSExtendedRegisterView()
        {
            InitializeComponent();
            foreach (var it in Enum.GetValues(typeof(Unit)))
            {
                UnitTB.Items.Add(it);
            }
        }
        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            if (arg.Index == 3)
            {
                ScalerTB.Text = ((GXDLMSRegister)Target).Scaler.ToString();
                UnitTB.SelectedItem = ((GXDLMSRegister)Target).Unit;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            bool enabled = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
            if (arg.Index == 3)
            {
                UnitTB.Enabled = enabled;
                ScalerTB.ReadOnly = !enabled;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
        {
            throw new IndexOutOfRangeException("index");
        }

        public void PreAction(GXActionArgs arg)
        {
            arg.Value = (sbyte)0;
            DialogResult ret;
            if (arg.Index == 1)
            {
                //Reset.
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.RegisterResetWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            //Read value after reset.
            if (arg.Action == ActionType.Action)
            {
                arg.Index = 2;
                arg.Action = ActionType.Read;
                return;
            }
            if (arg.Exception == null)
            {
                GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            switch (index)
            {
                case 2:
                    errorProvider1.SetError(ValueTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 4:
                    errorProvider1.SetError(StatusTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 5:
                    errorProvider1.SetError(CaptureTimeTB, Properties.Resources.ValueChangedTxt);
                    break;
                default:
                    errorProvider1.Clear();
                    break;
            }
        }

        #endregion

        /// <summary>
        /// User has change the unit.
        /// </summary>
        private void UnitTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSExtendedRegister r = (GXDLMSExtendedRegister)Target;
                if (r.Unit != (Unit)UnitTB.SelectedItem)
                {
                    r.Unit = (Unit)UnitTB.SelectedItem;
                    errorProvider1.SetError(UnitTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(3, r.Unit);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// User has change the scaler.
        /// </summary>
        private void ScalerTB_Leave(object sender, EventArgs e)
        {
            try
            {
                double v;
                if (!double.TryParse(ScalerTB.Text, out v))
                {
                    throw new Exception("Invalid scaler value.");
                }
                GXDLMSExtendedRegister r = (GXDLMSExtendedRegister)Target;
                if (r.Scaler != v)
                {
                    r.Scaler = v;
                    errorProvider1.SetError(ScalerTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(3, r.Scaler);
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
