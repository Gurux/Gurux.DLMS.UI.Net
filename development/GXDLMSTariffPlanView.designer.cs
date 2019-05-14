using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSTariffPlanView
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
        private GXValueField CalendarNameTb;
        private Label CalendarNameLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSTariffPlanView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SpecialDaysLv = new System.Windows.Forms.ListView();
            this.SpecialDaysCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeeklyActivationTb = new System.Windows.Forms.TextBox();
            this.WeeklyActivationLbl = new System.Windows.Forms.Label();
            this.DefaultTariffBandTb = new System.Windows.Forms.TextBox();
            this.DefaultTariffBandLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.WsWdIntervalTariff5Cb = new System.Windows.Forms.ComboBox();
            this.WsWdIntervalCb5 = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.WsWdStartHour5Tb = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.WsWdIntervalTariff4Cb = new System.Windows.Forms.ComboBox();
            this.WsWdIntervalCb4 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.WsWdStartHour4Tb = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.WsWdIntervalTariff3Cb = new System.Windows.Forms.ComboBox();
            this.WsWdIntervalCb3 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.WsWdStartHour3Tb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.WsWdIntervalTariff2Cb = new System.Windows.Forms.ComboBox();
            this.WsWdIntervalCb2 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.WsWdStartHour2Tb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WsWdIntervalTariff1Cb = new System.Windows.Forms.ComboBox();
            this.WsWdIntervalCb1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.WsWdStartHour1Tb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.WsSdIntervalTariff5Cb = new System.Windows.Forms.ComboBox();
            this.WsSdInterval5Cb = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.WsSiStartHour5Tb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.WsSdIntervalTariff4Cb = new System.Windows.Forms.ComboBox();
            this.WsSdInterval4Cb = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.WsSiStartHour4Tb = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.WsSdIntervalTariff3Cb = new System.Windows.Forms.ComboBox();
            this.WsSdInterval3Cb = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.WsSiStartHour3Tb = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.WsSdIntervalTariff2Cb = new System.Windows.Forms.ComboBox();
            this.WsSdInterval2Cb = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.WsSiStartHour2Tb = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.WsSdIntervalTariff1Cb = new System.Windows.Forms.ComboBox();
            this.WsSdInterval1Cb = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.WsSiStartHour1Tb = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.WsHdIntervalTariff5Cb = new System.Windows.Forms.ComboBox();
            this.WsHdInterval5Cb = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.WsHiStartHour5Tb = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.WsHdIntervalTariff4Cb = new System.Windows.Forms.ComboBox();
            this.WsHdInterval4Cb = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.WsHiStartHour4Tb = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.WsHdIntervalTariff3Cb = new System.Windows.Forms.ComboBox();
            this.WsHdInterval3Cb = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.WsHiStartHour3Tb = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.WsHdIntervalTariff2Cb = new System.Windows.Forms.ComboBox();
            this.WsHdInterval2Cb = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.WsHiStartHour2Tb = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.WsHdIntervalTariff1Cb = new System.Windows.Forms.ComboBox();
            this.WsHdInterval1Cb = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.WsHiStartHour1Tb = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.WinterDActivateTb = new System.Windows.Forms.TextBox();
            this.DayOfMonthLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HolidayTab = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SsWdIntervalTariff5Cb = new System.Windows.Forms.ComboBox();
            this.SsWdInterval5Cb = new System.Windows.Forms.CheckBox();
            this.label42 = new System.Windows.Forms.Label();
            this.SSWdStartHour5Tb = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.SsWdIntervalTariff4Cb = new System.Windows.Forms.ComboBox();
            this.SsWdInterval4Cb = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.SSWdStartHour4Tb = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.SsWdIntervalTariff3Cb = new System.Windows.Forms.ComboBox();
            this.SsWdInterval3Cb = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.SSWdStartHour3Tb = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.SsWdIntervalTariff2Cb = new System.Windows.Forms.ComboBox();
            this.SsWdInterval2Cb = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.SSWdStartHour2Tb = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.SsWdIntervalTariff1Cb = new System.Windows.Forms.ComboBox();
            this.SsWdInterval1Cb = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.SSWdStartHour1Tb = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.SsSdIntervalTariff5Cb = new System.Windows.Forms.ComboBox();
            this.SsSdInterval5Cb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SSSiStartHour5Tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SsSdIntervalTariff4Cb = new System.Windows.Forms.ComboBox();
            this.SsSdInterval4Cb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SSSiStartHour4Tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SsSdIntervalTariff3Cb = new System.Windows.Forms.ComboBox();
            this.SsSdInterval3Cb = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SSSiStartHour3Tb = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.SsSdIntervalTariff2Cb = new System.Windows.Forms.ComboBox();
            this.SsSdInterval2Cb = new System.Windows.Forms.CheckBox();
            this.label53 = new System.Windows.Forms.Label();
            this.SSSiStartHour2Tb = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.SsSdIntervalTariff1Cb = new System.Windows.Forms.ComboBox();
            this.SsSdInterval1Cb = new System.Windows.Forms.CheckBox();
            this.label55 = new System.Windows.Forms.Label();
            this.SSSiStartHour1Tb = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.SsHdIntervalTariff5Cb = new System.Windows.Forms.ComboBox();
            this.SsHdInterval5Cb = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SSHiStartHour5Tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SsHdIntervalTariff4Cb = new System.Windows.Forms.ComboBox();
            this.SsHdInterval4Cb = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SSHiStartHour4Tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SsHdIntervalTariff3Cb = new System.Windows.Forms.ComboBox();
            this.SsHdInterval3Cb = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SSHiStartHour3Tb = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.SsHdIntervalTariff2Cb = new System.Windows.Forms.ComboBox();
            this.SsHdInterval2Cb = new System.Windows.Forms.CheckBox();
            this.label58 = new System.Windows.Forms.Label();
            this.SSHiStartHour2Tb = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.SsHdIntervalTariff1Cb = new System.Windows.Forms.ComboBox();
            this.SsHdInterval1Cb = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.SSHiStartHour1Tb = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.SummerActivateTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivationTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.ActivationTimeLbl = new System.Windows.Forms.Label();
            this.EnabledLbl = new System.Windows.Forms.Label();
            this.EnabledCB = new System.Windows.Forms.CheckBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.CalendarNameTb = new Gurux.DLMS.UI.GXValueField();
            this.CalendarNameLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.HolidayTab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.ActivationTimeTb);
            this.groupBox1.Controls.Add(this.ActivationTimeLbl);
            this.groupBox1.Controls.Add(this.EnabledLbl);
            this.groupBox1.Controls.Add(this.EnabledCB);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.CalendarNameTb);
            this.groupBox1.Controls.Add(this.CalendarNameLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tariff Plan Object";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(10, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(515, 278);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tariff plan";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(494, 253);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RemoveBtn);
            this.tabPage1.Controls.Add(this.AddBtn);
            this.tabPage1.Controls.Add(this.SpecialDaysLv);
            this.tabPage1.Controls.Add(this.WeeklyActivationTb);
            this.tabPage1.Controls.Add(this.WeeklyActivationLbl);
            this.tabPage1.Controls.Add(this.DefaultTariffBandTb);
            this.tabPage1.Controls.Add(this.DefaultTariffBandLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(486, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Location = new System.Drawing.Point(396, 187);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 20;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(315, 187);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 19;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // SpecialDaysLv
            // 
            this.SpecialDaysLv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecialDaysLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SpecialDaysCh});
            this.SpecialDaysLv.FullRowSelect = true;
            this.SpecialDaysLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SpecialDaysLv.HideSelection = false;
            this.SpecialDaysLv.Location = new System.Drawing.Point(121, 62);
            this.SpecialDaysLv.Name = "SpecialDaysLv";
            this.SpecialDaysLv.Size = new System.Drawing.Size(359, 119);
            this.SpecialDaysLv.TabIndex = 18;
            this.SpecialDaysLv.UseCompatibleStateImageBehavior = false;
            this.SpecialDaysLv.View = System.Windows.Forms.View.Details;
            // 
            // SpecialDaysCh
            // 
            this.SpecialDaysCh.Text = "Special Days";
            this.SpecialDaysCh.Width = 129;
            // 
            // WeeklyActivationTb
            // 
            this.WeeklyActivationTb.Location = new System.Drawing.Point(121, 36);
            this.WeeklyActivationTb.Name = "WeeklyActivationTb";
            this.WeeklyActivationTb.Size = new System.Drawing.Size(294, 20);
            this.WeeklyActivationTb.TabIndex = 6;
            this.WeeklyActivationTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WeeklyActivationTb_KeyUp);
            this.WeeklyActivationTb.Leave += new System.EventHandler(this.WeeklyActivationTb_Leave);
            // 
            // WeeklyActivationLbl
            // 
            this.WeeklyActivationLbl.AutoSize = true;
            this.WeeklyActivationLbl.Location = new System.Drawing.Point(16, 39);
            this.WeeklyActivationLbl.Name = "WeeklyActivationLbl";
            this.WeeklyActivationLbl.Size = new System.Drawing.Size(96, 13);
            this.WeeklyActivationLbl.TabIndex = 5;
            this.WeeklyActivationLbl.Text = "Weekly Activation:";
            // 
            // DefaultTariffBandTb
            // 
            this.DefaultTariffBandTb.Location = new System.Drawing.Point(121, 10);
            this.DefaultTariffBandTb.Name = "DefaultTariffBandTb";
            this.DefaultTariffBandTb.Size = new System.Drawing.Size(294, 20);
            this.DefaultTariffBandTb.TabIndex = 4;
            this.DefaultTariffBandTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DefaultTariffBandTb_KeyUp);
            this.DefaultTariffBandTb.Leave += new System.EventHandler(this.DefaultTariffBandTb_Leave);
            // 
            // DefaultTariffBandLbl
            // 
            this.DefaultTariffBandLbl.AutoSize = true;
            this.DefaultTariffBandLbl.Location = new System.Drawing.Point(16, 13);
            this.DefaultTariffBandLbl.Name = "DefaultTariffBandLbl";
            this.DefaultTariffBandLbl.Size = new System.Drawing.Size(99, 13);
            this.DefaultTariffBandLbl.TabIndex = 3;
            this.DefaultTariffBandLbl.Text = "Default Tariff Band:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.WinterDActivateTb);
            this.tabPage2.Controls.Add(this.DayOfMonthLbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(486, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = " Winter season";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Controls.Add(this.tabPage9);
            this.tabControl2.Location = new System.Drawing.Point(15, 32);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(465, 176);
            this.tabControl2.TabIndex = 11;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.WsWdIntervalTariff5Cb);
            this.tabPage7.Controls.Add(this.WsWdIntervalCb5);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.WsWdStartHour5Tb);
            this.tabPage7.Controls.Add(this.label27);
            this.tabPage7.Controls.Add(this.WsWdIntervalTariff4Cb);
            this.tabPage7.Controls.Add(this.WsWdIntervalCb4);
            this.tabPage7.Controls.Add(this.label19);
            this.tabPage7.Controls.Add(this.WsWdStartHour4Tb);
            this.tabPage7.Controls.Add(this.label22);
            this.tabPage7.Controls.Add(this.WsWdIntervalTariff3Cb);
            this.tabPage7.Controls.Add(this.WsWdIntervalCb3);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.WsWdStartHour3Tb);
            this.tabPage7.Controls.Add(this.label17);
            this.tabPage7.Controls.Add(this.WsWdIntervalTariff2Cb);
            this.tabPage7.Controls.Add(this.WsWdIntervalCb2);
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.WsWdStartHour2Tb);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.WsWdIntervalTariff1Cb);
            this.tabPage7.Controls.Add(this.WsWdIntervalCb1);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.WsWdStartHour1Tb);
            this.tabPage7.Controls.Add(this.label16);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(457, 150);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Working Day Intervals";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // WsWdIntervalTariff5Cb
            // 
            this.WsWdIntervalTariff5Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsWdIntervalTariff5Cb.FormattingEnabled = true;
            this.WsWdIntervalTariff5Cb.Location = new System.Drawing.Point(320, 117);
            this.WsWdIntervalTariff5Cb.Name = "WsWdIntervalTariff5Cb";
            this.WsWdIntervalTariff5Cb.Size = new System.Drawing.Size(121, 21);
            this.WsWdIntervalTariff5Cb.TabIndex = 47;
            this.WsWdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsWdIntervalCb5
            // 
            this.WsWdIntervalCb5.Location = new System.Drawing.Point(15, 117);
            this.WsWdIntervalCb5.Name = "WsWdIntervalCb5";
            this.WsWdIntervalCb5.Size = new System.Drawing.Size(63, 19);
            this.WsWdIntervalCb5.TabIndex = 46;
            this.WsWdIntervalCb5.Text = "In use";
            this.WsWdIntervalCb5.UseVisualStyleBackColor = false;
            this.WsWdIntervalCb5.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(232, 119);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Interval Tariff:";
            // 
            // WsWdStartHour5Tb
            // 
            this.WsWdStartHour5Tb.Location = new System.Drawing.Point(166, 116);
            this.WsWdStartHour5Tb.Name = "WsWdStartHour5Tb";
            this.WsWdStartHour5Tb.Size = new System.Drawing.Size(47, 20);
            this.WsWdStartHour5Tb.TabIndex = 44;
            this.WsWdStartHour5Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsWdStartHourTb_KeyUp);
            this.WsWdStartHour5Tb.Leave += new System.EventHandler(this.WsWdStartHourTb_Leave);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(87, 119);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(58, 13);
            this.label27.TabIndex = 43;
            this.label27.Text = "Start Hour:";
            // 
            // WsWdIntervalTariff4Cb
            // 
            this.WsWdIntervalTariff4Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsWdIntervalTariff4Cb.FormattingEnabled = true;
            this.WsWdIntervalTariff4Cb.Location = new System.Drawing.Point(320, 91);
            this.WsWdIntervalTariff4Cb.Name = "WsWdIntervalTariff4Cb";
            this.WsWdIntervalTariff4Cb.Size = new System.Drawing.Size(121, 21);
            this.WsWdIntervalTariff4Cb.TabIndex = 42;
            this.WsWdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsWdIntervalCb4
            // 
            this.WsWdIntervalCb4.Location = new System.Drawing.Point(15, 91);
            this.WsWdIntervalCb4.Name = "WsWdIntervalCb4";
            this.WsWdIntervalCb4.Size = new System.Drawing.Size(63, 19);
            this.WsWdIntervalCb4.TabIndex = 41;
            this.WsWdIntervalCb4.Text = "In use";
            this.WsWdIntervalCb4.UseVisualStyleBackColor = false;
            this.WsWdIntervalCb4.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(232, 93);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Interval Tariff:";
            // 
            // WsWdStartHour4Tb
            // 
            this.WsWdStartHour4Tb.Location = new System.Drawing.Point(166, 90);
            this.WsWdStartHour4Tb.Name = "WsWdStartHour4Tb";
            this.WsWdStartHour4Tb.Size = new System.Drawing.Size(47, 20);
            this.WsWdStartHour4Tb.TabIndex = 39;
            this.WsWdStartHour4Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsWdStartHourTb_KeyUp);
            this.WsWdStartHour4Tb.Leave += new System.EventHandler(this.WsWdStartHourTb_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(87, 93);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 38;
            this.label22.Text = "Start Hour:";
            // 
            // WsWdIntervalTariff3Cb
            // 
            this.WsWdIntervalTariff3Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsWdIntervalTariff3Cb.FormattingEnabled = true;
            this.WsWdIntervalTariff3Cb.Location = new System.Drawing.Point(320, 65);
            this.WsWdIntervalTariff3Cb.Name = "WsWdIntervalTariff3Cb";
            this.WsWdIntervalTariff3Cb.Size = new System.Drawing.Size(121, 21);
            this.WsWdIntervalTariff3Cb.TabIndex = 37;
            this.WsWdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsWdIntervalCb3
            // 
            this.WsWdIntervalCb3.Location = new System.Drawing.Point(15, 65);
            this.WsWdIntervalCb3.Name = "WsWdIntervalCb3";
            this.WsWdIntervalCb3.Size = new System.Drawing.Size(63, 19);
            this.WsWdIntervalCb3.TabIndex = 36;
            this.WsWdIntervalCb3.Text = "In use";
            this.WsWdIntervalCb3.UseVisualStyleBackColor = false;
            this.WsWdIntervalCb3.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(232, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Interval Tariff:";
            // 
            // WsWdStartHour3Tb
            // 
            this.WsWdStartHour3Tb.Location = new System.Drawing.Point(166, 64);
            this.WsWdStartHour3Tb.Name = "WsWdStartHour3Tb";
            this.WsWdStartHour3Tb.Size = new System.Drawing.Size(47, 20);
            this.WsWdStartHour3Tb.TabIndex = 34;
            this.WsWdStartHour3Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsWdStartHourTb_KeyUp);
            this.WsWdStartHour3Tb.Leave += new System.EventHandler(this.WsWdStartHourTb_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(87, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Start Hour:";
            // 
            // WsWdIntervalTariff2Cb
            // 
            this.WsWdIntervalTariff2Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsWdIntervalTariff2Cb.FormattingEnabled = true;
            this.WsWdIntervalTariff2Cb.Location = new System.Drawing.Point(320, 39);
            this.WsWdIntervalTariff2Cb.Name = "WsWdIntervalTariff2Cb";
            this.WsWdIntervalTariff2Cb.Size = new System.Drawing.Size(121, 21);
            this.WsWdIntervalTariff2Cb.TabIndex = 32;
            this.WsWdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsWdIntervalCb2
            // 
            this.WsWdIntervalCb2.Location = new System.Drawing.Point(15, 39);
            this.WsWdIntervalCb2.Name = "WsWdIntervalCb2";
            this.WsWdIntervalCb2.Size = new System.Drawing.Size(63, 19);
            this.WsWdIntervalCb2.TabIndex = 31;
            this.WsWdIntervalCb2.Text = "In use";
            this.WsWdIntervalCb2.UseVisualStyleBackColor = false;
            this.WsWdIntervalCb2.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Interval Tariff:";
            // 
            // WsWdStartHour2Tb
            // 
            this.WsWdStartHour2Tb.Location = new System.Drawing.Point(166, 38);
            this.WsWdStartHour2Tb.Name = "WsWdStartHour2Tb";
            this.WsWdStartHour2Tb.Size = new System.Drawing.Size(47, 20);
            this.WsWdStartHour2Tb.TabIndex = 29;
            this.WsWdStartHour2Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsWdStartHourTb_KeyUp);
            this.WsWdStartHour2Tb.Leave += new System.EventHandler(this.WsWdStartHourTb_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Start Hour:";
            // 
            // WsWdIntervalTariff1Cb
            // 
            this.WsWdIntervalTariff1Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsWdIntervalTariff1Cb.FormattingEnabled = true;
            this.WsWdIntervalTariff1Cb.Location = new System.Drawing.Point(320, 13);
            this.WsWdIntervalTariff1Cb.Name = "WsWdIntervalTariff1Cb";
            this.WsWdIntervalTariff1Cb.Size = new System.Drawing.Size(121, 21);
            this.WsWdIntervalTariff1Cb.TabIndex = 27;
            this.WsWdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsWdIntervalCb1
            // 
            this.WsWdIntervalCb1.Location = new System.Drawing.Point(15, 13);
            this.WsWdIntervalCb1.Name = "WsWdIntervalCb1";
            this.WsWdIntervalCb1.Size = new System.Drawing.Size(63, 19);
            this.WsWdIntervalCb1.TabIndex = 25;
            this.WsWdIntervalCb1.Text = "In use";
            this.WsWdIntervalCb1.UseVisualStyleBackColor = false;
            this.WsWdIntervalCb1.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Interval Tariff:";
            // 
            // WsWdStartHour1Tb
            // 
            this.WsWdStartHour1Tb.Location = new System.Drawing.Point(166, 12);
            this.WsWdStartHour1Tb.Name = "WsWdStartHour1Tb";
            this.WsWdStartHour1Tb.Size = new System.Drawing.Size(47, 20);
            this.WsWdStartHour1Tb.TabIndex = 11;
            this.WsWdStartHour1Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsWdStartHourTb_KeyUp);
            this.WsWdStartHour1Tb.Leave += new System.EventHandler(this.WsWdStartHourTb_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Start Hour:";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.WsSdIntervalTariff5Cb);
            this.tabPage8.Controls.Add(this.WsSdInterval5Cb);
            this.tabPage8.Controls.Add(this.label18);
            this.tabPage8.Controls.Add(this.WsSiStartHour5Tb);
            this.tabPage8.Controls.Add(this.label20);
            this.tabPage8.Controls.Add(this.WsSdIntervalTariff4Cb);
            this.tabPage8.Controls.Add(this.WsSdInterval4Cb);
            this.tabPage8.Controls.Add(this.label21);
            this.tabPage8.Controls.Add(this.WsSiStartHour4Tb);
            this.tabPage8.Controls.Add(this.label28);
            this.tabPage8.Controls.Add(this.WsSdIntervalTariff3Cb);
            this.tabPage8.Controls.Add(this.WsSdInterval3Cb);
            this.tabPage8.Controls.Add(this.label29);
            this.tabPage8.Controls.Add(this.WsSiStartHour3Tb);
            this.tabPage8.Controls.Add(this.label30);
            this.tabPage8.Controls.Add(this.WsSdIntervalTariff2Cb);
            this.tabPage8.Controls.Add(this.WsSdInterval2Cb);
            this.tabPage8.Controls.Add(this.label31);
            this.tabPage8.Controls.Add(this.WsSiStartHour2Tb);
            this.tabPage8.Controls.Add(this.label32);
            this.tabPage8.Controls.Add(this.WsSdIntervalTariff1Cb);
            this.tabPage8.Controls.Add(this.WsSdInterval1Cb);
            this.tabPage8.Controls.Add(this.label33);
            this.tabPage8.Controls.Add(this.WsSiStartHour1Tb);
            this.tabPage8.Controls.Add(this.label34);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(457, 150);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Saturday Intervals";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // WsSdIntervalTariff5Cb
            // 
            this.WsSdIntervalTariff5Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsSdIntervalTariff5Cb.FormattingEnabled = true;
            this.WsSdIntervalTariff5Cb.Location = new System.Drawing.Point(320, 117);
            this.WsSdIntervalTariff5Cb.Name = "WsSdIntervalTariff5Cb";
            this.WsSdIntervalTariff5Cb.Size = new System.Drawing.Size(121, 21);
            this.WsSdIntervalTariff5Cb.TabIndex = 72;
            this.WsSdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsSdInterval5Cb
            // 
            this.WsSdInterval5Cb.Location = new System.Drawing.Point(15, 117);
            this.WsSdInterval5Cb.Name = "WsSdInterval5Cb";
            this.WsSdInterval5Cb.Size = new System.Drawing.Size(63, 19);
            this.WsSdInterval5Cb.TabIndex = 71;
            this.WsSdInterval5Cb.Text = "In use";
            this.WsSdInterval5Cb.UseVisualStyleBackColor = false;
            this.WsSdInterval5Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(232, 119);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 70;
            this.label18.Text = "Interval Tariff:";
            // 
            // WsSiStartHour5Tb
            // 
            this.WsSiStartHour5Tb.Location = new System.Drawing.Point(166, 116);
            this.WsSiStartHour5Tb.Name = "WsSiStartHour5Tb";
            this.WsSiStartHour5Tb.Size = new System.Drawing.Size(47, 20);
            this.WsSiStartHour5Tb.TabIndex = 69;
            this.WsSiStartHour5Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsSdStartHourTb_KeyUp);
            this.WsSiStartHour5Tb.Leave += new System.EventHandler(this.WsSdStartHourTb_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(87, 119);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 68;
            this.label20.Text = "Start Hour:";
            // 
            // WsSdIntervalTariff4Cb
            // 
            this.WsSdIntervalTariff4Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsSdIntervalTariff4Cb.FormattingEnabled = true;
            this.WsSdIntervalTariff4Cb.Location = new System.Drawing.Point(320, 91);
            this.WsSdIntervalTariff4Cb.Name = "WsSdIntervalTariff4Cb";
            this.WsSdIntervalTariff4Cb.Size = new System.Drawing.Size(121, 21);
            this.WsSdIntervalTariff4Cb.TabIndex = 67;
            this.WsSdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsSdInterval4Cb
            // 
            this.WsSdInterval4Cb.Location = new System.Drawing.Point(15, 91);
            this.WsSdInterval4Cb.Name = "WsSdInterval4Cb";
            this.WsSdInterval4Cb.Size = new System.Drawing.Size(63, 19);
            this.WsSdInterval4Cb.TabIndex = 66;
            this.WsSdInterval4Cb.Text = "In use";
            this.WsSdInterval4Cb.UseVisualStyleBackColor = false;
            this.WsSdInterval4Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(232, 93);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 65;
            this.label21.Text = "Interval Tariff:";
            // 
            // WsSiStartHour4Tb
            // 
            this.WsSiStartHour4Tb.Location = new System.Drawing.Point(166, 90);
            this.WsSiStartHour4Tb.Name = "WsSiStartHour4Tb";
            this.WsSiStartHour4Tb.Size = new System.Drawing.Size(47, 20);
            this.WsSiStartHour4Tb.TabIndex = 64;
            this.WsSiStartHour4Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsSdStartHourTb_KeyUp);
            this.WsSiStartHour4Tb.Leave += new System.EventHandler(this.WsSdStartHourTb_Leave);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(87, 93);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 13);
            this.label28.TabIndex = 63;
            this.label28.Text = "Start Hour:";
            // 
            // WsSdIntervalTariff3Cb
            // 
            this.WsSdIntervalTariff3Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsSdIntervalTariff3Cb.FormattingEnabled = true;
            this.WsSdIntervalTariff3Cb.Location = new System.Drawing.Point(320, 65);
            this.WsSdIntervalTariff3Cb.Name = "WsSdIntervalTariff3Cb";
            this.WsSdIntervalTariff3Cb.Size = new System.Drawing.Size(121, 21);
            this.WsSdIntervalTariff3Cb.TabIndex = 62;
            this.WsSdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsSdInterval3Cb
            // 
            this.WsSdInterval3Cb.Location = new System.Drawing.Point(15, 65);
            this.WsSdInterval3Cb.Name = "WsSdInterval3Cb";
            this.WsSdInterval3Cb.Size = new System.Drawing.Size(63, 19);
            this.WsSdInterval3Cb.TabIndex = 61;
            this.WsSdInterval3Cb.Text = "In use";
            this.WsSdInterval3Cb.UseVisualStyleBackColor = false;
            this.WsSdInterval3Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(232, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(72, 13);
            this.label29.TabIndex = 60;
            this.label29.Text = "Interval Tariff:";
            // 
            // WsSiStartHour3Tb
            // 
            this.WsSiStartHour3Tb.Location = new System.Drawing.Point(166, 64);
            this.WsSiStartHour3Tb.Name = "WsSiStartHour3Tb";
            this.WsSiStartHour3Tb.Size = new System.Drawing.Size(47, 20);
            this.WsSiStartHour3Tb.TabIndex = 59;
            this.WsSiStartHour3Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsSdStartHourTb_KeyUp);
            this.WsSiStartHour3Tb.Leave += new System.EventHandler(this.WsSdStartHourTb_Leave);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(87, 67);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 13);
            this.label30.TabIndex = 58;
            this.label30.Text = "Start Hour:";
            // 
            // WsSdIntervalTariff2Cb
            // 
            this.WsSdIntervalTariff2Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsSdIntervalTariff2Cb.FormattingEnabled = true;
            this.WsSdIntervalTariff2Cb.Location = new System.Drawing.Point(320, 39);
            this.WsSdIntervalTariff2Cb.Name = "WsSdIntervalTariff2Cb";
            this.WsSdIntervalTariff2Cb.Size = new System.Drawing.Size(121, 21);
            this.WsSdIntervalTariff2Cb.TabIndex = 57;
            this.WsSdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsSdInterval2Cb
            // 
            this.WsSdInterval2Cb.Location = new System.Drawing.Point(15, 39);
            this.WsSdInterval2Cb.Name = "WsSdInterval2Cb";
            this.WsSdInterval2Cb.Size = new System.Drawing.Size(63, 19);
            this.WsSdInterval2Cb.TabIndex = 56;
            this.WsSdInterval2Cb.Text = "In use";
            this.WsSdInterval2Cb.UseVisualStyleBackColor = false;
            this.WsSdInterval2Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(232, 41);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 13);
            this.label31.TabIndex = 55;
            this.label31.Text = "Interval Tariff:";
            // 
            // WsSiStartHour2Tb
            // 
            this.WsSiStartHour2Tb.Location = new System.Drawing.Point(166, 38);
            this.WsSiStartHour2Tb.Name = "WsSiStartHour2Tb";
            this.WsSiStartHour2Tb.Size = new System.Drawing.Size(47, 20);
            this.WsSiStartHour2Tb.TabIndex = 54;
            this.WsSiStartHour2Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsSdStartHourTb_KeyUp);
            this.WsSiStartHour2Tb.Leave += new System.EventHandler(this.WsSdStartHourTb_Leave);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(87, 41);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(58, 13);
            this.label32.TabIndex = 53;
            this.label32.Text = "Start Hour:";
            // 
            // WsSdIntervalTariff1Cb
            // 
            this.WsSdIntervalTariff1Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsSdIntervalTariff1Cb.FormattingEnabled = true;
            this.WsSdIntervalTariff1Cb.Location = new System.Drawing.Point(320, 13);
            this.WsSdIntervalTariff1Cb.Name = "WsSdIntervalTariff1Cb";
            this.WsSdIntervalTariff1Cb.Size = new System.Drawing.Size(121, 21);
            this.WsSdIntervalTariff1Cb.TabIndex = 52;
            this.WsSdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.WsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WsSdInterval1Cb
            // 
            this.WsSdInterval1Cb.Location = new System.Drawing.Point(15, 13);
            this.WsSdInterval1Cb.Name = "WsSdInterval1Cb";
            this.WsSdInterval1Cb.Size = new System.Drawing.Size(63, 19);
            this.WsSdInterval1Cb.TabIndex = 51;
            this.WsSdInterval1Cb.Text = "In use";
            this.WsSdInterval1Cb.UseVisualStyleBackColor = false;
            this.WsSdInterval1Cb.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(232, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(72, 13);
            this.label33.TabIndex = 50;
            this.label33.Text = "Interval Tariff:";
            // 
            // WsSiStartHour1Tb
            // 
            this.WsSiStartHour1Tb.Location = new System.Drawing.Point(166, 12);
            this.WsSiStartHour1Tb.Name = "WsSiStartHour1Tb";
            this.WsSiStartHour1Tb.Size = new System.Drawing.Size(47, 20);
            this.WsSiStartHour1Tb.TabIndex = 49;
            this.WsSiStartHour1Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsSdStartHourTb_KeyUp);
            this.WsSiStartHour1Tb.Leave += new System.EventHandler(this.WsSdStartHourTb_Leave);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(87, 15);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(58, 13);
            this.label34.TabIndex = 48;
            this.label34.Text = "Start Hour:";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.WsHdIntervalTariff5Cb);
            this.tabPage9.Controls.Add(this.WsHdInterval5Cb);
            this.tabPage9.Controls.Add(this.label23);
            this.tabPage9.Controls.Add(this.WsHiStartHour5Tb);
            this.tabPage9.Controls.Add(this.label25);
            this.tabPage9.Controls.Add(this.WsHdIntervalTariff4Cb);
            this.tabPage9.Controls.Add(this.WsHdInterval4Cb);
            this.tabPage9.Controls.Add(this.label26);
            this.tabPage9.Controls.Add(this.WsHiStartHour4Tb);
            this.tabPage9.Controls.Add(this.label35);
            this.tabPage9.Controls.Add(this.WsHdIntervalTariff3Cb);
            this.tabPage9.Controls.Add(this.WsHdInterval3Cb);
            this.tabPage9.Controls.Add(this.label36);
            this.tabPage9.Controls.Add(this.WsHiStartHour3Tb);
            this.tabPage9.Controls.Add(this.label37);
            this.tabPage9.Controls.Add(this.WsHdIntervalTariff2Cb);
            this.tabPage9.Controls.Add(this.WsHdInterval2Cb);
            this.tabPage9.Controls.Add(this.label38);
            this.tabPage9.Controls.Add(this.WsHiStartHour2Tb);
            this.tabPage9.Controls.Add(this.label39);
            this.tabPage9.Controls.Add(this.WsHdIntervalTariff1Cb);
            this.tabPage9.Controls.Add(this.WsHdInterval1Cb);
            this.tabPage9.Controls.Add(this.label40);
            this.tabPage9.Controls.Add(this.WsHiStartHour1Tb);
            this.tabPage9.Controls.Add(this.label41);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(457, 150);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Holiday Intervals";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // WsHdIntervalTariff5Cb
            // 
            this.WsHdIntervalTariff5Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsHdIntervalTariff5Cb.FormattingEnabled = true;
            this.WsHdIntervalTariff5Cb.Location = new System.Drawing.Point(320, 117);
            this.WsHdIntervalTariff5Cb.Name = "WsHdIntervalTariff5Cb";
            this.WsHdIntervalTariff5Cb.Size = new System.Drawing.Size(121, 21);
            this.WsHdIntervalTariff5Cb.TabIndex = 72;
            // 
            // WsHdInterval5Cb
            // 
            this.WsHdInterval5Cb.Location = new System.Drawing.Point(15, 117);
            this.WsHdInterval5Cb.Name = "WsHdInterval5Cb";
            this.WsHdInterval5Cb.Size = new System.Drawing.Size(63, 19);
            this.WsHdInterval5Cb.TabIndex = 71;
            this.WsHdInterval5Cb.Text = "In use";
            this.WsHdInterval5Cb.UseVisualStyleBackColor = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(232, 119);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 13);
            this.label23.TabIndex = 70;
            this.label23.Text = "Interval Tariff:";
            // 
            // WsHiStartHour5Tb
            // 
            this.WsHiStartHour5Tb.Location = new System.Drawing.Point(166, 116);
            this.WsHiStartHour5Tb.Name = "WsHiStartHour5Tb";
            this.WsHiStartHour5Tb.Size = new System.Drawing.Size(47, 20);
            this.WsHiStartHour5Tb.TabIndex = 69;
            this.WsHiStartHour5Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsHdStartHourTb_KeyUp);
            this.WsHiStartHour5Tb.Leave += new System.EventHandler(this.WsHdStartHourTb_Leave);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(87, 119);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 13);
            this.label25.TabIndex = 68;
            this.label25.Text = "Start Hour:";
            // 
            // WsHdIntervalTariff4Cb
            // 
            this.WsHdIntervalTariff4Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsHdIntervalTariff4Cb.FormattingEnabled = true;
            this.WsHdIntervalTariff4Cb.Location = new System.Drawing.Point(320, 91);
            this.WsHdIntervalTariff4Cb.Name = "WsHdIntervalTariff4Cb";
            this.WsHdIntervalTariff4Cb.Size = new System.Drawing.Size(121, 21);
            this.WsHdIntervalTariff4Cb.TabIndex = 67;
            // 
            // WsHdInterval4Cb
            // 
            this.WsHdInterval4Cb.Location = new System.Drawing.Point(15, 91);
            this.WsHdInterval4Cb.Name = "WsHdInterval4Cb";
            this.WsHdInterval4Cb.Size = new System.Drawing.Size(63, 19);
            this.WsHdInterval4Cb.TabIndex = 66;
            this.WsHdInterval4Cb.Text = "In use";
            this.WsHdInterval4Cb.UseVisualStyleBackColor = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(232, 93);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 13);
            this.label26.TabIndex = 65;
            this.label26.Text = "Interval Tariff:";
            // 
            // WsHiStartHour4Tb
            // 
            this.WsHiStartHour4Tb.Location = new System.Drawing.Point(166, 90);
            this.WsHiStartHour4Tb.Name = "WsHiStartHour4Tb";
            this.WsHiStartHour4Tb.Size = new System.Drawing.Size(47, 20);
            this.WsHiStartHour4Tb.TabIndex = 64;
            this.WsHiStartHour4Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsHdStartHourTb_KeyUp);
            this.WsHiStartHour4Tb.Leave += new System.EventHandler(this.WsHdStartHourTb_Leave);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(87, 93);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 13);
            this.label35.TabIndex = 63;
            this.label35.Text = "Start Hour:";
            // 
            // WsHdIntervalTariff3Cb
            // 
            this.WsHdIntervalTariff3Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsHdIntervalTariff3Cb.FormattingEnabled = true;
            this.WsHdIntervalTariff3Cb.Location = new System.Drawing.Point(320, 65);
            this.WsHdIntervalTariff3Cb.Name = "WsHdIntervalTariff3Cb";
            this.WsHdIntervalTariff3Cb.Size = new System.Drawing.Size(121, 21);
            this.WsHdIntervalTariff3Cb.TabIndex = 62;
            // 
            // WsHdInterval3Cb
            // 
            this.WsHdInterval3Cb.Location = new System.Drawing.Point(15, 65);
            this.WsHdInterval3Cb.Name = "WsHdInterval3Cb";
            this.WsHdInterval3Cb.Size = new System.Drawing.Size(63, 19);
            this.WsHdInterval3Cb.TabIndex = 61;
            this.WsHdInterval3Cb.Text = "In use";
            this.WsHdInterval3Cb.UseVisualStyleBackColor = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(232, 67);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(72, 13);
            this.label36.TabIndex = 60;
            this.label36.Text = "Interval Tariff:";
            // 
            // WsHiStartHour3Tb
            // 
            this.WsHiStartHour3Tb.Location = new System.Drawing.Point(166, 64);
            this.WsHiStartHour3Tb.Name = "WsHiStartHour3Tb";
            this.WsHiStartHour3Tb.Size = new System.Drawing.Size(47, 20);
            this.WsHiStartHour3Tb.TabIndex = 59;
            this.WsHiStartHour3Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsHdStartHourTb_KeyUp);
            this.WsHiStartHour3Tb.Leave += new System.EventHandler(this.WsHdStartHourTb_Leave);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(87, 67);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(58, 13);
            this.label37.TabIndex = 58;
            this.label37.Text = "Start Hour:";
            // 
            // WsHdIntervalTariff2Cb
            // 
            this.WsHdIntervalTariff2Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsHdIntervalTariff2Cb.FormattingEnabled = true;
            this.WsHdIntervalTariff2Cb.Location = new System.Drawing.Point(320, 39);
            this.WsHdIntervalTariff2Cb.Name = "WsHdIntervalTariff2Cb";
            this.WsHdIntervalTariff2Cb.Size = new System.Drawing.Size(121, 21);
            this.WsHdIntervalTariff2Cb.TabIndex = 57;
            // 
            // WsHdInterval2Cb
            // 
            this.WsHdInterval2Cb.Location = new System.Drawing.Point(15, 39);
            this.WsHdInterval2Cb.Name = "WsHdInterval2Cb";
            this.WsHdInterval2Cb.Size = new System.Drawing.Size(63, 19);
            this.WsHdInterval2Cb.TabIndex = 56;
            this.WsHdInterval2Cb.Text = "In use";
            this.WsHdInterval2Cb.UseVisualStyleBackColor = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(232, 41);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(72, 13);
            this.label38.TabIndex = 55;
            this.label38.Text = "Interval Tariff:";
            // 
            // WsHiStartHour2Tb
            // 
            this.WsHiStartHour2Tb.Location = new System.Drawing.Point(166, 38);
            this.WsHiStartHour2Tb.Name = "WsHiStartHour2Tb";
            this.WsHiStartHour2Tb.Size = new System.Drawing.Size(47, 20);
            this.WsHiStartHour2Tb.TabIndex = 54;
            this.WsHiStartHour2Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsHdStartHourTb_KeyUp);
            this.WsHiStartHour2Tb.Leave += new System.EventHandler(this.WsHdStartHourTb_Leave);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(87, 41);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(58, 13);
            this.label39.TabIndex = 53;
            this.label39.Text = "Start Hour:";
            // 
            // WsHdIntervalTariff1Cb
            // 
            this.WsHdIntervalTariff1Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsHdIntervalTariff1Cb.FormattingEnabled = true;
            this.WsHdIntervalTariff1Cb.Location = new System.Drawing.Point(320, 13);
            this.WsHdIntervalTariff1Cb.Name = "WsHdIntervalTariff1Cb";
            this.WsHdIntervalTariff1Cb.Size = new System.Drawing.Size(121, 21);
            this.WsHdIntervalTariff1Cb.TabIndex = 52;
            // 
            // WsHdInterval1Cb
            // 
            this.WsHdInterval1Cb.Location = new System.Drawing.Point(15, 13);
            this.WsHdInterval1Cb.Name = "WsHdInterval1Cb";
            this.WsHdInterval1Cb.Size = new System.Drawing.Size(63, 19);
            this.WsHdInterval1Cb.TabIndex = 51;
            this.WsHdInterval1Cb.Text = "In use";
            this.WsHdInterval1Cb.UseVisualStyleBackColor = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(232, 15);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(72, 13);
            this.label40.TabIndex = 50;
            this.label40.Text = "Interval Tariff:";
            // 
            // WsHiStartHour1Tb
            // 
            this.WsHiStartHour1Tb.Location = new System.Drawing.Point(166, 12);
            this.WsHiStartHour1Tb.Name = "WsHiStartHour1Tb";
            this.WsHiStartHour1Tb.Size = new System.Drawing.Size(47, 20);
            this.WsHiStartHour1Tb.TabIndex = 49;
            this.WsHiStartHour1Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsHdStartHourTb_KeyUp);
            this.WsHiStartHour1Tb.Leave += new System.EventHandler(this.WsHdStartHourTb_Leave);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(87, 15);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(58, 13);
            this.label41.TabIndex = 48;
            this.label41.Text = "Start Hour:";
            // 
            // WinterDActivateTb
            // 
            this.WinterDActivateTb.Location = new System.Drawing.Point(84, 6);
            this.WinterDActivateTb.Name = "WinterDActivateTb";
            this.WinterDActivateTb.Size = new System.Drawing.Size(111, 20);
            this.WinterDActivateTb.TabIndex = 6;
            this.WinterDActivateTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WinterDActivateTb_KeyUp);
            this.WinterDActivateTb.Leave += new System.EventHandler(this.WinterDActivateTb_Leave);
            // 
            // DayOfMonthLbl
            // 
            this.DayOfMonthLbl.AutoSize = true;
            this.DayOfMonthLbl.Location = new System.Drawing.Point(12, 9);
            this.DayOfMonthLbl.Name = "DayOfMonthLbl";
            this.DayOfMonthLbl.Size = new System.Drawing.Size(49, 13);
            this.DayOfMonthLbl.TabIndex = 5;
            this.DayOfMonthLbl.Text = "Activate:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.HolidayTab);
            this.tabPage3.Controls.Add(this.SummerActivateTb);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(486, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Summer season";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HolidayTab
            // 
            this.HolidayTab.Controls.Add(this.tabPage4);
            this.HolidayTab.Controls.Add(this.tabPage5);
            this.HolidayTab.Controls.Add(this.tabPage6);
            this.HolidayTab.Location = new System.Drawing.Point(15, 32);
            this.HolidayTab.Name = "HolidayTab";
            this.HolidayTab.SelectedIndex = 0;
            this.HolidayTab.Size = new System.Drawing.Size(465, 176);
            this.HolidayTab.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.SsWdIntervalTariff5Cb);
            this.tabPage4.Controls.Add(this.SsWdInterval5Cb);
            this.tabPage4.Controls.Add(this.label42);
            this.tabPage4.Controls.Add(this.SSWdStartHour5Tb);
            this.tabPage4.Controls.Add(this.label43);
            this.tabPage4.Controls.Add(this.SsWdIntervalTariff4Cb);
            this.tabPage4.Controls.Add(this.SsWdInterval4Cb);
            this.tabPage4.Controls.Add(this.label44);
            this.tabPage4.Controls.Add(this.SSWdStartHour4Tb);
            this.tabPage4.Controls.Add(this.label45);
            this.tabPage4.Controls.Add(this.SsWdIntervalTariff3Cb);
            this.tabPage4.Controls.Add(this.SsWdInterval3Cb);
            this.tabPage4.Controls.Add(this.label46);
            this.tabPage4.Controls.Add(this.SSWdStartHour3Tb);
            this.tabPage4.Controls.Add(this.label47);
            this.tabPage4.Controls.Add(this.SsWdIntervalTariff2Cb);
            this.tabPage4.Controls.Add(this.SsWdInterval2Cb);
            this.tabPage4.Controls.Add(this.label48);
            this.tabPage4.Controls.Add(this.SSWdStartHour2Tb);
            this.tabPage4.Controls.Add(this.label49);
            this.tabPage4.Controls.Add(this.SsWdIntervalTariff1Cb);
            this.tabPage4.Controls.Add(this.SsWdInterval1Cb);
            this.tabPage4.Controls.Add(this.label50);
            this.tabPage4.Controls.Add(this.SSWdStartHour1Tb);
            this.tabPage4.Controls.Add(this.label51);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(457, 150);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Working Day Intervals";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SsWdIntervalTariff5Cb
            // 
            this.SsWdIntervalTariff5Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsWdIntervalTariff5Cb.FormattingEnabled = true;
            this.SsWdIntervalTariff5Cb.Location = new System.Drawing.Point(320, 117);
            this.SsWdIntervalTariff5Cb.Name = "SsWdIntervalTariff5Cb";
            this.SsWdIntervalTariff5Cb.Size = new System.Drawing.Size(121, 21);
            this.SsWdIntervalTariff5Cb.TabIndex = 72;
            this.SsWdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsWdInterval5Cb
            // 
            this.SsWdInterval5Cb.Location = new System.Drawing.Point(15, 117);
            this.SsWdInterval5Cb.Name = "SsWdInterval5Cb";
            this.SsWdInterval5Cb.Size = new System.Drawing.Size(63, 19);
            this.SsWdInterval5Cb.TabIndex = 71;
            this.SsWdInterval5Cb.Text = "In use";
            this.SsWdInterval5Cb.UseVisualStyleBackColor = false;
            this.SsWdInterval5Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(232, 119);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(72, 13);
            this.label42.TabIndex = 70;
            this.label42.Text = "Interval Tariff:";
            // 
            // SSWdStartHour5Tb
            // 
            this.SSWdStartHour5Tb.Location = new System.Drawing.Point(166, 116);
            this.SSWdStartHour5Tb.Name = "SSWdStartHour5Tb";
            this.SSWdStartHour5Tb.Size = new System.Drawing.Size(47, 20);
            this.SSWdStartHour5Tb.TabIndex = 69;
            this.SSWdStartHour5Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSWdStartHourTb_KeyUp);
            this.SSWdStartHour5Tb.Leave += new System.EventHandler(this.SSWdStartHourTb_Leave);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(87, 119);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(58, 13);
            this.label43.TabIndex = 68;
            this.label43.Text = "Start Hour:";
            // 
            // SsWdIntervalTariff4Cb
            // 
            this.SsWdIntervalTariff4Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsWdIntervalTariff4Cb.FormattingEnabled = true;
            this.SsWdIntervalTariff4Cb.Location = new System.Drawing.Point(320, 91);
            this.SsWdIntervalTariff4Cb.Name = "SsWdIntervalTariff4Cb";
            this.SsWdIntervalTariff4Cb.Size = new System.Drawing.Size(121, 21);
            this.SsWdIntervalTariff4Cb.TabIndex = 67;
            this.SsWdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsWdInterval4Cb
            // 
            this.SsWdInterval4Cb.Location = new System.Drawing.Point(15, 91);
            this.SsWdInterval4Cb.Name = "SsWdInterval4Cb";
            this.SsWdInterval4Cb.Size = new System.Drawing.Size(63, 19);
            this.SsWdInterval4Cb.TabIndex = 66;
            this.SsWdInterval4Cb.Text = "In use";
            this.SsWdInterval4Cb.UseVisualStyleBackColor = false;
            this.SsWdInterval4Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(232, 93);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(72, 13);
            this.label44.TabIndex = 65;
            this.label44.Text = "Interval Tariff:";
            // 
            // SSWdStartHour4Tb
            // 
            this.SSWdStartHour4Tb.Location = new System.Drawing.Point(166, 90);
            this.SSWdStartHour4Tb.Name = "SSWdStartHour4Tb";
            this.SSWdStartHour4Tb.Size = new System.Drawing.Size(47, 20);
            this.SSWdStartHour4Tb.TabIndex = 64;
            this.SSWdStartHour4Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSWdStartHourTb_KeyUp);
            this.SSWdStartHour4Tb.Leave += new System.EventHandler(this.SSWdStartHourTb_Leave);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(87, 93);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 13);
            this.label45.TabIndex = 63;
            this.label45.Text = "Start Hour:";
            // 
            // SsWdIntervalTariff3Cb
            // 
            this.SsWdIntervalTariff3Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsWdIntervalTariff3Cb.FormattingEnabled = true;
            this.SsWdIntervalTariff3Cb.Location = new System.Drawing.Point(320, 65);
            this.SsWdIntervalTariff3Cb.Name = "SsWdIntervalTariff3Cb";
            this.SsWdIntervalTariff3Cb.Size = new System.Drawing.Size(121, 21);
            this.SsWdIntervalTariff3Cb.TabIndex = 62;
            this.SsWdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsWdInterval3Cb
            // 
            this.SsWdInterval3Cb.Location = new System.Drawing.Point(15, 65);
            this.SsWdInterval3Cb.Name = "SsWdInterval3Cb";
            this.SsWdInterval3Cb.Size = new System.Drawing.Size(63, 19);
            this.SsWdInterval3Cb.TabIndex = 61;
            this.SsWdInterval3Cb.Text = "In use";
            this.SsWdInterval3Cb.UseVisualStyleBackColor = false;
            this.SsWdInterval3Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(232, 67);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(72, 13);
            this.label46.TabIndex = 60;
            this.label46.Text = "Interval Tariff:";
            // 
            // SSWdStartHour3Tb
            // 
            this.SSWdStartHour3Tb.Location = new System.Drawing.Point(166, 64);
            this.SSWdStartHour3Tb.Name = "SSWdStartHour3Tb";
            this.SSWdStartHour3Tb.Size = new System.Drawing.Size(47, 20);
            this.SSWdStartHour3Tb.TabIndex = 59;
            this.SSWdStartHour3Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSWdStartHourTb_KeyUp);
            this.SSWdStartHour3Tb.Leave += new System.EventHandler(this.SSWdStartHourTb_Leave);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(87, 67);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(58, 13);
            this.label47.TabIndex = 58;
            this.label47.Text = "Start Hour:";
            // 
            // SsWdIntervalTariff2Cb
            // 
            this.SsWdIntervalTariff2Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsWdIntervalTariff2Cb.FormattingEnabled = true;
            this.SsWdIntervalTariff2Cb.Location = new System.Drawing.Point(320, 39);
            this.SsWdIntervalTariff2Cb.Name = "SsWdIntervalTariff2Cb";
            this.SsWdIntervalTariff2Cb.Size = new System.Drawing.Size(121, 21);
            this.SsWdIntervalTariff2Cb.TabIndex = 57;
            this.SsWdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsWdInterval2Cb
            // 
            this.SsWdInterval2Cb.Location = new System.Drawing.Point(15, 39);
            this.SsWdInterval2Cb.Name = "SsWdInterval2Cb";
            this.SsWdInterval2Cb.Size = new System.Drawing.Size(63, 19);
            this.SsWdInterval2Cb.TabIndex = 56;
            this.SsWdInterval2Cb.Text = "In use";
            this.SsWdInterval2Cb.UseVisualStyleBackColor = false;
            this.SsWdInterval2Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(232, 41);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(72, 13);
            this.label48.TabIndex = 55;
            this.label48.Text = "Interval Tariff:";
            // 
            // SSWdStartHour2Tb
            // 
            this.SSWdStartHour2Tb.Location = new System.Drawing.Point(166, 38);
            this.SSWdStartHour2Tb.Name = "SSWdStartHour2Tb";
            this.SSWdStartHour2Tb.Size = new System.Drawing.Size(47, 20);
            this.SSWdStartHour2Tb.TabIndex = 54;
            this.SSWdStartHour2Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSWdStartHourTb_KeyUp);
            this.SSWdStartHour2Tb.Leave += new System.EventHandler(this.SSWdStartHourTb_Leave);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(87, 41);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(58, 13);
            this.label49.TabIndex = 53;
            this.label49.Text = "Start Hour:";
            // 
            // SsWdIntervalTariff1Cb
            // 
            this.SsWdIntervalTariff1Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsWdIntervalTariff1Cb.FormattingEnabled = true;
            this.SsWdIntervalTariff1Cb.Location = new System.Drawing.Point(320, 13);
            this.SsWdIntervalTariff1Cb.Name = "SsWdIntervalTariff1Cb";
            this.SsWdIntervalTariff1Cb.Size = new System.Drawing.Size(121, 21);
            this.SsWdIntervalTariff1Cb.TabIndex = 52;
            this.SsWdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.SsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsWdInterval1Cb
            // 
            this.SsWdInterval1Cb.Location = new System.Drawing.Point(15, 13);
            this.SsWdInterval1Cb.Name = "SsWdInterval1Cb";
            this.SsWdInterval1Cb.Size = new System.Drawing.Size(63, 19);
            this.SsWdInterval1Cb.TabIndex = 51;
            this.SsWdInterval1Cb.Text = "In use";
            this.SsWdInterval1Cb.UseVisualStyleBackColor = false;
            this.SsWdInterval1Cb.CheckedChanged += new System.EventHandler(this.SsWdIntervalCb_CheckedChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(232, 15);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(72, 13);
            this.label50.TabIndex = 50;
            this.label50.Text = "Interval Tariff:";
            // 
            // SSWdStartHour1Tb
            // 
            this.SSWdStartHour1Tb.Location = new System.Drawing.Point(166, 12);
            this.SSWdStartHour1Tb.Name = "SSWdStartHour1Tb";
            this.SSWdStartHour1Tb.Size = new System.Drawing.Size(47, 20);
            this.SSWdStartHour1Tb.TabIndex = 49;
            this.SSWdStartHour1Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSWdStartHourTb_KeyUp);
            this.SSWdStartHour1Tb.Leave += new System.EventHandler(this.SSWdStartHourTb_Leave);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(87, 15);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(58, 13);
            this.label51.TabIndex = 48;
            this.label51.Text = "Start Hour:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.SsSdIntervalTariff5Cb);
            this.tabPage5.Controls.Add(this.SsSdInterval5Cb);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.SSSiStartHour5Tb);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.SsSdIntervalTariff4Cb);
            this.tabPage5.Controls.Add(this.SsSdInterval4Cb);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.SSSiStartHour4Tb);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.SsSdIntervalTariff3Cb);
            this.tabPage5.Controls.Add(this.SsSdInterval3Cb);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.SSSiStartHour3Tb);
            this.tabPage5.Controls.Add(this.label52);
            this.tabPage5.Controls.Add(this.SsSdIntervalTariff2Cb);
            this.tabPage5.Controls.Add(this.SsSdInterval2Cb);
            this.tabPage5.Controls.Add(this.label53);
            this.tabPage5.Controls.Add(this.SSSiStartHour2Tb);
            this.tabPage5.Controls.Add(this.label54);
            this.tabPage5.Controls.Add(this.SsSdIntervalTariff1Cb);
            this.tabPage5.Controls.Add(this.SsSdInterval1Cb);
            this.tabPage5.Controls.Add(this.label55);
            this.tabPage5.Controls.Add(this.SSSiStartHour1Tb);
            this.tabPage5.Controls.Add(this.label56);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(457, 150);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Saturday Intervals";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // SsSdIntervalTariff5Cb
            // 
            this.SsSdIntervalTariff5Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsSdIntervalTariff5Cb.FormattingEnabled = true;
            this.SsSdIntervalTariff5Cb.Location = new System.Drawing.Point(320, 117);
            this.SsSdIntervalTariff5Cb.Name = "SsSdIntervalTariff5Cb";
            this.SsSdIntervalTariff5Cb.Size = new System.Drawing.Size(121, 21);
            this.SsSdIntervalTariff5Cb.TabIndex = 72;
            this.SsSdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsSdInterval5Cb
            // 
            this.SsSdInterval5Cb.Location = new System.Drawing.Point(15, 117);
            this.SsSdInterval5Cb.Name = "SsSdInterval5Cb";
            this.SsSdInterval5Cb.Size = new System.Drawing.Size(63, 19);
            this.SsSdInterval5Cb.TabIndex = 71;
            this.SsSdInterval5Cb.Text = "In use";
            this.SsSdInterval5Cb.UseVisualStyleBackColor = false;
            this.SsSdInterval5Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Interval Tariff:";
            // 
            // SSSiStartHour5Tb
            // 
            this.SSSiStartHour5Tb.Location = new System.Drawing.Point(166, 116);
            this.SSSiStartHour5Tb.Name = "SSSiStartHour5Tb";
            this.SSSiStartHour5Tb.Size = new System.Drawing.Size(47, 20);
            this.SSSiStartHour5Tb.TabIndex = 69;
            this.SSSiStartHour5Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSSiStartHourTb_KeyUp);
            this.SSSiStartHour5Tb.Leave += new System.EventHandler(this.SSSiStartHourTb_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Start Hour:";
            // 
            // SsSdIntervalTariff4Cb
            // 
            this.SsSdIntervalTariff4Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsSdIntervalTariff4Cb.FormattingEnabled = true;
            this.SsSdIntervalTariff4Cb.Location = new System.Drawing.Point(320, 91);
            this.SsSdIntervalTariff4Cb.Name = "SsSdIntervalTariff4Cb";
            this.SsSdIntervalTariff4Cb.Size = new System.Drawing.Size(121, 21);
            this.SsSdIntervalTariff4Cb.TabIndex = 67;
            this.SsSdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsSdInterval4Cb
            // 
            this.SsSdInterval4Cb.Location = new System.Drawing.Point(15, 91);
            this.SsSdInterval4Cb.Name = "SsSdInterval4Cb";
            this.SsSdInterval4Cb.Size = new System.Drawing.Size(63, 19);
            this.SsSdInterval4Cb.TabIndex = 66;
            this.SsSdInterval4Cb.Text = "In use";
            this.SsSdInterval4Cb.UseVisualStyleBackColor = false;
            this.SsSdInterval4Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "Interval Tariff:";
            // 
            // SSSiStartHour4Tb
            // 
            this.SSSiStartHour4Tb.Location = new System.Drawing.Point(166, 90);
            this.SSSiStartHour4Tb.Name = "SSSiStartHour4Tb";
            this.SSSiStartHour4Tb.Size = new System.Drawing.Size(47, 20);
            this.SSSiStartHour4Tb.TabIndex = 64;
            this.SSSiStartHour4Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSSiStartHourTb_KeyUp);
            this.SSSiStartHour4Tb.Leave += new System.EventHandler(this.SSSiStartHourTb_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Start Hour:";
            // 
            // SsSdIntervalTariff3Cb
            // 
            this.SsSdIntervalTariff3Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsSdIntervalTariff3Cb.FormattingEnabled = true;
            this.SsSdIntervalTariff3Cb.Location = new System.Drawing.Point(320, 65);
            this.SsSdIntervalTariff3Cb.Name = "SsSdIntervalTariff3Cb";
            this.SsSdIntervalTariff3Cb.Size = new System.Drawing.Size(121, 21);
            this.SsSdIntervalTariff3Cb.TabIndex = 62;
            this.SsSdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsSdInterval3Cb
            // 
            this.SsSdInterval3Cb.Location = new System.Drawing.Point(15, 65);
            this.SsSdInterval3Cb.Name = "SsSdInterval3Cb";
            this.SsSdInterval3Cb.Size = new System.Drawing.Size(63, 19);
            this.SsSdInterval3Cb.TabIndex = 61;
            this.SsSdInterval3Cb.Text = "In use";
            this.SsSdInterval3Cb.UseVisualStyleBackColor = false;
            this.SsSdInterval3Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Interval Tariff:";
            // 
            // SSSiStartHour3Tb
            // 
            this.SSSiStartHour3Tb.Location = new System.Drawing.Point(166, 64);
            this.SSSiStartHour3Tb.Name = "SSSiStartHour3Tb";
            this.SSSiStartHour3Tb.Size = new System.Drawing.Size(47, 20);
            this.SSSiStartHour3Tb.TabIndex = 59;
            this.SSSiStartHour3Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSSiStartHourTb_KeyUp);
            this.SSSiStartHour3Tb.Leave += new System.EventHandler(this.SSSiStartHourTb_Leave);
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(87, 67);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(58, 13);
            this.label52.TabIndex = 58;
            this.label52.Text = "Start Hour:";
            // 
            // SsSdIntervalTariff2Cb
            // 
            this.SsSdIntervalTariff2Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsSdIntervalTariff2Cb.FormattingEnabled = true;
            this.SsSdIntervalTariff2Cb.Location = new System.Drawing.Point(320, 39);
            this.SsSdIntervalTariff2Cb.Name = "SsSdIntervalTariff2Cb";
            this.SsSdIntervalTariff2Cb.Size = new System.Drawing.Size(121, 21);
            this.SsSdIntervalTariff2Cb.TabIndex = 57;
            this.SsSdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsSdInterval2Cb
            // 
            this.SsSdInterval2Cb.Location = new System.Drawing.Point(15, 39);
            this.SsSdInterval2Cb.Name = "SsSdInterval2Cb";
            this.SsSdInterval2Cb.Size = new System.Drawing.Size(63, 19);
            this.SsSdInterval2Cb.TabIndex = 56;
            this.SsSdInterval2Cb.Text = "In use";
            this.SsSdInterval2Cb.UseVisualStyleBackColor = false;
            this.SsSdInterval2Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(232, 41);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(72, 13);
            this.label53.TabIndex = 55;
            this.label53.Text = "Interval Tariff:";
            // 
            // SSSiStartHour2Tb
            // 
            this.SSSiStartHour2Tb.Location = new System.Drawing.Point(166, 38);
            this.SSSiStartHour2Tb.Name = "SSSiStartHour2Tb";
            this.SSSiStartHour2Tb.Size = new System.Drawing.Size(47, 20);
            this.SSSiStartHour2Tb.TabIndex = 54;
            this.SSSiStartHour2Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSSiStartHourTb_KeyUp);
            this.SSSiStartHour2Tb.Leave += new System.EventHandler(this.SSSiStartHourTb_Leave);
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(87, 41);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(58, 13);
            this.label54.TabIndex = 53;
            this.label54.Text = "Start Hour:";
            // 
            // SsSdIntervalTariff1Cb
            // 
            this.SsSdIntervalTariff1Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsSdIntervalTariff1Cb.FormattingEnabled = true;
            this.SsSdIntervalTariff1Cb.Location = new System.Drawing.Point(320, 13);
            this.SsSdIntervalTariff1Cb.Name = "SsSdIntervalTariff1Cb";
            this.SsSdIntervalTariff1Cb.Size = new System.Drawing.Size(121, 21);
            this.SsSdIntervalTariff1Cb.TabIndex = 52;
            this.SsSdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.SsSdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsSdInterval1Cb
            // 
            this.SsSdInterval1Cb.Location = new System.Drawing.Point(15, 13);
            this.SsSdInterval1Cb.Name = "SsSdInterval1Cb";
            this.SsSdInterval1Cb.Size = new System.Drawing.Size(63, 19);
            this.SsSdInterval1Cb.TabIndex = 51;
            this.SsSdInterval1Cb.Text = "In use";
            this.SsSdInterval1Cb.UseVisualStyleBackColor = false;
            this.SsSdInterval1Cb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(232, 15);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(72, 13);
            this.label55.TabIndex = 50;
            this.label55.Text = "Interval Tariff:";
            // 
            // SSSiStartHour1Tb
            // 
            this.SSSiStartHour1Tb.Location = new System.Drawing.Point(166, 12);
            this.SSSiStartHour1Tb.Name = "SSSiStartHour1Tb";
            this.SSSiStartHour1Tb.Size = new System.Drawing.Size(47, 20);
            this.SSSiStartHour1Tb.TabIndex = 49;
            this.SSSiStartHour1Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSSiStartHourTb_KeyUp);
            this.SSSiStartHour1Tb.Leave += new System.EventHandler(this.SSSiStartHourTb_Leave);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(87, 15);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(58, 13);
            this.label56.TabIndex = 48;
            this.label56.Text = "Start Hour:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.SsHdIntervalTariff5Cb);
            this.tabPage6.Controls.Add(this.SsHdInterval5Cb);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.SSHiStartHour5Tb);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.SsHdIntervalTariff4Cb);
            this.tabPage6.Controls.Add(this.SsHdInterval4Cb);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.SSHiStartHour4Tb);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.SsHdIntervalTariff3Cb);
            this.tabPage6.Controls.Add(this.SsHdInterval3Cb);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.SSHiStartHour3Tb);
            this.tabPage6.Controls.Add(this.label57);
            this.tabPage6.Controls.Add(this.SsHdIntervalTariff2Cb);
            this.tabPage6.Controls.Add(this.SsHdInterval2Cb);
            this.tabPage6.Controls.Add(this.label58);
            this.tabPage6.Controls.Add(this.SSHiStartHour2Tb);
            this.tabPage6.Controls.Add(this.label59);
            this.tabPage6.Controls.Add(this.SsHdIntervalTariff1Cb);
            this.tabPage6.Controls.Add(this.SsHdInterval1Cb);
            this.tabPage6.Controls.Add(this.label60);
            this.tabPage6.Controls.Add(this.SSHiStartHour1Tb);
            this.tabPage6.Controls.Add(this.label61);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(457, 150);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Holiday Intervals";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // SsHdIntervalTariff5Cb
            // 
            this.SsHdIntervalTariff5Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsHdIntervalTariff5Cb.FormattingEnabled = true;
            this.SsHdIntervalTariff5Cb.Location = new System.Drawing.Point(320, 117);
            this.SsHdIntervalTariff5Cb.Name = "SsHdIntervalTariff5Cb";
            this.SsHdIntervalTariff5Cb.Size = new System.Drawing.Size(121, 21);
            this.SsHdIntervalTariff5Cb.TabIndex = 72;
            this.SsHdIntervalTariff5Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsHdInterval5Cb
            // 
            this.SsHdInterval5Cb.Location = new System.Drawing.Point(15, 117);
            this.SsHdInterval5Cb.Name = "SsHdInterval5Cb";
            this.SsHdInterval5Cb.Size = new System.Drawing.Size(63, 19);
            this.SsHdInterval5Cb.TabIndex = 71;
            this.SsHdInterval5Cb.Text = "In use";
            this.SsHdInterval5Cb.UseVisualStyleBackColor = false;
            this.SsHdInterval5Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Interval Tariff:";
            // 
            // SSHiStartHour5Tb
            // 
            this.SSHiStartHour5Tb.Location = new System.Drawing.Point(166, 116);
            this.SSHiStartHour5Tb.Name = "SSHiStartHour5Tb";
            this.SSHiStartHour5Tb.Size = new System.Drawing.Size(47, 20);
            this.SSHiStartHour5Tb.TabIndex = 69;
            this.SSHiStartHour5Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSHiStartHourTb_KeyUp);
            this.SSHiStartHour5Tb.Leave += new System.EventHandler(this.SSHiStartHourTb_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Start Hour:";
            // 
            // SsHdIntervalTariff4Cb
            // 
            this.SsHdIntervalTariff4Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsHdIntervalTariff4Cb.FormattingEnabled = true;
            this.SsHdIntervalTariff4Cb.Location = new System.Drawing.Point(320, 91);
            this.SsHdIntervalTariff4Cb.Name = "SsHdIntervalTariff4Cb";
            this.SsHdIntervalTariff4Cb.Size = new System.Drawing.Size(121, 21);
            this.SsHdIntervalTariff4Cb.TabIndex = 67;
            this.SsHdIntervalTariff4Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsHdInterval4Cb
            // 
            this.SsHdInterval4Cb.Location = new System.Drawing.Point(15, 91);
            this.SsHdInterval4Cb.Name = "SsHdInterval4Cb";
            this.SsHdInterval4Cb.Size = new System.Drawing.Size(63, 19);
            this.SsHdInterval4Cb.TabIndex = 66;
            this.SsHdInterval4Cb.Text = "In use";
            this.SsHdInterval4Cb.UseVisualStyleBackColor = false;
            this.SsHdInterval4Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Interval Tariff:";
            // 
            // SSHiStartHour4Tb
            // 
            this.SSHiStartHour4Tb.Location = new System.Drawing.Point(166, 90);
            this.SSHiStartHour4Tb.Name = "SSHiStartHour4Tb";
            this.SSHiStartHour4Tb.Size = new System.Drawing.Size(47, 20);
            this.SSHiStartHour4Tb.TabIndex = 64;
            this.SSHiStartHour4Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSHiStartHourTb_KeyUp);
            this.SSHiStartHour4Tb.Leave += new System.EventHandler(this.SSHiStartHourTb_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Start Hour:";
            // 
            // SsHdIntervalTariff3Cb
            // 
            this.SsHdIntervalTariff3Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsHdIntervalTariff3Cb.FormattingEnabled = true;
            this.SsHdIntervalTariff3Cb.Location = new System.Drawing.Point(320, 65);
            this.SsHdIntervalTariff3Cb.Name = "SsHdIntervalTariff3Cb";
            this.SsHdIntervalTariff3Cb.Size = new System.Drawing.Size(121, 21);
            this.SsHdIntervalTariff3Cb.TabIndex = 62;
            this.SsHdIntervalTariff3Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsHdInterval3Cb
            // 
            this.SsHdInterval3Cb.Location = new System.Drawing.Point(15, 65);
            this.SsHdInterval3Cb.Name = "SsHdInterval3Cb";
            this.SsHdInterval3Cb.Size = new System.Drawing.Size(63, 19);
            this.SsHdInterval3Cb.TabIndex = 61;
            this.SsHdInterval3Cb.Text = "In use";
            this.SsHdInterval3Cb.UseVisualStyleBackColor = false;
            this.SsHdInterval3Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Interval Tariff:";
            // 
            // SSHiStartHour3Tb
            // 
            this.SSHiStartHour3Tb.Location = new System.Drawing.Point(166, 64);
            this.SSHiStartHour3Tb.Name = "SSHiStartHour3Tb";
            this.SSHiStartHour3Tb.Size = new System.Drawing.Size(47, 20);
            this.SSHiStartHour3Tb.TabIndex = 59;
            this.SSHiStartHour3Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSHiStartHourTb_KeyUp);
            this.SSHiStartHour3Tb.Leave += new System.EventHandler(this.SSHiStartHourTb_Leave);
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(87, 67);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(58, 13);
            this.label57.TabIndex = 58;
            this.label57.Text = "Start Hour:";
            // 
            // SsHdIntervalTariff2Cb
            // 
            this.SsHdIntervalTariff2Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsHdIntervalTariff2Cb.FormattingEnabled = true;
            this.SsHdIntervalTariff2Cb.Location = new System.Drawing.Point(320, 39);
            this.SsHdIntervalTariff2Cb.Name = "SsHdIntervalTariff2Cb";
            this.SsHdIntervalTariff2Cb.Size = new System.Drawing.Size(121, 21);
            this.SsHdIntervalTariff2Cb.TabIndex = 57;
            this.SsHdIntervalTariff2Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsHdInterval2Cb
            // 
            this.SsHdInterval2Cb.Location = new System.Drawing.Point(15, 39);
            this.SsHdInterval2Cb.Name = "SsHdInterval2Cb";
            this.SsHdInterval2Cb.Size = new System.Drawing.Size(63, 19);
            this.SsHdInterval2Cb.TabIndex = 56;
            this.SsHdInterval2Cb.Text = "In use";
            this.SsHdInterval2Cb.UseVisualStyleBackColor = false;
            this.SsHdInterval2Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(232, 41);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(72, 13);
            this.label58.TabIndex = 55;
            this.label58.Text = "Interval Tariff:";
            // 
            // SSHiStartHour2Tb
            // 
            this.SSHiStartHour2Tb.Location = new System.Drawing.Point(166, 38);
            this.SSHiStartHour2Tb.Name = "SSHiStartHour2Tb";
            this.SSHiStartHour2Tb.Size = new System.Drawing.Size(47, 20);
            this.SSHiStartHour2Tb.TabIndex = 54;
            this.SSHiStartHour2Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSHiStartHourTb_KeyUp);
            this.SSHiStartHour2Tb.Leave += new System.EventHandler(this.SSHiStartHourTb_Leave);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(87, 41);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(58, 13);
            this.label59.TabIndex = 53;
            this.label59.Text = "Start Hour:";
            // 
            // SsHdIntervalTariff1Cb
            // 
            this.SsHdIntervalTariff1Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsHdIntervalTariff1Cb.FormattingEnabled = true;
            this.SsHdIntervalTariff1Cb.Location = new System.Drawing.Point(320, 13);
            this.SsHdIntervalTariff1Cb.Name = "SsHdIntervalTariff1Cb";
            this.SsHdIntervalTariff1Cb.Size = new System.Drawing.Size(121, 21);
            this.SsHdIntervalTariff1Cb.TabIndex = 52;
            this.SsHdIntervalTariff1Cb.SelectedIndexChanged += new System.EventHandler(this.SsHdIntervalTariffCb_SelectedIndexChanged);
            // 
            // SsHdInterval1Cb
            // 
            this.SsHdInterval1Cb.Location = new System.Drawing.Point(15, 13);
            this.SsHdInterval1Cb.Name = "SsHdInterval1Cb";
            this.SsHdInterval1Cb.Size = new System.Drawing.Size(63, 19);
            this.SsHdInterval1Cb.TabIndex = 51;
            this.SsHdInterval1Cb.Text = "In use";
            this.SsHdInterval1Cb.UseVisualStyleBackColor = false;
            this.SsHdInterval1Cb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(232, 15);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(72, 13);
            this.label60.TabIndex = 50;
            this.label60.Text = "Interval Tariff:";
            // 
            // SSHiStartHour1Tb
            // 
            this.SSHiStartHour1Tb.Location = new System.Drawing.Point(166, 12);
            this.SSHiStartHour1Tb.Name = "SSHiStartHour1Tb";
            this.SSHiStartHour1Tb.Size = new System.Drawing.Size(47, 20);
            this.SSHiStartHour1Tb.TabIndex = 49;
            this.SSHiStartHour1Tb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSHiStartHourTb_KeyUp);
            this.SSHiStartHour1Tb.Leave += new System.EventHandler(this.SSHiStartHourTb_Leave);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(87, 15);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(58, 13);
            this.label61.TabIndex = 48;
            this.label61.Text = "Start Hour:";
            // 
            // SummerActivateTb
            // 
            this.SummerActivateTb.Location = new System.Drawing.Point(84, 6);
            this.SummerActivateTb.Name = "SummerActivateTb";
            this.SummerActivateTb.Size = new System.Drawing.Size(111, 20);
            this.SummerActivateTb.TabIndex = 9;
            this.SummerActivateTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SummerActivateTb_KeyUp);
            this.SummerActivateTb.Leave += new System.EventHandler(this.SummerActivateTb_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Activate:";
            // 
            // ActivationTimeTb
            // 
            this.ActivationTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivationTimeTb.Index = 5;
            this.ActivationTimeTb.Location = new System.Drawing.Point(104, 120);
            this.ActivationTimeTb.Name = "ActivationTimeTb";
            this.ActivationTimeTb.NotifyChanges = false;
            this.ActivationTimeTb.Size = new System.Drawing.Size(406, 20);
            this.ActivationTimeTb.TabIndex = 25;
            this.ActivationTimeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ActivationTimeLbl
            // 
            this.ActivationTimeLbl.AutoSize = true;
            this.ActivationTimeLbl.Location = new System.Drawing.Point(8, 123);
            this.ActivationTimeLbl.Name = "ActivationTimeLbl";
            this.ActivationTimeLbl.Size = new System.Drawing.Size(83, 13);
            this.ActivationTimeLbl.TabIndex = 26;
            this.ActivationTimeLbl.Text = "Activation Time:";
            // 
            // EnabledLbl
            // 
            this.EnabledLbl.AutoSize = true;
            this.EnabledLbl.Location = new System.Drawing.Point(7, 99);
            this.EnabledLbl.Name = "EnabledLbl";
            this.EnabledLbl.Size = new System.Drawing.Size(49, 13);
            this.EnabledLbl.TabIndex = 24;
            this.EnabledLbl.Text = "Enabled:";
            // 
            // EnabledCB
            // 
            this.EnabledCB.Location = new System.Drawing.Point(103, 97);
            this.EnabledCB.Name = "EnabledCB";
            this.EnabledCB.Size = new System.Drawing.Size(37, 17);
            this.EnabledCB.TabIndex = 23;
            this.EnabledCB.UseVisualStyleBackColor = false;
            this.EnabledCB.CheckedChanged += new System.EventHandler(this.EnabledCB_CheckedChanged);
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
            this.DescriptionTB.Location = new System.Drawing.Point(103, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(407, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // CalendarNameTb
            // 
            this.CalendarNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarNameTb.Index = 2;
            this.CalendarNameTb.Location = new System.Drawing.Point(103, 71);
            this.CalendarNameTb.Name = "CalendarNameTb";
            this.CalendarNameTb.NotifyChanges = false;
            this.CalendarNameTb.Size = new System.Drawing.Size(406, 20);
            this.CalendarNameTb.TabIndex = 0;
            this.CalendarNameTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CalendarNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CalendarNameTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CalendarNameLbl
            // 
            this.CalendarNameLbl.AutoSize = true;
            this.CalendarNameLbl.Location = new System.Drawing.Point(7, 74);
            this.CalendarNameLbl.Name = "CalendarNameLbl";
            this.CalendarNameLbl.Size = new System.Drawing.Size(83, 13);
            this.CalendarNameLbl.TabIndex = 2;
            this.CalendarNameLbl.Text = "Calendar Name:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(406, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // GXDLMSTariffPlanView
            // 
            this.ClientSize = new System.Drawing.Size(555, 523);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSTariffPlanView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.HolidayTab.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label EnabledLbl;
        private CheckBox EnabledCB;
        private GXValueField ActivationTimeTb;
        private Label ActivationTimeLbl;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label DefaultTariffBandLbl;
        private TextBox DefaultTariffBandTb;
        private TextBox WeeklyActivationTb;
        private Label WeeklyActivationLbl;
        private Button RemoveBtn;
        private Button AddBtn;
        private ListView SpecialDaysLv;
        private ColumnHeader SpecialDaysCh;
        private TabPage tabPage3;
        private TextBox WinterDActivateTb;
        private Label DayOfMonthLbl;
        private TabControl HolidayTab;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TextBox SummerActivateTb;
        private Label label1;
        private TabControl tabControl2;
        private TabPage tabPage7;
        private ComboBox WsWdIntervalTariff1Cb;
        private CheckBox WsWdIntervalCb1;
        private Label label15;
        private TextBox WsWdStartHour1Tb;
        private Label label16;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private ComboBox WsWdIntervalTariff5Cb;
        private CheckBox WsWdIntervalCb5;
        private Label label24;
        private TextBox WsWdStartHour5Tb;
        private Label label27;
        private ComboBox WsWdIntervalTariff4Cb;
        private CheckBox WsWdIntervalCb4;
        private Label label19;
        private TextBox WsWdStartHour4Tb;
        private Label label22;
        private ComboBox WsWdIntervalTariff3Cb;
        private CheckBox WsWdIntervalCb3;
        private Label label14;
        private TextBox WsWdStartHour3Tb;
        private Label label17;
        private ComboBox WsWdIntervalTariff2Cb;
        private CheckBox WsWdIntervalCb2;
        private Label label12;
        private TextBox WsWdStartHour2Tb;
        private Label label13;
        private ComboBox WsSdIntervalTariff5Cb;
        private CheckBox WsSdInterval5Cb;
        private Label label18;
        private TextBox WsSiStartHour5Tb;
        private Label label20;
        private ComboBox WsSdIntervalTariff4Cb;
        private CheckBox WsSdInterval4Cb;
        private Label label21;
        private TextBox WsSiStartHour4Tb;
        private Label label28;
        private ComboBox WsSdIntervalTariff3Cb;
        private CheckBox WsSdInterval3Cb;
        private Label label29;
        private TextBox WsSiStartHour3Tb;
        private Label label30;
        private ComboBox WsSdIntervalTariff2Cb;
        private CheckBox WsSdInterval2Cb;
        private Label label31;
        private TextBox WsSiStartHour2Tb;
        private Label label32;
        private ComboBox WsSdIntervalTariff1Cb;
        private CheckBox WsSdInterval1Cb;
        private Label label33;
        private TextBox WsSiStartHour1Tb;
        private Label label34;
        private ComboBox WsHdIntervalTariff5Cb;
        private CheckBox WsHdInterval5Cb;
        private Label label23;
        private TextBox WsHiStartHour5Tb;
        private Label label25;
        private ComboBox WsHdIntervalTariff4Cb;
        private CheckBox WsHdInterval4Cb;
        private Label label26;
        private TextBox WsHiStartHour4Tb;
        private Label label35;
        private ComboBox WsHdIntervalTariff3Cb;
        private CheckBox WsHdInterval3Cb;
        private Label label36;
        private TextBox WsHiStartHour3Tb;
        private Label label37;
        private ComboBox WsHdIntervalTariff2Cb;
        private CheckBox WsHdInterval2Cb;
        private Label label38;
        private TextBox WsHiStartHour2Tb;
        private Label label39;
        private ComboBox WsHdIntervalTariff1Cb;
        private CheckBox WsHdInterval1Cb;
        private Label label40;
        private TextBox WsHiStartHour1Tb;
        private Label label41;
        private CheckBox SsWdInterval5Cb;
        private Label label42;
        private TextBox SSWdStartHour5Tb;
        private Label label43;
        private ComboBox SsWdIntervalTariff4Cb;
        private CheckBox SsWdInterval4Cb;
        private Label label44;
        private TextBox SSWdStartHour4Tb;
        private Label label45;
        private ComboBox SsWdIntervalTariff3Cb;
        private CheckBox SsWdInterval3Cb;
        private Label label46;
        private TextBox SSWdStartHour3Tb;
        private Label label47;
        private ComboBox SsWdIntervalTariff2Cb;
        private CheckBox SsWdInterval2Cb;
        private Label label48;
        private TextBox SSWdStartHour2Tb;
        private Label label49;
        private ComboBox SsWdIntervalTariff1Cb;
        private CheckBox SsWdInterval1Cb;
        private Label label50;
        private Label label51;
        private ComboBox SsSdIntervalTariff5Cb;
        private CheckBox SsSdInterval5Cb;
        private Label label2;
        private TextBox SSSiStartHour5Tb;
        private Label label3;
        private ComboBox SsSdIntervalTariff4Cb;
        private CheckBox SsSdInterval4Cb;
        private Label label4;
        private TextBox SSSiStartHour4Tb;
        private Label label5;
        private ComboBox SsSdIntervalTariff3Cb;
        private CheckBox SsSdInterval3Cb;
        private Label label6;
        private TextBox SSSiStartHour3Tb;
        private Label label52;
        private ComboBox SsSdIntervalTariff2Cb;
        private CheckBox SsSdInterval2Cb;
        private Label label53;
        private TextBox SSSiStartHour2Tb;
        private Label label54;
        private ComboBox SsSdIntervalTariff1Cb;
        private CheckBox SsSdInterval1Cb;
        private Label label55;
        private TextBox SSSiStartHour1Tb;
        private Label label56;
        private ComboBox SsHdIntervalTariff5Cb;
        private CheckBox SsHdInterval5Cb;
        private Label label7;
        private TextBox SSHiStartHour5Tb;
        private Label label8;
        private ComboBox SsHdIntervalTariff4Cb;
        private CheckBox SsHdInterval4Cb;
        private Label label9;
        private TextBox SSHiStartHour4Tb;
        private Label label10;
        private ComboBox SsHdIntervalTariff3Cb;
        private CheckBox SsHdInterval3Cb;
        private Label label11;
        private TextBox SSHiStartHour3Tb;
        private Label label57;
        private ComboBox SsHdIntervalTariff2Cb;
        private CheckBox SsHdInterval2Cb;
        private Label label58;
        private TextBox SSHiStartHour2Tb;
        private Label label59;
        private ComboBox SsHdIntervalTariff1Cb;
        private CheckBox SsHdInterval1Cb;
        private Label label60;
        private TextBox SSHiStartHour1Tb;
        private Label label61;
        private TextBox SSWdStartHour1Tb;
        private ComboBox SsWdIntervalTariff5Cb;
    }
}
