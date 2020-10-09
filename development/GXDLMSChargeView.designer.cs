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
        private ErrorProvider errorProvider1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSChargeView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gxButton3 = new Gurux.DLMS.UI.GXButton();
            this.gxButton1 = new Gurux.DLMS.UI.GXButton();
            this.UpdateAmountBtn = new Gurux.DLMS.UI.GXButton();
            this.ActiveChargePerUnits = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ActiveIndexTB = new System.Windows.Forms.TextBox();
            this.ActiveIndexLbl = new System.Windows.Forms.Label();
            this.ActiveTargetCb = new System.Windows.Forms.ComboBox();
            this.ActiveTargetLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ActivePriceScaleLbl = new System.Windows.Forms.Label();
            this.ActivePriceScaleTb = new System.Windows.Forms.TextBox();
            this.ActiveCommodityScaleLbl = new System.Windows.Forms.Label();
            this.ActiveCommodityScaleTb = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.gxButton4 = new Gurux.DLMS.UI.GXButton();
            this.gxButton2 = new Gurux.DLMS.UI.GXButton();
            this.PassiveChargePerUnits = new System.Windows.Forms.ListView();
            this.ActiveIndexCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActiveChargePerUnitCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PassiveIndexTB = new System.Windows.Forms.TextBox();
            this.PassiveIndexLbl = new System.Windows.Forms.Label();
            this.PassiveTargetCb = new System.Windows.Forms.ComboBox();
            this.PassiveTargetLbl = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.PassivePriceScaleLbl = new System.Windows.Forms.Label();
            this.PassivePriceScaleTb = new System.Windows.Forms.TextBox();
            this.PassiveCommodityScaleLbl = new System.Windows.Forms.Label();
            this.PassiveCommodityScaleTb = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charge Object";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(329, 407);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProportionTb);
            this.tabPage1.Controls.Add(this.ProportionLbl);
            this.tabPage1.Controls.Add(this.TotalAmountRemainingTb);
            this.tabPage1.Controls.Add(this.TotalAmountRemainingLbl);
            this.tabPage1.Controls.Add(this.LastCollectionAmountTb);
            this.tabPage1.Controls.Add(this.LastCollectionAmountLbl);
            this.tabPage1.Controls.Add(this.LastCollectionTimeTb);
            this.tabPage1.Controls.Add(this.LastCollectionTimeLbl);
            this.tabPage1.Controls.Add(this.ChargeConfigurationTb);
            this.tabPage1.Controls.Add(this.ChargeConfigurationLbl);
            this.tabPage1.Controls.Add(this.PeriodTb);
            this.tabPage1.Controls.Add(this.PeriodLbl);
            this.tabPage1.Controls.Add(this.LimitTb);
            this.tabPage1.Controls.Add(this.UnitChargeActivationTimeLbl);
            this.tabPage1.Controls.Add(this.PriorityTb);
            this.tabPage1.Controls.Add(this.PriorityLbl);
            this.tabPage1.Controls.Add(this.ChargeTypeTb);
            this.tabPage1.Controls.Add(this.ChargeTypeLbl);
            this.tabPage1.Controls.Add(this.DescriptionLbl);
            this.tabPage1.Controls.Add(this.DescriptionTB);
            this.tabPage1.Controls.Add(this.TotalAmountPaidTb);
            this.tabPage1.Controls.Add(this.TotalAmountPaidLbl);
            this.tabPage1.Controls.Add(this.LogicalNameTB);
            this.tabPage1.Controls.Add(this.LogicalNameLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(321, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProportionTb
            // 
            this.ProportionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProportionTb.Index = 13;
            this.ProportionTb.Location = new System.Drawing.Point(151, 292);
            this.ProportionTb.Name = "ProportionTb";
            this.ProportionTb.NotifyChanges = false;
            this.ProportionTb.Size = new System.Drawing.Size(162, 20);
            this.ProportionTb.TabIndex = 62;
            this.ProportionTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ProportionLbl
            // 
            this.ProportionLbl.AutoSize = true;
            this.ProportionLbl.Location = new System.Drawing.Point(9, 293);
            this.ProportionLbl.Name = "ProportionLbl";
            this.ProportionLbl.Size = new System.Drawing.Size(58, 13);
            this.ProportionLbl.TabIndex = 73;
            this.ProportionLbl.Text = "Proportion:";
            // 
            // TotalAmountRemainingTb
            // 
            this.TotalAmountRemainingTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountRemainingTb.Index = 12;
            this.TotalAmountRemainingTb.Location = new System.Drawing.Point(151, 266);
            this.TotalAmountRemainingTb.Name = "TotalAmountRemainingTb";
            this.TotalAmountRemainingTb.NotifyChanges = false;
            this.TotalAmountRemainingTb.Size = new System.Drawing.Size(162, 20);
            this.TotalAmountRemainingTb.TabIndex = 61;
            this.TotalAmountRemainingTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TotalAmountRemainingLbl
            // 
            this.TotalAmountRemainingLbl.AutoSize = true;
            this.TotalAmountRemainingLbl.Location = new System.Drawing.Point(9, 269);
            this.TotalAmountRemainingLbl.Name = "TotalAmountRemainingLbl";
            this.TotalAmountRemainingLbl.Size = new System.Drawing.Size(126, 13);
            this.TotalAmountRemainingLbl.TabIndex = 72;
            this.TotalAmountRemainingLbl.Text = "Total Amount Remaining:";
            // 
            // LastCollectionAmountTb
            // 
            this.LastCollectionAmountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastCollectionAmountTb.Index = 11;
            this.LastCollectionAmountTb.Location = new System.Drawing.Point(151, 240);
            this.LastCollectionAmountTb.Name = "LastCollectionAmountTb";
            this.LastCollectionAmountTb.NotifyChanges = false;
            this.LastCollectionAmountTb.Size = new System.Drawing.Size(162, 20);
            this.LastCollectionAmountTb.TabIndex = 60;
            this.LastCollectionAmountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LastCollectionAmountLbl
            // 
            this.LastCollectionAmountLbl.AutoSize = true;
            this.LastCollectionAmountLbl.Location = new System.Drawing.Point(9, 243);
            this.LastCollectionAmountLbl.Name = "LastCollectionAmountLbl";
            this.LastCollectionAmountLbl.Size = new System.Drawing.Size(118, 13);
            this.LastCollectionAmountLbl.TabIndex = 71;
            this.LastCollectionAmountLbl.Text = "Last Collection Amount:";
            // 
            // LastCollectionTimeTb
            // 
            this.LastCollectionTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastCollectionTimeTb.Index = 10;
            this.LastCollectionTimeTb.Location = new System.Drawing.Point(151, 214);
            this.LastCollectionTimeTb.Name = "LastCollectionTimeTb";
            this.LastCollectionTimeTb.NotifyChanges = false;
            this.LastCollectionTimeTb.Size = new System.Drawing.Size(162, 20);
            this.LastCollectionTimeTb.TabIndex = 59;
            this.LastCollectionTimeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LastCollectionTimeLbl
            // 
            this.LastCollectionTimeLbl.AutoSize = true;
            this.LastCollectionTimeLbl.Location = new System.Drawing.Point(9, 217);
            this.LastCollectionTimeLbl.Name = "LastCollectionTimeLbl";
            this.LastCollectionTimeLbl.Size = new System.Drawing.Size(105, 13);
            this.LastCollectionTimeLbl.TabIndex = 70;
            this.LastCollectionTimeLbl.Text = "Last Collection Time:";
            // 
            // ChargeConfigurationTb
            // 
            this.ChargeConfigurationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeConfigurationTb.Index = 9;
            this.ChargeConfigurationTb.Location = new System.Drawing.Point(151, 188);
            this.ChargeConfigurationTb.Name = "ChargeConfigurationTb";
            this.ChargeConfigurationTb.NotifyChanges = false;
            this.ChargeConfigurationTb.Size = new System.Drawing.Size(162, 20);
            this.ChargeConfigurationTb.TabIndex = 58;
            this.ChargeConfigurationTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ChargeConfigurationLbl
            // 
            this.ChargeConfigurationLbl.AutoSize = true;
            this.ChargeConfigurationLbl.Location = new System.Drawing.Point(9, 191);
            this.ChargeConfigurationLbl.Name = "ChargeConfigurationLbl";
            this.ChargeConfigurationLbl.Size = new System.Drawing.Size(109, 13);
            this.ChargeConfigurationLbl.TabIndex = 69;
            this.ChargeConfigurationLbl.Text = "Charge Configuration:";
            // 
            // PeriodTb
            // 
            this.PeriodTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTb.Index = 8;
            this.PeriodTb.Location = new System.Drawing.Point(151, 162);
            this.PeriodTb.Name = "PeriodTb";
            this.PeriodTb.NotifyChanges = false;
            this.PeriodTb.Size = new System.Drawing.Size(162, 20);
            this.PeriodTb.TabIndex = 57;
            this.PeriodTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PeriodLbl
            // 
            this.PeriodLbl.AutoSize = true;
            this.PeriodLbl.Location = new System.Drawing.Point(10, 163);
            this.PeriodLbl.Name = "PeriodLbl";
            this.PeriodLbl.Size = new System.Drawing.Size(40, 13);
            this.PeriodLbl.TabIndex = 68;
            this.PeriodLbl.Text = "Period:";
            // 
            // LimitTb
            // 
            this.LimitTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LimitTb.Index = 7;
            this.LimitTb.Location = new System.Drawing.Point(151, 136);
            this.LimitTb.Name = "LimitTb";
            this.LimitTb.NotifyChanges = false;
            this.LimitTb.Size = new System.Drawing.Size(162, 20);
            this.LimitTb.TabIndex = 56;
            this.LimitTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // UnitChargeActivationTimeLbl
            // 
            this.UnitChargeActivationTimeLbl.AutoSize = true;
            this.UnitChargeActivationTimeLbl.Location = new System.Drawing.Point(9, 139);
            this.UnitChargeActivationTimeLbl.Name = "UnitChargeActivationTimeLbl";
            this.UnitChargeActivationTimeLbl.Size = new System.Drawing.Size(142, 13);
            this.UnitChargeActivationTimeLbl.TabIndex = 67;
            this.UnitChargeActivationTimeLbl.Text = "Unit Charge Activation Time:";
            // 
            // PriorityTb
            // 
            this.PriorityTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityTb.Index = 4;
            this.PriorityTb.Location = new System.Drawing.Point(151, 109);
            this.PriorityTb.Name = "PriorityTb";
            this.PriorityTb.NotifyChanges = false;
            this.PriorityTb.Size = new System.Drawing.Size(162, 20);
            this.PriorityTb.TabIndex = 52;
            this.PriorityTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Location = new System.Drawing.Point(10, 112);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(41, 13);
            this.PriorityLbl.TabIndex = 64;
            this.PriorityLbl.Text = "Priority:";
            // 
            // ChargeTypeTb
            // 
            this.ChargeTypeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeTypeTb.Index = 3;
            this.ChargeTypeTb.Location = new System.Drawing.Point(151, 83);
            this.ChargeTypeTb.Name = "ChargeTypeTb";
            this.ChargeTypeTb.NotifyChanges = false;
            this.ChargeTypeTb.Size = new System.Drawing.Size(162, 20);
            this.ChargeTypeTb.TabIndex = 51;
            this.ChargeTypeTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // ChargeTypeLbl
            // 
            this.ChargeTypeLbl.AutoSize = true;
            this.ChargeTypeLbl.Location = new System.Drawing.Point(10, 86);
            this.ChargeTypeLbl.Name = "ChargeTypeLbl";
            this.ChargeTypeLbl.Size = new System.Drawing.Size(71, 13);
            this.ChargeTypeLbl.TabIndex = 63;
            this.ChargeTypeLbl.Text = "Charge Type:";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 8);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 53;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(151, 5);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(163, 20);
            this.DescriptionTB.TabIndex = 47;
            // 
            // TotalAmountPaidTb
            // 
            this.TotalAmountPaidTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmountPaidTb.Index = 2;
            this.TotalAmountPaidTb.Location = new System.Drawing.Point(151, 57);
            this.TotalAmountPaidTb.Name = "TotalAmountPaidTb";
            this.TotalAmountPaidTb.NotifyChanges = false;
            this.TotalAmountPaidTb.Size = new System.Drawing.Size(162, 20);
            this.TotalAmountPaidTb.TabIndex = 49;
            this.TotalAmountPaidTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TotalAmountPaidLbl
            // 
            this.TotalAmountPaidLbl.AutoSize = true;
            this.TotalAmountPaidLbl.Location = new System.Drawing.Point(7, 60);
            this.TotalAmountPaidLbl.Name = "TotalAmountPaidLbl";
            this.TotalAmountPaidLbl.Size = new System.Drawing.Size(97, 13);
            this.TotalAmountPaidLbl.TabIndex = 48;
            this.TotalAmountPaidLbl.Text = "Total Amount Paid:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(151, 31);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(162, 20);
            this.LogicalNameTB.TabIndex = 50;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(7, 34);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 46;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(321, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Unit Charge Active";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gxButton3);
            this.groupBox4.Controls.Add(this.gxButton1);
            this.groupBox4.Controls.Add(this.UpdateAmountBtn);
            this.groupBox4.Controls.Add(this.ActiveChargePerUnits);
            this.groupBox4.Location = new System.Drawing.Point(3, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 212);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Charge Tables";
            // 
            // gxButton3
            // 
            this.gxButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gxButton3.Index = 3;
            this.gxButton3.Location = new System.Drawing.Point(18, 183);
            this.gxButton3.Name = "gxButton3";
            this.gxButton3.Size = new System.Drawing.Size(94, 23);
            this.gxButton3.TabIndex = 70;
            this.gxButton3.Text = "Collect";
            this.gxButton3.UseVisualStyleBackColor = true;
            // 
            // gxButton1
            // 
            this.gxButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gxButton1.Index = 4;
            this.gxButton1.Location = new System.Drawing.Point(118, 183);
            this.gxButton1.Name = "gxButton1";
            this.gxButton1.Size = new System.Drawing.Size(94, 23);
            this.gxButton1.TabIndex = 69;
            this.gxButton1.Text = "Update Total...";
            this.gxButton1.UseVisualStyleBackColor = true;
            // 
            // UpdateAmountBtn
            // 
            this.UpdateAmountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateAmountBtn.Index = 5;
            this.UpdateAmountBtn.Location = new System.Drawing.Point(218, 183);
            this.UpdateAmountBtn.Name = "UpdateAmountBtn";
            this.UpdateAmountBtn.Size = new System.Drawing.Size(94, 23);
            this.UpdateAmountBtn.TabIndex = 68;
            this.UpdateAmountBtn.Text = "Set Total...";
            this.UpdateAmountBtn.UseVisualStyleBackColor = true;
            // 
            // ActiveChargePerUnits
            // 
            this.ActiveChargePerUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveChargePerUnits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ActiveChargePerUnits.FullRowSelect = true;
            this.ActiveChargePerUnits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActiveChargePerUnits.HideSelection = false;
            this.ActiveChargePerUnits.Location = new System.Drawing.Point(6, 19);
            this.ActiveChargePerUnits.Name = "ActiveChargePerUnits";
            this.ActiveChargePerUnits.Size = new System.Drawing.Size(306, 159);
            this.ActiveChargePerUnits.TabIndex = 65;
            this.ActiveChargePerUnits.UseCompatibleStateImageBehavior = false;
            this.ActiveChargePerUnits.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Charge Per Unit";
            this.columnHeader2.Width = 147;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ActiveIndexTB);
            this.groupBox3.Controls.Add(this.ActiveIndexLbl);
            this.groupBox3.Controls.Add(this.ActiveTargetCb);
            this.groupBox3.Controls.Add(this.ActiveTargetLbl);
            this.groupBox3.Location = new System.Drawing.Point(3, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 81);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Commodity Reference Type";
            // 
            // ActiveIndexTB
            // 
            this.ActiveIndexTB.Location = new System.Drawing.Point(122, 46);
            this.ActiveIndexTB.Name = "ActiveIndexTB";
            this.ActiveIndexTB.Size = new System.Drawing.Size(190, 20);
            this.ActiveIndexTB.TabIndex = 4;
            this.ActiveIndexTB.Leave += new System.EventHandler(this.ActiveIndexTB_Leave);
            // 
            // ActiveIndexLbl
            // 
            this.ActiveIndexLbl.AutoSize = true;
            this.ActiveIndexLbl.Location = new System.Drawing.Point(11, 46);
            this.ActiveIndexLbl.Name = "ActiveIndexLbl";
            this.ActiveIndexLbl.Size = new System.Drawing.Size(36, 13);
            this.ActiveIndexLbl.TabIndex = 9;
            this.ActiveIndexLbl.Text = "Index:";
            // 
            // ActiveTargetCb
            // 
            this.ActiveTargetCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveTargetCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveTargetCb.FormattingEnabled = true;
            this.ActiveTargetCb.Location = new System.Drawing.Point(122, 19);
            this.ActiveTargetCb.Name = "ActiveTargetCb";
            this.ActiveTargetCb.Size = new System.Drawing.Size(190, 21);
            this.ActiveTargetCb.TabIndex = 3;
            this.ActiveTargetCb.SelectedIndexChanged += new System.EventHandler(this.ActiveTargetCb_SelectedIndexChanged);
            // 
            // ActiveTargetLbl
            // 
            this.ActiveTargetLbl.AutoSize = true;
            this.ActiveTargetLbl.Location = new System.Drawing.Point(11, 19);
            this.ActiveTargetLbl.Name = "ActiveTargetLbl";
            this.ActiveTargetLbl.Size = new System.Drawing.Size(41, 13);
            this.ActiveTargetLbl.TabIndex = 7;
            this.ActiveTargetLbl.Text = "Target:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ActivePriceScaleLbl);
            this.groupBox2.Controls.Add(this.ActivePriceScaleTb);
            this.groupBox2.Controls.Add(this.ActiveCommodityScaleLbl);
            this.groupBox2.Controls.Add(this.ActiveCommodityScaleTb);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 78);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Charge Per Unit Scaling Type";
            // 
            // ActivePriceScaleLbl
            // 
            this.ActivePriceScaleLbl.AutoSize = true;
            this.ActivePriceScaleLbl.Location = new System.Drawing.Point(6, 50);
            this.ActivePriceScaleLbl.Name = "ActivePriceScaleLbl";
            this.ActivePriceScaleLbl.Size = new System.Drawing.Size(64, 13);
            this.ActivePriceScaleLbl.TabIndex = 59;
            this.ActivePriceScaleLbl.Text = "Price Scale:";
            // 
            // ActivePriceScaleTb
            // 
            this.ActivePriceScaleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivePriceScaleTb.Location = new System.Drawing.Point(122, 47);
            this.ActivePriceScaleTb.Name = "ActivePriceScaleTb";
            this.ActivePriceScaleTb.Size = new System.Drawing.Size(142, 20);
            this.ActivePriceScaleTb.TabIndex = 2;
            this.ActivePriceScaleTb.Leave += new System.EventHandler(this.ActivePriceScaleTb_Leave);
            // 
            // ActiveCommodityScaleLbl
            // 
            this.ActiveCommodityScaleLbl.AutoSize = true;
            this.ActiveCommodityScaleLbl.Location = new System.Drawing.Point(6, 26);
            this.ActiveCommodityScaleLbl.Name = "ActiveCommodityScaleLbl";
            this.ActiveCommodityScaleLbl.Size = new System.Drawing.Size(91, 13);
            this.ActiveCommodityScaleLbl.TabIndex = 57;
            this.ActiveCommodityScaleLbl.Text = "Commodity Scale:";
            // 
            // ActiveCommodityScaleTb
            // 
            this.ActiveCommodityScaleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveCommodityScaleTb.Location = new System.Drawing.Point(122, 23);
            this.ActiveCommodityScaleTb.Name = "ActiveCommodityScaleTb";
            this.ActiveCommodityScaleTb.Size = new System.Drawing.Size(142, 20);
            this.ActiveCommodityScaleTb.TabIndex = 1;
            this.ActiveCommodityScaleTb.Leave += new System.EventHandler(this.ActiveCommodityScaleTb_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(321, 381);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Unit Charge Passive:";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.RemoveBtn);
            this.groupBox5.Controls.Add(this.EditBtn);
            this.groupBox5.Controls.Add(this.AddBtn);
            this.groupBox5.Controls.Add(this.gxButton4);
            this.groupBox5.Controls.Add(this.gxButton2);
            this.groupBox5.Controls.Add(this.PassiveChargePerUnits);
            this.groupBox5.Location = new System.Drawing.Point(3, 163);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 215);
            this.groupBox5.TabIndex = 60;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Charge Tables";
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(237, 77);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 72;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(237, 48);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 71;
            this.EditBtn.Text = "Edit...";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(237, 19);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 70;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // gxButton4
            // 
            this.gxButton4.Index = 1;
            this.gxButton4.Location = new System.Drawing.Point(237, 157);
            this.gxButton4.Name = "gxButton4";
            this.gxButton4.Size = new System.Drawing.Size(75, 23);
            this.gxButton4.TabIndex = 69;
            this.gxButton4.Text = "Update";
            this.gxButton4.UseVisualStyleBackColor = true;
            // 
            // gxButton2
            // 
            this.gxButton2.Index = 2;
            this.gxButton2.Location = new System.Drawing.Point(237, 186);
            this.gxButton2.Name = "gxButton2";
            this.gxButton2.Size = new System.Drawing.Size(75, 23);
            this.gxButton2.TabIndex = 68;
            this.gxButton2.Text = "Activate";
            this.gxButton2.UseVisualStyleBackColor = true;
            // 
            // PassiveChargePerUnits
            // 
            this.PassiveChargePerUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PassiveChargePerUnits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActiveIndexCh,
            this.ActiveChargePerUnitCh});
            this.PassiveChargePerUnits.FullRowSelect = true;
            this.PassiveChargePerUnits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PassiveChargePerUnits.HideSelection = false;
            this.PassiveChargePerUnits.Location = new System.Drawing.Point(6, 19);
            this.PassiveChargePerUnits.Name = "PassiveChargePerUnits";
            this.PassiveChargePerUnits.Size = new System.Drawing.Size(225, 190);
            this.PassiveChargePerUnits.TabIndex = 64;
            this.PassiveChargePerUnits.UseCompatibleStateImageBehavior = false;
            this.PassiveChargePerUnits.View = System.Windows.Forms.View.Details;
            // 
            // ActiveIndexCh
            // 
            this.ActiveIndexCh.Text = "Index";
            this.ActiveIndexCh.Width = 114;
            // 
            // ActiveChargePerUnitCh
            // 
            this.ActiveChargePerUnitCh.Text = "Charge Per Unit";
            this.ActiveChargePerUnitCh.Width = 147;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PassiveIndexTB);
            this.groupBox6.Controls.Add(this.PassiveIndexLbl);
            this.groupBox6.Controls.Add(this.PassiveTargetCb);
            this.groupBox6.Controls.Add(this.PassiveTargetLbl);
            this.groupBox6.Location = new System.Drawing.Point(3, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(318, 81);
            this.groupBox6.TabIndex = 59;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Commodity Reference Type";
            // 
            // PassiveIndexTB
            // 
            this.PassiveIndexTB.Location = new System.Drawing.Point(122, 46);
            this.PassiveIndexTB.Name = "PassiveIndexTB";
            this.PassiveIndexTB.Size = new System.Drawing.Size(190, 20);
            this.PassiveIndexTB.TabIndex = 4;
            this.PassiveIndexTB.Leave += new System.EventHandler(this.PassiveIndexTB_Leave);
            // 
            // PassiveIndexLbl
            // 
            this.PassiveIndexLbl.AutoSize = true;
            this.PassiveIndexLbl.Location = new System.Drawing.Point(11, 46);
            this.PassiveIndexLbl.Name = "PassiveIndexLbl";
            this.PassiveIndexLbl.Size = new System.Drawing.Size(36, 13);
            this.PassiveIndexLbl.TabIndex = 9;
            this.PassiveIndexLbl.Text = "Index:";
            // 
            // PassiveTargetCb
            // 
            this.PassiveTargetCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassiveTargetCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PassiveTargetCb.FormattingEnabled = true;
            this.PassiveTargetCb.Location = new System.Drawing.Point(122, 19);
            this.PassiveTargetCb.Name = "PassiveTargetCb";
            this.PassiveTargetCb.Size = new System.Drawing.Size(190, 21);
            this.PassiveTargetCb.TabIndex = 3;
            this.PassiveTargetCb.SelectedIndexChanged += new System.EventHandler(this.PassiveTargetCb_SelectedIndexChanged);
            // 
            // PassiveTargetLbl
            // 
            this.PassiveTargetLbl.AutoSize = true;
            this.PassiveTargetLbl.Location = new System.Drawing.Point(11, 19);
            this.PassiveTargetLbl.Name = "PassiveTargetLbl";
            this.PassiveTargetLbl.Size = new System.Drawing.Size(41, 13);
            this.PassiveTargetLbl.TabIndex = 7;
            this.PassiveTargetLbl.Text = "Target:";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.PassivePriceScaleLbl);
            this.groupBox7.Controls.Add(this.PassivePriceScaleTb);
            this.groupBox7.Controls.Add(this.PassiveCommodityScaleLbl);
            this.groupBox7.Controls.Add(this.PassiveCommodityScaleTb);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(315, 78);
            this.groupBox7.TabIndex = 58;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Charge Per Unit Scaling Type";
            // 
            // PassivePriceScaleLbl
            // 
            this.PassivePriceScaleLbl.AutoSize = true;
            this.PassivePriceScaleLbl.Location = new System.Drawing.Point(6, 50);
            this.PassivePriceScaleLbl.Name = "PassivePriceScaleLbl";
            this.PassivePriceScaleLbl.Size = new System.Drawing.Size(64, 13);
            this.PassivePriceScaleLbl.TabIndex = 59;
            this.PassivePriceScaleLbl.Text = "Price Scale:";
            // 
            // PassivePriceScaleTb
            // 
            this.PassivePriceScaleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassivePriceScaleTb.Location = new System.Drawing.Point(122, 47);
            this.PassivePriceScaleTb.Name = "PassivePriceScaleTb";
            this.PassivePriceScaleTb.Size = new System.Drawing.Size(142, 20);
            this.PassivePriceScaleTb.TabIndex = 2;
            this.PassivePriceScaleTb.Leave += new System.EventHandler(this.PassivePriceScaleTb_Leave);
            // 
            // PassiveCommodityScaleLbl
            // 
            this.PassiveCommodityScaleLbl.AutoSize = true;
            this.PassiveCommodityScaleLbl.Location = new System.Drawing.Point(6, 26);
            this.PassiveCommodityScaleLbl.Name = "PassiveCommodityScaleLbl";
            this.PassiveCommodityScaleLbl.Size = new System.Drawing.Size(91, 13);
            this.PassiveCommodityScaleLbl.TabIndex = 57;
            this.PassiveCommodityScaleLbl.Text = "Commodity Scale:";
            // 
            // PassiveCommodityScaleTb
            // 
            this.PassiveCommodityScaleTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassiveCommodityScaleTb.Location = new System.Drawing.Point(122, 23);
            this.PassiveCommodityScaleTb.Name = "PassiveCommodityScaleTb";
            this.PassiveCommodityScaleTb.Size = new System.Drawing.Size(142, 20);
            this.PassiveCommodityScaleTb.TabIndex = 1;
            this.PassiveCommodityScaleTb.Leave += new System.EventHandler(this.PassiveCommodityScaleTb_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // GXDLMSChargeView
            // 
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSChargeView";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GXValueField ProportionTb;
        private Label ProportionLbl;
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
        private Label UnitChargeActivationTimeLbl;
        private GXValueField PriorityTb;
        private Label PriorityLbl;
        private GXValueField ChargeTypeTb;
        private Label ChargeTypeLbl;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private GXValueField TotalAmountPaidTb;
        private Label TotalAmountPaidLbl;
        private GXValueField LogicalNameTB;
        private Label LogicalNameLbl;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TabPage tabPage3;
        private Label ActiveCommodityScaleLbl;
        private TextBox ActiveCommodityScaleTb;
        private Label ActivePriceScaleLbl;
        private TextBox ActivePriceScaleTb;
        private ComboBox ActiveTargetCb;
        private Label ActiveTargetLbl;
        private TextBox ActiveIndexTB;
        private Label ActiveIndexLbl;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox PassiveIndexTB;
        private Label PassiveIndexLbl;
        private ComboBox PassiveTargetCb;
        private Label PassiveTargetLbl;
        private GroupBox groupBox7;
        private Label PassivePriceScaleLbl;
        private TextBox PassivePriceScaleTb;
        private Label PassiveCommodityScaleLbl;
        private TextBox PassiveCommodityScaleTb;
        private ListView PassiveChargePerUnits;
        private ColumnHeader ActiveIndexCh;
        private ColumnHeader ActiveChargePerUnitCh;
        private ListView ActiveChargePerUnits;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GXButton gxButton2;
        private GXButton gxButton3;
        private GXButton gxButton1;
        private GXButton UpdateAmountBtn;
        private GXButton gxButton4;
        private Button RemoveBtn;
        private Button EditBtn;
        private Button AddBtn;
    }
}
