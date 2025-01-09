//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: $
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gurux.DLMS.Objects;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSFunctionControl
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSFunctionControl))]
    partial class GXDLMSFunctionControlView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSFunctionControlView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSFunctionControl target = Target as GXDLMSFunctionControl;
            string ln = null;
            if (ActivationStatusView.SelectedItems.Count == 1)
            {
                ln = ActivationStatusView.SelectedItems[0].Text;
            }

            if (arg.Index == 2)
            {
                ActivationStatusView.Items.Clear();
                foreach (var it in target.ActivationStatus)
                {
                    ListViewItem li = new ListViewItem(new string[] { it.Key, it.Value.ToString() });
                    if (it.Key == ln)
                    {
                        li.Selected = true;
                    }
                    ActivationStatusView.Items.Add(li);
                }
            }
            else if (arg.Index == 3)
            {
                FunctionListView.Items.Clear();
                if (ln != null)
                {
                    foreach (var it in target.FunctionList)
                    {
                        if (it.Key == ln)
                        {
                            //Show activation status functions.
                            foreach (var obj in it.Value)
                            {
                                ListViewItem li = new ListViewItem(new string[] { obj.ObjectType.ToString(), obj.LogicalName });
                                FunctionListView.Items.Add(li);
                            }
                            break;
                        }
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        delegate void ShowFunctionControlDialogEventHandler(GXActionArgs arg);


        void OnShowDialog(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowFunctionControlDialogEventHandler(OnShowDialog), arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXDLMSFunctionControl target = (GXDLMSFunctionControl)Target;
                if (arg.Index == 1)
                {
                    //Enable/Disable...
                    if (ActivationStatusView.SelectedItems.Count == 1)
                    {
                        string name = ActivationStatusView.SelectedItems[0].Text;
                        GXFunctionControlFunctionDlg dlg = new GXFunctionControlFunctionDlg(target, name, 1);
                        if (dlg.ShowDialog(this.Parent) == DialogResult.OK)
                        {
                            List<GXKeyValuePair<string, bool>> functions = new List<GXKeyValuePair<string, bool>>();
                            functions.Add(new GXKeyValuePair<string, bool>(name, dlg.TargetEnabled));                            
                            arg.Value = target.SetFunctionStatus(arg.Client, functions);
                        }
                        else
                        {
                            arg.Handled = true;
                        }
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 2)
                {
                    //Add
                    GXFunctionControlFunctionDlg dlg = new GXFunctionControlFunctionDlg(target, null, 2);
                    if (dlg.ShowDialog(this.Parent) == DialogResult.OK)
                    {
                        arg.Value = target.AddFunction(arg.Client, dlg.TargetName, dlg.TargetObjects);
                        foreach (var obj in dlg.TargetObjects)
                        {
                            ListViewItem li = new ListViewItem(
                                new string[] { dlg.TargetName, false.ToString()
                            });
                            ActivationStatusView.Items.Add(li);
                        }
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else if (arg.Index == 3)
                {
                    //Delete
                    if (ActivationStatusView.SelectedItems.Count == 1)
                    {
                        string name = ActivationStatusView.SelectedItems[0].Text;
                        GXFunctionControlFunctionDlg dlg = new GXFunctionControlFunctionDlg(target, name, 3);
                        if (dlg.ShowDialog(this.Parent) == DialogResult.OK)
                        {
                            arg.Value = target.RemoveFunction(arg.Client, name);
                            ActivationStatusView.SelectedItems[0].Remove();
                        }
                        else
                        {
                            arg.Handled = true;
                        }
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action)
            {
                OnShowDialog(arg);
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

        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            bool enabled = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
            if (arg.Index == 2)
            {
                ActivationStatusView.Enabled = enabled;
            }
            else if (arg.Index == 3)
            {
                FunctionListView.Enabled = enabled;
            }
            else
            {
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

        /// <summary>
        /// Update function list when activation status is selected.
        /// </summary>
        private void ActivationStatusView_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnValueChanged(new GXDLMSViewArguments() { Index = 3 });
        }
    }
}
