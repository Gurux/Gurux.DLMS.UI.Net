namespace Gurux.DLMS.UI
{
    partial class GXCertificateType
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.DigitalSignatureKeyPairRb = new System.Windows.Forms.RadioButton();
            this.KeyAgreementKeyPairRb = new System.Windows.Forms.RadioButton();
            this.TlsKeyPairRb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(225, 85);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(144, 85);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 17;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            // 
            // DigitalSignatureKeyPairRb
            // 
            this.DigitalSignatureKeyPairRb.AutoSize = true;
            this.DigitalSignatureKeyPairRb.Checked = true;
            this.DigitalSignatureKeyPairRb.Location = new System.Drawing.Point(12, 7);
            this.DigitalSignatureKeyPairRb.Name = "DigitalSignatureKeyPairRb";
            this.DigitalSignatureKeyPairRb.Size = new System.Drawing.Size(140, 17);
            this.DigitalSignatureKeyPairRb.TabIndex = 22;
            this.DigitalSignatureKeyPairRb.TabStop = true;
            this.DigitalSignatureKeyPairRb.Text = "Digital signature key pair";
            this.DigitalSignatureKeyPairRb.UseVisualStyleBackColor = true;
            // 
            // KeyAgreementKeyPairRb
            // 
            this.KeyAgreementKeyPairRb.AutoSize = true;
            this.KeyAgreementKeyPairRb.Location = new System.Drawing.Point(12, 26);
            this.KeyAgreementKeyPairRb.Name = "KeyAgreementKeyPairRb";
            this.KeyAgreementKeyPairRb.Size = new System.Drawing.Size(136, 17);
            this.KeyAgreementKeyPairRb.TabIndex = 23;
            this.KeyAgreementKeyPairRb.Text = "Key agreement key pair";
            this.KeyAgreementKeyPairRb.UseVisualStyleBackColor = true;
            // 
            // TlsKeyPairRb
            // 
            this.TlsKeyPairRb.AutoSize = true;
            this.TlsKeyPairRb.Location = new System.Drawing.Point(12, 45);
            this.TlsKeyPairRb.Name = "TlsKeyPairRb";
            this.TlsKeyPairRb.Size = new System.Drawing.Size(85, 17);
            this.TlsKeyPairRb.TabIndex = 24;
            this.TlsKeyPairRb.Text = "TLS key pair";
            this.TlsKeyPairRb.UseVisualStyleBackColor = true;
            // 
            // GXCertificateType
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(312, 120);
            this.ControlBox = false;
            this.Controls.Add(this.TlsKeyPairRb);
            this.Controls.Add(this.KeyAgreementKeyPairRb);
            this.Controls.Add(this.DigitalSignatureKeyPairRb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXCertificateType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Certification type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.RadioButton DigitalSignatureKeyPairRb;
        private System.Windows.Forms.RadioButton KeyAgreementKeyPairRb;
        private System.Windows.Forms.RadioButton TlsKeyPairRb;
    }
}