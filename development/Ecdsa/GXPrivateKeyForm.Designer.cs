namespace Gurux.DLMS.UI.Ecdsa
{
    partial class GXPrivateKeyForm
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
            this.PrivateKey = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Key256 = new System.Windows.Forms.RadioButton();
            this.Key384 = new System.Windows.Forms.RadioButton();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.GeneratedKeyTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TransformBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrivateKey
            // 
            this.PrivateKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrivateKey.Location = new System.Drawing.Point(92, 73);
            this.PrivateKey.Multiline = true;
            this.PrivateKey.Name = "PrivateKey";
            this.PrivateKey.Size = new System.Drawing.Size(507, 96);
            this.PrivateKey.TabIndex = 38;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(21, 76);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(63, 13);
            this.NameLbl.TabIndex = 40;
            this.NameLbl.Text = "Private key:";
            // 
            // Key256
            // 
            this.Key256.AutoSize = true;
            this.Key256.Checked = true;
            this.Key256.Location = new System.Drawing.Point(18, 23);
            this.Key256.Name = "Key256";
            this.Key256.Size = new System.Drawing.Size(43, 17);
            this.Key256.TabIndex = 42;
            this.Key256.TabStop = true;
            this.Key256.Text = "256";
            this.Key256.UseVisualStyleBackColor = true;
            // 
            // Key384
            // 
            this.Key384.AutoSize = true;
            this.Key384.Location = new System.Drawing.Point(80, 23);
            this.Key384.Name = "Key384";
            this.Key384.Size = new System.Drawing.Size(43, 17);
            this.Key384.TabIndex = 43;
            this.Key384.Text = "384";
            this.Key384.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(443, 413);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 44;
            this.OKBtn.Text = "&Save";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(524, 413);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 45;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Key256);
            this.groupBox1.Controls.Add(this.GenerateBtn);
            this.groupBox1.Controls.Add(this.Key384);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 55);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key type";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(156, 20);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 49;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // GeneratedKeyTb
            // 
            this.GeneratedKeyTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GeneratedKeyTb.Location = new System.Drawing.Point(92, 175);
            this.GeneratedKeyTb.Multiline = true;
            this.GeneratedKeyTb.Name = "GeneratedKeyTb";
            this.GeneratedKeyTb.Size = new System.Drawing.Size(507, 232);
            this.GeneratedKeyTb.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Generated:";
            // 
            // TransformBtn
            // 
            this.TransformBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransformBtn.Location = new System.Drawing.Point(524, 44);
            this.TransformBtn.Name = "TransformBtn";
            this.TransformBtn.Size = new System.Drawing.Size(75, 23);
            this.TransformBtn.TabIndex = 50;
            this.TransformBtn.Text = "Convert";
            this.TransformBtn.UseVisualStyleBackColor = true;
            this.TransformBtn.Click += new System.EventHandler(this.TransformBtn_Click);
            // 
            // GXPrivateKeyForm
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(611, 448);
            this.ControlBox = false;
            this.Controls.Add(this.TransformBtn);
            this.Controls.Add(this.GeneratedKeyTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.PrivateKey);
            this.Controls.Add(this.NameLbl);
            this.Name = "GXPrivateKeyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Private key generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PrivateKey;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.RadioButton Key256;
        private System.Windows.Forms.RadioButton Key384;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox GeneratedKeyTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button TransformBtn;
    }
}