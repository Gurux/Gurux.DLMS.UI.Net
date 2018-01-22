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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Gurux.DLMS.UI
{
    public partial class GXImageInfoDlg : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="stream">Image file.</param>
        public GXImageInfoDlg(string path)
        {
            InitializeComponent();
            if (string.Compare(Path.GetExtension(path), ".xml", true) == 0)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(File.ReadAllText(path));
                GetNodes(doc.ChildNodes);
            }
            else
            {
                FileInfo fi = new FileInfo(path);
                ListViewItem li = ImageInfo.Items.Add("Image size:");
                li.SubItems.Add(fi.Length.ToString());
            }
        }

        private void GetNodes(XmlNodeList nodes)
        {
            foreach (XmlNode it in nodes)
            {
                if (it.NodeType == XmlNodeType.Element && it.ChildNodes.Count == 1 && it.ChildNodes[0].NodeType == XmlNodeType.Text)
                {
                    //Image is not shown.
                    if (it.InnerText == null || it.InnerText.Length < 200)
                    {
                        ListViewItem li = ImageInfo.Items.Add(it.Name);
                        li.SubItems.Add(it.InnerText);
                    }
                }
                else
                {
                    if (it.ChildNodes.Count != 0 && it.FirstChild.NodeType != XmlNodeType.Text)
                    {
                        GetNodes(it.ChildNodes);
                    }
                }
            }
        }
    }
}
