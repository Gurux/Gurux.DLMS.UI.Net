using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSSecuritySetupView_v1
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
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSecuritySetupView_v1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ServerSystemTitleLbl = new System.Windows.Forms.Label();
            this.ClientSystemTitleLbl = new System.Windows.Forms.Label();
            this.SuiteLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.SecurityPolicyLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.CertificatesLv = new System.Windows.Forms.ListView();
            this.EntityCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialNumberCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssuerCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectAltNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UpdateKeyBtn = new Gurux.DLMS.UI.GXButton();
            this.ActivateSecurityBtn = new Gurux.DLMS.UI.GXButton();
            this.ServerSystemTitleTB = new Gurux.DLMS.UI.GXValueField();
            this.ClientSystemTitleTB = new Gurux.DLMS.UI.GXValueField();
            this.SuiteTB = new Gurux.DLMS.UI.GXValueField();
            this.SecurityPolicyTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Setup Object";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 321);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UpdateKeyBtn);
            this.tabPage1.Controls.Add(this.ActivateSecurityBtn);
            this.tabPage1.Controls.Add(this.ServerSystemTitleTB);
            this.tabPage1.Controls.Add(this.ServerSystemTitleLbl);
            this.tabPage1.Controls.Add(this.ClientSystemTitleTB);
            this.tabPage1.Controls.Add(this.ClientSystemTitleLbl);
            this.tabPage1.Controls.Add(this.SuiteTB);
            this.tabPage1.Controls.Add(this.SuiteLbl);
            this.tabPage1.Controls.Add(this.DescriptionLbl);
            this.tabPage1.Controls.Add(this.DescriptionTB);
            this.tabPage1.Controls.Add(this.SecurityPolicyTB);
            this.tabPage1.Controls.Add(this.SecurityPolicyLbl);
            this.tabPage1.Controls.Add(this.LogicalNameTB);
            this.tabPage1.Controls.Add(this.LogicalNameLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(414, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CertificatesLv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(414, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Certificates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ServerSystemTitleLbl
            // 
            this.ServerSystemTitleLbl.AutoSize = true;
            this.ServerSystemTitleLbl.Location = new System.Drawing.Point(11, 114);
            this.ServerSystemTitleLbl.Name = "ServerSystemTitleLbl";
            this.ServerSystemTitleLbl.Size = new System.Drawing.Size(101, 13);
            this.ServerSystemTitleLbl.TabIndex = 25;
            this.ServerSystemTitleLbl.Text = "Server System Title:";
            // 
            // ClientSystemTitleLbl
            // 
            this.ClientSystemTitleLbl.AutoSize = true;
            this.ClientSystemTitleLbl.Location = new System.Drawing.Point(11, 88);
            this.ClientSystemTitleLbl.Name = "ClientSystemTitleLbl";
            this.ClientSystemTitleLbl.Size = new System.Drawing.Size(96, 13);
            this.ClientSystemTitleLbl.TabIndex = 24;
            this.ClientSystemTitleLbl.Text = "Client System Title:";
            // 
            // SuiteLbl
            // 
            this.SuiteLbl.AutoSize = true;
            this.SuiteLbl.Location = new System.Drawing.Point(11, 62);
            this.SuiteLbl.Name = "SuiteLbl";
            this.SuiteLbl.Size = new System.Drawing.Size(34, 13);
            this.SuiteLbl.TabIndex = 21;
            this.SuiteLbl.Text = "Suite:";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(11, 9);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 19;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(107, 6);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(292, 20);
            this.DescriptionTB.TabIndex = 22;
            // 
            // SecurityPolicyLbl
            // 
            this.SecurityPolicyLbl.AutoSize = true;
            this.SecurityPolicyLbl.Location = new System.Drawing.Point(11, 140);
            this.SecurityPolicyLbl.Name = "SecurityPolicyLbl";
            this.SecurityPolicyLbl.Size = new System.Drawing.Size(38, 13);
            this.SecurityPolicyLbl.TabIndex = 15;
            this.SecurityPolicyLbl.Text = "Policy:";
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(11, 35);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 13;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // CertificatesLv
            // 
            this.CertificatesLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CertificatesLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EntityCh,
            this.TypeCh,
            this.SerialNumberCh,
            this.IssuerCh,
            this.SubjectCh,
            this.SubjectAltNameCh});
            this.CertificatesLv.FullRowSelect = true;
            this.CertificatesLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CertificatesLv.HideSelection = false;
            this.CertificatesLv.Location = new System.Drawing.Point(6, 6);
            this.CertificatesLv.Name = "CertificatesLv";
            this.CertificatesLv.Size = new System.Drawing.Size(398, 245);
            this.CertificatesLv.TabIndex = 23;
            this.CertificatesLv.UseCompatibleStateImageBehavior = false;
            this.CertificatesLv.View = System.Windows.Forms.View.Details;
            // 
            // EntityCh
            // 
            this.EntityCh.Text = "Entity";
            // 
            // TypeCh
            // 
            this.TypeCh.Text = "Type";
            // 
            // SerialNumberCh
            // 
            this.SerialNumberCh.Text = "Serial Number";
            // 
            // IssuerCh
            // 
            this.IssuerCh.Text = "Issuer";
            // 
            // SubjectCh
            // 
            this.SubjectCh.Text = "Subject";
            // 
            // SubjectAltNameCh
            // 
            this.SubjectAltNameCh.Text = "Subject Alt Name";
            // 
            // UpdateKeyBtn
            // 
            this.UpdateKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateKeyBtn.Index = 2;
            this.UpdateKeyBtn.Location = new System.Drawing.Point(296, 257);
            this.UpdateKeyBtn.Name = "UpdateKeyBtn";
            this.UpdateKeyBtn.Size = new System.Drawing.Size(103, 23);
            this.UpdateKeyBtn.TabIndex = 18;
            this.UpdateKeyBtn.Text = "Update Key...";
            this.UpdateKeyBtn.UseVisualStyleBackColor = true;
            // 
            // ActivateSecurityBtn
            // 
            this.ActivateSecurityBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivateSecurityBtn.Index = 1;
            this.ActivateSecurityBtn.Location = new System.Drawing.Point(324, 135);
            this.ActivateSecurityBtn.Name = "ActivateSecurityBtn";
            this.ActivateSecurityBtn.Size = new System.Drawing.Size(75, 23);
            this.ActivateSecurityBtn.TabIndex = 20;
            this.ActivateSecurityBtn.Text = "Activate Security";
            this.ActivateSecurityBtn.UseVisualStyleBackColor = true;
            // 
            // ServerSystemTitleTB
            // 
            this.ServerSystemTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSystemTitleTB.Index = 5;
            this.ServerSystemTitleTB.Location = new System.Drawing.Point(108, 111);
            this.ServerSystemTitleTB.Name = "ServerSystemTitleTB";
            this.ServerSystemTitleTB.NotifyChanges = false;
            this.ServerSystemTitleTB.Size = new System.Drawing.Size(291, 20);
            this.ServerSystemTitleTB.TabIndex = 16;
            this.ServerSystemTitleTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ClientSystemTitleTB
            // 
            this.ClientSystemTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSystemTitleTB.Index = 4;
            this.ClientSystemTitleTB.Location = new System.Drawing.Point(108, 85);
            this.ClientSystemTitleTB.Name = "ClientSystemTitleTB";
            this.ClientSystemTitleTB.NotifyChanges = false;
            this.ClientSystemTitleTB.Size = new System.Drawing.Size(291, 20);
            this.ClientSystemTitleTB.TabIndex = 14;
            this.ClientSystemTitleTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // SuiteTB
            // 
            this.SuiteTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SuiteTB.Index = 3;
            this.SuiteTB.Location = new System.Drawing.Point(108, 59);
            this.SuiteTB.Name = "SuiteTB";
            this.SuiteTB.NotifyChanges = false;
            this.SuiteTB.ReadOnly = true;
            this.SuiteTB.Size = new System.Drawing.Size(291, 72);
            this.SuiteTB.TabIndex = 12;
            this.SuiteTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // SecurityPolicyTB
            // 
            this.SecurityPolicyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityPolicyTB.Index = 2;
            this.SecurityPolicyTB.Location = new System.Drawing.Point(108, 137);
            this.SecurityPolicyTB.Name = "SecurityPolicyTB";
            this.SecurityPolicyTB.NotifyChanges = true;
            this.SecurityPolicyTB.ReadOnly = true;
            this.SecurityPolicyTB.Size = new System.Drawing.Size(210, 114);
            this.SecurityPolicyTB.TabIndex = 17;
            this.SecurityPolicyTB.Type = Gurux.DLMS.Enums.ValueFieldType.CheckedListBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(107, 32);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(291, 20);
            this.LogicalNameTB.TabIndex = 23;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSSecuritySetupView_v1
            // 
            this.ClientSize = new System.Drawing.Size(458, 370);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSSecuritySetupView_v1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GXButton UpdateKeyBtn;
        private GXButton ActivateSecurityBtn;
        private GXValueField ServerSystemTitleTB;
        private Label ServerSystemTitleLbl;
        private GXValueField ClientSystemTitleTB;
        private Label ClientSystemTitleLbl;
        private GXValueField SuiteTB;
        private Label SuiteLbl;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private GXValueField SecurityPolicyTB;
        private Label SecurityPolicyLbl;
        private GXValueField LogicalNameTB;
        private Label LogicalNameLbl;
        private TabPage tabPage2;
        private ListView CertificatesLv;
        private ColumnHeader EntityCh;
        private ColumnHeader TypeCh;
        private ColumnHeader SerialNumberCh;
        private ColumnHeader IssuerCh;
        private ColumnHeader SubjectCh;
        private ColumnHeader SubjectAltNameCh;
    }
}
