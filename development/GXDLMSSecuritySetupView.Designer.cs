using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSSecuritySetupView
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
        private GXValueField SecurityPolicyTB;
        private Label SecurityPolicyLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private GXValueField SuiteTB;
        private Label SuiteLbl;
        private GXValueField ServerSystemTitleTB;
        private Label ServerSystemTitleLbl;
        private GXValueField ClientSystemTitleTB;
        private Label ClientSystemTitleLbl;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSecuritySetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateKeyBtn = new Gurux.DLMS.UI.GXButton();
            this.ActivateSecurityBtn = new Gurux.DLMS.UI.GXButton();
            this.ServerSystemTitleTB = new Gurux.DLMS.UI.GXValueField();
            this.ServerSystemTitleLbl = new System.Windows.Forms.Label();
            this.ClientSystemTitleTB = new Gurux.DLMS.UI.GXValueField();
            this.ClientSystemTitleLbl = new System.Windows.Forms.Label();
            this.SuiteTB = new Gurux.DLMS.UI.GXValueField();
            this.SuiteLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.SecurityPolicyTB = new Gurux.DLMS.UI.GXValueField();
            this.SecurityPolicyLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UpdateKeyBtn);
            this.groupBox1.Controls.Add(this.ActivateSecurityBtn);
            this.groupBox1.Controls.Add(this.ServerSystemTitleTB);
            this.groupBox1.Controls.Add(this.ServerSystemTitleLbl);
            this.groupBox1.Controls.Add(this.ClientSystemTitleTB);
            this.groupBox1.Controls.Add(this.ClientSystemTitleLbl);
            this.groupBox1.Controls.Add(this.SuiteTB);
            this.groupBox1.Controls.Add(this.SuiteLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.SecurityPolicyTB);
            this.groupBox1.Controls.Add(this.SecurityPolicyLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Setup Object";
            // 
            // UpdateKeyBtn
            // 
            this.UpdateKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateKeyBtn.Index = 2;
            this.UpdateKeyBtn.Location = new System.Drawing.Point(249, 270);
            this.UpdateKeyBtn.Name = "UpdateKeyBtn";
            this.UpdateKeyBtn.Size = new System.Drawing.Size(103, 23);
            this.UpdateKeyBtn.TabIndex = 5;
            this.UpdateKeyBtn.Text = "Update Key...";
            this.UpdateKeyBtn.UseVisualStyleBackColor = true;
            // 
            // ActivateSecurityBtn
            // 
            this.ActivateSecurityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivateSecurityBtn.Index = 1;
            this.ActivateSecurityBtn.Location = new System.Drawing.Point(277, 148);
            this.ActivateSecurityBtn.Name = "ActivateSecurityBtn";
            this.ActivateSecurityBtn.Size = new System.Drawing.Size(75, 23);
            this.ActivateSecurityBtn.TabIndex = 6;
            this.ActivateSecurityBtn.Text = "Activate Security";
            this.ActivateSecurityBtn.UseVisualStyleBackColor = true;
            // 
            // ServerSystemTitleTB
            // 
            this.ServerSystemTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSystemTitleTB.Index = 5;
            this.ServerSystemTitleTB.Location = new System.Drawing.Point(104, 124);
            this.ServerSystemTitleTB.Name = "ServerSystemTitleTB";
            this.ServerSystemTitleTB.NotifyChanges = false;
            this.ServerSystemTitleTB.Size = new System.Drawing.Size(249, 20);
            this.ServerSystemTitleTB.TabIndex = 3;
            this.ServerSystemTitleTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ServerSystemTitleLbl
            // 
            this.ServerSystemTitleLbl.AutoSize = true;
            this.ServerSystemTitleLbl.Location = new System.Drawing.Point(7, 127);
            this.ServerSystemTitleLbl.Name = "ServerSystemTitleLbl";
            this.ServerSystemTitleLbl.Size = new System.Drawing.Size(101, 13);
            this.ServerSystemTitleLbl.TabIndex = 11;
            this.ServerSystemTitleLbl.Text = "Server System Title:";
            // 
            // ClientSystemTitleTB
            // 
            this.ClientSystemTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSystemTitleTB.Index = 4;
            this.ClientSystemTitleTB.Location = new System.Drawing.Point(104, 98);
            this.ClientSystemTitleTB.Name = "ClientSystemTitleTB";
            this.ClientSystemTitleTB.NotifyChanges = false;
            this.ClientSystemTitleTB.Size = new System.Drawing.Size(249, 20);
            this.ClientSystemTitleTB.TabIndex = 2;
            this.ClientSystemTitleTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ClientSystemTitleLbl
            // 
            this.ClientSystemTitleLbl.AutoSize = true;
            this.ClientSystemTitleLbl.Location = new System.Drawing.Point(7, 101);
            this.ClientSystemTitleLbl.Name = "ClientSystemTitleLbl";
            this.ClientSystemTitleLbl.Size = new System.Drawing.Size(96, 13);
            this.ClientSystemTitleLbl.TabIndex = 9;
            this.ClientSystemTitleLbl.Text = "Client System Title:";
            // 
            // SuiteTB
            // 
            this.SuiteTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuiteTB.Index = 3;
            this.SuiteTB.Location = new System.Drawing.Point(104, 72);
            this.SuiteTB.Name = "SuiteTB";
            this.SuiteTB.NotifyChanges = false;
            this.SuiteTB.ReadOnly = true;
            this.SuiteTB.Size = new System.Drawing.Size(249, 72);
            this.SuiteTB.TabIndex = 0;
            this.SuiteTB.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // SuiteLbl
            // 
            this.SuiteLbl.AutoSize = true;
            this.SuiteLbl.Location = new System.Drawing.Point(7, 75);
            this.SuiteLbl.Name = "SuiteLbl";
            this.SuiteLbl.Size = new System.Drawing.Size(34, 13);
            this.SuiteLbl.TabIndex = 7;
            this.SuiteLbl.Text = "Suite:";
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
            this.DescriptionTB.Location = new System.Drawing.Point(103, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(250, 20);
            this.DescriptionTB.TabIndex = 7;
            // 
            // SecurityPolicyTB
            // 
            this.SecurityPolicyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityPolicyTB.Index = 2;
            this.SecurityPolicyTB.Location = new System.Drawing.Point(104, 150);
            this.SecurityPolicyTB.Name = "SecurityPolicyTB";
            this.SecurityPolicyTB.NotifyChanges = true;
            this.SecurityPolicyTB.ReadOnly = true;
            this.SecurityPolicyTB.Size = new System.Drawing.Size(151, 21);
            this.SecurityPolicyTB.TabIndex = 4;
            this.SecurityPolicyTB.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            this.SecurityPolicyTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.SecurityPolicyTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // SecurityPolicyLbl
            // 
            this.SecurityPolicyLbl.AutoSize = true;
            this.SecurityPolicyLbl.Location = new System.Drawing.Point(7, 153);
            this.SecurityPolicyLbl.Name = "SecurityPolicyLbl";
            this.SecurityPolicyLbl.Size = new System.Drawing.Size(38, 13);
            this.SecurityPolicyLbl.TabIndex = 2;
            this.SecurityPolicyLbl.Text = "Policy:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(249, 20);
            this.LogicalNameTB.TabIndex = 8;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
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
            // GXDLMSSecuritySetupView
            // 
            this.ClientSize = new System.Drawing.Size(385, 333);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSSecuritySetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXButton UpdateKeyBtn;
        private GXButton ActivateSecurityBtn;
    }
}
