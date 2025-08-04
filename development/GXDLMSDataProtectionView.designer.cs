using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSDataProtectionView
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
        private GXValueField ProtectionBufferTb;
        private Label ProtectionBufferLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSDataProtectionView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ObjectsTab = new System.Windows.Forms.TabPage();
            this.ObjectsLv = new System.Windows.Forms.ListView();
            this.ObjectTypeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GetParametersTab = new System.Windows.Forms.TabPage();
            this.GetLv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SetParametersTab = new System.Windows.Forms.TabPage();
            this.SetLv = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequiredProtectionLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ProtectionBufferLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RequiredProtectionLblTb = new Gurux.DLMS.UI.GXValueField();
            this.ProtectionBufferTb = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ObjectsTab.SuspendLayout();
            this.GetParametersTab.SuspendLayout();
            this.SetParametersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.RequiredProtectionLblTb);
            this.groupBox1.Controls.Add(this.RequiredProtectionLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.ProtectionBufferTb);
            this.groupBox1.Controls.Add(this.ProtectionBufferLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Protection Object";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(9, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 236);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Protection:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ObjectsTab);
            this.tabControl1.Controls.Add(this.GetParametersTab);
            this.tabControl1.Controls.Add(this.SetParametersTab);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 211);
            this.tabControl1.TabIndex = 9;
            // 
            // ObjectsTab
            // 
            this.ObjectsTab.Controls.Add(this.ObjectsLv);
            this.ObjectsTab.Location = new System.Drawing.Point(4, 22);
            this.ObjectsTab.Name = "ObjectsTab";
            this.ObjectsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ObjectsTab.Size = new System.Drawing.Size(615, 185);
            this.ObjectsTab.TabIndex = 0;
            this.ObjectsTab.Text = "Objects";
            this.ObjectsTab.UseVisualStyleBackColor = true;
            // 
            // ObjectsLv
            // 
            this.ObjectsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ObjectTypeHeader,
            this.LogicalNameHeader,
            this.AttributeHeader,
            this.dataHeader});
            this.ObjectsLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectsLv.FullRowSelect = true;
            this.ObjectsLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ObjectsLv.HideSelection = false;
            this.ObjectsLv.Location = new System.Drawing.Point(3, 3);
            this.ObjectsLv.Name = "ObjectsLv";
            this.ObjectsLv.Size = new System.Drawing.Size(609, 179);
            this.ObjectsLv.TabIndex = 26;
            this.ObjectsLv.UseCompatibleStateImageBehavior = false;
            this.ObjectsLv.View = System.Windows.Forms.View.Details;
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
            // dataHeader
            // 
            this.dataHeader.Text = "Data index:";
            this.dataHeader.Width = 75;
            // 
            // GetParametersTab
            // 
            this.GetParametersTab.Controls.Add(this.GetLv);
            this.GetParametersTab.Location = new System.Drawing.Point(4, 22);
            this.GetParametersTab.Name = "GetParametersTab";
            this.GetParametersTab.Padding = new System.Windows.Forms.Padding(3);
            this.GetParametersTab.Size = new System.Drawing.Size(615, 191);
            this.GetParametersTab.TabIndex = 1;
            this.GetParametersTab.Text = "Get Parameters";
            this.GetParametersTab.UseVisualStyleBackColor = true;
            // 
            // GetLv
            // 
            this.GetLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.GetLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GetLv.FullRowSelect = true;
            this.GetLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.GetLv.HideSelection = false;
            this.GetLv.Location = new System.Drawing.Point(3, 3);
            this.GetLv.Name = "GetLv";
            this.GetLv.Size = new System.Drawing.Size(609, 185);
            this.GetLv.TabIndex = 27;
            this.GetLv.UseCompatibleStateImageBehavior = false;
            this.GetLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Protection Type";
            this.columnHeader1.Width = 93;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Transaction ID";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Originator System Title";
            this.columnHeader3.Width = 121;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Recipient System Title";
            this.columnHeader4.Width = 123;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Other Information";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Key Info";
            this.columnHeader6.Width = 70;
            // 
            // SetParametersTab
            // 
            this.SetParametersTab.Controls.Add(this.SetLv);
            this.SetParametersTab.Location = new System.Drawing.Point(4, 22);
            this.SetParametersTab.Name = "SetParametersTab";
            this.SetParametersTab.Padding = new System.Windows.Forms.Padding(3);
            this.SetParametersTab.Size = new System.Drawing.Size(615, 191);
            this.SetParametersTab.TabIndex = 2;
            this.SetParametersTab.Text = "Set Parameters";
            this.SetParametersTab.UseVisualStyleBackColor = true;
            // 
            // SetLv
            // 
            this.SetLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.SetLv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetLv.FullRowSelect = true;
            this.SetLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SetLv.HideSelection = false;
            this.SetLv.Location = new System.Drawing.Point(3, 3);
            this.SetLv.Name = "SetLv";
            this.SetLv.Size = new System.Drawing.Size(609, 185);
            this.SetLv.TabIndex = 28;
            this.SetLv.UseCompatibleStateImageBehavior = false;
            this.SetLv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Protection Type";
            this.columnHeader7.Width = 93;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Transaction ID";
            this.columnHeader8.Width = 87;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Originator System Title";
            this.columnHeader9.Width = 121;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Recipient System Title";
            this.columnHeader10.Width = 123;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Other Information";
            this.columnHeader11.Width = 101;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Key Info";
            this.columnHeader12.Width = 70;
            // 
            // RequiredProtectionLbl
            // 
            this.RequiredProtectionLbl.AutoSize = true;
            this.RequiredProtectionLbl.Location = new System.Drawing.Point(3, 122);
            this.RequiredProtectionLbl.Name = "RequiredProtectionLbl";
            this.RequiredProtectionLbl.Size = new System.Drawing.Size(104, 13);
            this.RequiredProtectionLbl.TabIndex = 7;
            this.RequiredProtectionLbl.Text = "Required Protection:";
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
            this.DescriptionTB.Location = new System.Drawing.Point(112, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(521, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // ProtectionBufferLbl
            // 
            this.ProtectionBufferLbl.AutoSize = true;
            this.ProtectionBufferLbl.Location = new System.Drawing.Point(7, 74);
            this.ProtectionBufferLbl.Name = "ProtectionBufferLbl";
            this.ProtectionBufferLbl.Size = new System.Drawing.Size(89, 13);
            this.ProtectionBufferLbl.TabIndex = 2;
            this.ProtectionBufferLbl.Text = "Protection Buffer:";
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
            // RequiredProtectionLblTb
            // 
            this.RequiredProtectionLblTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RequiredProtectionLblTb.Index = 6;
            this.RequiredProtectionLblTb.Location = new System.Drawing.Point(112, 99);
            this.RequiredProtectionLblTb.Name = "RequiredProtectionLblTb";
            this.RequiredProtectionLblTb.NotifyChanges = false;
            this.RequiredProtectionLblTb.Size = new System.Drawing.Size(520, 113);
            this.RequiredProtectionLblTb.TabIndex = 6;
            this.RequiredProtectionLblTb.Type = Gurux.DLMS.Enums.ValueFieldType.CheckedListBox;
            // 
            // ProtectionBufferTb
            // 
            this.ProtectionBufferTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProtectionBufferTb.Index = 2;
            this.ProtectionBufferTb.Location = new System.Drawing.Point(113, 71);
            this.ProtectionBufferTb.Name = "ProtectionBufferTb";
            this.ProtectionBufferTb.NotifyChanges = false;
            this.ProtectionBufferTb.Size = new System.Drawing.Size(520, 68);
            this.ProtectionBufferTb.TabIndex = 0;
            this.ProtectionBufferTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.ProtectionBufferTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ProtectionBufferTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(112, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(520, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSDataProtectionView
            // 
            this.ClientSize = new System.Drawing.Size(669, 467);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSDataProtectionView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ObjectsTab.ResumeLayout(false);
            this.GetParametersTab.ResumeLayout(false);
            this.SetParametersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField RequiredProtectionLblTb;
        private Label RequiredProtectionLbl;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage ObjectsTab;
        private TabPage GetParametersTab;
        private TabPage SetParametersTab;
        private ListView ObjectsLv;
        private ColumnHeader ObjectTypeHeader;
        private ColumnHeader LogicalNameHeader;
        private ColumnHeader AttributeHeader;
        private ColumnHeader dataHeader;
        private ListView GetLv;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView SetLv;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}
