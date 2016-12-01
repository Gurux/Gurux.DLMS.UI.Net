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
        private TextBox MonitoredValueTB;
        private GXValueField ThresholdActiveTB;
        private GXValueField ThresholdNormalTB;
        private Label ThresholdNormalLbl;
        private GXValueField ThresholdEmergencyTB;
        private Label ThresholdEmergencyLbl;
        private GXValueField EmergencyProfileTB;
        private Label EmergencyProfileLbl;
        private GXValueField MinUnderThresholdDurationTB;
        private Label MinUnderThresholdDurationLbl;
        private GXValueField MinOverThresholdDurationTB;
        private Label MinOverThresholdDurationLbl;
        private GXValueField EmergencyProfileGroupIDsTB;
        private Label EmergencyProfileGroupIDsLbl;
        private CheckBox EmergencyProfileActiveCB;
        private GXValueField ActionUnderThresholdTB;
        private Label ActionUnderThresholdLbl;
        private GXValueField ActionOverThresholdTB;
        private Label ActionOverThresholdLbl;
        private GXValueField LogicalNameTB;
        private Label LogicalNameLbl;
        private Label ThresholdActiveLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSLimiterView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.ActionUnderThresholdLbl = new System.Windows.Forms.Label();
            this.ActionOverThresholdLbl = new System.Windows.Forms.Label();
            this.EmergencyProfileActiveCB = new System.Windows.Forms.CheckBox();
            this.EmergencyProfileGroupIDsLbl = new System.Windows.Forms.Label();
            this.EmergencyProfileLbl = new System.Windows.Forms.Label();
            this.MinUnderThresholdDurationLbl = new System.Windows.Forms.Label();
            this.MinOverThresholdDurationLbl = new System.Windows.Forms.Label();
            this.ThresholdEmergencyLbl = new System.Windows.Forms.Label();
            this.ThresholdNormalLbl = new System.Windows.Forms.Label();
            this.ThresholdActiveLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MonitoredGB = new System.Windows.Forms.GroupBox();
            this.MonitoredIndexTB = new System.Windows.Forms.TextBox();
            this.MonitoredIndexLbl = new System.Windows.Forms.Label();
            this.MonitoredValueLbl = new System.Windows.Forms.Label();
            this.MonitoredValueTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.ActionUnderThresholdTB = new Gurux.DLMS.UI.GXValueField();
            this.ActionOverThresholdTB = new Gurux.DLMS.UI.GXValueField();
            this.EmergencyProfileGroupIDsTB = new Gurux.DLMS.UI.GXValueField();
            this.EmergencyProfileTB = new Gurux.DLMS.UI.GXValueField();
            this.MinUnderThresholdDurationTB = new Gurux.DLMS.UI.GXValueField();
            this.MinOverThresholdDurationTB = new Gurux.DLMS.UI.GXValueField();
            this.ThresholdEmergencyTB = new Gurux.DLMS.UI.GXValueField();
            this.ThresholdNormalTB = new Gurux.DLMS.UI.GXValueField();
            this.ThresholdActiveTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.MonitoredGB.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Controls.Add(this.ActionUnderThresholdTB);
            this.groupBox1.Controls.Add(this.ActionUnderThresholdLbl);
            this.groupBox1.Controls.Add(this.ActionOverThresholdTB);
            this.groupBox1.Controls.Add(this.ActionOverThresholdLbl);
            this.groupBox1.Controls.Add(this.EmergencyProfileActiveCB);
            this.groupBox1.Controls.Add(this.EmergencyProfileGroupIDsTB);
            this.groupBox1.Controls.Add(this.EmergencyProfileGroupIDsLbl);
            this.groupBox1.Controls.Add(this.EmergencyProfileTB);
            this.groupBox1.Controls.Add(this.EmergencyProfileLbl);
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
            this.groupBox1.Size = new System.Drawing.Size(296, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Limiter Object";
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
            // ActionUnderThresholdLbl
            //
            this.ActionUnderThresholdLbl.AutoSize = true;
            this.ActionUnderThresholdLbl.Location = new System.Drawing.Point(10, 400);
            this.ActionUnderThresholdLbl.Name = "ActionUnderThresholdLbl";
            this.ActionUnderThresholdLbl.Size = new System.Drawing.Size(72, 13);
            this.ActionUnderThresholdLbl.TabIndex = 31;
            this.ActionUnderThresholdLbl.Text = "Action Under:";
            //
            // ActionOverThresholdLbl
            //
            this.ActionOverThresholdLbl.AutoSize = true;
            this.ActionOverThresholdLbl.Location = new System.Drawing.Point(10, 359);
            this.ActionOverThresholdLbl.Name = "ActionOverThresholdLbl";
            this.ActionOverThresholdLbl.Size = new System.Drawing.Size(66, 13);
            this.ActionOverThresholdLbl.TabIndex = 29;
            this.ActionOverThresholdLbl.Text = "Action Over:";
            //
            // EmergencyProfileActiveCB
            //
            this.EmergencyProfileActiveCB.AutoSize = true;
            this.EmergencyProfileActiveCB.Location = new System.Drawing.Point(12, 337);
            this.EmergencyProfileActiveCB.Name = "EmergencyProfileActiveCB";
            this.EmergencyProfileActiveCB.Size = new System.Drawing.Size(56, 17);
            this.EmergencyProfileActiveCB.TabIndex = 28;
            this.EmergencyProfileActiveCB.Text = "Active";
            this.EmergencyProfileActiveCB.UseVisualStyleBackColor = true;
            //
            // EmergencyProfileGroupIDsLbl
            //
            this.EmergencyProfileGroupIDsLbl.AutoSize = true;
            this.EmergencyProfileGroupIDsLbl.Location = new System.Drawing.Point(9, 303);
            this.EmergencyProfileGroupIDsLbl.Name = "EmergencyProfileGroupIDsLbl";
            this.EmergencyProfileGroupIDsLbl.Size = new System.Drawing.Size(58, 13);
            this.EmergencyProfileGroupIDsLbl.TabIndex = 26;
            this.EmergencyProfileGroupIDsLbl.Text = "Group IDs:";
            //
            // EmergencyProfileLbl
            //
            this.EmergencyProfileLbl.AutoSize = true;
            this.EmergencyProfileLbl.Location = new System.Drawing.Point(8, 278);
            this.EmergencyProfileLbl.Name = "EmergencyProfileLbl";
            this.EmergencyProfileLbl.Size = new System.Drawing.Size(94, 13);
            this.EmergencyProfileLbl.TabIndex = 24;
            this.EmergencyProfileLbl.Text = "Emergency profile:";
            //
            // MinUnderThresholdDurationLbl
            //
            this.MinUnderThresholdDurationLbl.AutoSize = true;
            this.MinUnderThresholdDurationLbl.Location = new System.Drawing.Point(8, 253);
            this.MinUnderThresholdDurationLbl.Name = "MinUnderThresholdDurationLbl";
            this.MinUnderThresholdDurationLbl.Size = new System.Drawing.Size(77, 13);
            this.MinUnderThresholdDurationLbl.TabIndex = 22;
            this.MinUnderThresholdDurationLbl.Text = "Minimal Under:";
            //
            // MinOverThresholdDurationLbl
            //
            this.MinOverThresholdDurationLbl.AutoSize = true;
            this.MinOverThresholdDurationLbl.Location = new System.Drawing.Point(8, 227);
            this.MinOverThresholdDurationLbl.Name = "MinOverThresholdDurationLbl";
            this.MinOverThresholdDurationLbl.Size = new System.Drawing.Size(71, 13);
            this.MinOverThresholdDurationLbl.TabIndex = 20;
            this.MinOverThresholdDurationLbl.Text = "Minimal Over:";
            //
            // ThresholdEmergencyLbl
            //
            this.ThresholdEmergencyLbl.AutoSize = true;
            this.ThresholdEmergencyLbl.Location = new System.Drawing.Point(7, 201);
            this.ThresholdEmergencyLbl.Name = "ThresholdEmergencyLbl";
            this.ThresholdEmergencyLbl.Size = new System.Drawing.Size(113, 13);
            this.ThresholdEmergencyLbl.TabIndex = 18;
            this.ThresholdEmergencyLbl.Text = "Threshold Emergency:";
            //
            // ThresholdNormalLbl
            //
            this.ThresholdNormalLbl.AutoSize = true;
            this.ThresholdNormalLbl.Location = new System.Drawing.Point(7, 176);
            this.ThresholdNormalLbl.Name = "ThresholdNormalLbl";
            this.ThresholdNormalLbl.Size = new System.Drawing.Size(93, 13);
            this.ThresholdNormalLbl.TabIndex = 16;
            this.ThresholdNormalLbl.Text = "Threshold Normal:";
            //
            // ThresholdActiveLbl
            //
            this.ThresholdActiveLbl.AutoSize = true;
            this.ThresholdActiveLbl.Location = new System.Drawing.Point(7, 150);
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
            this.DescriptionTB.Location = new System.Drawing.Point(103, 47);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(172, 20);
            this.DescriptionTB.TabIndex = 4;
            //
            // errorProvider1
            //
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            //
            // MonitoredGB
            //
            this.MonitoredGB.Controls.Add(this.MonitoredIndexTB);
            this.MonitoredGB.Controls.Add(this.MonitoredIndexLbl);
            this.MonitoredGB.Controls.Add(this.MonitoredValueLbl);
            this.MonitoredGB.Controls.Add(this.MonitoredValueTB);
            this.MonitoredGB.Location = new System.Drawing.Point(12, 79);
            this.MonitoredGB.Name = "MonitoredGB";
            this.MonitoredGB.Size = new System.Drawing.Size(296, 76);
            this.MonitoredGB.TabIndex = 8;
            this.MonitoredGB.TabStop = false;
            this.MonitoredGB.Text = "Monitored:";
            //
            // MonitoredIndexTB
            //
            this.MonitoredIndexTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoredIndexTB.Location = new System.Drawing.Point(103, 45);
            this.MonitoredIndexTB.Name = "MonitoredIndexTB";
            this.MonitoredIndexTB.Size = new System.Drawing.Size(171, 20);
            this.MonitoredIndexTB.TabIndex = 10;
            //
            // MonitoredIndexLbl
            //
            this.MonitoredIndexLbl.AutoSize = true;
            this.MonitoredIndexLbl.Location = new System.Drawing.Point(7, 48);
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
            // MonitoredValueTB
            //
            this.MonitoredValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoredValueTB.Location = new System.Drawing.Point(103, 19);
            this.MonitoredValueTB.Name = "MonitoredValueTB";
            this.MonitoredValueTB.Size = new System.Drawing.Size(171, 20);
            this.MonitoredValueTB.TabIndex = 5;
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(104, 19);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(171, 20);
            this.LogicalNameTB.TabIndex = 35;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ActionUnderThresholdTB
            //
            this.ActionUnderThresholdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                  | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionUnderThresholdTB.Index = 12;
            this.ActionUnderThresholdTB.Location = new System.Drawing.Point(106, 400);
            this.ActionUnderThresholdTB.Name = "ActionUnderThresholdTB";
            this.ActionUnderThresholdTB.Size = new System.Drawing.Size(171, 40);
            this.ActionUnderThresholdTB.TabIndex = 32;
            this.ActionUnderThresholdTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ActionOverThresholdTB
            //
            this.ActionOverThresholdTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                 | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionOverThresholdTB.Index = 11;
            this.ActionOverThresholdTB.Location = new System.Drawing.Point(106, 359);
            this.ActionOverThresholdTB.Name = "ActionOverThresholdTB";
            this.ActionOverThresholdTB.Size = new System.Drawing.Size(171, 35);
            this.ActionOverThresholdTB.TabIndex = 30;
            this.ActionOverThresholdTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // EmergencyProfileGroupIDsTB
            //
            this.EmergencyProfileGroupIDsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            this.EmergencyProfileGroupIDsTB.Index = 9;
            this.EmergencyProfileGroupIDsTB.Location = new System.Drawing.Point(105, 303);
            this.EmergencyProfileGroupIDsTB.Name = "EmergencyProfileGroupIDsTB";
            this.EmergencyProfileGroupIDsTB.ReadOnly = true;
            this.EmergencyProfileGroupIDsTB.Size = new System.Drawing.Size(171, 33);
            this.EmergencyProfileGroupIDsTB.TabIndex = 27;
            this.EmergencyProfileGroupIDsTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // EmergencyProfileTB
            //
            this.EmergencyProfileTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                              | System.Windows.Forms.AnchorStyles.Right)));
            this.EmergencyProfileTB.Index = 8;
            this.EmergencyProfileTB.Location = new System.Drawing.Point(104, 278);
            this.EmergencyProfileTB.Name = "EmergencyProfileTB";
            this.EmergencyProfileTB.Size = new System.Drawing.Size(171, 20);
            this.EmergencyProfileTB.TabIndex = 25;
            this.EmergencyProfileTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // MinUnderThresholdDurationTB
            //
            this.MinUnderThresholdDurationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            this.MinUnderThresholdDurationTB.Index = 7;
            this.MinUnderThresholdDurationTB.Location = new System.Drawing.Point(104, 253);
            this.MinUnderThresholdDurationTB.Name = "MinUnderThresholdDurationTB";
            this.MinUnderThresholdDurationTB.Size = new System.Drawing.Size(171, 20);
            this.MinUnderThresholdDurationTB.TabIndex = 23;
            this.MinUnderThresholdDurationTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // MinOverThresholdDurationTB
            //
            this.MinOverThresholdDurationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            this.MinOverThresholdDurationTB.Index = 6;
            this.MinOverThresholdDurationTB.Location = new System.Drawing.Point(104, 227);
            this.MinOverThresholdDurationTB.Name = "MinOverThresholdDurationTB";
            this.MinOverThresholdDurationTB.Size = new System.Drawing.Size(171, 20);
            this.MinOverThresholdDurationTB.TabIndex = 21;
            this.MinOverThresholdDurationTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ThresholdEmergencyTB
            //
            this.ThresholdEmergencyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdEmergencyTB.Index = 5;
            this.ThresholdEmergencyTB.Location = new System.Drawing.Point(103, 201);
            this.ThresholdEmergencyTB.Name = "ThresholdEmergencyTB";
            this.ThresholdEmergencyTB.Size = new System.Drawing.Size(171, 20);
            this.ThresholdEmergencyTB.TabIndex = 19;
            this.ThresholdEmergencyTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ThresholdNormalTB
            //
            this.ThresholdNormalTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdNormalTB.Index = 4;
            this.ThresholdNormalTB.Location = new System.Drawing.Point(103, 176);
            this.ThresholdNormalTB.Name = "ThresholdNormalTB";
            this.ThresholdNormalTB.Size = new System.Drawing.Size(171, 20);
            this.ThresholdNormalTB.TabIndex = 17;
            this.ThresholdNormalTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ThresholdActiveTB
            //
            this.ThresholdActiveTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdActiveTB.Index = 3;
            this.ThresholdActiveTB.Location = new System.Drawing.Point(103, 150);
            this.ThresholdActiveTB.Name = "ThresholdActiveTB";
            this.ThresholdActiveTB.Size = new System.Drawing.Size(171, 20);
            this.ThresholdActiveTB.TabIndex = 15;
            this.ThresholdActiveTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // GXDLMSLimiterView
            //
            this.ClientSize = new System.Drawing.Size(320, 456);
            this.Controls.Add(this.MonitoredGB);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSLimiterView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.MonitoredGB.ResumeLayout(false);
            this.MonitoredGB.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
