//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationDataView.cs $
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
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationData
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationData))]
    partial class GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationDataView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationDataView()
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
            GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationData target = Target as GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationData;
            if (index == 2)
            {
                MulticastView.Items.Clear();
                if (target.MulticastEntries != null)
                {
                    foreach (GXMacMulticastEntry it in target.MulticastEntries)
                    {
                        ListViewItem li = MulticastView.Items.Add(it.Id.ToString());
                        li.SubItems.Add(it.Members.ToString());
                    }
                }
            }
            else if (index == 3)
            {
                SwitchTableView.Items.Clear();
                if (target.SwitchTable != null)
                {
                    foreach (Int16 it in target.SwitchTable)
                    {
                        SwitchTableView.Items.Add(it.ToString());
                    }
                }
            }
            else if (index == 4)
            {
                DirectTableView.Items.Clear();
                if (target.DirectTable != null)
                {
                    foreach (GXMacDirectTable it in target.DirectTable)
                    {
                        ListViewItem li = DirectTableView.Items.Add(it.SourceSId.ToString());
                        li.SubItems.Add(it.SourceLnId.ToString());
                        li.SubItems.Add(it.SourceLcId.ToString());
                        li.SubItems.Add(it.DestinationSId.ToString());
                        li.SubItems.Add(it.DestinationLnId.ToString());
                        li.SubItems.Add(it.DestinationLcId.ToString());
                        li.SubItems.Add(GXDLMSTranslator.ToHex(it.Did));
                        li.Tag = it;
                    }
                }
            }
            else if (index == 5)
            {
                AvailableSwitchesView.Items.Clear();
                if (target.AvailableSwitches != null)
                {
                    foreach (GXMacAvailableSwitch it in target.AvailableSwitches)
                    {
                        ListViewItem li = AvailableSwitchesView.Items.Add(GXDLMSTranslator.ToHex(it.Sna));
                        li.SubItems.Add(it.LsId.ToString());
                        li.SubItems.Add(it.Level.ToString());
                        li.SubItems.Add(it.RxLevel.ToString());
                        li.SubItems.Add(it.RxSnr.ToString());
                        li.Tag = it;
                    }
                }
            }
            else if (index == 6)
            {
                PhyCommmunicationView.Items.Clear();
                if (target.Communications != null)
                {
                    foreach (GXMacPhyCommunication it in target.Communications)
                    {
                        ListViewItem li = PhyCommmunicationView.Items.Add(GXDLMSTranslator.ToHex(it.Eui));
                        li.SubItems.Add(it.TxPower.ToString());
                        li.SubItems.Add(it.TxCoding.ToString());
                        li.SubItems.Add(it.RxCoding.ToString());
                        li.SubItems.Add(it.RxLvl.ToString());
                        li.SubItems.Add(it.Snr.ToString());
                        li.SubItems.Add(it.TxPowerModified.ToString());
                        li.SubItems.Add(it.TxCodingModified.ToString());
                        li.SubItems.Add(it.RxCodingModified.ToString());
                        li.Tag = it;
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
            if (Dirty)
            {
                if (index == 2)
                {
                    errorProvider1.SetError(MulticastView, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 3)
                {
                    errorProvider1.SetError(SwitchTableView, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 4)
                {
                    errorProvider1.SetError(DirectTableView, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 5)
                {
                    errorProvider1.SetError(AvailableSwitchesView, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 6)
                {
                    errorProvider1.SetError(PhyCommmunicationView, Properties.Resources.ValueChangedTxt);
                }
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
            }
            else if (index == 3)
            {
            }
            else if (index == 4)
            {
            }
            else if (index == 5)
            {
            }
            else if (index == 6)
            {
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
