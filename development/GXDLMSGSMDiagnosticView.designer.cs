namespace Gurux.DLMS.UI
{
    partial class GXDLMSGSMDiagnosticView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSGSMDiagnosticView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CaptureTimeTb = new Gurux.DLMS.UI.GXValueField();
            this.CaptureTimeLbl = new System.Windows.Forms.Label();
            this.CellInfoCb = new System.Windows.Forms.GroupBox();
            this.BerTb = new System.Windows.Forms.TextBox();
            this.SignalQualityTb = new System.Windows.Forms.TextBox();
            this.BerLbl = new System.Windows.Forms.Label();
            this.SignalQualityLbl = new System.Windows.Forms.Label();
            this.LocationIDTb = new System.Windows.Forms.TextBox();
            this.CellIDTb = new System.Windows.Forms.TextBox();
            this.LocationIDLbl = new System.Windows.Forms.Label();
            this.CellIDLbl = new System.Windows.Forms.Label();
            this.PSStatusTb = new Gurux.DLMS.UI.GXValueField();
            this.PSStatusLbl = new System.Windows.Forms.Label();
            this.OperatorTb = new Gurux.DLMS.UI.GXValueField();
            this.OperatorLbl = new System.Windows.Forms.Label();
            this.AdjacentCellsLV = new System.Windows.Forms.ListView();
            this.CellIdCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SignalQualityCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdjacentCellsLbl = new System.Windows.Forms.Label();
            this.StatusTB = new Gurux.DLMS.UI.GXValueField();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.CSAttachmentTb = new Gurux.DLMS.UI.GXValueField();
            this.CSAttachmentLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.CellInfoCb.SuspendLayout();
            this.TimeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CaptureTimeTb);
            this.groupBox1.Controls.Add(this.CaptureTimeLbl);
            this.groupBox1.Controls.Add(this.CellInfoCb);
            this.groupBox1.Controls.Add(this.PSStatusTb);
            this.groupBox1.Controls.Add(this.PSStatusLbl);
            this.groupBox1.Controls.Add(this.OperatorTb);
            this.groupBox1.Controls.Add(this.OperatorLbl);
            this.groupBox1.Controls.Add(this.AdjacentCellsLV);
            this.groupBox1.Controls.Add(this.AdjacentCellsLbl);
            this.groupBox1.Controls.Add(this.StatusTB);
            this.groupBox1.Controls.Add(this.StatusLbl);
            this.groupBox1.Controls.Add(this.CSAttachmentTb);
            this.groupBox1.Controls.Add(this.CSAttachmentLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 419);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GSM diagnostic Object";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // CaptureTimeTb
            // 
            this.CaptureTimeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaptureTimeTb.Index = 8;
            this.CaptureTimeTb.Location = new System.Drawing.Point(102, 383);
            this.CaptureTimeTb.Name = "CaptureTimeTb";
            this.CaptureTimeTb.NotifyChanges = false;
            this.CaptureTimeTb.ReadOnly = true;
            this.CaptureTimeTb.Size = new System.Drawing.Size(238, 20);
            this.CaptureTimeTb.TabIndex = 19;
            this.CaptureTimeTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // CaptureTimeLbl
            // 
            this.CaptureTimeLbl.AutoSize = true;
            this.CaptureTimeLbl.Location = new System.Drawing.Point(7, 386);
            this.CaptureTimeLbl.Name = "CaptureTimeLbl";
            this.CaptureTimeLbl.Size = new System.Drawing.Size(73, 13);
            this.CaptureTimeLbl.TabIndex = 18;
            this.CaptureTimeLbl.Text = "Capture Time:";
            // 
            // CellInfoCb
            // 
            this.CellInfoCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellInfoCb.Controls.Add(this.BerTb);
            this.CellInfoCb.Controls.Add(this.SignalQualityTb);
            this.CellInfoCb.Controls.Add(this.BerLbl);
            this.CellInfoCb.Controls.Add(this.SignalQualityLbl);
            this.CellInfoCb.Controls.Add(this.LocationIDTb);
            this.CellInfoCb.Controls.Add(this.CellIDTb);
            this.CellInfoCb.Controls.Add(this.LocationIDLbl);
            this.CellInfoCb.Controls.Add(this.CellIDLbl);
            this.CellInfoCb.Location = new System.Drawing.Point(0, 151);
            this.CellInfoCb.Name = "CellInfoCb";
            this.CellInfoCb.Size = new System.Drawing.Size(357, 128);
            this.CellInfoCb.TabIndex = 17;
            this.CellInfoCb.TabStop = false;
            this.CellInfoCb.Text = "Cell Info";
            // 
            // BerTb
            // 
            this.BerTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BerTb.Location = new System.Drawing.Point(103, 96);
            this.BerTb.Name = "BerTb";
            this.BerTb.ReadOnly = true;
            this.BerTb.Size = new System.Drawing.Size(238, 20);
            this.BerTb.TabIndex = 22;
            // 
            // SignalQualityTb
            // 
            this.SignalQualityTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignalQualityTb.Location = new System.Drawing.Point(103, 70);
            this.SignalQualityTb.Name = "SignalQualityTb";
            this.SignalQualityTb.ReadOnly = true;
            this.SignalQualityTb.Size = new System.Drawing.Size(239, 20);
            this.SignalQualityTb.TabIndex = 21;
            // 
            // BerLbl
            // 
            this.BerLbl.AutoSize = true;
            this.BerLbl.Location = new System.Drawing.Point(7, 100);
            this.BerLbl.Name = "BerLbl";
            this.BerLbl.Size = new System.Drawing.Size(32, 13);
            this.BerLbl.TabIndex = 20;
            this.BerLbl.Text = "BER:";
            // 
            // SignalQualityLbl
            // 
            this.SignalQualityLbl.AutoSize = true;
            this.SignalQualityLbl.Location = new System.Drawing.Point(7, 73);
            this.SignalQualityLbl.Name = "SignalQualityLbl";
            this.SignalQualityLbl.Size = new System.Drawing.Size(74, 13);
            this.SignalQualityLbl.TabIndex = 19;
            this.SignalQualityLbl.Text = "Signal Quality:";
            // 
            // LocationIDTb
            // 
            this.LocationIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LocationIDTb.Location = new System.Drawing.Point(102, 43);
            this.LocationIDTb.Name = "LocationIDTb";
            this.LocationIDTb.ReadOnly = true;
            this.LocationIDTb.Size = new System.Drawing.Size(238, 20);
            this.LocationIDTb.TabIndex = 18;
            // 
            // CellIDTb
            // 
            this.CellIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CellIDTb.Location = new System.Drawing.Point(102, 17);
            this.CellIDTb.Name = "CellIDTb";
            this.CellIDTb.ReadOnly = true;
            this.CellIDTb.Size = new System.Drawing.Size(239, 20);
            this.CellIDTb.TabIndex = 17;
            // 
            // LocationIDLbl
            // 
            this.LocationIDLbl.AutoSize = true;
            this.LocationIDLbl.Location = new System.Drawing.Point(6, 46);
            this.LocationIDLbl.Name = "LocationIDLbl";
            this.LocationIDLbl.Size = new System.Drawing.Size(65, 13);
            this.LocationIDLbl.TabIndex = 16;
            this.LocationIDLbl.Text = "Location ID:";
            // 
            // CellIDLbl
            // 
            this.CellIDLbl.AutoSize = true;
            this.CellIDLbl.Location = new System.Drawing.Point(6, 19);
            this.CellIDLbl.Name = "CellIDLbl";
            this.CellIDLbl.Size = new System.Drawing.Size(41, 13);
            this.CellIDLbl.TabIndex = 15;
            this.CellIDLbl.Text = "Cell ID:";
            // 
            // PSStatusTb
            // 
            this.PSStatusTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSStatusTb.Index = 5;
            this.PSStatusTb.Location = new System.Drawing.Point(103, 127);
            this.PSStatusTb.Name = "PSStatusTb";
            this.PSStatusTb.NotifyChanges = false;
            this.PSStatusTb.ReadOnly = true;
            this.PSStatusTb.Size = new System.Drawing.Size(238, 20);
            this.PSStatusTb.TabIndex = 16;
            this.PSStatusTb.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // PSStatusLbl
            // 
            this.PSStatusLbl.AutoSize = true;
            this.PSStatusLbl.Location = new System.Drawing.Point(7, 130);
            this.PSStatusLbl.Name = "PSStatusLbl";
            this.PSStatusLbl.Size = new System.Drawing.Size(57, 13);
            this.PSStatusLbl.TabIndex = 15;
            this.PSStatusLbl.Text = "PS Status:";
            // 
            // OperatorTb
            // 
            this.OperatorTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OperatorTb.Index = 2;
            this.OperatorTb.Location = new System.Drawing.Point(102, 49);
            this.OperatorTb.Name = "OperatorTb";
            this.OperatorTb.NotifyChanges = false;
            this.OperatorTb.ReadOnly = true;
            this.OperatorTb.Size = new System.Drawing.Size(238, 20);
            this.OperatorTb.TabIndex = 7;
            this.OperatorTb.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
            // 
            // OperatorLbl
            // 
            this.OperatorLbl.AutoSize = true;
            this.OperatorLbl.Location = new System.Drawing.Point(7, 52);
            this.OperatorLbl.Name = "OperatorLbl";
            this.OperatorLbl.Size = new System.Drawing.Size(48, 13);
            this.OperatorLbl.TabIndex = 6;
            this.OperatorLbl.Text = "Operator";
            // 
            // AdjacentCellsLV
            // 
            this.AdjacentCellsLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdjacentCellsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CellIdCh,
            this.SignalQualityCh});
            this.AdjacentCellsLV.ContextMenuStrip = this.TimeMenu;
            this.AdjacentCellsLV.FullRowSelect = true;
            this.AdjacentCellsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AdjacentCellsLV.HideSelection = false;
            this.AdjacentCellsLV.Location = new System.Drawing.Point(102, 285);
            this.AdjacentCellsLV.Name = "AdjacentCellsLV";
            this.AdjacentCellsLV.Size = new System.Drawing.Size(238, 92);
            this.AdjacentCellsLV.TabIndex = 10;
            this.AdjacentCellsLV.UseCompatibleStateImageBehavior = false;
            this.AdjacentCellsLV.View = System.Windows.Forms.View.Details;
            // 
            // CellIdCh
            // 
            this.CellIdCh.Text = "Cell ID:";
            this.CellIdCh.Width = 100;
            // 
            // SignalQualityCh
            // 
            this.SignalQualityCh.Text = "Signal Quality:";
            this.SignalQualityCh.Width = 129;
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
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // AdjacentCellsLbl
            // 
            this.AdjacentCellsLbl.AutoSize = true;
            this.AdjacentCellsLbl.Location = new System.Drawing.Point(6, 285);
            this.AdjacentCellsLbl.Name = "AdjacentCellsLbl";
            this.AdjacentCellsLbl.Size = new System.Drawing.Size(94, 13);
            this.AdjacentCellsLbl.TabIndex = 9;
            this.AdjacentCellsLbl.Text = "Listening Window:";
            // 
            // StatusTB
            // 
            this.StatusTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTB.Index = 3;
            this.StatusTB.Location = new System.Drawing.Point(102, 75);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.NotifyChanges = false;
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(238, 20);
            this.StatusTB.TabIndex = 5;
            this.StatusTB.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(7, 78);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(40, 13);
            this.StatusLbl.TabIndex = 4;
            this.StatusLbl.Text = "Status:";
            // 
            // CSAttachmentTb
            // 
            this.CSAttachmentTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CSAttachmentTb.Index = 4;
            this.CSAttachmentTb.Location = new System.Drawing.Point(102, 101);
            this.CSAttachmentTb.Name = "CSAttachmentTb";
            this.CSAttachmentTb.NotifyChanges = false;
            this.CSAttachmentTb.ReadOnly = true;
            this.CSAttachmentTb.Size = new System.Drawing.Size(238, 20);
            this.CSAttachmentTb.TabIndex = 3;
            this.CSAttachmentTb.Type = Gurux.DLMS.UI.ValueFieldType.CompoBox;
            // 
            // CSAttachmentLbl
            // 
            this.CSAttachmentLbl.AutoSize = true;
            this.CSAttachmentLbl.Location = new System.Drawing.Point(6, 104);
            this.CSAttachmentLbl.Name = "CSAttachmentLbl";
            this.CSAttachmentLbl.Size = new System.Drawing.Size(81, 13);
            this.CSAttachmentLbl.TabIndex = 2;
            this.CSAttachmentLbl.Text = "CS Attachment:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(102, 21);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.ReadOnly = true;
            this.LogicalNameTB.Size = new System.Drawing.Size(238, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.ValueFieldType.TextBox;
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
            // GXDLMSGSMDiagnosticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 446);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSGSMDiagnosticView";
            this.Text = "GXDLMSGSMDiagnostic";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CellInfoCb.ResumeLayout(false);
            this.CellInfoCb.PerformLayout();
            this.TimeMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private GXValueField OperatorTb;
        private System.Windows.Forms.Label OperatorLbl;
        private GXValueField StatusTB;
        private System.Windows.Forms.Label StatusLbl;
        private GXValueField CSAttachmentTb;
        private System.Windows.Forms.Label CSAttachmentLbl;
        private GXValueField LogicalNameTB;
        private System.Windows.Forms.Label LogicalNameLbl;
        private System.Windows.Forms.ListView AdjacentCellsLV;
        private System.Windows.Forms.ColumnHeader CellIdCh;
        private System.Windows.Forms.ColumnHeader SignalQualityCh;
        private System.Windows.Forms.Label AdjacentCellsLbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip TimeMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.GroupBox CellInfoCb;
        private GXValueField PSStatusTb;
        private System.Windows.Forms.Label PSStatusLbl;
        private System.Windows.Forms.TextBox BerTb;
        private System.Windows.Forms.TextBox SignalQualityTb;
        private System.Windows.Forms.Label BerLbl;
        private System.Windows.Forms.Label SignalQualityLbl;
        private System.Windows.Forms.TextBox LocationIDTb;
        private System.Windows.Forms.TextBox CellIDTb;
        private System.Windows.Forms.Label LocationIDLbl;
        private System.Windows.Forms.Label CellIDLbl;
        private GXValueField CaptureTimeTb;
        private System.Windows.Forms.Label CaptureTimeLbl;
    }
}