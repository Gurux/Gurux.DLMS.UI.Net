using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPushSetupView
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
        private ListView CommunicationWindowLV;
        private ColumnHeader StartHeader;
        private GroupBox GXSendDestinationAndMethodGB;
        private Label MessageLbl;
        private Label DestinationLbl;
        private TextBox DestinationTB;
        private Label ServiceLbl;
        private ColumnHeader EndHeader;
        private GXValueField RepetitionDelayTB;
        private Label LblRepetitionDelay;
        private GXValueField NumberOfRetriesTB;
        private Label NumberOfRetriesLbl;
        private GXValueField RandomisationStartIntervalTB;
        private Label RandomisationStartIntervalLbl;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPushSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GXSendDestinationAndMethodGB = new System.Windows.Forms.GroupBox();
            this.MessageCB = new System.Windows.Forms.ComboBox();
            this.ServiceCB = new System.Windows.Forms.ComboBox();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.DestinationTB = new System.Windows.Forms.TextBox();
            this.ServiceLbl = new System.Windows.Forms.Label();
            this.RepetitionDelayTB = new Gurux.DLMS.UI.GXValueField();
            this.RandomisationStartIntervalLbl = new System.Windows.Forms.Label();
            this.LblRepetitionDelay = new System.Windows.Forms.Label();
            this.RandomisationStartIntervalTB = new Gurux.DLMS.UI.GXValueField();
            this.NumberOfRetriesTB = new Gurux.DLMS.UI.GXValueField();
            this.NumberOfRetriesLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ObjectsRemoveBtn = new System.Windows.Forms.Button();
            this.ObjectsEditBtn = new System.Windows.Forms.Button();
            this.ObjectsLV = new System.Windows.Forms.ListView();
            this.TypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeIndexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataIndexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObjectsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ObjectsAddBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CommunicationRemove = new System.Windows.Forms.Button();
            this.CommunicationEdit = new System.Windows.Forms.Button();
            this.CommunicationAdd = new System.Windows.Forms.Button();
            this.CommunicationWindowLV = new System.Windows.Forms.ListView();
            this.StartHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CommunicationWindowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.PushBtn = new Gurux.DLMS.UI.GXButton();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GXSendDestinationAndMethodGB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ObjectsMenu.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.CommunicationWindowMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.PushBtn);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Object";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 350);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GXSendDestinationAndMethodGB);
            this.tabPage1.Controls.Add(this.RepetitionDelayTB);
            this.tabPage1.Controls.Add(this.RandomisationStartIntervalLbl);
            this.tabPage1.Controls.Add(this.LblRepetitionDelay);
            this.tabPage1.Controls.Add(this.RandomisationStartIntervalTB);
            this.tabPage1.Controls.Add(this.NumberOfRetriesTB);
            this.tabPage1.Controls.Add(this.NumberOfRetriesLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GXSendDestinationAndMethodGB
            // 
            this.GXSendDestinationAndMethodGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GXSendDestinationAndMethodGB.Controls.Add(this.MessageCB);
            this.GXSendDestinationAndMethodGB.Controls.Add(this.ServiceCB);
            this.GXSendDestinationAndMethodGB.Controls.Add(this.MessageLbl);
            this.GXSendDestinationAndMethodGB.Controls.Add(this.DestinationLbl);
            this.GXSendDestinationAndMethodGB.Controls.Add(this.DestinationTB);
            this.GXSendDestinationAndMethodGB.Controls.Add(this.ServiceLbl);
            this.GXSendDestinationAndMethodGB.Location = new System.Drawing.Point(6, 6);
            this.GXSendDestinationAndMethodGB.Name = "GXSendDestinationAndMethodGB";
            this.GXSendDestinationAndMethodGB.Size = new System.Drawing.Size(480, 108);
            this.GXSendDestinationAndMethodGB.TabIndex = 16;
            this.GXSendDestinationAndMethodGB.TabStop = false;
            this.GXSendDestinationAndMethodGB.Text = "Send destination and method";
            // 
            // MessageCB
            // 
            this.MessageCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MessageCB.FormattingEnabled = true;
            this.MessageCB.Location = new System.Drawing.Point(97, 74);
            this.MessageCB.Name = "MessageCB";
            this.MessageCB.Size = new System.Drawing.Size(355, 21);
            this.MessageCB.TabIndex = 13;
            this.MessageCB.SelectedIndexChanged += new System.EventHandler(this.MessageCB_SelectedIndexChanged);
            // 
            // ServiceCB
            // 
            this.ServiceCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceCB.FormattingEnabled = true;
            this.ServiceCB.Location = new System.Drawing.Point(97, 18);
            this.ServiceCB.Name = "ServiceCB";
            this.ServiceCB.Size = new System.Drawing.Size(355, 21);
            this.ServiceCB.TabIndex = 12;
            this.ServiceCB.SelectedIndexChanged += new System.EventHandler(this.ServiceCB_SelectedIndexChanged);
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(7, 74);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(53, 13);
            this.MessageLbl.TabIndex = 11;
            this.MessageLbl.Text = "Message:";
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Location = new System.Drawing.Point(7, 48);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(63, 13);
            this.DestinationLbl.TabIndex = 9;
            this.DestinationLbl.Text = "Destination:";
            // 
            // DestinationTB
            // 
            this.DestinationTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationTB.Location = new System.Drawing.Point(97, 45);
            this.DestinationTB.Name = "DestinationTB";
            this.DestinationTB.Size = new System.Drawing.Size(356, 20);
            this.DestinationTB.TabIndex = 8;
            this.DestinationTB.TextChanged += new System.EventHandler(this.DestinationTB_TextChanged);
            // 
            // ServiceLbl
            // 
            this.ServiceLbl.AutoSize = true;
            this.ServiceLbl.Location = new System.Drawing.Point(7, 22);
            this.ServiceLbl.Name = "ServiceLbl";
            this.ServiceLbl.Size = new System.Drawing.Size(46, 13);
            this.ServiceLbl.TabIndex = 7;
            this.ServiceLbl.Text = "Service:";
            // 
            // RepetitionDelayTB
            // 
            this.RepetitionDelayTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepetitionDelayTB.Index = 7;
            this.RepetitionDelayTB.Location = new System.Drawing.Point(103, 166);
            this.RepetitionDelayTB.Name = "RepetitionDelayTB";
            this.RepetitionDelayTB.Size = new System.Drawing.Size(355, 20);
            this.RepetitionDelayTB.TabIndex = 22;
            this.RepetitionDelayTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // RandomisationStartIntervalLbl
            // 
            this.RandomisationStartIntervalLbl.AutoSize = true;
            this.RandomisationStartIntervalLbl.Location = new System.Drawing.Point(12, 118);
            this.RandomisationStartIntervalLbl.Name = "RandomisationStartIntervalLbl";
            this.RandomisationStartIntervalLbl.Size = new System.Drawing.Size(80, 13);
            this.RandomisationStartIntervalLbl.TabIndex = 17;
            this.RandomisationStartIntervalLbl.Text = "Randomisation:";
            // 
            // LblRepetitionDelay
            // 
            this.LblRepetitionDelay.AutoSize = true;
            this.LblRepetitionDelay.Location = new System.Drawing.Point(12, 169);
            this.LblRepetitionDelay.Name = "LblRepetitionDelay";
            this.LblRepetitionDelay.Size = new System.Drawing.Size(86, 13);
            this.LblRepetitionDelay.TabIndex = 21;
            this.LblRepetitionDelay.Text = "Repetition delay:";
            // 
            // RandomisationStartIntervalTB
            // 
            this.RandomisationStartIntervalTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RandomisationStartIntervalTB.Index = 5;
            this.RandomisationStartIntervalTB.Location = new System.Drawing.Point(103, 115);
            this.RandomisationStartIntervalTB.Name = "RandomisationStartIntervalTB";
            this.RandomisationStartIntervalTB.Size = new System.Drawing.Size(355, 20);
            this.RandomisationStartIntervalTB.TabIndex = 18;
            this.RandomisationStartIntervalTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // NumberOfRetriesTB
            // 
            this.NumberOfRetriesTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfRetriesTB.Index = 6;
            this.NumberOfRetriesTB.Location = new System.Drawing.Point(103, 141);
            this.NumberOfRetriesTB.Name = "NumberOfRetriesTB";
            this.NumberOfRetriesTB.Size = new System.Drawing.Size(355, 20);
            this.NumberOfRetriesTB.TabIndex = 20;
            this.NumberOfRetriesTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // NumberOfRetriesLbl
            // 
            this.NumberOfRetriesLbl.AutoSize = true;
            this.NumberOfRetriesLbl.Location = new System.Drawing.Point(12, 144);
            this.NumberOfRetriesLbl.Name = "NumberOfRetriesLbl";
            this.NumberOfRetriesLbl.Size = new System.Drawing.Size(90, 13);
            this.NumberOfRetriesLbl.TabIndex = 19;
            this.NumberOfRetriesLbl.Text = "Number of retries:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ObjectsRemoveBtn);
            this.tabPage2.Controls.Add(this.ObjectsEditBtn);
            this.tabPage2.Controls.Add(this.ObjectsLV);
            this.tabPage2.Controls.Add(this.ObjectsAddBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 324);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Objects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ObjectsRemoveBtn
            // 
            this.ObjectsRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsRemoveBtn.Location = new System.Drawing.Point(405, 285);
            this.ObjectsRemoveBtn.Name = "ObjectsRemoveBtn";
            this.ObjectsRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectsRemoveBtn.TabIndex = 10;
            this.ObjectsRemoveBtn.Text = "Remove...";
            this.ObjectsRemoveBtn.UseVisualStyleBackColor = true;
            this.ObjectsRemoveBtn.Click += new System.EventHandler(this.ObjectsRemoveBtn_Click);
            // 
            // ObjectsEditBtn
            // 
            this.ObjectsEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsEditBtn.Location = new System.Drawing.Point(324, 285);
            this.ObjectsEditBtn.Name = "ObjectsEditBtn";
            this.ObjectsEditBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectsEditBtn.TabIndex = 9;
            this.ObjectsEditBtn.Text = "Edit...";
            this.ObjectsEditBtn.UseVisualStyleBackColor = true;
            this.ObjectsEditBtn.Click += new System.EventHandler(this.ObjectsEditBtn_Click);
            // 
            // ObjectsLV
            // 
            this.ObjectsLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeHeader,
            this.LogicalNameHeader,
            this.AttributeIndexHeader,
            this.DataIndexHeader});
            this.ObjectsLV.ContextMenuStrip = this.ObjectsMenu;
            this.ObjectsLV.FullRowSelect = true;
            this.ObjectsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ObjectsLV.HideSelection = false;
            this.ObjectsLV.Location = new System.Drawing.Point(0, 6);
            this.ObjectsLV.Name = "ObjectsLV";
            this.ObjectsLV.Size = new System.Drawing.Size(479, 264);
            this.ObjectsLV.TabIndex = 14;
            this.ObjectsLV.UseCompatibleStateImageBehavior = false;
            this.ObjectsLV.View = System.Windows.Forms.View.Details;
            this.ObjectsLV.DoubleClick += new System.EventHandler(this.ObjectsEditBtn_Click);
            // 
            // TypeHeader
            // 
            this.TypeHeader.Text = "Type";
            this.TypeHeader.Width = 48;
            // 
            // LogicalNameHeader
            // 
            this.LogicalNameHeader.Text = "LogicalName";
            this.LogicalNameHeader.Width = 76;
            // 
            // AttributeIndexHeader
            // 
            this.AttributeIndexHeader.Text = "Attribute Index";
            this.AttributeIndexHeader.Width = 85;
            // 
            // DataIndexHeader
            // 
            this.DataIndexHeader.Text = "Data Index";
            this.DataIndexHeader.Width = 74;
            // 
            // ObjectsMenu
            // 
            this.ObjectsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.ObjectsMenu.Name = "contextMenuStrip1";
            this.ObjectsMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.ObjectsAddBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.ObjectsEditBtn_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.ObjectsRemoveBtn_Click);
            // 
            // ObjectsAddBtn
            // 
            this.ObjectsAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsAddBtn.Location = new System.Drawing.Point(243, 285);
            this.ObjectsAddBtn.Name = "ObjectsAddBtn";
            this.ObjectsAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectsAddBtn.TabIndex = 8;
            this.ObjectsAddBtn.Text = "Add...";
            this.ObjectsAddBtn.UseVisualStyleBackColor = true;
            this.ObjectsAddBtn.Click += new System.EventHandler(this.ObjectsAddBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CommunicationRemove);
            this.tabPage3.Controls.Add(this.CommunicationEdit);
            this.tabPage3.Controls.Add(this.CommunicationAdd);
            this.tabPage3.Controls.Add(this.CommunicationWindowLV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(497, 324);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Communication Window";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CommunicationRemove
            // 
            this.CommunicationRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommunicationRemove.Location = new System.Drawing.Point(403, 280);
            this.CommunicationRemove.Name = "CommunicationRemove";
            this.CommunicationRemove.Size = new System.Drawing.Size(75, 23);
            this.CommunicationRemove.TabIndex = 18;
            this.CommunicationRemove.Text = "Remove...";
            this.CommunicationRemove.UseVisualStyleBackColor = true;
            this.CommunicationRemove.Click += new System.EventHandler(this.CommunicationRemove_Click);
            // 
            // CommunicationEdit
            // 
            this.CommunicationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommunicationEdit.Location = new System.Drawing.Point(322, 280);
            this.CommunicationEdit.Name = "CommunicationEdit";
            this.CommunicationEdit.Size = new System.Drawing.Size(75, 23);
            this.CommunicationEdit.TabIndex = 17;
            this.CommunicationEdit.Text = "Edit...";
            this.CommunicationEdit.UseVisualStyleBackColor = true;
            this.CommunicationEdit.Click += new System.EventHandler(this.CommunicationEdit_Click);
            // 
            // CommunicationAdd
            // 
            this.CommunicationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CommunicationAdd.Location = new System.Drawing.Point(241, 280);
            this.CommunicationAdd.Name = "CommunicationAdd";
            this.CommunicationAdd.Size = new System.Drawing.Size(75, 23);
            this.CommunicationAdd.TabIndex = 16;
            this.CommunicationAdd.Text = "Add...";
            this.CommunicationAdd.UseVisualStyleBackColor = true;
            this.CommunicationAdd.Click += new System.EventHandler(this.CommunicationAdd_Click);
            // 
            // CommunicationWindowLV
            // 
            this.CommunicationWindowLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommunicationWindowLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StartHeader,
            this.EndHeader});
            this.CommunicationWindowLV.ContextMenuStrip = this.CommunicationWindowMenu;
            this.CommunicationWindowLV.FullRowSelect = true;
            this.CommunicationWindowLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CommunicationWindowLV.HideSelection = false;
            this.CommunicationWindowLV.Location = new System.Drawing.Point(2, 3);
            this.CommunicationWindowLV.Name = "CommunicationWindowLV";
            this.CommunicationWindowLV.Size = new System.Drawing.Size(476, 271);
            this.CommunicationWindowLV.TabIndex = 15;
            this.CommunicationWindowLV.UseCompatibleStateImageBehavior = false;
            this.CommunicationWindowLV.View = System.Windows.Forms.View.Details;
            this.CommunicationWindowLV.DoubleClick += new System.EventHandler(this.CommunicationEdit_Click);
            // 
            // StartHeader
            // 
            this.StartHeader.Text = "Start";
            this.StartHeader.Width = 128;
            // 
            // EndHeader
            // 
            this.EndHeader.Text = "End";
            this.EndHeader.Width = 157;
            // 
            // CommunicationWindowMenu
            // 
            this.CommunicationWindowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.CommunicationWindowMenu.Name = "contextMenuStrip1";
            this.CommunicationWindowMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem1.Text = "Add";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.CommunicationAdd_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem2.Text = "Edit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.CommunicationEdit_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItem3.Text = "Remove";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.CommunicationRemove_Click);
            // 
            // PushBtn
            // 
            this.PushBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PushBtn.Index = 1;
            this.PushBtn.Location = new System.Drawing.Point(407, 427);
            this.PushBtn.Name = "PushBtn";
            this.PushBtn.Size = new System.Drawing.Size(75, 23);
            this.PushBtn.TabIndex = 23;
            this.PushBtn.Text = "Push";
            this.PushBtn.UseVisualStyleBackColor = true;
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
            this.DescriptionTB.Size = new System.Drawing.Size(381, 20);
            this.DescriptionTB.TabIndex = 4;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(380, 20);
            this.LogicalNameTB.TabIndex = 1;
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
            // GXDLMSPushSetupView
            // 
            this.ClientSize = new System.Drawing.Size(529, 487);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPushSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GXSendDestinationAndMethodGB.ResumeLayout(false);
            this.GXSendDestinationAndMethodGB.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ObjectsMenu.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.CommunicationWindowMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXButton PushBtn;
        private ComboBox ServiceCB;
        private ComboBox MessageCB;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView ObjectsLV;
        private ColumnHeader TypeHeader;
        private ColumnHeader LogicalNameHeader;
        private ColumnHeader AttributeIndexHeader;
        private ColumnHeader DataIndexHeader;
        private TabPage tabPage3;
        private Button ObjectsRemoveBtn;
        private Button ObjectsEditBtn;
        private Button ObjectsAddBtn;
        private Button CommunicationRemove;
        private Button CommunicationEdit;
        private Button CommunicationAdd;
        private ContextMenuStrip ObjectsMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ContextMenuStrip CommunicationWindowMenu;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
