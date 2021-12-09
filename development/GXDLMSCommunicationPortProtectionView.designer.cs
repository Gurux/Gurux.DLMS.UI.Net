using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSCommunicationPortProtectionView
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
        private GXValueField ProtectionModeCb;
        private Label ProtectionModeLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSCommunicationPortProtectionView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ProtectionModeCb = new Gurux.DLMS.UI.GXValueField();
            this.ProtectionModeLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AllowedFailedAttemptsTb = new Gurux.DLMS.UI.GXValueField();
            this.AllowedFailedAttemptsLbl = new System.Windows.Forms.Label();
            this.InitialLockoutTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.InitialLockoutTimeLbl = new System.Windows.Forms.Label();
            this.SteepnessFactorTb = new Gurux.DLMS.UI.GXValueField();
            this.SteepnessFactorLbl = new System.Windows.Forms.Label();
            this.MaxLockoutTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.MaxLockoutTimeLbl = new System.Windows.Forms.Label();
            this.gxValueField5 = new Gurux.DLMS.UI.GXValueField();
            this.PortLbl = new System.Windows.Forms.Label();
            this.ProtectionStatusTb = new Gurux.DLMS.UI.GXValueField();
            this.ProtectionStatusLbl = new System.Windows.Forms.Label();
            this.FailedAttemptsTb = new Gurux.DLMS.UI.GXValueField();
            this.FailedAttemptsLbl = new System.Windows.Forms.Label();
            this.CumulativeFailedAttemptsTb = new Gurux.DLMS.UI.GXValueField();
            this.CumulativeFailedAttemptsLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CumulativeFailedAttemptsTb);
            this.groupBox1.Controls.Add(this.CumulativeFailedAttemptsLbl);
            this.groupBox1.Controls.Add(this.FailedAttemptsTb);
            this.groupBox1.Controls.Add(this.FailedAttemptsLbl);
            this.groupBox1.Controls.Add(this.ProtectionStatusTb);
            this.groupBox1.Controls.Add(this.ProtectionStatusLbl);
            this.groupBox1.Controls.Add(this.gxValueField5);
            this.groupBox1.Controls.Add(this.PortLbl);
            this.groupBox1.Controls.Add(this.MaxLockoutTimeTb);
            this.groupBox1.Controls.Add(this.MaxLockoutTimeLbl);
            this.groupBox1.Controls.Add(this.SteepnessFactorTb);
            this.groupBox1.Controls.Add(this.SteepnessFactorLbl);
            this.groupBox1.Controls.Add(this.InitialLockoutTimeTb);
            this.groupBox1.Controls.Add(this.InitialLockoutTimeLbl);
            this.groupBox1.Controls.Add(this.AllowedFailedAttemptsTb);
            this.groupBox1.Controls.Add(this.AllowedFailedAttemptsLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.ProtectionModeCb);
            this.groupBox1.Controls.Add(this.ProtectionModeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication port protection Object";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 5;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(150, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(282, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // ProtectionModeCb
            // 
            this.ProtectionModeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProtectionModeCb.Index = 2;
            this.ProtectionModeCb.Location = new System.Drawing.Point(150, 71);
            this.ProtectionModeCb.Name = "ProtectionModeCb";
            this.ProtectionModeCb.NotifyChanges = false;
            this.ProtectionModeCb.Size = new System.Drawing.Size(281, 82);
            this.ProtectionModeCb.TabIndex = 0;
            this.ProtectionModeCb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            this.ProtectionModeCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ProtectionModeCb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // ProtectionModeLbl
            // 
            this.ProtectionModeLbl.AutoSize = true;
            this.ProtectionModeLbl.Location = new System.Drawing.Point(7, 74);
            this.ProtectionModeLbl.Name = "ProtectionModeLbl";
            this.ProtectionModeLbl.Size = new System.Drawing.Size(88, 13);
            this.ProtectionModeLbl.TabIndex = 2;
            this.ProtectionModeLbl.Text = "Protection Mode:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(150, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(281, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(7, 48);
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
            // AllowedFailedAttemptsTb
            // 
            this.AllowedFailedAttemptsTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllowedFailedAttemptsTb.Index = 3;
            this.AllowedFailedAttemptsTb.Location = new System.Drawing.Point(150, 95);
            this.AllowedFailedAttemptsTb.Name = "AllowedFailedAttemptsTb";
            this.AllowedFailedAttemptsTb.NotifyChanges = false;
            this.AllowedFailedAttemptsTb.Size = new System.Drawing.Size(281, 82);
            this.AllowedFailedAttemptsTb.TabIndex = 6;
            this.AllowedFailedAttemptsTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // AllowedFailedAttemptsLbl
            // 
            this.AllowedFailedAttemptsLbl.AutoSize = true;
            this.AllowedFailedAttemptsLbl.Location = new System.Drawing.Point(6, 98);
            this.AllowedFailedAttemptsLbl.Name = "AllowedFailedAttemptsLbl";
            this.AllowedFailedAttemptsLbl.Size = new System.Drawing.Size(118, 13);
            this.AllowedFailedAttemptsLbl.TabIndex = 7;
            this.AllowedFailedAttemptsLbl.Text = "Allowed failed attempts:";
            // 
            // InitialLockoutTimeTb
            // 
            this.InitialLockoutTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialLockoutTimeTb.Index = 4;
            this.InitialLockoutTimeTb.Location = new System.Drawing.Point(150, 121);
            this.InitialLockoutTimeTb.Name = "InitialLockoutTimeTb";
            this.InitialLockoutTimeTb.NotifyChanges = false;
            this.InitialLockoutTimeTb.Size = new System.Drawing.Size(281, 82);
            this.InitialLockoutTimeTb.TabIndex = 8;
            this.InitialLockoutTimeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // InitialLockoutTimeLbl
            // 
            this.InitialLockoutTimeLbl.AutoSize = true;
            this.InitialLockoutTimeLbl.Location = new System.Drawing.Point(6, 124);
            this.InitialLockoutTimeLbl.Name = "InitialLockoutTimeLbl";
            this.InitialLockoutTimeLbl.Size = new System.Drawing.Size(94, 13);
            this.InitialLockoutTimeLbl.TabIndex = 9;
            this.InitialLockoutTimeLbl.Text = "Initial lockout time:";
            // 
            // SteepnessFactorTb
            // 
            this.SteepnessFactorTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SteepnessFactorTb.Index = 5;
            this.SteepnessFactorTb.Location = new System.Drawing.Point(150, 147);
            this.SteepnessFactorTb.Name = "SteepnessFactorTb";
            this.SteepnessFactorTb.NotifyChanges = false;
            this.SteepnessFactorTb.Size = new System.Drawing.Size(281, 82);
            this.SteepnessFactorTb.TabIndex = 10;
            this.SteepnessFactorTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // SteepnessFactorLbl
            // 
            this.SteepnessFactorLbl.AutoSize = true;
            this.SteepnessFactorLbl.Location = new System.Drawing.Point(7, 150);
            this.SteepnessFactorLbl.Name = "SteepnessFactorLbl";
            this.SteepnessFactorLbl.Size = new System.Drawing.Size(93, 13);
            this.SteepnessFactorLbl.TabIndex = 11;
            this.SteepnessFactorLbl.Text = "Steepness Factor:";
            // 
            // MaxLockoutTimeTb
            // 
            this.MaxLockoutTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxLockoutTimeTb.Index = 6;
            this.MaxLockoutTimeTb.Location = new System.Drawing.Point(150, 173);
            this.MaxLockoutTimeTb.Name = "MaxLockoutTimeTb";
            this.MaxLockoutTimeTb.NotifyChanges = false;
            this.MaxLockoutTimeTb.Size = new System.Drawing.Size(281, 82);
            this.MaxLockoutTimeTb.TabIndex = 12;
            this.MaxLockoutTimeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // MaxLockoutTimeLbl
            // 
            this.MaxLockoutTimeLbl.AutoSize = true;
            this.MaxLockoutTimeLbl.Location = new System.Drawing.Point(6, 176);
            this.MaxLockoutTimeLbl.Name = "MaxLockoutTimeLbl";
            this.MaxLockoutTimeLbl.Size = new System.Drawing.Size(98, 13);
            this.MaxLockoutTimeLbl.TabIndex = 13;
            this.MaxLockoutTimeLbl.Text = "Max Lockout Time:";
            // 
            // gxValueField5
            // 
            this.gxValueField5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField5.Index = 7;
            this.gxValueField5.Location = new System.Drawing.Point(150, 199);
            this.gxValueField5.Name = "gxValueField5";
            this.gxValueField5.NotifyChanges = false;
            this.gxValueField5.Size = new System.Drawing.Size(281, 82);
            this.gxValueField5.TabIndex = 14;
            this.gxValueField5.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PortLbl
            // 
            this.PortLbl.AutoSize = true;
            this.PortLbl.Location = new System.Drawing.Point(6, 202);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(29, 13);
            this.PortLbl.TabIndex = 15;
            this.PortLbl.Text = "Port:";
            // 
            // ProtectionStatusTb
            // 
            this.ProtectionStatusTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProtectionStatusTb.Index = 8;
            this.ProtectionStatusTb.Location = new System.Drawing.Point(150, 226);
            this.ProtectionStatusTb.Name = "ProtectionStatusTb";
            this.ProtectionStatusTb.NotifyChanges = false;
            this.ProtectionStatusTb.Size = new System.Drawing.Size(281, 82);
            this.ProtectionStatusTb.TabIndex = 16;
            this.ProtectionStatusTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // ProtectionStatusLbl
            // 
            this.ProtectionStatusLbl.AutoSize = true;
            this.ProtectionStatusLbl.Location = new System.Drawing.Point(7, 229);
            this.ProtectionStatusLbl.Name = "ProtectionStatusLbl";
            this.ProtectionStatusLbl.Size = new System.Drawing.Size(91, 13);
            this.ProtectionStatusLbl.TabIndex = 17;
            this.ProtectionStatusLbl.Text = "Protection Status:";
            // 
            // FailedAttemptsTb
            // 
            this.FailedAttemptsTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FailedAttemptsTb.Index = 9;
            this.FailedAttemptsTb.Location = new System.Drawing.Point(150, 250);
            this.FailedAttemptsTb.Name = "FailedAttemptsTb";
            this.FailedAttemptsTb.NotifyChanges = false;
            this.FailedAttemptsTb.Size = new System.Drawing.Size(281, 82);
            this.FailedAttemptsTb.TabIndex = 18;
            this.FailedAttemptsTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // FailedAttemptsLbl
            // 
            this.FailedAttemptsLbl.AutoSize = true;
            this.FailedAttemptsLbl.Location = new System.Drawing.Point(7, 253);
            this.FailedAttemptsLbl.Name = "FailedAttemptsLbl";
            this.FailedAttemptsLbl.Size = new System.Drawing.Size(82, 13);
            this.FailedAttemptsLbl.TabIndex = 19;
            this.FailedAttemptsLbl.Text = "Failed Attempts:";
            // 
            // CumulativeFailedAttemptsTb
            // 
            this.CumulativeFailedAttemptsTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CumulativeFailedAttemptsTb.Index = 10;
            this.CumulativeFailedAttemptsTb.Location = new System.Drawing.Point(150, 274);
            this.CumulativeFailedAttemptsTb.Name = "CumulativeFailedAttemptsTb";
            this.CumulativeFailedAttemptsTb.NotifyChanges = false;
            this.CumulativeFailedAttemptsTb.Size = new System.Drawing.Size(281, 34);
            this.CumulativeFailedAttemptsTb.TabIndex = 20;
            this.CumulativeFailedAttemptsTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // CumulativeFailedAttemptsLbl
            // 
            this.CumulativeFailedAttemptsLbl.AutoSize = true;
            this.CumulativeFailedAttemptsLbl.Location = new System.Drawing.Point(6, 277);
            this.CumulativeFailedAttemptsLbl.Name = "CumulativeFailedAttemptsLbl";
            this.CumulativeFailedAttemptsLbl.Size = new System.Drawing.Size(137, 13);
            this.CumulativeFailedAttemptsLbl.TabIndex = 21;
            this.CumulativeFailedAttemptsLbl.Text = "Cumulative Failed Attempts:";
            // 
            // GXDLMSCommunicationPortProtectionView
            // 
            this.ClientSize = new System.Drawing.Size(462, 333);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSCommunicationPortProtectionView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GXValueField CumulativeFailedAttemptsTb;
        private Label CumulativeFailedAttemptsLbl;
        private GXValueField FailedAttemptsTb;
        private Label FailedAttemptsLbl;
        private GXValueField ProtectionStatusTb;
        private Label ProtectionStatusLbl;
        private GXValueField gxValueField5;
        private Label PortLbl;
        private GXValueField MaxLockoutTimeTb;
        private Label MaxLockoutTimeLbl;
        private GXValueField SteepnessFactorTb;
        private Label SteepnessFactorLbl;
        private GXValueField InitialLockoutTimeTb;
        private Label InitialLockoutTimeLbl;
        private GXValueField AllowedFailedAttemptsTb;
        private Label AllowedFailedAttemptsLbl;
    }
}
