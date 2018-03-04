//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSDemandRegisterView.cs $
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
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSDemandRegisterView
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSDemandRegister))]
    partial class GXDLMSDemandRegisterView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSDemandRegisterView()
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

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            if (index == 4)
            {
                ScalerTB.Text = ((GXDLMSDemandRegister)Target).Scaler.ToString();
                UnitTB.SelectedItem = ((GXDLMSDemandRegister)Target).Unit;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 4)
            {
                UnitTB.Enabled = enabled;
                ScalerTB.ReadOnly = !enabled;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
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
            if (arg.Index == 1)
            {
                //Read value after reset.
                if (arg.Action == ActionType.Action)
                {
                    arg.Index = 2;
                    arg.Action = ActionType.Read;
                    return;
                }
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
                    errorProvider1.SetError(CAValueTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 3:
                    errorProvider1.SetError(LAValueTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 5:
                    errorProvider1.SetError(StatusTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 6:
                    errorProvider1.SetError(CaptureTimeTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 7:
                    errorProvider1.SetError(CurrentStartTimeTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 8:
                    errorProvider1.SetError(PeriodTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 9:
                    errorProvider1.SetError(NOPeriodTB, Properties.Resources.ValueChangedTxt);
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
                GXDLMSDemandRegister r = (GXDLMSDemandRegister)Target;
                if (r.Unit != (Unit)UnitTB.SelectedItem)
                {
                    r.Unit = (Unit)UnitTB.SelectedItem;
                    errorProvider1.SetError(UnitTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, r.Unit);
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
                GXDLMSDemandRegister r = (GXDLMSDemandRegister)Target;
                if (r.Scaler != v)
                {
                    r.Scaler = v;
                    errorProvider1.SetError(ScalerTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, r.Scaler);
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
