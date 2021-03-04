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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CipheringTab = new System.Windows.Forms.TabPage();
            this.SecuritySuiteCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecurityCB = new System.Windows.Forms.ComboBox();
            this.SecurityLbl = new System.Windows.Forms.Label();
            this.CipheringPanel = new System.Windows.Forms.Panel();
            this.CipheringV0Tab = new System.Windows.Forms.TabPage();
            this.Cipheringv0 = new System.Windows.Forms.Panel();
            this.SystemTitleAscii0Cb = new System.Windows.Forms.CheckBox();
            this.ItalySystemTitleTb = new System.Windows.Forms.TextBox();
            this.SystemTitle0Tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ServerSystemTitle0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsePreEstablishedApplicationAssociations = new System.Windows.Forms.CheckBox();
            this.ChallengeTB = new System.Windows.Forms.TextBox();
            this.ChallengeLbl = new System.Windows.Forms.Label();
            this.DedicatedKeyAsciiCb = new System.Windows.Forms.CheckBox();
            this.DedicatedKeyTb = new System.Windows.Forms.TextBox();
            this.DedicatedKeyLbl = new System.Windows.Forms.Label();
            this.BlockCipherKeyAsciiCb = new System.Windows.Forms.CheckBox();
            this.AuthenticationKey0AsciiCb = new System.Windows.Forms.CheckBox();
            this.AuthenticationKey0TB = new System.Windows.Forms.TextBox();
            this.BlockCipherKeyTB = new System.Windows.Forms.TextBox();
            this.AuthenticationKey0Lbl = new System.Windows.Forms.Label();
            this.BlockCipherKeyLbl = new System.Windows.Forms.Label();
            this.CipheringV1Tab = new System.Windows.Forms.TabPage();
            this.Cipheringv1 = new System.Windows.Forms.Panel();
            this.AuthenticationKeyAsciiCb = new System.Windows.Forms.CheckBox();
            this.KeyAgreementSchemeCb = new System.Windows.Forms.ComboBox();
            this.AuthenticationKeyTB = new System.Windows.Forms.TextBox();
            this.AuthenticationKeyLbl = new System.Windows.Forms.Label();
            this.SchemeLbl = new System.Windows.Forms.Label();
            this.ClientCertificateBtn = new System.Windows.Forms.Button();
            this.SystemTitleAsciiCb = new System.Windows.Forms.CheckBox();
            this.SystemTitleTB = new System.Windows.Forms.TextBox();
            this.SystemtitleLbl = new System.Windows.Forms.Label();
            this.ServerCertificateBtn = new System.Windows.Forms.Button();
            this.ServerSystemTitleTB = new System.Windows.Forms.TextBox();
            this.ServerSystemtitleLbl = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServerAgreementKeyInfoBtn = new System.Windows.Forms.Button();
            this.ServerSigningKeyInfoBtn = new System.Windows.Forms.Button();
            this.ServerSigningKeysCb = new System.Windows.Forms.ComboBox();
            this.ServerAgreementKeysCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClientAgreementKeyInfoBtn = new System.Windows.Forms.Button();
            this.ClientSigningKeysInfoBtn = new System.Windows.Forms.Button();
            this.ClientSigningKeysCb = new System.Windows.Forms.ComboBox();
            this.ClientAgreementKeysCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CipheringTab.SuspendLayout();
            this.CipheringV0Tab.SuspendLayout();
            this.Cipheringv0.SuspendLayout();
            this.CipheringV1Tab.SuspendLayout();
            this.Cipheringv1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://www.gurux.fi/GXDLMSDirector.DeviceProperties";
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
            // 
            // SecuritySuiteCb
            // 
            this.SecuritySuiteCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecuritySuiteCb.FormattingEnabled = true;
            this.SecuritySuiteCb.Location = new System.Drawing.Point(93, 4);
            this.SecuritySuiteCb.Name = "SecuritySuiteCb";
            this.SecuritySuiteCb.Size = new System.Drawing.Size(118, 21);
            this.SecuritySuiteCb.TabIndex = 91;
            this.SecuritySuiteCb.SelectedIndexChanged += new System.EventHandler(this.SecuritySuiteCb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Security Suite:";
            // 
            // SecurityCB
            // 
            this.SecurityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityCB.Location = new System.Drawing.Point(311, 4);
            this.SecurityCB.Name = "SecurityCB";
            this.SecurityCB.Size = new System.Drawing.Size(144, 21);
            this.SecurityCB.TabIndex = 0;
            this.SecurityCB.SelectedIndexChanged += new System.EventHandler(this.SecurityCB_SelectedIndexChanged);
            // 
            // SecurityLbl
            // 
            this.SecurityLbl.AutoSize = true;
            this.SecurityLbl.Location = new System.Drawing.Point(234, 7);
            this.SecurityLbl.Name = "SecurityLbl";
            this.SecurityLbl.Size = new System.Drawing.Size(48, 13);
            this.SecurityLbl.TabIndex = 50;
            this.SecurityLbl.Text = "Security:";
            // 
            // CipheringPanel
            // 
            this.CipheringPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CipheringPanel.Location = new System.Drawing.Point(5, 33);
            this.CipheringPanel.Name = "CipheringPanel";
            this.CipheringPanel.Size = new System.Drawing.Size(450, 247);
            this.CipheringPanel.TabIndex = 5;
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
            this.Cipheringv0.Controls.Add(this.SystemTitleAscii0Cb);
            this.Cipheringv0.Controls.Add(this.ItalySystemTitleTb);
            this.Cipheringv0.Controls.Add(this.SystemTitle0Tb);
            this.Cipheringv0.Controls.Add(this.label7);
            this.Cipheringv0.Controls.Add(this.ServerSystemTitle0);
            this.Cipheringv0.Controls.Add(this.label2);
            this.Cipheringv0.Controls.Add(this.UsePreEstablishedApplicationAssociations);
            this.Cipheringv0.Controls.Add(this.ChallengeTB);
            this.Cipheringv0.Controls.Add(this.ChallengeLbl);
            this.Cipheringv0.Controls.Add(this.DedicatedKeyAsciiCb);
            this.Cipheringv0.Controls.Add(this.DedicatedKeyTb);
            this.Cipheringv0.Controls.Add(this.DedicatedKeyLbl);
            this.Cipheringv0.Controls.Add(this.BlockCipherKeyAsciiCb);
            this.Cipheringv0.Controls.Add(this.AuthenticationKey0AsciiCb);
            this.Cipheringv0.Controls.Add(this.AuthenticationKey0TB);
            this.Cipheringv0.Controls.Add(this.BlockCipherKeyTB);
            this.Cipheringv0.Controls.Add(this.AuthenticationKey0Lbl);
            this.Cipheringv0.Controls.Add(this.BlockCipherKeyLbl);
            this.Cipheringv0.Location = new System.Drawing.Point(3, 3);
            this.Cipheringv0.Name = "Cipheringv0";
            this.Cipheringv0.Size = new System.Drawing.Size(450, 219);
            this.Cipheringv0.TabIndex = 81;
            // 
            // SystemTitleAscii0Cb
            // 
            this.SystemTitleAscii0Cb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleAscii0Cb.AutoSize = true;
            this.SystemTitleAscii0Cb.Location = new System.Drawing.Point(394, 3);
            this.SystemTitleAscii0Cb.Name = "SystemTitleAscii0Cb";
            this.SystemTitleAscii0Cb.Size = new System.Drawing.Size(53, 17);
            this.SystemTitleAscii0Cb.TabIndex = 106;
            this.SystemTitleAscii0Cb.Text = "ASCII";
            this.SystemTitleAscii0Cb.UseVisualStyleBackColor = true;
            this.SystemTitleAscii0Cb.CheckedChanged += new System.EventHandler(this.SystemTitleAscii0Cb_CheckedChanged);
            // 
            // ItalySystemTitleTb
            // 
            this.ItalySystemTitleTb.Location = new System.Drawing.Point(106, 182);
            this.ItalySystemTitleTb.Name = "ItalySystemTitleTb";
            this.ItalySystemTitleTb.ReadOnly = true;
            this.ItalySystemTitleTb.Size = new System.Drawing.Size(196, 20);
            this.ItalySystemTitleTb.TabIndex = 104;
            // 
            // SystemTitle0Tb
            // 
            this.SystemTitle0Tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitle0Tb.Location = new System.Drawing.Point(107, 3);
            this.SystemTitle0Tb.Name = "SystemTitle0Tb";
            this.SystemTitle0Tb.Size = new System.Drawing.Size(280, 20);
            this.SystemTitle0Tb.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "System title:";
            // 
            // ServerSystemTitle0
            // 
            this.ServerSystemTitle0.Location = new System.Drawing.Point(107, 156);
            this.ServerSystemTitle0.Name = "ServerSystemTitle0";
            this.ServerSystemTitle0.ReadOnly = true;
            this.ServerSystemTitle0.Size = new System.Drawing.Size(195, 20);
            this.ServerSystemTitle0.TabIndex = 100;
            this.ServerSystemTitle0.TextChanged += new System.EventHandler(this.ServerSystemTitle0_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "System title:";
            // 
            // UsePreEstablishedApplicationAssociations
            // 
            this.UsePreEstablishedApplicationAssociations.AutoSize = true;
            this.UsePreEstablishedApplicationAssociations.Location = new System.Drawing.Point(2, 133);
            this.UsePreEstablishedApplicationAssociations.Name = "UsePreEstablishedApplicationAssociations";
            this.UsePreEstablishedApplicationAssociations.Size = new System.Drawing.Size(218, 17);
            this.UsePreEstablishedApplicationAssociations.TabIndex = 99;
            this.UsePreEstablishedApplicationAssociations.Text = "Pre-established Application Associations ";
            this.UsePreEstablishedApplicationAssociations.UseVisualStyleBackColor = true;
            this.UsePreEstablishedApplicationAssociations.CheckedChanged += new System.EventHandler(this.UsePreEstablishedApplicationAssociations_CheckedChanged);
            // 
            // ChallengeTB
            // 
            this.ChallengeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChallengeTB.Location = new System.Drawing.Point(107, 107);
            this.ChallengeTB.Name = "ChallengeTB";
            this.ChallengeTB.Size = new System.Drawing.Size(280, 20);
            this.ChallengeTB.TabIndex = 98;
            // 
            // ChallengeLbl
            // 
            this.ChallengeLbl.AutoSize = true;
            this.ChallengeLbl.Location = new System.Drawing.Point(2, 110);
            this.ChallengeLbl.Name = "ChallengeLbl";
            this.ChallengeLbl.Size = new System.Drawing.Size(57, 13);
            this.ChallengeLbl.TabIndex = 102;
            this.ChallengeLbl.Text = "Challenge:";
            // 
            // DedicatedKeyAsciiCb
            // 
            this.DedicatedKeyAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DedicatedKeyAsciiCb.AutoSize = true;
            this.DedicatedKeyAsciiCb.Location = new System.Drawing.Point(394, 83);
            this.DedicatedKeyAsciiCb.Name = "DedicatedKeyAsciiCb";
            this.DedicatedKeyAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.DedicatedKeyAsciiCb.TabIndex = 5;
            this.DedicatedKeyAsciiCb.Text = "ASCII";
            this.DedicatedKeyAsciiCb.UseVisualStyleBackColor = true;
            this.DedicatedKeyAsciiCb.CheckedChanged += new System.EventHandler(this.DedicatedKeyAsciiCb_CheckedChanged);
            // 
            // DedicatedKeyTb
            // 
            this.DedicatedKeyTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DedicatedKeyTb.Location = new System.Drawing.Point(107, 81);
            this.DedicatedKeyTb.Name = "DedicatedKeyTb";
            this.DedicatedKeyTb.Size = new System.Drawing.Size(280, 20);
            this.DedicatedKeyTb.TabIndex = 4;
            this.DedicatedKeyTb.Leave += new System.EventHandler(this.DedicatedKeyTb_Leave);
            // 
            // DedicatedKeyLbl
            // 
            this.DedicatedKeyLbl.AutoSize = true;
            this.DedicatedKeyLbl.Location = new System.Drawing.Point(2, 84);
            this.DedicatedKeyLbl.Name = "DedicatedKeyLbl";
            this.DedicatedKeyLbl.Size = new System.Drawing.Size(80, 13);
            this.DedicatedKeyLbl.TabIndex = 97;
            this.DedicatedKeyLbl.Text = "Dedicated Key:";
            // 
            // BlockCipherKeyAsciiCb
            // 
            this.BlockCipherKeyAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockCipherKeyAsciiCb.AutoSize = true;
            this.BlockCipherKeyAsciiCb.Location = new System.Drawing.Point(394, 32);
            this.BlockCipherKeyAsciiCb.Name = "BlockCipherKeyAsciiCb";
            this.BlockCipherKeyAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.BlockCipherKeyAsciiCb.TabIndex = 1;
            this.BlockCipherKeyAsciiCb.Text = "ASCII";
            this.BlockCipherKeyAsciiCb.UseVisualStyleBackColor = true;
            this.BlockCipherKeyAsciiCb.CheckedChanged += new System.EventHandler(this.BlockCipherKeyAsciiCb_CheckedChanged);
            // 
            // AuthenticationKey0AsciiCb
            // 
            this.AuthenticationKey0AsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationKey0AsciiCb.AutoSize = true;
            this.AuthenticationKey0AsciiCb.Location = new System.Drawing.Point(394, 58);
            this.AuthenticationKey0AsciiCb.Name = "AuthenticationKey0AsciiCb";
            this.AuthenticationKey0AsciiCb.Size = new System.Drawing.Size(53, 17);
            this.AuthenticationKey0AsciiCb.TabIndex = 3;
            this.AuthenticationKey0AsciiCb.Text = "ASCII";
            this.AuthenticationKey0AsciiCb.UseVisualStyleBackColor = true;
            this.AuthenticationKey0AsciiCb.CheckedChanged += new System.EventHandler(this.AuthenticationKeyAsciiCb_CheckedChanged);
            // 
            // AuthenticationKey0TB
            // 
            this.AuthenticationKey0TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationKey0TB.Location = new System.Drawing.Point(107, 55);
            this.AuthenticationKey0TB.Name = "AuthenticationKey0TB";
            this.AuthenticationKey0TB.Size = new System.Drawing.Size(280, 20);
            this.AuthenticationKey0TB.TabIndex = 2;
            this.AuthenticationKey0TB.Leave += new System.EventHandler(this.AuthenticationKeyTB_Leave);
            // 
            // BlockCipherKeyTB
            // 
            this.BlockCipherKeyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockCipherKeyTB.Location = new System.Drawing.Point(107, 29);
            this.BlockCipherKeyTB.Name = "BlockCipherKeyTB";
            this.BlockCipherKeyTB.Size = new System.Drawing.Size(280, 20);
            this.BlockCipherKeyTB.TabIndex = 0;
            this.BlockCipherKeyTB.Leave += new System.EventHandler(this.BlockCipherKeyTB_Leave);
            // 
            // AuthenticationKey0Lbl
            // 
            this.AuthenticationKey0Lbl.AutoSize = true;
            this.AuthenticationKey0Lbl.Location = new System.Drawing.Point(2, 58);
            this.AuthenticationKey0Lbl.Name = "AuthenticationKey0Lbl";
            this.AuthenticationKey0Lbl.Size = new System.Drawing.Size(99, 13);
            this.AuthenticationKey0Lbl.TabIndex = 85;
            this.AuthenticationKey0Lbl.Text = "Authentication Key:";
            // 
            // BlockCipherKeyLbl
            // 
            this.BlockCipherKeyLbl.AutoSize = true;
            this.BlockCipherKeyLbl.Location = new System.Drawing.Point(2, 32);
            this.BlockCipherKeyLbl.Name = "BlockCipherKeyLbl";
            this.BlockCipherKeyLbl.Size = new System.Drawing.Size(91, 13);
            this.BlockCipherKeyLbl.TabIndex = 84;
            this.BlockCipherKeyLbl.Text = "Block Cipher Key:";
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
            this.Cipheringv1.Controls.Add(this.AuthenticationKeyAsciiCb);
            this.Cipheringv1.Controls.Add(this.KeyAgreementSchemeCb);
            this.Cipheringv1.Controls.Add(this.AuthenticationKeyTB);
            this.Cipheringv1.Controls.Add(this.AuthenticationKeyLbl);
            this.Cipheringv1.Controls.Add(this.SchemeLbl);
            this.Cipheringv1.Controls.Add(this.ClientCertificateBtn);
            this.Cipheringv1.Controls.Add(this.SystemTitleAsciiCb);
            this.Cipheringv1.Controls.Add(this.SystemTitleTB);
            this.Cipheringv1.Controls.Add(this.SystemtitleLbl);
            this.Cipheringv1.Controls.Add(this.ServerCertificateBtn);
            this.Cipheringv1.Controls.Add(this.ServerSystemTitleTB);
            this.Cipheringv1.Controls.Add(this.ServerSystemtitleLbl);
            this.Cipheringv1.Controls.Add(this.UpdateBtn);
            this.Cipheringv1.Controls.Add(this.groupBox3);
            this.Cipheringv1.Controls.Add(this.groupBox2);
            this.Cipheringv1.Location = new System.Drawing.Point(8, 3);
            this.Cipheringv1.Name = "Cipheringv1";
            this.Cipheringv1.Size = new System.Drawing.Size(440, 297);
            this.Cipheringv1.TabIndex = 82;
            // 
            // AuthenticationKeyAsciiCb
            // 
            this.AuthenticationKeyAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationKeyAsciiCb.AutoSize = true;
            this.AuthenticationKeyAsciiCb.Location = new System.Drawing.Point(345, 85);
            this.AuthenticationKeyAsciiCb.Name = "AuthenticationKeyAsciiCb";
            this.AuthenticationKeyAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.AuthenticationKeyAsciiCb.TabIndex = 87;
            this.AuthenticationKeyAsciiCb.Text = "ASCII";
            this.AuthenticationKeyAsciiCb.UseVisualStyleBackColor = true;
            // 
            // KeyAgreementSchemeCb
            // 
            this.KeyAgreementSchemeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyAgreementSchemeCb.Location = new System.Drawing.Point(108, 3);
            this.KeyAgreementSchemeCb.Name = "KeyAgreementSchemeCb";
            this.KeyAgreementSchemeCb.Size = new System.Drawing.Size(172, 21);
            this.KeyAgreementSchemeCb.TabIndex = 0;
            // 
            // AuthenticationKeyTB
            // 
            this.AuthenticationKeyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationKeyTB.Location = new System.Drawing.Point(108, 82);
            this.AuthenticationKeyTB.Name = "AuthenticationKeyTB";
            this.AuthenticationKeyTB.Size = new System.Drawing.Size(230, 20);
            this.AuthenticationKeyTB.TabIndex = 86;
            // 
            // AuthenticationKeyLbl
            // 
            this.AuthenticationKeyLbl.AutoSize = true;
            this.AuthenticationKeyLbl.Location = new System.Drawing.Point(3, 85);
            this.AuthenticationKeyLbl.Name = "AuthenticationKeyLbl";
            this.AuthenticationKeyLbl.Size = new System.Drawing.Size(99, 13);
            this.AuthenticationKeyLbl.TabIndex = 88;
            this.AuthenticationKeyLbl.Text = "Authentication Key:";
            // 
            // SchemeLbl
            // 
            this.SchemeLbl.AutoSize = true;
            this.SchemeLbl.Location = new System.Drawing.Point(3, 6);
            this.SchemeLbl.Name = "SchemeLbl";
            this.SchemeLbl.Size = new System.Drawing.Size(49, 13);
            this.SchemeLbl.TabIndex = 101;
            this.SchemeLbl.Text = "Scheme:";
            // 
            // ClientCertificateBtn
            // 
            this.ClientCertificateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientCertificateBtn.Location = new System.Drawing.Point(345, 28);
            this.ClientCertificateBtn.Name = "ClientCertificateBtn";
            this.ClientCertificateBtn.Size = new System.Drawing.Size(75, 23);
            this.ClientCertificateBtn.TabIndex = 3;
            this.ClientCertificateBtn.Text = "Certificate...";
            this.ClientCertificateBtn.UseVisualStyleBackColor = true;
            this.ClientCertificateBtn.Click += new System.EventHandler(this.PrivatekeyBtn_Click);
            // 
            // SystemTitleAsciiCb
            // 
            this.SystemTitleAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleAsciiCb.AutoSize = true;
            this.SystemTitleAsciiCb.Location = new System.Drawing.Point(286, 32);
            this.SystemTitleAsciiCb.Name = "SystemTitleAsciiCb";
            this.SystemTitleAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.SystemTitleAsciiCb.TabIndex = 2;
            this.SystemTitleAsciiCb.Text = "ASCII";
            this.SystemTitleAsciiCb.UseVisualStyleBackColor = true;
            this.SystemTitleAsciiCb.CheckedChanged += new System.EventHandler(this.SystemTitleAsciiCb_CheckedChanged);
            // 
            // SystemTitleTB
            // 
            this.SystemTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleTB.Location = new System.Drawing.Point(108, 30);
            this.SystemTitleTB.Name = "SystemTitleTB";
            this.SystemTitleTB.Size = new System.Drawing.Size(172, 20);
            this.SystemTitleTB.TabIndex = 1;
            // 
            // SystemtitleLbl
            // 
            this.SystemtitleLbl.AutoSize = true;
            this.SystemtitleLbl.Location = new System.Drawing.Point(3, 34);
            this.SystemtitleLbl.Name = "SystemtitleLbl";
            this.SystemtitleLbl.Size = new System.Drawing.Size(63, 13);
            this.SystemtitleLbl.TabIndex = 98;
            this.SystemtitleLbl.Text = "System title:";
            // 
            // ServerCertificateBtn
            // 
            this.ServerCertificateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerCertificateBtn.Location = new System.Drawing.Point(345, 55);
            this.ServerCertificateBtn.Name = "ServerCertificateBtn";
            this.ServerCertificateBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerCertificateBtn.TabIndex = 5;
            this.ServerCertificateBtn.Text = "Certificate...";
            this.ServerCertificateBtn.UseVisualStyleBackColor = true;
            this.ServerCertificateBtn.Click += new System.EventHandler(this.ServerCertificateBtn_Click);
            // 
            // ServerSystemTitleTB
            // 
            this.ServerSystemTitleTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSystemTitleTB.Location = new System.Drawing.Point(108, 56);
            this.ServerSystemTitleTB.Name = "ServerSystemTitleTB";
            this.ServerSystemTitleTB.Size = new System.Drawing.Size(172, 20);
            this.ServerSystemTitleTB.TabIndex = 4;
            // 
            // ServerSystemtitleLbl
            // 
            this.ServerSystemtitleLbl.AutoSize = true;
            this.ServerSystemtitleLbl.Location = new System.Drawing.Point(3, 60);
            this.ServerSystemtitleLbl.Name = "ServerSystemtitleLbl";
            this.ServerSystemtitleLbl.Size = new System.Drawing.Size(97, 13);
            this.ServerSystemtitleLbl.TabIndex = 93;
            this.ServerSystemtitleLbl.Text = "Server System title:";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.Location = new System.Drawing.Point(344, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = "Find";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ServerAgreementKeyInfoBtn);
            this.groupBox3.Controls.Add(this.ServerSigningKeyInfoBtn);
            this.groupBox3.Controls.Add(this.ServerSigningKeysCb);
            this.groupBox3.Controls.Add(this.ServerAgreementKeysCb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 74);
            this.groupBox3.TabIndex = 87;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server keys:";
            // 
            // ServerAgreementKeyInfoBtn
            // 
            this.ServerAgreementKeyInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerAgreementKeyInfoBtn.Location = new System.Drawing.Point(338, 39);
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
            this.ServerSigningKeyInfoBtn.Location = new System.Drawing.Point(338, 13);
            this.ServerSigningKeyInfoBtn.Name = "ServerSigningKeyInfoBtn";
            this.ServerSigningKeyInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ServerSigningKeyInfoBtn.TabIndex = 1;
            this.ServerSigningKeyInfoBtn.Text = "Info...";
            this.ServerSigningKeyInfoBtn.UseVisualStyleBackColor = true;
            this.ServerSigningKeyInfoBtn.Click += new System.EventHandler(this.ServerSigningKeyInfoBtn_Click);
            // 
            // ServerSigningKeysCb
            // 
            this.ServerSigningKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerSigningKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerSigningKeysCb.FormattingEnabled = true;
            this.ServerSigningKeysCb.Location = new System.Drawing.Point(102, 13);
            this.ServerSigningKeysCb.Name = "ServerSigningKeysCb";
            this.ServerSigningKeysCb.Size = new System.Drawing.Size(230, 21);
            this.ServerSigningKeysCb.TabIndex = 0;
            this.ServerSigningKeysCb.SelectedIndexChanged += new System.EventHandler(this.ServerSigningKeysCb_SelectedIndexChanged);
            this.ServerSigningKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // ServerAgreementKeysCb
            // 
            this.ServerAgreementKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerAgreementKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerAgreementKeysCb.FormattingEnabled = true;
            this.ServerAgreementKeysCb.Location = new System.Drawing.Point(102, 41);
            this.ServerAgreementKeysCb.Name = "ServerAgreementKeysCb";
            this.ServerAgreementKeysCb.Size = new System.Drawing.Size(230, 21);
            this.ServerAgreementKeysCb.TabIndex = 2;
            this.ServerAgreementKeysCb.SelectedIndexChanged += new System.EventHandler(this.ServerAgreementKeysCb_SelectedIndexChanged);
            this.ServerAgreementKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Agreement:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Signing:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ClientAgreementKeyInfoBtn);
            this.groupBox2.Controls.Add(this.ClientSigningKeysInfoBtn);
            this.groupBox2.Controls.Add(this.ClientSigningKeysCb);
            this.groupBox2.Controls.Add(this.ClientAgreementKeysCb);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client keys:";
            // 
            // ClientAgreementKeyInfoBtn
            // 
            this.ClientAgreementKeyInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAgreementKeyInfoBtn.Location = new System.Drawing.Point(338, 42);
            this.ClientAgreementKeyInfoBtn.Name = "ClientAgreementKeyInfoBtn";
            this.ClientAgreementKeyInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClientAgreementKeyInfoBtn.TabIndex = 3;
            this.ClientAgreementKeyInfoBtn.Text = "Info...";
            this.ClientAgreementKeyInfoBtn.UseVisualStyleBackColor = true;
            this.ClientAgreementKeyInfoBtn.Click += new System.EventHandler(this.ClientAgreementKeyInfoBtn_Click);
            // 
            // ClientSigningKeysInfoBtn
            // 
            this.ClientSigningKeysInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSigningKeysInfoBtn.Location = new System.Drawing.Point(338, 13);
            this.ClientSigningKeysInfoBtn.Name = "ClientSigningKeysInfoBtn";
            this.ClientSigningKeysInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ClientSigningKeysInfoBtn.TabIndex = 1;
            this.ClientSigningKeysInfoBtn.Text = "Info...";
            this.ClientSigningKeysInfoBtn.UseVisualStyleBackColor = true;
            this.ClientSigningKeysInfoBtn.Click += new System.EventHandler(this.ClientSigningKeysInfoBtn_Click);
            // 
            // ClientSigningKeysCb
            // 
            this.ClientSigningKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientSigningKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientSigningKeysCb.FormattingEnabled = true;
            this.ClientSigningKeysCb.Location = new System.Drawing.Point(102, 13);
            this.ClientSigningKeysCb.Name = "ClientSigningKeysCb";
            this.ClientSigningKeysCb.Size = new System.Drawing.Size(230, 21);
            this.ClientSigningKeysCb.TabIndex = 0;
            this.ClientSigningKeysCb.SelectedIndexChanged += new System.EventHandler(this.ClientSigningKeysCb_SelectedIndexChanged);
            this.ClientSigningKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // ClientAgreementKeysCb
            // 
            this.ClientAgreementKeysCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientAgreementKeysCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientAgreementKeysCb.FormattingEnabled = true;
            this.ClientAgreementKeysCb.Location = new System.Drawing.Point(102, 41);
            this.ClientAgreementKeysCb.Name = "ClientAgreementKeysCb";
            this.ClientAgreementKeysCb.Size = new System.Drawing.Size(230, 21);
            this.ClientAgreementKeysCb.TabIndex = 2;
            this.ClientAgreementKeysCb.SelectedIndexChanged += new System.EventHandler(this.ClientAgreementKeysCb_SelectedIndexChanged);
            this.ClientAgreementKeysCb.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ClientSigningKeysCb_Format);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Agreement:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Signing:";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.CheckBox BlockCipherKeyAsciiCb;
        private System.Windows.Forms.CheckBox AuthenticationKey0AsciiCb;
        private System.Windows.Forms.TextBox AuthenticationKey0TB;
        private System.Windows.Forms.TextBox BlockCipherKeyTB;
        private System.Windows.Forms.Label AuthenticationKey0Lbl;
        private System.Windows.Forms.Label BlockCipherKeyLbl;
        private System.Windows.Forms.TabPage CipheringV1Tab;
        private System.Windows.Forms.Panel Cipheringv1;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ServerAgreementKeyInfoBtn;
        private System.Windows.Forms.Button ServerSigningKeyInfoBtn;
        private System.Windows.Forms.ComboBox ServerSigningKeysCb;
        private System.Windows.Forms.ComboBox ServerAgreementKeysCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClientAgreementKeyInfoBtn;
        private System.Windows.Forms.Button ClientSigningKeysInfoBtn;
        private System.Windows.Forms.ComboBox ClientSigningKeysCb;
        private System.Windows.Forms.ComboBox ClientAgreementKeysCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItalySystemTitleTb;
        private System.Windows.Forms.TextBox ServerSystemTitle0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UsePreEstablishedApplicationAssociations;
        private System.Windows.Forms.TextBox ChallengeTB;
        private System.Windows.Forms.Label ChallengeLbl;
        private System.Windows.Forms.TextBox ServerSystemTitleTB;
        private System.Windows.Forms.Label ServerSystemtitleLbl;
        private System.Windows.Forms.Button ServerCertificateBtn;
        private System.Windows.Forms.CheckBox SystemTitleAscii0Cb;
        private System.Windows.Forms.TextBox SystemTitle0Tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ClientCertificateBtn;
        private System.Windows.Forms.CheckBox SystemTitleAsciiCb;
        private System.Windows.Forms.TextBox SystemTitleTB;
        private System.Windows.Forms.Label SystemtitleLbl;
        private System.Windows.Forms.ComboBox KeyAgreementSchemeCb;
        private System.Windows.Forms.Label SchemeLbl;
        private System.Windows.Forms.ComboBox SecuritySuiteCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AuthenticationKeyAsciiCb;
        private System.Windows.Forms.TextBox AuthenticationKeyTB;
        private System.Windows.Forms.Label AuthenticationKeyLbl;
    }
}