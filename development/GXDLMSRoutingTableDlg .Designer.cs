namespace Gurux.DLMS.UI
{
    partial class GXDLMSRoutingTableDlg
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
            this.DestinationTb = new System.Windows.Forms.TextBox();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.NextHopTb = new System.Windows.Forms.TextBox();
            this.NextHopLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OkBtn = new System.Windows.Forms.Button();
            this.RouteCostTb = new System.Windows.Forms.TextBox();
            this.RouteCostLbl = new System.Windows.Forms.Label();
            this.HopCountTb = new System.Windows.Forms.TextBox();
            this.HopCountLbl = new System.Windows.Forms.Label();
            this.WeakLinkCountTb = new System.Windows.Forms.TextBox();
            this.WeakLinkCountLbl = new System.Windows.Forms.Label();
            this.ValidTimeTb = new System.Windows.Forms.TextBox();
            this.ValidTimeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DestinationTb
            // 
            this.DestinationTb.Location = new System.Drawing.Point(74, 12);
            this.DestinationTb.Name = "DestinationTb";
            this.DestinationTb.Size = new System.Drawing.Size(198, 20);
            this.DestinationTb.TabIndex = 0;
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Location = new System.Drawing.Point(5, 12);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(63, 13);
            this.DestinationLbl.TabIndex = 13;
            this.DestinationLbl.Text = "Destination:";
            // 
            // NextHopTb
            // 
            this.NextHopTb.Location = new System.Drawing.Point(74, 38);
            this.NextHopTb.Name = "NextHopTb";
            this.NextHopTb.Size = new System.Drawing.Size(198, 20);
            this.NextHopTb.TabIndex = 1;
            // 
            // NextHopLbl
            // 
            this.NextHopLbl.AutoSize = true;
            this.NextHopLbl.Location = new System.Drawing.Point(5, 38);
            this.NextHopLbl.Name = "NextHopLbl";
            this.NextHopLbl.Size = new System.Drawing.Size(55, 13);
            this.NextHopLbl.TabIndex = 12;
            this.NextHopLbl.Text = "Next Hop:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(197, 182);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(116, 182);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 6;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // RouteCostTb
            // 
            this.RouteCostTb.Location = new System.Drawing.Point(74, 64);
            this.RouteCostTb.Name = "RouteCostTb";
            this.RouteCostTb.Size = new System.Drawing.Size(198, 20);
            this.RouteCostTb.TabIndex = 2;
            // 
            // RouteCostLbl
            // 
            this.RouteCostLbl.AutoSize = true;
            this.RouteCostLbl.Location = new System.Drawing.Point(5, 64);
            this.RouteCostLbl.Name = "RouteCostLbl";
            this.RouteCostLbl.Size = new System.Drawing.Size(62, 13);
            this.RouteCostLbl.TabIndex = 17;
            this.RouteCostLbl.Text = "Route cost:";
            // 
            // HopCountTb
            // 
            this.HopCountTb.Location = new System.Drawing.Point(74, 90);
            this.HopCountTb.Name = "HopCountTb";
            this.HopCountTb.Size = new System.Drawing.Size(198, 20);
            this.HopCountTb.TabIndex = 3;
            // 
            // HopCountLbl
            // 
            this.HopCountLbl.AutoSize = true;
            this.HopCountLbl.Location = new System.Drawing.Point(5, 90);
            this.HopCountLbl.Name = "HopCountLbl";
            this.HopCountLbl.Size = new System.Drawing.Size(60, 13);
            this.HopCountLbl.TabIndex = 16;
            this.HopCountLbl.Text = "Hop count:";
            // 
            // WeakLinkCountTb
            // 
            this.WeakLinkCountTb.Location = new System.Drawing.Point(74, 116);
            this.WeakLinkCountTb.Name = "WeakLinkCountTb";
            this.WeakLinkCountTb.Size = new System.Drawing.Size(198, 20);
            this.WeakLinkCountTb.TabIndex = 4;
            // 
            // WeakLinkCountLbl
            // 
            this.WeakLinkCountLbl.AutoSize = true;
            this.WeakLinkCountLbl.Location = new System.Drawing.Point(5, 116);
            this.WeakLinkCountLbl.Name = "WeakLinkCountLbl";
            this.WeakLinkCountLbl.Size = new System.Drawing.Size(58, 13);
            this.WeakLinkCountLbl.TabIndex = 21;
            this.WeakLinkCountLbl.Text = "Weak link:";
            // 
            // ValidTimeTb
            // 
            this.ValidTimeTb.Location = new System.Drawing.Point(74, 142);
            this.ValidTimeTb.Name = "ValidTimeTb";
            this.ValidTimeTb.Size = new System.Drawing.Size(198, 20);
            this.ValidTimeTb.TabIndex = 5;
            // 
            // ValidTimeLbl
            // 
            this.ValidTimeLbl.AutoSize = true;
            this.ValidTimeLbl.Location = new System.Drawing.Point(5, 142);
            this.ValidTimeLbl.Name = "ValidTimeLbl";
            this.ValidTimeLbl.Size = new System.Drawing.Size(55, 13);
            this.ValidTimeLbl.TabIndex = 20;
            this.ValidTimeLbl.Text = "Valid time:";
            // 
            // GXDLMSRoutingTableDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 217);
            this.ControlBox = false;
            this.Controls.Add(this.WeakLinkCountTb);
            this.Controls.Add(this.WeakLinkCountLbl);
            this.Controls.Add(this.ValidTimeTb);
            this.Controls.Add(this.ValidTimeLbl);
            this.Controls.Add(this.RouteCostTb);
            this.Controls.Add(this.RouteCostLbl);
            this.Controls.Add(this.HopCountTb);
            this.Controls.Add(this.HopCountLbl);
            this.Controls.Add(this.DestinationTb);
            this.Controls.Add(this.DestinationLbl);
            this.Controls.Add(this.NextHopTb);
            this.Controls.Add(this.NextHopLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GXDLMSRoutingTableDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Routing Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DestinationTb;
        private System.Windows.Forms.Label DestinationLbl;
        private System.Windows.Forms.TextBox NextHopTb;
        private System.Windows.Forms.Label NextHopLbl;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox RouteCostTb;
        private System.Windows.Forms.Label RouteCostLbl;
        private System.Windows.Forms.TextBox HopCountTb;
        private System.Windows.Forms.Label HopCountLbl;
        private System.Windows.Forms.TextBox WeakLinkCountTb;
        private System.Windows.Forms.Label WeakLinkCountLbl;
        private System.Windows.Forms.TextBox ValidTimeTb;
        private System.Windows.Forms.Label ValidTimeLbl;
    }
}