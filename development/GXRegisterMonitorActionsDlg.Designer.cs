namespace Gurux.DLMS.UI
{
    partial class GXRegisterMonitorActionsDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpSelectorTb = new System.Windows.Forms.TextBox();
            this.UpSelectorLbl = new System.Windows.Forms.Label();
            this.UpNameCb = new System.Windows.Forms.ComboBox();
            this.UpNameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DownSelectorTb = new System.Windows.Forms.TextBox();
            this.DownSelectorLbl = new System.Windows.Forms.Label();
            this.DownNameCb = new System.Windows.Forms.ComboBox();
            this.DownNameLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(367, 116);
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
            this.OkBtn.Location = new System.Drawing.Point(286, 116);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 17;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UpSelectorTb);
            this.groupBox1.Controls.Add(this.UpSelectorLbl);
            this.groupBox1.Controls.Add(this.UpNameCb);
            this.groupBox1.Controls.Add(this.UpNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 53);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Up";
            // 
            // UpSelectorTb
            // 
            this.UpSelectorTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpSelectorTb.Location = new System.Drawing.Point(365, 18);
            this.UpSelectorTb.Name = "UpSelectorTb";
            this.UpSelectorTb.Size = new System.Drawing.Size(65, 20);
            this.UpSelectorTb.TabIndex = 27;
            // 
            // UpSelectorLbl
            // 
            this.UpSelectorLbl.AutoSize = true;
            this.UpSelectorLbl.Location = new System.Drawing.Point(304, 20);
            this.UpSelectorLbl.Name = "UpSelectorLbl";
            this.UpSelectorLbl.Size = new System.Drawing.Size(49, 13);
            this.UpSelectorLbl.TabIndex = 26;
            this.UpSelectorLbl.Text = "Selector:";
            // 
            // UpNameCb
            // 
            this.UpNameCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpNameCb.FormattingEnabled = true;
            this.UpNameCb.Location = new System.Drawing.Point(46, 18);
            this.UpNameCb.Name = "UpNameCb";
            this.UpNameCb.Size = new System.Drawing.Size(252, 21);
            this.UpNameCb.TabIndex = 25;
            // 
            // UpNameLbl
            // 
            this.UpNameLbl.AutoSize = true;
            this.UpNameLbl.Location = new System.Drawing.Point(2, 20);
            this.UpNameLbl.Name = "UpNameLbl";
            this.UpNameLbl.Size = new System.Drawing.Size(38, 13);
            this.UpNameLbl.TabIndex = 24;
            this.UpNameLbl.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DownSelectorTb);
            this.groupBox2.Controls.Add(this.DownSelectorLbl);
            this.groupBox2.Controls.Add(this.DownNameCb);
            this.groupBox2.Controls.Add(this.DownNameLbl);
            this.groupBox2.Location = new System.Drawing.Point(1, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 53);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action Down";
            // 
            // DownSelectorTb
            // 
            this.DownSelectorTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownSelectorTb.Location = new System.Drawing.Point(365, 18);
            this.DownSelectorTb.Name = "DownSelectorTb";
            this.DownSelectorTb.Size = new System.Drawing.Size(65, 20);
            this.DownSelectorTb.TabIndex = 27;
            // 
            // DownSelectorLbl
            // 
            this.DownSelectorLbl.AutoSize = true;
            this.DownSelectorLbl.Location = new System.Drawing.Point(304, 20);
            this.DownSelectorLbl.Name = "DownSelectorLbl";
            this.DownSelectorLbl.Size = new System.Drawing.Size(49, 13);
            this.DownSelectorLbl.TabIndex = 26;
            this.DownSelectorLbl.Text = "Selector:";
            // 
            // DownNameCb
            // 
            this.DownNameCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownNameCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DownNameCb.FormattingEnabled = true;
            this.DownNameCb.Location = new System.Drawing.Point(46, 18);
            this.DownNameCb.Name = "DownNameCb";
            this.DownNameCb.Size = new System.Drawing.Size(252, 21);
            this.DownNameCb.TabIndex = 25;
            // 
            // DownNameLbl
            // 
            this.DownNameLbl.AutoSize = true;
            this.DownNameLbl.Location = new System.Drawing.Point(2, 20);
            this.DownNameLbl.Name = "DownNameLbl";
            this.DownNameLbl.Size = new System.Drawing.Size(38, 13);
            this.DownNameLbl.TabIndex = 24;
            this.DownNameLbl.Text = "Name:";
            // 
            // GXRegisterMonitorActionsDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(454, 151);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GXRegisterMonitorActionsDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register Monitor Action";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox UpSelectorTb;
        private System.Windows.Forms.Label UpSelectorLbl;
        private System.Windows.Forms.ComboBox UpNameCb;
        private System.Windows.Forms.Label UpNameLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DownSelectorTb;
        private System.Windows.Forms.Label DownSelectorLbl;
        private System.Windows.Forms.ComboBox DownNameCb;
        private System.Windows.Forms.Label DownNameLbl;
    }
}