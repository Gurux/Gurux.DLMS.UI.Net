using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationDataView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MulticastView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SwitchTableView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DirectTableView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.AvailableSwitchesView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.PhyCommmunicationView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Tabs);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRIME NB OFDM PLC MAC network administration data Object";
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Controls.Add(this.tabPage4);
            this.Tabs.Controls.Add(this.tabPage5);
            this.Tabs.Location = new System.Drawing.Point(10, 71);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(622, 265);
            this.Tabs.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MulticastView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Multicast:";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MulticastView
            // 
            this.MulticastView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6});
            this.MulticastView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MulticastView.FullRowSelect = true;
            this.MulticastView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MulticastView.HideSelection = false;
            this.MulticastView.Location = new System.Drawing.Point(3, 3);
            this.MulticastView.Name = "MulticastView";
            this.MulticastView.Size = new System.Drawing.Size(608, 233);
            this.MulticastView.TabIndex = 30;
            this.MulticastView.UseCompatibleStateImageBehavior = false;
            this.MulticastView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Members";
            this.columnHeader6.Width = 404;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SwitchTableView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Switch Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SwitchTableView
            // 
            this.SwitchTableView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.SwitchTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwitchTableView.FullRowSelect = true;
            this.SwitchTableView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.SwitchTableView.HideSelection = false;
            this.SwitchTableView.Location = new System.Drawing.Point(3, 3);
            this.SwitchTableView.Name = "SwitchTableView";
            this.SwitchTableView.Size = new System.Drawing.Size(608, 233);
            this.SwitchTableView.TabIndex = 20;
            this.SwitchTableView.UseCompatibleStateImageBehavior = false;
            this.SwitchTableView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SID:";
            this.columnHeader2.Width = 285;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DirectTableView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(614, 239);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Direct Table:";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DirectTableView
            // 
            this.DirectTableView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.DirectTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DirectTableView.FullRowSelect = true;
            this.DirectTableView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DirectTableView.HideSelection = false;
            this.DirectTableView.Location = new System.Drawing.Point(3, 3);
            this.DirectTableView.Name = "DirectTableView";
            this.DirectTableView.Size = new System.Drawing.Size(608, 233);
            this.DirectTableView.TabIndex = 20;
            this.DirectTableView.UseCompatibleStateImageBehavior = false;
            this.DirectTableView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Src SID";
            this.columnHeader3.Width = 55;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Src LNID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Src LCID";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Dst SID";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Dst LNID";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Dst LCID";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "DID";
            this.columnHeader12.Width = 111;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AvailableSwitchesView);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(614, 239);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Available Switches:";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AvailableSwitchesView
            // 
            this.AvailableSwitchesView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.AvailableSwitchesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvailableSwitchesView.FullRowSelect = true;
            this.AvailableSwitchesView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AvailableSwitchesView.HideSelection = false;
            this.AvailableSwitchesView.Location = new System.Drawing.Point(3, 3);
            this.AvailableSwitchesView.Name = "AvailableSwitchesView";
            this.AvailableSwitchesView.Size = new System.Drawing.Size(608, 233);
            this.AvailableSwitchesView.TabIndex = 21;
            this.AvailableSwitchesView.UseCompatibleStateImageBehavior = false;
            this.AvailableSwitchesView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SNA";
            this.columnHeader4.Width = 122;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "LSID";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Level";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "RX Level";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "RX SNR";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.PhyCommmunicationView);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(614, 239);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Phy Communication:";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // PhyCommmunicationView
            // 
            this.PhyCommmunicationView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.PhyCommmunicationView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhyCommmunicationView.FullRowSelect = true;
            this.PhyCommmunicationView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.PhyCommmunicationView.HideSelection = false;
            this.PhyCommmunicationView.Location = new System.Drawing.Point(3, 3);
            this.PhyCommmunicationView.Name = "PhyCommmunicationView";
            this.PhyCommmunicationView.Size = new System.Drawing.Size(608, 233);
            this.PhyCommmunicationView.TabIndex = 21;
            this.PhyCommmunicationView.UseCompatibleStateImageBehavior = false;
            this.PhyCommmunicationView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "EUI";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "TX Pwr";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "TX Code";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "RX Code";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "RX Lvl";
            this.columnHeader20.Width = 59;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "SNR";
            this.columnHeader21.Width = 48;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "TX Pwr Mod";
            this.columnHeader22.Width = 77;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "TX Code Mod";
            this.columnHeader23.Width = 78;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "RX Code Mod";
            this.columnHeader24.Width = 83;
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
            this.DescriptionTB.Size = new System.Drawing.Size(529, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(528, 20);
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
            // GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationDataView
            // 
            this.ClientSize = new System.Drawing.Size(677, 376);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPrimeNbOfdmPlcMacNetworkAdministrationDataView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl Tabs;
        private TabPage tabPage1;
        private ListView MulticastView;
        private ColumnHeader columnHeader1;
        private TabPage tabPage2;
        private ListView SwitchTableView;
        private ColumnHeader columnHeader2;
        private TabPage tabPage3;
        private ListView DirectTableView;
        private ColumnHeader columnHeader3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private ListView AvailableSwitchesView;
        private ColumnHeader columnHeader4;
        private ListView PhyCommmunicationView;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
    }
}
