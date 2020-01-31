namespace Gurux.DLMS.UI
{
    partial class GXDLMSRegisterActivationDlg
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.IndexLbl = new System.Windows.Forms.Label();
            this.IndexTB = new System.Windows.Forms.TextBox();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.SystemTitleAsciiCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(169, 84);
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
            this.CancelBtn.Location = new System.Drawing.Point(250, 84);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(12, 12);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(38, 13);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Name:";
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(12, 39);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(47, 13);
            this.IndexLbl.TabIndex = 7;
            this.IndexLbl.Text = "Indexes:";
            // 
            // IndexTB
            // 
            this.IndexTB.Location = new System.Drawing.Point(63, 39);
            this.IndexTB.Name = "IndexTB";
            this.IndexTB.Size = new System.Drawing.Size(262, 20);
            this.IndexTB.TabIndex = 8;
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(63, 13);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(181, 20);
            this.NameTb.TabIndex = 0;
            // 
            // SystemTitleAsciiCb
            // 
            this.SystemTitleAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemTitleAsciiCb.AutoSize = true;
            this.SystemTitleAsciiCb.Location = new System.Drawing.Point(272, 15);
            this.SystemTitleAsciiCb.Name = "SystemTitleAsciiCb";
            this.SystemTitleAsciiCb.Size = new System.Drawing.Size(53, 17);
            this.SystemTitleAsciiCb.TabIndex = 59;
            this.SystemTitleAsciiCb.Text = "ASCII";
            this.SystemTitleAsciiCb.UseVisualStyleBackColor = true;
            this.SystemTitleAsciiCb.CheckedChanged += new System.EventHandler(this.SystemTitleAsciiCb_CheckedChanged);
            // 
            // GXDLMSRegisterActivationDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(337, 119);
            this.ControlBox = false;
            this.Controls.Add(this.SystemTitleAsciiCb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.IndexTB);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSRegisterActivationDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Target";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.TextBox IndexTB;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.CheckBox SystemTitleAsciiCb;
    }
}