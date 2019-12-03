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
            if (index == 4)
            {
                UnicastAddBtn.Enabled = UnicastEditBtn.Enabled = UnicastRemoveBtn.Enabled = connected && (access & AccessMode.Write) != 0;
            }
            else if (index == 5)
            {
                MulticastAddBtn.Enabled = MulticastEditBtn.Enabled = MulticastRemoveBtn.Enabled = connected && (access & AccessMode.Write) != 0;
            }
            else if (index == 6)
            {
                GatewayAddBtn.Enabled = GatewayEditBtn.Enabled = GatewayRemoveBtn.Enabled = connected && (access & AccessMode.Write) != 0;
            }
            else if (index == 10)
            {
                AddBtn.Enabled = EditBtn.Enabled = RemoveBtn.Enabled = connected && (access & AccessMode.Write) != 0;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }


        public void PreAction(GXActionArgs arg)
        {
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

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void UnicastAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                GXTextDlg dlg = new GXTextDlg("Add Unicast Address", "Unicast address:", "", typeof(IPAddress));
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    IPAddress addr = IPAddress.Parse(dlg.GetValue());
                    List<IPAddress> list = new List<IPAddress>();
                    list.AddRange(target.UnicastIPAddress);
                    list.Add(addr);
                    target.UnicastIPAddress = list.ToArray();
                    ListViewItem li = UnicastAddressView.Items.Add(addr.ToString());
                    errorProvider1.SetError(UnicastAddressView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.UnicastIPAddress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MulticastAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                GXTextDlg dlg = new GXTextDlg("Add Multicast IP Address", "Multicast address:", "", typeof(IPAddress));
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    IPAddress addr = IPAddress.Parse(dlg.GetValue());
                    List<IPAddress> list = new List<IPAddress>();
                    list.AddRange(target.MulticastIPAddress);
                    list.Add(addr);
                    target.MulticastIPAddress = list.ToArray();
                    ListViewItem li = MulticastAddressView.Items.Add(addr.ToString());
                    errorProvider1.SetError(MulticastAddressView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(5, target.MulticastIPAddress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GatewayAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                GXTextDlg dlg = new GXTextDlg("Add Gateway IP Address", "Gateway address:", "", typeof(IPAddress));
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    IPAddress addr = IPAddress.Parse(dlg.GetValue());
                    List<IPAddress> list = new List<IPAddress>();
                    list.AddRange(target.GatewayIPAddress);
                    list.Add(addr);
                    target.GatewayIPAddress = list.ToArray();
                    ListViewItem li = GatewayAddressView.Items.Add(addr.ToString());
                    errorProvider1.SetError(GatewayAddressView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, target.GatewayIPAddress);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GatewayEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (GatewayAddressView.SelectedItems.Count == 1)
                {
                    IPAddress value = (IPAddress) GatewayAddressView.SelectedItems[0].Tag;
                    GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                    GXTextDlg dlg = new GXTextDlg("Edit Gateway IP Address", "Gateway address:", value.ToString(), typeof(IPAddress));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        IPAddress addr = IPAddress.Parse(dlg.GetValue());
                        List<IPAddress> list = new List<IPAddress>();
                        list.AddRange(target.GatewayIPAddress);
                        list.Remove(value);
                        list.Add(addr);
                        target.GatewayIPAddress = list.ToArray();
                        GatewayAddressView.SelectedItems[0].Text = addr.ToString();
                        GatewayAddressView.SelectedItems[0].Tag = addr;
                        errorProvider1.SetError(GatewayAddressView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(6, target.GatewayIPAddress);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnicastEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UnicastAddressView.SelectedItems.Count == 1)
                {
                    IPAddress value = (IPAddress)UnicastAddressView.SelectedItems[0].Tag;
                    GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                    GXTextDlg dlg = new GXTextDlg("Edit Unicast Address", "Unicast address:", value.ToString(), typeof(IPAddress));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        IPAddress addr = IPAddress.Parse(dlg.GetValue());
                        List<IPAddress> list = new List<IPAddress>();
                        list.AddRange(target.UnicastIPAddress);
                        list.Remove(value);
                        list.Add(addr);
                        target.UnicastIPAddress = list.ToArray();
                        UnicastAddressView.SelectedItems[0].Text = addr.ToString();
                        UnicastAddressView.SelectedItems[0].Tag = addr;
                        errorProvider1.SetError(UnicastAddressView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(4, target.UnicastIPAddress);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MulticastEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MulticastAddressView.SelectedItems.Count == 1)
                {
                    IPAddress value = (IPAddress)MulticastAddressView.SelectedItems[0].Tag;
                    GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                    GXTextDlg dlg = new GXTextDlg("Edit Multicast IP Address", "Multicast address:", value.ToString(), typeof(IPAddress));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        IPAddress addr = IPAddress.Parse(dlg.GetValue());
                        List<IPAddress> list = new List<IPAddress>();
                        list.AddRange(target.MulticastIPAddress);
                        list.Remove(value);
                        list.Add(addr);
                        target.MulticastIPAddress = list.ToArray();
                        MulticastAddressView.SelectedItems[0].Text = addr.ToString();
                        MulticastAddressView.SelectedItems[0].Tag = addr;
                        errorProvider1.SetError(MulticastAddressView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(5, target.MulticastIPAddress);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GatewayRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                List<IPAddress> list = new List<IPAddress>();
                list.AddRange(target.GatewayIPAddress);
                while (GatewayAddressView.SelectedItems.Count != 0)
                {
                    ListViewItem li = GatewayAddressView.SelectedItems[0];
                    GatewayAddressView.Items.Remove(li);
                    list.Remove((IPAddress)li.Tag);
                    errorProvider1.SetError(GatewayAddressView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, target.GatewayIPAddress);
                }
                target.GatewayIPAddress = list.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MulticastRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                List<IPAddress> list = new List<IPAddress>();
                list.AddRange(target.MulticastIPAddress);
                while (MulticastAddressView.SelectedItems.Count != 0)
                {
                    ListViewItem li = MulticastAddressView.SelectedItems[0];
                    MulticastAddressView.Items.Remove(li);
                    list.Remove((IPAddress)li.Tag);
                    errorProvider1.SetError(MulticastAddressView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(5, target.MulticastIPAddress);
                }
                target.MulticastIPAddress = list.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnicastRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIp6Setup target = Target as GXDLMSIp6Setup;
                List<IPAddress> list = new List<IPAddress>();
                list.AddRange(target.UnicastIPAddress);
                while (UnicastAddressView.SelectedItems.Count != 0)
                {
                    ListViewItem li = UnicastAddressView.SelectedItems[0];
                    UnicastAddressView.Items.Remove(li);
                    list.Remove((IPAddress)li.Tag);
                    errorProvider1.SetError(UnicastAddressView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.UnicastIPAddress);
                }
                target.UnicastIPAddress = list.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
