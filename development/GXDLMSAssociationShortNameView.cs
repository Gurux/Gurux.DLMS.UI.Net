//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSAssociationShortNameView.cs $
//
// Version:         $Revision: 4781 $,
//                  $Date: 2012-03-19 10:23:38 +0200 (ma, 19 maalis 2012) $
//                  $Author: kurumi $
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
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    [GXDLMSViewAttribute(typeof(GXDLMSAssociationShortName))]
    partial class GXDLMSAssociationShortNameView : Form, IGXDLMSView
    {

        Dictionary<int, ListViewItem> SNItems = new Dictionary<int, ListViewItem>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAssociationShortNameView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user)
        {
            GXDLMSAssociationShortName target = Target as GXDLMSAssociationShortName;
            if (index == 2)
            {
                GXDLMSObjectCollection items = target.ObjectList;
                CallingWindowLV.Items.Clear();
                if (items != null)
                {
                    SNItems.Clear();
                    foreach (GXDLMSObject it in items)
                    {
                        int sn = it.ShortName;
                        ListViewItem li = CallingWindowLV.Items.Add(Convert.ToString(sn, 16));
                        li.SubItems.AddRange(new string[] { it.ObjectType.ToString(), it.Version.ToString(),
                                                        it.LogicalName, "", ""
                                                      });
                        SNItems.Add(sn, li);
                    }
                }
            }
            //Update Access rights.
            if (index == 3)
            {
                //access_rights: access_right
                object[] access = (object[])target.AccessRightsList;
                if (access != null)
                {
                    foreach (object[] it in access)
                    {
                        int sn = (Convert.ToInt32(it[0]) & 0xFFFF);
                        if (SNItems.ContainsKey(sn))
                        {
                            ListViewItem li = SNItems[sn];
                            List<string> modes = new List<string>();
                            foreach (object[] attributeAccess in (object[])it[1])
                            {
                                uint id = Convert.ToUInt32(attributeAccess[0]);
                                AccessMode mode = (AccessMode)Convert.ToInt32(attributeAccess[1]);
                                modes.Add(id.ToString() + " = " + mode);
                            }
                            string str = null;
                            //Show attribute access.
                            foreach (string m in modes)
                            {
                                if (str != null)
                                {
                                    str += ", ";
                                }
                                str += m.ToString();
                            }
                            li.SubItems[4].Text = str;
                            foreach (object[] attributeAccess in (object[])it[2])
                            {
                                uint id = Convert.ToUInt32(attributeAccess[0]);
                                AccessMode mode = (AccessMode)Convert.ToInt32(attributeAccess[1]);
                                modes.Add(id.ToString() + " = " + mode);
                            }
                            //Show Method access.
                            str = null;
                            foreach (string m in modes)
                            {
                                if (str != null)
                                {
                                    str += ", ";
                                }
                                str += m.ToString();
                            }
                            li.SubItems[5].Text = str;
                        }
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access)
        {
        }

        public System.Windows.Forms.ErrorProvider ErrorProvider
        {
            get
            {
                return errorProvider1;
            }
        }

        public string Description
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {

        }

        #endregion



    }
}
