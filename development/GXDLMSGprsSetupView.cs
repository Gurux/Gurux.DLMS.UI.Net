//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSGprsSetupView.cs $
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSGprsSetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSGprsSetup))]
    partial class GXDLMSGprsSetupView : Form, IGXDLMSView
    {


        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSGprsSetupView()
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
            GXDLMSGprsSetup target = Target as GXDLMSGprsSetup;
            if (arg.Index == 4)
            {
                CPrecedenceTB.Text = target.DefaultQualityOfService.Precedence.ToString();
                CDelayTB.Text = target.DefaultQualityOfService.Delay.ToString();
                CReliabilityTB.Text = target.DefaultQualityOfService.Reliability.ToString();
                CPeakThroughputTB.Text = target.DefaultQualityOfService.PeakThroughput.ToString();
                CMeanThroughputTB.Text = target.DefaultQualityOfService.MeanThroughput.ToString();
                MPrecedenceTB.Text = target.RequestedQualityOfService.Precedence.ToString();
                MDelayTB.Text = target.RequestedQualityOfService.Delay.ToString();
                MReliabilityTB.Text = target.RequestedQualityOfService.Reliability.ToString();
                MPeakThroughputTB.Text = target.RequestedQualityOfService.PeakThroughput.ToString();
                MMeanThroughputTB.Text = target.RequestedQualityOfService.MeanThroughput.ToString();
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            if (arg.Index == 4)
            {
                bool enabled = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
                CPrecedenceTB.ReadOnly = !enabled;
                CReliabilityTB.ReadOnly = CDelayTB.ReadOnly = CPrecedenceTB.ReadOnly;
                CPeakThroughputTB.ReadOnly = CMeanThroughputTB.ReadOnly = CPrecedenceTB.ReadOnly;
                MPrecedenceTB.ReadOnly = MDelayTB.ReadOnly = MReliabilityTB.ReadOnly = CPrecedenceTB.ReadOnly;
                MPeakThroughputTB.ReadOnly = MMeanThroughputTB.ReadOnly = CPrecedenceTB.ReadOnly;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
        {
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
                return null;
            }
            set
            {
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {

        }
        #endregion     
    }
}
