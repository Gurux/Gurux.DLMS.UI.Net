using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPrimeNbOfdmPlcApplicationsIdentificationView
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
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPrimeNbOfdmPlcApplicationsIdentificationView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FirmwareVersionTb = new Gurux.DLMS.UI.GXValueField();
            this.FirmwareVersionLbl = new System.Windows.Forms.Label();
            this.VendorIDTb = new Gurux.DLMS.UI.GXValueField();
            this.VendorIDLbl = new System.Windows.Forms.Label();
            this.ProductIDTb = new Gurux.DLMS.UI.GXValueField();
            this.ProductIDLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ProductIDTb);
            this.groupBox1.Controls.Add(this.ProductIDLbl);
            this.groupBox1.Controls.Add(this.VendorIDTb);
            this.groupBox1.Controls.Add(this.VendorIDLbl);
            this.groupBox1.Controls.Add(this.FirmwareVersionTb);
            this.groupBox1.Controls.Add(this.FirmwareVersionLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRIME NB OFDM PLC Application identification Object";
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
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // FirmwareVersionTb
            // 
            this.FirmwareVersionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirmwareVersionTb.Index = 2;
            this.FirmwareVersionTb.Location = new System.Drawing.Point(103, 71);
            this.FirmwareVersionTb.Name = "FirmwareVersionTb";
            this.FirmwareVersionTb.NotifyChanges = false;
            this.FirmwareVersionTb.Size = new System.Drawing.Size(171, 20);
            this.FirmwareVersionTb.TabIndex = 14;
            this.FirmwareVersionTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // FirmwareVersionLbl
            // 
            this.FirmwareVersionLbl.AutoSize = true;
            this.FirmwareVersionLbl.Location = new System.Drawing.Point(8, 74);
            this.FirmwareVersionLbl.Name = "FirmwareVersionLbl";
            this.FirmwareVersionLbl.Size = new System.Drawing.Size(90, 13);
            this.FirmwareVersionLbl.TabIndex = 13;
            this.FirmwareVersionLbl.Text = "Firmware Version:";
            // 
            // VendorIDTb
            // 
            this.VendorIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VendorIDTb.Index = 3;
            this.VendorIDTb.Location = new System.Drawing.Point(103, 97);
            this.VendorIDTb.Name = "VendorIDTb";
            this.VendorIDTb.NotifyChanges = false;
            this.VendorIDTb.Size = new System.Drawing.Size(171, 20);
            this.VendorIDTb.TabIndex = 16;
            this.VendorIDTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // VendorIDLbl
            // 
            this.VendorIDLbl.AutoSize = true;
            this.VendorIDLbl.Location = new System.Drawing.Point(8, 100);
            this.VendorIDLbl.Name = "VendorIDLbl";
            this.VendorIDLbl.Size = new System.Drawing.Size(58, 13);
            this.VendorIDLbl.TabIndex = 15;
            this.VendorIDLbl.Text = "Vendor ID:";
            // 
            // ProductIDTb
            // 
            this.ProductIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductIDTb.Index = 4;
            this.ProductIDTb.Location = new System.Drawing.Point(103, 123);
            this.ProductIDTb.Name = "ProductIDTb";
            this.ProductIDTb.NotifyChanges = false;
            this.ProductIDTb.Size = new System.Drawing.Size(171, 20);
            this.ProductIDTb.TabIndex = 18;
            this.ProductIDTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ProductIDLbl
            // 
            this.ProductIDLbl.AutoSize = true;
            this.ProductIDLbl.Location = new System.Drawing.Point(8, 126);
            this.ProductIDLbl.Name = "ProductIDLbl";
            this.ProductIDLbl.Size = new System.Drawing.Size(61, 13);
            this.ProductIDLbl.TabIndex = 17;
            this.ProductIDLbl.Text = "Product ID:";
            // 
            // GXDLMSPrimeNbOfdmPlcApplicationsIdentificationView
            // 
            this.ClientSize = new System.Drawing.Size(320, 182);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPrimeNbOfdmPlcApplicationsIdentificationView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField ProductIDTb;
        private Label ProductIDLbl;
        private GXValueField VendorIDTb;
        private Label VendorIDLbl;
        private GXValueField FirmwareVersionTb;
        private Label FirmwareVersionLbl;
    }
}
