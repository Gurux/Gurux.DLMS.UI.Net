using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSClockView
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
        private GroupBox groupBox1;
        private GXValueField TimeTB;
        private Label TimeLbl;
        private GXValueField LogicalNameTB;
        private GXValueField StatusTB;
        private Label StatusLbl;
        private GXValueField TimeZoneTB;
        private Label TimeZoneLbl;
        private GXValueField ClockBaseTB;
        private Label ClockBaseLbl;
        private GroupBox groupBox2;
        private CheckBox EnabledCB;
        private GXValueField EndTB;
        private Label EndLbl;
        private GXValueField BeginTB;
        private Label BeginLbl;
        private Label EnabledLbl;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSClockView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShiftTimeBtn = new Gurux.DLMS.UI.GXButton();
            this.PresetAdjustingTimeBtn = new Gurux.DLMS.UI.GXButton();
            this.CurrentTimeZoneBtn = new Gurux.DLMS.UI.GXButton();
            this.TimeZoneCb = new System.Windows.Forms.CheckBox();
            this.UpdateTimeBtn = new Gurux.DLMS.UI.GXButton();
            this.ClockBaseTB = new Gurux.DLMS.UI.GXValueField();
            this.ClockBaseLbl = new System.Windows.Forms.Label();
            this.StatusTB = new Gurux.DLMS.UI.GXValueField();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.TimeZoneTB = new Gurux.DLMS.UI.GXValueField();
            this.TimeZoneLbl = new System.Windows.Forms.Label();
            this.TimeTB = new Gurux.DLMS.UI.GXValueField();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeviationTB = new Gurux.DLMS.UI.GXValueField();
            this.DeviationLbl = new System.Windows.Forms.Label();
            this.EndTB = new Gurux.DLMS.UI.GXValueField();
            this.EnabledLbl = new System.Windows.Forms.Label();
            this.EnabledCB = new System.Windows.Forms.CheckBox();
            this.EndLbl = new System.Windows.Forms.Label();
            this.BeginTB = new Gurux.DLMS.UI.GXValueField();
            this.BeginLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AdjustToMinuteBtn = new Gurux.DLMS.UI.GXButton();
            this.AdjustToPresetTimeBtn = new Gurux.DLMS.UI.GXButton();
            this.AdjustToMeasuringPeriodBtn = new Gurux.DLMS.UI.GXButton();
            this.AdjustToQuarterBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ShiftTimeBtn);
            this.groupBox1.Controls.Add(this.PresetAdjustingTimeBtn);
            this.groupBox1.Controls.Add(this.CurrentTimeZoneBtn);
            this.groupBox1.Controls.Add(this.TimeZoneCb);
            this.groupBox1.Controls.Add(this.UpdateTimeBtn);
            this.groupBox1.Controls.Add(this.ClockBaseTB);
            this.groupBox1.Controls.Add(this.ClockBaseLbl);
            this.groupBox1.Controls.Add(this.StatusTB);
            this.groupBox1.Controls.Add(this.StatusLbl);
            this.groupBox1.Controls.Add(this.TimeZoneTB);
            this.groupBox1.Controls.Add(this.TimeZoneLbl);
            this.groupBox1.Controls.Add(this.TimeTB);
            this.groupBox1.Controls.Add(this.TimeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 488);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock Object";
            // 
            // ShiftTimeBtn
            // 
            this.ShiftTimeBtn.Index = 6;
            this.ShiftTimeBtn.Location = new System.Drawing.Point(208, 443);
            this.ShiftTimeBtn.Name = "ShiftTimeBtn";
            this.ShiftTimeBtn.Size = new System.Drawing.Size(100, 23);
            this.ShiftTimeBtn.TabIndex = 25;
            this.ShiftTimeBtn.Text = "Shift Time...";
            this.ShiftTimeBtn.UseVisualStyleBackColor = true;
            // 
            // PresetAdjustingTimeBtn
            // 
            this.PresetAdjustingTimeBtn.Index = 5;
            this.PresetAdjustingTimeBtn.Location = new System.Drawing.Point(102, 443);
            this.PresetAdjustingTimeBtn.Name = "PresetAdjustingTimeBtn";
            this.PresetAdjustingTimeBtn.Size = new System.Drawing.Size(100, 23);
            this.PresetAdjustingTimeBtn.TabIndex = 24;
            this.PresetAdjustingTimeBtn.Text = "Preset Adjusting Time...";
            this.PresetAdjustingTimeBtn.UseVisualStyleBackColor = true;
            // 
            // CurrentTimeZoneBtn
            // 
            this.CurrentTimeZoneBtn.Action = Gurux.DLMS.UI.ActionType.Write;
            this.CurrentTimeZoneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentTimeZoneBtn.Index = 3;
            this.CurrentTimeZoneBtn.Location = new System.Drawing.Point(244, 70);
            this.CurrentTimeZoneBtn.Name = "CurrentTimeZoneBtn";
            this.CurrentTimeZoneBtn.Size = new System.Drawing.Size(100, 23);
            this.CurrentTimeZoneBtn.TabIndex = 5;
            this.CurrentTimeZoneBtn.Text = "Current time Zone";
            this.CurrentTimeZoneBtn.UseVisualStyleBackColor = true;
            // 
            // TimeZoneCb
            // 
            this.TimeZoneCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeZoneCb.Location = new System.Drawing.Point(215, 75);
            this.TimeZoneCb.Name = "TimeZoneCb";
            this.TimeZoneCb.Size = new System.Drawing.Size(37, 17);
            this.TimeZoneCb.TabIndex = 4;
            this.TimeZoneCb.UseVisualStyleBackColor = false;
            this.TimeZoneCb.CheckedChanged += new System.EventHandler(this.TimeZoneCb_CheckedChanged);
            // 
            // UpdateTimeBtn
            // 
            this.UpdateTimeBtn.Action = Gurux.DLMS.UI.ActionType.Write;
            this.UpdateTimeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateTimeBtn.Index = 2;
            this.UpdateTimeBtn.Location = new System.Drawing.Point(244, 45);
            this.UpdateTimeBtn.Name = "UpdateTimeBtn";
            this.UpdateTimeBtn.Size = new System.Drawing.Size(100, 23);
            this.UpdateTimeBtn.TabIndex = 2;
            this.UpdateTimeBtn.Text = "Current time";
            this.UpdateTimeBtn.UseVisualStyleBackColor = true;
            // 
            // ClockBaseTB
            // 
            this.ClockBaseTB.Index = 9;
            this.ClockBaseTB.Location = new System.Drawing.Point(102, 337);
            this.ClockBaseTB.Name = "ClockBaseTB";
            this.ClockBaseTB.NotifyChanges = false;
            this.ClockBaseTB.Size = new System.Drawing.Size(98, 63);
            this.ClockBaseTB.TabIndex = 12;
            this.ClockBaseTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // ClockBaseLbl
            // 
            this.ClockBaseLbl.AutoSize = true;
            this.ClockBaseLbl.Location = new System.Drawing.Point(6, 340);
            this.ClockBaseLbl.Name = "ClockBaseLbl";
            this.ClockBaseLbl.Size = new System.Drawing.Size(64, 13);
            this.ClockBaseLbl.TabIndex = 22;
            this.ClockBaseLbl.Text = "Clock Base:";
            // 
            // StatusTB
            // 
            this.StatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTB.Index = 4;
            this.StatusTB.Location = new System.Drawing.Point(102, 98);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.NotifyChanges = false;
            this.StatusTB.Size = new System.Drawing.Size(242, 111);
            this.StatusTB.TabIndex = 6;
            this.StatusTB.Type = Gurux.DLMS.Enums.ValueFieldType.CheckedListBox;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(6, 102);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(40, 13);
            this.StatusLbl.TabIndex = 6;
            this.StatusLbl.Text = "Status:";
            // 
            // TimeZoneTB
            // 
            this.TimeZoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeZoneTB.Index = 3;
            this.TimeZoneTB.Location = new System.Drawing.Point(102, 73);
            this.TimeZoneTB.Name = "TimeZoneTB";
            this.TimeZoneTB.NotifyChanges = true;
            this.TimeZoneTB.Size = new System.Drawing.Size(96, 20);
            this.TimeZoneTB.TabIndex = 3;
            this.TimeZoneTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TimeZoneLbl
            // 
            this.TimeZoneLbl.AutoSize = true;
            this.TimeZoneLbl.Location = new System.Drawing.Point(6, 76);
            this.TimeZoneLbl.Name = "TimeZoneLbl";
            this.TimeZoneLbl.Size = new System.Drawing.Size(61, 13);
            this.TimeZoneLbl.TabIndex = 4;
            this.TimeZoneLbl.Text = "Time Zone:";
            // 
            // TimeTB
            // 
            this.TimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTB.Index = 2;
            this.TimeTB.Location = new System.Drawing.Point(102, 47);
            this.TimeTB.Name = "TimeTB";
            this.TimeTB.NotifyChanges = true;
            this.TimeTB.Size = new System.Drawing.Size(131, 20);
            this.TimeTB.TabIndex = 1;
            this.TimeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(6, 50);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(33, 13);
            this.TimeLbl.TabIndex = 2;
            this.TimeLbl.Text = "Time:";
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
            this.LogicalNameTB.Size = new System.Drawing.Size(242, 20);
            this.LogicalNameTB.TabIndex = 0;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DeviationTB);
            this.groupBox2.Controls.Add(this.DeviationLbl);
            this.groupBox2.Controls.Add(this.EndTB);
            this.groupBox2.Controls.Add(this.EnabledLbl);
            this.groupBox2.Controls.Add(this.EnabledCB);
            this.groupBox2.Controls.Add(this.EndLbl);
            this.groupBox2.Controls.Add(this.BeginTB);
            this.groupBox2.Controls.Add(this.BeginLbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 116);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daylight Savings";
            // 
            // DeviationTB
            // 
            this.DeviationTB.Index = 7;
            this.DeviationTB.Location = new System.Drawing.Point(244, 16);
            this.DeviationTB.Name = "DeviationTB";
            this.DeviationTB.NotifyChanges = false;
            this.DeviationTB.Size = new System.Drawing.Size(100, 20);
            this.DeviationTB.TabIndex = 9;
            this.DeviationTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // DeviationLbl
            // 
            this.DeviationLbl.AutoSize = true;
            this.DeviationLbl.Location = new System.Drawing.Point(178, 19);
            this.DeviationLbl.Name = "DeviationLbl";
            this.DeviationLbl.Size = new System.Drawing.Size(55, 13);
            this.DeviationLbl.TabIndex = 26;
            this.DeviationLbl.Text = "Deviation:";
            // 
            // EndTB
            // 
            this.EndTB.Index = 6;
            this.EndTB.Location = new System.Drawing.Point(102, 71);
            this.EndTB.Name = "EndTB";
            this.EndTB.NotifyChanges = false;
            this.EndTB.Size = new System.Drawing.Size(242, 20);
            this.EndTB.TabIndex = 11;
            this.EndTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // EnabledLbl
            // 
            this.EnabledLbl.AutoSize = true;
            this.EnabledLbl.Location = new System.Drawing.Point(6, 21);
            this.EnabledLbl.Name = "EnabledLbl";
            this.EnabledLbl.Size = new System.Drawing.Size(49, 13);
            this.EnabledLbl.TabIndex = 22;
            this.EnabledLbl.Text = "Enabled:";
            // 
            // EnabledCB
            // 
            this.EnabledCB.Location = new System.Drawing.Point(102, 19);
            this.EnabledCB.Name = "EnabledCB";
            this.EnabledCB.Size = new System.Drawing.Size(37, 17);
            this.EnabledCB.TabIndex = 8;
            this.EnabledCB.UseVisualStyleBackColor = false;
            this.EnabledCB.CheckedChanged += new System.EventHandler(this.EnabledCB_CheckedChanged);
            // 
            // EndLbl
            // 
            this.EndLbl.AutoSize = true;
            this.EndLbl.Location = new System.Drawing.Point(6, 74);
            this.EndLbl.Name = "EndLbl";
            this.EndLbl.Size = new System.Drawing.Size(29, 13);
            this.EndLbl.TabIndex = 18;
            this.EndLbl.Text = "End:";
            // 
            // BeginTB
            // 
            this.BeginTB.Index = 5;
            this.BeginTB.Location = new System.Drawing.Point(102, 45);
            this.BeginTB.Name = "BeginTB";
            this.BeginTB.NotifyChanges = false;
            this.BeginTB.Size = new System.Drawing.Size(242, 20);
            this.BeginTB.TabIndex = 10;
            this.BeginTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // BeginLbl
            // 
            this.BeginLbl.AutoSize = true;
            this.BeginLbl.Location = new System.Drawing.Point(6, 47);
            this.BeginLbl.Name = "BeginLbl";
            this.BeginLbl.Size = new System.Drawing.Size(37, 13);
            this.BeginLbl.TabIndex = 16;
            this.BeginLbl.Text = "Begin:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // AdjustToMinuteBtn
            // 
            this.AdjustToMinuteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjustToMinuteBtn.Index = 3;
            this.AdjustToMinuteBtn.Location = new System.Drawing.Point(101, 45);
            this.AdjustToMinuteBtn.Name = "AdjustToMinuteBtn";
            this.AdjustToMinuteBtn.Size = new System.Drawing.Size(100, 23);
            this.AdjustToMinuteBtn.TabIndex = 23;
            this.AdjustToMinuteBtn.Text = "Minute";
            this.AdjustToMinuteBtn.UseVisualStyleBackColor = true;
            // 
            // AdjustToPresetTimeBtn
            // 
            this.AdjustToPresetTimeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjustToPresetTimeBtn.Index = 4;
            this.AdjustToPresetTimeBtn.Location = new System.Drawing.Point(207, 45);
            this.AdjustToPresetTimeBtn.Name = "AdjustToPresetTimeBtn";
            this.AdjustToPresetTimeBtn.Size = new System.Drawing.Size(100, 23);
            this.AdjustToPresetTimeBtn.TabIndex = 24;
            this.AdjustToPresetTimeBtn.Text = "Preset time";
            this.AdjustToPresetTimeBtn.UseVisualStyleBackColor = true;
            // 
            // AdjustToMeasuringPeriodBtn
            // 
            this.AdjustToMeasuringPeriodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjustToMeasuringPeriodBtn.Index = 2;
            this.AdjustToMeasuringPeriodBtn.Location = new System.Drawing.Point(207, 16);
            this.AdjustToMeasuringPeriodBtn.Name = "AdjustToMeasuringPeriodBtn";
            this.AdjustToMeasuringPeriodBtn.Size = new System.Drawing.Size(100, 23);
            this.AdjustToMeasuringPeriodBtn.TabIndex = 25;
            this.AdjustToMeasuringPeriodBtn.Text = "Measuring period";
            this.AdjustToMeasuringPeriodBtn.UseVisualStyleBackColor = true;
            // 
            // AdjustToQuarterBtn
            // 
            this.AdjustToQuarterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjustToQuarterBtn.Index = 1;
            this.AdjustToQuarterBtn.Location = new System.Drawing.Point(101, 16);
            this.AdjustToQuarterBtn.Name = "AdjustToQuarterBtn";
            this.AdjustToQuarterBtn.Size = new System.Drawing.Size(100, 23);
            this.AdjustToQuarterBtn.TabIndex = 26;
            this.AdjustToQuarterBtn.Text = "Quarter";
            this.AdjustToQuarterBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AdjustToQuarterBtn);
            this.groupBox3.Controls.Add(this.AdjustToPresetTimeBtn);
            this.groupBox3.Controls.Add(this.AdjustToMeasuringPeriodBtn);
            this.groupBox3.Controls.Add(this.AdjustToMinuteBtn);
            this.groupBox3.Location = new System.Drawing.Point(11, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 76);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adjust to";
            // 
            // GXDLMSClockView
            // 
            this.ClientSize = new System.Drawing.Size(391, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSClockView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField DeviationTB;
        private Label DeviationLbl;
        private GXButton UpdateTimeBtn;
        private CheckBox TimeZoneCb;
        private GXButton CurrentTimeZoneBtn;
        private GXButton AdjustToQuarterBtn;
        private GXButton AdjustToMeasuringPeriodBtn;
        private GXButton AdjustToPresetTimeBtn;
        private GXButton AdjustToMinuteBtn;
        private GroupBox groupBox3;
        private GXButton ShiftTimeBtn;
        private GXButton PresetAdjustingTimeBtn;
    }
}
