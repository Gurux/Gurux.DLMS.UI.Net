//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL:$
//
// Version:         $Revision: $,
//                  $Date:  $
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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSAutoAnswer
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSAutoAnswer))]
    public partial class GXDLMSAutoAnswerView : Form, IGXDLMSView
    {
        public GXDLMSAutoAnswerView()
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
            GXDLMSAutoAnswer target = Target as GXDLMSAutoAnswer;
            if (index == 3)
            {
                ListeningWindowLV.Items.Clear();
                if (target.ListeningWindow != null)
                {
                    foreach (var it in target.ListeningWindow)
                    {
                        ListViewItem li = ListeningWindowLV.Items.Add(it.Key.ToFormatString());
                        li.SubItems.Add(it.Value.ToFormatString());
                        li.Tag = it;
                    }
                }
            }
            else if (index == 5)
            {
                if (target.NumberOfCalls == 0)
                {
                    NumberOfCallsTB.Value = "No limit.";
                }
                else
                {
                    NumberOfCallsTB.Value = target.NumberOfCalls.ToString();
                }

            }
            else if (index == 6)
            {
                if (target.NumberOfRingsInListeningWindow == 0)
                {
                    this.RingCountInWindowTB.Text = "No connect.";
                }
                else
                {
                    this.RingCountInWindowTB.Text = target.NumberOfRingsInListeningWindow.ToString();
                }
                if (target.NumberOfRingsOutListeningWindow == 0)
                {
                    this.RingCountOutOfWindowTB.Text = "No connect.";
                }
                else
                {
                    this.RingCountOutOfWindowTB.Text = target.NumberOfRingsOutListeningWindow.ToString();
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
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
                GXDLMSAutoAnswer target = Target as GXDLMSAutoAnswer;
                KeyValuePair<GXDateTime, GXDateTime> it = new KeyValuePair<GXDateTime, GXDateTime>(DateTime.Now, DateTime.Now);
                GXDateTimeDlg dlg = new GXDateTimeDlg(it.Key, it.Value);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    ListViewItem li = ListeningWindowLV.Items.Add(it.Key.ToFormatString());
                    li.SubItems.Add(it.Value.ToFormatString());
                    li.Tag = it;
                    target.ListeningWindow.Add(it);
                    errorProvider1.SetError(ListeningWindowLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(3, target.ListeningWindow);
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
        private void TimeEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListeningWindowLV.SelectedItems.Count == 1)
                {
                    GXDLMSAutoAnswer target = Target as GXDLMSAutoAnswer;
                    ListViewItem li = ListeningWindowLV.SelectedItems[0];
                    KeyValuePair<GXDateTime, GXDateTime> it = (KeyValuePair<GXDateTime, GXDateTime>)li.Tag;
                    GXDateTimeDlg dlg = new GXDateTimeDlg(it.Key, it.Value);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = it.Key.ToFormatString();
                        li.SubItems[1].Text = it.Value.ToFormatString();
                        errorProvider1.SetError(ListeningWindowLV, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(3, target.ListeningWindow);
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
                GXDLMSAutoAnswer target = Target as GXDLMSAutoAnswer;
                while (ListeningWindowLV.SelectedItems.Count != 0)
                {
                    KeyValuePair<GXDateTime, GXDateTime> item = (KeyValuePair<GXDateTime, GXDateTime>)ListeningWindowLV.SelectedItems[0].Tag;
                    ListeningWindowLV.Items.Remove(ListeningWindowLV.SelectedItems[0]);
                    errorProvider1.SetError(ListeningWindowLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(3, target.ListeningWindow);
                    target.ListeningWindow.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
