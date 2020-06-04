//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSArbitratorView.cs $
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSArbitrator
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSArbitrator))]
    partial class GXDLMSArbitratorView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSArbitratorView()
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
            GXDLMSArbitrator target = (GXDLMSArbitrator)Target;
            switch (index)
            {
                case 2:
                    {
                        ActionsView.Items.Clear();
                        if (target.Actions != null)
                        {
                            foreach (GXDLMSActionItem it in target.Actions)
                            {
                                ListViewItem li = new ListViewItem(new string[] { it.LogicalName, it.ScriptSelector.ToString(), "", "", "" });
                                li.Tag = it;
                                ActionsView.Items.Add(li);
                            }
                        }
                    }
                    break;
                case 3:
                    if (target.PermissionsTable != null)
                    {
                        int pos = 0;
                        ListViewItem li;
                        foreach (string it in target.PermissionsTable)
                        {
                            if (ActionsView.Items.Count <= pos)
                            {
                                li = new ListViewItem(new string[] { "", "", "", "", "" });
                                ActionsView.Items.Add(li);
                            }
                            li = ActionsView.Items[pos];
                            li.SubItems[2].Text = it;
                            ++pos;
                        }
                    }
                    break;
                case 4:
                    if (target.WeightingsTable != null)
                    {
                        int pos = 0;
                        ListViewItem li;
                        foreach (UInt16[] it in target.WeightingsTable)
                        {
                            if (ActionsView.Items.Count <= pos)
                            {
                                li = new ListViewItem(new string[] { "", "", "", "", "" });
                                ActionsView.Items.Add(li);
                            }
                            li = ActionsView.Items[pos];
                            li.SubItems[3].Text = string.Join(", ", it);
                            ++pos;
                        }
                    }
                    break;
                case 5:
                    if (target.MostRecentRequestsTable != null)
                    {
                        int pos = 0;
                        ListViewItem li;
                        foreach (string it in target.MostRecentRequestsTable)
                        {
                            if (ActionsView.Items.Count <= pos)
                            {
                                li = new ListViewItem(new string[] { "", "", "", "", "" });
                                ActionsView.Items.Add(li);
                            }
                            li = ActionsView.Items[pos];
                            li.SubItems[4].Text = it;
                            ++pos;
                        }
                    }
                    break;
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            arg.Value = (sbyte)0;
            DialogResult ret;
            if (arg.Index == 1)
            {
                //Request Action.
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.AccountActivateWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
            }
            else if (arg.Index == 1)
            {
                //Reset.
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.RegisterResetWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            if (arg.Exception == null)
            {
                GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                switch (index)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        errorProvider1.SetError(ActionsView, Properties.Resources.ValueChangedTxt);
                        break;
                }
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            switch (index)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                    break;
                default:
                    throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }
        #endregion

        private void RequestActionBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
