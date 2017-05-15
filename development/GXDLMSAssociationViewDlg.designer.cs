namespace Gurux.DLMS.UI
{
    partial class GXDLMSAssociationViewDlg
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
            this.ObjectTypeLbl = new System.Windows.Forms.Label();
            this.ObjectTypeCb = new System.Windows.Forms.ComboBox();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.ShortNameTb = new System.Windows.Forms.TextBox();
            this.ShortNameLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTb = new System.Windows.Forms.Label();
            this.VerifyBtn = new System.Windows.Forms.Button();
            this.LogicalNameTb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(109, 175);
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
            this.CancelBtn.Location = new System.Drawing.Point(190, 175);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ObjectTypeLbl
            // 
            this.ObjectTypeLbl.AutoSize = true;
            this.ObjectTypeLbl.Location = new System.Drawing.Point(12, 12);
            this.ObjectTypeLbl.Name = "ObjectTypeLbl";
            this.ObjectTypeLbl.Size = new System.Drawing.Size(68, 13);
            this.ObjectTypeLbl.TabIndex = 4;
            this.ObjectTypeLbl.Text = "Object Type:";
            // 
            // ObjectTypeCb
            // 
            this.ObjectTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectTypeCb.FormattingEnabled = true;
            this.ObjectTypeCb.Location = new System.Drawing.Point(93, 12);
            this.ObjectTypeCb.Name = "ObjectTypeCb";
            this.ObjectTypeCb.Size = new System.Drawing.Size(172, 21);
            this.ObjectTypeCb.Sorted = true;
            this.ObjectTypeCb.TabIndex = 0;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(12, 39);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 7;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // ShortNameTb
            // 
            this.ShortNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortNameTb.Location = new System.Drawing.Point(93, 65);
            this.ShortNameTb.Name = "ShortNameTb";
            this.ShortNameTb.Size = new System.Drawing.Size(172, 20);
            this.ShortNameTb.TabIndex = 2;
            // 
            // ShortNameLbl
            // 
            this.ShortNameLbl.AutoSize = true;
            this.ShortNameLbl.Location = new System.Drawing.Point(12, 65);
            this.ShortNameLbl.Name = "ShortNameLbl";
            this.ShortNameLbl.Size = new System.Drawing.Size(66, 13);
            this.ShortNameLbl.TabIndex = 10;
            this.ShortNameLbl.Text = "Short Name:";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(14, 125);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 12;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTb.Location = new System.Drawing.Point(93, 125);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(172, 47);
            this.DescriptionTb.TabIndex = 13;
            // 
            // VerifyBtn
            // 
            this.VerifyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VerifyBtn.Location = new System.Drawing.Point(190, 95);
            this.VerifyBtn.Name = "VerifyBtn";
            this.VerifyBtn.Size = new System.Drawing.Size(75, 23);
            this.VerifyBtn.TabIndex = 3;
            this.VerifyBtn.Text = "Verify";
            this.VerifyBtn.UseVisualStyleBackColor = true;
            this.VerifyBtn.Click += new System.EventHandler(this.VerifyBtn_Click);
            // 
            // LogicalNameTb
            // 
            this.LogicalNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTb.FormattingEnabled = true;
            this.LogicalNameTb.Location = new System.Drawing.Point(93, 39);
            this.LogicalNameTb.Name = "LogicalNameTb";
            this.LogicalNameTb.Size = new System.Drawing.Size(172, 21);
            this.LogicalNameTb.TabIndex = 1;
            this.LogicalNameTb.SelectedIndexChanged += new System.EventHandler(this.LogicalNameTb_SelectedIndexChanged);
            // 
            // GXDLMSAssociationViewDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(277, 210);
            this.ControlBox = false;
            this.Controls.Add(this.LogicalNameTb);
            this.Controls.Add(this.VerifyBtn);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.ShortNameTb);
            this.Controls.Add(this.ShortNameLbl);
            this.Controls.Add(this.LogicalNameLbl);
            this.Controls.Add(this.ObjectTypeCb);
            this.Controls.Add(this.ObjectTypeLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSAssociationViewDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Association view Object";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label ObjectTypeLbl;
        private System.Windows.Forms.ComboBox ObjectTypeCb;
        private System.Windows.Forms.Label LogicalNameLbl;
        private System.Windows.Forms.TextBox ShortNameTb;
        private System.Windows.Forms.Label ShortNameLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label DescriptionTb;
        private System.Windows.Forms.Button VerifyBtn;
        private System.Windows.Forms.ComboBox LogicalNameTb;
    }
}