using Gurux.DLMS.ASN;
using Gurux.DLMS.ASN.Enums;
using Gurux.DLMS.Ecdsa;
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
        private bool _checkSystemTitle;

        /// <summary>
        /// Private keys.
        /// </summary>
        private GXPkcs8Collection _privateKeys;
        /// <summary>
        /// Public key certifications.
        /// </summary>
        private GXx509CertificateCollection _certifications;

        /// <summary>
        /// Public key certifications.
        /// </summary>
        public List<KeyValuePair<GXPkcs8, GXx509Certificate>> KeyPairs;

        public GXCipheringSettings(GXDLMSTranslator translator, string keysPath, string certificatesPath,
                            string clientAgreementKey,
                            string clientSigningKey,
                            string serverAgreementKey,
                            string serverSigningKey)
        {
            InitializeComponent();
            KeyPairs = new List<KeyValuePair<GXPkcs8, GXx509Certificate>>();
            ClientAgreementKey = clientAgreementKey;
            ClientSigningKey = clientSigningKey;
            ServerAgreementKey = serverAgreementKey;
            ServerSigningKey = serverSigningKey;
            _translator = translator;
            _privateKeys = new GXPkcs8Collection();
            _certifications = new GXx509CertificateCollection();
            _privateKeys.Import(keysPath);
            _certifications.Import(certificatesPath);

            SecuritySuiteCb.Items.AddRange(new object[] { SecuritySuite.Suite0, SecuritySuite.Suite1, SecuritySuite.Suite2 });
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
                AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKey0AsciiCb.Checked = true;
                AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKeyTB.Text = ASCIIEncoding.ASCII.GetString(_translator.AuthenticationKey);
            }
            else
            {
                AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKey0AsciiCb.Checked = false;
                AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKeyTB.Text = GXDLMSTranslator.ToHex(_translator.AuthenticationKey);
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
            ClientAgreementKeysCb.Items.Add("");
            ServerAgreementKeysCb.Items.Add("");
            ClientSigningKeysCb.Items.Add("");
            ServerSigningKeysCb.Items.Add("");
            GXPkcs8 k;
            foreach (GXx509Certificate cert in _certifications)
            {
                k = _privateKeys.Find(cert.PublicKey);
                KeyValuePair<GXPkcs8, GXx509Certificate> tmp = new KeyValuePair<GXPkcs8, GXx509Certificate>(k, cert);
                KeyPairs.Add(tmp);
                if ((cert.KeyUsage & KeyUsage.KeyAgreement) != 0)
                {
                    ClientAgreementKeysCb.Items.Add(tmp);
                    ServerAgreementKeysCb.Items.Add(tmp);
                }
                if ((cert.KeyUsage & KeyUsage.DigitalSignature) != 0)
                {
                    ClientSigningKeysCb.Items.Add(tmp);
                    ServerSigningKeysCb.Items.Add(tmp);
                }
            }
            //Select default values.
            if (!string.IsNullOrEmpty(clientSigningKey))
            {
                foreach (object tmp in ClientSigningKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == clientSigningKey)
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
            if (!string.IsNullOrEmpty(clientAgreementKey))
            {
                foreach (object tmp in ClientAgreementKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == clientAgreementKey)
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

            if (!string.IsNullOrEmpty(serverSigningKey))
            {
                foreach (object tmp in ServerSigningKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == serverSigningKey)
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

            if (!string.IsNullOrEmpty(serverAgreementKey))
            {
                foreach (object tmp in ServerAgreementKeysCb.Items)
                {
                    if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                    {
                        if (it.Value.SerialNumber.ToString() == serverAgreementKey)
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
            _checkSystemTitle = true;
        }

        /// <summary>
        /// Find private key.
        /// </summary>
        /// <param name="securitySuite">Used security suite.</param>
        /// <param name="certificateType">Certificate type.</param>
        /// <param name="systemTitle">System title.</param>
        /// <returns>Found private key or null, if key not fould.</returns>
        public GXPrivateKey FindPrivateKey(SecuritySuite securitySuite, CertificateType certificateType, byte[] systemTitle)
        {
            Ecc scheme;
            KeyUsage keyUsage;
            if (securitySuite == SecuritySuite.Suite1)
            {
                scheme = Ecc.P256;
            }
            else if (securitySuite == SecuritySuite.Suite2)
            {
                scheme = Ecc.P256;
            }
            else
            {
                throw new Exception("GMAC is not use certificates.");
            }
            if (certificateType == CertificateType.DigitalSignature)
            {
                keyUsage = KeyUsage.DigitalSignature;
            }
            else if (certificateType == CertificateType.KeyAgreement)
            {
                keyUsage = KeyUsage.KeyAgreement;
            }
            else if (certificateType == CertificateType.TLS)
            {
                keyUsage = (KeyUsage.DigitalSignature | KeyUsage.KeyAgreement);
            }
            else
            {
                keyUsage = KeyUsage.None;
            }
            string st = "CN=" + GXDLMSTranslator.ToHex(systemTitle, false);
            foreach (var it in KeyPairs)
            {
                if (it.Key != null && it.Value.KeyUsage == keyUsage && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(st))
                {
                    return it.Key.PrivateKey;
                }
            }
            return null;
        }

        /// <summary>
        /// Find public key.
        /// </summary>
        /// <param name="securitySuite">Used security suite.</param>
        /// <param name="keyUsage">Key usage.</param>
        /// <param name="systemTitle">System title.</param>
        /// <returns>Found public key or null, if key not fould.</returns>
        public GXPublicKey FindPublicKey(SecuritySuite securitySuite, CertificateType certificateType, byte[] systemTitle)
        {
            Ecc scheme;
            KeyUsage keyUsage;
            if (securitySuite == SecuritySuite.Suite1)
            {
                scheme = Ecc.P256;
            }
            else if (securitySuite == SecuritySuite.Suite2)
            {
                scheme = Ecc.P256;
            }
            else
            {
                throw new Exception("GMAC is not use certificates.");
            }
            if (certificateType == CertificateType.DigitalSignature)
            {
                keyUsage = KeyUsage.DigitalSignature;
            }
            else if (certificateType == CertificateType.KeyAgreement)
            {
                keyUsage = KeyUsage.KeyAgreement;
            }
            else if (certificateType == CertificateType.TLS)
            {
                keyUsage = (KeyUsage.DigitalSignature | KeyUsage.KeyAgreement);
            }
            else
            {
                keyUsage = KeyUsage.None;
            }
            string st = "CN=" + GXDLMSTranslator.ToHex(systemTitle, false);
            foreach (var it in KeyPairs)
            {
                if (it.Value.KeyUsage == keyUsage && it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(st))
                {
                    return it.Value.PublicKey;
                }
            }
            return null;
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
                SystemTitleAscii = value.Length != 8;
                if (SystemTitleAsciiCb.Checked)
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
                ServerSystemTitleAsciiCb.Checked = value.Length != 8;
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

        public bool ServerSystemTitleAscii
        {
            get
            {
                return ServerSystemTitleAsciiCb.Checked;
            }
            set
            {
                ServerSystemTitleAsciiCb.CheckedChanged -= ServerSystemTitleAsciiCb_CheckedChanged;
                ServerSystemTitleAsciiCb.Checked = value;
                ServerSystemTitleAsciiCb.CheckedChanged += ServerSystemTitleAsciiCb_CheckedChanged;
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
                return GXDLMSTranslator.HexToBytes(GetAsHex(AuthenticationKeyTB.Text, AuthenticationKey0AsciiCb.Checked, false));
            }
            set
            {
                if (AuthenticationKey0AsciiCb.Checked)
                {
                    AuthenticationKeyTB.Text = ASCIIEncoding.ASCII.GetString(value);
                }
                else
                {
                    AuthenticationKeyTB.Text = GXDLMSTranslator.ToHex(value);
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
                AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                AuthenticationKey0AsciiCb.Checked = value;
                AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
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

        private void AuthenticationKeyAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateValue(AuthenticationKeyTB, AuthenticationKey0AsciiCb.Checked);
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
                c.AuthenticationKey = GXDLMSTranslator.HexToBytes(GetAsHex(AuthenticationKeyTB.Text, AuthenticationKey0AsciiCb.Checked));
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
            BlockCipherKeyTB.ReadOnly = _translator.Security == Security.None;
            AuthenticationKeyTB.ReadOnly = _translator.Security == Security.None || _translator.Security == Security.Encryption;
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
                Ecc scheme = ss == SecuritySuite.Suite1 ? Ecc.P256 : Ecc.P384;
                if (_translator.SystemTitle != null && _translator.SystemTitle.Length != 0)
                {
                    clientST = "CN=" + GXDLMSTranslator.ToHex(_translator.SystemTitle, false);
                }
                if (_translator.ServerSystemTitle != null && _translator.ServerSystemTitle.Length != 0)
                {
                    serverST = "CN=" + GXDLMSTranslator.ToHex(_translator.ServerSystemTitle, false);
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
                    foreach (object tmp in ClientAgreementKeysCb.Items)
                    {
                        if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                            {
                                ClientAgreementKeysCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                    foreach (object tmp in ClientSigningKeysCb.Items)
                    {
                        if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(clientST))
                            {
                                ClientSigningKeysCb.SelectedItem = it;
                                break;
                            }
                        }
                    }                   
                }
                if (serverST != null)
                {
                    foreach (object tmp in ServerAgreementKeysCb.Items)
                    {
                        if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                            {
                                ServerAgreementKeysCb.SelectedItem = it;
                                break;
                            }
                        }
                    }
                    foreach (object tmp in ServerSigningKeysCb.Items)
                    {
                        if (tmp is KeyValuePair<GXPkcs8, GXx509Certificate> it)
                        {
                            if (it.Value.PublicKey.Scheme == scheme && it.Value.Subject.Contains(serverST))
                            {
                                ServerSigningKeysCb.SelectedItem = it;
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
                        if (BlockCipherKeyAsciiCb.Checked)
                        {
                            BlockCipherKeyAsciiCb.CheckedChanged -= BlockCipherKeyAsciiCb_CheckedChanged;
                            BlockCipherKeyAsciiCb.Checked = false;
                            BlockCipherKeyAsciiCb.CheckedChanged += BlockCipherKeyAsciiCb_CheckedChanged;
                        }
                    }
                    else if (len == 16)
                    {
                        if (!BlockCipherKeyAsciiCb.Checked)
                        {
                            BlockCipherKeyAsciiCb.CheckedChanged -= BlockCipherKeyAsciiCb_CheckedChanged;
                            BlockCipherKeyAsciiCb.Checked = true;
                            BlockCipherKeyAsciiCb.CheckedChanged += BlockCipherKeyAsciiCb_CheckedChanged;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid block cipher key.");
                    }
                }
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
                int len = AuthenticationKeyTB.Text.Replace(" ", "").Length;
                if (len != 0)
                {
                    if (len == 32)
                    {
                        if (AuthenticationKey0AsciiCb.Checked)
                        {
                            AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                            AuthenticationKey0AsciiCb.Checked = false;
                            AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
                        }
                    }
                    else if (len == 16)
                    {
                        if (!AuthenticationKey0AsciiCb.Checked)
                        {
                            AuthenticationKey0AsciiCb.CheckedChanged -= AuthenticationKeyAsciiCb_CheckedChanged;
                            AuthenticationKey0AsciiCb.Checked = true;
                            AuthenticationKey0AsciiCb.CheckedChanged += AuthenticationKeyAsciiCb_CheckedChanged;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid authentication key.");
                    }
                }
                _translator.AuthenticationKey = GXDLMSTranslator.HexToBytes(GetAsHex(AuthenticationKeyTB.Text, AuthenticationKey0AsciiCb.Checked, false));
            }
            catch (Exception ex)
            {
                AuthenticationKeyTB.Select();
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
                        if (DedicatedKeyAsciiCb.Checked)
                        {
                            DedicatedKeyAsciiCb.CheckedChanged -= DedicatedKeyAsciiCb_CheckedChanged;
                            DedicatedKeyAsciiCb.Checked = false;
                            DedicatedKeyAsciiCb.CheckedChanged += DedicatedKeyAsciiCb_CheckedChanged;
                        }
                    }
                    else if (len == 16)
                    {
                        if (!DedicatedKeyAsciiCb.Checked)
                        {
                            DedicatedKeyAsciiCb.CheckedChanged -= DedicatedKeyAsciiCb_CheckedChanged;
                            DedicatedKeyAsciiCb.Checked = true;
                            DedicatedKeyAsciiCb.CheckedChanged += DedicatedKeyAsciiCb_CheckedChanged;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid dedicated key.");
                    }
                }
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

        /// <summary>
        /// Update ASCII checked when focus is moved out.
        /// </summary>
        private void SystemTitleTB_Leave(object sender, EventArgs e)
        {
            try
            {
                int len = SystemTitleTB.Text.Replace(" ", "").Length;
                if (len != 0)
                {
                    if (len == 16)
                    {
                        if (SystemTitleAsciiCb.Checked)
                        {
                            SystemTitleAscii = false;
                        }
                    }
                    else if (len == 8)
                    {
                        if (!SystemTitleAsciiCb.Checked)
                        {
                            SystemTitleAscii = true;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid system title.");
                    }
                }
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
                int len = ServerSystemTitleTB.Text.Replace(" ", "").Length;
                if (len != 0)
                {
                    if (len == 16)
                    {
                        if (ServerSystemTitleAsciiCb.Checked)
                        {
                            ServerSystemTitleAsciiCb.CheckedChanged -= ServerSystemTitleAsciiCb_CheckedChanged;
                            ServerSystemTitleAsciiCb.Checked = false;
                            ServerSystemTitleAsciiCb.CheckedChanged += ServerSystemTitleAsciiCb_CheckedChanged;
                        }
                    }
                    else if (len == 8)
                    {
                        if (!ServerSystemTitleAsciiCb.Checked)
                        {
                            ServerSystemTitleAsciiCb.CheckedChanged -= ServerSystemTitleAsciiCb_CheckedChanged;
                            ServerSystemTitleAsciiCb.Checked = true;
                            ServerSystemTitleAsciiCb.CheckedChanged += ServerSystemTitleAsciiCb_CheckedChanged;
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid system title.");
                    }
                }
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
            if (_checkSystemTitle)
            {
                _translator.Keys.Clear();
                if (ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cs)
                {
                    _translator.Keys.Add(cs);
                    ClientSigningKey = cs.Value.SerialNumber.ToString();
                }
                else
                {
                    ClientSigningKey = null;
                }
                if (ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ca)
                {
                    _translator.Keys.Add(ca);
                    ClientAgreementKey = ca.Value.SerialNumber.ToString();
                }
                else
                {
                    ClientAgreementKey = null;
                }
                if (ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ss)
                {
                    _translator.Keys.Add(ss);
                    ServerSigningKey = ss.Value.SerialNumber.ToString();
                }
                else
                {
                    ServerSigningKey = null;
                }
                if (ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sa)
                {
                    _translator.Keys.Add(sa);
                    ServerAgreementKey = sa.Value.SerialNumber.ToString();
                }
                else
                {
                    ServerAgreementKey = null;
                }               
                bool check = _checkSystemTitle;
                if (check && ClientSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> cv)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(cv.Value.Subject), true);
                    if (GXDLMSTranslator.ToHex(_translator.SystemTitle, true) != certificateSt)
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SystemTitleAscii = false;
                            SystemTitleTB.Text = certificateSt;
                            SystemTitleTB_Leave(null, null);
                            check = false;
                        }
                    }
                }
                if (check && ClientAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> ck)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(ck.Value.Subject), true);
                    if (GXDLMSTranslator.ToHex(_translator.SystemTitle, true) != certificateSt)
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the client is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", SystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SystemTitleAscii = false;
                            SystemTitleTB.Text = certificateSt;
                            SystemTitleTB_Leave(null, null);
                            check = false;
                        }
                    }
                }

                if (check && ServerSigningKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sv)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(sv.Value.Subject), true);
                    if (GXDLMSTranslator.ToHex(_translator.ServerSystemTitle, true) != certificateSt)
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the server is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", ServerSystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ServerSystemTitleAsciiCb.Checked = false;
                            ServerSystemTitleTB.Text = certificateSt;
                            ServerSystemTitleTB_Leave(null, null);
                            check = false;
                        }
                    }
                }
                if (check && ServerAgreementKeysCb.SelectedItem is KeyValuePair<GXPkcs8, GXx509Certificate> sk)
                {
                    string certificateSt = GXDLMSTranslator.ToHex(GXAsn1Converter.SystemTitleFromSubject(sk.Value.Subject), true);
                    if (GXDLMSTranslator.ToHex(_translator.ServerSystemTitle, true) != certificateSt)
                    {
                        if (MessageBox.Show(Parent, string.Format("System title '{0}' of the server is different than in the certificate '{1}'. Do you want to update the system title from the certificate?", ServerSystemTitleTB.Text, certificateSt), "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ServerSystemTitleAsciiCb.Checked = false;
                            ServerSystemTitleTB.Text = certificateSt;
                            ServerSystemTitleTB_Leave(null, null);
                            check = false;
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
                if (SecuritySuite == SecuritySuite.Suite0)
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
      
        private void ServerSystemTitleTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toolTip1.SetToolTip(SystemTitleDescriptionTb, null);
                byte[] tmp = GXDLMSTranslator.HexToBytes(ServerSystemTitleTB.Text);
                if (tmp.Length == 8)
                {
                    SystemTitleDescriptionTb.Text = GXDLMSConverter.SystemTitleToString(Standard.DLMS, tmp, false);
                    toolTip1.SetToolTip(SystemTitleDescriptionTb, GXDLMSConverter.SystemTitleToString(Standard.DLMS, tmp, true));
                }
                else
                {
                    SystemTitleDescriptionTb.Text = "";
                }
            }
            catch (Exception)
            {
                //Ignore all exceptions.
                SystemTitleDescriptionTb.Text = "";
            }
        }

        /// <summary>
        /// Update client TLS.
        /// </summary>
        private void ClientTlsCb_SelectedIndexChanged(object sender, EventArgs e)
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
        /// Update server TLS.
        /// </summary>
        private void ServerTlsCb_SelectedIndexChanged(object sender, EventArgs e)
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

        private void ClientTlsCb_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value is KeyValuePair<GXPkcs8, GXx509Certificate> kp)
            {
                e.Value = kp.Value.Subject + " #" + kp.Value.SerialNumber;
            }
        }

        private void ServerTlsCb_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value is KeyValuePair<GXPkcs8, GXx509Certificate> kp)
            {
                e.Value = kp.Value.Subject + " #" + kp.Value.SerialNumber;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClientSigningKeysCb.SelectedIndex = 0;
            ClientAgreementKeysCb.SelectedIndex = 0;
            ServerSigningKeysCb.SelectedIndex = 0;
            ServerAgreementKeysCb.SelectedIndex = 0;
        }

        private void Cipheringv1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
