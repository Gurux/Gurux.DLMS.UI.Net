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
            this.DayRemoveBtn = new Gurux.DLMS.UI.GXButton();
            this.DayAddBtn = new Gurux.DLMS.UI.GXButton();
            this.SpecialDay = new System.Windows.Forms.ListView();
            this.IndexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SpecialDayDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DayRemoveBtn);
            this.groupBox1.Controls.Add(this.DayAddBtn);
            this.groupBox1.Controls.Add(this.SpecialDay);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Special Days Table Object";
            // 
            // DayRemoveBtn
            // 
            this.DayRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayRemoveBtn.Index = 2;
            this.DayRemoveBtn.Location = new System.Drawing.Point(235, 225);
            this.DayRemoveBtn.Name = "DayRemoveBtn";
            this.DayRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.DayRemoveBtn.TabIndex = 21;
            this.DayRemoveBtn.Text = "Remove";
            this.DayRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // DayAddBtn
            // 
            this.DayAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DayAddBtn.Index = 1;
            this.DayAddBtn.Location = new System.Drawing.Point(154, 225);
            this.DayAddBtn.Name = "DayAddBtn";
            this.DayAddBtn.Size = new System.Drawing.Size(75, 23);
            this.DayAddBtn.TabIndex = 20;
            this.DayAddBtn.Text = "Add...";
            this.DayAddBtn.UseVisualStyleBackColor = true;
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
            this.SpecialDay.FullRowSelect = true;
            this.SpecialDay.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SpecialDay.HideSelection = false;
            this.SpecialDay.Location = new System.Drawing.Point(6, 57);
            this.SpecialDay.Name = "SpecialDay";
            this.SpecialDay.Size = new System.Drawing.Size(304, 162);
            this.SpecialDay.TabIndex = 9;
            this.SpecialDay.UseCompatibleStateImageBehavior = false;
            this.SpecialDay.View = System.Windows.Forms.View.Details;
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
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
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
            // GXDLMSSpecialDaysTableView
            // 
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSSpecialDaysTableView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GXButton DayRemoveBtn;
        private GXButton DayAddBtn;
    }
}
