using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSSFSKActiveInitiatorView
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
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSFSKActiveInitiatorView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.LSAPSelectorTB = new System.Windows.Forms.TextBox();
        this.MACAddressTB = new System.Windows.Forms.TextBox();
        this.SystemTitleTB = new System.Windows.Forms.TextBox();
        this.SystemTitleLbl = new System.Windows.Forms.Label();
        this.MACAddressLbl = new System.Windows.Forms.Label();
        this.LSAPSelectorLbl = new System.Windows.Forms.Label();
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
        this.groupBox1.Controls.Add(this.LSAPSelectorTB);
        this.groupBox1.Controls.Add(this.MACAddressTB);
        this.groupBox1.Controls.Add(this.SystemTitleTB);
        this.groupBox1.Controls.Add(this.SystemTitleLbl);
        this.groupBox1.Controls.Add(this.MACAddressLbl);
        this.groupBox1.Controls.Add(this.LSAPSelectorLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 138);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "S-FSK Active initiator Object:";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // LSAPSelectorTB
        //
        this.LSAPSelectorTB.Location = new System.Drawing.Point(136, 99);
        this.LSAPSelectorTB.Name = "LSAPSelectorTB";
        this.LSAPSelectorTB.Size = new System.Drawing.Size(206, 20);
        this.LSAPSelectorTB.TabIndex = 3;
        //
        // MACAddressTB
        //
        this.MACAddressTB.Location = new System.Drawing.Point(136, 73);
        this.MACAddressTB.Name = "MACAddressTB";
        this.MACAddressTB.Size = new System.Drawing.Size(206, 20);
        this.MACAddressTB.TabIndex = 2;
        //
        // SystemTitleTB
        //
        this.SystemTitleTB.Location = new System.Drawing.Point(136, 47);
        this.SystemTitleTB.Name = "SystemTitleTB";
        this.SystemTitleTB.Size = new System.Drawing.Size(206, 20);
        this.SystemTitleTB.TabIndex = 1;
        //
        // SystemTitleLbl
        //
        this.SystemTitleLbl.AutoSize = true;
        this.SystemTitleLbl.Location = new System.Drawing.Point(6, 50);
        this.SystemTitleLbl.Name = "SystemTitleLbl";
        this.SystemTitleLbl.Size = new System.Drawing.Size(67, 13);
        this.SystemTitleLbl.TabIndex = 6;
        this.SystemTitleLbl.Text = "System Title:";
        //
        // MACAddressLbl
        //
        this.MACAddressLbl.AutoSize = true;
        this.MACAddressLbl.Location = new System.Drawing.Point(6, 76);
        this.MACAddressLbl.Name = "MACAddressLbl";
        this.MACAddressLbl.Size = new System.Drawing.Size(73, 13);
        this.MACAddressLbl.TabIndex = 4;
        this.MACAddressLbl.Text = "MAC address:";
        //
        // LSAPSelectorLbl
        //
        this.LSAPSelectorLbl.AutoSize = true;
        this.LSAPSelectorLbl.Location = new System.Drawing.Point(6, 102);
        this.LSAPSelectorLbl.Name = "LSAPSelectorLbl";
        this.LSAPSelectorLbl.Size = new System.Drawing.Size(82, 13);
        this.LSAPSelectorLbl.TabIndex = 2;
        this.LSAPSelectorLbl.Text = "L SAP Selector:";
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
        // GXDLMSSFSKActiveInitiatorView
        //
        this.ClientSize = new System.Drawing.Size(372, 164);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSSFSKActiveInitiatorView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion
    private Label SystemTitleLbl;
    private Label MACAddressLbl;
    private Label LSAPSelectorLbl;
    private TextBox LSAPSelectorTB;
    private TextBox MACAddressTB;
    private TextBox SystemTitleTB;
}
}
