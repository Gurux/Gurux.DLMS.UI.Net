using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSSFSKMacCountersView
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
    private GXValueField TransmissionsCounterTB;
    private Label TransmissionsCounterLbl;
    private GXValueField RepetitionsCounterTB;
    private Label RepetitionsCounterLbl;
    private GXValueField BroadcastFramesCounterTB;
    private Label BroadcastFramesCounterLbl;
    private GXValueField SynchronizationRegisterTB;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSFSKMacCountersView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.CrcNOkFramesCounterTB = new Gurux.DLMS.UI.GXValueField();
        this.CrcNOkFramesCounterLbl = new System.Windows.Forms.Label();
        this.CrcOkFramesCounterTB = new Gurux.DLMS.UI.GXValueField();
        this.CrcOkFramesCounterLbl = new System.Windows.Forms.Label();
        this.TransmissionsCounterTB = new Gurux.DLMS.UI.GXValueField();
        this.TransmissionsCounterLbl = new System.Windows.Forms.Label();
        this.RepetitionsCounterTB = new Gurux.DLMS.UI.GXValueField();
        this.RepetitionsCounterLbl = new System.Windows.Forms.Label();
        this.BroadcastFramesCounterTB = new Gurux.DLMS.UI.GXValueField();
        this.BroadcastFramesCounterLbl = new System.Windows.Forms.Label();
        this.SynchronizationRegisterTB = new Gurux.DLMS.UI.GXValueField();
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
        this.groupBox1.Controls.Add(this.CrcNOkFramesCounterTB);
        this.groupBox1.Controls.Add(this.CrcNOkFramesCounterLbl);
        this.groupBox1.Controls.Add(this.CrcOkFramesCounterTB);
        this.groupBox1.Controls.Add(this.CrcOkFramesCounterLbl);
        this.groupBox1.Controls.Add(this.TransmissionsCounterTB);
        this.groupBox1.Controls.Add(this.TransmissionsCounterLbl);
        this.groupBox1.Controls.Add(this.RepetitionsCounterTB);
        this.groupBox1.Controls.Add(this.RepetitionsCounterLbl);
        this.groupBox1.Controls.Add(this.BroadcastFramesCounterTB);
        this.groupBox1.Controls.Add(this.BroadcastFramesCounterLbl);
        this.groupBox1.Controls.Add(this.SynchronizationRegisterTB);
        this.groupBox1.Controls.Add(this.SynchronizationRegisterLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 224);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = " S-FSK MAC counters Object";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // CrcNOkFramesCounterTB
        //
        this.CrcNOkFramesCounterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                             | System.Windows.Forms.AnchorStyles.Right)));
        this.CrcNOkFramesCounterTB.Index = 8;
        this.CrcNOkFramesCounterTB.Location = new System.Drawing.Point(136, 177);
        this.CrcNOkFramesCounterTB.Name = "CrcNOkFramesCounterTB";
        this.CrcNOkFramesCounterTB.Size = new System.Drawing.Size(206, 20);
        this.CrcNOkFramesCounterTB.TabIndex = 10;
        this.CrcNOkFramesCounterTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // CrcNOkFramesCounterLbl
        //
        this.CrcNOkFramesCounterLbl.AutoSize = true;
        this.CrcNOkFramesCounterLbl.Location = new System.Drawing.Point(6, 180);
        this.CrcNOkFramesCounterLbl.Name = "CrcNOkFramesCounterLbl";
        this.CrcNOkFramesCounterLbl.Size = new System.Drawing.Size(131, 13);
        this.CrcNOkFramesCounterLbl.TabIndex = 12;
        this.CrcNOkFramesCounterLbl.Text = "CRC NOK frames counter:";
        //
        // CrcOkFramesCounterTB
        //
        this.CrcOkFramesCounterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
        this.CrcOkFramesCounterTB.Index = 7;
        this.CrcOkFramesCounterTB.Location = new System.Drawing.Point(136, 151);
        this.CrcOkFramesCounterTB.Name = "CrcOkFramesCounterTB";
        this.CrcOkFramesCounterTB.Size = new System.Drawing.Size(206, 20);
        this.CrcOkFramesCounterTB.TabIndex = 9;
        this.CrcOkFramesCounterTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // CrcOkFramesCounterLbl
        //
        this.CrcOkFramesCounterLbl.AutoSize = true;
        this.CrcOkFramesCounterLbl.Location = new System.Drawing.Point(6, 154);
        this.CrcOkFramesCounterLbl.Name = "CrcOkFramesCounterLbl";
        this.CrcOkFramesCounterLbl.Size = new System.Drawing.Size(123, 13);
        this.CrcOkFramesCounterLbl.TabIndex = 11;
        this.CrcOkFramesCounterLbl.Text = "CRC OK frames counter:";
        //
        // TransmissionsCounterTB
        //
        this.TransmissionsCounterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                              | System.Windows.Forms.AnchorStyles.Right)));
        this.TransmissionsCounterTB.Index = 6;
        this.TransmissionsCounterTB.Location = new System.Drawing.Point(136, 125);
        this.TransmissionsCounterTB.Name = "TransmissionsCounterTB";
        this.TransmissionsCounterTB.Size = new System.Drawing.Size(206, 20);
        this.TransmissionsCounterTB.TabIndex = 4;
        this.TransmissionsCounterTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TransmissionsCounterLbl
        //
        this.TransmissionsCounterLbl.AutoSize = true;
        this.TransmissionsCounterLbl.Location = new System.Drawing.Point(6, 128);
        this.TransmissionsCounterLbl.Name = "TransmissionsCounterLbl";
        this.TransmissionsCounterLbl.Size = new System.Drawing.Size(115, 13);
        this.TransmissionsCounterLbl.TabIndex = 8;
        this.TransmissionsCounterLbl.Text = "Transmissions counter:";
        //
        // RepetitionsCounterTB
        //
        this.RepetitionsCounterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
        this.RepetitionsCounterTB.Index = 5;
        this.RepetitionsCounterTB.Location = new System.Drawing.Point(136, 99);
        this.RepetitionsCounterTB.Name = "RepetitionsCounterTB";
        this.RepetitionsCounterTB.Size = new System.Drawing.Size(206, 20);
        this.RepetitionsCounterTB.TabIndex = 3;
        this.RepetitionsCounterTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // RepetitionsCounterLbl
        //
        this.RepetitionsCounterLbl.AutoSize = true;
        this.RepetitionsCounterLbl.Location = new System.Drawing.Point(6, 102);
        this.RepetitionsCounterLbl.Name = "RepetitionsCounterLbl";
        this.RepetitionsCounterLbl.Size = new System.Drawing.Size(102, 13);
        this.RepetitionsCounterLbl.TabIndex = 6;
        this.RepetitionsCounterLbl.Text = "Repetitions counter:";
        //
        // BroadcastFramesCounterTB
        //
        this.BroadcastFramesCounterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                | System.Windows.Forms.AnchorStyles.Right)));
        this.BroadcastFramesCounterTB.Index = 4;
        this.BroadcastFramesCounterTB.Location = new System.Drawing.Point(136, 73);
        this.BroadcastFramesCounterTB.Name = "BroadcastFramesCounterTB";
        this.BroadcastFramesCounterTB.Size = new System.Drawing.Size(206, 20);
        this.BroadcastFramesCounterTB.TabIndex = 2;
        this.BroadcastFramesCounterTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        this.BroadcastFramesCounterTB.Load += new System.EventHandler(this.BroadcastFramesCounterTB_Load);
        //
        // BroadcastFramesCounterLbl
        //
        this.BroadcastFramesCounterLbl.AutoSize = true;
        this.BroadcastFramesCounterLbl.Location = new System.Drawing.Point(6, 76);
        this.BroadcastFramesCounterLbl.Name = "BroadcastFramesCounterLbl";
        this.BroadcastFramesCounterLbl.Size = new System.Drawing.Size(131, 13);
        this.BroadcastFramesCounterLbl.TabIndex = 4;
        this.BroadcastFramesCounterLbl.Text = "Broadcast frames counter:";
        //
        // SynchronizationRegisterTB
        //
        this.SynchronizationRegisterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                | System.Windows.Forms.AnchorStyles.Right)));
        this.SynchronizationRegisterTB.Index = 2;
        this.SynchronizationRegisterTB.Location = new System.Drawing.Point(136, 47);
        this.SynchronizationRegisterTB.Name = "SynchronizationRegisterTB";
        this.SynchronizationRegisterTB.Size = new System.Drawing.Size(206, 20);
        this.SynchronizationRegisterTB.TabIndex = 1;
        this.SynchronizationRegisterTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // SynchronizationRegisterLbl
        //
        this.SynchronizationRegisterLbl.AutoSize = true;
        this.SynchronizationRegisterLbl.Location = new System.Drawing.Point(6, 50);
        this.SynchronizationRegisterLbl.Name = "SynchronizationRegisterLbl";
        this.SynchronizationRegisterLbl.Size = new System.Drawing.Size(122, 13);
        this.SynchronizationRegisterLbl.TabIndex = 2;
        this.SynchronizationRegisterLbl.Text = "Synchronization register:";
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
        // GXDLMSSFSKMacCountersView
        //
        this.ClientSize = new System.Drawing.Size(372, 248);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSSFSKMacCountersView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private GXValueField CrcNOkFramesCounterTB;
    private Label CrcNOkFramesCounterLbl;
    private GXValueField CrcOkFramesCounterTB;
    private Label CrcOkFramesCounterLbl;
}
}
