using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSRegisterMonitorView
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
        private Label ThresholdsLbl;
        private TextBox ThresholdsTB;
        private GroupBox MonitoredValueGB;
        private Label ClassIDLbl;
        private TextBox ClassIDTB;
        private Label AttributeIndexLbl;
        private TextBox AttributeIndexTB;
        private Label MLogicalNameLbl;
        private TextBox MLogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private ListView ActionsLV;
        private ColumnHeader ActionUpLogicalNameHeader;
        private ColumnHeader ActionUpScriptSelectoHeader;
        private ColumnHeader ActionDownLogicalNameHeader;
        private ColumnHeader ActionDownScriptSelectoHeader;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSRegisterMonitorView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.MonitoredValueGB = new System.Windows.Forms.GroupBox();
            this.AttributeIndexLbl = new System.Windows.Forms.Label();
            this.AttributeIndexTB = new System.Windows.Forms.TextBox();
            this.MLogicalNameLbl = new System.Windows.Forms.Label();
            this.MLogicalNameTB = new System.Windows.Forms.TextBox();
            this.ClassIDLbl = new System.Windows.Forms.Label();
            this.ClassIDTB = new System.Windows.Forms.TextBox();
            this.ThresholdsLbl = new System.Windows.Forms.Label();
            this.ThresholdsTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActionsLV = new System.Windows.Forms.ListView();
            this.ActionUpLogicalNameHeader = new System.Windows.Forms.ColumnHeader();
            this.ActionUpScriptSelectoHeader = new System.Windows.Forms.ColumnHeader();
            this.ActionDownLogicalNameHeader = new System.Windows.Forms.ColumnHeader();
            this.ActionDownScriptSelectoHeader = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.MonitoredValueGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ActionsLV);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.MonitoredValueGB);
            this.groupBox1.Controls.Add(this.ThresholdsLbl);
            this.groupBox1.Controls.Add(this.ThresholdsTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Monitor Object";
            //
            // DescriptionLbl
            //
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(8, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 11;
            this.DescriptionLbl.Text = "Description:";
            //
            // DescriptionTB
            //
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(104, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(329, 20);
            this.DescriptionTB.TabIndex = 10;
            //
            // MonitoredValueGB
            //
            this.MonitoredValueGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.MonitoredValueGB.Controls.Add(this.AttributeIndexLbl);
            this.MonitoredValueGB.Controls.Add(this.AttributeIndexTB);
            this.MonitoredValueGB.Controls.Add(this.MLogicalNameLbl);
            this.MonitoredValueGB.Controls.Add(this.MLogicalNameTB);
            this.MonitoredValueGB.Controls.Add(this.ClassIDLbl);
            this.MonitoredValueGB.Controls.Add(this.ClassIDTB);
            this.MonitoredValueGB.Location = new System.Drawing.Point(0, 148);
            this.MonitoredValueGB.Name = "MonitoredValueGB";
            this.MonitoredValueGB.Size = new System.Drawing.Size(433, 100);
            this.MonitoredValueGB.TabIndex = 7;
            this.MonitoredValueGB.TabStop = false;
            this.MonitoredValueGB.Text = "Monitored Value";
            //
            // AttributeIndexLbl
            //
            this.AttributeIndexLbl.AutoSize = true;
            this.AttributeIndexLbl.Location = new System.Drawing.Point(6, 78);
            this.AttributeIndexLbl.Name = "AttributeIndexLbl";
            this.AttributeIndexLbl.Size = new System.Drawing.Size(78, 13);
            this.AttributeIndexLbl.TabIndex = 12;
            this.AttributeIndexLbl.Text = "Attribute Index:";
            //
            // AttributeIndexTB
            //
            this.AttributeIndexTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttributeIndexTB.Location = new System.Drawing.Point(102, 75);
            this.AttributeIndexTB.Name = "AttributeIndexTB";
            this.AttributeIndexTB.Size = new System.Drawing.Size(325, 20);
            this.AttributeIndexTB.TabIndex = 11;
            //
            // MLogicalNameLbl
            //
            this.MLogicalNameLbl.AutoSize = true;
            this.MLogicalNameLbl.Location = new System.Drawing.Point(6, 52);
            this.MLogicalNameLbl.Name = "MLogicalNameLbl";
            this.MLogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.MLogicalNameLbl.TabIndex = 10;
            this.MLogicalNameLbl.Text = "Logical Name:";
            //
            // MLogicalNameTB
            //
            this.MLogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                          | System.Windows.Forms.AnchorStyles.Right)));
            this.MLogicalNameTB.Location = new System.Drawing.Point(102, 49);
            this.MLogicalNameTB.Name = "MLogicalNameTB";
            this.MLogicalNameTB.Size = new System.Drawing.Size(325, 20);
            this.MLogicalNameTB.TabIndex = 9;
            //
            // ClassIDLbl
            //
            this.ClassIDLbl.AutoSize = true;
            this.ClassIDLbl.Location = new System.Drawing.Point(6, 26);
            this.ClassIDLbl.Name = "ClassIDLbl";
            this.ClassIDLbl.Size = new System.Drawing.Size(49, 13);
            this.ClassIDLbl.TabIndex = 8;
            this.ClassIDLbl.Text = "Class ID:";
            //
            // ClassIDTB
            //
            this.ClassIDTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassIDTB.Location = new System.Drawing.Point(102, 23);
            this.ClassIDTB.Name = "ClassIDTB";
            this.ClassIDTB.Size = new System.Drawing.Size(325, 20);
            this.ClassIDTB.TabIndex = 7;
            //
            // ThresholdsLbl
            //
            this.ThresholdsLbl.AutoSize = true;
            this.ThresholdsLbl.Location = new System.Drawing.Point(6, 75);
            this.ThresholdsLbl.Name = "ThresholdsLbl";
            this.ThresholdsLbl.Size = new System.Drawing.Size(62, 13);
            this.ThresholdsLbl.TabIndex = 4;
            this.ThresholdsLbl.Text = "Thresholds:";
            //
            // ThresholdsTB
            //
            this.ThresholdsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ThresholdsTB.Location = new System.Drawing.Point(102, 72);
            this.ThresholdsTB.Multiline = true;
            this.ThresholdsTB.Name = "ThresholdsTB";
            this.ThresholdsTB.ReadOnly = true;
            this.ThresholdsTB.Size = new System.Drawing.Size(331, 70);
            this.ThresholdsTB.TabIndex = 3;
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(331, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // LogicalNameLbl
            //
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(6, 48);
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
            // ActionsLV
            //
            this.ActionsLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                     | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ActionUpLogicalNameHeader,
            this.ActionUpScriptSelectoHeader,
            this.ActionDownLogicalNameHeader,
            this.ActionDownScriptSelectoHeader
        });
            this.ActionsLV.FullRowSelect = true;
            this.ActionsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActionsLV.HideSelection = false;
            this.ActionsLV.Location = new System.Drawing.Point(11, 254);
            this.ActionsLV.Name = "ActionsLV";
            this.ActionsLV.Size = new System.Drawing.Size(416, 98);
            this.ActionsLV.TabIndex = 12;
            this.ActionsLV.UseCompatibleStateImageBehavior = false;
            this.ActionsLV.View = System.Windows.Forms.View.Details;
            //
            // ActionUpLogicalNameHeader
            //
            this.ActionUpLogicalNameHeader.Text = "Up LogicalName:";
            this.ActionUpLogicalNameHeader.Width = 96;
            //
            // ActionUpScriptSelectoHeader
            //
            this.ActionUpScriptSelectoHeader.Text = "Up Script Selector:";
            this.ActionUpScriptSelectoHeader.Width = 104;
            //
            // ActionDownLogicalNameHeader
            //
            this.ActionDownLogicalNameHeader.Text = "Down LogicalName:";
            this.ActionDownLogicalNameHeader.Width = 106;
            //
            // ActionDownScriptSelectoHeader
            //
            this.ActionDownScriptSelectoHeader.Text = "Down Script Selector:";
            this.ActionDownScriptSelectoHeader.Width = 106;
            //
            // GXDLMSRegisterMonitorView
            //
            this.ClientSize = new System.Drawing.Size(463, 391);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSRegisterMonitorView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.MonitoredValueGB.ResumeLayout(false);
            this.MonitoredValueGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
