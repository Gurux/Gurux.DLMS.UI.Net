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
            this.label12 = new System.Windows.Forms.Label();
            this.WsWdSpecialDayEnabled = new System.Windows.Forms.CheckBox();
            this.WsWdWeeklyActivationCb = new System.Windows.Forms.ComboBox();
            this.WsWdIntervalTariffCb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WsWdIntervalCb = new System.Windows.Forms.CheckBox();
            this.WsWdSpecialDayTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.WsWdStartHourTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.WsSiStartHourTb = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.WsSiSpecialDayCb = new System.Windows.Forms.CheckBox();
            this.WsSiWeeklyActivationCb = new System.Windows.Forms.ComboBox();
            this.WsSiIntervalTariffTb = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.WsSiIntervalEnabled = new System.Windows.Forms.CheckBox();
            this.WsSiSpecialDayTb = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.WsHiSpecialDayCb = new System.Windows.Forms.CheckBox();
            this.WsHiWeeklyActivationCb = new System.Windows.Forms.ComboBox();
            this.WsHiIntervalTarifCb = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.WsHiUseIntervalCb = new System.Windows.Forms.CheckBox();
            this.WsHiSpecialDayTb = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.WsHiStartHourTb = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.WinterDActivateTb = new System.Windows.Forms.TextBox();
            this.DayOfMonthLbl = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HolidayTab = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.WdSpecialDayEnabledCb = new System.Windows.Forms.Label();
            this.SSWdSpecialDayCb = new System.Windows.Forms.CheckBox();
            this.SSWdWeeklyActivationCb = new System.Windows.Forms.ComboBox();
            this.SSWdIntervalTariffCb = new System.Windows.Forms.ComboBox();
            this.WdUseIntervalCb = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SSWdSpecialDayTb = new System.Windows.Forms.TextBox();
            this.WdWeeklyActivationLbl = new System.Windows.Forms.Label();
            this.IntervalTariffLbl = new System.Windows.Forms.Label();
            this.SSWdStartHourTb = new System.Windows.Forms.TextBox();
            this.StartHourLbl = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.SSSiSpecialDayCb = new System.Windows.Forms.CheckBox();
            this.SSSiWeeklyActivationCb = new System.Windows.Forms.ComboBox();
            this.SSSiIntrvalTarifCb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SSSiUseIntervalCb = new System.Windows.Forms.CheckBox();
            this.SSSiSpecialDayTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SSSiStartHourTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.SSHiSpecialDayCb = new System.Windows.Forms.CheckBox();
            this.SSHiWeeklyActivationCb = new System.Windows.Forms.ComboBox();
            this.SSHiIntervalTarifCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SSHiUseIntervalCb = new System.Windows.Forms.CheckBox();
            this.SSHiSpecialDayTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SSHiStartHourTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SummerActivateTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivationTimeLbl = new System.Windows.Forms.Label();
            this.EnabledLbl = new System.Windows.Forms.Label();
            this.EnabledCB = new System.Windows.Forms.CheckBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.CalendarNameLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActivationTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.CalendarNameTb = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
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
            this.groupBox1.Size = new System.Drawing.Size(475, 452);
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
            this.groupBox2.Size = new System.Drawing.Size(459, 278);
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
            this.tabControl1.Size = new System.Drawing.Size(438, 253);
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
            this.tabPage1.Size = new System.Drawing.Size(430, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Location = new System.Drawing.Point(340, 187);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 20;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(259, 187);
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
            this.SpecialDaysLv.Size = new System.Drawing.Size(303, 119);
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
            this.tabPage2.Size = new System.Drawing.Size(430, 227);
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
            this.tabControl2.Size = new System.Drawing.Size(387, 176);
            this.tabControl2.TabIndex = 11;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label12);
            this.tabPage7.Controls.Add(this.WsWdSpecialDayEnabled);
            this.tabPage7.Controls.Add(this.WsWdWeeklyActivationCb);
            this.tabPage7.Controls.Add(this.WsWdIntervalTariffCb);
            this.tabPage7.Controls.Add(this.label13);
            this.tabPage7.Controls.Add(this.WsWdIntervalCb);
            this.tabPage7.Controls.Add(this.WsWdSpecialDayTb);
            this.tabPage7.Controls.Add(this.label14);
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Controls.Add(this.WsWdStartHourTb);
            this.tabPage7.Controls.Add(this.label16);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(379, 150);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Working Day Intervals";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "SpecialDay";
            // 
            // WsWdSpecialDayEnabled
            // 
            this.WsWdSpecialDayEnabled.Location = new System.Drawing.Point(241, 120);
            this.WsWdSpecialDayEnabled.Name = "WsWdSpecialDayEnabled";
            this.WsWdSpecialDayEnabled.Size = new System.Drawing.Size(37, 17);
            this.WsWdSpecialDayEnabled.TabIndex = 29;
            this.WsWdSpecialDayEnabled.UseVisualStyleBackColor = false;
            this.WsWdSpecialDayEnabled.CheckedChanged += new System.EventHandler(this.WsWdSpecialDayEnabled_CheckedChanged);
            // 
            // WsWdWeeklyActivationCb
            // 
            this.WsWdWeeklyActivationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsWdWeeklyActivationCb.FormattingEnabled = true;
            this.WsWdWeeklyActivationCb.Location = new System.Drawing.Point(115, 90);
            this.WsWdWeeklyActivationCb.Name = "WsWdWeeklyActivationCb";
            this.WsWdWeeklyActivationCb.Size = new System.Drawing.Size(121, 21);
            this.WsWdWeeklyActivationCb.TabIndex = 28;
            this.WsWdWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.WsWdWeeklyActivationCb_SelectedIndexChanged);
            // 
            // WsWdIntervalTariffCb
            // 
            this.WsWdIntervalTariffCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsWdIntervalTariffCb.FormattingEnabled = true;
            this.WsWdIntervalTariffCb.Location = new System.Drawing.Point(115, 32);
            this.WsWdIntervalTariffCb.Name = "WsWdIntervalTariffCb";
            this.WsWdIntervalTariffCb.Size = new System.Drawing.Size(121, 21);
            this.WsWdIntervalTariffCb.TabIndex = 27;
            this.WsWdIntervalTariffCb.SelectedIndexChanged += new System.EventHandler(this.WsWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Use Interval";
            // 
            // WsWdIntervalCb
            // 
            this.WsWdIntervalCb.Location = new System.Drawing.Point(115, 64);
            this.WsWdIntervalCb.Name = "WsWdIntervalCb";
            this.WsWdIntervalCb.Size = new System.Drawing.Size(37, 17);
            this.WsWdIntervalCb.TabIndex = 25;
            this.WsWdIntervalCb.UseVisualStyleBackColor = false;
            this.WsWdIntervalCb.CheckedChanged += new System.EventHandler(this.WsWdIntervalCb_CheckedChanged);
            // 
            // WsWdSpecialDayTb
            // 
            this.WsWdSpecialDayTb.Location = new System.Drawing.Point(115, 117);
            this.WsWdSpecialDayTb.Name = "WsWdSpecialDayTb";
            this.WsWdSpecialDayTb.Size = new System.Drawing.Size(121, 20);
            this.WsWdSpecialDayTb.TabIndex = 17;
            this.WsWdSpecialDayTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsWdSpecialDayTb_KeyUp);
            this.WsWdSpecialDayTb.Leave += new System.EventHandler(this.WsWdSpecialDayTb_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Weekly Activation:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Interval Tariff:";
            // 
            // WsWdStartHourTb
            // 
            this.WsWdStartHourTb.Location = new System.Drawing.Point(115, 6);
            this.WsWdStartHourTb.Name = "WsWdStartHourTb";
            this.WsWdStartHourTb.Size = new System.Drawing.Size(121, 20);
            this.WsWdStartHourTb.TabIndex = 11;
            this.WsWdStartHourTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsWdStartHourTb_KeyUp);
            this.WsWdStartHourTb.Leave += new System.EventHandler(this.WsWdStartHourTb_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Start Hour:";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.WsSiStartHourTb);
            this.tabPage8.Controls.Add(this.label17);
            this.tabPage8.Controls.Add(this.WsSiSpecialDayCb);
            this.tabPage8.Controls.Add(this.WsSiWeeklyActivationCb);
            this.tabPage8.Controls.Add(this.WsSiIntervalTariffTb);
            this.tabPage8.Controls.Add(this.label18);
            this.tabPage8.Controls.Add(this.WsSiIntervalEnabled);
            this.tabPage8.Controls.Add(this.WsSiSpecialDayTb);
            this.tabPage8.Controls.Add(this.label19);
            this.tabPage8.Controls.Add(this.label20);
            this.tabPage8.Controls.Add(this.label21);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(379, 150);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Saturday Intervals";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // WsSiStartHourTb
            // 
            this.WsSiStartHourTb.Location = new System.Drawing.Point(118, 7);
            this.WsSiStartHourTb.Name = "WsSiStartHourTb";
            this.WsSiStartHourTb.Size = new System.Drawing.Size(121, 20);
            this.WsSiStartHourTb.TabIndex = 32;
            this.WsSiStartHourTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsSiStartHourTb_KeyUp);
            this.WsSiStartHourTb.Leave += new System.EventHandler(this.WsSiStartHourTb_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "SpecialDay";
            // 
            // WsSiSpecialDayCb
            // 
            this.WsSiSpecialDayCb.Location = new System.Drawing.Point(244, 121);
            this.WsSiSpecialDayCb.Name = "WsSiSpecialDayCb";
            this.WsSiSpecialDayCb.Size = new System.Drawing.Size(37, 17);
            this.WsSiSpecialDayCb.TabIndex = 40;
            this.WsSiSpecialDayCb.UseVisualStyleBackColor = false;
            this.WsSiSpecialDayCb.CheckedChanged += new System.EventHandler(this.WsSiSpecialDayCb_CheckedChanged);
            // 
            // WsSiWeeklyActivationCb
            // 
            this.WsSiWeeklyActivationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsSiWeeklyActivationCb.FormattingEnabled = true;
            this.WsSiWeeklyActivationCb.Location = new System.Drawing.Point(118, 91);
            this.WsSiWeeklyActivationCb.Name = "WsSiWeeklyActivationCb";
            this.WsSiWeeklyActivationCb.Size = new System.Drawing.Size(121, 21);
            this.WsSiWeeklyActivationCb.TabIndex = 39;
            this.WsSiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.WsSiWeeklyActivationCb_SelectedIndexChanged);
            // 
            // WsSiIntervalTariffTb
            // 
            this.WsSiIntervalTariffTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsSiIntervalTariffTb.FormattingEnabled = true;
            this.WsSiIntervalTariffTb.Location = new System.Drawing.Point(118, 33);
            this.WsSiIntervalTariffTb.Name = "WsSiIntervalTariffTb";
            this.WsSiIntervalTariffTb.Size = new System.Drawing.Size(121, 21);
            this.WsSiIntervalTariffTb.TabIndex = 38;
            this.WsSiIntervalTariffTb.SelectedIndexChanged += new System.EventHandler(this.WsSiIntervalTariffTb_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Use Interval";
            // 
            // WsSiIntervalEnabled
            // 
            this.WsSiIntervalEnabled.Location = new System.Drawing.Point(118, 65);
            this.WsSiIntervalEnabled.Name = "WsSiIntervalEnabled";
            this.WsSiIntervalEnabled.Size = new System.Drawing.Size(37, 17);
            this.WsSiIntervalEnabled.TabIndex = 36;
            this.WsSiIntervalEnabled.UseVisualStyleBackColor = false;
            this.WsSiIntervalEnabled.CheckedChanged += new System.EventHandler(this.WsSiIntervalEnabled_CheckedChanged);
            // 
            // WsSiSpecialDayTb
            // 
            this.WsSiSpecialDayTb.Location = new System.Drawing.Point(118, 118);
            this.WsSiSpecialDayTb.Name = "WsSiSpecialDayTb";
            this.WsSiSpecialDayTb.Size = new System.Drawing.Size(121, 20);
            this.WsSiSpecialDayTb.TabIndex = 35;
            this.WsSiSpecialDayTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsSiSpecialDayTb_KeyUp);
            this.WsSiSpecialDayTb.Leave += new System.EventHandler(this.WsSiSpecialDayTb_Leave);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "Weekly Activation:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Interval Tariff:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(15, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 31;
            this.label21.Text = "Start Hour:";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label22);
            this.tabPage9.Controls.Add(this.WsHiSpecialDayCb);
            this.tabPage9.Controls.Add(this.WsHiWeeklyActivationCb);
            this.tabPage9.Controls.Add(this.WsHiIntervalTarifCb);
            this.tabPage9.Controls.Add(this.label23);
            this.tabPage9.Controls.Add(this.WsHiUseIntervalCb);
            this.tabPage9.Controls.Add(this.WsHiSpecialDayTb);
            this.tabPage9.Controls.Add(this.label24);
            this.tabPage9.Controls.Add(this.label25);
            this.tabPage9.Controls.Add(this.WsHiStartHourTb);
            this.tabPage9.Controls.Add(this.label26);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(379, 150);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "Holiday Intervals";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 121);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "SpecialDay";
            // 
            // WsHiSpecialDayCb
            // 
            this.WsHiSpecialDayCb.Location = new System.Drawing.Point(241, 121);
            this.WsHiSpecialDayCb.Name = "WsHiSpecialDayCb";
            this.WsHiSpecialDayCb.Size = new System.Drawing.Size(37, 17);
            this.WsHiSpecialDayCb.TabIndex = 40;
            this.WsHiSpecialDayCb.UseVisualStyleBackColor = false;
            this.WsHiSpecialDayCb.CheckedChanged += new System.EventHandler(this.WsHiSpecialDayCb_CheckedChanged);
            // 
            // WsHiWeeklyActivationCb
            // 
            this.WsHiWeeklyActivationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsHiWeeklyActivationCb.FormattingEnabled = true;
            this.WsHiWeeklyActivationCb.Location = new System.Drawing.Point(115, 91);
            this.WsHiWeeklyActivationCb.Name = "WsHiWeeklyActivationCb";
            this.WsHiWeeklyActivationCb.Size = new System.Drawing.Size(121, 21);
            this.WsHiWeeklyActivationCb.TabIndex = 39;
            this.WsHiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.WsHiWeeklyActivationCb_SelectedIndexChanged);
            // 
            // WsHiIntervalTarifCb
            // 
            this.WsHiIntervalTarifCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WsHiIntervalTarifCb.FormattingEnabled = true;
            this.WsHiIntervalTarifCb.Location = new System.Drawing.Point(115, 33);
            this.WsHiIntervalTarifCb.Name = "WsHiIntervalTarifCb";
            this.WsHiIntervalTarifCb.Size = new System.Drawing.Size(121, 21);
            this.WsHiIntervalTarifCb.TabIndex = 38;
            this.WsHiIntervalTarifCb.SelectedIndexChanged += new System.EventHandler(this.WsHiIntervalTarifCb_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 37;
            this.label23.Text = "Use Interval";
            // 
            // WsHiUseIntervalCb
            // 
            this.WsHiUseIntervalCb.Location = new System.Drawing.Point(115, 65);
            this.WsHiUseIntervalCb.Name = "WsHiUseIntervalCb";
            this.WsHiUseIntervalCb.Size = new System.Drawing.Size(37, 17);
            this.WsHiUseIntervalCb.TabIndex = 36;
            this.WsHiUseIntervalCb.UseVisualStyleBackColor = false;
            this.WsHiUseIntervalCb.CheckedChanged += new System.EventHandler(this.WsHiUseIntervalCb_CheckedChanged);
            // 
            // WsHiSpecialDayTb
            // 
            this.WsHiSpecialDayTb.Location = new System.Drawing.Point(115, 118);
            this.WsHiSpecialDayTb.Name = "WsHiSpecialDayTb";
            this.WsHiSpecialDayTb.Size = new System.Drawing.Size(121, 20);
            this.WsHiSpecialDayTb.TabIndex = 35;
            this.WsHiSpecialDayTb.TextChanged += new System.EventHandler(this.WsHiSpecialDayTb_TextChanged);
            this.WsHiSpecialDayTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsHiSpecialDayTb_KeyUp);
            this.WsHiSpecialDayTb.Leave += new System.EventHandler(this.WsHiSpecialDayTb_Leave);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 94);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 13);
            this.label24.TabIndex = 34;
            this.label24.Text = "Weekly Activation:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Interval Tariff:";
            // 
            // WsHiStartHourTb
            // 
            this.WsHiStartHourTb.Location = new System.Drawing.Point(115, 7);
            this.WsHiStartHourTb.Name = "WsHiStartHourTb";
            this.WsHiStartHourTb.Size = new System.Drawing.Size(121, 20);
            this.WsHiStartHourTb.TabIndex = 32;
            this.WsHiStartHourTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WsHiStartHourTb_KeyUp);
            this.WsHiStartHourTb.Leave += new System.EventHandler(this.WsHiStartHourTb_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(12, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 13);
            this.label26.TabIndex = 31;
            this.label26.Text = "Start Hour:";
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
            this.tabPage3.Size = new System.Drawing.Size(430, 227);
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
            this.HolidayTab.Size = new System.Drawing.Size(387, 176);
            this.HolidayTab.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.WdSpecialDayEnabledCb);
            this.tabPage4.Controls.Add(this.SSWdSpecialDayCb);
            this.tabPage4.Controls.Add(this.SSWdWeeklyActivationCb);
            this.tabPage4.Controls.Add(this.SSWdIntervalTariffCb);
            this.tabPage4.Controls.Add(this.WdUseIntervalCb);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.SSWdSpecialDayTb);
            this.tabPage4.Controls.Add(this.WdWeeklyActivationLbl);
            this.tabPage4.Controls.Add(this.IntervalTariffLbl);
            this.tabPage4.Controls.Add(this.SSWdStartHourTb);
            this.tabPage4.Controls.Add(this.StartHourLbl);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(379, 150);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Working Day Intervals";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // WdSpecialDayEnabledCb
            // 
            this.WdSpecialDayEnabledCb.AutoSize = true;
            this.WdSpecialDayEnabledCb.Location = new System.Drawing.Point(12, 120);
            this.WdSpecialDayEnabledCb.Name = "WdSpecialDayEnabledCb";
            this.WdSpecialDayEnabledCb.Size = new System.Drawing.Size(61, 13);
            this.WdSpecialDayEnabledCb.TabIndex = 30;
            this.WdSpecialDayEnabledCb.Text = "SpecialDay";
            // 
            // SSWdSpecialDayCb
            // 
            this.SSWdSpecialDayCb.Location = new System.Drawing.Point(241, 120);
            this.SSWdSpecialDayCb.Name = "SSWdSpecialDayCb";
            this.SSWdSpecialDayCb.Size = new System.Drawing.Size(37, 17);
            this.SSWdSpecialDayCb.TabIndex = 29;
            this.SSWdSpecialDayCb.UseVisualStyleBackColor = false;
            this.SSWdSpecialDayCb.CheckedChanged += new System.EventHandler(this.SSWdSpecialDayCb_CheckedChanged);
            // 
            // SSWdWeeklyActivationCb
            // 
            this.SSWdWeeklyActivationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSWdWeeklyActivationCb.FormattingEnabled = true;
            this.SSWdWeeklyActivationCb.Location = new System.Drawing.Point(115, 90);
            this.SSWdWeeklyActivationCb.Name = "SSWdWeeklyActivationCb";
            this.SSWdWeeklyActivationCb.Size = new System.Drawing.Size(121, 21);
            this.SSWdWeeklyActivationCb.TabIndex = 28;
            this.SSWdWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.SSWdWeeklyActivationCb_SelectedIndexChanged);
            // 
            // SSWdIntervalTariffCb
            // 
            this.SSWdIntervalTariffCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSWdIntervalTariffCb.FormattingEnabled = true;
            this.SSWdIntervalTariffCb.Location = new System.Drawing.Point(115, 32);
            this.SSWdIntervalTariffCb.Name = "SSWdIntervalTariffCb";
            this.SSWdIntervalTariffCb.Size = new System.Drawing.Size(121, 21);
            this.SSWdIntervalTariffCb.TabIndex = 27;
            this.SSWdIntervalTariffCb.SelectedIndexChanged += new System.EventHandler(this.SSWdIntervalTariffCb_SelectedIndexChanged);
            // 
            // WdUseIntervalCb
            // 
            this.WdUseIntervalCb.AutoSize = true;
            this.WdUseIntervalCb.Location = new System.Drawing.Point(12, 64);
            this.WdUseIntervalCb.Name = "WdUseIntervalCb";
            this.WdUseIntervalCb.Size = new System.Drawing.Size(64, 13);
            this.WdUseIntervalCb.TabIndex = 26;
            this.WdUseIntervalCb.Text = "Use Interval";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(115, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(37, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SSWdSpecialDayTb
            // 
            this.SSWdSpecialDayTb.Location = new System.Drawing.Point(115, 117);
            this.SSWdSpecialDayTb.Name = "SSWdSpecialDayTb";
            this.SSWdSpecialDayTb.Size = new System.Drawing.Size(121, 20);
            this.SSWdSpecialDayTb.TabIndex = 17;
            this.SSWdSpecialDayTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSWdSpecialDayTb_KeyUp);
            this.SSWdSpecialDayTb.Leave += new System.EventHandler(this.SSWdSpecialDayTb_Leave);
            // 
            // WdWeeklyActivationLbl
            // 
            this.WdWeeklyActivationLbl.AutoSize = true;
            this.WdWeeklyActivationLbl.Location = new System.Drawing.Point(12, 93);
            this.WdWeeklyActivationLbl.Name = "WdWeeklyActivationLbl";
            this.WdWeeklyActivationLbl.Size = new System.Drawing.Size(96, 13);
            this.WdWeeklyActivationLbl.TabIndex = 14;
            this.WdWeeklyActivationLbl.Text = "Weekly Activation:";
            // 
            // IntervalTariffLbl
            // 
            this.IntervalTariffLbl.AutoSize = true;
            this.IntervalTariffLbl.Location = new System.Drawing.Point(12, 35);
            this.IntervalTariffLbl.Name = "IntervalTariffLbl";
            this.IntervalTariffLbl.Size = new System.Drawing.Size(72, 13);
            this.IntervalTariffLbl.TabIndex = 12;
            this.IntervalTariffLbl.Text = "Interval Tariff:";
            // 
            // SSWdStartHourTb
            // 
            this.SSWdStartHourTb.Location = new System.Drawing.Point(115, 6);
            this.SSWdStartHourTb.Name = "SSWdStartHourTb";
            this.SSWdStartHourTb.Size = new System.Drawing.Size(121, 20);
            this.SSWdStartHourTb.TabIndex = 11;
            this.SSWdStartHourTb.DragLeave += new System.EventHandler(this.SSWdStartHourTb_DragLeave);
            this.SSWdStartHourTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSWdStartHourTb_KeyUp);
            this.SSWdStartHourTb.Leave += new System.EventHandler(this.SSWdStartHourTb_Leave);
            // 
            // StartHourLbl
            // 
            this.StartHourLbl.AutoSize = true;
            this.StartHourLbl.Location = new System.Drawing.Point(12, 9);
            this.StartHourLbl.Name = "StartHourLbl";
            this.StartHourLbl.Size = new System.Drawing.Size(58, 13);
            this.StartHourLbl.TabIndex = 10;
            this.StartHourLbl.Text = "Start Hour:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.SSSiSpecialDayCb);
            this.tabPage5.Controls.Add(this.SSSiWeeklyActivationCb);
            this.tabPage5.Controls.Add(this.SSSiIntrvalTarifCb);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.SSSiUseIntervalCb);
            this.tabPage5.Controls.Add(this.SSSiSpecialDayTb);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.SSSiStartHourTb);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(379, 150);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Saturday Intervals";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "SpecialDay";
            // 
            // SSSiSpecialDayCb
            // 
            this.SSSiSpecialDayCb.Location = new System.Drawing.Point(244, 121);
            this.SSSiSpecialDayCb.Name = "SSSiSpecialDayCb";
            this.SSSiSpecialDayCb.Size = new System.Drawing.Size(37, 17);
            this.SSSiSpecialDayCb.TabIndex = 40;
            this.SSSiSpecialDayCb.UseVisualStyleBackColor = false;
            this.SSSiSpecialDayCb.CheckedChanged += new System.EventHandler(this.SSSiSpecialDayCb_CheckedChanged);
            // 
            // SSSiWeeklyActivationCb
            // 
            this.SSSiWeeklyActivationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSSiWeeklyActivationCb.FormattingEnabled = true;
            this.SSSiWeeklyActivationCb.Location = new System.Drawing.Point(118, 91);
            this.SSSiWeeklyActivationCb.Name = "SSSiWeeklyActivationCb";
            this.SSSiWeeklyActivationCb.Size = new System.Drawing.Size(121, 21);
            this.SSSiWeeklyActivationCb.TabIndex = 39;
            this.SSSiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.SSSiWeeklyActivationCb_SelectedIndexChanged);
            // 
            // SSSiIntrvalTarifCb
            // 
            this.SSSiIntrvalTarifCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSSiIntrvalTarifCb.FormattingEnabled = true;
            this.SSSiIntrvalTarifCb.Location = new System.Drawing.Point(118, 33);
            this.SSSiIntrvalTarifCb.Name = "SSSiIntrvalTarifCb";
            this.SSSiIntrvalTarifCb.Size = new System.Drawing.Size(121, 21);
            this.SSSiIntrvalTarifCb.TabIndex = 38;
            this.SSSiIntrvalTarifCb.SelectedIndexChanged += new System.EventHandler(this.SSSiIntrvalTarifCb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Use Interval";
            // 
            // SSSiUseIntervalCb
            // 
            this.SSSiUseIntervalCb.Location = new System.Drawing.Point(118, 65);
            this.SSSiUseIntervalCb.Name = "SSSiUseIntervalCb";
            this.SSSiUseIntervalCb.Size = new System.Drawing.Size(37, 17);
            this.SSSiUseIntervalCb.TabIndex = 36;
            this.SSSiUseIntervalCb.UseVisualStyleBackColor = false;
            this.SSSiUseIntervalCb.CheckedChanged += new System.EventHandler(this.SSSiUseIntervalCb_CheckedChanged);
            // 
            // SSSiSpecialDayTb
            // 
            this.SSSiSpecialDayTb.Location = new System.Drawing.Point(118, 118);
            this.SSSiSpecialDayTb.Name = "SSSiSpecialDayTb";
            this.SSSiSpecialDayTb.Size = new System.Drawing.Size(121, 20);
            this.SSSiSpecialDayTb.TabIndex = 35;
            this.SSSiSpecialDayTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSSiSpecialDayTb_KeyUp);
            this.SSSiSpecialDayTb.Leave += new System.EventHandler(this.SSSiSpecialDayTb_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Weekly Activation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Interval Tariff:";
            // 
            // SSSiStartHourTb
            // 
            this.SSSiStartHourTb.Location = new System.Drawing.Point(118, 7);
            this.SSSiStartHourTb.Name = "SSSiStartHourTb";
            this.SSSiStartHourTb.Size = new System.Drawing.Size(121, 20);
            this.SSSiStartHourTb.TabIndex = 32;
            this.SSSiStartHourTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSSiStartHourTb_KeyUp);
            this.SSSiStartHourTb.Leave += new System.EventHandler(this.SSSiStartHourTb_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Start Hour:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Controls.Add(this.SSHiSpecialDayCb);
            this.tabPage6.Controls.Add(this.SSHiWeeklyActivationCb);
            this.tabPage6.Controls.Add(this.SSHiIntervalTarifCb);
            this.tabPage6.Controls.Add(this.label8);
            this.tabPage6.Controls.Add(this.SSHiUseIntervalCb);
            this.tabPage6.Controls.Add(this.SSHiSpecialDayTb);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.SSHiStartHourTb);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(379, 150);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Holiday Intervals";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "SpecialDay";
            // 
            // SSHiSpecialDayCb
            // 
            this.SSHiSpecialDayCb.Location = new System.Drawing.Point(241, 121);
            this.SSHiSpecialDayCb.Name = "SSHiSpecialDayCb";
            this.SSHiSpecialDayCb.Size = new System.Drawing.Size(37, 17);
            this.SSHiSpecialDayCb.TabIndex = 40;
            this.SSHiSpecialDayCb.UseVisualStyleBackColor = false;
            this.SSHiSpecialDayCb.CheckedChanged += new System.EventHandler(this.SSHiSpecialDayCb_CheckedChanged);
            // 
            // SSHiWeeklyActivationCb
            // 
            this.SSHiWeeklyActivationCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSHiWeeklyActivationCb.FormattingEnabled = true;
            this.SSHiWeeklyActivationCb.Location = new System.Drawing.Point(115, 91);
            this.SSHiWeeklyActivationCb.Name = "SSHiWeeklyActivationCb";
            this.SSHiWeeklyActivationCb.Size = new System.Drawing.Size(121, 21);
            this.SSHiWeeklyActivationCb.TabIndex = 39;
            this.SSHiWeeklyActivationCb.SelectedIndexChanged += new System.EventHandler(this.SSHiWeeklyActivationCb_SelectedIndexChanged);
            // 
            // SSHiIntervalTarifCb
            // 
            this.SSHiIntervalTarifCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SSHiIntervalTarifCb.FormattingEnabled = true;
            this.SSHiIntervalTarifCb.Location = new System.Drawing.Point(115, 33);
            this.SSHiIntervalTarifCb.Name = "SSHiIntervalTarifCb";
            this.SSHiIntervalTarifCb.Size = new System.Drawing.Size(121, 21);
            this.SSHiIntervalTarifCb.TabIndex = 38;
            this.SSHiIntervalTarifCb.SelectedIndexChanged += new System.EventHandler(this.SSHiIntervalTarifCb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Use Interval";
            // 
            // SSHiUseIntervalCb
            // 
            this.SSHiUseIntervalCb.Location = new System.Drawing.Point(115, 65);
            this.SSHiUseIntervalCb.Name = "SSHiUseIntervalCb";
            this.SSHiUseIntervalCb.Size = new System.Drawing.Size(37, 17);
            this.SSHiUseIntervalCb.TabIndex = 36;
            this.SSHiUseIntervalCb.UseVisualStyleBackColor = false;
            this.SSHiUseIntervalCb.CheckedChanged += new System.EventHandler(this.SSHiUseIntervalCb_CheckedChanged);
            // 
            // SSHiSpecialDayTb
            // 
            this.SSHiSpecialDayTb.Location = new System.Drawing.Point(115, 118);
            this.SSHiSpecialDayTb.Name = "SSHiSpecialDayTb";
            this.SSHiSpecialDayTb.Size = new System.Drawing.Size(121, 20);
            this.SSHiSpecialDayTb.TabIndex = 35;
            this.SSHiSpecialDayTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSHiSpecialDayTb_KeyUp);
            this.SSHiSpecialDayTb.Leave += new System.EventHandler(this.SSHiSpecialDayTb_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Weekly Activation:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Interval Tariff:";
            // 
            // SSHiStartHourTb
            // 
            this.SSHiStartHourTb.Location = new System.Drawing.Point(115, 7);
            this.SSHiStartHourTb.Name = "SSHiStartHourTb";
            this.SSHiStartHourTb.Size = new System.Drawing.Size(121, 20);
            this.SSHiStartHourTb.TabIndex = 32;
            this.SSHiStartHourTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SSHiStartHourTb_KeyUp);
            this.SSHiStartHourTb.Leave += new System.EventHandler(this.SSHiStartHourTb_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Start Hour:";
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
            this.DescriptionTB.Size = new System.Drawing.Size(351, 20);
            this.DescriptionTB.TabIndex = 1;
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
            // ActivationTimeTb
            // 
            this.ActivationTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivationTimeTb.Index = 5;
            this.ActivationTimeTb.Location = new System.Drawing.Point(104, 120);
            this.ActivationTimeTb.Name = "ActivationTimeTb";
            this.ActivationTimeTb.NotifyChanges = false;
            this.ActivationTimeTb.Size = new System.Drawing.Size(350, 20);
            this.ActivationTimeTb.TabIndex = 25;
            this.ActivationTimeTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // CalendarNameTb
            // 
            this.CalendarNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalendarNameTb.Index = 2;
            this.CalendarNameTb.Location = new System.Drawing.Point(103, 71);
            this.CalendarNameTb.Name = "CalendarNameTb";
            this.CalendarNameTb.NotifyChanges = false;
            this.CalendarNameTb.Size = new System.Drawing.Size(350, 20);
            this.CalendarNameTb.TabIndex = 0;
            this.CalendarNameTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            this.CalendarNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CalendarNameTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(350, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // GXDLMSTariffPlanView
            // 
            this.ClientSize = new System.Drawing.Size(499, 523);
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
        private TextBox SSWdStartHourTb;
        private Label StartHourLbl;
        private Label WdUseIntervalCb;
        private CheckBox checkBox1;
        private TextBox SSWdSpecialDayTb;
        private Label WdWeeklyActivationLbl;
        private Label IntervalTariffLbl;
        private ComboBox SSWdIntervalTariffCb;
        private ComboBox SSWdWeeklyActivationCb;
        private Label WdSpecialDayEnabledCb;
        private CheckBox SSWdSpecialDayCb;
        private Label label2;
        private CheckBox SSSiSpecialDayCb;
        private ComboBox SSSiWeeklyActivationCb;
        private ComboBox SSSiIntrvalTarifCb;
        private Label label3;
        private CheckBox SSSiUseIntervalCb;
        private TextBox SSSiSpecialDayTb;
        private Label label4;
        private Label label5;
        private TextBox SSSiStartHourTb;
        private Label label6;
        private Label label7;
        private CheckBox SSHiSpecialDayCb;
        private ComboBox SSHiWeeklyActivationCb;
        private ComboBox SSHiIntervalTarifCb;
        private Label label8;
        private CheckBox SSHiUseIntervalCb;
        private TextBox SSHiSpecialDayTb;
        private Label label9;
        private Label label10;
        private TextBox SSHiStartHourTb;
        private Label label11;
        private TabControl tabControl2;
        private TabPage tabPage7;
        private Label label12;
        private CheckBox WsWdSpecialDayEnabled;
        private ComboBox WsWdWeeklyActivationCb;
        private ComboBox WsWdIntervalTariffCb;
        private Label label13;
        private CheckBox WsWdIntervalCb;
        private TextBox WsWdSpecialDayTb;
        private Label label14;
        private Label label15;
        private TextBox WsWdStartHourTb;
        private Label label16;
        private TabPage tabPage8;
        private Label label17;
        private CheckBox WsSiSpecialDayCb;
        private ComboBox WsSiWeeklyActivationCb;
        private ComboBox WsSiIntervalTariffTb;
        private Label label18;
        private CheckBox WsSiIntervalEnabled;
        private TextBox WsSiSpecialDayTb;
        private Label label19;
        private Label label20;
        private TextBox WsSiStartHourTb;
        private Label label21;
        private TabPage tabPage9;
        private Label label22;
        private CheckBox WsHiSpecialDayCb;
        private ComboBox WsHiWeeklyActivationCb;
        private ComboBox WsHiIntervalTarifCb;
        private Label label23;
        private CheckBox WsHiUseIntervalCb;
        private TextBox WsHiSpecialDayTb;
        private Label label24;
        private Label label25;
        private TextBox WsHiStartHourTb;
        private Label label26;
    }
}
