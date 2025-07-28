//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSMBusDiagnostic.cs $
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSMBusDiagnostic
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSMBusDiagnostic))]
    class GXDLMSMBusDiagnosticView : Form, IGXDLMSView
    {
        private GroupBox groupBox1;
        private Label ReceivedSignalStrengthLbl;
        private GXValueField LogicalNameTB;
        private GXValueField LinkStatusTb;
        private Label LinkStatusLbl;
        private GXValueField ReceivedSignalStrengthTb;
        private ErrorProvider errorProvider1;
        private System.ComponentModel.IContainer components;
        private Label FCSOkFramesCounterLbl;
        private Label TransmissionsCounterLbl;
        private GXValueField FCSOkFramesCounterTb;
        private GXValueField TransmissionsCounterTb;
        private GXValueField ChannelIdTb;
        private Label ChannelIdLbl;
        private Label CaptureTimeLbl;
        private GXValueField FCSNOkFramesCounterTb;
        private Label FCSNOkFramesCounterLbl;
        private GXButton ResetBtn;
        private GroupBox GXSendDestinationAndMethodGB;
        private ListView FramesCounterLv;
        private ColumnHeader ClientId;
        private ColumnHeader Counter;
        private ColumnHeader TimeStamp;
        private TextBox CaptureTimeTb;
        private TextBox IdTb;
        private Label IdLbl;
        private Label LogicalNameLbl;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSMBusDiagnosticView()
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
            GXDLMSMBusDiagnostic target = Target as GXDLMSMBusDiagnostic;
            if (arg.Index == 5)
            {
                FramesCounterLv.Items.Clear();
                foreach (var it in target.BroadcastFrames)
                {
                    var li = FramesCounterLv.Items.Add(it.ClientId.ToString());
                    li.SubItems.AddRange(new string[] { it.Counter.ToString(), it.TimeStamp.ToString() });
                }
            }
            else if (arg.Index == 9)
            {
                IdTb.Text = target.CaptureTime.AttributeId.ToString();
                CaptureTimeTb.Text = Convert.ToString(target.CaptureTime.TimeStamp);
            }
            else
            {
                throw new IndexOutOfRangeException("attributeID");
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
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


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSMBusDiagnosticView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaptureTimeTb = new System.Windows.Forms.TextBox();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.GXSendDestinationAndMethodGB = new System.Windows.Forms.GroupBox();
            this.FramesCounterLv = new System.Windows.Forms.ListView();
            this.ClientId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Counter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeStamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.FCSNOkFramesCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.FCSNOkFramesCounterLbl = new System.Windows.Forms.Label();
            this.CaptureTimeLbl = new System.Windows.Forms.Label();
            this.ChannelIdTb = new Gurux.DLMS.UI.GXValueField();
            this.ChannelIdLbl = new System.Windows.Forms.Label();
            this.FCSOkFramesCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.FCSOkFramesCounterLbl = new System.Windows.Forms.Label();
            this.TransmissionsCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.TransmissionsCounterLbl = new System.Windows.Forms.Label();
            this.LinkStatusTb = new Gurux.DLMS.UI.GXValueField();
            this.LinkStatusLbl = new System.Windows.Forms.Label();
            this.ReceivedSignalStrengthTb = new Gurux.DLMS.UI.GXValueField();
            this.ReceivedSignalStrengthLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.GXSendDestinationAndMethodGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CaptureTimeTb);
            this.groupBox1.Controls.Add(this.IdTb);
            this.groupBox1.Controls.Add(this.IdLbl);
            this.groupBox1.Controls.Add(this.GXSendDestinationAndMethodGB);
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.FCSNOkFramesCounterTb);
            this.groupBox1.Controls.Add(this.FCSNOkFramesCounterLbl);
            this.groupBox1.Controls.Add(this.CaptureTimeLbl);
            this.groupBox1.Controls.Add(this.ChannelIdTb);
            this.groupBox1.Controls.Add(this.ChannelIdLbl);
            this.groupBox1.Controls.Add(this.FCSOkFramesCounterTb);
            this.groupBox1.Controls.Add(this.FCSOkFramesCounterLbl);
            this.groupBox1.Controls.Add(this.TransmissionsCounterTb);
            this.groupBox1.Controls.Add(this.TransmissionsCounterLbl);
            this.groupBox1.Controls.Add(this.LinkStatusTb);
            this.groupBox1.Controls.Add(this.LinkStatusLbl);
            this.groupBox1.Controls.Add(this.ReceivedSignalStrengthTb);
            this.groupBox1.Controls.Add(this.ReceivedSignalStrengthLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 490);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MBus diagnostic Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // CaptureTimeTb
            // 
            this.CaptureTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureTimeTb.Location = new System.Drawing.Point(143, 456);
            this.CaptureTimeTb.Name = "CaptureTimeTb";
            this.CaptureTimeTb.Size = new System.Drawing.Size(205, 20);
            this.CaptureTimeTb.TabIndex = 32;
            // 
            // IdTb
            // 
            this.IdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTb.Location = new System.Drawing.Point(143, 430);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(205, 20);
            this.IdTb.TabIndex = 30;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(8, 433);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(61, 13);
            this.IdLbl.TabIndex = 29;
            this.IdLbl.Text = "Capture ID:";
            // 
            // GXSendDestinationAndMethodGB
            // 
            this.GXSendDestinationAndMethodGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GXSendDestinationAndMethodGB.Controls.Add(this.FramesCounterLv);
            this.GXSendDestinationAndMethodGB.Location = new System.Drawing.Point(143, 125);
            this.GXSendDestinationAndMethodGB.Name = "GXSendDestinationAndMethodGB";
            this.GXSendDestinationAndMethodGB.Size = new System.Drawing.Size(356, 221);
            this.GXSendDestinationAndMethodGB.TabIndex = 28;
            this.GXSendDestinationAndMethodGB.TabStop = false;
            this.GXSendDestinationAndMethodGB.Text = "Broadcast Frames Counter";
            // 
            // FramesCounterLv
            // 
            this.FramesCounterLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FramesCounterLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClientId,
            this.Counter,
            this.TimeStamp});
            this.FramesCounterLv.FullRowSelect = true;
            this.FramesCounterLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FramesCounterLv.HideSelection = false;
            this.FramesCounterLv.Location = new System.Drawing.Point(6, 16);
            this.FramesCounterLv.Name = "FramesCounterLv";
            this.FramesCounterLv.Size = new System.Drawing.Size(344, 199);
            this.FramesCounterLv.TabIndex = 15;
            this.FramesCounterLv.UseCompatibleStateImageBehavior = false;
            this.FramesCounterLv.View = System.Windows.Forms.View.Details;
            // 
            // ClientId
            // 
            this.ClientId.Text = "Client ID";
            this.ClientId.Width = 127;
            // 
            // Counter
            // 
            this.Counter.Text = "Counter";
            this.Counter.Width = 79;
            // 
            // TimeStamp
            // 
            this.TimeStamp.Text = "Time Stamp";
            this.TimeStamp.Width = 126;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 1;
            this.ResetBtn.Location = new System.Drawing.Point(424, 456);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 27;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // FCSNOkFramesCounterTb
            // 
            this.FCSNOkFramesCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FCSNOkFramesCounterTb.Index = 8;
            this.FCSNOkFramesCounterTb.Location = new System.Drawing.Point(143, 404);
            this.FCSNOkFramesCounterTb.Name = "FCSNOkFramesCounterTb";
            this.FCSNOkFramesCounterTb.NotifyChanges = false;
            this.FCSNOkFramesCounterTb.Size = new System.Drawing.Size(356, 20);
            this.FCSNOkFramesCounterTb.TabIndex = 26;
            this.FCSNOkFramesCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // FCSNOkFramesCounterLbl
            // 
            this.FCSNOkFramesCounterLbl.AutoSize = true;
            this.FCSNOkFramesCounterLbl.Location = new System.Drawing.Point(7, 407);
            this.FCSNOkFramesCounterLbl.Name = "FCSNOkFramesCounterLbl";
            this.FCSNOkFramesCounterLbl.Size = new System.Drawing.Size(133, 13);
            this.FCSNOkFramesCounterLbl.TabIndex = 25;
            this.FCSNOkFramesCounterLbl.Text = "FCS NOK Frames Counter:";
            // 
            // CaptureTimeLbl
            // 
            this.CaptureTimeLbl.AutoSize = true;
            this.CaptureTimeLbl.Location = new System.Drawing.Point(10, 459);
            this.CaptureTimeLbl.Name = "CaptureTimeLbl";
            this.CaptureTimeLbl.Size = new System.Drawing.Size(73, 13);
            this.CaptureTimeLbl.TabIndex = 23;
            this.CaptureTimeLbl.Text = "Capture Time:";
            // 
            // ChannelIdTb
            // 
            this.ChannelIdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChannelIdTb.Index = 3;
            this.ChannelIdTb.Location = new System.Drawing.Point(143, 73);
            this.ChannelIdTb.Name = "ChannelIdTb";
            this.ChannelIdTb.NotifyChanges = false;
            this.ChannelIdTb.Size = new System.Drawing.Size(356, 20);
            this.ChannelIdTb.TabIndex = 21;
            this.ChannelIdTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ChannelIdLbl
            // 
            this.ChannelIdLbl.AutoSize = true;
            this.ChannelIdLbl.Location = new System.Drawing.Point(6, 76);
            this.ChannelIdLbl.Name = "ChannelIdLbl";
            this.ChannelIdLbl.Size = new System.Drawing.Size(63, 13);
            this.ChannelIdLbl.TabIndex = 22;
            this.ChannelIdLbl.Text = "Channel ID:";
            // 
            // FCSOkFramesCounterTb
            // 
            this.FCSOkFramesCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FCSOkFramesCounterTb.Index = 7;
            this.FCSOkFramesCounterTb.Location = new System.Drawing.Point(143, 378);
            this.FCSOkFramesCounterTb.Name = "FCSOkFramesCounterTb";
            this.FCSOkFramesCounterTb.NotifyChanges = false;
            this.FCSOkFramesCounterTb.Size = new System.Drawing.Size(356, 20);
            this.FCSOkFramesCounterTb.TabIndex = 20;
            this.FCSOkFramesCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // FCSOkFramesCounterLbl
            // 
            this.FCSOkFramesCounterLbl.AutoSize = true;
            this.FCSOkFramesCounterLbl.Location = new System.Drawing.Point(7, 381);
            this.FCSOkFramesCounterLbl.Name = "FCSOkFramesCounterLbl";
            this.FCSOkFramesCounterLbl.Size = new System.Drawing.Size(125, 13);
            this.FCSOkFramesCounterLbl.TabIndex = 19;
            this.FCSOkFramesCounterLbl.Text = "FCS OK Frames Counter:";
            // 
            // TransmissionsCounterTb
            // 
            this.TransmissionsCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransmissionsCounterTb.Index = 6;
            this.TransmissionsCounterTb.Location = new System.Drawing.Point(143, 352);
            this.TransmissionsCounterTb.Name = "TransmissionsCounterTb";
            this.TransmissionsCounterTb.NotifyChanges = false;
            this.TransmissionsCounterTb.Size = new System.Drawing.Size(356, 20);
            this.TransmissionsCounterTb.TabIndex = 18;
            this.TransmissionsCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TransmissionsCounterLbl
            // 
            this.TransmissionsCounterLbl.AutoSize = true;
            this.TransmissionsCounterLbl.Location = new System.Drawing.Point(7, 355);
            this.TransmissionsCounterLbl.Name = "TransmissionsCounterLbl";
            this.TransmissionsCounterLbl.Size = new System.Drawing.Size(116, 13);
            this.TransmissionsCounterLbl.TabIndex = 17;
            this.TransmissionsCounterLbl.Text = "Transmissions Counter:";
            // 
            // LinkStatusTb
            // 
            this.LinkStatusTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkStatusTb.Index = 4;
            this.LinkStatusTb.Location = new System.Drawing.Point(143, 99);
            this.LinkStatusTb.Name = "LinkStatusTb";
            this.LinkStatusTb.NotifyChanges = false;
            this.LinkStatusTb.Size = new System.Drawing.Size(356, 20);
            this.LinkStatusTb.TabIndex = 3;
            this.LinkStatusTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // LinkStatusLbl
            // 
            this.LinkStatusLbl.AutoSize = true;
            this.LinkStatusLbl.Location = new System.Drawing.Point(6, 102);
            this.LinkStatusLbl.Name = "LinkStatusLbl";
            this.LinkStatusLbl.Size = new System.Drawing.Size(63, 13);
            this.LinkStatusLbl.TabIndex = 4;
            this.LinkStatusLbl.Text = "Link Status:";
            // 
            // ReceivedSignalStrengthTb
            // 
            this.ReceivedSignalStrengthTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceivedSignalStrengthTb.Index = 2;
            this.ReceivedSignalStrengthTb.Location = new System.Drawing.Point(143, 47);
            this.ReceivedSignalStrengthTb.Name = "ReceivedSignalStrengthTb";
            this.ReceivedSignalStrengthTb.NotifyChanges = false;
            this.ReceivedSignalStrengthTb.Size = new System.Drawing.Size(356, 20);
            this.ReceivedSignalStrengthTb.TabIndex = 2;
            this.ReceivedSignalStrengthTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ReceivedSignalStrengthLbl
            // 
            this.ReceivedSignalStrengthLbl.AutoSize = true;
            this.ReceivedSignalStrengthLbl.Location = new System.Drawing.Point(6, 50);
            this.ReceivedSignalStrengthLbl.Name = "ReceivedSignalStrengthLbl";
            this.ReceivedSignalStrengthLbl.Size = new System.Drawing.Size(131, 13);
            this.ReceivedSignalStrengthLbl.TabIndex = 2;
            this.ReceivedSignalStrengthLbl.Text = "Received Signal Strength:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(143, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(356, 20);
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
            // GXDLMSMBusDiagnosticView
            // 
            this.ClientSize = new System.Drawing.Size(533, 510);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSMBusDiagnosticView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GXSendDestinationAndMethodGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
