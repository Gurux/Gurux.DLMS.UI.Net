//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSAutoConnectView.cs $
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
    [GXDLMSViewAttribute(typeof(GXDLMSAutoConnect))]
    partial class GXDLMSAutoConnectView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAutoConnectView()
        {
            InitializeComponent();
        }
        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user)
        {
            GXDLMSAutoConnect target = Target as GXDLMSAutoConnect;
            if (index == 5)
            {
                CallingWindowLV.Items.Clear();
                foreach (var it in target.CallingWindow)
                {
                    ListViewItem li = CallingWindowLV.Items.Add(it.Key.ToFormatString());
                    li.SubItems.Add(it.Value.ToFormatString());
                    li.Tag = it;
                }
            }
            else if (index == 6)
            {
                DestinationLv.Items.Clear();
                if (target.Destinations != null)
                {
                    foreach (string it in target.Destinations)
                    {
                        DestinationLv.Items.Add(it);
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access)
        {
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode)
        {
        }

        public void PreAction(ActionType type, ValueEventArgs arg)
        {

        }

        public void PostAction(ActionType type, ValueEventArgs arg)
        {

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
        /// Add calling window time.
        /// </summary>
        private void TimeAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAutoConnect target = Target as GXDLMSAutoConnect;
                KeyValuePair<GXDateTime, GXDateTime> it = new KeyValuePair<GXDateTime, GXDateTime>(DateTime.Now, DateTime.Now);
                GXDateTimeDlg dlg = new GXDateTimeDlg(it.Key, it.Value);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    ListViewItem li = CallingWindowLV.Items.Add(it.Key.ToFormatString());
                    li.SubItems.Add(it.Value.ToFormatString());
                    li.Tag = it;
                    target.CallingWindow.Add(it);
                    errorProvider1.SetError(CallingWindowLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(5, target.CallingWindow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit calling window time.
        /// </summary>
        /// 
        private void TimeEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CallingWindowLV.SelectedItems.Count == 1)
                {
                    GXDLMSAutoConnect target = Target as GXDLMSAutoConnect;
                    ListViewItem li = CallingWindowLV.SelectedItems[0];
                    KeyValuePair<GXDateTime, GXDateTime> it = (KeyValuePair<GXDateTime, GXDateTime>)li.Tag;
                    GXDateTimeDlg dlg = new GXDateTimeDlg(it.Key, it.Value);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = it.Key.ToFormatString();
                        li.SubItems[1].Text = it.Value.ToFormatString();
                        errorProvider1.SetError(CallingWindowLV, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(5, target.CallingWindow);
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
        /// Remove calling window time.
        /// </summary>
        private void TimeRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAutoConnect target = Target as GXDLMSAutoConnect;
                while (CallingWindowLV.SelectedItems.Count != 0)
                {
                    KeyValuePair<GXDateTime, GXDateTime> item = (KeyValuePair<GXDateTime, GXDateTime>)CallingWindowLV.SelectedItems[0].Tag;
                    CallingWindowLV.Items.Remove(CallingWindowLV.SelectedItems[0]);
                    errorProvider1.SetError(CallingWindowLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(5, target.CallingWindow);
                    target.CallingWindow.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add destination.
        /// </summary>
        private void DestinationAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAutoConnect target = Target as GXDLMSAutoConnect;
                List<string> entries = new List<string>();
                if (target.Destinations != null)
                {
                    entries.AddRange(target.Destinations);
                }
                GXTextDlg dlg = new GXTextDlg("Destination", "Destination", "");
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string tmp = dlg.GetValue();
                    ListViewItem li = DestinationLv.Items.Add(tmp);
                    entries.Add(tmp);
                    errorProvider1.SetError(DestinationLv, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, target.Destinations);
                    target.Destinations = entries.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit destination.
        /// </summary>
        private void DestinationEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DestinationLv.SelectedItems.Count == 1)
                {
                    GXDLMSAutoConnect target = Target as GXDLMSAutoConnect;
                    List<string> entries = new List<string>();
                    if (target.Destinations != null)
                    {
                        entries.AddRange(target.Destinations);
                    }
                    ListViewItem li = DestinationLv.SelectedItems[0];
                    GXTextDlg dlg = new GXTextDlg("Destination", "Destination", li.Text);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        string tmp = dlg.GetValue();
                        int pos = DestinationLv.SelectedIndices[0];
                        li.SubItems[0].Text = tmp;
                        entries.RemoveAt(pos);
                        entries.Insert(pos, tmp);
                        errorProvider1.SetError(DestinationLv, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(6, target.Destinations);
                        target.Destinations = entries.ToArray();
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
        /// Remove destination.
        /// </summary>
        private void DestinationRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAutoConnect target = Target as GXDLMSAutoConnect;
                List<string> entries = new List<string>();
                if (target.Destinations != null)
                {
                    entries.AddRange(target.Destinations);
                }
                while (DestinationLv.SelectedItems.Count != 0)
                {
                    string item = DestinationLv.SelectedItems[0].Text;
                    DestinationLv.Items.Remove(DestinationLv.SelectedItems[0]);
                    errorProvider1.SetError(DestinationLv, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, target.Destinations);
                    entries.Remove(item);
                }
                target.Destinations = entries.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
