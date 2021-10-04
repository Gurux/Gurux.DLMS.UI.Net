using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSNtpSetupView
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
        private GXValueField ServerAddressTb;
        private Label ServerAddressLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSNtpSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KeysLbl = new System.Windows.Forms.Label();
            this.ClientKeyLbl = new System.Windows.Forms.Label();
            this.AuthenticationLbl = new System.Windows.Forms.Label();
            this.PortLbl = new System.Windows.Forms.Label();
            this.EnabledLbl = new System.Windows.Forms.Label();
            this.ActivatedCb = new System.Windows.Forms.CheckBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ServerAddressLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.KeysView = new System.Windows.Forms.ListView();
            this.ClassIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveBtn = new Gurux.DLMS.UI.GXButton();
            this.AddBtn = new Gurux.DLMS.UI.GXButton();
            this.SynchronizeBtn = new Gurux.DLMS.UI.GXButton();
            this.ClientKeyTb = new Gurux.DLMS.UI.GXValueField();
            this.AuthenticationCb = new Gurux.DLMS.UI.GXValueField();
            this.PortTb = new Gurux.DLMS.UI.GXValueField();
            this.ServerAddressTb = new Gurux.DLMS.UI.GXValueField();
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
            this.groupBox1.Controls.Add(this.RemoveBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.SynchronizeBtn);
            this.groupBox1.Controls.Add(this.KeysLbl);
            this.groupBox1.Controls.Add(this.ClientKeyTb);
            this.groupBox1.Controls.Add(this.ClientKeyLbl);
            this.groupBox1.Controls.Add(this.AuthenticationCb);
            this.groupBox1.Controls.Add(this.AuthenticationLbl);
            this.groupBox1.Controls.Add(this.PortTb);
            this.groupBox1.Controls.Add(this.PortLbl);
            this.groupBox1.Controls.Add(this.EnabledLbl);
            this.groupBox1.Controls.Add(this.ActivatedCb);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.ServerAddressTb);
            this.groupBox1.Controls.Add(this.ServerAddressLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NTP Setup Object";
            // 
            // KeysLbl
            // 
            this.KeysLbl.AutoSize = true;
            this.KeysLbl.Location = new System.Drawing.Point(13, 215);
            this.KeysLbl.Name = "KeysLbl";
            this.KeysLbl.Size = new System.Drawing.Size(33, 13);
            this.KeysLbl.TabIndex = 31;
            this.KeysLbl.Text = "Keys:";
            // 
            // ClientKeyLbl
            // 
            this.ClientKeyLbl.AutoSize = true;
            this.ClientKeyLbl.Location = new System.Drawing.Point(7, 182);
            this.ClientKeyLbl.Name = "ClientKeyLbl";
            this.ClientKeyLbl.Size = new System.Drawing.Size(57, 13);
            this.ClientKeyLbl.TabIndex = 30;
            this.ClientKeyLbl.Text = "Client Key:";
            // 
            // AuthenticationLbl
            // 
            this.AuthenticationLbl.AutoSize = true;
            this.AuthenticationLbl.Location = new System.Drawing.Point(7, 155);
            this.AuthenticationLbl.Name = "AuthenticationLbl";
            this.AuthenticationLbl.Size = new System.Drawing.Size(78, 13);
            this.AuthenticationLbl.TabIndex = 28;
            this.AuthenticationLbl.Text = "Authentication:";
            // 
            // PortLbl
            // 
            this.PortLbl.AutoSize = true;
            this.PortLbl.Location = new System.Drawing.Point(6, 123);
            this.PortLbl.Name = "PortLbl";
            this.PortLbl.Size = new System.Drawing.Size(29, 13);
            this.PortLbl.TabIndex = 26;
            this.PortLbl.Text = "Port:";
            // 
            // EnabledLbl
            // 
            this.EnabledLbl.AutoSize = true;
            this.EnabledLbl.Location = new System.Drawing.Point(7, 73);
            this.EnabledLbl.Name = "EnabledLbl";
            this.EnabledLbl.Size = new System.Drawing.Size(55, 13);
            this.EnabledLbl.TabIndex = 24;
            this.EnabledLbl.Text = "Activated:";
            // 
            // ActivatedCb
            // 
            this.ActivatedCb.Location = new System.Drawing.Point(103, 71);
            this.ActivatedCb.Name = "ActivatedCb";
            this.ActivatedCb.Size = new System.Drawing.Size(37, 17);
            this.ActivatedCb.TabIndex = 23;
            this.ActivatedCb.UseVisualStyleBackColor = false;
            this.ActivatedCb.CheckedChanged += new System.EventHandler(this.ActivatedCb_CheckedChanged);
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
            this.DescriptionTB.Size = new System.Drawing.Size(384, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // ServerAddressLbl
            // 
            this.ServerAddressLbl.AutoSize = true;
            this.ServerAddressLbl.Location = new System.Drawing.Point(6, 97);
            this.ServerAddressLbl.Name = "ServerAddressLbl";
            this.ServerAddressLbl.Size = new System.Drawing.Size(82, 13);
            this.ServerAddressLbl.TabIndex = 2;
            this.ServerAddressLbl.Text = "Server Address:";
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
            // KeysView
            // 
            this.KeysView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeysView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassIdHeader,
            this.KeyHeader});
            this.KeysView.FullRowSelect = true;
            this.KeysView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.KeysView.HideSelection = false;
            this.KeysView.Location = new System.Drawing.Point(116, 223);
            this.KeysView.Name = "KeysView";
            this.KeysView.Size = new System.Drawing.Size(383, 151);
            this.KeysView.TabIndex = 31;
            this.KeysView.UseCompatibleStateImageBehavior = false;
            this.KeysView.View = System.Windows.Forms.View.Details;
            // 
            // ClassIdHeader
            // 
            this.ClassIdHeader.Text = "ID:";
            this.ClassIdHeader.Width = 41;
            // 
            // KeyHeader
            // 
            this.KeyHeader.Text = "Key:";
            this.KeyHeader.Width = 349;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Index = 3;
            this.RemoveBtn.Location = new System.Drawing.Point(412, 368);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 34;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Index = 2;
            this.AddBtn.Location = new System.Drawing.Point(331, 368);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 33;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // SynchronizeBtn
            // 
            this.SynchronizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SynchronizeBtn.Index = 1;
            this.SynchronizeBtn.Location = new System.Drawing.Point(104, 368);
            this.SynchronizeBtn.Name = "SynchronizeBtn";
            this.SynchronizeBtn.Size = new System.Drawing.Size(84, 23);
            this.SynchronizeBtn.TabIndex = 32;
            this.SynchronizeBtn.Text = "Synchronize";
            this.SynchronizeBtn.UseVisualStyleBackColor = true;
            // 
            // ClientKeyTb
            // 
            this.ClientKeyTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientKeyTb.Index = 7;
            this.ClientKeyTb.Location = new System.Drawing.Point(104, 179);
            this.ClientKeyTb.Name = "ClientKeyTb";
            this.ClientKeyTb.NotifyChanges = false;
            this.ClientKeyTb.Size = new System.Drawing.Size(383, 26);
            this.ClientKeyTb.TabIndex = 29;
            this.ClientKeyTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // AuthenticationCb
            // 
            this.AuthenticationCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationCb.Index = 5;
            this.AuthenticationCb.Location = new System.Drawing.Point(104, 152);
            this.AuthenticationCb.Name = "AuthenticationCb";
            this.AuthenticationCb.NotifyChanges = false;
            this.AuthenticationCb.Size = new System.Drawing.Size(398, 21);
            this.AuthenticationCb.TabIndex = 27;
            this.AuthenticationCb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // PortTb
            // 
            this.PortTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTb.Index = 4;
            this.PortTb.Location = new System.Drawing.Point(103, 120);
            this.PortTb.Name = "PortTb";
            this.PortTb.NotifyChanges = false;
            this.PortTb.Size = new System.Drawing.Size(384, 26);
            this.PortTb.TabIndex = 25;
            this.PortTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ServerAddressTb
            // 
            this.ServerAddressTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerAddressTb.Index = 3;
            this.ServerAddressTb.Location = new System.Drawing.Point(103, 94);
            this.ServerAddressTb.Name = "ServerAddressTb";
            this.ServerAddressTb.NotifyChanges = false;
            this.ServerAddressTb.Size = new System.Drawing.Size(384, 26);
            this.ServerAddressTb.TabIndex = 0;
            this.ServerAddressTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.ServerAddressTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ServerAddressTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(384, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSNtpSetupView
            // 
            this.ClientSize = new System.Drawing.Size(547, 424);
            this.Controls.Add(this.KeysView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSNtpSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label EnabledLbl;
        private CheckBox ActivatedCb;
        private GXValueField PortTb;
        private Label PortLbl;
        private GXValueField AuthenticationCb;
        private Label AuthenticationLbl;
        private GXValueField ClientKeyTb;
        private Label ClientKeyLbl;
        private Label KeysLbl;
        private ListView KeysView;
        private ColumnHeader ClassIdHeader;
        private ColumnHeader KeyHeader;
        private GXButton RemoveBtn;
        private GXButton AddBtn;
        private GXButton SynchronizeBtn;
    }
}
