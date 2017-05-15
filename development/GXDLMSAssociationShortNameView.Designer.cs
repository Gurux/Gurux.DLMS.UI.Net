using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSAssociationShortNameView
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
        private ListView ObjectsView;
        private ColumnHeader BaseNameHeader;
        private ColumnHeader ClassIdHeader;
        private ColumnHeader VersionHeader;
        private ColumnHeader LogicalNameHeader;
        private ColumnHeader AttributeAccesssHeader;
        private ColumnHeader MethodAccessHeader;
        private ErrorProvider errorProvider1;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSAssociationShortNameView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ObjectRemoveBtn = new System.Windows.Forms.Button();
            this.ObjectEditBtn = new System.Windows.Forms.Button();
            this.ObjectAddBtn = new System.Windows.Forms.Button();
            this.ObjectsView = new System.Windows.Forms.ListView();
            this.BaseNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VersionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AttributeAccesssHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MethodAccessHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.ObjectsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.ObjectsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ObjectRemoveBtn);
            this.groupBox1.Controls.Add(this.ObjectEditBtn);
            this.groupBox1.Controls.Add(this.ObjectAddBtn);
            this.groupBox1.Controls.Add(this.ObjectsView);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Association Short Name Object";
            // 
            // ObjectRemoveBtn
            // 
            this.ObjectRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectRemoveBtn.Location = new System.Drawing.Point(448, 295);
            this.ObjectRemoveBtn.Name = "ObjectRemoveBtn";
            this.ObjectRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectRemoveBtn.TabIndex = 23;
            this.ObjectRemoveBtn.Text = "Remove";
            this.ObjectRemoveBtn.UseVisualStyleBackColor = true;
            this.ObjectRemoveBtn.Click += new System.EventHandler(this.ObjectRemoveBtn_Click);
            // 
            // ObjectEditBtn
            // 
            this.ObjectEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectEditBtn.Location = new System.Drawing.Point(367, 295);
            this.ObjectEditBtn.Name = "ObjectEditBtn";
            this.ObjectEditBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectEditBtn.TabIndex = 22;
            this.ObjectEditBtn.Text = "Edit...";
            this.ObjectEditBtn.UseVisualStyleBackColor = true;
            this.ObjectEditBtn.Click += new System.EventHandler(this.ObjectEditBtn_Click);
            // 
            // ObjectAddBtn
            // 
            this.ObjectAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectAddBtn.Location = new System.Drawing.Point(286, 295);
            this.ObjectAddBtn.Name = "ObjectAddBtn";
            this.ObjectAddBtn.Size = new System.Drawing.Size(75, 23);
            this.ObjectAddBtn.TabIndex = 21;
            this.ObjectAddBtn.Text = "Add...";
            this.ObjectAddBtn.UseVisualStyleBackColor = true;
            this.ObjectAddBtn.Click += new System.EventHandler(this.ObjectAddBtn_Click);
            // 
            // ObjectsView
            // 
            this.ObjectsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BaseNameHeader,
            this.ClassIdHeader,
            this.VersionHeader,
            this.LogicalNameHeader,
            this.AttributeAccesssHeader,
            this.MethodAccessHeader});
            this.ObjectsView.ContextMenuStrip = this.ObjectsMenu;
            this.ObjectsView.FullRowSelect = true;
            this.ObjectsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ObjectsView.HideSelection = false;
            this.ObjectsView.Location = new System.Drawing.Point(9, 47);
            this.ObjectsView.Name = "ObjectsView";
            this.ObjectsView.Size = new System.Drawing.Size(514, 242);
            this.ObjectsView.TabIndex = 9;
            this.ObjectsView.UseCompatibleStateImageBehavior = false;
            this.ObjectsView.View = System.Windows.Forms.View.Details;
            // 
            // BaseNameHeader
            // 
            this.BaseNameHeader.Text = "Base Name:";
            this.BaseNameHeader.Width = 77;
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
            this.LogicalNameHeader.Width = 84;
            // 
            // AttributeAccesssHeader
            // 
            this.AttributeAccesssHeader.Text = "Attribute Accesss";
            this.AttributeAccesssHeader.Width = 83;
            // 
            // MethodAccessHeader
            // 
            this.MethodAccessHeader.Text = "Method Access";
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
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(421, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // ObjectsMenu
            // 
            this.ObjectsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.ObjectsMenu.Name = "contextMenuStrip1";
            this.ObjectsMenu.Size = new System.Drawing.Size(153, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.ObjectAddBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.ObjectEditBtn_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.ObjectRemoveBtn_Click);
            // 
            // GXDLMSAssociationShortNameView
            // 
            this.ClientSize = new System.Drawing.Size(570, 348);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSAssociationShortNameView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ObjectsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button ObjectRemoveBtn;
        private Button ObjectEditBtn;
        private Button ObjectAddBtn;
        private ContextMenuStrip ObjectsMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}
