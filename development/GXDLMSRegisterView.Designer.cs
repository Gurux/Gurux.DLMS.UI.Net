using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSRegisterView
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
        private GXValueField ValueTB;
        private Label ValueLbl;
        private GXValueField LogicalNameTB;
        private GXValueField UnitTB;
        private Label UnitLbl;
        private GXValueField ScalerTB;
        private Label ScalerLbl;
        private ErrorProvider errorProvider1;
        private GXButton ResetBtn;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSRegisterView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.UnitTB = new Gurux.DLMS.UI.GXValueField();
            this.UnitLbl = new System.Windows.Forms.Label();
            this.ScalerTB = new Gurux.DLMS.UI.GXValueField();
            this.ScalerLbl = new System.Windows.Forms.Label();
            this.ValueTB = new Gurux.DLMS.UI.GXValueField();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.UnitTB);
            this.groupBox1.Controls.Add(this.UnitLbl);
            this.groupBox1.Controls.Add(this.ScalerTB);
            this.groupBox1.Controls.Add(this.ScalerLbl);
            this.groupBox1.Controls.Add(this.ValueTB);
            this.groupBox1.Controls.Add(this.ValueLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Object";
            //
            // ResetBtn
            //
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 1;
            this.ResetBtn.Location = new System.Drawing.Point(236, 151);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 7;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            //
            // UnitTB
            //
            this.UnitTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                  | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitTB.Index = 0;
            this.UnitTB.Location = new System.Drawing.Point(103, 123);
            this.UnitTB.Name = "UnitTB";
            this.UnitTB.ReadOnly = true;
            this.UnitTB.Size = new System.Drawing.Size(208, 20);
            this.UnitTB.TabIndex = 2;
            this.UnitTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // UnitLbl
            //
            this.UnitLbl.AutoSize = true;
            this.UnitLbl.Location = new System.Drawing.Point(7, 126);
            this.UnitLbl.Name = "UnitLbl";
            this.UnitLbl.Size = new System.Drawing.Size(29, 13);
            this.UnitLbl.TabIndex = 6;
            this.UnitLbl.Text = "Unit:";
            //
            // ScalerTB
            //
            this.ScalerTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.ScalerTB.Index = 0;
            this.ScalerTB.Location = new System.Drawing.Point(103, 97);
            this.ScalerTB.Name = "ScalerTB";
            this.ScalerTB.ReadOnly = true;
            this.ScalerTB.Size = new System.Drawing.Size(208, 20);
            this.ScalerTB.TabIndex = 1;
            this.ScalerTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ScalerLbl
            //
            this.ScalerLbl.AutoSize = true;
            this.ScalerLbl.Location = new System.Drawing.Point(7, 100);
            this.ScalerLbl.Name = "ScalerLbl";
            this.ScalerLbl.Size = new System.Drawing.Size(40, 13);
            this.ScalerLbl.TabIndex = 4;
            this.ScalerLbl.Text = "Scaler:";
            //
            // ValueTB
            //
            this.ValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueTB.Index = 2;
            this.ValueTB.Location = new System.Drawing.Point(103, 71);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(208, 20);
            this.ValueTB.TabIndex = 0;
            this.ValueTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ValueLbl
            //
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(7, 74);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(37, 13);
            this.ValueLbl.TabIndex = 2;
            this.ValueLbl.Text = "Value:";
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.ReadOnly = true;
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
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
            // DescriptionLbl
            //
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 9;
            this.DescriptionLbl.Text = "Description:";
            //
            // DescriptionTB
            //
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(103, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(208, 20);
            this.DescriptionTB.TabIndex = 8;
            //
            // GXDLMSRegisterView
            //
            this.ClientSize = new System.Drawing.Size(357, 214);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSRegisterView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
