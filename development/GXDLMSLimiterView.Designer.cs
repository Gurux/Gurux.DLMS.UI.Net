using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSLimiterView
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
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private GroupBox MonitoredGB;
        private TextBox MonitoredIndexTB;
        private Label MonitoredIndexLbl;
        private Label MonitoredValueLbl;
        private GXValueField ThresholdActiveTB;
        private GXValueField ThresholdNormalTB;
        private Label ThresholdNormalLbl;
        private GXValueField ThresholdEmergencyTB;
        private Label ThresholdEmergencyLbl;
        private GXValueField MinUnderThresholdDurationTB;
        private Label MinUnderThresholdDurationLbl;
        private GXValueField MinOverThresholdDurationTB;
        private Label MinOverThresholdDurationLbl;
        private Label EmergencyProfileGroupIDsLbl;
        private CheckBox EmergencyProfileActiveCB;
        private GXValueField LogicalNameTB;
        private Label LogicalNameLbl;
        private Label ThresholdActiveLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSLimiterView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EmergencyProfileGroupIDsTB = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ActivationTimeTb = new System.Windows.Forms.TextBox();
            this.ActivationTimeLbl = new System.Windows.Forms.Label();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.IdLbl = new System.Windows.Forms.Label();
            this.DurationTb = new System.Windows.Forms.TextBox();
            this.DurationLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ActionUnderScript = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActionUnderThresholdIndexTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ActionOverScript = new System.Windows.Forms.ComboBox();
            this.ActionOverThresholdLbl = new System.Windows.Forms.Label();
            this.ActionOverThresholdIndexTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.EmergencyProfileActiveCB = new System.Windows.Forms.CheckBox();
            this.EmergencyProfileGroupIDsLbl = new System.Windows.Forms.Label();
            this.MinUnderThresholdDurationLbl = new System.Windows.Forms.Label();
            this.MinOverThresholdDurationLbl = new System.Windows.Forms.Label();
            this.ThresholdEmergencyLbl = new System.Windows.Forms.Label();
            this.ThresholdNormalLbl = new System.Windows.Forms.Label();
            this.ThresholdActiveLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MonitoredGB = new System.Windows.Forms.GroupBox();
            this.MonitoredValueTB = new System.Windows.Forms.ComboBox();
            this.MonitoredIndexTB = new System.Windows.Forms.TextBox();
            this.MonitoredIndexLbl = new System.Windows.Forms.Label();
            this.MonitoredValueLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.MinUnderThresholdDurationTB = new Gurux.DLMS.UI.GXValueField();
            this.MinOverThresholdDurationTB = new Gurux.DLMS.UI.GXValueField();
            this.ThresholdEmergencyTB = new Gurux.DLMS.UI.GXValueField();
            this.ThresholdNormalTB = new Gurux.DLMS.UI.GXValueField();
            this.ThresholdActiveTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.MonitoredGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.MonitoredGB);
            this.groupBox1.Controls.Add(this.EmergencyProfileGroupIDsTB);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Controls.Add(this.EmergencyProfileActiveCB);
            this.groupBox1.Controls.Add(this.EmergencyProfileGroupIDsLbl);
            this.groupBox1.Controls.Add(this.MinUnderThresholdDurationTB);
            this.groupBox1.Controls.Add(this.MinUnderThresholdDurationLbl);
            this.groupBox1.Controls.Add(this.MinOverThresholdDurationTB);
            this.groupBox1.Controls.Add(this.MinOverThresholdDurationLbl);
            this.groupBox1.Controls.Add(this.ThresholdEmergencyTB);
            this.groupBox1.Controls.Add(this.ThresholdEmergencyLbl);
            this.groupBox1.Controls.Add(this.ThresholdNormalTB);
            this.groupBox1.Controls.Add(this.ThresholdNormalLbl);
            this.groupBox1.Controls.Add(this.ThresholdActiveTB);
            this.groupBox1.Controls.Add(this.ThresholdActiveLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 470);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limiter Object";
            // 
            // EmergencyProfileGroupIDsTB
            // 
            this.EmergencyProfileGroupIDsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmergencyProfileGroupIDsTB.Location = new System.Drawing.Point(126, 304);
            this.EmergencyProfileGroupIDsTB.Name = "EmergencyProfileGroupIDsTB";
            this.EmergencyProfileGroupIDsTB.Size = new System.Drawing.Size(298, 20);
            this.EmergencyProfileGroupIDsTB.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ActivationTimeTb);
            this.groupBox4.Controls.Add(this.ActivationTimeLbl);
            this.groupBox4.Controls.Add(this.IdTb);
            this.groupBox4.Controls.Add(this.IdLbl);
            this.groupBox4.Controls.Add(this.DurationTb);
            this.groupBox4.Controls.Add(this.DurationLbl);
            this.groupBox4.Location = new System.Drawing.Point(12, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(412, 49);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emergency profile:";
            // 
            // ActivationTimeTb
            // 
            this.ActivationTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivationTimeTb.Location = new System.Drawing.Point(190, 19);
            this.ActivationTimeTb.Name = "ActivationTimeTb";
            this.ActivationTimeTb.Size = new System.Drawing.Size(89, 20);
            this.ActivationTimeTb.TabIndex = 12;
            this.ActivationTimeTb.Leave += new System.EventHandler(this.ActivationTimeTb_Leave);
            // 
            // ActivationTimeLbl
            // 
            this.ActivationTimeLbl.AutoSize = true;
            this.ActivationTimeLbl.Location = new System.Drawing.Point(101, 22);
            this.ActivationTimeLbl.Name = "ActivationTimeLbl";
            this.ActivationTimeLbl.Size = new System.Drawing.Size(83, 13);
            this.ActivationTimeLbl.TabIndex = 32;
            this.ActivationTimeLbl.Text = "Activation Time:";
            // 
            // IdTb
            // 
            this.IdTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTb.Location = new System.Drawing.Point(39, 19);
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(46, 20);
            this.IdTb.TabIndex = 11;
            this.IdTb.Leave += new System.EventHandler(this.IdTb_Leave);
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(11, 22);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(21, 13);
            this.IdLbl.TabIndex = 30;
            this.IdLbl.Text = "ID:";
            // 
            // DurationTb
            // 
            this.DurationTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationTb.Location = new System.Drawing.Point(347, 19);
            this.DurationTb.Name = "DurationTb";
            this.DurationTb.Size = new System.Drawing.Size(46, 20);
            this.DurationTb.TabIndex = 13;
            this.DurationTb.Leave += new System.EventHandler(this.DurationTb_Leave);
            // 
            // DurationLbl
            // 
            this.DurationLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationLbl.AutoSize = true;
            this.DurationLbl.Location = new System.Drawing.Point(297, 22);
            this.DurationLbl.Name = "DurationLbl";
            this.DurationLbl.Size = new System.Drawing.Size(50, 13);
            this.DurationLbl.TabIndex = 9;
            this.DurationLbl.Text = "Duration:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ActionUnderScript);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ActionUnderThresholdIndexTB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 49);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "18";
            // 
            // ActionUnderScript
            // 
            this.ActionUnderScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionUnderScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionUnderScript.FormattingEnabled = true;
            this.ActionUnderScript.Location = new System.Drawing.Point(127, 14);
            this.ActionUnderScript.Name = "ActionUnderScript";
            this.ActionUnderScript.Size = new System.Drawing.Size(152, 21);
            this.ActionUnderScript.Sorted = true;
            this.ActionUnderScript.TabIndex = 18;
            this.ActionUnderScript.SelectedIndexChanged += new System.EventHandler(this.ActionUnderScript_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Script:";
            // 
            // ActionUnderThresholdIndexTB
            // 
            this.ActionUnderThresholdIndexTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionUnderThresholdIndexTB.Location = new System.Drawing.Point(347, 19);
            this.ActionUnderThresholdIndexTB.Name = "ActionUnderThresholdIndexTB";
            this.ActionUnderThresholdIndexTB.Size = new System.Drawing.Size(46, 20);
            this.ActionUnderThresholdIndexTB.TabIndex = 19;
            this.ActionUnderThresholdIndexTB.Leave += new System.EventHandler(this.ActionUnderThresholdIndexTB_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selector:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ActionOverScript);
            this.groupBox2.Controls.Add(this.ActionOverThresholdLbl);
            this.groupBox2.Controls.Add(this.ActionOverThresholdIndexTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 50);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action Over";
            // 
            // ActionOverScript
            // 
            this.ActionOverScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionOverScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActionOverScript.FormattingEnabled = true;
            this.ActionOverScript.Location = new System.Drawing.Point(127, 19);
            this.ActionOverScript.Name = "ActionOverScript";
            this.ActionOverScript.Size = new System.Drawing.Size(152, 21);
            this.ActionOverScript.Sorted = true;
            this.ActionOverScript.TabIndex = 31;
            this.ActionOverScript.SelectedIndexChanged += new System.EventHandler(this.ActionOverScript_SelectedIndexChanged);
            // 
            // ActionOverThresholdLbl
            // 
            this.ActionOverThresholdLbl.AutoSize = true;
            this.ActionOverThresholdLbl.Location = new System.Drawing.Point(11, 22);
            this.ActionOverThresholdLbl.Name = "ActionOverThresholdLbl";
            this.ActionOverThresholdLbl.Size = new System.Drawing.Size(37, 13);
            this.ActionOverThresholdLbl.TabIndex = 30;
            this.ActionOverThresholdLbl.Text = "Script:";
            // 
            // ActionOverThresholdIndexTB
            // 
            this.ActionOverThresholdIndexTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionOverThresholdIndexTB.Location = new System.Drawing.Point(347, 22);
            this.ActionOverThresholdIndexTB.Name = "ActionOverThresholdIndexTB";
            this.ActionOverThresholdIndexTB.Size = new System.Drawing.Size(46, 20);
            this.ActionOverThresholdIndexTB.TabIndex = 10;
            this.ActionOverThresholdIndexTB.Text = "17";
            this.ActionOverThresholdIndexTB.Leave += new System.EventHandler(this.ActionOverThresholdIndexTB_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selector:";
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(8, 22);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 36;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // EmergencyProfileActiveCB
            // 
            this.EmergencyProfileActiveCB.AutoSize = true;
            this.EmergencyProfileActiveCB.Location = new System.Drawing.Point(12, 331);
            this.EmergencyProfileActiveCB.Name = "EmergencyProfileActiveCB";
            this.EmergencyProfileActiveCB.Size = new System.Drawing.Size(56, 17);
            this.EmergencyProfileActiveCB.TabIndex = 15;
            this.EmergencyProfileActiveCB.Text = "Active";
            this.EmergencyProfileActiveCB.UseVisualStyleBackColor = true;
            this.EmergencyProfileActiveCB.CheckedChanged += new System.EventHandler(this.EmergencyProfileActiveCB_CheckedChanged);
            // 
            // EmergencyProfileGroupIDsLbl
            // 
            this.EmergencyProfileGroupIDsLbl.AutoSize = true;
            this.EmergencyProfileGroupIDsLbl.Location = new System.Drawing.Point(9, 304);
            this.EmergencyProfileGroupIDsLbl.Name = "EmergencyProfileGroupIDsLbl";
            this.EmergencyProfileGroupIDsLbl.Size = new System.Drawing.Size(58, 13);
            this.EmergencyProfileGroupIDsLbl.TabIndex = 26;
            this.EmergencyProfileGroupIDsLbl.Text = "Group IDs:";
            // 
            // MinUnderThresholdDurationLbl
            // 
            this.MinUnderThresholdDurationLbl.AutoSize = true;
            this.MinUnderThresholdDurationLbl.Location = new System.Drawing.Point(8, 227);
            this.MinUnderThresholdDurationLbl.Name = "MinUnderThresholdDurationLbl";
            this.MinUnderThresholdDurationLbl.Size = new System.Drawing.Size(77, 13);
            this.MinUnderThresholdDurationLbl.TabIndex = 22;
            this.MinUnderThresholdDurationLbl.Text = "Minimal Under:";
            // 
            // MinOverThresholdDurationLbl
            // 
            this.MinOverThresholdDurationLbl.AutoSize = true;
            this.MinOverThresholdDurationLbl.Location = new System.Drawing.Point(8, 201);
            this.MinOverThresholdDurationLbl.Name = "MinOverThresholdDurationLbl";
            this.MinOverThresholdDurationLbl.Size = new System.Drawing.Size(71, 13);
            this.MinOverThresholdDurationLbl.TabIndex = 20;
            this.MinOverThresholdDurationLbl.Text = "Minimal Over:";
            // 
            // ThresholdEmergencyLbl
            // 
            this.ThresholdEmergencyLbl.AutoSize = true;
            this.ThresholdEmergencyLbl.Location = new System.Drawing.Point(7, 175);
            this.ThresholdEmergencyLbl.Name = "ThresholdEmergencyLbl";
            this.ThresholdEmergencyLbl.Size = new System.Drawing.Size(113, 13);
            this.ThresholdEmergencyLbl.TabIndex = 18;
            this.ThresholdEmergencyLbl.Text = "Threshold Emergency:";
            // 
            // ThresholdNormalLbl
            // 
            this.ThresholdNormalLbl.AutoSize = true;
            this.ThresholdNormalLbl.Location = new System.Drawing.Point(7, 150);
            this.ThresholdNormalLbl.Name = "ThresholdNormalLbl";
            this.ThresholdNormalLbl.Size = new System.Drawing.Size(93, 13);
            this.ThresholdNormalLbl.TabIndex = 16;
            this.ThresholdNormalLbl.Text = "Threshold Normal:";
            // 
            // ThresholdActiveLbl
            // 
            this.ThresholdActiveLbl.AutoSize = true;
            this.ThresholdActiveLbl.Location = new System.Drawing.Point(7, 124);
            this.ThresholdActiveLbl.Name = "ThresholdActiveLbl";
            this.ThresholdActiveLbl.Size = new System.Drawing.Size(90, 13);
            this.ThresholdActiveLbl.TabIndex = 13;
            this.ThresholdActiveLbl.Text = "Threshold Active:";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 50);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 5;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(126, 47);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(299, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // MonitoredGB
            // 
            this.MonitoredGB.Controls.Add(this.MonitoredValueTB);
            this.MonitoredGB.Controls.Add(this.MonitoredIndexTB);
            this.MonitoredGB.Controls.Add(this.MonitoredIndexLbl);
            this.MonitoredGB.Controls.Add(this.MonitoredValueLbl);
            this.MonitoredGB.Location = new System.Drawing.Point(12, 73);
            this.MonitoredGB.Name = "MonitoredGB";
            this.MonitoredGB.Size = new System.Drawing.Size(413, 45);
            this.MonitoredGB.TabIndex = 2;
            this.MonitoredGB.TabStop = false;
            this.MonitoredGB.Text = "Monitored:";
            // 
            // MonitoredValueTB
            // 
            this.MonitoredValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoredValueTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonitoredValueTB.FormattingEnabled = true;
            this.MonitoredValueTB.Location = new System.Drawing.Point(126, 16);
            this.MonitoredValueTB.Name = "MonitoredValueTB";
            this.MonitoredValueTB.Size = new System.Drawing.Size(154, 21);
            this.MonitoredValueTB.Sorted = true;
            this.MonitoredValueTB.TabIndex = 2;
            this.MonitoredValueTB.SelectedIndexChanged += new System.EventHandler(this.MonitoredValueTB_SelectedIndexChanged);
            // 
            // MonitoredIndexTB
            // 
            this.MonitoredIndexTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoredIndexTB.Location = new System.Drawing.Point(359, 19);
            this.MonitoredIndexTB.Name = "MonitoredIndexTB";
            this.MonitoredIndexTB.Size = new System.Drawing.Size(35, 20);
            this.MonitoredIndexTB.TabIndex = 3;
            this.MonitoredIndexTB.Leave += new System.EventHandler(this.MonitoredIndexTB_Leave);
            // 
            // MonitoredIndexLbl
            // 
            this.MonitoredIndexLbl.AutoSize = true;
            this.MonitoredIndexLbl.Location = new System.Drawing.Point(309, 19);
            this.MonitoredIndexLbl.Name = "MonitoredIndexLbl";
            this.MonitoredIndexLbl.Size = new System.Drawing.Size(36, 13);
            this.MonitoredIndexLbl.TabIndex = 9;
            this.MonitoredIndexLbl.Text = "Index:";
            // 
            // MonitoredValueLbl
            // 
            this.MonitoredValueLbl.AutoSize = true;
            this.MonitoredValueLbl.Location = new System.Drawing.Point(7, 22);
            this.MonitoredValueLbl.Name = "MonitoredValueLbl";
            this.MonitoredValueLbl.Size = new System.Drawing.Size(37, 13);
            this.MonitoredValueLbl.TabIndex = 6;
            this.MonitoredValueLbl.Text = "Value:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(127, 19);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(298, 20);
            this.LogicalNameTB.TabIndex = 0;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // MinUnderThresholdDurationTB
            // 
            this.MinUnderThresholdDurationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinUnderThresholdDurationTB.Index = 7;
            this.MinUnderThresholdDurationTB.Location = new System.Drawing.Point(127, 227);
            this.MinUnderThresholdDurationTB.Name = "MinUnderThresholdDurationTB";
            this.MinUnderThresholdDurationTB.NotifyChanges = false;
            this.MinUnderThresholdDurationTB.Size = new System.Drawing.Size(298, 20);
            this.MinUnderThresholdDurationTB.TabIndex = 9;
            this.MinUnderThresholdDurationTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // MinOverThresholdDurationTB
            // 
            this.MinOverThresholdDurationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MinOverThresholdDurationTB.Index = 6;
            this.MinOverThresholdDurationTB.Location = new System.Drawing.Point(127, 201);
            this.MinOverThresholdDurationTB.Name = "MinOverThresholdDurationTB";
            this.MinOverThresholdDurationTB.NotifyChanges = false;
            this.MinOverThresholdDurationTB.Size = new System.Drawing.Size(298, 20);
            this.MinOverThresholdDurationTB.TabIndex = 8;
            this.MinOverThresholdDurationTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ThresholdEmergencyTB
            // 
            this.ThresholdEmergencyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdEmergencyTB.Index = 5;
            this.ThresholdEmergencyTB.Location = new System.Drawing.Point(126, 175);
            this.ThresholdEmergencyTB.Name = "ThresholdEmergencyTB";
            this.ThresholdEmergencyTB.NotifyChanges = false;
            this.ThresholdEmergencyTB.Size = new System.Drawing.Size(298, 20);
            this.ThresholdEmergencyTB.TabIndex = 7;
            this.ThresholdEmergencyTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ThresholdNormalTB
            // 
            this.ThresholdNormalTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdNormalTB.Index = 4;
            this.ThresholdNormalTB.Location = new System.Drawing.Point(126, 150);
            this.ThresholdNormalTB.Name = "ThresholdNormalTB";
            this.ThresholdNormalTB.NotifyChanges = false;
            this.ThresholdNormalTB.Size = new System.Drawing.Size(298, 20);
            this.ThresholdNormalTB.TabIndex = 6;
            this.ThresholdNormalTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ThresholdActiveTB
            // 
            this.ThresholdActiveTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdActiveTB.Index = 3;
            this.ThresholdActiveTB.Location = new System.Drawing.Point(126, 124);
            this.ThresholdActiveTB.Name = "ThresholdActiveTB";
            this.ThresholdActiveTB.NotifyChanges = false;
            this.ThresholdActiveTB.Size = new System.Drawing.Size(298, 20);
            this.ThresholdActiveTB.TabIndex = 5;
            this.ThresholdActiveTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // GXDLMSLimiterView
            // 
            this.ClientSize = new System.Drawing.Size(449, 493);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSLimiterView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.MonitoredGB.ResumeLayout(false);
            this.MonitoredGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Label ActionOverThresholdLbl;
        private TextBox ActionOverThresholdIndexTB;
        private Label label1;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox ActionUnderThresholdIndexTB;
        private Label label3;
        private ComboBox ActionUnderScript;
        private ComboBox ActionOverScript;
        private ComboBox MonitoredValueTB;
        private GroupBox groupBox4;
        private TextBox ActivationTimeTb;
        private Label ActivationTimeLbl;
        private TextBox IdTb;
        private Label IdLbl;
        private TextBox DurationTb;
        private Label DurationLbl;
        private TextBox EmergencyProfileGroupIDsTB;
    }
}
