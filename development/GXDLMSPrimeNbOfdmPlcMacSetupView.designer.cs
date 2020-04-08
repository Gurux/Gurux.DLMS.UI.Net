using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSPrimeNbOfdmPlcMacSetupView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSPrimeNbOfdmPlcMacSetupView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CRCIncorrectCountTb = new Gurux.DLMS.UI.GXValueField();
            this.CRCIncorrectCountLbl = new System.Windows.Forms.Label();
            this.gxValueField1 = new Gurux.DLMS.UI.GXValueField();
            this.label1 = new System.Windows.Forms.Label();
            this.gxValueField2 = new Gurux.DLMS.UI.GXValueField();
            this.label2 = new System.Windows.Forms.Label();
            this.gxValueField3 = new Gurux.DLMS.UI.GXValueField();
            this.label3 = new System.Windows.Forms.Label();
            this.gxValueField4 = new Gurux.DLMS.UI.GXValueField();
            this.label4 = new System.Windows.Forms.Label();
            this.gxValueField5 = new Gurux.DLMS.UI.GXValueField();
            this.label5 = new System.Windows.Forms.Label();
            this.gxValueField6 = new Gurux.DLMS.UI.GXValueField();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gxValueField6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gxValueField5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.gxValueField4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gxValueField3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.gxValueField2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gxValueField1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CRCIncorrectCountTb);
            this.groupBox1.Controls.Add(this.CRCIncorrectCountLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 252);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRIME NB OFDM PLC MAC setup Object";
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
            this.DescriptionTB.Location = new System.Drawing.Point(139, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(160, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(139, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(159, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.LogicalNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.LogicalNameTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
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
            // CRCIncorrectCountTb
            // 
            this.CRCIncorrectCountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CRCIncorrectCountTb.Index = 2;
            this.CRCIncorrectCountTb.Location = new System.Drawing.Point(140, 71);
            this.CRCIncorrectCountTb.Name = "CRCIncorrectCountTb";
            this.CRCIncorrectCountTb.NotifyChanges = false;
            this.CRCIncorrectCountTb.Size = new System.Drawing.Size(159, 20);
            this.CRCIncorrectCountTb.TabIndex = 8;
            this.CRCIncorrectCountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CRCIncorrectCountTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CRCIncorrectCountTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CRCIncorrectCountLbl
            // 
            this.CRCIncorrectCountLbl.AutoSize = true;
            this.CRCIncorrectCountLbl.Location = new System.Drawing.Point(8, 74);
            this.CRCIncorrectCountLbl.Name = "CRCIncorrectCountLbl";
            this.CRCIncorrectCountLbl.Size = new System.Drawing.Size(125, 13);
            this.CRCIncorrectCountLbl.TabIndex = 7;
            this.CRCIncorrectCountLbl.Text = "Min Switch Search Time:";
            // 
            // gxValueField1
            // 
            this.gxValueField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField1.Index = 3;
            this.gxValueField1.Location = new System.Drawing.Point(140, 97);
            this.gxValueField1.Name = "gxValueField1";
            this.gxValueField1.NotifyChanges = false;
            this.gxValueField1.Size = new System.Drawing.Size(159, 20);
            this.gxValueField1.TabIndex = 10;
            this.gxValueField1.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.gxValueField1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.gxValueField1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Max Promotion PDU:";
            // 
            // gxValueField2
            // 
            this.gxValueField2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField2.Index = 4;
            this.gxValueField2.Location = new System.Drawing.Point(140, 123);
            this.gxValueField2.Name = "gxValueField2";
            this.gxValueField2.NotifyChanges = false;
            this.gxValueField2.Size = new System.Drawing.Size(159, 20);
            this.gxValueField2.TabIndex = 12;
            this.gxValueField2.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.gxValueField2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.gxValueField2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Promotion PDU TX Period:";
            // 
            // gxValueField3
            // 
            this.gxValueField3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField3.Index = 5;
            this.gxValueField3.Location = new System.Drawing.Point(140, 149);
            this.gxValueField3.Name = "gxValueField3";
            this.gxValueField3.NotifyChanges = false;
            this.gxValueField3.Size = new System.Drawing.Size(159, 20);
            this.gxValueField3.TabIndex = 14;
            this.gxValueField3.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.gxValueField3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.gxValueField3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Beacons Per Frame:";
            // 
            // gxValueField4
            // 
            this.gxValueField4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField4.Index = 6;
            this.gxValueField4.Location = new System.Drawing.Point(139, 175);
            this.gxValueField4.Name = "gxValueField4";
            this.gxValueField4.NotifyChanges = false;
            this.gxValueField4.Size = new System.Drawing.Size(159, 20);
            this.gxValueField4.TabIndex = 16;
            this.gxValueField4.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.gxValueField4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.gxValueField4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "SCP Max TX Attemps:";
            // 
            // gxValueField5
            // 
            this.gxValueField5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField5.Index = 7;
            this.gxValueField5.Location = new System.Drawing.Point(139, 201);
            this.gxValueField5.Name = "gxValueField5";
            this.gxValueField5.NotifyChanges = false;
            this.gxValueField5.Size = new System.Drawing.Size(159, 20);
            this.gxValueField5.TabIndex = 18;
            this.gxValueField5.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.gxValueField5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.gxValueField5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "CLT Re TX Timer:";
            // 
            // gxValueField6
            // 
            this.gxValueField6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField6.Index = 8;
            this.gxValueField6.Location = new System.Drawing.Point(140, 226);
            this.gxValueField6.Name = "gxValueField6";
            this.gxValueField6.NotifyChanges = false;
            this.gxValueField6.Size = new System.Drawing.Size(159, 20);
            this.gxValueField6.TabIndex = 20;
            this.gxValueField6.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.gxValueField6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.gxValueField6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Max Ctl Re Tx:";
            // 
            // GXDLMSPrimeNbOfdmPlcMacSetupView
            // 
            this.ClientSize = new System.Drawing.Size(344, 276);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSPrimeNbOfdmPlcMacSetupView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField gxValueField5;
        private Label label5;
        private GXValueField gxValueField4;
        private Label label4;
        private GXValueField gxValueField3;
        private Label label3;
        private GXValueField gxValueField2;
        private Label label2;
        private GXValueField gxValueField1;
        private Label label1;
        private GXValueField CRCIncorrectCountTb;
        private Label CRCIncorrectCountLbl;
        private GXValueField gxValueField6;
        private Label label6;
    }
}
