namespace Gurux.DLMS.UI
{
    partial class GXDLMSMBusClientDataDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSMBusClientDataDlg));
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.DataTb = new System.Windows.Forms.TextBox();
            this.DataLbl = new System.Windows.Forms.Label();
            this.DataTypeCb = new System.Windows.Forms.ComboBox();
            this.DataTypeLbl = new System.Windows.Forms.Label();
            this.DataInformationTb = new System.Windows.Forms.TextBox();
            this.DataInformationLbl = new System.Windows.Forms.Label();
            this.ValueInformationTb = new System.Windows.Forms.TextBox();
            this.ValueInformationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(157, 113);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 4;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(238, 113);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // DataTb
            // 
            this.DataTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTb.Location = new System.Drawing.Point(101, 57);
            this.DataTb.Name = "DataTb";
            this.DataTb.Size = new System.Drawing.Size(212, 20);
            this.DataTb.TabIndex = 2;
            // 
            // DataLbl
            // 
            this.DataLbl.AutoSize = true;
            this.DataLbl.Location = new System.Drawing.Point(3, 57);
            this.DataLbl.Name = "DataLbl";
            this.DataLbl.Size = new System.Drawing.Size(33, 13);
            this.DataLbl.TabIndex = 9;
            this.DataLbl.Text = "Data:";
            // 
            // DataTypeCb
            // 
            this.DataTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataTypeCb.FormattingEnabled = true;
            this.DataTypeCb.Location = new System.Drawing.Point(101, 83);
            this.DataTypeCb.Name = "DataTypeCb";
            this.DataTypeCb.Size = new System.Drawing.Size(212, 21);
            this.DataTypeCb.TabIndex = 3;
            // 
            // DataTypeLbl
            // 
            this.DataTypeLbl.AutoSize = true;
            this.DataTypeLbl.Location = new System.Drawing.Point(3, 83);
            this.DataTypeLbl.Name = "DataTypeLbl";
            this.DataTypeLbl.Size = new System.Drawing.Size(34, 13);
            this.DataTypeLbl.TabIndex = 11;
            this.DataTypeLbl.Text = "Type:";
            // 
            // DataInformationTb
            // 
            this.DataInformationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataInformationTb.Location = new System.Drawing.Point(101, 31);
            this.DataInformationTb.Name = "DataInformationTb";
            this.DataInformationTb.Size = new System.Drawing.Size(212, 20);
            this.DataInformationTb.TabIndex = 1;
            // 
            // DataInformationLbl
            // 
            this.DataInformationLbl.AutoSize = true;
            this.DataInformationLbl.Location = new System.Drawing.Point(3, 31);
            this.DataInformationLbl.Name = "DataInformationLbl";
            this.DataInformationLbl.Size = new System.Drawing.Size(88, 13);
            this.DataInformationLbl.TabIndex = 13;
            this.DataInformationLbl.Text = "Data Information:";
            // 
            // ValueInformationTb
            // 
            this.ValueInformationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueInformationTb.Location = new System.Drawing.Point(101, 5);
            this.ValueInformationTb.Name = "ValueInformationTb";
            this.ValueInformationTb.Size = new System.Drawing.Size(212, 20);
            this.ValueInformationTb.TabIndex = 0;
            // 
            // ValueInformationLbl
            // 
            this.ValueInformationLbl.AutoSize = true;
            this.ValueInformationLbl.Location = new System.Drawing.Point(3, 5);
            this.ValueInformationLbl.Name = "ValueInformationLbl";
            this.ValueInformationLbl.Size = new System.Drawing.Size(92, 13);
            this.ValueInformationLbl.TabIndex = 15;
            this.ValueInformationLbl.Text = "Value Information:";
            // 
            // GXDLMSMBusClientDataDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(334, 148);
            this.Controls.Add(this.ValueInformationTb);
            this.Controls.Add(this.ValueInformationLbl);
            this.Controls.Add(this.DataInformationTb);
            this.Controls.Add(this.DataInformationLbl);
            this.Controls.Add(this.DataTypeCb);
            this.Controls.Add(this.DataTypeLbl);
            this.Controls.Add(this.DataTb);
            this.Controls.Add(this.DataLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GXDLMSMBusClientDataDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sends data to the M-Bus slave device. ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox DataTb;
        private System.Windows.Forms.Label DataLbl;
        private System.Windows.Forms.ComboBox DataTypeCb;
        private System.Windows.Forms.Label DataTypeLbl;
        private System.Windows.Forms.TextBox DataInformationTb;
        private System.Windows.Forms.Label DataInformationLbl;
        private System.Windows.Forms.TextBox ValueInformationTb;
        private System.Windows.Forms.Label ValueInformationLbl;
    }
}