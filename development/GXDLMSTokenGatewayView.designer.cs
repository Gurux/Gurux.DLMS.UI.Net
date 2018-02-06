using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSTokenGatewayView
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
        private GXValueField TokenTb;
        private Label TokenLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSTokenGatewayView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatusCodeTb = new System.Windows.Forms.ComboBox();
            this.DataValueTb = new System.Windows.Forms.TextBox();
            this.DataValueLbl = new System.Windows.Forms.Label();
            this.StatusCodeLbl = new System.Windows.Forms.Label();
            this.DeliveryMethodLbl = new System.Windows.Forms.Label();
            this.DescriptionsLbl = new System.Windows.Forms.Label();
            this.DescriptionsRemove = new System.Windows.Forms.Button();
            this.DescriptionsEdit = new System.Windows.Forms.Button();
            this.DescriptionsAdd = new System.Windows.Forms.Button();
            this.DescriptionsView = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.TokenLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DeliveryMethodCb = new Gurux.DLMS.UI.GXValueField();
            this.TimeTb = new Gurux.DLMS.UI.GXValueField();
            this.TokenTb = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StatusCodeTb);
            this.groupBox1.Controls.Add(this.DeliveryMethodCb);
            this.groupBox1.Controls.Add(this.DataValueTb);
            this.groupBox1.Controls.Add(this.DataValueLbl);
            this.groupBox1.Controls.Add(this.StatusCodeLbl);
            this.groupBox1.Controls.Add(this.DeliveryMethodLbl);
            this.groupBox1.Controls.Add(this.DescriptionsLbl);
            this.groupBox1.Controls.Add(this.DescriptionsRemove);
            this.groupBox1.Controls.Add(this.DescriptionsEdit);
            this.groupBox1.Controls.Add(this.DescriptionsAdd);
            this.groupBox1.Controls.Add(this.DescriptionsView);
            this.groupBox1.Controls.Add(this.TimeTb);
            this.groupBox1.Controls.Add(this.TimeLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.TokenTb);
            this.groupBox1.Controls.Add(this.TokenLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Token Gateway Object";
            // 
            // StatusCodeTb
            // 
            this.StatusCodeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusCodeTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCodeTb.FormattingEnabled = true;
            this.StatusCodeTb.Location = new System.Drawing.Point(103, 315);
            this.StatusCodeTb.Name = "StatusCodeTb";
            this.StatusCodeTb.Size = new System.Drawing.Size(354, 21);
            this.StatusCodeTb.TabIndex = 7;
            this.StatusCodeTb.SelectedIndexChanged += new System.EventHandler(this.StatusCodeTb_SelectedIndexChanged);
            // 
            // DataValueTb
            // 
            this.DataValueTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataValueTb.Location = new System.Drawing.Point(103, 342);
            this.DataValueTb.Name = "DataValueTb";
            this.DataValueTb.Size = new System.Drawing.Size(353, 20);
            this.DataValueTb.TabIndex = 8;
            this.DataValueTb.Leave += new System.EventHandler(this.DataValueTb_Leave);
            // 
            // DataValueLbl
            // 
            this.DataValueLbl.AutoSize = true;
            this.DataValueLbl.Location = new System.Drawing.Point(6, 345);
            this.DataValueLbl.Name = "DataValueLbl";
            this.DataValueLbl.Size = new System.Drawing.Size(63, 13);
            this.DataValueLbl.TabIndex = 82;
            this.DataValueLbl.Text = "Data Value:";
            // 
            // StatusCodeLbl
            // 
            this.StatusCodeLbl.AutoSize = true;
            this.StatusCodeLbl.Location = new System.Drawing.Point(7, 323);
            this.StatusCodeLbl.Name = "StatusCodeLbl";
            this.StatusCodeLbl.Size = new System.Drawing.Size(67, 13);
            this.StatusCodeLbl.TabIndex = 81;
            this.StatusCodeLbl.Text = "Status code:";
            // 
            // DeliveryMethodLbl
            // 
            this.DeliveryMethodLbl.AutoSize = true;
            this.DeliveryMethodLbl.Location = new System.Drawing.Point(7, 292);
            this.DeliveryMethodLbl.Name = "DeliveryMethodLbl";
            this.DeliveryMethodLbl.Size = new System.Drawing.Size(87, 13);
            this.DeliveryMethodLbl.TabIndex = 80;
            this.DeliveryMethodLbl.Text = "Delivery Method:";
            // 
            // DescriptionsLbl
            // 
            this.DescriptionsLbl.AutoSize = true;
            this.DescriptionsLbl.Location = new System.Drawing.Point(7, 123);
            this.DescriptionsLbl.Name = "DescriptionsLbl";
            this.DescriptionsLbl.Size = new System.Drawing.Size(68, 13);
            this.DescriptionsLbl.TabIndex = 28;
            this.DescriptionsLbl.Text = "Descriptions:";
            // 
            // DescriptionsRemove
            // 
            this.DescriptionsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionsRemove.Location = new System.Drawing.Point(381, 260);
            this.DescriptionsRemove.Name = "DescriptionsRemove";
            this.DescriptionsRemove.Size = new System.Drawing.Size(75, 23);
            this.DescriptionsRemove.TabIndex = 5;
            this.DescriptionsRemove.Text = "Remove";
            this.DescriptionsRemove.UseVisualStyleBackColor = true;
            this.DescriptionsRemove.Click += new System.EventHandler(this.DescriptionsRemove_Click);
            // 
            // DescriptionsEdit
            // 
            this.DescriptionsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionsEdit.Location = new System.Drawing.Point(300, 260);
            this.DescriptionsEdit.Name = "DescriptionsEdit";
            this.DescriptionsEdit.Size = new System.Drawing.Size(75, 23);
            this.DescriptionsEdit.TabIndex = 4;
            this.DescriptionsEdit.Text = "Edit...";
            this.DescriptionsEdit.UseVisualStyleBackColor = true;
            this.DescriptionsEdit.Click += new System.EventHandler(this.DescriptionsEdit_Click);
            // 
            // DescriptionsAdd
            // 
            this.DescriptionsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionsAdd.Location = new System.Drawing.Point(219, 260);
            this.DescriptionsAdd.Name = "DescriptionsAdd";
            this.DescriptionsAdd.Size = new System.Drawing.Size(75, 23);
            this.DescriptionsAdd.TabIndex = 3;
            this.DescriptionsAdd.Text = "Add...";
            this.DescriptionsAdd.UseVisualStyleBackColor = true;
            this.DescriptionsAdd.Click += new System.EventHandler(this.DescriptionsAdd_Click);
            // 
            // DescriptionsView
            // 
            this.DescriptionsView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader});
            this.DescriptionsView.FullRowSelect = true;
            this.DescriptionsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DescriptionsView.HideSelection = false;
            this.DescriptionsView.Location = new System.Drawing.Point(103, 123);
            this.DescriptionsView.Name = "DescriptionsView";
            this.DescriptionsView.Size = new System.Drawing.Size(353, 131);
            this.DescriptionsView.TabIndex = 2;
            this.DescriptionsView.UseCompatibleStateImageBehavior = false;
            this.DescriptionsView.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 315;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(7, 100);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(33, 13);
            this.TimeLbl.TabIndex = 7;
            this.TimeLbl.Text = "Time:";
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
            this.DescriptionTB.Size = new System.Drawing.Size(354, 20);
            this.DescriptionTB.TabIndex = 9;
            // 
            // TokenLbl
            // 
            this.TokenLbl.AutoSize = true;
            this.TokenLbl.Location = new System.Drawing.Point(7, 74);
            this.TokenLbl.Name = "TokenLbl";
            this.TokenLbl.Size = new System.Drawing.Size(41, 13);
            this.TokenLbl.TabIndex = 2;
            this.TokenLbl.Text = "Token:";
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
            // DeliveryMethodCb
            // 
            this.DeliveryMethodCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeliveryMethodCb.Index = 5;
            this.DeliveryMethodCb.Location = new System.Drawing.Point(104, 290);
            this.DeliveryMethodCb.Name = "DeliveryMethodCb";
            this.DeliveryMethodCb.NotifyChanges = false;
            this.DeliveryMethodCb.ReadOnly = true;
            this.DeliveryMethodCb.Size = new System.Drawing.Size(353, 20);
            this.DeliveryMethodCb.TabIndex = 6;
            this.DeliveryMethodCb.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // TimeTb
            // 
            this.TimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTb.Index = 3;
            this.TimeTb.Location = new System.Drawing.Point(104, 97);
            this.TimeTb.Name = "TimeTb";
            this.TimeTb.NotifyChanges = false;
            this.TimeTb.Size = new System.Drawing.Size(353, 20);
            this.TimeTb.TabIndex = 1;
            this.TimeTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // TokenTb
            // 
            this.TokenTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenTb.Index = 2;
            this.TokenTb.Location = new System.Drawing.Point(104, 71);
            this.TokenTb.Name = "TokenTb";
            this.TokenTb.NotifyChanges = false;
            this.TokenTb.Size = new System.Drawing.Size(353, 20);
            this.TokenTb.TabIndex = 0;
            this.TokenTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(353, 20);
            this.LogicalNameTB.TabIndex = 10;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // GXDLMSTokenGatewayView
            // 
            this.ClientSize = new System.Drawing.Size(502, 406);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSTokenGatewayView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField TimeTb;
        private Label TimeLbl;
        private Label DescriptionsLbl;
        private Button DescriptionsRemove;
        private Button DescriptionsEdit;
        private Button DescriptionsAdd;
        private ListView DescriptionsView;
        private ColumnHeader NameHeader;
        private Label DataValueLbl;
        private Label StatusCodeLbl;
        private Label DeliveryMethodLbl;
        private TextBox DataValueTb;
        private GXValueField DeliveryMethodCb;
        private ComboBox StatusCodeTb;
    }
}
