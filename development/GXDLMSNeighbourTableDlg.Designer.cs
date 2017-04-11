namespace Gurux.DLMS.UI
{
    partial class GXDLMSNeighbourTableDlg
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
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.ToneMapTb = new System.Windows.Forms.TextBox();
            this.ToneMapLbl = new System.Windows.Forms.Label();
            this.ModulationLbl = new System.Windows.Forms.Label();
            this.LinkQualityIndicatorTb = new System.Windows.Forms.TextBox();
            this.LinkQualityIndicatorLbl = new System.Windows.Forms.Label();
            this.TransmitterGainTb = new System.Windows.Forms.TextBox();
            this.TransmitterGainLbl = new System.Windows.Forms.Label();
            this.TxGainResolutionLbl = new System.Windows.Forms.Label();
            this.TxGainTb = new System.Windows.Forms.TextBox();
            this.TxGainLbl = new System.Windows.Forms.Label();
            this.ValidTimeTb = new System.Windows.Forms.TextBox();
            this.ValidTimeLbl = new System.Windows.Forms.Label();
            this.TMRValidTimeTb = new System.Windows.Forms.TextBox();
            this.TMRValidTimeLbl = new System.Windows.Forms.Label();
            this.PhaseDifferenceTb = new System.Windows.Forms.TextBox();
            this.PhaseDifferenceLbl = new System.Windows.Forms.Label();
            this.EnabledCB = new System.Windows.Forms.CheckBox();
            this.ModulationCb = new System.Windows.Forms.ComboBox();
            this.TxGainResolutionCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(294, 300);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(213, 300);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 11;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(163, 12);
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(205, 20);
            this.AddressTb.TabIndex = 0;
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(12, 12);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(48, 13);
            this.AddressLbl.TabIndex = 7;
            this.AddressLbl.Text = "Address:";
            // 
            // ToneMapTb
            // 
            this.ToneMapTb.Location = new System.Drawing.Point(163, 64);
            this.ToneMapTb.Name = "ToneMapTb";
            this.ToneMapTb.Size = new System.Drawing.Size(205, 20);
            this.ToneMapTb.TabIndex = 2;
            // 
            // ToneMapLbl
            // 
            this.ToneMapLbl.AutoSize = true;
            this.ToneMapLbl.Location = new System.Drawing.Point(12, 64);
            this.ToneMapLbl.Name = "ToneMapLbl";
            this.ToneMapLbl.Size = new System.Drawing.Size(59, 13);
            this.ToneMapLbl.TabIndex = 11;
            this.ToneMapLbl.Text = "Tone Map:";
            // 
            // ModulationLbl
            // 
            this.ModulationLbl.AutoSize = true;
            this.ModulationLbl.Location = new System.Drawing.Point(12, 90);
            this.ModulationLbl.Name = "ModulationLbl";
            this.ModulationLbl.Size = new System.Drawing.Size(62, 13);
            this.ModulationLbl.TabIndex = 13;
            this.ModulationLbl.Text = "Modulation:";
            // 
            // LinkQualityIndicatorTb
            // 
            this.LinkQualityIndicatorTb.Location = new System.Drawing.Point(163, 194);
            this.LinkQualityIndicatorTb.Name = "LinkQualityIndicatorTb";
            this.LinkQualityIndicatorTb.Size = new System.Drawing.Size(205, 20);
            this.LinkQualityIndicatorTb.TabIndex = 7;
            // 
            // LinkQualityIndicatorLbl
            // 
            this.LinkQualityIndicatorLbl.AutoSize = true;
            this.LinkQualityIndicatorLbl.Location = new System.Drawing.Point(12, 194);
            this.LinkQualityIndicatorLbl.Name = "LinkQualityIndicatorLbl";
            this.LinkQualityIndicatorLbl.Size = new System.Drawing.Size(109, 13);
            this.LinkQualityIndicatorLbl.TabIndex = 21;
            this.LinkQualityIndicatorLbl.Text = "Link Quality Indicator:";
            // 
            // TransmitterGainTb
            // 
            this.TransmitterGainTb.Location = new System.Drawing.Point(163, 168);
            this.TransmitterGainTb.Name = "TransmitterGainTb";
            this.TransmitterGainTb.Size = new System.Drawing.Size(205, 20);
            this.TransmitterGainTb.TabIndex = 6;
            // 
            // TransmitterGainLbl
            // 
            this.TransmitterGainLbl.AutoSize = true;
            this.TransmitterGainLbl.Location = new System.Drawing.Point(12, 168);
            this.TransmitterGainLbl.Name = "TransmitterGainLbl";
            this.TransmitterGainLbl.Size = new System.Drawing.Size(85, 13);
            this.TransmitterGainLbl.TabIndex = 19;
            this.TransmitterGainLbl.Text = "Transmitter gain:";
            // 
            // TxGainResolutionLbl
            // 
            this.TxGainResolutionLbl.AutoSize = true;
            this.TxGainResolutionLbl.Location = new System.Drawing.Point(12, 142);
            this.TxGainResolutionLbl.Name = "TxGainResolutionLbl";
            this.TxGainResolutionLbl.Size = new System.Drawing.Size(75, 13);
            this.TxGainResolutionLbl.TabIndex = 17;
            this.TxGainResolutionLbl.Text = "Tx Resolution:";
            // 
            // TxGainTb
            // 
            this.TxGainTb.Location = new System.Drawing.Point(163, 116);
            this.TxGainTb.Name = "TxGainTb";
            this.TxGainTb.Size = new System.Drawing.Size(205, 20);
            this.TxGainTb.TabIndex = 4;
            // 
            // TxGainLbl
            // 
            this.TxGainLbl.AutoSize = true;
            this.TxGainLbl.Location = new System.Drawing.Point(12, 116);
            this.TxGainLbl.Name = "TxGainLbl";
            this.TxGainLbl.Size = new System.Drawing.Size(47, 13);
            this.TxGainLbl.TabIndex = 15;
            this.TxGainLbl.Text = "Tx Gain:";
            // 
            // ValidTimeTb
            // 
            this.ValidTimeTb.Location = new System.Drawing.Point(163, 272);
            this.ValidTimeTb.Name = "ValidTimeTb";
            this.ValidTimeTb.Size = new System.Drawing.Size(205, 20);
            this.ValidTimeTb.TabIndex = 10;
            // 
            // ValidTimeLbl
            // 
            this.ValidTimeLbl.AutoSize = true;
            this.ValidTimeLbl.Location = new System.Drawing.Point(12, 272);
            this.ValidTimeLbl.Name = "ValidTimeLbl";
            this.ValidTimeLbl.Size = new System.Drawing.Size(56, 13);
            this.ValidTimeLbl.TabIndex = 27;
            this.ValidTimeLbl.Text = "Valid Time";
            // 
            // TMRValidTimeTb
            // 
            this.TMRValidTimeTb.Location = new System.Drawing.Point(163, 246);
            this.TMRValidTimeTb.Name = "TMRValidTimeTb";
            this.TMRValidTimeTb.Size = new System.Drawing.Size(205, 20);
            this.TMRValidTimeTb.TabIndex = 9;
            // 
            // TMRValidTimeLbl
            // 
            this.TMRValidTimeLbl.AutoSize = true;
            this.TMRValidTimeLbl.Location = new System.Drawing.Point(12, 246);
            this.TMRValidTimeLbl.Name = "TMRValidTimeLbl";
            this.TMRValidTimeLbl.Size = new System.Drawing.Size(86, 13);
            this.TMRValidTimeLbl.TabIndex = 25;
            this.TMRValidTimeLbl.Text = "TMR Valid Time:";
            // 
            // PhaseDifferenceTb
            // 
            this.PhaseDifferenceTb.Location = new System.Drawing.Point(163, 220);
            this.PhaseDifferenceTb.Name = "PhaseDifferenceTb";
            this.PhaseDifferenceTb.Size = new System.Drawing.Size(205, 20);
            this.PhaseDifferenceTb.TabIndex = 8;
            // 
            // PhaseDifferenceLbl
            // 
            this.PhaseDifferenceLbl.AutoSize = true;
            this.PhaseDifferenceLbl.Location = new System.Drawing.Point(12, 220);
            this.PhaseDifferenceLbl.Name = "PhaseDifferenceLbl";
            this.PhaseDifferenceLbl.Size = new System.Drawing.Size(90, 13);
            this.PhaseDifferenceLbl.TabIndex = 23;
            this.PhaseDifferenceLbl.Text = "Phase difference:";
            // 
            // EnabledCB
            // 
            this.EnabledCB.AutoSize = true;
            this.EnabledCB.Location = new System.Drawing.Point(163, 38);
            this.EnabledCB.Name = "EnabledCB";
            this.EnabledCB.Size = new System.Drawing.Size(65, 17);
            this.EnabledCB.TabIndex = 1;
            this.EnabledCB.Text = "Enabled";
            this.EnabledCB.UseVisualStyleBackColor = true;
            // 
            // ModulationCb
            // 
            this.ModulationCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModulationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModulationCb.FormattingEnabled = true;
            this.ModulationCb.Location = new System.Drawing.Point(163, 90);
            this.ModulationCb.Name = "ModulationCb";
            this.ModulationCb.Size = new System.Drawing.Size(206, 21);
            this.ModulationCb.TabIndex = 3;
            // 
            // TxGainResolutionCb
            // 
            this.TxGainResolutionCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxGainResolutionCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxGainResolutionCb.FormattingEnabled = true;
            this.TxGainResolutionCb.Location = new System.Drawing.Point(163, 142);
            this.TxGainResolutionCb.Name = "TxGainResolutionCb";
            this.TxGainResolutionCb.Size = new System.Drawing.Size(206, 21);
            this.TxGainResolutionCb.TabIndex = 5;
            // 
            // GXDLMSNeighbourTableDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(381, 335);
            this.ControlBox = false;
            this.Controls.Add(this.TxGainResolutionCb);
            this.Controls.Add(this.ModulationCb);
            this.Controls.Add(this.EnabledCB);
            this.Controls.Add(this.ValidTimeTb);
            this.Controls.Add(this.ValidTimeLbl);
            this.Controls.Add(this.TMRValidTimeTb);
            this.Controls.Add(this.TMRValidTimeLbl);
            this.Controls.Add(this.PhaseDifferenceTb);
            this.Controls.Add(this.PhaseDifferenceLbl);
            this.Controls.Add(this.LinkQualityIndicatorTb);
            this.Controls.Add(this.LinkQualityIndicatorLbl);
            this.Controls.Add(this.TransmitterGainTb);
            this.Controls.Add(this.TransmitterGainLbl);
            this.Controls.Add(this.TxGainResolutionLbl);
            this.Controls.Add(this.TxGainTb);
            this.Controls.Add(this.TxGainLbl);
            this.Controls.Add(this.ModulationLbl);
            this.Controls.Add(this.ToneMapTb);
            this.Controls.Add(this.ToneMapLbl);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GXDLMSNeighbourTableDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Neighbour Table";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox ToneMapTb;
        private System.Windows.Forms.Label ToneMapLbl;
        private System.Windows.Forms.Label ModulationLbl;
        private System.Windows.Forms.TextBox LinkQualityIndicatorTb;
        private System.Windows.Forms.Label LinkQualityIndicatorLbl;
        private System.Windows.Forms.TextBox TransmitterGainTb;
        private System.Windows.Forms.Label TransmitterGainLbl;
        private System.Windows.Forms.Label TxGainResolutionLbl;
        private System.Windows.Forms.TextBox TxGainTb;
        private System.Windows.Forms.Label TxGainLbl;
        private System.Windows.Forms.TextBox ValidTimeTb;
        private System.Windows.Forms.Label ValidTimeLbl;
        private System.Windows.Forms.TextBox TMRValidTimeTb;
        private System.Windows.Forms.Label TMRValidTimeLbl;
        private System.Windows.Forms.TextBox PhaseDifferenceTb;
        private System.Windows.Forms.Label PhaseDifferenceLbl;
        private System.Windows.Forms.CheckBox EnabledCB;
        private System.Windows.Forms.ComboBox ModulationCb;
        private System.Windows.Forms.ComboBox TxGainResolutionCb;
    }
}