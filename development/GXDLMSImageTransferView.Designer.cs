using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSImageTransferView
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
        private GXValueField ImageBlockSizeTB;
        private Label ImageBlockSizeLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private GXValueField ImageTransferredBlocksStatusTB;
        private Label ImageTransferredBlocksStatusLbl;
        private GXValueField ImageFirstNotTransferredBlockNumberTB;
        private Label ImageFirstNotTransferredBlockNumberLbl;
        private CheckBox ImageTransferEnabledCB;
        private Label ImageTransferEnabledLbl;
        private GXValueField ImageTransferStatusCB;
        private Label ImageTransferStatusLbl;
        private GXValueField ImageActivateInfoTB;
        private Label ImageActivateInfoLbl;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSImageTransferView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImageTransferStatusCB = new Gurux.DLMS.UI.GXValueField();
            this.ImageTransferStatusLbl = new System.Windows.Forms.Label();
            this.ImageTransferEnabledCB = new System.Windows.Forms.CheckBox();
            this.ImageTransferEnabledLbl = new System.Windows.Forms.Label();
            this.ImageFirstNotTransferredBlockNumberTB = new Gurux.DLMS.UI.GXValueField();
            this.ImageFirstNotTransferredBlockNumberLbl = new System.Windows.Forms.Label();
            this.ImageTransferredBlocksStatusTB = new Gurux.DLMS.UI.GXValueField();
            this.ImageTransferredBlocksStatusLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.ImageBlockSizeTB = new Gurux.DLMS.UI.GXValueField();
            this.ImageBlockSizeLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ImageActivateInfoTB = new Gurux.DLMS.UI.GXValueField();
            this.ImageActivateInfoLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ImageActivateInfoTB);
            this.groupBox1.Controls.Add(this.ImageActivateInfoLbl);
            this.groupBox1.Controls.Add(this.ImageTransferStatusCB);
            this.groupBox1.Controls.Add(this.ImageTransferStatusLbl);
            this.groupBox1.Controls.Add(this.ImageTransferEnabledCB);
            this.groupBox1.Controls.Add(this.ImageTransferEnabledLbl);
            this.groupBox1.Controls.Add(this.ImageFirstNotTransferredBlockNumberTB);
            this.groupBox1.Controls.Add(this.ImageFirstNotTransferredBlockNumberLbl);
            this.groupBox1.Controls.Add(this.ImageTransferredBlocksStatusTB);
            this.groupBox1.Controls.Add(this.ImageTransferredBlocksStatusLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.ImageBlockSizeTB);
            this.groupBox1.Controls.Add(this.ImageBlockSizeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Transfer Object";
            //
            // ImageTransferStatusCB
            //
            this.ImageTransferStatusCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                 | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageTransferStatusCB.Index = 6;
            this.ImageTransferStatusCB.Location = new System.Drawing.Point(104, 171);
            this.ImageTransferStatusCB.Name = "ImageTransferStatusCB";
            this.ImageTransferStatusCB.ReadOnly = true;
            this.ImageTransferStatusCB.Size = new System.Drawing.Size(171, 59);
            this.ImageTransferStatusCB.TabIndex = 19;
            this.ImageTransferStatusCB.Type = Gurux.DLMS.UI.GXValueFieldType.CompoBox;
            //
            // ImageTransferStatusLbl
            //
            this.ImageTransferStatusLbl.AutoSize = true;
            this.ImageTransferStatusLbl.Location = new System.Drawing.Point(7, 174);
            this.ImageTransferStatusLbl.Name = "ImageTransferStatusLbl";
            this.ImageTransferStatusLbl.Size = new System.Drawing.Size(40, 13);
            this.ImageTransferStatusLbl.TabIndex = 20;
            this.ImageTransferStatusLbl.Text = "Status:";
            //
            // ImageTransferEnabledCB
            //
            this.ImageTransferEnabledCB.Checked = true;
            this.ImageTransferEnabledCB.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.ImageTransferEnabledCB.Location = new System.Drawing.Point(104, 148);
            this.ImageTransferEnabledCB.Name = "ImageTransferEnabledCB";
            this.ImageTransferEnabledCB.Size = new System.Drawing.Size(27, 17);
            this.ImageTransferEnabledCB.TabIndex = 17;
            this.ImageTransferEnabledCB.UseVisualStyleBackColor = false;
            //
            // ImageTransferEnabledLbl
            //
            this.ImageTransferEnabledLbl.AutoSize = true;
            this.ImageTransferEnabledLbl.Location = new System.Drawing.Point(7, 149);
            this.ImageTransferEnabledLbl.Name = "ImageTransferEnabledLbl";
            this.ImageTransferEnabledLbl.Size = new System.Drawing.Size(49, 13);
            this.ImageTransferEnabledLbl.TabIndex = 18;
            this.ImageTransferEnabledLbl.Text = "Enabled:";
            //
            // ImageFirstNotTransferredBlockNumberTB
            //
            this.ImageFirstNotTransferredBlockNumberTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageFirstNotTransferredBlockNumberTB.Index = 4;
            this.ImageFirstNotTransferredBlockNumberTB.Location = new System.Drawing.Point(104, 123);
            this.ImageFirstNotTransferredBlockNumberTB.Name = "ImageFirstNotTransferredBlockNumberTB";
            this.ImageFirstNotTransferredBlockNumberTB.Size = new System.Drawing.Size(171, 20);
            this.ImageFirstNotTransferredBlockNumberTB.TabIndex = 8;
            this.ImageFirstNotTransferredBlockNumberTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ImageFirstNotTransferredBlockNumberLbl
            //
            this.ImageFirstNotTransferredBlockNumberLbl.AutoSize = true;
            this.ImageFirstNotTransferredBlockNumberLbl.Location = new System.Drawing.Point(7, 126);
            this.ImageFirstNotTransferredBlockNumberLbl.Name = "ImageFirstNotTransferredBlockNumberLbl";
            this.ImageFirstNotTransferredBlockNumberLbl.Size = new System.Drawing.Size(59, 13);
            this.ImageFirstNotTransferredBlockNumberLbl.TabIndex = 9;
            this.ImageFirstNotTransferredBlockNumberLbl.Text = "First Block:";
            //
            // ImageTransferredBlocksStatusTB
            //
            this.ImageTransferredBlocksStatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageTransferredBlocksStatusTB.Index = 3;
            this.ImageTransferredBlocksStatusTB.Location = new System.Drawing.Point(104, 97);
            this.ImageTransferredBlocksStatusTB.Name = "ImageTransferredBlocksStatusTB";
            this.ImageTransferredBlocksStatusTB.Size = new System.Drawing.Size(171, 20);
            this.ImageTransferredBlocksStatusTB.TabIndex = 6;
            this.ImageTransferredBlocksStatusTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ImageTransferredBlocksStatusLbl
            //
            this.ImageTransferredBlocksStatusLbl.AutoSize = true;
            this.ImageTransferredBlocksStatusLbl.Location = new System.Drawing.Point(7, 100);
            this.ImageTransferredBlocksStatusLbl.Name = "ImageTransferredBlocksStatusLbl";
            this.ImageTransferredBlocksStatusLbl.Size = new System.Drawing.Size(75, 13);
            this.ImageTransferredBlocksStatusLbl.TabIndex = 7;
            this.ImageTransferredBlocksStatusLbl.Text = "Blocks Status:";
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
            this.DescriptionTB.TabIndex = 4;
            //
            // ImageBlockSizeTB
            //
            this.ImageBlockSizeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBlockSizeTB.Index = 2;
            this.ImageBlockSizeTB.Location = new System.Drawing.Point(104, 71);
            this.ImageBlockSizeTB.Name = "ImageBlockSizeTB";
            this.ImageBlockSizeTB.Size = new System.Drawing.Size(171, 20);
            this.ImageBlockSizeTB.TabIndex = 0;
            this.ImageBlockSizeTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            this.ImageBlockSizeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.ImageBlockSizeTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            //
            // ImageBlockSizeLbl
            //
            this.ImageBlockSizeLbl.AutoSize = true;
            this.ImageBlockSizeLbl.Location = new System.Drawing.Point(7, 74);
            this.ImageBlockSizeLbl.Name = "ImageBlockSizeLbl";
            this.ImageBlockSizeLbl.Size = new System.Drawing.Size(92, 13);
            this.ImageBlockSizeLbl.TabIndex = 2;
            this.ImageBlockSizeLbl.Text = "Image Block Size:";
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(171, 20);
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
            // ImageActivateInfoTB
            //
            this.ImageActivateInfoTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                               | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageActivateInfoTB.Index = 7;
            this.ImageActivateInfoTB.Location = new System.Drawing.Point(103, 200);
            this.ImageActivateInfoTB.Name = "ImageActivateInfoTB";
            this.ImageActivateInfoTB.Size = new System.Drawing.Size(171, 20);
            this.ImageActivateInfoTB.TabIndex = 21;
            this.ImageActivateInfoTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            //
            // ImageActivateInfoLbl
            //
            this.ImageActivateInfoLbl.AutoSize = true;
            this.ImageActivateInfoLbl.Location = new System.Drawing.Point(6, 203);
            this.ImageActivateInfoLbl.Name = "ImageActivateInfoLbl";
            this.ImageActivateInfoLbl.Size = new System.Drawing.Size(59, 13);
            this.ImageActivateInfoLbl.TabIndex = 22;
            this.ImageActivateInfoLbl.Text = "First Block:";
            //
            // GXDLMSImageTransferView
            //
            this.ClientSize = new System.Drawing.Size(320, 275);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSImageTransferView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
