using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSModemConfigurationView
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
        private GXValueField CommunicationSpeedTB;
        private Label CommunicationSpeedLbl;
        private GXValueField LogicalNameTB;
        private Label ModemProfileLbl;
        private Label InitialisationLbl;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSModemConfigurationView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ModemProfileLbl = new System.Windows.Forms.Label();
            this.InitialisationLbl = new System.Windows.Forms.Label();
            this.CommunicationSpeedLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.InitialisationView = new System.Windows.Forms.ListView();
            this.RequestHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ResponseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DelayHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ModemProfileTB = new System.Windows.Forms.TextBox();
            this.CommunicationSpeedTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ModemProfileTB);
            this.groupBox1.Controls.Add(this.RemoveBtn);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.InitialisationView);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.ModemProfileLbl);
            this.groupBox1.Controls.Add(this.InitialisationLbl);
            this.groupBox1.Controls.Add(this.CommunicationSpeedTB);
            this.groupBox1.Controls.Add(this.CommunicationSpeedLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modem Configuration Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // ModemProfileLbl
            // 
            this.ModemProfileLbl.AutoSize = true;
            this.ModemProfileLbl.Location = new System.Drawing.Point(6, 246);
            this.ModemProfileLbl.Name = "ModemProfileLbl";
            this.ModemProfileLbl.Size = new System.Drawing.Size(77, 13);
            this.ModemProfileLbl.TabIndex = 6;
            this.ModemProfileLbl.Text = "Modem Profile:";
            // 
            // InitialisationLbl
            // 
            this.InitialisationLbl.AutoSize = true;
            this.InitialisationLbl.Location = new System.Drawing.Point(6, 76);
            this.InitialisationLbl.Name = "InitialisationLbl";
            this.InitialisationLbl.Size = new System.Drawing.Size(64, 13);
            this.InitialisationLbl.TabIndex = 4;
            this.InitialisationLbl.Text = "Initialisation:";
            // 
            // CommunicationSpeedLbl
            // 
            this.CommunicationSpeedLbl.AutoSize = true;
            this.CommunicationSpeedLbl.Location = new System.Drawing.Point(6, 50);
            this.CommunicationSpeedLbl.Name = "CommunicationSpeedLbl";
            this.CommunicationSpeedLbl.Size = new System.Drawing.Size(41, 13);
            this.CommunicationSpeedLbl.TabIndex = 2;
            this.CommunicationSpeedLbl.Text = "Speed:";
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
            // InitialisationView
            // 
            this.InitialisationView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialisationView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RequestHeader,
            this.ResponseHeader,
            this.DelayHeader});
            this.InitialisationView.FullRowSelect = true;
            this.InitialisationView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.InitialisationView.HideSelection = false;
            this.InitialisationView.Location = new System.Drawing.Point(102, 76);
            this.InitialisationView.Name = "InitialisationView";
            this.InitialisationView.Size = new System.Drawing.Size(383, 137);
            this.InitialisationView.TabIndex = 18;
            this.InitialisationView.UseCompatibleStateImageBehavior = false;
            this.InitialisationView.View = System.Windows.Forms.View.Details;
            // 
            // RequestHeader
            // 
            this.RequestHeader.Text = "Request";
            this.RequestHeader.Width = 91;
            // 
            // ResponseHeader
            // 
            this.ResponseHeader.Text = "Response:";
            this.ResponseHeader.Width = 114;
            // 
            // DelayHeader
            // 
            this.DelayHeader.Text = "Delay";
            this.DelayHeader.Width = 218;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.Location = new System.Drawing.Point(410, 217);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 23;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(329, 217);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Edit...";
            this.EditBtn.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(248, 217);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "Add...";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // ModemProfileTB
            // 
            this.ModemProfileTB.Location = new System.Drawing.Point(102, 246);
            this.ModemProfileTB.Multiline = true;
            this.ModemProfileTB.Name = "ModemProfileTB";
            this.ModemProfileTB.Size = new System.Drawing.Size(383, 112);
            this.ModemProfileTB.TabIndex = 24;
            this.ModemProfileTB.Leave += new System.EventHandler(this.ModemProfileTB_Leave);
            // 
            // CommunicationSpeedTB
            // 
            this.CommunicationSpeedTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommunicationSpeedTB.Index = 2;
            this.CommunicationSpeedTB.Location = new System.Drawing.Point(102, 47);
            this.CommunicationSpeedTB.Name = "CommunicationSpeedTB";
            this.CommunicationSpeedTB.NotifyChanges = false;
            this.CommunicationSpeedTB.Size = new System.Drawing.Size(383, 20);
            this.CommunicationSpeedTB.TabIndex = 0;
            this.CommunicationSpeedTB.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(383, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // GXDLMSModemConfigurationView
            // 
            this.ClientSize = new System.Drawing.Size(522, 388);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSModemConfigurationView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView InitialisationView;
        private ColumnHeader RequestHeader;
        public ColumnHeader ResponseHeader;
        private ColumnHeader DelayHeader;
        private Button RemoveBtn;
        private Button EditBtn;
        private Button AddBtn;
        private TextBox ModemProfileTB;
    }
}
