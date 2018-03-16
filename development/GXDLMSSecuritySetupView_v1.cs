//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSSecuritySetupView_v1.cs $
//
// Version:         $Revision: 5795 $,
//                  $Date: 2012-10-02 13:22:54 +0300 (ti, 02 loka 2012) $
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
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Collections.Generic;
using Gurux.DLMS.Objects.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSSecuritySetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSSecuritySetup), 1)]
    partial class GXDLMSSecuritySetupView_v1 : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSSecuritySetupView_v1()
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
            if (index == 6)
            {
                GXDLMSSecuritySetup target = (GXDLMSSecuritySetup)Target;
                CertificatesLv.Items.Clear();
                if (target.Certificates != null)
                {
                    foreach (GXDLMSCertificateInfo it in target.Certificates)
                    {
                        ListViewItem li = CertificatesLv.Items.Add(it.Entity.ToString());
                        li.SubItems.Add(it.Type.ToString());
                        li.SubItems.Add(it.SerialNumber);
                        li.SubItems.Add(it.Issuer);
                        li.SubItems.Add(it.Subject);
                        li.SubItems.Add(it.SubjectAltName);
                        li.Tag = it;
                    }
                }
            }
            else if (index != 2)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        delegate void GetValueEventHandler(GXActionArgs arg);
        void OnGetValue(GXActionArgs arg)
        {
            if (arg.Index == 1)
            {
                arg.Value = SecurityPolicyTB.Value;
            }
            else if (arg.Index == 2)
            {
                GXSecuritySetupKeyDlg dlg = new GXSecuritySetupKeyDlg(0);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    List<KeyValuePair<GlobalKeyType, byte[]>> list = new List<KeyValuePair<GlobalKeyType, byte[]>>();
                    list.Add(new KeyValuePair<GlobalKeyType, byte[]>(dlg.Type, dlg.Key));
                    arg.Value = (Target as GXDLMSSecuritySetup).GlobalKeyTransfer(arg.Client, dlg.Kek, list);
                }
                else
                {
                    arg.Handled = true;
                }
            }
        }


        public void PreAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action && arg.Index == 1)
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
                else
                {
                    arg.Value = SecurityPolicyTB.Value;
                }
            }
            else if (arg.Action == ActionType.Action && arg.Index == 2)
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new GetValueEventHandler(OnGetValue), arg).AsyncWaitHandle.WaitOne();
                }
                else
                {
                    arg.Value = SecurityPolicyTB.Value;
                }
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action && arg.Index == 1)
            {
                arg.Action = ActionType.Read;
                arg.Index = 2;
            }
            else
            {
                if (arg.Action == ActionType.Action && arg.Index == 2)
                {
                    GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                arg.Action = ActionType.None;
            }
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
            if (!Dirty)
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 2)
            {
                SecurityPolicyTB.ReadOnly = !connected || Target.GetMethodAccess(1) == MethodAccessMode.NoAccess;
            }
            else if (index != 6)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
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
    }
}
