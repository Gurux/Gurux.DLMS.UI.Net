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

using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSIp6Setup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSIp6Setup))]
    public partial class GXDLMSIp6SetupView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSIp6SetupView()
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
            if (index == 4)
            {
                UnicastAddressView.Items.Clear();
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                if (target.UnicastIPAddress != null)
                {
                    foreach (IPAddress it in target.UnicastIPAddress)
                    {
                        ListViewItem li = UnicastAddressView.Items.Add(it.ToString());
                        li.Tag = it;
                    }
                }
            }
            else if (index == 5)
            {
                MulticastAddressView.Items.Clear();
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                if (target.MulticastIPAddress != null)
                {
                    foreach (IPAddress it in target.MulticastIPAddress)
                    {
                        ListViewItem li = MulticastAddressView.Items.Add(it.ToString());
                        li.Tag = it;
                    }
                }
            }
            else if (index == 6)
            {
                GatewayAddressView.Items.Clear();
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                if (target.GatewayIPAddress != null)
                {
                    foreach (IPAddress it in target.GatewayIPAddress)
                    {
                        ListViewItem li = GatewayAddressView.Items.Add(it.ToString());
                        li.Tag = it;
                    }
                }
            }
            else if (index == 10)
            {
                DiscoverySetupView.Items.Clear();
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                if (target.NeighborDiscoverySetup != null)
                {
                    foreach (GXNeighborDiscoverySetup it in target.NeighborDiscoverySetup)
                    {
                        ListViewItem li = DiscoverySetupView.Items.Add(it.MaxRetry.ToString());
                        li.SubItems.Add(it.RetryWaitTime.ToString());
                        li.SubItems.Add(it.SendPeriod.ToString());
                        li.Tag = it;
                    }
                }
            }
            else if (index != 0)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 10)
            {
                AddBtn.Enabled = EditBtn.Enabled = RemoveBtn.Enabled = connected && (access & AccessMode.Write) != 0;
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
                GXTextDlg dlg;
                IPv6AddressType type;
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                if (arg.Index == 1)
                {
                    if (AddressTab.SelectedIndex == 0)
                    {
                        dlg = new GXTextDlg("Add Unicast Address", "Unicast address:", "", typeof(IPAddress));
                        type = IPv6AddressType.Unicast;
                    }
                    else if (AddressTab.SelectedIndex == 1)
                    {
                        dlg = new GXTextDlg("Add Multicast IP Address", "Multicast address:", "", typeof(IPAddress));
                        type = IPv6AddressType.Multicast;
                    }
                    else if (AddressTab.SelectedIndex == 2)
                    {
                        dlg = new GXTextDlg("Add Gateway IP Address", "Gateway address:", "", typeof(IPAddress));
                        type = IPv6AddressType.Gateway;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        IPAddress addr = IPAddress.Parse(dlg.GetValue());
                        arg.Value = target.AddAddress(arg.Client, type, addr);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 2)
                {
                    if (AddressTab.SelectedIndex == 0 && UnicastAddressView.SelectedItems.Count != 0)
                    {
                        ListViewItem li = UnicastAddressView.SelectedItems[0];
                        IPAddress address = (IPAddress)li.Tag;
                        UnicastAddressView.Items.Remove(li);
                        arg.Value = target.RemoveAddress(arg.Client, IPv6AddressType.Unicast, address);
                    }
                    else if (AddressTab.SelectedIndex == 1 && MulticastAddressView.SelectedItems.Count != 0)
                    {
                        ListViewItem li = MulticastAddressView.SelectedItems[0];
                        IPAddress address = (IPAddress)li.Tag;
                        MulticastAddressView.Items.Remove(li);
                        arg.Value = target.RemoveAddress(arg.Client, IPv6AddressType.Multicast, address);
                    }
                    else if (AddressTab.SelectedIndex == 2 && GatewayAddressView.SelectedItems.Count != 0)
                    {
                        ListViewItem li = GatewayAddressView.SelectedItems[0];
                        IPAddress address = (IPAddress)li.Tag;
                        GatewayAddressView.Items.Remove(li);
                        arg.Value = target.RemoveAddress(arg.Client, IPv6AddressType.Gateway, address);
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
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
