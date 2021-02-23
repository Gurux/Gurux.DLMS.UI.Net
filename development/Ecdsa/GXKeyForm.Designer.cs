namespace Gurux.DLMS.UI.Ecdsa
{
    partial class GXKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXKeyForm));
            this.KeyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GenerateKeyMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyAddMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyRenameMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.GetCertificateMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.KeyRemoveMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.KeyList = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KeyCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileNameCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InfoMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.KeyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyMenu
            // 
            this.KeyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateKeyMnu,
            this.KeyAddMnu,
            this.KeyRenameMnu,
            this.GetCertificateMnu,
            this.InfoMnu,
            this.toolStripMenuItem2,
            this.KeyRemoveMnu});
            this.KeyMenu.Name = "contextMenuStrip1";
            this.KeyMenu.Size = new System.Drawing.Size(159, 142);
            this.KeyMenu.Opening += new System.ComponentModel.CancelEventHandler(this.KeyMenu_Opening);
            // 
            // GenerateKeyMnu
            // 
            this.GenerateKeyMnu.Name = "GenerateKeyMnu";
            this.GenerateKeyMnu.Size = new System.Drawing.Size(180, 22);
            this.GenerateKeyMnu.Text = "Generate...";
            this.GenerateKeyMnu.Click += new System.EventHandler(this.GenerateKeyMnu_Click);
            // 
            // KeyAddMnu
            // 
            this.KeyAddMnu.Name = "KeyAddMnu";
            this.KeyAddMnu.Size = new System.Drawing.Size(180, 22);
            this.KeyAddMnu.Text = "Add..";
            this.KeyAddMnu.Click += new System.EventHandler(this.KeyAddMnu_Click);
            // 
            // KeyRenameMnu
            // 
            this.KeyRenameMnu.Name = "KeyRenameMnu";
            this.KeyRenameMnu.Size = new System.Drawing.Size(180, 22);
            this.KeyRenameMnu.Text = "Rename...";
            this.KeyRenameMnu.Click += new System.EventHandler(this.KeyRenameMnu_Click);
            // 
            // GetCertificateMnu
            // 
            this.GetCertificateMnu.Name = "GetCertificateMnu";
            this.GetCertificateMnu.Size = new System.Drawing.Size(180, 22);
            this.GetCertificateMnu.Text = "Get Certificate...";
            this.GetCertificateMnu.Click += new System.EventHandler(this.GetCertificateMnu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // KeyRemoveMnu
            // 
            this.KeyRemoveMnu.Name = "KeyRemoveMnu";
            this.KeyRemoveMnu.Size = new System.Drawing.Size(180, 22);
            this.KeyRemoveMnu.Text = "Remove";
            this.KeyRemoveMnu.Click += new System.EventHandler(this.KeyRemoveMnu_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "publicKey.png");
            this.imageList1.Images.SetKeyName(1, "privateKey.png");
            // 
            // KeyList
            // 
            this.KeyList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.KeyCh,
            this.FileNameCh});
            this.KeyList.ContextMenuStrip = this.KeyMenu;
            this.KeyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyList.FullRowSelect = true;
            this.KeyList.HideSelection = false;
            this.KeyList.Location = new System.Drawing.Point(0, 0);
            this.KeyList.Name = "KeyList";
            this.KeyList.Size = new System.Drawing.Size(800, 450);
            this.KeyList.SmallImageList = this.imageList1;
            this.KeyList.TabIndex = 26;
            this.KeyList.UseCompatibleStateImageBehavior = false;
            this.KeyList.View = System.Windows.Forms.View.Details;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // KeyCh
            // 
            this.KeyCh.Text = "Key";
            this.KeyCh.Width = 236;
            // 
            // FileNameCh
            // 
            this.FileNameCh.Text = "File name";
            this.FileNameCh.Width = 183;
            // 
            // InfoMnu
            // 
            this.InfoMnu.Name = "InfoMnu";
            this.InfoMnu.Size = new System.Drawing.Size(180, 22);
            this.InfoMnu.Text = "Info...";
            this.InfoMnu.Click += new System.EventHandler(this.InfoMnu_Click);
            // 
            // GXKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.KeyList);
            this.Name = "GXKeyForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GXKeyForm";
            this.KeyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip KeyMenu;
        private System.Windows.Forms.ToolStripMenuItem GenerateKeyMnu;
        private System.Windows.Forms.ToolStripMenuItem KeyAddMnu;
        private System.Windows.Forms.ToolStripMenuItem KeyRemoveMnu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView KeyList;
        private System.Windows.Forms.ColumnHeader KeyCh;
        private System.Windows.Forms.ColumnHeader FileNameCh;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ToolStripMenuItem KeyRenameMnu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem GetCertificateMnu;
        private System.Windows.Forms.ToolStripMenuItem InfoMnu;
    }
}