using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSIEC14908DiagnosticView
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
    private Label PlcSignalQualityStatusLbl;
    private GXValueField LogicalNameTB;
    private GXValueField NoReceiveBufferTB;
    private Label NoReceiveBufferLbl;
    private GXValueField ReceivedMessageStatusTB;
    private Label ReceivedMessageStatusLbl;
    private GXValueField TransceiverStateTB;
    private Label TransceiverStateLbl;
    private GXValueField PlcSignalQualityStatusTB;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIEC14908DiagnosticView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.PlcTestRateTB = new Gurux.DLMS.UI.GXValueField();
        this.PlcTestRateLbl = new System.Windows.Forms.Label();
        this.FrequencyInvalidTB = new Gurux.DLMS.UI.GXValueField();
        this.FrequencyInvalidLbl = new System.Windows.Forms.Label();
        this.LateAckTB = new Gurux.DLMS.UI.GXValueField();
        this.LateAckLbl = new System.Windows.Forms.Label();
        this.BacklogOverflowsTB = new Gurux.DLMS.UI.GXValueField();
        this.BacklogOverflowsLbl = new System.Windows.Forms.Label();
        this.UnexpectedPlcCommandCountTB = new Gurux.DLMS.UI.GXValueField();
        this.UnexpectedPlcCommandCountLbl = new System.Windows.Forms.Label();
        this.TransmitNoDataTB = new Gurux.DLMS.UI.GXValueField();
        this.TransmitNoDataLbl = new System.Windows.Forms.Label();
        this.NoReceiveBufferTB = new Gurux.DLMS.UI.GXValueField();
        this.NoReceiveBufferLbl = new System.Windows.Forms.Label();
        this.ReceivedMessageStatusTB = new Gurux.DLMS.UI.GXValueField();
        this.ReceivedMessageStatusLbl = new System.Windows.Forms.Label();
        this.TransceiverStateTB = new Gurux.DLMS.UI.GXValueField();
        this.TransceiverStateLbl = new System.Windows.Forms.Label();
        this.PlcSignalQualityStatusTB = new Gurux.DLMS.UI.GXValueField();
        this.PlcSignalQualityStatusLbl = new System.Windows.Forms.Label();
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
        this.groupBox1.Controls.Add(this.PlcTestRateTB);
        this.groupBox1.Controls.Add(this.PlcTestRateLbl);
        this.groupBox1.Controls.Add(this.FrequencyInvalidTB);
        this.groupBox1.Controls.Add(this.FrequencyInvalidLbl);
        this.groupBox1.Controls.Add(this.LateAckTB);
        this.groupBox1.Controls.Add(this.LateAckLbl);
        this.groupBox1.Controls.Add(this.BacklogOverflowsTB);
        this.groupBox1.Controls.Add(this.BacklogOverflowsLbl);
        this.groupBox1.Controls.Add(this.UnexpectedPlcCommandCountTB);
        this.groupBox1.Controls.Add(this.UnexpectedPlcCommandCountLbl);
        this.groupBox1.Controls.Add(this.TransmitNoDataTB);
        this.groupBox1.Controls.Add(this.TransmitNoDataLbl);
        this.groupBox1.Controls.Add(this.NoReceiveBufferTB);
        this.groupBox1.Controls.Add(this.NoReceiveBufferLbl);
        this.groupBox1.Controls.Add(this.ReceivedMessageStatusTB);
        this.groupBox1.Controls.Add(this.ReceivedMessageStatusLbl);
        this.groupBox1.Controls.Add(this.TransceiverStateTB);
        this.groupBox1.Controls.Add(this.TransceiverStateLbl);
        this.groupBox1.Controls.Add(this.PlcSignalQualityStatusTB);
        this.groupBox1.Controls.Add(this.PlcSignalQualityStatusLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 312);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = " IEC 14908  Diagnostic Object";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // PlcTestRateTB
        //
        this.PlcTestRateTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.PlcTestRateTB.Index = 11;
        this.PlcTestRateTB.Location = new System.Drawing.Point(136, 280);
        this.PlcTestRateTB.Name = "PlcTestRateTB";
        this.PlcTestRateTB.Size = new System.Drawing.Size(206, 20);
        this.PlcTestRateTB.TabIndex = 19;
        this.PlcTestRateTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // PlcTestRateLbl
        //
        this.PlcTestRateLbl.AutoSize = true;
        this.PlcTestRateLbl.Location = new System.Drawing.Point(6, 283);
        this.PlcTestRateLbl.Name = "PlcTestRateLbl";
        this.PlcTestRateLbl.Size = new System.Drawing.Size(71, 13);
        this.PlcTestRateLbl.TabIndex = 20;
        this.PlcTestRateLbl.Text = "PLC test rate:";
        //
        // FrequencyInvalidTB
        //
        this.FrequencyInvalidTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
        this.FrequencyInvalidTB.Index = 10;
        this.FrequencyInvalidTB.Location = new System.Drawing.Point(136, 254);
        this.FrequencyInvalidTB.Name = "FrequencyInvalidTB";
        this.FrequencyInvalidTB.Size = new System.Drawing.Size(206, 20);
        this.FrequencyInvalidTB.TabIndex = 15;
        this.FrequencyInvalidTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // FrequencyInvalidLbl
        //
        this.FrequencyInvalidLbl.AutoSize = true;
        this.FrequencyInvalidLbl.Location = new System.Drawing.Point(6, 257);
        this.FrequencyInvalidLbl.Name = "FrequencyInvalidLbl";
        this.FrequencyInvalidLbl.Size = new System.Drawing.Size(93, 13);
        this.FrequencyInvalidLbl.TabIndex = 18;
        this.FrequencyInvalidLbl.Text = "Frequency invalid:";
        //
        // LateAckTB
        //
        this.LateAckTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
        this.LateAckTB.Index = 9;
        this.LateAckTB.Location = new System.Drawing.Point(136, 228);
        this.LateAckTB.Name = "LateAckTB";
        this.LateAckTB.Size = new System.Drawing.Size(206, 20);
        this.LateAckTB.TabIndex = 14;
        this.LateAckTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // LateAckLbl
        //
        this.LateAckLbl.AutoSize = true;
        this.LateAckLbl.Location = new System.Drawing.Point(6, 231);
        this.LateAckLbl.Name = "LateAckLbl";
        this.LateAckLbl.Size = new System.Drawing.Size(55, 13);
        this.LateAckLbl.TabIndex = 17;
        this.LateAckLbl.Text = "Late ACK:";
        //
        // BacklogOverflowsTB
        //
        this.BacklogOverflowsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
        this.BacklogOverflowsTB.Index = 8;
        this.BacklogOverflowsTB.Location = new System.Drawing.Point(136, 202);
        this.BacklogOverflowsTB.Name = "BacklogOverflowsTB";
        this.BacklogOverflowsTB.Size = new System.Drawing.Size(206, 20);
        this.BacklogOverflowsTB.TabIndex = 12;
        this.BacklogOverflowsTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // BacklogOverflowsLbl
        //
        this.BacklogOverflowsLbl.AutoSize = true;
        this.BacklogOverflowsLbl.Location = new System.Drawing.Point(6, 205);
        this.BacklogOverflowsLbl.Name = "BacklogOverflowsLbl";
        this.BacklogOverflowsLbl.Size = new System.Drawing.Size(97, 13);
        this.BacklogOverflowsLbl.TabIndex = 16;
        this.BacklogOverflowsLbl.Text = "Backlog overflows:";
        //
        // UnexpectedPlcCommandCountTB
        //
        this.UnexpectedPlcCommandCountTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
        this.UnexpectedPlcCommandCountTB.Index = 7;
        this.UnexpectedPlcCommandCountTB.Location = new System.Drawing.Point(136, 176);
        this.UnexpectedPlcCommandCountTB.Name = "UnexpectedPlcCommandCountTB";
        this.UnexpectedPlcCommandCountTB.Size = new System.Drawing.Size(206, 20);
        this.UnexpectedPlcCommandCountTB.TabIndex = 11;
        this.UnexpectedPlcCommandCountTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // UnexpectedPlcCommandCountLbl
        //
        this.UnexpectedPlcCommandCountLbl.AutoSize = true;
        this.UnexpectedPlcCommandCountLbl.Location = new System.Drawing.Point(6, 179);
        this.UnexpectedPlcCommandCountLbl.Name = "UnexpectedPlcCommandCountLbl";
        this.UnexpectedPlcCommandCountLbl.Size = new System.Drawing.Size(99, 13);
        this.UnexpectedPlcCommandCountLbl.TabIndex = 13;
        this.UnexpectedPlcCommandCountLbl.Text = "Unexpected Count:";
        //
        // TransmitNoDataTB
        //
        this.TransmitNoDataTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
        this.TransmitNoDataTB.Index = 6;
        this.TransmitNoDataTB.Location = new System.Drawing.Point(136, 151);
        this.TransmitNoDataTB.Name = "TransmitNoDataTB";
        this.TransmitNoDataTB.Size = new System.Drawing.Size(206, 20);
        this.TransmitNoDataTB.TabIndex = 9;
        this.TransmitNoDataTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TransmitNoDataLbl
        //
        this.TransmitNoDataLbl.AutoSize = true;
        this.TransmitNoDataLbl.Location = new System.Drawing.Point(6, 154);
        this.TransmitNoDataLbl.Name = "TransmitNoDataLbl";
        this.TransmitNoDataLbl.Size = new System.Drawing.Size(93, 13);
        this.TransmitNoDataLbl.TabIndex = 10;
        this.TransmitNoDataLbl.Text = "Transmit No Data:";
        //
        // NoReceiveBufferTB
        //
        this.NoReceiveBufferTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
        this.NoReceiveBufferTB.Index = 5;
        this.NoReceiveBufferTB.Location = new System.Drawing.Point(136, 125);
        this.NoReceiveBufferTB.Name = "NoReceiveBufferTB";
        this.NoReceiveBufferTB.Size = new System.Drawing.Size(206, 20);
        this.NoReceiveBufferTB.TabIndex = 4;
        this.NoReceiveBufferTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // NoReceiveBufferLbl
        //
        this.NoReceiveBufferLbl.AutoSize = true;
        this.NoReceiveBufferLbl.Location = new System.Drawing.Point(6, 128);
        this.NoReceiveBufferLbl.Name = "NoReceiveBufferLbl";
        this.NoReceiveBufferLbl.Size = new System.Drawing.Size(98, 13);
        this.NoReceiveBufferLbl.TabIndex = 8;
        this.NoReceiveBufferLbl.Text = "No Receive Buffer:";
        //
        // ReceivedMessageStatusTB
        //
        this.ReceivedMessageStatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                               | System.Windows.Forms.AnchorStyles.Right)));
        this.ReceivedMessageStatusTB.Index = 4;
        this.ReceivedMessageStatusTB.Location = new System.Drawing.Point(136, 99);
        this.ReceivedMessageStatusTB.Name = "ReceivedMessageStatusTB";
        this.ReceivedMessageStatusTB.Size = new System.Drawing.Size(206, 20);
        this.ReceivedMessageStatusTB.TabIndex = 3;
        this.ReceivedMessageStatusTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // ReceivedMessageStatusLbl
        //
        this.ReceivedMessageStatusLbl.AutoSize = true;
        this.ReceivedMessageStatusLbl.Location = new System.Drawing.Point(6, 102);
        this.ReceivedMessageStatusLbl.Name = "ReceivedMessageStatusLbl";
        this.ReceivedMessageStatusLbl.Size = new System.Drawing.Size(132, 13);
        this.ReceivedMessageStatusLbl.TabIndex = 6;
        this.ReceivedMessageStatusLbl.Text = "Received message status:";
        //
        // TransceiverStateTB
        //
        this.TransceiverStateTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
        this.TransceiverStateTB.Index = 3;
        this.TransceiverStateTB.Location = new System.Drawing.Point(136, 73);
        this.TransceiverStateTB.Name = "TransceiverStateTB";
        this.TransceiverStateTB.Size = new System.Drawing.Size(206, 20);
        this.TransceiverStateTB.TabIndex = 2;
        this.TransceiverStateTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TransceiverStateLbl
        //
        this.TransceiverStateLbl.AutoSize = true;
        this.TransceiverStateLbl.Location = new System.Drawing.Point(6, 76);
        this.TransceiverStateLbl.Name = "TransceiverStateLbl";
        this.TransceiverStateLbl.Size = new System.Drawing.Size(92, 13);
        this.TransceiverStateLbl.TabIndex = 4;
        this.TransceiverStateLbl.Text = "Transceiver state:";
        //
        // PlcSignalQualityStatusTB
        //
        this.PlcSignalQualityStatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                | System.Windows.Forms.AnchorStyles.Right)));
        this.PlcSignalQualityStatusTB.Index = 2;
        this.PlcSignalQualityStatusTB.Location = new System.Drawing.Point(136, 47);
        this.PlcSignalQualityStatusTB.Name = "PlcSignalQualityStatusTB";
        this.PlcSignalQualityStatusTB.Size = new System.Drawing.Size(206, 20);
        this.PlcSignalQualityStatusTB.TabIndex = 1;
        this.PlcSignalQualityStatusTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // PlcSignalQualityStatusLbl
        //
        this.PlcSignalQualityStatusLbl.AutoSize = true;
        this.PlcSignalQualityStatusLbl.Location = new System.Drawing.Point(6, 50);
        this.PlcSignalQualityStatusLbl.Name = "PlcSignalQualityStatusLbl";
        this.PlcSignalQualityStatusLbl.Size = new System.Drawing.Size(124, 13);
        this.PlcSignalQualityStatusLbl.TabIndex = 2;
        this.PlcSignalQualityStatusLbl.Text = "PLC signal quality status:";
        //
        // LogicalNameTB
        //
        this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.LogicalNameTB.Index = 1;
        this.LogicalNameTB.Location = new System.Drawing.Point(136, 21);
        this.LogicalNameTB.Name = "LogicalNameTB";
        this.LogicalNameTB.Size = new System.Drawing.Size(206, 20);
        this.LogicalNameTB.TabIndex = 0;
        this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
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
        // GXDLMSIEC14908DiagnosticView
        //
        this.ClientSize = new System.Drawing.Size(372, 337);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSIEC14908DiagnosticView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private GXValueField TransmitNoDataTB;
    private Label TransmitNoDataLbl;
    private GXValueField PlcTestRateTB;
    private Label PlcTestRateLbl;
    private GXValueField FrequencyInvalidTB;
    private Label FrequencyInvalidLbl;
    private GXValueField LateAckTB;
    private Label LateAckLbl;
    private GXValueField BacklogOverflowsTB;
    private Label BacklogOverflowsLbl;
    private GXValueField UnexpectedPlcCommandCountTB;
    private Label UnexpectedPlcCommandCountLbl;
}
}
