using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSIECLocalPortSetupView
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
        private GXValueField DefaultModeTB;
        private Label DefaultModeLbl;
        private GXValueField LogicalNameTB;
        private GXValueField Password5TB;
        private Label Password5Lbl;
        private GXValueField Password2TB;
        private Label Password2Lbl;
        private GXValueField Password1TB;
        private Label Password1Lbl;
        private GXValueField DeviceAddressTB;
        private Label DeviceAddressLbl;
        private GXValueField ResponseTimeTB;
        private Label ResponseTimeLbl;
        private GXValueField MaximumBaudrateTB;
        private Label MaximumBaudrateLbl;
        private GXValueField DefaultBaudrateTB;
        private Label DefaultBaudrateLbl;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIECLocalPortSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Password5Lbl = new System.Windows.Forms.Label();
            this.Password2Lbl = new System.Windows.Forms.Label();
            this.Password1Lbl = new System.Windows.Forms.Label();
            this.DeviceAddressLbl = new System.Windows.Forms.Label();
            this.ResponseTimeLbl = new System.Windows.Forms.Label();
            this.MaximumBaudrateLbl = new System.Windows.Forms.Label();
            this.DefaultBaudrateLbl = new System.Windows.Forms.Label();
            this.DefaultModeLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password5TB = new Gurux.DLMS.UI.GXValueField();
            this.Password2TB = new Gurux.DLMS.UI.GXValueField();
            this.Password1TB = new Gurux.DLMS.UI.GXValueField();
            this.DeviceAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.ResponseTimeTB = new Gurux.DLMS.UI.GXValueField();
            this.MaximumBaudrateTB = new Gurux.DLMS.UI.GXValueField();
            this.DefaultBaudrateTB = new Gurux.DLMS.UI.GXValueField();
            this.DefaultModeTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Password5TB);
            this.groupBox1.Controls.Add(this.Password5Lbl);
            this.groupBox1.Controls.Add(this.Password2TB);
            this.groupBox1.Controls.Add(this.Password2Lbl);
            this.groupBox1.Controls.Add(this.Password1TB);
            this.groupBox1.Controls.Add(this.Password1Lbl);
            this.groupBox1.Controls.Add(this.DeviceAddressTB);
            this.groupBox1.Controls.Add(this.DeviceAddressLbl);
            this.groupBox1.Controls.Add(this.ResponseTimeTB);
            this.groupBox1.Controls.Add(this.ResponseTimeLbl);
            this.groupBox1.Controls.Add(this.MaximumBaudrateTB);
            this.groupBox1.Controls.Add(this.MaximumBaudrateLbl);
            this.groupBox1.Controls.Add(this.DefaultBaudrateTB);
            this.groupBox1.Controls.Add(this.DefaultBaudrateLbl);
            this.groupBox1.Controls.Add(this.DefaultModeTB);
            this.groupBox1.Controls.Add(this.DefaultModeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IEC Local Port Setup";
            // 
            // Password5Lbl
            // 
            this.Password5Lbl.AutoSize = true;
            this.Password5Lbl.Location = new System.Drawing.Point(6, 232);
            this.Password5Lbl.Name = "Password5Lbl";
            this.Password5Lbl.Size = new System.Drawing.Size(65, 13);
            this.Password5Lbl.TabIndex = 16;
            this.Password5Lbl.Text = "Password 5:";
            // 
            // Password2Lbl
            // 
            this.Password2Lbl.AutoSize = true;
            this.Password2Lbl.Location = new System.Drawing.Point(6, 206);
            this.Password2Lbl.Name = "Password2Lbl";
            this.Password2Lbl.Size = new System.Drawing.Size(65, 13);
            this.Password2Lbl.TabIndex = 14;
            this.Password2Lbl.Text = "Password 2:";
            // 
            // Password1Lbl
            // 
            this.Password1Lbl.AutoSize = true;
            this.Password1Lbl.Location = new System.Drawing.Point(6, 180);
            this.Password1Lbl.Name = "Password1Lbl";
            this.Password1Lbl.Size = new System.Drawing.Size(65, 13);
            this.Password1Lbl.TabIndex = 12;
            this.Password1Lbl.Text = "Password 1:";
            // 
            // DeviceAddressLbl
            // 
            this.DeviceAddressLbl.AutoSize = true;
            this.DeviceAddressLbl.Location = new System.Drawing.Point(6, 154);
            this.DeviceAddressLbl.Name = "DeviceAddressLbl";
            this.DeviceAddressLbl.Size = new System.Drawing.Size(85, 13);
            this.DeviceAddressLbl.TabIndex = 10;
            this.DeviceAddressLbl.Text = "Device Address:";
            // 
            // ResponseTimeLbl
            // 
            this.ResponseTimeLbl.AutoSize = true;
            this.ResponseTimeLbl.Location = new System.Drawing.Point(6, 128);
            this.ResponseTimeLbl.Name = "ResponseTimeLbl";
            this.ResponseTimeLbl.Size = new System.Drawing.Size(84, 13);
            this.ResponseTimeLbl.TabIndex = 8;
            this.ResponseTimeLbl.Text = "Response Time:";
            // 
            // MaximumBaudrateLbl
            // 
            this.MaximumBaudrateLbl.AutoSize = true;
            this.MaximumBaudrateLbl.Location = new System.Drawing.Point(6, 102);
            this.MaximumBaudrateLbl.Name = "MaximumBaudrateLbl";
            this.MaximumBaudrateLbl.Size = new System.Drawing.Size(100, 13);
            this.MaximumBaudrateLbl.TabIndex = 6;
            this.MaximumBaudrateLbl.Text = "Maximum Baudrate:";
            // 
            // DefaultBaudrateLbl
            // 
            this.DefaultBaudrateLbl.AutoSize = true;
            this.DefaultBaudrateLbl.Location = new System.Drawing.Point(6, 76);
            this.DefaultBaudrateLbl.Name = "DefaultBaudrateLbl";
            this.DefaultBaudrateLbl.Size = new System.Drawing.Size(90, 13);
            this.DefaultBaudrateLbl.TabIndex = 4;
            this.DefaultBaudrateLbl.Text = "Default Baudrate:";
            // 
            // DefaultModeLbl
            // 
            this.DefaultModeLbl.AutoSize = true;
            this.DefaultModeLbl.Location = new System.Drawing.Point(6, 50);
            this.DefaultModeLbl.Name = "DefaultModeLbl";
            this.DefaultModeLbl.Size = new System.Drawing.Size(74, 13);
            this.DefaultModeLbl.TabIndex = 2;
            this.DefaultModeLbl.Text = "Default Mode:";
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
            // Password5TB
            // 
            this.Password5TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password5TB.Index = 9;
            this.Password5TB.Location = new System.Drawing.Point(102, 229);
            this.Password5TB.Name = "Password5TB";
            this.Password5TB.NotifyChanges = false;
            this.Password5TB.Size = new System.Drawing.Size(208, 20);
            this.Password5TB.TabIndex = 8;
            this.Password5TB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // Password2TB
            // 
            this.Password2TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password2TB.Index = 8;
            this.Password2TB.Location = new System.Drawing.Point(102, 203);
            this.Password2TB.Name = "Password2TB";
            this.Password2TB.NotifyChanges = false;
            this.Password2TB.Size = new System.Drawing.Size(208, 20);
            this.Password2TB.TabIndex = 7;
            this.Password2TB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // Password1TB
            // 
            this.Password1TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Password1TB.Index = 7;
            this.Password1TB.Location = new System.Drawing.Point(102, 177);
            this.Password1TB.Name = "Password1TB";
            this.Password1TB.NotifyChanges = false;
            this.Password1TB.Size = new System.Drawing.Size(208, 20);
            this.Password1TB.TabIndex = 6;
            this.Password1TB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // DeviceAddressTB
            // 
            this.DeviceAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceAddressTB.Index = 6;
            this.DeviceAddressTB.Location = new System.Drawing.Point(102, 151);
            this.DeviceAddressTB.Name = "DeviceAddressTB";
            this.DeviceAddressTB.NotifyChanges = false;
            this.DeviceAddressTB.Size = new System.Drawing.Size(208, 20);
            this.DeviceAddressTB.TabIndex = 5;
            this.DeviceAddressTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ResponseTimeTB
            // 
            this.ResponseTimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseTimeTB.Index = 5;
            this.ResponseTimeTB.Location = new System.Drawing.Point(102, 125);
            this.ResponseTimeTB.Name = "ResponseTimeTB";
            this.ResponseTimeTB.NotifyChanges = false;
            this.ResponseTimeTB.Size = new System.Drawing.Size(208, 20);
            this.ResponseTimeTB.TabIndex = 4;
            this.ResponseTimeTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // MaximumBaudrateTB
            // 
            this.MaximumBaudrateTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximumBaudrateTB.Index = 4;
            this.MaximumBaudrateTB.Location = new System.Drawing.Point(102, 99);
            this.MaximumBaudrateTB.Name = "MaximumBaudrateTB";
            this.MaximumBaudrateTB.NotifyChanges = false;
            this.MaximumBaudrateTB.Size = new System.Drawing.Size(208, 20);
            this.MaximumBaudrateTB.TabIndex = 3;
            this.MaximumBaudrateTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // DefaultBaudrateTB
            // 
            this.DefaultBaudrateTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultBaudrateTB.Index = 3;
            this.DefaultBaudrateTB.Location = new System.Drawing.Point(102, 73);
            this.DefaultBaudrateTB.Name = "DefaultBaudrateTB";
            this.DefaultBaudrateTB.NotifyChanges = false;
            this.DefaultBaudrateTB.Size = new System.Drawing.Size(208, 20);
            this.DefaultBaudrateTB.TabIndex = 2;
            this.DefaultBaudrateTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // DefaultModeTB
            // 
            this.DefaultModeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultModeTB.Index = 2;
            this.DefaultModeTB.Location = new System.Drawing.Point(102, 47);
            this.DefaultModeTB.Name = "DefaultModeTB";
            this.DefaultModeTB.NotifyChanges = false;
            this.DefaultModeTB.Size = new System.Drawing.Size(208, 20);
            this.DefaultModeTB.TabIndex = 1;
            this.DefaultModeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
            this.LogicalNameTB.TabIndex = 0;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSIECLocalPortSetupView
            // 
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSIECLocalPortSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
