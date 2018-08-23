using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSActivityCalendarView
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
        private TabControl tabControl1;
        private TabPage ActiveTab;
        private GXValueField ACalendarNameTB;
        private Label ACalendarNameLbl;
        private TabPage PassiveTab;
        private GXValueField PCalendarNameTB;
        private Label PCalendarNameLbl;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSActivityCalendarView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ActivatePassiveCalendarLbl = new System.Windows.Forms.Label();
            this.ActivatePassiveCalendarTb = new Gurux.DLMS.UI.GXValueField();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActiveTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.SeasonProfileActiveTab = new System.Windows.Forms.TabPage();
            this.SeasonProfileActiveLV = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeekNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SeasonProfileActiveRemoveBtn = new System.Windows.Forms.Button();
            this.SeasonProfileActiveEditBtn = new System.Windows.Forms.Button();
            this.SeasonProfileActiveAddBtn = new System.Windows.Forms.Button();
            this.WeekProfileActiveTab = new System.Windows.Forms.TabPage();
            this.AWeekProfileLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MonHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WedHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThuHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FriHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SunHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.WeekProfileActiveRemoveBtn = new System.Windows.Forms.Button();
            this.WeekProfileActiveEditBtn = new System.Windows.Forms.Button();
            this.WeekProfileActiveAddBtn = new System.Windows.Forms.Button();
            this.DayProfileActiveTab = new System.Windows.Forms.TabPage();
            this.ActiveActionList = new System.Windows.Forms.ListView();
            this.AStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AScriptCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ASelectorCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ActiveDaysList = new System.Windows.Forms.ListView();
            this.DayIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddDayActiveBtn = new System.Windows.Forms.Button();
            this.DayProfileActiveRemoveBtn = new System.Windows.Forms.Button();
            this.DayProfileActiveEditBtn = new System.Windows.Forms.Button();
            this.ActiveActionAddBtn = new System.Windows.Forms.Button();
            this.ACalendarNameTB = new Gurux.DLMS.UI.GXValueField();
            this.ACalendarNameLbl = new System.Windows.Forms.Label();
            this.PassiveTab = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.SeasonProfilePassiveTab = new System.Windows.Forms.TabPage();
            this.SeasonProfilePassiveLV = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.SeasonProfilePassiveRemoveBtn = new System.Windows.Forms.Button();
            this.SeasonProfilePassiveEditBtn = new System.Windows.Forms.Button();
            this.SeasonProfilePassiveAddBtn = new System.Windows.Forms.Button();
            this.WeekProfilePassiveTab = new System.Windows.Forms.TabPage();
            this.PWeekProfileLV = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.WeekProfilePassiveRemoveBtn = new System.Windows.Forms.Button();
            this.WeekProfilePassiveEditBtn = new System.Windows.Forms.Button();
            this.WeekProfilePassiveAddBtn = new System.Windows.Forms.Button();
            this.DayProfilePassiveTab = new System.Windows.Forms.TabPage();
            this.PassiveActionList = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PassiveDaysList = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel6 = new System.Windows.Forms.Panel();
            this.AddDayPassiveBtn = new System.Windows.Forms.Button();
            this.PassiveActionAddBtn = new System.Windows.Forms.Button();
            this.DayProfilePassiveRemoveBtn = new System.Windows.Forms.Button();
            this.DayProfilePassiveEditBtn = new System.Windows.Forms.Button();
            this.PCalendarNameLbl = new System.Windows.Forms.Label();
            this.PCalendarNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActivatePassiveCalendarBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ActiveTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SeasonProfileActiveTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.WeekProfileActiveTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DayProfileActiveTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PassiveTab.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.SeasonProfilePassiveTab.SuspendLayout();
            this.panel4.SuspendLayout();
            this.WeekProfilePassiveTab.SuspendLayout();
            this.panel5.SuspendLayout();
            this.DayProfilePassiveTab.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ActivatePassiveCalendarLbl);
            this.groupBox1.Controls.Add(this.ActivatePassiveCalendarTb);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 618);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Calendar Object";
            // 
            // ActivatePassiveCalendarLbl
            // 
            this.ActivatePassiveCalendarLbl.AutoSize = true;
            this.ActivatePassiveCalendarLbl.Location = new System.Drawing.Point(6, 51);
            this.ActivatePassiveCalendarLbl.Name = "ActivatePassiveCalendarLbl";
            this.ActivatePassiveCalendarLbl.Size = new System.Drawing.Size(132, 13);
            this.ActivatePassiveCalendarLbl.TabIndex = 23;
            this.ActivatePassiveCalendarLbl.Text = "Activate passive calendar:";
            // 
            // ActivatePassiveCalendarTb
            // 
            this.ActivatePassiveCalendarTb.Index = 10;
            this.ActivatePassiveCalendarTb.Location = new System.Drawing.Point(144, 48);
            this.ActivatePassiveCalendarTb.Name = "ActivatePassiveCalendarTb";
            this.ActivatePassiveCalendarTb.NotifyChanges = false;
            this.ActivatePassiveCalendarTb.ReadOnly = true;
            this.ActivatePassiveCalendarTb.Size = new System.Drawing.Size(166, 20);
            this.ActivatePassiveCalendarTb.TabIndex = 22;
            this.ActivatePassiveCalendarTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ActiveTab);
            this.tabControl1.Controls.Add(this.PassiveTab);
            this.tabControl1.Location = new System.Drawing.Point(6, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(495, 531);
            this.tabControl1.TabIndex = 4;
            // 
            // ActiveTab
            // 
            this.ActiveTab.Controls.Add(this.tabControl2);
            this.ActiveTab.Controls.Add(this.ACalendarNameTB);
            this.ActiveTab.Controls.Add(this.ACalendarNameLbl);
            this.ActiveTab.Location = new System.Drawing.Point(4, 22);
            this.ActiveTab.Name = "ActiveTab";
            this.ActiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveTab.Size = new System.Drawing.Size(487, 505);
            this.ActiveTab.TabIndex = 0;
            this.ActiveTab.Text = "Active";
            this.ActiveTab.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.SeasonProfileActiveTab);
            this.tabControl2.Controls.Add(this.WeekProfileActiveTab);
            this.tabControl2.Controls.Add(this.DayProfileActiveTab);
            this.tabControl2.Location = new System.Drawing.Point(11, 38);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(467, 464);
            this.tabControl2.TabIndex = 20;
            // 
            // SeasonProfileActiveTab
            // 
            this.SeasonProfileActiveTab.Controls.Add(this.SeasonProfileActiveLV);
            this.SeasonProfileActiveTab.Controls.Add(this.panel1);
            this.SeasonProfileActiveTab.Location = new System.Drawing.Point(4, 22);
            this.SeasonProfileActiveTab.Name = "SeasonProfileActiveTab";
            this.SeasonProfileActiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.SeasonProfileActiveTab.Size = new System.Drawing.Size(459, 438);
            this.SeasonProfileActiveTab.TabIndex = 0;
            this.SeasonProfileActiveTab.Text = "Season Profile";
            this.SeasonProfileActiveTab.UseVisualStyleBackColor = true;
            // 
            // SeasonProfileActiveLV
            // 
            this.SeasonProfileActiveLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfileActiveLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.StartHeader,
            this.WeekNameHeader});
            this.SeasonProfileActiveLV.FullRowSelect = true;
            this.SeasonProfileActiveLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SeasonProfileActiveLV.HideSelection = false;
            this.SeasonProfileActiveLV.Location = new System.Drawing.Point(3, 3);
            this.SeasonProfileActiveLV.Name = "SeasonProfileActiveLV";
            this.SeasonProfileActiveLV.Size = new System.Drawing.Size(433, 385);
            this.SeasonProfileActiveLV.TabIndex = 17;
            this.SeasonProfileActiveLV.UseCompatibleStateImageBehavior = false;
            this.SeasonProfileActiveLV.View = System.Windows.Forms.View.Details;
            this.SeasonProfileActiveLV.DoubleClick += new System.EventHandler(this.SeasonProfileActiveEditBtn_Click);
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 91;
            // 
            // StartHeader
            // 
            this.StartHeader.Text = "Start";
            this.StartHeader.Width = 114;
            // 
            // WeekNameHeader
            // 
            this.WeekNameHeader.Text = "Week Name";
            this.WeekNameHeader.Width = 218;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SeasonProfileActiveRemoveBtn);
            this.panel1.Controls.Add(this.SeasonProfileActiveEditBtn);
            this.panel1.Controls.Add(this.SeasonProfileActiveAddBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 47);
            this.panel1.TabIndex = 0;
            // 
            // SeasonProfileActiveRemoveBtn
            // 
            this.SeasonProfileActiveRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfileActiveRemoveBtn.Location = new System.Drawing.Point(375, 11);
            this.SeasonProfileActiveRemoveBtn.Name = "SeasonProfileActiveRemoveBtn";
            this.SeasonProfileActiveRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.SeasonProfileActiveRemoveBtn.TabIndex = 20;
            this.SeasonProfileActiveRemoveBtn.Text = "Remove";
            this.SeasonProfileActiveRemoveBtn.UseVisualStyleBackColor = true;
            this.SeasonProfileActiveRemoveBtn.Click += new System.EventHandler(this.SeasonProfileActiveRemoveBtn_Click);
            // 
            // SeasonProfileActiveEditBtn
            // 
            this.SeasonProfileActiveEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfileActiveEditBtn.Location = new System.Drawing.Point(294, 11);
            this.SeasonProfileActiveEditBtn.Name = "SeasonProfileActiveEditBtn";
            this.SeasonProfileActiveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.SeasonProfileActiveEditBtn.TabIndex = 19;
            this.SeasonProfileActiveEditBtn.Text = "Edit...";
            this.SeasonProfileActiveEditBtn.UseVisualStyleBackColor = true;
            this.SeasonProfileActiveEditBtn.Click += new System.EventHandler(this.SeasonProfileActiveEditBtn_Click);
            // 
            // SeasonProfileActiveAddBtn
            // 
            this.SeasonProfileActiveAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfileActiveAddBtn.Location = new System.Drawing.Point(213, 11);
            this.SeasonProfileActiveAddBtn.Name = "SeasonProfileActiveAddBtn";
            this.SeasonProfileActiveAddBtn.Size = new System.Drawing.Size(75, 23);
            this.SeasonProfileActiveAddBtn.TabIndex = 18;
            this.SeasonProfileActiveAddBtn.Text = "Add...";
            this.SeasonProfileActiveAddBtn.UseVisualStyleBackColor = true;
            this.SeasonProfileActiveAddBtn.Click += new System.EventHandler(this.SeasonProfileActiveAddBtn_Click);
            // 
            // WeekProfileActiveTab
            // 
            this.WeekProfileActiveTab.Controls.Add(this.AWeekProfileLV);
            this.WeekProfileActiveTab.Controls.Add(this.panel2);
            this.WeekProfileActiveTab.Location = new System.Drawing.Point(4, 22);
            this.WeekProfileActiveTab.Name = "WeekProfileActiveTab";
            this.WeekProfileActiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.WeekProfileActiveTab.Size = new System.Drawing.Size(459, 438);
            this.WeekProfileActiveTab.TabIndex = 1;
            this.WeekProfileActiveTab.Text = "Week Profile";
            this.WeekProfileActiveTab.UseVisualStyleBackColor = true;
            // 
            // AWeekProfileLV
            // 
            this.AWeekProfileLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AWeekProfileLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.MonHeader,
            this.TueHeader,
            this.WedHeader,
            this.ThuHeader,
            this.FriHeader,
            this.SatHeader,
            this.SunHeader});
            this.AWeekProfileLV.FullRowSelect = true;
            this.AWeekProfileLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AWeekProfileLV.HideSelection = false;
            this.AWeekProfileLV.Location = new System.Drawing.Point(3, 3);
            this.AWeekProfileLV.Name = "AWeekProfileLV";
            this.AWeekProfileLV.Size = new System.Drawing.Size(436, 385);
            this.AWeekProfileLV.TabIndex = 17;
            this.AWeekProfileLV.UseCompatibleStateImageBehavior = false;
            this.AWeekProfileLV.View = System.Windows.Forms.View.Details;
            this.AWeekProfileLV.DoubleClick += new System.EventHandler(this.WeekProfileActiveEditBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 49;
            // 
            // MonHeader
            // 
            this.MonHeader.Text = "Mon";
            this.MonHeader.Width = 50;
            // 
            // TueHeader
            // 
            this.TueHeader.Text = "Tue";
            // 
            // WedHeader
            // 
            this.WedHeader.Text = "Wed";
            // 
            // ThuHeader
            // 
            this.ThuHeader.Text = "Thu";
            // 
            // FriHeader
            // 
            this.FriHeader.Text = "Fri";
            this.FriHeader.Width = 73;
            // 
            // SatHeader
            // 
            this.SatHeader.Text = "Sat";
            this.SatHeader.Width = 78;
            // 
            // SunHeader
            // 
            this.SunHeader.Text = "Sun";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.WeekProfileActiveRemoveBtn);
            this.panel2.Controls.Add(this.WeekProfileActiveEditBtn);
            this.panel2.Controls.Add(this.WeekProfileActiveAddBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 47);
            this.panel2.TabIndex = 1;
            // 
            // WeekProfileActiveRemoveBtn
            // 
            this.WeekProfileActiveRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekProfileActiveRemoveBtn.Location = new System.Drawing.Point(375, 11);
            this.WeekProfileActiveRemoveBtn.Name = "WeekProfileActiveRemoveBtn";
            this.WeekProfileActiveRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.WeekProfileActiveRemoveBtn.TabIndex = 20;
            this.WeekProfileActiveRemoveBtn.Text = "Remove";
            this.WeekProfileActiveRemoveBtn.UseVisualStyleBackColor = true;
            this.WeekProfileActiveRemoveBtn.Click += new System.EventHandler(this.WeekProfileActiveRemoveBtn_Click);
            // 
            // WeekProfileActiveEditBtn
            // 
            this.WeekProfileActiveEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekProfileActiveEditBtn.Location = new System.Drawing.Point(294, 11);
            this.WeekProfileActiveEditBtn.Name = "WeekProfileActiveEditBtn";
            this.WeekProfileActiveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.WeekProfileActiveEditBtn.TabIndex = 19;
            this.WeekProfileActiveEditBtn.Text = "Edit...";
            this.WeekProfileActiveEditBtn.UseVisualStyleBackColor = true;
            this.WeekProfileActiveEditBtn.Click += new System.EventHandler(this.WeekProfileActiveEditBtn_Click);
            // 
            // WeekProfileActiveAddBtn
            // 
            this.WeekProfileActiveAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekProfileActiveAddBtn.Location = new System.Drawing.Point(213, 11);
            this.WeekProfileActiveAddBtn.Name = "WeekProfileActiveAddBtn";
            this.WeekProfileActiveAddBtn.Size = new System.Drawing.Size(75, 23);
            this.WeekProfileActiveAddBtn.TabIndex = 18;
            this.WeekProfileActiveAddBtn.Text = "Add...";
            this.WeekProfileActiveAddBtn.UseVisualStyleBackColor = true;
            this.WeekProfileActiveAddBtn.Click += new System.EventHandler(this.WeekProfileActiveAddBtn_Click);
            // 
            // DayProfileActiveTab
            // 
            this.DayProfileActiveTab.Controls.Add(this.ActiveActionList);
            this.DayProfileActiveTab.Controls.Add(this.splitter1);
            this.DayProfileActiveTab.Controls.Add(this.ActiveDaysList);
            this.DayProfileActiveTab.Controls.Add(this.panel3);
            this.DayProfileActiveTab.Location = new System.Drawing.Point(4, 22);
            this.DayProfileActiveTab.Name = "DayProfileActiveTab";
            this.DayProfileActiveTab.Size = new System.Drawing.Size(459, 438);
            this.DayProfileActiveTab.TabIndex = 2;
            this.DayProfileActiveTab.Text = "Day Profile";
            this.DayProfileActiveTab.UseVisualStyleBackColor = true;
            // 
            // ActiveActionList
            // 
            this.ActiveActionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveActionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AStartTime,
            this.AScriptCh,
            this.ASelectorCh});
            this.ActiveActionList.FullRowSelect = true;
            this.ActiveActionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActiveActionList.HideSelection = false;
            this.ActiveActionList.Location = new System.Drawing.Point(105, 0);
            this.ActiveActionList.Name = "ActiveActionList";
            this.ActiveActionList.Size = new System.Drawing.Size(332, 391);
            this.ActiveActionList.TabIndex = 20;
            this.ActiveActionList.UseCompatibleStateImageBehavior = false;
            this.ActiveActionList.View = System.Windows.Forms.View.Details;
            this.ActiveActionList.DoubleClick += new System.EventHandler(this.DayProfileActiveEditBtn_Click);
            // 
            // AStartTime
            // 
            this.AStartTime.Text = "Start Time";
            this.AStartTime.Width = 91;
            // 
            // AScriptCh
            // 
            this.AScriptCh.Text = "Script";
            this.AScriptCh.Width = 87;
            // 
            // ASelectorCh
            // 
            this.ASelectorCh.Text = "Selector";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(102, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 391);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // ActiveDaysList
            // 
            this.ActiveDaysList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DayIdHeader});
            this.ActiveDaysList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ActiveDaysList.FullRowSelect = true;
            this.ActiveDaysList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActiveDaysList.HideSelection = false;
            this.ActiveDaysList.Location = new System.Drawing.Point(0, 0);
            this.ActiveDaysList.Name = "ActiveDaysList";
            this.ActiveDaysList.Size = new System.Drawing.Size(102, 391);
            this.ActiveDaysList.TabIndex = 18;
            this.ActiveDaysList.UseCompatibleStateImageBehavior = false;
            this.ActiveDaysList.View = System.Windows.Forms.View.Details;
            this.ActiveDaysList.SelectedIndexChanged += new System.EventHandler(this.ActiveDaysList_SelectedIndexChanged);
            this.ActiveDaysList.DoubleClick += new System.EventHandler(this.DayProfileActiveEditBtn_Click);
            // 
            // DayIdHeader
            // 
            this.DayIdHeader.Text = "Day ID";
            this.DayIdHeader.Width = 91;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddDayActiveBtn);
            this.panel3.Controls.Add(this.DayProfileActiveRemoveBtn);
            this.panel3.Controls.Add(this.DayProfileActiveEditBtn);
            this.panel3.Controls.Add(this.ActiveActionAddBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 47);
            this.panel3.TabIndex = 1;
            // 
            // AddDayActiveBtn
            // 
            this.AddDayActiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDayActiveBtn.Location = new System.Drawing.Point(128, 11);
            this.AddDayActiveBtn.Name = "AddDayActiveBtn";
            this.AddDayActiveBtn.Size = new System.Drawing.Size(75, 23);
            this.AddDayActiveBtn.TabIndex = 21;
            this.AddDayActiveBtn.Text = "Add Day...";
            this.AddDayActiveBtn.UseVisualStyleBackColor = true;
            this.AddDayActiveBtn.Click += new System.EventHandler(this.AddDayActiveBtn_Click);
            // 
            // DayProfileActiveRemoveBtn
            // 
            this.DayProfileActiveRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayProfileActiveRemoveBtn.Location = new System.Drawing.Point(381, 11);
            this.DayProfileActiveRemoveBtn.Name = "DayProfileActiveRemoveBtn";
            this.DayProfileActiveRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.DayProfileActiveRemoveBtn.TabIndex = 20;
            this.DayProfileActiveRemoveBtn.Text = "Remove";
            this.DayProfileActiveRemoveBtn.UseVisualStyleBackColor = true;
            this.DayProfileActiveRemoveBtn.Click += new System.EventHandler(this.DayProfileActiveRemoveBtn_Click);
            // 
            // DayProfileActiveEditBtn
            // 
            this.DayProfileActiveEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayProfileActiveEditBtn.Location = new System.Drawing.Point(300, 11);
            this.DayProfileActiveEditBtn.Name = "DayProfileActiveEditBtn";
            this.DayProfileActiveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.DayProfileActiveEditBtn.TabIndex = 19;
            this.DayProfileActiveEditBtn.Text = "Edit...";
            this.DayProfileActiveEditBtn.UseVisualStyleBackColor = true;
            this.DayProfileActiveEditBtn.Click += new System.EventHandler(this.DayProfileActiveEditBtn_Click);
            // 
            // ActiveActionAddBtn
            // 
            this.ActiveActionAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveActionAddBtn.Location = new System.Drawing.Point(209, 11);
            this.ActiveActionAddBtn.Name = "ActiveActionAddBtn";
            this.ActiveActionAddBtn.Size = new System.Drawing.Size(85, 23);
            this.ActiveActionAddBtn.TabIndex = 18;
            this.ActiveActionAddBtn.Text = "Add Action...";
            this.ActiveActionAddBtn.UseVisualStyleBackColor = true;
            this.ActiveActionAddBtn.Click += new System.EventHandler(this.ActiveActionAddBtn_Click);
            // 
            // ACalendarNameTB
            // 
            this.ACalendarNameTB.Index = 2;
            this.ACalendarNameTB.Location = new System.Drawing.Point(104, 12);
            this.ACalendarNameTB.Name = "ACalendarNameTB";
            this.ACalendarNameTB.NotifyChanges = false;
            this.ACalendarNameTB.ReadOnly = true;
            this.ACalendarNameTB.Size = new System.Drawing.Size(208, 20);
            this.ACalendarNameTB.TabIndex = 12;
            this.ACalendarNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ACalendarNameLbl
            // 
            this.ACalendarNameLbl.AutoSize = true;
            this.ACalendarNameLbl.Location = new System.Drawing.Point(8, 15);
            this.ACalendarNameLbl.Name = "ACalendarNameLbl";
            this.ACalendarNameLbl.Size = new System.Drawing.Size(83, 13);
            this.ACalendarNameLbl.TabIndex = 13;
            this.ACalendarNameLbl.Text = "Calendar Name:";
            // 
            // PassiveTab
            // 
            this.PassiveTab.Controls.Add(this.ActivatePassiveCalendarBtn);
            this.PassiveTab.Controls.Add(this.tabControl3);
            this.PassiveTab.Controls.Add(this.PCalendarNameLbl);
            this.PassiveTab.Controls.Add(this.PCalendarNameTB);
            this.PassiveTab.Location = new System.Drawing.Point(4, 22);
            this.PassiveTab.Name = "PassiveTab";
            this.PassiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.PassiveTab.Size = new System.Drawing.Size(487, 505);
            this.PassiveTab.TabIndex = 1;
            this.PassiveTab.Text = "Passive";
            this.PassiveTab.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.SeasonProfilePassiveTab);
            this.tabControl3.Controls.Add(this.WeekProfilePassiveTab);
            this.tabControl3.Controls.Add(this.DayProfilePassiveTab);
            this.tabControl3.Location = new System.Drawing.Point(11, 38);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(470, 464);
            this.tabControl3.TabIndex = 28;
            // 
            // SeasonProfilePassiveTab
            // 
            this.SeasonProfilePassiveTab.Controls.Add(this.SeasonProfilePassiveLV);
            this.SeasonProfilePassiveTab.Controls.Add(this.panel4);
            this.SeasonProfilePassiveTab.Location = new System.Drawing.Point(4, 22);
            this.SeasonProfilePassiveTab.Name = "SeasonProfilePassiveTab";
            this.SeasonProfilePassiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.SeasonProfilePassiveTab.Size = new System.Drawing.Size(462, 438);
            this.SeasonProfilePassiveTab.TabIndex = 0;
            this.SeasonProfilePassiveTab.Text = "Season Profile";
            this.SeasonProfilePassiveTab.UseVisualStyleBackColor = true;
            // 
            // SeasonProfilePassiveLV
            // 
            this.SeasonProfilePassiveLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfilePassiveLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader16});
            this.SeasonProfilePassiveLV.FullRowSelect = true;
            this.SeasonProfilePassiveLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SeasonProfilePassiveLV.HideSelection = false;
            this.SeasonProfilePassiveLV.Location = new System.Drawing.Point(3, 3);
            this.SeasonProfilePassiveLV.Name = "SeasonProfilePassiveLV";
            this.SeasonProfilePassiveLV.Size = new System.Drawing.Size(434, 385);
            this.SeasonProfilePassiveLV.TabIndex = 24;
            this.SeasonProfilePassiveLV.UseCompatibleStateImageBehavior = false;
            this.SeasonProfilePassiveLV.View = System.Windows.Forms.View.Details;
            this.SeasonProfilePassiveLV.DoubleClick += new System.EventHandler(this.SeasonProfilePassiveEditBtn_Click);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Name";
            this.columnHeader10.Width = 95;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Start";
            this.columnHeader11.Width = 111;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Week Name";
            this.columnHeader16.Width = 232;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SeasonProfilePassiveRemoveBtn);
            this.panel4.Controls.Add(this.SeasonProfilePassiveEditBtn);
            this.panel4.Controls.Add(this.SeasonProfilePassiveAddBtn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 388);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 47);
            this.panel4.TabIndex = 1;
            // 
            // SeasonProfilePassiveRemoveBtn
            // 
            this.SeasonProfilePassiveRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfilePassiveRemoveBtn.Location = new System.Drawing.Point(378, 11);
            this.SeasonProfilePassiveRemoveBtn.Name = "SeasonProfilePassiveRemoveBtn";
            this.SeasonProfilePassiveRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.SeasonProfilePassiveRemoveBtn.TabIndex = 20;
            this.SeasonProfilePassiveRemoveBtn.Text = "Remove";
            this.SeasonProfilePassiveRemoveBtn.UseVisualStyleBackColor = true;
            this.SeasonProfilePassiveRemoveBtn.Click += new System.EventHandler(this.SeasonProfilePassiveRemoveBtn_Click);
            // 
            // SeasonProfilePassiveEditBtn
            // 
            this.SeasonProfilePassiveEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfilePassiveEditBtn.Location = new System.Drawing.Point(297, 11);
            this.SeasonProfilePassiveEditBtn.Name = "SeasonProfilePassiveEditBtn";
            this.SeasonProfilePassiveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.SeasonProfilePassiveEditBtn.TabIndex = 19;
            this.SeasonProfilePassiveEditBtn.Text = "Edit...";
            this.SeasonProfilePassiveEditBtn.UseVisualStyleBackColor = true;
            this.SeasonProfilePassiveEditBtn.Click += new System.EventHandler(this.SeasonProfilePassiveEditBtn_Click);
            // 
            // SeasonProfilePassiveAddBtn
            // 
            this.SeasonProfilePassiveAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SeasonProfilePassiveAddBtn.Location = new System.Drawing.Point(216, 11);
            this.SeasonProfilePassiveAddBtn.Name = "SeasonProfilePassiveAddBtn";
            this.SeasonProfilePassiveAddBtn.Size = new System.Drawing.Size(75, 23);
            this.SeasonProfilePassiveAddBtn.TabIndex = 18;
            this.SeasonProfilePassiveAddBtn.Text = "Add...";
            this.SeasonProfilePassiveAddBtn.UseVisualStyleBackColor = true;
            this.SeasonProfilePassiveAddBtn.Click += new System.EventHandler(this.SeasonProfilePassiveAddBtn_Click);
            // 
            // WeekProfilePassiveTab
            // 
            this.WeekProfilePassiveTab.Controls.Add(this.PWeekProfileLV);
            this.WeekProfilePassiveTab.Controls.Add(this.panel5);
            this.WeekProfilePassiveTab.Location = new System.Drawing.Point(4, 22);
            this.WeekProfilePassiveTab.Name = "WeekProfilePassiveTab";
            this.WeekProfilePassiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.WeekProfilePassiveTab.Size = new System.Drawing.Size(462, 438);
            this.WeekProfilePassiveTab.TabIndex = 1;
            this.WeekProfilePassiveTab.Text = "Week Profile";
            this.WeekProfilePassiveTab.UseVisualStyleBackColor = true;
            // 
            // PWeekProfileLV
            // 
            this.PWeekProfileLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWeekProfileLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.PWeekProfileLV.FullRowSelect = true;
            this.PWeekProfileLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PWeekProfileLV.HideSelection = false;
            this.PWeekProfileLV.Location = new System.Drawing.Point(3, 3);
            this.PWeekProfileLV.Name = "PWeekProfileLV";
            this.PWeekProfileLV.Size = new System.Drawing.Size(434, 385);
            this.PWeekProfileLV.TabIndex = 25;
            this.PWeekProfileLV.UseCompatibleStateImageBehavior = false;
            this.PWeekProfileLV.View = System.Windows.Forms.View.Details;
            this.PWeekProfileLV.DoubleClick += new System.EventHandler(this.WeekProfilePassiveEditBtn_Click);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 49;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mon";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tue";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Wed";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thu";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Fri";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sat";
            this.columnHeader8.Width = 78;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sun";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.WeekProfilePassiveRemoveBtn);
            this.panel5.Controls.Add(this.WeekProfilePassiveEditBtn);
            this.panel5.Controls.Add(this.WeekProfilePassiveAddBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 388);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 47);
            this.panel5.TabIndex = 1;
            // 
            // WeekProfilePassiveRemoveBtn
            // 
            this.WeekProfilePassiveRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekProfilePassiveRemoveBtn.Location = new System.Drawing.Point(378, 11);
            this.WeekProfilePassiveRemoveBtn.Name = "WeekProfilePassiveRemoveBtn";
            this.WeekProfilePassiveRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.WeekProfilePassiveRemoveBtn.TabIndex = 20;
            this.WeekProfilePassiveRemoveBtn.Text = "Remove";
            this.WeekProfilePassiveRemoveBtn.UseVisualStyleBackColor = true;
            this.WeekProfilePassiveRemoveBtn.Click += new System.EventHandler(this.WeekProfilePassiveRemoveBtn_Click);
            // 
            // WeekProfilePassiveEditBtn
            // 
            this.WeekProfilePassiveEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekProfilePassiveEditBtn.Location = new System.Drawing.Point(297, 11);
            this.WeekProfilePassiveEditBtn.Name = "WeekProfilePassiveEditBtn";
            this.WeekProfilePassiveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.WeekProfilePassiveEditBtn.TabIndex = 19;
            this.WeekProfilePassiveEditBtn.Text = "Edit...";
            this.WeekProfilePassiveEditBtn.UseVisualStyleBackColor = true;
            this.WeekProfilePassiveEditBtn.Click += new System.EventHandler(this.WeekProfilePassiveEditBtn_Click);
            // 
            // WeekProfilePassiveAddBtn
            // 
            this.WeekProfilePassiveAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekProfilePassiveAddBtn.Location = new System.Drawing.Point(216, 11);
            this.WeekProfilePassiveAddBtn.Name = "WeekProfilePassiveAddBtn";
            this.WeekProfilePassiveAddBtn.Size = new System.Drawing.Size(75, 23);
            this.WeekProfilePassiveAddBtn.TabIndex = 18;
            this.WeekProfilePassiveAddBtn.Text = "Add...";
            this.WeekProfilePassiveAddBtn.UseVisualStyleBackColor = true;
            this.WeekProfilePassiveAddBtn.Click += new System.EventHandler(this.WeekProfilePassiveAddBtn_Click);
            // 
            // DayProfilePassiveTab
            // 
            this.DayProfilePassiveTab.Controls.Add(this.PassiveActionList);
            this.DayProfilePassiveTab.Controls.Add(this.PassiveDaysList);
            this.DayProfilePassiveTab.Controls.Add(this.panel6);
            this.DayProfilePassiveTab.Location = new System.Drawing.Point(4, 22);
            this.DayProfilePassiveTab.Name = "DayProfilePassiveTab";
            this.DayProfilePassiveTab.Size = new System.Drawing.Size(462, 438);
            this.DayProfilePassiveTab.TabIndex = 2;
            this.DayProfilePassiveTab.Text = "Day Profile";
            this.DayProfilePassiveTab.UseVisualStyleBackColor = true;
            // 
            // PassiveActionList
            // 
            this.PassiveActionList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassiveActionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.PassiveActionList.FullRowSelect = true;
            this.PassiveActionList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PassiveActionList.HideSelection = false;
            this.PassiveActionList.Location = new System.Drawing.Point(102, 0);
            this.PassiveActionList.Name = "PassiveActionList";
            this.PassiveActionList.Size = new System.Drawing.Size(337, 391);
            this.PassiveActionList.TabIndex = 22;
            this.PassiveActionList.UseCompatibleStateImageBehavior = false;
            this.PassiveActionList.View = System.Windows.Forms.View.Details;
            this.PassiveActionList.DoubleClick += new System.EventHandler(this.DayProfilePassiveEditBtn_Click);
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Start Time";
            this.columnHeader12.Width = 91;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Script";
            this.columnHeader13.Width = 87;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Selector";
            // 
            // PassiveDaysList
            // 
            this.PassiveDaysList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15});
            this.PassiveDaysList.Dock = System.Windows.Forms.DockStyle.Left;
            this.PassiveDaysList.FullRowSelect = true;
            this.PassiveDaysList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PassiveDaysList.HideSelection = false;
            this.PassiveDaysList.Location = new System.Drawing.Point(0, 0);
            this.PassiveDaysList.Name = "PassiveDaysList";
            this.PassiveDaysList.Size = new System.Drawing.Size(102, 391);
            this.PassiveDaysList.TabIndex = 21;
            this.PassiveDaysList.UseCompatibleStateImageBehavior = false;
            this.PassiveDaysList.View = System.Windows.Forms.View.Details;
            this.PassiveDaysList.SelectedIndexChanged += new System.EventHandler(this.PassiveDaysList_SelectedIndexChanged);
            this.PassiveDaysList.DoubleClick += new System.EventHandler(this.DayProfilePassiveEditBtn_Click);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Day ID";
            this.columnHeader15.Width = 91;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.AddDayPassiveBtn);
            this.panel6.Controls.Add(this.PassiveActionAddBtn);
            this.panel6.Controls.Add(this.DayProfilePassiveRemoveBtn);
            this.panel6.Controls.Add(this.DayProfilePassiveEditBtn);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(462, 47);
            this.panel6.TabIndex = 1;
            // 
            // AddDayPassiveBtn
            // 
            this.AddDayPassiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDayPassiveBtn.Location = new System.Drawing.Point(131, 11);
            this.AddDayPassiveBtn.Name = "AddDayPassiveBtn";
            this.AddDayPassiveBtn.Size = new System.Drawing.Size(75, 23);
            this.AddDayPassiveBtn.TabIndex = 23;
            this.AddDayPassiveBtn.Text = "Add Day...";
            this.AddDayPassiveBtn.UseVisualStyleBackColor = true;
            this.AddDayPassiveBtn.Click += new System.EventHandler(this.AddDayPassiveBtn_Click);
            // 
            // PassiveActionAddBtn
            // 
            this.PassiveActionAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PassiveActionAddBtn.Location = new System.Drawing.Point(212, 11);
            this.PassiveActionAddBtn.Name = "PassiveActionAddBtn";
            this.PassiveActionAddBtn.Size = new System.Drawing.Size(85, 23);
            this.PassiveActionAddBtn.TabIndex = 22;
            this.PassiveActionAddBtn.Text = "Add Action...";
            this.PassiveActionAddBtn.UseVisualStyleBackColor = true;
            this.PassiveActionAddBtn.Click += new System.EventHandler(this.PassiveActionAddBtn_Click);
            // 
            // DayProfilePassiveRemoveBtn
            // 
            this.DayProfilePassiveRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayProfilePassiveRemoveBtn.Location = new System.Drawing.Point(384, 11);
            this.DayProfilePassiveRemoveBtn.Name = "DayProfilePassiveRemoveBtn";
            this.DayProfilePassiveRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.DayProfilePassiveRemoveBtn.TabIndex = 20;
            this.DayProfilePassiveRemoveBtn.Text = "Remove";
            this.DayProfilePassiveRemoveBtn.UseVisualStyleBackColor = true;
            this.DayProfilePassiveRemoveBtn.Click += new System.EventHandler(this.DayProfilePassiveRemoveBtn_Click);
            // 
            // DayProfilePassiveEditBtn
            // 
            this.DayProfilePassiveEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayProfilePassiveEditBtn.Location = new System.Drawing.Point(303, 11);
            this.DayProfilePassiveEditBtn.Name = "DayProfilePassiveEditBtn";
            this.DayProfilePassiveEditBtn.Size = new System.Drawing.Size(75, 23);
            this.DayProfilePassiveEditBtn.TabIndex = 19;
            this.DayProfilePassiveEditBtn.Text = "Edit...";
            this.DayProfilePassiveEditBtn.UseVisualStyleBackColor = true;
            this.DayProfilePassiveEditBtn.Click += new System.EventHandler(this.DayProfilePassiveEditBtn_Click);
            // 
            // PCalendarNameLbl
            // 
            this.PCalendarNameLbl.AutoSize = true;
            this.PCalendarNameLbl.Location = new System.Drawing.Point(8, 15);
            this.PCalendarNameLbl.Name = "PCalendarNameLbl";
            this.PCalendarNameLbl.Size = new System.Drawing.Size(83, 13);
            this.PCalendarNameLbl.TabIndex = 21;
            this.PCalendarNameLbl.Text = "Calendar Name:";
            // 
            // PCalendarNameTB
            // 
            this.PCalendarNameTB.Index = 6;
            this.PCalendarNameTB.Location = new System.Drawing.Point(104, 12);
            this.PCalendarNameTB.Name = "PCalendarNameTB";
            this.PCalendarNameTB.NotifyChanges = false;
            this.PCalendarNameTB.ReadOnly = true;
            this.PCalendarNameTB.Size = new System.Drawing.Size(208, 20);
            this.PCalendarNameTB.TabIndex = 20;
            this.PCalendarNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.ReadOnly = true;
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
            this.LogicalNameTB.TabIndex = 1;
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
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ActivatePassiveCalendarBtn
            // 
            this.ActivatePassiveCalendarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivatePassiveCalendarBtn.Index = 1;
            this.ActivatePassiveCalendarBtn.Location = new System.Drawing.Point(387, 15);
            this.ActivatePassiveCalendarBtn.Name = "ActivatePassiveCalendarBtn";
            this.ActivatePassiveCalendarBtn.Size = new System.Drawing.Size(84, 23);
            this.ActivatePassiveCalendarBtn.TabIndex = 29;
            this.ActivatePassiveCalendarBtn.Text = "Activate";
            this.ActivatePassiveCalendarBtn.UseVisualStyleBackColor = true;
            // 
            // GXDLMSActivityCalendarView
            // 
            this.ClientSize = new System.Drawing.Size(531, 635);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSActivityCalendarView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ActiveTab.ResumeLayout(false);
            this.ActiveTab.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.SeasonProfileActiveTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.WeekProfileActiveTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.DayProfileActiveTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.PassiveTab.ResumeLayout(false);
            this.PassiveTab.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.SeasonProfilePassiveTab.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.WeekProfilePassiveTab.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.DayProfilePassiveTab.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl2;
        private TabPage SeasonProfileActiveTab;
        private TabPage WeekProfileActiveTab;
        private TabPage DayProfileActiveTab;
        private TabControl tabControl3;
        private TabPage SeasonProfilePassiveTab;
        private TabPage WeekProfilePassiveTab;
        private TabPage DayProfilePassiveTab;
        private ListView SeasonProfileActiveLV;
        private ColumnHeader NameHeader;
        private ColumnHeader StartHeader;
        private ColumnHeader WeekNameHeader;
        private Panel panel1;
        private Button SeasonProfileActiveRemoveBtn;
        private Button SeasonProfileActiveEditBtn;
        private Button SeasonProfileActiveAddBtn;
        private ListView AWeekProfileLV;
        private ColumnHeader columnHeader1;
        private ColumnHeader MonHeader;
        private ColumnHeader TueHeader;
        private ColumnHeader WedHeader;
        private ColumnHeader ThuHeader;
        private ColumnHeader FriHeader;
        private ColumnHeader SatHeader;
        private ColumnHeader SunHeader;
        private Panel panel2;
        private Button WeekProfileActiveRemoveBtn;
        private Button WeekProfileActiveEditBtn;
        private Button WeekProfileActiveAddBtn;
        private Panel panel3;
        private Button DayProfileActiveRemoveBtn;
        private Button DayProfileActiveEditBtn;
        private Button ActiveActionAddBtn;
        private ListView SeasonProfilePassiveLV;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader16;
        private Panel panel4;
        private Button SeasonProfilePassiveRemoveBtn;
        private Button SeasonProfilePassiveEditBtn;
        private Button SeasonProfilePassiveAddBtn;
        private ListView PWeekProfileLV;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Panel panel5;
        private Button WeekProfilePassiveRemoveBtn;
        private Button WeekProfilePassiveEditBtn;
        private Button WeekProfilePassiveAddBtn;
        private Panel panel6;
        private Button DayProfilePassiveRemoveBtn;
        private Button DayProfilePassiveEditBtn;
        private ListView ActiveActionList;
        private ColumnHeader AStartTime;
        private ColumnHeader AScriptCh;
        private ColumnHeader ASelectorCh;
        private Splitter splitter1;
        private ListView ActiveDaysList;
        private ColumnHeader DayIdHeader;
        private ListView PassiveActionList;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ListView PassiveDaysList;
        private ColumnHeader columnHeader15;
        private Button AddDayActiveBtn;
        private Button AddDayPassiveBtn;
        private Button PassiveActionAddBtn;
        private Label ActivatePassiveCalendarLbl;
        private GXValueField ActivatePassiveCalendarTb;
        private GXButton ActivatePassiveCalendarBtn;
    }
}
