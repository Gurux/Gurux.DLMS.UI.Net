using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSExtendedRegisterView
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
        private GXValueField CaptureTimeTB;
        private Label CaptureTimeLbl;
        private GXValueField StatusTB;
        private Label StatusLbl;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSExtendedRegisterView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaptureTimeTB = new Gurux.DLMS.UI.GXValueField();
            this.CaptureTimeLbl = new System.Windows.Forms.Label();
            this.StatusTB = new Gurux.DLMS.UI.GXValueField();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.UnitTB = new Gurux.DLMS.UI.GXValueField();
            this.UnitLbl = new System.Windows.Forms.Label();
            this.ScalerTB = new Gurux.DLMS.UI.GXValueField();
            this.ScalerLbl = new System.Windows.Forms.Label();
            this.ValueTB = new Gurux.DLMS.UI.GXValueField();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CaptureTimeTB);
            this.groupBox1.Controls.Add(this.CaptureTimeLbl);
            this.groupBox1.Controls.Add(this.StatusTB);
            this.groupBox1.Controls.Add(this.StatusLbl);
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
            this.groupBox1.Size = new System.Drawing.Size(333, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extended Register Object";
            //
            // CaptureTimeTB
            //
            this.CaptureTimeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureTimeTB.Index = 5;
            this.CaptureTimeTB.Location = new System.Drawing.Point(102, 151);
            this.CaptureTimeTB.Name = "CaptureTimeTB";
            this.CaptureTimeTB.Size = new System.Drawing.Size(208, 20);
            this.CaptureTimeTB.TabIndex = 2;
            this.CaptureTimeTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // CaptureTimeLbl
            //
            this.CaptureTimeLbl.AutoSize = true;
            this.CaptureTimeLbl.Location = new System.Drawing.Point(6, 154);
            this.CaptureTimeLbl.Name = "CaptureTimeLbl";
            this.CaptureTimeLbl.Size = new System.Drawing.Size(73, 13);
            this.CaptureTimeLbl.TabIndex = 10;
            this.CaptureTimeLbl.Text = "Capture Time:";
            //
            // StatusTB
            //
            this.StatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                    | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTB.Index = 4;
            this.StatusTB.Location = new System.Drawing.Point(102, 125);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.Size = new System.Drawing.Size(208, 20);
            this.StatusTB.TabIndex = 1;
            this.StatusTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // StatusLbl
            //
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(6, 128);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(40, 13);
            this.StatusLbl.TabIndex = 8;
            this.StatusLbl.Text = "Status:";
            //
            // UnitTB
            //
            this.UnitTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                  | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitTB.Index = 0;
            this.UnitTB.Location = new System.Drawing.Point(102, 99);
            this.UnitTB.Name = "UnitTB";
            this.UnitTB.Size = new System.Drawing.Size(208, 20);
            this.UnitTB.TabIndex = 5;
            this.UnitTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // UnitLbl
            //
            this.UnitLbl.AutoSize = true;
            this.UnitLbl.Location = new System.Drawing.Point(6, 102);
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
            this.ScalerTB.Location = new System.Drawing.Point(102, 73);
            this.ScalerTB.Name = "ScalerTB";
            this.ScalerTB.Size = new System.Drawing.Size(208, 20);
            this.ScalerTB.TabIndex = 4;
            this.ScalerTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ScalerLbl
            //
            this.ScalerLbl.AutoSize = true;
            this.ScalerLbl.Location = new System.Drawing.Point(6, 76);
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
            this.ValueTB.Location = new System.Drawing.Point(102, 47);
            this.ValueTB.Name = "ValueTB";
            this.ValueTB.Size = new System.Drawing.Size(208, 20);
            this.ValueTB.TabIndex = 0;
            this.ValueTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ValueLbl
            //
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Location = new System.Drawing.Point(6, 50);
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
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(208, 20);
            this.LogicalNameTB.TabIndex = 3;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
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
            // GXDLMSExtendedRegisterView
            //
            this.ClientSize = new System.Drawing.Size(357, 216);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSExtendedRegisterView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
