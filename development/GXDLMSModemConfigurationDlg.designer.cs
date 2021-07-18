namespace Gurux.DLMS.UI
{
    partial class GXDLMSModemConfigurationDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSModemConfigurationDlg));
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DelayTb = new System.Windows.Forms.TextBox();
            this.DelayLbl = new System.Windows.Forms.Label();
            this.ResponseTb = new System.Windows.Forms.TextBox();
            this.ResponseLbl = new System.Windows.Forms.Label();
            this.RequestTb = new System.Windows.Forms.TextBox();
            this.RequestLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(157, 113);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(238, 113);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // DelayTb
            // 
            this.DelayTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelayTb.Location = new System.Drawing.Point(101, 57);
            this.DelayTb.Name = "DelayTb";
            this.DelayTb.Size = new System.Drawing.Size(212, 20);
            this.DelayTb.TabIndex = 2;
            // 
            // DelayLbl
            // 
            this.DelayLbl.AutoSize = true;
            this.DelayLbl.Location = new System.Drawing.Point(3, 57);
            this.DelayLbl.Name = "DelayLbl";
            this.DelayLbl.Size = new System.Drawing.Size(37, 13);
            this.DelayLbl.TabIndex = 9;
            this.DelayLbl.Text = "Delay:";
            // 
            // ResponseTb
            // 
            this.ResponseTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResponseTb.Location = new System.Drawing.Point(101, 31);
            this.ResponseTb.Name = "ResponseTb";
            this.ResponseTb.Size = new System.Drawing.Size(212, 20);
            this.ResponseTb.TabIndex = 1;
            // 
            // ResponseLbl
            // 
            this.ResponseLbl.AutoSize = true;
            this.ResponseLbl.Location = new System.Drawing.Point(3, 31);
            this.ResponseLbl.Name = "ResponseLbl";
            this.ResponseLbl.Size = new System.Drawing.Size(58, 13);
            this.ResponseLbl.TabIndex = 13;
            this.ResponseLbl.Text = "Response:";
            // 
            // RequestTb
            // 
            this.RequestTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestTb.Location = new System.Drawing.Point(101, 5);
            this.RequestTb.Name = "RequestTb";
            this.RequestTb.Size = new System.Drawing.Size(212, 20);
            this.RequestTb.TabIndex = 0;
            // 
            // RequestLbl
            // 
            this.RequestLbl.AutoSize = true;
            this.RequestLbl.Location = new System.Drawing.Point(3, 5);
            this.RequestLbl.Name = "RequestLbl";
            this.RequestLbl.Size = new System.Drawing.Size(50, 13);
            this.RequestLbl.TabIndex = 15;
            this.RequestLbl.Text = "Request:";
            // 
            // GXDLMSModemConfigurationDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(334, 148);
            this.Controls.Add(this.RequestTb);
            this.Controls.Add(this.RequestLbl);
            this.Controls.Add(this.ResponseTb);
            this.Controls.Add(this.ResponseLbl);
            this.Controls.Add(this.DelayTb);
            this.Controls.Add(this.DelayLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GXDLMSModemConfigurationDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modem Initialize settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox DelayTb;
        private System.Windows.Forms.Label DelayLbl;
        private System.Windows.Forms.TextBox ResponseTb;
        private System.Windows.Forms.Label ResponseLbl;
        private System.Windows.Forms.TextBox RequestTb;
        private System.Windows.Forms.Label RequestLbl;
    }
}