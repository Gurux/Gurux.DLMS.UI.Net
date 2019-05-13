using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSUtilityTablesView
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
        private GXValueField TableIdTB;
        private Label TableIdLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSUtilityTablesView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.TableIdTB = new Gurux.DLMS.UI.GXValueField();
            this.TableIdLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LengthTb = new Gurux.DLMS.UI.GXValueField();
            this.LengthLbl = new System.Windows.Forms.Label();
            this.BufferTb = new Gurux.DLMS.UI.GXValueField();
            this.BufferLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BufferTb);
            this.groupBox1.Controls.Add(this.BufferLbl);
            this.groupBox1.Controls.Add(this.LengthTb);
            this.groupBox1.Controls.Add(this.LengthLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.TableIdTB);
            this.groupBox1.Controls.Add(this.TableIdLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utility Tables Object";
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
            this.DescriptionTB.Size = new System.Drawing.Size(275, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // TableIdTB
            // 
            this.TableIdTB.Index = 2;
            this.TableIdTB.Location = new System.Drawing.Point(104, 71);
            this.TableIdTB.Name = "TableIdTB";
            this.TableIdTB.NotifyChanges = false;
            this.TableIdTB.Size = new System.Drawing.Size(87, 22);
            this.TableIdTB.TabIndex = 0;
            this.TableIdTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.TableIdTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.TableIdTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // TableIdLbl
            // 
            this.TableIdLbl.AutoSize = true;
            this.TableIdLbl.Location = new System.Drawing.Point(7, 74);
            this.TableIdLbl.Name = "TableIdLbl";
            this.TableIdLbl.Size = new System.Drawing.Size(51, 13);
            this.TableIdLbl.TabIndex = 2;
            this.TableIdLbl.Text = "Table ID:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(274, 20);
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
            // LengthTb
            // 
            this.LengthTb.Index = 3;
            this.LengthTb.Location = new System.Drawing.Point(290, 72);
            this.LengthTb.Name = "LengthTb";
            this.LengthTb.NotifyChanges = false;
            this.LengthTb.Size = new System.Drawing.Size(87, 22);
            this.LengthTb.TabIndex = 6;
            this.LengthTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LengthLbl
            // 
            this.LengthLbl.AutoSize = true;
            this.LengthLbl.Location = new System.Drawing.Point(207, 74);
            this.LengthLbl.Name = "LengthLbl";
            this.LengthLbl.Size = new System.Drawing.Size(43, 13);
            this.LengthLbl.TabIndex = 7;
            this.LengthLbl.Text = "Length:";
            // 
            // BufferTb
            // 
            this.BufferTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BufferTb.Index = 4;
            this.BufferTb.Location = new System.Drawing.Point(104, 100);
            this.BufferTb.Name = "BufferTb";
            this.BufferTb.NotifyChanges = false;
            this.BufferTb.Size = new System.Drawing.Size(274, 106);
            this.BufferTb.TabIndex = 8;
            this.BufferTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // BufferLbl
            // 
            this.BufferLbl.AutoSize = true;
            this.BufferLbl.Location = new System.Drawing.Point(7, 103);
            this.BufferLbl.Name = "BufferLbl";
            this.BufferLbl.Size = new System.Drawing.Size(38, 13);
            this.BufferLbl.TabIndex = 9;
            this.BufferLbl.Text = "Buffer:";
            // 
            // GXDLMSUtilityTablesView
            // 
            this.ClientSize = new System.Drawing.Size(423, 236);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSUtilityTablesView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField BufferTb;
        private Label BufferLbl;
        private GXValueField LengthTb;
        private Label LengthLbl;
    }
}
