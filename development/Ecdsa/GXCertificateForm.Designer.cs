namespace Gurux.DLMS.UI.Ecdsa
{
    partial class GXCertificateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXCertificateForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CertificateMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.CopySystemTitleMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.openContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.CertificatesList = new System.Windows.Forms.ListView();
            this.TypeCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialNumberCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValidityCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyUsageCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CertificateMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "publicKey.png");
            this.imageList1.Images.SetKeyName(1, "privateKey.png");
            // 
            // CertificateMenu
            // 
            this.CertificateMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMnu,
            this.GenerateMnu,
            this.RenameMnu,
            this.descriptionToolStripMenuItem,
            this.InfoMnu,
            this.CopySystemTitleMnu,
            this.openContainingFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.RemoveMnu});
            this.CertificateMenu.Name = "contextMenuStrip1";
            this.CertificateMenu.Size = new System.Drawing.Size(202, 208);
            this.CertificateMenu.Opening += new System.ComponentModel.CancelEventHandler(this.CertificateMenu_Opening);
            // 
            // AddMnu
            // 
            this.AddMnu.Name = "AddMnu";
            this.AddMnu.Size = new System.Drawing.Size(201, 22);
            this.AddMnu.Text = "Add..";
            this.AddMnu.Click += new System.EventHandler(this.CertificateAddMnu_Click);
            // 
            // GenerateMnu
            // 
            this.GenerateMnu.Name = "GenerateMnu";
            this.GenerateMnu.Size = new System.Drawing.Size(201, 22);
            this.GenerateMnu.Text = "Generate...";
            this.GenerateMnu.Click += new System.EventHandler(this.GenerateMnu_Click);
            // 
            // RenameMnu
            // 
            this.RenameMnu.Name = "RenameMnu";
            this.RenameMnu.Size = new System.Drawing.Size(201, 22);
            this.RenameMnu.Text = "Rename";
            this.RenameMnu.Click += new System.EventHandler(this.RenameMnu_Click);
            // 
            // InfoMnu
            // 
            this.InfoMnu.Name = "InfoMnu";
            this.InfoMnu.Size = new System.Drawing.Size(201, 22);
            this.InfoMnu.Text = "Info...";
            this.InfoMnu.Click += new System.EventHandler(this.InfoMnu_Click);
            // 
            // CopySystemTitleMnu
            // 
            this.CopySystemTitleMnu.Name = "CopySystemTitleMnu";
            this.CopySystemTitleMnu.Size = new System.Drawing.Size(201, 22);
            this.CopySystemTitleMnu.Text = "Copy System Title";
            this.CopySystemTitleMnu.Click += new System.EventHandler(this.CopySystemTitleMnu_Click);
            // 
            // openContainingFolderToolStripMenuItem
            // 
            this.openContainingFolderToolStripMenuItem.Name = "openContainingFolderToolStripMenuItem";
            this.openContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.openContainingFolderToolStripMenuItem.Text = "Open Containing Folder";
            this.openContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.openContainingFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // RemoveMnu
            // 
            this.RemoveMnu.Name = "RemoveMnu";
            this.RemoveMnu.Size = new System.Drawing.Size(201, 22);
            this.RemoveMnu.Text = "Remove";
            this.RemoveMnu.Click += new System.EventHandler(this.CertificateRemoveMnu_Click);
            // 
            // CertificatesList
            // 
            this.CertificatesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TypeCh,
            this.SerialNumberCh,
            this.SubjectCh,
            this.ValidityCh,
            this.KeyUsageCh,
            this.FileNameCh,
            this.DescriptionCh});
            this.CertificatesList.ContextMenuStrip = this.CertificateMenu;
            this.CertificatesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CertificatesList.FullRowSelect = true;
            this.CertificatesList.HideSelection = false;
            this.CertificatesList.Location = new System.Drawing.Point(0, 0);
            this.CertificatesList.Name = "CertificatesList";
            this.CertificatesList.Size = new System.Drawing.Size(800, 450);
            this.CertificatesList.SmallImageList = this.imageList1;
            this.CertificatesList.TabIndex = 25;
            this.CertificatesList.UseCompatibleStateImageBehavior = false;
            this.CertificatesList.View = System.Windows.Forms.View.Details;
            // 
            // TypeCh
            // 
            this.TypeCh.Text = "Type";
            this.TypeCh.Width = 72;
            // 
            // SerialNumberCh
            // 
            this.SerialNumberCh.Text = "Serial Number";
            this.SerialNumberCh.Width = 101;
            // 
            // SubjectCh
            // 
            this.SubjectCh.Text = "Subject";
            this.SubjectCh.Width = 115;
            // 
            // ValidityCh
            // 
            this.ValidityCh.Text = "Validity";
            this.ValidityCh.Width = 161;
            // 
            // KeyUsageCh
            // 
            this.KeyUsageCh.Text = "Key Usage";
            this.KeyUsageCh.Width = 127;
            // 
            // FileNameCh
            // 
            this.FileNameCh.Text = "File name";
            // 
            // DescriptionCh
            // 
            this.DescriptionCh.Text = "Description";
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.descriptionToolStripMenuItem.Text = "Description...";
            this.descriptionToolStripMenuItem.Click += new System.EventHandler(this.descriptionToolStripMenuItem_Click);
            // 
            // GXCertificateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.CertificatesList);
            this.Name = "GXCertificateForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GXCertificateForm";
            this.CertificateMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip CertificateMenu;
        private System.Windows.Forms.ToolStripMenuItem AddMnu;
        private System.Windows.Forms.ToolStripMenuItem RemoveMnu;
        private System.Windows.Forms.ListView CertificatesList;
        private System.Windows.Forms.ColumnHeader TypeCh;
        private System.Windows.Forms.ColumnHeader SubjectCh;
        private System.Windows.Forms.ColumnHeader ValidityCh;
        private System.Windows.Forms.ColumnHeader KeyUsageCh;
        private System.Windows.Forms.ToolStripMenuItem GenerateMnu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ColumnHeader FileNameCh;
        private System.Windows.Forms.ToolStripMenuItem RenameMnu;
        private System.Windows.Forms.ToolStripMenuItem InfoMnu;
        private System.Windows.Forms.ToolStripMenuItem CopySystemTitleMnu;
        private System.Windows.Forms.ColumnHeader SerialNumberCh;
        private System.Windows.Forms.ToolStripMenuItem openContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader DescriptionCh;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
    }
}