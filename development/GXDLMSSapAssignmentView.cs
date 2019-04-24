//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSSapAssignmentView.cs $
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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
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
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSSapAssignment
    /// </summary>
    [GXDLMSViewAttribute(typeof(Gurux.DLMS.Objects.GXDLMSSapAssignment))]
    partial class GXDLMSSapAssignmentView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSSapAssignmentView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            if (index == 2)
            {
                GXDLMSSapAssignment target = Target as GXDLMSSapAssignment;
                SapAssignmentView.Items.Clear();
                if (target.SapAssignmentList != null)
                {
                    foreach (var it in target.SapAssignmentList)
                    {
                        ListViewItem li = SapAssignmentView.Items.Add(Convert.ToString(it.Key, 16));
                        li.SubItems.Add(it.Value);
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
        }
        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        delegate void ShowUserDialogEventHandler(bool addUser, GXActionArgs arg);

        void OnShowDialog(bool addUser, GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowUserDialogEventHandler(OnShowDialog), addUser, arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXDLMSSapAssignment target = Target as GXDLMSSapAssignment;
                if (addUser)
                {
                    GXSapDlg dlg = new GXSapDlg(0, "", false);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        ListViewItem li = SapAssignmentView.Items.Add(dlg.SapId.ToString());
                        li.SubItems.Add(dlg.LogicalDeviceName);
                        arg.Value = target.AddSap(arg.Client, dlg.SapId, dlg.LogicalDeviceName);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else
                {
                    if (SapAssignmentView.SelectedItems.Count == 1)
                    {
                        ListViewItem li = SapAssignmentView.SelectedItems[0];
                        GXSapDlg dlg = new GXSapDlg(UInt16.Parse(li.SubItems[0].Text), li.SubItems[1].Text, true);
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            arg.Value = target.RemoveSap(arg.Client, dlg.LogicalDeviceName);
                            li.Remove();
                        }
                        else
                        {
                            arg.Handled = true;
                        }
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            //Add object to SAP assignment.
            if (arg.Index == 1)
            {
                OnShowDialog(true, arg);
            }
            else if (arg.Index == 2)
            {
                // Remove object from SAP assignment.
                OnShowDialog(false, arg);
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            arg.Action = ActionType.None;
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
