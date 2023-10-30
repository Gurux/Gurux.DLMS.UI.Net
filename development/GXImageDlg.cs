//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL:  $
//
// Version:         $Revision: $,
//                  $Date: $
//                  $Author: gurux01 $
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
// See the GNU General Public License for more details.
//
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.ASN;
using Gurux.DLMS.Ecdsa;
using Gurux.DLMS.ManufacturerSettings;
using Gurux.DLMS.Secure;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Gurux.DLMS.UI
{
    public partial class GXImageDlg : Form
    {
        bool AddSignatureToIdentifier;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXImageDlg(ManufactureSettings settings, GXDLMSClient client)
        {
            InitializeComponent();
            IdentificationTb.Text = Properties.Settings.Default.Identification;
            FileNameTb.Text = Properties.Settings.Default.ImageFile;
            SigningKeyTb.Text = Properties.Settings.Default.SigningKey;
            if (client is GXDLMSSecureClient cl)
            {                
                AddSignatureToIdentifier = cl.Ciphering.SecuritySuite != Objects.Enums.SecuritySuite.Suite0 && 
                    (settings & ManufactureSettings.SignImageWithEcdsa) != 0;
            }
            else
            {
                AddSignatureToIdentifier = false;
            }
            if (!AddSignatureToIdentifier)
            {
                SignatureGb.Visible = false;
            }
        }

        /// <summary>
        /// Get the firmware image.
        /// </summary>
        public byte[] Image
        {
            get;
            private set;
        }

        /// <summary>
        /// Get image identifier.
        /// </summary>
        /// <returns></returns>
        public byte[] GetImageIdentifier()
        {
            GXByteBuffer bb = new GXByteBuffer();
            if (AsciiCb.Checked)
            {
                bb.Set(ASCIIEncoding.ASCII.GetBytes(IdentificationTb.Text));
            }
            else
            {
                bb.SetHexString(IdentificationTb.Text);
            }
            if (AddSignatureToIdentifier)
            {
                bb.SetHexString(SignatureTb.Text);
            }
            return bb.Array();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IdentificationTb.Text.Length == 0)
                {
                    throw new Exception("Image identification is invalid.");
                }
                if (FileNameTb.Text.Length == 0 || !File.Exists(FileNameTb.Text))
                {
                    throw new Exception("Invalid image file.");
                }
                if (string.Compare(Path.GetExtension(FileNameTb.Text), ".xml", true) == 0)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(FileNameTb.Text);
                    byte[] image = null;
                    GetImage(doc.ChildNodes, ref image);
                    Image = image;
                }
                else
                {
                    Image = File.ReadAllBytes(FileNameTb.Text);
                }
                if (AddSignatureToIdentifier)
                {
                    if (SignatureTb.Text.Length == 0)
                    {
                        throw new Exception("Invalid signature.");
                    }

                    Properties.Settings.Default.SigningKey = SigningKeyTb.Text;
                }
                Properties.Settings.Default.Identification = IdentificationTb.Text;
                Properties.Settings.Default.ImageFile = FileNameTb.Text;
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Try to get identification from xml file.
        /// </summary>
        /// <param name="nodes">XML nodes.</param>
        /// <returns>Found dentification.</returns>
        public static byte[] GetIdentification(XmlNodeList nodes)
        {
            foreach (XmlNode it in nodes)
            {
                if (it.NodeType == XmlNodeType.Element && it.ChildNodes.Count == 1 && it.ChildNodes[0].NodeType == XmlNodeType.Text &&
                    it.Name.Contains("Identification"))
                {
                    return GXDLMSTranslator.HexToBytes(it.InnerText);
                }
                else
                {
                    if (it.ChildNodes.Count != 0 && it.FirstChild.NodeType != XmlNodeType.Text)
                    {
                        byte[] ret = GetIdentification(it.ChildNodes);
                        if (ret != null)
                        {
                            return ret;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Try to get image from xml file.
        /// </summary>
        /// <param name="nodes">XML nodes.</param>
        /// <returns>Found dentification.</returns>
        public static void GetImage(XmlNodeList nodes, ref byte[] image)
        {
            foreach (XmlNode it in nodes)
            {
                if (it.NodeType == XmlNodeType.Element && it.ChildNodes.Count == 1 && it.ChildNodes[0].NodeType == XmlNodeType.Text)
                {
                    byte[] tmp = GXDLMSTranslator.HexToBytes(it.InnerText);
                    if (image == null || tmp.Length > image.Length)
                    {
                        image = tmp;
                    }
                }
                else
                {
                    if (it.ChildNodes.Count != 0 && it.FirstChild.NodeType != XmlNodeType.Text)
                    {
                        GetImage(it.ChildNodes, ref image);
                    }
                }
            }
        }


        /// <summary>
        /// Browse image.
        /// </summary>
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = false;
                if (FileNameTb.Text != "")
                {
                    dlg.InitialDirectory = Path.GetDirectoryName(FileNameTb.Text);
                    dlg.FileName = FileNameTb.Text;
                }
                else
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                }
                dlg.Filter = Properties.Resources.ImageFilesTxt;
                dlg.DefaultExt = ".bin";
                dlg.ValidateNames = true;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    FileNameTb.Text = dlg.FileName;
                }
                if (IdentificationTb.Text == "")
                {
                    if (string.Compare(Path.GetExtension(FileNameTb.Text), ".xml", true) == 0)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(FileNameTb.Text);
                        byte[] arr = GetIdentification(doc.ChildNodes);
                        if (GXByteBuffer.IsAsciiString(arr))
                        {
                            IdentificationTb.Text = ASCIIEncoding.ASCII.GetString(arr);
                        }
                        else
                        {
                            IdentificationTb.Text = GXDLMSTranslator.ToHex(arr);
                        }
                    }
                    else
                    {
                        IdentificationTb.Text = Path.GetFileNameWithoutExtension(dlg.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXImageInfoDlg dlg = new GXImageInfoDlg(FileNameTb.Text);
                dlg.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FileNameTb_TextChanged(object sender, EventArgs e)
        {
            InfoBtn.Enabled = FileNameTb.Text.Length != 0;
        }

        private void CertificatesCb_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value is GXx509Certificate cert)
            {
                e.Value = cert.Subject + " #" + cert.SerialNumber;
            }
        }

        /// <summary>
        /// Get the signature for the image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = false;
                if (SigningKeyTb.Text == "" || Path.GetFileName(SigningKeyTb.Text) == "")
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                    dlg.Filter = Properties.Resources.PemFilterTxt;
                    dlg.DefaultExt = ".pem";
                    dlg.ValidateNames = true;
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        SigningKeyTb.Text = dlg.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                GXPkcs8 key = GXPkcs8.Load(SigningKeyTb.Text);
                GXEcdsa ecdsa = new GXEcdsa(key.PrivateKey);
                SignatureTb.Text = GXDLMSTranslator.ToHex(ecdsa.Sign(File.ReadAllBytes(FileNameTb.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = false;
                if (SigningKeyTb.Text == "" || Path.GetFileName(SigningKeyTb.Text) == "")
                {
                    dlg.InitialDirectory = Directory.GetCurrentDirectory();
                    dlg.Filter = Properties.Resources.PemFilterTxt;
                    dlg.DefaultExt = ".pem";
                    dlg.ValidateNames = true;
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        SigningKeyTb.Text = dlg.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
                GXPkcs8 key = GXPkcs8.Load(SigningKeyTb.Text);
                GXEcdsa ecdsa = new GXEcdsa(key.PublicKey);
                if (ecdsa.Verify(GXDLMSTranslator.HexToBytes(SignatureTb.Text), File.ReadAllBytes(FileNameTb.Text)))
                {
                    MessageBox.Show(this, "Verification succeeded.", "Signature verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "Verification failed.", "Signature verification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            if (IdentificationTb.Text != "")
            {
                if (AsciiCb.Checked)
                {
                    IdentificationTb.Text = ASCIIEncoding.ASCII.GetString(GXDLMSTranslator.HexToBytes(IdentificationTb.Text));
                }
                else
                {
                    IdentificationTb.Text = GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(IdentificationTb.Text));
                }
            }
        }
    }
}
