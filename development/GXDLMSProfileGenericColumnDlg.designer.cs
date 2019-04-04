namespace Gurux.DLMS.UI
{
    partial class GXDLMSProfileGenericColumnDlg
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
            this.IndexLbl = new System.Windows.Forms.Label();
            this.IndexTB = new System.Windows.Forms.TextBox();
            this.DataIndexTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(225, 93);
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
            this.CancelBtn.Location = new System.Drawing.Point(306, 93);
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
            this.TargetCb.FormattingEnabled = true;
            this.TargetCb.Location = new System.Drawing.Point(80, 12);
            this.TargetCb.Name = "TargetCb";
            this.TargetCb.Size = new System.Drawing.Size(301, 21);
            this.TargetCb.TabIndex = 6;
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(12, 39);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(36, 13);
            this.IndexLbl.TabIndex = 7;
            this.IndexLbl.Text = "Index:";
            // 
            // IndexTB
            // 
            this.IndexTB.Location = new System.Drawing.Point(80, 39);
            this.IndexTB.Name = "IndexTB";
            this.IndexTB.Size = new System.Drawing.Size(89, 20);
            this.IndexTB.TabIndex = 8;
            // 
            // DataIndexTb
            // 
            this.DataIndexTb.Location = new System.Drawing.Point(292, 39);
            this.DataIndexTb.Name = "DataIndexTb";
            this.DataIndexTb.Size = new System.Drawing.Size(89, 20);
            this.DataIndexTb.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Index:";
            // 
            // GXDLMSProfileGenericColumnDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(393, 128);
            this.ControlBox = false;
            this.Controls.Add(this.DataIndexTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IndexTB);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.TargetCb);
            this.Controls.Add(this.TargetLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSProfileGenericColumnDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Generic Capture Object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label TargetLbl;
        private System.Windows.Forms.ComboBox TargetCb;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.TextBox IndexTB;
        private System.Windows.Forms.TextBox DataIndexTb;
        private System.Windows.Forms.Label label1;
    }
}