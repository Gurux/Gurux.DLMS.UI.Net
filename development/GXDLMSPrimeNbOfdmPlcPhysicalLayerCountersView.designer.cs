using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPrimeNbOfdmPlcPhysicalLayerCountersView
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
        private Label CRCIncorrectCountLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPrimeNbOfdmPlcPhysicalLayerCountersView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.RXDropCountTb = new Gurux.DLMS.UI.GXValueField();
            this.RXDropCountLbl = new System.Windows.Forms.Label();
            this.TXDropCountTb = new Gurux.DLMS.UI.GXValueField();
            this.TXDropCountLbl = new System.Windows.Forms.Label();
            this.CRCFailedCountTb = new Gurux.DLMS.UI.GXValueField();
            this.CRCFailedCountLbl = new System.Windows.Forms.Label();
            this.CRCIncorrectCountTb = new Gurux.DLMS.UI.GXValueField();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.CRCIncorrectCountLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ServerAddressTb = new Gurux.DLMS.UI.GXValueField();
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
            this.groupBox1.Controls.Add(this.RXDropCountTb);
            this.groupBox1.Controls.Add(this.RXDropCountLbl);
            this.groupBox1.Controls.Add(this.TXDropCountTb);
            this.groupBox1.Controls.Add(this.TXDropCountLbl);
            this.groupBox1.Controls.Add(this.CRCFailedCountTb);
            this.groupBox1.Controls.Add(this.CRCFailedCountLbl);
            this.groupBox1.Controls.Add(this.CRCIncorrectCountTb);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.CRCIncorrectCountLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRIME NB OFDM PLC Physical layer counters Object";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 1;
            this.ResetBtn.Location = new System.Drawing.Point(200, 175);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 13;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // RXDropCountTb
            // 
            this.RXDropCountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RXDropCountTb.Index = 5;
            this.RXDropCountTb.Location = new System.Drawing.Point(119, 149);
            this.RXDropCountTb.Name = "RXDropCountTb";
            this.RXDropCountTb.NotifyChanges = false;
            this.RXDropCountTb.Size = new System.Drawing.Size(156, 20);
            this.RXDropCountTb.TabIndex = 12;
            this.RXDropCountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // RXDropCountLbl
            // 
            this.RXDropCountLbl.AutoSize = true;
            this.RXDropCountLbl.Location = new System.Drawing.Point(7, 149);
            this.RXDropCountLbl.Name = "RXDropCountLbl";
            this.RXDropCountLbl.Size = new System.Drawing.Size(82, 13);
            this.RXDropCountLbl.TabIndex = 11;
            this.RXDropCountLbl.Text = "RX Drop Count:";
            // 
            // TXDropCountTb
            // 
            this.TXDropCountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXDropCountTb.Index = 4;
            this.TXDropCountTb.Location = new System.Drawing.Point(118, 123);
            this.TXDropCountTb.Name = "TXDropCountTb";
            this.TXDropCountTb.NotifyChanges = false;
            this.TXDropCountTb.Size = new System.Drawing.Size(156, 20);
            this.TXDropCountTb.TabIndex = 10;
            this.TXDropCountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TXDropCountLbl
            // 
            this.TXDropCountLbl.AutoSize = true;
            this.TXDropCountLbl.Location = new System.Drawing.Point(6, 123);
            this.TXDropCountLbl.Name = "TXDropCountLbl";
            this.TXDropCountLbl.Size = new System.Drawing.Size(81, 13);
            this.TXDropCountLbl.TabIndex = 9;
            this.TXDropCountLbl.Text = "TX Drop Count:";
            // 
            // CRCFailedCountTb
            // 
            this.CRCFailedCountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRCFailedCountTb.Index = 3;
            this.CRCFailedCountTb.Location = new System.Drawing.Point(118, 97);
            this.CRCFailedCountTb.Name = "CRCFailedCountTb";
            this.CRCFailedCountTb.NotifyChanges = false;
            this.CRCFailedCountTb.Size = new System.Drawing.Size(156, 20);
            this.CRCFailedCountTb.TabIndex = 8;
            this.CRCFailedCountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // CRCFailedCountLbl
            // 
            this.CRCFailedCountLbl.AutoSize = true;
            this.CRCFailedCountLbl.Location = new System.Drawing.Point(6, 97);
            this.CRCFailedCountLbl.Name = "CRCFailedCountLbl";
            this.CRCFailedCountLbl.Size = new System.Drawing.Size(94, 13);
            this.CRCFailedCountLbl.TabIndex = 7;
            this.CRCFailedCountLbl.Text = "CRC Failed Count:";
            // 
            // CRCIncorrectCountTb
            // 
            this.CRCIncorrectCountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRCIncorrectCountTb.Index = 2;
            this.CRCIncorrectCountTb.Location = new System.Drawing.Point(118, 71);
            this.CRCIncorrectCountTb.Name = "CRCIncorrectCountTb";
            this.CRCIncorrectCountTb.NotifyChanges = false;
            this.CRCIncorrectCountTb.Size = new System.Drawing.Size(156, 20);
            this.CRCIncorrectCountTb.TabIndex = 6;
            this.CRCIncorrectCountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // CRCIncorrectCountLbl
            // 
            this.CRCIncorrectCountLbl.AutoSize = true;
            this.CRCIncorrectCountLbl.Location = new System.Drawing.Point(7, 74);
            this.CRCIncorrectCountLbl.Name = "CRCIncorrectCountLbl";
            this.CRCIncorrectCountLbl.Size = new System.Drawing.Size(108, 13);
            this.CRCIncorrectCountLbl.TabIndex = 2;
            this.CRCIncorrectCountLbl.Text = "CRC Incorrect Count:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(118, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(156, 20);
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
            // ServerAddressTb
            // 
            this.ServerAddressTb.Index = 0;
            this.ServerAddressTb.Location = new System.Drawing.Point(0, 0);
            this.ServerAddressTb.Name = "ServerAddressTb";
            this.ServerAddressTb.NotifyChanges = false;
            this.ServerAddressTb.Size = new System.Drawing.Size(194, 22);
            this.ServerAddressTb.TabIndex = 0;
            this.ServerAddressTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSPrimeNbOfdmPlcPhysicalLayerCountersView
            // 
            this.ClientSize = new System.Drawing.Size(320, 239);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPrimeNbOfdmPlcPhysicalLayerCountersView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField ServerAddressTb;
        private GXValueField CRCIncorrectCountTb;
        private GXValueField RXDropCountTb;
        private Label RXDropCountLbl;
        private GXValueField TXDropCountTb;
        private Label TXDropCountLbl;
        private GXValueField CRCFailedCountTb;
        private Label CRCFailedCountLbl;
        private GXButton ResetBtn;
    }
}
