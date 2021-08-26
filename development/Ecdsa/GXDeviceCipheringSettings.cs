using Gurux.DLMS.ASN;
using Gurux.DLMS.ASN.Enums;
using Gurux.DLMS.Ecdsa.Enums;
using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects.Enums;
using Gurux.DLMS.Secure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{

    public partial class GXDeviceCipheringSettings : Form
    {
        private bool updateUI;
        private bool _checkSystemTitle;
        private Standard _standard;
        private readonly string _title;
        private readonly string _keysPath;
        private readonly string _certificatesPath;
        private readonly string _address;

        /// <summary>
        /// Private keys.
        /// </summary>
        internal GXPkcs8Collection _privateKeys;
        /// <summary>
        /// Public keys.
        /// </summary>
        internal GXx509CertificateCollection _certifications;

        public List<KeyValuePair<GXPkcs8, GXx509Certificate>> GetClientKeys(string systemTitle)
        {
            byte[] st = GXDLMSTranslator.HexToBytes(systemTitle);
            List<KeyValuePair<GXPkcs8, GXx509Certificate>> list = new List<KeyValuePair<GXPkcs8, GXx509Certificate>>();
            if (st.Length == 8)
            {
                string subject = GXAsn1Converter.SystemTitleToSubject(st);
                GXPkcs8 k;
                foreach (GXx509Certificate cert in _certifications)
                {
                    if (cert.Subject == subject)
                    {
                        if ((k = _privateKeys.Find(cert.PublicKey)) != null)
                        {
                            if ((cert.KeyUsage & KeyUsage.DigitalSignature) != 0)
                            {
                                list.Add(new KeyValuePair<GXPkcs8, GXx509Certificate>(k, cert));
                            }
                        }
                    }
                }
            }
            return list;
        }

        private void ShowKeys()
        {
            ClientAgreementKeysCb.Items.Clear();
            ServerAgreementKeysCb.Items.Clear();
            ClientSigningKeysCb.Items.Clear();
            ServerSigningKeysCb.Items.Clear();
            ClientTlsCb.Items.Clear();
            ServerTlsCb.Items.Clear();

            ClientAgreementKeysCb.Items.Add("");
            ServerAgreementKeysCb.Items.Add("");
            ClientSigningKeysCb.Items.Add("");
            ServerSigningKeysCb.Items.Add("");
            ClientTlsCb.Items.Add("");
            ServerTlsCb.Items.Add("");
            //Add all private keys.
            GXPkcs8 k;
            foreach (GXx509Certificate cert in _certifications)
            {
                if ((k = _privateKeys.Find(cert.PublicKey)) != null)
                {
                    KeyValuePair<GXPkcs8, GXx509Certificate> tmp = new KeyValuePair<GXPkcs8, GXx509Certificate>(k, cert);
                    if (cert.KeyUsage == KeyUsage.KeyAgreement)
                    {
                        ClientAgreementKeysCb.Items.Add(tmp);
                        ServerAgreementKeysCb.Items.Add(tmp);
                    }
                    else if (cert.KeyUsage == KeyUsage.DigitalSignature)
                    {
                        ClientSigningKeysCb.Items.Add(tmp);
                        ServerSigningKeysCb.Items.Add(tmp);
                    }
                    else if (cert.KeyUsage == (KeyUsage.KeyAgreement | KeyUsage.DigitalSignature))
                    {
                        ClientTlsCb.Items.Add(tmp);
                        ServerTlsCb.Items.Add(tmp);
                    }
                }
                else
                {
                    //This is server key if private key is not found.
                    KeyValuePair<GXPkcs8, GXx509Certificate> tmp = new KeyValuePair<GXPkcs8, GXx509Certificate>(k, cert);
                    if (cert.KeyUsage == KeyUsage.KeyAgreement)
                    {
                        ServerAgreementKeysCb.Items.Add(tmp);
                    }
                    else if (cert.KeyUsage == KeyUsage.DigitalSignature)
                    {
                        ServerSigningKeysCb.Items.Add(tmp);
                    }
                    else if (cert.KeyUsage == (KeyUsage.KeyAgreement | KeyUsage.DigitalSignature))
                    {
                        ServerTlsCb.Items.Add(tmp);
                    }
                }
            }
            //Select default values.
            if (!string.IsNullOrEmpty(ClientSigningKey))
            {
                foreach (object tmp in ClientSigningKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == ClientSigningKey)
                        {
                            ClientSigningKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
            }
            else
            {
                ClientSigningKeysCb.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(ClientAgreementKey))
            {
                foreach (object tmp in ClientAgreementKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == ClientAgreementKey)
                        {
                            ClientAgreementKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
            }
            else
            {
                ClientAgreementKeysCb.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(ClientTls))
            {
                foreach (object tmp in ClientTlsCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == ClientTls)
                        {
                            ClientTlsCb.SelectedItem = it;
                            break;
                        }
                    }
                }
            }
            else
            {
                ClientTlsCb.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(ServerSigningKey))
            {
                foreach (object tmp in ServerSigningKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == ServerSigningKey)
                        {
                            ServerSigningKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
            }
            else
            {
                ServerSigningKeysCb.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(ServerAgreementKey))
            {
                foreach (object tmp in ServerAgreementKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == ServerAgreementKey)
                        {
                            ServerAgreementKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
            }
            else
            {
                ServerAgreementKeysCb.SelectedIndex = 0;
            }
            if (!string.IsNullOrEmpty(ServerTls))
            {
                foreach (object tmp in ServerTlsCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == ServerAgreementKey)
                        {
                            ServerTlsCb.SelectedItem = it;
                            break;
                        }
                    }
                }
            }
            else
            {
                ServerTlsCb.SelectedIndex = 0;
            }
        }

        public Security Security
        {
            get
            {
                return (Security)SecurityCB.SelectedItem;
            }
            set
            {
                //TODO: Obsolete. This can be remove at some point.
                if (value == Security.DigitallySigned)
                {
                    value = Security.AuthenticationEncryption;
                }
                SecurityCB.SelectedItem = value;
            }
        }
        public SecuritySuite SecuritySuite
        {
            get
            {
                if (SecuritySuiteCb.SelectedItem == null)
                {
                    return SecuritySuite.Suite0;
                }
                return (SecuritySuite)SecuritySuiteCb.SelectedItem;
            }
            set
            {
                SecuritySuiteCb.SelectedItem = value;
            }
        }

        public string SystemTitle
        {
            get
            {
                return GetAsHex(SystemTitleTb.Text, SystemTitleAsciiCb.Checked, false);
            }
            set
            {
                SystemTitleTb.Text = value;
            }
        }

        public Standard Standard
        {
            get
            {
                return _standard;
            }
            set
            {
                _standard = value;
            }
        }

        public bool SystemTitleAscii
        {
            get
            {
                return SystemTitleAsciiCb.Checked;
            }
            set
            {
                SystemTitleAsciiCb.CheckedChanged -= SystemTitleAsciiCb_CheckedChanged;
                SystemTitleAsciiCb.Checked = value;
                SystemTitleAsciiCb.CheckedChanged += SystemTitleAsciiCb_CheckedChanged;
            }
        }

        public string BlockCipherKey
        {
            get
            {
                return GetAsHex(BlockCipherKeyTB.Text, BlockCipherKeyAsciiCb.Checked, false);
            }
            set
            {
                BlockCipherKeyTB.Text = value;
            }
        }

        public bool BlockCipherKeyAscii
        {
            get
            {
                return BlockCipherKeyAsciiCb.Checked;
            }
            set
            {
                BlockCipherKeyAsciiCb.CheckedChanged -= BlockCipherKeyAsciiCb_CheckedChanged;
                BlockCipherKeyAsciiCb.Checked = value;
                BlockCipherKeyAsciiCb.CheckedChanged += BlockCipherKeyAsciiCb_CheckedChanged;
            }
        }

        public string AuthenticationKey
        {
            get
            {
                return GetAsHex(AuthenticationKeyTB.Text, AuthenticationKeyAsciiCb.Checked, false);
            }
            set
            {
                AuthenticationKeyTB.Text = value;
            }
        }

        public bool AuthenticationKeyAscii
        {
            get
            {
                return AuthenticationKeyAsciiCb.Checked;
            }
            set
            {
                AuthenticationKeyAsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKeyAsciiCb.Checked = value;
                AuthenticationKeyAsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
            }
        }

        public string DedicatedKey
        {
            get
            {
                return GetAsHex(DedicatedKeyTb.Text, DedicatedKeyAsciiCb.Checked, false);
            }
            set
            {
                DedicatedKeyTb.Text = value;
            }
        }

        public bool DedicatedKeyAscii
        {
            get
            {
                return AuthenticationKeyAsciiCb.Checked;
            }
            set
            {
                DedicatedKeyAsciiCb.CheckedChanged -= DedicatedKeyAsciiCb_CheckedChanged;
                DedicatedKeyAsciiCb.Checked = value;
                DedicatedKeyAsciiCb.CheckedChanged += DedicatedKeyAsciiCb_CheckedChanged;
            }
        }

        /// <summary>
        /// Signing.
        /// </summary>
        public Signing Signing
        {
            get
            {
                return (Signing)SigningCb.SelectedItem;
            }
            set
            {
                SigningCb.SelectedItem = value;
            }
        }

        /// <summary>
        /// Signing key of the client.
        /// </summary>
        public string ClientSigningKey
        {
            get;
            set;
        }

        /// <summary>
        /// Agreement key of the client.
        /// </summary>
        public string ClientAgreementKey
        {
            get;
            set;
        }

        /// <summary>
        /// TLS of the client.
        /// </summary>
        public string ClientTls
        {
            get;
            set;
        }

        /// <summary>
        /// Signing key of the server.
        /// </summary>
        public string ServerSigningKey
        {
            get;
            set;
        }

        /// <summary>
        /// Agreement key of the server.
        /// </summary>
        public string ServerAgreementKey
        {
            get;
            set;
        }

        /// <summary>
        /// TLS of the server.
        /// </summary>
        public string ServerTls
        {
            get;
            set;
        }


        /// <summary>
        /// Agreement key of the server.
        /// </summary>
        public bool PreEstablishedApplicationAssociations
        {
            get
            {
                return UsePreEstablishedApplicationAssociations.Checked;
            }
            set
            {
                UsePreEstablishedApplicationAssociations.Checked = value;
            }
        }

        public string ServerSystemTitle
        {
            get
            {
                return GetAsHex(ServerSystemTitleTb.Text, false, false);
            }
            set
            {
                ServerSystemTitleTb.Text = value;
            }
        }

        public string Challenge
        {
            get
            {
                return GetAsHex(ChallengeTB.Text, false, false);
            }
            set
            {
                ChallengeTB.Text = value;
            }
        }

        public GXDeviceCipheringSettings(string address, string title, string keysPath, string certificatesPath)
        {
            InitializeComponent();
            _address = address;
            _title = title;
            _keysPath = keysPath;
            _certificatesPath = certificatesPath;
            _privateKeys = new GXPkcs8Collection();
            _certifications = new GXx509CertificateCollection();
            _privateKeys.Import(keysPath);
            _certifications.Import(certificatesPath);
            SigningCb.Items.AddRange(new object[] { Signing.None, Signing.OnePassDiffieHellman, Signing.StaticUnifiedModel, Signing.GeneralSigning });
            SecuritySuiteCb.Items.AddRange(new object[] { SecuritySuite.Suite0, SecuritySuite.Suite1, SecuritySuite.Suite2 });
            SecurityCB.Items.AddRange(new object[] { Security.None, Security.Authentication,
                                      Security.Encryption, Security.AuthenticationEncryption });
            SecurityCB.SelectedIndex = 0;
            SecuritySuiteCb.SelectedIndex = 0;
            ShowKeys();
            _checkSystemTitle = true;
            updateUI = true;
        }

        public TabPage GetCiphetingTab()
        {
            return CipheringTab;
        }

        private static bool IsAscii(byte[] value)
        {
            if (value != null)
            {
                foreach (byte it in value)
                {
                    if (it < 0x21 || it > 0x7E)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Get value as hex string.
        /// </summary>
        /// <param name="value">Value to convert to hex.</param>
        /// <param name="ascii">Is value ASCII or hex string.</param>
        /// <returns></returns>
        private static string GetAsHex(string value, bool ascii, bool addSpaces)
        {
            if (ascii)
            {
                return GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(value), addSpaces);
            }
            return GXDLMSTranslator.ToHex(GXDLMSTranslator.HexToBytes(value), addSpaces);
        }

        private void UsePreEstablishedApplicationAssociations_CheckedChanged(object sender, EventArgs e)
        {
            ServerSystemTitleTb.ReadOnly = !UsePreEstablishedApplicationAssociations.Checked;
        }

        private void UpdateValue(TextBox value, bool ascii)
        {
            string str = GetAsHex(value.Text, !ascii, true);
            if (ascii)
            {
                if (!IsAscii(GXDLMSTranslator.HexToBytes(str)))
                {
                    value.Select();
                    throw new ArgumentOutOfRangeException("There are non ASCII chars.");
                }
                value.Text = ASCIIEncoding.ASCII.GetString(GXDLMSTranslator.HexToBytes(str));
            }
            else
            {
                value.Text = str;
            }
        }

        private void SystemTitleAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(SystemTitleTb, SystemTitleAsciiCb.Checked);
            }
            catch (Exception ex)
            {
                SystemTitleAscii = !SystemTitleAsciiCb.Checked;
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void BlockCipherKeyAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(BlockCipherKeyTB, BlockCipherKeyAsciiCb.Checked);
            }
            catch (Exception ex)
            {
                BlockCipherKeyAscii = !BlockCipherKeyAsciiCb.Checked;
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void AuthenticationKeyAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(AuthenticationKeyTB, AuthenticationKeyAsciiCb.Checked);
            }
            catch (Exception ex)
            {
                AuthenticationKeyAscii = !AuthenticationKeyAsciiCb.Checked;
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void DedicatedKeyAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(DedicatedKeyTb, DedicatedKeyAsciiCb.Checked);
            }
            catch (Exception ex)
            {
                DedicatedKeyAscii = !DedicatedKeyAsciiCb.Checked;
                MessageBox.Show(Parent, ex.Message);
            }
        }


        private void SecurityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Security selected = (Security)SecurityCB.SelectedItem;
            AuthenticationKeyTB.ReadOnly = BlockCipherKeyTB.ReadOnly = selected == Security.None;
        }

        /// <summary>
        /// Update certificates with server and client system title.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                _checkSystemTitle = false;
                SecuritySuite ss = (SecuritySuite)SecuritySuiteCb.SelectedItem;
                Ecc scheme = ss == SecuritySuite.Suite1 ? Ecc.P256 : Ecc.P384;
                byte[] tmp = GXDLMSTranslator.HexToBytes(SystemTitle);
                if (tmp.Length != 0 && tmp.Length != 8)
                {
                    throw new Exception("Client system title is invalid.");
                }
                string clientST = null;
                if (tmp.Length != 0)
                {
                    clientST = "CN=" + GXDLMSTranslator.ToHex(tmp, false);
                }
                tmp = GXDLMSTranslator.HexToBytes(ServerSystemTitle);
                if (tmp.Length != 0 && tmp.Length != 8)
                {
                    throw new Exception("Server system title is invalid.");
                }
                string serverST = null;
                if (tmp.Length != 0)
                {
                    serverST = "CN=" + GXDLMSTranslator.ToHex(tmp, false);
                }
                ClientAgreementKeysCb.SelectedItem = null;
                ServerAgreementKeysCb.SelectedItem = null;
                ClientSigningKeysCb.SelectedItem = null;
                ServerSigningKeysCb.SelectedItem = null;
                ClientTlsCb.SelectedItem = null;
                ServerTlsCb.SelectedItem = null;
                if (clientST != null)
                {
                    foreach (object tmp2 in ClientAgreementKeysCb.Items)
                    {
                        if (tmp2 is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                            {
                                ClientAgreementKeysCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                    foreach (object tmp2 in ClientSigningKeysCb.Items)
                    {
                        if (tmp2 is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                            {
                                ClientSigningKeysCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                    foreach (object tmp2 in ClientTlsCb.Items)
                    {
                        if (tmp2 is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                            {
                                ClientTlsCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                }
                if (serverST != null)
                {
                    foreach (object tmp2 in ServerAgreementKeysCb.Items)
                    {
                        if (tmp2 is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                            {
                                ServerAgreementKeysCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                    foreach (object tmp2 in ServerSigningKeysCb.Items)
                    {
                        if (tmp2 is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                            {
                                ServerSigningKeysCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                    foreach (object tmp2 in ServerTlsCb.Items)
                    {
                        if (tmp2 is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                            {
                                ServerTlsCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
            finally
            {
                _checkSystemTitle = true;
            }
        }

        private static void ShowInfo(IWin32Window owner, KeyValuePair<GXPkcs8, GXx509Certificate> value)
        {
            StringBuilder sb = new StringBuilder();
            if (value.Key != null)
            {
                sb.AppendLine("Private key:");
                sb.AppendLine(value.Key.PrivateKey.ToHex());
                sb.AppendLine(Environment.NewLine);
            }
            if (value.Value != null)
            {
                sb.AppendLine("Public key info:");
                sb.AppendLine(value.Value.ToString());
            }
            MessageBox.Show(owner, sb.ToString());
        }

        /// <summary>
        /// Show client signing key Info.
        /// </summary>
        private void ClientSigningKeysInfoBtn_Click(object sender, EventArgs e)
        {
            if (ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> v)
            {
                ShowInfo(Parent, v);
            }
        }

        /// <summary>
        /// Show client agreement key Info.
        /// </summary>
        private void ClientAgreementKeyInfoBtn_Click(object sender, EventArgs e)
        {
            if (ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> v)
            {
                ShowInfo(Parent, v);
            }

        }

        /// <summary>
        /// Show server signing key Info.
        /// </summary>
        private void ServerSigningKeyInfoBtn_Click(object sender, EventArgs e)
        {
            if (ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> v)
            {
                ShowInfo(Parent, v);
            }
        }

        /// <summary>
        /// Show server agreement key Info.
        /// </summary>
        private void ServerAgreementKeyInfoBtn_Click(object sender, EventArgs e)
        {
            if (ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> v)
            {
                ShowInfo(Parent, v);
            }
        }

        private void BlockCipherKeyTB_Leave(object sender, EventArgs e)
        {
            try
            {
                int len = BlockCipherKeyTB.Text.Replace(" ", "").Length;
                if (len != 0)
                {
                    if (len == 32)
                    {
                        if (BlockCipherKeyAscii)
                        {
                            BlockCipherKeyAscii = false;
                        }
                    }
                    else if (len == 16)
                    {
                        if (!BlockCipherKeyAscii)
                        {
                            BlockCipherKeyAscii = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid Block cipher key.");
                    }
                }
                GetAsHex(BlockCipherKeyTB.Text, BlockCipherKeyAsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                BlockCipherKeyTB.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void DedicatedKeyTb_Leave(object sender, EventArgs e)
        {
            try
            {
                int len = DedicatedKeyTb.Text.Replace(" ", "").Length;
                if (len != 0)
                {
                    if (len == 32)
                    {
                        if (DedicatedKeyAscii)
                        {
                            DedicatedKeyAscii = false;
                        }
                    }
                    else if (len == 16)
                    {
                        if (!DedicatedKeyAscii)
                        {
                            DedicatedKeyAscii = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid dedicated key.");
                    }
                }
                GetAsHex(DedicatedKeyTb.Text, DedicatedKeyAsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                DedicatedKeyTb.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Update ASCII checked when focus is moved out.
        /// </summary>
        private void SystemTitleTB_Leave(object sender, EventArgs e)
        {
            try
            {
                int len = SystemTitleTb.Text.Replace(" ", "").Length;
                if (len != 0)
                {
                    if (len == 16)
                    {
                        if (SystemTitleAscii)
                        {
                            SystemTitleAscii = false;
                        }
                    }
                    else if (len == 8)
                    {
                        if (!SystemTitleAscii)
                        {
                            SystemTitleAscii = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid system title.");
                    }
                }
                GetAsHex(SystemTitleTb.Text, SystemTitleAsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                SystemTitleTb.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void ClientSigningKeysCb_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value is KeyValuePair<GXPkcs8, GXx509Certificate> kp)
            {
                if (kp.Value != null)
                {
                    e.Value = kp.Value.Subject + " #" + kp.Value.SerialNumber;
                }
                else
                {
                    e.Value = kp.Key.PrivateKey.ToHex();
                }
            }
        }

        /// <summary>
        /// Update private and public keys to the translator.
        /// </summary>
        private void GetKeys()
        {
            if (updateUI)
            {
                if (ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cs)
                {
                    ClientSigningKey = cs.Key.ToDer();
                }
                else
                {
                    ClientSigningKey = null;
                }
                if (ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ca)
                {
                    ClientAgreementKey = ca.Key.ToDer();
                }
                else
                {
                    ClientAgreementKey = null;
                }
                if (ClientTlsCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ct)
                {
                    ClientTls = ct.Key.ToDer();
                }
                else
                {
                    ClientTls = null;
                }
                if (ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ss)
                {
                    ServerSigningKey = ss.Value.ToDer();
                }
                else
                {
                    ServerSigningKey = null;
                }
                if (ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sa)
                {
                    ServerAgreementKey = sa.Value.ToDer();
                }
                else
                {
                    ServerAgreementKey = null;
                }
                if (ServerTlsCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> stk)
                {
                    ServerTls = stk.Value.ToDer();
                }
                else
                {
                    ServerTls = null;
                }
                bool check = _checkSystemTitle;
                if (check)
                {
                    string st;
                    if (SystemTitleAsciiCb.Checked)
                    {
                        st = GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(SystemTitleTb.Text), false);
                    }
                    else
                    {
                        st = SystemTitleTb.Text.Replace(" ", "");
                    }
                    if (check && (ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cv) && cv.Value != null)
                    {
                        string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(cv.Value.Subject), false);
                        if (st != certificateSt)
                        {
                            if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTb.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SystemTitleAsciiCb.Checked = false;
                                SystemTitleTb.Text = certificateSt;
                                check = false;
                            }
                        }
                    }
                    if (check && (ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ck) && ck.Value != null)
                    {
                        string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(ck.Value.Subject), false);
                        if (st != certificateSt)
                        {
                            if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTb.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SystemTitleAsciiCb.Checked = false;
                                SystemTitleTb.Text = certificateSt;
                                check = false;
                            }
                        }
                    }

                    if (check && (ClientTlsCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ct3) && ct3.Value != null)
                    {
                        string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(ct3.Value.Subject), false);
                        if (st != certificateSt)
                        {
                            if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTb.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                SystemTitleAsciiCb.Checked = false;
                                SystemTitleTb.Text = certificateSt;
                                check = false;
                            }
                        }
                    }

                    if (check && ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sv)
                    {
                        string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(sv.Value.Subject), false);
                        if (ServerSystemTitleTb.Text.Replace(" ", "") != certificateSt)
                        {
                            if (MessageBox.Show(Parent, string.Format("System title '{0}' of the server is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", ServerSystemTitleTb.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ServerSystemTitleTb.Text = certificateSt;
                                check = false;
                            }
                        }
                    }
                    if (check && ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sk)
                    {
                        string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(sk.Value.Subject), false);
                        if (ServerSystemTitleTb.Text.Replace(" ", "") != certificateSt)
                        {
                            if (MessageBox.Show(Parent, string.Format("System title '{0}' of the server is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", ServerSystemTitleTb.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ServerSystemTitleTb.Text = certificateSt;
                                check = false;
                            }
                        }
                    }
                    if (check && ServerTlsCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> st3)
                    {
                        string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(st3.Value.Subject), false);
                        if (ServerSystemTitleTb.Text.Replace(" ", "") != certificateSt)
                        {
                            if (MessageBox.Show(Parent, string.Format("System title '{0}' of the server is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", ServerSystemTitleTb.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                ServerSystemTitleTb.Text = certificateSt;
                            }
                        }
                    }
                }
            }
        }

        private static void SelectWithPrivateKey(ComboBox items, GXPkcs8 pk)
        {
            bool found = false;
            //Select default values.
            foreach (object tmp in items.Items)
            {
                if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                {
                    if (it.Key.Equals(pk))
                    {
                        items.SelectedItem = it;
                        found = true;
                        break;
                    }
                }
            }
            if (!found)
            {
                items.SelectedIndex = items.Items.Add(new KeyValuePair<GXPkcs8, GXx509Certificate>(pk, null));

            }
        }
        private void SelectWithCertificate(ComboBox items, string value)
        {
            try
            {
                GXx509Certificate cert = GXx509Certificate.FromDer(value);
                bool found = false;
                //Select default values.
                foreach (object tmp in items.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.Equals(cert))
                        {
                            items.SelectedItem = it;
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    items.SelectedIndex = items.Items.Add(new KeyValuePair<GXPkcs8, GXx509Certificate>(null, cert));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        public void UpdateKeys()
        {
            updateUI = false;
            _checkSystemTitle = false;
            try
            {
                if (!string.IsNullOrEmpty(ClientSigningKey))
                {
                    SelectWithPrivateKey(ClientSigningKeysCb, GXPkcs8.FromDer(ClientSigningKey));
                }
                else
                {
                    ClientSigningKeysCb.SelectedItem = null;
                }
                if (!string.IsNullOrEmpty(ClientAgreementKey))
                {
                    SelectWithPrivateKey(ClientAgreementKeysCb, GXPkcs8.FromDer(ClientAgreementKey));
                }
                else
                {
                    ClientAgreementKeysCb.SelectedItem = null;
                }
                if (!string.IsNullOrEmpty(ClientTls))
                {
                    SelectWithPrivateKey(ClientTlsCb, GXPkcs8.FromDer(ClientTls));
                }
                else
                {
                    ClientTlsCb.SelectedItem = null;
                }
                if (!string.IsNullOrEmpty(ServerSigningKey))
                {
                    SelectWithCertificate(ServerSigningKeysCb, ServerSigningKey);
                }
                else
                {
                    ServerSigningKeysCb.SelectedItem = null;
                }
                if (!string.IsNullOrEmpty(ServerAgreementKey))
                {
                    SelectWithCertificate(ServerAgreementKeysCb, ServerAgreementKey);
                }
                else
                {
                    ServerAgreementKeysCb.SelectedItem = null;
                }
                if (!string.IsNullOrEmpty(ServerTls))
                {
                    SelectWithCertificate(ServerTlsCb, ServerTls);
                }
                else
                {
                    ServerTlsCb.SelectedItem = null;
                }
            }
            finally
            {
                _checkSystemTitle = true;
                updateUI = true;
            }
        }

        /// <summary>
        /// Update client signing key.
        /// </summary>
        private void ClientSigningKeysCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Update client key agreement key.
        /// </summary>
        private void ClientAgreementKeysCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Update server signing key.
        /// </summary>
        private void ServerSigningKeysCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Update server key agreement key.
        /// </summary>
        private void ServerAgreementKeysCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Generate private key and certificate for the client.
        /// </summary>
        private void PrivatekeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXEcdsaKeysDlg dlg = new GXEcdsaKeysDlg(_address, _keysPath,
                    _certificatesPath,
                    _title,
                    SecuritySuite,
                    GXDLMSTranslator.HexToBytes(SystemTitle));
                if (dlg.ShowDialog(Parent) == DialogResult.OK)
                {
                    _privateKeys.Import(_keysPath);
                    _certifications.Import(_certificatesPath);
                    ShowKeys();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        /// <summary>
        /// Update server system title if Italy standard is used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerSystemTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int len = ServerSystemTitleTb.Text.Replace(" ", "").Length;
                if (len != 0 && len != 16)
                {
                    throw new Exception("Invalid system title.");
                }
                toolTip1.SetToolTip(ServerSystemTitleTb, null);
                if (len == 16)
                {
                    byte[] tmp = GXDLMSTranslator.HexToBytes(ServerSystemTitleTb.Text);
                    toolTip1.SetToolTip(ServerSystemTitleTb, GXDLMSConverter.SystemTitleToString(_standard, tmp, true));
                }
            }
            catch (Exception ex)
            {
                ServerSystemTitleTb.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void GenerateDedicatedKeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] dedicatedKey = new byte[16];
                if (DedicatedKeyAsciiCb.Checked)
                {
                    Random r = new Random();
                    for (int pos = 0; pos != 16; ++pos)
                    {
                        dedicatedKey[pos] = (byte)r.Next((int)'A', (int)'Z');
                    }
                    DedicatedKeyTb.Text = ASCIIEncoding.ASCII.GetString(dedicatedKey);
                }
                else
                {
                    new Random().NextBytes(dedicatedKey);
                    DedicatedKeyTb.Text = GXDLMSTranslator.ToHex(dedicatedKey, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void ClientTlsInfoBtn_Click(object sender, EventArgs e)
        {
            if (ClientTlsCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> v)
            {
                ShowInfo(Parent, v);
            }
        }

        private void ServerTlsInfoBtn_Click(object sender, EventArgs e)
        {
            if (ClientTlsCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> v)
            {
                ShowInfo(Parent, v);
            }
        }

        private void ClientTlsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void ServerTlsCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void AuthenticationKeyTB_Leave(object sender, EventArgs e)
        {
            try
            {
                int len = AuthenticationKeyTB.Text.Replace(" ", "").Length;
                if (len != 0)
                {
                    if (len == 32)
                    {
                        if (AuthenticationKeyAscii)
                        {
                            AuthenticationKeyAscii = false;
                        }
                    }
                    else if (len == 16)
                    {
                        if (!AuthenticationKeyAscii)
                        {
                            AuthenticationKeyAscii = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid authentication key.");
                    }
                }
                GetAsHex(AuthenticationKeyTB.Text, AuthenticationKeyAsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                AuthenticationKeyTB.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void CipheringTab_Click(object sender, EventArgs e)
        {

        }

        private void SystemTitleAsciiCb_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void SigningCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Signing selected = (Signing)SigningCb.SelectedItem;
            if (selected == Signing.None)
            {
                while (Cipheringv1.Controls.Count == 0)
                {
                    while (CipheringPanel.Controls.Count != 0)
                    {
                        Control ctr = CipheringPanel.Controls[0];
                        ctr.Visible = false;
                        Cipheringv1.Controls.Add(ctr);
                    }
                }
                while (Cipheringv0.Controls.Count != 0)
                {
                    Control ctr = Cipheringv0.Controls[0];
                    CipheringPanel.Controls.Add(ctr);
                    ctr.Visible = true;
                }
            }
            else
            {
                //Static unified model doesn't use signing key.
                ClientSigningKeysCb.Enabled = ServerSigningKeysCb.Enabled = selected != Signing.StaticUnifiedModel;
                //General signing doesn't use agreement key.
                ClientAgreementKeysCb.Enabled = ServerAgreementKeysCb.Enabled = selected != Signing.GeneralSigning;
                while (Cipheringv0.Controls.Count == 0)
                {
                    while (CipheringPanel.Controls.Count != 0)
                    {
                        Control ctr = CipheringPanel.Controls[0];
                        ctr.Visible = false;
                        Cipheringv0.Controls.Add(ctr);
                    }
                }
                while (Cipheringv1.Controls.Count != 0)
                {
                    Control ctr = Cipheringv1.Controls[0];
                    CipheringPanel.Controls.Add(ctr);
                    ctr.Visible = true;
                }
            }
        }
    }
}
