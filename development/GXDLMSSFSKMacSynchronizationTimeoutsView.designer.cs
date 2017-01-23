using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSSFSKMacSynchronizationTimeoutsView
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
    private Label SearchInitiatorTimeoutLbl;
    private GXValueField LogicalNameTB;
    private GXValueField TimeOutFrameNotOKTB;
    private Label TimeOutFrameNotOKLbl;
    private GXValueField TimeOutNotAddressedTB;
    private Label TimeOutNotAddressedLbl;
    private GXValueField SynchronizationConfirmationTimeoutTB;
    private Label SynchronizationConfirmationTimeoutLbl;
    private GXValueField SearchInitiatorTimeoutTB;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSFSKMacSynchronizationTimeoutsView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.TimeOutFrameNotOKTB = new Gurux.DLMS.UI.GXValueField();
        this.TimeOutFrameNotOKLbl = new System.Windows.Forms.Label();
        this.TimeOutNotAddressedTB = new Gurux.DLMS.UI.GXValueField();
        this.TimeOutNotAddressedLbl = new System.Windows.Forms.Label();
        this.SynchronizationConfirmationTimeoutTB = new Gurux.DLMS.UI.GXValueField();
        this.SynchronizationConfirmationTimeoutLbl = new System.Windows.Forms.Label();
        this.SearchInitiatorTimeoutTB = new Gurux.DLMS.UI.GXValueField();
        this.SearchInitiatorTimeoutLbl = new System.Windows.Forms.Label();
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
        this.groupBox1.Controls.Add(this.TimeOutFrameNotOKTB);
        this.groupBox1.Controls.Add(this.TimeOutFrameNotOKLbl);
        this.groupBox1.Controls.Add(this.TimeOutNotAddressedTB);
        this.groupBox1.Controls.Add(this.TimeOutNotAddressedLbl);
        this.groupBox1.Controls.Add(this.SynchronizationConfirmationTimeoutTB);
        this.groupBox1.Controls.Add(this.SynchronizationConfirmationTimeoutLbl);
        this.groupBox1.Controls.Add(this.SearchInitiatorTimeoutTB);
        this.groupBox1.Controls.Add(this.SearchInitiatorTimeoutLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 158);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = " S-FSK MAC synchronization timeouts Object";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // TimeOutFrameNotOKTB
        //
        this.TimeOutFrameNotOKTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                           | System.Windows.Forms.AnchorStyles.Right)));
        this.TimeOutFrameNotOKTB.Index = 5;
        this.TimeOutFrameNotOKTB.Location = new System.Drawing.Point(136, 125);
        this.TimeOutFrameNotOKTB.Name = "TimeOutFrameNotOKTB";
        this.TimeOutFrameNotOKTB.Size = new System.Drawing.Size(206, 20);
        this.TimeOutFrameNotOKTB.TabIndex = 4;
        this.TimeOutFrameNotOKTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TimeOutFrameNotOKLbl
        //
        this.TimeOutFrameNotOKLbl.AutoSize = true;
        this.TimeOutFrameNotOKLbl.Location = new System.Drawing.Point(6, 128);
        this.TimeOutFrameNotOKLbl.Name = "TimeOutFrameNotOKLbl";
        this.TimeOutFrameNotOKLbl.Size = new System.Drawing.Size(119, 13);
        this.TimeOutFrameNotOKLbl.TabIndex = 8;
        this.TimeOutFrameNotOKLbl.Text = "Timeuout frame not OK:";
        //
        // TimeOutNotAddressedTB
        //
        this.TimeOutNotAddressedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                             | System.Windows.Forms.AnchorStyles.Right)));
        this.TimeOutNotAddressedTB.Index = 4;
        this.TimeOutNotAddressedTB.Location = new System.Drawing.Point(136, 99);
        this.TimeOutNotAddressedTB.Name = "TimeOutNotAddressedTB";
        this.TimeOutNotAddressedTB.Size = new System.Drawing.Size(206, 20);
        this.TimeOutNotAddressedTB.TabIndex = 3;
        this.TimeOutNotAddressedTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // TimeOutNotAddressedLbl
        //
        this.TimeOutNotAddressedLbl.AutoSize = true;
        this.TimeOutNotAddressedLbl.Location = new System.Drawing.Point(6, 102);
        this.TimeOutNotAddressedLbl.Name = "TimeOutNotAddressedLbl";
        this.TimeOutNotAddressedLbl.Size = new System.Drawing.Size(118, 13);
        this.TimeOutNotAddressedLbl.TabIndex = 6;
        this.TimeOutNotAddressedLbl.Text = "Timeout not addressed:";
        //
        // SynchronizationConfirmationTimeoutTB
        //
        this.SynchronizationConfirmationTimeoutTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
        this.SynchronizationConfirmationTimeoutTB.Index = 3;
        this.SynchronizationConfirmationTimeoutTB.Location = new System.Drawing.Point(136, 73);
        this.SynchronizationConfirmationTimeoutTB.Name = "SynchronizationConfirmationTimeoutTB";
        this.SynchronizationConfirmationTimeoutTB.Size = new System.Drawing.Size(206, 20);
        this.SynchronizationConfirmationTimeoutTB.TabIndex = 2;
        this.SynchronizationConfirmationTimeoutTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // SynchronizationConfirmationTimeoutLbl
        //
        this.SynchronizationConfirmationTimeoutLbl.AutoSize = true;
        this.SynchronizationConfirmationTimeoutLbl.Location = new System.Drawing.Point(6, 76);
        this.SynchronizationConfirmationTimeoutLbl.Name = "SynchronizationConfirmationTimeoutLbl";
        this.SynchronizationConfirmationTimeoutLbl.Size = new System.Drawing.Size(109, 13);
        this.SynchronizationConfirmationTimeoutLbl.TabIndex = 4;
        this.SynchronizationConfirmationTimeoutLbl.Text = "Confirmation Timeout:";
        //
        // SearchInitiatorTimeoutTB
        //
        this.SearchInitiatorTimeoutTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                | System.Windows.Forms.AnchorStyles.Right)));
        this.SearchInitiatorTimeoutTB.Index = 2;
        this.SearchInitiatorTimeoutTB.Location = new System.Drawing.Point(136, 47);
        this.SearchInitiatorTimeoutTB.Name = "SearchInitiatorTimeoutTB";
        this.SearchInitiatorTimeoutTB.Size = new System.Drawing.Size(206, 20);
        this.SearchInitiatorTimeoutTB.TabIndex = 1;
        this.SearchInitiatorTimeoutTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // SearchInitiatorTimeoutLbl
        //
        this.SearchInitiatorTimeoutLbl.AutoSize = true;
        this.SearchInitiatorTimeoutLbl.Location = new System.Drawing.Point(6, 50);
        this.SearchInitiatorTimeoutLbl.Name = "SearchInitiatorTimeoutLbl";
        this.SearchInitiatorTimeoutLbl.Size = new System.Drawing.Size(117, 13);
        this.SearchInitiatorTimeoutLbl.TabIndex = 2;
        this.SearchInitiatorTimeoutLbl.Text = "Search initiator timeout:";
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
        // GXDLMSSFSKMacSynchronizationTimeoutsView
        //
        this.ClientSize = new System.Drawing.Size(372, 181);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSSFSKMacSynchronizationTimeoutsView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion
}
}
