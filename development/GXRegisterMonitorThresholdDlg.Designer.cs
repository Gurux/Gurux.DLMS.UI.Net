namespace Gurux.DLMS.UI
{
    partial class GXRegisterMonitorThresholdDlg
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
            this.ValueTb = new System.Windows.Forms.TextBox();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ValueTypeTb = new System.Windows.Forms.ComboBox();
            this.ParameterTypeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueTb
            // 
            this.ValueTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTb.Location = new System.Drawing.Point(70, 12);
            this.ValueTb.Name = "ValueTb";
            this.ValueTb.Size = new System.Drawing.Size(197, 20);
            this.ValueTb.TabIndex = 20;
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(9, 12);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(37, 13);
            this.ValueLbl.TabIndex = 0;
            this.ValueLbl.Text = "Value:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(191, 73);
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
            this.OkBtn.Location = new System.Drawing.Point(110, 73);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 17;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // ValueTypeTb
            // 
            this.ValueTypeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTypeTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueTypeTb.FormattingEnabled = true;
            this.ValueTypeTb.Location = new System.Drawing.Point(70, 38);
            this.ValueTypeTb.Name = "ValueTypeTb";
            this.ValueTypeTb.Size = new System.Drawing.Size(196, 21);
            this.ValueTypeTb.TabIndex = 30;
            // 
            // ParameterTypeLbl
            // 
            this.ParameterTypeLbl.AutoSize = true;
            this.ParameterTypeLbl.Location = new System.Drawing.Point(12, 41);
            this.ParameterTypeLbl.Name = "ParameterTypeLbl";
            this.ParameterTypeLbl.Size = new System.Drawing.Size(34, 13);
            this.ParameterTypeLbl.TabIndex = 29;
            this.ParameterTypeLbl.Text = "Type:";
            // 
            // GXRegisterMonitorThresholdDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(278, 108);
            this.ControlBox = false;
            this.Controls.Add(this.ValueTypeTb);
            this.Controls.Add(this.ParameterTypeLbl);
            this.Controls.Add(this.ValueTb);
            this.Controls.Add(this.ValueLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GXRegisterMonitorThresholdDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Monitor Threshold";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ValueTb;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.ComboBox ValueTypeTb;
        private System.Windows.Forms.Label ParameterTypeLbl;
    }
}