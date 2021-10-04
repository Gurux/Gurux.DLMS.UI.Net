namespace Gurux.DLMS.UI
{
    partial class GXDLMSNtpDlg
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
            this.IdTb = new System.Windows.Forms.TextBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.KeyTb = new System.Windows.Forms.TextBox();
            this.KeyLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdTb
            // 
            this.IdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTb.Location = new System.Drawing.Point(70, 12);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(205, 20);
            this.IdTb.TabIndex = 20;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(9, 12);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(21, 13);
            this.IdLbl.TabIndex = 19;
            this.IdLbl.Text = "ID:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(200, 76);
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
            this.OkBtn.Location = new System.Drawing.Point(119, 76);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 17;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // KeyTb
            // 
            this.KeyTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyTb.Location = new System.Drawing.Point(70, 38);
            this.KeyTb.Name = "KeyTb";
            this.KeyTb.Size = new System.Drawing.Size(205, 20);
            this.KeyTb.TabIndex = 23;
            // 
            // KeyLbl
            // 
            this.KeyLbl.AutoSize = true;
            this.KeyLbl.Location = new System.Drawing.Point(9, 38);
            this.KeyLbl.Name = "KeyLbl";
            this.KeyLbl.Size = new System.Drawing.Size(28, 13);
            this.KeyLbl.TabIndex = 22;
            this.KeyLbl.Text = "Key:";
            // 
            // GXDLMSNtpDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(287, 111);
            this.ControlBox = false;
            this.Controls.Add(this.KeyTb);
            this.Controls.Add(this.KeyLbl);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSNtpDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NTP authentication key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox KeyTb;
        private System.Windows.Forms.Label KeyLbl;
    }
}