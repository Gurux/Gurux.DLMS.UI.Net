using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSIEC14908IdentificationView
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
    private Label NodeIdLbl;
    private GXValueField LogicalNameTB;
    private GXValueField ProgramIdTB;
    private Label ProgramIdLbl;
    private GXValueField DomainIdTB;
    private Label DomainIdLbl;
    private GXValueField SubnetIdTB;
    private Label SubnetIdLbl;
    private GXValueField NodeIdTB;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIEC14908IdentificationView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.UniqueNodeIdLbl = new System.Windows.Forms.Label();
        this.ProgramIdLbl = new System.Windows.Forms.Label();
        this.DomainIdLbl = new System.Windows.Forms.Label();
        this.SubnetIdLbl = new System.Windows.Forms.Label();
        this.NodeIdLbl = new System.Windows.Forms.Label();
        this.LogicalNameLbl = new System.Windows.Forms.Label();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        this.UniqueNodeIdTb = new Gurux.DLMS.UI.GXValueField();
        this.ProgramIdTB = new Gurux.DLMS.UI.GXValueField();
        this.DomainIdTB = new Gurux.DLMS.UI.GXValueField();
        this.SubnetIdTB = new Gurux.DLMS.UI.GXValueField();
        this.NodeIdTB = new Gurux.DLMS.UI.GXValueField();
        this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();
        //
        // groupBox1
        //
        this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                 | System.Windows.Forms.AnchorStyles.Right)));
        this.groupBox1.Controls.Add(this.UniqueNodeIdTb);
        this.groupBox1.Controls.Add(this.UniqueNodeIdLbl);
        this.groupBox1.Controls.Add(this.ProgramIdTB);
        this.groupBox1.Controls.Add(this.ProgramIdLbl);
        this.groupBox1.Controls.Add(this.DomainIdTB);
        this.groupBox1.Controls.Add(this.DomainIdLbl);
        this.groupBox1.Controls.Add(this.SubnetIdTB);
        this.groupBox1.Controls.Add(this.SubnetIdLbl);
        this.groupBox1.Controls.Add(this.NodeIdTB);
        this.groupBox1.Controls.Add(this.NodeIdLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 183);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = " IEC 14908 identification Object";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // UniqueNodeIdLbl
        //
        this.UniqueNodeIdLbl.AutoSize = true;
        this.UniqueNodeIdLbl.Location = new System.Drawing.Point(6, 154);
        this.UniqueNodeIdLbl.Name = "UniqueNodeIdLbl";
        this.UniqueNodeIdLbl.Size = new System.Drawing.Size(87, 13);
        this.UniqueNodeIdLbl.TabIndex = 10;
        this.UniqueNodeIdLbl.Text = "Unique Node ID:";
        //
        // ProgramIdLbl
        //
        this.ProgramIdLbl.AutoSize = true;
        this.ProgramIdLbl.Location = new System.Drawing.Point(6, 128);
        this.ProgramIdLbl.Name = "ProgramIdLbl";
        this.ProgramIdLbl.Size = new System.Drawing.Size(63, 13);
        this.ProgramIdLbl.TabIndex = 8;
        this.ProgramIdLbl.Text = "Program ID:";
        //
        // DomainIdLbl
        //
        this.DomainIdLbl.AutoSize = true;
        this.DomainIdLbl.Location = new System.Drawing.Point(6, 102);
        this.DomainIdLbl.Name = "DomainIdLbl";
        this.DomainIdLbl.Size = new System.Drawing.Size(60, 13);
        this.DomainIdLbl.TabIndex = 6;
        this.DomainIdLbl.Text = "Domain ID:";
        //
        // SubnetIdLbl
        //
        this.SubnetIdLbl.AutoSize = true;
        this.SubnetIdLbl.Location = new System.Drawing.Point(6, 76);
        this.SubnetIdLbl.Name = "SubnetIdLbl";
        this.SubnetIdLbl.Size = new System.Drawing.Size(58, 13);
        this.SubnetIdLbl.TabIndex = 4;
        this.SubnetIdLbl.Text = "Subnet ID:";
        //
        // NodeIdLbl
        //
        this.NodeIdLbl.AutoSize = true;
        this.NodeIdLbl.Location = new System.Drawing.Point(6, 50);
        this.NodeIdLbl.Name = "NodeIdLbl";
        this.NodeIdLbl.Size = new System.Drawing.Size(50, 13);
        this.NodeIdLbl.TabIndex = 2;
        this.NodeIdLbl.Text = "Node ID:";
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
        // UniqueNodeIdTb
        //
        this.UniqueNodeIdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                      | System.Windows.Forms.AnchorStyles.Right)));
        this.UniqueNodeIdTb.Index = 7;
        this.UniqueNodeIdTb.Location = new System.Drawing.Point(136, 151);
        this.UniqueNodeIdTb.Name = "UniqueNodeIdTb";
        this.UniqueNodeIdTb.Size = new System.Drawing.Size(206, 20);
        this.UniqueNodeIdTb.TabIndex = 9;
        this.UniqueNodeIdTb.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // ProgramIdTB
        //
        this.ProgramIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
        this.ProgramIdTB.Index = 6;
        this.ProgramIdTB.Location = new System.Drawing.Point(136, 125);
        this.ProgramIdTB.Name = "ProgramIdTB";
        this.ProgramIdTB.Size = new System.Drawing.Size(206, 20);
        this.ProgramIdTB.TabIndex = 4;
        this.ProgramIdTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // DomainIdTB
        //
        this.DomainIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                  | System.Windows.Forms.AnchorStyles.Right)));
        this.DomainIdTB.Index = 4;
        this.DomainIdTB.Location = new System.Drawing.Point(136, 99);
        this.DomainIdTB.Name = "DomainIdTB";
        this.DomainIdTB.Size = new System.Drawing.Size(206, 20);
        this.DomainIdTB.TabIndex = 3;
        this.DomainIdTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // SubnetIdTB
        //
        this.SubnetIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                  | System.Windows.Forms.AnchorStyles.Right)));
        this.SubnetIdTB.Index = 3;
        this.SubnetIdTB.Location = new System.Drawing.Point(136, 73);
        this.SubnetIdTB.Name = "SubnetIdTB";
        this.SubnetIdTB.Size = new System.Drawing.Size(206, 20);
        this.SubnetIdTB.TabIndex = 2;
        this.SubnetIdTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // NodeIdTB
        //
        this.NodeIdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                | System.Windows.Forms.AnchorStyles.Right)));
        this.NodeIdTB.Index = 2;
        this.NodeIdTB.Location = new System.Drawing.Point(136, 47);
        this.NodeIdTB.Name = "NodeIdTB";
        this.NodeIdTB.Size = new System.Drawing.Size(206, 20);
        this.NodeIdTB.TabIndex = 1;
        this.NodeIdTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
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
        // GXDLMSIEC14908IdentificationView
        //
        this.ClientSize = new System.Drawing.Size(372, 219);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSIEC14908IdentificationView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private GXValueField UniqueNodeIdTb;
    private Label UniqueNodeIdLbl;
}
}
