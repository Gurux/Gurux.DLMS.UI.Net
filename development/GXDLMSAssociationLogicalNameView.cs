//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSAssociationLogicalNameView.cs $
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
using Gurux.DLMS;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    [GXDLMSViewAttribute(typeof(GXDLMSAssociationLogicalName))]
    partial class GXDLMSAssociationLogicalNameView : Form, IGXDLMSView
    {











        private System.ComponentModel.IContainer components;



        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAssociationLogicalNameView()
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
            if (index == 2)
            {
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                GXDLMSObjectCollection items = target.ObjectList;
                CallingWindowLV.Items.Clear();
                if (items != null)
                {
                    foreach (GXDLMSObject it in items)
                    {
                        ListViewItem li = CallingWindowLV.Items.Add(it.ObjectType.ToString());
                        li.SubItems.Add(it.Version.ToString()); //Version
                        li.SubItems.Add(it.LogicalName);
                        //access_rights: access_right
                        if (it is IGXDLMSBase)
                        {
                            string str = null;
                            //Show attribute access.
                            int cnt = (it as IGXDLMSBase).GetAttributeCount();
                            for (int pos = 1; pos != cnt + 1; ++pos)
                            {
                                if (str != null)
                                {
                                    str += ", ";
                                }
                                AccessMode mode = it.GetAccess(pos);
                                str += pos.ToString() + " = " + mode;
                            }
                            li.SubItems.Add(str);
                            //Show method access.
                            str = null;
                            cnt = (it as IGXDLMSBase).GetMethodCount();
                            for (int pos = 1; pos != cnt + 1; ++pos)
                            {
                                if (str != null)
                                {
                                    str += ", ";
                                }
                                MethodAccessMode mode = it.GetMethodAccess(pos);
                                str += pos.ToString() + " = " + mode;
                            }
                            li.SubItems.Add(str);
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
