using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPrimeNbOfdmPlcMacCountersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPrimeNbOfdmPlcMacCountersView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TXDataPacketCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.TXDataPacketCounterLbl = new System.Windows.Forms.Label();
            this.RXDataPacketCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.RXDataPacketCounterLbl = new System.Windows.Forms.Label();
            this.TXCtrlPacketCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.TXCtrlPacketCounterLbl = new System.Windows.Forms.Label();
            this.RXCtrlPacketCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.RXCtrlPacketCounterLbl = new System.Windows.Forms.Label();
            this.CSMAFailCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.CSMAFailCounterLbl = new System.Windows.Forms.Label();
            this.CSMABusyCounterTb = new Gurux.DLMS.UI.GXValueField();
            this.CSMABusyCounterLbl = new System.Windows.Forms.Label();
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.CSMABusyCounterTb);
            this.groupBox1.Controls.Add(this.CSMABusyCounterLbl);
            this.groupBox1.Controls.Add(this.CSMAFailCounterTb);
            this.groupBox1.Controls.Add(this.CSMAFailCounterLbl);
            this.groupBox1.Controls.Add(this.RXCtrlPacketCounterTb);
            this.groupBox1.Controls.Add(this.RXCtrlPacketCounterLbl);
            this.groupBox1.Controls.Add(this.TXCtrlPacketCounterTb);
            this.groupBox1.Controls.Add(this.TXCtrlPacketCounterLbl);
            this.groupBox1.Controls.Add(this.RXDataPacketCounterTb);
            this.groupBox1.Controls.Add(this.RXDataPacketCounterLbl);
            this.groupBox1.Controls.Add(this.TXDataPacketCounterTb);
            this.groupBox1.Controls.Add(this.TXDataPacketCounterLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRIME NB OFDM PLC MAC counters Object";
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
            // TXDataPacketCounterTb
            // 
            this.TXDataPacketCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXDataPacketCounterTb.Index = 2;
            this.TXDataPacketCounterTb.Location = new System.Drawing.Point(140, 71);
            this.TXDataPacketCounterTb.Name = "TXDataPacketCounterTb";
            this.TXDataPacketCounterTb.NotifyChanges = false;
            this.TXDataPacketCounterTb.Size = new System.Drawing.Size(134, 20);
            this.TXDataPacketCounterTb.TabIndex = 12;
            this.TXDataPacketCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.TXDataPacketCounterTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.TXDataPacketCounterTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // TXDataPacketCounterLbl
            // 
            this.TXDataPacketCounterLbl.AutoSize = true;
            this.TXDataPacketCounterLbl.Location = new System.Drawing.Point(7, 74);
            this.TXDataPacketCounterLbl.Name = "TXDataPacketCounterLbl";
            this.TXDataPacketCounterLbl.Size = new System.Drawing.Size(127, 13);
            this.TXDataPacketCounterLbl.TabIndex = 11;
            this.TXDataPacketCounterLbl.Text = "TX Data Packet Counter:";
            // 
            // RXDataPacketCounterTb
            // 
            this.RXDataPacketCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RXDataPacketCounterTb.Index = 3;
            this.RXDataPacketCounterTb.Location = new System.Drawing.Point(140, 97);
            this.RXDataPacketCounterTb.Name = "RXDataPacketCounterTb";
            this.RXDataPacketCounterTb.NotifyChanges = false;
            this.RXDataPacketCounterTb.Size = new System.Drawing.Size(134, 20);
            this.RXDataPacketCounterTb.TabIndex = 14;
            this.RXDataPacketCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.RXDataPacketCounterTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.RXDataPacketCounterTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // RXDataPacketCounterLbl
            // 
            this.RXDataPacketCounterLbl.AutoSize = true;
            this.RXDataPacketCounterLbl.Location = new System.Drawing.Point(7, 100);
            this.RXDataPacketCounterLbl.Name = "RXDataPacketCounterLbl";
            this.RXDataPacketCounterLbl.Size = new System.Drawing.Size(128, 13);
            this.RXDataPacketCounterLbl.TabIndex = 13;
            this.RXDataPacketCounterLbl.Text = "RX Data Packet Counter:";
            // 
            // TXCtrlPacketCounterTb
            // 
            this.TXCtrlPacketCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXCtrlPacketCounterTb.Index = 4;
            this.TXCtrlPacketCounterTb.Location = new System.Drawing.Point(141, 123);
            this.TXCtrlPacketCounterTb.Name = "TXCtrlPacketCounterTb";
            this.TXCtrlPacketCounterTb.NotifyChanges = false;
            this.TXCtrlPacketCounterTb.Size = new System.Drawing.Size(134, 20);
            this.TXCtrlPacketCounterTb.TabIndex = 16;
            this.TXCtrlPacketCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.TXCtrlPacketCounterTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.TXCtrlPacketCounterTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // TXCtrlPacketCounterLbl
            // 
            this.TXCtrlPacketCounterLbl.AutoSize = true;
            this.TXCtrlPacketCounterLbl.Location = new System.Drawing.Point(8, 126);
            this.TXCtrlPacketCounterLbl.Name = "TXCtrlPacketCounterLbl";
            this.TXCtrlPacketCounterLbl.Size = new System.Drawing.Size(119, 13);
            this.TXCtrlPacketCounterLbl.TabIndex = 15;
            this.TXCtrlPacketCounterLbl.Text = "TX Ctrl Packet Counter:";
            // 
            // RXCtrlPacketCounterTb
            // 
            this.RXCtrlPacketCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RXCtrlPacketCounterTb.Index = 5;
            this.RXCtrlPacketCounterTb.Location = new System.Drawing.Point(141, 149);
            this.RXCtrlPacketCounterTb.Name = "RXCtrlPacketCounterTb";
            this.RXCtrlPacketCounterTb.NotifyChanges = false;
            this.RXCtrlPacketCounterTb.Size = new System.Drawing.Size(134, 20);
            this.RXCtrlPacketCounterTb.TabIndex = 18;
            this.RXCtrlPacketCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.RXCtrlPacketCounterTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.RXCtrlPacketCounterTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // RXCtrlPacketCounterLbl
            // 
            this.RXCtrlPacketCounterLbl.AutoSize = true;
            this.RXCtrlPacketCounterLbl.Location = new System.Drawing.Point(8, 152);
            this.RXCtrlPacketCounterLbl.Name = "RXCtrlPacketCounterLbl";
            this.RXCtrlPacketCounterLbl.Size = new System.Drawing.Size(120, 13);
            this.RXCtrlPacketCounterLbl.TabIndex = 17;
            this.RXCtrlPacketCounterLbl.Text = "RX Ctrl Packet Counter:";
            // 
            // CSMAFailCounterTb
            // 
            this.CSMAFailCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CSMAFailCounterTb.Index = 6;
            this.CSMAFailCounterTb.Location = new System.Drawing.Point(141, 175);
            this.CSMAFailCounterTb.Name = "CSMAFailCounterTb";
            this.CSMAFailCounterTb.NotifyChanges = false;
            this.CSMAFailCounterTb.Size = new System.Drawing.Size(134, 20);
            this.CSMAFailCounterTb.TabIndex = 20;
            this.CSMAFailCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CSMAFailCounterTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CSMAFailCounterTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CSMAFailCounterLbl
            // 
            this.CSMAFailCounterLbl.AutoSize = true;
            this.CSMAFailCounterLbl.Location = new System.Drawing.Point(8, 178);
            this.CSMAFailCounterLbl.Name = "CSMAFailCounterLbl";
            this.CSMAFailCounterLbl.Size = new System.Drawing.Size(99, 13);
            this.CSMAFailCounterLbl.TabIndex = 19;
            this.CSMAFailCounterLbl.Text = "CSMA Fail Counter:";
            // 
            // CSMABusyCounterTb
            // 
            this.CSMABusyCounterTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CSMABusyCounterTb.Index = 7;
            this.CSMABusyCounterTb.Location = new System.Drawing.Point(141, 201);
            this.CSMABusyCounterTb.Name = "CSMABusyCounterTb";
            this.CSMABusyCounterTb.NotifyChanges = false;
            this.CSMABusyCounterTb.Size = new System.Drawing.Size(134, 20);
            this.CSMABusyCounterTb.TabIndex = 22;
            this.CSMABusyCounterTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CSMABusyCounterTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CSMABusyCounterTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CSMABusyCounterLbl
            // 
            this.CSMABusyCounterLbl.AutoSize = true;
            this.CSMABusyCounterLbl.Location = new System.Drawing.Point(8, 204);
            this.CSMABusyCounterLbl.Name = "CSMABusyCounterLbl";
            this.CSMABusyCounterLbl.Size = new System.Drawing.Size(106, 13);
            this.CSMABusyCounterLbl.TabIndex = 21;
            this.CSMABusyCounterLbl.Text = "CSMA Busy Counter:";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 1;
            this.ResetBtn.Location = new System.Drawing.Point(199, 227);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 23;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // GXDLMSPrimeNbOfdmPlcMacCountersView
            // 
            this.ClientSize = new System.Drawing.Size(320, 289);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPrimeNbOfdmPlcMacCountersView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField CSMABusyCounterTb;
        private Label CSMABusyCounterLbl;
        private GXValueField CSMAFailCounterTb;
        private Label CSMAFailCounterLbl;
        private GXValueField RXCtrlPacketCounterTb;
        private Label RXCtrlPacketCounterLbl;
        private GXValueField TXCtrlPacketCounterTb;
        private Label TXCtrlPacketCounterLbl;
        private GXValueField RXDataPacketCounterTb;
        private Label RXDataPacketCounterLbl;
        private GXValueField TXDataPacketCounterTb;
        private Label TXDataPacketCounterLbl;
        private GXButton ResetBtn;
    }
}
