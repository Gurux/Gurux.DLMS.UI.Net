//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSMBusSlavePortSetup.cs $
//
// Version:         $Revision: 6510 $,
//                  $Date: 2013-08-08 16:24:58 +0300 (to, 08 elo 2013) $
//                  $Author: kurumi $
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
using Gurux.DLMS;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
[GXDLMSViewAttribute(typeof(GXDLMSMBusMasterPortSetup))]
class GXDLMSMBusMasterPortSetupView : Form, IGXDLMSView
{
    private GroupBox groupBox1;
    private Label CommSpeedLbl;
    private GXValueField LogicalNameTB;
    private GXValueField CommSpeedTB;
    private ErrorProvider errorProvider1;
    private System.ComponentModel.IContainer components;
    private Label LogicalNameLbl;
    /// <summary>
    /// Constructor.
    /// </summary>
    public GXDLMSMBusMasterPortSetupView()
    {
        InitializeComponent();
    }
    #region IGXDLMSView Members

    public GXDLMSObject Target
    {
        get;
        set;
    }

    public void OnValueChanged(int index, object value, bool user)
    {
        GXDLMSMBusSlavePortSetup target = Target as GXDLMSMBusSlavePortSetup;
        /*
        if (attributeID == 4)
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
            throw new IndexOutOfRangeException("attributeID");
        }
         * */
    }

    public void OnAccessRightsChange(int attributeID, AccessMode access)
    {
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


    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSMBusMasterPortSetupView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.CommSpeedTB = new Gurux.DLMS.UI.GXValueField();
        this.CommSpeedLbl = new System.Windows.Forms.Label();
        this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
        this.LogicalNameLbl = new System.Windows.Forms.Label();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        //
        // groupBox1
        //
        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox1.Controls.Add(this.CommSpeedTB);
        this.groupBox1.Controls.Add(this.CommSpeedLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(300, 96);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "MBus Master Port Setup Object";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // CommSpeedTB
        //
        this.CommSpeedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
        this.CommSpeedTB.Index = 2;
        this.CommSpeedTB.Location = new System.Drawing.Point(122, 47);
        this.CommSpeedTB.Name = "CommSpeedTB";
        this.CommSpeedTB.Size = new System.Drawing.Size(168, 20);
        this.CommSpeedTB.TabIndex = 2;
        this.CommSpeedTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // CommSpeedLbl
        //
        this.CommSpeedLbl.AutoSize = true;
        this.CommSpeedLbl.Location = new System.Drawing.Point(6, 50);
        this.CommSpeedLbl.Name = "CommSpeedLbl";
        this.CommSpeedLbl.Size = new System.Drawing.Size(73, 13);
        this.CommSpeedLbl.TabIndex = 2;
        this.CommSpeedLbl.Text = "Comm Speed:";
        //
        // LogicalNameTB
        //
        this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.LogicalNameTB.Index = 1;
        this.LogicalNameTB.Location = new System.Drawing.Point(122, 21);
        this.LogicalNameTB.Name = "LogicalNameTB";
        this.LogicalNameTB.Size = new System.Drawing.Size(168, 20);
        this.LogicalNameTB.TabIndex = 1;
        this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // LogicalNameLbl
        //
        this.LogicalNameLbl.AutoSize = true;
        this.LogicalNameLbl.Location = new System.Drawing.Point(6, 24);
        this.LogicalNameLbl.Name = "LogicalNameLbl";
        this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
        this.LogicalNameLbl.TabIndex = 0;
        this.LogicalNameLbl.Text = "Logical Name:";
        //
        // errorProvider1
        //
        this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
        this.errorProvider1.ContainerControl = this;
        this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
        //
        // GXDLMSMBusMasterPortSetupView
        //
        this.ClientSize = new System.Drawing.Size(324, 126);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSMBusMasterPortSetupView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }
}
}
