//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSPrimeNbOfdmPlcMacFunctionalParametersView.cs $
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSPrimeNbOfdmPlcMacFunctionalParameters
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSPrimeNbOfdmPlcMacFunctionalParameters))]
    partial class GXDLMSPrimeNbOfdmPlcMacFunctionalParametersView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSPrimeNbOfdmPlcMacFunctionalParametersView()
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
            throw new IndexOutOfRangeException("index");
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
                    errorProvider1.SetError(LNIDTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 3)
                {
                    errorProvider1.SetError(LSIDTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 4)
                {
                    errorProvider1.SetError(SIDTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 5)
                {
                    errorProvider1.SetError(SNATb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 6)
                {
                    errorProvider1.SetError(StateTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 7)
                {
                    errorProvider1.SetError(SCPLengtTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 8)
                {
                    errorProvider1.SetError(NodeHierarchyLevelTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 9)
                {
                    errorProvider1.SetError(BeaconSlotCountTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 10)
                {
                    errorProvider1.SetError(BeaconRXSlotTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 11)
                {
                    errorProvider1.SetError(BeaconTXSlotTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 12)
                {
                    errorProvider1.SetError(BeaconRXFrequencyTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 13)
                {
                    errorProvider1.SetError(BeaconTXFrequencyTb, Properties.Resources.ValueChangedTxt);
                }
                else if (index == 14)
                {
                    errorProvider1.SetError(CapabilitiesCb, Properties.Resources.ValueChangedTxt);
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            throw new IndexOutOfRangeException("index");
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
