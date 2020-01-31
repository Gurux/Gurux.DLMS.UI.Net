using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSIp6SetupView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private GroupBox groupBox1;
        private Label DataLinkLayerLbl;
        private GXValueField LogicalNameTB;
        private GXValueField DataLinkLayerTB;
        private GXValueField SecondaryDNSAddressTB;
        private Label SecondaryDNSAddressLbl;
        private GXValueField PrimaryDNSAddressTB;
        private Label PrimaryDNSAddressLbl;
        private GXValueField TrafficClassLblTB;
        private Label TrafficClassLbl;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIp6SetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoveAddressBtb = new Gurux.DLMS.UI.GXButton();
            this.AddAddressBtn = new Gurux.DLMS.UI.GXButton();
            this.AddressTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UnicastAddressView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MulticastAddressView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GatewayAddressView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DiscoverySetupView = new System.Windows.Forms.ListView();
            this.RSMaxRetryCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RSRetryWaitTimeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RASendPeriodCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddressConfigModeCb = new Gurux.DLMS.UI.GXValueField();
            this.AddressConfigModeLbl = new System.Windows.Forms.Label();
            this.SecondaryDNSAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.SecondaryDNSAddressLbl = new System.Windows.Forms.Label();
            this.PrimaryDNSAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.PrimaryDNSAddressLbl = new System.Windows.Forms.Label();
            this.TrafficClassLblTB = new Gurux.DLMS.UI.GXValueField();
            this.TrafficClassLbl = new System.Windows.Forms.Label();
            this.DataLinkLayerTB = new Gurux.DLMS.UI.GXValueField();
            this.DataLinkLayerLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.AddressTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RemoveAddressBtb);
            this.groupBox1.Controls.Add(this.AddAddressBtn);
            this.groupBox1.Controls.Add(this.AddressTab);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.AddressConfigModeCb);
            this.groupBox1.Controls.Add(this.AddressConfigModeLbl);
            this.groupBox1.Controls.Add(this.SecondaryDNSAddressTB);
            this.groupBox1.Controls.Add(this.SecondaryDNSAddressLbl);
            this.groupBox1.Controls.Add(this.PrimaryDNSAddressTB);
            this.groupBox1.Controls.Add(this.PrimaryDNSAddressLbl);
            this.groupBox1.Controls.Add(this.TrafficClassLblTB);
            this.groupBox1.Controls.Add(this.TrafficClassLbl);
            this.groupBox1.Controls.Add(this.DataLinkLayerTB);
            this.groupBox1.Controls.Add(this.DataLinkLayerLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ip6 Setup Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // RemoveAddressBtb
            // 
            this.RemoveAddressBtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveAddressBtb.Index = 2;
            this.RemoveAddressBtb.Location = new System.Drawing.Point(447, 155);
            this.RemoveAddressBtb.Name = "RemoveAddressBtb";
            this.RemoveAddressBtb.Size = new System.Drawing.Size(75, 23);
            this.RemoveAddressBtb.TabIndex = 26;
            this.RemoveAddressBtb.Text = "Remove...";
            this.RemoveAddressBtb.UseVisualStyleBackColor = true;
            // 
            // AddAddressBtn
            // 
            this.AddAddressBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAddressBtn.Index = 1;
            this.AddAddressBtn.Location = new System.Drawing.Point(447, 126);
            this.AddAddressBtn.Name = "AddAddressBtn";
            this.AddAddressBtn.Size = new System.Drawing.Size(75, 23);
            this.AddAddressBtn.TabIndex = 25;
            this.AddAddressBtn.Text = "Add...";
            this.AddAddressBtn.UseVisualStyleBackColor = true;
            // 
            // AddressTab
            // 
            this.AddressTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTab.Controls.Add(this.tabPage1);
            this.AddressTab.Controls.Add(this.tabPage2);
            this.AddressTab.Controls.Add(this.tabPage3);
            this.AddressTab.Location = new System.Drawing.Point(9, 101);
            this.AddressTab.Name = "AddressTab";
            this.AddressTab.SelectedIndex = 0;
            this.AddressTab.Size = new System.Drawing.Size(432, 124);
            this.AddressTab.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UnicastAddressView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 98);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unicast:";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UnicastAddressView
            // 
            this.UnicastAddressView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.UnicastAddressView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnicastAddressView.FullRowSelect = true;
            this.UnicastAddressView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UnicastAddressView.HideSelection = false;
            this.UnicastAddressView.Location = new System.Drawing.Point(3, 3);
            this.UnicastAddressView.Name = "UnicastAddressView";
            this.UnicastAddressView.Size = new System.Drawing.Size(418, 92);
            this.UnicastAddressView.TabIndex = 30;
            this.UnicastAddressView.UseCompatibleStateImageBehavior = false;
            this.UnicastAddressView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 285;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MulticastAddressView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 98);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multicast:";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MulticastAddressView
            // 
            this.MulticastAddressView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.MulticastAddressView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MulticastAddressView.FullRowSelect = true;
            this.MulticastAddressView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MulticastAddressView.HideSelection = false;
            this.MulticastAddressView.Location = new System.Drawing.Point(3, 3);
            this.MulticastAddressView.Name = "MulticastAddressView";
            this.MulticastAddressView.Size = new System.Drawing.Size(418, 92);
            this.MulticastAddressView.TabIndex = 20;
            this.MulticastAddressView.UseCompatibleStateImageBehavior = false;
            this.MulticastAddressView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Address";
            this.columnHeader2.Width = 285;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GatewayAddressView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(424, 98);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Gateway:";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GatewayAddressView
            // 
            this.GatewayAddressView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.GatewayAddressView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GatewayAddressView.FullRowSelect = true;
            this.GatewayAddressView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.GatewayAddressView.HideSelection = false;
            this.GatewayAddressView.Location = new System.Drawing.Point(3, 3);
            this.GatewayAddressView.Name = "GatewayAddressView";
            this.GatewayAddressView.Size = new System.Drawing.Size(418, 92);
            this.GatewayAddressView.TabIndex = 20;
            this.GatewayAddressView.UseCompatibleStateImageBehavior = false;
            this.GatewayAddressView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 286;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.RemoveBtn);
            this.groupBox2.Controls.Add(this.EditBtn);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Controls.Add(this.DiscoverySetupView);
            this.groupBox2.Location = new System.Drawing.Point(9, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(519, 199);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighbor Discovery Setup";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Location = new System.Drawing.Point(438, 170);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 23;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(357, 170);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Edit...";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(276, 170);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // DiscoverySetupView
            // 
            this.DiscoverySetupView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscoverySetupView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RSMaxRetryCh,
            this.RSRetryWaitTimeCh,
            this.RASendPeriodCh});
            this.DiscoverySetupView.FullRowSelect = true;
            this.DiscoverySetupView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DiscoverySetupView.HideSelection = false;
            this.DiscoverySetupView.Location = new System.Drawing.Point(6, 19);
            this.DiscoverySetupView.Name = "DiscoverySetupView";
            this.DiscoverySetupView.Size = new System.Drawing.Size(507, 145);
            this.DiscoverySetupView.TabIndex = 18;
            this.DiscoverySetupView.UseCompatibleStateImageBehavior = false;
            this.DiscoverySetupView.View = System.Windows.Forms.View.Details;
            // 
            // RSMaxRetryCh
            // 
            this.RSMaxRetryCh.Text = "RS Max Retry";
            this.RSMaxRetryCh.Width = 86;
            // 
            // RSRetryWaitTimeCh
            // 
            this.RSRetryWaitTimeCh.Text = "RS retry wait time";
            this.RSRetryWaitTimeCh.Width = 103;
            // 
            // RASendPeriodCh
            // 
            this.RASendPeriodCh.Text = "RA send period";
            this.RASendPeriodCh.Width = 94;
            // 
            // AddressConfigModeCb
            // 
            this.AddressConfigModeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressConfigModeCb.Index = 3;
            this.AddressConfigModeCb.Location = new System.Drawing.Point(136, 73);
            this.AddressConfigModeCb.Name = "AddressConfigModeCb";
            this.AddressConfigModeCb.NotifyChanges = false;
            this.AddressConfigModeCb.Size = new System.Drawing.Size(386, 20);
            this.AddressConfigModeCb.TabIndex = 2;
            this.AddressConfigModeCb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // AddressConfigModeLbl
            // 
            this.AddressConfigModeLbl.AutoSize = true;
            this.AddressConfigModeLbl.Location = new System.Drawing.Point(6, 76);
            this.AddressConfigModeLbl.Name = "AddressConfigModeLbl";
            this.AddressConfigModeLbl.Size = new System.Drawing.Size(109, 13);
            this.AddressConfigModeLbl.TabIndex = 20;
            this.AddressConfigModeLbl.Text = "Address config mode:";
            // 
            // SecondaryDNSAddressTB
            // 
            this.SecondaryDNSAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryDNSAddressTB.Index = 8;
            this.SecondaryDNSAddressTB.Location = new System.Drawing.Point(136, 257);
            this.SecondaryDNSAddressTB.Name = "SecondaryDNSAddressTB";
            this.SecondaryDNSAddressTB.NotifyChanges = false;
            this.SecondaryDNSAddressTB.Size = new System.Drawing.Size(386, 20);
            this.SecondaryDNSAddressTB.TabIndex = 7;
            this.SecondaryDNSAddressTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // SecondaryDNSAddressLbl
            // 
            this.SecondaryDNSAddressLbl.AutoSize = true;
            this.SecondaryDNSAddressLbl.Location = new System.Drawing.Point(6, 260);
            this.SecondaryDNSAddressLbl.Name = "SecondaryDNSAddressLbl";
            this.SecondaryDNSAddressLbl.Size = new System.Drawing.Size(128, 13);
            this.SecondaryDNSAddressLbl.TabIndex = 18;
            this.SecondaryDNSAddressLbl.Text = "Secondary DNS Address:";
            // 
            // PrimaryDNSAddressTB
            // 
            this.PrimaryDNSAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryDNSAddressTB.Index = 7;
            this.PrimaryDNSAddressTB.Location = new System.Drawing.Point(136, 231);
            this.PrimaryDNSAddressTB.Name = "PrimaryDNSAddressTB";
            this.PrimaryDNSAddressTB.NotifyChanges = false;
            this.PrimaryDNSAddressTB.Size = new System.Drawing.Size(386, 20);
            this.PrimaryDNSAddressTB.TabIndex = 6;
            this.PrimaryDNSAddressTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PrimaryDNSAddressLbl
            // 
            this.PrimaryDNSAddressLbl.AutoSize = true;
            this.PrimaryDNSAddressLbl.Location = new System.Drawing.Point(6, 234);
            this.PrimaryDNSAddressLbl.Name = "PrimaryDNSAddressLbl";
            this.PrimaryDNSAddressLbl.Size = new System.Drawing.Size(111, 13);
            this.PrimaryDNSAddressLbl.TabIndex = 16;
            this.PrimaryDNSAddressLbl.Text = "Primary DNS Address:";
            // 
            // TrafficClassLblTB
            // 
            this.TrafficClassLblTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficClassLblTB.Index = 9;
            this.TrafficClassLblTB.Location = new System.Drawing.Point(136, 283);
            this.TrafficClassLblTB.Name = "TrafficClassLblTB";
            this.TrafficClassLblTB.NotifyChanges = false;
            this.TrafficClassLblTB.Size = new System.Drawing.Size(386, 20);
            this.TrafficClassLblTB.TabIndex = 8;
            this.TrafficClassLblTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TrafficClassLbl
            // 
            this.TrafficClassLbl.AutoSize = true;
            this.TrafficClassLbl.Location = new System.Drawing.Point(6, 286);
            this.TrafficClassLbl.Name = "TrafficClassLbl";
            this.TrafficClassLbl.Size = new System.Drawing.Size(67, 13);
            this.TrafficClassLbl.TabIndex = 12;
            this.TrafficClassLbl.Text = "Traffic class:";
            // 
            // DataLinkLayerTB
            // 
            this.DataLinkLayerTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataLinkLayerTB.Index = 2;
            this.DataLinkLayerTB.Location = new System.Drawing.Point(136, 47);
            this.DataLinkLayerTB.Name = "DataLinkLayerTB";
            this.DataLinkLayerTB.NotifyChanges = false;
            this.DataLinkLayerTB.Size = new System.Drawing.Size(386, 20);
            this.DataLinkLayerTB.TabIndex = 1;
            this.DataLinkLayerTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // DataLinkLayerLbl
            // 
            this.DataLinkLayerLbl.AutoSize = true;
            this.DataLinkLayerLbl.Location = new System.Drawing.Point(6, 50);
            this.DataLinkLayerLbl.Name = "DataLinkLayerLbl";
            this.DataLinkLayerLbl.Size = new System.Drawing.Size(77, 13);
            this.DataLinkLayerLbl.TabIndex = 2;
            this.DataLinkLayerLbl.Text = "Data link layer:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(136, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(386, 20);
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
            // GXDLMSIp6SetupView
            // 
            this.ClientSize = new System.Drawing.Size(564, 539);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSIp6SetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AddressTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField AddressConfigModeCb;
        private Label AddressConfigModeLbl;
        private GroupBox groupBox2;
        private ListView DiscoverySetupView;
        private ColumnHeader RSMaxRetryCh;
        private ColumnHeader RSRetryWaitTimeCh;
        private ColumnHeader RASendPeriodCh;
        private Button RemoveBtn;
        private Button EditBtn;
        private Button AddBtn;
        private TabControl AddressTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView MulticastAddressView;
        private ColumnHeader columnHeader2;
        private TabPage tabPage3;
        private ListView GatewayAddressView;
        private ColumnHeader columnHeader3;
        private ListView UnicastAddressView;
        private ColumnHeader columnHeader1;
        private GXButton RemoveAddressBtb;
        private GXButton AddAddressBtn;
    }
}
