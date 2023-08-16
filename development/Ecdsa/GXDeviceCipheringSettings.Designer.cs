namespace Gurux.DLMS.UI.Ecdsa
{
    partial class GXDeviceCipheringSettings
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SignInitiateRequestResponseCb = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CipheringTab = new System.Windows.Forms.TabPage();
            this.SigningCb = new System.Windows.Forms.ComboBox();
            this.SigningLbl = new System.Windows.Forms.Label();
            this.ServerSystemTitleTb = new System.Windows.Forms.TextBox();
            this.UsePreEstablishedApplicationAssociations = new System.Windows.Forms.CheckBox();
            this.ClientCertificateBtn = new System.Windows.Forms.Button();
            this.SystemTitleAsciiCb = new System.Windows.Forms.CheckBox();
            this.SystemTitleTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BlockCipherKeyAsciiCb = new System.Windows.Forms.CheckBox();
            this.AuthenticationKeyAsciiCb = new System.Windows.Forms.CheckBox();
            this.AuthenticationKeyTB = new System.Windows.Forms.TextBox();
            this.BlockCipherKeyTB = new System.Windows.Forms.TextBox();
            this.AuthenticationKey0Lbl = new System.Windows.Forms.Label();
            this.BlockCipherKeyLbl = new System.Windows.Forms.Label();
            this.SecuritySuiteCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecurityCB = new System.Windows.Forms.ComboBox();
            this.SecurityLbl = new System.Windows.Forms.Label();
            this.CipheringPanel = new System.Windows.Forms.Panel();
            this.CipheringV0Tab = new System.Windows.Forms.TabPage();
            this.Cipheringv0 = new System.Windows.Forms.Panel();
            this.GenerateDedicatedKeyBtn = new System.Windows.Forms.Button();
            this.ChallengeTB = new System.Windows.Forms.TextBox();
            this.ChallengeLbl = new System.Windows.Forms.Label();
            this.DedicatedKeyAsciiCb = new System.Windows.Forms.CheckBox();
            this.DedicatedKeyTb = new System.Windows.Forms.TextBox();
            this.DedicatedKeyLbl = new System.Windows.Forms.Label();
            this.CipheringV1Tab = new System.Windows.Forms.TabPage();
            this.Cipheringv1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ServerAgreementKeyInfoBtn = new System.Windows.Forms.Button();
            this.ServerSigningKeyInfoBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ServerSigningKeysCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ServerAgreementKeysCb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientAgreementKeyInfoBtn = new System.Windows.Forms.Button();
            this.ClientAgreementKeysCb = new System.Windows.Forms.ComboBox();
            this.ClientSigningKeysInfoBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ClientSigningKeysCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.IgnoreSNRM = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.CipheringTab.SuspendLayout();
            this.CipheringV0Tab.SuspendLayout();
            this.Cipheringv0.SuspendLayout();
            this.CipheringV1Tab.SuspendLayout();
            this.Cipheringv1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://www.gurux.fi/GXDLMSDirector.DeviceProperties";
            // 
            // SignInitiateRequestResponseCb
            // 
            this.SignInitiateRequestResponseCb.AutoSize = true;
            this.helpProvider1.SetHelpString(this.SignInitiateRequestResponseCb, "Is protected release used.");
            this.SignInitiateRequestResponseCb.Location = new System.Drawing.Point(107, 7);
            this.SignInitiateRequestResponseCb.Name = "SignInitiateRequestResponseCb";
            this.helpProvider1.SetShowHelp(this.SignInitiateRequestResponseCb, true);
            this.SignInitiateRequestResponseCb.Size = new System.Drawing.Size(186, 17);
            this.SignInitiateRequestResponseCb.TabIndex = 66;
            this.SignInitiateRequestResponseCb.Text = "Sign Initiate request and response";
            this.SignInitiateRequestResponseCb.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CipheringTab);
            this.tabControl1.Controls.Add(this.CipheringV0Tab);
            this.tabControl1.Controls.Add(this.CipheringV1Tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // CipheringTab
            // 
            this.CipheringTab.Controls.Add(this.IgnoreSNRM);
            this.CipheringTab.Controls.Add(this.SigningCb);
            this.CipheringTab.Controls.Add(this.SigningLbl);
            this.CipheringTab.Controls.Add(this.ServerSystemTitleTb);
            this.CipheringTab.Controls.Add(this.UsePreEstablishedApplicationAssociations);
            this.CipheringTab.Controls.Add(this.ClientCertificateBtn);
            this.CipheringTab.Controls.Add(this.SystemTitleAsciiCb);
            this.CipheringTab.Controls.Add(this.SystemTitleTb);
            this.CipheringTab.Controls.Add(this.label7);
            this.CipheringTab.Controls.Add(this.BlockCipherKeyAsciiCb);
            this.CipheringTab.Controls.Add(this.AuthenticationKeyAsciiCb);
            this.CipheringTab.Controls.Add(this.AuthenticationKeyTB);
            this.CipheringTab.Controls.Add(this.BlockCipherKeyTB);
            this.CipheringTab.Controls.Add(this.AuthenticationKey0Lbl);
            this.CipheringTab.Controls.Add(this.BlockCipherKeyLbl);
            this.CipheringTab.Controls.Add(this.SecuritySuiteCb);
            this.CipheringTab.Controls.Add(this.label1);
            this.CipheringTab.Controls.Add(this.SecurityCB);
            this.CipheringTab.Controls.Add(this.SecurityLbl);
            this.CipheringTab.Controls.Add(this.CipheringPanel);
            this.CipheringTab.Location = new System.Drawing.Point(4, 22);
            this.CipheringTab.Name = "CipheringTab";
            this.CipheringTab.Size = new System.Drawing.Size(792, 424);
            this.CipheringTab.TabIndex = 2;
            this.CipheringTab.Text = "Ciphering";
            this.CipheringTab.UseVisualStyleBackColor = true;
            this.CipheringTab.Click += new System.EventHandler(this.CipheringTab_Click);
            // 
            // SigningCb
            // 
            this.SigningCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SigningCb.Location = new System.Drawing.Point(367, 105);
            this.SigningCb.Name = "SigningCb";
            this.SigningCb.Size = new System.Drawing.Size(98, 21);
            this.SigningCb.TabIndex = 117;
            this.SigningCb.SelectedIndexChanged += new System.EventHandler(this.SigningCb_SelectedIndexChanged);
            // 
            // SigningLbl
            // 
            this.SigningLbl.AutoSize = true;
            this.SigningLbl.Location = new System.Drawing.Point(310, 107);
            this.SigningLbl.Name = "SigningLbl";
            this.SigningLbl.Size = new System.Drawing.Size(42, 13);
            this.SigningLbl.TabIndex = 118;
            this.SigningLbl.Text = "Signing";
            // 
            // ServerSystemTitleTb
            // 
            this.ServerSystemTitleTb.Location = new System.Drawing.Point(161, 106);
            this.ServerSystemTitleTb.Name = "ServerSystemTitleTb";
            this.ServerSystemTitleTb.ReadOnly = true;
            this.ServerSystemTitleTb.Size = new System.Drawing.Size(138, 20);
            this.ServerSystemTitleTb.TabIndex = 8;
            this.ServerSystemTitleTb.Leave += new System.EventHandler(this.ServerSystemTitle_TextChanged);
            // 
            // UsePreEstablishedApplicationAssociations
            // 
            this.UsePreEstablishedApplicationAssociations.AutoSize = true;
            this.UsePreEstablishedApplicationAssociations.Location = new System.Drawing.Point(5, 108);
            this.UsePreEstablishedApplicationAssociations.Name = "UsePreEstablishedApplicationAssociations";
            this.UsePreEstablishedApplicationAssociations.Size = new System.Drawing.Size(155, 17);
            this.UsePreEstablishedApplicationAssociations.TabIndex = 7;
            this.UsePreEstablishedApplicationAssociations.Text = "Pre-established system title:";
            this.UsePreEstablishedApplicationAssociations.UseVisualStyleBackColor = true;
            this.UsePreEstablishedApplicationAssociations.CheckedChanged += new System.EventHandler(this.UsePreEstablishedApplicationAssociations_CheckedChanged);
            // 
            // ClientCertificateBtn
            // 
            this.ClientCertificateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientCertificateBtn.Location = new System.Drawing.Point(380, 30);
            this.ClientCertificateBtn.Name = "ClientCertificateBtn";
            this.ClientCertificateBtn.Size = new System.Drawing.Size(85, 23);
            this.ClientCertificateBtn.TabIndex = 2;
            this.ClientCertificateBtn.Text = "Certificate...";
            this.ClientCertificateBtn.UseVisualStyleBackColor = true;
            this.ClientCertificateBtn.Click += new System.EventHandler(this.PrivatekeyBtn_Click);
            // 
            // SystemTitleAsciiCb
            // 
            this.SystemTitleAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleAsciiCb.AutoSize = true;
            this.SystemTitleAsciiCb.Location = new System.Drawing.Point(311, 32);
            this.SystemTitleAsciiCb.Name = "SystemTitleAsciiCb";
            this.SystemTitleAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.SystemTitleAsciiCb.TabIndex = 1;
            this.SystemTitleAsciiCb.Text = "ASCII";
            this.SystemTitleAsciiCb.UseVisualStyleBackColor = true;
            this.SystemTitleAsciiCb.CheckedChanged += new System.EventHandler(this.SystemTitleAsciiCb_CheckedChanged);
            this.SystemTitleAsciiCb.CheckStateChanged += new System.EventHandler(this.SystemTitleAsciiCb_CheckStateChanged);
            // 
            // SystemTitleTb
            // 
            this.SystemTitleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleTb.Location = new System.Drawing.Point(115, 30);
            this.SystemTitleTb.Name = "SystemTitleTb";
            this.SystemTitleTb.Size = new System.Drawing.Size(184, 20);
            this.SystemTitleTb.TabIndex = 0;
            this.SystemTitleTb.Leave += new System.EventHandler(this.SystemTitleTB_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 116;
            this.label7.Text = "System title:";
            // 
            // BlockCipherKeyAsciiCb
            // 
            this.BlockCipherKeyAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockCipherKeyAsciiCb.AutoSize = true;
            this.BlockCipherKeyAsciiCb.Location = new System.Drawing.Point(402, 59);
            this.BlockCipherKeyAsciiCb.Name = "BlockCipherKeyAsciiCb";
            this.BlockCipherKeyAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.BlockCipherKeyAsciiCb.TabIndex = 4;
            this.BlockCipherKeyAsciiCb.Text = "ASCII";
            this.BlockCipherKeyAsciiCb.UseVisualStyleBackColor = true;
            this.BlockCipherKeyAsciiCb.CheckedChanged += new System.EventHandler(this.BlockCipherKeyAsciiCb_CheckedChanged);
            // 
            // AuthenticationKeyAsciiCb
            // 
            this.AuthenticationKeyAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationKeyAsciiCb.AutoSize = true;
            this.AuthenticationKeyAsciiCb.Location = new System.Drawing.Point(402, 85);
            this.AuthenticationKeyAsciiCb.Name = "AuthenticationKeyAsciiCb";
            this.AuthenticationKeyAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.AuthenticationKeyAsciiCb.TabIndex = 6;
            this.AuthenticationKeyAsciiCb.Text = "ASCII";
            this.AuthenticationKeyAsciiCb.UseVisualStyleBackColor = true;
            this.AuthenticationKeyAsciiCb.CheckedChanged += new System.EventHandler(this.AuthenticationKeyAsciiCb_CheckedChanged);
            // 
            // AuthenticationKeyTB
            // 
            this.AuthenticationKeyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationKeyTB.Location = new System.Drawing.Point(115, 82);
            this.AuthenticationKeyTB.Name = "AuthenticationKeyTB";
            this.AuthenticationKeyTB.Size = new System.Drawing.Size(280, 20);
            this.AuthenticationKeyTB.TabIndex = 5;
            this.AuthenticationKeyTB.Leave += new System.EventHandler(this.AuthenticationKeyTB_Leave);
            // 
            // BlockCipherKeyTB
            // 
            this.BlockCipherKeyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockCipherKeyTB.Location = new System.Drawing.Point(115, 56);
            this.BlockCipherKeyTB.Name = "BlockCipherKeyTB";
            this.BlockCipherKeyTB.Size = new System.Drawing.Size(280, 20);
            this.BlockCipherKeyTB.TabIndex = 3;
            this.BlockCipherKeyTB.Leave += new System.EventHandler(this.BlockCipherKeyTB_Leave);
            // 
            // AuthenticationKey0Lbl
            // 
            this.AuthenticationKey0Lbl.AutoSize = true;
            this.AuthenticationKey0Lbl.Location = new System.Drawing.Point(5, 85);
            this.AuthenticationKey0Lbl.Name = "AuthenticationKey0Lbl";
            this.AuthenticationKey0Lbl.Size = new System.Drawing.Size(99, 13);
            this.AuthenticationKey0Lbl.TabIndex = 113;
            this.AuthenticationKey0Lbl.Text = "Authentication Key:";
            // 
            // BlockCipherKeyLbl
            // 
            this.BlockCipherKeyLbl.AutoSize = true;
            this.BlockCipherKeyLbl.Location = new System.Drawing.Point(5, 59);
            this.BlockCipherKeyLbl.Name = "BlockCipherKeyLbl";
            this.BlockCipherKeyLbl.Size = new System.Drawing.Size(91, 13);
            this.BlockCipherKeyLbl.TabIndex = 112;
            this.BlockCipherKeyLbl.Text = "Block Cipher Key:";
            // 
            // SecuritySuiteCb
            // 
            this.SecuritySuiteCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecuritySuiteCb.FormattingEnabled = true;
            this.SecuritySuiteCb.Location = new System.Drawing.Point(115, 3);
            this.SecuritySuiteCb.Name = "SecuritySuiteCb";
            this.SecuritySuiteCb.Size = new System.Drawing.Size(92, 21);
            this.SecuritySuiteCb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Security Suite:";
            // 
            // SecurityCB
            // 
            this.SecurityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityCB.Location = new System.Drawing.Point(294, 3);
            this.SecurityCB.Name = "SecurityCB";
            this.SecurityCB.Size = new System.Drawing.Size(171, 21);
            this.SecurityCB.TabIndex = 11;
            this.SecurityCB.SelectedIndexChanged += new System.EventHandler(this.SecurityCB_SelectedIndexChanged);
            // 
            // SecurityLbl
            // 
            this.SecurityLbl.AutoSize = true;
            this.SecurityLbl.Location = new System.Drawing.Point(225, 6);
            this.SecurityLbl.Name = "SecurityLbl";
            this.SecurityLbl.Size = new System.Drawing.Size(48, 13);
            this.SecurityLbl.TabIndex = 50;
            this.SecurityLbl.Text = "Security:";
            // 
            // CipheringPanel
            // 
            this.CipheringPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CipheringPanel.Location = new System.Drawing.Point(7, 151);
            this.CipheringPanel.Name = "CipheringPanel";
            this.CipheringPanel.Size = new System.Drawing.Size(458, 227);
            this.CipheringPanel.TabIndex = 12;
            // 
            // CipheringV0Tab
            // 
            this.CipheringV0Tab.Controls.Add(this.Cipheringv0);
            this.CipheringV0Tab.Location = new System.Drawing.Point(4, 22);
            this.CipheringV0Tab.Name = "CipheringV0Tab";
            this.CipheringV0Tab.Padding = new System.Windows.Forms.Padding(3);
            this.CipheringV0Tab.Size = new System.Drawing.Size(792, 424);
            this.CipheringV0Tab.TabIndex = 7;
            this.CipheringV0Tab.Text = "Ciphering V0 Settings.";
            this.CipheringV0Tab.UseVisualStyleBackColor = true;
            // 
            // Cipheringv0
            // 
            this.Cipheringv0.Controls.Add(this.GenerateDedicatedKeyBtn);
            this.Cipheringv0.Controls.Add(this.ChallengeTB);
            this.Cipheringv0.Controls.Add(this.ChallengeLbl);
            this.Cipheringv0.Controls.Add(this.DedicatedKeyAsciiCb);
            this.Cipheringv0.Controls.Add(this.DedicatedKeyTb);
            this.Cipheringv0.Controls.Add(this.DedicatedKeyLbl);
            this.Cipheringv0.Location = new System.Drawing.Point(3, 3);
            this.Cipheringv0.Name = "Cipheringv0";
            this.Cipheringv0.Size = new System.Drawing.Size(450, 219);
            this.Cipheringv0.TabIndex = 81;
            // 
            // GenerateDedicatedKeyBtn
            // 
            this.GenerateDedicatedKeyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateDedicatedKeyBtn.Location = new System.Drawing.Point(314, 28);
            this.GenerateDedicatedKeyBtn.Name = "GenerateDedicatedKeyBtn";
            this.GenerateDedicatedKeyBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateDedicatedKeyBtn.TabIndex = 2;
            this.GenerateDedicatedKeyBtn.Text = "Generate";
            this.GenerateDedicatedKeyBtn.UseVisualStyleBackColor = true;
            this.GenerateDedicatedKeyBtn.Click += new System.EventHandler(this.GenerateDedicatedKeyBtn_Click);
            // 
            // ChallengeTB
            // 
            this.ChallengeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChallengeTB.Location = new System.Drawing.Point(109, 57);
            this.ChallengeTB.Name = "ChallengeTB";
            this.ChallengeTB.Size = new System.Drawing.Size(280, 20);
            this.ChallengeTB.TabIndex = 3;
            // 
            // ChallengeLbl
            // 
            this.ChallengeLbl.AutoSize = true;
            this.ChallengeLbl.Location = new System.Drawing.Point(4, 60);
            this.ChallengeLbl.Name = "ChallengeLbl";
            this.ChallengeLbl.Size = new System.Drawing.Size(57, 13);
            this.ChallengeLbl.TabIndex = 102;
            this.ChallengeLbl.Text = "Challenge:";
            // 
            // DedicatedKeyAsciiCb
            // 
            this.DedicatedKeyAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DedicatedKeyAsciiCb.AutoSize = true;
            this.DedicatedKeyAsciiCb.Location = new System.Drawing.Point(394, 6);
            this.DedicatedKeyAsciiCb.Name = "DedicatedKeyAsciiCb";
            this.DedicatedKeyAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.DedicatedKeyAsciiCb.TabIndex = 1;
            this.DedicatedKeyAsciiCb.Text = "ASCII";
            this.DedicatedKeyAsciiCb.UseVisualStyleBackColor = true;
            this.DedicatedKeyAsciiCb.CheckedChanged += new System.EventHandler(this.DedicatedKeyAsciiCb_CheckedChanged);
            // 
            // DedicatedKeyTb
            // 
            this.DedicatedKeyTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DedicatedKeyTb.Location = new System.Drawing.Point(109, 3);
            this.DedicatedKeyTb.Name = "DedicatedKeyTb";
            this.DedicatedKeyTb.Size = new System.Drawing.Size(279, 20);
            this.DedicatedKeyTb.TabIndex = 0;
            this.DedicatedKeyTb.Leave += new System.EventHandler(this.DedicatedKeyTb_Leave);
            // 
            // DedicatedKeyLbl
            // 
            this.DedicatedKeyLbl.AutoSize = true;
            this.DedicatedKeyLbl.Location = new System.Drawing.Point(4, 6);
            this.DedicatedKeyLbl.Name = "DedicatedKeyLbl";
            this.DedicatedKeyLbl.Size = new System.Drawing.Size(80, 13);
            this.DedicatedKeyLbl.TabIndex = 97;
            this.DedicatedKeyLbl.Text = "Dedicated Key:";
            // 
            // CipheringV1Tab
            // 
            this.CipheringV1Tab.Controls.Add(this.Cipheringv1);
            this.CipheringV1Tab.Location = new System.Drawing.Point(4, 22);
            this.CipheringV1Tab.Name = "CipheringV1Tab";
            this.CipheringV1Tab.Size = new System.Drawing.Size(792, 424);
            this.CipheringV1Tab.TabIndex = 8;
            this.CipheringV1Tab.Text = "Ciphering V1 Settings.";
            this.CipheringV1Tab.UseVisualStyleBackColor = true;
            // 
            // Cipheringv1
            // 
            this.Cipheringv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cipheringv1.Controls.Add(this.SignInitiateRequestResponseCb);
            this.Cipheringv1.Controls.Add(this.groupBox2);
            this.Cipheringv1.Controls.Add(this.groupBox1);
            this.Cipheringv1.Controls.Add(this.UpdateBtn);
            this.Cipheringv1.Location = new System.Drawing.Point(8, 3);
            this.Cipheringv1.Name = "Cipheringv1";
            this.Cipheringv1.Size = new System.Drawing.Size(458, 311);
            this.Cipheringv1.TabIndex = 82;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ServerAgreementKeyInfoBtn);
            this.groupBox2.Controls.Add(this.ServerSigningKeyInfoBtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ServerSigningKeysCb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ServerAgreementKeysCb);
            this.groupBox2.Location = new System.Drawing.Point(3, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server keys";
            // 
            // ServerAgreementKeyInfoBtn
            // 
            this.ServerAgreementKeyInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerAgreementKeyInfoBtn.Location = new System.Drawing.Point(368, 35);
            this.ServerAgreementKeyInfoBtn.Name = "ServerAgreementKeyInfoBtn";
            this.ServerAgreementKeyInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerAgreementKeyInfoBtn.TabIndex = 3;
            this.ServerAgreementKeyInfoBtn.Text = "Info...";
            this.ServerAgreementKeyInfoBtn.UseVisualStyleBackColor = true;
            this.ServerAgreementKeyInfoBtn.Click += new System.EventHandler(this.ServerAgreementKeyInfoBtn_Click);
            // 
            // ServerSigningKeyInfoBtn
            // 
            this.ServerSigningKeyInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSigningKeyInfoBtn.Location = new System.Drawing.Point(368, 9);
            this.ServerSigningKeyInfoBtn.Name = "ServerSigningKeyInfoBtn";
            this.ServerSigningKeyInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerSigningKeyInfoBtn.TabIndex = 1;
            this.ServerSigningKeyInfoBtn.Text = "Info...";
            this.ServerSigningKeyInfoBtn.UseVisualStyleBackColor = true;
            this.ServerSigningKeyInfoBtn.Click += new System.EventHandler(this.ServerSigningKeyInfoBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Signing:";
            // 
            // ServerSigningKeysCb
            // 
            this.ServerSigningKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSigningKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerSigningKeysCb.FormattingEnabled = true;
            this.ServerSigningKeysCb.Location = new System.Drawing.Point(104, 9);
            this.ServerSigningKeysCb.Name = "ServerSigningKeysCb";
            this.ServerSigningKeysCb.Size = new System.Drawing.Size(247, 21);
            this.ServerSigningKeysCb.TabIndex = 0;
            this.ServerSigningKeysCb.SelectedIndexChanged += new System.EventHandler(this.ServerSigningKeysCb_SelectedIndexChanged);
            this.ServerSigningKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Agreement:";
            // 
            // ServerAgreementKeysCb
            // 
            this.ServerAgreementKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerAgreementKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerAgreementKeysCb.FormattingEnabled = true;
            this.ServerAgreementKeysCb.Location = new System.Drawing.Point(104, 36);
            this.ServerAgreementKeysCb.Name = "ServerAgreementKeysCb";
            this.ServerAgreementKeysCb.Size = new System.Drawing.Size(247, 21);
            this.ServerAgreementKeysCb.TabIndex = 2;
            this.ServerAgreementKeysCb.SelectedIndexChanged += new System.EventHandler(this.ServerAgreementKeysCb_SelectedIndexChanged);
            this.ServerAgreementKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClientAgreementKeyInfoBtn);
            this.groupBox1.Controls.Add(this.ClientAgreementKeysCb);
            this.groupBox1.Controls.Add(this.ClientSigningKeysInfoBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ClientSigningKeysCb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client keys";
            // 
            // ClientAgreementKeyInfoBtn
            // 
            this.ClientAgreementKeyInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAgreementKeyInfoBtn.Location = new System.Drawing.Point(367, 37);
            this.ClientAgreementKeyInfoBtn.Name = "ClientAgreementKeyInfoBtn";
            this.ClientAgreementKeyInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClientAgreementKeyInfoBtn.TabIndex = 3;
            this.ClientAgreementKeyInfoBtn.Text = "Info...";
            this.ClientAgreementKeyInfoBtn.UseVisualStyleBackColor = true;
            this.ClientAgreementKeyInfoBtn.Click += new System.EventHandler(this.ClientAgreementKeyInfoBtn_Click);
            // 
            // ClientAgreementKeysCb
            // 
            this.ClientAgreementKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAgreementKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientAgreementKeysCb.FormattingEnabled = true;
            this.ClientAgreementKeysCb.Location = new System.Drawing.Point(104, 38);
            this.ClientAgreementKeysCb.Name = "ClientAgreementKeysCb";
            this.ClientAgreementKeysCb.Size = new System.Drawing.Size(247, 21);
            this.ClientAgreementKeysCb.TabIndex = 2;
            this.ClientAgreementKeysCb.SelectedIndexChanged += new System.EventHandler(this.ClientAgreementKeysCb_SelectedIndexChanged);
            this.ClientAgreementKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // ClientSigningKeysInfoBtn
            // 
            this.ClientSigningKeysInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSigningKeysInfoBtn.Location = new System.Drawing.Point(367, 10);
            this.ClientSigningKeysInfoBtn.Name = "ClientSigningKeysInfoBtn";
            this.ClientSigningKeysInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClientSigningKeysInfoBtn.TabIndex = 1;
            this.ClientSigningKeysInfoBtn.Text = "Info...";
            this.ClientSigningKeysInfoBtn.UseVisualStyleBackColor = true;
            this.ClientSigningKeysInfoBtn.Click += new System.EventHandler(this.ClientSigningKeysInfoBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Signing:";
            // 
            // ClientSigningKeysCb
            // 
            this.ClientSigningKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSigningKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientSigningKeysCb.FormattingEnabled = true;
            this.ClientSigningKeysCb.Location = new System.Drawing.Point(104, 10);
            this.ClientSigningKeysCb.Name = "ClientSigningKeysCb";
            this.ClientSigningKeysCb.Size = new System.Drawing.Size(247, 21);
            this.ClientSigningKeysCb.TabIndex = 0;
            this.ClientSigningKeysCb.SelectedIndexChanged += new System.EventHandler(this.ClientSigningKeysCb_SelectedIndexChanged);
            this.ClientSigningKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Agreement:";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.Location = new System.Drawing.Point(372, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.Text = "Find";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // IgnoreSNRM
            // 
            this.IgnoreSNRM.AutoSize = true;
            this.IgnoreSNRM.Enabled = false;
            this.IgnoreSNRM.Location = new System.Drawing.Point(5, 128);
            this.IgnoreSNRM.Name = "IgnoreSNRM";
            this.IgnoreSNRM.Size = new System.Drawing.Size(136, 17);
            this.IgnoreSNRM.TabIndex = 119;
            this.IgnoreSNRM.Text = "Ignore SNRM message";
            this.IgnoreSNRM.UseVisualStyleBackColor = true;
            // 
            // GXDeviceCipheringSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "GXDeviceCipheringSettings";
            this.Text = "GXDeviceCipheringSettings";
            this.tabControl1.ResumeLayout(false);
            this.CipheringTab.ResumeLayout(false);
            this.CipheringTab.PerformLayout();
            this.CipheringV0Tab.ResumeLayout(false);
            this.Cipheringv0.ResumeLayout(false);
            this.Cipheringv0.PerformLayout();
            this.CipheringV1Tab.ResumeLayout(false);
            this.Cipheringv1.ResumeLayout(false);
            this.Cipheringv1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CipheringTab;
        private System.Windows.Forms.ComboBox SecurityCB;
        private System.Windows.Forms.Label SecurityLbl;
        private System.Windows.Forms.Panel CipheringPanel;
        private System.Windows.Forms.TabPage CipheringV0Tab;
        private System.Windows.Forms.Panel Cipheringv0;
        private System.Windows.Forms.CheckBox DedicatedKeyAsciiCb;
        private System.Windows.Forms.TextBox DedicatedKeyTb;
        private System.Windows.Forms.Label DedicatedKeyLbl;
        private System.Windows.Forms.TabPage CipheringV1Tab;
        private System.Windows.Forms.Panel Cipheringv1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox ChallengeTB;
        private System.Windows.Forms.Label ChallengeLbl;
        private System.Windows.Forms.ComboBox SecuritySuiteCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateDedicatedKeyBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ClientAgreementKeyInfoBtn;
        private System.Windows.Forms.Button ClientSigningKeysInfoBtn;
        private System.Windows.Forms.ComboBox ClientSigningKeysCb;
        private System.Windows.Forms.ComboBox ClientAgreementKeysCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ServerAgreementKeyInfoBtn;
        private System.Windows.Forms.Button ServerSigningKeyInfoBtn;
        private System.Windows.Forms.ComboBox ServerSigningKeysCb;
        private System.Windows.Forms.ComboBox ServerAgreementKeysCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox SystemTitleAsciiCb;
        private System.Windows.Forms.TextBox SystemTitleTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox BlockCipherKeyAsciiCb;
        private System.Windows.Forms.CheckBox AuthenticationKeyAsciiCb;
        private System.Windows.Forms.TextBox AuthenticationKeyTB;
        private System.Windows.Forms.TextBox BlockCipherKeyTB;
        private System.Windows.Forms.Label AuthenticationKey0Lbl;
        private System.Windows.Forms.Label BlockCipherKeyLbl;
        private System.Windows.Forms.Button ClientCertificateBtn;
        private System.Windows.Forms.TextBox ServerSystemTitleTb;
        private System.Windows.Forms.CheckBox UsePreEstablishedApplicationAssociations;
        private System.Windows.Forms.ComboBox SigningCb;
        private System.Windows.Forms.Label SigningLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SignInitiateRequestResponseCb;
        private System.Windows.Forms.CheckBox IgnoreSNRM;
    }
}