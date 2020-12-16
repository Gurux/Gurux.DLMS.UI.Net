using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSIecTwistedPairSetupView
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
        private Label ModeLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIecTwistedPairSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ModeLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ModeTb = new Gurux.DLMS.UI.GXValueField();
            this.SpeedTb = new Gurux.DLMS.UI.GXValueField();
            this.SpeedLbl = new System.Windows.Forms.Label();
            this.PrimaryAddressesList = new System.Windows.Forms.ListView();
            this.NameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabisList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrimaryAddressesRemoveBtn = new System.Windows.Forms.Button();
            this.PrimaryAddressesEditBtn = new System.Windows.Forms.Button();
            this.PrimaryAddressesAddBtn = new System.Windows.Forms.Button();
            this.PrimaryAddressesLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TabisRemoveBtn = new System.Windows.Forms.Button();
            this.TabisEditBtn = new System.Windows.Forms.Button();
            this.TabisAddBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TabisRemoveBtn);
            this.groupBox1.Controls.Add(this.TabisEditBtn);
            this.groupBox1.Controls.Add(this.TabisAddBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PrimaryAddressesLbl);
            this.groupBox1.Controls.Add(this.PrimaryAddressesRemoveBtn);
            this.groupBox1.Controls.Add(this.PrimaryAddressesEditBtn);
            this.groupBox1.Controls.Add(this.PrimaryAddressesAddBtn);
            this.groupBox1.Controls.Add(this.TabisList);
            this.groupBox1.Controls.Add(this.PrimaryAddressesList);
            this.groupBox1.Controls.Add(this.SpeedTb);
            this.groupBox1.Controls.Add(this.SpeedLbl);
            this.groupBox1.Controls.Add(this.ModeTb);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.ModeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 413);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Object";
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
            this.DescriptionTB.Size = new System.Drawing.Size(380, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // ModeLbl
            // 
            this.ModeLbl.AutoSize = true;
            this.ModeLbl.Location = new System.Drawing.Point(7, 74);
            this.ModeLbl.Name = "ModeLbl";
            this.ModeLbl.Size = new System.Drawing.Size(34, 13);
            this.ModeLbl.TabIndex = 2;
            this.ModeLbl.Text = "Mode";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(379, 20);
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
            // ModeTb
            // 
            this.ModeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeTb.Index = 2;
            this.ModeTb.Location = new System.Drawing.Point(103, 71);
            this.ModeTb.Name = "ModeTb";
            this.ModeTb.NotifyChanges = false;
            this.ModeTb.Size = new System.Drawing.Size(379, 20);
            this.ModeTb.TabIndex = 6;
            this.ModeTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // SpeedTb
            // 
            this.SpeedTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpeedTb.Index = 3;
            this.SpeedTb.Location = new System.Drawing.Point(103, 97);
            this.SpeedTb.Name = "SpeedTb";
            this.SpeedTb.NotifyChanges = false;
            this.SpeedTb.Size = new System.Drawing.Size(379, 20);
            this.SpeedTb.TabIndex = 8;
            this.SpeedTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // SpeedLbl
            // 
            this.SpeedLbl.AutoSize = true;
            this.SpeedLbl.Location = new System.Drawing.Point(7, 100);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(41, 13);
            this.SpeedLbl.TabIndex = 7;
            this.SpeedLbl.Text = "Speed:";
            // 
            // PrimaryAddressesList
            // 
            this.PrimaryAddressesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader});
            this.PrimaryAddressesList.FullRowSelect = true;
            this.PrimaryAddressesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PrimaryAddressesList.HideSelection = false;
            this.PrimaryAddressesList.Location = new System.Drawing.Point(103, 123);
            this.PrimaryAddressesList.Name = "PrimaryAddressesList";
            this.PrimaryAddressesList.Size = new System.Drawing.Size(283, 136);
            this.PrimaryAddressesList.TabIndex = 19;
            this.PrimaryAddressesList.UseCompatibleStateImageBehavior = false;
            this.PrimaryAddressesList.View = System.Windows.Forms.View.Details;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            this.NameHeader.Width = 145;
            // 
            // TabisList
            // 
            this.TabisList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.TabisList.FullRowSelect = true;
            this.TabisList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TabisList.HideSelection = false;
            this.TabisList.Location = new System.Drawing.Point(103, 265);
            this.TabisList.Name = "TabisList";
            this.TabisList.Size = new System.Drawing.Size(283, 142);
            this.TabisList.TabIndex = 20;
            this.TabisList.UseCompatibleStateImageBehavior = false;
            this.TabisList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 145;
            // 
            // PrimaryAddressesRemoveBtn
            // 
            this.PrimaryAddressesRemoveBtn.Location = new System.Drawing.Point(408, 181);
            this.PrimaryAddressesRemoveBtn.Name = "PrimaryAddressesRemoveBtn";
            this.PrimaryAddressesRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.PrimaryAddressesRemoveBtn.TabIndex = 26;
            this.PrimaryAddressesRemoveBtn.Text = "Remove";
            this.PrimaryAddressesRemoveBtn.UseVisualStyleBackColor = true;
            this.PrimaryAddressesRemoveBtn.Click += new System.EventHandler(this.PrimaryAddressesRemoveBtn_Click);
            // 
            // PrimaryAddressesEditBtn
            // 
            this.PrimaryAddressesEditBtn.Location = new System.Drawing.Point(408, 152);
            this.PrimaryAddressesEditBtn.Name = "PrimaryAddressesEditBtn";
            this.PrimaryAddressesEditBtn.Size = new System.Drawing.Size(75, 23);
            this.PrimaryAddressesEditBtn.TabIndex = 25;
            this.PrimaryAddressesEditBtn.Text = "Edit...";
            this.PrimaryAddressesEditBtn.UseVisualStyleBackColor = true;
            this.PrimaryAddressesEditBtn.Click += new System.EventHandler(this.PrimaryAddressesEditBtn_Click);
            // 
            // PrimaryAddressesAddBtn
            // 
            this.PrimaryAddressesAddBtn.Location = new System.Drawing.Point(408, 123);
            this.PrimaryAddressesAddBtn.Name = "PrimaryAddressesAddBtn";
            this.PrimaryAddressesAddBtn.Size = new System.Drawing.Size(75, 23);
            this.PrimaryAddressesAddBtn.TabIndex = 24;
            this.PrimaryAddressesAddBtn.Text = "Add...";
            this.PrimaryAddressesAddBtn.UseVisualStyleBackColor = true;
            this.PrimaryAddressesAddBtn.Click += new System.EventHandler(this.PrimaryAddressesAddBtn_Click);
            // 
            // PrimaryAddressesLbl
            // 
            this.PrimaryAddressesLbl.AutoSize = true;
            this.PrimaryAddressesLbl.Location = new System.Drawing.Point(7, 133);
            this.PrimaryAddressesLbl.Name = "PrimaryAddressesLbl";
            this.PrimaryAddressesLbl.Size = new System.Drawing.Size(95, 13);
            this.PrimaryAddressesLbl.TabIndex = 27;
            this.PrimaryAddressesLbl.Text = "Primary addresses:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "TAB(i)";
            // 
            // TabisRemoveBtn
            // 
            this.TabisRemoveBtn.Location = new System.Drawing.Point(407, 323);
            this.TabisRemoveBtn.Name = "TabisRemoveBtn";
            this.TabisRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.TabisRemoveBtn.TabIndex = 31;
            this.TabisRemoveBtn.Text = "Remove";
            this.TabisRemoveBtn.UseVisualStyleBackColor = true;
            this.TabisRemoveBtn.Click += new System.EventHandler(this.TabisRemoveBtn_Click);
            // 
            // TabisEditBtn
            // 
            this.TabisEditBtn.Location = new System.Drawing.Point(407, 294);
            this.TabisEditBtn.Name = "TabisEditBtn";
            this.TabisEditBtn.Size = new System.Drawing.Size(75, 23);
            this.TabisEditBtn.TabIndex = 30;
            this.TabisEditBtn.Text = "Edit...";
            this.TabisEditBtn.UseVisualStyleBackColor = true;
            this.TabisEditBtn.Click += new System.EventHandler(this.TabisEditBtn_Click);
            // 
            // TabisAddBtn
            // 
            this.TabisAddBtn.Location = new System.Drawing.Point(407, 265);
            this.TabisAddBtn.Name = "TabisAddBtn";
            this.TabisAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TabisAddBtn.TabIndex = 29;
            this.TabisAddBtn.Text = "Add...";
            this.TabisAddBtn.UseVisualStyleBackColor = true;
            this.TabisAddBtn.Click += new System.EventHandler(this.TabisAddBtn_Click);
            // 
            // GXDLMSIecTwistedPairSetupView
            // 
            this.ClientSize = new System.Drawing.Size(528, 437);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSIecTwistedPairSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField SpeedTb;
        private Label SpeedLbl;
        private GXValueField ModeTb;
        private ListView TabisList;
        private ColumnHeader columnHeader1;
        private ListView PrimaryAddressesList;
        private ColumnHeader NameHeader;
        private Button TabisRemoveBtn;
        private Button TabisEditBtn;
        private Button TabisAddBtn;
        private Label label2;
        private Label PrimaryAddressesLbl;
        private Button PrimaryAddressesRemoveBtn;
        private Button PrimaryAddressesEditBtn;
        private Button PrimaryAddressesAddBtn;
    }
}
