using Gurux.DLMS.ASN;
using Gurux.DLMS.Ecdsa;
using Gurux.DLMS.Ecdsa.Enums;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gurux.DLMS.UI.Ecdsa
{
    public partial class GXPrivateKeyForm : Form
    {
        public GXPrivateKeyForm()
        {
            InitializeComponent();
        }

        public GXPkcs8 Key
        {
            get;
            private set;
        }

        /// <summary>
        /// Generate new private key.
        /// </summary>
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PrivateKey.Text = "";
                GeneratedKeyTb.Text = "";
                KeyValuePair<GXPrivateKey, GXPublicKey> k = GXEcdsa.GenerateKeyPair(Key256.Checked ? Ecc.P256 : Ecc.P384);
                GXEcdsa.Validate(k.Value);
                Key = new GXPkcs8(k);
                GXEcdsa.Validate(Key.PublicKey);
                PrivateKey.Text = Key.ToPem();
                UpdateGeneratedKey();
            }
            catch (Exception ex)
            {
                Key = null;
                MessageBox.Show(this, ex.Message);
            }
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (Key == null)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, "Private key is not generated.");
            }
        }

        private void UpdateGeneratedKey()
        {
            GeneratedKeyTb.Text = Key.ToPem() + Environment.NewLine + Environment.NewLine + Environment.NewLine + Key.ToString();
        }

        private void TransformBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratedKeyTb.Text = "";
                if (string.IsNullOrEmpty(PrivateKey.Text))
                {
                    KeyValuePair<GXPrivateKey, GXPublicKey> k = GXEcdsa.GenerateKeyPair(Key256.Checked ? Ecc.P256 : Ecc.P384);
                    Key = new GXPkcs8(k);
                    GXEcdsa.Validate(k.Value);
                }
                else
                {
                    Key = GXPkcs8.Import(PrivateKey.Text);
                }
                UpdateGeneratedKey();
            }
            catch (Exception ex)
            {
                Key = null;
                MessageBox.Show(this, ex.Message);
            }
        }
    }
}
