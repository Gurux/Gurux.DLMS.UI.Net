namespace Gurux.DLMS.UI
{
    partial class GXDLMSParameterMonitorView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSParameterMonitorView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ParametersLV = new System.Windows.Forms.ListView();
            this.TargetCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndexCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ParametersLbl = new System.Windows.Forms.Label();
            this.CaptureTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.CaptureTimeLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ChangedParameterGB = new System.Windows.Forms.GroupBox();
            this.TargetTb = new System.Windows.Forms.TextBox();
            this.ValueTb = new System.Windows.Forms.TextBox();
            this.IndexTb = new System.Windows.Forms.TextBox();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.IndexLbl = new System.Windows.Forms.Label();
            this.TargetLbl = new System.Windows.Forms.Label();
            this.RemoveBtn = new Gurux.DLMS.UI.GXButton();
            this.AddBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.ChangedParameterGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RemoveBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.ChangedParameterGB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Controls.Add(this.ParametersLV);
            this.groupBox1.Controls.Add(this.CaptureTimeTb);
            this.groupBox1.Controls.Add(this.CaptureTimeLbl);
            this.groupBox1.Controls.Add(this.ParametersLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameter Monitor Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // ParametersLV
            // 
            this.ParametersLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParametersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TargetCh,
            this.IndexCh});
            this.ParametersLV.FullRowSelect = true;
            this.ParametersLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ParametersLV.HideSelection = false;
            this.ParametersLV.Location = new System.Drawing.Point(102, 189);
            this.ParametersLV.Name = "ParametersLV";
            this.ParametersLV.Size = new System.Drawing.Size(238, 137);
            this.ParametersLV.TabIndex = 4;
            this.ParametersLV.UseCompatibleStateImageBehavior = false;
            this.ParametersLV.View = System.Windows.Forms.View.Details;
            // 
            // TargetCh
            // 
            this.TargetCh.Text = "Target:";
            this.TargetCh.Width = 100;
            // 
            // IndexCh
            // 
            this.IndexCh.Text = "Index:";
            this.IndexCh.Width = 129;
            // 
            // ParametersLbl
            // 
            this.ParametersLbl.AutoSize = true;
            this.ParametersLbl.Location = new System.Drawing.Point(6, 189);
            this.ParametersLbl.Name = "ParametersLbl";
            this.ParametersLbl.Size = new System.Drawing.Size(63, 13);
            this.ParametersLbl.TabIndex = 9;
            this.ParametersLbl.Text = "Parameters:";
            // 
            // CaptureTimeTb
            // 
            this.CaptureTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureTimeTb.Index = 3;
            this.CaptureTimeTb.Location = new System.Drawing.Point(102, 163);
            this.CaptureTimeTb.Name = "CaptureTimeTb";
            this.CaptureTimeTb.NotifyChanges = false;
            this.CaptureTimeTb.ReadOnly = true;
            this.CaptureTimeTb.Size = new System.Drawing.Size(238, 20);
            this.CaptureTimeTb.TabIndex = 3;
            this.CaptureTimeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // CaptureTimeLbl
            // 
            this.CaptureTimeLbl.AutoSize = true;
            this.CaptureTimeLbl.Location = new System.Drawing.Point(6, 166);
            this.CaptureTimeLbl.Name = "CaptureTimeLbl";
            this.CaptureTimeLbl.Size = new System.Drawing.Size(69, 13);
            this.CaptureTimeLbl.TabIndex = 2;
            this.CaptureTimeLbl.Text = "Capture time:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.ReadOnly = true;
            this.LogicalNameTB.Size = new System.Drawing.Size(238, 20);
            this.LogicalNameTB.TabIndex = 7;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(6, 24);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 0;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ChangedParameterGB
            // 
            this.ChangedParameterGB.Controls.Add(this.TargetTb);
            this.ChangedParameterGB.Controls.Add(this.ValueTb);
            this.ChangedParameterGB.Controls.Add(this.IndexTb);
            this.ChangedParameterGB.Controls.Add(this.ValueLbl);
            this.ChangedParameterGB.Controls.Add(this.IndexLbl);
            this.ChangedParameterGB.Controls.Add(this.TargetLbl);
            this.ChangedParameterGB.Location = new System.Drawing.Point(9, 47);
            this.ChangedParameterGB.Name = "ChangedParameterGB";
            this.ChangedParameterGB.Size = new System.Drawing.Size(348, 110);
            this.ChangedParameterGB.TabIndex = 19;
            this.ChangedParameterGB.TabStop = false;
            this.ChangedParameterGB.Text = "Changed Parameter";
            // 
            // TargetTb
            // 
            this.TargetTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TargetTb.Location = new System.Drawing.Point(93, 19);
            this.TargetTb.Name = "TargetTb";
            this.TargetTb.ReadOnly = true;
            this.TargetTb.Size = new System.Drawing.Size(238, 20);
            this.TargetTb.TabIndex = 0;
            // 
            // ValueTb
            // 
            this.ValueTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTb.Location = new System.Drawing.Point(93, 77);
            this.ValueTb.Name = "ValueTb";
            this.ValueTb.ReadOnly = true;
            this.ValueTb.Size = new System.Drawing.Size(238, 20);
            this.ValueTb.TabIndex = 2;
            // 
            // IndexTb
            // 
            this.IndexTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IndexTb.Location = new System.Drawing.Point(93, 51);
            this.IndexTb.Name = "IndexTb";
            this.IndexTb.ReadOnly = true;
            this.IndexTb.Size = new System.Drawing.Size(238, 20);
            this.IndexTb.TabIndex = 1;
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(8, 83);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(37, 13);
            this.ValueLbl.TabIndex = 21;
            this.ValueLbl.Text = "Value:";
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(8, 54);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(36, 13);
            this.IndexLbl.TabIndex = 20;
            this.IndexLbl.Text = "Index:";
            // 
            // TargetLbl
            // 
            this.TargetLbl.AutoSize = true;
            this.TargetLbl.Location = new System.Drawing.Point(8, 26);
            this.TargetLbl.Name = "TargetLbl";
            this.TargetLbl.Size = new System.Drawing.Size(41, 13);
            this.TargetLbl.TabIndex = 19;
            this.TargetLbl.Text = "Target:";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Index = 2;
            this.RemoveBtn.Location = new System.Drawing.Point(265, 332);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 6;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Index = 1;
            this.AddBtn.Location = new System.Drawing.Point(184, 332);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // GXDLMSParameterMonitorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 393);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSParameterMonitorView";
            this.Text = "GXDLMSParameterMonitorView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ChangedParameterGB.ResumeLayout(false);
            this.ChangedParameterGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GXValueField CaptureTimeTb;
        private System.Windows.Forms.Label CaptureTimeLbl;
        private GXValueField LogicalNameTB;
        private System.Windows.Forms.Label LogicalNameLbl;
        private System.Windows.Forms.ListView ParametersLV;
        private System.Windows.Forms.ColumnHeader TargetCh;
        private System.Windows.Forms.ColumnHeader IndexCh;
        private System.Windows.Forms.Label ParametersLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox ChangedParameterGB;
        private System.Windows.Forms.TextBox TargetTb;
        private System.Windows.Forms.TextBox ValueTb;
        private System.Windows.Forms.TextBox IndexTb;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.Label TargetLbl;
        private GXButton RemoveBtn;
        private GXButton AddBtn;
    }
}