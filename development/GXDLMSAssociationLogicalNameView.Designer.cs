using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
	public partial class GXDLMSAssociationLogicalNameView
	{
		#region Windows Form Designer generated code
		private GroupBox groupBox1;
private GXValueField LogicalNameTB;
private ListView CallingWindowLV;
private ColumnHeader ClassIdHeader;
private ColumnHeader VersionHeader;
private ColumnHeader LogicalNameHeader;
private ColumnHeader AttributeAccesssHeader;
private ColumnHeader MethodAccessHeader;
private GXValueField gxValueField1;
private Label label1;
private ErrorProvider errorProvider1;
private GXValueField SecretTB;
private Label SecretLbl;
private Label LogicalNameLbl;

		private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSAssociationLogicalNameView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gxValueField1 = new Gurux.DLMS.UI.GXValueField();
            this.label1 = new System.Windows.Forms.Label();
            this.CallingWindowLV = new System.Windows.Forms.ListView();
            this.ClassIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeAccesssHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MethodAccessHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SecretTB = new Gurux.DLMS.UI.GXValueField();
            this.SecretLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SecretTB);
            this.groupBox1.Controls.Add(this.SecretLbl);
            this.groupBox1.Controls.Add(this.gxValueField1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CallingWindowLV);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Association Logical  Name Object";
            // 
            // gxValueField1
            // 
            this.gxValueField1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gxValueField1.Index = 8;
            this.gxValueField1.Location = new System.Drawing.Point(102, 47);
            this.gxValueField1.Name = "gxValueField1";
            this.gxValueField1.Size = new System.Drawing.Size(390, 20);
            this.gxValueField1.TabIndex = 11;
            this.gxValueField1.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Association Status:";
            // 
            // CallingWindowLV
            // 
            this.CallingWindowLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CallingWindowLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassIdHeader,
            this.VersionHeader,
            this.LogicalNameHeader,
            this.AttributeAccesssHeader,
            this.MethodAccessHeader});
            this.CallingWindowLV.FullRowSelect = true;
            this.CallingWindowLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.CallingWindowLV.HideSelection = false;
            this.CallingWindowLV.Location = new System.Drawing.Point(9, 103);
            this.CallingWindowLV.Name = "CallingWindowLV";
            this.CallingWindowLV.Size = new System.Drawing.Size(483, 215);
            this.CallingWindowLV.TabIndex = 9;
            this.CallingWindowLV.UseCompatibleStateImageBehavior = false;
            this.CallingWindowLV.View = System.Windows.Forms.View.Details;
            // 
            // ClassIdHeader
            // 
            this.ClassIdHeader.Text = "Class ID:";
            this.ClassIdHeader.Width = 105;
            // 
            // VersionHeader
            // 
            this.VersionHeader.Text = "Version:";
            // 
            // LogicalNameHeader
            // 
            this.LogicalNameHeader.Text = "Logical Name:";
            this.LogicalNameHeader.Width = 106;
            // 
            // AttributeAccesssHeader
            // 
            this.AttributeAccesssHeader.Text = "Acctibute Access:";
            this.AttributeAccesssHeader.Width = 106;
            // 
            // MethodAccessHeader
            // 
            this.MethodAccessHeader.Text = "Method Access:";
            this.MethodAccessHeader.Width = 97;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(390, 20);
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
            // SecretTB
            // 
            this.SecretTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecretTB.Index = 7;
            this.SecretTB.Location = new System.Drawing.Point(102, 73);
            this.SecretTB.Name = "SecretTB";
            this.SecretTB.ReadOnly = true;
            this.SecretTB.Size = new System.Drawing.Size(390, 20);
            this.SecretTB.TabIndex = 13;
            this.SecretTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // SecretLbl
            // 
            this.SecretLbl.AutoSize = true;
            this.SecretLbl.Location = new System.Drawing.Point(6, 76);
            this.SecretLbl.Name = "SecretLbl";
            this.SecretLbl.Size = new System.Drawing.Size(41, 13);
            this.SecretLbl.TabIndex = 12;
            this.SecretLbl.Text = "Secret:";
            // 
            // GXDLMSAssociationLogicalNameView
            // 
            this.ClientSize = new System.Drawing.Size(539, 348);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSAssociationLogicalNameView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		
	}
}
