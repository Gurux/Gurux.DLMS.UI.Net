//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSSpecialDaysTableView.cs $
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
using Gurux.DLMS;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSSpecialDaysTable
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSSpecialDaysTable))]
    partial class GXDLMSSpecialDaysTableView : Form, IGXDLMSView
    {
        List<GXDLMSSpecialDay> entries = new List<Objects.GXDLMSSpecialDay>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSSpecialDaysTableView()
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
                GXDLMSSpecialDaysTable target = Target as GXDLMSSpecialDaysTable;
                GXDLMSSpecialDay[] items = target.Entries;
                SpecialDay.Items.Clear();
                entries.Clear();
                if (items != null)
                {
                    entries.AddRange(items);
                    foreach (GXDLMSSpecialDay it in items)
                    {
                        ListViewItem li = SpecialDay.Items.Add(it.Index.ToString());
                        li.SubItems.Add(it.Date.ToString());
                        li.SubItems.Add(it.DayId.ToString());
                        li.Tag = it;
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 2)
            {
                DayAddBtn.Enabled = DayRemoveBtn.Enabled = DayEditBtn.Enabled = enabled;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        public ActionType PreAction(GXDLMSClient client, ActionType type, ValueEventArgs arg)
        {
            //Entries are handled using actions.
            if (arg.Index == 2)
            {
                arg.Handled = true;
            }
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

        /// <summary>
        /// Add special day.
        /// </summary>
        private void DayAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSSpecialDay it = new GXDLMSSpecialDay();
                GXDLMSSpecialDaysTableDlg dlg = new GXDLMSSpecialDaysTableDlg(it);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    GXDLMSSpecialDaysTable target = Target as GXDLMSSpecialDaysTable;
                    ListViewItem li = SpecialDay.Items.Add(it.Index.ToString());
                    li.SubItems.Add(it.Date.ToString());
                    li.SubItems.Add(it.DayId.ToString());
                    li.Tag = it;
                    entries.Add(it);
                    errorProvider1.SetError(SpecialDay, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.Entries);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit special day.
        /// </summary>
        private void DayEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SpecialDay.SelectedItems.Count == 1)
                {
                    ListViewItem li = SpecialDay.SelectedItems[0];
                    GXDLMSSpecialDay it = (GXDLMSSpecialDay)li.Tag;
                    GXDLMSSpecialDaysTableDlg dlg = new GXDLMSSpecialDaysTableDlg(it);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        GXDLMSSpecialDaysTable target = Target as GXDLMSSpecialDaysTable;
                        li.SubItems[0].Text = it.Index.ToString();
                        li.SubItems[1].Text = it.Date.ToString();
                        li.SubItems[2].Text = it.DayId.ToString();
                        errorProvider1.SetError(SpecialDay, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(2, target.Entries);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove special day.
        /// </summary>
        private void DayRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSSpecialDaysTable target = Target as GXDLMSSpecialDaysTable;
                while (SpecialDay.SelectedItems.Count != 0)
                {
                    GXDLMSSpecialDay item = (GXDLMSSpecialDay)SpecialDay.SelectedItems[0].Tag;
                    SpecialDay.Items.Remove(SpecialDay.SelectedItems[0]);
                    errorProvider1.SetError(SpecialDay, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.Entries);
                    entries.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
