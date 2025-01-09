namespace Gurux.DLMS.UI
{
    partial class GXFunctionControlFunctionDlg
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
            this.TargetTb = new System.Windows.Forms.ComboBox();
            this.ScriptLbl = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.IndexLbl = new System.Windows.Forms.Label();
            this.FunctionListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnabledLbl = new System.Windows.Forms.Label();
            this.EnabledCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(230, 291);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 20;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(149, 291);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 19;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // TargetTb
            // 
            this.TargetTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TargetTb.FormattingEnabled = true;
            this.TargetTb.Location = new System.Drawing.Point(75, 59);
            this.TargetTb.Name = "TargetTb";
            this.TargetTb.Size = new System.Drawing.Size(149, 21);
            this.TargetTb.TabIndex = 21;
            // 
            // ScriptLbl
            // 
            this.ScriptLbl.AutoSize = true;
            this.ScriptLbl.Location = new System.Drawing.Point(17, 62);
            this.ScriptLbl.Name = "ScriptLbl";
            this.ScriptLbl.Size = new System.Drawing.Size(41, 13);
            this.ScriptLbl.TabIndex = 22;
            this.ScriptLbl.Text = "Target:";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(75, 12);
            this.NameTb.Name = "NameTb";
            this.NameTb.ReadOnly = true;
            this.NameTb.Size = new System.Drawing.Size(230, 20);
            this.NameTb.TabIndex = 23;
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(17, 12);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(38, 13);
            this.IndexLbl.TabIndex = 24;
            this.IndexLbl.Text = "Name:";
            // 
            // FunctionListView
            // 
            this.FunctionListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.FunctionListView.FullRowSelect = true;
            this.FunctionListView.HideSelection = false;
            this.FunctionListView.Location = new System.Drawing.Point(12, 88);
            this.FunctionListView.Name = "FunctionListView";
            this.FunctionListView.Size = new System.Drawing.Size(293, 197);
            this.FunctionListView.TabIndex = 31;
            this.FunctionListView.UseCompatibleStateImageBehavior = false;
            this.FunctionListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Object Type:";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Logical Name:";
            this.columnHeader4.Width = 78;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveBtn.Location = new System.Drawing.Point(12, 291);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 33;
            this.RemoveBtn.Text = "Remove...";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(230, 59);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 32;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Description:";
            // 
            // EnabledLbl
            // 
            this.EnabledLbl.AutoSize = true;
            this.EnabledLbl.Enabled = false;
            this.EnabledLbl.Location = new System.Drawing.Point(17, 39);
            this.EnabledLbl.Name = "EnabledLbl";
            this.EnabledLbl.Size = new System.Drawing.Size(49, 13);
            this.EnabledLbl.TabIndex = 35;
            this.EnabledLbl.Text = "Enabled:";
            // 
            // EnabledCB
            // 
            this.EnabledCB.Enabled = false;
            this.EnabledCB.Location = new System.Drawing.Point(75, 39);
            this.EnabledCB.Name = "EnabledCB";
            this.EnabledCB.Size = new System.Drawing.Size(37, 17);
            this.EnabledCB.TabIndex = 34;
            this.EnabledCB.UseVisualStyleBackColor = false;
            // 
            // GXFunctionControlFunctionDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 326);
            this.Controls.Add(this.EnabledLbl);
            this.Controls.Add(this.EnabledCB);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FunctionListView);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.ScriptLbl);
            this.Controls.Add(this.TargetTb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXFunctionControlFunctionDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GXFunctionControlFunctionDlg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.ComboBox TargetTb;
        private System.Windows.Forms.Label ScriptLbl;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.ListView FunctionListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label EnabledLbl;
        private System.Windows.Forms.CheckBox EnabledCB;
    }
}