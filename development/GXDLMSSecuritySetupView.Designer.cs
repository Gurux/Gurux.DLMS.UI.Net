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
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSecuritySetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SecurityCb = new System.Windows.Forms.ComboBox();
            this.SystemTitleDescriptionTb = new System.Windows.Forms.TextBox();
            this.SecurityPolicyTB = new System.Windows.Forms.CheckedListBox();
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
            this.SecurityPolicyLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RemoveCertificateBtn = new Gurux.DLMS.UI.GXButton();
            this.ImportCertificateBtn = new Gurux.DLMS.UI.GXButton();
            this.ExportCertificateBtn = new Gurux.DLMS.UI.GXButton();
            this.GenerateCertificateRequestBtn = new Gurux.DLMS.UI.GXButton();
            this.GenerateKeyPairBtn = new Gurux.DLMS.UI.GXButton();
            this.CertificatesLv = new System.Windows.Forms.ListView();
            this.EntityCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialNumberCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IssuerCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectAltNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.groupBox1.Size = new System.Drawing.Size(610, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security Setup Object";
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
            this.tabControl1.Size = new System.Drawing.Size(598, 423);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SecurityCb);
            this.tabPage1.Controls.Add(this.SystemTitleDescriptionTb);
            this.tabPage1.Controls.Add(this.SecurityPolicyTB);
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
            this.tabPage1.Controls.Add(this.SecurityPolicyLbl);
            this.tabPage1.Controls.Add(this.LogicalNameTB);
            this.tabPage1.Controls.Add(this.LogicalNameLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SecurityCb
            // 
            this.SecurityCb.FormattingEnabled = true;
            this.SecurityCb.Location = new System.Drawing.Point(107, 237);
            this.SecurityCb.Name = "SecurityCb";
            this.SecurityCb.Size = new System.Drawing.Size(258, 21);
            this.SecurityCb.TabIndex = 40;
            // 
            // SystemTitleDescriptionTb
            // 
            this.SystemTitleDescriptionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleDescriptionTb.Location = new System.Drawing.Point(107, 137);
            this.SystemTitleDescriptionTb.Multiline = true;
            this.SystemTitleDescriptionTb.Name = "SystemTitleDescriptionTb";
            this.SystemTitleDescriptionTb.ReadOnly = true;
            this.SystemTitleDescriptionTb.Size = new System.Drawing.Size(258, 94);
            this.SystemTitleDescriptionTb.TabIndex = 38;
            // 
            // SecurityPolicyTB
            // 
            this.SecurityPolicyTB.FormattingEnabled = true;
            this.SecurityPolicyTB.Location = new System.Drawing.Point(108, 237);
            this.SecurityPolicyTB.Name = "SecurityPolicyTB";
            this.SecurityPolicyTB.Size = new System.Drawing.Size(257, 154);
            this.SecurityPolicyTB.TabIndex = 26;
            // 
            // UpdateKeyBtn
            // 
            this.UpdateKeyBtn.Index = 2;
            this.UpdateKeyBtn.Location = new System.Drawing.Point(371, 58);
            this.UpdateKeyBtn.Name = "UpdateKeyBtn";
            this.UpdateKeyBtn.Size = new System.Drawing.Size(103, 23);
            this.UpdateKeyBtn.TabIndex = 18;
            this.UpdateKeyBtn.Text = "Update Key...";
            this.UpdateKeyBtn.UseVisualStyleBackColor = true;
            // 
            // ActivateSecurityBtn
            // 
            this.ActivateSecurityBtn.Index = 1;
            this.ActivateSecurityBtn.Location = new System.Drawing.Point(380, 237);
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
            this.ServerSystemTitleTB.NotifyChanges = true;
            this.ServerSystemTitleTB.Size = new System.Drawing.Size(467, 20);
            this.ServerSystemTitleTB.TabIndex = 16;
            this.ServerSystemTitleTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // ClientSystemTitleTB
            // 
            this.ClientSystemTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSystemTitleTB.Index = 4;
            this.ClientSystemTitleTB.Location = new System.Drawing.Point(108, 85);
            this.ClientSystemTitleTB.Name = "ClientSystemTitleTB";
            this.ClientSystemTitleTB.NotifyChanges = false;
            this.ClientSystemTitleTB.Size = new System.Drawing.Size(467, 20);
            this.ClientSystemTitleTB.TabIndex = 14;
            this.ClientSystemTitleTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // SuiteTB
            // 
            this.SuiteTB.Index = 3;
            this.SuiteTB.Location = new System.Drawing.Point(108, 59);
            this.SuiteTB.Name = "SuiteTB";
            this.SuiteTB.NotifyChanges = false;
            this.SuiteTB.Size = new System.Drawing.Size(257, 72);
            this.SuiteTB.TabIndex = 12;
            this.SuiteTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
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
            this.DescriptionTB.Size = new System.Drawing.Size(468, 20);
            this.DescriptionTB.TabIndex = 22;
            // 
            // SecurityPolicyLbl
            // 
            this.SecurityPolicyLbl.AutoSize = true;
            this.SecurityPolicyLbl.Location = new System.Drawing.Point(11, 237);
            this.SecurityPolicyLbl.Name = "SecurityPolicyLbl";
            this.SecurityPolicyLbl.Size = new System.Drawing.Size(38, 13);
            this.SecurityPolicyLbl.TabIndex = 15;
            this.SecurityPolicyLbl.Text = "Policy:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(107, 32);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(467, 20);
            this.LogicalNameTB.TabIndex = 23;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RemoveCertificateBtn);
            this.tabPage2.Controls.Add(this.ImportCertificateBtn);
            this.tabPage2.Controls.Add(this.ExportCertificateBtn);
            this.tabPage2.Controls.Add(this.GenerateCertificateRequestBtn);
            this.tabPage2.Controls.Add(this.GenerateKeyPairBtn);
            this.tabPage2.Controls.Add(this.CertificatesLv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Certificates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // RemoveCertificateBtn
            // 
            this.RemoveCertificateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveCertificateBtn.Index = 8;
            this.RemoveCertificateBtn.Location = new System.Drawing.Point(474, 368);
            this.RemoveCertificateBtn.Name = "RemoveCertificateBtn";
            this.RemoveCertificateBtn.Size = new System.Drawing.Size(111, 23);
            this.RemoveCertificateBtn.TabIndex = 28;
            this.RemoveCertificateBtn.Text = "Remove certificate";
            this.RemoveCertificateBtn.UseVisualStyleBackColor = true;
            // 
            // ImportCertificateBtn
            // 
            this.ImportCertificateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportCertificateBtn.Index = 6;
            this.ImportCertificateBtn.Location = new System.Drawing.Point(240, 368);
            this.ImportCertificateBtn.Name = "ImportCertificateBtn";
            this.ImportCertificateBtn.Size = new System.Drawing.Size(111, 23);
            this.ImportCertificateBtn.TabIndex = 27;
            this.ImportCertificateBtn.Text = "Import Certificate";
            this.ImportCertificateBtn.UseVisualStyleBackColor = true;
            // 
            // ExportCertificateBtn
            // 
            this.ExportCertificateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportCertificateBtn.Index = 7;
            this.ExportCertificateBtn.Location = new System.Drawing.Point(357, 368);
            this.ExportCertificateBtn.Name = "ExportCertificateBtn";
            this.ExportCertificateBtn.Size = new System.Drawing.Size(111, 23);
            this.ExportCertificateBtn.TabIndex = 26;
            this.ExportCertificateBtn.Text = "Export certificate...";
            this.ExportCertificateBtn.UseVisualStyleBackColor = true;
            // 
            // GenerateCertificateRequestBtn
            // 
            this.GenerateCertificateRequestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateCertificateRequestBtn.Index = 5;
            this.GenerateCertificateRequestBtn.Location = new System.Drawing.Point(123, 368);
            this.GenerateCertificateRequestBtn.Name = "GenerateCertificateRequestBtn";
            this.GenerateCertificateRequestBtn.Size = new System.Drawing.Size(111, 23);
            this.GenerateCertificateRequestBtn.TabIndex = 25;
            this.GenerateCertificateRequestBtn.Text = "Certificate request...";
            this.GenerateCertificateRequestBtn.UseVisualStyleBackColor = true;
            // 
            // GenerateKeyPairBtn
            // 
            this.GenerateKeyPairBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateKeyPairBtn.Index = 4;
            this.GenerateKeyPairBtn.Location = new System.Drawing.Point(6, 368);
            this.GenerateKeyPairBtn.Name = "GenerateKeyPairBtn";
            this.GenerateKeyPairBtn.Size = new System.Drawing.Size(111, 23);
            this.GenerateKeyPairBtn.TabIndex = 24;
            this.GenerateKeyPairBtn.Text = "Key pair...";
            this.GenerateKeyPairBtn.UseVisualStyleBackColor = true;
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
            this.CertificatesLv.Size = new System.Drawing.Size(570, 356);
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
            this.TypeCh.Width = 93;
            // 
            // SerialNumberCh
            // 
            this.SerialNumberCh.Text = "Serial Number";
            this.SerialNumberCh.Width = 106;
            // 
            // IssuerCh
            // 
            this.IssuerCh.Text = "Issuer";
            this.IssuerCh.Width = 109;
            // 
            // SubjectCh
            // 
            this.SubjectCh.Text = "Subject";
            this.SubjectCh.Width = 124;
            // 
            // SubjectAltNameCh
            // 
            this.SubjectAltNameCh.Text = "Subject Alt Name";
            this.SubjectAltNameCh.Width = 107;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // GXDLMSSecuritySetupView
            // 
            this.ClientSize = new System.Drawing.Size(634, 472);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSSecuritySetupView";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private GXButton GenerateCertificateRequestBtn;
        private GXButton GenerateKeyPairBtn;
        private GXButton ImportCertificateBtn;
        private GXButton ExportCertificateBtn;
        private CheckedListBox SecurityPolicyTB;
        private GXButton RemoveCertificateBtn;
        private TextBox SystemTitleDescriptionTb;
        private ComboBox SecurityCb;
    }
}
