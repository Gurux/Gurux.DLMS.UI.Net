using Gurux.DLMS.ASN;
using Gurux.DLMS.Ecdsa;
using Gurux.DLMS.Ecdsa.Enums;
using Gurux.DLMS.Objects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{
    public partial class GXKeyForm : Form
    {
        private readonly IGXUpdater _updater;
        private string _path;
        private readonly string KeyFolder;
        string _certificateFolder;
        private readonly string Title;
        private byte[] SystemTitle;
        internal GXPkcs8Collection privateKeys;
        private byte[] _systemTitle;
        private readonly string _address;

        public GXKeyForm(IGXUpdater updater, string address, string keyFolder, string certificateFolder, string title, SecuritySuite securitySuiteCb, byte[] systemTitle)
        {
            InitializeComponent();
            _updater = updater;
            _address = address;
            _certificateFolder = certificateFolder;
            _systemTitle = systemTitle;
            privateKeys = new GXPkcs8Collection();
            KeyFolder = keyFolder;
            Title = title;

            foreach (string p in Directory.GetFiles(keyFolder, "*.pem"))
            {
                try
                {
                    GXPkcs8 cert = GXPkcs8.Load(p);
                    AddKey(cert, p);
                }
                catch(Exception)
                {
                    System.Diagnostics.Debug.WriteLine("Failed to open " + p);
                }
            }
            if (_systemTitle != null)
            {
                string path = Path.Combine(KeyFolder, "D" + GXDLMSTranslator.ToHex(_systemTitle, false)) + ".pem";
                //Generate private key for digital signature.
                GXPkcs8 digitalSignature = new GXPkcs8(GXEcdsa.GenerateKeyPair(securitySuiteCb == SecuritySuite.Ecdsa256 ? Ecc.P256 : Ecc.P384));
                digitalSignature.Save(path);
                AddKey(digitalSignature, path);
                path = Path.Combine(KeyFolder, "A" + GXDLMSTranslator.ToHex(_systemTitle, false)) + ".pem";
                //Generate private key for Key agreement.
                GXPkcs8 keyAgreement = new GXPkcs8(GXEcdsa.GenerateKeyPair(Ecc.P256));
                keyAgreement.Save(path);
                AddKey(keyAgreement, path);

                //Get CRS.
                KeyValuePair<GXPrivateKey, GXPublicKey> kp = new KeyValuePair<GXPrivateKey, GXPublicKey>(digitalSignature.PrivateKey, digitalSignature.PublicKey);
                //Generate certificate request and ask new x509Certificate.
                GXPkcs10 pkc10DS = GXPkcs10.CreateCertificateSigningRequest(kp, GXAsn1Converter.SystemTitleToSubject(_systemTitle));
                GXPkcs10 pkc10KA = GXPkcs10.CreateCertificateSigningRequest(kp, GXAsn1Converter.SystemTitleToSubject(_systemTitle));
                //Note! There is a limit how many request you can do in a day.
                List<KeyValuePair<CertificateType, GXPkcs10>> certifications = new List<KeyValuePair<CertificateType, GXPkcs10>>();
                certifications.Add(new KeyValuePair<CertificateType, GXPkcs10>(CertificateType.DigitalSignature, pkc10DS));
                certifications.Add(new KeyValuePair<CertificateType, GXPkcs10>(CertificateType.KeyAgreement, pkc10KA));
                GXx509Certificate[] certificates = GXPkcs10.GetCertificate(address, certifications);
                foreach (GXx509Certificate cert in certificates)
                {
                    if (cert.KeyUsage == ASN.Enums.KeyUsage.DigitalSignature)
                    {
                        path = "D" + GXDLMSTranslator.ToHex(_systemTitle, false);
                    }
                    else if (cert.KeyUsage == ASN.Enums.KeyUsage.KeyAgreement)
                    {
                        path = "A" + GXDLMSTranslator.ToHex(_systemTitle, false);
                    }
                    path = Path.Combine(_certificateFolder, path) + ".pem";
                    cert.Save(path);
                }
            }

        }

        private ListViewItem AddKey(GXPkcs8 cert, string path)
        {
            ListViewItem li = new ListViewItem(cert.PrivateKey.Scheme.ToString());
            li.SubItems.Add(cert.PrivateKey.ToHex(false));
            li.SubItems.Add(Path.GetFileNameWithoutExtension(path));
            li.StateImageIndex = li.ImageIndex = 1;
            KeyList.Items.Add(li).Tag = path;
            privateKeys.Add(cert);
            return li;
        }

        /// <summary>
        /// Generate new private key.
        /// </summary>
        private void GenerateKeyMnu_Click(object sender, EventArgs e)
        {
            try
            {
                GXPrivateKeyForm dlg = new GXPrivateKeyForm();
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    string path = Path.Combine(KeyFolder, dlg.Key.PrivateKey.ToHex(false)) + ".pem";
                    dlg.Key.Save(path);
                    KeyList.SelectedItems.Clear();
                    AddKey(dlg.Key, path).Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void RemoveKey(string path)
        {
            foreach(ListViewItem it in KeyList.Items)
            {
                if (path.Equals(it.Tag))
                {
                    it.Remove();
                    break;
                }
            }
        }

        /// <summary>
        /// Add new key.
        /// </summary>
        private void KeyAddMnu_Click(object sender, EventArgs e)
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
                        _path = fileName;
                        GXPkcs8 key = GXPkcs8.Load(fileName);
                        string path = Path.Combine(KeyFolder, Path.GetFileName(fileName));
                        if (File.Exists(path))
                        {
                            DialogResult ret = MessageBox.Show(Parent, "Private key file already exists. Do you want to overwrite it?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (ret != DialogResult.Yes)
                            {
                                return;
                            }
                            RemoveKey(path);
                        }
                        key.Save(path);
                        KeyList.SelectedItems.Clear();
                        AddKey(key, path).Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }


        /// <summary>
        /// Remove selected private keys.
        /// </summary>
        private void KeyRemoveMnu_Click(object sender, EventArgs e)
        {
            try
            {
                if (KeyList.SelectedItems.Count != 0)
                {
                    DialogResult ret = MessageBox.Show(Parent, Properties.Resources.PrivateKeyRemove, Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (ret != DialogResult.Yes)
                    {
                        return;
                    }
                    while (KeyList.SelectedItems.Count != 0)
                    {
                        ListViewItem it = KeyList.SelectedItems[0];
                        byte[] raw = GXDLMSTranslator.HexToBytes(it.SubItems[1].Text);
                        foreach (GXPkcs8 pk in privateKeys)
                        {
                            if (pk.PrivateKey.RawValue == raw)
                            {
                                privateKeys.Remove(pk);
                                break;
                            }
                        }
                        File.Delete((string)it.Tag);
                        it.Remove();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Rename selected private key file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void KeyRenameMnu_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem it = KeyList.SelectedItems[0];
                GXTextDlg dlg = new GXTextDlg("Rename private key file.", "Key name:", it.SubItems[2].Text);
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    string path = dlg.GetValue();
                    path = Path.Combine(KeyFolder, Path.GetFileNameWithoutExtension(path)) + ".pem";
                    File.Move(Path.Combine(KeyFolder, it.SubItems[2].Text) + ".pem", path);
                    it.SubItems[2].Text = Path.GetFileNameWithoutExtension(path);
                    it.Tag = path;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void KeyMenu_Opening(object sender, CancelEventArgs e)
        {
            InfoMnu.Enabled = GetCertificateMnu.Enabled = KeyRenameMnu.Enabled = KeyList.SelectedItems.Count == 1;
            KeyRemoveMnu.Enabled = KeyList.SelectedItems.Count != 0;
        }

        /// <summary>
        /// Get certificate for the private key.
        /// </summary>
        private void GetCertificateMnu_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem it = KeyList.SelectedItems[0];
                GXCertificateSigningRequestDlg dlg = new GXCertificateSigningRequestDlg(SystemTitle);
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    SystemTitle = dlg.SystemTitle;
                    GXPkcs8 pk = GXPkcs8.Load((string)it.Tag);
                    KeyValuePair<GXPrivateKey, GXPublicKey> kp = new KeyValuePair<GXPrivateKey, GXPublicKey>(pk.PrivateKey, pk.PublicKey);
                    //Generate certificate request and ask new x509Certificate.
                    GXPkcs10 pkc10 = GXPkcs10.CreateCertificateSigningRequest(kp, GXAsn1Converter.SystemTitleToSubject(SystemTitle));

                    List<KeyValuePair<CertificateType, GXPkcs10>> certifications = new List<KeyValuePair<CertificateType, GXPkcs10>>();
                    certifications.Add(new KeyValuePair<CertificateType, GXPkcs10>(dlg.CertificateType, pkc10));
                    //Note! There is a limit how many request you can do in a day.
                    GXx509Certificate[] certificates = GXPkcs10.GetCertificate(_address, certifications);
                    foreach (GXx509Certificate cert in certificates)
                    {
                        if (cert.KeyUsage == ASN.Enums.KeyUsage.DigitalSignature)
                        {
                            _path = "D" + GXDLMSTranslator.ToHex(SystemTitle, false);
                        }
                        else if (cert.KeyUsage == ASN.Enums.KeyUsage.KeyAgreement)
                        {
                            _path = "A" + GXDLMSTranslator.ToHex(SystemTitle, false);
                        }
                        _path = Path.Combine(_certificateFolder, _path) + ".pem";
                        cert.Save(_path);
                    }
                    _updater.UpdateUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        internal void ShowInfo(GXPkcs8 cert)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Private key:");
            sb.AppendLine(cert.PrivateKey.ToHex());
            sb.AppendLine(Environment.NewLine);
            sb.AppendLine("Public key info:");
            sb.AppendLine(cert.PublicKey.ToString());
            MessageBox.Show(Parent, sb.ToString());
        }

        private void InfoMnu_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem it = KeyList.SelectedItems[0];
                ShowInfo(GXPkcs8.Load((string)it.Tag));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }
    }
}
