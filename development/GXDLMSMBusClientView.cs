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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSMBusClient
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSMBusClient))]
    class GXDLMSMBusClientView : Form, IGXDLMSView
    {
        private GroupBox groupBox1;
        private Label MBusPortReferenceLbl;
        private GXValueField LogicalNameTB;
        private GXValueField MBusPortReferenceTB;
        private ErrorProvider errorProvider1;
        private System.ComponentModel.IContainer components;
        private Label PrimaryAddressLbl;
        private Label CapturePeriodLbl;
        private GXValueField PrimaryAddressTB;
        private GXValueField CapturePeriodTB;
        private GXValueField AccessNumberTB;
        private Label AccessNumberLbl;
        private GXValueField DeviceTypeTB;
        private Label DeviceTypeLbl;
        private GXValueField VersionTB;
        private Label VersionLbl;
        private GXValueField ManufacturerIDTB;
        private Label ManufacturerIDLbl;
        private GXValueField IdentificationNumberTB;
        private Label IdentificationNumberLbl;
        private GXValueField EncryptionKeyStatusTB;
        private Label EncryptionKeyStatusLbl;
        private GXValueField ConfigurationTB;
        private Label ConfigurationLbl;
        private GXValueField AlarmTB;
        private Label AlarmLbl;
        private GXValueField StatusTB;
        private Label StatusLbl;
        private GroupBox groupBox2;
        private ListView CaptureDefinitionView;
        private ColumnHeader DataInformationBlockCh;
        private ColumnHeader ValueInformationBlockCh;
        private Label LogicalNameLbl;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSMBusClientView()
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
            if (index == 3)
            {
                GXDLMSMBusClient target = Target as GXDLMSMBusClient;
                CaptureDefinitionView.Items.Clear();
                if (target.CaptureDefinition != null)
                {
                    foreach (KeyValuePair<string, string> it in target.CaptureDefinition)
                    {
                        ListViewItem li = CaptureDefinitionView.Items.Add(it.Key);
                        li.SubItems.Add(it.Value);
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException("attributeID");
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSMBusClientView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CaptureDefinitionView = new System.Windows.Forms.ListView();
            this.DataInformationBlockCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueInformationBlockCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EncryptionKeyStatusTB = new Gurux.DLMS.UI.GXValueField();
            this.EncryptionKeyStatusLbl = new System.Windows.Forms.Label();
            this.ConfigurationTB = new Gurux.DLMS.UI.GXValueField();
            this.ConfigurationLbl = new System.Windows.Forms.Label();
            this.AlarmTB = new Gurux.DLMS.UI.GXValueField();
            this.AlarmLbl = new System.Windows.Forms.Label();
            this.StatusTB = new Gurux.DLMS.UI.GXValueField();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.AccessNumberTB = new Gurux.DLMS.UI.GXValueField();
            this.AccessNumberLbl = new System.Windows.Forms.Label();
            this.DeviceTypeTB = new Gurux.DLMS.UI.GXValueField();
            this.DeviceTypeLbl = new System.Windows.Forms.Label();
            this.VersionTB = new Gurux.DLMS.UI.GXValueField();
            this.VersionLbl = new System.Windows.Forms.Label();
            this.ManufacturerIDTB = new Gurux.DLMS.UI.GXValueField();
            this.ManufacturerIDLbl = new System.Windows.Forms.Label();
            this.IdentificationNumberTB = new Gurux.DLMS.UI.GXValueField();
            this.IdentificationNumberLbl = new System.Windows.Forms.Label();
            this.PrimaryAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.PrimaryAddressLbl = new System.Windows.Forms.Label();
            this.CapturePeriodTB = new Gurux.DLMS.UI.GXValueField();
            this.CapturePeriodLbl = new System.Windows.Forms.Label();
            this.MBusPortReferenceTB = new Gurux.DLMS.UI.GXValueField();
            this.MBusPortReferenceLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.EncryptionKeyStatusTB);
            this.groupBox1.Controls.Add(this.EncryptionKeyStatusLbl);
            this.groupBox1.Controls.Add(this.ConfigurationTB);
            this.groupBox1.Controls.Add(this.ConfigurationLbl);
            this.groupBox1.Controls.Add(this.AlarmTB);
            this.groupBox1.Controls.Add(this.AlarmLbl);
            this.groupBox1.Controls.Add(this.StatusTB);
            this.groupBox1.Controls.Add(this.StatusLbl);
            this.groupBox1.Controls.Add(this.AccessNumberTB);
            this.groupBox1.Controls.Add(this.AccessNumberLbl);
            this.groupBox1.Controls.Add(this.DeviceTypeTB);
            this.groupBox1.Controls.Add(this.DeviceTypeLbl);
            this.groupBox1.Controls.Add(this.VersionTB);
            this.groupBox1.Controls.Add(this.VersionLbl);
            this.groupBox1.Controls.Add(this.ManufacturerIDTB);
            this.groupBox1.Controls.Add(this.ManufacturerIDLbl);
            this.groupBox1.Controls.Add(this.IdentificationNumberTB);
            this.groupBox1.Controls.Add(this.IdentificationNumberLbl);
            this.groupBox1.Controls.Add(this.PrimaryAddressTB);
            this.groupBox1.Controls.Add(this.PrimaryAddressLbl);
            this.groupBox1.Controls.Add(this.CapturePeriodTB);
            this.groupBox1.Controls.Add(this.CapturePeriodLbl);
            this.groupBox1.Controls.Add(this.MBusPortReferenceTB);
            this.groupBox1.Controls.Add(this.MBusPortReferenceLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MBus Client Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CaptureDefinitionView);
            this.groupBox2.Location = new System.Drawing.Point(9, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 125);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capture Definition:";
            // 
            // CaptureDefinitionView
            // 
            this.CaptureDefinitionView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureDefinitionView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DataInformationBlockCh,
            this.ValueInformationBlockCh});
            this.CaptureDefinitionView.FullRowSelect = true;
            this.CaptureDefinitionView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CaptureDefinitionView.HideSelection = false;
            this.CaptureDefinitionView.Location = new System.Drawing.Point(0, 19);
            this.CaptureDefinitionView.Name = "CaptureDefinitionView";
            this.CaptureDefinitionView.Size = new System.Drawing.Size(275, 72);
            this.CaptureDefinitionView.TabIndex = 41;
            this.CaptureDefinitionView.UseCompatibleStateImageBehavior = false;
            this.CaptureDefinitionView.View = System.Windows.Forms.View.Details;
            // 
            // DataInformationBlockCh
            // 
            this.DataInformationBlockCh.Text = "Data Information";
            this.DataInformationBlockCh.Width = 114;
            // 
            // ValueInformationBlockCh
            // 
            this.ValueInformationBlockCh.Text = "Value Information";
            this.ValueInformationBlockCh.Width = 147;
            // 
            // EncryptionKeyStatusTB
            // 
            this.EncryptionKeyStatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptionKeyStatusTB.Index = 14;
            this.EncryptionKeyStatusTB.Location = new System.Drawing.Point(122, 466);
            this.EncryptionKeyStatusTB.Name = "EncryptionKeyStatusTB";
            this.EncryptionKeyStatusTB.NotifyChanges = false;
            this.EncryptionKeyStatusTB.ReadOnly = true;
            this.EncryptionKeyStatusTB.Size = new System.Drawing.Size(168, 20);
            this.EncryptionKeyStatusTB.TabIndex = 38;
            this.EncryptionKeyStatusTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // EncryptionKeyStatusLbl
            // 
            this.EncryptionKeyStatusLbl.AutoSize = true;
            this.EncryptionKeyStatusLbl.Location = new System.Drawing.Point(3, 469);
            this.EncryptionKeyStatusLbl.Name = "EncryptionKeyStatusLbl";
            this.EncryptionKeyStatusLbl.Size = new System.Drawing.Size(114, 13);
            this.EncryptionKeyStatusLbl.TabIndex = 37;
            this.EncryptionKeyStatusLbl.Text = "Encryption Key Status:";
            // 
            // ConfigurationTB
            // 
            this.ConfigurationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigurationTB.Index = 13;
            this.ConfigurationTB.Location = new System.Drawing.Point(122, 440);
            this.ConfigurationTB.Name = "ConfigurationTB";
            this.ConfigurationTB.NotifyChanges = false;
            this.ConfigurationTB.Size = new System.Drawing.Size(168, 20);
            this.ConfigurationTB.TabIndex = 35;
            this.ConfigurationTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ConfigurationLbl
            // 
            this.ConfigurationLbl.AutoSize = true;
            this.ConfigurationLbl.Location = new System.Drawing.Point(6, 443);
            this.ConfigurationLbl.Name = "ConfigurationLbl";
            this.ConfigurationLbl.Size = new System.Drawing.Size(72, 13);
            this.ConfigurationLbl.TabIndex = 36;
            this.ConfigurationLbl.Text = "Configuration:";
            // 
            // AlarmTB
            // 
            this.AlarmTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlarmTB.Index = 12;
            this.AlarmTB.Location = new System.Drawing.Point(122, 414);
            this.AlarmTB.Name = "AlarmTB";
            this.AlarmTB.NotifyChanges = false;
            this.AlarmTB.Size = new System.Drawing.Size(168, 20);
            this.AlarmTB.TabIndex = 33;
            this.AlarmTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // AlarmLbl
            // 
            this.AlarmLbl.AutoSize = true;
            this.AlarmLbl.Location = new System.Drawing.Point(6, 417);
            this.AlarmLbl.Name = "AlarmLbl";
            this.AlarmLbl.Size = new System.Drawing.Size(36, 13);
            this.AlarmLbl.TabIndex = 34;
            this.AlarmLbl.Text = "Alarm:";
            // 
            // StatusTB
            // 
            this.StatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTB.Index = 11;
            this.StatusTB.Location = new System.Drawing.Point(122, 388);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.NotifyChanges = false;
            this.StatusTB.Size = new System.Drawing.Size(168, 20);
            this.StatusTB.TabIndex = 32;
            this.StatusTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(6, 391);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(40, 13);
            this.StatusLbl.TabIndex = 31;
            this.StatusLbl.Text = "Status:";
            // 
            // AccessNumberTB
            // 
            this.AccessNumberTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccessNumberTB.Index = 10;
            this.AccessNumberTB.Location = new System.Drawing.Point(122, 361);
            this.AccessNumberTB.Name = "AccessNumberTB";
            this.AccessNumberTB.NotifyChanges = false;
            this.AccessNumberTB.Size = new System.Drawing.Size(168, 20);
            this.AccessNumberTB.TabIndex = 30;
            this.AccessNumberTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // AccessNumberLbl
            // 
            this.AccessNumberLbl.AutoSize = true;
            this.AccessNumberLbl.Location = new System.Drawing.Point(3, 364);
            this.AccessNumberLbl.Name = "AccessNumberLbl";
            this.AccessNumberLbl.Size = new System.Drawing.Size(85, 13);
            this.AccessNumberLbl.TabIndex = 29;
            this.AccessNumberLbl.Text = "Access Number:";
            // 
            // DeviceTypeTB
            // 
            this.DeviceTypeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceTypeTB.Index = 9;
            this.DeviceTypeTB.Location = new System.Drawing.Point(122, 335);
            this.DeviceTypeTB.Name = "DeviceTypeTB";
            this.DeviceTypeTB.NotifyChanges = false;
            this.DeviceTypeTB.Size = new System.Drawing.Size(168, 20);
            this.DeviceTypeTB.TabIndex = 28;
            this.DeviceTypeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // DeviceTypeLbl
            // 
            this.DeviceTypeLbl.AutoSize = true;
            this.DeviceTypeLbl.Location = new System.Drawing.Point(3, 338);
            this.DeviceTypeLbl.Name = "DeviceTypeLbl";
            this.DeviceTypeLbl.Size = new System.Drawing.Size(71, 13);
            this.DeviceTypeLbl.TabIndex = 27;
            this.DeviceTypeLbl.Text = "Device Type:";
            // 
            // VersionTB
            // 
            this.VersionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionTB.Index = 8;
            this.VersionTB.Location = new System.Drawing.Point(122, 309);
            this.VersionTB.Name = "VersionTB";
            this.VersionTB.NotifyChanges = false;
            this.VersionTB.Size = new System.Drawing.Size(168, 20);
            this.VersionTB.TabIndex = 25;
            this.VersionTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Location = new System.Drawing.Point(6, 312);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(45, 13);
            this.VersionLbl.TabIndex = 26;
            this.VersionLbl.Text = "Version:";
            // 
            // ManufacturerIDTB
            // 
            this.ManufacturerIDTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerIDTB.Index = 7;
            this.ManufacturerIDTB.Location = new System.Drawing.Point(122, 283);
            this.ManufacturerIDTB.Name = "ManufacturerIDTB";
            this.ManufacturerIDTB.NotifyChanges = false;
            this.ManufacturerIDTB.Size = new System.Drawing.Size(168, 20);
            this.ManufacturerIDTB.TabIndex = 23;
            this.ManufacturerIDTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ManufacturerIDLbl
            // 
            this.ManufacturerIDLbl.AutoSize = true;
            this.ManufacturerIDLbl.Location = new System.Drawing.Point(6, 286);
            this.ManufacturerIDLbl.Name = "ManufacturerIDLbl";
            this.ManufacturerIDLbl.Size = new System.Drawing.Size(87, 13);
            this.ManufacturerIDLbl.TabIndex = 24;
            this.ManufacturerIDLbl.Text = "Manufacturer ID:";
            // 
            // IdentificationNumberTB
            // 
            this.IdentificationNumberTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentificationNumberTB.Index = 6;
            this.IdentificationNumberTB.Location = new System.Drawing.Point(122, 257);
            this.IdentificationNumberTB.Name = "IdentificationNumberTB";
            this.IdentificationNumberTB.NotifyChanges = false;
            this.IdentificationNumberTB.Size = new System.Drawing.Size(168, 20);
            this.IdentificationNumberTB.TabIndex = 22;
            this.IdentificationNumberTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // IdentificationNumberLbl
            // 
            this.IdentificationNumberLbl.AutoSize = true;
            this.IdentificationNumberLbl.Location = new System.Drawing.Point(6, 260);
            this.IdentificationNumberLbl.Name = "IdentificationNumberLbl";
            this.IdentificationNumberLbl.Size = new System.Drawing.Size(110, 13);
            this.IdentificationNumberLbl.TabIndex = 21;
            this.IdentificationNumberLbl.Text = "Identification Number:";
            // 
            // PrimaryAddressTB
            // 
            this.PrimaryAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryAddressTB.Index = 5;
            this.PrimaryAddressTB.Location = new System.Drawing.Point(122, 230);
            this.PrimaryAddressTB.Name = "PrimaryAddressTB";
            this.PrimaryAddressTB.NotifyChanges = false;
            this.PrimaryAddressTB.Size = new System.Drawing.Size(168, 20);
            this.PrimaryAddressTB.TabIndex = 20;
            this.PrimaryAddressTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PrimaryAddressLbl
            // 
            this.PrimaryAddressLbl.AutoSize = true;
            this.PrimaryAddressLbl.Location = new System.Drawing.Point(3, 233);
            this.PrimaryAddressLbl.Name = "PrimaryAddressLbl";
            this.PrimaryAddressLbl.Size = new System.Drawing.Size(85, 13);
            this.PrimaryAddressLbl.TabIndex = 19;
            this.PrimaryAddressLbl.Text = "Primary Address:";
            // 
            // CapturePeriodTB
            // 
            this.CapturePeriodTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CapturePeriodTB.Index = 4;
            this.CapturePeriodTB.Location = new System.Drawing.Point(122, 204);
            this.CapturePeriodTB.Name = "CapturePeriodTB";
            this.CapturePeriodTB.NotifyChanges = false;
            this.CapturePeriodTB.Size = new System.Drawing.Size(168, 20);
            this.CapturePeriodTB.TabIndex = 18;
            this.CapturePeriodTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // CapturePeriodLbl
            // 
            this.CapturePeriodLbl.AutoSize = true;
            this.CapturePeriodLbl.Location = new System.Drawing.Point(3, 207);
            this.CapturePeriodLbl.Name = "CapturePeriodLbl";
            this.CapturePeriodLbl.Size = new System.Drawing.Size(80, 13);
            this.CapturePeriodLbl.TabIndex = 17;
            this.CapturePeriodLbl.Text = "Capture Period:";
            // 
            // MBusPortReferenceTB
            // 
            this.MBusPortReferenceTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MBusPortReferenceTB.Index = 2;
            this.MBusPortReferenceTB.Location = new System.Drawing.Point(122, 47);
            this.MBusPortReferenceTB.Name = "MBusPortReferenceTB";
            this.MBusPortReferenceTB.NotifyChanges = false;
            this.MBusPortReferenceTB.Size = new System.Drawing.Size(168, 20);
            this.MBusPortReferenceTB.TabIndex = 2;
            this.MBusPortReferenceTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // MBusPortReferenceLbl
            // 
            this.MBusPortReferenceLbl.AutoSize = true;
            this.MBusPortReferenceLbl.Location = new System.Drawing.Point(6, 50);
            this.MBusPortReferenceLbl.Name = "MBusPortReferenceLbl";
            this.MBusPortReferenceLbl.Size = new System.Drawing.Size(112, 13);
            this.MBusPortReferenceLbl.TabIndex = 2;
            this.MBusPortReferenceLbl.Text = "MBus Port Reference:";
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
            // GXDLMSMBusClientView
            // 
            this.ClientSize = new System.Drawing.Size(324, 517);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSMBusClientView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

    }
}
