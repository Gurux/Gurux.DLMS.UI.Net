using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSRegisterMonitorView
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
        private GroupBox MonitoredValueGB;
        private Label MonitoredLbl;
        private Label AttributeIndexLbl;
        private TextBox AttributeIndexTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSRegisterMonitorView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ActionRemoveBtn = new System.Windows.Forms.Button();
            this.ActionEditBtn = new System.Windows.Forms.Button();
            this.ActionAddBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ThresholdRemoveBtn = new System.Windows.Forms.Button();
            this.ThresholdEditBtn = new System.Windows.Forms.Button();
            this.ThresholdAddBtn = new System.Windows.Forms.Button();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.MonitoredValueGB = new System.Windows.Forms.GroupBox();
            this.ShowAllTargetsCb = new System.Windows.Forms.CheckBox();
            this.MonitoredValueCb = new System.Windows.Forms.ComboBox();
            this.AttributeIndexLbl = new System.Windows.Forms.Label();
            this.AttributeIndexTB = new System.Windows.Forms.TextBox();
            this.MonitoredLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActionsLV = new System.Windows.Forms.ListView();
            this.ActionUpLogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionUpScriptSelectoHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionDownLogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActionDownScriptSelectoHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThresholdsLv = new System.Windows.Forms.ListView();
            this.ThresholdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.MonitoredValueGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.MonitoredValueGB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 391);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Monitor Object";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ActionsLV);
            this.groupBox3.Controls.Add(this.ActionRemoveBtn);
            this.groupBox3.Controls.Add(this.ActionEditBtn);
            this.groupBox3.Controls.Add(this.ActionAddBtn);
            this.groupBox3.Location = new System.Drawing.Point(269, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 234);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // ActionRemoveBtn
            // 
            this.ActionRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionRemoveBtn.Location = new System.Drawing.Point(330, 201);
            this.ActionRemoveBtn.Name = "ActionRemoveBtn";
            this.ActionRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.ActionRemoveBtn.TabIndex = 34;
            this.ActionRemoveBtn.Text = "Remove";
            this.ActionRemoveBtn.UseVisualStyleBackColor = true;
            this.ActionRemoveBtn.Click += new System.EventHandler(this.ActionRemoveBtn_Click);
            // 
            // ActionEditBtn
            // 
            this.ActionEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionEditBtn.Location = new System.Drawing.Point(249, 201);
            this.ActionEditBtn.Name = "ActionEditBtn";
            this.ActionEditBtn.Size = new System.Drawing.Size(75, 23);
            this.ActionEditBtn.TabIndex = 33;
            this.ActionEditBtn.Text = "Edit...";
            this.ActionEditBtn.UseVisualStyleBackColor = true;
            this.ActionEditBtn.Click += new System.EventHandler(this.ActionEditBtn_Click);
            // 
            // ActionAddBtn
            // 
            this.ActionAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionAddBtn.Location = new System.Drawing.Point(168, 201);
            this.ActionAddBtn.Name = "ActionAddBtn";
            this.ActionAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ActionAddBtn.TabIndex = 32;
            this.ActionAddBtn.Text = "Add...";
            this.ActionAddBtn.UseVisualStyleBackColor = true;
            this.ActionAddBtn.Click += new System.EventHandler(this.ActionAddBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.ThresholdsLv);
            this.groupBox2.Controls.Add(this.ThresholdRemoveBtn);
            this.groupBox2.Controls.Add(this.ThresholdEditBtn);
            this.groupBox2.Controls.Add(this.ThresholdAddBtn);
            this.groupBox2.Location = new System.Drawing.Point(8, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 234);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thresholds";
            // 
            // ThresholdRemoveBtn
            // 
            this.ThresholdRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdRemoveBtn.Location = new System.Drawing.Point(173, 205);
            this.ThresholdRemoveBtn.Name = "ThresholdRemoveBtn";
            this.ThresholdRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.ThresholdRemoveBtn.TabIndex = 34;
            this.ThresholdRemoveBtn.Text = "Remove";
            this.ThresholdRemoveBtn.UseVisualStyleBackColor = true;
            this.ThresholdRemoveBtn.Click += new System.EventHandler(this.ThresholdRemoveBtn_Click);
            // 
            // ThresholdEditBtn
            // 
            this.ThresholdEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdEditBtn.Location = new System.Drawing.Point(92, 205);
            this.ThresholdEditBtn.Name = "ThresholdEditBtn";
            this.ThresholdEditBtn.Size = new System.Drawing.Size(75, 23);
            this.ThresholdEditBtn.TabIndex = 33;
            this.ThresholdEditBtn.Text = "Edit...";
            this.ThresholdEditBtn.UseVisualStyleBackColor = true;
            this.ThresholdEditBtn.Click += new System.EventHandler(this.ThresholdEditBtn_Click);
            // 
            // ThresholdAddBtn
            // 
            this.ThresholdAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdAddBtn.Location = new System.Drawing.Point(11, 205);
            this.ThresholdAddBtn.Name = "ThresholdAddBtn";
            this.ThresholdAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ThresholdAddBtn.TabIndex = 32;
            this.ThresholdAddBtn.Text = "Add...";
            this.ThresholdAddBtn.UseVisualStyleBackColor = true;
            this.ThresholdAddBtn.Click += new System.EventHandler(this.ThresholdAddBtn_Click);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(8, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 11;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(102, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(578, 20);
            this.DescriptionTB.TabIndex = 10;
            // 
            // MonitoredValueGB
            // 
            this.MonitoredValueGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoredValueGB.Controls.Add(this.ShowAllTargetsCb);
            this.MonitoredValueGB.Controls.Add(this.MonitoredValueCb);
            this.MonitoredValueGB.Controls.Add(this.AttributeIndexLbl);
            this.MonitoredValueGB.Controls.Add(this.AttributeIndexTB);
            this.MonitoredValueGB.Controls.Add(this.MonitoredLbl);
            this.MonitoredValueGB.Location = new System.Drawing.Point(0, 72);
            this.MonitoredValueGB.Name = "MonitoredValueGB";
            this.MonitoredValueGB.Size = new System.Drawing.Size(682, 73);
            this.MonitoredValueGB.TabIndex = 7;
            this.MonitoredValueGB.TabStop = false;
            this.MonitoredValueGB.Text = "Monitored Value";
            // 
            // ShowAllTargetsCb
            // 
            this.ShowAllTargetsCb.AutoSize = true;
            this.ShowAllTargetsCb.Location = new System.Drawing.Point(102, 46);
            this.ShowAllTargetsCb.Name = "ShowAllTargetsCb";
            this.ShowAllTargetsCb.Size = new System.Drawing.Size(105, 17);
            this.ShowAllTargetsCb.TabIndex = 14;
            this.ShowAllTargetsCb.Text = "Show all Targets";
            this.ShowAllTargetsCb.UseVisualStyleBackColor = true;
            this.ShowAllTargetsCb.CheckedChanged += new System.EventHandler(this.ShowAllTargetsCb_CheckedChanged);
            // 
            // MonitoredValueCb
            // 
            this.MonitoredValueCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoredValueCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonitoredValueCb.FormattingEnabled = true;
            this.MonitoredValueCb.Location = new System.Drawing.Point(102, 19);
            this.MonitoredValueCb.Name = "MonitoredValueCb";
            this.MonitoredValueCb.Size = new System.Drawing.Size(447, 21);
            this.MonitoredValueCb.TabIndex = 13;
            this.MonitoredValueCb.SelectedIndexChanged += new System.EventHandler(this.MonitoredValueCb_SelectedIndexChanged);
            // 
            // AttributeIndexLbl
            // 
            this.AttributeIndexLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributeIndexLbl.AutoSize = true;
            this.AttributeIndexLbl.Location = new System.Drawing.Point(555, 22);
            this.AttributeIndexLbl.Name = "AttributeIndexLbl";
            this.AttributeIndexLbl.Size = new System.Drawing.Size(36, 13);
            this.AttributeIndexLbl.TabIndex = 12;
            this.AttributeIndexLbl.Text = "Index:";
            // 
            // AttributeIndexTB
            // 
            this.AttributeIndexTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributeIndexTB.Location = new System.Drawing.Point(598, 22);
            this.AttributeIndexTB.Name = "AttributeIndexTB";
            this.AttributeIndexTB.Size = new System.Drawing.Size(61, 20);
            this.AttributeIndexTB.TabIndex = 5;
            this.AttributeIndexTB.Leave += new System.EventHandler(this.AttributeIndexTB_Leave);
            // 
            // MonitoredLbl
            // 
            this.MonitoredLbl.AutoSize = true;
            this.MonitoredLbl.Location = new System.Drawing.Point(6, 22);
            this.MonitoredLbl.Name = "MonitoredLbl";
            this.MonitoredLbl.Size = new System.Drawing.Size(41, 13);
            this.MonitoredLbl.TabIndex = 8;
            this.MonitoredLbl.Text = "Target:";
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(6, 48);
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
            // ActionsLV
            // 
            this.ActionsLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionUpLogicalNameHeader,
            this.ActionUpScriptSelectoHeader,
            this.ActionDownLogicalNameHeader,
            this.ActionDownScriptSelectoHeader});
            this.ActionsLV.FullRowSelect = true;
            this.ActionsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActionsLV.HideSelection = false;
            this.ActionsLV.Location = new System.Drawing.Point(7, 19);
            this.ActionsLV.Name = "ActionsLV";
            this.ActionsLV.Size = new System.Drawing.Size(398, 176);
            this.ActionsLV.TabIndex = 35;
            this.ActionsLV.UseCompatibleStateImageBehavior = false;
            this.ActionsLV.View = System.Windows.Forms.View.Details;
            this.ActionsLV.DoubleClick += new System.EventHandler(this.ActionEditBtn_Click);
            // 
            // ActionUpLogicalNameHeader
            // 
            this.ActionUpLogicalNameHeader.Text = "Up LogicalName:";
            this.ActionUpLogicalNameHeader.Width = 96;
            // 
            // ActionUpScriptSelectoHeader
            // 
            this.ActionUpScriptSelectoHeader.Text = "Up Script Selector:";
            this.ActionUpScriptSelectoHeader.Width = 104;
            // 
            // ActionDownLogicalNameHeader
            // 
            this.ActionDownLogicalNameHeader.Text = "Down LogicalName:";
            this.ActionDownLogicalNameHeader.Width = 106;
            // 
            // ActionDownScriptSelectoHeader
            // 
            this.ActionDownScriptSelectoHeader.Text = "Down Script Selector:";
            this.ActionDownScriptSelectoHeader.Width = 106;
            // 
            // ThresholdsLv
            // 
            this.ThresholdsLv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ThresholdsLv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ThresholdHeader});
            this.ThresholdsLv.FullRowSelect = true;
            this.ThresholdsLv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ThresholdsLv.HideSelection = false;
            this.ThresholdsLv.Location = new System.Drawing.Point(0, 19);
            this.ThresholdsLv.Name = "ThresholdsLv";
            this.ThresholdsLv.Size = new System.Drawing.Size(248, 175);
            this.ThresholdsLv.TabIndex = 35;
            this.ThresholdsLv.UseCompatibleStateImageBehavior = false;
            this.ThresholdsLv.View = System.Windows.Forms.View.Details;
            this.ThresholdsLv.DoubleClick += new System.EventHandler(this.ThresholdEditBtn_Click);
            // 
            // ThresholdHeader
            // 
            this.ThresholdHeader.Text = "Threshold";
            this.ThresholdHeader.Width = 236;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(580, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSRegisterMonitorView
            // 
            this.ClientSize = new System.Drawing.Size(712, 415);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSRegisterMonitorView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.MonitoredValueGB.ResumeLayout(false);
            this.MonitoredValueGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComboBox MonitoredValueCb;
        private CheckBox ShowAllTargetsCb;
        private GroupBox groupBox3;
        private Button ActionRemoveBtn;
        private Button ActionEditBtn;
        private Button ActionAddBtn;
        private GroupBox groupBox2;
        private Button ThresholdRemoveBtn;
        private Button ThresholdEditBtn;
        private Button ThresholdAddBtn;
        private ListView ActionsLV;
        private ColumnHeader ActionUpLogicalNameHeader;
        private ColumnHeader ActionUpScriptSelectoHeader;
        private ColumnHeader ActionDownLogicalNameHeader;
        private ColumnHeader ActionDownScriptSelectoHeader;
        private ListView ThresholdsLv;
        private ColumnHeader ThresholdHeader;
    }
}
