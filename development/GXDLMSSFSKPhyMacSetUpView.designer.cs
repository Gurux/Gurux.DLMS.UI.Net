using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSSFSKPhyMacSetUpView
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
    private Label InitiatorElectricalPhaseLbl;
    private GXValueField LogicalNameTB;
    private GXValueField SearchInitiatorThresholdTB;
    private Label SearchInitiatorThresholdLbl;
    private GXValueField MaxTransmittingGainTB;
    private Label MaxTransmittingGainLbl;
    private GXValueField MaxReceivingGainTB;
    private Label MaxReceivingGainLbl;
    private GXValueField DeltaElectricalPhaseTB;
    private Label DeltaElectricalPhaseLbl;
    private GXValueField InitiatorElectricalPhaseTB;
    private GXValueField MacGroupAddressesTB;
    private Label MacGroupAddressesLbl;
    private GXValueField MacAddressTB;
    private Label MacAddressLbl;
    private GXValueField FrequencyTB;
    private CheckBox RepeaterStatusCB;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSFSKPhyMacSetUpView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.TransmissionSpeedTB = new Gurux.DLMS.UI.GXValueField();
        this.TransmissionSpeedLbl = new System.Windows.Forms.Label();
        this.SynchronizationLockedLbl = new System.Windows.Forms.Label();
        this.InitiatorMacAddressTB = new Gurux.DLMS.UI.GXValueField();
        this.InitiatorMacAddressLbl = new System.Windows.Forms.Label();
        this.MinDeltaCreditTB = new Gurux.DLMS.UI.GXValueField();
        this.MinDeltaCreditLbl = new System.Windows.Forms.Label();
        this.RepeaterStatusCB = new System.Windows.Forms.CheckBox();
        this.RepeaterTB = new Gurux.DLMS.UI.GXValueField();
        this.RepeaterLbl = new System.Windows.Forms.Label();
        this.MacGroupAddressesTB = new Gurux.DLMS.UI.GXValueField();
        this.MacGroupAddressesLbl = new System.Windows.Forms.Label();
        this.MacAddressTB = new Gurux.DLMS.UI.GXValueField();
        this.MacAddressLbl = new System.Windows.Forms.Label();
        this.FrequencyTB = new Gurux.DLMS.UI.GXValueField();
        this.FrequencyLbl = new System.Windows.Forms.Label();
        this.SearchInitiatorThresholdTB = new Gurux.DLMS.UI.GXValueField();
        this.SearchInitiatorThresholdLbl = new System.Windows.Forms.Label();
        this.MaxTransmittingGainTB = new Gurux.DLMS.UI.GXValueField();
        this.MaxTransmittingGainLbl = new System.Windows.Forms.Label();
        this.MaxReceivingGainTB = new Gurux.DLMS.UI.GXValueField();
        this.MaxReceivingGainLbl = new System.Windows.Forms.Label();
        this.DeltaElectricalPhaseTB = new Gurux.DLMS.UI.GXValueField();
        this.DeltaElectricalPhaseLbl = new System.Windows.Forms.Label();
        this.InitiatorElectricalPhaseTB = new Gurux.DLMS.UI.GXValueField();
        this.InitiatorElectricalPhaseLbl = new System.Windows.Forms.Label();
        this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
        this.LogicalNameLbl = new System.Windows.Forms.Label();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        this.SynchronizationLockedCB = new System.Windows.Forms.CheckBox();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        //
        // groupBox1
        //
        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox1.Controls.Add(this.SynchronizationLockedCB);
        this.groupBox1.Controls.Add(this.TransmissionSpeedTB);
        this.groupBox1.Controls.Add(this.TransmissionSpeedLbl);
        this.groupBox1.Controls.Add(this.SynchronizationLockedLbl);
        this.groupBox1.Controls.Add(this.InitiatorMacAddressTB);
        this.groupBox1.Controls.Add(this.InitiatorMacAddressLbl);
        this.groupBox1.Controls.Add(this.MinDeltaCreditTB);
        this.groupBox1.Controls.Add(this.MinDeltaCreditLbl);
        this.groupBox1.Controls.Add(this.RepeaterStatusCB);
        this.groupBox1.Controls.Add(this.RepeaterTB);
        this.groupBox1.Controls.Add(this.RepeaterLbl);
        this.groupBox1.Controls.Add(this.MacGroupAddressesTB);
        this.groupBox1.Controls.Add(this.MacGroupAddressesLbl);
        this.groupBox1.Controls.Add(this.MacAddressTB);
        this.groupBox1.Controls.Add(this.MacAddressLbl);
        this.groupBox1.Controls.Add(this.FrequencyTB);
        this.groupBox1.Controls.Add(this.FrequencyLbl);
        this.groupBox1.Controls.Add(this.SearchInitiatorThresholdTB);
        this.groupBox1.Controls.Add(this.SearchInitiatorThresholdLbl);
        this.groupBox1.Controls.Add(this.MaxTransmittingGainTB);
        this.groupBox1.Controls.Add(this.MaxTransmittingGainLbl);
        this.groupBox1.Controls.Add(this.MaxReceivingGainTB);
        this.groupBox1.Controls.Add(this.MaxReceivingGainLbl);
        this.groupBox1.Controls.Add(this.DeltaElectricalPhaseTB);
        this.groupBox1.Controls.Add(this.DeltaElectricalPhaseLbl);
        this.groupBox1.Controls.Add(this.InitiatorElectricalPhaseTB);
        this.groupBox1.Controls.Add(this.InitiatorElectricalPhaseLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 408);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "S-FSK Phy MAC Setup Object";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // TransmissionSpeedTB
        //
        this.TransmissionSpeedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                           | System.Windows.Forms.AnchorStyles.Right)));
        this.TransmissionSpeedTB.Index = 15;
        this.TransmissionSpeedTB.Location = new System.Drawing.Point(135, 351);
        this.TransmissionSpeedTB.Name = "TransmissionSpeedTB";
        this.TransmissionSpeedTB.ReadOnly = true;
        this.TransmissionSpeedTB.Size = new System.Drawing.Size(206, 20);
        this.TransmissionSpeedTB.TabIndex = 27;
        this.TransmissionSpeedTB.Type = Gurux.DLMS.UI.GXValueFieldType.CompoBox;
        //
        // TransmissionSpeedLbl
        //
        this.TransmissionSpeedLbl.AutoSize = true;
        this.TransmissionSpeedLbl.Location = new System.Drawing.Point(5, 354);
        this.TransmissionSpeedLbl.Name = "TransmissionSpeedLbl";
        this.TransmissionSpeedLbl.Size = new System.Drawing.Size(103, 13);
        this.TransmissionSpeedLbl.TabIndex = 28;
        this.TransmissionSpeedLbl.Text = "Transmission speed:";
        //
        // SynchronizationLockedLbl
        //
        this.SynchronizationLockedLbl.AutoSize = true;
        this.SynchronizationLockedLbl.Location = new System.Drawing.Point(6, 329);
        this.SynchronizationLockedLbl.Name = "SynchronizationLockedLbl";
        this.SynchronizationLockedLbl.Size = new System.Drawing.Size(120, 13);
        this.SynchronizationLockedLbl.TabIndex = 26;
        this.SynchronizationLockedLbl.Text = "Synchronization locked:";
        //
        // InitiatorMacAddressTB
        //
        this.InitiatorMacAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                             | System.Windows.Forms.AnchorStyles.Right)));
        this.InitiatorMacAddressTB.Index = 13;
        this.InitiatorMacAddressTB.Location = new System.Drawing.Point(135, 302);
        this.InitiatorMacAddressTB.Name = "InitiatorMacAddressTB";
        this.InitiatorMacAddressTB.Size = new System.Drawing.Size(206, 20);
        this.InitiatorMacAddressTB.TabIndex = 23;
        this.InitiatorMacAddressTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // InitiatorMacAddressLbl
        //
        this.InitiatorMacAddressLbl.AutoSize = true;
        this.InitiatorMacAddressLbl.Location = new System.Drawing.Point(5, 305);
        this.InitiatorMacAddressLbl.Name = "InitiatorMacAddressLbl";
        this.InitiatorMacAddressLbl.Size = new System.Drawing.Size(111, 13);
        this.InitiatorMacAddressLbl.TabIndex = 24;
        this.InitiatorMacAddressLbl.Text = "Initiator MAC Address:";
        //
        // MinDeltaCreditTB
        //
        this.MinDeltaCreditTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
        this.MinDeltaCreditTB.Index = 12;
        this.MinDeltaCreditTB.Location = new System.Drawing.Point(136, 277);
        this.MinDeltaCreditTB.Name = "MinDeltaCreditTB";
        this.MinDeltaCreditTB.Size = new System.Drawing.Size(206, 20);
        this.MinDeltaCreditTB.TabIndex = 21;
        this.MinDeltaCreditTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MinDeltaCreditLbl
        //
        this.MinDeltaCreditLbl.AutoSize = true;
        this.MinDeltaCreditLbl.Location = new System.Drawing.Point(6, 280);
        this.MinDeltaCreditLbl.Name = "MinDeltaCreditLbl";
        this.MinDeltaCreditLbl.Size = new System.Drawing.Size(85, 13);
        this.MinDeltaCreditLbl.TabIndex = 22;
        this.MinDeltaCreditLbl.Text = "Min Delta Credit:";
        //
        // RepeaterStatusCB
        //
        this.RepeaterStatusCB.Checked = true;
        this.RepeaterStatusCB.CheckState = System.Windows.Forms.CheckState.Indeterminate;
        this.RepeaterStatusCB.Location = new System.Drawing.Point(136, 254);
        this.RepeaterStatusCB.Name = "RepeaterStatusCB";
        this.RepeaterStatusCB.Size = new System.Drawing.Size(27, 17);
        this.RepeaterStatusCB.TabIndex = 7;
        this.RepeaterStatusCB.UseVisualStyleBackColor = false;
        //
        // RepeaterTB
        //
        this.RepeaterTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                  | System.Windows.Forms.AnchorStyles.Right)));
        this.RepeaterTB.Index = 10;
        this.RepeaterTB.Location = new System.Drawing.Point(169, 251);
        this.RepeaterTB.Name = "RepeaterTB";
        this.RepeaterTB.ReadOnly = true;
        this.RepeaterTB.Size = new System.Drawing.Size(173, 20);
        this.RepeaterTB.TabIndex = 19;
        this.RepeaterTB.Type = Gurux.DLMS.UI.GXValueFieldType.CompoBox;
        //
        // RepeaterLbl
        //
        this.RepeaterLbl.AutoSize = true;
        this.RepeaterLbl.Location = new System.Drawing.Point(6, 254);
        this.RepeaterLbl.Name = "RepeaterLbl";
        this.RepeaterLbl.Size = new System.Drawing.Size(54, 13);
        this.RepeaterLbl.TabIndex = 20;
        this.RepeaterLbl.Text = "Repeater:";
        //
        // MacGroupAddressesTB
        //
        this.MacGroupAddressesTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                           | System.Windows.Forms.AnchorStyles.Right)));
        this.MacGroupAddressesTB.Index = 9;
        this.MacGroupAddressesTB.Location = new System.Drawing.Point(136, 227);
        this.MacGroupAddressesTB.Name = "MacGroupAddressesTB";
        this.MacGroupAddressesTB.Size = new System.Drawing.Size(206, 20);
        this.MacGroupAddressesTB.TabIndex = 9;
        this.MacGroupAddressesTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MacGroupAddressesLbl
        //
        this.MacGroupAddressesLbl.AutoSize = true;
        this.MacGroupAddressesLbl.Location = new System.Drawing.Point(6, 230);
        this.MacGroupAddressesLbl.Name = "MacGroupAddressesLbl";
        this.MacGroupAddressesLbl.Size = new System.Drawing.Size(117, 13);
        this.MacGroupAddressesLbl.TabIndex = 18;
        this.MacGroupAddressesLbl.Text = "MAC Group Addresses:";
        //
        // MacAddressTB
        //
        this.MacAddressTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
        this.MacAddressTB.Index = 8;
        this.MacAddressTB.Location = new System.Drawing.Point(136, 201);
        this.MacAddressTB.Name = "MacAddressTB";
        this.MacAddressTB.Size = new System.Drawing.Size(206, 20);
        this.MacAddressTB.TabIndex = 8;
        this.MacAddressTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MacAddressLbl
        //
        this.MacAddressLbl.AutoSize = true;
        this.MacAddressLbl.Location = new System.Drawing.Point(6, 204);
        this.MacAddressLbl.Name = "MacAddressLbl";
        this.MacAddressLbl.Size = new System.Drawing.Size(74, 13);
        this.MacAddressLbl.TabIndex = 16;
        this.MacAddressLbl.Text = "MAC Address:";
        //
        // FrequencyTB
        //
        this.FrequencyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
        this.FrequencyTB.Index = 7;
        this.FrequencyTB.Location = new System.Drawing.Point(136, 177);
        this.FrequencyTB.Name = "FrequencyTB";
        this.FrequencyTB.Size = new System.Drawing.Size(206, 20);
        this.FrequencyTB.TabIndex = 6;
        this.FrequencyTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // FrequencyLbl
        //
        this.FrequencyLbl.AutoSize = true;
        this.FrequencyLbl.Location = new System.Drawing.Point(6, 180);
        this.FrequencyLbl.Name = "FrequencyLbl";
        this.FrequencyLbl.Size = new System.Drawing.Size(60, 13);
        this.FrequencyLbl.TabIndex = 12;
        this.FrequencyLbl.Text = "Frequency:";
        //
        // SearchInitiatorThresholdTB
        //
        this.SearchInitiatorThresholdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
        this.SearchInitiatorThresholdTB.Index = 6;
        this.SearchInitiatorThresholdTB.Location = new System.Drawing.Point(136, 151);
        this.SearchInitiatorThresholdTB.Name = "SearchInitiatorThresholdTB";
        this.SearchInitiatorThresholdTB.Size = new System.Drawing.Size(206, 20);
        this.SearchInitiatorThresholdTB.TabIndex = 5;
        this.SearchInitiatorThresholdTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // SearchInitiatorThresholdLbl
        //
        this.SearchInitiatorThresholdLbl.AutoSize = true;
        this.SearchInitiatorThresholdLbl.Location = new System.Drawing.Point(6, 154);
        this.SearchInitiatorThresholdLbl.Name = "SearchInitiatorThresholdLbl";
        this.SearchInitiatorThresholdLbl.Size = new System.Drawing.Size(126, 13);
        this.SearchInitiatorThresholdLbl.TabIndex = 10;
        this.SearchInitiatorThresholdLbl.Text = "Search initiator threshold:";
        //
        // MaxTransmittingGainTB
        //
        this.MaxTransmittingGainTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                             | System.Windows.Forms.AnchorStyles.Right)));
        this.MaxTransmittingGainTB.Index = 5;
        this.MaxTransmittingGainTB.Location = new System.Drawing.Point(136, 125);
        this.MaxTransmittingGainTB.Name = "MaxTransmittingGainTB";
        this.MaxTransmittingGainTB.Size = new System.Drawing.Size(206, 20);
        this.MaxTransmittingGainTB.TabIndex = 4;
        this.MaxTransmittingGainTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MaxTransmittingGainLbl
        //
        this.MaxTransmittingGainLbl.AutoSize = true;
        this.MaxTransmittingGainLbl.Location = new System.Drawing.Point(6, 128);
        this.MaxTransmittingGainLbl.Name = "MaxTransmittingGainLbl";
        this.MaxTransmittingGainLbl.Size = new System.Drawing.Size(115, 13);
        this.MaxTransmittingGainLbl.TabIndex = 8;
        this.MaxTransmittingGainLbl.Text = "Max Transmitting Gain:";
        //
        // MaxReceivingGainTB
        //
        this.MaxReceivingGainTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
        this.MaxReceivingGainTB.Index = 4;
        this.MaxReceivingGainTB.Location = new System.Drawing.Point(136, 99);
        this.MaxReceivingGainTB.Name = "MaxReceivingGainTB";
        this.MaxReceivingGainTB.Size = new System.Drawing.Size(206, 20);
        this.MaxReceivingGainTB.TabIndex = 3;
        this.MaxReceivingGainTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MaxReceivingGainLbl
        //
        this.MaxReceivingGainLbl.AutoSize = true;
        this.MaxReceivingGainLbl.Location = new System.Drawing.Point(6, 102);
        this.MaxReceivingGainLbl.Name = "MaxReceivingGainLbl";
        this.MaxReceivingGainLbl.Size = new System.Drawing.Size(106, 13);
        this.MaxReceivingGainLbl.TabIndex = 6;
        this.MaxReceivingGainLbl.Text = "Max Receiving Gain:";
        //
        // DeltaElectricalPhaseTB
        //
        this.DeltaElectricalPhaseTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                              | System.Windows.Forms.AnchorStyles.Right)));
        this.DeltaElectricalPhaseTB.Index = 3;
        this.DeltaElectricalPhaseTB.Location = new System.Drawing.Point(136, 73);
        this.DeltaElectricalPhaseTB.Name = "DeltaElectricalPhaseTB";
        this.DeltaElectricalPhaseTB.ReadOnly = true;
        this.DeltaElectricalPhaseTB.Size = new System.Drawing.Size(206, 20);
        this.DeltaElectricalPhaseTB.TabIndex = 2;
        this.DeltaElectricalPhaseTB.Type = Gurux.DLMS.UI.GXValueFieldType.CompoBox;
        //
        // DeltaElectricalPhaseLbl
        //
        this.DeltaElectricalPhaseLbl.AutoSize = true;
        this.DeltaElectricalPhaseLbl.Location = new System.Drawing.Point(6, 76);
        this.DeltaElectricalPhaseLbl.Name = "DeltaElectricalPhaseLbl";
        this.DeltaElectricalPhaseLbl.Size = new System.Drawing.Size(114, 13);
        this.DeltaElectricalPhaseLbl.TabIndex = 4;
        this.DeltaElectricalPhaseLbl.Text = "Delta Electrical Phase:";
        //
        // InitiatorElectricalPhaseTB
        //
        this.InitiatorElectricalPhaseTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
        this.InitiatorElectricalPhaseTB.Index = 2;
        this.InitiatorElectricalPhaseTB.Location = new System.Drawing.Point(136, 47);
        this.InitiatorElectricalPhaseTB.Name = "InitiatorElectricalPhaseTB";
        this.InitiatorElectricalPhaseTB.ReadOnly = true;
        this.InitiatorElectricalPhaseTB.Size = new System.Drawing.Size(206, 20);
        this.InitiatorElectricalPhaseTB.TabIndex = 1;
        this.InitiatorElectricalPhaseTB.Type = Gurux.DLMS.UI.GXValueFieldType.CompoBox;
        //
        // InitiatorElectricalPhaseLbl
        //
        this.InitiatorElectricalPhaseLbl.AutoSize = true;
        this.InitiatorElectricalPhaseLbl.Location = new System.Drawing.Point(6, 50);
        this.InitiatorElectricalPhaseLbl.Name = "InitiatorElectricalPhaseLbl";
        this.InitiatorElectricalPhaseLbl.Size = new System.Drawing.Size(123, 13);
        this.InitiatorElectricalPhaseLbl.TabIndex = 2;
        this.InitiatorElectricalPhaseLbl.Text = "Initiator Electrical Phase:";
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
        // SynchronizationLockedCB
        //
        this.SynchronizationLockedCB.Checked = true;
        this.SynchronizationLockedCB.CheckState = System.Windows.Forms.CheckState.Indeterminate;
        this.SynchronizationLockedCB.Location = new System.Drawing.Point(136, 329);
        this.SynchronizationLockedCB.Name = "SynchronizationLockedCB";
        this.SynchronizationLockedCB.Size = new System.Drawing.Size(27, 17);
        this.SynchronizationLockedCB.TabIndex = 29;
        this.SynchronizationLockedCB.UseVisualStyleBackColor = false;
        //
        // GXDLMSSFSKPhyMacSetUpView
        //
        this.ClientSize = new System.Drawing.Size(372, 460);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSSFSKPhyMacSetUpView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private Label FrequencyLbl;
    private GXValueField RepeaterTB;
    private Label RepeaterLbl;
    private GXValueField MinDeltaCreditTB;
    private Label MinDeltaCreditLbl;
    private GXValueField InitiatorMacAddressTB;
    private Label InitiatorMacAddressLbl;
    private GXValueField TransmissionSpeedTB;
    private Label TransmissionSpeedLbl;
    private Label SynchronizationLockedLbl;
    private CheckBox SynchronizationLockedCB;
}
}
