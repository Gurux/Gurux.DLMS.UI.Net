using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPppSetupView
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
        private Label PHYReferenceLbl;
        private GXValueField LogicalNameTB;
        private Label UserNameLbl;
        private GXValueField IPCPOptionsTB;
        private Label IPCPOptionsLbl;
        private GXValueField LCPOptionsTB;
        private Label LCPOptionsLbl;
        private GXValueField PHYReferenceTB;
        private ErrorProvider errorProvider1;
        private Label PasswordLbl;
        private TextBox PasswordTB;
        private TextBox UserNameTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPppSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.IPCPOptionsTB = new Gurux.DLMS.UI.GXValueField();
            this.IPCPOptionsLbl = new System.Windows.Forms.Label();
            this.LCPOptionsTB = new Gurux.DLMS.UI.GXValueField();
            this.LCPOptionsLbl = new System.Windows.Forms.Label();
            this.PHYReferenceTB = new Gurux.DLMS.UI.GXValueField();
            this.PHYReferenceLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PasswordTB);
            this.groupBox1.Controls.Add(this.UserNameTB);
            this.groupBox1.Controls.Add(this.PasswordLbl);
            this.groupBox1.Controls.Add(this.UserNameLbl);
            this.groupBox1.Controls.Add(this.IPCPOptionsTB);
            this.groupBox1.Controls.Add(this.IPCPOptionsLbl);
            this.groupBox1.Controls.Add(this.LCPOptionsTB);
            this.groupBox1.Controls.Add(this.LCPOptionsLbl);
            this.groupBox1.Controls.Add(this.PHYReferenceTB);
            this.groupBox1.Controls.Add(this.PHYReferenceLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PPP Setup Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            //
            // PasswordLbl
            //
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(6, 154);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(56, 13);
            this.PasswordLbl.TabIndex = 10;
            this.PasswordLbl.Text = "Password:";
            //
            // UserNameLbl
            //
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.Location = new System.Drawing.Point(6, 128);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(63, 13);
            this.UserNameLbl.TabIndex = 8;
            this.UserNameLbl.Text = "User Name:";
            //
            // IPCPOptionsTB
            //
            this.IPCPOptionsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.IPCPOptionsTB.Index = 4;
            this.IPCPOptionsTB.Location = new System.Drawing.Point(114, 99);
            this.IPCPOptionsTB.Name = "IPCPOptionsTB";
            this.IPCPOptionsTB.Size = new System.Drawing.Size(171, 20);
            this.IPCPOptionsTB.TabIndex = 7;
            this.IPCPOptionsTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // IPCPOptionsLbl
            //
            this.IPCPOptionsLbl.AutoSize = true;
            this.IPCPOptionsLbl.Location = new System.Drawing.Point(6, 102);
            this.IPCPOptionsLbl.Name = "IPCPOptionsLbl";
            this.IPCPOptionsLbl.Size = new System.Drawing.Size(73, 13);
            this.IPCPOptionsLbl.TabIndex = 6;
            this.IPCPOptionsLbl.Text = "IPCP Options:";
            //
            // LCPOptionsTB
            //
            this.LCPOptionsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LCPOptionsTB.Index = 3;
            this.LCPOptionsTB.Location = new System.Drawing.Point(114, 73);
            this.LCPOptionsTB.Name = "LCPOptionsTB";
            this.LCPOptionsTB.Size = new System.Drawing.Size(171, 20);
            this.LCPOptionsTB.TabIndex = 5;
            this.LCPOptionsTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // LCPOptionsLbl
            //
            this.LCPOptionsLbl.AutoSize = true;
            this.LCPOptionsLbl.Location = new System.Drawing.Point(6, 76);
            this.LCPOptionsLbl.Name = "LCPOptionsLbl";
            this.LCPOptionsLbl.Size = new System.Drawing.Size(69, 13);
            this.LCPOptionsLbl.TabIndex = 4;
            this.LCPOptionsLbl.Text = "LCP Options:";
            //
            // PHYReferenceTB
            //
            this.PHYReferenceTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
            this.PHYReferenceTB.Index = 2;
            this.PHYReferenceTB.Location = new System.Drawing.Point(114, 47);
            this.PHYReferenceTB.Name = "PHYReferenceTB";
            this.PHYReferenceTB.Size = new System.Drawing.Size(171, 20);
            this.PHYReferenceTB.TabIndex = 3;
            this.PHYReferenceTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            this.PHYReferenceTB.Load += new System.EventHandler(this.DataLinkLayerTB_Load);
            //
            // PHYReferenceLbl
            //
            this.PHYReferenceLbl.AutoSize = true;
            this.PHYReferenceLbl.Location = new System.Drawing.Point(6, 50);
            this.PHYReferenceLbl.Name = "PHYReferenceLbl";
            this.PHYReferenceLbl.Size = new System.Drawing.Size(85, 13);
            this.PHYReferenceLbl.TabIndex = 2;
            this.PHYReferenceLbl.Text = "PHY Reference:";
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(114, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(171, 20);
            this.LogicalNameTB.TabIndex = 1;
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
            // UserNameTB
            //
            this.UserNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameTB.Location = new System.Drawing.Point(115, 126);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(170, 20);
            this.UserNameTB.TabIndex = 12;
            //
            // PasswordTB
            //
            this.PasswordTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTB.Location = new System.Drawing.Point(116, 152);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(170, 20);
            this.PasswordTB.TabIndex = 13;
            //
            // GXDLMSPppSetupView
            //
            this.ClientSize = new System.Drawing.Size(320, 211);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPppSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
