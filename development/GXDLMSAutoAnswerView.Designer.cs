namespace Gurux.DLMS.UI
{
    partial class GXDLMSAutoAnswerView
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSAutoAnswerView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TimeRemoveBtn = new System.Windows.Forms.Button();
            this.TimeEditBtn = new System.Windows.Forms.Button();
            this.TimeAddBtn = new System.Windows.Forms.Button();
            this.RingCountOutOfWindowTB = new System.Windows.Forms.TextBox();
            this.RingCountInWindowTB = new System.Windows.Forms.TextBox();
            this.RingCountOutOfWindowLbl = new System.Windows.Forms.Label();
            this.RingCountInWindowLbl = new System.Windows.Forms.Label();
            this.ListeningWindowLV = new System.Windows.Forms.ListView();
            this.StartTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListeningWindowLbl = new System.Windows.Forms.Label();
            this.NumberOfCallsLbl = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.ModeLbl = new System.Windows.Forms.Label();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.NumberOfCallsTB = new Gurux.DLMS.UI.GXValueField();
            this.StatusTB = new Gurux.DLMS.UI.GXValueField();
            this.ModeTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox1.SuspendLayout();
            this.TimeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TimeRemoveBtn);
            this.groupBox1.Controls.Add(this.TimeEditBtn);
            this.groupBox1.Controls.Add(this.TimeAddBtn);
            this.groupBox1.Controls.Add(this.RingCountOutOfWindowTB);
            this.groupBox1.Controls.Add(this.RingCountInWindowTB);
            this.groupBox1.Controls.Add(this.RingCountOutOfWindowLbl);
            this.groupBox1.Controls.Add(this.RingCountInWindowLbl);
            this.groupBox1.Controls.Add(this.ListeningWindowLV);
            this.groupBox1.Controls.Add(this.ListeningWindowLbl);
            this.groupBox1.Controls.Add(this.NumberOfCallsTB);
            this.groupBox1.Controls.Add(this.NumberOfCallsLbl);
            this.groupBox1.Controls.Add(this.StatusTB);
            this.groupBox1.Controls.Add(this.StatusLbl);
            this.groupBox1.Controls.Add(this.ModeTB);
            this.groupBox1.Controls.Add(this.ModeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 342);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto Answer Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // TimeRemoveBtn
            // 
            this.TimeRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeRemoveBtn.Location = new System.Drawing.Point(265, 175);
            this.TimeRemoveBtn.Name = "TimeRemoveBtn";
            this.TimeRemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeRemoveBtn.TabIndex = 17;
            this.TimeRemoveBtn.Text = "Remove";
            this.TimeRemoveBtn.UseVisualStyleBackColor = true;
            this.TimeRemoveBtn.Click += new System.EventHandler(this.TimeRemoveBtn_Click);
            // 
            // TimeEditBtn
            // 
            this.TimeEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeEditBtn.Location = new System.Drawing.Point(184, 175);
            this.TimeEditBtn.Name = "TimeEditBtn";
            this.TimeEditBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeEditBtn.TabIndex = 16;
            this.TimeEditBtn.Text = "Edit...";
            this.TimeEditBtn.UseVisualStyleBackColor = true;
            this.TimeEditBtn.Click += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // TimeAddBtn
            // 
            this.TimeAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeAddBtn.Location = new System.Drawing.Point(103, 175);
            this.TimeAddBtn.Name = "TimeAddBtn";
            this.TimeAddBtn.Size = new System.Drawing.Size(75, 23);
            this.TimeAddBtn.TabIndex = 15;
            this.TimeAddBtn.Text = "Add...";
            this.TimeAddBtn.UseVisualStyleBackColor = true;
            this.TimeAddBtn.Click += new System.EventHandler(this.TimeAddBtn_Click);
            // 
            // RingCountOutOfWindowTB
            // 
            this.RingCountOutOfWindowTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RingCountOutOfWindowTB.Location = new System.Drawing.Point(173, 284);
            this.RingCountOutOfWindowTB.Name = "RingCountOutOfWindowTB";
            this.RingCountOutOfWindowTB.ReadOnly = true;
            this.RingCountOutOfWindowTB.Size = new System.Drawing.Size(167, 20);
            this.RingCountOutOfWindowTB.TabIndex = 14;
            // 
            // RingCountInWindowTB
            // 
            this.RingCountInWindowTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RingCountInWindowTB.Location = new System.Drawing.Point(173, 258);
            this.RingCountInWindowTB.Name = "RingCountInWindowTB";
            this.RingCountInWindowTB.ReadOnly = true;
            this.RingCountInWindowTB.Size = new System.Drawing.Size(167, 20);
            this.RingCountInWindowTB.TabIndex = 13;
            // 
            // RingCountOutOfWindowLbl
            // 
            this.RingCountOutOfWindowLbl.AutoSize = true;
            this.RingCountOutOfWindowLbl.Location = new System.Drawing.Point(6, 290);
            this.RingCountOutOfWindowLbl.Name = "RingCountOutOfWindowLbl";
            this.RingCountOutOfWindowLbl.Size = new System.Drawing.Size(139, 13);
            this.RingCountOutOfWindowLbl.TabIndex = 12;
            this.RingCountOutOfWindowLbl.Text = "Ring Count Out Of Window:";
            // 
            // RingCountInWindowLbl
            // 
            this.RingCountInWindowLbl.AutoSize = true;
            this.RingCountInWindowLbl.Location = new System.Drawing.Point(6, 261);
            this.RingCountInWindowLbl.Name = "RingCountInWindowLbl";
            this.RingCountInWindowLbl.Size = new System.Drawing.Size(117, 13);
            this.RingCountInWindowLbl.TabIndex = 11;
            this.RingCountInWindowLbl.Text = "Ring Count In Window:";
            // 
            // ListeningWindowLV
            // 
            this.ListeningWindowLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeningWindowLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StartTimeHeader,
            this.EndTimeHeader});
            this.ListeningWindowLV.ContextMenuStrip = this.TimeMenu;
            this.ListeningWindowLV.FullRowSelect = true;
            this.ListeningWindowLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListeningWindowLV.HideSelection = false;
            this.ListeningWindowLV.Location = new System.Drawing.Point(102, 73);
            this.ListeningWindowLV.Name = "ListeningWindowLV";
            this.ListeningWindowLV.Size = new System.Drawing.Size(238, 92);
            this.ListeningWindowLV.TabIndex = 10;
            this.ListeningWindowLV.UseCompatibleStateImageBehavior = false;
            this.ListeningWindowLV.View = System.Windows.Forms.View.Details;
            this.ListeningWindowLV.DoubleClick += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // StartTimeHeader
            // 
            this.StartTimeHeader.Text = "Start Time:";
            this.StartTimeHeader.Width = 100;
            // 
            // EndTimeHeader
            // 
            this.EndTimeHeader.Text = "End Time:";
            this.EndTimeHeader.Width = 129;
            // 
            // TimeMenu
            // 
            this.TimeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.TimeMenu.Name = "contextMenuStrip1";
            this.TimeMenu.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.TimeAddBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.TimeEditBtn_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.TimeRemoveBtn_Click);
            // 
            // ListeningWindowLbl
            // 
            this.ListeningWindowLbl.AutoSize = true;
            this.ListeningWindowLbl.Location = new System.Drawing.Point(6, 73);
            this.ListeningWindowLbl.Name = "ListeningWindowLbl";
            this.ListeningWindowLbl.Size = new System.Drawing.Size(94, 13);
            this.ListeningWindowLbl.TabIndex = 9;
            this.ListeningWindowLbl.Text = "Listening Window:";
            // 
            // NumberOfCallsLbl
            // 
            this.NumberOfCallsLbl.AutoSize = true;
            this.NumberOfCallsLbl.Location = new System.Drawing.Point(6, 233);
            this.NumberOfCallsLbl.Name = "NumberOfCallsLbl";
            this.NumberOfCallsLbl.Size = new System.Drawing.Size(86, 13);
            this.NumberOfCallsLbl.TabIndex = 6;
            this.NumberOfCallsLbl.Text = "Number Of Calls:";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(6, 207);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(40, 13);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Status:";
            // 
            // ModeLbl
            // 
            this.ModeLbl.AutoSize = true;
            this.ModeLbl.Location = new System.Drawing.Point(6, 50);
            this.ModeLbl.Name = "ModeLbl";
            this.ModeLbl.Size = new System.Drawing.Size(37, 13);
            this.ModeLbl.TabIndex = 2;
            this.ModeLbl.Text = "Mode:";
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
            // NumberOfCallsTB
            // 
            this.NumberOfCallsTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfCallsTB.Index = 0;
            this.NumberOfCallsTB.Location = new System.Drawing.Point(102, 230);
            this.NumberOfCallsTB.Name = "NumberOfCallsTB";
            this.NumberOfCallsTB.ReadOnly = true;
            this.NumberOfCallsTB.Size = new System.Drawing.Size(238, 20);
            this.NumberOfCallsTB.TabIndex = 7;
            this.NumberOfCallsTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // StatusTB
            // 
            this.StatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTB.Index = 4;
            this.StatusTB.Location = new System.Drawing.Point(102, 204);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(238, 20);
            this.StatusTB.TabIndex = 5;
            this.StatusTB.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // ModeTB
            // 
            this.ModeTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeTB.Index = 2;
            this.ModeTB.Location = new System.Drawing.Point(102, 47);
            this.ModeTB.Name = "ModeTB";
            this.ModeTB.ReadOnly = true;
            this.ModeTB.Size = new System.Drawing.Size(238, 20);
            this.ModeTB.TabIndex = 3;
            this.ModeTB.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.ReadOnly = true;
            this.LogicalNameTB.Size = new System.Drawing.Size(238, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // GXDLMSAutoAnswerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 366);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSAutoAnswerView";
            this.Text = "GXDLMSAutoAnswerView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TimeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GXValueField NumberOfCallsTB;
        private System.Windows.Forms.Label NumberOfCallsLbl;
        private GXValueField StatusTB;
        private System.Windows.Forms.Label StatusLbl;
        private GXValueField ModeTB;
        private System.Windows.Forms.Label ModeLbl;
        private GXValueField LogicalNameTB;
        private System.Windows.Forms.Label LogicalNameLbl;
        private System.Windows.Forms.ListView ListeningWindowLV;
        private System.Windows.Forms.ColumnHeader StartTimeHeader;
        private System.Windows.Forms.ColumnHeader EndTimeHeader;
        private System.Windows.Forms.Label ListeningWindowLbl;
        private System.Windows.Forms.TextBox RingCountOutOfWindowTB;
        private System.Windows.Forms.TextBox RingCountInWindowTB;
        private System.Windows.Forms.Label RingCountOutOfWindowLbl;
        private System.Windows.Forms.Label RingCountInWindowLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip TimeMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.Button TimeRemoveBtn;
        private System.Windows.Forms.Button TimeEditBtn;
        private System.Windows.Forms.Button TimeAddBtn;
    }
}