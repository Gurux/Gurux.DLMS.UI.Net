//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSChargeView.cs $
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
using System.Collections.Generic;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSCharge
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSCharge))]
    partial class GXDLMSChargeView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSChargeView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSCharge target = (GXDLMSCharge)Target;
            if (index == 5)
            {
                ActiveCommodityScaleTb.Text = target.UnitChargeActive.ChargePerUnitScaling.CommodityScale.ToString();
                ActivePriceScaleTb.Text = target.UnitChargeActive.ChargePerUnitScaling.PriceScale.ToString();

                ActiveTargetCb.Items.Clear();
                int selected = -1;
                foreach (GXDLMSObject it in Target.Parent.GetObjects(ObjectType.Credit))
                {
                    int pos = ActiveTargetCb.Items.Add(it);
                    if (it == target.UnitChargeActive.Commodity.Target)
                    {
                        selected = pos;
                    }
                }
                ActiveTargetCb.SelectedIndex = selected;
                ActiveIndexTB.Text = target.UnitChargeActive.Commodity.Index.ToString();
                ActiveChargePerUnits.Items.Clear();
                if (target.UnitChargeActive.ChargeTables != null)
                {
                    foreach (GXChargeTable it in target.UnitChargeActive.ChargeTables)
                    {
                        ListViewItem li = new ListViewItem(it.Index.ToString());
                        li.SubItems.Add(it.ChargePerUnit.ToString());
                        li.Tag = it;
                        ActiveChargePerUnits.Items.Add(li);
                    }
                }
            }
            else if (index == 6)
            {
                PassiveCommodityScaleTb.Text = target.UnitChargePassive.ChargePerUnitScaling.CommodityScale.ToString();
                PassivePriceScaleTb.Text = target.UnitChargePassive.ChargePerUnitScaling.PriceScale.ToString();

                PassiveTargetCb.Items.Clear();
                int selected = -1;
                foreach (GXDLMSObject it in Target.Parent.GetObjects(ObjectType.Credit))
                {
                    int pos = PassiveTargetCb.Items.Add(it);
                    if (it == target.UnitChargePassive.Commodity.Target)
                    {
                        selected = pos;
                    }
                }
                PassiveTargetCb.SelectedIndex = selected;
                PassiveIndexTB.Text = target.UnitChargePassive.Commodity.Index.ToString();

                PassiveChargePerUnits.Items.Clear();
                if (target.UnitChargePassive.ChargeTables != null)
                {
                    foreach (GXChargeTable it in target.UnitChargePassive.ChargeTables)
                    {
                        ListViewItem li = new ListViewItem(it.Index.ToString());
                        li.SubItems.Add(it.ChargePerUnit.ToString());
                        li.Tag = it;
                        PassiveChargePerUnits.Items.Add(li);
                    }
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
                errorProvider1.SetError(TotalAmountPaidTb, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 5)
            {
                ActiveTargetCb.Enabled = enabled;
                ActiveCommodityScaleTb.ReadOnly = ActivePriceScaleTb.ReadOnly = ActiveIndexTB.ReadOnly = !enabled;
            }
            else if (index == 6)
            {
                PassiveTargetCb.Enabled = enabled;
                PassiveCommodityScaleTb.ReadOnly = PassivePriceScaleTb.ReadOnly = PassiveIndexTB.ReadOnly = !enabled;
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSCharge target = Target as GXDLMSCharge;
                GXChargeTableDlg dlg = new GXChargeTableDlg(null, 0, false);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    List<GXChargeTable> list = new List<GXChargeTable>();
                    if (target.UnitChargePassive.ChargeTables != null)
                    {
                        list.AddRange(target.UnitChargePassive.ChargeTables);
                    }
                    GXChargeTable t = new GXChargeTable();
                    t.Index = GXDLMSTranslator.ToHex(dlg.Index);
                    t.ChargePerUnit = dlg.ChargePerUnit;
                    ListViewItem li = new ListViewItem(t.Index);
                    li.Tag = t;
                    li.SubItems.Add(t.ChargePerUnit.ToString());
                    list.Add(t);
                    target.UnitChargePassive.ChargeTables = list.ToArray();
                    PassiveChargePerUnits.Items.Add(li);
                    errorProvider1.SetError(PassiveChargePerUnits, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, target.UnitChargePassive.ChargeTables);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassiveChargePerUnits.SelectedItems.Count == 1)
                {
                    ListViewItem li = PassiveChargePerUnits.SelectedItems[0];
                    byte[] index = GXDLMSTranslator.HexToBytes(li.SubItems[0].Text);
                    Int16 chargePerUnit = Int16.Parse(li.SubItems[1].Text);
                    GXDLMSCharge target = Target as GXDLMSCharge;
                    GXChargeTableDlg dlg = new GXChargeTableDlg(index, chargePerUnit, false);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        GXChargeTable t = (GXChargeTable)li.Tag;
                        t.Index = GXDLMSTranslator.ToHex(dlg.Index);
                        t.ChargePerUnit = dlg.ChargePerUnit;
                        li.SubItems[0].Text = t.Index;
                        li.SubItems[1].Text = dlg.ChargePerUnit.ToString();
                        errorProvider1.SetError(PassiveChargePerUnits, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(6, target.UnitChargePassive.ChargeTables);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PassiveChargePerUnits.SelectedItems.Count != 0)
                {
                    GXDLMSCharge target = Target as GXDLMSCharge;
                    List<GXChargeTable> list = new List<GXChargeTable>();
                    if (target.UnitChargePassive.ChargeTables != null)
                    {
                        list.AddRange(target.UnitChargePassive.ChargeTables);
                    }
                    while (PassiveChargePerUnits.SelectedItems.Count != 0)
                    {
                        ListViewItem li = PassiveChargePerUnits.SelectedItems[0];
                        GXChargeTable item = (GXChargeTable)li.Tag;
                        list.Remove(item);
                        PassiveChargePerUnits.Items.Remove(li);
                        errorProvider1.SetError(PassiveChargePerUnits, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(6, target.UnitChargePassive.ChargeTables);
                    }
                    target.UnitChargePassive.ChargeTables = list.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActiveCommodityScaleTb_Leave(object sender, EventArgs e)
        {
            try
            {
                sbyte v = sbyte.Parse(ActiveCommodityScaleTb.Text);
                (Target as GXDLMSCharge).UnitChargeActive.ChargePerUnitScaling.CommodityScale = v;
                Target.UpdateDirty(5, v);
                errorProvider1.SetError(ActiveCommodityScaleTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActivePriceScaleTb_Leave(object sender, EventArgs e)
        {
            try
            {
                sbyte v = sbyte.Parse(ActivePriceScaleTb.Text);
                (Target as GXDLMSCharge).UnitChargeActive.ChargePerUnitScaling.PriceScale = v;
                Target.UpdateDirty(5, v);
                errorProvider1.SetError(ActivePriceScaleTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActiveTargetCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSCharge).UnitChargeActive.Commodity.Target = (GXDLMSObject) ActiveTargetCb.SelectedItem;
                Target.UpdateDirty(5, ActiveTargetCb.SelectedItem);
                errorProvider1.SetError(ActiveTargetCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActiveIndexTB_Leave(object sender, EventArgs e)
        {
            try
            {
                sbyte v = sbyte.Parse(ActiveIndexTB.Text);
                (Target as GXDLMSCharge).UnitChargeActive.Commodity.Index = v;
                Target.UpdateDirty(5, v);
                errorProvider1.SetError(ActiveIndexTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PassiveCommodityScaleTb_Leave(object sender, EventArgs e)
        {
            try
            {
                sbyte v = sbyte.Parse(PassiveCommodityScaleTb.Text);
                (Target as GXDLMSCharge).UnitChargePassive.ChargePerUnitScaling.CommodityScale = v;
                Target.UpdateDirty(6, v);
                errorProvider1.SetError(PassiveCommodityScaleTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PassivePriceScaleTb_Leave(object sender, EventArgs e)
        {
            try
            {
                sbyte v = sbyte.Parse(PassivePriceScaleTb.Text);
                (Target as GXDLMSCharge).UnitChargePassive.ChargePerUnitScaling.PriceScale = v;
                Target.UpdateDirty(6, v);
                errorProvider1.SetError(PassivePriceScaleTb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PassiveTargetCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSCharge).UnitChargePassive.Commodity.Target = (GXDLMSObject)PassiveTargetCb.SelectedItem;
                Target.UpdateDirty(5, PassiveTargetCb.SelectedItem);
                errorProvider1.SetError(PassiveTargetCb, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PassiveIndexTB_Leave(object sender, EventArgs e)
        {
            try
            {
                sbyte v = sbyte.Parse(PassiveIndexTB.Text);
                (Target as GXDLMSCharge).UnitChargePassive.Commodity.Index = v;
                Target.UpdateDirty(6, v);
                errorProvider1.SetError(PassiveIndexTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
