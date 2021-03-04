using Gurux.DLMS.ASN;
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
        private bool _checkSystemTitle = true;
        private Standard _standard;
        private readonly string _title;
        private readonly string _keysPath;
        private readonly string _certificatesPath;
        private readonly string _address;

        /// <summary>
        /// Private keys.
        /// </summary>
        public GXPkcs8Collection _privateKeys;
        /// <summary>
        /// Public keys.
        /// </summary>
        public GXx509CertificateCollection _certifications;

        private void ShowKeys()
        {
            ClientAgreementKeysCb.Items.Clear();
            ServerAgreementKeysCb.Items.Clear();
            ClientSigningKeysCb.Items.Clear();
            ServerSigningKeysCb.Items.Clear();
            //Add all private keys.
            GXPkcs8 k;
            foreach (GXx509Certificate cert in _certifications)
            {
                if ((k = _privateKeys.Find(cert.PublicKey)) != null)
                {
                    KeyValuePair<GXPkcs8, GXx509Certificate> tmp = new KeyValuePair<GXPkcs8, GXx509Certificate>(k, cert);
                    if (cert.KeyUsage == Gurux.DLMS.ASN.Enums.KeyUsage.KeyAgreement)
                    {
                        ClientAgreementKeysCb.Items.Add(tmp);
                        ServerAgreementKeysCb.Items.Add(tmp);
                    }
                    else if (cert.KeyUsage == Gurux.DLMS.ASN.Enums.KeyUsage.DigitalSignature)
                    {
                        ClientSigningKeysCb.Items.Add(tmp);
                        ServerSigningKeysCb.Items.Add(tmp);
                    }
                }
                else
                {
                    //This is server key if private key is not found.
                    KeyValuePair<GXPkcs8, GXx509Certificate> tmp = new KeyValuePair<GXPkcs8, GXx509Certificate>(k, cert);
                    if (cert.KeyUsage == Gurux.DLMS.ASN.Enums.KeyUsage.KeyAgreement)
                    {
                        ServerAgreementKeysCb.Items.Add(tmp);
                    }
                    else if (cert.KeyUsage == Gurux.DLMS.ASN.Enums.KeyUsage.DigitalSignature)
                    {
                        ServerSigningKeysCb.Items.Add(tmp);
                    }
                }
            }
            //Select default values.
            if (!string.IsNullOrEmpty(ClientSigningKey))
            {
                foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ClientSigningKeysCb.Items)
                {
                    if (it.Value.SerialNumber.ToString() == ClientSigningKey)
                    {
                        ClientSigningKeysCb.SelectedItem = it;
                        break;
                    }
                }
            }
            if (!string.IsNullOrEmpty(ClientAgreementKey))
            {
                foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ClientAgreementKeysCb.Items)
                {
                    if (it.Value.SerialNumber.ToString() == ClientAgreementKey)
                    {
                        ClientAgreementKeysCb.SelectedItem = it;
                        break;
                    }
                }
            }
            if (!string.IsNullOrEmpty(ServerSigningKey))
            {
                foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ServerSigningKeysCb.Items)
                {
                    if (it.Value.SerialNumber.ToString() == ServerSigningKey)
                    {
                        ServerSigningKeysCb.SelectedItem = it;
                        break;
                    }
                }
            }
            if (!string.IsNullOrEmpty(ServerAgreementKey))
            {
                foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ServerAgreementKeysCb.Items)
                {
                    if (it.Value.SerialNumber.ToString() == ServerAgreementKey)
                    {
                        ServerAgreementKeysCb.SelectedItem = it;
                        break;
                    }
                }
            }
        }

        public KeyAgreementScheme KeyAgreementScheme
        {
            get
            {
                return (KeyAgreementScheme)KeyAgreementSchemeCb.SelectedItem;
            }
            set
            {
                KeyAgreementSchemeCb.SelectedItem = value;
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
                SecurityCB.SelectedItem = value;
            }
        }
        public SecuritySuite SecuritySuite
        {
            get
            {
                if (SecuritySuiteCb.SelectedItem == null)
                {
                    return SecuritySuite.GMac;
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
                if (SecuritySuite == SecuritySuite.GMac)
                {
                    return GetAsHex(SystemTitle0Tb.Text, SystemTitleAscii0Cb.Checked, false);
                }
                return GetAsHex(SystemTitleTB.Text, SystemTitleAsciiCb.Checked, false);
            }
            set
            {
                SystemTitle0Tb.Text = SystemTitleTB.Text = value;
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
                ItalySystemTitleTb.Visible = _standard == Standard.Italy;
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
                SystemTitleAscii0Cb.CheckedChanged -= SystemTitleAscii0Cb_CheckedChanged;
                SystemTitleAscii0Cb.Checked = value;
                SystemTitleAscii0Cb.CheckedChanged += SystemTitleAscii0Cb_CheckedChanged;
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
                if (SecuritySuite == SecuritySuite.GMac)
                {
                    return GetAsHex(AuthenticationKey0TB.Text, AuthenticationKey0AsciiCb.Checked, false);
                }
                return GetAsHex(AuthenticationKeyTB.Text, AuthenticationKeyAsciiCb.Checked, false);
            }
            set
            {
                AuthenticationKeyTB.Text = AuthenticationKey0TB.Text = value;
            }
        }

        public bool AuthenticationKeyAscii
        {
            get
            {
                return AuthenticationKey0AsciiCb.Checked;
            }
            set
            {
                AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKey0AsciiCb.Checked = value;
                AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
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
        public bool PreEstablished
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

        public bool DedicatedKeyAscii
        {
            get
            {
                return AuthenticationKey0AsciiCb.Checked;
            }
            set
            {
                DedicatedKeyAsciiCb.CheckedChanged -= DedicatedKeyAsciiCb_CheckedChanged;
                DedicatedKeyAsciiCb.Checked = value;
                DedicatedKeyAsciiCb.CheckedChanged += DedicatedKeyAsciiCb_CheckedChanged;
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
                if (SecuritySuite == SecuritySuite.GMac)
                {
                    return GetAsHex(ServerSystemTitle0.Text, SystemTitleAscii0Cb.Checked, false);
                }
                return GetAsHex(ServerSystemTitleTB.Text, false, false);
            }
            set
            {
                ServerSystemTitle0.Text = ServerSystemTitleTB.Text = value;
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
            SecuritySuiteCb.Items.AddRange(new object[] { SecuritySuite.GMac, SecuritySuite.Ecdsa256, SecuritySuite.Ecdsa384 });
            SecurityCB.Items.AddRange(new object[] { Security.None, Security.Authentication,
                                      Security.Encryption, Security.AuthenticationEncryption });
            KeyAgreementSchemeCb.Items.AddRange(new object[] {KeyAgreementScheme.EphemeralUnifiedModel,
                KeyAgreementScheme.OnePassDiffieHellman,
                KeyAgreementScheme.StaticUnifiedModel});
            ShowKeys();
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
            ServerSystemTitle0.ReadOnly = !UsePreEstablishedApplicationAssociations.Checked;
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
                if (SecuritySuite == SecuritySuite.GMac)
                {
                    UpdateValue(SystemTitle0Tb, SystemTitleAscii0Cb.Checked);
                }
                else
                {
                    UpdateValue(SystemTitleTB, SystemTitleAsciiCb.Checked);
                }
            }
            catch (Exception ex)
            {
                SystemTitleAscii = !SystemTitleAscii0Cb.Checked;
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
                UpdateValue(AuthenticationKey0TB, AuthenticationKey0AsciiCb.Checked);
            }
            catch (Exception ex)
            {
                AuthenticationKeyAscii = !AuthenticationKey0AsciiCb.Checked;
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
            Security s = (Security)SecurityCB.SelectedItem;
            BlockCipherKeyTB.ReadOnly = s == Security.None || s == Security.Authentication;
            AuthenticationKeyTB.ReadOnly = AuthenticationKey0TB.ReadOnly = s == Security.None || s == Security.Encryption;
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
                Ecc scheme = ss == SecuritySuite.Ecdsa256 ? Ecc.P256 : Ecc.P384;
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
                if (clientST != null)
                {
                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ClientAgreementKeysCb.Items)
                    {
                        if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                        {
                            ClientAgreementKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
                if (serverST != null)
                {
                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ServerAgreementKeysCb.Items)
                    {
                        if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                        {
                            ServerAgreementKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
                if (clientST != null)
                {

                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ClientSigningKeysCb.Items)
                    {
                        if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                        {
                            ClientSigningKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
                if (serverST != null)
                {
                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ServerSigningKeysCb.Items)
                    {
                        if (it.Value != null && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                        {
                            ServerSigningKeysCb.SelectedItem = it;
                            break;
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
                GetAsHex(BlockCipherKeyTB.Text, BlockCipherKeyAsciiCb.Checked, false);
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
                GetAsHex(AuthenticationKey0TB.Text, AuthenticationKey0AsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                AuthenticationKey0TB.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void DedicatedKeyTb_Leave(object sender, EventArgs e)
        {
            try
            {
                GetAsHex(DedicatedKeyTb.Text, DedicatedKeyAsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                DedicatedKeyTb.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void SystemTitleTB_Leave(object sender, EventArgs e)
        {
            try
            {
                GetAsHex(SystemTitleTB.Text, SystemTitleAsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                SystemTitleTB.Select();
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
            if (ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cs)
            {
                ClientSigningKey = cs.Key.ToDer();
            }
            if (ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ca)
            {
                ClientAgreementKey = ca.Key.ToDer();
            }
            if (ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ss)
            {
                ServerSigningKey = ss.Value.ToDer();
            }
            if (ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sa)
            {
                ServerAgreementKey = sa.Value.ToDer();
            }
            if (_checkSystemTitle)
            {
                string st;
                if (SystemTitleAsciiCb.Checked)
                {
                    st = GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(SystemTitleTB.Text), false);
                }
                else
                {
                    st = SystemTitleTB.Text.Replace(" ", "");
                }
                if ((ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cv) && cv.Value != null)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(cv.Value.Subject), false);
                    if (st != certificateSt)
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SystemTitleTB.Text = certificateSt;
                        }
                    }
                }
                if ((ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ck) && ck.Value != null)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(ck.Value.Subject), false);
                    if (st != certificateSt)
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SystemTitleTB.Text = certificateSt;
                        }
                    }
                }

                if (ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sv)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(sv.Value.Subject));
                    if (ServerSystemTitleTB.Text.Replace(" ", "") != certificateSt.Replace(" ", ""))
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the server is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", ServerSystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ServerSystemTitleTB.Text = certificateSt;
                        }
                    }
                }
                if (ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sk)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(sk.Value.Subject));
                    if (ServerSystemTitleTB.Text.Replace(" ", "") != certificateSt.Replace(" ", ""))
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the server is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", ServerSystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ServerSystemTitleTB.Text = certificateSt;
                        }
                    }
                }
            }
        }

        private static void SelectWithPrivateKey(ComboBox items, GXPkcs8 pk)
        {
            bool found = false;
            //Select default values.
            foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in items.Items)
            {
                if (it.Key.Equals(pk))
                {
                    items.SelectedItem = it;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                items.SelectedIndex = items.Items.Add(new KeyValuePair<GXPkcs8, GXx509Certificate>(pk, null));

            }
        }
        private static void SelectWithCertificate(ComboBox items, GXx509Certificate cert)
        {
            bool found = false;
            //Select default values.
            foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in items.Items)
            {
                if (it.Value.Equals(cert))
                {
                    items.SelectedItem = it;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                items.SelectedIndex = items.Items.Add(new KeyValuePair<GXPkcs8, GXx509Certificate>(null, cert));
            }
        }

        public void UpdateKeys()
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
            if (!string.IsNullOrEmpty(ServerSigningKey))
            {
                SelectWithCertificate(ServerSigningKeysCb, GXx509Certificate.FromDer(ServerSigningKey));
            }
            else
            {
                ServerSigningKeysCb.SelectedItem = null;
            }
            if (!string.IsNullOrEmpty(ServerAgreementKey))
            {
                SelectWithCertificate(ServerAgreementKeysCb, GXx509Certificate.FromDer(ServerAgreementKey));
            }
            else
            {
                ServerAgreementKeysCb.SelectedItem = null;
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

        private void SecuritySuiteCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SecuritySuite == SecuritySuite.GMac)
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
            // UpdateBtn_Click(null, null);
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

        private void ServerCertificateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXEcdsaKeysDlg dlg = new GXEcdsaKeysDlg(_address, _keysPath,
                    _certificatesPath,
                   _title,
                   SecuritySuite,
                    GXDLMSTranslator.HexToBytes(GetAsHex(ServerSystemTitle, false, true)));
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

        private void SystemTitleAscii0Cb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(SystemTitle0Tb, SystemTitleAscii0Cb.Checked);
            }
            catch (Exception ex)
            {
                SystemTitleAscii = !SystemTitleAscii0Cb.Checked;
                MessageBox.Show(Parent, ex.Message);
            }
        }
        /// <summary>
        /// Update server system title if Italy standard is used.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerSystemTitle0_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] tmp = GXDLMSTranslator.HexToBytes(ServerSystemTitle0.Text);
                if (tmp.Length == 8)
                {
                    ItalySystemTitleTb.Text = GXDLMSConverter.SystemTitleToString(Standard.Italy, tmp, false);
                }
                else
                {
                    ItalySystemTitleTb.Text = "";
                }
            }
            catch (Exception)
            {
                //Ignore all exceptions.
                ItalySystemTitleTb.Text = "";
            }
        }
    }
}
