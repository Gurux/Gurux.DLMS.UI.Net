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

using Gurux.DLMS.Objects;
using Gurux.DLMS.Objects.Enums;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXAccountCreditChargeDlg : Form
    {
        GXCreditChargeConfiguration Target;

        public GXAccountCreditChargeDlg(GXCreditChargeConfiguration target, GXDLMSObjectCollection objects)
        {
            InitializeComponent();
            Target = target;
            foreach(var it in Enum.GetValues(typeof(CreditCollectionConfiguration)))
            {
                //None is not added.
                if ((int) it != 0)
                {
                    ConfigurationLb.Items.Add(it, (Target.CollectionConfiguration & (CreditCollectionConfiguration)it) != 0);
                }
            }
            foreach (GXDLMSObject it in objects.GetObjects(Enums.ObjectType.Credit))
            {
                CreditCb.Items.Add(it);
                if (target.CreditReference == it.LogicalName)
                {
                    CreditCb.SelectedItem = it;
                }
            }
            foreach (GXDLMSObject it in objects.GetObjects(Enums.ObjectType.Charge))
            {
                ChargeCb.Items.Add(it);
                if (target.ChargeReference == it.LogicalName)
                {
                    ChargeCb.SelectedItem = it;
                }
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CreditCb.SelectedItem == null)
                {
                    throw new Exception("Credit is not selected.");
                }
                if (ChargeCb.SelectedItem == null)
                {
                    throw new Exception("Charge is not selected.");
                }
                Target.ChargeReference = (ChargeCb.SelectedItem as GXDLMSObject).LogicalName;
                Target.CreditReference = (CreditCb.SelectedItem as GXDLMSObject).LogicalName;

                Target.CollectionConfiguration = CreditCollectionConfiguration.None;
                foreach (var it in ConfigurationLb.CheckedItems)
                {
                    Target.CollectionConfiguration |= (CreditCollectionConfiguration)it;
                }
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
