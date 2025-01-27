//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSLteMonitoringView.cs $
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

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSLteMonitoring
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSLteMonitoring))]
    public partial class GXDLMSLteMonitoringView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSLteMonitoringView()
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
            GXDLMSLteMonitoring target = (GXDLMSLteMonitoring)Target;
            if (arg.Index == 2)
            {
                T3402Tb.Text = target.NetworkParameters.T3402.ToString();
                T3412Tb.Text = target.NetworkParameters.T3412.ToString();
                T3412ext2Tb.Text = target.NetworkParameters.T3412ext2.ToString();
                T3324Tb.Text = target.NetworkParameters.T3324.ToString();
                TeDRXTb.Text = target.NetworkParameters.TeDRX.ToString();
                TPTWTb.Text = target.NetworkParameters.TPTW.ToString();
                QRxlevMinTb.Text = target.NetworkParameters.QRxlevMin.ToString();
                QRxlevMinCETb.Text = target.NetworkParameters.QRxlevMinCE.ToString();
                QRxLevMinCE1Tb.Text = target.NetworkParameters.QRxLevMinCE1.ToString();
            }
            else if (arg.Index == 3)
            {
                SignalQualityTb.Text = target.QualityOfService.SignalQuality.ToString();
                SignalLevelTb.Text = target.QualityOfService.SignalLevel.ToString();
                SignalToNoiseRatioTb.Text = target.QualityOfService.SignalToNoiseRatio.ToString();
                CoverageEnhancementTb.Text = target.QualityOfService.CoverageEnhancement.ToString();
            }
            else
            {
                throw new IndexOutOfRangeException("index");

            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            if (arg.Index != 2 && arg.Index != 3)
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
