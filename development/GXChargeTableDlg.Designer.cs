namespace Gurux.DLMS.UI
{
    partial class GXChargeTableDlg
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
            this.IndexTb = new System.Windows.Forms.TextBox();
            this.IndexLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.ChargePerUnitTb = new System.Windows.Forms.TextBox();
            this.ChargePerUnitLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IndexTb
            // 
            this.IndexTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IndexTb.Location = new System.Drawing.Point(100, 12);
            this.IndexTb.Name = "IndexTb";
            this.IndexTb.Size = new System.Drawing.Size(175, 20);
            this.IndexTb.TabIndex = 20;
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(9, 12);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(36, 13);
            this.IndexLbl.TabIndex = 19;
            this.IndexLbl.Text = "Index:";
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
            // ChargePerUnitTb
            // 
            this.ChargePerUnitTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargePerUnitTb.Location = new System.Drawing.Point(100, 38);
            this.ChargePerUnitTb.Name = "ChargePerUnitTb";
            this.ChargePerUnitTb.Size = new System.Drawing.Size(175, 20);
            this.ChargePerUnitTb.TabIndex = 23;
            // 
            // ChargePerUnitLbl
            // 
            this.ChargePerUnitLbl.AutoSize = true;
            this.ChargePerUnitLbl.Location = new System.Drawing.Point(9, 38);
            this.ChargePerUnitLbl.Name = "ChargePerUnitLbl";
            this.ChargePerUnitLbl.Size = new System.Drawing.Size(85, 13);
            this.ChargePerUnitLbl.TabIndex = 22;
            this.ChargePerUnitLbl.Text = "Charge Per Unit:";
            // 
            // GXChargeTableDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(287, 111);
            this.ControlBox = false;
            this.Controls.Add(this.ChargePerUnitTb);
            this.Controls.Add(this.ChargePerUnitLbl);
            this.Controls.Add(this.IndexTb);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXChargeTableDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Charge Table Element";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IndexTb;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox ChargePerUnitTb;
        private System.Windows.Forms.Label ChargePerUnitLbl;
    }
}