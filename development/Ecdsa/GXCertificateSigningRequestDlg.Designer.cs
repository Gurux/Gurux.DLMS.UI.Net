namespace Gurux.DLMS.UI.Ecdsa
{
    partial class GXCertificateSigningRequestDlg
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
            this.SystemTitleTb = new System.Windows.Forms.TextBox();
            this.TextLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ServerTlsCb = new System.Windows.Forms.RadioButton();
            this.KeyAgreementCb = new System.Windows.Forms.RadioButton();
            this.DigitalSignatureCb = new System.Windows.Forms.RadioButton();
            this.ClientTlsCb = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemTitleTb
            // 
            this.SystemTitleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleTb.Location = new System.Drawing.Point(78, 62);
            this.SystemTitleTb.Name = "SystemTitleTb";
            this.SystemTitleTb.Size = new System.Drawing.Size(385, 20);
            this.SystemTitleTb.TabIndex = 0;
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(9, 65);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(63, 13);
            this.TextLbl.TabIndex = 19;
            this.TextLbl.Text = "System title:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(388, 95);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(307, 95);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 1;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ClientTlsCb);
            this.groupBox3.Controls.Add(this.ServerTlsCb);
            this.groupBox3.Controls.Add(this.KeyAgreementCb);
            this.groupBox3.Controls.Add(this.DigitalSignatureCb);
            this.groupBox3.Location = new System.Drawing.Point(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 55);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Certificate type";
            // 
            // ServerTlsCb
            // 
            this.ServerTlsCb.AutoSize = true;
            this.ServerTlsCb.Location = new System.Drawing.Point(244, 23);
            this.ServerTlsCb.Name = "ServerTlsCb";
            this.ServerTlsCb.Size = new System.Drawing.Size(79, 17);
            this.ServerTlsCb.TabIndex = 2;
            this.ServerTlsCb.Text = "Server TLS";
            this.ServerTlsCb.UseVisualStyleBackColor = true;
            // 
            // KeyAgreementCb
            // 
            this.KeyAgreementCb.AutoSize = true;
            this.KeyAgreementCb.Location = new System.Drawing.Point(130, 23);
            this.KeyAgreementCb.Name = "KeyAgreementCb";
            this.KeyAgreementCb.Size = new System.Drawing.Size(97, 17);
            this.KeyAgreementCb.TabIndex = 1;
            this.KeyAgreementCb.Text = "Key Agreement";
            this.KeyAgreementCb.UseVisualStyleBackColor = true;
            // 
            // DigitalSignatureCb
            // 
            this.DigitalSignatureCb.AutoSize = true;
            this.DigitalSignatureCb.Checked = true;
            this.DigitalSignatureCb.Location = new System.Drawing.Point(11, 23);
            this.DigitalSignatureCb.Name = "DigitalSignatureCb";
            this.DigitalSignatureCb.Size = new System.Drawing.Size(102, 17);
            this.DigitalSignatureCb.TabIndex = 0;
            this.DigitalSignatureCb.TabStop = true;
            this.DigitalSignatureCb.Text = "Digital Signature";
            this.DigitalSignatureCb.UseVisualStyleBackColor = true;
            // 
            // ClientTlsCb
            // 
            this.ClientTlsCb.AutoSize = true;
            this.ClientTlsCb.Location = new System.Drawing.Point(329, 23);
            this.ClientTlsCb.Name = "ClientTlsCb";
            this.ClientTlsCb.Size = new System.Drawing.Size(74, 17);
            this.ClientTlsCb.TabIndex = 3;
            this.ClientTlsCb.Text = "Client TLS";
            this.ClientTlsCb.UseVisualStyleBackColor = true;
            // 
            // GXCertificateSigningRequestDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(475, 130);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SystemTitleTb);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXCertificateSigningRequestDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Certificate Signing Request generator.";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SystemTitleTb;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton KeyAgreementCb;
        private System.Windows.Forms.RadioButton DigitalSignatureCb;
        private System.Windows.Forms.RadioButton ServerTlsCb;
        private System.Windows.Forms.RadioButton ClientTlsCb;
    }
}