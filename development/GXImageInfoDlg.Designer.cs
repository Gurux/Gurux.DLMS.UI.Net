namespace Gurux.DLMS.UI
{
    partial class GXImageInfoDlg
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
            this.ImageInfo = new System.Windows.Forms.ListView();
            this.DescriptionCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValueCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(277, 332);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Close";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ImageInfo
            // 
            this.ImageInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DescriptionCh,
            this.ValueCh});
            this.ImageInfo.FullRowSelect = true;
            this.ImageInfo.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ImageInfo.HideSelection = false;
            this.ImageInfo.Location = new System.Drawing.Point(2, 12);
            this.ImageInfo.Name = "ImageInfo";
            this.ImageInfo.Size = new System.Drawing.Size(350, 314);
            this.ImageInfo.TabIndex = 0;
            this.ImageInfo.UseCompatibleStateImageBehavior = false;
            this.ImageInfo.View = System.Windows.Forms.View.Details;
            // 
            // DescriptionCh
            // 
            this.DescriptionCh.Text = "Description";
            this.DescriptionCh.Width = 112;
            // 
            // ValueCh
            // 
            this.ValueCh.Text = "Value";
            this.ValueCh.Width = 173;
            // 
            // GXImageInfoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(364, 367);
            this.ControlBox = false;
            this.Controls.Add(this.ImageInfo);
            this.Controls.Add(this.CancelBtn);
            this.Name = "GXImageInfoDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image information:";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ListView ImageInfo;
        private System.Windows.Forms.ColumnHeader DescriptionCh;
        private System.Windows.Forms.ColumnHeader ValueCh;
    }
}