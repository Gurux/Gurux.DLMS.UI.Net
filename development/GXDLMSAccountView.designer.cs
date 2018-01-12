using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSAccountView
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
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSAccountView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GeneralTab = new System.Windows.Forms.TabPage();
            this.AccountStatusCb = new System.Windows.Forms.ComboBox();
            this.PaymentModeCb = new System.Windows.Forms.ComboBox();
            this.CurrencyUnitTb = new System.Windows.Forms.TextBox();
            this.CurrencyScaleTb = new System.Windows.Forms.TextBox();
            this.CurrencyNameTb = new System.Windows.Forms.TextBox();
            this.MaxProvisionPeriodTb = new Gurux.DLMS.UI.GXValueField();
            this.MaxProvisionPeriodLbl = new System.Windows.Forms.Label();
            this.MaxProvisionTb = new Gurux.DLMS.UI.GXValueField();
            this.MaxProvisionLbl = new System.Windows.Forms.Label();
            this.NextCreditAvailableThresholdTb = new Gurux.DLMS.UI.GXValueField();
            this.NextCreditAvailableThresholdLbl = new System.Windows.Forms.Label();
            this.LowCreditThresholdTb = new Gurux.DLMS.UI.GXValueField();
            this.LowCreditThresholdLbl = new System.Windows.Forms.Label();
            this.CurrencyUnitLbl = new System.Windows.Forms.Label();
            this.CurrencyScaleLbl = new System.Windows.Forms.Label();
            this.CurrencyNameLbl = new System.Windows.Forms.Label();
            this.AccountClosureTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.AccountClosureTimeLbl = new System.Windows.Forms.Label();
            this.AccountActivationTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.AccountActivationTimeLbl = new System.Windows.Forms.Label();
            this.AggregatedDebtTb = new Gurux.DLMS.UI.GXValueField();
            this.AggregatedDebtLbl = new System.Windows.Forms.Label();
            this.ClearanceThresholdTb = new Gurux.DLMS.UI.GXValueField();
            this.ClearanceThresholdLbl = new System.Windows.Forms.Label();
            this.AmountToClearTb = new Gurux.DLMS.UI.GXValueField();
            this.AmountToClearLbl = new System.Windows.Forms.Label();
            this.AvailableCreditTb = new Gurux.DLMS.UI.GXValueField();
            this.AvailableCreditLbl = new System.Windows.Forms.Label();
            this.CurrentCreditStatusTb = new Gurux.DLMS.UI.GXValueField();
            this.CurrentCreditStatusLbl = new System.Windows.Forms.Label();
            this.CurrentCreditInUseTb = new Gurux.DLMS.UI.GXValueField();
            this.CurrentCreditInUseLbl = new System.Windows.Forms.Label();
            this.AccountStatusLbl = new System.Windows.Forms.Label();
            this.PaymentModeLbl = new System.Windows.Forms.Label();
            this.CreditReferenceTab = new System.Windows.Forms.TabPage();
            this.CreditReferenceRemove = new System.Windows.Forms.Button();
            this.CreditReferenceEdit = new System.Windows.Forms.Button();
            this.CreditReferenceAdd = new System.Windows.Forms.Button();
            this.CreditReferenceView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChargeReferenceTab = new System.Windows.Forms.TabPage();
            this.ChargeReferenceRemove = new System.Windows.Forms.Button();
            this.ChargeReferenceEdit = new System.Windows.Forms.Button();
            this.ChargeReferenceAdd = new System.Windows.Forms.Button();
            this.ChargeReferenceView = new System.Windows.Forms.ListView();
            this.ChargeReferenceNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreditChargeTab = new System.Windows.Forms.TabPage();
            this.CreditChargeRemove = new System.Windows.Forms.Button();
            this.CreditChargeEdit = new System.Windows.Forms.Button();
            this.CreditChargeAdd = new System.Windows.Forms.Button();
            this.CreditChargeView = new System.Windows.Forms.ListView();
            this.CreditCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChargeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConfigurationCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TokenGatewayTab = new System.Windows.Forms.TabPage();
            this.TokenGatewayRemove = new System.Windows.Forms.Button();
            this.TokenGatewayEdit = new System.Windows.Forms.Button();
            this.TokenGatewayAdd = new System.Windows.Forms.Button();
            this.TokenGatewayView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GeneralTab.SuspendLayout();
            this.CreditReferenceTab.SuspendLayout();
            this.ChargeReferenceTab.SuspendLayout();
            this.CreditChargeTab.SuspendLayout();
            this.TokenGatewayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 700);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Object";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.GeneralTab);
            this.tabControl1.Controls.Add(this.CreditReferenceTab);
            this.tabControl1.Controls.Add(this.ChargeReferenceTab);
            this.tabControl1.Controls.Add(this.CreditChargeTab);
            this.tabControl1.Controls.Add(this.TokenGatewayTab);
            this.tabControl1.Location = new System.Drawing.Point(11, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(379, 487);
            this.tabControl1.TabIndex = 40;
            // 
            // GeneralTab
            // 
            this.GeneralTab.Controls.Add(this.AccountStatusCb);
            this.GeneralTab.Controls.Add(this.PaymentModeCb);
            this.GeneralTab.Controls.Add(this.CurrencyUnitTb);
            this.GeneralTab.Controls.Add(this.CurrencyScaleTb);
            this.GeneralTab.Controls.Add(this.CurrencyNameTb);
            this.GeneralTab.Controls.Add(this.MaxProvisionPeriodTb);
            this.GeneralTab.Controls.Add(this.MaxProvisionPeriodLbl);
            this.GeneralTab.Controls.Add(this.MaxProvisionTb);
            this.GeneralTab.Controls.Add(this.MaxProvisionLbl);
            this.GeneralTab.Controls.Add(this.NextCreditAvailableThresholdTb);
            this.GeneralTab.Controls.Add(this.NextCreditAvailableThresholdLbl);
            this.GeneralTab.Controls.Add(this.LowCreditThresholdTb);
            this.GeneralTab.Controls.Add(this.LowCreditThresholdLbl);
            this.GeneralTab.Controls.Add(this.CurrencyUnitLbl);
            this.GeneralTab.Controls.Add(this.CurrencyScaleLbl);
            this.GeneralTab.Controls.Add(this.CurrencyNameLbl);
            this.GeneralTab.Controls.Add(this.AccountClosureTimeTb);
            this.GeneralTab.Controls.Add(this.AccountClosureTimeLbl);
            this.GeneralTab.Controls.Add(this.AccountActivationTimeTb);
            this.GeneralTab.Controls.Add(this.AccountActivationTimeLbl);
            this.GeneralTab.Controls.Add(this.AggregatedDebtTb);
            this.GeneralTab.Controls.Add(this.AggregatedDebtLbl);
            this.GeneralTab.Controls.Add(this.ClearanceThresholdTb);
            this.GeneralTab.Controls.Add(this.ClearanceThresholdLbl);
            this.GeneralTab.Controls.Add(this.AmountToClearTb);
            this.GeneralTab.Controls.Add(this.AmountToClearLbl);
            this.GeneralTab.Controls.Add(this.AvailableCreditTb);
            this.GeneralTab.Controls.Add(this.AvailableCreditLbl);
            this.GeneralTab.Controls.Add(this.CurrentCreditStatusTb);
            this.GeneralTab.Controls.Add(this.CurrentCreditStatusLbl);
            this.GeneralTab.Controls.Add(this.CurrentCreditInUseTb);
            this.GeneralTab.Controls.Add(this.CurrentCreditInUseLbl);
            this.GeneralTab.Controls.Add(this.AccountStatusLbl);
            this.GeneralTab.Controls.Add(this.PaymentModeLbl);
            this.GeneralTab.Location = new System.Drawing.Point(4, 22);
            this.GeneralTab.Name = "GeneralTab";
            this.GeneralTab.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralTab.Size = new System.Drawing.Size(371, 461);
            this.GeneralTab.TabIndex = 0;
            this.GeneralTab.Text = "General";
            this.GeneralTab.UseVisualStyleBackColor = true;
            // 
            // AccountStatusCb
            // 
            this.AccountStatusCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountStatusCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountStatusCb.FormattingEnabled = true;
            this.AccountStatusCb.Location = new System.Drawing.Point(167, 31);
            this.AccountStatusCb.Name = "AccountStatusCb";
            this.AccountStatusCb.Size = new System.Drawing.Size(192, 21);
            this.AccountStatusCb.TabIndex = 78;
            // 
            // PaymentModeCb
            // 
            this.PaymentModeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentModeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentModeCb.FormattingEnabled = true;
            this.PaymentModeCb.Location = new System.Drawing.Point(167, 6);
            this.PaymentModeCb.Name = "PaymentModeCb";
            this.PaymentModeCb.Size = new System.Drawing.Size(192, 21);
            this.PaymentModeCb.TabIndex = 77;
            this.PaymentModeCb.SelectedIndexChanged += new System.EventHandler(this.SecuritySetupCb_SelectedIndexChanged);
            // 
            // CurrencyUnitTb
            // 
            this.CurrencyUnitTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyUnitTb.Location = new System.Drawing.Point(168, 318);
            this.CurrencyUnitTb.Name = "CurrencyUnitTb";
            this.CurrencyUnitTb.Size = new System.Drawing.Size(193, 20);
            this.CurrencyUnitTb.TabIndex = 76;
            // 
            // CurrencyScaleTb
            // 
            this.CurrencyScaleTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyScaleTb.Location = new System.Drawing.Point(168, 292);
            this.CurrencyScaleTb.Name = "CurrencyScaleTb";
            this.CurrencyScaleTb.Size = new System.Drawing.Size(193, 20);
            this.CurrencyScaleTb.TabIndex = 75;
            // 
            // CurrencyNameTb
            // 
            this.CurrencyNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrencyNameTb.Location = new System.Drawing.Point(167, 266);
            this.CurrencyNameTb.Name = "CurrencyNameTb";
            this.CurrencyNameTb.Size = new System.Drawing.Size(193, 20);
            this.CurrencyNameTb.TabIndex = 74;
            // 
            // MaxProvisionPeriodTb
            // 
            this.MaxProvisionPeriodTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxProvisionPeriodTb.Index = 19;
            this.MaxProvisionPeriodTb.Location = new System.Drawing.Point(167, 422);
            this.MaxProvisionPeriodTb.Name = "MaxProvisionPeriodTb";
            this.MaxProvisionPeriodTb.NotifyChanges = false;
            this.MaxProvisionPeriodTb.Size = new System.Drawing.Size(192, 20);
            this.MaxProvisionPeriodTb.TabIndex = 71;
            this.MaxProvisionPeriodTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // MaxProvisionPeriodLbl
            // 
            this.MaxProvisionPeriodLbl.AutoSize = true;
            this.MaxProvisionPeriodLbl.Location = new System.Drawing.Point(7, 425);
            this.MaxProvisionPeriodLbl.Name = "MaxProvisionPeriodLbl";
            this.MaxProvisionPeriodLbl.Size = new System.Drawing.Size(109, 13);
            this.MaxProvisionPeriodLbl.TabIndex = 70;
            this.MaxProvisionPeriodLbl.Text = "Max Provision Period:";
            // 
            // MaxProvisionTb
            // 
            this.MaxProvisionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxProvisionTb.Index = 18;
            this.MaxProvisionTb.Location = new System.Drawing.Point(167, 396);
            this.MaxProvisionTb.Name = "MaxProvisionTb";
            this.MaxProvisionTb.NotifyChanges = false;
            this.MaxProvisionTb.Size = new System.Drawing.Size(192, 20);
            this.MaxProvisionTb.TabIndex = 69;
            this.MaxProvisionTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // MaxProvisionLbl
            // 
            this.MaxProvisionLbl.AutoSize = true;
            this.MaxProvisionLbl.Location = new System.Drawing.Point(7, 399);
            this.MaxProvisionLbl.Name = "MaxProvisionLbl";
            this.MaxProvisionLbl.Size = new System.Drawing.Size(76, 13);
            this.MaxProvisionLbl.TabIndex = 68;
            this.MaxProvisionLbl.Text = "Max Provision:";
            // 
            // NextCreditAvailableThresholdTb
            // 
            this.NextCreditAvailableThresholdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextCreditAvailableThresholdTb.Index = 17;
            this.NextCreditAvailableThresholdTb.Location = new System.Drawing.Point(167, 370);
            this.NextCreditAvailableThresholdTb.Name = "NextCreditAvailableThresholdTb";
            this.NextCreditAvailableThresholdTb.NotifyChanges = false;
            this.NextCreditAvailableThresholdTb.Size = new System.Drawing.Size(192, 20);
            this.NextCreditAvailableThresholdTb.TabIndex = 67;
            this.NextCreditAvailableThresholdTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // NextCreditAvailableThresholdLbl
            // 
            this.NextCreditAvailableThresholdLbl.AutoSize = true;
            this.NextCreditAvailableThresholdLbl.Location = new System.Drawing.Point(7, 373);
            this.NextCreditAvailableThresholdLbl.Name = "NextCreditAvailableThresholdLbl";
            this.NextCreditAvailableThresholdLbl.Size = new System.Drawing.Size(158, 13);
            this.NextCreditAvailableThresholdLbl.TabIndex = 66;
            this.NextCreditAvailableThresholdLbl.Text = "Next Credit Available Threshold:";
            // 
            // LowCreditThresholdTb
            // 
            this.LowCreditThresholdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LowCreditThresholdTb.Index = 16;
            this.LowCreditThresholdTb.Location = new System.Drawing.Point(168, 344);
            this.LowCreditThresholdTb.Name = "LowCreditThresholdTb";
            this.LowCreditThresholdTb.NotifyChanges = false;
            this.LowCreditThresholdTb.Size = new System.Drawing.Size(192, 20);
            this.LowCreditThresholdTb.TabIndex = 65;
            this.LowCreditThresholdTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LowCreditThresholdLbl
            // 
            this.LowCreditThresholdLbl.AutoSize = true;
            this.LowCreditThresholdLbl.Location = new System.Drawing.Point(8, 347);
            this.LowCreditThresholdLbl.Name = "LowCreditThresholdLbl";
            this.LowCreditThresholdLbl.Size = new System.Drawing.Size(110, 13);
            this.LowCreditThresholdLbl.TabIndex = 64;
            this.LowCreditThresholdLbl.Text = "Low Credit Threshold:";
            // 
            // CurrencyUnitLbl
            // 
            this.CurrencyUnitLbl.AutoSize = true;
            this.CurrencyUnitLbl.Location = new System.Drawing.Point(7, 321);
            this.CurrencyUnitLbl.Name = "CurrencyUnitLbl";
            this.CurrencyUnitLbl.Size = new System.Drawing.Size(74, 13);
            this.CurrencyUnitLbl.TabIndex = 62;
            this.CurrencyUnitLbl.Text = "Currency Unit:";
            // 
            // CurrencyScaleLbl
            // 
            this.CurrencyScaleLbl.AutoSize = true;
            this.CurrencyScaleLbl.Location = new System.Drawing.Point(7, 295);
            this.CurrencyScaleLbl.Name = "CurrencyScaleLbl";
            this.CurrencyScaleLbl.Size = new System.Drawing.Size(82, 13);
            this.CurrencyScaleLbl.TabIndex = 60;
            this.CurrencyScaleLbl.Text = "Currency Scale:";
            // 
            // CurrencyNameLbl
            // 
            this.CurrencyNameLbl.AutoSize = true;
            this.CurrencyNameLbl.Location = new System.Drawing.Point(8, 269);
            this.CurrencyNameLbl.Name = "CurrencyNameLbl";
            this.CurrencyNameLbl.Size = new System.Drawing.Size(83, 13);
            this.CurrencyNameLbl.TabIndex = 58;
            this.CurrencyNameLbl.Text = "Currency Name:";
            // 
            // AccountClosureTimeTb
            // 
            this.AccountClosureTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountClosureTimeTb.Index = 14;
            this.AccountClosureTimeTb.Location = new System.Drawing.Point(168, 240);
            this.AccountClosureTimeTb.Name = "AccountClosureTimeTb";
            this.AccountClosureTimeTb.NotifyChanges = false;
            this.AccountClosureTimeTb.Size = new System.Drawing.Size(192, 20);
            this.AccountClosureTimeTb.TabIndex = 56;
            this.AccountClosureTimeTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // AccountClosureTimeLbl
            // 
            this.AccountClosureTimeLbl.AutoSize = true;
            this.AccountClosureTimeLbl.Location = new System.Drawing.Point(7, 243);
            this.AccountClosureTimeLbl.Name = "AccountClosureTimeLbl";
            this.AccountClosureTimeLbl.Size = new System.Drawing.Size(114, 13);
            this.AccountClosureTimeLbl.TabIndex = 57;
            this.AccountClosureTimeLbl.Text = "Account Closure Time:";
            // 
            // AccountActivationTimeTb
            // 
            this.AccountActivationTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountActivationTimeTb.Index = 13;
            this.AccountActivationTimeTb.Location = new System.Drawing.Point(168, 214);
            this.AccountActivationTimeTb.Name = "AccountActivationTimeTb";
            this.AccountActivationTimeTb.NotifyChanges = false;
            this.AccountActivationTimeTb.Size = new System.Drawing.Size(192, 20);
            this.AccountActivationTimeTb.TabIndex = 54;
            this.AccountActivationTimeTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // AccountActivationTimeLbl
            // 
            this.AccountActivationTimeLbl.AutoSize = true;
            this.AccountActivationTimeLbl.Location = new System.Drawing.Point(7, 217);
            this.AccountActivationTimeLbl.Name = "AccountActivationTimeLbl";
            this.AccountActivationTimeLbl.Size = new System.Drawing.Size(126, 13);
            this.AccountActivationTimeLbl.TabIndex = 55;
            this.AccountActivationTimeLbl.Text = "Account Activation Time:";
            // 
            // AggregatedDebtTb
            // 
            this.AggregatedDebtTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AggregatedDebtTb.Index = 8;
            this.AggregatedDebtTb.Location = new System.Drawing.Point(168, 188);
            this.AggregatedDebtTb.Name = "AggregatedDebtTb";
            this.AggregatedDebtTb.NotifyChanges = false;
            this.AggregatedDebtTb.Size = new System.Drawing.Size(192, 20);
            this.AggregatedDebtTb.TabIndex = 52;
            this.AggregatedDebtTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // AggregatedDebtLbl
            // 
            this.AggregatedDebtLbl.AutoSize = true;
            this.AggregatedDebtLbl.Location = new System.Drawing.Point(7, 191);
            this.AggregatedDebtLbl.Name = "AggregatedDebtLbl";
            this.AggregatedDebtLbl.Size = new System.Drawing.Size(91, 13);
            this.AggregatedDebtLbl.TabIndex = 53;
            this.AggregatedDebtLbl.Text = "Aggregated Debt:";
            // 
            // ClearanceThresholdTb
            // 
            this.ClearanceThresholdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearanceThresholdTb.Index = 7;
            this.ClearanceThresholdTb.Location = new System.Drawing.Point(168, 162);
            this.ClearanceThresholdTb.Name = "ClearanceThresholdTb";
            this.ClearanceThresholdTb.NotifyChanges = false;
            this.ClearanceThresholdTb.Size = new System.Drawing.Size(192, 20);
            this.ClearanceThresholdTb.TabIndex = 50;
            this.ClearanceThresholdTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ClearanceThresholdLbl
            // 
            this.ClearanceThresholdLbl.AutoSize = true;
            this.ClearanceThresholdLbl.Location = new System.Drawing.Point(7, 165);
            this.ClearanceThresholdLbl.Name = "ClearanceThresholdLbl";
            this.ClearanceThresholdLbl.Size = new System.Drawing.Size(108, 13);
            this.ClearanceThresholdLbl.TabIndex = 51;
            this.ClearanceThresholdLbl.Text = "Clearance Threshold:";
            // 
            // AmountToClearTb
            // 
            this.AmountToClearTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountToClearTb.Index = 6;
            this.AmountToClearTb.Location = new System.Drawing.Point(168, 136);
            this.AmountToClearTb.Name = "AmountToClearTb";
            this.AmountToClearTb.NotifyChanges = false;
            this.AmountToClearTb.Size = new System.Drawing.Size(192, 20);
            this.AmountToClearTb.TabIndex = 48;
            this.AmountToClearTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // AmountToClearLbl
            // 
            this.AmountToClearLbl.AutoSize = true;
            this.AmountToClearLbl.Location = new System.Drawing.Point(7, 139);
            this.AmountToClearLbl.Name = "AmountToClearLbl";
            this.AmountToClearLbl.Size = new System.Drawing.Size(89, 13);
            this.AmountToClearLbl.TabIndex = 49;
            this.AmountToClearLbl.Text = "Amount To Clear:";
            // 
            // AvailableCreditTb
            // 
            this.AvailableCreditTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableCreditTb.Index = 5;
            this.AvailableCreditTb.Location = new System.Drawing.Point(167, 110);
            this.AvailableCreditTb.Name = "AvailableCreditTb";
            this.AvailableCreditTb.NotifyChanges = false;
            this.AvailableCreditTb.Size = new System.Drawing.Size(192, 20);
            this.AvailableCreditTb.TabIndex = 46;
            this.AvailableCreditTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // AvailableCreditLbl
            // 
            this.AvailableCreditLbl.AutoSize = true;
            this.AvailableCreditLbl.Location = new System.Drawing.Point(6, 113);
            this.AvailableCreditLbl.Name = "AvailableCreditLbl";
            this.AvailableCreditLbl.Size = new System.Drawing.Size(83, 13);
            this.AvailableCreditLbl.TabIndex = 47;
            this.AvailableCreditLbl.Text = "Available Credit:";
            // 
            // CurrentCreditStatusTb
            // 
            this.CurrentCreditStatusTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCreditStatusTb.Index = 4;
            this.CurrentCreditStatusTb.Location = new System.Drawing.Point(167, 84);
            this.CurrentCreditStatusTb.Name = "CurrentCreditStatusTb";
            this.CurrentCreditStatusTb.NotifyChanges = false;
            this.CurrentCreditStatusTb.Size = new System.Drawing.Size(192, 20);
            this.CurrentCreditStatusTb.TabIndex = 44;
            this.CurrentCreditStatusTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // CurrentCreditStatusLbl
            // 
            this.CurrentCreditStatusLbl.AutoSize = true;
            this.CurrentCreditStatusLbl.Location = new System.Drawing.Point(6, 87);
            this.CurrentCreditStatusLbl.Name = "CurrentCreditStatusLbl";
            this.CurrentCreditStatusLbl.Size = new System.Drawing.Size(107, 13);
            this.CurrentCreditStatusLbl.TabIndex = 45;
            this.CurrentCreditStatusLbl.Text = "Current Credit Status:";
            // 
            // CurrentCreditInUseTb
            // 
            this.CurrentCreditInUseTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCreditInUseTb.Index = 3;
            this.CurrentCreditInUseTb.Location = new System.Drawing.Point(167, 58);
            this.CurrentCreditInUseTb.Name = "CurrentCreditInUseTb";
            this.CurrentCreditInUseTb.NotifyChanges = false;
            this.CurrentCreditInUseTb.Size = new System.Drawing.Size(192, 20);
            this.CurrentCreditInUseTb.TabIndex = 42;
            this.CurrentCreditInUseTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            this.CurrentCreditInUseTb.Load += new System.EventHandler(this.CurrentCreditInUseTb_Load);
            // 
            // CurrentCreditInUseLbl
            // 
            this.CurrentCreditInUseLbl.AutoSize = true;
            this.CurrentCreditInUseLbl.Location = new System.Drawing.Point(6, 61);
            this.CurrentCreditInUseLbl.Name = "CurrentCreditInUseLbl";
            this.CurrentCreditInUseLbl.Size = new System.Drawing.Size(108, 13);
            this.CurrentCreditInUseLbl.TabIndex = 43;
            this.CurrentCreditInUseLbl.Text = "Current Credit In Use:";
            // 
            // AccountStatusLbl
            // 
            this.AccountStatusLbl.AutoSize = true;
            this.AccountStatusLbl.Location = new System.Drawing.Point(7, 35);
            this.AccountStatusLbl.Name = "AccountStatusLbl";
            this.AccountStatusLbl.Size = new System.Drawing.Size(40, 13);
            this.AccountStatusLbl.TabIndex = 41;
            this.AccountStatusLbl.Text = "Status:";
            // 
            // PaymentModeLbl
            // 
            this.PaymentModeLbl.AutoSize = true;
            this.PaymentModeLbl.Location = new System.Drawing.Point(7, 9);
            this.PaymentModeLbl.Name = "PaymentModeLbl";
            this.PaymentModeLbl.Size = new System.Drawing.Size(81, 13);
            this.PaymentModeLbl.TabIndex = 40;
            this.PaymentModeLbl.Text = "Payment Mode:";
            // 
            // CreditReferenceTab
            // 
            this.CreditReferenceTab.Controls.Add(this.CreditReferenceRemove);
            this.CreditReferenceTab.Controls.Add(this.CreditReferenceEdit);
            this.CreditReferenceTab.Controls.Add(this.CreditReferenceAdd);
            this.CreditReferenceTab.Controls.Add(this.CreditReferenceView);
            this.CreditReferenceTab.Location = new System.Drawing.Point(4, 22);
            this.CreditReferenceTab.Name = "CreditReferenceTab";
            this.CreditReferenceTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreditReferenceTab.Size = new System.Drawing.Size(371, 461);
            this.CreditReferenceTab.TabIndex = 1;
            this.CreditReferenceTab.Text = "Credit reference";
            this.CreditReferenceTab.UseVisualStyleBackColor = true;
            // 
            // CreditReferenceRemove
            // 
            this.CreditReferenceRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditReferenceRemove.Location = new System.Drawing.Point(290, 416);
            this.CreditReferenceRemove.Name = "CreditReferenceRemove";
            this.CreditReferenceRemove.Size = new System.Drawing.Size(75, 23);
            this.CreditReferenceRemove.TabIndex = 23;
            this.CreditReferenceRemove.Text = "Remove";
            this.CreditReferenceRemove.UseVisualStyleBackColor = true;
            // 
            // CreditReferenceEdit
            // 
            this.CreditReferenceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditReferenceEdit.Location = new System.Drawing.Point(209, 416);
            this.CreditReferenceEdit.Name = "CreditReferenceEdit";
            this.CreditReferenceEdit.Size = new System.Drawing.Size(75, 23);
            this.CreditReferenceEdit.TabIndex = 22;
            this.CreditReferenceEdit.Text = "Edit...";
            this.CreditReferenceEdit.UseVisualStyleBackColor = true;
            // 
            // CreditReferenceAdd
            // 
            this.CreditReferenceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditReferenceAdd.Location = new System.Drawing.Point(128, 416);
            this.CreditReferenceAdd.Name = "CreditReferenceAdd";
            this.CreditReferenceAdd.Size = new System.Drawing.Size(75, 23);
            this.CreditReferenceAdd.TabIndex = 21;
            this.CreditReferenceAdd.Text = "Add...";
            this.CreditReferenceAdd.UseVisualStyleBackColor = true;
            // 
            // CreditReferenceView
            // 
            this.CreditReferenceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditReferenceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader});
            this.CreditReferenceView.FullRowSelect = true;
            this.CreditReferenceView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CreditReferenceView.HideSelection = false;
            this.CreditReferenceView.Location = new System.Drawing.Point(6, 6);
            this.CreditReferenceView.Name = "CreditReferenceView";
            this.CreditReferenceView.Size = new System.Drawing.Size(359, 404);
            this.CreditReferenceView.TabIndex = 18;
            this.CreditReferenceView.UseCompatibleStateImageBehavior = false;
            this.CreditReferenceView.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 315;
            // 
            // ChargeReferenceTab
            // 
            this.ChargeReferenceTab.Controls.Add(this.ChargeReferenceRemove);
            this.ChargeReferenceTab.Controls.Add(this.ChargeReferenceEdit);
            this.ChargeReferenceTab.Controls.Add(this.ChargeReferenceAdd);
            this.ChargeReferenceTab.Controls.Add(this.ChargeReferenceView);
            this.ChargeReferenceTab.Location = new System.Drawing.Point(4, 22);
            this.ChargeReferenceTab.Name = "ChargeReferenceTab";
            this.ChargeReferenceTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChargeReferenceTab.Size = new System.Drawing.Size(371, 461);
            this.ChargeReferenceTab.TabIndex = 2;
            this.ChargeReferenceTab.Text = "Charge Reference";
            this.ChargeReferenceTab.UseVisualStyleBackColor = true;
            // 
            // ChargeReferenceRemove
            // 
            this.ChargeReferenceRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeReferenceRemove.Location = new System.Drawing.Point(290, 416);
            this.ChargeReferenceRemove.Name = "ChargeReferenceRemove";
            this.ChargeReferenceRemove.Size = new System.Drawing.Size(75, 23);
            this.ChargeReferenceRemove.TabIndex = 27;
            this.ChargeReferenceRemove.Text = "Remove";
            this.ChargeReferenceRemove.UseVisualStyleBackColor = true;
            // 
            // ChargeReferenceEdit
            // 
            this.ChargeReferenceEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeReferenceEdit.Location = new System.Drawing.Point(209, 416);
            this.ChargeReferenceEdit.Name = "ChargeReferenceEdit";
            this.ChargeReferenceEdit.Size = new System.Drawing.Size(75, 23);
            this.ChargeReferenceEdit.TabIndex = 26;
            this.ChargeReferenceEdit.Text = "Edit...";
            this.ChargeReferenceEdit.UseVisualStyleBackColor = true;
            // 
            // ChargeReferenceAdd
            // 
            this.ChargeReferenceAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeReferenceAdd.Location = new System.Drawing.Point(128, 416);
            this.ChargeReferenceAdd.Name = "ChargeReferenceAdd";
            this.ChargeReferenceAdd.Size = new System.Drawing.Size(75, 23);
            this.ChargeReferenceAdd.TabIndex = 25;
            this.ChargeReferenceAdd.Text = "Add...";
            this.ChargeReferenceAdd.UseVisualStyleBackColor = true;
            // 
            // ChargeReferenceView
            // 
            this.ChargeReferenceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChargeReferenceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChargeReferenceNameCh});
            this.ChargeReferenceView.FullRowSelect = true;
            this.ChargeReferenceView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ChargeReferenceView.HideSelection = false;
            this.ChargeReferenceView.Location = new System.Drawing.Point(6, 6);
            this.ChargeReferenceView.Name = "ChargeReferenceView";
            this.ChargeReferenceView.Size = new System.Drawing.Size(359, 404);
            this.ChargeReferenceView.TabIndex = 24;
            this.ChargeReferenceView.UseCompatibleStateImageBehavior = false;
            this.ChargeReferenceView.View = System.Windows.Forms.View.Details;
            // 
            // ChargeReferenceNameCh
            // 
            this.ChargeReferenceNameCh.Text = "Name";
            this.ChargeReferenceNameCh.Width = 91;
            // 
            // CreditChargeTab
            // 
            this.CreditChargeTab.Controls.Add(this.CreditChargeRemove);
            this.CreditChargeTab.Controls.Add(this.CreditChargeEdit);
            this.CreditChargeTab.Controls.Add(this.CreditChargeAdd);
            this.CreditChargeTab.Controls.Add(this.CreditChargeView);
            this.CreditChargeTab.Location = new System.Drawing.Point(4, 22);
            this.CreditChargeTab.Name = "CreditChargeTab";
            this.CreditChargeTab.Size = new System.Drawing.Size(371, 461);
            this.CreditChargeTab.TabIndex = 3;
            this.CreditChargeTab.Text = "Credit Charge";
            this.CreditChargeTab.UseVisualStyleBackColor = true;
            // 
            // CreditChargeRemove
            // 
            this.CreditChargeRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditChargeRemove.Location = new System.Drawing.Point(287, 413);
            this.CreditChargeRemove.Name = "CreditChargeRemove";
            this.CreditChargeRemove.Size = new System.Drawing.Size(75, 23);
            this.CreditChargeRemove.TabIndex = 27;
            this.CreditChargeRemove.Text = "Remove";
            this.CreditChargeRemove.UseVisualStyleBackColor = true;
            // 
            // CreditChargeEdit
            // 
            this.CreditChargeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditChargeEdit.Location = new System.Drawing.Point(206, 413);
            this.CreditChargeEdit.Name = "CreditChargeEdit";
            this.CreditChargeEdit.Size = new System.Drawing.Size(75, 23);
            this.CreditChargeEdit.TabIndex = 26;
            this.CreditChargeEdit.Text = "Edit...";
            this.CreditChargeEdit.UseVisualStyleBackColor = true;
            // 
            // CreditChargeAdd
            // 
            this.CreditChargeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditChargeAdd.Location = new System.Drawing.Point(125, 413);
            this.CreditChargeAdd.Name = "CreditChargeAdd";
            this.CreditChargeAdd.Size = new System.Drawing.Size(75, 23);
            this.CreditChargeAdd.TabIndex = 25;
            this.CreditChargeAdd.Text = "Add...";
            this.CreditChargeAdd.UseVisualStyleBackColor = true;
            // 
            // CreditChargeView
            // 
            this.CreditChargeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditChargeView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CreditCh,
            this.ChargeCh,
            this.ConfigurationCh});
            this.CreditChargeView.FullRowSelect = true;
            this.CreditChargeView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CreditChargeView.HideSelection = false;
            this.CreditChargeView.Location = new System.Drawing.Point(3, 3);
            this.CreditChargeView.Name = "CreditChargeView";
            this.CreditChargeView.Size = new System.Drawing.Size(359, 404);
            this.CreditChargeView.TabIndex = 24;
            this.CreditChargeView.UseCompatibleStateImageBehavior = false;
            this.CreditChargeView.View = System.Windows.Forms.View.Details;
            // 
            // CreditCh
            // 
            this.CreditCh.Text = "Credit";
            this.CreditCh.Width = 91;
            // 
            // ChargeCh
            // 
            this.ChargeCh.Text = "Charge";
            this.ChargeCh.Width = 114;
            // 
            // ConfigurationCh
            // 
            this.ConfigurationCh.Text = "Configuration";
            this.ConfigurationCh.Width = 218;
            // 
            // TokenGatewayTab
            // 
            this.TokenGatewayTab.Controls.Add(this.TokenGatewayRemove);
            this.TokenGatewayTab.Controls.Add(this.TokenGatewayEdit);
            this.TokenGatewayTab.Controls.Add(this.TokenGatewayAdd);
            this.TokenGatewayTab.Controls.Add(this.TokenGatewayView);
            this.TokenGatewayTab.Location = new System.Drawing.Point(4, 22);
            this.TokenGatewayTab.Name = "TokenGatewayTab";
            this.TokenGatewayTab.Size = new System.Drawing.Size(371, 461);
            this.TokenGatewayTab.TabIndex = 4;
            this.TokenGatewayTab.Text = "Token Gateway";
            this.TokenGatewayTab.UseVisualStyleBackColor = true;
            // 
            // TokenGatewayRemove
            // 
            this.TokenGatewayRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenGatewayRemove.Location = new System.Drawing.Point(287, 413);
            this.TokenGatewayRemove.Name = "TokenGatewayRemove";
            this.TokenGatewayRemove.Size = new System.Drawing.Size(75, 23);
            this.TokenGatewayRemove.TabIndex = 27;
            this.TokenGatewayRemove.Text = "Remove";
            this.TokenGatewayRemove.UseVisualStyleBackColor = true;
            // 
            // TokenGatewayEdit
            // 
            this.TokenGatewayEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenGatewayEdit.Location = new System.Drawing.Point(206, 413);
            this.TokenGatewayEdit.Name = "TokenGatewayEdit";
            this.TokenGatewayEdit.Size = new System.Drawing.Size(75, 23);
            this.TokenGatewayEdit.TabIndex = 26;
            this.TokenGatewayEdit.Text = "Edit...";
            this.TokenGatewayEdit.UseVisualStyleBackColor = true;
            // 
            // TokenGatewayAdd
            // 
            this.TokenGatewayAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenGatewayAdd.Location = new System.Drawing.Point(125, 413);
            this.TokenGatewayAdd.Name = "TokenGatewayAdd";
            this.TokenGatewayAdd.Size = new System.Drawing.Size(75, 23);
            this.TokenGatewayAdd.TabIndex = 25;
            this.TokenGatewayAdd.Text = "Add...";
            this.TokenGatewayAdd.UseVisualStyleBackColor = true;
            // 
            // TokenGatewayView
            // 
            this.TokenGatewayView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenGatewayView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.TokenGatewayView.FullRowSelect = true;
            this.TokenGatewayView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TokenGatewayView.HideSelection = false;
            this.TokenGatewayView.Location = new System.Drawing.Point(3, 3);
            this.TokenGatewayView.Name = "TokenGatewayView";
            this.TokenGatewayView.Size = new System.Drawing.Size(359, 404);
            this.TokenGatewayView.TabIndex = 24;
            this.TokenGatewayView.UseCompatibleStateImageBehavior = false;
            this.TokenGatewayView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Start";
            this.columnHeader8.Width = 114;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Week Name";
            this.columnHeader9.Width = 218;
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
            this.DescriptionTB.Location = new System.Drawing.Point(167, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(208, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(167, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(207, 20);
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
            // GXDLMSAccountView
            // 
            this.ClientSize = new System.Drawing.Size(420, 678);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSAccountView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.GeneralTab.ResumeLayout(false);
            this.GeneralTab.PerformLayout();
            this.CreditReferenceTab.ResumeLayout(false);
            this.ChargeReferenceTab.ResumeLayout(false);
            this.CreditChargeTab.ResumeLayout(false);
            this.TokenGatewayTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage GeneralTab;
        private GXValueField MaxProvisionPeriodTb;
        private Label MaxProvisionPeriodLbl;
        private GXValueField MaxProvisionTb;
        private Label MaxProvisionLbl;
        private GXValueField NextCreditAvailableThresholdTb;
        private Label NextCreditAvailableThresholdLbl;
        private GXValueField LowCreditThresholdTb;
        private Label LowCreditThresholdLbl;
        private Label CurrencyUnitLbl;
        private Label CurrencyScaleLbl;
        private Label CurrencyNameLbl;
        private GXValueField AccountClosureTimeTb;
        private Label AccountClosureTimeLbl;
        private GXValueField AccountActivationTimeTb;
        private Label AccountActivationTimeLbl;
        private GXValueField AggregatedDebtTb;
        private Label AggregatedDebtLbl;
        private GXValueField ClearanceThresholdTb;
        private Label ClearanceThresholdLbl;
        private GXValueField AmountToClearTb;
        private Label AmountToClearLbl;
        private GXValueField AvailableCreditTb;
        private Label AvailableCreditLbl;
        private GXValueField CurrentCreditStatusTb;
        private Label CurrentCreditStatusLbl;
        private GXValueField CurrentCreditInUseTb;
        private Label CurrentCreditInUseLbl;
        private Label AccountStatusLbl;
        private Label PaymentModeLbl;
        private TabPage CreditReferenceTab;
        private TabPage ChargeReferenceTab;
        private TabPage CreditChargeTab;
        private TabPage TokenGatewayTab;
        private ListView CreditReferenceView;
        private ColumnHeader NameHeader;
        private Button CreditReferenceRemove;
        private Button CreditReferenceEdit;
        private Button CreditReferenceAdd;
        private Button ChargeReferenceRemove;
        private Button ChargeReferenceEdit;
        private Button ChargeReferenceAdd;
        private ListView ChargeReferenceView;
        private ColumnHeader ChargeReferenceNameCh;
        private Button CreditChargeRemove;
        private Button CreditChargeEdit;
        private Button CreditChargeAdd;
        private ListView CreditChargeView;
        private ColumnHeader CreditCh;
        private ColumnHeader ChargeCh;
        private ColumnHeader ConfigurationCh;
        private Button TokenGatewayRemove;
        private Button TokenGatewayEdit;
        private Button TokenGatewayAdd;
        private ListView TokenGatewayView;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private TextBox CurrencyUnitTb;
        private TextBox CurrencyScaleTb;
        private TextBox CurrencyNameTb;
        private ComboBox AccountStatusCb;
        private ComboBox PaymentModeCb;
    }
}
