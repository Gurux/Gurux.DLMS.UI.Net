using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSG3PlcMacSetupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSG3PlcMacSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DuplicateDetectionLbl = new System.Windows.Forms.Label();
            this.TransmitAttenLbl = new System.Windows.Forms.Label();
            this.BroadcastMaxCW = new System.Windows.Forms.CheckBox();
            this.MinBeLbl = new System.Windows.Forms.Label();
            this.MaxCsmaBackoffsLbl = new System.Windows.Forms.Label();
            this.MaxBeLbl = new System.Windows.Forms.Label();
            this.FccLegacyModeLbl = new System.Windows.Forms.Label();
            this.CenelecLegacyModeLbl = new System.Windows.Forms.Label();
            this.MinCwAttemptsLbl = new System.Windows.Forms.Label();
            this.KLbl = new System.Windows.Forms.Label();
            this.Albl = new System.Windows.Forms.Label();
            this.BeaconRandomizationWindowLengthLbl = new System.Windows.Forms.Label();
            this.CscmFairnessLimitLbl = new System.Windows.Forms.Label();
            this.HighPriorityWindowSizeLbl = new System.Windows.Forms.Label();
            this.NeighbourTableEntryTtlLbl = new System.Windows.Forms.Label();
            this.MaxFrameRetriesLbl = new System.Windows.Forms.Label();
            this.TmrTtlLbl = new System.Windows.Forms.Label();
            this.ToneMaskLbl = new System.Windows.Forms.Label();
            this.FrameCounterLbl = new System.Windows.Forms.Label();
            this.PANIdLbl = new System.Windows.Forms.Label();
            this.RcCoordLbl = new System.Windows.Forms.Label();
            this.ShortAddressLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.KeyTable = new System.Windows.Forms.ListView();
            this.IdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.keyTableMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyTableRemoveBtn = new System.Windows.Forms.Button();
            this.KeyTableEditBtn = new System.Windows.Forms.Button();
            this.KeyTableAddBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.NeighbourTable = new System.Windows.Forms.ListView();
            this.AddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PayloadModulationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModulationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToneMapHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NeighbourTableMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.NeighbourTableRemoveTbBtn = new System.Windows.Forms.Button();
            this.NeighbourTableAddBtn = new System.Windows.Forms.Button();
            this.NeighbourTableEditBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PosTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DuplicateDetectionTb = new Gurux.DLMS.UI.GXValueField();
            this.TransmitAttenTb = new Gurux.DLMS.UI.GXValueField();
            this.MinBeTB = new Gurux.DLMS.UI.GXValueField();
            this.MaxCsmaBackoffsTB = new Gurux.DLMS.UI.GXValueField();
            this.MaxBeTB = new Gurux.DLMS.UI.GXValueField();
            this.FccLegacyModeTB = new Gurux.DLMS.UI.GXValueField();
            this.CenelecLegacyModeTB = new Gurux.DLMS.UI.GXValueField();
            this.MinCwAttemptsTB = new Gurux.DLMS.UI.GXValueField();
            this.KTB = new Gurux.DLMS.UI.GXValueField();
            this.ATX = new Gurux.DLMS.UI.GXValueField();
            this.BeaconRandomizationWindowLengthTB = new Gurux.DLMS.UI.GXValueField();
            this.CscmFairnessLimitTB = new Gurux.DLMS.UI.GXValueField();
            this.HighPriorityWindowSizeTB = new Gurux.DLMS.UI.GXValueField();
            this.NeighbourTableEntryTtlTB = new Gurux.DLMS.UI.GXValueField();
            this.MaxFrameRetriesTB = new Gurux.DLMS.UI.GXValueField();
            this.TmrTtlTB = new Gurux.DLMS.UI.GXValueField();
            this.ToneMaskTB = new Gurux.DLMS.UI.GXValueField();
            this.FrameCounterTB = new Gurux.DLMS.UI.GXValueField();
            this.PANIdTB = new Gurux.DLMS.UI.GXValueField();
            this.RcCoordTB = new Gurux.DLMS.UI.GXValueField();
            this.ShortAddressTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.keyTableMenu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.NeighbourTableMenu.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(491, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " G3-PLC MAC setup object";
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
            this.DescriptionTB.Size = new System.Drawing.Size(367, 20);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 424);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DuplicateDetectionTb);
            this.tabPage1.Controls.Add(this.DuplicateDetectionLbl);
            this.tabPage1.Controls.Add(this.TransmitAttenTb);
            this.tabPage1.Controls.Add(this.TransmitAttenLbl);
            this.tabPage1.Controls.Add(this.BroadcastMaxCW);
            this.tabPage1.Controls.Add(this.MinBeTB);
            this.tabPage1.Controls.Add(this.MinBeLbl);
            this.tabPage1.Controls.Add(this.MaxCsmaBackoffsTB);
            this.tabPage1.Controls.Add(this.MaxCsmaBackoffsLbl);
            this.tabPage1.Controls.Add(this.MaxBeTB);
            this.tabPage1.Controls.Add(this.MaxBeLbl);
            this.tabPage1.Controls.Add(this.FccLegacyModeTB);
            this.tabPage1.Controls.Add(this.FccLegacyModeLbl);
            this.tabPage1.Controls.Add(this.CenelecLegacyModeTB);
            this.tabPage1.Controls.Add(this.CenelecLegacyModeLbl);
            this.tabPage1.Controls.Add(this.MinCwAttemptsTB);
            this.tabPage1.Controls.Add(this.MinCwAttemptsLbl);
            this.tabPage1.Controls.Add(this.KTB);
            this.tabPage1.Controls.Add(this.KLbl);
            this.tabPage1.Controls.Add(this.ATX);
            this.tabPage1.Controls.Add(this.Albl);
            this.tabPage1.Controls.Add(this.BeaconRandomizationWindowLengthTB);
            this.tabPage1.Controls.Add(this.BeaconRandomizationWindowLengthLbl);
            this.tabPage1.Controls.Add(this.CscmFairnessLimitTB);
            this.tabPage1.Controls.Add(this.CscmFairnessLimitLbl);
            this.tabPage1.Controls.Add(this.HighPriorityWindowSizeTB);
            this.tabPage1.Controls.Add(this.HighPriorityWindowSizeLbl);
            this.tabPage1.Controls.Add(this.NeighbourTableEntryTtlTB);
            this.tabPage1.Controls.Add(this.NeighbourTableEntryTtlLbl);
            this.tabPage1.Controls.Add(this.MaxFrameRetriesTB);
            this.tabPage1.Controls.Add(this.MaxFrameRetriesLbl);
            this.tabPage1.Controls.Add(this.TmrTtlTB);
            this.tabPage1.Controls.Add(this.TmrTtlLbl);
            this.tabPage1.Controls.Add(this.ToneMaskTB);
            this.tabPage1.Controls.Add(this.ToneMaskLbl);
            this.tabPage1.Controls.Add(this.FrameCounterTB);
            this.tabPage1.Controls.Add(this.FrameCounterLbl);
            this.tabPage1.Controls.Add(this.PANIdTB);
            this.tabPage1.Controls.Add(this.PANIdLbl);
            this.tabPage1.Controls.Add(this.RcCoordTB);
            this.tabPage1.Controls.Add(this.RcCoordLbl);
            this.tabPage1.Controls.Add(this.ShortAddressTB);
            this.tabPage1.Controls.Add(this.ShortAddressLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DuplicateDetectionLbl
            // 
            this.DuplicateDetectionLbl.AutoSize = true;
            this.DuplicateDetectionLbl.Location = new System.Drawing.Point(239, 270);
            this.DuplicateDetectionLbl.Name = "DuplicateDetectionLbl";
            this.DuplicateDetectionLbl.Size = new System.Drawing.Size(99, 13);
            this.DuplicateDetectionLbl.TabIndex = 64;
            this.DuplicateDetectionLbl.Text = "Duplicate detection";
            // 
            // TransmitAttenLbl
            // 
            this.TransmitAttenLbl.AutoSize = true;
            this.TransmitAttenLbl.Location = new System.Drawing.Point(14, 270);
            this.TransmitAttenLbl.Name = "TransmitAttenLbl";
            this.TransmitAttenLbl.Size = new System.Drawing.Size(77, 13);
            this.TransmitAttenLbl.TabIndex = 62;
            this.TransmitAttenLbl.Text = "Transmit atten:";
            // 
            // BroadcastMaxCW
            // 
            this.BroadcastMaxCW.Location = new System.Drawing.Point(244, 244);
            this.BroadcastMaxCW.Name = "BroadcastMaxCW";
            this.BroadcastMaxCW.Size = new System.Drawing.Size(212, 23);
            this.BroadcastMaxCW.TabIndex = 60;
            this.BroadcastMaxCW.Text = "Broadcast max CW Enabled";
            this.BroadcastMaxCW.UseVisualStyleBackColor = false;
            // 
            // MinBeLbl
            // 
            this.MinBeLbl.AutoSize = true;
            this.MinBeLbl.Location = new System.Drawing.Point(14, 244);
            this.MinBeLbl.Name = "MinBeLbl";
            this.MinBeLbl.Size = new System.Drawing.Size(72, 13);
            this.MinBeLbl.TabIndex = 59;
            this.MinBeLbl.Text = "Min  backoff: ";
            // 
            // MaxCsmaBackoffsLbl
            // 
            this.MaxCsmaBackoffsLbl.AutoSize = true;
            this.MaxCsmaBackoffsLbl.Location = new System.Drawing.Point(242, 222);
            this.MaxCsmaBackoffsLbl.Name = "MaxCsmaBackoffsLbl";
            this.MaxCsmaBackoffsLbl.Size = new System.Drawing.Size(105, 13);
            this.MaxCsmaBackoffsLbl.TabIndex = 57;
            this.MaxCsmaBackoffsLbl.Text = "Max CSMA Backoffs";
            // 
            // MaxBeLbl
            // 
            this.MaxBeLbl.AutoSize = true;
            this.MaxBeLbl.Location = new System.Drawing.Point(14, 218);
            this.MaxBeLbl.Name = "MaxBeLbl";
            this.MaxBeLbl.Size = new System.Drawing.Size(72, 13);
            this.MaxBeLbl.TabIndex = 55;
            this.MaxBeLbl.Text = "Max  backoff:";
            // 
            // FccLegacyModeLbl
            // 
            this.FccLegacyModeLbl.AutoSize = true;
            this.FccLegacyModeLbl.Location = new System.Drawing.Point(241, 196);
            this.FccLegacyModeLbl.Name = "FccLegacyModeLbl";
            this.FccLegacyModeLbl.Size = new System.Drawing.Size(98, 13);
            this.FccLegacyModeLbl.TabIndex = 53;
            this.FccLegacyModeLbl.Text = "FCC Legacy Mode:";
            // 
            // CenelecLegacyModeLbl
            // 
            this.CenelecLegacyModeLbl.AutoSize = true;
            this.CenelecLegacyModeLbl.Location = new System.Drawing.Point(13, 192);
            this.CenelecLegacyModeLbl.Name = "CenelecLegacyModeLbl";
            this.CenelecLegacyModeLbl.Size = new System.Drawing.Size(87, 13);
            this.CenelecLegacyModeLbl.TabIndex = 51;
            this.CenelecLegacyModeLbl.Text = "Cenelec Legacy:";
            // 
            // MinCwAttemptsLbl
            // 
            this.MinCwAttemptsLbl.AutoSize = true;
            this.MinCwAttemptsLbl.Location = new System.Drawing.Point(242, 171);
            this.MinCwAttemptsLbl.Name = "MinCwAttemptsLbl";
            this.MinCwAttemptsLbl.Size = new System.Drawing.Size(92, 13);
            this.MinCwAttemptsLbl.TabIndex = 49;
            this.MinCwAttemptsLbl.Text = "Min CW Attempts:";
            // 
            // KLbl
            // 
            this.KLbl.AutoSize = true;
            this.KLbl.Location = new System.Drawing.Point(14, 167);
            this.KLbl.Name = "KLbl";
            this.KLbl.Size = new System.Drawing.Size(17, 13);
            this.KLbl.TabIndex = 47;
            this.KLbl.Text = "K:";
            // 
            // Albl
            // 
            this.Albl.AutoSize = true;
            this.Albl.Location = new System.Drawing.Point(242, 145);
            this.Albl.Name = "Albl";
            this.Albl.Size = new System.Drawing.Size(17, 13);
            this.Albl.TabIndex = 45;
            this.Albl.Text = "A:";
            // 
            // BeaconRandomizationWindowLengthLbl
            // 
            this.BeaconRandomizationWindowLengthLbl.AutoSize = true;
            this.BeaconRandomizationWindowLengthLbl.Location = new System.Drawing.Point(14, 141);
            this.BeaconRandomizationWindowLengthLbl.Name = "BeaconRandomizationWindowLengthLbl";
            this.BeaconRandomizationWindowLengthLbl.Size = new System.Drawing.Size(70, 13);
            this.BeaconRandomizationWindowLengthLbl.TabIndex = 43;
            this.BeaconRandomizationWindowLengthLbl.Text = "Beacon Rnd:";
            // 
            // CscmFairnessLimitLbl
            // 
            this.CscmFairnessLimitLbl.AutoSize = true;
            this.CscmFairnessLimitLbl.Location = new System.Drawing.Point(241, 119);
            this.CscmFairnessLimitLbl.Name = "CscmFairnessLimitLbl";
            this.CscmFairnessLimitLbl.Size = new System.Drawing.Size(106, 13);
            this.CscmFairnessLimitLbl.TabIndex = 41;
            this.CscmFairnessLimitLbl.Text = "CSCM Fairness Limit:";
            // 
            // HighPriorityWindowSizeLbl
            // 
            this.HighPriorityWindowSizeLbl.AutoSize = true;
            this.HighPriorityWindowSizeLbl.Location = new System.Drawing.Point(13, 115);
            this.HighPriorityWindowSizeLbl.Name = "HighPriorityWindowSizeLbl";
            this.HighPriorityWindowSizeLbl.Size = new System.Drawing.Size(87, 13);
            this.HighPriorityWindowSizeLbl.TabIndex = 39;
            this.HighPriorityWindowSizeLbl.Text = "HighPriority SIze:";
            // 
            // NeighbourTableEntryTtlLbl
            // 
            this.NeighbourTableEntryTtlLbl.AutoSize = true;
            this.NeighbourTableEntryTtlLbl.Location = new System.Drawing.Point(242, 91);
            this.NeighbourTableEntryTtlLbl.Name = "NeighbourTableEntryTtlLbl";
            this.NeighbourTableEntryTtlLbl.Size = new System.Drawing.Size(108, 13);
            this.NeighbourTableEntryTtlLbl.TabIndex = 37;
            this.NeighbourTableEntryTtlLbl.Text = "Neighbour table TTL:";
            // 
            // MaxFrameRetriesLbl
            // 
            this.MaxFrameRetriesLbl.AutoSize = true;
            this.MaxFrameRetriesLbl.Location = new System.Drawing.Point(14, 87);
            this.MaxFrameRetriesLbl.Name = "MaxFrameRetriesLbl";
            this.MaxFrameRetriesLbl.Size = new System.Drawing.Size(98, 13);
            this.MaxFrameRetriesLbl.TabIndex = 35;
            this.MaxFrameRetriesLbl.Text = "Max Frame Retries:";
            // 
            // TmrTtlLbl
            // 
            this.TmrTtlLbl.AutoSize = true;
            this.TmrTtlLbl.Location = new System.Drawing.Point(242, 65);
            this.TmrTtlLbl.Name = "TmrTtlLbl";
            this.TmrTtlLbl.Size = new System.Drawing.Size(82, 13);
            this.TmrTtlLbl.TabIndex = 33;
            this.TmrTtlLbl.Text = "Tone Map TTL:";
            // 
            // ToneMaskLbl
            // 
            this.ToneMaskLbl.AutoSize = true;
            this.ToneMaskLbl.Location = new System.Drawing.Point(14, 61);
            this.ToneMaskLbl.Name = "ToneMaskLbl";
            this.ToneMaskLbl.Size = new System.Drawing.Size(64, 13);
            this.ToneMaskLbl.TabIndex = 31;
            this.ToneMaskLbl.Text = "Tone Mask:";
            // 
            // FrameCounterLbl
            // 
            this.FrameCounterLbl.AutoSize = true;
            this.FrameCounterLbl.Location = new System.Drawing.Point(241, 39);
            this.FrameCounterLbl.Name = "FrameCounterLbl";
            this.FrameCounterLbl.Size = new System.Drawing.Size(79, 13);
            this.FrameCounterLbl.TabIndex = 29;
            this.FrameCounterLbl.Text = "Frame Counter:";
            // 
            // PANIdLbl
            // 
            this.PANIdLbl.AutoSize = true;
            this.PANIdLbl.Location = new System.Drawing.Point(13, 35);
            this.PANIdLbl.Name = "PANIdLbl";
            this.PANIdLbl.Size = new System.Drawing.Size(46, 13);
            this.PANIdLbl.TabIndex = 27;
            this.PANIdLbl.Text = "PAN ID:";
            // 
            // RcCoordLbl
            // 
            this.RcCoordLbl.AutoSize = true;
            this.RcCoordLbl.Location = new System.Drawing.Point(241, 13);
            this.RcCoordLbl.Name = "RcCoordLbl";
            this.RcCoordLbl.Size = new System.Drawing.Size(104, 13);
            this.RcCoordLbl.TabIndex = 25;
            this.RcCoordLbl.Text = "Route cost to coord:";
            // 
            // ShortAddressLbl
            // 
            this.ShortAddressLbl.AutoSize = true;
            this.ShortAddressLbl.Location = new System.Drawing.Point(13, 9);
            this.ShortAddressLbl.Name = "ShortAddressLbl";
            this.ShortAddressLbl.Size = new System.Drawing.Size(76, 13);
            this.ShortAddressLbl.TabIndex = 23;
            this.ShortAddressLbl.Text = "Short Address:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.KeyTable);
            this.tabPage2.Controls.Add(this.KeyTableRemoveBtn);
            this.tabPage2.Controls.Add(this.KeyTableEditBtn);
            this.tabPage2.Controls.Add(this.KeyTableAddBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Key table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // KeyTable
            // 
            this.KeyTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHeader,
            this.KeyHeader});
            this.KeyTable.ContextMenuStrip = this.keyTableMenu;
            this.KeyTable.FullRowSelect = true;
            this.KeyTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.KeyTable.HideSelection = false;
            this.KeyTable.Location = new System.Drawing.Point(3, 3);
            this.KeyTable.Name = "KeyTable";
            this.KeyTable.Size = new System.Drawing.Size(480, 349);
            this.KeyTable.TabIndex = 8;
            this.KeyTable.UseCompatibleStateImageBehavior = false;
            this.KeyTable.View = System.Windows.Forms.View.Details;
            this.KeyTable.DoubleClick += new System.EventHandler(this.KeyTableEditBtn_Click);
            // 
            // IdHeader
            // 
            this.IdHeader.Text = "ID:";
            this.IdHeader.Width = 74;
            // 
            // KeyHeader
            // 
            this.KeyHeader.Text = "Key:";
            this.KeyHeader.Width = 396;
            // 
            // keyTableMenu
            // 
            this.keyTableMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.keyTableMenu.Name = "contextMenuStrip1";
            this.keyTableMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.KeyTableAddBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.KeyTableEditBtn_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.KeyTableRemoveBtn_Click);
            // 
            // KeyTableRemoveBtn
            // 
            this.KeyTableRemoveBtn.Location = new System.Drawing.Point(402, 358);
            this.KeyTableRemoveBtn.Name = "KeyTableRemoveBtn";
            this.KeyTableRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.KeyTableRemoveBtn.TabIndex = 7;
            this.KeyTableRemoveBtn.Text = "Remove...";
            this.KeyTableRemoveBtn.UseVisualStyleBackColor = true;
            this.KeyTableRemoveBtn.Click += new System.EventHandler(this.KeyTableRemoveBtn_Click);
            // 
            // KeyTableEditBtn
            // 
            this.KeyTableEditBtn.Location = new System.Drawing.Point(321, 358);
            this.KeyTableEditBtn.Name = "KeyTableEditBtn";
            this.KeyTableEditBtn.Size = new System.Drawing.Size(75, 23);
            this.KeyTableEditBtn.TabIndex = 6;
            this.KeyTableEditBtn.Text = "Edit...";
            this.KeyTableEditBtn.UseVisualStyleBackColor = true;
            this.KeyTableEditBtn.Click += new System.EventHandler(this.KeyTableEditBtn_Click);
            // 
            // KeyTableAddBtn
            // 
            this.KeyTableAddBtn.Location = new System.Drawing.Point(240, 358);
            this.KeyTableAddBtn.Name = "KeyTableAddBtn";
            this.KeyTableAddBtn.Size = new System.Drawing.Size(75, 23);
            this.KeyTableAddBtn.TabIndex = 5;
            this.KeyTableAddBtn.Text = "Add...";
            this.KeyTableAddBtn.UseVisualStyleBackColor = true;
            this.KeyTableAddBtn.Click += new System.EventHandler(this.KeyTableAddBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.NeighbourTable);
            this.tabPage3.Controls.Add(this.NeighbourTableRemoveTbBtn);
            this.tabPage3.Controls.Add(this.NeighbourTableAddBtn);
            this.tabPage3.Controls.Add(this.NeighbourTableEditBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(483, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Neighbour table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // NeighbourTable
            // 
            this.NeighbourTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AddressHeader,
            this.PayloadModulationHeader,
            this.ModulationHeader,
            this.ToneMapHeader});
            this.NeighbourTable.ContextMenuStrip = this.NeighbourTableMenu;
            this.NeighbourTable.FullRowSelect = true;
            this.NeighbourTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.NeighbourTable.HideSelection = false;
            this.NeighbourTable.Location = new System.Drawing.Point(0, 0);
            this.NeighbourTable.Name = "NeighbourTable";
            this.NeighbourTable.Size = new System.Drawing.Size(480, 349);
            this.NeighbourTable.TabIndex = 12;
            this.NeighbourTable.UseCompatibleStateImageBehavior = false;
            this.NeighbourTable.View = System.Windows.Forms.View.Details;
            this.NeighbourTable.DoubleClick += new System.EventHandler(this.NeighbourTableEditBtn_Click);
            // 
            // AddressHeader
            // 
            this.AddressHeader.Text = "Address:";
            this.AddressHeader.Width = 74;
            // 
            // PayloadModulationHeader
            // 
            this.PayloadModulationHeader.Text = "Enabled:";
            this.PayloadModulationHeader.Width = 120;
            // 
            // ModulationHeader
            // 
            this.ModulationHeader.Text = "Modulation:";
            this.ModulationHeader.Width = 98;
            // 
            // ToneMapHeader
            // 
            this.ToneMapHeader.Text = "Tone Map:";
            this.ToneMapHeader.Width = 97;
            // 
            // NeighbourTableMenu
            // 
            this.NeighbourTableMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.NeighbourTableMenu.Name = "contextMenuStrip1";
            this.NeighbourTableMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.NeighbourTableAddBtn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Edit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.NeighbourTableEditBtn_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem3.Text = "Remove";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.NeighbourTableRemoveTbBtn_Click);
            // 
            // NeighbourTableRemoveTbBtn
            // 
            this.NeighbourTableRemoveTbBtn.Location = new System.Drawing.Point(399, 355);
            this.NeighbourTableRemoveTbBtn.Name = "NeighbourTableRemoveTbBtn";
            this.NeighbourTableRemoveTbBtn.Size = new System.Drawing.Size(75, 23);
            this.NeighbourTableRemoveTbBtn.TabIndex = 11;
            this.NeighbourTableRemoveTbBtn.Text = "Remove...";
            this.NeighbourTableRemoveTbBtn.UseVisualStyleBackColor = true;
            this.NeighbourTableRemoveTbBtn.Click += new System.EventHandler(this.NeighbourTableRemoveTbBtn_Click);
            // 
            // NeighbourTableAddBtn
            // 
            this.NeighbourTableAddBtn.Location = new System.Drawing.Point(237, 355);
            this.NeighbourTableAddBtn.Name = "NeighbourTableAddBtn";
            this.NeighbourTableAddBtn.Size = new System.Drawing.Size(75, 23);
            this.NeighbourTableAddBtn.TabIndex = 9;
            this.NeighbourTableAddBtn.Text = "Add...";
            this.NeighbourTableAddBtn.UseVisualStyleBackColor = true;
            this.NeighbourTableAddBtn.Click += new System.EventHandler(this.NeighbourTableAddBtn_Click);
            // 
            // NeighbourTableEditBtn
            // 
            this.NeighbourTableEditBtn.Location = new System.Drawing.Point(318, 355);
            this.NeighbourTableEditBtn.Name = "NeighbourTableEditBtn";
            this.NeighbourTableEditBtn.Size = new System.Drawing.Size(75, 23);
            this.NeighbourTableEditBtn.TabIndex = 10;
            this.NeighbourTableEditBtn.Text = "Edit...";
            this.NeighbourTableEditBtn.UseVisualStyleBackColor = true;
            this.NeighbourTableEditBtn.Click += new System.EventHandler(this.NeighbourTableEditBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.PosTable);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(483, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "POS table";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // PosTable
            // 
            this.PosTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.PosTable.FullRowSelect = true;
            this.PosTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PosTable.HideSelection = false;
            this.PosTable.Location = new System.Drawing.Point(1, 25);
            this.PosTable.Name = "PosTable";
            this.PosTable.Size = new System.Drawing.Size(480, 349);
            this.PosTable.TabIndex = 9;
            this.PosTable.UseCompatibleStateImageBehavior = false;
            this.PosTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "LQI";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Valid time";
            this.columnHeader3.Width = 92;
            // 
            // DuplicateDetectionTb
            // 
            this.DuplicateDetectionTb.Index = 26;
            this.DuplicateDetectionTb.Location = new System.Drawing.Point(352, 267);
            this.DuplicateDetectionTb.Name = "DuplicateDetectionTb";
            this.DuplicateDetectionTb.NotifyChanges = false;
            this.DuplicateDetectionTb.ReadOnly = true;
            this.DuplicateDetectionTb.Size = new System.Drawing.Size(104, 20);
            this.DuplicateDetectionTb.TabIndex = 63;
            this.DuplicateDetectionTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TransmitAttenTb
            // 
            this.TransmitAttenTb.Index = 24;
            this.TransmitAttenTb.Location = new System.Drawing.Point(111, 267);
            this.TransmitAttenTb.Name = "TransmitAttenTb";
            this.TransmitAttenTb.NotifyChanges = false;
            this.TransmitAttenTb.ReadOnly = true;
            this.TransmitAttenTb.Size = new System.Drawing.Size(104, 20);
            this.TransmitAttenTb.TabIndex = 61;
            this.TransmitAttenTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // MinBeTB
            // 
            this.MinBeTB.Index = 22;
            this.MinBeTB.Location = new System.Drawing.Point(111, 241);
            this.MinBeTB.Name = "MinBeTB";
            this.MinBeTB.NotifyChanges = false;
            this.MinBeTB.ReadOnly = true;
            this.MinBeTB.Size = new System.Drawing.Size(104, 20);
            this.MinBeTB.TabIndex = 58;
            this.MinBeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MinBeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MinBeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // MaxCsmaBackoffsTB
            // 
            this.MaxCsmaBackoffsTB.Index = 21;
            this.MaxCsmaBackoffsTB.Location = new System.Drawing.Point(353, 218);
            this.MaxCsmaBackoffsTB.Name = "MaxCsmaBackoffsTB";
            this.MaxCsmaBackoffsTB.NotifyChanges = false;
            this.MaxCsmaBackoffsTB.ReadOnly = true;
            this.MaxCsmaBackoffsTB.Size = new System.Drawing.Size(104, 20);
            this.MaxCsmaBackoffsTB.TabIndex = 56;
            this.MaxCsmaBackoffsTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MaxCsmaBackoffsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MaxCsmaBackoffsTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // MaxBeTB
            // 
            this.MaxBeTB.Index = 20;
            this.MaxBeTB.Location = new System.Drawing.Point(111, 215);
            this.MaxBeTB.Name = "MaxBeTB";
            this.MaxBeTB.NotifyChanges = false;
            this.MaxBeTB.ReadOnly = true;
            this.MaxBeTB.Size = new System.Drawing.Size(104, 20);
            this.MaxBeTB.TabIndex = 54;
            this.MaxBeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MaxBeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MaxBeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // FccLegacyModeTB
            // 
            this.FccLegacyModeTB.Index = 19;
            this.FccLegacyModeTB.Location = new System.Drawing.Point(352, 192);
            this.FccLegacyModeTB.Name = "FccLegacyModeTB";
            this.FccLegacyModeTB.NotifyChanges = false;
            this.FccLegacyModeTB.ReadOnly = true;
            this.FccLegacyModeTB.Size = new System.Drawing.Size(104, 20);
            this.FccLegacyModeTB.TabIndex = 52;
            this.FccLegacyModeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.FccLegacyModeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.FccLegacyModeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CenelecLegacyModeTB
            // 
            this.CenelecLegacyModeTB.Index = 18;
            this.CenelecLegacyModeTB.Location = new System.Drawing.Point(110, 189);
            this.CenelecLegacyModeTB.Name = "CenelecLegacyModeTB";
            this.CenelecLegacyModeTB.NotifyChanges = false;
            this.CenelecLegacyModeTB.ReadOnly = true;
            this.CenelecLegacyModeTB.Size = new System.Drawing.Size(104, 20);
            this.CenelecLegacyModeTB.TabIndex = 50;
            this.CenelecLegacyModeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CenelecLegacyModeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CenelecLegacyModeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // MinCwAttemptsTB
            // 
            this.MinCwAttemptsTB.Index = 17;
            this.MinCwAttemptsTB.Location = new System.Drawing.Point(353, 167);
            this.MinCwAttemptsTB.Name = "MinCwAttemptsTB";
            this.MinCwAttemptsTB.NotifyChanges = false;
            this.MinCwAttemptsTB.ReadOnly = true;
            this.MinCwAttemptsTB.Size = new System.Drawing.Size(104, 20);
            this.MinCwAttemptsTB.TabIndex = 48;
            this.MinCwAttemptsTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MinCwAttemptsTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MinCwAttemptsTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // KTB
            // 
            this.KTB.Index = 16;
            this.KTB.Location = new System.Drawing.Point(111, 164);
            this.KTB.Name = "KTB";
            this.KTB.NotifyChanges = false;
            this.KTB.ReadOnly = true;
            this.KTB.Size = new System.Drawing.Size(104, 20);
            this.KTB.TabIndex = 46;
            this.KTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.KTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.KTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // ATX
            // 
            this.ATX.Index = 15;
            this.ATX.Location = new System.Drawing.Point(353, 141);
            this.ATX.Name = "ATX";
            this.ATX.NotifyChanges = false;
            this.ATX.ReadOnly = true;
            this.ATX.Size = new System.Drawing.Size(104, 20);
            this.ATX.TabIndex = 44;
            this.ATX.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.ATX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ATX.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // BeaconRandomizationWindowLengthTB
            // 
            this.BeaconRandomizationWindowLengthTB.Index = 14;
            this.BeaconRandomizationWindowLengthTB.Location = new System.Drawing.Point(111, 138);
            this.BeaconRandomizationWindowLengthTB.Name = "BeaconRandomizationWindowLengthTB";
            this.BeaconRandomizationWindowLengthTB.NotifyChanges = false;
            this.BeaconRandomizationWindowLengthTB.ReadOnly = true;
            this.BeaconRandomizationWindowLengthTB.Size = new System.Drawing.Size(104, 20);
            this.BeaconRandomizationWindowLengthTB.TabIndex = 42;
            this.BeaconRandomizationWindowLengthTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.BeaconRandomizationWindowLengthTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.BeaconRandomizationWindowLengthTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CscmFairnessLimitTB
            // 
            this.CscmFairnessLimitTB.Index = 13;
            this.CscmFairnessLimitTB.Location = new System.Drawing.Point(352, 115);
            this.CscmFairnessLimitTB.Name = "CscmFairnessLimitTB";
            this.CscmFairnessLimitTB.NotifyChanges = false;
            this.CscmFairnessLimitTB.ReadOnly = true;
            this.CscmFairnessLimitTB.Size = new System.Drawing.Size(104, 20);
            this.CscmFairnessLimitTB.TabIndex = 40;
            this.CscmFairnessLimitTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CscmFairnessLimitTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CscmFairnessLimitTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // HighPriorityWindowSizeTB
            // 
            this.HighPriorityWindowSizeTB.Index = 12;
            this.HighPriorityWindowSizeTB.Location = new System.Drawing.Point(110, 112);
            this.HighPriorityWindowSizeTB.Name = "HighPriorityWindowSizeTB";
            this.HighPriorityWindowSizeTB.NotifyChanges = false;
            this.HighPriorityWindowSizeTB.ReadOnly = true;
            this.HighPriorityWindowSizeTB.Size = new System.Drawing.Size(104, 20);
            this.HighPriorityWindowSizeTB.TabIndex = 38;
            this.HighPriorityWindowSizeTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.HighPriorityWindowSizeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.HighPriorityWindowSizeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // NeighbourTableEntryTtlTB
            // 
            this.NeighbourTableEntryTtlTB.Index = 10;
            this.NeighbourTableEntryTtlTB.Location = new System.Drawing.Point(353, 87);
            this.NeighbourTableEntryTtlTB.Name = "NeighbourTableEntryTtlTB";
            this.NeighbourTableEntryTtlTB.NotifyChanges = false;
            this.NeighbourTableEntryTtlTB.ReadOnly = true;
            this.NeighbourTableEntryTtlTB.Size = new System.Drawing.Size(104, 20);
            this.NeighbourTableEntryTtlTB.TabIndex = 36;
            this.NeighbourTableEntryTtlTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.NeighbourTableEntryTtlTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.NeighbourTableEntryTtlTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // MaxFrameRetriesTB
            // 
            this.MaxFrameRetriesTB.Index = 9;
            this.MaxFrameRetriesTB.Location = new System.Drawing.Point(111, 84);
            this.MaxFrameRetriesTB.Name = "MaxFrameRetriesTB";
            this.MaxFrameRetriesTB.NotifyChanges = false;
            this.MaxFrameRetriesTB.ReadOnly = true;
            this.MaxFrameRetriesTB.Size = new System.Drawing.Size(104, 20);
            this.MaxFrameRetriesTB.TabIndex = 34;
            this.MaxFrameRetriesTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.MaxFrameRetriesTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.MaxFrameRetriesTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // TmrTtlTB
            // 
            this.TmrTtlTB.Index = 8;
            this.TmrTtlTB.Location = new System.Drawing.Point(353, 61);
            this.TmrTtlTB.Name = "TmrTtlTB";
            this.TmrTtlTB.NotifyChanges = false;
            this.TmrTtlTB.ReadOnly = true;
            this.TmrTtlTB.Size = new System.Drawing.Size(104, 20);
            this.TmrTtlTB.TabIndex = 32;
            this.TmrTtlTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.TmrTtlTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.TmrTtlTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // ToneMaskTB
            // 
            this.ToneMaskTB.Index = 7;
            this.ToneMaskTB.Location = new System.Drawing.Point(111, 58);
            this.ToneMaskTB.Name = "ToneMaskTB";
            this.ToneMaskTB.NotifyChanges = false;
            this.ToneMaskTB.ReadOnly = true;
            this.ToneMaskTB.Size = new System.Drawing.Size(104, 20);
            this.ToneMaskTB.TabIndex = 30;
            this.ToneMaskTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.ToneMaskTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ToneMaskTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // FrameCounterTB
            // 
            this.FrameCounterTB.Index = 6;
            this.FrameCounterTB.Location = new System.Drawing.Point(352, 35);
            this.FrameCounterTB.Name = "FrameCounterTB";
            this.FrameCounterTB.NotifyChanges = false;
            this.FrameCounterTB.ReadOnly = true;
            this.FrameCounterTB.Size = new System.Drawing.Size(104, 20);
            this.FrameCounterTB.TabIndex = 28;
            this.FrameCounterTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.FrameCounterTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.FrameCounterTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // PANIdTB
            // 
            this.PANIdTB.Index = 4;
            this.PANIdTB.Location = new System.Drawing.Point(110, 32);
            this.PANIdTB.Name = "PANIdTB";
            this.PANIdTB.NotifyChanges = false;
            this.PANIdTB.ReadOnly = true;
            this.PANIdTB.Size = new System.Drawing.Size(104, 20);
            this.PANIdTB.TabIndex = 26;
            this.PANIdTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.PANIdTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.PANIdTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // RcCoordTB
            // 
            this.RcCoordTB.Index = 3;
            this.RcCoordTB.Location = new System.Drawing.Point(352, 9);
            this.RcCoordTB.Name = "RcCoordTB";
            this.RcCoordTB.NotifyChanges = false;
            this.RcCoordTB.ReadOnly = true;
            this.RcCoordTB.Size = new System.Drawing.Size(104, 20);
            this.RcCoordTB.TabIndex = 24;
            this.RcCoordTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.RcCoordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.RcCoordTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // ShortAddressTB
            // 
            this.ShortAddressTB.Index = 2;
            this.ShortAddressTB.Location = new System.Drawing.Point(110, 6);
            this.ShortAddressTB.Name = "ShortAddressTB";
            this.ShortAddressTB.NotifyChanges = false;
            this.ShortAddressTB.ReadOnly = true;
            this.ShortAddressTB.Size = new System.Drawing.Size(104, 20);
            this.ShortAddressTB.TabIndex = 22;
            this.ShortAddressTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.ShortAddressTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ShortAddressTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(366, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSG3PlcMacSetupView
            // 
            this.ClientSize = new System.Drawing.Size(515, 533);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSG3PlcMacSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.keyTableMenu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.NeighbourTableMenu.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private GXValueField NeighbourTableEntryTtlTB;
        private Label NeighbourTableEntryTtlLbl;
        private GXValueField MaxFrameRetriesTB;
        private Label MaxFrameRetriesLbl;
        private GXValueField TmrTtlTB;
        private Label TmrTtlLbl;
        private GXValueField ToneMaskTB;
        private Label ToneMaskLbl;
        private GXValueField FrameCounterTB;
        private Label FrameCounterLbl;
        private GXValueField PANIdTB;
        private Label PANIdLbl;
        private GXValueField RcCoordTB;
        private Label RcCoordLbl;
        private GXValueField ShortAddressTB;
        private Label ShortAddressLbl;
        private GXValueField MinBeTB;
        private Label MinBeLbl;
        private GXValueField MaxCsmaBackoffsTB;
        private Label MaxCsmaBackoffsLbl;
        private GXValueField MaxBeTB;
        private Label MaxBeLbl;
        private GXValueField FccLegacyModeTB;
        private Label FccLegacyModeLbl;
        private GXValueField CenelecLegacyModeTB;
        private Label CenelecLegacyModeLbl;
        private GXValueField MinCwAttemptsTB;
        private Label MinCwAttemptsLbl;
        private GXValueField KTB;
        private Label KLbl;
        private GXValueField ATX;
        private Label Albl;
        private GXValueField BeaconRandomizationWindowLengthTB;
        private Label BeaconRandomizationWindowLengthLbl;
        private GXValueField CscmFairnessLimitTB;
        private Label CscmFairnessLimitLbl;
        private GXValueField HighPriorityWindowSizeTB;
        private Label HighPriorityWindowSizeLbl;
        private Button KeyTableRemoveBtn;
        private ContextMenuStrip keyTableMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private Button KeyTableEditBtn;
        private Button KeyTableAddBtn;
        private Button NeighbourTableRemoveTbBtn;
        private ContextMenuStrip NeighbourTableMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Button NeighbourTableAddBtn;
        private Button NeighbourTableEditBtn;
        private ListView KeyTable;
        private ColumnHeader IdHeader;
        private ColumnHeader KeyHeader;
        private ListView NeighbourTable;
        private ColumnHeader AddressHeader;
        private ColumnHeader PayloadModulationHeader;
        private ColumnHeader ModulationHeader;
        private ColumnHeader ToneMapHeader;
        private CheckBox BroadcastMaxCW;
        private GXValueField DuplicateDetectionTb;
        private Label DuplicateDetectionLbl;
        private GXValueField TransmitAttenTb;
        private Label TransmitAttenLbl;
        private TabPage tabPage4;
        private ListView PosTable;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
