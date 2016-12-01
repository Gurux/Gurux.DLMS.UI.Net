using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSActionScheduleView
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
        private GroupBox groupBox2;
        private Label ScriptNameLbl;
        private TextBox ScriptNameTB;
        private Label ScriptTypeLbl;
        private TextBox ScriptTypeTB;
        private Label ScriptSelectorLbl;
        private TextBox ScriptSelectorTB;
        private ListView CallingWindowLV;
        private ColumnHeader TimeHeader;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSActionScheduleView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CallingWindowLV = new System.Windows.Forms.ListView();
            this.TimeHeader = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ScriptTypeLbl = new System.Windows.Forms.Label();
            this.ScriptTypeTB = new System.Windows.Forms.TextBox();
            this.ScriptSelectorLbl = new System.Windows.Forms.Label();
            this.ScriptSelectorTB = new System.Windows.Forms.TextBox();
            this.ScriptNameLbl = new System.Windows.Forms.Label();
            this.ScriptNameTB = new System.Windows.Forms.TextBox();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CallingWindowLV);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action Schedule Object";
            //
            // CallingWindowLV
            //
            this.CallingWindowLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                           | System.Windows.Forms.AnchorStyles.Right)));
            this.CallingWindowLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TimeHeader
        });
            this.CallingWindowLV.FullRowSelect = true;
            this.CallingWindowLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CallingWindowLV.HideSelection = false;
            this.CallingWindowLV.Location = new System.Drawing.Point(6, 174);
            this.CallingWindowLV.Name = "CallingWindowLV";
            this.CallingWindowLV.Size = new System.Drawing.Size(359, 143);
            this.CallingWindowLV.TabIndex = 9;
            this.CallingWindowLV.UseCompatibleStateImageBehavior = false;
            this.CallingWindowLV.View = System.Windows.Forms.View.Details;
            //
            // TimeHeader
            //
            this.TimeHeader.Text = "Time:";
            this.TimeHeader.Width = 339;
            //
            // groupBox2
            //
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                     | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ScriptTypeLbl);
            this.groupBox2.Controls.Add(this.ScriptTypeTB);
            this.groupBox2.Controls.Add(this.ScriptSelectorLbl);
            this.groupBox2.Controls.Add(this.ScriptSelectorTB);
            this.groupBox2.Controls.Add(this.ScriptNameLbl);
            this.groupBox2.Controls.Add(this.ScriptNameTB);
            this.groupBox2.Location = new System.Drawing.Point(1, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Executed Script";
            //
            // ScriptTypeLbl
            //
            this.ScriptTypeLbl.AutoSize = true;
            this.ScriptTypeLbl.Location = new System.Drawing.Point(6, 80);
            this.ScriptTypeLbl.Name = "ScriptTypeLbl";
            this.ScriptTypeLbl.Size = new System.Drawing.Size(64, 13);
            this.ScriptTypeLbl.TabIndex = 5;
            this.ScriptTypeLbl.Text = "Script Type:";
            //
            // ScriptTypeTB
            //
            this.ScriptTypeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptTypeTB.Location = new System.Drawing.Point(101, 80);
            this.ScriptTypeTB.Name = "ScriptTypeTB";
            this.ScriptTypeTB.Size = new System.Drawing.Size(261, 20);
            this.ScriptTypeTB.TabIndex = 4;
            //
            // ScriptSelectorLbl
            //
            this.ScriptSelectorLbl.AutoSize = true;
            this.ScriptSelectorLbl.Location = new System.Drawing.Point(6, 54);
            this.ScriptSelectorLbl.Name = "ScriptSelectorLbl";
            this.ScriptSelectorLbl.Size = new System.Drawing.Size(79, 13);
            this.ScriptSelectorLbl.TabIndex = 3;
            this.ScriptSelectorLbl.Text = "Script Selector:";
            //
            // ScriptSelectorTB
            //
            this.ScriptSelectorTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptSelectorTB.Location = new System.Drawing.Point(101, 54);
            this.ScriptSelectorTB.Name = "ScriptSelectorTB";
            this.ScriptSelectorTB.Size = new System.Drawing.Size(261, 20);
            this.ScriptSelectorTB.TabIndex = 2;
            //
            // ScriptNameLbl
            //
            this.ScriptNameLbl.AutoSize = true;
            this.ScriptNameLbl.Location = new System.Drawing.Point(6, 28);
            this.ScriptNameLbl.Name = "ScriptNameLbl";
            this.ScriptNameLbl.Size = new System.Drawing.Size(68, 13);
            this.ScriptNameLbl.TabIndex = 1;
            this.ScriptNameLbl.Text = "Script Name:";
            //
            // ScriptNameTB
            //
            this.ScriptNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptNameTB.Location = new System.Drawing.Point(101, 28);
            this.ScriptNameTB.Name = "ScriptNameTB";
            this.ScriptNameTB.Size = new System.Drawing.Size(261, 20);
            this.ScriptNameTB.TabIndex = 0;
            //
            // LogicalNameTB
            //
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(263, 20);
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
            // GXDLMSActionScheduleView
            //
            this.ClientSize = new System.Drawing.Size(412, 359);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSActionScheduleView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
