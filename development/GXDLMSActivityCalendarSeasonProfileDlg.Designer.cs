namespace Gurux.DLMS.UI
{
    partial class GXDLMSActivityCalendarSeasonProfileDlg
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.StartTb = new System.Windows.Forms.TextBox();
            this.StartLbl = new System.Windows.Forms.Label();
            this.WeekNameLbl = new System.Windows.Forms.Label();
            this.WeekNameCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(197, 104);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(116, 104);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 7;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // NameTb
            // 
            this.NameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTb.Location = new System.Drawing.Point(91, 12);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(181, 20);
            this.NameTb.TabIndex = 0;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(11, 12);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 21;
            this.NameLbl.Text = "Name:";
            // 
            // StartTb
            // 
            this.StartTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTb.Location = new System.Drawing.Point(91, 38);
            this.StartTb.Name = "StartTb";
            this.StartTb.Size = new System.Drawing.Size(181, 20);
            this.StartTb.TabIndex = 1;
            // 
            // StartLbl
            // 
            this.StartLbl.AutoSize = true;
            this.StartLbl.Location = new System.Drawing.Point(11, 38);
            this.StartLbl.Name = "StartLbl";
            this.StartLbl.Size = new System.Drawing.Size(32, 13);
            this.StartLbl.TabIndex = 23;
            this.StartLbl.Text = "Start:";
            // 
            // WeekNameLbl
            // 
            this.WeekNameLbl.AutoSize = true;
            this.WeekNameLbl.Location = new System.Drawing.Point(11, 64);
            this.WeekNameLbl.Name = "WeekNameLbl";
            this.WeekNameLbl.Size = new System.Drawing.Size(70, 13);
            this.WeekNameLbl.TabIndex = 33;
            this.WeekNameLbl.Text = "Week Name:";
            // 
            // WeekNameCb
            // 
            this.WeekNameCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeekNameCb.FormattingEnabled = true;
            this.WeekNameCb.Location = new System.Drawing.Point(91, 64);
            this.WeekNameCb.Name = "WeekNameCb";
            this.WeekNameCb.Size = new System.Drawing.Size(181, 21);
            this.WeekNameCb.Sorted = true;
            this.WeekNameCb.TabIndex = 34;
            // 
            // GXDLMSActivityCalendarSeasonProfileDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.WeekNameCb);
            this.Controls.Add(this.WeekNameLbl);
            this.Controls.Add(this.StartTb);
            this.Controls.Add(this.StartLbl);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GXDLMSActivityCalendarSeasonProfileDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Season Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox StartTb;
        private System.Windows.Forms.Label StartLbl;
        private System.Windows.Forms.Label WeekNameLbl;
        private System.Windows.Forms.ComboBox WeekNameCb;
    }
}