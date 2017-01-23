using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
public partial class GXDLMSIEC14908PhysicalSetupView
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
    private Label PLCInactivityTimeoutLbl;
    private GXValueField LogicalNameTB;
    private GXValueField PLCInactivityTimeoutTB;
    private ErrorProvider errorProvider1;
    private Label LogicalNameLbl;

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIEC14908PhysicalSetupView));
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.PLCInactivityTimeoutTB = new Gurux.DLMS.UI.GXValueField();
        this.PLCInactivityTimeoutLbl = new System.Windows.Forms.Label();
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
        this.groupBox1.Controls.Add(this.PLCInactivityTimeoutTB);
        this.groupBox1.Controls.Add(this.PLCInactivityTimeoutLbl);
        this.groupBox1.Controls.Add(this.LogicalNameTB);
        this.groupBox1.Controls.Add(this.LogicalNameLbl);
        this.groupBox1.Location = new System.Drawing.Point(12, 12);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(348, 85);
        this.groupBox1.TabIndex = 0;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = " IEC 14908 Physical Setup";
        this.groupBox1.UseCompatibleTextRendering = true;
        //
        // PLCInactivityTimeoutTB
        //
        this.PLCInactivityTimeoutTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                              | System.Windows.Forms.AnchorStyles.Right)));
        this.PLCInactivityTimeoutTB.Index = 2;
        this.PLCInactivityTimeoutTB.Location = new System.Drawing.Point(136, 47);
        this.PLCInactivityTimeoutTB.Name = "PLCInactivityTimeoutTB";
        this.PLCInactivityTimeoutTB.Size = new System.Drawing.Size(206, 20);
        this.PLCInactivityTimeoutTB.TabIndex = 1;
        this.PLCInactivityTimeoutTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
        //
        // PLCInactivityTimeoutLbl
        //
        this.PLCInactivityTimeoutLbl.AutoSize = true;
        this.PLCInactivityTimeoutLbl.Location = new System.Drawing.Point(6, 50);
        this.PLCInactivityTimeoutLbl.Name = "PLCInactivityTimeoutLbl";
        this.PLCInactivityTimeoutLbl.Size = new System.Drawing.Size(111, 13);
        this.PLCInactivityTimeoutLbl.TabIndex = 2;
        this.PLCInactivityTimeoutLbl.Text = "PLC inactivity timeout:";
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
        // GXDLMSIEC14908PhysicalSetupView
        //
        this.ClientSize = new System.Drawing.Size(372, 117);
        this.Controls.Add(this.groupBox1);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        this.Name = "GXDLMSIEC14908PhysicalSetupView";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion
}
}
