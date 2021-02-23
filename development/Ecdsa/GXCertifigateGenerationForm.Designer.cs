namespace Gurux.DLMS.UI.Ecdsa
{
    partial class GXCertifigateGenerationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXCertifigateGenerationForm));
            this.LoadBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.Pkcs10Tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.KeyAgreementCb = new System.Windows.Forms.RadioButton();
            this.DigitalSignatureCb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CSRBtn = new System.Windows.Forms.Button();
            this.SystemTitleTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadBtn.Location = new System.Drawing.Point(18, 453);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load...";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(632, 453);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "Generate";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(713, 453);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // Pkcs10Tb
            // 
            this.Pkcs10Tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pkcs10Tb.Location = new System.Drawing.Point(3, 16);
            this.Pkcs10Tb.Multiline = true;
            this.Pkcs10Tb.Name = "Pkcs10Tb";
            this.Pkcs10Tb.Size = new System.Drawing.Size(770, 353);
            this.Pkcs10Tb.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Pkcs10Tb);
            this.groupBox1.Location = new System.Drawing.Point(15, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 372);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Certificate Signing Request in  PKCS #10 format ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.KeyAgreementCb);
            this.groupBox3.Controls.Add(this.DigitalSignatureCb);
            this.groupBox3.Location = new System.Drawing.Point(18, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 55);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Certificate type";
            // 
            // KeyAgreementCb
            // 
            this.KeyAgreementCb.AutoSize = true;
            this.KeyAgreementCb.Location = new System.Drawing.Point(130, 23);
            this.KeyAgreementCb.Name = "KeyAgreementCb";
            this.KeyAgreementCb.Size = new System.Drawing.Size(97, 17);
            this.KeyAgreementCb.TabIndex = 71;
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
            this.DigitalSignatureCb.TabIndex = 70;
            this.DigitalSignatureCb.TabStop = true;
            this.DigitalSignatureCb.Text = "Digital Signature";
            this.DigitalSignatureCb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CSRBtn);
            this.groupBox2.Controls.Add(this.SystemTitleTb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(343, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 55);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Certificate Signing Request from Private Key";
            // 
            // CSRBtn
            // 
            this.CSRBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CSRBtn.Location = new System.Drawing.Point(367, 20);
            this.CSRBtn.Name = "CSRBtn";
            this.CSRBtn.Size = new System.Drawing.Size(75, 23);
            this.CSRBtn.TabIndex = 1;
            this.CSRBtn.Text = "Get";
            this.CSRBtn.UseVisualStyleBackColor = true;
            this.CSRBtn.Click += new System.EventHandler(this.CSRBtn_Click);
            // 
            // SystemTitleTb
            // 
            this.SystemTitleTb.Location = new System.Drawing.Point(93, 23);
            this.SystemTitleTb.Name = "SystemTitleTb";
            this.SystemTitleTb.Size = new System.Drawing.Size(200, 20);
            this.SystemTitleTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "System title:";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(99, 453);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 70;
            this.SaveBtn.Text = "Save...";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // GXCertifigateGenerationForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GXCertifigateGenerationForm";
            this.Text = " Certificate generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox Pkcs10Tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CSRBtn;
        private System.Windows.Forms.TextBox SystemTitleTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton DigitalSignatureCb;
        private System.Windows.Forms.RadioButton KeyAgreementCb;
        private System.Windows.Forms.Button SaveBtn;
    }
}