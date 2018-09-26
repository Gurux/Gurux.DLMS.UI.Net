using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSSapAssignmentView
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
        private ListView SapAssignmentView;
        private ColumnHeader SapAddressHeader;
        private ColumnHeader LogicalDeviceNameHeader;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSapAssignmentView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SapAssignmentView = new System.Windows.Forms.ListView();
            this.SapAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalDeviceNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddObjectBtn = new Gurux.DLMS.UI.GXButton();
            this.RemoveObjectBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AddObjectBtn);
            this.groupBox1.Controls.Add(this.RemoveObjectBtn);
            this.groupBox1.Controls.Add(this.SapAssignmentView);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAP Assignment Object";
            // 
            // SapAssignmentView
            // 
            this.SapAssignmentView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SapAssignmentView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SapAddressHeader,
            this.LogicalDeviceNameHeader});
            this.SapAssignmentView.FullRowSelect = true;
            this.SapAssignmentView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SapAssignmentView.HideSelection = false;
            this.SapAssignmentView.Location = new System.Drawing.Point(9, 47);
            this.SapAssignmentView.Name = "SapAssignmentView";
            this.SapAssignmentView.Size = new System.Drawing.Size(264, 141);
            this.SapAssignmentView.TabIndex = 9;
            this.SapAssignmentView.UseCompatibleStateImageBehavior = false;
            this.SapAssignmentView.View = System.Windows.Forms.View.Details;
            // 
            // SapAddressHeader
            // 
            this.SapAddressHeader.Text = "SAP address:";
            this.SapAddressHeader.Width = 81;
            // 
            // LogicalDeviceNameHeader
            // 
            this.LogicalDeviceNameHeader.Text = "Logical Device Name:";
            this.LogicalDeviceNameHeader.Width = 175;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(171, 20);
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
            // AddObjectBtn
            // 
            this.AddObjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddObjectBtn.Index = 3;
            this.AddObjectBtn.Location = new System.Drawing.Point(117, 194);
            this.AddObjectBtn.Name = "AddObjectBtn";
            this.AddObjectBtn.Size = new System.Drawing.Size(75, 23);
            this.AddObjectBtn.TabIndex = 24;
            this.AddObjectBtn.Text = "Add";
            this.AddObjectBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveObjectBtn
            // 
            this.RemoveObjectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveObjectBtn.Index = 4;
            this.RemoveObjectBtn.Location = new System.Drawing.Point(198, 194);
            this.RemoveObjectBtn.Name = "RemoveObjectBtn";
            this.RemoveObjectBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveObjectBtn.TabIndex = 23;
            this.RemoveObjectBtn.Text = "Remove";
            this.RemoveObjectBtn.UseVisualStyleBackColor = true;
            // 
            // GXDLMSSapAssignmentView
            // 
            this.ClientSize = new System.Drawing.Size(320, 259);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSSapAssignmentView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXButton AddObjectBtn;
        private GXButton RemoveObjectBtn;
    }
}
