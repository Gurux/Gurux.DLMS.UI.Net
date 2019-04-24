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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSMBusSlavePortSetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSMBusSlavePortSetup))]
    class GXDLMSMBusSlavePortSetupView : Form, IGXDLMSView
    {
        private GroupBox groupBox1;
        private Label DefaultBaudrateLbl;
        private GXValueField LogicalNameTB;
        private GXValueField AvailableBaudrateTB;
        private Label AvailableBaudrateLbl;
        private GXValueField DefaultBaudrateTB;
        private ErrorProvider errorProvider1;
        private System.ComponentModel.IContainer components;
        private Label BusAddressLbl;
        private Label AddressStateLbl;
        private GXValueField BusAddressTB;
        private GXValueField AddressStateTB;
        private Label LogicalNameLbl;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSMBusSlavePortSetupView()
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

        public void OnAccessRightsChange(int attributeID, AccessMode access, bool connected)
        {
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSMBusSlavePortSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BusAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.BusAddressLbl = new System.Windows.Forms.Label();
            this.AddressStateTB = new Gurux.DLMS.UI.GXValueField();
            this.AddressStateLbl = new System.Windows.Forms.Label();
            this.AvailableBaudrateTB = new Gurux.DLMS.UI.GXValueField();
            this.AvailableBaudrateLbl = new System.Windows.Forms.Label();
            this.DefaultBaudrateTB = new Gurux.DLMS.UI.GXValueField();
            this.DefaultBaudrateLbl = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.BusAddressTB);
            this.groupBox1.Controls.Add(this.BusAddressLbl);
            this.groupBox1.Controls.Add(this.AddressStateTB);
            this.groupBox1.Controls.Add(this.AddressStateLbl);
            this.groupBox1.Controls.Add(this.AvailableBaudrateTB);
            this.groupBox1.Controls.Add(this.AvailableBaudrateLbl);
            this.groupBox1.Controls.Add(this.DefaultBaudrateTB);
            this.groupBox1.Controls.Add(this.DefaultBaudrateLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MBus Slave Port Setup Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // BusAddressTB
            // 
            this.BusAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BusAddressTB.Index = 5;
            this.BusAddressTB.Location = new System.Drawing.Point(122, 125);
            this.BusAddressTB.Name = "BusAddressTB";
            this.BusAddressTB.NotifyChanges = false;
            this.BusAddressTB.Size = new System.Drawing.Size(168, 20);
            this.BusAddressTB.TabIndex = 20;
            this.BusAddressTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // BusAddressLbl
            // 
            this.BusAddressLbl.AutoSize = true;
            this.BusAddressLbl.Location = new System.Drawing.Point(3, 128);
            this.BusAddressLbl.Name = "BusAddressLbl";
            this.BusAddressLbl.Size = new System.Drawing.Size(69, 13);
            this.BusAddressLbl.TabIndex = 19;
            this.BusAddressLbl.Text = "Bus Address:";
            // 
            // AddressStateTB
            // 
            this.AddressStateTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressStateTB.Index = 4;
            this.AddressStateTB.Location = new System.Drawing.Point(122, 99);
            this.AddressStateTB.Name = "AddressStateTB";
            this.AddressStateTB.NotifyChanges = false;
            this.AddressStateTB.Size = new System.Drawing.Size(168, 20);
            this.AddressStateTB.TabIndex = 18;
            this.AddressStateTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // AddressStateLbl
            // 
            this.AddressStateLbl.AutoSize = true;
            this.AddressStateLbl.Location = new System.Drawing.Point(3, 102);
            this.AddressStateLbl.Name = "AddressStateLbl";
            this.AddressStateLbl.Size = new System.Drawing.Size(76, 13);
            this.AddressStateLbl.TabIndex = 17;
            this.AddressStateLbl.Text = "Address State:";
            // 
            // AvailableBaudrateTB
            // 
            this.AvailableBaudrateTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableBaudrateTB.Index = 3;
            this.AvailableBaudrateTB.Location = new System.Drawing.Point(122, 73);
            this.AvailableBaudrateTB.Name = "AvailableBaudrateTB";
            this.AvailableBaudrateTB.NotifyChanges = false;
            this.AvailableBaudrateTB.ReadOnly = true;
            this.AvailableBaudrateTB.Size = new System.Drawing.Size(168, 20);
            this.AvailableBaudrateTB.TabIndex = 3;
            this.AvailableBaudrateTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // AvailableBaudrateLbl
            // 
            this.AvailableBaudrateLbl.AutoSize = true;
            this.AvailableBaudrateLbl.Location = new System.Drawing.Point(6, 76);
            this.AvailableBaudrateLbl.Name = "AvailableBaudrateLbl";
            this.AvailableBaudrateLbl.Size = new System.Drawing.Size(99, 13);
            this.AvailableBaudrateLbl.TabIndex = 4;
            this.AvailableBaudrateLbl.Text = "Available Baudrate:";
            // 
            // DefaultBaudrateTB
            // 
            this.DefaultBaudrateTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultBaudrateTB.Index = 2;
            this.DefaultBaudrateTB.Location = new System.Drawing.Point(122, 47);
            this.DefaultBaudrateTB.Name = "DefaultBaudrateTB";
            this.DefaultBaudrateTB.NotifyChanges = false;
            this.DefaultBaudrateTB.ReadOnly = true;
            this.DefaultBaudrateTB.Size = new System.Drawing.Size(168, 20);
            this.DefaultBaudrateTB.TabIndex = 2;
            this.DefaultBaudrateTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // DefaultBaudrateLbl
            // 
            this.DefaultBaudrateLbl.AutoSize = true;
            this.DefaultBaudrateLbl.Location = new System.Drawing.Point(6, 50);
            this.DefaultBaudrateLbl.Name = "DefaultBaudrateLbl";
            this.DefaultBaudrateLbl.Size = new System.Drawing.Size(90, 13);
            this.DefaultBaudrateLbl.TabIndex = 2;
            this.DefaultBaudrateLbl.Text = "Default Baudrate:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(122, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(168, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // GXDLMSMBusSlavePortSetupView
            // 
            this.ClientSize = new System.Drawing.Size(324, 179);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSMBusSlavePortSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
