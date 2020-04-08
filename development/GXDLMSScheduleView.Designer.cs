using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSScheduleView
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
        private Label ValueLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSScheduleView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddObjectBtn = new Gurux.DLMS.UI.GXButton();
            this.RemoveObjectBtn = new Gurux.DLMS.UI.GXButton();
            this.EntriesView = new System.Windows.Forms.ListView();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gxButton1 = new Gurux.DLMS.UI.GXButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.EntriesView);
            this.groupBox1.Controls.Add(this.gxButton1);
            this.groupBox1.Controls.Add(this.AddObjectBtn);
            this.groupBox1.Controls.Add(this.RemoveObjectBtn);
            this.groupBox1.Controls.Add(this.ValueLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule Object";
            // 
            // AddObjectBtn
            // 
            this.AddObjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddObjectBtn.Index = 2;
            this.AddObjectBtn.Location = new System.Drawing.Point(609, 232);
            this.AddObjectBtn.Name = "AddObjectBtn";
            this.AddObjectBtn.Size = new System.Drawing.Size(75, 23);
            this.AddObjectBtn.TabIndex = 24;
            this.AddObjectBtn.Text = "Insert";
            this.AddObjectBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveObjectBtn
            // 
            this.RemoveObjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveObjectBtn.Index = 3;
            this.RemoveObjectBtn.Location = new System.Drawing.Point(690, 232);
            this.RemoveObjectBtn.Name = "RemoveObjectBtn";
            this.RemoveObjectBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveObjectBtn.TabIndex = 23;
            this.RemoveObjectBtn.Text = "Remove";
            this.RemoveObjectBtn.UseVisualStyleBackColor = true;
            // 
            // EntriesView
            // 
            this.EntriesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntriesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.EntriesView.FullRowSelect = true;
            this.EntriesView.HideSelection = false;
            this.EntriesView.Location = new System.Drawing.Point(9, 66);
            this.EntriesView.Name = "EntriesView";
            this.EntriesView.Size = new System.Drawing.Size(756, 160);
            this.EntriesView.TabIndex = 4;
            this.EntriesView.UseCompatibleStateImageBehavior = false;
            this.EntriesView.View = System.Windows.Forms.View.Details;
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(6, 50);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(42, 13);
            this.ValueLbl.TabIndex = 2;
            this.ValueLbl.Text = "Entries:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(663, 20);
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index:";
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Enable:";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Logical Name:";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Selector:";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Switch time:";
            this.columnHeader5.Width = 69;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Validity Window:";
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Exec weekdays:";
            this.columnHeader7.Width = 96;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Exec spec days:";
            this.columnHeader8.Width = 98;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Begin:";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "End:";
            this.columnHeader10.Width = 66;
            // 
            // gxButton1
            // 
            this.gxButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gxButton1.Index = 1;
            this.gxButton1.Location = new System.Drawing.Point(486, 232);
            this.gxButton1.Name = "gxButton1";
            this.gxButton1.Size = new System.Drawing.Size(117, 23);
            this.gxButton1.TabIndex = 25;
            this.gxButton1.Text = "Enable/Disable";
            this.gxButton1.UseVisualStyleBackColor = true;
            // 
            // GXDLMSScheduleView
            // 
            this.ClientSize = new System.Drawing.Size(812, 290);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSScheduleView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView EntriesView;
        private GXButton AddObjectBtn;
        private GXButton RemoveObjectBtn;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private GXButton gxButton1;
    }
}
