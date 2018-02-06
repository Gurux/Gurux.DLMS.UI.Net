using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSActionScheduleView
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
        private GroupBox groupBox2;
        private Label ScriptNameLbl;
        private Label ScriptTypeLbl;
        private Label ScriptSelectorLbl;
        private TextBox ScriptSelectorTB;
        private ListView Time;
        private ColumnHeader TimeHeader;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSActionScheduleView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimeRemoveBtn = new System.Windows.Forms.Button();
            this.TimeEditBtn = new System.Windows.Forms.Button();
            this.TimeAddBtn = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.ListView();
            this.TimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ScriptTypeTb = new Gurux.DLMS.UI.GXValueField();
            this.ScriptTypeLbl = new System.Windows.Forms.Label();
            this.ScriptSelectorLbl = new System.Windows.Forms.Label();
            this.ScriptSelectorTB = new System.Windows.Forms.TextBox();
            this.ScriptNameLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ScriptNameTB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TimeRemoveBtn);
            this.groupBox1.Controls.Add(this.TimeEditBtn);
            this.groupBox1.Controls.Add(this.TimeAddBtn);
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Schedule Object";
            // 
            // TimeRemoveBtn
            // 
            this.TimeRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeRemoveBtn.Location = new System.Drawing.Point(290, 306);
            this.TimeRemoveBtn.Name = "TimeRemoveBtn";
            this.TimeRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeRemoveBtn.TabIndex = 7;
            this.TimeRemoveBtn.Text = "Remove";
            this.TimeRemoveBtn.UseVisualStyleBackColor = true;
            this.TimeRemoveBtn.Click += new System.EventHandler(this.TimeRemoveBtn_Click);
            // 
            // TimeEditBtn
            // 
            this.TimeEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeEditBtn.Location = new System.Drawing.Point(209, 306);
            this.TimeEditBtn.Name = "TimeEditBtn";
            this.TimeEditBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeEditBtn.TabIndex = 6;
            this.TimeEditBtn.Text = "Edit...";
            this.TimeEditBtn.UseVisualStyleBackColor = true;
            this.TimeEditBtn.Click += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // TimeAddBtn
            // 
            this.TimeAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeAddBtn.Location = new System.Drawing.Point(128, 306);
            this.TimeAddBtn.Name = "TimeAddBtn";
            this.TimeAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeAddBtn.TabIndex = 5;
            this.TimeAddBtn.Text = "Add...";
            this.TimeAddBtn.UseVisualStyleBackColor = true;
            this.TimeAddBtn.Click += new System.EventHandler(this.TimeAddBtn_Click);
            // 
            // Time
            // 
            this.Time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Time.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeHeader});
            this.Time.ContextMenuStrip = this.contextMenuStrip1;
            this.Time.FullRowSelect = true;
            this.Time.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Time.HideSelection = false;
            this.Time.Location = new System.Drawing.Point(6, 174);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(359, 126);
            this.Time.TabIndex = 4;
            this.Time.UseCompatibleStateImageBehavior = false;
            this.Time.View = System.Windows.Forms.View.Details;
            this.Time.DoubleClick += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // TimeHeader
            // 
            this.TimeHeader.Text = "Time:";
            this.TimeHeader.Width = 339;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 70);
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ScriptNameTB);
            this.groupBox2.Controls.Add(this.ScriptTypeTb);
            this.groupBox2.Controls.Add(this.ScriptTypeLbl);
            this.groupBox2.Controls.Add(this.ScriptSelectorLbl);
            this.groupBox2.Controls.Add(this.ScriptSelectorTB);
            this.groupBox2.Controls.Add(this.ScriptNameLbl);
            this.groupBox2.Location = new System.Drawing.Point(1, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Executed Script";
            // 
            // ScriptTypeTb
            // 
            this.ScriptTypeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptTypeTb.Index = 3;
            this.ScriptTypeTb.Location = new System.Drawing.Point(101, 80);
            this.ScriptTypeTb.Name = "ScriptTypeTb";
            this.ScriptTypeTb.NotifyChanges = false;
            this.ScriptTypeTb.ReadOnly = true;
            this.ScriptTypeTb.Size = new System.Drawing.Size(263, 99);
            this.ScriptTypeTb.TabIndex = 3;
            this.ScriptTypeTb.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // ScriptTypeLbl
            // 
            this.ScriptTypeLbl.AutoSize = true;
            this.ScriptTypeLbl.Location = new System.Drawing.Point(6, 80);
            this.ScriptTypeLbl.Name = "ScriptTypeLbl";
            this.ScriptTypeLbl.Size = new System.Drawing.Size(64, 13);
            this.ScriptTypeLbl.TabIndex = 5;
            this.ScriptTypeLbl.Text = "Script Type:";
            // 
            // ScriptSelectorLbl
            // 
            this.ScriptSelectorLbl.AutoSize = true;
            this.ScriptSelectorLbl.Location = new System.Drawing.Point(6, 54);
            this.ScriptSelectorLbl.Name = "ScriptSelectorLbl";
            this.ScriptSelectorLbl.Size = new System.Drawing.Size(79, 13);
            this.ScriptSelectorLbl.TabIndex = 3;
            this.ScriptSelectorLbl.Text = "Script Selector:";
            // 
            // ScriptSelectorTB
            // 
            this.ScriptSelectorTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptSelectorTB.Location = new System.Drawing.Point(101, 54);
            this.ScriptSelectorTB.Name = "ScriptSelectorTB";
            this.ScriptSelectorTB.Size = new System.Drawing.Size(261, 20);
            this.ScriptSelectorTB.TabIndex = 2;
            this.ScriptSelectorTB.Leave += new System.EventHandler(this.ScriptSelectorTB_Leave);
            // 
            // ScriptNameLbl
            // 
            this.ScriptNameLbl.AutoSize = true;
            this.ScriptNameLbl.Location = new System.Drawing.Point(6, 28);
            this.ScriptNameLbl.Name = "ScriptNameLbl";
            this.ScriptNameLbl.Size = new System.Drawing.Size(68, 13);
            this.ScriptNameLbl.TabIndex = 1;
            this.ScriptNameLbl.Text = "Script Name:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(263, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
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
            // ScriptNameTB
            // 
            this.ScriptNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptNameTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScriptNameTB.FormattingEnabled = true;
            this.ScriptNameTB.Location = new System.Drawing.Point(101, 25);
            this.ScriptNameTB.Name = "ScriptNameTB";
            this.ScriptNameTB.Size = new System.Drawing.Size(261, 21);
            this.ScriptNameTB.TabIndex = 78;
            this.ScriptNameTB.SelectedIndexChanged += new System.EventHandler(this.ScriptNameTB_SelectedIndexChanged);
            // 
            // GXDLMSActionScheduleView
            // 
            this.ClientSize = new System.Drawing.Size(412, 359);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSActionScheduleView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button TimeRemoveBtn;
        private Button TimeEditBtn;
        private Button TimeAddBtn;
        private GXValueField ScriptTypeTb;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ComboBox ScriptNameTB;
    }
}
