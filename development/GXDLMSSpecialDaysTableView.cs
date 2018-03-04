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
using System.Windows.Forms;
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
                if (items != null)
                {
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
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        delegate void SpecialDaysDlgEventHandler(GXActionArgs arg, GXDLMSSpecialDaysTableDlg dlg, GXDLMSSpecialDay it);

        void OnSpecialDaysDlg(GXActionArgs arg, GXDLMSSpecialDaysTableDlg dlg, GXDLMSSpecialDay it)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SpecialDaysDlgEventHandler(OnSpecialDaysDlg), arg, dlg, it).AsyncWaitHandle.WaitOne();
            }
            else
            {
                bool remove = false;
                ListViewItem li = null;
                if (it == null)
                {
                    remove = true;
                    GXDLMSSpecialDaysTable target = Target as GXDLMSSpecialDaysTable;
                    if (SpecialDay.SelectedItems.Count != 1)
                    {
                        arg.Handled = true;
                        return;
                    }
                    else
                    {
                         li = SpecialDay.SelectedItems[0];
                        dlg.Item = it = (GXDLMSSpecialDay)li.Tag;                        
                    }
                }
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    GXDLMSSpecialDaysTable target = Target as GXDLMSSpecialDaysTable;
                    if (!remove)
                    {
                        li = SpecialDay.Items.Add(it.Index.ToString());
                        li.SubItems.Add(it.Date.ToString());
                        li.SubItems.Add(it.DayId.ToString());
                        li.Tag = it;
                        arg.Value = target.Insert(arg.Client, it);
                    }
                    else
                    {
                        arg.Value = target.Delete(arg.Client, it);
                        li.Remove();
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
            //Entries are handled using actions.
            if (arg.Index == 1)
            {
                GXDLMSSpecialDay it = new GXDLMSSpecialDay();
                GXDLMSSpecialDaysTableDlg dlg = new GXDLMSSpecialDaysTableDlg(it, false);
                OnSpecialDaysDlg(arg, dlg, it);
            }
            else if (arg.Index == 2)
            {
                GXDLMSSpecialDaysTableDlg dlg = new GXDLMSSpecialDaysTableDlg(null, true);
                OnSpecialDaysDlg(arg, dlg, null);               
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
