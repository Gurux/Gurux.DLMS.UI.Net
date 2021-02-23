namespace Gurux.DLMS.UI.Ecdsa
{
    partial class GXEcdsaKeysDlg
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CertificatesTab = new System.Windows.Forms.TabPage();
            this.CertificatesView = new System.Windows.Forms.Panel();
            this.PrivateKeysTab = new System.Windows.Forms.TabPage();
            this.KeysView = new System.Windows.Forms.Panel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabControl1.SuspendLayout();
            this.CertificatesTab.SuspendLayout();
            this.PrivateKeysTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CertificatesTab);
            this.tabControl1.Controls.Add(this.PrivateKeysTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // CertificatesTab
            // 
            this.CertificatesTab.Controls.Add(this.CertificatesView);
            this.CertificatesTab.Location = new System.Drawing.Point(4, 22);
            this.CertificatesTab.Name = "CertificatesTab";
            this.CertificatesTab.Size = new System.Drawing.Size(792, 424);
            this.CertificatesTab.TabIndex = 5;
            this.CertificatesTab.Text = "Certificates";
            this.CertificatesTab.UseVisualStyleBackColor = true;
            // 
            // CertificatesView
            // 
            this.CertificatesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CertificatesView.Location = new System.Drawing.Point(0, 0);
            this.CertificatesView.Name = "CertificatesView";
            this.CertificatesView.Size = new System.Drawing.Size(792, 424);
            this.CertificatesView.TabIndex = 25;
            // 
            // PrivateKeysTab
            // 
            this.PrivateKeysTab.Controls.Add(this.KeysView);
            this.PrivateKeysTab.Location = new System.Drawing.Point(4, 22);
            this.PrivateKeysTab.Name = "PrivateKeysTab";
            this.PrivateKeysTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrivateKeysTab.Size = new System.Drawing.Size(792, 424);
            this.PrivateKeysTab.TabIndex = 6;
            this.PrivateKeysTab.Text = "Private keys";
            this.PrivateKeysTab.UseVisualStyleBackColor = true;
            // 
            // KeysView
            // 
            this.KeysView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeysView.Location = new System.Drawing.Point(3, 3);
            this.KeysView.Name = "KeysView";
            this.KeysView.Size = new System.Drawing.Size(786, 418);
            this.KeysView.TabIndex = 26;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "https://www.gurux.fi/GXDLMSDirector.EcdsaKeys";
            // 
            // GXEcdsaKeysDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Topic);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GXEcdsaKeysDlg";
            this.helpProvider1.SetShowHelp(this, true);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ECDSA Private and Public keys";
            this.tabControl1.ResumeLayout(false);
            this.CertificatesTab.ResumeLayout(false);
            this.PrivateKeysTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CertificatesTab;
        private System.Windows.Forms.Panel CertificatesView;
        private System.Windows.Forms.TabPage PrivateKeysTab;
        private System.Windows.Forms.Panel KeysView;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}