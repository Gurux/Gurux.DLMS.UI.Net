using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSLteMonitoringView
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
    private Label SynchronizationRegisterLbl;
    private GXValueField LogicalNameTB;
    private Label TransmissionsCounterLbl;
    private Label RepetitionsCounterLbl;
    private Label BroadcastFramesCounterLbl;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSLteMonitoringView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CoverageEnhancementTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SignalToNoiseRatioTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SignalLevelTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SignalQualityTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QRxLevMinCE1Tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QRxlevMinCETb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QRxlevMinTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TPTWTb = new System.Windows.Forms.TextBox();
            this.TeDRXTb = new System.Windows.Forms.TextBox();
            this.T3324Tb = new System.Windows.Forms.TextBox();
            this.T3412ext2Tb = new System.Windows.Forms.TextBox();
            this.T3412Tb = new System.Windows.Forms.TextBox();
            this.T3402Tb = new System.Windows.Forms.TextBox();
            this.CrcNOkFramesCounterLbl = new System.Windows.Forms.Label();
            this.CrcOkFramesCounterLbl = new System.Windows.Forms.Label();
            this.TransmissionsCounterLbl = new System.Windows.Forms.Label();
            this.RepetitionsCounterLbl = new System.Windows.Forms.Label();
            this.BroadcastFramesCounterLbl = new System.Windows.Forms.Label();
            this.SynchronizationRegisterLbl = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.CoverageEnhancementTb);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SignalToNoiseRatioTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SignalLevelTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SignalQualityTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.QRxLevMinCE1Tb);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.QRxlevMinCETb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.QRxlevMinTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TPTWTb);
            this.groupBox1.Controls.Add(this.TeDRXTb);
            this.groupBox1.Controls.Add(this.T3324Tb);
            this.groupBox1.Controls.Add(this.T3412ext2Tb);
            this.groupBox1.Controls.Add(this.T3412Tb);
            this.groupBox1.Controls.Add(this.T3402Tb);
            this.groupBox1.Controls.Add(this.CrcNOkFramesCounterLbl);
            this.groupBox1.Controls.Add(this.CrcOkFramesCounterLbl);
            this.groupBox1.Controls.Add(this.TransmissionsCounterLbl);
            this.groupBox1.Controls.Add(this.RepetitionsCounterLbl);
            this.groupBox1.Controls.Add(this.BroadcastFramesCounterLbl);
            this.groupBox1.Controls.Add(this.SynchronizationRegisterLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LTE Monitoring Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // CoverageEnhancementTb
            // 
            this.CoverageEnhancementTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoverageEnhancementTb.Location = new System.Drawing.Point(136, 356);
            this.CoverageEnhancementTb.Name = "CoverageEnhancementTb";
            this.CoverageEnhancementTb.ReadOnly = true;
            this.CoverageEnhancementTb.Size = new System.Drawing.Size(206, 20);
            this.CoverageEnhancementTb.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Coverage enhancement:";
            // 
            // SignalToNoiseRatioTb
            // 
            this.SignalToNoiseRatioTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignalToNoiseRatioTb.Location = new System.Drawing.Point(136, 330);
            this.SignalToNoiseRatioTb.Name = "SignalToNoiseRatioTb";
            this.SignalToNoiseRatioTb.ReadOnly = true;
            this.SignalToNoiseRatioTb.Size = new System.Drawing.Size(206, 20);
            this.SignalToNoiseRatioTb.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Signal to noise ratio:";
            // 
            // SignalLevelTb
            // 
            this.SignalLevelTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignalLevelTb.Location = new System.Drawing.Point(136, 304);
            this.SignalLevelTb.Name = "SignalLevelTb";
            this.SignalLevelTb.ReadOnly = true;
            this.SignalLevelTb.Size = new System.Drawing.Size(206, 20);
            this.SignalLevelTb.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Signal level:";
            // 
            // SignalQualityTb
            // 
            this.SignalQualityTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignalQualityTb.Location = new System.Drawing.Point(136, 278);
            this.SignalQualityTb.Name = "SignalQualityTb";
            this.SignalQualityTb.ReadOnly = true;
            this.SignalQualityTb.Size = new System.Drawing.Size(206, 20);
            this.SignalQualityTb.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Signal quality:";
            // 
            // QRxLevMinCE1Tb
            // 
            this.QRxLevMinCE1Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QRxLevMinCE1Tb.Location = new System.Drawing.Point(136, 252);
            this.QRxLevMinCE1Tb.Name = "QRxLevMinCE1Tb";
            this.QRxLevMinCE1Tb.ReadOnly = true;
            this.QRxLevMinCE1Tb.Size = new System.Drawing.Size(206, 20);
            this.QRxLevMinCE1Tb.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "QRxLevMinCE1:";
            // 
            // QRxlevMinCETb
            // 
            this.QRxlevMinCETb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QRxlevMinCETb.Location = new System.Drawing.Point(136, 226);
            this.QRxlevMinCETb.Name = "QRxlevMinCETb";
            this.QRxlevMinCETb.ReadOnly = true;
            this.QRxlevMinCETb.Size = new System.Drawing.Size(206, 20);
            this.QRxlevMinCETb.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "QRxlevMinCE:";
            // 
            // QRxlevMinTb
            // 
            this.QRxlevMinTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QRxlevMinTb.Location = new System.Drawing.Point(136, 200);
            this.QRxlevMinTb.Name = "QRxlevMinTb";
            this.QRxlevMinTb.ReadOnly = true;
            this.QRxlevMinTb.Size = new System.Drawing.Size(206, 20);
            this.QRxlevMinTb.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "QRxlevMin:";
            // 
            // TPTWTb
            // 
            this.TPTWTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TPTWTb.Location = new System.Drawing.Point(136, 174);
            this.TPTWTb.Name = "TPTWTb";
            this.TPTWTb.ReadOnly = true;
            this.TPTWTb.Size = new System.Drawing.Size(206, 20);
            this.TPTWTb.TabIndex = 18;
            // 
            // TeDRXTb
            // 
            this.TeDRXTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeDRXTb.Location = new System.Drawing.Point(136, 148);
            this.TeDRXTb.Name = "TeDRXTb";
            this.TeDRXTb.ReadOnly = true;
            this.TeDRXTb.Size = new System.Drawing.Size(206, 20);
            this.TeDRXTb.TabIndex = 17;
            // 
            // T3324Tb
            // 
            this.T3324Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T3324Tb.Location = new System.Drawing.Point(136, 122);
            this.T3324Tb.Name = "T3324Tb";
            this.T3324Tb.ReadOnly = true;
            this.T3324Tb.Size = new System.Drawing.Size(206, 20);
            this.T3324Tb.TabIndex = 16;
            // 
            // T3412ext2Tb
            // 
            this.T3412ext2Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T3412ext2Tb.Location = new System.Drawing.Point(136, 96);
            this.T3412ext2Tb.Name = "T3412ext2Tb";
            this.T3412ext2Tb.ReadOnly = true;
            this.T3412ext2Tb.Size = new System.Drawing.Size(206, 20);
            this.T3412ext2Tb.TabIndex = 15;
            // 
            // T3412Tb
            // 
            this.T3412Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T3412Tb.Location = new System.Drawing.Point(136, 73);
            this.T3412Tb.Name = "T3412Tb";
            this.T3412Tb.ReadOnly = true;
            this.T3412Tb.Size = new System.Drawing.Size(206, 20);
            this.T3412Tb.TabIndex = 14;
            // 
            // T3402Tb
            // 
            this.T3402Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.T3402Tb.Location = new System.Drawing.Point(136, 47);
            this.T3402Tb.Name = "T3402Tb";
            this.T3402Tb.ReadOnly = true;
            this.T3402Tb.Size = new System.Drawing.Size(206, 20);
            this.T3402Tb.TabIndex = 13;
            // 
            // CrcNOkFramesCounterLbl
            // 
            this.CrcNOkFramesCounterLbl.AutoSize = true;
            this.CrcNOkFramesCounterLbl.Location = new System.Drawing.Point(6, 180);
            this.CrcNOkFramesCounterLbl.Name = "CrcNOkFramesCounterLbl";
            this.CrcNOkFramesCounterLbl.Size = new System.Drawing.Size(42, 13);
            this.CrcNOkFramesCounterLbl.TabIndex = 12;
            this.CrcNOkFramesCounterLbl.Text = "TPTW:";
            // 
            // CrcOkFramesCounterLbl
            // 
            this.CrcOkFramesCounterLbl.AutoSize = true;
            this.CrcOkFramesCounterLbl.Location = new System.Drawing.Point(6, 154);
            this.CrcOkFramesCounterLbl.Name = "CrcOkFramesCounterLbl";
            this.CrcOkFramesCounterLbl.Size = new System.Drawing.Size(46, 13);
            this.CrcOkFramesCounterLbl.TabIndex = 11;
            this.CrcOkFramesCounterLbl.Text = "TeDRX:";
            // 
            // TransmissionsCounterLbl
            // 
            this.TransmissionsCounterLbl.AutoSize = true;
            this.TransmissionsCounterLbl.Location = new System.Drawing.Point(6, 128);
            this.TransmissionsCounterLbl.Name = "TransmissionsCounterLbl";
            this.TransmissionsCounterLbl.Size = new System.Drawing.Size(41, 13);
            this.TransmissionsCounterLbl.TabIndex = 8;
            this.TransmissionsCounterLbl.Text = "T3324:";
            // 
            // RepetitionsCounterLbl
            // 
            this.RepetitionsCounterLbl.AutoSize = true;
            this.RepetitionsCounterLbl.Location = new System.Drawing.Point(6, 102);
            this.RepetitionsCounterLbl.Name = "RepetitionsCounterLbl";
            this.RepetitionsCounterLbl.Size = new System.Drawing.Size(64, 13);
            this.RepetitionsCounterLbl.TabIndex = 6;
            this.RepetitionsCounterLbl.Text = "T3412 ext 2";
            // 
            // BroadcastFramesCounterLbl
            // 
            this.BroadcastFramesCounterLbl.AutoSize = true;
            this.BroadcastFramesCounterLbl.Location = new System.Drawing.Point(6, 76);
            this.BroadcastFramesCounterLbl.Name = "BroadcastFramesCounterLbl";
            this.BroadcastFramesCounterLbl.Size = new System.Drawing.Size(38, 13);
            this.BroadcastFramesCounterLbl.TabIndex = 4;
            this.BroadcastFramesCounterLbl.Text = "T3412";
            // 
            // SynchronizationRegisterLbl
            // 
            this.SynchronizationRegisterLbl.AutoSize = true;
            this.SynchronizationRegisterLbl.Location = new System.Drawing.Point(6, 50);
            this.SynchronizationRegisterLbl.Name = "SynchronizationRegisterLbl";
            this.SynchronizationRegisterLbl.Size = new System.Drawing.Size(38, 13);
            this.SynchronizationRegisterLbl.TabIndex = 2;
            this.SynchronizationRegisterLbl.Text = "T3402";
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
            // GXDLMSLteMonitoringView
            // 
            this.ClientSize = new System.Drawing.Size(372, 406);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSLteMonitoringView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion
    private Label CrcNOkFramesCounterLbl;
    private Label CrcOkFramesCounterLbl;
        private TextBox CoverageEnhancementTb;
        private Label label7;
        private TextBox SignalToNoiseRatioTb;
        private Label label6;
        private TextBox SignalLevelTb;
        private Label label5;
        private TextBox SignalQualityTb;
        private Label label4;
        private TextBox QRxLevMinCE1Tb;
        private Label label3;
        private TextBox QRxlevMinCETb;
        private Label label2;
        private TextBox QRxlevMinTb;
        private Label label1;
        private TextBox TPTWTb;
        private TextBox TeDRXTb;
        private TextBox T3324Tb;
        private TextBox T3412ext2Tb;
        private TextBox T3402Tb;
        private TextBox T3412Tb;
    }
}
