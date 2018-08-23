using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSAutoConnectView
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
        private GXValueField ModeTB;
        private Label CommunicationSpeedLbl;
        private GXValueField LogicalNameTB;
        private GXValueField RepetitionDelayTB;
        private Label RepetitionDelayLbl;
        private GXValueField RepetitionsTB;
        private Label RepetitionsLbl;
        private Label CallingWindowLbl;
        private ListView CallingWindowLV;
        private ColumnHeader StartTimeHeader;
        private ColumnHeader EndTimeHeader;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSAutoConnectView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectBtn = new Gurux.DLMS.UI.GXButton();
            this.DestinationLv = new System.Windows.Forms.ListView();
            this.DestinationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DestinationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DestinationRemoveBtn = new System.Windows.Forms.Button();
            this.DestinationEditBtn = new System.Windows.Forms.Button();
            this.DestinationAddBtn = new System.Windows.Forms.Button();
            this.TimeRemoveBtn = new System.Windows.Forms.Button();
            this.TimeEditBtn = new System.Windows.Forms.Button();
            this.TimeAddBtn = new System.Windows.Forms.Button();
            this.CallingWindowLV = new System.Windows.Forms.ListView();
            this.StartTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CallingWindowLbl = new System.Windows.Forms.Label();
            this.RepetitionDelayTB = new Gurux.DLMS.UI.GXValueField();
            this.RepetitionDelayLbl = new System.Windows.Forms.Label();
            this.RepetitionsTB = new Gurux.DLMS.UI.GXValueField();
            this.RepetitionsLbl = new System.Windows.Forms.Label();
            this.ModeTB = new Gurux.DLMS.UI.GXValueField();
            this.CommunicationSpeedLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.DestinationMenu.SuspendLayout();
            this.TimeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ConnectBtn);
            this.groupBox1.Controls.Add(this.DestinationLv);
            this.groupBox1.Controls.Add(this.DestinationRemoveBtn);
            this.groupBox1.Controls.Add(this.DestinationEditBtn);
            this.groupBox1.Controls.Add(this.DestinationAddBtn);
            this.groupBox1.Controls.Add(this.TimeRemoveBtn);
            this.groupBox1.Controls.Add(this.TimeEditBtn);
            this.groupBox1.Controls.Add(this.TimeAddBtn);
            this.groupBox1.Controls.Add(this.CallingWindowLV);
            this.groupBox1.Controls.Add(this.CallingWindowLbl);
            this.groupBox1.Controls.Add(this.RepetitionDelayTB);
            this.groupBox1.Controls.Add(this.RepetitionDelayLbl);
            this.groupBox1.Controls.Add(this.RepetitionsTB);
            this.groupBox1.Controls.Add(this.RepetitionsLbl);
            this.groupBox1.Controls.Add(this.ModeTB);
            this.groupBox1.Controls.Add(this.CommunicationSpeedLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 397);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Connect Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Index = 1;
            this.ConnectBtn.Location = new System.Drawing.Point(14, 261);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.ConnectBtn.TabIndex = 24;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            // 
            // DestinationLv
            // 
            this.DestinationLv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DestinationHeader});
            this.DestinationLv.ContextMenuStrip = this.DestinationMenu;
            this.DestinationLv.FullRowSelect = true;
            this.DestinationLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DestinationLv.HideSelection = false;
            this.DestinationLv.Location = new System.Drawing.Point(102, 261);
            this.DestinationLv.Name = "DestinationLv";
            this.DestinationLv.Size = new System.Drawing.Size(352, 92);
            this.DestinationLv.TabIndex = 18;
            this.DestinationLv.UseCompatibleStateImageBehavior = false;
            this.DestinationLv.View = System.Windows.Forms.View.Details;
            this.DestinationLv.DoubleClick += new System.EventHandler(this.DestinationEditBtn_Click);
            // 
            // DestinationHeader
            // 
            this.DestinationHeader.Text = "Destination:";
            this.DestinationHeader.Width = 334;
            // 
            // DestinationMenu
            // 
            this.DestinationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.DestinationMenu.Name = "contextMenuStrip1";
            this.DestinationMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.DestinationAddBtn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Edit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.DestinationEditBtn_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem3.Text = "Remove";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.DestinationRemoveBtn_Click);
            // 
            // DestinationRemoveBtn
            // 
            this.DestinationRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationRemoveBtn.Location = new System.Drawing.Point(379, 368);
            this.DestinationRemoveBtn.Name = "DestinationRemoveBtn";
            this.DestinationRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.DestinationRemoveBtn.TabIndex = 17;
            this.DestinationRemoveBtn.Text = "Remove";
            this.DestinationRemoveBtn.UseVisualStyleBackColor = true;
            this.DestinationRemoveBtn.Click += new System.EventHandler(this.DestinationRemoveBtn_Click);
            // 
            // DestinationEditBtn
            // 
            this.DestinationEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationEditBtn.Location = new System.Drawing.Point(298, 368);
            this.DestinationEditBtn.Name = "DestinationEditBtn";
            this.DestinationEditBtn.Size = new System.Drawing.Size(75, 23);
            this.DestinationEditBtn.TabIndex = 16;
            this.DestinationEditBtn.Text = "Edit...";
            this.DestinationEditBtn.UseVisualStyleBackColor = true;
            this.DestinationEditBtn.Click += new System.EventHandler(this.DestinationEditBtn_Click);
            // 
            // DestinationAddBtn
            // 
            this.DestinationAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationAddBtn.Location = new System.Drawing.Point(217, 368);
            this.DestinationAddBtn.Name = "DestinationAddBtn";
            this.DestinationAddBtn.Size = new System.Drawing.Size(75, 23);
            this.DestinationAddBtn.TabIndex = 15;
            this.DestinationAddBtn.Text = "Add...";
            this.DestinationAddBtn.UseVisualStyleBackColor = true;
            this.DestinationAddBtn.Click += new System.EventHandler(this.DestinationAddBtn_Click);
            // 
            // TimeRemoveBtn
            // 
            this.TimeRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeRemoveBtn.Location = new System.Drawing.Point(379, 223);
            this.TimeRemoveBtn.Name = "TimeRemoveBtn";
            this.TimeRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeRemoveBtn.TabIndex = 14;
            this.TimeRemoveBtn.Text = "Remove";
            this.TimeRemoveBtn.UseVisualStyleBackColor = true;
            this.TimeRemoveBtn.Click += new System.EventHandler(this.TimeRemoveBtn_Click);
            // 
            // TimeEditBtn
            // 
            this.TimeEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeEditBtn.Location = new System.Drawing.Point(298, 223);
            this.TimeEditBtn.Name = "TimeEditBtn";
            this.TimeEditBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeEditBtn.TabIndex = 13;
            this.TimeEditBtn.Text = "Edit...";
            this.TimeEditBtn.UseVisualStyleBackColor = true;
            this.TimeEditBtn.Click += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // TimeAddBtn
            // 
            this.TimeAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeAddBtn.Location = new System.Drawing.Point(217, 223);
            this.TimeAddBtn.Name = "TimeAddBtn";
            this.TimeAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeAddBtn.TabIndex = 12;
            this.TimeAddBtn.Text = "Add...";
            this.TimeAddBtn.UseVisualStyleBackColor = true;
            this.TimeAddBtn.Click += new System.EventHandler(this.TimeAddBtn_Click);
            // 
            // CallingWindowLV
            // 
            this.CallingWindowLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CallingWindowLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StartTimeHeader,
            this.EndTimeHeader});
            this.CallingWindowLV.ContextMenuStrip = this.TimeMenu;
            this.CallingWindowLV.FullRowSelect = true;
            this.CallingWindowLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CallingWindowLV.HideSelection = false;
            this.CallingWindowLV.Location = new System.Drawing.Point(102, 125);
            this.CallingWindowLV.Name = "CallingWindowLV";
            this.CallingWindowLV.Size = new System.Drawing.Size(352, 92);
            this.CallingWindowLV.TabIndex = 8;
            this.CallingWindowLV.UseCompatibleStateImageBehavior = false;
            this.CallingWindowLV.View = System.Windows.Forms.View.Details;
            this.CallingWindowLV.DoubleClick += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // StartTimeHeader
            // 
            this.StartTimeHeader.Text = "Start Time:";
            this.StartTimeHeader.Width = 143;
            // 
            // EndTimeHeader
            // 
            this.EndTimeHeader.Text = "End Time:";
            this.EndTimeHeader.Width = 185;
            // 
            // TimeMenu
            // 
            this.TimeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.TimeMenu.Name = "contextMenuStrip1";
            this.TimeMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.TimeAddBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.TimeRemoveBtn_Click);
            // 
            // CallingWindowLbl
            // 
            this.CallingWindowLbl.AutoSize = true;
            this.CallingWindowLbl.Location = new System.Drawing.Point(6, 138);
            this.CallingWindowLbl.Name = "CallingWindowLbl";
            this.CallingWindowLbl.Size = new System.Drawing.Size(83, 13);
            this.CallingWindowLbl.TabIndex = 7;
            this.CallingWindowLbl.Text = "Calling Window:";
            // 
            // RepetitionDelayTB
            // 
            this.RepetitionDelayTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepetitionDelayTB.Index = 4;
            this.RepetitionDelayTB.Location = new System.Drawing.Point(102, 99);
            this.RepetitionDelayTB.Name = "RepetitionDelayTB";
            this.RepetitionDelayTB.NotifyChanges = false;
            this.RepetitionDelayTB.ReadOnly = true;
            this.RepetitionDelayTB.Size = new System.Drawing.Size(352, 20);
            this.RepetitionDelayTB.TabIndex = 5;
            this.RepetitionDelayTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // RepetitionDelayLbl
            // 
            this.RepetitionDelayLbl.AutoSize = true;
            this.RepetitionDelayLbl.Location = new System.Drawing.Point(6, 102);
            this.RepetitionDelayLbl.Name = "RepetitionDelayLbl";
            this.RepetitionDelayLbl.Size = new System.Drawing.Size(88, 13);
            this.RepetitionDelayLbl.TabIndex = 6;
            this.RepetitionDelayLbl.Text = "Repetition Delay:";
            // 
            // RepetitionsTB
            // 
            this.RepetitionsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepetitionsTB.Index = 3;
            this.RepetitionsTB.Location = new System.Drawing.Point(102, 73);
            this.RepetitionsTB.Name = "RepetitionsTB";
            this.RepetitionsTB.NotifyChanges = false;
            this.RepetitionsTB.ReadOnly = true;
            this.RepetitionsTB.Size = new System.Drawing.Size(352, 20);
            this.RepetitionsTB.TabIndex = 3;
            this.RepetitionsTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // RepetitionsLbl
            // 
            this.RepetitionsLbl.AutoSize = true;
            this.RepetitionsLbl.Location = new System.Drawing.Point(6, 76);
            this.RepetitionsLbl.Name = "RepetitionsLbl";
            this.RepetitionsLbl.Size = new System.Drawing.Size(63, 13);
            this.RepetitionsLbl.TabIndex = 4;
            this.RepetitionsLbl.Text = "Repetitions:";
            // 
            // ModeTB
            // 
            this.ModeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeTB.Index = 2;
            this.ModeTB.Location = new System.Drawing.Point(102, 47);
            this.ModeTB.Name = "ModeTB";
            this.ModeTB.NotifyChanges = false;
            this.ModeTB.ReadOnly = true;
            this.ModeTB.Size = new System.Drawing.Size(352, 72);
            this.ModeTB.TabIndex = 0;
            this.ModeTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // CommunicationSpeedLbl
            // 
            this.CommunicationSpeedLbl.AutoSize = true;
            this.CommunicationSpeedLbl.Location = new System.Drawing.Point(6, 50);
            this.CommunicationSpeedLbl.Name = "CommunicationSpeedLbl";
            this.CommunicationSpeedLbl.Size = new System.Drawing.Size(37, 13);
            this.CommunicationSpeedLbl.TabIndex = 2;
            this.CommunicationSpeedLbl.Text = "Mode:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.ReadOnly = true;
            this.LogicalNameTB.Size = new System.Drawing.Size(352, 20);
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
            // GXDLMSAutoConnectView
            // 
            this.ClientSize = new System.Drawing.Size(506, 421);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSAutoConnectView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DestinationMenu.ResumeLayout(false);
            this.TimeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button DestinationRemoveBtn;
        private Button DestinationEditBtn;
        private Button DestinationAddBtn;
        private Button TimeRemoveBtn;
        private Button TimeEditBtn;
        private Button TimeAddBtn;
        private ListView DestinationLv;
        private ColumnHeader DestinationHeader;
        private ContextMenuStrip TimeMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ContextMenuStrip DestinationMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private GXButton ConnectBtn;
    }
}
