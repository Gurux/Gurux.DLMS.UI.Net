using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSSpecialDaysTableView
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
        private ListView SpecialDay;
        private ColumnHeader IndexHeader;
        private ColumnHeader SpecialDayDateHeader;
        private ColumnHeader DayIdHeader;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSpecialDaysTableView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpecialDay = new System.Windows.Forms.ListView();
            this.IndexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpecialDayDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DayRemoveBtn = new System.Windows.Forms.Button();
            this.DayEditBtn = new System.Windows.Forms.Button();
            this.DayAddBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SpecialDay);
            this.groupBox1.Controls.Add(this.DayRemoveBtn);
            this.groupBox1.Controls.Add(this.DayEditBtn);
            this.groupBox1.Controls.Add(this.DayAddBtn);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Days Table Object";
            // 
            // SpecialDay
            // 
            this.SpecialDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpecialDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IndexHeader,
            this.SpecialDayDateHeader,
            this.DayIdHeader});
            this.SpecialDay.ContextMenuStrip = this.contextMenuStrip1;
            this.SpecialDay.FullRowSelect = true;
            this.SpecialDay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SpecialDay.HideSelection = false;
            this.SpecialDay.Location = new System.Drawing.Point(6, 57);
            this.SpecialDay.Name = "SpecialDay";
            this.SpecialDay.Size = new System.Drawing.Size(304, 162);
            this.SpecialDay.TabIndex = 9;
            this.SpecialDay.UseCompatibleStateImageBehavior = false;
            this.SpecialDay.View = System.Windows.Forms.View.Details;
            this.SpecialDay.DoubleClick += new System.EventHandler(this.DayEditBtn_Click);
            // 
            // IndexHeader
            // 
            this.IndexHeader.Text = "Index:";
            this.IndexHeader.Width = 77;
            // 
            // SpecialDayDateHeader
            // 
            this.SpecialDayDateHeader.Text = "Special Day Date:";
            this.SpecialDayDateHeader.Width = 115;
            // 
            // DayIdHeader
            // 
            this.DayIdHeader.Text = "Day ID:";
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
            // DayRemoveBtn
            // 
            this.DayRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayRemoveBtn.Location = new System.Drawing.Point(235, 225);
            this.DayRemoveBtn.Name = "DayRemoveBtn";
            this.DayRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.DayRemoveBtn.TabIndex = 19;
            this.DayRemoveBtn.Text = "Remove";
            this.DayRemoveBtn.UseVisualStyleBackColor = true;
            this.DayRemoveBtn.Click += new System.EventHandler(this.DayRemoveBtn_Click);
            // 
            // DayEditBtn
            // 
            this.DayEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayEditBtn.Location = new System.Drawing.Point(154, 225);
            this.DayEditBtn.Name = "DayEditBtn";
            this.DayEditBtn.Size = new System.Drawing.Size(75, 23);
            this.DayEditBtn.TabIndex = 18;
            this.DayEditBtn.Text = "Edit...";
            this.DayEditBtn.UseVisualStyleBackColor = true;
            this.DayEditBtn.Click += new System.EventHandler(this.DayEditBtn_Click);
            // 
            // DayAddBtn
            // 
            this.DayAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayAddBtn.Location = new System.Drawing.Point(73, 225);
            this.DayAddBtn.Name = "DayAddBtn";
            this.DayAddBtn.Size = new System.Drawing.Size(75, 23);
            this.DayAddBtn.TabIndex = 17;
            this.DayAddBtn.Text = "Add...";
            this.DayAddBtn.UseVisualStyleBackColor = true;
            this.DayAddBtn.Click += new System.EventHandler(this.DayAddBtn_Click);
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
            this.addToolStripMenuItem.Click += new System.EventHandler(this.DayAddBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.DayEditBtn_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.DayRemoveBtn_Click);
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // GXDLMSSpecialDaysTableView
            // 
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSSpecialDaysTableView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button DayRemoveBtn;
        private Button DayEditBtn;
        private Button DayAddBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}
