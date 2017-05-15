namespace Gurux.DLMS.UI
{
    partial class GXDateTimeDlg
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
            this.StartTimeTb = new System.Windows.Forms.TextBox();
            this.StartTimeLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.NowBtn = new System.Windows.Forms.Button();
            this.NowEndBtn = new System.Windows.Forms.Button();
            this.EndTimeTb = new System.Windows.Forms.TextBox();
            this.EndTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartTimeTb
            // 
            this.StartTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTimeTb.Location = new System.Drawing.Point(70, 12);
            this.StartTimeTb.Name = "StartTimeTb";
            this.StartTimeTb.Size = new System.Drawing.Size(149, 20);
            this.StartTimeTb.TabIndex = 20;
            // 
            // StartTimeLbl
            // 
            this.StartTimeLbl.AutoSize = true;
            this.StartTimeLbl.Location = new System.Drawing.Point(9, 12);
            this.StartTimeLbl.Name = "StartTimeLbl";
            this.StartTimeLbl.Size = new System.Drawing.Size(58, 13);
            this.StartTimeLbl.TabIndex = 19;
            this.StartTimeLbl.Text = "Start Time:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(225, 76);
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
            this.OkBtn.Location = new System.Drawing.Point(144, 76);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 17;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // NowBtn
            // 
            this.NowBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NowBtn.Location = new System.Drawing.Point(225, 10);
            this.NowBtn.Name = "NowBtn";
            this.NowBtn.Size = new System.Drawing.Size(75, 23);
            this.NowBtn.TabIndex = 21;
            this.NowBtn.Text = "Now";
            this.NowBtn.UseVisualStyleBackColor = true;
            this.NowBtn.Click += new System.EventHandler(this.NowBtn_Click);
            // 
            // NowEndBtn
            // 
            this.NowEndBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NowEndBtn.Location = new System.Drawing.Point(225, 36);
            this.NowEndBtn.Name = "NowEndBtn";
            this.NowEndBtn.Size = new System.Drawing.Size(75, 23);
            this.NowEndBtn.TabIndex = 24;
            this.NowEndBtn.Text = "Now";
            this.NowEndBtn.UseVisualStyleBackColor = true;
            this.NowEndBtn.Click += new System.EventHandler(this.NowEndBtn_Click);
            // 
            // EndTimeTb
            // 
            this.EndTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTimeTb.Location = new System.Drawing.Point(70, 38);
            this.EndTimeTb.Name = "EndTimeTb";
            this.EndTimeTb.Size = new System.Drawing.Size(149, 20);
            this.EndTimeTb.TabIndex = 23;
            // 
            // EndTimeLbl
            // 
            this.EndTimeLbl.AutoSize = true;
            this.EndTimeLbl.Location = new System.Drawing.Point(9, 38);
            this.EndTimeLbl.Name = "EndTimeLbl";
            this.EndTimeLbl.Size = new System.Drawing.Size(55, 13);
            this.EndTimeLbl.TabIndex = 22;
            this.EndTimeLbl.Text = "End Time:";
            // 
            // GXDateTimeDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(312, 111);
            this.ControlBox = false;
            this.Controls.Add(this.NowEndBtn);
            this.Controls.Add(this.EndTimeTb);
            this.Controls.Add(this.EndTimeLbl);
            this.Controls.Add(this.NowBtn);
            this.Controls.Add(this.StartTimeTb);
            this.Controls.Add(this.StartTimeLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDateTimeDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StartTimeTb;
        private System.Windows.Forms.Label StartTimeLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button NowBtn;
        private System.Windows.Forms.Button NowEndBtn;
        private System.Windows.Forms.TextBox EndTimeTb;
        private System.Windows.Forms.Label EndTimeLbl;
    }
}