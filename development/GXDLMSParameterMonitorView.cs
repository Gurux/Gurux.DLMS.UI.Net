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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSParameterMonitor
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSParameterMonitor))]
    public partial class GXDLMSParameterMonitorView : Form, IGXDLMSView
    {
        public GXDLMSParameterMonitorView()
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
            GXDLMSParameterMonitor target = Target as GXDLMSParameterMonitor;
            if (index == 2)
            {
                if (target.ChangedParameter != null && target.ChangedParameter.Target != null)
                {
                    TargetTb.Text = target.ChangedParameter.Target.ToString();
                    IndexTb.Text = target.ChangedParameter.AttributeIndex.ToString();
                    ValueTb.Text = Convert.ToString(GXHelpers.ConvertFromDLMS(target.ChangedParameter.Value, DataType.None, DataType.None, true, false));
                }
                else
                {
                    TargetTb.Text = "";
                    IndexTb.Text = "";
                    ValueTb.Text = "";
                }
            }
            else if (index == 4)
            {
                ParametersLV.Items.Clear();
                if (target.Parameters != null)
                {
                    foreach (GXDLMSTarget it in target.Parameters)
                    {
                        ListViewItem li = ParametersLV.Items.Add(it.Target.ToString());
                        li.SubItems.Add(it.AttributeIndex.ToString());
                        li.Tag = it;
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (Target.GetAccess(index) & AccessMode.Write) != 0;
            if (index == 4)
            {
                AddBtn.Enabled = RemoveBtn.Enabled = enabled;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        delegate void ShowDlgEventHandler(GXActionArgs arg, GXDLMSTargetObjectDlg dlg, GXDLMSTarget it);

        void OnShowDlg(GXActionArgs arg, GXDLMSTargetObjectDlg dlg, GXDLMSTarget it)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDlgEventHandler(OnShowDlg), arg, dlg, it).AsyncWaitHandle.WaitOne();
            }
            else
            {
                bool remove = false;
                ListViewItem li = null;
                GXDLMSParameterMonitor target = Target as GXDLMSParameterMonitor;
                if (it == null)
                {
                    remove = true;
                    if (ParametersLV.SelectedItems.Count != 1)
                    {
                        arg.Handled = true;
                        return;
                    }
                    else
                    {
                        li = ParametersLV.SelectedItems[0];
                        it = (GXDLMSTarget)li.Tag;
                        dlg.Target = it.Target;
                        dlg.Index = it.AttributeIndex;
                    }
                }
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    if (!remove)
                    {
                        it.Target = dlg.Target;
                        it.AttributeIndex = dlg.Index;
                        li = ParametersLV.Items.Add(it.Target.ToString());
                        li.SubItems.Add(it.AttributeIndex.ToString());
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
            if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    GXDLMSTarget item =new GXDLMSTarget();
                    GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Add new target", item.Target, item.AttributeIndex, Target.Parent);
                    OnShowDlg(arg, dlg, item);
                }
                else if (arg.Index == 2)
                {
                    GXDLMSTargetObjectDlg dlg = new GXDLMSTargetObjectDlg("Remove target", null, 0, null);
                    OnShowDlg(arg, dlg, null);
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
