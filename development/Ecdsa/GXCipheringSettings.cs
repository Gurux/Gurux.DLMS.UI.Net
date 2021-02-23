using Gurux.DLMS.ASN;
using Gurux.DLMS.Ecdsa.Enums;
using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects.Enums;
using Gurux.DLMS.Secure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{

    public partial class GXCipheringSettings : Form
    {
        private readonly GXDLMSTranslator _translator;
        private bool _checkSystemTitle = true;

        /// <summary>
        /// Private keys.
        /// </summary>
        private GXPkcs8Collection _privateKeys;
        /// <summary>
        /// Public key certifications.
        /// </summary>
        private GXx509CertificateCollection _certifications;

        public GXCipheringSettings(GXDLMSTranslator translator, string keysPath, string certificatesPath,
                            string clientAgreementKey,
                            string clientSigningKey,
                            string serverAgreementKey,
                            string serverSigningKey)
        {
            InitializeComponent();
            ClientAgreementKey = clientAgreementKey;
            ClientSigningKey = clientSigningKey;
            ServerAgreementKey = serverAgreementKey;
            ServerSigningKey = serverSigningKey;
            _translator = translator;
            _privateKeys = new GXPkcs8Collection();
            _certifications = new GXx509CertificateCollection();
            _privateKeys.Import(keysPath);
            _certifications.Import(certificatesPath);

            SecuritySuiteCb.Items.AddRange(new object[] { SecuritySuite.GMac, SecuritySuite.Ecdsa256, SecuritySuite.Ecdsa384 });
            SecurityCB.Items.AddRange(new object[] { Security.None, Security.Authentication,
                                      Security.Encryption, Security.AuthenticationEncryption});
            InvocationCounterTB.Text = _translator.InvocationCounter.ToString();
            SecuritySuiteCb.SelectedItem = _translator.SecuritySuite;
            SecurityCB.SelectedItem = _translator.Security;

            SystemTitle = translator.SystemTitle;
            ServerSystemTitle = translator.ServerSystemTitle;
            BlockCipherKey = translator.BlockCipherKey;
            AuthenticationKey = translator.AuthenticationKey;
            InvocationCounter = translator.InvocationCounter;
            DedicatedKey = translator.DedicatedKey;

            if (_translator.SystemTitle != null && IsAscii(_translator.SystemTitle))
            {
                SystemTitleAsciiCb.CheckedChanged -= SystemTitleAsciiCb_CheckedChanged;
                SystemTitleAsciiCb.Checked = true;
                SystemTitleAsciiCb.CheckedChanged += SystemTitleAsciiCb_CheckedChanged;
                SystemTitleTB.Text = ASCIIEncoding.ASCII.GetString(_translator.SystemTitle);
            }
            else
            {
                SystemTitleAsciiCb.CheckedChanged -= SystemTitleAsciiCb_CheckedChanged;
                SystemTitleAsciiCb.Checked = false;
                SystemTitleAsciiCb.CheckedChanged += SystemTitleAsciiCb_CheckedChanged;
                SystemTitleTB.Text = GXDLMSTranslator.ToHex(_translator.SystemTitle);
            }
            if (_translator.BlockCipherKey != null && IsAscii(_translator.BlockCipherKey))
            {
                BlockCipherKeyAsciiCb.CheckedChanged -= BlockCipherKeyAsciiCb_CheckedChanged;
                BlockCipherKeyAsciiCb.Checked = true;
                BlockCipherKeyAsciiCb.CheckedChanged += BlockCipherKeyAsciiCb_CheckedChanged;
                BlockCipherKeyTB.Text = ASCIIEncoding.ASCII.GetString(_translator.BlockCipherKey);
            }
            else
            {
                BlockCipherKeyAsciiCb.CheckedChanged -= BlockCipherKeyAsciiCb_CheckedChanged;
                BlockCipherKeyAsciiCb.Checked = false;
                BlockCipherKeyAsciiCb.CheckedChanged += BlockCipherKeyAsciiCb_CheckedChanged;
                BlockCipherKeyTB.Text = GXDLMSTranslator.ToHex(_translator.BlockCipherKey);
            }
            if (_translator.AuthenticationKey != null && IsAscii(_translator.AuthenticationKey))
            {
                AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKey0AsciiCb.Checked = true;
                AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKeyAsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKeyAsciiCb.Checked = true;
                AuthenticationKeyAsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKeyTB.Text = AuthenticationKey0TB.Text = ASCIIEncoding.ASCII.GetString(_translator.AuthenticationKey);
            }
            else
            {
                AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKey0AsciiCb.Checked = false;
                AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKeyAsciiCb.CheckedChanged -= AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKeyAsciiCb.Checked = false;
                AuthenticationKeyAsciiCb.CheckedChanged += AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKeyTB.Text = AuthenticationKey0TB.Text = GXDLMSTranslator.ToHex(_translator.AuthenticationKey);
            }

            if (_translator.DedicatedKey != null && IsAscii(_translator.DedicatedKey))
            {
                DedicatedKeyAsciiCb.CheckedChanged -= DedicatedKeyAsciiCb_CheckedChanged;
                DedicatedKeyAsciiCb.Checked = true;
                DedicatedKeyAsciiCb.CheckedChanged += DedicatedKeyAsciiCb_CheckedChanged;
                DedicatedKeyTb.Text = ASCIIEncoding.ASCII.GetString(_translator.DedicatedKey);
            }
            else
            {
                DedicatedKeyAsciiCb.CheckedChanged -= DedicatedKeyAsciiCb_CheckedChanged;
                DedicatedKeyAsciiCb.Checked = false;
                DedicatedKeyAsciiCb.CheckedChanged += DedicatedKeyAsciiCb_CheckedChanged;
                DedicatedKeyTb.Text = GXDLMSTranslator.ToHex(_translator.DedicatedKey);
            }
            if (_translator.ServerSystemTitle != null && IsAscii(_translator.ServerSystemTitle))
            {
                ServerSystemTitleAsciiCb.CheckedChanged -= ServerSystemTitleAsciiCb_CheckedChanged;
                ServerSystemTitleAsciiCb.Checked = true;
                ServerSystemTitleAsciiCb.CheckedChanged += ServerSystemTitleAsciiCb_CheckedChanged;
                ServerSystemTitleTB.Text = ASCIIEncoding.ASCII.GetString(_translator.ServerSystemTitle);
            }
            else
            {
                ServerSystemTitleAsciiCb.CheckedChanged -= ServerSystemTitleAsciiCb_CheckedChanged;
                ServerSystemTitleAsciiCb.Checked = false;
                ServerSystemTitleAsciiCb.CheckedChanged += ServerSystemTitleAsciiCb_CheckedChanged;
                ServerSystemTitleTB.Text = GXDLMSTranslator.ToHex(_translator.ServerSystemTitle);
            }
            //Add all private keys.
            GXPkcs8 k;
            foreach (GXx509Certificate cert in _certifications)
            {
                k = _privateKeys.Find(cert.PublicKey);
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
                return (SecuritySuite)SecuritySuiteCb.SelectedItem;
            }
            set
            {
                SecuritySuiteCb.SelectedItem = value;
            }
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

        public byte[] SystemTitle
        {
            get
            {
                return GXDLMSTranslator.HexToBytes(GetAsHex(SystemTitleTB.Text, SystemTitleAsciiCb.Checked, false));
            }
            set
            {
                if (ServerSystemTitleAsciiCb.Checked)
                {
                    SystemTitleTB.Text = ASCIIEncoding.ASCII.GetString(value);
                }
                else
                {
                    SystemTitleTB.Text = GXDLMSTranslator.ToHex(value);
                }
            }
        }

        public byte[] ServerSystemTitle
        {
            get
            {
                return GXDLMSTranslator.HexToBytes(GetAsHex(ServerSystemTitleTB.Text, ServerSystemTitleAsciiCb.Checked, false));
            }
            set
            {
                if (ServerSystemTitleAsciiCb.Checked)
                {
                    ServerSystemTitleTB.Text = ASCIIEncoding.ASCII.GetString(value);
                }
                else
                {
                    ServerSystemTitleTB.Text = GXDLMSTranslator.ToHex(value);
                }
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

        public byte[] BlockCipherKey
        {
            get
            {
                return GXDLMSTranslator.HexToBytes(GetAsHex(BlockCipherKeyTB.Text, BlockCipherKeyAsciiCb.Checked, false));
            }
            set
            {
                if (BlockCipherKeyAsciiCb.Checked)
                {
                    BlockCipherKeyTB.Text = ASCIIEncoding.ASCII.GetString(value);
                }
                else
                {
                    BlockCipherKeyTB.Text = GXDLMSTranslator.ToHex(value);
                }
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


        public byte[] AuthenticationKey
        {
            get
            {
                return GXDLMSTranslator.HexToBytes(GetAsHex(AuthenticationKey0TB.Text, AuthenticationKey0AsciiCb.Checked, false));
            }
            set
            {
                if (AuthenticationKey0AsciiCb.Checked)
                {
                    AuthenticationKey0TB.Text = ASCIIEncoding.ASCII.GetString(value);
                }
                else
                {
                    AuthenticationKey0TB.Text = GXDLMSTranslator.ToHex(value);
                }
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
                AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKey0AsciiCb.Checked = value;
                AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKey0AsciiCb_CheckedChanged;
                AuthenticationKeyAsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKeyAsciiCb.Checked = value;
                AuthenticationKeyAsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
            }
        }

        public byte[] DedicatedKey
        {
            get
            {
                return GXDLMSTranslator.HexToBytes(GetAsHex(DedicatedKeyTb.Text, DedicatedKeyAsciiCb.Checked, false));
            }
            set
            {
                if (DedicatedKeyAsciiCb.Checked)
                {
                    DedicatedKeyTb.Text = ASCIIEncoding.ASCII.GetString(value);
                }
                else
                {
                    DedicatedKeyTb.Text = GXDLMSTranslator.ToHex(value);
                }
            }
        }

        public bool DedicatedKeyAscii
        {
            get
            {
                return DedicatedKeyAsciiCb.Checked;
            }
            set
            {
                DedicatedKeyAsciiCb.CheckedChanged -= DedicatedKeyAsciiCb_CheckedChanged;
                DedicatedKeyAsciiCb.Checked = value;
                DedicatedKeyAsciiCb.CheckedChanged += DedicatedKeyAsciiCb_CheckedChanged;
            }
        }

        public byte[] Challenge
        {
            get
            {
                return GXDLMSTranslator.HexToBytes(GetAsHex(ChallengeTb.Text, ChallengeAsciiCb.Checked, false));
            }
            set
            {
                if (ChallengeAsciiCb.Checked)
                {
                    ChallengeTb.Text = ASCIIEncoding.ASCII.GetString(value);
                }
                else
                {
                    ChallengeTb.Text = GXDLMSTranslator.ToHex(value);
                }
            }
        }

        public bool ChallengeAscii
        {
            get
            {
                return ChallengeAsciiCb.Checked;
            }
            set
            {
                ChallengeAsciiCb.CheckedChanged -= ChallengeAsciiCb_CheckedChanged;
                ChallengeAsciiCb.Checked = value;
                ChallengeAsciiCb.CheckedChanged += ChallengeAsciiCb_CheckedChanged;
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
        /// Invocation counter.
        /// </summary>
        public UInt32 InvocationCounter
        {
            get;
            set;
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
        public static string GetAsHex(string value, bool ascii)
        {
            if (ascii)
            {
                return GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(value), false);
            }
            return GXDLMSTranslator.ToHex(GXDLMSTranslator.HexToBytes(value), false);
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
                UpdateValue(SystemTitleTB, SystemTitleAsciiCb.Checked);
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

        private void AuthenticationKey0AsciiCb_CheckedChanged(object sender, EventArgs e)
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

        private void ChallengeAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(ChallengeTb, ChallengeAsciiCb.Checked);
            }
            catch (Exception ex)
            {
                ChallengeAscii = !ChallengeAsciiCb.Checked;
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void PasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXCiphering c = new GXCiphering(null);
                c.SystemTitle = GXDLMSTranslator.HexToBytes(GetAsHex(SystemTitleTB.Text, SystemTitleAsciiCb.Checked));
                c.BlockCipherKey = GXDLMSTranslator.HexToBytes(GetAsHex(BlockCipherKeyTB.Text, BlockCipherKeyAsciiCb.Checked));
                c.AuthenticationKey = GXDLMSTranslator.HexToBytes(GetAsHex(AuthenticationKey0TB.Text, AuthenticationKey0AsciiCb.Checked));
                c.InvocationCounter = UInt32.Parse(InvocationCounterTB.Text);
                MessageBox.Show(Parent, GXDLMSTranslator.ToHex(c.GenerateGmacPassword(GXDLMSTranslator.HexToBytes(GetAsHex(ChallengeTb.Text, ChallengeAsciiCb.Checked))), true));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void ServerSystemTitleAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(ServerSystemTitleTB, ServerSystemTitleAsciiCb.Checked);
            }
            catch (Exception ex)
            {
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
                MessageBox.Show(Parent, ex.Message);
            }
        }


        private void SecurityCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            _translator.Security = Security;
            BlockCipherKeyTB.ReadOnly = _translator.Security == Security.None || _translator.Security == Security.Authentication;
            AuthenticationKey0TB.ReadOnly = _translator.Security == Security.None || _translator.Security == Security.Encryption;
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
                string clientST = null;
                string serverST = null;
                SecuritySuite ss = (SecuritySuite)SecuritySuiteCb.SelectedItem;
                Ecc scheme = ss == SecuritySuite.Ecdsa256 ? Ecc.P256 : Ecc.P384;
                byte[] tmp = GXDLMSTranslator.HexToBytes(SystemTitleTB.Text);
                if (tmp.Length != 0)
                {
                    if (tmp.Length != 8)
                    {
                        throw new Exception("Client system title is invalid.");
                    }
                    clientST = "CN=" + GXDLMSTranslator.ToHex(tmp, false);
                }
                tmp = GXDLMSTranslator.HexToBytes(ServerSystemTitleTB.Text);
                if (tmp.Length != 0)
                {
                    if (tmp.Length != 8)
                    {
                        throw new Exception("Server system title is invalid.");
                    }
                    serverST = "CN=" + GXDLMSTranslator.ToHex(tmp, false);
                }
                ClientAgreementKeysCb.SelectedItem = null;
                ServerAgreementKeysCb.SelectedItem = null;
                ClientSigningKeysCb.SelectedItem = null;
                ServerSigningKeysCb.SelectedItem = null;
                ClientAgreementKey = null;
                ServerAgreementKey = null;
                ClientSigningKey = null;
                ServerSigningKey = null;
                if (clientST != null)
                {
                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ClientAgreementKeysCb.Items)
                    {
                        if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                        {
                            ClientAgreementKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ClientSigningKeysCb.Items)
                    {
                        if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                        {
                            ClientSigningKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                }
                if (serverST != null)
                {
                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ServerAgreementKeysCb.Items)
                    {
                        if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                        {
                            ServerAgreementKeysCb.SelectedItem = it;
                            break;
                        }
                    }
                    foreach (KeyValuePair<GXPkcs8, GXx509Certificate> it in ServerSigningKeysCb.Items)
                    {
                        if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
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
                _translator.BlockCipherKey = GXDLMSTranslator.HexToBytes(GetAsHex(BlockCipherKeyTB.Text, BlockCipherKeyAsciiCb.Checked, false));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void AuthenticationKey0TB_Leave(object sender, EventArgs e)
        {
            try
            {
                _translator.AuthenticationKey = GXDLMSTranslator.HexToBytes(GetAsHex(AuthenticationKey0TB.Text, AuthenticationKey0AsciiCb.Checked, false));
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
                _translator.DedicatedKey = GXDLMSTranslator.HexToBytes(GetAsHex(DedicatedKeyTb.Text, DedicatedKeyAsciiCb.Checked, false));
            }
            catch (Exception ex)
            {
                DedicatedKeyTb.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void InvocationCounterTB_Leave(object sender, EventArgs e)
        {
            try
            {
                if (InvocationCounterTB.Text.Length == 0)
                {
                    InvocationCounter = 0;
                }
                else
                {
                    InvocationCounter = UInt32.Parse(InvocationCounterTB.Text);
                }
                _translator.InvocationCounter = InvocationCounter;
            }
            catch (Exception ex)
            {
                InvocationCounterTB.Select();
                MessageBox.Show(Parent, ex.Message);
            }

        }

        private void ChallengeTb_Leave(object sender, EventArgs e)
        {
            try
            {
                GetAsHex(ChallengeTb.Text, ChallengeAsciiCb.Checked, false);
            }
            catch (Exception ex)
            {
                ChallengeTb.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void SystemTitleTB_Leave(object sender, EventArgs e)
        {
            try
            {
                _translator.SystemTitle = GXDLMSTranslator.HexToBytes(GetAsHex(SystemTitleTB.Text, SystemTitleAsciiCb.Checked, false));
            }
            catch (Exception ex)
            {
                SystemTitleTB.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void ServerSystemTitleTB_Leave(object sender, EventArgs e)
        {
            try
            {
                _translator.ServerSystemTitle = GXDLMSTranslator.HexToBytes(GetAsHex(ServerSystemTitleTB.Text, ServerSystemTitleAsciiCb.Checked, false));
            }
            catch (Exception ex)
            {
                ServerSystemTitleTB.Select();
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void ClientSigningKeysCb_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value is KeyValuePair<GXPkcs8, GXx509Certificate> kp)
            {
                e.Value = kp.Value.Subject + " #" + kp.Value.SerialNumber;
            }
        }

        /// <summary>
        /// Update private and public keys to the translator.
        /// </summary>
        private void UpdateKeys()
        {
            _translator.Keys.Clear();
            if (ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cs)
            {
                _translator.Keys.Add(cs);
                ClientSigningKey = cs.Value.SerialNumber.ToString();
            }
            if (ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ca)
            {
                _translator.Keys.Add(ca);
                ClientAgreementKey = ca.Value.SerialNumber.ToString();
            }
            if (ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ss)
            {
                _translator.Keys.Add(ss);
                ServerSigningKey = ss.Value.SerialNumber.ToString();
            }
            if (ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sa)
            {
                _translator.Keys.Add(sa);
                ServerAgreementKey = sa.Value.SerialNumber.ToString();
            }
            if (_checkSystemTitle)
            {
                if (ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cv)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(cv.Value.Subject));
                    if (SystemTitleTB.Text.Replace(" ", "") != certificateSt.Replace(" ", ""))
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SystemTitleTB.Text = certificateSt;
                        }
                    }
                }
                if (ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ck)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(ck.Value.Subject));
                    if (SystemTitleTB.Text.Replace(" ", "") != certificateSt.Replace(" ", ""))
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

        /// <summary>
        /// Update client signing key.
        /// </summary>
        private void ClientSigningKeysCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateKeys();
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
                UpdateKeys();
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
                UpdateKeys();
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
                UpdateKeys();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message);
            }
        }

        private void SecuritySuiteCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _translator.SecuritySuite = SecuritySuite;
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

                if (Created)
                {
                    UpdateBtn_Click(null, null);
                }
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
                _translator.AuthenticationKey = GXDLMSTranslator.HexToBytes(GetAsHex(AuthenticationKeyTB.Text, AuthenticationKeyAsciiCb.Checked, false));
            }
            catch (Exception ex)
            {
                AuthenticationKey0TB.Select();
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
    }
}
