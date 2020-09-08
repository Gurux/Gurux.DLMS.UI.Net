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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSAccount
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSAccount))]
    partial class GXDLMSAccountView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAccountView()
        {
            InitializeComponent();
            foreach (var it in Enum.GetValues(typeof(AccountStatus)))
            {
                AccountStatusCb.Items.Add(it);
            }
            foreach (var it in Enum.GetValues(typeof(PaymentMode)))
            {
                PaymentModeCb.Items.Add(it);
            }
            foreach (var it in Enum.GetValues(typeof(Currency)))
            {
                CurrencyUnitTb.Items.Add(it);
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
            GXDLMSAccount target = Target as GXDLMSAccount;
            if (index == 2)
            {
                try
                {
                    PaymentModeCb.SelectedIndexChanged -= new System.EventHandler(AccountStatusCb_SelectedIndexChanged);
                    AccountStatusCb.SelectedIndexChanged -= new System.EventHandler(AccountStatusCb_SelectedIndexChanged);
                    PaymentModeCb.SelectedItem = target.PaymentMode;
                    AccountStatusCb.SelectedItem = target.AccountStatus;
                }
                finally
                {
                    PaymentModeCb.SelectedIndexChanged += new System.EventHandler(AccountStatusCb_SelectedIndexChanged);
                    AccountStatusCb.SelectedIndexChanged += new System.EventHandler(AccountStatusCb_SelectedIndexChanged);
                }
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
                        ListViewItem li = CreditChargeView.Items.Add(it.CreditReference);
                        li.SubItems.Add(it.ChargeReference);
                        li.SubItems.Add(it.CollectionConfiguration.ToString());
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
                CurrencyUnitTb.SelectedItem = target.Currency.Unit;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            arg.Value = (sbyte)0;
            DialogResult ret;
            //Activate.
            if (arg.Index == 1)
            {
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.AccountActivateWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
            }
            else if (arg.Index == 2)
            {
                //Close
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.AccountCloseWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
            }
            else if (arg.Index == 3)
            {
                //Reset
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.RegisterResetWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
            }
        }

        public void PostAction(GXActionArgs arg)
        {
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
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 2)
            {
                PaymentModeCb.Enabled = AccountStatusCb.Enabled = enabled;
            }
            else if (index == 9)
            {
                CreditReferenceAdd.Enabled = CreditReferenceEdit.Enabled = CreditReferenceRemove.Enabled = enabled;
            }
            else if (index == 10)
            {
                ChargeReferenceAdd.Enabled = ChargeReferenceEdit.Enabled = ChargeReferenceRemove.Enabled = enabled;
            }
            else if (index == 11)
            {
                CreditChargeAdd.Enabled = CreditChargeEdit.Enabled = CreditChargeRemove.Enabled = enabled;
            }
            else if (index == 12)
            {
                TokenGatewayAdd.Enabled = TokenGatewayEdit.Enabled = TokenGatewayRemove.Enabled = enabled;
            }
            else if (index == 15)
            {
                CurrencyNameTb.ReadOnly = CurrencyScaleTb.ReadOnly = !enabled;
                CurrencyUnitTb.Enabled = enabled;
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

        private void CurrentCreditInUseTb_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add credit reference.
        /// </summary>
        private void CreditReferenceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                GXDLMSObjectCollection objects = target.Parent.GetObjects(ObjectType.Credit);
                if (objects.Count == 0)
                {
                    throw new Exception("There are no Credit objects.");
                }
                GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Add credit reference", null, objects);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string desc = dlg.Target.LogicalName;
                    target.CreditReferences.Add(desc);
                    ListViewItem li = CreditReferenceView.Items.Add(desc);
                    errorProvider1.SetError(CreditReferenceView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(9, target.CreditReferences);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit credit reference.
        /// </summary>
        private void CreditReferenceEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreditReferenceView.SelectedItems.Count == 1)
                {
                    GXDLMSAccount target = Target as GXDLMSAccount;
                    GXDLMSObjectCollection objects = target.Parent.GetObjects(ObjectType.Credit);
                    if (objects.Count == 0)
                    {
                        throw new Exception("There are no Credit objects.");
                    }
                    ListViewItem li = CreditReferenceView.SelectedItems[0];
                    GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Edit credit reference", target.Parent.FindByLN(ObjectType.None, li.Text), objects);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        target.CreditReferences.Remove(li.Text);
                        string desc = dlg.Target.LogicalName;
                        li.SubItems[0].Text = desc;
                        target.CreditReferences.Add(desc);
                        errorProvider1.SetError(CreditReferenceView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(9, target.CreditReferences);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove credit reference.
        /// </summary>
        private void CreditReferenceRemove_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                while (CreditReferenceView.SelectedItems.Count != 0)
                {
                    ListViewItem li = CreditReferenceView.SelectedItems[0];
                    CreditReferenceView.Items.Remove(li);
                    errorProvider1.SetError(CreditReferenceView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(9, target.CreditReferences);
                    target.CreditReferences.Remove(li.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add charge reference.
        /// </summary>
        private void ChargeReferenceAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                GXDLMSObjectCollection objects = target.Parent.GetObjects(ObjectType.Charge);
                if (objects.Count == 0)
                {
                    throw new Exception("There are no Charge objects.");
                }
                GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Add new charge reference", null, objects);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string desc = dlg.Target.LogicalName;
                    target.ChargeReferences.Add(desc);
                    ListViewItem li = ChargeReferenceView.Items.Add(desc);
                    errorProvider1.SetError(ChargeReferenceView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(10, target.ChargeReferences);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit charge reference.
        /// </summary>
        private void ChargeReferenceEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChargeReferenceView.SelectedItems.Count == 1)
                {
                    GXDLMSAccount target = Target as GXDLMSAccount;
                    GXDLMSObjectCollection objects = target.Parent.GetObjects(ObjectType.Charge);
                    if (objects.Count == 0)
                    {
                        throw new Exception("There are no Charge objects.");
                    }
                    ListViewItem li = ChargeReferenceView.SelectedItems[0];
                    GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Edit charge reference", target.Parent.FindByLN(ObjectType.None, li.Text) as GXDLMSObject, objects);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        target.ChargeReferences.Remove(li.Text);
                        string desc = dlg.Target.LogicalName;
                        li.SubItems[0].Text = desc;
                        target.ChargeReferences.Add(desc);
                        errorProvider1.SetError(ChargeReferenceView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(10, target.ChargeReferences);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove charge reference.
        /// </summary>
        private void ChargeReferenceRemove_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                while (ChargeReferenceView.SelectedItems.Count != 0)
                {
                    ListViewItem li = ChargeReferenceView.SelectedItems[0];
                    ChargeReferenceView.Items.Remove(li);
                    errorProvider1.SetError(ChargeReferenceView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(10, target.ChargeReferences);
                    target.ChargeReferences.Remove(li.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add credit charge reference.
        /// </summary>
        private void CreditChargeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                GXCreditChargeConfiguration item = new GXCreditChargeConfiguration();
                GXAccountCreditChargeDlg dlg = new GXAccountCreditChargeDlg(item, target.Parent);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    target.CreditChargeConfigurations.Add(item);
                    ListViewItem li = CreditChargeView.Items.Add(item.ChargeReference);
                    li.SubItems.Add(item.CreditReference);
                    li.SubItems.Add(item.CollectionConfiguration.ToString());
                    li.Tag = item;
                    errorProvider1.SetError(CreditChargeView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(11, target.CreditChargeConfigurations);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add credit charge reference.
        /// </summary>
        private void CreditChargeEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreditChargeView.SelectedItems.Count == 1)
                {
                    GXDLMSAccount target = Target as GXDLMSAccount;
                    ListViewItem li = CreditChargeView.SelectedItems[0];
                    GXCreditChargeConfiguration item = li.Tag as GXCreditChargeConfiguration;
                    GXAccountCreditChargeDlg dlg = new GXAccountCreditChargeDlg(item, target.Parent);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = item.ChargeReference;
                        li.SubItems[1].Text = item.CreditReference;
                        li.SubItems[2].Text = item.CollectionConfiguration.ToString();
                        errorProvider1.SetError(CreditChargeView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(11, target.CreditChargeConfigurations);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add credit charge reference.
        /// </summary>
        private void CreditChargeRemove_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                while (CreditChargeView.SelectedItems.Count != 0)
                {
                    ListViewItem li = CreditChargeView.SelectedItems[0];
                    GXCreditChargeConfiguration item = li.Tag as GXCreditChargeConfiguration;
                    CreditChargeView.Items.Remove(li);
                    errorProvider1.SetError(CreditChargeView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(11, target.CreditChargeConfigurations);
                    target.CreditChargeConfigurations.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add token gateway.
        /// </summary>
        private void TokenGatewayAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                GXTokenGatewayConfiguration item = new GXTokenGatewayConfiguration();
                GXDLMSTokenGatewayConfigurationDlg dlg = new GXDLMSTokenGatewayConfigurationDlg(item, target.Parent);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    target.TokenGatewayConfigurations.Add(item);
                    ListViewItem li = TokenGatewayView.Items.Add(item.CreditReference);
                    li.SubItems.Add(item.TokenProportion.ToString());
                    li.Tag = item;
                    errorProvider1.SetError(TokenGatewayView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(12, target.CreditChargeConfigurations);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit token gateway.
        /// </summary>
        private void TokenGatewayEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TokenGatewayView.SelectedItems.Count == 1)
                {
                    GXDLMSAccount target = Target as GXDLMSAccount;
                    ListViewItem li = TokenGatewayView.SelectedItems[0];
                    GXTokenGatewayConfiguration item = li.Tag as GXTokenGatewayConfiguration;
                    GXDLMSTokenGatewayConfigurationDlg dlg = new GXDLMSTokenGatewayConfigurationDlg(item, target.Parent);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = item.CreditReference;
                        li.SubItems[1].Text = item.TokenProportion.ToString();
                        errorProvider1.SetError(CreditChargeView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(12, target.CreditChargeConfigurations);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove token gateway.
        /// </summary>
        private void TokenGatewayRemove_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                while (TokenGatewayView.SelectedItems.Count != 0)
                {
                    ListViewItem li = TokenGatewayView.SelectedItems[0];
                    GXTokenGatewayConfiguration item = li.Tag as GXTokenGatewayConfiguration;
                    TokenGatewayView.Items.Remove(li);
                    errorProvider1.SetError(TokenGatewayView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(12, target.TokenGatewayConfigurations);
                    target.TokenGatewayConfigurations.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccountStatusCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAccount target = Target as GXDLMSAccount;
                if (sender == AccountStatusCb)
                {
                    errorProvider1.SetError(AccountStatusCb, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.AccountStatus);
                }
                else
                {
                    errorProvider1.SetError(PaymentModeCb, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.PaymentMode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
