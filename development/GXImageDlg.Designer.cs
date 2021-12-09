namespace Gurux.DLMS.UI
{
    partial class GXImageDlg
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
            this.IdentificationTb = new System.Windows.Forms.TextBox();
            this.TextLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.FileNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.AsciiCb = new System.Windows.Forms.CheckBox();
            this.SignatureTb = new System.Windows.Forms.TextBox();
            this.SignatureLbl = new System.Windows.Forms.Label();
            this.SignBtn = new System.Windows.Forms.Button();
            this.SigningKeyTb = new System.Windows.Forms.TextBox();
            this.SigningKeyLbl = new System.Windows.Forms.Label();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.SignatureGb = new System.Windows.Forms.GroupBox();
            this.SignatureGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdentificationTb
            // 
            this.IdentificationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdentificationTb.Location = new System.Drawing.Point(85, 9);
            this.IdentificationTb.Name = "IdentificationTb";
            this.IdentificationTb.Size = new System.Drawing.Size(346, 20);
            this.IdentificationTb.TabIndex = 0;
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(9, 12);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(70, 13);
            this.TextLbl.TabIndex = 19;
            this.TextLbl.Text = "Identification:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(437, 173);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(356, 173);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // FileNameTb
            // 
            this.FileNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTb.Location = new System.Drawing.Point(85, 36);
            this.FileNameTb.Name = "FileNameTb";
            this.FileNameTb.Size = new System.Drawing.Size(346, 20);
            this.FileNameTb.TabIndex = 2;
            this.FileNameTb.TextChanged += new System.EventHandler(this.FileNameTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Image:";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBtn.Location = new System.Drawing.Point(437, 35);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoBtn.Enabled = false;
            this.InfoBtn.Location = new System.Drawing.Point(12, 173);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(75, 23);
            this.InfoBtn.TabIndex = 4;
            this.InfoBtn.Text = "Info...";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // AsciiCb
            // 
            this.AsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AsciiCb.AutoSize = true;
            this.AsciiCb.Checked = true;
            this.AsciiCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AsciiCb.Location = new System.Drawing.Point(437, 11);
            this.AsciiCb.Name = "AsciiCb";
            this.AsciiCb.Size = new System.Drawing.Size(53, 17);
            this.AsciiCb.TabIndex = 1;
            this.AsciiCb.Text = "ASCII";
            this.AsciiCb.UseVisualStyleBackColor = true;
            this.AsciiCb.CheckedChanged += new System.EventHandler(this.AsciiCb_CheckedChanged);
            // 
            // SignatureTb
            // 
            this.SignatureTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignatureTb.Location = new System.Drawing.Point(82, 43);
            this.SignatureTb.Name = "SignatureTb";
            this.SignatureTb.Size = new System.Drawing.Size(348, 20);
            this.SignatureTb.TabIndex = 22;
            // 
            // SignatureLbl
            // 
            this.SignatureLbl.AutoSize = true;
            this.SignatureLbl.Location = new System.Drawing.Point(6, 46);
            this.SignatureLbl.Name = "SignatureLbl";
            this.SignatureLbl.Size = new System.Drawing.Size(55, 13);
            this.SignatureLbl.TabIndex = 23;
            this.SignatureLbl.Text = "Signature:";
            // 
            // SignBtn
            // 
            this.SignBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SignBtn.Location = new System.Drawing.Point(436, 16);
            this.SignBtn.Name = "SignBtn";
            this.SignBtn.Size = new System.Drawing.Size(75, 23);
            this.SignBtn.TabIndex = 25;
            this.SignBtn.Text = "Sign";
            this.SignBtn.UseVisualStyleBackColor = true;
            this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
            // 
            // SigningKeyTb
            // 
            this.SigningKeyTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SigningKeyTb.Location = new System.Drawing.Point(82, 17);
            this.SigningKeyTb.Name = "SigningKeyTb";
            this.SigningKeyTb.Size = new System.Drawing.Size(348, 20);
            this.SigningKeyTb.TabIndex = 26;
            // 
            // SigningKeyLbl
            // 
            this.SigningKeyLbl.AutoSize = true;
            this.SigningKeyLbl.Location = new System.Drawing.Point(6, 20);
            this.SigningKeyLbl.Name = "SigningKeyLbl";
            this.SigningKeyLbl.Size = new System.Drawing.Size(65, 13);
            this.SigningKeyLbl.TabIndex = 27;
            this.SigningKeyLbl.Text = "Signing key:";
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VerifyBtn.Location = new System.Drawing.Point(436, 42);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(75, 23);
            this.VerifyBtn.TabIndex = 28;
            this.VerifyBtn.Text = "Verify";
            this.VerifyBtn.UseVisualStyleBackColor = true;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // SignatureGb
            // 
            this.SignatureGb.Controls.Add(this.SignatureTb);
            this.SignatureGb.Controls.Add(this.VerifyBtn);
            this.SignatureGb.Controls.Add(this.SignatureLbl);
            this.SignatureGb.Controls.Add(this.SigningKeyLbl);
            this.SignatureGb.Controls.Add(this.SignBtn);
            this.SignatureGb.Controls.Add(this.SigningKeyTb);
            this.SignatureGb.Location = new System.Drawing.Point(1, 62);
            this.SignatureGb.Name = "SignatureGb";
            this.SignatureGb.Size = new System.Drawing.Size(524, 80);
            this.SignatureGb.TabIndex = 29;
            this.SignatureGb.TabStop = false;
            this.SignatureGb.Text = "Signature";
            // 
            // GXImageDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(524, 208);
            this.ControlBox = false;
            this.Controls.Add(this.SignatureGb);
            this.Controls.Add(this.AsciiCb);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.FileNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdentificationTb);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXImageDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image updater";
            this.SignatureGb.ResumeLayout(false);
            this.SignatureGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseBtn;
        public System.Windows.Forms.TextBox IdentificationTb;
        public System.Windows.Forms.TextBox FileNameTb;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.CheckBox AsciiCb;
        public System.Windows.Forms.TextBox SignatureTb;
        private System.Windows.Forms.Label SignatureLbl;
        private System.Windows.Forms.Button SignBtn;
        public System.Windows.Forms.TextBox SigningKeyTb;
        private System.Windows.Forms.Label SigningKeyLbl;
        private System.Windows.Forms.Button VerifyBtn;
        private System.Windows.Forms.GroupBox SignatureGb;
    }
}