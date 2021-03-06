﻿namespace Gurux.DLMS.UI
{
    partial class GXImageDlg
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
            this.TextTb = new System.Windows.Forms.TextBox();
            this.TextLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.FileNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.AsciiCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TextTb
            // 
            this.TextTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTb.Location = new System.Drawing.Point(85, 9);
            this.TextTb.Name = "TextTb";
            this.TextTb.Size = new System.Drawing.Size(134, 20);
            this.TextTb.TabIndex = 0;
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Location = new System.Drawing.Point(9, 12);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(70, 13);
            this.TextLbl.TabIndex = 19;
            this.TextLbl.Text = "Identification:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(225, 76);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(144, 76);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 5;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // FileNameTb
            // 
            this.FileNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNameTb.Location = new System.Drawing.Point(85, 35);
            this.FileNameTb.Name = "FileNameTb";
            this.FileNameTb.Size = new System.Drawing.Size(134, 20);
            this.FileNameTb.TabIndex = 2;
            this.FileNameTb.TextChanged += new System.EventHandler(this.FileNameTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Image:";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBtn.Location = new System.Drawing.Point(225, 35);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.BrowseBtn.TabIndex = 3;
            this.BrowseBtn.Text = "Browse...";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoBtn.Enabled = false;
            this.InfoBtn.Location = new System.Drawing.Point(12, 76);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(75, 23);
            this.InfoBtn.TabIndex = 4;
            this.InfoBtn.Text = "Info...";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // AsciiCb
            // 
            this.AsciiCb.AutoSize = true;
            this.AsciiCb.Checked = true;
            this.AsciiCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AsciiCb.Location = new System.Drawing.Point(225, 11);
            this.AsciiCb.Name = "AsciiCb";
            this.AsciiCb.Size = new System.Drawing.Size(53, 17);
            this.AsciiCb.TabIndex = 1;
            this.AsciiCb.Text = "ASCII";
            this.AsciiCb.UseVisualStyleBackColor = true;
            // 
            // GXImageDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(312, 111);
            this.ControlBox = false;
            this.Controls.Add(this.AsciiCb);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.FileNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextTb);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXImageDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseBtn;
        public System.Windows.Forms.TextBox TextTb;
        public System.Windows.Forms.TextBox FileNameTb;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.CheckBox AsciiCb;
    }
}