namespace Gurux.DLMS.UI
{
    partial class GXDLMScheduleDlg
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
            this.ScriptLbl = new System.Windows.Forms.Label();
            this.ScriptTb = new System.Windows.Forms.ComboBox();
            this.IndexLbl = new System.Windows.Forms.Label();
            this.IndexTB = new System.Windows.Forms.TextBox();
            this.EnabledCb = new System.Windows.Forms.CheckBox();
            this.SelectorTb = new System.Windows.Forms.TextBox();
            this.SelectorLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.TimeTb = new System.Windows.Forms.TextBox();
            this.ValidityWindowTb = new System.Windows.Forms.TextBox();
            this.ValidityWindowLbl = new System.Windows.Forms.Label();
            this.ExecSpecDaysTb = new System.Windows.Forms.TextBox();
            this.ExecSpecDaysLbl = new System.Windows.Forms.Label();
            this.BeginTb = new System.Windows.Forms.TextBox();
            this.BeginLbl = new System.Windows.Forms.Label();
            this.EndTb = new System.Windows.Forms.TextBox();
            this.EndLbl = new System.Windows.Forms.Label();
            this.ExecWeekdaysGb = new System.Windows.Forms.GroupBox();
            this.SundayCb = new System.Windows.Forms.CheckBox();
            this.SaturdayCb = new System.Windows.Forms.CheckBox();
            this.FridayCb = new System.Windows.Forms.CheckBox();
            this.ThursdayCb = new System.Windows.Forms.CheckBox();
            this.WednesdayCb = new System.Windows.Forms.CheckBox();
            this.TuesdayCb = new System.Windows.Forms.CheckBox();
            this.MondayCb = new System.Windows.Forms.CheckBox();
            this.ExecWeekdaysGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBtn.Location = new System.Drawing.Point(109, 350);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 16;
            this.OkBtn.Text = "OK";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(190, 350);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ScriptLbl
            // 
            this.ScriptLbl.AutoSize = true;
            this.ScriptLbl.Location = new System.Drawing.Point(12, 60);
            this.ScriptLbl.Name = "ScriptLbl";
            this.ScriptLbl.Size = new System.Drawing.Size(37, 13);
            this.ScriptLbl.TabIndex = 4;
            this.ScriptLbl.Text = "Script:";
            // 
            // ScriptTb
            // 
            this.ScriptTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScriptTb.FormattingEnabled = true;
            this.ScriptTb.Location = new System.Drawing.Point(70, 60);
            this.ScriptTb.Name = "ScriptTb";
            this.ScriptTb.Size = new System.Drawing.Size(195, 21);
            this.ScriptTb.TabIndex = 2;
            // 
            // IndexLbl
            // 
            this.IndexLbl.AutoSize = true;
            this.IndexLbl.Location = new System.Drawing.Point(12, 12);
            this.IndexLbl.Name = "IndexLbl";
            this.IndexLbl.Size = new System.Drawing.Size(36, 13);
            this.IndexLbl.TabIndex = 7;
            this.IndexLbl.Text = "Index:";
            // 
            // IndexTB
            // 
            this.IndexTB.Location = new System.Drawing.Point(70, 12);
            this.IndexTB.Name = "IndexTB";
            this.IndexTB.Size = new System.Drawing.Size(195, 20);
            this.IndexTB.TabIndex = 0;
            // 
            // EnabledCb
            // 
            this.EnabledCb.AutoSize = true;
            this.EnabledCb.Location = new System.Drawing.Point(70, 38);
            this.EnabledCb.Name = "EnabledCb";
            this.EnabledCb.Size = new System.Drawing.Size(65, 17);
            this.EnabledCb.TabIndex = 1;
            this.EnabledCb.Text = "Enabled";
            this.EnabledCb.UseVisualStyleBackColor = true;
            // 
            // SelectorTb
            // 
            this.SelectorTb.Location = new System.Drawing.Point(70, 89);
            this.SelectorTb.Name = "SelectorTb";
            this.SelectorTb.Size = new System.Drawing.Size(195, 20);
            this.SelectorTb.TabIndex = 3;
            // 
            // SelectorLbl
            // 
            this.SelectorLbl.AutoSize = true;
            this.SelectorLbl.Location = new System.Drawing.Point(12, 89);
            this.SelectorLbl.Name = "SelectorLbl";
            this.SelectorLbl.Size = new System.Drawing.Size(49, 13);
            this.SelectorLbl.TabIndex = 14;
            this.SelectorLbl.Text = "Selector:";
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(12, 118);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(33, 13);
            this.TimeLbl.TabIndex = 16;
            this.TimeLbl.Text = "Time:";
            // 
            // TimeTb
            // 
            this.TimeTb.Location = new System.Drawing.Point(70, 115);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.Size = new System.Drawing.Size(195, 20);
            this.TimeTb.TabIndex = 4;
            // 
            // ValidityWindowTb
            // 
            this.ValidityWindowTb.Location = new System.Drawing.Point(100, 141);
            this.ValidityWindowTb.Name = "ValidityWindowTb";
            this.ValidityWindowTb.Size = new System.Drawing.Size(165, 20);
            this.ValidityWindowTb.TabIndex = 5;
            // 
            // ValidityWindowLbl
            // 
            this.ValidityWindowLbl.AutoSize = true;
            this.ValidityWindowLbl.Location = new System.Drawing.Point(12, 144);
            this.ValidityWindowLbl.Name = "ValidityWindowLbl";
            this.ValidityWindowLbl.Size = new System.Drawing.Size(82, 13);
            this.ValidityWindowLbl.TabIndex = 18;
            this.ValidityWindowLbl.Text = "Validity window:";
            // 
            // ExecSpecDaysTb
            // 
            this.ExecSpecDaysTb.Location = new System.Drawing.Point(100, 268);
            this.ExecSpecDaysTb.Name = "ExecSpecDaysTb";
            this.ExecSpecDaysTb.Size = new System.Drawing.Size(165, 20);
            this.ExecSpecDaysTb.TabIndex = 13;
            // 
            // ExecSpecDaysLbl
            // 
            this.ExecSpecDaysLbl.AutoSize = true;
            this.ExecSpecDaysLbl.Location = new System.Drawing.Point(12, 271);
            this.ExecSpecDaysLbl.Name = "ExecSpecDaysLbl";
            this.ExecSpecDaysLbl.Size = new System.Drawing.Size(89, 13);
            this.ExecSpecDaysLbl.TabIndex = 20;
            this.ExecSpecDaysLbl.Text = "Exec Spec Days:";
            // 
            // BeginTb
            // 
            this.BeginTb.Location = new System.Drawing.Point(100, 294);
            this.BeginTb.Name = "BeginTb";
            this.BeginTb.Size = new System.Drawing.Size(165, 20);
            this.BeginTb.TabIndex = 14;
            // 
            // BeginLbl
            // 
            this.BeginLbl.AutoSize = true;
            this.BeginLbl.Location = new System.Drawing.Point(12, 297);
            this.BeginLbl.Name = "BeginLbl";
            this.BeginLbl.Size = new System.Drawing.Size(37, 13);
            this.BeginLbl.TabIndex = 22;
            this.BeginLbl.Text = "Begin:";
            // 
            // EndTb
            // 
            this.EndTb.Location = new System.Drawing.Point(100, 320);
            this.EndTb.Name = "EndTb";
            this.EndTb.Size = new System.Drawing.Size(165, 20);
            this.EndTb.TabIndex = 15;
            // 
            // EndLbl
            // 
            this.EndLbl.AutoSize = true;
            this.EndLbl.Location = new System.Drawing.Point(12, 323);
            this.EndLbl.Name = "EndLbl";
            this.EndLbl.Size = new System.Drawing.Size(29, 13);
            this.EndLbl.TabIndex = 24;
            this.EndLbl.Text = "End:";
            // 
            // ExecWeekdaysGb
            // 
            this.ExecWeekdaysGb.Controls.Add(this.SundayCb);
            this.ExecWeekdaysGb.Controls.Add(this.SaturdayCb);
            this.ExecWeekdaysGb.Controls.Add(this.FridayCb);
            this.ExecWeekdaysGb.Controls.Add(this.ThursdayCb);
            this.ExecWeekdaysGb.Controls.Add(this.WednesdayCb);
            this.ExecWeekdaysGb.Controls.Add(this.TuesdayCb);
            this.ExecWeekdaysGb.Controls.Add(this.MondayCb);
            this.ExecWeekdaysGb.Location = new System.Drawing.Point(2, 167);
            this.ExecWeekdaysGb.Name = "ExecWeekdaysGb";
            this.ExecWeekdaysGb.Size = new System.Drawing.Size(263, 95);
            this.ExecWeekdaysGb.TabIndex = 33;
            this.ExecWeekdaysGb.TabStop = false;
            this.ExecWeekdaysGb.Text = "Exec Weekdays";
            // 
            // SundayCb
            // 
            this.SundayCb.AutoSize = true;
            this.SundayCb.Location = new System.Drawing.Point(10, 65);
            this.SundayCb.Name = "SundayCb";
            this.SundayCb.Size = new System.Drawing.Size(62, 17);
            this.SundayCb.TabIndex = 12;
            this.SundayCb.Text = "Sunday";
            this.SundayCb.UseVisualStyleBackColor = true;
            // 
            // SaturdayCb
            // 
            this.SaturdayCb.AutoSize = true;
            this.SaturdayCb.Location = new System.Drawing.Point(151, 42);
            this.SaturdayCb.Name = "SaturdayCb";
            this.SaturdayCb.Size = new System.Drawing.Size(68, 17);
            this.SaturdayCb.TabIndex = 11;
            this.SaturdayCb.Text = "Saturday";
            this.SaturdayCb.UseVisualStyleBackColor = true;
            // 
            // FridayCb
            // 
            this.FridayCb.AutoSize = true;
            this.FridayCb.Location = new System.Drawing.Point(80, 42);
            this.FridayCb.Name = "FridayCb";
            this.FridayCb.Size = new System.Drawing.Size(54, 17);
            this.FridayCb.TabIndex = 10;
            this.FridayCb.Text = "Friday";
            this.FridayCb.UseVisualStyleBackColor = true;
            // 
            // ThursdayCb
            // 
            this.ThursdayCb.AutoSize = true;
            this.ThursdayCb.Location = new System.Drawing.Point(10, 42);
            this.ThursdayCb.Name = "ThursdayCb";
            this.ThursdayCb.Size = new System.Drawing.Size(70, 17);
            this.ThursdayCb.TabIndex = 9;
            this.ThursdayCb.Text = "Thursday";
            this.ThursdayCb.UseVisualStyleBackColor = true;
            // 
            // WednesdayCb
            // 
            this.WednesdayCb.AutoSize = true;
            this.WednesdayCb.Location = new System.Drawing.Point(151, 19);
            this.WednesdayCb.Name = "WednesdayCb";
            this.WednesdayCb.Size = new System.Drawing.Size(83, 17);
            this.WednesdayCb.TabIndex = 8;
            this.WednesdayCb.Text = "Wednesday";
            this.WednesdayCb.UseVisualStyleBackColor = true;
            // 
            // TuesdayCb
            // 
            this.TuesdayCb.AutoSize = true;
            this.TuesdayCb.Location = new System.Drawing.Point(80, 19);
            this.TuesdayCb.Name = "TuesdayCb";
            this.TuesdayCb.Size = new System.Drawing.Size(67, 17);
            this.TuesdayCb.TabIndex = 7;
            this.TuesdayCb.Text = "Tuesday";
            this.TuesdayCb.UseVisualStyleBackColor = true;
            // 
            // MondayCb
            // 
            this.MondayCb.AutoSize = true;
            this.MondayCb.Location = new System.Drawing.Point(10, 19);
            this.MondayCb.Name = "MondayCb";
            this.MondayCb.Size = new System.Drawing.Size(64, 17);
            this.MondayCb.TabIndex = 6;
            this.MondayCb.Text = "Monday";
            this.MondayCb.UseVisualStyleBackColor = true;
            // 
            // GXDLMScheduleDlg
            // 
            this.AcceptButton = this.OkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(277, 385);
            this.ControlBox = false;
            this.Controls.Add(this.ExecWeekdaysGb);
            this.Controls.Add(this.EndTb);
            this.Controls.Add(this.EndLbl);
            this.Controls.Add(this.BeginTb);
            this.Controls.Add(this.BeginLbl);
            this.Controls.Add(this.ExecSpecDaysTb);
            this.Controls.Add(this.ExecSpecDaysLbl);
            this.Controls.Add(this.ValidityWindowTb);
            this.Controls.Add(this.ValidityWindowLbl);
            this.Controls.Add(this.TimeTb);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.SelectorTb);
            this.Controls.Add(this.SelectorLbl);
            this.Controls.Add(this.EnabledCb);
            this.Controls.Add(this.IndexTB);
            this.Controls.Add(this.IndexLbl);
            this.Controls.Add(this.ScriptTb);
            this.Controls.Add(this.ScriptLbl);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "GXDLMScheduleDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule";
            this.ExecWeekdaysGb.ResumeLayout(false);
            this.ExecWeekdaysGb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label ScriptLbl;
        private System.Windows.Forms.ComboBox ScriptTb;
        private System.Windows.Forms.Label IndexLbl;
        private System.Windows.Forms.TextBox IndexTB;
        private System.Windows.Forms.CheckBox EnabledCb;
        private System.Windows.Forms.TextBox SelectorTb;
        private System.Windows.Forms.Label SelectorLbl;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.TextBox TimeTb;
        private System.Windows.Forms.TextBox ValidityWindowTb;
        private System.Windows.Forms.Label ValidityWindowLbl;
        private System.Windows.Forms.TextBox ExecSpecDaysTb;
        private System.Windows.Forms.Label ExecSpecDaysLbl;
        private System.Windows.Forms.TextBox BeginTb;
        private System.Windows.Forms.Label BeginLbl;
        private System.Windows.Forms.TextBox EndTb;
        private System.Windows.Forms.Label EndLbl;
        private System.Windows.Forms.GroupBox ExecWeekdaysGb;
        private System.Windows.Forms.CheckBox SundayCb;
        private System.Windows.Forms.CheckBox SaturdayCb;
        private System.Windows.Forms.CheckBox FridayCb;
        private System.Windows.Forms.CheckBox ThursdayCb;
        private System.Windows.Forms.CheckBox WednesdayCb;
        private System.Windows.Forms.CheckBox TuesdayCb;
        private System.Windows.Forms.CheckBox MondayCb;
    }
}