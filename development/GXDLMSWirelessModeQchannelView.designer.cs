using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSWirelessModeQchannelView
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
        private GXValueField AddressStateTb;
        private Label AddressStateLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSWirelessModeQchannelView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.AddressStateTb = new Gurux.DLMS.UI.GXValueField();
            this.AddressStateLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DeviceAddressTb = new Gurux.DLMS.UI.GXValueField();
            this.DeviceAddressLbl = new System.Windows.Forms.Label();
            this.AddressMaskTb = new Gurux.DLMS.UI.GXValueField();
            this.AddressMaskLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddressMaskTb);
            this.groupBox1.Controls.Add(this.AddressMaskLbl);
            this.groupBox1.Controls.Add(this.DeviceAddressTb);
            this.groupBox1.Controls.Add(this.DeviceAddressLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.AddressStateTb);
            this.groupBox1.Controls.Add(this.AddressStateLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wireless Mode Q channel";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 5;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(103, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(172, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // AddressStateTb
            // 
            this.AddressStateTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressStateTb.Index = 2;
            this.AddressStateTb.Location = new System.Drawing.Point(104, 71);
            this.AddressStateTb.Name = "AddressStateTb";
            this.AddressStateTb.NotifyChanges = false;
            this.AddressStateTb.Size = new System.Drawing.Size(171, 57);
            this.AddressStateTb.TabIndex = 0;
            this.AddressStateTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            this.AddressStateTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.AddressStateTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // AddressStateLbl
            // 
            this.AddressStateLbl.AutoSize = true;
            this.AddressStateLbl.Location = new System.Drawing.Point(7, 74);
            this.AddressStateLbl.Name = "AddressStateLbl";
            this.AddressStateLbl.Size = new System.Drawing.Size(76, 13);
            this.AddressStateLbl.TabIndex = 2;
            this.AddressStateLbl.Text = "Address State:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(171, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(7, 48);
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
            // DeviceAddressTb
            // 
            this.DeviceAddressTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceAddressTb.Index = 3;
            this.DeviceAddressTb.Location = new System.Drawing.Point(104, 98);
            this.DeviceAddressTb.Name = "DeviceAddressTb";
            this.DeviceAddressTb.NotifyChanges = false;
            this.DeviceAddressTb.Size = new System.Drawing.Size(171, 20);
            this.DeviceAddressTb.TabIndex = 7;
            this.DeviceAddressTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // DeviceAddressLbl
            // 
            this.DeviceAddressLbl.AutoSize = true;
            this.DeviceAddressLbl.Location = new System.Drawing.Point(8, 101);
            this.DeviceAddressLbl.Name = "DeviceAddressLbl";
            this.DeviceAddressLbl.Size = new System.Drawing.Size(85, 13);
            this.DeviceAddressLbl.TabIndex = 6;
            this.DeviceAddressLbl.Text = "Device Address:";
            // 
            // AddressMaskTb
            // 
            this.AddressMaskTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressMaskTb.Index = 4;
            this.AddressMaskTb.Location = new System.Drawing.Point(104, 124);
            this.AddressMaskTb.Name = "AddressMaskTb";
            this.AddressMaskTb.NotifyChanges = false;
            this.AddressMaskTb.Size = new System.Drawing.Size(171, 20);
            this.AddressMaskTb.TabIndex = 9;
            this.AddressMaskTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // AddressMaskLbl
            // 
            this.AddressMaskLbl.AutoSize = true;
            this.AddressMaskLbl.Location = new System.Drawing.Point(8, 127);
            this.AddressMaskLbl.Name = "AddressMaskLbl";
            this.AddressMaskLbl.Size = new System.Drawing.Size(77, 13);
            this.AddressMaskLbl.TabIndex = 8;
            this.AddressMaskLbl.Text = "Address Mask:";
            // 
            // GXDLMSWirelessModeQchannelView
            // 
            this.ClientSize = new System.Drawing.Size(320, 226);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSWirelessModeQchannelView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField AddressMaskTb;
        private Label AddressMaskLbl;
        private GXValueField DeviceAddressTb;
        private Label DeviceAddressLbl;
    }
}
