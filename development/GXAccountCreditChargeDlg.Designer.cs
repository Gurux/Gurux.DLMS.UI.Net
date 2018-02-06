namespace Gurux.DLMS.UI
{
    partial class GXAccountCreditChargeDlg
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
            this.CreditLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ConfigurationLbl = new System.Windows.Forms.Label();
            this.CreditCb = new System.Windows.Forms.ComboBox();
            this.ChargeCb = new System.Windows.Forms.ComboBox();
            this.ChargeLbl = new System.Windows.Forms.Label();
            this.ConfigurationLb = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CreditLbl
            // 
            this.CreditLbl.AutoSize = true;
            this.CreditLbl.Location = new System.Drawing.Point(9, 12);
            this.CreditLbl.Name = "CreditLbl";
            this.CreditLbl.Size = new System.Drawing.Size(37, 13);
            this.CreditLbl.TabIndex = 19;
            this.CreditLbl.Text = "Credit:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(225, 150);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 4;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(144, 150);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 3;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ConfigurationLbl
            // 
            this.ConfigurationLbl.AutoSize = true;
            this.ConfigurationLbl.Location = new System.Drawing.Point(9, 66);
            this.ConfigurationLbl.Name = "ConfigurationLbl";
            this.ConfigurationLbl.Size = new System.Drawing.Size(72, 13);
            this.ConfigurationLbl.TabIndex = 22;
            this.ConfigurationLbl.Text = "Configuration:";
            // 
            // CreditCb
            // 
            this.CreditCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreditCb.FormattingEnabled = true;
            this.CreditCb.Location = new System.Drawing.Point(91, 12);
            this.CreditCb.Name = "CreditCb";
            this.CreditCb.Size = new System.Drawing.Size(209, 21);
            this.CreditCb.TabIndex = 0;
            // 
            // ChargeCb
            // 
            this.ChargeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChargeCb.FormattingEnabled = true;
            this.ChargeCb.Location = new System.Drawing.Point(91, 39);
            this.ChargeCb.Name = "ChargeCb";
            this.ChargeCb.Size = new System.Drawing.Size(209, 21);
            this.ChargeCb.TabIndex = 1;
            // 
            // ChargeLbl
            // 
            this.ChargeLbl.AutoSize = true;
            this.ChargeLbl.Location = new System.Drawing.Point(9, 39);
            this.ChargeLbl.Name = "ChargeLbl";
            this.ChargeLbl.Size = new System.Drawing.Size(44, 13);
            this.ChargeLbl.TabIndex = 80;
            this.ChargeLbl.Text = "Charge:";
            // 
            // ConfigurationLb
            // 
            this.ConfigurationLb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfigurationLb.FormattingEnabled = true;
            this.ConfigurationLb.Location = new System.Drawing.Point(93, 71);
            this.ConfigurationLb.Name = "ConfigurationLb";
            this.ConfigurationLb.Size = new System.Drawing.Size(207, 64);
            this.ConfigurationLb.TabIndex = 2;
            // 
            // GXAccountCreditChargeDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(312, 185);
            this.ControlBox = false;
            this.Controls.Add(this.ConfigurationLb);
            this.Controls.Add(this.ChargeCb);
            this.Controls.Add(this.ChargeLbl);
            this.Controls.Add(this.CreditCb);
            this.Controls.Add(this.ConfigurationLbl);
            this.Controls.Add(this.CreditLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXAccountCreditChargeDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Account Credit Charge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CreditLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label ConfigurationLbl;
        private System.Windows.Forms.ComboBox CreditCb;
        private System.Windows.Forms.ComboBox ChargeCb;
        private System.Windows.Forms.Label ChargeLbl;
        private System.Windows.Forms.CheckedListBox ConfigurationLb;
    }
}