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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.VersionCb = new System.Windows.Forms.ComboBox();
            this.VersionLbl = new System.Windows.Forms.Label();
            this.LogicalNameTb = new System.Windows.Forms.ComboBox();
            this.DescriptionTb = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.ShortNameTb = new System.Windows.Forms.TextBox();
            this.ShortNameLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.ObjectTypeCb = new System.Windows.Forms.ComboBox();
            this.ObjectTypeLbl = new System.Windows.Forms.Label();
            this.AccessRightsTab = new System.Windows.Forms.TabPage();
            this.Accessrights = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AccessRightsApplyBtn = new System.Windows.Forms.Button();
            this.AccessRightAllCb = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MethodAccessrights = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MethodAccessRightsApplyBtn = new System.Windows.Forms.Button();
            this.MethodAccessRightAllCb = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.AccessRightsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accessrights)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MethodAccessrights)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(306, 315);
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
            this.CancelBtn.Location = new System.Drawing.Point(387, 315);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.AccessRightsTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 304);
            this.tabControl1.TabIndex = 18;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.VersionCb);
            this.GeneralTab.Controls.Add(this.VersionLbl);
            this.GeneralTab.Controls.Add(this.LogicalNameTb);
            this.GeneralTab.Controls.Add(this.DescriptionTb);
            this.GeneralTab.Controls.Add(this.DescriptionLbl);
            this.GeneralTab.Controls.Add(this.ShortNameTb);
            this.GeneralTab.Controls.Add(this.ShortNameLbl);
            this.GeneralTab.Controls.Add(this.LogicalNameLbl);
            this.GeneralTab.Controls.Add(this.ObjectTypeCb);
            this.GeneralTab.Controls.Add(this.ObjectTypeLbl);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(463, 278);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // VersionCb
            // 
            this.VersionCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VersionCb.FormattingEnabled = true;
            this.VersionCb.Location = new System.Drawing.Point(83, 68);
            this.VersionCb.Name = "VersionCb";
            this.VersionCb.Size = new System.Drawing.Size(108, 21);
            this.VersionCb.TabIndex = 30;
            this.VersionCb.SelectedIndexChanged += new System.EventHandler(this.VersionCb_SelectedIndexChanged);
            // 
            // VersionLbl
            // 
            this.VersionLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Location = new System.Drawing.Point(2, 68);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(42, 13);
            this.VersionLbl.TabIndex = 31;
            this.VersionLbl.Text = "Version";
            // 
            // LogicalNameTb
            // 
            this.LogicalNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTb.FormattingEnabled = true;
            this.LogicalNameTb.Location = new System.Drawing.Point(83, 41);
            this.LogicalNameTb.Name = "LogicalNameTb";
            this.LogicalNameTb.Size = new System.Drawing.Size(369, 21);
            this.LogicalNameTb.TabIndex = 19;
            this.LogicalNameTb.SelectedIndexChanged += new System.EventHandler(this.LogicalNameTb_SelectedIndexChanged);
            this.LogicalNameTb.Leave += new System.EventHandler(this.LogicalNameTb_Leave);
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTb.Location = new System.Drawing.Point(83, 123);
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(369, 57);
            this.DescriptionTb.TabIndex = 25;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 127);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 24;
            this.DescriptionLbl.Text = "Description:";
            // 
            // ShortNameTb
            // 
            this.ShortNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortNameTb.Location = new System.Drawing.Point(83, 95);
            this.ShortNameTb.Name = "ShortNameTb";
            this.ShortNameTb.Size = new System.Drawing.Size(108, 20);
            this.ShortNameTb.TabIndex = 20;
            // 
            // ShortNameLbl
            // 
            this.ShortNameLbl.AutoSize = true;
            this.ShortNameLbl.Location = new System.Drawing.Point(2, 95);
            this.ShortNameLbl.Name = "ShortNameLbl";
            this.ShortNameLbl.Size = new System.Drawing.Size(66, 13);
            this.ShortNameLbl.TabIndex = 23;
            this.ShortNameLbl.Text = "Short Name:";
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(2, 41);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 22;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // ObjectTypeCb
            // 
            this.ObjectTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ObjectTypeCb.FormattingEnabled = true;
            this.ObjectTypeCb.Location = new System.Drawing.Point(83, 14);
            this.ObjectTypeCb.Name = "ObjectTypeCb";
            this.ObjectTypeCb.Size = new System.Drawing.Size(369, 21);
            this.ObjectTypeCb.Sorted = true;
            this.ObjectTypeCb.TabIndex = 18;
            this.ObjectTypeCb.SelectedIndexChanged += new System.EventHandler(this.ObjectTypeCb_SelectedIndexChanged);
            // 
            // ObjectTypeLbl
            // 
            this.ObjectTypeLbl.AutoSize = true;
            this.ObjectTypeLbl.Location = new System.Drawing.Point(2, 14);
            this.ObjectTypeLbl.Name = "ObjectTypeLbl";
            this.ObjectTypeLbl.Size = new System.Drawing.Size(68, 13);
            this.ObjectTypeLbl.TabIndex = 21;
            this.ObjectTypeLbl.Text = "Object Type:";
            // 
            // AccessRightsTab
            // 
            this.AccessRightsTab.Controls.Add(this.Accessrights);
            this.AccessRightsTab.Controls.Add(this.panel1);
            this.AccessRightsTab.Location = new System.Drawing.Point(4, 22);
            this.AccessRightsTab.Name = "AccessRightsTab";
            this.AccessRightsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AccessRightsTab.Size = new System.Drawing.Size(463, 278);
            this.AccessRightsTab.TabIndex = 1;
            this.AccessRightsTab.Text = "Access Rights";
            this.AccessRightsTab.UseVisualStyleBackColor = true;
            // 
            // Accessrights
            // 
            this.Accessrights.AllowUserToAddRows = false;
            this.Accessrights.AllowUserToDeleteRows = false;
            this.Accessrights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accessrights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Accessrights.Location = new System.Drawing.Point(3, 34);
            this.Accessrights.Name = "Accessrights";
            this.Accessrights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Accessrights.Size = new System.Drawing.Size(457, 241);
            this.Accessrights.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AccessRightsApplyBtn);
            this.panel1.Controls.Add(this.AccessRightAllCb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 31);
            this.panel1.TabIndex = 32;
            // 
            // AccessRightsApplyBtn
            // 
            this.AccessRightsApplyBtn.Location = new System.Drawing.Point(126, 5);
            this.AccessRightsApplyBtn.Name = "AccessRightsApplyBtn";
            this.AccessRightsApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.AccessRightsApplyBtn.TabIndex = 33;
            this.AccessRightsApplyBtn.Text = "Apply";
            this.AccessRightsApplyBtn.UseVisualStyleBackColor = true;
            this.AccessRightsApplyBtn.Click += new System.EventHandler(this.AccessRightsApplyBtn_Click);
            // 
            // AccessRightAllCb
            // 
            this.AccessRightAllCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccessRightAllCb.FormattingEnabled = true;
            this.AccessRightAllCb.Location = new System.Drawing.Point(12, 7);
            this.AccessRightAllCb.Name = "AccessRightAllCb";
            this.AccessRightAllCb.Size = new System.Drawing.Size(108, 21);
            this.AccessRightAllCb.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MethodAccessrights);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 278);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Method Access Rights";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MethodAccessrights
            // 
            this.MethodAccessrights.AllowUserToAddRows = false;
            this.MethodAccessrights.AllowUserToDeleteRows = false;
            this.MethodAccessrights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MethodAccessrights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MethodAccessrights.Location = new System.Drawing.Point(3, 34);
            this.MethodAccessrights.Name = "MethodAccessrights";
            this.MethodAccessrights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MethodAccessrights.Size = new System.Drawing.Size(457, 241);
            this.MethodAccessrights.TabIndex = 35;
            this.MethodAccessrights.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.MethodAccessrights_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MethodAccessRightsApplyBtn);
            this.panel2.Controls.Add(this.MethodAccessRightAllCb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 31);
            this.panel2.TabIndex = 34;
            // 
            // MethodAccessRightsApplyBtn
            // 
            this.MethodAccessRightsApplyBtn.Location = new System.Drawing.Point(126, 5);
            this.MethodAccessRightsApplyBtn.Name = "MethodAccessRightsApplyBtn";
            this.MethodAccessRightsApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.MethodAccessRightsApplyBtn.TabIndex = 34;
            this.MethodAccessRightsApplyBtn.Text = "Apply";
            this.MethodAccessRightsApplyBtn.UseVisualStyleBackColor = true;
            this.MethodAccessRightsApplyBtn.Click += new System.EventHandler(this.MethodAccessRightsApplyBtn_Click);
            // 
            // MethodAccessRightAllCb
            // 
            this.MethodAccessRightAllCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodAccessRightAllCb.FormattingEnabled = true;
            this.MethodAccessRightAllCb.Location = new System.Drawing.Point(12, 7);
            this.MethodAccessRightAllCb.Name = "MethodAccessRightAllCb";
            this.MethodAccessRightAllCb.Size = new System.Drawing.Size(108, 21);
            this.MethodAccessRightAllCb.TabIndex = 32;
            // 
            // GXDLMSAssociationViewDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(474, 350);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMSAssociationViewDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Association view Object";
            this.tabControl1.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            this.AccessRightsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Accessrights)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MethodAccessrights)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GeneralTab;
        private System.Windows.Forms.ComboBox LogicalNameTb;
        private System.Windows.Forms.Label DescriptionTb;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.TextBox ShortNameTb;
        private System.Windows.Forms.Label ShortNameLbl;
        private System.Windows.Forms.Label LogicalNameLbl;
        private System.Windows.Forms.ComboBox ObjectTypeCb;
        private System.Windows.Forms.Label ObjectTypeLbl;
        private System.Windows.Forms.TabPage AccessRightsTab;
        private System.Windows.Forms.ComboBox VersionCb;
        private System.Windows.Forms.Label VersionLbl;
        private System.Windows.Forms.DataGridView Accessrights;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox AccessRightAllCb;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView MethodAccessrights;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox MethodAccessRightAllCb;
        private System.Windows.Forms.Button AccessRightsApplyBtn;
        private System.Windows.Forms.Button MethodAccessRightsApplyBtn;
    }
}