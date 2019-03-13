using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSCompactDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSCompactDataView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TemplateDescriptionTb = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProfileGenericView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ColumnRemoveBtn = new System.Windows.Forms.Button();
            this.ColumnEditBtn = new System.Windows.Forms.Button();
            this.ColumnAddBtn = new System.Windows.Forms.Button();
            this.CaptureObjectsLv = new System.Windows.Forms.ListView();
            this.ObjectTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaptureBtn = new Gurux.DLMS.UI.GXButton();
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.CaptureMethodTb = new Gurux.DLMS.UI.GXValueField();
            this.CaptureMethodLbl = new System.Windows.Forms.Label();
            this.TemplateDescriptionLbl = new System.Windows.Forms.Label();
            this.TemplateIdTb = new Gurux.DLMS.UI.GXValueField();
            this.TemplateIdLbl = new System.Windows.Forms.Label();
            this.BufferLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ObjectsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BufferTb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileGenericView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.ObjectsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BufferTb);
            this.groupBox1.Controls.Add(this.TemplateDescriptionTb);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.CaptureBtn);
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.CaptureMethodTb);
            this.groupBox1.Controls.Add(this.CaptureMethodLbl);
            this.groupBox1.Controls.Add(this.TemplateDescriptionLbl);
            this.groupBox1.Controls.Add(this.TemplateIdTb);
            this.groupBox1.Controls.Add(this.TemplateIdLbl);
            this.groupBox1.Controls.Add(this.BufferLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compact Data";
            // 
            // TemplateDescriptionTb
            // 
            this.TemplateDescriptionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateDescriptionTb.Location = new System.Drawing.Point(117, 123);
            this.TemplateDescriptionTb.Name = "TemplateDescriptionTb";
            this.TemplateDescriptionTb.Size = new System.Drawing.Size(324, 20);
            this.TemplateDescriptionTb.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 182);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(525, 271);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProfileGenericView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(517, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProfileGenericView
            // 
            this.ProfileGenericView.AllowUserToAddRows = false;
            this.ProfileGenericView.AllowUserToDeleteRows = false;
            this.ProfileGenericView.AllowUserToOrderColumns = true;
            this.ProfileGenericView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfileGenericView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileGenericView.Location = new System.Drawing.Point(3, 3);
            this.ProfileGenericView.Name = "ProfileGenericView";
            this.ProfileGenericView.ReadOnly = true;
            this.ProfileGenericView.ShowCellErrors = false;
            this.ProfileGenericView.ShowRowErrors = false;
            this.ProfileGenericView.Size = new System.Drawing.Size(511, 239);
            this.ProfileGenericView.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ColumnRemoveBtn);
            this.tabPage2.Controls.Add(this.ColumnEditBtn);
            this.tabPage2.Controls.Add(this.ColumnAddBtn);
            this.tabPage2.Controls.Add(this.CaptureObjectsLv);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(517, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Capture Objects";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ColumnRemoveBtn
            // 
            this.ColumnRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnRemoveBtn.Location = new System.Drawing.Point(418, 205);
            this.ColumnRemoveBtn.Name = "ColumnRemoveBtn";
            this.ColumnRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.ColumnRemoveBtn.TabIndex = 28;
            this.ColumnRemoveBtn.Text = "Remove";
            this.ColumnRemoveBtn.UseVisualStyleBackColor = true;
            this.ColumnRemoveBtn.Click += new System.EventHandler(this.ColumnRemoveBtn_Click);
            // 
            // ColumnEditBtn
            // 
            this.ColumnEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnEditBtn.Location = new System.Drawing.Point(337, 205);
            this.ColumnEditBtn.Name = "ColumnEditBtn";
            this.ColumnEditBtn.Size = new System.Drawing.Size(75, 23);
            this.ColumnEditBtn.TabIndex = 27;
            this.ColumnEditBtn.Text = "Edit...";
            this.ColumnEditBtn.UseVisualStyleBackColor = true;
            this.ColumnEditBtn.Click += new System.EventHandler(this.ColumnEditBtn_Click);
            // 
            // ColumnAddBtn
            // 
            this.ColumnAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnAddBtn.Location = new System.Drawing.Point(256, 205);
            this.ColumnAddBtn.Name = "ColumnAddBtn";
            this.ColumnAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ColumnAddBtn.TabIndex = 26;
            this.ColumnAddBtn.Text = "Add...";
            this.ColumnAddBtn.UseVisualStyleBackColor = true;
            this.ColumnAddBtn.Click += new System.EventHandler(this.ColumnAddBtn_Click);
            // 
            // CaptureObjectsLv
            // 
            this.CaptureObjectsLv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureObjectsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ObjectTypeHeader,
            this.LogicalNameHeader,
            this.AttributeHeader});
            this.CaptureObjectsLv.FullRowSelect = true;
            this.CaptureObjectsLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CaptureObjectsLv.HideSelection = false;
            this.CaptureObjectsLv.Location = new System.Drawing.Point(0, 2);
            this.CaptureObjectsLv.Name = "CaptureObjectsLv";
            this.CaptureObjectsLv.Size = new System.Drawing.Size(493, 197);
            this.CaptureObjectsLv.TabIndex = 25;
            this.CaptureObjectsLv.UseCompatibleStateImageBehavior = false;
            this.CaptureObjectsLv.View = System.Windows.Forms.View.Details;
            // 
            // ObjectTypeHeader
            // 
            this.ObjectTypeHeader.Text = "Object type:";
            this.ObjectTypeHeader.Width = 105;
            // 
            // LogicalNameHeader
            // 
            this.LogicalNameHeader.Text = "Logical Name:";
            this.LogicalNameHeader.Width = 106;
            // 
            // AttributeHeader
            // 
            this.AttributeHeader.Text = "Attribute Index:";
            this.AttributeHeader.Width = 97;
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureBtn.Index = 2;
            this.CaptureBtn.Location = new System.Drawing.Point(460, 48);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(72, 23);
            this.CaptureBtn.TabIndex = 15;
            this.CaptureBtn.Text = "Capture";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 1;
            this.ResetBtn.Location = new System.Drawing.Point(460, 19);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(72, 23);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // CaptureMethodTb
            // 
            this.CaptureMethodTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureMethodTb.Index = 6;
            this.CaptureMethodTb.Location = new System.Drawing.Point(118, 149);
            this.CaptureMethodTb.Name = "CaptureMethodTb";
            this.CaptureMethodTb.NotifyChanges = false;
            this.CaptureMethodTb.Size = new System.Drawing.Size(324, 73);
            this.CaptureMethodTb.TabIndex = 6;
            this.CaptureMethodTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // CaptureMethodLbl
            // 
            this.CaptureMethodLbl.AutoSize = true;
            this.CaptureMethodLbl.Location = new System.Drawing.Point(8, 152);
            this.CaptureMethodLbl.Name = "CaptureMethodLbl";
            this.CaptureMethodLbl.Size = new System.Drawing.Size(86, 13);
            this.CaptureMethodLbl.TabIndex = 12;
            this.CaptureMethodLbl.Text = "Capture Method:";
            // 
            // TemplateDescriptionLbl
            // 
            this.TemplateDescriptionLbl.AutoSize = true;
            this.TemplateDescriptionLbl.Location = new System.Drawing.Point(8, 126);
            this.TemplateDescriptionLbl.Name = "TemplateDescriptionLbl";
            this.TemplateDescriptionLbl.Size = new System.Drawing.Size(110, 13);
            this.TemplateDescriptionLbl.TabIndex = 10;
            this.TemplateDescriptionLbl.Text = "Template Description:";
            // 
            // TemplateIdTb
            // 
            this.TemplateIdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateIdTb.Index = 4;
            this.TemplateIdTb.Location = new System.Drawing.Point(117, 97);
            this.TemplateIdTb.Name = "TemplateIdTb";
            this.TemplateIdTb.NotifyChanges = false;
            this.TemplateIdTb.Size = new System.Drawing.Size(324, 20);
            this.TemplateIdTb.TabIndex = 4;
            this.TemplateIdTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TemplateIdLbl
            // 
            this.TemplateIdLbl.AutoSize = true;
            this.TemplateIdLbl.Location = new System.Drawing.Point(7, 100);
            this.TemplateIdLbl.Name = "TemplateIdLbl";
            this.TemplateIdLbl.Size = new System.Drawing.Size(68, 13);
            this.TemplateIdLbl.TabIndex = 8;
            this.TemplateIdLbl.Text = "Template ID:";
            // 
            // BufferLbl
            // 
            this.BufferLbl.AutoSize = true;
            this.BufferLbl.Location = new System.Drawing.Point(8, 74);
            this.BufferLbl.Name = "BufferLbl";
            this.BufferLbl.Size = new System.Drawing.Size(38, 13);
            this.BufferLbl.TabIndex = 6;
            this.BufferLbl.Text = "Buffer:";
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
            this.DescriptionTB.Location = new System.Drawing.Point(117, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(325, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(117, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(324, 20);
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
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // BufferTb
            // 
            this.BufferTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BufferTb.Location = new System.Drawing.Point(118, 71);
            this.BufferTb.Name = "BufferTb";
            this.BufferTb.Size = new System.Drawing.Size(324, 20);
            this.BufferTb.TabIndex = 3;
            // 
            // GXDLMSCompactDataView
            // 
            this.ClientSize = new System.Drawing.Size(560, 483);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSCompactDataView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileGenericView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ObjectsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField CaptureMethodTb;
        private Label CaptureMethodLbl;
        private Label TemplateDescriptionLbl;
        private GXValueField TemplateIdTb;
        private Label TemplateIdLbl;
        private Label BufferLbl;
        private GXButton CaptureBtn;
        private GXButton ResetBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView ProfileGenericView;
        private TabPage tabPage2;
        private Button ColumnRemoveBtn;
        private Button ColumnEditBtn;
        private Button ColumnAddBtn;
        private ListView CaptureObjectsLv;
        private ColumnHeader ObjectTypeHeader;
        private ColumnHeader LogicalNameHeader;
        private ColumnHeader AttributeHeader;
        private ContextMenuStrip ObjectsMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private TextBox TemplateDescriptionTb;
        private TextBox BufferTb;
    }
}
