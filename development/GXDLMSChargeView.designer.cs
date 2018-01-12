using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSChargeView
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
        private GXValueField TotalAmountPaidTb;
        private Label TotalAmountPaidLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSChargeView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProportionTb = new Gurux.DLMS.UI.GXValueField();
            this.ProportionLbl = new System.Windows.Forms.Label();
            this.TotalAmountRemainingTb = new Gurux.DLMS.UI.GXValueField();
            this.TotalAmountRemainingLbl = new System.Windows.Forms.Label();
            this.LastCollectionAmountTb = new Gurux.DLMS.UI.GXValueField();
            this.LastCollectionAmountLbl = new System.Windows.Forms.Label();
            this.LastCollectionTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.LastCollectionTimeLbl = new System.Windows.Forms.Label();
            this.ChargeConfigurationTb = new Gurux.DLMS.UI.GXValueField();
            this.ChargeConfigurationLbl = new System.Windows.Forms.Label();
            this.PeriodTb = new Gurux.DLMS.UI.GXValueField();
            this.PeriodLbl = new System.Windows.Forms.Label();
            this.LimitTb = new Gurux.DLMS.UI.GXValueField();
            this.UnitChargeActivationTimeLbl = new System.Windows.Forms.Label();
            this.UnitChargePassiveTb = new Gurux.DLMS.UI.GXValueField();
            this.UnitChargePassiveLbl = new System.Windows.Forms.Label();
            this.UnitChargeActiveTb = new Gurux.DLMS.UI.GXValueField();
            this.UnitChargeActiveLbl = new System.Windows.Forms.Label();
            this.PriorityTb = new Gurux.DLMS.UI.GXValueField();
            this.PriorityLbl = new System.Windows.Forms.Label();
            this.ChargeTypeTb = new Gurux.DLMS.UI.GXValueField();
            this.ChargeTypeLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.TotalAmountPaidTb = new Gurux.DLMS.UI.GXValueField();
            this.TotalAmountPaidLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ProportionTb);
            this.groupBox1.Controls.Add(this.ProportionLbl);
            this.groupBox1.Controls.Add(this.TotalAmountRemainingTb);
            this.groupBox1.Controls.Add(this.TotalAmountRemainingLbl);
            this.groupBox1.Controls.Add(this.LastCollectionAmountTb);
            this.groupBox1.Controls.Add(this.LastCollectionAmountLbl);
            this.groupBox1.Controls.Add(this.LastCollectionTimeTb);
            this.groupBox1.Controls.Add(this.LastCollectionTimeLbl);
            this.groupBox1.Controls.Add(this.ChargeConfigurationTb);
            this.groupBox1.Controls.Add(this.ChargeConfigurationLbl);
            this.groupBox1.Controls.Add(this.PeriodTb);
            this.groupBox1.Controls.Add(this.PeriodLbl);
            this.groupBox1.Controls.Add(this.LimitTb);
            this.groupBox1.Controls.Add(this.UnitChargeActivationTimeLbl);
            this.groupBox1.Controls.Add(this.UnitChargePassiveTb);
            this.groupBox1.Controls.Add(this.UnitChargePassiveLbl);
            this.groupBox1.Controls.Add(this.UnitChargeActiveTb);
            this.groupBox1.Controls.Add(this.UnitChargeActiveLbl);
            this.groupBox1.Controls.Add(this.PriorityTb);
            this.groupBox1.Controls.Add(this.PriorityLbl);
            this.groupBox1.Controls.Add(this.ChargeTypeTb);
            this.groupBox1.Controls.Add(this.ChargeTypeLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.TotalAmountPaidTb);
            this.groupBox1.Controls.Add(this.TotalAmountPaidLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charge Object";
            // 
            // ProportionTb
            // 
            this.ProportionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProportionTb.Index = 13;
            this.ProportionTb.Location = new System.Drawing.Point(151, 357);
            this.ProportionTb.Name = "ProportionTb";
            this.ProportionTb.NotifyChanges = false;
            this.ProportionTb.Size = new System.Drawing.Size(190, 20);
            this.ProportionTb.TabIndex = 13;
            this.ProportionTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ProportionLbl
            // 
            this.ProportionLbl.AutoSize = true;
            this.ProportionLbl.Location = new System.Drawing.Point(9, 360);
            this.ProportionLbl.Name = "ProportionLbl";
            this.ProportionLbl.Size = new System.Drawing.Size(58, 13);
            this.ProportionLbl.TabIndex = 45;
            this.ProportionLbl.Text = "Proportion:";
            // 
            // TotalAmountRemainingTb
            // 
            this.TotalAmountRemainingTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountRemainingTb.Index = 12;
            this.TotalAmountRemainingTb.Location = new System.Drawing.Point(151, 331);
            this.TotalAmountRemainingTb.Name = "TotalAmountRemainingTb";
            this.TotalAmountRemainingTb.NotifyChanges = false;
            this.TotalAmountRemainingTb.Size = new System.Drawing.Size(190, 20);
            this.TotalAmountRemainingTb.TabIndex = 12;
            this.TotalAmountRemainingTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // TotalAmountRemainingLbl
            // 
            this.TotalAmountRemainingLbl.AutoSize = true;
            this.TotalAmountRemainingLbl.Location = new System.Drawing.Point(9, 334);
            this.TotalAmountRemainingLbl.Name = "TotalAmountRemainingLbl";
            this.TotalAmountRemainingLbl.Size = new System.Drawing.Size(126, 13);
            this.TotalAmountRemainingLbl.TabIndex = 43;
            this.TotalAmountRemainingLbl.Text = "Total Amount Remaining:";
            // 
            // LastCollectionAmountTb
            // 
            this.LastCollectionAmountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastCollectionAmountTb.Index = 11;
            this.LastCollectionAmountTb.Location = new System.Drawing.Point(151, 305);
            this.LastCollectionAmountTb.Name = "LastCollectionAmountTb";
            this.LastCollectionAmountTb.NotifyChanges = false;
            this.LastCollectionAmountTb.Size = new System.Drawing.Size(190, 20);
            this.LastCollectionAmountTb.TabIndex = 11;
            this.LastCollectionAmountTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LastCollectionAmountLbl
            // 
            this.LastCollectionAmountLbl.AutoSize = true;
            this.LastCollectionAmountLbl.Location = new System.Drawing.Point(9, 308);
            this.LastCollectionAmountLbl.Name = "LastCollectionAmountLbl";
            this.LastCollectionAmountLbl.Size = new System.Drawing.Size(118, 13);
            this.LastCollectionAmountLbl.TabIndex = 42;
            this.LastCollectionAmountLbl.Text = "Last Collection Amount:";
            // 
            // LastCollectionTimeTb
            // 
            this.LastCollectionTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastCollectionTimeTb.Index = 10;
            this.LastCollectionTimeTb.Location = new System.Drawing.Point(151, 279);
            this.LastCollectionTimeTb.Name = "LastCollectionTimeTb";
            this.LastCollectionTimeTb.NotifyChanges = false;
            this.LastCollectionTimeTb.Size = new System.Drawing.Size(190, 20);
            this.LastCollectionTimeTb.TabIndex = 10;
            this.LastCollectionTimeTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LastCollectionTimeLbl
            // 
            this.LastCollectionTimeLbl.AutoSize = true;
            this.LastCollectionTimeLbl.Location = new System.Drawing.Point(9, 282);
            this.LastCollectionTimeLbl.Name = "LastCollectionTimeLbl";
            this.LastCollectionTimeLbl.Size = new System.Drawing.Size(105, 13);
            this.LastCollectionTimeLbl.TabIndex = 41;
            this.LastCollectionTimeLbl.Text = "Last Collection Time:";
            // 
            // ChargeConfigurationTb
            // 
            this.ChargeConfigurationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeConfigurationTb.Index = 9;
            this.ChargeConfigurationTb.Location = new System.Drawing.Point(151, 253);
            this.ChargeConfigurationTb.Name = "ChargeConfigurationTb";
            this.ChargeConfigurationTb.NotifyChanges = false;
            this.ChargeConfigurationTb.Size = new System.Drawing.Size(190, 20);
            this.ChargeConfigurationTb.TabIndex = 9;
            this.ChargeConfigurationTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ChargeConfigurationLbl
            // 
            this.ChargeConfigurationLbl.AutoSize = true;
            this.ChargeConfigurationLbl.Location = new System.Drawing.Point(9, 256);
            this.ChargeConfigurationLbl.Name = "ChargeConfigurationLbl";
            this.ChargeConfigurationLbl.Size = new System.Drawing.Size(109, 13);
            this.ChargeConfigurationLbl.TabIndex = 40;
            this.ChargeConfigurationLbl.Text = "Charge Configuration:";
            // 
            // PeriodTb
            // 
            this.PeriodTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTb.Index = 8;
            this.PeriodTb.Location = new System.Drawing.Point(151, 227);
            this.PeriodTb.Name = "PeriodTb";
            this.PeriodTb.NotifyChanges = false;
            this.PeriodTb.Size = new System.Drawing.Size(190, 20);
            this.PeriodTb.TabIndex = 8;
            this.PeriodTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // PeriodLbl
            // 
            this.PeriodLbl.AutoSize = true;
            this.PeriodLbl.Location = new System.Drawing.Point(10, 230);
            this.PeriodLbl.Name = "PeriodLbl";
            this.PeriodLbl.Size = new System.Drawing.Size(40, 13);
            this.PeriodLbl.TabIndex = 39;
            this.PeriodLbl.Text = "Period:";
            // 
            // LimitTb
            // 
            this.LimitTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LimitTb.Index = 7;
            this.LimitTb.Location = new System.Drawing.Point(151, 201);
            this.LimitTb.Name = "LimitTb";
            this.LimitTb.NotifyChanges = false;
            this.LimitTb.Size = new System.Drawing.Size(190, 20);
            this.LimitTb.TabIndex = 7;
            this.LimitTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // UnitChargeActivationTimeLbl
            // 
            this.UnitChargeActivationTimeLbl.AutoSize = true;
            this.UnitChargeActivationTimeLbl.Location = new System.Drawing.Point(9, 204);
            this.UnitChargeActivationTimeLbl.Name = "UnitChargeActivationTimeLbl";
            this.UnitChargeActivationTimeLbl.Size = new System.Drawing.Size(142, 13);
            this.UnitChargeActivationTimeLbl.TabIndex = 38;
            this.UnitChargeActivationTimeLbl.Text = "Unit Charge Activation Time:";
            // 
            // UnitChargePassiveTb
            // 
            this.UnitChargePassiveTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitChargePassiveTb.Index = 6;
            this.UnitChargePassiveTb.Location = new System.Drawing.Point(151, 175);
            this.UnitChargePassiveTb.Name = "UnitChargePassiveTb";
            this.UnitChargePassiveTb.NotifyChanges = false;
            this.UnitChargePassiveTb.Size = new System.Drawing.Size(190, 20);
            this.UnitChargePassiveTb.TabIndex = 6;
            this.UnitChargePassiveTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // UnitChargePassiveLbl
            // 
            this.UnitChargePassiveLbl.AutoSize = true;
            this.UnitChargePassiveLbl.Location = new System.Drawing.Point(9, 178);
            this.UnitChargePassiveLbl.Name = "UnitChargePassiveLbl";
            this.UnitChargePassiveLbl.Size = new System.Drawing.Size(106, 13);
            this.UnitChargePassiveLbl.TabIndex = 36;
            this.UnitChargePassiveLbl.Text = "Unit Charge Passive:";
            // 
            // UnitChargeActiveTb
            // 
            this.UnitChargeActiveTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitChargeActiveTb.Index = 5;
            this.UnitChargeActiveTb.Location = new System.Drawing.Point(151, 149);
            this.UnitChargeActiveTb.Name = "UnitChargeActiveTb";
            this.UnitChargeActiveTb.NotifyChanges = false;
            this.UnitChargeActiveTb.Size = new System.Drawing.Size(190, 20);
            this.UnitChargeActiveTb.TabIndex = 5;
            this.UnitChargeActiveTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // UnitChargeActiveLbl
            // 
            this.UnitChargeActiveLbl.AutoSize = true;
            this.UnitChargeActiveLbl.Location = new System.Drawing.Point(9, 152);
            this.UnitChargeActiveLbl.Name = "UnitChargeActiveLbl";
            this.UnitChargeActiveLbl.Size = new System.Drawing.Size(99, 13);
            this.UnitChargeActiveLbl.TabIndex = 32;
            this.UnitChargeActiveLbl.Text = "Unit Charge Active:";
            // 
            // PriorityTb
            // 
            this.PriorityTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityTb.Index = 4;
            this.PriorityTb.Location = new System.Drawing.Point(151, 123);
            this.PriorityTb.Name = "PriorityTb";
            this.PriorityTb.NotifyChanges = false;
            this.PriorityTb.Size = new System.Drawing.Size(190, 20);
            this.PriorityTb.TabIndex = 4;
            this.PriorityTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Location = new System.Drawing.Point(10, 126);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(41, 13);
            this.PriorityLbl.TabIndex = 29;
            this.PriorityLbl.Text = "Priority:";
            // 
            // ChargeTypeTb
            // 
            this.ChargeTypeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeTypeTb.Index = 3;
            this.ChargeTypeTb.Location = new System.Drawing.Point(151, 97);
            this.ChargeTypeTb.Name = "ChargeTypeTb";
            this.ChargeTypeTb.NotifyChanges = false;
            this.ChargeTypeTb.Size = new System.Drawing.Size(190, 20);
            this.ChargeTypeTb.TabIndex = 3;
            this.ChargeTypeTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ChargeTypeLbl
            // 
            this.ChargeTypeLbl.AutoSize = true;
            this.ChargeTypeLbl.Location = new System.Drawing.Point(10, 100);
            this.ChargeTypeLbl.Name = "ChargeTypeLbl";
            this.ChargeTypeLbl.Size = new System.Drawing.Size(71, 13);
            this.ChargeTypeLbl.TabIndex = 24;
            this.ChargeTypeLbl.Text = "Charge Type:";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 5;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(151, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(191, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // TotalAmountPaidTb
            // 
            this.TotalAmountPaidTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountPaidTb.Index = 2;
            this.TotalAmountPaidTb.Location = new System.Drawing.Point(151, 71);
            this.TotalAmountPaidTb.Name = "TotalAmountPaidTb";
            this.TotalAmountPaidTb.NotifyChanges = false;
            this.TotalAmountPaidTb.Size = new System.Drawing.Size(190, 20);
            this.TotalAmountPaidTb.TabIndex = 2;
            this.TotalAmountPaidTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // TotalAmountPaidLbl
            // 
            this.TotalAmountPaidLbl.AutoSize = true;
            this.TotalAmountPaidLbl.Location = new System.Drawing.Point(7, 74);
            this.TotalAmountPaidLbl.Name = "TotalAmountPaidLbl";
            this.TotalAmountPaidLbl.Size = new System.Drawing.Size(97, 13);
            this.TotalAmountPaidLbl.TabIndex = 2;
            this.TotalAmountPaidLbl.Text = "Total Amount Paid:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(151, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(190, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(7, 48);
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
            // GXDLMSChargeView
            // 
            this.ClientSize = new System.Drawing.Size(387, 414);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSChargeView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField TotalAmountRemainingTb;
        private Label TotalAmountRemainingLbl;
        private GXValueField LastCollectionAmountTb;
        private Label LastCollectionAmountLbl;
        private GXValueField LastCollectionTimeTb;
        private Label LastCollectionTimeLbl;
        private GXValueField ChargeConfigurationTb;
        private Label ChargeConfigurationLbl;
        private GXValueField PeriodTb;
        private Label PeriodLbl;
        private GXValueField LimitTb;
        private GXValueField UnitChargePassiveTb;
        private Label UnitChargePassiveLbl;
        private GXValueField UnitChargeActiveTb;
        private Label UnitChargeActiveLbl;
        private GXValueField PriorityTb;
        private Label PriorityLbl;
        private GXValueField ChargeTypeTb;
        private Label ChargeTypeLbl;
        private Label UnitChargeActivationTimeLbl;
        private GXValueField ProportionTb;
        private Label ProportionLbl;
    }
}
