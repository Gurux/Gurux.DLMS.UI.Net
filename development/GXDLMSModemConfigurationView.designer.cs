using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSModemConfigurationView
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
        private GXValueField CommunicationSpeedTB;
        private Label CommunicationSpeedLbl;
        private GXValueField LogicalNameTB;
        private TextBox ModemProfileTB;
        private Label ModemProfileLbl;
        private Label InitialisationLbl;
        private ErrorProvider errorProvider1;
        private TextBox InitialisationTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSModemConfigurationView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModemProfileTB = new System.Windows.Forms.TextBox();
            this.ModemProfileLbl = new System.Windows.Forms.Label();
            this.InitialisationTB = new System.Windows.Forms.TextBox();
            this.InitialisationLbl = new System.Windows.Forms.Label();
            this.CommunicationSpeedTB = new Gurux.DLMS.UI.GXValueField();
            this.CommunicationSpeedLbl = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.ModemProfileTB);
            this.groupBox1.Controls.Add(this.ModemProfileLbl);
            this.groupBox1.Controls.Add(this.InitialisationTB);
            this.groupBox1.Controls.Add(this.InitialisationLbl);
            this.groupBox1.Controls.Add(this.CommunicationSpeedTB);
            this.groupBox1.Controls.Add(this.CommunicationSpeedLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modem Configuration Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            //
            // ModemProfileTB
            //
            this.ModemProfileTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
            this.ModemProfileTB.Location = new System.Drawing.Point(102, 161);
            this.ModemProfileTB.Multiline = true;
            this.ModemProfileTB.Name = "ModemProfileTB";
            this.ModemProfileTB.ReadOnly = true;
            this.ModemProfileTB.Size = new System.Drawing.Size(175, 82);
            this.ModemProfileTB.TabIndex = 5;
            //
            // ModemProfileLbl
            //
            this.ModemProfileLbl.AutoSize = true;
            this.ModemProfileLbl.Location = new System.Drawing.Point(6, 164);
            this.ModemProfileLbl.Name = "ModemProfileLbl";
            this.ModemProfileLbl.Size = new System.Drawing.Size(77, 13);
            this.ModemProfileLbl.TabIndex = 6;
            this.ModemProfileLbl.Text = "Modem Profile:";
            //
            // InitialisationTB
            //
            this.InitialisationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialisationTB.Location = new System.Drawing.Point(102, 73);
            this.InitialisationTB.Multiline = true;
            this.InitialisationTB.Name = "InitialisationTB";
            this.InitialisationTB.ReadOnly = true;
            this.InitialisationTB.Size = new System.Drawing.Size(175, 82);
            this.InitialisationTB.TabIndex = 3;
            //
            // InitialisationLbl
            //
            this.InitialisationLbl.AutoSize = true;
            this.InitialisationLbl.Location = new System.Drawing.Point(6, 76);
            this.InitialisationLbl.Name = "InitialisationLbl";
            this.InitialisationLbl.Size = new System.Drawing.Size(64, 13);
            this.InitialisationLbl.TabIndex = 4;
            this.InitialisationLbl.Text = "Initialisation:";
            //
            // CommunicationSpeedTB
            //
            this.CommunicationSpeedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                | System.Windows.Forms.AnchorStyles.Right)));
            this.CommunicationSpeedTB.Index = 2;
            this.CommunicationSpeedTB.Location = new System.Drawing.Point(102, 47);
            this.CommunicationSpeedTB.Name = "CommunicationSpeedTB";
            this.CommunicationSpeedTB.Size = new System.Drawing.Size(175, 20);
            this.CommunicationSpeedTB.TabIndex = 0;
            this.CommunicationSpeedTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // CommunicationSpeedLbl
            //
            this.CommunicationSpeedLbl.AutoSize = true;
            this.CommunicationSpeedLbl.Location = new System.Drawing.Point(6, 50);
            this.CommunicationSpeedLbl.Name = "CommunicationSpeedLbl";
            this.CommunicationSpeedLbl.Size = new System.Drawing.Size(41, 13);
            this.CommunicationSpeedLbl.TabIndex = 2;
            this.CommunicationSpeedLbl.Text = "Speed:";
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(175, 20);
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
            // GXDLMSModemConfigurationView
            //
            this.ClientSize = new System.Drawing.Size(314, 270);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSModemConfigurationView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
