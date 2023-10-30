//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSG3Plc6LoWPanView.cs $
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
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSG3Plc6LoWPan
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSG3Plc6LoWPan))]
    partial class GXDLMSG3Plc6LoWPanView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSG3Plc6LoWPanView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }
        void ShowRoutings(GXDLMSG3Plc6LoWPan target)
        {
            PrefixTable.Items.Clear();
            foreach (var item in target.RoutingTable)
            {
                ListViewItem li = new ListViewItem(item.DestinationAddress.ToString());
                li.SubItems.Add(item.NextHopAddress.ToString());
                li.SubItems.Add(item.RouteCost.ToString());
                li.SubItems.Add(item.HopCount.ToString());
                li.SubItems.Add(item.WeakLinkCount.ToString());
                li.SubItems.Add(item.ValidTime.ToString());
                li.Tag = item;
                PrefixTable.Items.Add(li);
            }
        }

        void ShowRoutingConfiguration(GXDLMSG3Plc6LoWPan target)
        {
            RoutingConfiguration.Items.Clear();
            foreach (GXDLMSRoutingConfiguration item in target.RoutingConfiguration)
            {
                ListViewItem li = new ListViewItem(item.NetTraversalTime.ToString());
                li.SubItems.Add(item.RoutingTableEntryTtl.ToString());
                li.SubItems.Add(item.Kr.ToString());
                li.SubItems.Add(item.Km.ToString());
                li.SubItems.Add(item.Kc.ToString());
                li.SubItems.Add(item.Kq.ToString());
                li.SubItems.Add(item.Kh.ToString());
                li.SubItems.Add(item.Krt.ToString());
                li.SubItems.Add(item.RreqRetries.ToString());
                li.SubItems.Add(item.RreqReqWait.ToString());
                li.SubItems.Add(item.BlacklistTableEntryTtl.ToString());
                li.SubItems.Add(item.UnicastRreqGenEnable.ToString());
                li.SubItems.Add(item.RlcEnabled.ToString());
                li.SubItems.Add(item.AddRevLinkCost.ToString());
                li.Tag = item;
                RoutingConfiguration.Items.Add(li);
            }
        }

        void ShowContextInformation(GXDLMSG3Plc6LoWPan target)
        {
            ContextInformation.Items.Clear();
            foreach (var item in target.ContextInformationTable)
            {
                ListViewItem li = new ListViewItem(item.CID);
                li.SubItems.Add(GXDLMSTranslator.ToHex(item.Context));
                li.SubItems.Add(item.Compression.ToString());
                li.SubItems.Add(item.ValidLifetime.ToString());
                li.Tag = item;
                ContextInformation.Items.Add(li);
            }
        }

        void ShowBlackList(GXDLMSG3Plc6LoWPan target)
        {
            BlackList.Items.Clear();
            if (target.BlacklistTable != null)
            {
                foreach (GXKeyValuePair<UInt16, UInt16> item in target.BlacklistTable)
                {
                    ListViewItem li = new ListViewItem(item.Key.ToString());
                    li.SubItems.Add(item.Value.ToString());
                    li.Tag = item;
                    BlackList.Items.Add(li);
                }
            }
        }

        void ShowBroadcastLog(GXDLMSG3Plc6LoWPan target)
        {
            BroadcastLog.Items.Clear();
            if (target.BroadcastLogTable != null)
            {
                foreach (GXDLMSBroadcastLogTable item in target.BroadcastLogTable)
                {
                    ListViewItem li = new ListViewItem(item.SourceAddress.ToString());
                    li.SubItems.Add(item.SequenceNumber.ToString());
                    li.SubItems.Add(item.ValidTime.ToString());
                    li.Tag = item;
                    BroadcastLog.Items.Add(li);
                }
            }
        }

        void ShowGroupTable(GXDLMSG3Plc6LoWPan target)
        {
            GroupTable.Items.Clear();
            if (target.GroupTable != null)
            {
                foreach (UInt16 item in target.GroupTable)
                {
                    ListViewItem li = new ListViewItem(item.ToString());
                    GroupTable.Items.Add(li);
                }
            }
        }


        void ShowPrefixTable(GXDLMSG3Plc6LoWPan target)
        {
            PrefixTable.Items.Clear();
            if (target.PrefixTable != null)
            {
                foreach (object item in target.PrefixTable)
                {
                    ListViewItem li = new ListViewItem(item.ToString());
                    PrefixTable.Items.Add(li);
                }
            }
        }


        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSG3Plc6LoWPan target = (GXDLMSG3Plc6LoWPan)Target;
            switch (arg.Index)
            {
                case 5:
                    ShowPrefixTable(target);
                    break;
                case 6:
                    ShowRoutingConfiguration(target);
                    break;
                case 8:
                    ShowRoutings(target);
                    break;
                case 9:
                    ShowContextInformation(target);
                    break;
                case 10:
                    ShowBlackList(target);
                    break;
                case 11:
                    ShowBroadcastLog(target);
                    break;
                case 12:
                    ShowGroupTable(target);
                    break;
                case 18:
                    DisableDefaultRoutingCB.CheckedChanged -= new System.EventHandler(this.DisableDefaultRoutingCB_CheckedChanged);
                    DisableDefaultRoutingCB.Checked = target.DisableDefaultRouting;
                    DisableDefaultRoutingCB.CheckedChanged += new System.EventHandler(this.DisableDefaultRoutingCB_CheckedChanged);
                    break;
                case 20:
                    DefaultCoordRouteEnabledCb.Checked = target.DefaultCoordRouteEnabled;
                    break;
                case 21:
                    break;
                default:
                    throw new IndexOutOfRangeException("index");
            }
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
                return DescriptionTB.Text;
            }
            set
            {
                DescriptionTB.Text = value;
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {
            if (Dirty)
            {
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            switch (arg.Index)
            {
                case 5:
                case 6:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 18:
                case 20:
                case 21:
                    break;
                default:
                    throw new IndexOutOfRangeException("index");
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
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

        private void DisableDefaultRoutingCB_CheckedChanged(object sender, EventArgs e)
        {
            GXDLMSG3Plc6LoWPan target = (GXDLMSG3Plc6LoWPan)Target;
            target.DisableDefaultRouting = DisableDefaultRoutingCB.Checked;
            errorProvider1.SetError(DisableDefaultRoutingCB, Properties.Resources.ValueChangedTxt);
        }

        /// <summary>
        /// Add new item to routing table.
        /// </summary>
        private void RoutingAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSRoutingTable item = new GXDLMSRoutingTable();
                GXDLMSRoutingTableDlg dlg = new GXDLMSRoutingTableDlg(item);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    GXDLMSG3Plc6LoWPan target = (GXDLMSG3Plc6LoWPan)Target;
                    target.RoutingTable.Add(item);
                    ListViewItem li = new ListViewItem(item.DestinationAddress.ToString());
                    li.SubItems.Add(item.NextHopAddress.ToString());
                    li.SubItems.Add(item.RouteCost.ToString());
                    li.SubItems.Add(item.HopCount.ToString());
                    li.SubItems.Add(item.WeakLinkCount.ToString());
                    li.SubItems.Add(item.ValidTime.ToString());
                    li.Tag = item;
                    Routing.Items.Add(li);
                    Target.UpdateDirty(8, target.RoutingTable);
                    errorProvider1.SetError(Routing, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit routing table item.
        /// </summary>
        private void RoutingEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Routing.SelectedItems.Count != 0)
                {
                    GXDLMSG3Plc6LoWPan target = (GXDLMSG3Plc6LoWPan)Target;
                    ListViewItem li = Routing.SelectedItems[0];
                    GXDLMSRoutingTable item = (GXDLMSRoutingTable)li.Tag;
                    GXDLMSRoutingTableDlg dlg = new GXDLMSRoutingTableDlg(item);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = item.DestinationAddress.ToString();
                        li.SubItems[1].Text = item.NextHopAddress.ToString();
                        li.SubItems[2].Text = item.RouteCost.ToString();
                        li.SubItems[3].Text = item.HopCount.ToString();
                        li.SubItems[4].Text = item.WeakLinkCount.ToString();
                        li.SubItems[5].Text = item.ValidTime.ToString();
                        errorProvider1.SetError(Routing, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(8, target.RoutingTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove item from routing table.
        /// </summary>
        private void RoutingRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                while (Routing.SelectedItems.Count != 0)
                {
                    GXDLMSRoutingTable item = (GXDLMSRoutingTable)Routing.SelectedItems[0].Tag;
                    Routing.Items.Remove(Routing.SelectedItems[0]);
                    GXDLMSG3Plc6LoWPan target = Target as GXDLMSG3Plc6LoWPan;
                    target.RoutingTable.Remove(item);
                    Target.UpdateDirty(8, target.RoutingTable);
                    errorProvider1.SetError(Routing, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
