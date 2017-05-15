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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ObjectRemoveBtn = new System.Windows.Forms.Button();
            this.ObjectEditBtn = new System.Windows.Forms.Button();
            this.ObjectAddBtn = new System.Windows.Forms.Button();
            this.ObjectsView = new System.Windows.Forms.ListView();
            this.ClassIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeAccesssHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MethodAccessHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SecretTB = new System.Windows.Forms.TextBox();
            this.SecretAsciiCb = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SecuritySetupReferenceLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServerSAPTb = new System.Windows.Forms.TextBox();
            this.ClientSAPTb = new System.Windows.Forms.TextBox();
            this.ServerSAPLbl = new System.Windows.Forms.Label();
            this.ClientSAPLbl = new System.Windows.Forms.Label();
            this.SecretLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CypheringInfoTb = new System.Windows.Forms.TextBox();
            this.CypheringInfoLbl = new System.Windows.Forms.Label();
            this.DLMSVersionNumberTB = new System.Windows.Forms.TextBox();
            this.DLMSVersionNumberLbl = new System.Windows.Forms.Label();
            this.MaxSendPDUSizeTb = new System.Windows.Forms.TextBox();
            this.MaxSendPDUSizeLbl = new System.Windows.Forms.Label();
            this.MaxReceivePDUSizeTb = new System.Windows.Forms.TextBox();
            this.MaxReceivePDUSizeLbl = new System.Windows.Forms.Label();
            this.ConformanceTB = new System.Windows.Forms.TextBox();
            this.ConformanceLbl = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ApplicationContextIDTb = new System.Windows.Forms.TextBox();
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
            this.AuthenticationMechanismIdTb = new System.Windows.Forms.TextBox();
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
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gxValueField1 = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.ObjectsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.ObjectsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Association Logical  Name Object";
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
            this.tabControl1.Location = new System.Drawing.Point(9, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 271);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ObjectRemoveBtn);
            this.tabPage1.Controls.Add(this.ObjectEditBtn);
            this.tabPage1.Controls.Add(this.ObjectAddBtn);
            this.tabPage1.Controls.Add(this.ObjectsView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Objects";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ObjectRemoveBtn
            // 
            this.ObjectRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectRemoveBtn.Location = new System.Drawing.Point(409, 219);
            this.ObjectRemoveBtn.Name = "ObjectRemoveBtn";
            this.ObjectRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectRemoveBtn.TabIndex = 20;
            this.ObjectRemoveBtn.Text = "Remove";
            this.ObjectRemoveBtn.UseVisualStyleBackColor = true;
            this.ObjectRemoveBtn.Click += new System.EventHandler(this.ObjectRemoveBtn_Click);
            // 
            // ObjectEditBtn
            // 
            this.ObjectEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectEditBtn.Location = new System.Drawing.Point(328, 219);
            this.ObjectEditBtn.Name = "ObjectEditBtn";
            this.ObjectEditBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectEditBtn.TabIndex = 19;
            this.ObjectEditBtn.Text = "Edit...";
            this.ObjectEditBtn.UseVisualStyleBackColor = true;
            this.ObjectEditBtn.Click += new System.EventHandler(this.ObjectEditBtn_Click);
            // 
            // ObjectAddBtn
            // 
            this.ObjectAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectAddBtn.Location = new System.Drawing.Point(247, 219);
            this.ObjectAddBtn.Name = "ObjectAddBtn";
            this.ObjectAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectAddBtn.TabIndex = 18;
            this.ObjectAddBtn.Text = "Add...";
            this.ObjectAddBtn.UseVisualStyleBackColor = true;
            this.ObjectAddBtn.Click += new System.EventHandler(this.ObjectAddBtn_Click);
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
            this.ObjectsView.ContextMenuStrip = this.ObjectsMenu;
            this.ObjectsView.FullRowSelect = true;
            this.ObjectsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ObjectsView.HideSelection = false;
            this.ObjectsView.Location = new System.Drawing.Point(3, 3);
            this.ObjectsView.Name = "ObjectsView";
            this.ObjectsView.Size = new System.Drawing.Size(482, 210);
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
            this.AttributeAccesssHeader.Text = "Acctibute Access:";
            this.AttributeAccesssHeader.Width = 106;
            // 
            // MethodAccessHeader
            // 
            this.MethodAccessHeader.Text = "Method Access:";
            this.MethodAccessHeader.Width = 97;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SecretTB);
            this.tabPage2.Controls.Add(this.SecretAsciiCb);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.SecuritySetupReferenceLbl);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.SecretLbl);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.gxValueField1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "General";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SecretTB
            // 
            this.SecretTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretTB.Location = new System.Drawing.Point(115, 67);
            this.SecretTB.Name = "SecretTB";
            this.SecretTB.Size = new System.Drawing.Size(242, 20);
            this.SecretTB.TabIndex = 28;
            // 
            // SecretAsciiCb
            // 
            this.SecretAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretAsciiCb.AutoSize = true;
            this.SecretAsciiCb.Location = new System.Drawing.Point(371, 71);
            this.SecretAsciiCb.Name = "SecretAsciiCb";
            this.SecretAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.SecretAsciiCb.TabIndex = 27;
            this.SecretAsciiCb.Text = "ASCII";
            this.SecretAsciiCb.UseVisualStyleBackColor = true;
            this.SecretAsciiCb.CheckedChanged += new System.EventHandler(this.SecretAsciiCb_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(115, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 26;
            // 
            // SecuritySetupReferenceLbl
            // 
            this.SecuritySetupReferenceLbl.AutoSize = true;
            this.SecuritySetupReferenceLbl.Location = new System.Drawing.Point(8, 123);
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
            this.groupBox2.Size = new System.Drawing.Size(639, 61);
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
            // 
            // ClientSAPTb
            // 
            this.ClientSAPTb.Location = new System.Drawing.Point(113, 25);
            this.ClientSAPTb.Name = "ClientSAPTb";
            this.ClientSAPTb.Size = new System.Drawing.Size(100, 20);
            this.ClientSAPTb.TabIndex = 24;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CypheringInfoTb);
            this.tabPage3.Controls.Add(this.CypheringInfoLbl);
            this.tabPage3.Controls.Add(this.DLMSVersionNumberTB);
            this.tabPage3.Controls.Add(this.DLMSVersionNumberLbl);
            this.tabPage3.Controls.Add(this.MaxSendPDUSizeTb);
            this.tabPage3.Controls.Add(this.MaxSendPDUSizeLbl);
            this.tabPage3.Controls.Add(this.MaxReceivePDUSizeTb);
            this.tabPage3.Controls.Add(this.MaxReceivePDUSizeLbl);
            this.tabPage3.Controls.Add(this.ConformanceTB);
            this.tabPage3.Controls.Add(this.ConformanceLbl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(509, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "xDLMS Context Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CypheringInfoTb
            // 
            this.CypheringInfoTb.Location = new System.Drawing.Point(129, 115);
            this.CypheringInfoTb.Name = "CypheringInfoTb";
            this.CypheringInfoTb.ReadOnly = true;
            this.CypheringInfoTb.Size = new System.Drawing.Size(327, 20);
            this.CypheringInfoTb.TabIndex = 36;
            // 
            // CypheringInfoLbl
            // 
            this.CypheringInfoLbl.AutoSize = true;
            this.CypheringInfoLbl.Location = new System.Drawing.Point(8, 118);
            this.CypheringInfoLbl.Name = "CypheringInfoLbl";
            this.CypheringInfoLbl.Size = new System.Drawing.Size(77, 13);
            this.CypheringInfoLbl.TabIndex = 35;
            this.CypheringInfoLbl.Text = "Cyphering info:";
            // 
            // DLMSVersionNumberTB
            // 
            this.DLMSVersionNumberTB.Location = new System.Drawing.Point(129, 89);
            this.DLMSVersionNumberTB.Name = "DLMSVersionNumberTB";
            this.DLMSVersionNumberTB.ReadOnly = true;
            this.DLMSVersionNumberTB.Size = new System.Drawing.Size(100, 20);
            this.DLMSVersionNumberTB.TabIndex = 32;
            // 
            // DLMSVersionNumberLbl
            // 
            this.DLMSVersionNumberLbl.AutoSize = true;
            this.DLMSVersionNumberLbl.Location = new System.Drawing.Point(8, 92);
            this.DLMSVersionNumberLbl.Name = "DLMSVersionNumberLbl";
            this.DLMSVersionNumberLbl.Size = new System.Drawing.Size(115, 13);
            this.DLMSVersionNumberLbl.TabIndex = 31;
            this.DLMSVersionNumberLbl.Text = "DLMS version number:";
            // 
            // MaxSendPDUSizeTb
            // 
            this.MaxSendPDUSizeTb.Location = new System.Drawing.Point(356, 63);
            this.MaxSendPDUSizeTb.Name = "MaxSendPDUSizeTb";
            this.MaxSendPDUSizeTb.ReadOnly = true;
            this.MaxSendPDUSizeTb.Size = new System.Drawing.Size(100, 20);
            this.MaxSendPDUSizeTb.TabIndex = 30;
            // 
            // MaxSendPDUSizeLbl
            // 
            this.MaxSendPDUSizeLbl.AutoSize = true;
            this.MaxSendPDUSizeLbl.Location = new System.Drawing.Point(235, 66);
            this.MaxSendPDUSizeLbl.Name = "MaxSendPDUSizeLbl";
            this.MaxSendPDUSizeLbl.Size = new System.Drawing.Size(103, 13);
            this.MaxSendPDUSizeLbl.TabIndex = 29;
            this.MaxSendPDUSizeLbl.Text = "Max send PDU size:";
            // 
            // MaxReceivePDUSizeTb
            // 
            this.MaxReceivePDUSizeTb.Location = new System.Drawing.Point(129, 63);
            this.MaxReceivePDUSizeTb.Name = "MaxReceivePDUSizeTb";
            this.MaxReceivePDUSizeTb.ReadOnly = true;
            this.MaxReceivePDUSizeTb.Size = new System.Drawing.Size(100, 20);
            this.MaxReceivePDUSizeTb.TabIndex = 28;
            // 
            // MaxReceivePDUSizeLbl
            // 
            this.MaxReceivePDUSizeLbl.AutoSize = true;
            this.MaxReceivePDUSizeLbl.Location = new System.Drawing.Point(8, 66);
            this.MaxReceivePDUSizeLbl.Name = "MaxReceivePDUSizeLbl";
            this.MaxReceivePDUSizeLbl.Size = new System.Drawing.Size(115, 13);
            this.MaxReceivePDUSizeLbl.TabIndex = 27;
            this.MaxReceivePDUSizeLbl.Text = "Max receive PDU size:";
            // 
            // ConformanceTB
            // 
            this.ConformanceTB.Location = new System.Drawing.Point(92, 14);
            this.ConformanceTB.Multiline = true;
            this.ConformanceTB.Name = "ConformanceTB";
            this.ConformanceTB.ReadOnly = true;
            this.ConformanceTB.Size = new System.Drawing.Size(546, 43);
            this.ConformanceTB.TabIndex = 26;
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
            this.tabPage4.Controls.Add(this.ApplicationContextIDTb);
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
            this.tabPage4.Size = new System.Drawing.Size(509, 245);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Application Context Name";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ApplicationContextIDTb
            // 
            this.ApplicationContextIDTb.Location = new System.Drawing.Point(133, 171);
            this.ApplicationContextIDTb.Name = "ApplicationContextIDTb";
            this.ApplicationContextIDTb.ReadOnly = true;
            this.ApplicationContextIDTb.Size = new System.Drawing.Size(100, 20);
            this.ApplicationContextIDTb.TabIndex = 42;
            // 
            // ApplicationContextIDLbl
            // 
            this.ApplicationContextIDLbl.AutoSize = true;
            this.ApplicationContextIDLbl.Location = new System.Drawing.Point(12, 174);
            this.ApplicationContextIDLbl.Name = "ApplicationContextIDLbl";
            this.ApplicationContextIDLbl.Size = new System.Drawing.Size(60, 13);
            this.ApplicationContextIDLbl.TabIndex = 41;
            this.ApplicationContextIDLbl.Text = "Context ID:";
            // 
            // ApplicationContextTb
            // 
            this.ApplicationContextTb.Location = new System.Drawing.Point(133, 145);
            this.ApplicationContextTb.Name = "ApplicationContextTb";
            this.ApplicationContextTb.ReadOnly = true;
            this.ApplicationContextTb.Size = new System.Drawing.Size(100, 20);
            this.ApplicationContextTb.TabIndex = 40;
            // 
            // ApplicationContextLbl
            // 
            this.ApplicationContextLbl.AutoSize = true;
            this.ApplicationContextLbl.Location = new System.Drawing.Point(12, 148);
            this.ApplicationContextLbl.Name = "ApplicationContextLbl";
            this.ApplicationContextLbl.Size = new System.Drawing.Size(100, 13);
            this.ApplicationContextLbl.TabIndex = 39;
            this.ApplicationContextLbl.Text = "Application context:";
            // 
            // ApplicationDLMSUATb
            // 
            this.ApplicationDLMSUATb.Location = new System.Drawing.Point(133, 119);
            this.ApplicationDLMSUATb.Name = "ApplicationDLMSUATb";
            this.ApplicationDLMSUATb.ReadOnly = true;
            this.ApplicationDLMSUATb.Size = new System.Drawing.Size(100, 20);
            this.ApplicationDLMSUATb.TabIndex = 38;
            // 
            // ApplicationDLMSUALbl
            // 
            this.ApplicationDLMSUALbl.AutoSize = true;
            this.ApplicationDLMSUALbl.Location = new System.Drawing.Point(12, 122);
            this.ApplicationDLMSUALbl.Name = "ApplicationDLMSUALbl";
            this.ApplicationDLMSUALbl.Size = new System.Drawing.Size(58, 13);
            this.ApplicationDLMSUALbl.TabIndex = 37;
            this.ApplicationDLMSUALbl.Text = "DLMS UA:";
            // 
            // ApplicationIdentifiedOrganizationTb
            // 
            this.ApplicationIdentifiedOrganizationTb.Location = new System.Drawing.Point(133, 93);
            this.ApplicationIdentifiedOrganizationTb.Name = "ApplicationIdentifiedOrganizationTb";
            this.ApplicationIdentifiedOrganizationTb.ReadOnly = true;
            this.ApplicationIdentifiedOrganizationTb.Size = new System.Drawing.Size(100, 20);
            this.ApplicationIdentifiedOrganizationTb.TabIndex = 36;
            // 
            // ApplicationIdentifiedOrganizationLbl
            // 
            this.ApplicationIdentifiedOrganizationLbl.AutoSize = true;
            this.ApplicationIdentifiedOrganizationLbl.Location = new System.Drawing.Point(12, 96);
            this.ApplicationIdentifiedOrganizationLbl.Name = "ApplicationIdentifiedOrganizationLbl";
            this.ApplicationIdentifiedOrganizationLbl.Size = new System.Drawing.Size(113, 13);
            this.ApplicationIdentifiedOrganizationLbl.TabIndex = 35;
            this.ApplicationIdentifiedOrganizationLbl.Text = "Identified organization:";
            // 
            // ApplicationCountryNameTb
            // 
            this.ApplicationCountryNameTb.Location = new System.Drawing.Point(133, 67);
            this.ApplicationCountryNameTb.Name = "ApplicationCountryNameTb";
            this.ApplicationCountryNameTb.ReadOnly = true;
            this.ApplicationCountryNameTb.Size = new System.Drawing.Size(100, 20);
            this.ApplicationCountryNameTb.TabIndex = 34;
            // 
            // ApplicationCountryNameLbl
            // 
            this.ApplicationCountryNameLbl.AutoSize = true;
            this.ApplicationCountryNameLbl.Location = new System.Drawing.Point(12, 70);
            this.ApplicationCountryNameLbl.Name = "ApplicationCountryNameLbl";
            this.ApplicationCountryNameLbl.Size = new System.Drawing.Size(75, 13);
            this.ApplicationCountryNameLbl.TabIndex = 33;
            this.ApplicationCountryNameLbl.Text = "Country name:";
            // 
            // ApplicationCountryTb
            // 
            this.ApplicationCountryTb.Location = new System.Drawing.Point(133, 41);
            this.ApplicationCountryTb.Name = "ApplicationCountryTb";
            this.ApplicationCountryTb.ReadOnly = true;
            this.ApplicationCountryTb.Size = new System.Drawing.Size(100, 20);
            this.ApplicationCountryTb.TabIndex = 32;
            // 
            // ApplicationCountryLbl
            // 
            this.ApplicationCountryLbl.AutoSize = true;
            this.ApplicationCountryLbl.Location = new System.Drawing.Point(12, 44);
            this.ApplicationCountryLbl.Name = "ApplicationCountryLbl";
            this.ApplicationCountryLbl.Size = new System.Drawing.Size(46, 13);
            this.ApplicationCountryLbl.TabIndex = 31;
            this.ApplicationCountryLbl.Text = "Country:";
            // 
            // ApplicationJointISOCTTTb
            // 
            this.ApplicationJointISOCTTTb.Location = new System.Drawing.Point(133, 15);
            this.ApplicationJointISOCTTTb.Name = "ApplicationJointISOCTTTb";
            this.ApplicationJointISOCTTTb.ReadOnly = true;
            this.ApplicationJointISOCTTTb.Size = new System.Drawing.Size(100, 20);
            this.ApplicationJointISOCTTTb.TabIndex = 30;
            // 
            // ApplicationJointISOCTTLbl
            // 
            this.ApplicationJointISOCTTLbl.AutoSize = true;
            this.ApplicationJointISOCTTLbl.Location = new System.Drawing.Point(12, 18);
            this.ApplicationJointISOCTTLbl.Name = "ApplicationJointISOCTTLbl";
            this.ApplicationJointISOCTTLbl.Size = new System.Drawing.Size(77, 13);
            this.ApplicationJointISOCTTLbl.TabIndex = 29;
            this.ApplicationJointISOCTTLbl.Text = "Joint ISO CTT:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.AuthenticationMechanismIdTb);
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
            this.tabPage5.Size = new System.Drawing.Size(509, 245);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Authentication Mechanism Name ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // AuthenticationMechanismIdTb
            // 
            this.AuthenticationMechanismIdTb.Location = new System.Drawing.Point(134, 170);
            this.AuthenticationMechanismIdTb.Name = "AuthenticationMechanismIdTb";
            this.AuthenticationMechanismIdTb.ReadOnly = true;
            this.AuthenticationMechanismIdTb.Size = new System.Drawing.Size(100, 20);
            this.AuthenticationMechanismIdTb.TabIndex = 56;
            // 
            // AuthenticationMechanismIdLbl
            // 
            this.AuthenticationMechanismIdLbl.AutoSize = true;
            this.AuthenticationMechanismIdLbl.Location = new System.Drawing.Point(13, 173);
            this.AuthenticationMechanismIdLbl.Name = "AuthenticationMechanismIdLbl";
            this.AuthenticationMechanismIdLbl.Size = new System.Drawing.Size(78, 13);
            this.AuthenticationMechanismIdLbl.TabIndex = 55;
            this.AuthenticationMechanismIdLbl.Text = "Mechanism ID:";
            // 
            // AuthenticationMechanismNameTb
            // 
            this.AuthenticationMechanismNameTb.Location = new System.Drawing.Point(134, 144);
            this.AuthenticationMechanismNameTb.Name = "AuthenticationMechanismNameTb";
            this.AuthenticationMechanismNameTb.ReadOnly = true;
            this.AuthenticationMechanismNameTb.Size = new System.Drawing.Size(100, 20);
            this.AuthenticationMechanismNameTb.TabIndex = 54;
            // 
            // AuthenticationMechanismNameLbl
            // 
            this.AuthenticationMechanismNameLbl.AutoSize = true;
            this.AuthenticationMechanismNameLbl.Location = new System.Drawing.Point(13, 147);
            this.AuthenticationMechanismNameLbl.Name = "AuthenticationMechanismNameLbl";
            this.AuthenticationMechanismNameLbl.Size = new System.Drawing.Size(109, 13);
            this.AuthenticationMechanismNameLbl.TabIndex = 53;
            this.AuthenticationMechanismNameLbl.Text = "Authentication Name:";
            // 
            // AuthenticationDLMSUATb
            // 
            this.AuthenticationDLMSUATb.Location = new System.Drawing.Point(134, 118);
            this.AuthenticationDLMSUATb.Name = "AuthenticationDLMSUATb";
            this.AuthenticationDLMSUATb.ReadOnly = true;
            this.AuthenticationDLMSUATb.Size = new System.Drawing.Size(100, 20);
            this.AuthenticationDLMSUATb.TabIndex = 52;
            // 
            // AuthenticationDLMSUALbl
            // 
            this.AuthenticationDLMSUALbl.AutoSize = true;
            this.AuthenticationDLMSUALbl.Location = new System.Drawing.Point(13, 121);
            this.AuthenticationDLMSUALbl.Name = "AuthenticationDLMSUALbl";
            this.AuthenticationDLMSUALbl.Size = new System.Drawing.Size(58, 13);
            this.AuthenticationDLMSUALbl.TabIndex = 51;
            this.AuthenticationDLMSUALbl.Text = "DLMS UA:";
            // 
            // AuthenticationIdentifiedorganizationTb
            // 
            this.AuthenticationIdentifiedorganizationTb.Location = new System.Drawing.Point(134, 92);
            this.AuthenticationIdentifiedorganizationTb.Name = "AuthenticationIdentifiedorganizationTb";
            this.AuthenticationIdentifiedorganizationTb.ReadOnly = true;
            this.AuthenticationIdentifiedorganizationTb.Size = new System.Drawing.Size(100, 20);
            this.AuthenticationIdentifiedorganizationTb.TabIndex = 50;
            // 
            // AuthenticationIdentifiedorganizationLbl
            // 
            this.AuthenticationIdentifiedorganizationLbl.AutoSize = true;
            this.AuthenticationIdentifiedorganizationLbl.Location = new System.Drawing.Point(13, 95);
            this.AuthenticationIdentifiedorganizationLbl.Name = "AuthenticationIdentifiedorganizationLbl";
            this.AuthenticationIdentifiedorganizationLbl.Size = new System.Drawing.Size(113, 13);
            this.AuthenticationIdentifiedorganizationLbl.TabIndex = 49;
            this.AuthenticationIdentifiedorganizationLbl.Text = "Identified organization:";
            // 
            // AuthenticationCountryNameTb
            // 
            this.AuthenticationCountryNameTb.Location = new System.Drawing.Point(134, 66);
            this.AuthenticationCountryNameTb.Name = "AuthenticationCountryNameTb";
            this.AuthenticationCountryNameTb.ReadOnly = true;
            this.AuthenticationCountryNameTb.Size = new System.Drawing.Size(100, 20);
            this.AuthenticationCountryNameTb.TabIndex = 48;
            // 
            // AuthenticationCountryNameLbl
            // 
            this.AuthenticationCountryNameLbl.AutoSize = true;
            this.AuthenticationCountryNameLbl.Location = new System.Drawing.Point(13, 69);
            this.AuthenticationCountryNameLbl.Name = "AuthenticationCountryNameLbl";
            this.AuthenticationCountryNameLbl.Size = new System.Drawing.Size(75, 13);
            this.AuthenticationCountryNameLbl.TabIndex = 47;
            this.AuthenticationCountryNameLbl.Text = "Country name:";
            // 
            // AuthenticationCountryTb
            // 
            this.AuthenticationCountryTb.Location = new System.Drawing.Point(134, 40);
            this.AuthenticationCountryTb.Name = "AuthenticationCountryTb";
            this.AuthenticationCountryTb.ReadOnly = true;
            this.AuthenticationCountryTb.Size = new System.Drawing.Size(100, 20);
            this.AuthenticationCountryTb.TabIndex = 46;
            // 
            // AuthenticationCountryLbl
            // 
            this.AuthenticationCountryLbl.AutoSize = true;
            this.AuthenticationCountryLbl.Location = new System.Drawing.Point(13, 43);
            this.AuthenticationCountryLbl.Name = "AuthenticationCountryLbl";
            this.AuthenticationCountryLbl.Size = new System.Drawing.Size(46, 13);
            this.AuthenticationCountryLbl.TabIndex = 45;
            this.AuthenticationCountryLbl.Text = "Country:";
            // 
            // AuthenticationJointISOCTTTb
            // 
            this.AuthenticationJointISOCTTTb.Location = new System.Drawing.Point(134, 14);
            this.AuthenticationJointISOCTTTb.Name = "AuthenticationJointISOCTTTb";
            this.AuthenticationJointISOCTTTb.ReadOnly = true;
            this.AuthenticationJointISOCTTTb.Size = new System.Drawing.Size(100, 20);
            this.AuthenticationJointISOCTTTb.TabIndex = 44;
            // 
            // AuthenticationJointISOCTTLbl
            // 
            this.AuthenticationJointISOCTTLbl.AutoSize = true;
            this.AuthenticationJointISOCTTLbl.Location = new System.Drawing.Point(13, 17);
            this.AuthenticationJointISOCTTLbl.Name = "AuthenticationJointISOCTTLbl";
            this.AuthenticationJointISOCTTLbl.Size = new System.Drawing.Size(77, 13);
            this.AuthenticationJointISOCTTLbl.TabIndex = 43;
            this.AuthenticationJointISOCTTLbl.Text = "Joint ISO CTT:";
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
            // gxValueField1
            // 
            this.gxValueField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField1.Index = 8;
            this.gxValueField1.Location = new System.Drawing.Point(114, 93);
            this.gxValueField1.Name = "gxValueField1";
            this.gxValueField1.Size = new System.Drawing.Size(243, 20);
            this.gxValueField1.TabIndex = 20;
            this.gxValueField1.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(420, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ObjectsMenu
            // 
            this.ObjectsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.ObjectsMenu.Name = "contextMenuStrip1";
            this.ObjectsMenu.Size = new System.Drawing.Size(153, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.ObjectAddBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.ObjectEditBtn_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.ObjectRemoveBtn_Click);
            // 
            // GXDLMSAssociationLogicalNameView
            // 
            this.ClientSize = new System.Drawing.Size(556, 348);
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ObjectsMenu.ResumeLayout(false);
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
        private TextBox textBox1;
        private TextBox ConformanceTB;
        private Label ConformanceLbl;
        private TextBox MaxSendPDUSizeTb;
        private Label MaxSendPDUSizeLbl;
        private TextBox MaxReceivePDUSizeTb;
        private Label MaxReceivePDUSizeLbl;
        private TextBox DLMSVersionNumberTB;
        private Label DLMSVersionNumberLbl;
        private TextBox CypheringInfoTb;
        private Label CypheringInfoLbl;
        private TextBox ApplicationContextIDTb;
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
        private TextBox AuthenticationMechanismIdTb;
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
        private Button ObjectRemoveBtn;
        private Button ObjectEditBtn;
        private Button ObjectAddBtn;
        private ContextMenuStrip ObjectsMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}
