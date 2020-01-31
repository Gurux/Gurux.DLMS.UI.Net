using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSRegisterActivationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSRegisterActivationView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Assigments = new System.Windows.Forms.ListView();
            this.ClassIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ActiveMasksCb = new System.Windows.Forms.ComboBox();
            this.ActiveLbl = new System.Windows.Forms.Label();
            this.Masks = new System.Windows.Forms.ListView();
            this.MaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaskIndexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AssigmentAddBtn = new Gurux.DLMS.UI.GXButton();
            this.MaskRemoveBtn = new Gurux.DLMS.UI.GXButton();
            this.MaskAddBtn = new Gurux.DLMS.UI.GXButton();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Activation Object";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 270);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AssigmentAddBtn);
            this.tabPage1.Controls.Add(this.Assigments);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(313, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assignments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Assigments
            // 
            this.Assigments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Assigments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassIDHeader,
            this.LogicalNameHeader});
            this.Assigments.FullRowSelect = true;
            this.Assigments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Assigments.HideSelection = false;
            this.Assigments.Location = new System.Drawing.Point(3, 0);
            this.Assigments.Name = "Assigments";
            this.Assigments.Size = new System.Drawing.Size(310, 209);
            this.Assigments.TabIndex = 9;
            this.Assigments.UseCompatibleStateImageBehavior = false;
            this.Assigments.View = System.Windows.Forms.View.Details;
            // 
            // ClassIDHeader
            // 
            this.ClassIDHeader.Text = "Object Type";
            this.ClassIDHeader.Width = 78;
            // 
            // LogicalNameHeader
            // 
            this.LogicalNameHeader.Text = "Logical Name";
            this.LogicalNameHeader.Width = 186;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ActiveMasksCb);
            this.tabPage2.Controls.Add(this.ActiveLbl);
            this.tabPage2.Controls.Add(this.MaskRemoveBtn);
            this.tabPage2.Controls.Add(this.MaskAddBtn);
            this.tabPage2.Controls.Add(this.Masks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(313, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Masks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ActiveMasksCb
            // 
            this.ActiveMasksCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveMasksCb.FormattingEnabled = true;
            this.ActiveMasksCb.Location = new System.Drawing.Point(75, 5);
            this.ActiveMasksCb.Name = "ActiveMasksCb";
            this.ActiveMasksCb.Size = new System.Drawing.Size(230, 21);
            this.ActiveMasksCb.TabIndex = 24;
            this.ActiveMasksCb.SelectedIndexChanged += new System.EventHandler(this.ActiveMasksCb_SelectedIndexChanged);
            // 
            // ActiveLbl
            // 
            this.ActiveLbl.AutoSize = true;
            this.ActiveLbl.Location = new System.Drawing.Point(1, 9);
            this.ActiveLbl.Name = "ActiveLbl";
            this.ActiveLbl.Size = new System.Drawing.Size(68, 13);
            this.ActiveLbl.TabIndex = 18;
            this.ActiveLbl.Text = "Active mask:";
            // 
            // Masks
            // 
            this.Masks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Masks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaskName,
            this.MaskIndexHeader});
            this.Masks.FullRowSelect = true;
            this.Masks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Masks.HideSelection = false;
            this.Masks.Location = new System.Drawing.Point(1, 32);
            this.Masks.Name = "Masks";
            this.Masks.Size = new System.Drawing.Size(310, 180);
            this.Masks.TabIndex = 13;
            this.Masks.UseCompatibleStateImageBehavior = false;
            this.Masks.View = System.Windows.Forms.View.Details;
            // 
            // MaskName
            // 
            this.MaskName.Text = "Name";
            this.MaskName.Width = 78;
            // 
            // MaskIndexHeader
            // 
            this.MaskIndexHeader.Text = "Indexes";
            this.MaskIndexHeader.Width = 186;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(11, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 13;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(107, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(208, 20);
            this.DescriptionTB.TabIndex = 12;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(11, 48);
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
            // AssigmentAddBtn
            // 
            this.AssigmentAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AssigmentAddBtn.Index = 1;
            this.AssigmentAddBtn.Location = new System.Drawing.Point(235, 215);
            this.AssigmentAddBtn.Name = "AssigmentAddBtn";
            this.AssigmentAddBtn.Size = new System.Drawing.Size(75, 23);
            this.AssigmentAddBtn.TabIndex = 23;
            this.AssigmentAddBtn.Text = "Add...";
            this.AssigmentAddBtn.UseVisualStyleBackColor = true;
            // 
            // MaskRemoveBtn
            // 
            this.MaskRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskRemoveBtn.Index = 3;
            this.MaskRemoveBtn.Location = new System.Drawing.Point(230, 218);
            this.MaskRemoveBtn.Name = "MaskRemoveBtn";
            this.MaskRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.MaskRemoveBtn.TabIndex = 23;
            this.MaskRemoveBtn.Text = "Remove";
            this.MaskRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // MaskAddBtn
            // 
            this.MaskAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaskAddBtn.Index = 2;
            this.MaskAddBtn.Location = new System.Drawing.Point(149, 218);
            this.MaskAddBtn.Name = "MaskAddBtn";
            this.MaskAddBtn.Size = new System.Drawing.Size(75, 23);
            this.MaskAddBtn.TabIndex = 22;
            this.MaskAddBtn.Text = "Add...";
            this.MaskAddBtn.UseVisualStyleBackColor = true;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(107, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSRegisterActivationView
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(357, 371);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSRegisterActivationView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView Assigments;
        private ColumnHeader ClassIDHeader;
        private ColumnHeader LogicalNameHeader;
        private ListView Masks;
        private ColumnHeader MaskName;
        private ColumnHeader MaskIndexHeader;
        private Label ActiveLbl;
        private GXButton MaskRemoveBtn;
        private GXButton MaskAddBtn;
        private ComboBox ActiveMasksCb;
        private GXButton AssigmentAddBtn;
    }
}
