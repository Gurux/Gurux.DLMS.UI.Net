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
        private GXButton DeInstallSlaveBtn;
        private ColumnHeader ValueInformationBlockCh;
        private GXButton InstallSlaveBtn;
        private GXButton SynchronizeClockBtn;
        private GXButton ResetAlarmBtn;
        private GXButton CaptureBtn;
        private GroupBox groupBox5;
        private GXButton TransferKeyBtn;
        private GXButton SetBtn;
        private GroupBox groupBox3;
        private GXButton SendBtn;
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

        delegate void ShowDlgEventHandler(GXActionArgs arg);

        void OnShowDlg(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDlgEventHandler(OnShowDlg), arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                if (arg.Index == 1)
                {
                    GXTextDlg dlg = new GXTextDlg(Properties.Resources.InstallMBusClient, Properties.Resources.Address, "0", typeof(sbyte));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        arg.Value = sbyte.Parse(dlg.GetValue());
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 2)
                {
                    GXTextDlg dlg = new GXTextDlg(Properties.Resources.DeInstallMBusClient, Properties.Resources.Address, "0", typeof(sbyte));
                    arg.Handled = dlg.ShowDialog(this) != DialogResult.OK;
                }
                else if (arg.Index == 6)
                {
                    GXMBusClientData data = new GXMBusClientData();
                    GXDLMSMBusClientDataDlg dlg = new GXDLMSMBusClientDataDlg(data);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        GXMBusClientData[] arr = new GXMBusClientData[] { data };
                        GXDLMSMBusClient target = Target as GXDLMSMBusClient;
                        arg.Value = target.SendData(arg.Client, arr);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 7)
                {
                    GXTextDlg dlg = new GXTextDlg("Set encryption key.", "Key:", "", typeof(byte[]));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        GXDLMSMBusClient target = Target as GXDLMSMBusClient;
                        arg.Value = target.SetEncryptionKey(arg.Client, GXDLMSTranslator.HexToBytes(dlg.GetValue()));
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 8)
                {
                    GXTextDlg dlg = new GXTextDlg("Transfer encryption key.", "Key:", "", typeof(byte[]));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        GXDLMSMBusClient target = Target as GXDLMSMBusClient;
                        arg.Value = target.TransferKey(arg.Client, GXDLMSTranslator.HexToBytes(dlg.GetValue()));
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else
                {
                    arg.Handled = true;
                }
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            arg.Value = (sbyte)0;
            DialogResult ret;
            switch (arg.Index)
            {
                case 1:
                case 2:
                    OnShowDlg(arg);
                    break;
                case 3:
                    ret = GXHelpers.ShowMessageBox(this, Properties.Resources.CaptureWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    arg.Handled = ret != DialogResult.Yes;
                    break;
                case 4:
                    ret = GXHelpers.ShowMessageBox(this, Properties.Resources.ResetAlarm, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    arg.Handled = ret != DialogResult.Yes;
                    break;
                case 5:
                    ret = GXHelpers.ShowMessageBox(this, Properties.Resources.SynchronizeClock, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    arg.Handled = ret != DialogResult.Yes;
                    break;
                case 6:
                case 7:
                    OnShowDlg(arg);
                    break;
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action && arg.Index == 7)
            {
                arg.Index = 14;
                arg.Action = ActionType.Read;
                return;
            }
            if (arg.Exception == null)
            {
                GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            this.SendBtn = new Gurux.DLMS.UI.GXButton();
            this.CaptureBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TransferKeyBtn = new Gurux.DLMS.UI.GXButton();
            this.SetBtn = new Gurux.DLMS.UI.GXButton();
            this.ResetAlarmBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeInstallSlaveBtn = new Gurux.DLMS.UI.GXButton();
            this.InstallSlaveBtn = new Gurux.DLMS.UI.GXButton();
            this.SynchronizeClockBtn = new Gurux.DLMS.UI.GXButton();
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
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SendBtn);
            this.groupBox1.Controls.Add(this.CaptureBtn);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.ResetAlarmBtn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.SynchronizeClockBtn);
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
            this.groupBox1.Size = new System.Drawing.Size(482, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MBus Client Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // SendBtn
            // 
            this.SendBtn.Index = 6;
            this.SendBtn.Location = new System.Drawing.Point(372, 442);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(94, 23);
            this.SendBtn.TabIndex = 16;
            this.SendBtn.Text = "Send...";
            this.SendBtn.UseVisualStyleBackColor = true;
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Index = 3;
            this.CaptureBtn.Location = new System.Drawing.Point(15, 442);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(112, 23);
            this.CaptureBtn.TabIndex = 13;
            this.CaptureBtn.Text = "Capture";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TransferKeyBtn);
            this.groupBox5.Controls.Add(this.SetBtn);
            this.groupBox5.Location = new System.Drawing.Point(9, 472);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(462, 52);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Encryption key";
            // 
            // TransferKeyBtn
            // 
            this.TransferKeyBtn.Index = 8;
            this.TransferKeyBtn.Location = new System.Drawing.Point(124, 19);
            this.TransferKeyBtn.Name = "TransferKeyBtn";
            this.TransferKeyBtn.Size = new System.Drawing.Size(112, 23);
            this.TransferKeyBtn.TabIndex = 1;
            this.TransferKeyBtn.Text = "Transfer...";
            this.TransferKeyBtn.UseVisualStyleBackColor = true;
            // 
            // SetBtn
            // 
            this.SetBtn.Index = 7;
            this.SetBtn.Location = new System.Drawing.Point(6, 19);
            this.SetBtn.Name = "SetBtn";
            this.SetBtn.Size = new System.Drawing.Size(112, 23);
            this.SetBtn.TabIndex = 0;
            this.SetBtn.Text = "Set...";
            this.SetBtn.UseVisualStyleBackColor = true;
            // 
            // ResetAlarmBtn
            // 
            this.ResetAlarmBtn.Index = 4;
            this.ResetAlarmBtn.Location = new System.Drawing.Point(133, 442);
            this.ResetAlarmBtn.Name = "ResetAlarmBtn";
            this.ResetAlarmBtn.Size = new System.Drawing.Size(112, 23);
            this.ResetAlarmBtn.TabIndex = 14;
            this.ResetAlarmBtn.Text = "Reset alarm";
            this.ResetAlarmBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeInstallSlaveBtn);
            this.groupBox3.Controls.Add(this.InstallSlaveBtn);
            this.groupBox3.Location = new System.Drawing.Point(9, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 50);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Slave";
            // 
            // DeInstallSlaveBtn
            // 
            this.DeInstallSlaveBtn.Index = 2;
            this.DeInstallSlaveBtn.Location = new System.Drawing.Point(124, 19);
            this.DeInstallSlaveBtn.Name = "DeInstallSlaveBtn";
            this.DeInstallSlaveBtn.Size = new System.Drawing.Size(112, 23);
            this.DeInstallSlaveBtn.TabIndex = 1;
            this.DeInstallSlaveBtn.Text = "De-install";
            this.DeInstallSlaveBtn.UseVisualStyleBackColor = true;
            // 
            // InstallSlaveBtn
            // 
            this.InstallSlaveBtn.Index = 1;
            this.InstallSlaveBtn.Location = new System.Drawing.Point(6, 19);
            this.InstallSlaveBtn.Name = "InstallSlaveBtn";
            this.InstallSlaveBtn.Size = new System.Drawing.Size(112, 23);
            this.InstallSlaveBtn.TabIndex = 0;
            this.InstallSlaveBtn.Text = "Install";
            this.InstallSlaveBtn.UseVisualStyleBackColor = true;
            // 
            // SynchronizeClockBtn
            // 
            this.SynchronizeClockBtn.Index = 5;
            this.SynchronizeClockBtn.Location = new System.Drawing.Point(254, 442);
            this.SynchronizeClockBtn.Name = "SynchronizeClockBtn";
            this.SynchronizeClockBtn.Size = new System.Drawing.Size(112, 23);
            this.SynchronizeClockBtn.TabIndex = 15;
            this.SynchronizeClockBtn.Text = "Synchronize clock";
            this.SynchronizeClockBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CaptureDefinitionView);
            this.groupBox2.Location = new System.Drawing.Point(9, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 125);
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
            this.CaptureDefinitionView.Size = new System.Drawing.Size(457, 72);
            this.CaptureDefinitionView.TabIndex = 0;
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
            this.EncryptionKeyStatusTB.Location = new System.Drawing.Point(122, 360);
            this.EncryptionKeyStatusTB.Name = "EncryptionKeyStatusTB";
            this.EncryptionKeyStatusTB.NotifyChanges = false;
            this.EncryptionKeyStatusTB.Size = new System.Drawing.Size(350, 20);
            this.EncryptionKeyStatusTB.TabIndex = 12;
            this.EncryptionKeyStatusTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // EncryptionKeyStatusLbl
            // 
            this.EncryptionKeyStatusLbl.AutoSize = true;
            this.EncryptionKeyStatusLbl.Location = new System.Drawing.Point(3, 363);
            this.EncryptionKeyStatusLbl.Name = "EncryptionKeyStatusLbl";
            this.EncryptionKeyStatusLbl.Size = new System.Drawing.Size(114, 13);
            this.EncryptionKeyStatusLbl.TabIndex = 37;
            this.EncryptionKeyStatusLbl.Text = "Encryption Key Status:";
            // 
            // ConfigurationTB
            // 
            this.ConfigurationTB.Index = 13;
            this.ConfigurationTB.Location = new System.Drawing.Point(357, 334);
            this.ConfigurationTB.Name = "ConfigurationTB";
            this.ConfigurationTB.NotifyChanges = false;
            this.ConfigurationTB.Size = new System.Drawing.Size(115, 20);
            this.ConfigurationTB.TabIndex = 11;
            this.ConfigurationTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ConfigurationLbl
            // 
            this.ConfigurationLbl.AutoSize = true;
            this.ConfigurationLbl.Location = new System.Drawing.Point(245, 337);
            this.ConfigurationLbl.Name = "ConfigurationLbl";
            this.ConfigurationLbl.Size = new System.Drawing.Size(72, 13);
            this.ConfigurationLbl.TabIndex = 36;
            this.ConfigurationLbl.Text = "Configuration:";
            // 
            // AlarmTB
            // 
            this.AlarmTB.Index = 12;
            this.AlarmTB.Location = new System.Drawing.Point(122, 334);
            this.AlarmTB.Name = "AlarmTB";
            this.AlarmTB.NotifyChanges = false;
            this.AlarmTB.Size = new System.Drawing.Size(115, 20);
            this.AlarmTB.TabIndex = 10;
            this.AlarmTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // AlarmLbl
            // 
            this.AlarmLbl.AutoSize = true;
            this.AlarmLbl.Location = new System.Drawing.Point(6, 337);
            this.AlarmLbl.Name = "AlarmLbl";
            this.AlarmLbl.Size = new System.Drawing.Size(36, 13);
            this.AlarmLbl.TabIndex = 34;
            this.AlarmLbl.Text = "Alarm:";
            // 
            // StatusTB
            // 
            this.StatusTB.Index = 11;
            this.StatusTB.Location = new System.Drawing.Point(357, 308);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.NotifyChanges = false;
            this.StatusTB.Size = new System.Drawing.Size(115, 20);
            this.StatusTB.TabIndex = 9;
            this.StatusTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(264, 311);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(40, 13);
            this.StatusLbl.TabIndex = 31;
            this.StatusLbl.Text = "Status:";
            // 
            // AccessNumberTB
            // 
            this.AccessNumberTB.Index = 10;
            this.AccessNumberTB.Location = new System.Drawing.Point(122, 308);
            this.AccessNumberTB.Name = "AccessNumberTB";
            this.AccessNumberTB.NotifyChanges = false;
            this.AccessNumberTB.Size = new System.Drawing.Size(115, 20);
            this.AccessNumberTB.TabIndex = 8;
            this.AccessNumberTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // AccessNumberLbl
            // 
            this.AccessNumberLbl.AutoSize = true;
            this.AccessNumberLbl.Location = new System.Drawing.Point(3, 311);
            this.AccessNumberLbl.Name = "AccessNumberLbl";
            this.AccessNumberLbl.Size = new System.Drawing.Size(85, 13);
            this.AccessNumberLbl.TabIndex = 29;
            this.AccessNumberLbl.Text = "Access Number:";
            // 
            // DeviceTypeTB
            // 
            this.DeviceTypeTB.Index = 9;
            this.DeviceTypeTB.Location = new System.Drawing.Point(357, 283);
            this.DeviceTypeTB.Name = "DeviceTypeTB";
            this.DeviceTypeTB.NotifyChanges = false;
            this.DeviceTypeTB.Size = new System.Drawing.Size(115, 20);
            this.DeviceTypeTB.TabIndex = 7;
            this.DeviceTypeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // DeviceTypeLbl
            // 
            this.DeviceTypeLbl.AutoSize = true;
            this.DeviceTypeLbl.Location = new System.Drawing.Point(264, 286);
            this.DeviceTypeLbl.Name = "DeviceTypeLbl";
            this.DeviceTypeLbl.Size = new System.Drawing.Size(71, 13);
            this.DeviceTypeLbl.TabIndex = 27;
            this.DeviceTypeLbl.Text = "Device Type:";
            // 
            // VersionTB
            // 
            this.VersionTB.Index = 8;
            this.VersionTB.Location = new System.Drawing.Point(122, 283);
            this.VersionTB.Name = "VersionTB";
            this.VersionTB.NotifyChanges = false;
            this.VersionTB.Size = new System.Drawing.Size(115, 20);
            this.VersionTB.TabIndex = 6;
            this.VersionTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Location = new System.Drawing.Point(3, 286);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(45, 13);
            this.VersionLbl.TabIndex = 26;
            this.VersionLbl.Text = "Version:";
            // 
            // ManufacturerIDTB
            // 
            this.ManufacturerIDTB.Index = 7;
            this.ManufacturerIDTB.Location = new System.Drawing.Point(357, 257);
            this.ManufacturerIDTB.Name = "ManufacturerIDTB";
            this.ManufacturerIDTB.NotifyChanges = false;
            this.ManufacturerIDTB.Size = new System.Drawing.Size(115, 20);
            this.ManufacturerIDTB.TabIndex = 5;
            this.ManufacturerIDTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ManufacturerIDLbl
            // 
            this.ManufacturerIDLbl.AutoSize = true;
            this.ManufacturerIDLbl.Location = new System.Drawing.Point(264, 260);
            this.ManufacturerIDLbl.Name = "ManufacturerIDLbl";
            this.ManufacturerIDLbl.Size = new System.Drawing.Size(87, 13);
            this.ManufacturerIDLbl.TabIndex = 24;
            this.ManufacturerIDLbl.Text = "Manufacturer ID:";
            // 
            // IdentificationNumberTB
            // 
            this.IdentificationNumberTB.Index = 6;
            this.IdentificationNumberTB.Location = new System.Drawing.Point(122, 257);
            this.IdentificationNumberTB.Name = "IdentificationNumberTB";
            this.IdentificationNumberTB.NotifyChanges = false;
            this.IdentificationNumberTB.Size = new System.Drawing.Size(115, 20);
            this.IdentificationNumberTB.TabIndex = 4;
            this.IdentificationNumberTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // IdentificationNumberLbl
            // 
            this.IdentificationNumberLbl.AutoSize = true;
            this.IdentificationNumberLbl.Location = new System.Drawing.Point(3, 260);
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
            this.PrimaryAddressTB.Size = new System.Drawing.Size(350, 20);
            this.PrimaryAddressTB.TabIndex = 3;
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
            this.CapturePeriodTB.Size = new System.Drawing.Size(350, 20);
            this.CapturePeriodTB.TabIndex = 2;
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
            this.MBusPortReferenceTB.Size = new System.Drawing.Size(350, 20);
            this.MBusPortReferenceTB.TabIndex = 1;
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
            this.LogicalNameTB.Size = new System.Drawing.Size(350, 20);
            this.LogicalNameTB.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(506, 556);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSMBusClientView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
