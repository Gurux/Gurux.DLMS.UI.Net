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
        private GXValueField GatewayAddressesTb;
        private Label GatewayAddressesLbl;
        private GXValueField MulticastIPAddressTB;
        private Label MulticastIPAddressLbl;
        private GXValueField UnicastIPAddressesTb;
        private Label UnicastIPAddressesLbl;
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
            this.SecondaryDNSAddressLbl = new System.Windows.Forms.Label();
            this.PrimaryDNSAddressLbl = new System.Windows.Forms.Label();
            this.TrafficClassLbl = new System.Windows.Forms.Label();
            this.GatewayAddressesLbl = new System.Windows.Forms.Label();
            this.MulticastIPAddressLbl = new System.Windows.Forms.Label();
            this.UnicastIPAddressesLbl = new System.Windows.Forms.Label();
            this.DataLinkLayerLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddressConfigModeLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DiscoverySetupView = new System.Windows.Forms.ListView();
            this.RSMaxRetryCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RSRetryWaitTimeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RASendPeriodCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.AddressConfigModeCb = new Gurux.DLMS.UI.GXValueField();
            this.SecondaryDNSAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.PrimaryDNSAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.TrafficClassLblTB = new Gurux.DLMS.UI.GXValueField();
            this.GatewayAddressesTb = new Gurux.DLMS.UI.GXValueField();
            this.MulticastIPAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.UnicastIPAddressesTb = new Gurux.DLMS.UI.GXValueField();
            this.DataLinkLayerTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.AddressConfigModeCb);
            this.groupBox1.Controls.Add(this.AddressConfigModeLbl);
            this.groupBox1.Controls.Add(this.SecondaryDNSAddressTB);
            this.groupBox1.Controls.Add(this.SecondaryDNSAddressLbl);
            this.groupBox1.Controls.Add(this.PrimaryDNSAddressTB);
            this.groupBox1.Controls.Add(this.PrimaryDNSAddressLbl);
            this.groupBox1.Controls.Add(this.TrafficClassLblTB);
            this.groupBox1.Controls.Add(this.TrafficClassLbl);
            this.groupBox1.Controls.Add(this.GatewayAddressesTb);
            this.groupBox1.Controls.Add(this.GatewayAddressesLbl);
            this.groupBox1.Controls.Add(this.MulticastIPAddressTB);
            this.groupBox1.Controls.Add(this.MulticastIPAddressLbl);
            this.groupBox1.Controls.Add(this.UnicastIPAddressesTb);
            this.groupBox1.Controls.Add(this.UnicastIPAddressesLbl);
            this.groupBox1.Controls.Add(this.DataLinkLayerTB);
            this.groupBox1.Controls.Add(this.DataLinkLayerLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 515);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ip6 Setup Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // SecondaryDNSAddressLbl
            // 
            this.SecondaryDNSAddressLbl.AutoSize = true;
            this.SecondaryDNSAddressLbl.Location = new System.Drawing.Point(6, 210);
            this.SecondaryDNSAddressLbl.Name = "SecondaryDNSAddressLbl";
            this.SecondaryDNSAddressLbl.Size = new System.Drawing.Size(128, 13);
            this.SecondaryDNSAddressLbl.TabIndex = 18;
            this.SecondaryDNSAddressLbl.Text = "Secondary DNS Address:";
            // 
            // PrimaryDNSAddressLbl
            // 
            this.PrimaryDNSAddressLbl.AutoSize = true;
            this.PrimaryDNSAddressLbl.Location = new System.Drawing.Point(6, 184);
            this.PrimaryDNSAddressLbl.Name = "PrimaryDNSAddressLbl";
            this.PrimaryDNSAddressLbl.Size = new System.Drawing.Size(111, 13);
            this.PrimaryDNSAddressLbl.TabIndex = 16;
            this.PrimaryDNSAddressLbl.Text = "Primary DNS Address:";
            // 
            // TrafficClassLbl
            // 
            this.TrafficClassLbl.AutoSize = true;
            this.TrafficClassLbl.Location = new System.Drawing.Point(6, 236);
            this.TrafficClassLbl.Name = "TrafficClassLbl";
            this.TrafficClassLbl.Size = new System.Drawing.Size(67, 13);
            this.TrafficClassLbl.TabIndex = 12;
            this.TrafficClassLbl.Text = "Traffic class:";
            // 
            // GatewayAddressesLbl
            // 
            this.GatewayAddressesLbl.AutoSize = true;
            this.GatewayAddressesLbl.Location = new System.Drawing.Point(6, 158);
            this.GatewayAddressesLbl.Name = "GatewayAddressesLbl";
            this.GatewayAddressesLbl.Size = new System.Drawing.Size(104, 13);
            this.GatewayAddressesLbl.TabIndex = 8;
            this.GatewayAddressesLbl.Text = "Gateway Addresses:";
            // 
            // MulticastIPAddressLbl
            // 
            this.MulticastIPAddressLbl.AutoSize = true;
            this.MulticastIPAddressLbl.Location = new System.Drawing.Point(6, 132);
            this.MulticastIPAddressLbl.Name = "MulticastIPAddressLbl";
            this.MulticastIPAddressLbl.Size = new System.Drawing.Size(117, 13);
            this.MulticastIPAddressLbl.TabIndex = 6;
            this.MulticastIPAddressLbl.Text = "Multicast IP Addresses:";
            // 
            // UnicastIPAddressesLbl
            // 
            this.UnicastIPAddressesLbl.AutoSize = true;
            this.UnicastIPAddressesLbl.Location = new System.Drawing.Point(6, 106);
            this.UnicastIPAddressesLbl.Name = "UnicastIPAddressesLbl";
            this.UnicastIPAddressesLbl.Size = new System.Drawing.Size(111, 13);
            this.UnicastIPAddressesLbl.TabIndex = 4;
            this.UnicastIPAddressesLbl.Text = "Unicast IP Addresses:";
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
            // AddressConfigModeLbl
            // 
            this.AddressConfigModeLbl.AutoSize = true;
            this.AddressConfigModeLbl.Location = new System.Drawing.Point(6, 76);
            this.AddressConfigModeLbl.Name = "AddressConfigModeLbl";
            this.AddressConfigModeLbl.Size = new System.Drawing.Size(109, 13);
            this.AddressConfigModeLbl.TabIndex = 20;
            this.AddressConfigModeLbl.Text = "Address config mode:";
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
            this.groupBox2.Location = new System.Drawing.Point(9, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 250);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighbor Discovery Setup";
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
            this.DiscoverySetupView.Size = new System.Drawing.Size(315, 196);
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
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Location = new System.Drawing.Point(246, 221);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 23;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(165, 221);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Edit...";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(84, 221);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // AddressConfigModeCb
            // 
            this.AddressConfigModeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressConfigModeCb.Index = 3;
            this.AddressConfigModeCb.Location = new System.Drawing.Point(136, 73);
            this.AddressConfigModeCb.Name = "AddressConfigModeCb";
            this.AddressConfigModeCb.NotifyChanges = false;
            this.AddressConfigModeCb.ReadOnly = true;
            this.AddressConfigModeCb.Size = new System.Drawing.Size(206, 20);
            this.AddressConfigModeCb.TabIndex = 2;
            this.AddressConfigModeCb.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // SecondaryDNSAddressTB
            // 
            this.SecondaryDNSAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryDNSAddressTB.Index = 8;
            this.SecondaryDNSAddressTB.Location = new System.Drawing.Point(136, 207);
            this.SecondaryDNSAddressTB.Name = "SecondaryDNSAddressTB";
            this.SecondaryDNSAddressTB.NotifyChanges = false;
            this.SecondaryDNSAddressTB.Size = new System.Drawing.Size(206, 20);
            this.SecondaryDNSAddressTB.TabIndex = 7;
            this.SecondaryDNSAddressTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // PrimaryDNSAddressTB
            // 
            this.PrimaryDNSAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryDNSAddressTB.Index = 7;
            this.PrimaryDNSAddressTB.Location = new System.Drawing.Point(136, 181);
            this.PrimaryDNSAddressTB.Name = "PrimaryDNSAddressTB";
            this.PrimaryDNSAddressTB.NotifyChanges = false;
            this.PrimaryDNSAddressTB.Size = new System.Drawing.Size(206, 20);
            this.PrimaryDNSAddressTB.TabIndex = 6;
            this.PrimaryDNSAddressTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // TrafficClassLblTB
            // 
            this.TrafficClassLblTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TrafficClassLblTB.Index = 9;
            this.TrafficClassLblTB.Location = new System.Drawing.Point(136, 233);
            this.TrafficClassLblTB.Name = "TrafficClassLblTB";
            this.TrafficClassLblTB.NotifyChanges = false;
            this.TrafficClassLblTB.Size = new System.Drawing.Size(206, 20);
            this.TrafficClassLblTB.TabIndex = 8;
            this.TrafficClassLblTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // GatewayAddressesTb
            // 
            this.GatewayAddressesTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GatewayAddressesTb.Index = 6;
            this.GatewayAddressesTb.Location = new System.Drawing.Point(136, 155);
            this.GatewayAddressesTb.Name = "GatewayAddressesTb";
            this.GatewayAddressesTb.NotifyChanges = false;
            this.GatewayAddressesTb.Size = new System.Drawing.Size(206, 20);
            this.GatewayAddressesTb.TabIndex = 5;
            this.GatewayAddressesTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // MulticastIPAddressTB
            // 
            this.MulticastIPAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MulticastIPAddressTB.Index = 5;
            this.MulticastIPAddressTB.Location = new System.Drawing.Point(136, 129);
            this.MulticastIPAddressTB.Name = "MulticastIPAddressTB";
            this.MulticastIPAddressTB.NotifyChanges = false;
            this.MulticastIPAddressTB.Size = new System.Drawing.Size(206, 20);
            this.MulticastIPAddressTB.TabIndex = 4;
            this.MulticastIPAddressTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // UnicastIPAddressesTb
            // 
            this.UnicastIPAddressesTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnicastIPAddressesTb.Index = 4;
            this.UnicastIPAddressesTb.Location = new System.Drawing.Point(136, 103);
            this.UnicastIPAddressesTb.Name = "UnicastIPAddressesTb";
            this.UnicastIPAddressesTb.NotifyChanges = false;
            this.UnicastIPAddressesTb.Size = new System.Drawing.Size(206, 20);
            this.UnicastIPAddressesTb.TabIndex = 3;
            this.UnicastIPAddressesTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // DataLinkLayerTB
            // 
            this.DataLinkLayerTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataLinkLayerTB.Index = 2;
            this.DataLinkLayerTB.Location = new System.Drawing.Point(136, 47);
            this.DataLinkLayerTB.Name = "DataLinkLayerTB";
            this.DataLinkLayerTB.NotifyChanges = false;
            this.DataLinkLayerTB.Size = new System.Drawing.Size(206, 20);
            this.DataLinkLayerTB.TabIndex = 1;
            this.DataLinkLayerTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(136, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(206, 20);
            this.LogicalNameTB.TabIndex = 0;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // GXDLMSIp6SetupView
            // 
            this.ClientSize = new System.Drawing.Size(372, 539);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSIp6SetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
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
    }
}
