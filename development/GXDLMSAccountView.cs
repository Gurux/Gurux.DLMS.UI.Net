//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSAccountView.cs $
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
    [GXDLMSViewAttribute(typeof(GXDLMSAccount))]
    partial class GXDLMSAccountView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAccountView()
        {
            InitializeComponent();
            PaymentModeCb.Items.Add(PaymentMode.Credit);
            PaymentModeCb.Items.Add(PaymentMode.Prepayment);
            AccountStatusCb.Items.Add(AccountStatus.NewInactiveAccount);
            AccountStatusCb.Items.Add(AccountStatus.AccountActive);
            AccountStatusCb.Items.Add(AccountStatus.AccountClosed);
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSAccount target = Target as GXDLMSAccount;
            if (index == 2)
            {
                PaymentModeCb.SelectedItem = target.PaymentMode;
                AccountStatusCb.SelectedItem = target.AccountStatus;
            }
            else if (index == 9)
            {
                CreditReferenceView.Items.Clear();
                if (target.CreditReferences != null)
                {
                    foreach (string it in target.CreditReferences)
                    {
                        CreditReferenceView.Items.Add(it);
                    }
                }
            }
            else if (index == 10)
            {
                ChargeReferenceView.Items.Clear();
                if (target.ChargeReferences != null)
                {
                    foreach (string it in target.ChargeReferences)
                    {
                        ChargeReferenceView.Items.Add(it);
                    }
                }
            }
            else if (index == 11)
            {
                CreditChargeView.Items.Clear();
                if (target.CreditChargeConfigurations != null)
                {
                    foreach (GXCreditChargeConfiguration it in target.CreditChargeConfigurations)
                    {
                        ListViewItem li = CreditChargeView.Items.Add(it.ChargeReference);
                        li.SubItems.Add(it.ChargeReference);
                        li.SubItems.Add(it.CollectionConfiguration);
                        li.Tag = it;
                    }
                }
            }
            else if (index == 12)
            {
                TokenGatewayView.Items.Clear();
                if (target.TokenGatewayConfigurations != null)
                {
                    foreach (GXTokenGatewayConfiguration it in target.TokenGatewayConfigurations)
                    {
                        ListViewItem li = TokenGatewayView.Items.Add(it.CreditReference);
                        li.SubItems.Add(it.TokenProportion.ToString());
                        li.Tag = it;
                    }
                }
            }
            else if (index == 15)
            {
                CurrencyNameTb.Text = target.Currency.Name;
                CurrencyScaleTb.Text = target.Currency.Scale.ToString();
                CurrencyUnitTb.Text = target.Currency.Unit.ToString();
            }           
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public ActionType PreAction(GXDLMSClient client, ActionType type, ValueEventArgs arg)
        {
            return type;
        }

        public ActionType PostAction(ActionType type, ValueEventArgs arg)
        {
            return ActionType.None;
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
                errorProvider1.SetError(PaymentModeCb, Properties.Resources.ValueChangedTxt);
                errorProvider1.SetError(AccountStatusCb, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 2)
            {
                PaymentModeCb.Enabled = AccountStatusCb.Enabled = (access & AccessMode.Read) != 0;
            }
            else if (index == 9)
            {
                CreditReferenceAdd.Enabled = CreditReferenceEdit.Enabled = CreditReferenceRemove.Enabled = (access & AccessMode.Read) != 0;
            }
            else if (index == 10)
            {
                ChargeReferenceAdd.Enabled = ChargeReferenceEdit.Enabled = ChargeReferenceRemove.Enabled = (access & AccessMode.Read) != 0;
            }
            else if (index == 11)
            {
                CreditChargeAdd.Enabled = CreditChargeEdit.Enabled = CreditChargeRemove.Enabled = (access & AccessMode.Read) != 0;
            }
            else if (index == 12)
            {
                TokenGatewayAdd.Enabled = TokenGatewayEdit.Enabled = TokenGatewayRemove.Enabled = (access & AccessMode.Read) != 0;
            }
            else if (index == 15)
            {
                CurrencyNameTb.ReadOnly = CurrencyScaleTb.ReadOnly = CurrencyUnitTb.ReadOnly = (access & AccessMode.Read) == 0;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }
        #endregion

        private void SecuritySetupCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurrentCreditInUseTb_Load(object sender, EventArgs e)
        {

        }
    }
}
