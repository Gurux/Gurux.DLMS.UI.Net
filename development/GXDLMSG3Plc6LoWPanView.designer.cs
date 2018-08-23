using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSG3Plc6LoWPanView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSG3Plc6LoWPanView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DisableDefaultRoutingCB = new System.Windows.Forms.CheckBox();
            this.DeviceTypeLbl = new System.Windows.Forms.Label();
            this.CoordShortAddressLbl = new System.Windows.Forms.Label();
            this.MetricTypeLbl = new System.Windows.Forms.Label();
            this.ActiveKeyIndexLbl = new System.Windows.Forms.Label();
            this.PathDiscoveryTimeLbl = new System.Windows.Forms.Label();
            this.MaxJoinWaitTimeLbl = new System.Windows.Forms.Label();
            this.BroadcastLogTableEntryTtlLbl = new System.Windows.Forms.Label();
            this.SecurityLevelLbl = new System.Windows.Forms.Label();
            this.WeakLqiValueLbl = new System.Windows.Forms.Label();
            this.MaxHopsLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PrefixTable = new System.Windows.Forms.ListView();
            this.PrefixHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyTableRemoveBtn = new System.Windows.Forms.Button();
            this.KeyTableEditBtn = new System.Windows.Forms.Button();
            this.KeyTableAddBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RoutingConfiguration = new System.Windows.Forms.ListView();
            this.NetTraversalTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RoutingTableEntryTtlHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KrHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KmHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NeighbourTableRemoveTbBtn = new System.Windows.Forms.Button();
            this.NeighbourTableAddBtn = new System.Windows.Forms.Button();
            this.NeighbourTableEditBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.RoutingRemoveBtn = new System.Windows.Forms.Button();
            this.RoutingEditBtn = new System.Windows.Forms.Button();
            this.RoutingAddBtn = new System.Windows.Forms.Button();
            this.Routing = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.RoutingMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RoutingAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutingEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutingRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.KcHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KqHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KhHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KrtHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RreqRetriesHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RreqRerrWaitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BlacklistTableEntryTtlHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnicastRreqGenEnableHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RlcEnabledHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddRevLinkCostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextInformation = new System.Windows.Forms.ListView();
            this.CIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompressionHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidLifetimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BlackList = new System.Windows.Forms.ListView();
            this.NeighbourAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BroadcastLog = new System.Windows.Forms.ListView();
            this.SourceAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SequenceNumberHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidTimeHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GroupTable = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gxValueField1 = new Gurux.DLMS.UI.GXValueField();
            this.CoordShortAddressTb = new Gurux.DLMS.UI.GXValueField();
            this.MetricTypeTb = new Gurux.DLMS.UI.GXValueField();
            this.ActiveKeyIndexTb = new Gurux.DLMS.UI.GXValueField();
            this.PathDiscoveryTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.MaxJoinWaitTimeTB = new Gurux.DLMS.UI.GXValueField();
            this.BroadcastLogTableEntryTtlTb = new Gurux.DLMS.UI.GXValueField();
            this.SecurityLevelTb = new Gurux.DLMS.UI.GXValueField();
            this.WeakLqiValueTb = new Gurux.DLMS.UI.GXValueField();
            this.MaxHopsTb = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.RoutingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "G3-PLC 6LoWPAN adaptation layer setup Object";
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
            this.DescriptionTB.Size = new System.Drawing.Size(571, 20);
            this.DescriptionTB.TabIndex = 4;
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(13, 92);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 418);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gxValueField1);
            this.tabPage1.Controls.Add(this.DisableDefaultRoutingCB);
            this.tabPage1.Controls.Add(this.DeviceTypeLbl);
            this.tabPage1.Controls.Add(this.CoordShortAddressTb);
            this.tabPage1.Controls.Add(this.CoordShortAddressLbl);
            this.tabPage1.Controls.Add(this.MetricTypeTb);
            this.tabPage1.Controls.Add(this.MetricTypeLbl);
            this.tabPage1.Controls.Add(this.ActiveKeyIndexTb);
            this.tabPage1.Controls.Add(this.ActiveKeyIndexLbl);
            this.tabPage1.Controls.Add(this.PathDiscoveryTimeTb);
            this.tabPage1.Controls.Add(this.PathDiscoveryTimeLbl);
            this.tabPage1.Controls.Add(this.MaxJoinWaitTimeTB);
            this.tabPage1.Controls.Add(this.MaxJoinWaitTimeLbl);
            this.tabPage1.Controls.Add(this.BroadcastLogTableEntryTtlTb);
            this.tabPage1.Controls.Add(this.BroadcastLogTableEntryTtlLbl);
            this.tabPage1.Controls.Add(this.SecurityLevelTb);
            this.tabPage1.Controls.Add(this.SecurityLevelLbl);
            this.tabPage1.Controls.Add(this.WeakLqiValueTb);
            this.tabPage1.Controls.Add(this.WeakLqiValueLbl);
            this.tabPage1.Controls.Add(this.MaxHopsTb);
            this.tabPage1.Controls.Add(this.MaxHopsLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 392);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DisableDefaultRoutingCB
            // 
            this.DisableDefaultRoutingCB.AutoSize = true;
            this.DisableDefaultRoutingCB.Location = new System.Drawing.Point(244, 115);
            this.DisableDefaultRoutingCB.Name = "DisableDefaultRoutingCB";
            this.DisableDefaultRoutingCB.Size = new System.Drawing.Size(138, 17);
            this.DisableDefaultRoutingCB.TabIndex = 9;
            this.DisableDefaultRoutingCB.Text = "Disable Default Routing";
            this.DisableDefaultRoutingCB.UseVisualStyleBackColor = true;
            this.DisableDefaultRoutingCB.CheckedChanged += new System.EventHandler(this.DisableDefaultRoutingCB_CheckedChanged);
            // 
            // DeviceTypeLbl
            // 
            this.DeviceTypeLbl.AutoSize = true;
            this.DeviceTypeLbl.Location = new System.Drawing.Point(14, 141);
            this.DeviceTypeLbl.Name = "DeviceTypeLbl";
            this.DeviceTypeLbl.Size = new System.Drawing.Size(71, 13);
            this.DeviceTypeLbl.TabIndex = 43;
            this.DeviceTypeLbl.Text = "Device Type:";
            // 
            // CoordShortAddressLbl
            // 
            this.CoordShortAddressLbl.AutoSize = true;
            this.CoordShortAddressLbl.Location = new System.Drawing.Point(13, 115);
            this.CoordShortAddressLbl.Name = "CoordShortAddressLbl";
            this.CoordShortAddressLbl.Size = new System.Drawing.Size(78, 13);
            this.CoordShortAddressLbl.TabIndex = 39;
            this.CoordShortAddressLbl.Text = "Coord address:";
            // 
            // MetricTypeLbl
            // 
            this.MetricTypeLbl.AutoSize = true;
            this.MetricTypeLbl.Location = new System.Drawing.Point(242, 91);
            this.MetricTypeLbl.Name = "MetricTypeLbl";
            this.MetricTypeLbl.Size = new System.Drawing.Size(62, 13);
            this.MetricTypeLbl.TabIndex = 37;
            this.MetricTypeLbl.Text = "Metric type:";
            // 
            // ActiveKeyIndexLbl
            // 
            this.ActiveKeyIndexLbl.AutoSize = true;
            this.ActiveKeyIndexLbl.Location = new System.Drawing.Point(14, 87);
            this.ActiveKeyIndexLbl.Name = "ActiveKeyIndexLbl";
            this.ActiveKeyIndexLbl.Size = new System.Drawing.Size(89, 13);
            this.ActiveKeyIndexLbl.TabIndex = 35;
            this.ActiveKeyIndexLbl.Text = "Active key Index:";
            // 
            // PathDiscoveryTimeLbl
            // 
            this.PathDiscoveryTimeLbl.AutoSize = true;
            this.PathDiscoveryTimeLbl.Location = new System.Drawing.Point(242, 65);
            this.PathDiscoveryTimeLbl.Name = "PathDiscoveryTimeLbl";
            this.PathDiscoveryTimeLbl.Size = new System.Drawing.Size(102, 13);
            this.PathDiscoveryTimeLbl.TabIndex = 33;
            this.PathDiscoveryTimeLbl.Text = "Path discovery time:";
            // 
            // MaxJoinWaitTimeLbl
            // 
            this.MaxJoinWaitTimeLbl.AutoSize = true;
            this.MaxJoinWaitTimeLbl.Location = new System.Drawing.Point(14, 61);
            this.MaxJoinWaitTimeLbl.Name = "MaxJoinWaitTimeLbl";
            this.MaxJoinWaitTimeLbl.Size = new System.Drawing.Size(84, 13);
            this.MaxJoinWaitTimeLbl.TabIndex = 31;
            this.MaxJoinWaitTimeLbl.Text = "Max Join WaitT:";
            // 
            // BroadcastLogTableEntryTtlLbl
            // 
            this.BroadcastLogTableEntryTtlLbl.AutoSize = true;
            this.BroadcastLogTableEntryTtlLbl.Location = new System.Drawing.Point(241, 39);
            this.BroadcastLogTableEntryTtlLbl.Name = "BroadcastLogTableEntryTtlLbl";
            this.BroadcastLogTableEntryTtlLbl.Size = new System.Drawing.Size(102, 13);
            this.BroadcastLogTableEntryTtlLbl.TabIndex = 29;
            this.BroadcastLogTableEntryTtlLbl.Text = "Broadcast Log TTL:";
            // 
            // SecurityLevelLbl
            // 
            this.SecurityLevelLbl.AutoSize = true;
            this.SecurityLevelLbl.Location = new System.Drawing.Point(13, 35);
            this.SecurityLevelLbl.Name = "SecurityLevelLbl";
            this.SecurityLevelLbl.Size = new System.Drawing.Size(77, 13);
            this.SecurityLevelLbl.TabIndex = 27;
            this.SecurityLevelLbl.Text = "Security Level:";
            // 
            // WeakLqiValueLbl
            // 
            this.WeakLqiValueLbl.AutoSize = true;
            this.WeakLqiValueLbl.Location = new System.Drawing.Point(241, 13);
            this.WeakLqiValueLbl.Name = "WeakLqiValueLbl";
            this.WeakLqiValueLbl.Size = new System.Drawing.Size(89, 13);
            this.WeakLqiValueLbl.TabIndex = 25;
            this.WeakLqiValueLbl.Text = "Weak LQI Value:";
            // 
            // MaxHopsLbl
            // 
            this.MaxHopsLbl.AutoSize = true;
            this.MaxHopsLbl.Location = new System.Drawing.Point(13, 9);
            this.MaxHopsLbl.Name = "MaxHopsLbl";
            this.MaxHopsLbl.Size = new System.Drawing.Size(58, 13);
            this.MaxHopsLbl.TabIndex = 23;
            this.MaxHopsLbl.Text = "Max Hops:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PrefixTable);
            this.tabPage2.Controls.Add(this.KeyTableRemoveBtn);
            this.tabPage2.Controls.Add(this.KeyTableEditBtn);
            this.tabPage2.Controls.Add(this.KeyTableAddBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prefix";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PrefixTable
            // 
            this.PrefixTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrefixTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PrefixHeader});
            this.PrefixTable.FullRowSelect = true;
            this.PrefixTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PrefixTable.Location = new System.Drawing.Point(3, 3);
            this.PrefixTable.Name = "PrefixTable";
            this.PrefixTable.Size = new System.Drawing.Size(659, 349);
            this.PrefixTable.TabIndex = 8;
            this.PrefixTable.UseCompatibleStateImageBehavior = false;
            this.PrefixTable.View = System.Windows.Forms.View.Details;
            // 
            // PrefixHeader
            // 
            this.PrefixHeader.Text = "Prefix";
            this.PrefixHeader.Width = 617;
            // 
            // KeyTableRemoveBtn
            // 
            this.KeyTableRemoveBtn.Location = new System.Drawing.Point(584, 358);
            this.KeyTableRemoveBtn.Name = "KeyTableRemoveBtn";
            this.KeyTableRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.KeyTableRemoveBtn.TabIndex = 7;
            this.KeyTableRemoveBtn.Text = "Remove...";
            this.KeyTableRemoveBtn.UseVisualStyleBackColor = true;
            this.KeyTableRemoveBtn.Visible = false;
            // 
            // KeyTableEditBtn
            // 
            this.KeyTableEditBtn.Location = new System.Drawing.Point(503, 358);
            this.KeyTableEditBtn.Name = "KeyTableEditBtn";
            this.KeyTableEditBtn.Size = new System.Drawing.Size(75, 23);
            this.KeyTableEditBtn.TabIndex = 6;
            this.KeyTableEditBtn.Text = "Edit...";
            this.KeyTableEditBtn.UseVisualStyleBackColor = true;
            this.KeyTableEditBtn.Visible = false;
            // 
            // KeyTableAddBtn
            // 
            this.KeyTableAddBtn.Location = new System.Drawing.Point(422, 358);
            this.KeyTableAddBtn.Name = "KeyTableAddBtn";
            this.KeyTableAddBtn.Size = new System.Drawing.Size(75, 23);
            this.KeyTableAddBtn.TabIndex = 5;
            this.KeyTableAddBtn.Text = "Add...";
            this.KeyTableAddBtn.UseVisualStyleBackColor = true;
            this.KeyTableAddBtn.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RoutingConfiguration);
            this.tabPage3.Controls.Add(this.NeighbourTableRemoveTbBtn);
            this.tabPage3.Controls.Add(this.NeighbourTableAddBtn);
            this.tabPage3.Controls.Add(this.NeighbourTableEditBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(665, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Routing configuration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RoutingConfiguration
            // 
            this.RoutingConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoutingConfiguration.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NetTraversalTimeHeader,
            this.RoutingTableEntryTtlHeader,
            this.KrHeader,
            this.KmHeader,
            this.KcHeader,
            this.KqHeader,
            this.KhHeader,
            this.KrtHeader,
            this.RreqRetriesHeader,
            this.RreqRerrWaitHeader,
            this.BlacklistTableEntryTtlHeader,
            this.UnicastRreqGenEnableHeader,
            this.RlcEnabledHeader,
            this.AddRevLinkCostHeader});
            this.RoutingConfiguration.FullRowSelect = true;
            this.RoutingConfiguration.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.RoutingConfiguration.Location = new System.Drawing.Point(0, 0);
            this.RoutingConfiguration.Name = "RoutingConfiguration";
            this.RoutingConfiguration.Size = new System.Drawing.Size(662, 349);
            this.RoutingConfiguration.TabIndex = 12;
            this.RoutingConfiguration.UseCompatibleStateImageBehavior = false;
            this.RoutingConfiguration.View = System.Windows.Forms.View.Details;
            // 
            // NetTraversalTimeHeader
            // 
            this.NetTraversalTimeHeader.Text = "Net Traversal Time";
            this.NetTraversalTimeHeader.Width = 113;
            // 
            // RoutingTableEntryTtlHeader
            // 
            this.RoutingTableEntryTtlHeader.Text = "TTL";
            this.RoutingTableEntryTtlHeader.Width = 61;
            // 
            // KrHeader
            // 
            this.KrHeader.Text = "Kr";
            this.KrHeader.Width = 34;
            // 
            // KmHeader
            // 
            this.KmHeader.Text = "Km";
            this.KmHeader.Width = 33;
            // 
            // NeighbourTableRemoveTbBtn
            // 
            this.NeighbourTableRemoveTbBtn.Location = new System.Drawing.Point(587, 355);
            this.NeighbourTableRemoveTbBtn.Name = "NeighbourTableRemoveTbBtn";
            this.NeighbourTableRemoveTbBtn.Size = new System.Drawing.Size(75, 23);
            this.NeighbourTableRemoveTbBtn.TabIndex = 11;
            this.NeighbourTableRemoveTbBtn.Text = "Remove...";
            this.NeighbourTableRemoveTbBtn.UseVisualStyleBackColor = true;
            this.NeighbourTableRemoveTbBtn.Visible = false;
            // 
            // NeighbourTableAddBtn
            // 
            this.NeighbourTableAddBtn.Location = new System.Drawing.Point(425, 355);
            this.NeighbourTableAddBtn.Name = "NeighbourTableAddBtn";
            this.NeighbourTableAddBtn.Size = new System.Drawing.Size(75, 23);
            this.NeighbourTableAddBtn.TabIndex = 9;
            this.NeighbourTableAddBtn.Text = "Add...";
            this.NeighbourTableAddBtn.UseVisualStyleBackColor = true;
            this.NeighbourTableAddBtn.Visible = false;
            // 
            // NeighbourTableEditBtn
            // 
            this.NeighbourTableEditBtn.Location = new System.Drawing.Point(506, 355);
            this.NeighbourTableEditBtn.Name = "NeighbourTableEditBtn";
            this.NeighbourTableEditBtn.Size = new System.Drawing.Size(75, 23);
            this.NeighbourTableEditBtn.TabIndex = 10;
            this.NeighbourTableEditBtn.Text = "Edit...";
            this.NeighbourTableEditBtn.UseVisualStyleBackColor = true;
            this.NeighbourTableEditBtn.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.RoutingRemoveBtn);
            this.tabPage4.Controls.Add(this.RoutingEditBtn);
            this.tabPage4.Controls.Add(this.RoutingAddBtn);
            this.tabPage4.Controls.Add(this.Routing);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(665, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Routing";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // RoutingRemoveBtn
            // 
            this.RoutingRemoveBtn.Location = new System.Drawing.Point(576, 355);
            this.RoutingRemoveBtn.Name = "RoutingRemoveBtn";
            this.RoutingRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RoutingRemoveBtn.TabIndex = 12;
            this.RoutingRemoveBtn.Text = "Remove...";
            this.RoutingRemoveBtn.UseVisualStyleBackColor = true;
            this.RoutingRemoveBtn.Click += new System.EventHandler(this.RoutingRemoveBtn_Click);
            // 
            // RoutingEditBtn
            // 
            this.RoutingEditBtn.Location = new System.Drawing.Point(495, 355);
            this.RoutingEditBtn.Name = "RoutingEditBtn";
            this.RoutingEditBtn.Size = new System.Drawing.Size(75, 23);
            this.RoutingEditBtn.TabIndex = 11;
            this.RoutingEditBtn.Text = "Edit...";
            this.RoutingEditBtn.UseVisualStyleBackColor = true;
            this.RoutingEditBtn.Click += new System.EventHandler(this.RoutingEditBtn_Click);
            // 
            // RoutingAddBtn
            // 
            this.RoutingAddBtn.Location = new System.Drawing.Point(414, 355);
            this.RoutingAddBtn.Name = "RoutingAddBtn";
            this.RoutingAddBtn.Size = new System.Drawing.Size(75, 23);
            this.RoutingAddBtn.TabIndex = 10;
            this.RoutingAddBtn.Text = "Add...";
            this.RoutingAddBtn.UseVisualStyleBackColor = true;
            this.RoutingAddBtn.Click += new System.EventHandler(this.RoutingAddBtn_Click);
            // 
            // Routing
            // 
            this.Routing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Routing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.Routing.FullRowSelect = true;
            this.Routing.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Routing.Location = new System.Drawing.Point(0, 0);
            this.Routing.Name = "Routing";
            this.Routing.Size = new System.Drawing.Size(662, 349);
            this.Routing.TabIndex = 9;
            this.Routing.UseCompatibleStateImageBehavior = false;
            this.Routing.View = System.Windows.Forms.View.Details;
            this.Routing.DoubleClick += new System.EventHandler(this.RoutingEditBtn_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Destination:";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Next Hop:";
            this.columnHeader2.Width = 89;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Route:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hop Count:";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Weak Link:";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Valid Time:";
            this.columnHeader6.Width = 76;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ContextInformation);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(665, 392);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Context information";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.BlackList);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(665, 392);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Blacklist";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.BroadcastLog);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(665, 392);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Broadcast log";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.GroupTable);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(665, 392);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Group";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // RoutingMenu
            // 
            this.RoutingMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoutingAdd,
            this.RoutingEdit,
            this.RoutingRemove});
            this.RoutingMenu.Name = "contextMenuStrip1";
            this.RoutingMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // RoutingAdd
            // 
            this.RoutingAdd.Name = "RoutingAdd";
            this.RoutingAdd.Size = new System.Drawing.Size(117, 22);
            this.RoutingAdd.Text = "Add";
            this.RoutingAdd.Click += new System.EventHandler(this.RoutingAddBtn_Click);
            // 
            // RoutingEdit
            // 
            this.RoutingEdit.Name = "RoutingEdit";
            this.RoutingEdit.Size = new System.Drawing.Size(117, 22);
            this.RoutingEdit.Text = "Edit";
            this.RoutingEdit.Click += new System.EventHandler(this.RoutingEditBtn_Click);
            // 
            // RoutingRemove
            // 
            this.RoutingRemove.Name = "RoutingRemove";
            this.RoutingRemove.Size = new System.Drawing.Size(117, 22);
            this.RoutingRemove.Text = "Remove";
            this.RoutingRemove.Click += new System.EventHandler(this.RoutingRemoveBtn_Click);
            // 
            // KcHeader
            // 
            this.KcHeader.Text = "Kc";
            this.KcHeader.Width = 42;
            // 
            // KqHeader
            // 
            this.KqHeader.Text = "Kq";
            this.KqHeader.Width = 38;
            // 
            // KhHeader
            // 
            this.KhHeader.Text = "Kh";
            this.KhHeader.Width = 39;
            // 
            // KrtHeader
            // 
            this.KrtHeader.Text = "Krt";
            this.KrtHeader.Width = 38;
            // 
            // RreqRetriesHeader
            // 
            this.RreqRetriesHeader.Text = "Rreq Retries";
            this.RreqRetriesHeader.Width = 79;
            // 
            // RreqRerrWaitHeader
            // 
            this.RreqRerrWaitHeader.Text = "Rreq Rerr Wait";
            this.RreqRerrWaitHeader.Width = 88;
            // 
            // BlacklistTableEntryTtlHeader
            // 
            this.BlacklistTableEntryTtlHeader.Text = "Black list TTL";
            this.BlacklistTableEntryTtlHeader.Width = 92;
            // 
            // UnicastRreqGenEnableHeader
            // 
            this.UnicastRreqGenEnableHeader.Text = "Unicast Rreq Gen Enable";
            // 
            // RlcEnabledHeader
            // 
            this.RlcEnabledHeader.Text = "Rlc Enabled";
            // 
            // AddRevLinkCostHeader
            // 
            this.AddRevLinkCostHeader.Text = "Add Rev Link Cost";
            // 
            // ContextInformation
            // 
            this.ContextInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContextInformation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CIDHeader,
            this.ContextHeader,
            this.CompressionHeader9,
            this.ValidLifetimeHeader});
            this.ContextInformation.FullRowSelect = true;
            this.ContextInformation.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ContextInformation.Location = new System.Drawing.Point(0, 0);
            this.ContextInformation.Name = "ContextInformation";
            this.ContextInformation.Size = new System.Drawing.Size(662, 349);
            this.ContextInformation.TabIndex = 10;
            this.ContextInformation.UseCompatibleStateImageBehavior = false;
            this.ContextInformation.View = System.Windows.Forms.View.Details;
            // 
            // CIDHeader
            // 
            this.CIDHeader.Text = "CID";
            this.CIDHeader.Width = 74;
            // 
            // ContextHeader
            // 
            this.ContextHeader.Text = "Context";
            this.ContextHeader.Width = 89;
            // 
            // CompressionHeader9
            // 
            this.CompressionHeader9.Text = "Compression";
            this.CompressionHeader9.Width = 84;
            // 
            // ValidLifetimeHeader
            // 
            this.ValidLifetimeHeader.Text = "Valid lifetime";
            this.ValidLifetimeHeader.Width = 79;
            // 
            // BlackList
            // 
            this.BlackList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NeighbourAddressHeader,
            this.ValidTimeHeader});
            this.BlackList.FullRowSelect = true;
            this.BlackList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BlackList.Location = new System.Drawing.Point(3, 0);
            this.BlackList.Name = "BlackList";
            this.BlackList.Size = new System.Drawing.Size(662, 349);
            this.BlackList.TabIndex = 11;
            this.BlackList.UseCompatibleStateImageBehavior = false;
            this.BlackList.View = System.Windows.Forms.View.Details;
            // 
            // NeighbourAddressHeader
            // 
            this.NeighbourAddressHeader.Text = "Neighbour Address";
            this.NeighbourAddressHeader.Width = 122;
            // 
            // ValidTimeHeader
            // 
            this.ValidTimeHeader.Text = "Valid Time";
            this.ValidTimeHeader.Width = 216;
            // 
            // BroadcastLog
            // 
            this.BroadcastLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BroadcastLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SourceAddressHeader,
            this.SequenceNumberHeader,
            this.ValidTimeHeader2});
            this.BroadcastLog.FullRowSelect = true;
            this.BroadcastLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.BroadcastLog.Location = new System.Drawing.Point(0, 0);
            this.BroadcastLog.Name = "BroadcastLog";
            this.BroadcastLog.Size = new System.Drawing.Size(662, 349);
            this.BroadcastLog.TabIndex = 12;
            this.BroadcastLog.UseCompatibleStateImageBehavior = false;
            this.BroadcastLog.View = System.Windows.Forms.View.Details;
            // 
            // SourceAddressHeader
            // 
            this.SourceAddressHeader.Text = "Source Address";
            this.SourceAddressHeader.Width = 90;
            // 
            // SequenceNumberHeader
            // 
            this.SequenceNumberHeader.Text = "Sequence Number";
            this.SequenceNumberHeader.Width = 109;
            // 
            // ValidTimeHeader2
            // 
            this.ValidTimeHeader2.Text = "Valid Time";
            this.ValidTimeHeader2.Width = 95;
            // 
            // GroupTable
            // 
            this.GroupTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.GroupTable.FullRowSelect = true;
            this.GroupTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.GroupTable.Location = new System.Drawing.Point(2, 0);
            this.GroupTable.Name = "GroupTable";
            this.GroupTable.Size = new System.Drawing.Size(662, 349);
            this.GroupTable.TabIndex = 13;
            this.GroupTable.UseCompatibleStateImageBehavior = false;
            this.GroupTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Source Address";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Sequence Number";
            this.columnHeader8.Width = 109;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Valid Time";
            this.columnHeader9.Width = 95;
            // 
            // gxValueField1
            // 
            this.gxValueField1.Index = 19;
            this.gxValueField1.Location = new System.Drawing.Point(111, 141);
            this.gxValueField1.Name = "gxValueField1";
            this.gxValueField1.ReadOnly = true;
            this.gxValueField1.Size = new System.Drawing.Size(104, 112);
            this.gxValueField1.TabIndex = 10;
            this.gxValueField1.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // CoordShortAddressTb
            // 
            this.CoordShortAddressTb.Index = 17;
            this.CoordShortAddressTb.Location = new System.Drawing.Point(110, 112);
            this.CoordShortAddressTb.Name = "CoordShortAddressTb";
            this.CoordShortAddressTb.ReadOnly = true;
            this.CoordShortAddressTb.Size = new System.Drawing.Size(104, 20);
            this.CoordShortAddressTb.TabIndex = 8;
            this.CoordShortAddressTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CoordShortAddressTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CoordShortAddressTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // MetricTypeTb
            // 
            this.MetricTypeTb.Index = 16;
            this.MetricTypeTb.Location = new System.Drawing.Point(353, 87);
            this.MetricTypeTb.Name = "MetricTypeTb";
            this.MetricTypeTb.ReadOnly = true;
            this.MetricTypeTb.Size = new System.Drawing.Size(104, 20);
            this.MetricTypeTb.TabIndex = 7;
            this.MetricTypeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MetricTypeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MetricTypeTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // ActiveKeyIndexTb
            // 
            this.ActiveKeyIndexTb.Index = 15;
            this.ActiveKeyIndexTb.Location = new System.Drawing.Point(111, 84);
            this.ActiveKeyIndexTb.Name = "ActiveKeyIndexTb";
            this.ActiveKeyIndexTb.ReadOnly = true;
            this.ActiveKeyIndexTb.Size = new System.Drawing.Size(104, 20);
            this.ActiveKeyIndexTb.TabIndex = 6;
            this.ActiveKeyIndexTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.ActiveKeyIndexTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ActiveKeyIndexTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // PathDiscoveryTimeTb
            // 
            this.PathDiscoveryTimeTb.Index = 14;
            this.PathDiscoveryTimeTb.Location = new System.Drawing.Point(353, 61);
            this.PathDiscoveryTimeTb.Name = "PathDiscoveryTimeTb";
            this.PathDiscoveryTimeTb.ReadOnly = true;
            this.PathDiscoveryTimeTb.Size = new System.Drawing.Size(104, 20);
            this.PathDiscoveryTimeTb.TabIndex = 5;
            this.PathDiscoveryTimeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.PathDiscoveryTimeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.PathDiscoveryTimeTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // MaxJoinWaitTimeTB
            // 
            this.MaxJoinWaitTimeTB.Index = 13;
            this.MaxJoinWaitTimeTB.Location = new System.Drawing.Point(111, 58);
            this.MaxJoinWaitTimeTB.Name = "MaxJoinWaitTimeTB";
            this.MaxJoinWaitTimeTB.ReadOnly = true;
            this.MaxJoinWaitTimeTB.Size = new System.Drawing.Size(104, 20);
            this.MaxJoinWaitTimeTB.TabIndex = 4;
            this.MaxJoinWaitTimeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MaxJoinWaitTimeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MaxJoinWaitTimeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // BroadcastLogTableEntryTtlTb
            // 
            this.BroadcastLogTableEntryTtlTb.Index = 7;
            this.BroadcastLogTableEntryTtlTb.Location = new System.Drawing.Point(352, 35);
            this.BroadcastLogTableEntryTtlTb.Name = "BroadcastLogTableEntryTtlTb";
            this.BroadcastLogTableEntryTtlTb.ReadOnly = true;
            this.BroadcastLogTableEntryTtlTb.Size = new System.Drawing.Size(104, 20);
            this.BroadcastLogTableEntryTtlTb.TabIndex = 3;
            this.BroadcastLogTableEntryTtlTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.BroadcastLogTableEntryTtlTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.BroadcastLogTableEntryTtlTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // SecurityLevelTb
            // 
            this.SecurityLevelTb.Index = 4;
            this.SecurityLevelTb.Location = new System.Drawing.Point(110, 32);
            this.SecurityLevelTb.Name = "SecurityLevelTb";
            this.SecurityLevelTb.ReadOnly = true;
            this.SecurityLevelTb.Size = new System.Drawing.Size(104, 20);
            this.SecurityLevelTb.TabIndex = 2;
            this.SecurityLevelTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.SecurityLevelTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.SecurityLevelTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // WeakLqiValueTb
            // 
            this.WeakLqiValueTb.Index = 3;
            this.WeakLqiValueTb.Location = new System.Drawing.Point(352, 9);
            this.WeakLqiValueTb.Name = "WeakLqiValueTb";
            this.WeakLqiValueTb.ReadOnly = true;
            this.WeakLqiValueTb.Size = new System.Drawing.Size(104, 20);
            this.WeakLqiValueTb.TabIndex = 1;
            this.WeakLqiValueTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.WeakLqiValueTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.WeakLqiValueTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // MaxHopsTb
            // 
            this.MaxHopsTb.Index = 2;
            this.MaxHopsTb.Location = new System.Drawing.Point(110, 6);
            this.MaxHopsTb.Name = "MaxHopsTb";
            this.MaxHopsTb.ReadOnly = true;
            this.MaxHopsTb.Size = new System.Drawing.Size(104, 20);
            this.MaxHopsTb.TabIndex = 0;
            this.MaxHopsTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MaxHopsTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MaxHopsTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(570, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSG3Plc6LoWPanView
            // 
            this.ClientSize = new System.Drawing.Size(719, 522);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSG3Plc6LoWPanView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.RoutingMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label DeviceTypeLbl;
        private GXValueField CoordShortAddressTb;
        private Label CoordShortAddressLbl;
        private GXValueField MetricTypeTb;
        private Label MetricTypeLbl;
        private GXValueField ActiveKeyIndexTb;
        private Label ActiveKeyIndexLbl;
        private GXValueField PathDiscoveryTimeTb;
        private Label PathDiscoveryTimeLbl;
        private GXValueField MaxJoinWaitTimeTB;
        private Label MaxJoinWaitTimeLbl;
        private GXValueField BroadcastLogTableEntryTtlTb;
        private Label BroadcastLogTableEntryTtlLbl;
        private GXValueField SecurityLevelTb;
        private Label SecurityLevelLbl;
        private GXValueField WeakLqiValueTb;
        private Label WeakLqiValueLbl;
        private GXValueField MaxHopsTb;
        private Label MaxHopsLbl;
        private TabPage tabPage2;
        private ListView PrefixTable;
        private ColumnHeader PrefixHeader;
        private Button KeyTableRemoveBtn;
        private Button KeyTableEditBtn;
        private Button KeyTableAddBtn;
        private TabPage tabPage3;
        private ListView RoutingConfiguration;
        private ColumnHeader NetTraversalTimeHeader;
        private ColumnHeader RoutingTableEntryTtlHeader;
        private ColumnHeader KrHeader;
        private ColumnHeader KmHeader;
        private Button NeighbourTableRemoveTbBtn;
        private Button NeighbourTableAddBtn;
        private Button NeighbourTableEditBtn;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private CheckBox DisableDefaultRoutingCB;
        private GXValueField gxValueField1;
        private ListView Routing;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button RoutingRemoveBtn;
        private Button RoutingEditBtn;
        private Button RoutingAddBtn;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ContextMenuStrip RoutingMenu;
        private ToolStripMenuItem RoutingAdd;
        private ToolStripMenuItem RoutingEdit;
        private ToolStripMenuItem RoutingRemove;
        private ColumnHeader KcHeader;
        private ColumnHeader KqHeader;
        private ColumnHeader KhHeader;
        private ColumnHeader KrtHeader;
        private ColumnHeader RreqRetriesHeader;
        private ColumnHeader RreqRerrWaitHeader;
        private ColumnHeader BlacklistTableEntryTtlHeader;
        private ColumnHeader UnicastRreqGenEnableHeader;
        private ColumnHeader RlcEnabledHeader;
        private ColumnHeader AddRevLinkCostHeader;
        private ListView ContextInformation;
        private ColumnHeader CIDHeader;
        private ColumnHeader ContextHeader;
        private ColumnHeader CompressionHeader9;
        private ColumnHeader ValidLifetimeHeader;
        private ListView BlackList;
        private ColumnHeader NeighbourAddressHeader;
        private ColumnHeader ValidTimeHeader;
        private ListView BroadcastLog;
        private ColumnHeader SourceAddressHeader;
        private ColumnHeader SequenceNumberHeader;
        private ColumnHeader ValidTimeHeader2;
        private ListView GroupTable;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
    }
}
