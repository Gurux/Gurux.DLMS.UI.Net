using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPrimeNbOfdmPlcMacFunctionalParametersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPrimeNbOfdmPlcMacFunctionalParametersView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CapabilitiesCb = new Gurux.DLMS.UI.GXValueField();
            this.CapabilitiesLbl = new System.Windows.Forms.Label();
            this.BeaconTXFrequencyTb = new Gurux.DLMS.UI.GXValueField();
            this.BeaconTXFrequencyLbl = new System.Windows.Forms.Label();
            this.BeaconRXFrequencyTb = new Gurux.DLMS.UI.GXValueField();
            this.BeaconRXFrequencyLbl = new System.Windows.Forms.Label();
            this.BeaconTXSlotTb = new Gurux.DLMS.UI.GXValueField();
            this.BeaconTXSlotLbl = new System.Windows.Forms.Label();
            this.BeaconRXSlotTb = new Gurux.DLMS.UI.GXValueField();
            this.BeaconRXSlotLbl = new System.Windows.Forms.Label();
            this.BeaconSlotCountTb = new Gurux.DLMS.UI.GXValueField();
            this.BeaconSlotCountLbl = new System.Windows.Forms.Label();
            this.NodeHierarchyLevelTb = new Gurux.DLMS.UI.GXValueField();
            this.NodeHierarchyLevelLbl = new System.Windows.Forms.Label();
            this.SCPLengtTb = new Gurux.DLMS.UI.GXValueField();
            this.SCPLengtLbl = new System.Windows.Forms.Label();
            this.StateTb = new Gurux.DLMS.UI.GXValueField();
            this.StateLbl = new System.Windows.Forms.Label();
            this.SNATb = new Gurux.DLMS.UI.GXValueField();
            this.SNALbl = new System.Windows.Forms.Label();
            this.SIDTb = new Gurux.DLMS.UI.GXValueField();
            this.SIDLbl = new System.Windows.Forms.Label();
            this.LSIDTb = new Gurux.DLMS.UI.GXValueField();
            this.LSIDLbl = new System.Windows.Forms.Label();
            this.LNIDTb = new Gurux.DLMS.UI.GXValueField();
            this.LNIDLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.CapabilitiesCb);
            this.groupBox1.Controls.Add(this.CapabilitiesLbl);
            this.groupBox1.Controls.Add(this.BeaconTXFrequencyTb);
            this.groupBox1.Controls.Add(this.BeaconTXFrequencyLbl);
            this.groupBox1.Controls.Add(this.BeaconRXFrequencyTb);
            this.groupBox1.Controls.Add(this.BeaconRXFrequencyLbl);
            this.groupBox1.Controls.Add(this.BeaconTXSlotTb);
            this.groupBox1.Controls.Add(this.BeaconTXSlotLbl);
            this.groupBox1.Controls.Add(this.BeaconRXSlotTb);
            this.groupBox1.Controls.Add(this.BeaconRXSlotLbl);
            this.groupBox1.Controls.Add(this.BeaconSlotCountTb);
            this.groupBox1.Controls.Add(this.BeaconSlotCountLbl);
            this.groupBox1.Controls.Add(this.NodeHierarchyLevelTb);
            this.groupBox1.Controls.Add(this.NodeHierarchyLevelLbl);
            this.groupBox1.Controls.Add(this.SCPLengtTb);
            this.groupBox1.Controls.Add(this.SCPLengtLbl);
            this.groupBox1.Controls.Add(this.StateTb);
            this.groupBox1.Controls.Add(this.StateLbl);
            this.groupBox1.Controls.Add(this.SNATb);
            this.groupBox1.Controls.Add(this.SNALbl);
            this.groupBox1.Controls.Add(this.SIDTb);
            this.groupBox1.Controls.Add(this.SIDLbl);
            this.groupBox1.Controls.Add(this.LSIDTb);
            this.groupBox1.Controls.Add(this.LSIDLbl);
            this.groupBox1.Controls.Add(this.LNIDTb);
            this.groupBox1.Controls.Add(this.LNIDLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 608);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRIME NB OFDM PLC MAC functional parameters Object";
            // 
            // CapabilitiesCb
            // 
            this.CapabilitiesCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CapabilitiesCb.Index = 14;
            this.CapabilitiesCb.Location = new System.Drawing.Point(104, 383);
            this.CapabilitiesCb.Name = "CapabilitiesCb";
            this.CapabilitiesCb.NotifyChanges = false;
            this.CapabilitiesCb.Size = new System.Drawing.Size(171, 248);
            this.CapabilitiesCb.TabIndex = 34;
            this.CapabilitiesCb.Type = Gurux.DLMS.Enums.ValueFieldType.CheckedListBox;
            this.CapabilitiesCb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CapabilitiesCb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CapabilitiesLbl
            // 
            this.CapabilitiesLbl.AutoSize = true;
            this.CapabilitiesLbl.Location = new System.Drawing.Point(8, 386);
            this.CapabilitiesLbl.Name = "CapabilitiesLbl";
            this.CapabilitiesLbl.Size = new System.Drawing.Size(63, 13);
            this.CapabilitiesLbl.TabIndex = 33;
            this.CapabilitiesLbl.Text = "Capabilities:";
            // 
            // BeaconTXFrequencyTb
            // 
            this.BeaconTXFrequencyTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BeaconTXFrequencyTb.Index = 13;
            this.BeaconTXFrequencyTb.Location = new System.Drawing.Point(131, 357);
            this.BeaconTXFrequencyTb.Name = "BeaconTXFrequencyTb";
            this.BeaconTXFrequencyTb.NotifyChanges = false;
            this.BeaconTXFrequencyTb.Size = new System.Drawing.Size(144, 20);
            this.BeaconTXFrequencyTb.TabIndex = 32;
            this.BeaconTXFrequencyTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.BeaconTXFrequencyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.BeaconTXFrequencyTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // BeaconTXFrequencyLbl
            // 
            this.BeaconTXFrequencyLbl.AutoSize = true;
            this.BeaconTXFrequencyLbl.Location = new System.Drawing.Point(8, 360);
            this.BeaconTXFrequencyLbl.Name = "BeaconTXFrequencyLbl";
            this.BeaconTXFrequencyLbl.Size = new System.Drawing.Size(117, 13);
            this.BeaconTXFrequencyLbl.TabIndex = 31;
            this.BeaconTXFrequencyLbl.Text = "Beacon TX Frequency:";
            // 
            // BeaconRXFrequencyTb
            // 
            this.BeaconRXFrequencyTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BeaconRXFrequencyTb.Index = 12;
            this.BeaconRXFrequencyTb.Location = new System.Drawing.Point(130, 331);
            this.BeaconRXFrequencyTb.Name = "BeaconRXFrequencyTb";
            this.BeaconRXFrequencyTb.NotifyChanges = false;
            this.BeaconRXFrequencyTb.Size = new System.Drawing.Size(144, 20);
            this.BeaconRXFrequencyTb.TabIndex = 30;
            this.BeaconRXFrequencyTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.BeaconRXFrequencyTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.BeaconRXFrequencyTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // BeaconRXFrequencyLbl
            // 
            this.BeaconRXFrequencyLbl.AutoSize = true;
            this.BeaconRXFrequencyLbl.Location = new System.Drawing.Point(7, 334);
            this.BeaconRXFrequencyLbl.Name = "BeaconRXFrequencyLbl";
            this.BeaconRXFrequencyLbl.Size = new System.Drawing.Size(118, 13);
            this.BeaconRXFrequencyLbl.TabIndex = 29;
            this.BeaconRXFrequencyLbl.Text = "Beacon RX Frequency:";
            // 
            // BeaconTXSlotTb
            // 
            this.BeaconTXSlotTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BeaconTXSlotTb.Index = 11;
            this.BeaconTXSlotTb.Location = new System.Drawing.Point(130, 305);
            this.BeaconTXSlotTb.Name = "BeaconTXSlotTb";
            this.BeaconTXSlotTb.NotifyChanges = false;
            this.BeaconTXSlotTb.Size = new System.Drawing.Size(144, 20);
            this.BeaconTXSlotTb.TabIndex = 28;
            this.BeaconTXSlotTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.BeaconTXSlotTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.BeaconTXSlotTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // BeaconTXSlotLbl
            // 
            this.BeaconTXSlotLbl.AutoSize = true;
            this.BeaconTXSlotLbl.Location = new System.Drawing.Point(7, 308);
            this.BeaconTXSlotLbl.Name = "BeaconTXSlotLbl";
            this.BeaconTXSlotLbl.Size = new System.Drawing.Size(85, 13);
            this.BeaconTXSlotLbl.TabIndex = 27;
            this.BeaconTXSlotLbl.Text = "Beacon TX Slot:";
            // 
            // BeaconRXSlotTb
            // 
            this.BeaconRXSlotTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BeaconRXSlotTb.Index = 10;
            this.BeaconRXSlotTb.Location = new System.Drawing.Point(131, 279);
            this.BeaconRXSlotTb.Name = "BeaconRXSlotTb";
            this.BeaconRXSlotTb.NotifyChanges = false;
            this.BeaconRXSlotTb.Size = new System.Drawing.Size(144, 20);
            this.BeaconRXSlotTb.TabIndex = 26;
            this.BeaconRXSlotTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.BeaconRXSlotTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.BeaconRXSlotTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // BeaconRXSlotLbl
            // 
            this.BeaconRXSlotLbl.AutoSize = true;
            this.BeaconRXSlotLbl.Location = new System.Drawing.Point(8, 282);
            this.BeaconRXSlotLbl.Name = "BeaconRXSlotLbl";
            this.BeaconRXSlotLbl.Size = new System.Drawing.Size(86, 13);
            this.BeaconRXSlotLbl.TabIndex = 25;
            this.BeaconRXSlotLbl.Text = "Beacon RX Slot:";
            // 
            // BeaconSlotCountTb
            // 
            this.BeaconSlotCountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BeaconSlotCountTb.Index = 9;
            this.BeaconSlotCountTb.Location = new System.Drawing.Point(131, 253);
            this.BeaconSlotCountTb.Name = "BeaconSlotCountTb";
            this.BeaconSlotCountTb.NotifyChanges = false;
            this.BeaconSlotCountTb.Size = new System.Drawing.Size(144, 20);
            this.BeaconSlotCountTb.TabIndex = 24;
            this.BeaconSlotCountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.BeaconSlotCountTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.BeaconSlotCountTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // BeaconSlotCountLbl
            // 
            this.BeaconSlotCountLbl.AutoSize = true;
            this.BeaconSlotCountLbl.Location = new System.Drawing.Point(8, 256);
            this.BeaconSlotCountLbl.Name = "BeaconSlotCountLbl";
            this.BeaconSlotCountLbl.Size = new System.Drawing.Size(99, 13);
            this.BeaconSlotCountLbl.TabIndex = 23;
            this.BeaconSlotCountLbl.Text = "Beacon Slot Count:";
            // 
            // NodeHierarchyLevelTb
            // 
            this.NodeHierarchyLevelTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NodeHierarchyLevelTb.Index = 8;
            this.NodeHierarchyLevelTb.Location = new System.Drawing.Point(130, 227);
            this.NodeHierarchyLevelTb.Name = "NodeHierarchyLevelTb";
            this.NodeHierarchyLevelTb.NotifyChanges = false;
            this.NodeHierarchyLevelTb.Size = new System.Drawing.Size(144, 20);
            this.NodeHierarchyLevelTb.TabIndex = 22;
            this.NodeHierarchyLevelTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.NodeHierarchyLevelTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.NodeHierarchyLevelTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // NodeHierarchyLevelLbl
            // 
            this.NodeHierarchyLevelLbl.AutoSize = true;
            this.NodeHierarchyLevelLbl.Location = new System.Drawing.Point(7, 230);
            this.NodeHierarchyLevelLbl.Name = "NodeHierarchyLevelLbl";
            this.NodeHierarchyLevelLbl.Size = new System.Drawing.Size(113, 13);
            this.NodeHierarchyLevelLbl.TabIndex = 21;
            this.NodeHierarchyLevelLbl.Text = "Node Hierarchy Level:";
            // 
            // SCPLengtTb
            // 
            this.SCPLengtTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SCPLengtTb.Index = 7;
            this.SCPLengtTb.Location = new System.Drawing.Point(131, 201);
            this.SCPLengtTb.Name = "SCPLengtTb";
            this.SCPLengtTb.NotifyChanges = false;
            this.SCPLengtTb.Size = new System.Drawing.Size(144, 20);
            this.SCPLengtTb.TabIndex = 20;
            this.SCPLengtTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.SCPLengtTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.SCPLengtTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // SCPLengtLbl
            // 
            this.SCPLengtLbl.AutoSize = true;
            this.SCPLengtLbl.Location = new System.Drawing.Point(8, 204);
            this.SCPLengtLbl.Name = "SCPLengtLbl";
            this.SCPLengtLbl.Size = new System.Drawing.Size(61, 13);
            this.SCPLengtLbl.TabIndex = 19;
            this.SCPLengtLbl.Text = "SCP Lengt:";
            // 
            // StateTb
            // 
            this.StateTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StateTb.Index = 6;
            this.StateTb.Location = new System.Drawing.Point(131, 175);
            this.StateTb.Name = "StateTb";
            this.StateTb.NotifyChanges = false;
            this.StateTb.Size = new System.Drawing.Size(144, 20);
            this.StateTb.TabIndex = 18;
            this.StateTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.StateTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.StateTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Location = new System.Drawing.Point(8, 178);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(35, 13);
            this.StateLbl.TabIndex = 17;
            this.StateLbl.Text = "State:";
            // 
            // SNATb
            // 
            this.SNATb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SNATb.Index = 5;
            this.SNATb.Location = new System.Drawing.Point(130, 149);
            this.SNATb.Name = "SNATb";
            this.SNATb.NotifyChanges = false;
            this.SNATb.Size = new System.Drawing.Size(144, 20);
            this.SNATb.TabIndex = 16;
            this.SNATb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.SNATb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.SNATb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // SNALbl
            // 
            this.SNALbl.AutoSize = true;
            this.SNALbl.Location = new System.Drawing.Point(7, 152);
            this.SNALbl.Name = "SNALbl";
            this.SNALbl.Size = new System.Drawing.Size(32, 13);
            this.SNALbl.TabIndex = 15;
            this.SNALbl.Text = "SNA:";
            // 
            // SIDTb
            // 
            this.SIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SIDTb.Index = 4;
            this.SIDTb.Location = new System.Drawing.Point(131, 123);
            this.SIDTb.Name = "SIDTb";
            this.SIDTb.NotifyChanges = false;
            this.SIDTb.Size = new System.Drawing.Size(144, 20);
            this.SIDTb.TabIndex = 14;
            this.SIDTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.SIDTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.SIDTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // SIDLbl
            // 
            this.SIDLbl.AutoSize = true;
            this.SIDLbl.Location = new System.Drawing.Point(8, 126);
            this.SIDLbl.Name = "SIDLbl";
            this.SIDLbl.Size = new System.Drawing.Size(28, 13);
            this.SIDLbl.TabIndex = 13;
            this.SIDLbl.Text = "SID:";
            // 
            // LSIDTb
            // 
            this.LSIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LSIDTb.Index = 3;
            this.LSIDTb.Location = new System.Drawing.Point(130, 97);
            this.LSIDTb.Name = "LSIDTb";
            this.LSIDTb.NotifyChanges = false;
            this.LSIDTb.Size = new System.Drawing.Size(144, 20);
            this.LSIDTb.TabIndex = 12;
            this.LSIDTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.LSIDTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.LSIDTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LSIDLbl
            // 
            this.LSIDLbl.AutoSize = true;
            this.LSIDLbl.Location = new System.Drawing.Point(7, 100);
            this.LSIDLbl.Name = "LSIDLbl";
            this.LSIDLbl.Size = new System.Drawing.Size(34, 13);
            this.LSIDLbl.TabIndex = 11;
            this.LSIDLbl.Text = "LSID:";
            // 
            // LNIDTb
            // 
            this.LNIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LNIDTb.Index = 2;
            this.LNIDTb.Location = new System.Drawing.Point(130, 71);
            this.LNIDTb.Name = "LNIDTb";
            this.LNIDTb.NotifyChanges = false;
            this.LNIDTb.Size = new System.Drawing.Size(144, 20);
            this.LNIDTb.TabIndex = 10;
            this.LNIDTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.LNIDTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.LNIDTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // LNIDLbl
            // 
            this.LNIDLbl.AutoSize = true;
            this.LNIDLbl.Location = new System.Drawing.Point(7, 74);
            this.LNIDLbl.Name = "LNIDLbl";
            this.LNIDLbl.Size = new System.Drawing.Size(35, 13);
            this.LNIDLbl.TabIndex = 9;
            this.LNIDLbl.Text = "LNID:";
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
            this.DescriptionTB.Size = new System.Drawing.Size(172, 20);
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
            this.LogicalNameTB.Size = new System.Drawing.Size(171, 20);
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
            // GXDLMSPrimeNbOfdmPlcMacFunctionalParametersView
            // 
            this.ClientSize = new System.Drawing.Size(320, 632);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPrimeNbOfdmPlcMacFunctionalParametersView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField LNIDTb;
        private Label LNIDLbl;
        private GXValueField CapabilitiesCb;
        private Label CapabilitiesLbl;
        private GXValueField BeaconTXFrequencyTb;
        private Label BeaconTXFrequencyLbl;
        private GXValueField BeaconRXFrequencyTb;
        private Label BeaconRXFrequencyLbl;
        private GXValueField BeaconTXSlotTb;
        private Label BeaconTXSlotLbl;
        private GXValueField BeaconRXSlotTb;
        private Label BeaconRXSlotLbl;
        private GXValueField BeaconSlotCountTb;
        private Label BeaconSlotCountLbl;
        private GXValueField NodeHierarchyLevelTb;
        private Label NodeHierarchyLevelLbl;
        private GXValueField SCPLengtTb;
        private Label SCPLengtLbl;
        private GXValueField StateTb;
        private Label StateLbl;
        private GXValueField SNATb;
        private Label SNALbl;
        private GXValueField SIDTb;
        private Label SIDLbl;
        private GXValueField LSIDTb;
        private Label LSIDLbl;
    }
}
