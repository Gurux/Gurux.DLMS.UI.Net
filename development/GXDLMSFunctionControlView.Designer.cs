using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSFunctionControlView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSFunctionControlView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FunctionListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivationStatusView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gxButton1 = new Gurux.DLMS.UI.GXButton();
            this.AddFunctionBtn = new Gurux.DLMS.UI.GXButton();
            this.SetStatusBtn = new Gurux.DLMS.UI.GXButton();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.FunctionListView);
            this.groupBox1.Controls.Add(this.gxButton1);
            this.groupBox1.Controls.Add(this.AddFunctionBtn);
            this.groupBox1.Controls.Add(this.SetStatusBtn);
            this.groupBox1.Controls.Add(this.ActivationStatusView);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function control Object";
            // 
            // FunctionListView
            // 
            this.FunctionListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.FunctionListView.FullRowSelect = true;
            this.FunctionListView.HideSelection = false;
            this.FunctionListView.Location = new System.Drawing.Point(200, 71);
            this.FunctionListView.Name = "FunctionListView";
            this.FunctionListView.Size = new System.Drawing.Size(278, 261);
            this.FunctionListView.TabIndex = 30;
            this.FunctionListView.UseCompatibleStateImageBehavior = false;
            this.FunctionListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Object Type:";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Logical Name:";
            this.columnHeader4.Width = 78;
            // 
            // ActivationStatusView
            // 
            this.ActivationStatusView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ActivationStatusView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ActivationStatusView.FullRowSelect = true;
            this.ActivationStatusView.HideSelection = false;
            this.ActivationStatusView.Location = new System.Drawing.Point(11, 71);
            this.ActivationStatusView.Name = "ActivationStatusView";
            this.ActivationStatusView.Size = new System.Drawing.Size(183, 261);
            this.ActivationStatusView.TabIndex = 25;
            this.ActivationStatusView.UseCompatibleStateImageBehavior = false;
            this.ActivationStatusView.View = System.Windows.Forms.View.Details;
            this.ActivationStatusView.SelectedIndexChanged += new System.EventHandler(this.ActivationStatusView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Function Name:";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status:";
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
            this.DescriptionTB.Size = new System.Drawing.Size(375, 20);
            this.DescriptionTB.TabIndex = 1;
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
            // gxButton1
            // 
            this.gxButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gxButton1.Index = 3;
            this.gxButton1.Location = new System.Drawing.Point(223, 338);
            this.gxButton1.Name = "gxButton1";
            this.gxButton1.Size = new System.Drawing.Size(100, 23);
            this.gxButton1.TabIndex = 29;
            this.gxButton1.Text = "Remove...";
            this.gxButton1.UseVisualStyleBackColor = true;
            // 
            // AddFunctionBtn
            // 
            this.AddFunctionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddFunctionBtn.Index = 2;
            this.AddFunctionBtn.Location = new System.Drawing.Point(117, 338);
            this.AddFunctionBtn.Name = "AddFunctionBtn";
            this.AddFunctionBtn.Size = new System.Drawing.Size(100, 23);
            this.AddFunctionBtn.TabIndex = 28;
            this.AddFunctionBtn.Text = "Add function...";
            this.AddFunctionBtn.UseVisualStyleBackColor = true;
            // 
            // SetStatusBtn
            // 
            this.SetStatusBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetStatusBtn.Index = 1;
            this.SetStatusBtn.Location = new System.Drawing.Point(11, 338);
            this.SetStatusBtn.Name = "SetStatusBtn";
            this.SetStatusBtn.Size = new System.Drawing.Size(100, 23);
            this.SetStatusBtn.TabIndex = 27;
            this.SetStatusBtn.Text = "Set status...";
            this.SetStatusBtn.UseVisualStyleBackColor = true;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(374, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSFunctionControlView
            // 
            this.ClientSize = new System.Drawing.Size(523, 391);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSFunctionControlView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ListView ActivationStatusView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView FunctionListView;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GXButton gxButton1;
        private GXButton AddFunctionBtn;
        private GXButton SetStatusBtn;
    }
}
