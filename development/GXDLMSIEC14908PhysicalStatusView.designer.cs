using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSIEC14908PhysicalStatusView
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
    private Label TransmissionErrorsLbl;
    private GXValueField LogicalNameTB;
    private GXValueField ReceiveFullTB;
    private Label ReceiveFullLbl;
    private GXValueField TransmitRetriesTB;
    private Label TransmitRetriesLbl;
    private GXValueField TransmitFailureTB;
    private Label TransmitFailureLbl;
    private GXValueField TransmissionErrorsTB;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIEC14908PhysicalStatusView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.MessagesValidatedTB = new Gurux.DLMS.UI.GXValueField();
        this.MessagesValidatedLbl = new System.Windows.Forms.Label();
        this.MessagesReceivedTB = new Gurux.DLMS.UI.GXValueField();
        this.MessagesReceivedLbl = new System.Windows.Forms.Label();
        this.Layer3ReceivedTB = new Gurux.DLMS.UI.GXValueField();
        this.Layer3ReceivedLbl = new System.Windows.Forms.Label();
        this.Layer2ReceivedTB = new Gurux.DLMS.UI.GXValueField();
        this.Layer2ReceivedLbl = new System.Windows.Forms.Label();
        this.MissedMessagesTB = new Gurux.DLMS.UI.GXValueField();
        this.MissedMessagesLbl = new System.Windows.Forms.Label();
        this.LostMessagesTB = new Gurux.DLMS.UI.GXValueField();
        this.LostMessagesLbl = new System.Windows.Forms.Label();
        this.ReceiveFullTB = new Gurux.DLMS.UI.GXValueField();
        this.ReceiveFullLbl = new System.Windows.Forms.Label();
        this.TransmitRetriesTB = new Gurux.DLMS.UI.GXValueField();
        this.TransmitRetriesLbl = new System.Windows.Forms.Label();
        this.TransmitFailureTB = new Gurux.DLMS.UI.GXValueField();
        this.TransmitFailureLbl = new System.Windows.Forms.Label();
        this.TransmissionErrorsTB = new Gurux.DLMS.UI.GXValueField();
        this.TransmissionErrorsLbl = new System.Windows.Forms.Label();
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
        this.groupBox1.Controls.Add(this.MessagesValidatedTB);
        this.groupBox1.Controls.Add(this.MessagesValidatedLbl);
        this.groupBox1.Controls.Add(this.MessagesReceivedTB);
        this.groupBox1.Controls.Add(this.MessagesReceivedLbl);
        this.groupBox1.Controls.Add(this.Layer3ReceivedTB);
        this.groupBox1.Controls.Add(this.Layer3ReceivedLbl);
        this.groupBox1.Controls.Add(this.Layer2ReceivedTB);
        this.groupBox1.Controls.Add(this.Layer2ReceivedLbl);
        this.groupBox1.Controls.Add(this.MissedMessagesTB);
        this.groupBox1.Controls.Add(this.MissedMessagesLbl);
        this.groupBox1.Controls.Add(this.LostMessagesTB);
        this.groupBox1.Controls.Add(this.LostMessagesLbl);
        this.groupBox1.Controls.Add(this.ReceiveFullTB);
        this.groupBox1.Controls.Add(this.ReceiveFullLbl);
        this.groupBox1.Controls.Add(this.TransmitRetriesTB);
        this.groupBox1.Controls.Add(this.TransmitRetriesLbl);
        this.groupBox1.Controls.Add(this.TransmitFailureTB);
        this.groupBox1.Controls.Add(this.TransmitFailureLbl);
        this.groupBox1.Controls.Add(this.TransmissionErrorsTB);
        this.groupBox1.Controls.Add(this.TransmissionErrorsLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 312);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = " IEC 14908 Physical status Object";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // MessagesValidatedTB
        //
        this.MessagesValidatedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                           | System.Windows.Forms.AnchorStyles.Right)));
        this.MessagesValidatedTB.Index = 11;
        this.MessagesValidatedTB.Location = new System.Drawing.Point(136, 280);
        this.MessagesValidatedTB.Name = "MessagesValidatedTB";
        this.MessagesValidatedTB.Size = new System.Drawing.Size(206, 20);
        this.MessagesValidatedTB.TabIndex = 19;
        this.MessagesValidatedTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MessagesValidatedLbl
        //
        this.MessagesValidatedLbl.AutoSize = true;
        this.MessagesValidatedLbl.Location = new System.Drawing.Point(6, 283);
        this.MessagesValidatedLbl.Name = "MessagesValidatedLbl";
        this.MessagesValidatedLbl.Size = new System.Drawing.Size(104, 13);
        this.MessagesValidatedLbl.TabIndex = 20;
        this.MessagesValidatedLbl.Text = "Messages validated:";
        //
        // MessagesReceivedTB
        //
        this.MessagesReceivedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
        this.MessagesReceivedTB.Index = 10;
        this.MessagesReceivedTB.Location = new System.Drawing.Point(136, 254);
        this.MessagesReceivedTB.Name = "MessagesReceivedTB";
        this.MessagesReceivedTB.Size = new System.Drawing.Size(206, 20);
        this.MessagesReceivedTB.TabIndex = 15;
        this.MessagesReceivedTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MessagesReceivedLbl
        //
        this.MessagesReceivedLbl.AutoSize = true;
        this.MessagesReceivedLbl.Location = new System.Drawing.Point(6, 257);
        this.MessagesReceivedLbl.Name = "MessagesReceivedLbl";
        this.MessagesReceivedLbl.Size = new System.Drawing.Size(102, 13);
        this.MessagesReceivedLbl.TabIndex = 18;
        this.MessagesReceivedLbl.Text = "Messages received:";
        //
        // Layer3ReceivedTB
        //
        this.Layer3ReceivedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
        this.Layer3ReceivedTB.Index = 9;
        this.Layer3ReceivedTB.Location = new System.Drawing.Point(136, 228);
        this.Layer3ReceivedTB.Name = "Layer3ReceivedTB";
        this.Layer3ReceivedTB.Size = new System.Drawing.Size(206, 20);
        this.Layer3ReceivedTB.TabIndex = 14;
        this.Layer3ReceivedTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // Layer3ReceivedLbl
        //
        this.Layer3ReceivedLbl.AutoSize = true;
        this.Layer3ReceivedLbl.Location = new System.Drawing.Point(6, 231);
        this.Layer3ReceivedLbl.Name = "Layer3ReceivedLbl";
        this.Layer3ReceivedLbl.Size = new System.Drawing.Size(86, 13);
        this.Layer3ReceivedLbl.TabIndex = 17;
        this.Layer3ReceivedLbl.Text = "Layer3 received:";
        //
        // Layer2ReceivedTB
        //
        this.Layer2ReceivedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
        this.Layer2ReceivedTB.Index = 8;
        this.Layer2ReceivedTB.Location = new System.Drawing.Point(136, 202);
        this.Layer2ReceivedTB.Name = "Layer2ReceivedTB";
        this.Layer2ReceivedTB.Size = new System.Drawing.Size(206, 20);
        this.Layer2ReceivedTB.TabIndex = 12;
        this.Layer2ReceivedTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // Layer2ReceivedLbl
        //
        this.Layer2ReceivedLbl.AutoSize = true;
        this.Layer2ReceivedLbl.Location = new System.Drawing.Point(6, 205);
        this.Layer2ReceivedLbl.Name = "Layer2ReceivedLbl";
        this.Layer2ReceivedLbl.Size = new System.Drawing.Size(86, 13);
        this.Layer2ReceivedLbl.TabIndex = 16;
        this.Layer2ReceivedLbl.Text = "Layer2 received:";
        //
        // MissedMessagesTB
        //
        this.MissedMessagesTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
        this.MissedMessagesTB.Index = 7;
        this.MissedMessagesTB.Location = new System.Drawing.Point(136, 176);
        this.MissedMessagesTB.Name = "MissedMessagesTB";
        this.MissedMessagesTB.Size = new System.Drawing.Size(206, 20);
        this.MissedMessagesTB.TabIndex = 11;
        this.MissedMessagesTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // MissedMessagesLbl
        //
        this.MissedMessagesLbl.AutoSize = true;
        this.MissedMessagesLbl.Location = new System.Drawing.Point(6, 179);
        this.MissedMessagesLbl.Name = "MissedMessagesLbl";
        this.MissedMessagesLbl.Size = new System.Drawing.Size(93, 13);
        this.MissedMessagesLbl.TabIndex = 13;
        this.MissedMessagesLbl.Text = "Missed messages:";
        //
        // LostMessagesTB
        //
        this.LostMessagesTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                      | System.Windows.Forms.AnchorStyles.Right)));
        this.LostMessagesTB.Index = 6;
        this.LostMessagesTB.Location = new System.Drawing.Point(136, 151);
        this.LostMessagesTB.Name = "LostMessagesTB";
        this.LostMessagesTB.Size = new System.Drawing.Size(206, 20);
        this.LostMessagesTB.TabIndex = 9;
        this.LostMessagesTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // LostMessagesLbl
        //
        this.LostMessagesLbl.AutoSize = true;
        this.LostMessagesLbl.Location = new System.Drawing.Point(6, 154);
        this.LostMessagesLbl.Name = "LostMessagesLbl";
        this.LostMessagesLbl.Size = new System.Drawing.Size(80, 13);
        this.LostMessagesLbl.TabIndex = 10;
        this.LostMessagesLbl.Text = "Lost messages:";
        //
        // ReceiveFullTB
        //
        this.ReceiveFullTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
        this.ReceiveFullTB.Index = 5;
        this.ReceiveFullTB.Location = new System.Drawing.Point(136, 125);
        this.ReceiveFullTB.Name = "ReceiveFullTB";
        this.ReceiveFullTB.Size = new System.Drawing.Size(206, 20);
        this.ReceiveFullTB.TabIndex = 4;
        this.ReceiveFullTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // ReceiveFullLbl
        //
        this.ReceiveFullLbl.AutoSize = true;
        this.ReceiveFullLbl.Location = new System.Drawing.Point(6, 128);
        this.ReceiveFullLbl.Name = "ReceiveFullLbl";
        this.ReceiveFullLbl.Size = new System.Drawing.Size(66, 13);
        this.ReceiveFullLbl.TabIndex = 8;
        this.ReceiveFullLbl.Text = "Receive full:";
        //
        // TransmitRetriesTB
        //
        this.TransmitRetriesTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
        this.TransmitRetriesTB.Index = 4;
        this.TransmitRetriesTB.Location = new System.Drawing.Point(136, 99);
        this.TransmitRetriesTB.Name = "TransmitRetriesTB";
        this.TransmitRetriesTB.Size = new System.Drawing.Size(206, 20);
        this.TransmitRetriesTB.TabIndex = 3;
        this.TransmitRetriesTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TransmitRetriesLbl
        //
        this.TransmitRetriesLbl.AutoSize = true;
        this.TransmitRetriesLbl.Location = new System.Drawing.Point(6, 102);
        this.TransmitRetriesLbl.Name = "TransmitRetriesLbl";
        this.TransmitRetriesLbl.Size = new System.Drawing.Size(81, 13);
        this.TransmitRetriesLbl.TabIndex = 6;
        this.TransmitRetriesLbl.Text = "Transmit retries:";
        //
        // TransmitFailureTB
        //
        this.TransmitFailureTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
        this.TransmitFailureTB.Index = 3;
        this.TransmitFailureTB.Location = new System.Drawing.Point(136, 73);
        this.TransmitFailureTB.Name = "TransmitFailureTB";
        this.TransmitFailureTB.Size = new System.Drawing.Size(206, 20);
        this.TransmitFailureTB.TabIndex = 2;
        this.TransmitFailureTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TransmitFailureLbl
        //
        this.TransmitFailureLbl.AutoSize = true;
        this.TransmitFailureLbl.Location = new System.Drawing.Point(6, 76);
        this.TransmitFailureLbl.Name = "TransmitFailureLbl";
        this.TransmitFailureLbl.Size = new System.Drawing.Size(81, 13);
        this.TransmitFailureLbl.TabIndex = 4;
        this.TransmitFailureLbl.Text = "Transmit failure:";
        //
        // TransmissionErrorsTB
        //
        this.TransmissionErrorsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
        this.TransmissionErrorsTB.Index = 2;
        this.TransmissionErrorsTB.Location = new System.Drawing.Point(136, 47);
        this.TransmissionErrorsTB.Name = "TransmissionErrorsTB";
        this.TransmissionErrorsTB.Size = new System.Drawing.Size(206, 20);
        this.TransmissionErrorsTB.TabIndex = 1;
        this.TransmissionErrorsTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TransmissionErrorsLbl
        //
        this.TransmissionErrorsLbl.AutoSize = true;
        this.TransmissionErrorsLbl.Location = new System.Drawing.Point(6, 50);
        this.TransmissionErrorsLbl.Name = "TransmissionErrorsLbl";
        this.TransmissionErrorsLbl.Size = new System.Drawing.Size(100, 13);
        this.TransmissionErrorsLbl.TabIndex = 2;
        this.TransmissionErrorsLbl.Text = "Transmission errors:";
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
        // GXDLMSIEC14908PhysicalStatusView
        //
        this.ClientSize = new System.Drawing.Size(372, 337);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSIEC14908PhysicalStatusView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private GXValueField LostMessagesTB;
    private Label LostMessagesLbl;
    private GXValueField MessagesValidatedTB;
    private Label MessagesValidatedLbl;
    private GXValueField MessagesReceivedTB;
    private Label MessagesReceivedLbl;
    private GXValueField Layer3ReceivedTB;
    private Label Layer3ReceivedLbl;
    private GXValueField Layer2ReceivedTB;
    private Label Layer2ReceivedLbl;
    private GXValueField MissedMessagesTB;
    private Label MissedMessagesLbl;
}
}
