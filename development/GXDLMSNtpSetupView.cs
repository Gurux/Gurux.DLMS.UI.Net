//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: $
//
// Version:         $Revision: $,
//                  $Date: $
//                  $Author: $
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
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Collections.Generic;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSNtpSetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSNtpSetup))]
    partial class GXDLMSNtpSetupView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSNtpSetupView()
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
            GXDLMSNtpSetup target = (GXDLMSNtpSetup)Target;
            if (index == 2)
            {
                ActivatedCb.Checked = target.Activated;
            }
            else if (index == 6)
            {
                KeysView.Items.Clear();
                foreach (KeyValuePair<UInt32, byte[]> it in target.Keys)
                {
                    ListViewItem li = new ListViewItem(new string[] { it.Key.ToString(), GXDLMSTranslator.ToHex(it.Value) });
                    KeysView.Items.Add(li).Tag = it;
                }
                ActivatedCb.Checked = target.Activated;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        delegate void ShowDialogEventHandler(GXActionArgs arg);

        void OnShowDialog(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDialogEventHandler(OnShowDialog), arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXDLMSNtpSetup target = (GXDLMSNtpSetup)Target;
                //If user is adding a new item.
                if (arg.Index == 2)
                {
                    GXDLMSNtpDlg dlg = new GXDLMSNtpDlg(0, null, false);
                    if (dlg.ShowDialog(Parent) == DialogResult.OK)
                    {
                        arg.Value = target.AddAuthenticationKey(arg.Client, dlg.Id, dlg.Key);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else
                {
                    //User is removing the item.
                    if (KeysView.SelectedItems.Count == 1)
                    {
                        KeyValuePair<UInt32, byte[]> item = (KeyValuePair<UInt32, byte[]>)KeysView.SelectedItems[0].Tag;
                        GXDLMSNtpDlg dlg = new GXDLMSNtpDlg(item.Key, item.Value, true);
                        if (dlg.ShowDialog(Parent) == DialogResult.OK)
                        {
                            arg.Value = target.DeleteAuthenticationKey(arg.Client, item.Key);
                            KeysView.Items.Remove(KeysView.SelectedItems[0]);
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
            DialogResult ret;
            if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    //Synchronize current time
                    ret = GXHelpers.ShowMessageBox(this, "Are you sure that you want to synchronize current time to the meter?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (ret == DialogResult.Yes)
                    {
                        arg.Value = (sbyte)0;
                    }
                    arg.Handled = ret != DialogResult.Yes;
                }
                else if (arg.Index == 2)
                {
                    OnShowDialog(arg);
                }
                else if (arg.Index == 3)
                {
                    OnShowDialog(arg);
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
            if (Dirty && index == 2)
            {
                errorProvider1.SetError(ActivatedCb, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 3)
            {
                errorProvider1.SetError(ServerAddressTb, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 4)
            {
                errorProvider1.SetError(PortTb, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 5)
            {
                errorProvider1.SetError(AuthenticationCb, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 6)
            {
                errorProvider1.SetError(KeysView, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 7)
            {
                errorProvider1.SetError(ClientKeyTb, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool writable = connected && (access & AccessMode.Write) != 0;
            if (index == 2)
            {
                ActivatedCb.Enabled = writable;
            }
            else if (index == 6)
            {

            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
            throw new IndexOutOfRangeException("index");
        }
        #endregion




        private void ValueTB_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void ValueTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void ActivatedCb_CheckedChanged(object sender, EventArgs e)
        {
            (Target as GXDLMSNtpSetup).Activated = ActivatedCb.Checked;
            Target.UpdateDirty(2, ActivatedCb.Checked);
            errorProvider1.SetError(ActivatedCb, Properties.Resources.ValueChangedTxt);
        }
    }
}
