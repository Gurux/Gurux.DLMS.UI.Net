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
            this.ClockBaseLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.TimeZoneLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EnabledLbl = new System.Windows.Forms.Label();
            this.EnabledCB = new System.Windows.Forms.CheckBox();
            this.EndLbl = new System.Windows.Forms.Label();
            this.BeginLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DeviationLbl = new System.Windows.Forms.Label();
            this.DeviationTB = new Gurux.DLMS.UI.GXValueField();
            this.EndTB = new Gurux.DLMS.UI.GXValueField();
            this.BeginTB = new Gurux.DLMS.UI.GXValueField();
            this.ClockBaseTB = new Gurux.DLMS.UI.GXValueField();
            this.StatusTB = new Gurux.DLMS.UI.GXValueField();
            this.TimeZoneTB = new Gurux.DLMS.UI.GXValueField();
            this.TimeTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Size = new System.Drawing.Size(333, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clock Object";
            // 
            // ClockBaseLbl
            // 
            this.ClockBaseLbl.AutoSize = true;
            this.ClockBaseLbl.Location = new System.Drawing.Point(6, 264);
            this.ClockBaseLbl.Name = "ClockBaseLbl";
            this.ClockBaseLbl.Size = new System.Drawing.Size(64, 13);
            this.ClockBaseLbl.TabIndex = 22;
            this.ClockBaseLbl.Text = "Clock Base:";
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
            // TimeZoneLbl
            // 
            this.TimeZoneLbl.AutoSize = true;
            this.TimeZoneLbl.Location = new System.Drawing.Point(6, 76);
            this.TimeZoneLbl.Name = "TimeZoneLbl";
            this.TimeZoneLbl.Size = new System.Drawing.Size(61, 13);
            this.TimeZoneLbl.TabIndex = 4;
            this.TimeZoneLbl.Text = "Time Zone:";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 78);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Daylight Savings";
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
            this.EnabledCB.TabIndex = 3;
            this.EnabledCB.UseVisualStyleBackColor = false;
            this.EnabledCB.CheckedChanged += new System.EventHandler(this.EnabledCB_CheckedChanged);
            // 
            // EndLbl
            // 
            this.EndLbl.AutoSize = true;
            this.EndLbl.Location = new System.Drawing.Point(204, 45);
            this.EndLbl.Name = "EndLbl";
            this.EndLbl.Size = new System.Drawing.Size(29, 13);
            this.EndLbl.TabIndex = 18;
            this.EndLbl.Text = "End:";
            // 
            // BeginLbl
            // 
            this.BeginLbl.AutoSize = true;
            this.BeginLbl.Location = new System.Drawing.Point(6, 45);
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
            // DeviationLbl
            // 
            this.DeviationLbl.AutoSize = true;
            this.DeviationLbl.Location = new System.Drawing.Point(178, 19);
            this.DeviationLbl.Name = "DeviationLbl";
            this.DeviationLbl.Size = new System.Drawing.Size(55, 13);
            this.DeviationLbl.TabIndex = 26;
            this.DeviationLbl.Text = "Deviation:";
            // 
            // DeviationTB
            // 
            this.DeviationTB.Index = 7;
            this.DeviationTB.Location = new System.Drawing.Point(244, 16);
            this.DeviationTB.Name = "DeviationTB";
            this.DeviationTB.Size = new System.Drawing.Size(66, 20);
            this.DeviationTB.TabIndex = 4;
            this.DeviationTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // EndTB
            // 
            this.EndTB.Index = 6;
            this.EndTB.Location = new System.Drawing.Point(244, 45);
            this.EndTB.Name = "EndTB";
            this.EndTB.Size = new System.Drawing.Size(66, 20);
            this.EndTB.TabIndex = 6;
            this.EndTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // BeginTB
            // 
            this.BeginTB.Index = 5;
            this.BeginTB.Location = new System.Drawing.Point(102, 45);
            this.BeginTB.Name = "BeginTB";
            this.BeginTB.Size = new System.Drawing.Size(66, 20);
            this.BeginTB.TabIndex = 5;
            this.BeginTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // ClockBaseTB
            // 
            this.ClockBaseTB.Index = 9;
            this.ClockBaseTB.Location = new System.Drawing.Point(102, 261);
            this.ClockBaseTB.Name = "ClockBaseTB";
            this.ClockBaseTB.ReadOnly = true;
            this.ClockBaseTB.Size = new System.Drawing.Size(66, 63);
            this.ClockBaseTB.TabIndex = 7;
            this.ClockBaseTB.Type = Gurux.DLMS.UI.GXValueFieldType.CompoBox;
            // 
            // StatusTB
            // 
            this.StatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTB.Index = 4;
            this.StatusTB.Location = new System.Drawing.Point(102, 99);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(208, 75);
            this.StatusTB.TabIndex = 2;
            this.StatusTB.Type = Gurux.DLMS.UI.GXValueFieldType.CheckedListBox;
            // 
            // TimeZoneTB
            // 
            this.TimeZoneTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeZoneTB.Index = 3;
            this.TimeZoneTB.Location = new System.Drawing.Point(102, 73);
            this.TimeZoneTB.Name = "TimeZoneTB";
            this.TimeZoneTB.Size = new System.Drawing.Size(208, 20);
            this.TimeZoneTB.TabIndex = 1;
            this.TimeZoneTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // TimeTB
            // 
            this.TimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTB.Index = 2;
            this.TimeTB.Location = new System.Drawing.Point(102, 47);
            this.TimeTB.Name = "TimeTB";
            this.TimeTB.Size = new System.Drawing.Size(208, 20);
            this.TimeTB.TabIndex = 0;
            this.TimeTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.ReadOnly = true;
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
            this.LogicalNameTB.TabIndex = 0;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // GXDLMSClockView
            // 
            this.ClientSize = new System.Drawing.Size(357, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSClockView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField DeviationTB;
        private Label DeviationLbl;
    }
}
