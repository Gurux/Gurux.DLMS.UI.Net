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
using System.Windows.Forms;
using Gurux.DLMS.Objects;

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

        public ErrorProvider ErrorProvider
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

        private void CPrecedenceTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(CPrecedenceTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.DefaultQualityOfService.Precedence != v)
                {
                    target.DefaultQualityOfService.Precedence = v;
                    errorProvider1.SetError(CPrecedenceTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.DefaultQualityOfService.Precedence);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CDelayTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(CDelayTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.DefaultQualityOfService.Delay != v)
                {
                    target.DefaultQualityOfService.Delay = v;
                    errorProvider1.SetError(CDelayTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.DefaultQualityOfService.Delay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CReliabilityTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(CReliabilityTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.DefaultQualityOfService.Reliability != v)
                {
                    target.DefaultQualityOfService.Reliability = v;
                    errorProvider1.SetError(CReliabilityTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.DefaultQualityOfService.Reliability);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CPeakThroughputTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(CPeakThroughputTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.DefaultQualityOfService.PeakThroughput != v)
                {
                    target.DefaultQualityOfService.PeakThroughput = v;
                    errorProvider1.SetError(CPeakThroughputTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.DefaultQualityOfService.PeakThroughput);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CMeanThroughputTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(CMeanThroughputTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.DefaultQualityOfService.MeanThroughput != v)
                {
                    target.DefaultQualityOfService.MeanThroughput = v;
                    errorProvider1.SetError(CMeanThroughputTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.DefaultQualityOfService.MeanThroughput);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MPrecedenceTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(MPrecedenceTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.RequestedQualityOfService.Precedence != v)
                {
                    target.RequestedQualityOfService.Precedence = v;
                    errorProvider1.SetError(MPrecedenceTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.RequestedQualityOfService.Precedence);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MDelayTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(MDelayTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.RequestedQualityOfService.Delay != v)
                {
                    target.RequestedQualityOfService.Delay = v;
                    errorProvider1.SetError(MDelayTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.RequestedQualityOfService.Delay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MReliabilityTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(MReliabilityTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.RequestedQualityOfService.Reliability != v)
                {
                    target.RequestedQualityOfService.Reliability = v;
                    errorProvider1.SetError(MReliabilityTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.RequestedQualityOfService.Reliability);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MPeakThroughputTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(MPeakThroughputTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.RequestedQualityOfService.PeakThroughput != v)
                {
                    target.RequestedQualityOfService.PeakThroughput = v;
                    errorProvider1.SetError(MPeakThroughputTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.RequestedQualityOfService.PeakThroughput);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MMeanThroughputTB_Leave(object sender, EventArgs e)
        {
            try
            {
                byte v;
                if (!byte.TryParse(MMeanThroughputTB.Text, out v))
                {
                    throw new Exception("Invalid value.");
                }
                GXDLMSGprsSetup target = (GXDLMSGprsSetup)Target;
                if (target.RequestedQualityOfService.MeanThroughput != v)
                {
                    target.RequestedQualityOfService.MeanThroughput = v;
                    errorProvider1.SetError(MMeanThroughputTB, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.RequestedQualityOfService.MeanThroughput);
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
