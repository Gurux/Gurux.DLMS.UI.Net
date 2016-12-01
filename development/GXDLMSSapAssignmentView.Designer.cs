using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSSapAssignmentView
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
        private ListView CallingWindowLV;
        private ColumnHeader SapAddressHeader;
        private ColumnHeader LogicalDeviceNameHeader;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSSapAssignmentView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CallingWindowLV = new System.Windows.Forms.ListView();
            this.SapAddressHeader = new System.Windows.Forms.ColumnHeader();
            this.LogicalDeviceNameHeader = new System.Windows.Forms.ColumnHeader();
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
            this.groupBox1.Controls.Add(this.CallingWindowLV);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SAP Assignment Object";
            //
            // CallingWindowLV
            //
            this.CallingWindowLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                           | System.Windows.Forms.AnchorStyles.Left)
                                           | System.Windows.Forms.AnchorStyles.Right)));
            this.CallingWindowLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SapAddressHeader,
            this.LogicalDeviceNameHeader
        });
            this.CallingWindowLV.FullRowSelect = true;
            this.CallingWindowLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CallingWindowLV.HideSelection = false;
            this.CallingWindowLV.Location = new System.Drawing.Point(9, 47);
            this.CallingWindowLV.Name = "CallingWindowLV";
            this.CallingWindowLV.Size = new System.Drawing.Size(264, 182);
            this.CallingWindowLV.TabIndex = 9;
            this.CallingWindowLV.UseCompatibleStateImageBehavior = false;
            this.CallingWindowLV.View = System.Windows.Forms.View.Details;
            //
            // SapAddressHeader
            //
            this.SapAddressHeader.Text = "SAP address:";
            this.SapAddressHeader.Width = 81;
            //
            // LogicalDeviceNameHeader
            //
            this.LogicalDeviceNameHeader.Text = "Logical Device Name:";
            this.LogicalDeviceNameHeader.Width = 175;
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(171, 20);
            this.LogicalNameTB.TabIndex = 1;
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
            // GXDLMSSapAssignmentView
            //
            this.ClientSize = new System.Drawing.Size(320, 259);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSSapAssignmentView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
