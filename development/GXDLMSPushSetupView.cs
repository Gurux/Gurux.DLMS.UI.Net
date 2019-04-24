//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSPushSetupView.cs $
//
// Version:         $Revision: 5795 $,
//                  $Date: 2012-10-02 13:22:54 +0300 (ti, 02 loka 2012) $
//                  $Author: kurumi $
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
using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSPushSetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSPushSetup))]
    partial class GXDLMSPushSetupView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSPushSetupView()
        {
            InitializeComponent();
            ServiceCB.Items.AddRange(new object[] { ServiceType.Tcp, ServiceType.Udp, ServiceType.Ftp,
                ServiceType.Smtp, ServiceType.Sms, ServiceType.Hdlc, ServiceType.MBus, ServiceType.ZigBee });
            MessageCB.Items.AddRange(new object[] { MessageType.CosemApdu, MessageType.CosemApduXml, MessageType.ManufacturerSpesific });
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
                ObjectsLV.Items.Clear();
                foreach (var it in ((GXDLMSPushSetup)Target).PushObjectList)
                {
                    ListViewItem li = new ListViewItem(it.Key.ObjectType.ToString());
                    li.SubItems.Add(it.Key.LogicalName);
                    li.SubItems.Add(it.Value.AttributeIndex.ToString());
                    li.SubItems.Add(it.Value.DataIndex.ToString());
                    ObjectsLV.Items.Add(li);
                    li.Tag = it;
                }
            }
            else if (index == 3)
            {
                ServiceCB.SelectedIndexChanged -= new System.EventHandler(this.ServiceCB_SelectedIndexChanged);
                ServiceCB.SelectedItem = ((GXDLMSPushSetup)Target).Service;
                ServiceCB.SelectedIndexChanged += new System.EventHandler(this.ServiceCB_SelectedIndexChanged);

                DestinationTB.TextChanged -= new System.EventHandler(this.DestinationTB_TextChanged);
                DestinationTB.Text = ((GXDLMSPushSetup)Target).Destination;
                DestinationTB.TextChanged += new System.EventHandler(this.DestinationTB_TextChanged);
                MessageCB.SelectedIndexChanged -= new System.EventHandler(this.MessageCB_SelectedIndexChanged);
                MessageCB.SelectedItem = ((GXDLMSPushSetup)Target).Message;
                MessageCB.SelectedIndexChanged += new System.EventHandler(this.MessageCB_SelectedIndexChanged);
            }
            else if (index == 4)
            {
                CommunicationWindowLV.Items.Clear();
                foreach (KeyValuePair<GXDateTime, GXDateTime> it in ((GXDLMSPushSetup)Target).CommunicationWindow)
                {
                    ListViewItem li = new ListViewItem(it.Key.ToString());
                    li.SubItems.Add(it.Value.ToString());
                    CommunicationWindowLV.Items.Add(li);
                    li.Tag = it;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            arg.Value = (sbyte)0;
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
            errorProvider1.Clear();
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 2)
            {
                ObjectsAddBtn.Enabled = ObjectsEditBtn.Enabled =
                    ObjectsRemoveBtn.Enabled = ObjectsMenu.Enabled = enabled;
            }
            else if (index == 3)
            {
                MessageCB.Enabled = MessageCB.Enabled = enabled;
                DestinationTB.ReadOnly = !enabled;
            }
            else if (index == 4)
            {
                CommunicationAdd.Enabled = CommunicationEdit.Enabled =
                    CommunicationRemove.Enabled = CommunicationWindowMenu.Enabled = enabled;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
            if (index == 1)
            {
                PushBtn.Enabled = connected && mode == MethodAccessMode.Access;
            }
        }

        #endregion

        private void ServiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            (Target as GXDLMSPushSetup).Service = (ServiceType)ServiceCB.SelectedItem;
            Target.UpdateDirty(3, ServiceCB.SelectedItem);
        }

        private void MessageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            (Target as GXDLMSPushSetup).Message = (MessageType)MessageCB.SelectedItem;
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            Target.UpdateDirty(3, MessageCB.SelectedItem);
        }

        private void DestinationTB_TextChanged(object sender, EventArgs e)
        {
            (Target as GXDLMSPushSetup).Destination = DestinationTB.Text;
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
            Target.UpdateDirty(3, DestinationTB.Text);
        }

        /// <summary>
        /// Add new Object to push view.
        /// </summary>
        private void ObjectsAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSPushSetup target = Target as GXDLMSPushSetup;
                KeyValuePair<GXDLMSObject, GXDLMSCaptureObject> it = new KeyValuePair<GXDLMSObject, GXDLMSCaptureObject>();
                GXDLMSPushTargetDlg dlg = new GXDLMSPushTargetDlg(it, target.Parent as GXDLMSObjectCollection);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    it = dlg.Target;
                    ListViewItem li = ObjectsLV.Items.Add(it.Key.ObjectType.ToString());
                    li.SubItems.Add(it.Key.LogicalName);
                    li.SubItems.Add(it.Value.AttributeIndex.ToString());
                    li.SubItems.Add(it.Value.DataIndex.ToString());
                    li.Tag = it;
                    target.PushObjectList.Add(it);
                }
                errorProvider1.SetError(ObjectsLV, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(2, target.PushObjectList);
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit Object.
        /// </summary>
        private void ObjectsEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjectsLV.SelectedItems.Count == 1)
                {
                    GXDLMSPushSetup target = Target as GXDLMSPushSetup;
                    ListViewItem li = ObjectsLV.SelectedItems[0];
                    KeyValuePair<GXDLMSObject, GXDLMSCaptureObject> it = (KeyValuePair<GXDLMSObject, GXDLMSCaptureObject>)li.Tag;
                    GXDLMSPushTargetDlg dlg = new GXDLMSPushTargetDlg(it, target.Parent as GXDLMSObjectCollection);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        target.PushObjectList.Remove(it);
                        it = dlg.Target;
                        target.PushObjectList.Add(it);
                        li.SubItems[0].Text = it.Key.ObjectType.ToString();
                        li.SubItems[1].Text = it.Key.LogicalName;
                        li.SubItems[2].Text = it.Value.AttributeIndex.ToString();
                        li.SubItems[3].Text = it.Value.DataIndex.ToString();
                        li.Tag = it;
                        errorProvider1.SetError(ObjectsLV, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(2, target.PushObjectList);
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
        /// Remove Object.
        /// </summary>
        private void ObjectsRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                KeyValuePair<GXDLMSObject, GXDLMSCaptureObject> item;
                GXDLMSPushSetup target = Target as GXDLMSPushSetup;
                while (ObjectsLV.SelectedItems.Count != 0)
                {
                    ListViewItem li = ObjectsLV.SelectedItems[0];
                    item = (KeyValuePair<GXDLMSObject, GXDLMSCaptureObject>)li.Tag;
                    ObjectsLV.Items.Remove(ObjectsLV.SelectedItems[0]);
                    errorProvider1.SetError(ObjectsLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.PushObjectList);
                    target.PushObjectList.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add new communication window item.
        /// </summary>
        private void CommunicationAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSPushSetup target = Target as GXDLMSPushSetup;
                KeyValuePair<GXDateTime, GXDateTime> it = new KeyValuePair<GXDateTime, GXDateTime>(new GXDateTime(DateTime.Now), new GXDateTime(DateTime.Now));
                GXDateTimeDlg dlg = new GXDateTimeDlg(it.Key, it.Value);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    ListViewItem li = CommunicationWindowLV.Items.Add(it.Key.ToFormatString());
                    li.SubItems.Add(it.Value.ToFormatString());
                    li.Tag = it;
                    target.CommunicationWindow.Add(it);
                    errorProvider1.SetError(CommunicationWindowLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.CommunicationWindow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit communication window item.
        /// </summary>
        private void CommunicationEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CommunicationWindowLV.SelectedItems.Count == 1)
                {
                    GXDLMSPushSetup target = Target as GXDLMSPushSetup;
                    ListViewItem li = CommunicationWindowLV.SelectedItems[0];
                    KeyValuePair<GXDateTime, GXDateTime> it = (KeyValuePair<GXDateTime, GXDateTime>)li.Tag;
                    GXDateTimeDlg dlg = new GXDateTimeDlg(it.Key, it.Value);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        li.SubItems[0].Text = it.Key.ToFormatString();
                        li.SubItems[1].Text = it.Value.ToFormatString();
                        errorProvider1.SetError(CommunicationWindowLV, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(4, target.CommunicationWindow);
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
        /// Remove communication window item.
        /// </summary>
        private void CommunicationRemove_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSPushSetup target = Target as GXDLMSPushSetup;
                while (CommunicationWindowLV.SelectedItems.Count != 0)
                {
                    KeyValuePair<GXDateTime, GXDateTime> item = (KeyValuePair<GXDateTime, GXDateTime>)CommunicationWindowLV.SelectedItems[0].Tag;
                    CommunicationWindowLV.Items.Remove(CommunicationWindowLV.SelectedItems[0]);
                    errorProvider1.SetError(CommunicationWindowLV, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.CommunicationWindow);
                    target.CommunicationWindow.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
