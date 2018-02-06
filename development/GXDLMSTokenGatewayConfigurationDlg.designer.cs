namespace Gurux.DLMS.UI
{
    partial class GXDLMSTokenGatewayConfigurationDlg
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TargetLbl = new System.Windows.Forms.Label();
            this.TargetCb = new System.Windows.Forms.ComboBox();
            this.ProportionLbl = new System.Windows.Forms.Label();
            this.ProportionTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(109, 84);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(190, 84);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // TargetLbl
            // 
            this.TargetLbl.AutoSize = true;
            this.TargetLbl.Location = new System.Drawing.Point(12, 12);
            this.TargetLbl.Name = "TargetLbl";
            this.TargetLbl.Size = new System.Drawing.Size(41, 13);
            this.TargetLbl.TabIndex = 4;
            this.TargetLbl.Text = "Target:";
            // 
            // TargetCb
            // 
            this.TargetCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetCb.FormattingEnabled = true;
            this.TargetCb.Location = new System.Drawing.Point(76, 12);
            this.TargetCb.Name = "TargetCb";
            this.TargetCb.Size = new System.Drawing.Size(189, 21);
            this.TargetCb.TabIndex = 6;
            // 
            // ProportionLbl
            // 
            this.ProportionLbl.AutoSize = true;
            this.ProportionLbl.Location = new System.Drawing.Point(12, 39);
            this.ProportionLbl.Name = "ProportionLbl";
            this.ProportionLbl.Size = new System.Drawing.Size(58, 13);
            this.ProportionLbl.TabIndex = 7;
            this.ProportionLbl.Text = "Proportion:";
            // 
            // ProportionTb
            // 
            this.ProportionTb.Location = new System.Drawing.Point(76, 39);
            this.ProportionTb.Name = "ProportionTb";
            this.ProportionTb.Size = new System.Drawing.Size(189, 20);
            this.ProportionTb.TabIndex = 8;
            // 
            // GXDLMSTokenGatewayConfigurationDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(277, 119);
            this.ControlBox = false;
            this.Controls.Add(this.ProportionTb);
            this.Controls.Add(this.ProportionLbl);
            this.Controls.Add(this.TargetCb);
            this.Controls.Add(this.TargetLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSTokenGatewayConfigurationDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Target";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label TargetLbl;
        private System.Windows.Forms.ComboBox TargetCb;
        private System.Windows.Forms.Label ProportionLbl;
        private System.Windows.Forms.TextBox ProportionTb;
    }
}