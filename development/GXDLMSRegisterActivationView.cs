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

using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
                ActiveMasksCb.Items.Clear();
                StringBuilder sb = new StringBuilder();
                string str;
                foreach (KeyValuePair<byte[], byte[]> it in target.MaskList)
                {
                    if (IsAscii(it.Key))
                    {
                        str = ASCIIEncoding.ASCII.GetString(it.Key);
                    }
                    else
                    {
                        str = GXDLMSTranslator.ToHex(it.Key);
                    }
                    ListViewItem li = new ListViewItem(str);
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
                    li.Tag = it;
                    Masks.Items.Add(li);
                    ActiveMasksCb.Items.Add(str);
                }
            }
            else if (index == 4)
            {
                string str;
                if (target.ActiveMask != null && IsAscii(target.ActiveMask))
                {
                    str = ASCIIEncoding.ASCII.GetString(target.ActiveMask);
                }
                else
                {
                    str = GXDLMSTranslator.ToHex(target.ActiveMask);
                }
                this.ActiveMasksCb.SelectedIndexChanged -= new System.EventHandler(this.ActiveMasksCb_SelectedIndexChanged);
                ActiveMasksCb.SelectedIndex = ActiveMasksCb.FindString(str);
                this.ActiveMasksCb.SelectedIndexChanged += new System.EventHandler(this.ActiveMasksCb_SelectedIndexChanged);
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 2)
            {
                // register_assignment
                Assigments.Enabled = connected && access != AccessMode.NoAccess;
            }
            else if (index == 3)
            {
                // mask_list
                Masks.Enabled = connected && access != AccessMode.NoAccess;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        delegate void ShowDlgEventHandler(GXActionArgs arg);

        void OnShowDlg(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDlgEventHandler(OnShowDlg), arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXDLMSRegisterActivation target = (GXDLMSRegisterActivation)Target;
                ListViewItem li = null;
                if (arg.Index == 1)
                {
                    GXDLMSObjectDefinition item = new GXDLMSObjectDefinition();
                    GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Add new register", null,
                           Target.Parent.GetObjects(new ObjectType[] { ObjectType.Register, ObjectType.ExtendedRegister, ObjectType.DemandRegister }));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        item.ObjectType = dlg.Target.ObjectType;
                        item.LogicalName = dlg.Target.LogicalName;
                        li = Assigments.Items.Add(item.ObjectType.ToString());
                        li.SubItems.Add(item.LogicalName);
                        li.Tag = item;
                        arg.Value = target.AddRegister(arg.Client, ((GXDLMSTargetObjectDlg)dlg).Target);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 2)
                {
                    GXDLMSObjectDefinition item = new GXDLMSObjectDefinition();
                    GXDLMSRegisterActivationDlg dlg = new GXDLMSRegisterActivationDlg("Add new mask", null, null);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        arg.Value = target.AddMask(arg.Client, dlg.MaskName, dlg.IndexArray);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 3)
                {
                    if (Masks.SelectedItems.Count == 1)
                    {
                        GXDLMSObjectDefinition item = new GXDLMSObjectDefinition();
                        KeyValuePair<byte[], byte[]> it = (KeyValuePair<byte[], byte[]>)Masks.SelectedItems[0].Tag;
                        GXDLMSRegisterActivationDlg dlg = new GXDLMSRegisterActivationDlg("Remove mask", it.Key, it.Value);
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            arg.Value = target.RemoveMask(arg.Client, ((GXDLMSRegisterActivationDlg)dlg).MaskName);
                        }
                        else
                        {
                            arg.Handled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show(Parent, "Select one item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    OnShowDlg(arg);
                }
                else if (arg.Index == 2)
                {
                    OnShowDlg(arg);
                }
                else if (arg.Index == 3)
                {
                    OnShowDlg(arg);
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

        private void ActiveMasksCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSRegisterActivation target = (GXDLMSRegisterActivation)Target;
                target.ActiveMask = target.MaskList[ActiveMasksCb.SelectedIndex].Key;
                errorProvider1.SetError(ActiveMasksCb, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(4, target.ActiveMask);
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
