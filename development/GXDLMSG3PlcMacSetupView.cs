//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSG3PlcMacSetupView.cs $
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
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSG3PlcMacSetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSG3PlcMacSetup))]
    partial class GXDLMSG3PlcMacSetupView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSG3PlcMacSetupView()
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
            if (index == 5)
            {
                GXDLMSG3PlcMacSetup target = Target as GXDLMSG3PlcMacSetup;
                KeyTable.Items.Clear();
                if (target.KeyTable != null)
                {
                    foreach (GXKeyValuePair<byte, byte[]> it in target.KeyTable)
                    {
                        ListViewItem li = new ListViewItem(it.Key.ToString());
                        li.SubItems.Add(GXDLMSTranslator.ToHex(it.Value));
                        li.Tag = it;
                        KeyTable.Items.Add(li);
                    }
                }
            }
            else if (index == 11)
            {
                GXDLMSG3PlcMacSetup target = Target as GXDLMSG3PlcMacSetup;
                NeighbourTable.Items.Clear();
                if (target.NeighbourTable != null)
                {
                    foreach (GXDLMSNeighbourTable it in target.NeighbourTable)
                    {
                        ListViewItem li = new ListViewItem(it.ShortAddress.ToString());
                        li.SubItems.Add(it.Enabled.ToString());
                        li.SubItems.Add(it.Modulation.ToString());
                        li.SubItems.Add(it.ToneMap);
                        li.Tag = it;
                        NeighbourTable.Items.Add(li);
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public ActionType PreAction(GXDLMSClient client, ActionType type, ValueEventArgs arg)
        {
            return type;
        }

        public ActionType PostAction(ActionType type, ValueEventArgs arg)
        {
            return ActionType.None;
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

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 5)
            {

            }
            else if (index == 11)
            {

            }
            else
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

        /// <summary>
        /// Add new item to key table.
        /// </summary>
        private void KeyTableAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXKeyValuePair<byte, byte[]> item = new GXKeyValuePair<byte, byte[]>();
                GXDLMSKeyTableDlg dlg = new GXDLMSKeyTableDlg(item);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    item.Key = dlg.id;
                    item.Value = dlg.key;
                    ListViewItem li = new ListViewItem(item.Key.ToString());
                    li.SubItems.Add(GXDLMSTranslator.ToHex(item.Value));
                    li.Tag = item;
                    KeyTable.Items.Add(li);
                    GXDLMSG3PlcMacSetup target = Target as GXDLMSG3PlcMacSetup;
                    target.KeyTable.Add(item);
                    errorProvider1.SetError(KeyTable, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit key table item.
        /// </summary>
        private void KeyTableEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (KeyTable.SelectedItems.Count != 0)
                {
                    ListViewItem li = KeyTable.SelectedItems[0];
                    GXKeyValuePair<byte, byte[]> item = (GXKeyValuePair<byte, byte[]>)li.Tag;
                    GXDLMSKeyTableDlg dlg = new GXDLMSKeyTableDlg(item);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        item.Key = dlg.id;
                        item.Value = dlg.key;
                        li.SubItems[0].Text = item.Key.ToString();
                        li.SubItems[1].Text = GXDLMSTranslator.ToHex(item.Value);
                        errorProvider1.SetError(KeyTable, Properties.Resources.ValueChangedTxt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove item from key table.
        /// </summary>
        private void KeyTableRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                while (KeyTable.SelectedItems.Count != 0)
                {
                    GXKeyValuePair<byte, byte[]> item = (GXKeyValuePair<byte, byte[]>)KeyTable.SelectedItems[0].Tag;
                    KeyTable.Items.Remove(KeyTable.SelectedItems[0]);
                    GXDLMSG3PlcMacSetup target = Target as GXDLMSG3PlcMacSetup;
                    target.KeyTable.Remove(item);
                    errorProvider1.SetError(KeyTable, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add new item to neighbour table.
        /// </summary>
        private void NeighbourTableAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSNeighbourTable item = new GXDLMSNeighbourTable();
                GXDLMSNeighbourTableDlg dlg = new GXDLMSNeighbourTableDlg(item);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    ListViewItem li = new ListViewItem(item.ShortAddress.ToString());
                    li.SubItems.Add(item.Enabled.ToString());
                    li.SubItems.Add(item.Modulation.ToString());
                    li.SubItems.Add(item.ToneMap);
                    li.Tag = item;
                    NeighbourTable.Items.Add(li);
                    errorProvider1.SetError(NeighbourTable, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Edit key neighbour item.
        /// </summary>
        private void NeighbourTableEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NeighbourTable.SelectedItems.Count != 0)
                {
                    ListViewItem li = NeighbourTable.SelectedItems[0];
                    GXDLMSNeighbourTable item = (GXDLMSNeighbourTable)li.Tag;
                    GXDLMSNeighbourTableDlg dlg = new GXDLMSNeighbourTableDlg(item);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = item.ShortAddress.ToString();
                        li.SubItems[1].Text = item.Enabled.ToString();
                        li.SubItems[2].Text = item.Modulation.ToString();
                        li.SubItems[3].Text = item.ToneMap;
                        errorProvider1.SetError(NeighbourTable, Properties.Resources.ValueChangedTxt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Remove item from neighbour table.
        /// </summary>
        private void NeighbourTableRemoveTbBtn_Click(object sender, EventArgs e)
        {
            try
            {
                while (NeighbourTable.SelectedItems.Count != 0)
                {
                    NeighbourTable.Items.Remove(NeighbourTable.SelectedItems[0]);
                    errorProvider1.SetError(NeighbourTable, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
