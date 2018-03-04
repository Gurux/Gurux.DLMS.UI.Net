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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Gurux.DLMS.UI
{
    public partial class GXImageDlg : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXImageDlg()
        {
            InitializeComponent();
            FileNameTb.Text = Properties.Settings.Default.ImageFile;
        }

        public byte[] Image
        {
            get;
            private set;
        }

        public bool IsAscii
        {
            get
            {
                return AsciiCb.Checked;
            }
        }


        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextTb.Text.Length == 0)
                {
                    throw new Exception("Image identification is invalid.");
                }
                if (FileNameTb.Text.Length == 0 || !File.Exists(FileNameTb.Text))
                {
                    throw new Exception("Invalid image.");
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
        /// Try to get identification from xml file.
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
                if (TextTb.Text == "")
                {
                    if (string.Compare(Path.GetExtension(FileNameTb.Text), ".xml", true) == 0)
                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load(FileNameTb.Text);
                        byte[] arr = GetIdentification(doc.ChildNodes);
                        if (GXByteBuffer.IsAsciiString(arr))
                        {
                            TextTb.Text = ASCIIEncoding.ASCII.GetString(arr);
                        }
                        else
                        {
                            TextTb.Text = GXDLMSTranslator.ToHex(arr);
                        }
                    }
                    else
                    {
                        TextTb.Text = Path.GetFileNameWithoutExtension(dlg.FileName);
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
    }
}
