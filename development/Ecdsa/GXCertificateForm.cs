using Gurux.DLMS.ASN;
using Gurux.DLMS.ASN.Enums;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{
    public partial class GXCertificateForm : Form, IGXUpdater
    {
        private readonly IGXUpdater _updater;
        private string _path;
        private readonly string CertificateFolder;
        private readonly string Title;
        private readonly string _address;
        internal GXx509CertificateCollection Certificates
        {
            get;
            private set;
        }

        Hashtable keys = new Hashtable();
        //List of duplicate public keys.
        Hashtable duplicate = new Hashtable();

        private void AddCertificate(GXx509Certificate cert, string path, string st)
        {
            ListViewItem li = new ListViewItem(cert.PublicKey.Scheme.ToString());
            string tmp = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(cert.Subject));
            tmp += ((int)cert.KeyUsage).ToString();
            object tmp2 = keys[tmp];
            //Show duplicate certificates.
            if (tmp2 == null)
            {
                keys[tmp] = cert.KeyUsage;
                duplicate[tmp] = li;
            }
            else
            {
                ((ListViewItem)duplicate[tmp]).BackColor = Color.Yellow;
                li.BackColor = Color.Yellow;
            }
            li.StateImageIndex = li.ImageIndex = 0;
            li.SubItems.Add(cert.SerialNumber.ToString());
            li.SubItems.Add(cert.Subject);
            li.SubItems.Add(cert.ValidFrom + "-" + cert.ValidTo);
            StringBuilder sb = new StringBuilder();
            foreach (KeyUsage it in Enum.GetValues(typeof(KeyUsage)))
            {
                if (((int)it & (int)cert.KeyUsage) != 0)
                {
                    sb.Append(it);
                    sb.Append(", ");
                }
            }
            if (sb.Length != 0)
            {
                sb.Length -= 2;
            }
            li.SubItems.Add(sb.ToString());
            li.SubItems.Add(Path.GetFileNameWithoutExtension(path));
            li.SubItems.Add(cert.Description);
            CertificatesList.Items.Add(li);
            li.Tag = path;
            if (st != null && cert.Subject.Contains(st))
            {
                li.Selected = true;
            }
            Certificates.Add(cert);
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="certificateFolder"></param>
        /// <param name="title"></param>
        /// <param name="systemTitle">If system title is not null this certificate is selected.</param>
        public GXCertificateForm(IGXUpdater updater, string address, string certificateFolder, string title, byte[] systemTitle)
        {
            InitializeComponent();
            _updater = updater;
            _address = address;
            string st = null;
            if (systemTitle != null && systemTitle.Length == 8)
            {
                st = GXAsn1Converter.SystemTitleToSubject(systemTitle);
            }

            Certificates = new GXx509CertificateCollection();
            CertificateFolder = certificateFolder;
            Title = title;
            foreach (string p in Directory.GetFiles(CertificateFolder))
            {
                string ext = Path.GetExtension(p);
                if (string.Compare(ext, ".pem", true) == 0 || string.Compare(ext, ".cer", true) == 0)
                {
                    try
                    {
                        GXx509Certificate cert = GXx509Certificate.Load(p);
                        AddCertificate(cert, p, st);
                    }
                    catch (Exception ex)
                    {
                        ListViewItem li = new ListViewItem(new string[] { ex.Message, "", "", "", "", Path.GetFileNameWithoutExtension(p) });
                        li.Tag = p;
                        li.BackColor = Color.Red;
                        CertificatesList.Items.Add(li);
                    }
                }
            }
        }

        /// <summary>
        /// Refresh certificates.
        /// </summary>
        public void RefreshCertificates()
        {
            CertificatesList.Items.Clear();
            Certificates.Clear();
            keys.Clear();
            duplicate.Clear();
            foreach (string p in Directory.GetFiles(CertificateFolder))
            {
                string ext = Path.GetExtension(p);
                if (string.Compare(ext, ".pem", true) == 0 || string.Compare(ext, ".cer", true) == 0)
                {
                    try
                    {
                        GXx509Certificate cert = GXx509Certificate.Load(p);
                        AddCertificate(cert, p, null);
                    }
                    catch (Exception ex)
                    {
                        ListViewItem li = new ListViewItem(new string[] { ex.Message, "", "", "", "", Path.GetFileNameWithoutExtension(p) });
                        li.Tag = p;
                        li.BackColor = Color.Red;
                        CertificatesList.Items.Add(li);
                    }
                }
            }
        }

        /// <summary>
        /// Add new certificate.
        /// </summary>
        private void CertificateAddMnu_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = true;
                if (string.IsNullOrEmpty(_path))
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                }
                else
                {
                    System.IO.FileInfo fi = new System.IO.FileInfo(_path);
                    dlg.InitialDirectory = fi.DirectoryName;
                    dlg.FileName = fi.Name;
                }
                dlg.Filter = Properties.Resources.PemFilterTxt;
                dlg.DefaultExt = ".pem";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    foreach (string fileName in dlg.FileNames)
                    {
                        try
                        {
                            _path = fileName;
                            if (File.Exists(fileName))
                            {
                                GXx509Certificate cert = GXx509Certificate.Load(fileName);
                                foreach (ListViewItem it in CertificatesList.Items)
                                {
                                    if (it.SubItems[1].Text == cert.SerialNumber.ToString())
                                    {
                                        throw new Exception("Certificate already exists for the meter." + cert.Subject +
                                            ". File name:" + Path.GetFileNameWithoutExtension((string)it.Tag));
                                    }
                                }
                                string path = Path.Combine(CertificateFolder, Path.GetFileName(fileName));
                                cert.Save(path);
                                AddCertificate(cert, path, null);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(Parent, ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Remove selected certificates.
        /// </summary>
        private void CertificateRemoveMnu_Click(object sender, EventArgs e)
        {
            try
            {
                if (CertificatesList.SelectedItems.Count != 0)
                {
                    DialogResult ret = MessageBox.Show(Parent, Properties.Resources.CertificateRemove, Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (ret != DialogResult.Yes)
                    {
                        return;
                    }
                    while (CertificatesList.SelectedItems.Count != 0)
                    {
                        ListViewItem it = CertificatesList.SelectedItems[0];
                        foreach (GXx509Certificate c in Certificates)
                        {
                            if (c.SerialNumber.ToString() == it.SubItems[1].Text)
                            {
                                Certificates.Remove(c);
                                break;
                            }
                        }
                        File.Delete((string)it.Tag);
                        it.Remove();
                    }
                    RefreshCertificates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void CertificateMenu_Opening(object sender, CancelEventArgs e)
        {
            InfoMnu.Enabled = CopySystemTitleMnu.Enabled = RenameMnu.Enabled = CertificatesList.SelectedItems.Count == 1;
            RemoveMnu.Enabled = CertificatesList.SelectedItems.Count != 0;
        }

        private void RenameMnu_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem it = CertificatesList.SelectedItems[0];
                GXTextDlg dlg = new GXTextDlg("Rename certificate file.", "Certificate name:", it.SubItems[5].Text);
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    string path = dlg.GetValue();
                    path = Path.Combine(CertificateFolder, Path.GetFileNameWithoutExtension(path)) + ".pem";
                    File.Move(Path.Combine(CertificateFolder, it.SubItems[5].Text) + ".pem", path);
                    it.SubItems[5].Text = Path.GetFileNameWithoutExtension(path);
                    it.Tag = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void GenerateMnu_Click(object sender, EventArgs e)
        {
            try
            {
                GXCertifigateGenerationForm dlg = new GXCertifigateGenerationForm(_path, _address);
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    string path = dlg.Certificate.Subject;
                    path = path.Replace("CN=", "");
                    path = Path.Combine(CertificateFolder, path) + ".pem";
                    dlg.Certificate.Save(path);
                    AddCertificate(dlg.Certificate, path, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        internal void ShowInfo(GXx509Certificate cert)
        {
            StringBuilder sb = new StringBuilder();
            if (!string.IsNullOrEmpty(cert.Description))
            {
                sb.AppendLine("Description:");
                sb.AppendLine(cert.Description);
                sb.AppendLine("");
            }
            sb.AppendLine("Public key info:");
            sb.AppendLine(cert.ToString());
            MessageBox.Show(Parent, sb.ToString());
        }

        private void InfoMnu_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem it = CertificatesList.SelectedItems[0];
                ShowInfo(GXx509Certificate.Load((string)it.Tag));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }

        }

        /// <summary>
        /// Copy system title to clipboard.
        /// </summary>
        private void CopySystemTitleMnu_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem it = CertificatesList.SelectedItems[0];
                string subject = GXx509Certificate.Load((string)it.Tag).Subject;
                int pos = subject.IndexOf("CN=");
                if (pos == -1)
                {
                    throw new Exception("System title not found.");
                }
                subject = subject.Substring(pos + 3, 16);
                Clipboard.SetText(subject);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        public void UpdateUI()
        {
            RefreshCertificates();
        }

        private void openContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(CertificateFolder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem it = CertificatesList.SelectedItems[0];
                GXTextDlg dlg = new GXTextDlg("Certificate description.", "Certificate description:", it.SubItems[6].Text);
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    string desc = dlg.GetValue();
                    GXx509Certificate cert = GXx509Certificate.Load((string)it.Tag);
                    cert.Description = desc;
                    cert.Save((string)it.Tag);
                    it.SubItems[6].Text = desc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }
    }
}
