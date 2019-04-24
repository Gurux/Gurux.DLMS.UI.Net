//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSRegisterActivationView.cs $
//
// Version:         $Revision: 8933 $,
//                  $Date: 2016-11-23 09:20:07 +0200 (ke, 23 marras 2016) $
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSRegisterActivation
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSRegisterActivation))]
    partial class GXDLMSRegisterActivationView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSRegisterActivationView()
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
            GXDLMSRegisterActivation target = (GXDLMSRegisterActivation)Target;
            if (index == 2)
            {
                // register_assignment
                Assigments.Items.Clear();
                if (target.RegisterAssignment != null)
                {
                    foreach (GXDLMSObjectDefinition it in target.RegisterAssignment)
                    {
                        ListViewItem li = new ListViewItem(it.ObjectType.ToString());
                        li.SubItems.Add(it.LogicalName);
                        Assigments.Items.Add(li);
                    }
                }
            }
            else if (index == 3)
            {
                // mask_list
                Masks.Items.Clear();
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<byte[], byte[]> it in target.MaskList)
                {
                    ListViewItem li = new ListViewItem(GXDLMSTranslator.ToHex(it.Key));
                    sb.Length = 0;
                    foreach (byte v in it.Value)
                    {
                        sb.Append(v);
                        sb.Append(", ");
                    }
                    if (sb.Length != 0)
                    {
                        sb.Length -= 2;
                    }
                    li.SubItems.Add(sb.ToString());
                    Masks.Items.Add(li);
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 2)
            {
                // register_assignment
                Assigments.Enabled = access != AccessMode.NoAccess;
            }
            else if (index == 3)
            {
                // mask_list
                Masks.Enabled = access != AccessMode.NoAccess;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        delegate void ShowDlgEventHandler(GXActionArgs arg, GXDLMSTargetObjectDlg dlg, GXDLMSObjectDefinition it);

        void OnShowDlg(GXActionArgs arg, GXDLMSTargetObjectDlg dlg, GXDLMSObjectDefinition it)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDlgEventHandler(OnShowDlg), arg, dlg, it).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXDLMSRegisterActivation target = (GXDLMSRegisterActivation)Target;
                ListViewItem li = null;
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    it.ObjectType = dlg.Target.ObjectType;
                    it.LogicalName = dlg.Target.LogicalName;
                    li = Assigments.Items.Add(it.ObjectType.ToString());
                    li.SubItems.Add(it.LogicalName);
                    li.Tag = it;
                  //TODO:  arg.Value = target.AddRegister(arg.Client, dlg.Target);
                }
                else
                {
                    arg.Handled = true;
                }
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    GXDLMSObjectDefinition item = new GXDLMSObjectDefinition();
                    GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Add new register", null, Target.Parent);
                    OnShowDlg(arg, dlg, item);
                }
                else
                {
                    arg.Handled = true;
                }
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
                return DescriptionTB.Text;
            }
            set
            {
                DescriptionTB.Text = value;
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {

        }

        #endregion            
    }
}
