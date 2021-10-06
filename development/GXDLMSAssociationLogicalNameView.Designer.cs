using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSAssociationLogicalNameView
    {
        private System.ComponentModel.IContainer components;

        #region Windows Form Designer generated code
        private GroupBox groupBox1;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSAssociationLogicalNameView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VersionLbl = new System.Windows.Forms.Label();
            this.VersionTb = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddObjectBtn = new Gurux.DLMS.UI.GXButton();
            this.RemoveObjectBtn = new Gurux.DLMS.UI.GXButton();
            this.ObjectsView = new System.Windows.Forms.ListView();
            this.ClassIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeAccesssHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MethodAccessHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UpdateHighPwBtn = new Gurux.DLMS.UI.GXButton();
            this.SecuritySetupCb = new System.Windows.Forms.ComboBox();
            this.SecretTB = new System.Windows.Forms.TextBox();
            this.SecretAsciiCb = new System.Windows.Forms.CheckBox();
            this.SecuritySetupReferenceLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServerSAPTb = new System.Windows.Forms.TextBox();
            this.ClientSAPTb = new System.Windows.Forms.TextBox();
            this.ServerSAPLbl = new System.Windows.Forms.Label();
            this.ClientSAPLbl = new System.Windows.Forms.Label();
            this.SecretLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdatePwBtn = new Gurux.DLMS.UI.GXButton();
            this.gxValueField1 = new Gurux.DLMS.UI.GXValueField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LNSettings = new System.Windows.Forms.GroupBox();
            this.DeltaValueEncodingCb = new System.Windows.Forms.CheckBox();
            this.GeneralProtectionCB = new System.Windows.Forms.CheckBox();
            this.GeneralBlockTransferCB = new System.Windows.Forms.CheckBox();
            this.Attribute0SetReferencingCB = new System.Windows.Forms.CheckBox();
            this.PriorityManagementCB = new System.Windows.Forms.CheckBox();
            this.Attribute0GetReferencingCB = new System.Windows.Forms.CheckBox();
            this.GetBlockTransferCB = new System.Windows.Forms.CheckBox();
            this.SetBlockTransferCB = new System.Windows.Forms.CheckBox();
            this.ActionBlockTransferCB = new System.Windows.Forms.CheckBox();
            this.MultipleReferencesCB = new System.Windows.Forms.CheckBox();
            this.DataNotificationCB = new System.Windows.Forms.CheckBox();
            this.AccessCB = new System.Windows.Forms.CheckBox();
            this.GetCB = new System.Windows.Forms.CheckBox();
            this.SetCB = new System.Windows.Forms.CheckBox();
            this.SelectiveAccessCB = new System.Windows.Forms.CheckBox();
            this.EventNotificationCB = new System.Windows.Forms.CheckBox();
            this.ActionCB = new System.Windows.Forms.CheckBox();
            this.CypheringInfoTb = new System.Windows.Forms.TextBox();
            this.CypheringInfoLbl = new System.Windows.Forms.Label();
            this.DLMSVersionNumberTB = new System.Windows.Forms.TextBox();
            this.DLMSVersionNumberLbl = new System.Windows.Forms.Label();
            this.MaxSendPDUSizeTb = new System.Windows.Forms.TextBox();
            this.MaxSendPDUSizeLbl = new System.Windows.Forms.Label();
            this.MaxReceivePDUSizeTb = new System.Windows.Forms.TextBox();
            this.MaxReceivePDUSizeLbl = new System.Windows.Forms.Label();
            this.ConformanceLbl = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ApplicationRegistrationAuthorityCb = new System.Windows.Forms.ComboBox();
            this.ApplicationRegistrationAuthorityLbl = new System.Windows.Forms.Label();
            this.ApplicationContextIDCb = new System.Windows.Forms.ComboBox();
            this.ApplicationContextIDLbl = new System.Windows.Forms.Label();
            this.ApplicationContextTb = new System.Windows.Forms.TextBox();
            this.ApplicationContextLbl = new System.Windows.Forms.Label();
            this.ApplicationDLMSUATb = new System.Windows.Forms.TextBox();
            this.ApplicationDLMSUALbl = new System.Windows.Forms.Label();
            this.ApplicationIdentifiedOrganizationTb = new System.Windows.Forms.TextBox();
            this.ApplicationIdentifiedOrganizationLbl = new System.Windows.Forms.Label();
            this.ApplicationCountryNameTb = new System.Windows.Forms.TextBox();
            this.ApplicationCountryNameLbl = new System.Windows.Forms.Label();
            this.ApplicationCountryTb = new System.Windows.Forms.TextBox();
            this.ApplicationCountryLbl = new System.Windows.Forms.Label();
            this.ApplicationJointISOCTTTb = new System.Windows.Forms.TextBox();
            this.ApplicationJointISOCTTLbl = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.AuthenticationMechanismIdCb = new System.Windows.Forms.ComboBox();
            this.AuthenticationRegistrationAuthorityCb = new System.Windows.Forms.ComboBox();
            this.AuthenticationRegistrationAuthorityLbl = new System.Windows.Forms.Label();
            this.AuthenticationMechanismIdLbl = new System.Windows.Forms.Label();
            this.AuthenticationMechanismNameTb = new System.Windows.Forms.TextBox();
            this.AuthenticationMechanismNameLbl = new System.Windows.Forms.Label();
            this.AuthenticationDLMSUATb = new System.Windows.Forms.TextBox();
            this.AuthenticationDLMSUALbl = new System.Windows.Forms.Label();
            this.AuthenticationIdentifiedorganizationTb = new System.Windows.Forms.TextBox();
            this.AuthenticationIdentifiedorganizationLbl = new System.Windows.Forms.Label();
            this.AuthenticationCountryNameTb = new System.Windows.Forms.TextBox();
            this.AuthenticationCountryNameLbl = new System.Windows.Forms.Label();
            this.AuthenticationCountryTb = new System.Windows.Forms.TextBox();
            this.AuthenticationCountryLbl = new System.Windows.Forms.Label();
            this.AuthenticationJointISOCTTTb = new System.Windows.Forms.TextBox();
            this.AuthenticationJointISOCTTLbl = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.AddUserBtn = new Gurux.DLMS.UI.GXButton();
            this.RemoveUserBtn = new Gurux.DLMS.UI.GXButton();
            this.UsersList = new System.Windows.Forms.ListView();
            this.UserIdCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.LNSettings.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.VersionLbl);
            this.groupBox1.Controls.Add(this.VersionTb);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Association Logical  Name Object";
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Location = new System.Drawing.Point(335, 24);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(45, 13);
            this.VersionLbl.TabIndex = 16;
            this.VersionLbl.Text = "Version:";
            // 
            // VersionTb
            // 
            this.VersionTb.Location = new System.Drawing.Point(428, 21);
            this.VersionTb.Name = "VersionTb";
            this.VersionTb.ReadOnly = true;
            this.VersionTb.Size = new System.Drawing.Size(100, 20);
            this.VersionTb.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(9, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 335);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddObjectBtn);
            this.tabPage1.Controls.Add(this.RemoveObjectBtn);
            this.tabPage1.Controls.Add(this.ObjectsView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Objects";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddObjectBtn
            // 
            this.AddObjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddObjectBtn.Index = 3;
            this.AddObjectBtn.Location = new System.Drawing.Point(421, 283);
            this.AddObjectBtn.Name = "AddObjectBtn";
            this.AddObjectBtn.Size = new System.Drawing.Size(75, 23);
            this.AddObjectBtn.TabIndex = 22;
            this.AddObjectBtn.Text = "Add";
            this.AddObjectBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveObjectBtn
            // 
            this.RemoveObjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveObjectBtn.Index = 4;
            this.RemoveObjectBtn.Location = new System.Drawing.Point(502, 283);
            this.RemoveObjectBtn.Name = "RemoveObjectBtn";
            this.RemoveObjectBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveObjectBtn.TabIndex = 21;
            this.RemoveObjectBtn.Text = "Remove";
            this.RemoveObjectBtn.UseVisualStyleBackColor = true;
            // 
            // ObjectsView
            // 
            this.ObjectsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassIdHeader,
            this.VersionHeader,
            this.LogicalNameHeader,
            this.AttributeAccesssHeader,
            this.MethodAccessHeader});
            this.ObjectsView.FullRowSelect = true;
            this.ObjectsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ObjectsView.HideSelection = false;
            this.ObjectsView.Location = new System.Drawing.Point(3, 3);
            this.ObjectsView.Name = "ObjectsView";
            this.ObjectsView.Size = new System.Drawing.Size(574, 274);
            this.ObjectsView.TabIndex = 14;
            this.ObjectsView.UseCompatibleStateImageBehavior = false;
            this.ObjectsView.View = System.Windows.Forms.View.Details;
            // 
            // ClassIdHeader
            // 
            this.ClassIdHeader.Text = "Class ID:";
            this.ClassIdHeader.Width = 105;
            // 
            // VersionHeader
            // 
            this.VersionHeader.Text = "Version:";
            // 
            // LogicalNameHeader
            // 
            this.LogicalNameHeader.Text = "Logical Name:";
            this.LogicalNameHeader.Width = 106;
            // 
            // AttributeAccesssHeader
            // 
            this.AttributeAccesssHeader.Text = "Attribute Access:";
            this.AttributeAccesssHeader.Width = 106;
            // 
            // MethodAccessHeader
            // 
            this.MethodAccessHeader.Text = "Method Access:";
            this.MethodAccessHeader.Width = 97;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UpdateHighPwBtn);
            this.tabPage2.Controls.Add(this.SecuritySetupCb);
            this.tabPage2.Controls.Add(this.SecretTB);
            this.tabPage2.Controls.Add(this.SecretAsciiCb);
            this.tabPage2.Controls.Add(this.SecuritySetupReferenceLbl);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.SecretLbl);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.UpdatePwBtn);
            this.tabPage2.Controls.Add(this.gxValueField1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(601, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "General";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpdateHighPwBtn
            // 
            this.UpdateHighPwBtn.Index = 2;
            this.UpdateHighPwBtn.Location = new System.Drawing.Point(260, 119);
            this.UpdateHighPwBtn.Name = "UpdateHighPwBtn";
            this.UpdateHighPwBtn.Size = new System.Drawing.Size(141, 23);
            this.UpdateHighPwBtn.TabIndex = 36;
            this.UpdateHighPwBtn.Text = "Update High password";
            this.UpdateHighPwBtn.UseVisualStyleBackColor = true;
            // 
            // SecuritySetupCb
            // 
            this.SecuritySetupCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecuritySetupCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecuritySetupCb.FormattingEnabled = true;
            this.SecuritySetupCb.Location = new System.Drawing.Point(114, 148);
            this.SecuritySetupCb.Name = "SecuritySetupCb";
            this.SecuritySetupCb.Size = new System.Drawing.Size(335, 21);
            this.SecuritySetupCb.TabIndex = 35;
            this.SecuritySetupCb.SelectedIndexChanged += new System.EventHandler(this.SecuritySetupCb_SelectedIndexChanged);
            // 
            // SecretTB
            // 
            this.SecretTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretTB.Location = new System.Drawing.Point(115, 67);
            this.SecretTB.Name = "SecretTB";
            this.SecretTB.ReadOnly = true;
            this.SecretTB.Size = new System.Drawing.Size(275, 20);
            this.SecretTB.TabIndex = 26;
            // 
            // SecretAsciiCb
            // 
            this.SecretAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretAsciiCb.AutoSize = true;
            this.SecretAsciiCb.Location = new System.Drawing.Point(396, 69);
            this.SecretAsciiCb.Name = "SecretAsciiCb";
            this.SecretAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.SecretAsciiCb.TabIndex = 27;
            this.SecretAsciiCb.Text = "ASCII";
            this.SecretAsciiCb.UseVisualStyleBackColor = true;
            this.SecretAsciiCb.CheckedChanged += new System.EventHandler(this.SecretAsciiCb_CheckedChanged);
            // 
            // SecuritySetupReferenceLbl
            // 
            this.SecuritySetupReferenceLbl.AutoSize = true;
            this.SecuritySetupReferenceLbl.Location = new System.Drawing.Point(8, 151);
            this.SecuritySetupReferenceLbl.Name = "SecuritySetupReferenceLbl";
            this.SecuritySetupReferenceLbl.Size = new System.Drawing.Size(77, 13);
            this.SecuritySetupReferenceLbl.TabIndex = 24;
            this.SecuritySetupReferenceLbl.Text = "Security setup:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServerSAPTb);
            this.groupBox2.Controls.Add(this.ClientSAPTb);
            this.groupBox2.Controls.Add(this.ServerSAPLbl);
            this.groupBox2.Controls.Add(this.ClientSAPLbl);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 61);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Associated  partners ID";
            // 
            // ServerSAPTb
            // 
            this.ServerSAPTb.Location = new System.Drawing.Point(322, 25);
            this.ServerSAPTb.Name = "ServerSAPTb";
            this.ServerSAPTb.Size = new System.Drawing.Size(100, 20);
            this.ServerSAPTb.TabIndex = 25;
            this.ServerSAPTb.Leave += new System.EventHandler(this.ServerSAPTb_Leave);
            // 
            // ClientSAPTb
            // 
            this.ClientSAPTb.Location = new System.Drawing.Point(113, 25);
            this.ClientSAPTb.Name = "ClientSAPTb";
            this.ClientSAPTb.Size = new System.Drawing.Size(100, 20);
            this.ClientSAPTb.TabIndex = 24;
            this.ClientSAPTb.Leave += new System.EventHandler(this.ClientSAPTb_Leave);
            // 
            // ServerSAPLbl
            // 
            this.ServerSAPLbl.AutoSize = true;
            this.ServerSAPLbl.Location = new System.Drawing.Point(240, 28);
            this.ServerSAPLbl.Name = "ServerSAPLbl";
            this.ServerSAPLbl.Size = new System.Drawing.Size(65, 13);
            this.ServerSAPLbl.TabIndex = 23;
            this.ServerSAPLbl.Text = "Server SAP:";
            // 
            // ClientSAPLbl
            // 
            this.ClientSAPLbl.AutoSize = true;
            this.ClientSAPLbl.Location = new System.Drawing.Point(6, 28);
            this.ClientSAPLbl.Name = "ClientSAPLbl";
            this.ClientSAPLbl.Size = new System.Drawing.Size(60, 13);
            this.ClientSAPLbl.TabIndex = 22;
            this.ClientSAPLbl.Text = "Client SAP:";
            // 
            // SecretLbl
            // 
            this.SecretLbl.AutoSize = true;
            this.SecretLbl.Location = new System.Drawing.Point(8, 72);
            this.SecretLbl.Name = "SecretLbl";
            this.SecretLbl.Size = new System.Drawing.Size(41, 13);
            this.SecretLbl.TabIndex = 21;
            this.SecretLbl.Text = "Secret:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Association Status:";
            // 
            // UpdatePwBtn
            // 
            this.UpdatePwBtn.Action = Gurux.DLMS.UI.ActionType.Write;
            this.UpdatePwBtn.Index = 7;
            this.UpdatePwBtn.Location = new System.Drawing.Point(114, 119);
            this.UpdatePwBtn.Name = "UpdatePwBtn";
            this.UpdatePwBtn.Size = new System.Drawing.Size(140, 23);
            this.UpdatePwBtn.TabIndex = 28;
            this.UpdatePwBtn.Text = "Update Low password";
            this.UpdatePwBtn.UseVisualStyleBackColor = true;
            // 
            // gxValueField1
            // 
            this.gxValueField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField1.Index = 8;
            this.gxValueField1.Location = new System.Drawing.Point(114, 93);
            this.gxValueField1.Name = "gxValueField1";
            this.gxValueField1.NotifyChanges = false;
            this.gxValueField1.Size = new System.Drawing.Size(335, 20);
            this.gxValueField1.TabIndex = 29;
            this.gxValueField1.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LNSettings);
            this.tabPage3.Controls.Add(this.CypheringInfoTb);
            this.tabPage3.Controls.Add(this.CypheringInfoLbl);
            this.tabPage3.Controls.Add(this.DLMSVersionNumberTB);
            this.tabPage3.Controls.Add(this.DLMSVersionNumberLbl);
            this.tabPage3.Controls.Add(this.MaxSendPDUSizeTb);
            this.tabPage3.Controls.Add(this.MaxSendPDUSizeLbl);
            this.tabPage3.Controls.Add(this.MaxReceivePDUSizeTb);
            this.tabPage3.Controls.Add(this.MaxReceivePDUSizeLbl);
            this.tabPage3.Controls.Add(this.ConformanceLbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(601, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "xDLMS Context Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LNSettings
            // 
            this.LNSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LNSettings.Controls.Add(this.DeltaValueEncodingCb);
            this.LNSettings.Controls.Add(this.GeneralProtectionCB);
            this.LNSettings.Controls.Add(this.GeneralBlockTransferCB);
            this.LNSettings.Controls.Add(this.Attribute0SetReferencingCB);
            this.LNSettings.Controls.Add(this.PriorityManagementCB);
            this.LNSettings.Controls.Add(this.Attribute0GetReferencingCB);
            this.LNSettings.Controls.Add(this.GetBlockTransferCB);
            this.LNSettings.Controls.Add(this.SetBlockTransferCB);
            this.LNSettings.Controls.Add(this.ActionBlockTransferCB);
            this.LNSettings.Controls.Add(this.MultipleReferencesCB);
            this.LNSettings.Controls.Add(this.DataNotificationCB);
            this.LNSettings.Controls.Add(this.AccessCB);
            this.LNSettings.Controls.Add(this.GetCB);
            this.LNSettings.Controls.Add(this.SetCB);
            this.LNSettings.Controls.Add(this.SelectiveAccessCB);
            this.LNSettings.Controls.Add(this.EventNotificationCB);
            this.LNSettings.Controls.Add(this.ActionCB);
            this.LNSettings.Location = new System.Drawing.Point(87, 6);
            this.LNSettings.Name = "LNSettings";
            this.LNSettings.Size = new System.Drawing.Size(480, 140);
            this.LNSettings.TabIndex = 38;
            this.LNSettings.TabStop = false;
            this.LNSettings.Text = "LN settings";
            // 
            // DeltaValueEncodingCb
            // 
            this.DeltaValueEncodingCb.AutoSize = true;
            this.DeltaValueEncodingCb.Location = new System.Drawing.Point(389, 40);
            this.DeltaValueEncodingCb.Name = "DeltaValueEncodingCb";
            this.DeltaValueEncodingCb.Size = new System.Drawing.Size(127, 17);
            this.DeltaValueEncodingCb.TabIndex = 36;
            this.DeltaValueEncodingCb.Text = "Delta value encoding";
            this.DeltaValueEncodingCb.UseVisualStyleBackColor = true;
            this.DeltaValueEncodingCb.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // GeneralProtectionCB
            // 
            this.GeneralProtectionCB.AutoSize = true;
            this.GeneralProtectionCB.Location = new System.Drawing.Point(389, 20);
            this.GeneralProtectionCB.Name = "GeneralProtectionCB";
            this.GeneralProtectionCB.Size = new System.Drawing.Size(113, 17);
            this.GeneralProtectionCB.TabIndex = 35;
            this.GeneralProtectionCB.Text = "General protection";
            this.GeneralProtectionCB.UseVisualStyleBackColor = true;
            this.GeneralProtectionCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // GeneralBlockTransferCB
            // 
            this.GeneralBlockTransferCB.AutoSize = true;
            this.GeneralBlockTransferCB.Location = new System.Drawing.Point(240, 99);
            this.GeneralBlockTransferCB.Name = "GeneralBlockTransferCB";
            this.GeneralBlockTransferCB.Size = new System.Drawing.Size(130, 17);
            this.GeneralBlockTransferCB.TabIndex = 34;
            this.GeneralBlockTransferCB.Text = "General block transfer";
            this.GeneralBlockTransferCB.UseVisualStyleBackColor = true;
            this.GeneralBlockTransferCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // Attribute0SetReferencingCB
            // 
            this.Attribute0SetReferencingCB.AutoSize = true;
            this.Attribute0SetReferencingCB.Location = new System.Drawing.Point(240, 79);
            this.Attribute0SetReferencingCB.Name = "Attribute0SetReferencingCB";
            this.Attribute0SetReferencingCB.Size = new System.Drawing.Size(147, 17);
            this.Attribute0SetReferencingCB.TabIndex = 33;
            this.Attribute0SetReferencingCB.Text = "Attribute 0 set referencing";
            this.Attribute0SetReferencingCB.UseVisualStyleBackColor = true;
            this.Attribute0SetReferencingCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // PriorityManagementCB
            // 
            this.PriorityManagementCB.AutoSize = true;
            this.PriorityManagementCB.Location = new System.Drawing.Point(240, 59);
            this.PriorityManagementCB.Name = "PriorityManagementCB";
            this.PriorityManagementCB.Size = new System.Drawing.Size(121, 17);
            this.PriorityManagementCB.TabIndex = 32;
            this.PriorityManagementCB.Text = "Priority management";
            this.PriorityManagementCB.UseVisualStyleBackColor = true;
            this.PriorityManagementCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // Attribute0GetReferencingCB
            // 
            this.Attribute0GetReferencingCB.AutoSize = true;
            this.Attribute0GetReferencingCB.Location = new System.Drawing.Point(239, 39);
            this.Attribute0GetReferencingCB.Name = "Attribute0GetReferencingCB";
            this.Attribute0GetReferencingCB.Size = new System.Drawing.Size(148, 17);
            this.Attribute0GetReferencingCB.TabIndex = 31;
            this.Attribute0GetReferencingCB.Text = "Attribute 0 get referencing";
            this.Attribute0GetReferencingCB.UseVisualStyleBackColor = true;
            this.Attribute0GetReferencingCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // GetBlockTransferCB
            // 
            this.GetBlockTransferCB.AutoSize = true;
            this.GetBlockTransferCB.Location = new System.Drawing.Point(240, 19);
            this.GetBlockTransferCB.Name = "GetBlockTransferCB";
            this.GetBlockTransferCB.Size = new System.Drawing.Size(110, 17);
            this.GetBlockTransferCB.TabIndex = 30;
            this.GetBlockTransferCB.Text = "Get block transfer";
            this.GetBlockTransferCB.UseVisualStyleBackColor = true;
            this.GetBlockTransferCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // SetBlockTransferCB
            // 
            this.SetBlockTransferCB.AutoSize = true;
            this.SetBlockTransferCB.Location = new System.Drawing.Point(120, 99);
            this.SetBlockTransferCB.Name = "SetBlockTransferCB";
            this.SetBlockTransferCB.Size = new System.Drawing.Size(109, 17);
            this.SetBlockTransferCB.TabIndex = 22;
            this.SetBlockTransferCB.Text = "Set block transfer";
            this.SetBlockTransferCB.UseVisualStyleBackColor = true;
            this.SetBlockTransferCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // ActionBlockTransferCB
            // 
            this.ActionBlockTransferCB.AutoSize = true;
            this.ActionBlockTransferCB.Location = new System.Drawing.Point(120, 79);
            this.ActionBlockTransferCB.Name = "ActionBlockTransferCB";
            this.ActionBlockTransferCB.Size = new System.Drawing.Size(123, 17);
            this.ActionBlockTransferCB.TabIndex = 21;
            this.ActionBlockTransferCB.Text = "Action block transfer";
            this.ActionBlockTransferCB.UseVisualStyleBackColor = true;
            this.ActionBlockTransferCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // MultipleReferencesCB
            // 
            this.MultipleReferencesCB.AutoSize = true;
            this.MultipleReferencesCB.Location = new System.Drawing.Point(120, 59);
            this.MultipleReferencesCB.Name = "MultipleReferencesCB";
            this.MultipleReferencesCB.Size = new System.Drawing.Size(120, 17);
            this.MultipleReferencesCB.TabIndex = 20;
            this.MultipleReferencesCB.Text = "Multiple References";
            this.MultipleReferencesCB.UseVisualStyleBackColor = true;
            this.MultipleReferencesCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // DataNotificationCB
            // 
            this.DataNotificationCB.AutoSize = true;
            this.DataNotificationCB.Location = new System.Drawing.Point(120, 39);
            this.DataNotificationCB.Name = "DataNotificationCB";
            this.DataNotificationCB.Size = new System.Drawing.Size(105, 17);
            this.DataNotificationCB.TabIndex = 19;
            this.DataNotificationCB.Text = "Data Notification";
            this.DataNotificationCB.UseVisualStyleBackColor = true;
            this.DataNotificationCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // AccessCB
            // 
            this.AccessCB.AutoSize = true;
            this.AccessCB.Location = new System.Drawing.Point(120, 19);
            this.AccessCB.Name = "AccessCB";
            this.AccessCB.Size = new System.Drawing.Size(61, 17);
            this.AccessCB.TabIndex = 18;
            this.AccessCB.Text = "Access";
            this.AccessCB.UseVisualStyleBackColor = true;
            this.AccessCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // GetCB
            // 
            this.GetCB.AutoSize = true;
            this.GetCB.Location = new System.Drawing.Point(6, 100);
            this.GetCB.Name = "GetCB";
            this.GetCB.Size = new System.Drawing.Size(43, 17);
            this.GetCB.TabIndex = 5;
            this.GetCB.Text = "Get";
            this.GetCB.UseVisualStyleBackColor = true;
            this.GetCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // SetCB
            // 
            this.SetCB.AutoSize = true;
            this.SetCB.Location = new System.Drawing.Point(6, 80);
            this.SetCB.Name = "SetCB";
            this.SetCB.Size = new System.Drawing.Size(42, 17);
            this.SetCB.TabIndex = 4;
            this.SetCB.Text = "Set";
            this.SetCB.UseVisualStyleBackColor = true;
            this.SetCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // SelectiveAccessCB
            // 
            this.SelectiveAccessCB.AutoSize = true;
            this.SelectiveAccessCB.Location = new System.Drawing.Point(6, 60);
            this.SelectiveAccessCB.Name = "SelectiveAccessCB";
            this.SelectiveAccessCB.Size = new System.Drawing.Size(108, 17);
            this.SelectiveAccessCB.TabIndex = 3;
            this.SelectiveAccessCB.Text = "Selective Access";
            this.SelectiveAccessCB.UseVisualStyleBackColor = true;
            this.SelectiveAccessCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // EventNotificationCB
            // 
            this.EventNotificationCB.AutoSize = true;
            this.EventNotificationCB.Location = new System.Drawing.Point(6, 40);
            this.EventNotificationCB.Name = "EventNotificationCB";
            this.EventNotificationCB.Size = new System.Drawing.Size(110, 17);
            this.EventNotificationCB.TabIndex = 2;
            this.EventNotificationCB.Text = "Event Notification";
            this.EventNotificationCB.UseVisualStyleBackColor = true;
            this.EventNotificationCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // ActionCB
            // 
            this.ActionCB.AutoSize = true;
            this.ActionCB.Location = new System.Drawing.Point(6, 20);
            this.ActionCB.Name = "ActionCB";
            this.ActionCB.Size = new System.Drawing.Size(56, 17);
            this.ActionCB.TabIndex = 1;
            this.ActionCB.Text = "Action";
            this.ActionCB.UseVisualStyleBackColor = true;
            this.ActionCB.CheckedChanged += new System.EventHandler(this.OnConformanceChange);
            // 
            // CypheringInfoTb
            // 
            this.CypheringInfoTb.Location = new System.Drawing.Point(129, 204);
            this.CypheringInfoTb.Name = "CypheringInfoTb";
            this.CypheringInfoTb.ReadOnly = true;
            this.CypheringInfoTb.Size = new System.Drawing.Size(327, 20);
            this.CypheringInfoTb.TabIndex = 36;
            // 
            // CypheringInfoLbl
            // 
            this.CypheringInfoLbl.AutoSize = true;
            this.CypheringInfoLbl.Location = new System.Drawing.Point(8, 207);
            this.CypheringInfoLbl.Name = "CypheringInfoLbl";
            this.CypheringInfoLbl.Size = new System.Drawing.Size(79, 13);
            this.CypheringInfoLbl.TabIndex = 35;
            this.CypheringInfoLbl.Text = "Dedicated key:";
            // 
            // DLMSVersionNumberTB
            // 
            this.DLMSVersionNumberTB.Location = new System.Drawing.Point(129, 178);
            this.DLMSVersionNumberTB.Name = "DLMSVersionNumberTB";
            this.DLMSVersionNumberTB.ReadOnly = true;
            this.DLMSVersionNumberTB.Size = new System.Drawing.Size(100, 20);
            this.DLMSVersionNumberTB.TabIndex = 32;
            // 
            // DLMSVersionNumberLbl
            // 
            this.DLMSVersionNumberLbl.AutoSize = true;
            this.DLMSVersionNumberLbl.Location = new System.Drawing.Point(8, 181);
            this.DLMSVersionNumberLbl.Name = "DLMSVersionNumberLbl";
            this.DLMSVersionNumberLbl.Size = new System.Drawing.Size(115, 13);
            this.DLMSVersionNumberLbl.TabIndex = 31;
            this.DLMSVersionNumberLbl.Text = "DLMS version number:";
            // 
            // MaxSendPDUSizeTb
            // 
            this.MaxSendPDUSizeTb.Location = new System.Drawing.Point(356, 152);
            this.MaxSendPDUSizeTb.Name = "MaxSendPDUSizeTb";
            this.MaxSendPDUSizeTb.ReadOnly = true;
            this.MaxSendPDUSizeTb.Size = new System.Drawing.Size(100, 20);
            this.MaxSendPDUSizeTb.TabIndex = 30;
            this.MaxSendPDUSizeTb.Leave += new System.EventHandler(this.MaxSendPDUSizeTb_Leave);
            // 
            // MaxSendPDUSizeLbl
            // 
            this.MaxSendPDUSizeLbl.AutoSize = true;
            this.MaxSendPDUSizeLbl.Location = new System.Drawing.Point(235, 155);
            this.MaxSendPDUSizeLbl.Name = "MaxSendPDUSizeLbl";
            this.MaxSendPDUSizeLbl.Size = new System.Drawing.Size(103, 13);
            this.MaxSendPDUSizeLbl.TabIndex = 29;
            this.MaxSendPDUSizeLbl.Text = "Max send PDU size:";
            // 
            // MaxReceivePDUSizeTb
            // 
            this.MaxReceivePDUSizeTb.Location = new System.Drawing.Point(129, 152);
            this.MaxReceivePDUSizeTb.Name = "MaxReceivePDUSizeTb";
            this.MaxReceivePDUSizeTb.ReadOnly = true;
            this.MaxReceivePDUSizeTb.Size = new System.Drawing.Size(100, 20);
            this.MaxReceivePDUSizeTb.TabIndex = 28;
            this.MaxReceivePDUSizeTb.Leave += new System.EventHandler(this.MaxReceivePDUSizeTb_Leave);
            // 
            // MaxReceivePDUSizeLbl
            // 
            this.MaxReceivePDUSizeLbl.AutoSize = true;
            this.MaxReceivePDUSizeLbl.Location = new System.Drawing.Point(8, 155);
            this.MaxReceivePDUSizeLbl.Name = "MaxReceivePDUSizeLbl";
            this.MaxReceivePDUSizeLbl.Size = new System.Drawing.Size(115, 13);
            this.MaxReceivePDUSizeLbl.TabIndex = 27;
            this.MaxReceivePDUSizeLbl.Text = "Max receive PDU size:";
            // 
            // ConformanceLbl
            // 
            this.ConformanceLbl.AutoSize = true;
            this.ConformanceLbl.Location = new System.Drawing.Point(8, 17);
            this.ConformanceLbl.Name = "ConformanceLbl";
            this.ConformanceLbl.Size = new System.Drawing.Size(73, 13);
            this.ConformanceLbl.TabIndex = 25;
            this.ConformanceLbl.Text = "Conformance:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ApplicationRegistrationAuthorityCb);
            this.tabPage4.Controls.Add(this.ApplicationRegistrationAuthorityLbl);
            this.tabPage4.Controls.Add(this.ApplicationContextIDCb);
            this.tabPage4.Controls.Add(this.ApplicationContextIDLbl);
            this.tabPage4.Controls.Add(this.ApplicationContextTb);
            this.tabPage4.Controls.Add(this.ApplicationContextLbl);
            this.tabPage4.Controls.Add(this.ApplicationDLMSUATb);
            this.tabPage4.Controls.Add(this.ApplicationDLMSUALbl);
            this.tabPage4.Controls.Add(this.ApplicationIdentifiedOrganizationTb);
            this.tabPage4.Controls.Add(this.ApplicationIdentifiedOrganizationLbl);
            this.tabPage4.Controls.Add(this.ApplicationCountryNameTb);
            this.tabPage4.Controls.Add(this.ApplicationCountryNameLbl);
            this.tabPage4.Controls.Add(this.ApplicationCountryTb);
            this.tabPage4.Controls.Add(this.ApplicationCountryLbl);
            this.tabPage4.Controls.Add(this.ApplicationJointISOCTTTb);
            this.tabPage4.Controls.Add(this.ApplicationJointISOCTTLbl);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(601, 309);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Application Context Name";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ApplicationRegistrationAuthorityCb
            // 
            this.ApplicationRegistrationAuthorityCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApplicationRegistrationAuthorityCb.Enabled = false;
            this.ApplicationRegistrationAuthorityCb.FormattingEnabled = true;
            this.ApplicationRegistrationAuthorityCb.Location = new System.Drawing.Point(133, 13);
            this.ApplicationRegistrationAuthorityCb.Name = "ApplicationRegistrationAuthorityCb";
            this.ApplicationRegistrationAuthorityCb.Size = new System.Drawing.Size(198, 21);
            this.ApplicationRegistrationAuthorityCb.TabIndex = 45;
            // 
            // ApplicationRegistrationAuthorityLbl
            // 
            this.ApplicationRegistrationAuthorityLbl.AutoSize = true;
            this.ApplicationRegistrationAuthorityLbl.Location = new System.Drawing.Point(12, 16);
            this.ApplicationRegistrationAuthorityLbl.Name = "ApplicationRegistrationAuthorityLbl";
            this.ApplicationRegistrationAuthorityLbl.Size = new System.Drawing.Size(110, 13);
            this.ApplicationRegistrationAuthorityLbl.TabIndex = 44;
            this.ApplicationRegistrationAuthorityLbl.Text = "Registration Authority:";
            // 
            // ApplicationContextIDCb
            // 
            this.ApplicationContextIDCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ApplicationContextIDCb.FormattingEnabled = true;
            this.ApplicationContextIDCb.Location = new System.Drawing.Point(133, 196);
            this.ApplicationContextIDCb.Name = "ApplicationContextIDCb";
            this.ApplicationContextIDCb.Size = new System.Drawing.Size(198, 21);
            this.ApplicationContextIDCb.TabIndex = 43;
            this.ApplicationContextIDCb.SelectedIndexChanged += new System.EventHandler(this.ApplicationContextIDCb_SelectedIndexChanged);
            // 
            // ApplicationContextIDLbl
            // 
            this.ApplicationContextIDLbl.AutoSize = true;
            this.ApplicationContextIDLbl.Location = new System.Drawing.Point(12, 199);
            this.ApplicationContextIDLbl.Name = "ApplicationContextIDLbl";
            this.ApplicationContextIDLbl.Size = new System.Drawing.Size(60, 13);
            this.ApplicationContextIDLbl.TabIndex = 41;
            this.ApplicationContextIDLbl.Text = "Context ID:";
            // 
            // ApplicationContextTb
            // 
            this.ApplicationContextTb.Location = new System.Drawing.Point(133, 170);
            this.ApplicationContextTb.Name = "ApplicationContextTb";
            this.ApplicationContextTb.ReadOnly = true;
            this.ApplicationContextTb.Size = new System.Drawing.Size(198, 20);
            this.ApplicationContextTb.TabIndex = 40;
            // 
            // ApplicationContextLbl
            // 
            this.ApplicationContextLbl.AutoSize = true;
            this.ApplicationContextLbl.Location = new System.Drawing.Point(12, 173);
            this.ApplicationContextLbl.Name = "ApplicationContextLbl";
            this.ApplicationContextLbl.Size = new System.Drawing.Size(100, 13);
            this.ApplicationContextLbl.TabIndex = 39;
            this.ApplicationContextLbl.Text = "Application context:";
            // 
            // ApplicationDLMSUATb
            // 
            this.ApplicationDLMSUATb.Location = new System.Drawing.Point(133, 144);
            this.ApplicationDLMSUATb.Name = "ApplicationDLMSUATb";
            this.ApplicationDLMSUATb.ReadOnly = true;
            this.ApplicationDLMSUATb.Size = new System.Drawing.Size(198, 20);
            this.ApplicationDLMSUATb.TabIndex = 38;
            // 
            // ApplicationDLMSUALbl
            // 
            this.ApplicationDLMSUALbl.AutoSize = true;
            this.ApplicationDLMSUALbl.Location = new System.Drawing.Point(12, 147);
            this.ApplicationDLMSUALbl.Name = "ApplicationDLMSUALbl";
            this.ApplicationDLMSUALbl.Size = new System.Drawing.Size(58, 13);
            this.ApplicationDLMSUALbl.TabIndex = 37;
            this.ApplicationDLMSUALbl.Text = "DLMS UA:";
            // 
            // ApplicationIdentifiedOrganizationTb
            // 
            this.ApplicationIdentifiedOrganizationTb.Location = new System.Drawing.Point(133, 118);
            this.ApplicationIdentifiedOrganizationTb.Name = "ApplicationIdentifiedOrganizationTb";
            this.ApplicationIdentifiedOrganizationTb.ReadOnly = true;
            this.ApplicationIdentifiedOrganizationTb.Size = new System.Drawing.Size(198, 20);
            this.ApplicationIdentifiedOrganizationTb.TabIndex = 36;
            // 
            // ApplicationIdentifiedOrganizationLbl
            // 
            this.ApplicationIdentifiedOrganizationLbl.AutoSize = true;
            this.ApplicationIdentifiedOrganizationLbl.Location = new System.Drawing.Point(12, 121);
            this.ApplicationIdentifiedOrganizationLbl.Name = "ApplicationIdentifiedOrganizationLbl";
            this.ApplicationIdentifiedOrganizationLbl.Size = new System.Drawing.Size(113, 13);
            this.ApplicationIdentifiedOrganizationLbl.TabIndex = 35;
            this.ApplicationIdentifiedOrganizationLbl.Text = "Identified organization:";
            // 
            // ApplicationCountryNameTb
            // 
            this.ApplicationCountryNameTb.Location = new System.Drawing.Point(133, 92);
            this.ApplicationCountryNameTb.Name = "ApplicationCountryNameTb";
            this.ApplicationCountryNameTb.ReadOnly = true;
            this.ApplicationCountryNameTb.Size = new System.Drawing.Size(198, 20);
            this.ApplicationCountryNameTb.TabIndex = 34;
            // 
            // ApplicationCountryNameLbl
            // 
            this.ApplicationCountryNameLbl.AutoSize = true;
            this.ApplicationCountryNameLbl.Location = new System.Drawing.Point(12, 95);
            this.ApplicationCountryNameLbl.Name = "ApplicationCountryNameLbl";
            this.ApplicationCountryNameLbl.Size = new System.Drawing.Size(75, 13);
            this.ApplicationCountryNameLbl.TabIndex = 33;
            this.ApplicationCountryNameLbl.Text = "Country name:";
            // 
            // ApplicationCountryTb
            // 
            this.ApplicationCountryTb.Location = new System.Drawing.Point(133, 66);
            this.ApplicationCountryTb.Name = "ApplicationCountryTb";
            this.ApplicationCountryTb.ReadOnly = true;
            this.ApplicationCountryTb.Size = new System.Drawing.Size(198, 20);
            this.ApplicationCountryTb.TabIndex = 32;
            // 
            // ApplicationCountryLbl
            // 
            this.ApplicationCountryLbl.AutoSize = true;
            this.ApplicationCountryLbl.Location = new System.Drawing.Point(12, 69);
            this.ApplicationCountryLbl.Name = "ApplicationCountryLbl";
            this.ApplicationCountryLbl.Size = new System.Drawing.Size(46, 13);
            this.ApplicationCountryLbl.TabIndex = 31;
            this.ApplicationCountryLbl.Text = "Country:";
            // 
            // ApplicationJointISOCTTTb
            // 
            this.ApplicationJointISOCTTTb.Location = new System.Drawing.Point(133, 40);
            this.ApplicationJointISOCTTTb.Name = "ApplicationJointISOCTTTb";
            this.ApplicationJointISOCTTTb.ReadOnly = true;
            this.ApplicationJointISOCTTTb.Size = new System.Drawing.Size(198, 20);
            this.ApplicationJointISOCTTTb.TabIndex = 30;
            // 
            // ApplicationJointISOCTTLbl
            // 
            this.ApplicationJointISOCTTLbl.AutoSize = true;
            this.ApplicationJointISOCTTLbl.Location = new System.Drawing.Point(12, 43);
            this.ApplicationJointISOCTTLbl.Name = "ApplicationJointISOCTTLbl";
            this.ApplicationJointISOCTTLbl.Size = new System.Drawing.Size(77, 13);
            this.ApplicationJointISOCTTLbl.TabIndex = 29;
            this.ApplicationJointISOCTTLbl.Text = "Joint ISO CTT:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.AuthenticationMechanismIdCb);
            this.tabPage5.Controls.Add(this.AuthenticationRegistrationAuthorityCb);
            this.tabPage5.Controls.Add(this.AuthenticationRegistrationAuthorityLbl);
            this.tabPage5.Controls.Add(this.AuthenticationMechanismIdLbl);
            this.tabPage5.Controls.Add(this.AuthenticationMechanismNameTb);
            this.tabPage5.Controls.Add(this.AuthenticationMechanismNameLbl);
            this.tabPage5.Controls.Add(this.AuthenticationDLMSUATb);
            this.tabPage5.Controls.Add(this.AuthenticationDLMSUALbl);
            this.tabPage5.Controls.Add(this.AuthenticationIdentifiedorganizationTb);
            this.tabPage5.Controls.Add(this.AuthenticationIdentifiedorganizationLbl);
            this.tabPage5.Controls.Add(this.AuthenticationCountryNameTb);
            this.tabPage5.Controls.Add(this.AuthenticationCountryNameLbl);
            this.tabPage5.Controls.Add(this.AuthenticationCountryTb);
            this.tabPage5.Controls.Add(this.AuthenticationCountryLbl);
            this.tabPage5.Controls.Add(this.AuthenticationJointISOCTTTb);
            this.tabPage5.Controls.Add(this.AuthenticationJointISOCTTLbl);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(601, 309);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Authentication Mechanism Name ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // AuthenticationMechanismIdCb
            // 
            this.AuthenticationMechanismIdCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthenticationMechanismIdCb.FormattingEnabled = true;
            this.AuthenticationMechanismIdCb.Location = new System.Drawing.Point(133, 199);
            this.AuthenticationMechanismIdCb.Name = "AuthenticationMechanismIdCb";
            this.AuthenticationMechanismIdCb.Size = new System.Drawing.Size(198, 21);
            this.AuthenticationMechanismIdCb.TabIndex = 7;
            this.AuthenticationMechanismIdCb.SelectedIndexChanged += new System.EventHandler(this.AuthenticationMechanismIdCb_SelectedIndexChanged);
            // 
            // AuthenticationRegistrationAuthorityCb
            // 
            this.AuthenticationRegistrationAuthorityCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthenticationRegistrationAuthorityCb.Enabled = false;
            this.AuthenticationRegistrationAuthorityCb.FormattingEnabled = true;
            this.AuthenticationRegistrationAuthorityCb.Location = new System.Drawing.Point(133, 13);
            this.AuthenticationRegistrationAuthorityCb.Name = "AuthenticationRegistrationAuthorityCb";
            this.AuthenticationRegistrationAuthorityCb.Size = new System.Drawing.Size(198, 21);
            this.AuthenticationRegistrationAuthorityCb.TabIndex = 0;
            // 
            // AuthenticationRegistrationAuthorityLbl
            // 
            this.AuthenticationRegistrationAuthorityLbl.AutoSize = true;
            this.AuthenticationRegistrationAuthorityLbl.Location = new System.Drawing.Point(12, 16);
            this.AuthenticationRegistrationAuthorityLbl.Name = "AuthenticationRegistrationAuthorityLbl";
            this.AuthenticationRegistrationAuthorityLbl.Size = new System.Drawing.Size(110, 13);
            this.AuthenticationRegistrationAuthorityLbl.TabIndex = 57;
            this.AuthenticationRegistrationAuthorityLbl.Text = "Registration Authority:";
            // 
            // AuthenticationMechanismIdLbl
            // 
            this.AuthenticationMechanismIdLbl.AutoSize = true;
            this.AuthenticationMechanismIdLbl.Location = new System.Drawing.Point(12, 199);
            this.AuthenticationMechanismIdLbl.Name = "AuthenticationMechanismIdLbl";
            this.AuthenticationMechanismIdLbl.Size = new System.Drawing.Size(78, 13);
            this.AuthenticationMechanismIdLbl.TabIndex = 55;
            this.AuthenticationMechanismIdLbl.Text = "Mechanism ID:";
            // 
            // AuthenticationMechanismNameTb
            // 
            this.AuthenticationMechanismNameTb.Location = new System.Drawing.Point(133, 170);
            this.AuthenticationMechanismNameTb.Name = "AuthenticationMechanismNameTb";
            this.AuthenticationMechanismNameTb.ReadOnly = true;
            this.AuthenticationMechanismNameTb.Size = new System.Drawing.Size(198, 20);
            this.AuthenticationMechanismNameTb.TabIndex = 6;
            // 
            // AuthenticationMechanismNameLbl
            // 
            this.AuthenticationMechanismNameLbl.AutoSize = true;
            this.AuthenticationMechanismNameLbl.Location = new System.Drawing.Point(12, 173);
            this.AuthenticationMechanismNameLbl.Name = "AuthenticationMechanismNameLbl";
            this.AuthenticationMechanismNameLbl.Size = new System.Drawing.Size(109, 13);
            this.AuthenticationMechanismNameLbl.TabIndex = 53;
            this.AuthenticationMechanismNameLbl.Text = "Authentication Name:";
            // 
            // AuthenticationDLMSUATb
            // 
            this.AuthenticationDLMSUATb.Location = new System.Drawing.Point(133, 144);
            this.AuthenticationDLMSUATb.Name = "AuthenticationDLMSUATb";
            this.AuthenticationDLMSUATb.ReadOnly = true;
            this.AuthenticationDLMSUATb.Size = new System.Drawing.Size(198, 20);
            this.AuthenticationDLMSUATb.TabIndex = 5;
            // 
            // AuthenticationDLMSUALbl
            // 
            this.AuthenticationDLMSUALbl.AutoSize = true;
            this.AuthenticationDLMSUALbl.Location = new System.Drawing.Point(12, 147);
            this.AuthenticationDLMSUALbl.Name = "AuthenticationDLMSUALbl";
            this.AuthenticationDLMSUALbl.Size = new System.Drawing.Size(58, 13);
            this.AuthenticationDLMSUALbl.TabIndex = 51;
            this.AuthenticationDLMSUALbl.Text = "DLMS UA:";
            // 
            // AuthenticationIdentifiedorganizationTb
            // 
            this.AuthenticationIdentifiedorganizationTb.Location = new System.Drawing.Point(133, 118);
            this.AuthenticationIdentifiedorganizationTb.Name = "AuthenticationIdentifiedorganizationTb";
            this.AuthenticationIdentifiedorganizationTb.ReadOnly = true;
            this.AuthenticationIdentifiedorganizationTb.Size = new System.Drawing.Size(198, 20);
            this.AuthenticationIdentifiedorganizationTb.TabIndex = 4;
            // 
            // AuthenticationIdentifiedorganizationLbl
            // 
            this.AuthenticationIdentifiedorganizationLbl.AutoSize = true;
            this.AuthenticationIdentifiedorganizationLbl.Location = new System.Drawing.Point(12, 121);
            this.AuthenticationIdentifiedorganizationLbl.Name = "AuthenticationIdentifiedorganizationLbl";
            this.AuthenticationIdentifiedorganizationLbl.Size = new System.Drawing.Size(113, 13);
            this.AuthenticationIdentifiedorganizationLbl.TabIndex = 49;
            this.AuthenticationIdentifiedorganizationLbl.Text = "Identified organization:";
            // 
            // AuthenticationCountryNameTb
            // 
            this.AuthenticationCountryNameTb.Location = new System.Drawing.Point(133, 92);
            this.AuthenticationCountryNameTb.Name = "AuthenticationCountryNameTb";
            this.AuthenticationCountryNameTb.ReadOnly = true;
            this.AuthenticationCountryNameTb.Size = new System.Drawing.Size(198, 20);
            this.AuthenticationCountryNameTb.TabIndex = 3;
            // 
            // AuthenticationCountryNameLbl
            // 
            this.AuthenticationCountryNameLbl.AutoSize = true;
            this.AuthenticationCountryNameLbl.Location = new System.Drawing.Point(12, 95);
            this.AuthenticationCountryNameLbl.Name = "AuthenticationCountryNameLbl";
            this.AuthenticationCountryNameLbl.Size = new System.Drawing.Size(75, 13);
            this.AuthenticationCountryNameLbl.TabIndex = 47;
            this.AuthenticationCountryNameLbl.Text = "Country name:";
            // 
            // AuthenticationCountryTb
            // 
            this.AuthenticationCountryTb.Location = new System.Drawing.Point(133, 66);
            this.AuthenticationCountryTb.Name = "AuthenticationCountryTb";
            this.AuthenticationCountryTb.ReadOnly = true;
            this.AuthenticationCountryTb.Size = new System.Drawing.Size(198, 20);
            this.AuthenticationCountryTb.TabIndex = 2;
            // 
            // AuthenticationCountryLbl
            // 
            this.AuthenticationCountryLbl.AutoSize = true;
            this.AuthenticationCountryLbl.Location = new System.Drawing.Point(12, 69);
            this.AuthenticationCountryLbl.Name = "AuthenticationCountryLbl";
            this.AuthenticationCountryLbl.Size = new System.Drawing.Size(46, 13);
            this.AuthenticationCountryLbl.TabIndex = 45;
            this.AuthenticationCountryLbl.Text = "Country:";
            // 
            // AuthenticationJointISOCTTTb
            // 
            this.AuthenticationJointISOCTTTb.Location = new System.Drawing.Point(133, 40);
            this.AuthenticationJointISOCTTTb.Name = "AuthenticationJointISOCTTTb";
            this.AuthenticationJointISOCTTTb.ReadOnly = true;
            this.AuthenticationJointISOCTTTb.Size = new System.Drawing.Size(198, 20);
            this.AuthenticationJointISOCTTTb.TabIndex = 1;
            // 
            // AuthenticationJointISOCTTLbl
            // 
            this.AuthenticationJointISOCTTLbl.AutoSize = true;
            this.AuthenticationJointISOCTTLbl.Location = new System.Drawing.Point(12, 43);
            this.AuthenticationJointISOCTTLbl.Name = "AuthenticationJointISOCTTLbl";
            this.AuthenticationJointISOCTTLbl.Size = new System.Drawing.Size(77, 13);
            this.AuthenticationJointISOCTTLbl.TabIndex = 43;
            this.AuthenticationJointISOCTTLbl.Text = "Joint ISO CTT:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.AddUserBtn);
            this.tabPage6.Controls.Add(this.RemoveUserBtn);
            this.tabPage6.Controls.Add(this.UsersList);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(601, 309);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "User List";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddUserBtn.Index = 5;
            this.AddUserBtn.Location = new System.Drawing.Point(418, 280);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(75, 23);
            this.AddUserBtn.TabIndex = 20;
            this.AddUserBtn.Text = "Add";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveUserBtn
            // 
            this.RemoveUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveUserBtn.Index = 6;
            this.RemoveUserBtn.Location = new System.Drawing.Point(499, 280);
            this.RemoveUserBtn.Name = "RemoveUserBtn";
            this.RemoveUserBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveUserBtn.TabIndex = 16;
            this.RemoveUserBtn.Text = "Remove";
            this.RemoveUserBtn.UseVisualStyleBackColor = true;
            // 
            // UsersList
            // 
            this.UsersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserIdCh,
            this.UserNameCh});
            this.UsersList.FullRowSelect = true;
            this.UsersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UsersList.HideSelection = false;
            this.UsersList.Location = new System.Drawing.Point(0, 0);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(574, 274);
            this.UsersList.TabIndex = 15;
            this.UsersList.UseCompatibleStateImageBehavior = false;
            this.UsersList.View = System.Windows.Forms.View.Details;
            // 
            // UserIdCh
            // 
            this.UserIdCh.Text = "ID:";
            this.UserIdCh.Width = 47;
            // 
            // UserNameCh
            // 
            this.UserNameCh.Text = "Name";
            this.UserNameCh.Width = 418;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(185, 20);
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
            // GXDLMSAssociationLogicalNameView
            // 
            this.ClientSize = new System.Drawing.Size(648, 412);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSAssociationLogicalNameView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.LNSettings.ResumeLayout(false);
            this.LNSettings.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView ObjectsView;
        private ColumnHeader ClassIdHeader;
        private ColumnHeader VersionHeader;
        private ColumnHeader LogicalNameHeader;
        private ColumnHeader AttributeAccesssHeader;
        private ColumnHeader MethodAccessHeader;
        private TabPage tabPage2;
        private Label SecretLbl;
        private GXValueField gxValueField1;
        private Label label1;
        private TabPage tabPage3;
        private GroupBox groupBox2;
        private TextBox ServerSAPTb;
        private TextBox ClientSAPTb;
        private Label ServerSAPLbl;
        private Label ClientSAPLbl;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label SecuritySetupReferenceLbl;
        private Label ConformanceLbl;
        private TextBox MaxSendPDUSizeTb;
        private Label MaxSendPDUSizeLbl;
        private TextBox MaxReceivePDUSizeTb;
        private Label MaxReceivePDUSizeLbl;
        private TextBox DLMSVersionNumberTB;
        private Label DLMSVersionNumberLbl;
        private TextBox CypheringInfoTb;
        private Label CypheringInfoLbl;
        private Label ApplicationContextIDLbl;
        private TextBox ApplicationContextTb;
        private Label ApplicationContextLbl;
        private TextBox ApplicationDLMSUATb;
        private Label ApplicationDLMSUALbl;
        private TextBox ApplicationIdentifiedOrganizationTb;
        private Label ApplicationIdentifiedOrganizationLbl;
        private TextBox ApplicationCountryNameTb;
        private Label ApplicationCountryNameLbl;
        private TextBox ApplicationCountryTb;
        private Label ApplicationCountryLbl;
        private TextBox ApplicationJointISOCTTTb;
        private Label ApplicationJointISOCTTLbl;
        private Label AuthenticationMechanismIdLbl;
        private TextBox AuthenticationMechanismNameTb;
        private Label AuthenticationMechanismNameLbl;
        private TextBox AuthenticationDLMSUATb;
        private Label AuthenticationDLMSUALbl;
        private TextBox AuthenticationIdentifiedorganizationTb;
        private Label AuthenticationIdentifiedorganizationLbl;
        private TextBox AuthenticationCountryNameTb;
        private Label AuthenticationCountryNameLbl;
        private TextBox AuthenticationCountryTb;
        private Label AuthenticationCountryLbl;
        private TextBox AuthenticationJointISOCTTTb;
        private Label AuthenticationJointISOCTTLbl;
        private CheckBox SecretAsciiCb;
        private TextBox SecretTB;
        private GXButton UpdatePwBtn;
        private ComboBox SecuritySetupCb;
        private TabPage tabPage6;
        private ListView UsersList;
        private ColumnHeader UserIdCh;
        private ColumnHeader UserNameCh;
        private GXButton AddUserBtn;
        private GXButton RemoveUserBtn;
        private GXButton AddObjectBtn;
        private GXButton RemoveObjectBtn;
        private GXButton UpdateHighPwBtn;
        private ComboBox ApplicationContextIDCb;
        private ComboBox ApplicationRegistrationAuthorityCb;
        private Label ApplicationRegistrationAuthorityLbl;
        private ComboBox AuthenticationRegistrationAuthorityCb;
        private Label AuthenticationRegistrationAuthorityLbl;
        private ComboBox AuthenticationMechanismIdCb;
        private GroupBox LNSettings;
        private CheckBox DeltaValueEncodingCb;
        private CheckBox GeneralProtectionCB;
        private CheckBox GeneralBlockTransferCB;
        private CheckBox Attribute0SetReferencingCB;
        private CheckBox PriorityManagementCB;
        private CheckBox Attribute0GetReferencingCB;
        private CheckBox GetBlockTransferCB;
        private CheckBox SetBlockTransferCB;
        private CheckBox ActionBlockTransferCB;
        private CheckBox MultipleReferencesCB;
        private CheckBox DataNotificationCB;
        private CheckBox AccessCB;
        private CheckBox GetCB;
        private CheckBox SetCB;
        private CheckBox SelectiveAccessCB;
        private CheckBox EventNotificationCB;
        private CheckBox ActionCB;
        private Label VersionLbl;
        private TextBox VersionTb;
    }
}
