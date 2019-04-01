namespace Gurux.DLMS.UI
{
    partial class GXDLMSScriptActionDlg
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
            this.TypeLbl = new System.Windows.Forms.Label();
            this.TargetLbl = new System.Windows.Forms.Label();
            this.TypeCb = new System.Windows.Forms.ComboBox();
            this.TargetCb = new System.Windows.Forms.ComboBox();
            this.IndexLbl = new System.Windows.Forms.Label();
            this.IndexTB = new System.Windows.Forms.TextBox();
            this.ParameterTb = new System.Windows.Forms.TextBox();
            this.ParameterLbl = new System.Windows.Forms.Label();
            this.ParameterTypeTb = new System.Windows.Forms.ComboBox();
            this.ParameterTypeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(109, 172);
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
            this.CancelBtn.Location = new System.Drawing.Point(190, 172);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(12, 27);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(34, 13);
            this.TypeLbl.TabIndex = 2;
            this.TypeLbl.Text = "Type:";
            // 
            // TargetLbl
            // 
            this.TargetLbl.AutoSize = true;
            this.TargetLbl.Location = new System.Drawing.Point(12, 54);
            this.TargetLbl.Name = "TargetLbl";
            this.TargetLbl.Size = new System.Drawing.Size(41, 13);
            this.TargetLbl.TabIndex = 4;
            this.TargetLbl.Text = "Target:";
            // 
            // TypeCb
            // 
            this.TypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCb.FormattingEnabled = true;
            this.TypeCb.Location = new System.Drawing.Point(70, 27);
            this.TypeCb.Name = "TypeCb";
            this.TypeCb.Size = new System.Drawing.Size(195, 21);
            this.TypeCb.TabIndex = 5;
            // 
            // TargetCb
            // 
            this.TargetCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetCb.FormattingEnabled = true;
            this.TargetCb.Location = new System.Drawing.Point(70, 54);
            this.TargetCb.Name = "TargetCb";
            this.TargetCb.Size = new System.Drawing.Size(195, 21);
            this.TargetCb.TabIndex = 6;
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(12, 81);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(36, 13);
            this.IndexLbl.TabIndex = 7;
            this.IndexLbl.Text = "Index:";
            // 
            // IndexTB
            // 
            this.IndexTB.Location = new System.Drawing.Point(70, 81);
            this.IndexTB.Name = "IndexTB";
            this.IndexTB.Size = new System.Drawing.Size(195, 20);
            this.IndexTB.TabIndex = 8;
            // 
            // ParameterTb
            // 
            this.ParameterTb.Location = new System.Drawing.Point(70, 107);
            this.ParameterTb.Name = "ParameterTb";
            this.ParameterTb.Size = new System.Drawing.Size(195, 20);
            this.ParameterTb.TabIndex = 10;
            // 
            // ParameterLbl
            // 
            this.ParameterLbl.AutoSize = true;
            this.ParameterLbl.Location = new System.Drawing.Point(12, 107);
            this.ParameterLbl.Name = "ParameterLbl";
            this.ParameterLbl.Size = new System.Drawing.Size(58, 13);
            this.ParameterLbl.TabIndex = 9;
            this.ParameterLbl.Text = "Parameter:";
            // 
            // ParameterTypeTb
            // 
            this.ParameterTypeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParameterTypeTb.FormattingEnabled = true;
            this.ParameterTypeTb.Location = new System.Drawing.Point(70, 133);
            this.ParameterTypeTb.Name = "ParameterTypeTb";
            this.ParameterTypeTb.Size = new System.Drawing.Size(195, 21);
            this.ParameterTypeTb.TabIndex = 12;
            // 
            // ParameterTypeLbl
            // 
            this.ParameterTypeLbl.AutoSize = true;
            this.ParameterTypeLbl.Location = new System.Drawing.Point(12, 133);
            this.ParameterTypeLbl.Name = "ParameterTypeLbl";
            this.ParameterTypeLbl.Size = new System.Drawing.Size(34, 13);
            this.ParameterTypeLbl.TabIndex = 11;
            this.ParameterTypeLbl.Text = "Type:";
            // 
            // GXDLMSScriptActionDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(277, 207);
            this.ControlBox = false;
            this.Controls.Add(this.ParameterTypeTb);
            this.Controls.Add(this.ParameterTypeLbl);
            this.Controls.Add(this.ParameterTb);
            this.Controls.Add(this.ParameterLbl);
            this.Controls.Add(this.IndexTB);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.TargetCb);
            this.Controls.Add(this.TypeCb);
            this.Controls.Add(this.TargetLbl);
            this.Controls.Add(this.TypeLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSScriptActionDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Script";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label TypeLbl;
        private System.Windows.Forms.Label TargetLbl;
        private System.Windows.Forms.ComboBox TypeCb;
        private System.Windows.Forms.ComboBox TargetCb;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.TextBox IndexTB;
        private System.Windows.Forms.TextBox ParameterTb;
        private System.Windows.Forms.Label ParameterLbl;
        private System.Windows.Forms.ComboBox ParameterTypeTb;
        private System.Windows.Forms.Label ParameterTypeLbl;
    }
}