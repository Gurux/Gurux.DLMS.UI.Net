using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSCompactDataView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSCompactDataView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BufferLbl = new System.Windows.Forms.Label();
            this.TemplateIdLbl = new System.Windows.Forms.Label();
            this.TemplateDescriptionLbl = new System.Windows.Forms.Label();
            this.CaptureMethodLbl = new System.Windows.Forms.Label();
            this.CaptureBtn = new Gurux.DLMS.UI.GXButton();
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.CaptureMethodTb = new Gurux.DLMS.UI.GXValueField();
            this.TemplateDescriptionTb = new Gurux.DLMS.UI.GXValueField();
            this.TemplateIdTb = new Gurux.DLMS.UI.GXValueField();
            this.BufferTb = new Gurux.DLMS.UI.GXValueField();
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
            this.groupBox1.Controls.Add(this.CaptureBtn);
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.CaptureMethodTb);
            this.groupBox1.Controls.Add(this.CaptureMethodLbl);
            this.groupBox1.Controls.Add(this.TemplateDescriptionTb);
            this.groupBox1.Controls.Add(this.TemplateDescriptionLbl);
            this.groupBox1.Controls.Add(this.TemplateIdTb);
            this.groupBox1.Controls.Add(this.TemplateIdLbl);
            this.groupBox1.Controls.Add(this.BufferTb);
            this.groupBox1.Controls.Add(this.BufferLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compact Data";
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
            // BufferLbl
            // 
            this.BufferLbl.AutoSize = true;
            this.BufferLbl.Location = new System.Drawing.Point(8, 74);
            this.BufferLbl.Name = "BufferLbl";
            this.BufferLbl.Size = new System.Drawing.Size(38, 13);
            this.BufferLbl.TabIndex = 6;
            this.BufferLbl.Text = "Buffer:";
            // 
            // TemplateIdLbl
            // 
            this.TemplateIdLbl.AutoSize = true;
            this.TemplateIdLbl.Location = new System.Drawing.Point(7, 100);
            this.TemplateIdLbl.Name = "TemplateIdLbl";
            this.TemplateIdLbl.Size = new System.Drawing.Size(68, 13);
            this.TemplateIdLbl.TabIndex = 8;
            this.TemplateIdLbl.Text = "Template ID:";
            // 
            // TemplateDescriptionLbl
            // 
            this.TemplateDescriptionLbl.AutoSize = true;
            this.TemplateDescriptionLbl.Location = new System.Drawing.Point(8, 126);
            this.TemplateDescriptionLbl.Name = "TemplateDescriptionLbl";
            this.TemplateDescriptionLbl.Size = new System.Drawing.Size(110, 13);
            this.TemplateDescriptionLbl.TabIndex = 10;
            this.TemplateDescriptionLbl.Text = "Template Description:";
            // 
            // CaptureMethodLbl
            // 
            this.CaptureMethodLbl.AutoSize = true;
            this.CaptureMethodLbl.Location = new System.Drawing.Point(8, 152);
            this.CaptureMethodLbl.Name = "CaptureMethodLbl";
            this.CaptureMethodLbl.Size = new System.Drawing.Size(86, 13);
            this.CaptureMethodLbl.TabIndex = 12;
            this.CaptureMethodLbl.Text = "Capture Method:";
            // 
            // CaptureBtn
            // 
            this.CaptureBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureBtn.Index = 2;
            this.CaptureBtn.Location = new System.Drawing.Point(202, 192);
            this.CaptureBtn.Name = "CaptureBtn";
            this.CaptureBtn.Size = new System.Drawing.Size(72, 23);
            this.CaptureBtn.TabIndex = 15;
            this.CaptureBtn.Text = "Capture";
            this.CaptureBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 1;
            this.ResetBtn.Location = new System.Drawing.Point(124, 192);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(72, 23);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // CaptureMethodTb
            // 
            this.CaptureMethodTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureMethodTb.Index = 6;
            this.CaptureMethodTb.Location = new System.Drawing.Point(104, 149);
            this.CaptureMethodTb.Name = "CaptureMethodTb";
            this.CaptureMethodTb.NotifyChanges = false;
            this.CaptureMethodTb.ReadOnly = true;
            this.CaptureMethodTb.Size = new System.Drawing.Size(171, 73);
            this.CaptureMethodTb.TabIndex = 13;
            this.CaptureMethodTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // TemplateDescriptionTb
            // 
            this.TemplateDescriptionTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateDescriptionTb.Index = 5;
            this.TemplateDescriptionTb.Location = new System.Drawing.Point(104, 123);
            this.TemplateDescriptionTb.Name = "TemplateDescriptionTb";
            this.TemplateDescriptionTb.NotifyChanges = false;
            this.TemplateDescriptionTb.Size = new System.Drawing.Size(171, 20);
            this.TemplateDescriptionTb.TabIndex = 11;
            this.TemplateDescriptionTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TemplateIdTb
            // 
            this.TemplateIdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplateIdTb.Index = 4;
            this.TemplateIdTb.Location = new System.Drawing.Point(103, 97);
            this.TemplateIdTb.Name = "TemplateIdTb";
            this.TemplateIdTb.NotifyChanges = false;
            this.TemplateIdTb.Size = new System.Drawing.Size(171, 20);
            this.TemplateIdTb.TabIndex = 9;
            this.TemplateIdTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // BufferTb
            // 
            this.BufferTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BufferTb.Index = 2;
            this.BufferTb.Location = new System.Drawing.Point(104, 71);
            this.BufferTb.Name = "BufferTb";
            this.BufferTb.NotifyChanges = false;
            this.BufferTb.Size = new System.Drawing.Size(171, 20);
            this.BufferTb.TabIndex = 7;
            this.BufferTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
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
            // GXDLMSCompactDataView
            // 
            this.ClientSize = new System.Drawing.Size(320, 376);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSCompactDataView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField CaptureMethodTb;
        private Label CaptureMethodLbl;
        private GXValueField TemplateDescriptionTb;
        private Label TemplateDescriptionLbl;
        private GXValueField TemplateIdTb;
        private Label TemplateIdLbl;
        private GXValueField BufferTb;
        private Label BufferLbl;
        private GXButton CaptureBtn;
        private GXButton ResetBtn;
    }
}
