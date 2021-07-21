//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSModemConfigurationView.cs $
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSModemConfiguration
    /// </summary>
    [GXDLMSViewAttribute(typeof(Gurux.DLMS.Objects.GXDLMSModemConfiguration))]
    public partial class GXDLMSModemConfigurationView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSModemConfigurationView()
        {
            InitializeComponent();
        }
        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        private void UpdateModemInitialisationUI(GXDLMSModemInitialisation it, ListViewItem li)
        {
            if (li == null)
            {
                li = new ListViewItem(it.Request);
                li.SubItems.Add(it.Response);
                li.SubItems.Add(it.Delay.ToString());
                li.Tag = it;
                InitialisationView.Items.Add(li);
            }
            else
            {
                li.SubItems[0].Text = it.Request;
                li.SubItems[1].Text = it.Response;
                li.SubItems[2].Text = it.Delay.ToString();
            }
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSModemConfiguration target = Target as GXDLMSModemConfiguration;
            if (index == 3)
            {
                InitialisationView.Items.Clear();
                if (target.InitialisationStrings != null)
                {
                    foreach (GXDLMSModemInitialisation it in target.InitialisationStrings)
                    {
                        UpdateModemInitialisationUI(it, null);
                    }
                }
            }
            else if (index == 4)
            {
                if (target.ModemProfile == null)
                {
                    this.ModemProfileTB.Text = "";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string it in target.ModemProfile)
                    {
                        sb.AppendLine(it);
                    }
                    this.ModemProfileTB.Text = sb.ToString();
                }
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 3)
            {
                InitialisationView.Enabled = AddBtn.Enabled = EditBtn.Enabled = RemoveBtn.Enabled = enabled;
            }
            else if (index == 4)
            {
                ModemProfileTB.Enabled = enabled;
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
            switch (index)
            {
                case 2:
                    errorProvider1.SetError(CommunicationSpeedTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 3:
                    errorProvider1.SetError(InitialisationView, Properties.Resources.ValueChangedTxt);
                    break;
                case 4:
                    errorProvider1.SetError(ModemProfileTB, Properties.Resources.ValueChangedTxt);
                    break;
                default:
                    errorProvider1.Clear();
                    break;
            }
        }

        #endregion

        private void ModemProfileTB_Leave(object sender, EventArgs e)
        {
            try
            {
                GXDLMSModemConfiguration target = Target as GXDLMSModemConfiguration;
                target.ModemProfile = this.ModemProfileTB.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                Target.UpdateDirty(2, target.ModemProfile);
                errorProvider1.SetError(ModemProfileTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            GXDLMSModemConfiguration target = Target as GXDLMSModemConfiguration;
            GXDLMSModemInitialisation item = new GXDLMSModemInitialisation();
            GXDLMSModemConfigurationDlg dlg = new GXDLMSModemConfigurationDlg(item);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                List<GXDLMSModemInitialisation> list = new List<GXDLMSModemInitialisation>();
                if (target.InitialisationStrings != null)
                {
                    list.AddRange(target.InitialisationStrings);
                }
                list.Add(item);
                target.InitialisationStrings = list.ToArray();
                UpdateModemInitialisationUI(item, null);
                errorProvider1.SetError(InitialisationView, Properties.Resources.ValueChangedTxt);
                target.UpdateDirty(3, target.InitialisationStrings);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (InitialisationView.SelectedItems.Count == 1)
            {
                ListViewItem li = InitialisationView.SelectedItems[0];
                GXDLMSModemConfiguration target = Target as GXDLMSModemConfiguration;
                GXDLMSModemInitialisation item = InitialisationView.SelectedItems[0].Tag as GXDLMSModemInitialisation;
                GXDLMSModemConfigurationDlg dlg = new GXDLMSModemConfigurationDlg(item);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    UpdateModemInitialisationUI(item, li);
                    errorProvider1.SetError(InitialisationView, Properties.Resources.ValueChangedTxt);
                    target.UpdateDirty(3, target.InitialisationStrings);
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            GXDLMSModemConfiguration target = Target as GXDLMSModemConfiguration;
            List<GXDLMSModemInitialisation> list = new List<GXDLMSModemInitialisation>();
            if (target.InitialisationStrings != null)
            {
                list.AddRange(target.InitialisationStrings);
            }

            while (InitialisationView.SelectedItems.Count != 0)
            {
                ListViewItem li = InitialisationView.SelectedItems[0];
                GXDLMSModemInitialisation item = (GXDLMSModemInitialisation)li.Tag;
                li.Remove();
                errorProvider1.SetError(InitialisationView, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(3, target.InitialisationStrings);
                list.Remove(item);
            }
            target.InitialisationStrings = list.ToArray();
        }
    }
}
