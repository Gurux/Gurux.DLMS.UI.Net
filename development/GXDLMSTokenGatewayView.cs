//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSTokenGatewayView.cs $
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
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSTokenGateway
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSTokenGateway))]
    partial class GXDLMSTokenGatewayView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSTokenGatewayView()
        {
            InitializeComponent();
            foreach (var it in Enum.GetValues(typeof(TokenStatusCode)))
            {
                StatusCodeTb.Items.Add(it);
            }
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSTokenGateway target = (GXDLMSTokenGateway)Target;
            if (index == 4)
            {
                DescriptionsView.Items.Clear();
                foreach (string it in target.Descriptions)
                {
                    DescriptionsView.Items.Add(it);
                }
            }
            else if (index == 6)
            {
                StatusCodeTb.SelectedItem = target.StatusCode;
                DataValueTb.Text = target.DataValue;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        delegate void ShowDialogEventHandler(GXActionArgs arg);

        void OnShowDialog(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDialogEventHandler(OnShowDialog), arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXTextDlg dlg = new GXTextDlg("Transfer token", "Token", "", typeof(byte[]));
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    GXByteBuffer bb = new GXByteBuffer();
                    bb.SetUInt8((byte)DataType.OctetString);
                    byte[] str = GXDLMSTranslator.HexToBytes(dlg.GetValue());
                    bb.SetUInt8((byte)str.Length);
                    bb.Set(str);
                    arg.Value = bb.Array();
                }
                else
                {
                    arg.Handled = true;
                }

            }
        }

        public void PreAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action && arg.Index == 1)
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
            if (Dirty && index == 4)
            {
                errorProvider1.SetError(DescriptionsView, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 6)
            {
                errorProvider1.SetError(StatusCodeTb, Properties.Resources.ValueChangedTxt);
                errorProvider1.SetError(DataValueTb, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 4)
            {
                DescriptionsAdd.Enabled = DescriptionsEdit.Enabled = DescriptionsRemove.Enabled = enabled;
            }
            else if (index == 6)
            {
                StatusCodeTb.Enabled = enabled;
                DataValueTb.ReadOnly = !enabled;
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

        /// <summary>
        /// Add description.
        /// </summary>
        private void DescriptionsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSTokenGateway target = Target as GXDLMSTokenGateway;
                GXTextDlg dlg = new GXTextDlg("Add new description", "Description:", "");
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string desc = dlg.GetValue();
                    target.Descriptions.Add(desc);
                    ListViewItem li = DescriptionsView.Items.Add(desc);
                    errorProvider1.SetError(DescriptionsView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.Descriptions);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit description.
        /// </summary>
        private void DescriptionsEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DescriptionsView.SelectedItems.Count == 1)
                {
                    GXDLMSTokenGateway target = Target as GXDLMSTokenGateway;
                    ListViewItem li = DescriptionsView.SelectedItems[0];
                    GXTextDlg dlg = new GXTextDlg("Edit description", "Description:", li.Text);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        target.Descriptions.Remove(li.Text);
                        string desc = dlg.GetValue();
                        li.SubItems[0].Text = desc;
                        target.Descriptions.Add(desc);
                        errorProvider1.SetError(DescriptionsView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(4, target.Descriptions);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove description.
        /// </summary>
        private void DescriptionsRemove_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSTokenGateway target = Target as GXDLMSTokenGateway;
                while (DescriptionsView.SelectedItems.Count != 0)
                {
                    ListViewItem li = DescriptionsView.SelectedItems[0];
                    DescriptionsView.Items.Remove(li);
                    errorProvider1.SetError(DescriptionsView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.Descriptions);
                    target.Descriptions.Remove(li.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Status Code has change.
        /// </summary>
        private void StatusCodeTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSTokenGateway target = Target as GXDLMSTokenGateway;
                if (target.StatusCode != (TokenStatusCode) StatusCodeTb.SelectedItem)
                {
                    target.StatusCode = (TokenStatusCode)StatusCodeTb.SelectedItem;
                    errorProvider1.SetError(StatusCodeTb, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, target.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Data Value has change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataValueTb_Leave(object sender, EventArgs e)
        {
            try
            {
                GXDLMSTokenGateway target = Target as GXDLMSTokenGateway;
                if (target.DataValue != DataValueTb.Text)
                {
                    target.DataValue = DataValueTb.Text;
                    errorProvider1.SetError(DataValueTb, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, target.DataValue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Parent, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
