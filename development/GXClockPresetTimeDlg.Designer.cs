namespace Gurux.DLMS.UI
{
    partial class GXClockPresetTimeDlg
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
            this.PresetTimeTb = new System.Windows.Forms.TextBox();
            this.PresetTimeLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.IntervalStartTb = new System.Windows.Forms.TextBox();
            this.IntervalStartLbl = new System.Windows.Forms.Label();
            this.IntervalEndTb = new System.Windows.Forms.TextBox();
            this.IntervalEndLbl = new System.Windows.Forms.Label();
            this.NowPresetBtn = new System.Windows.Forms.Button();
            this.NowStartBtn = new System.Windows.Forms.Button();
            this.NowEndBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PresetTimeTb
            // 
            this.PresetTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetTimeTb.Location = new System.Drawing.Point(85, 12);
            this.PresetTimeTb.Name = "PresetTimeTb";
            this.PresetTimeTb.Size = new System.Drawing.Size(132, 20);
            this.PresetTimeTb.TabIndex = 20;
            // 
            // PresetTimeLbl
            // 
            this.PresetTimeLbl.AutoSize = true;
            this.PresetTimeLbl.Location = new System.Drawing.Point(9, 12);
            this.PresetTimeLbl.Name = "PresetTimeLbl";
            this.PresetTimeLbl.Size = new System.Drawing.Size(66, 13);
            this.PresetTimeLbl.TabIndex = 19;
            this.PresetTimeLbl.Text = "Preset Time:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(223, 107);
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
            this.OkBtn.Location = new System.Drawing.Point(142, 107);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 17;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // IntervalStartTb
            // 
            this.IntervalStartTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntervalStartTb.Location = new System.Drawing.Point(85, 38);
            this.IntervalStartTb.Name = "IntervalStartTb";
            this.IntervalStartTb.Size = new System.Drawing.Size(132, 20);
            this.IntervalStartTb.TabIndex = 23;
            // 
            // IntervalStartLbl
            // 
            this.IntervalStartLbl.AutoSize = true;
            this.IntervalStartLbl.Location = new System.Drawing.Point(9, 38);
            this.IntervalStartLbl.Name = "IntervalStartLbl";
            this.IntervalStartLbl.Size = new System.Drawing.Size(70, 13);
            this.IntervalStartLbl.TabIndex = 22;
            this.IntervalStartLbl.Text = "Interval Start:";
            // 
            // IntervalEndTb
            // 
            this.IntervalEndTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntervalEndTb.Location = new System.Drawing.Point(85, 64);
            this.IntervalEndTb.Name = "IntervalEndTb";
            this.IntervalEndTb.Size = new System.Drawing.Size(132, 20);
            this.IntervalEndTb.TabIndex = 25;
            // 
            // IntervalEndLbl
            // 
            this.IntervalEndLbl.AutoSize = true;
            this.IntervalEndLbl.Location = new System.Drawing.Point(9, 64);
            this.IntervalEndLbl.Name = "IntervalEndLbl";
            this.IntervalEndLbl.Size = new System.Drawing.Size(67, 13);
            this.IntervalEndLbl.TabIndex = 24;
            this.IntervalEndLbl.Text = "Interval End:";
            // 
            // NowPresetBtn
            // 
            this.NowPresetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NowPresetBtn.Location = new System.Drawing.Point(223, 12);
            this.NowPresetBtn.Name = "NowPresetBtn";
            this.NowPresetBtn.Size = new System.Drawing.Size(75, 23);
            this.NowPresetBtn.TabIndex = 26;
            this.NowPresetBtn.Text = "Now";
            this.NowPresetBtn.UseVisualStyleBackColor = true;
            this.NowPresetBtn.Click += new System.EventHandler(this.NowPresetBtn_Click);
            // 
            // NowStartBtn
            // 
            this.NowStartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NowStartBtn.Location = new System.Drawing.Point(223, 38);
            this.NowStartBtn.Name = "NowStartBtn";
            this.NowStartBtn.Size = new System.Drawing.Size(75, 23);
            this.NowStartBtn.TabIndex = 27;
            this.NowStartBtn.Text = "Now";
            this.NowStartBtn.UseVisualStyleBackColor = true;
            this.NowStartBtn.Click += new System.EventHandler(this.NowStartBtn_Click);
            // 
            // NowEndBtn
            // 
            this.NowEndBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NowEndBtn.Location = new System.Drawing.Point(223, 64);
            this.NowEndBtn.Name = "NowEndBtn";
            this.NowEndBtn.Size = new System.Drawing.Size(75, 23);
            this.NowEndBtn.TabIndex = 28;
            this.NowEndBtn.Text = "Now";
            this.NowEndBtn.UseVisualStyleBackColor = true;
            this.NowEndBtn.Click += new System.EventHandler(this.NowEndBtn_Click);
            // 
            // GXClockPresetTimeDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(310, 142);
            this.ControlBox = false;
            this.Controls.Add(this.NowEndBtn);
            this.Controls.Add(this.NowStartBtn);
            this.Controls.Add(this.NowPresetBtn);
            this.Controls.Add(this.IntervalEndTb);
            this.Controls.Add(this.IntervalEndLbl);
            this.Controls.Add(this.IntervalStartTb);
            this.Controls.Add(this.IntervalStartLbl);
            this.Controls.Add(this.PresetTimeTb);
            this.Controls.Add(this.PresetTimeLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXClockPresetTimeDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preset Adjusting Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PresetTimeTb;
        private System.Windows.Forms.Label PresetTimeLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox IntervalStartTb;
        private System.Windows.Forms.Label IntervalStartLbl;
        private System.Windows.Forms.TextBox IntervalEndTb;
        private System.Windows.Forms.Label IntervalEndLbl;
        private System.Windows.Forms.Button NowPresetBtn;
        private System.Windows.Forms.Button NowStartBtn;
        private System.Windows.Forms.Button NowEndBtn;
    }
}