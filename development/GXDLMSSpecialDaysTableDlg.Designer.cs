namespace Gurux.DLMS.UI
{
    partial class GXDLMSSpecialDaysTableDlg
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
            this.DayIdTb = new System.Windows.Forms.TextBox();
            this.DayIdLbl = new System.Windows.Forms.Label();
            this.DateTb = new System.Windows.Forms.TextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IndexTb
            // 
            this.IndexTb.Location = new System.Drawing.Point(59, 12);
            this.IndexTb.Name = "IndexTb";
            this.IndexTb.Size = new System.Drawing.Size(143, 20);
            this.IndexTb.TabIndex = 12;
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(8, 12);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(36, 13);
            this.IndexLbl.TabIndex = 11;
            this.IndexLbl.Text = "Index:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(199, 122);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(118, 122);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 9;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // DayIdTb
            // 
            this.DayIdTb.Location = new System.Drawing.Point(59, 64);
            this.DayIdTb.Name = "DayIdTb";
            this.DayIdTb.Size = new System.Drawing.Size(143, 20);
            this.DayIdTb.TabIndex = 14;
            // 
            // DayIdLbl
            // 
            this.DayIdLbl.AutoSize = true;
            this.DayIdLbl.Location = new System.Drawing.Point(8, 64);
            this.DayIdLbl.Name = "DayIdLbl";
            this.DayIdLbl.Size = new System.Drawing.Size(43, 13);
            this.DayIdLbl.TabIndex = 13;
            this.DayIdLbl.Text = "Day ID:";
            // 
            // DateTb
            // 
            this.DateTb.Location = new System.Drawing.Point(59, 38);
            this.DateTb.Name = "DateTb";
            this.DateTb.Size = new System.Drawing.Size(143, 20);
            this.DateTb.TabIndex = 16;
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(8, 38);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(33, 13);
            this.DateLbl.TabIndex = 15;
            this.DateLbl.Text = "Date:";
            // 
            // GXDLMSSpecialDaysTableDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(286, 157);
            this.ControlBox = false;
            this.Controls.Add(this.DateTb);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.DayIdTb);
            this.Controls.Add(this.DayIdLbl);
            this.Controls.Add(this.IndexTb);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSSpecialDaysTableDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Special Day";
            this.Load += new System.EventHandler(this.GXDLMSSpecialDaysTableDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IndexTb;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox DayIdTb;
        private System.Windows.Forms.Label DayIdLbl;
        private System.Windows.Forms.TextBox DateTb;
        private System.Windows.Forms.Label DateLbl;
    }
}