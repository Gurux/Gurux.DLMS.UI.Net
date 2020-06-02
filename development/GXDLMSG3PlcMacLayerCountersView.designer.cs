using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSG3PlcMacLayerCountersView
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
        private GXValueField TxDataPacketCountTB;
        private Label TxDataPacketCountLbl;
        private GXValueField LogicalNameTB;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSG3PlcMacLayerCountersView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.RxDataBroadcastCountTB = new Gurux.DLMS.UI.GXValueField();
            this.RxDataBroadcastCountLbl = new System.Windows.Forms.Label();
            this.TxDataBroadcastCountTB = new Gurux.DLMS.UI.GXValueField();
            this.TxDataBroadcastCountLbl = new System.Windows.Forms.Label();
            this.BadCrcCountTB = new Gurux.DLMS.UI.GXValueField();
            this.BadCrcCountLbl = new System.Windows.Forms.Label();
            this.CSMANoAckCountTB = new Gurux.DLMS.UI.GXValueField();
            this.CSMANoAckCountLbl = new System.Windows.Forms.Label();
            this.CSMAFailCountTB = new Gurux.DLMS.UI.GXValueField();
            this.CSMAFailCountLbl = new System.Windows.Forms.Label();
            this.RxCmdPacketCountTB = new Gurux.DLMS.UI.GXValueField();
            this.RxCmdPacketCountLbl = new System.Windows.Forms.Label();
            this.TxCmdPacketCountTB = new Gurux.DLMS.UI.GXValueField();
            this.TxCmdPacketCountLbl = new System.Windows.Forms.Label();
            this.RxDataPacketCountTB = new Gurux.DLMS.UI.GXValueField();
            this.RxDataPacketCountLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.TxDataPacketCountTB = new Gurux.DLMS.UI.GXValueField();
            this.TxDataPacketCountLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.RxDataBroadcastCountTB);
            this.groupBox1.Controls.Add(this.RxDataBroadcastCountLbl);
            this.groupBox1.Controls.Add(this.TxDataBroadcastCountTB);
            this.groupBox1.Controls.Add(this.TxDataBroadcastCountLbl);
            this.groupBox1.Controls.Add(this.BadCrcCountTB);
            this.groupBox1.Controls.Add(this.BadCrcCountLbl);
            this.groupBox1.Controls.Add(this.CSMANoAckCountTB);
            this.groupBox1.Controls.Add(this.CSMANoAckCountLbl);
            this.groupBox1.Controls.Add(this.CSMAFailCountTB);
            this.groupBox1.Controls.Add(this.CSMAFailCountLbl);
            this.groupBox1.Controls.Add(this.RxCmdPacketCountTB);
            this.groupBox1.Controls.Add(this.RxCmdPacketCountLbl);
            this.groupBox1.Controls.Add(this.TxCmdPacketCountTB);
            this.groupBox1.Controls.Add(this.TxCmdPacketCountLbl);
            this.groupBox1.Controls.Add(this.RxDataPacketCountTB);
            this.groupBox1.Controls.Add(this.RxDataPacketCountLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.TxDataPacketCountTB);
            this.groupBox1.Controls.Add(this.TxDataPacketCountLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "G3 PLC MAC layer counters Object";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 1;
            this.ResetBtn.Location = new System.Drawing.Point(375, 216);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 25;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // RxDataBroadcastCountTB
            // 
            this.RxDataBroadcastCountTB.Index = 10;
            this.RxDataBroadcastCountTB.Location = new System.Drawing.Point(347, 178);
            this.RxDataBroadcastCountTB.Name = "RxDataBroadcastCountTB";
            this.RxDataBroadcastCountTB.NotifyChanges = false;
            this.RxDataBroadcastCountTB.ReadOnly = true;
            this.RxDataBroadcastCountTB.Size = new System.Drawing.Size(104, 20);
            this.RxDataBroadcastCountTB.TabIndex = 20;
            this.RxDataBroadcastCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // RxDataBroadcastCountLbl
            // 
            this.RxDataBroadcastCountLbl.AutoSize = true;
            this.RxDataBroadcastCountLbl.Location = new System.Drawing.Point(235, 185);
            this.RxDataBroadcastCountLbl.Name = "RxDataBroadcastCountLbl";
            this.RxDataBroadcastCountLbl.Size = new System.Drawing.Size(105, 13);
            this.RxDataBroadcastCountLbl.TabIndex = 21;
            this.RxDataBroadcastCountLbl.Text = "Rx Data Broadcasts:";
            // 
            // TxDataBroadcastCountTB
            // 
            this.TxDataBroadcastCountTB.Index = 9;
            this.TxDataBroadcastCountTB.Location = new System.Drawing.Point(347, 152);
            this.TxDataBroadcastCountTB.Name = "TxDataBroadcastCountTB";
            this.TxDataBroadcastCountTB.NotifyChanges = false;
            this.TxDataBroadcastCountTB.ReadOnly = true;
            this.TxDataBroadcastCountTB.Size = new System.Drawing.Size(104, 20);
            this.TxDataBroadcastCountTB.TabIndex = 18;
            this.TxDataBroadcastCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TxDataBroadcastCountLbl
            // 
            this.TxDataBroadcastCountLbl.AutoSize = true;
            this.TxDataBroadcastCountLbl.Location = new System.Drawing.Point(236, 156);
            this.TxDataBroadcastCountLbl.Name = "TxDataBroadcastCountLbl";
            this.TxDataBroadcastCountLbl.Size = new System.Drawing.Size(104, 13);
            this.TxDataBroadcastCountLbl.TabIndex = 19;
            this.TxDataBroadcastCountLbl.Text = "Tx Data Broadcasts:";
            // 
            // BadCrcCountTB
            // 
            this.BadCrcCountTB.Index = 8;
            this.BadCrcCountTB.Location = new System.Drawing.Point(105, 149);
            this.BadCrcCountTB.Name = "BadCrcCountTB";
            this.BadCrcCountTB.NotifyChanges = false;
            this.BadCrcCountTB.ReadOnly = true;
            this.BadCrcCountTB.Size = new System.Drawing.Size(104, 20);
            this.BadCrcCountTB.TabIndex = 16;
            this.BadCrcCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // BadCrcCountLbl
            // 
            this.BadCrcCountLbl.AutoSize = true;
            this.BadCrcCountLbl.Location = new System.Drawing.Point(8, 152);
            this.BadCrcCountLbl.Name = "BadCrcCountLbl";
            this.BadCrcCountLbl.Size = new System.Drawing.Size(59, 13);
            this.BadCrcCountLbl.TabIndex = 17;
            this.BadCrcCountLbl.Text = "Bad CRCs:";
            // 
            // CSMANoAckCountTB
            // 
            this.CSMANoAckCountTB.Index = 7;
            this.CSMANoAckCountTB.Location = new System.Drawing.Point(347, 126);
            this.CSMANoAckCountTB.Name = "CSMANoAckCountTB";
            this.CSMANoAckCountTB.NotifyChanges = false;
            this.CSMANoAckCountTB.ReadOnly = true;
            this.CSMANoAckCountTB.Size = new System.Drawing.Size(104, 20);
            this.CSMANoAckCountTB.TabIndex = 14;
            this.CSMANoAckCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // CSMANoAckCountLbl
            // 
            this.CSMANoAckCountLbl.AutoSize = true;
            this.CSMANoAckCountLbl.Location = new System.Drawing.Point(236, 130);
            this.CSMANoAckCountLbl.Name = "CSMANoAckCountLbl";
            this.CSMANoAckCountLbl.Size = new System.Drawing.Size(84, 13);
            this.CSMANoAckCountLbl.TabIndex = 15;
            this.CSMANoAckCountLbl.Text = "CSMA No Acks:";
            // 
            // CSMAFailCountTB
            // 
            this.CSMAFailCountTB.Index = 6;
            this.CSMAFailCountTB.Location = new System.Drawing.Point(105, 123);
            this.CSMAFailCountTB.Name = "CSMAFailCountTB";
            this.CSMAFailCountTB.NotifyChanges = false;
            this.CSMAFailCountTB.ReadOnly = true;
            this.CSMAFailCountTB.Size = new System.Drawing.Size(104, 20);
            this.CSMAFailCountTB.TabIndex = 12;
            this.CSMAFailCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // CSMAFailCountLbl
            // 
            this.CSMAFailCountLbl.AutoSize = true;
            this.CSMAFailCountLbl.Location = new System.Drawing.Point(8, 126);
            this.CSMAFailCountLbl.Name = "CSMAFailCountLbl";
            this.CSMAFailCountLbl.Size = new System.Drawing.Size(64, 13);
            this.CSMAFailCountLbl.TabIndex = 13;
            this.CSMAFailCountLbl.Text = "CSMA Fails:";
            // 
            // RxCmdPacketCountTB
            // 
            this.RxCmdPacketCountTB.Index = 5;
            this.RxCmdPacketCountTB.Location = new System.Drawing.Point(346, 100);
            this.RxCmdPacketCountTB.Name = "RxCmdPacketCountTB";
            this.RxCmdPacketCountTB.NotifyChanges = false;
            this.RxCmdPacketCountTB.ReadOnly = true;
            this.RxCmdPacketCountTB.Size = new System.Drawing.Size(104, 20);
            this.RxCmdPacketCountTB.TabIndex = 10;
            this.RxCmdPacketCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // RxCmdPacketCountLbl
            // 
            this.RxCmdPacketCountLbl.AutoSize = true;
            this.RxCmdPacketCountLbl.Location = new System.Drawing.Point(235, 104);
            this.RxCmdPacketCountLbl.Name = "RxCmdPacketCountLbl";
            this.RxCmdPacketCountLbl.Size = new System.Drawing.Size(89, 13);
            this.RxCmdPacketCountLbl.TabIndex = 11;
            this.RxCmdPacketCountLbl.Text = "Rx Cmd Packets:";
            // 
            // TxCmdPacketCountTB
            // 
            this.TxCmdPacketCountTB.Index = 4;
            this.TxCmdPacketCountTB.Location = new System.Drawing.Point(104, 97);
            this.TxCmdPacketCountTB.Name = "TxCmdPacketCountTB";
            this.TxCmdPacketCountTB.NotifyChanges = false;
            this.TxCmdPacketCountTB.ReadOnly = true;
            this.TxCmdPacketCountTB.Size = new System.Drawing.Size(104, 20);
            this.TxCmdPacketCountTB.TabIndex = 8;
            this.TxCmdPacketCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TxCmdPacketCountLbl
            // 
            this.TxCmdPacketCountLbl.AutoSize = true;
            this.TxCmdPacketCountLbl.Location = new System.Drawing.Point(7, 100);
            this.TxCmdPacketCountLbl.Name = "TxCmdPacketCountLbl";
            this.TxCmdPacketCountLbl.Size = new System.Drawing.Size(88, 13);
            this.TxCmdPacketCountLbl.TabIndex = 9;
            this.TxCmdPacketCountLbl.Text = "Tx Cmd Packets:";
            // 
            // RxDataPacketCountTB
            // 
            this.RxDataPacketCountTB.Index = 3;
            this.RxDataPacketCountTB.Location = new System.Drawing.Point(346, 74);
            this.RxDataPacketCountTB.Name = "RxDataPacketCountTB";
            this.RxDataPacketCountTB.NotifyChanges = false;
            this.RxDataPacketCountTB.ReadOnly = true;
            this.RxDataPacketCountTB.Size = new System.Drawing.Size(104, 20);
            this.RxDataPacketCountTB.TabIndex = 6;
            this.RxDataPacketCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // RxDataPacketCountLbl
            // 
            this.RxDataPacketCountLbl.AutoSize = true;
            this.RxDataPacketCountLbl.Location = new System.Drawing.Point(235, 78);
            this.RxDataPacketCountLbl.Name = "RxDataPacketCountLbl";
            this.RxDataPacketCountLbl.Size = new System.Drawing.Size(91, 13);
            this.RxDataPacketCountLbl.TabIndex = 7;
            this.RxDataPacketCountLbl.Text = "Rx Data Packets:";
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
            this.DescriptionTB.Size = new System.Drawing.Size(348, 20);
            this.DescriptionTB.TabIndex = 4;
            // 
            // TxDataPacketCountTB
            // 
            this.TxDataPacketCountTB.Index = 2;
            this.TxDataPacketCountTB.Location = new System.Drawing.Point(104, 71);
            this.TxDataPacketCountTB.Name = "TxDataPacketCountTB";
            this.TxDataPacketCountTB.NotifyChanges = false;
            this.TxDataPacketCountTB.ReadOnly = true;
            this.TxDataPacketCountTB.Size = new System.Drawing.Size(104, 20);
            this.TxDataPacketCountTB.TabIndex = 0;
            this.TxDataPacketCountTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TxDataPacketCountLbl
            // 
            this.TxDataPacketCountLbl.AutoSize = true;
            this.TxDataPacketCountLbl.Location = new System.Drawing.Point(7, 74);
            this.TxDataPacketCountLbl.Name = "TxDataPacketCountLbl";
            this.TxDataPacketCountLbl.Size = new System.Drawing.Size(90, 13);
            this.TxDataPacketCountLbl.TabIndex = 2;
            this.TxDataPacketCountLbl.Text = "Tx Data Packets:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(347, 20);
            this.LogicalNameTB.TabIndex = 1;
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
            // GXDLMSG3PlcMacLayerCountersView
            // 
            this.ClientSize = new System.Drawing.Size(496, 325);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSG3PlcMacLayerCountersView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField RxCmdPacketCountTB;
        private Label RxCmdPacketCountLbl;
        private GXValueField TxCmdPacketCountTB;
        private Label TxCmdPacketCountLbl;
        private GXValueField RxDataPacketCountTB;
        private Label RxDataPacketCountLbl;
        private GXValueField RxDataBroadcastCountTB;
        private Label RxDataBroadcastCountLbl;
        private GXValueField TxDataBroadcastCountTB;
        private Label TxDataBroadcastCountLbl;
        private GXValueField BadCrcCountTB;
        private Label BadCrcCountLbl;
        private GXValueField CSMANoAckCountTB;
        private Label CSMANoAckCountLbl;
        private GXValueField CSMAFailCountTB;
        private Label CSMAFailCountLbl;
        private GXButton ResetBtn;
        private ErrorProvider errorProvider1;
    }
}
