//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSAssociationLogicalNameView.cs $
//
// Version:         $Revision: 4781 $,
//                  $Date: 2012-03-19 10:23:38 +0200 (ma, 19 maalis 2012) $
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
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Collections.Generic;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSAssociationLogicalName
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSAssociationLogicalName))]
    partial class GXDLMSAssociationLogicalNameView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAssociationLogicalNameView()
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
            GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
            //object list.
            if (index == 2)
            {
                GXDLMSObjectCollection items = target.ObjectList;
                ObjectsView.Items.Clear();
                if (items != null)
                {
                    foreach (GXDLMSObject it in items)
                    {
                        ListViewItem li = ObjectsView.Items.Add(it.ObjectType.ToString());
                        li.SubItems.Add(it.Version.ToString()); //Version
                        li.SubItems.Add(it.LogicalName);
                        li.Tag = it;
                        //access_rights: access_right
                        if (it is IGXDLMSBase)
                        {
                            string str = null;
                            //Show attribute access.
                            int cnt = (it as IGXDLMSBase).GetAttributeCount();
                            for (int pos = 1; pos != cnt + 1; ++pos)
                            {
                                if (str != null)
                                {
                                    str += ", ";
                                }
                                AccessMode mode = it.GetAccess(pos);
                                str += pos.ToString() + " = " + mode;
                            }
                            li.SubItems.Add(str);
                            //Show method access.
                            str = null;
                            cnt = (it as IGXDLMSBase).GetMethodCount();
                            for (int pos = 1; pos != cnt + 1; ++pos)
                            {
                                if (str != null)
                                {
                                    str += ", ";
                                }
                                MethodAccessMode mode = it.GetMethodAccess(pos);
                                str += pos.ToString() + " = " + mode;
                            }
                            li.SubItems.Add(str);
                        }
                    }
                }
            }
            //Associated partners ID.
            else if (index == 3)
            {
                ClientSAPTb.Text = Convert.ToString(target.ClientSAP);
                ServerSAPTb.Text = Convert.ToString(target.ServerSAP);
            }
            else if (index == 4)
            {
                // Application context name.
                ApplicationJointISOCTTTb.Text = Convert.ToString(target.ApplicationContextName.JointIsoCtt);
                ApplicationCountryTb.Text = Convert.ToString(target.ApplicationContextName.Country);
                ApplicationCountryNameTb.Text = Convert.ToString(target.ApplicationContextName.CountryName);
                ApplicationIdentifiedOrganizationTb.Text = Convert.ToString(target.ApplicationContextName.IdentifiedOrganization);
                ApplicationDLMSUATb.Text = Convert.ToString(target.ApplicationContextName.DlmsUA);
                ApplicationContextTb.Text = Convert.ToString(target.ApplicationContextName.ApplicationContext);
                ApplicationContextIDTb.Text = Convert.ToString(target.ApplicationContextName.ContextId);
            }
            else if (index == 5)
            {
                // xDLMS_context_info
                ConformanceTB.Text = target.XDLMSContextInfo.Conformance.ToString();
                MaxReceivePDUSizeTb.Text = target.XDLMSContextInfo.MaxReceivePduSize.ToString();
                MaxSendPDUSizeTb.Text = target.XDLMSContextInfo.MaxSendPduSize.ToString();
                DLMSVersionNumberTB.Text = target.XDLMSContextInfo.DlmsVersionNumber.ToString();
                CypheringInfoTb.Text = GXDLMSTranslator.ToHex(target.XDLMSContextInfo.CypheringInfo);
            }
            else if (index == 6)
            {
                // authentication_mechanism_name
                AuthenticationJointISOCTTTb.Text = Convert.ToString(target.AuthenticationMechanismName.JointIsoCtt);
                AuthenticationCountryTb.Text = Convert.ToString(target.AuthenticationMechanismName.Country);
                AuthenticationCountryNameTb.Text = Convert.ToString(target.AuthenticationMechanismName.CountryName);
                AuthenticationIdentifiedorganizationTb.Text = Convert.ToString(target.AuthenticationMechanismName.IdentifiedOrganization);
                AuthenticationDLMSUATb.Text = Convert.ToString(target.AuthenticationMechanismName.DlmsUA);
                AuthenticationMechanismNameTb.Text = Convert.ToString(target.AuthenticationMechanismName.AuthenticationMechanismName);
                AuthenticationMechanismIdTb.Text = Convert.ToString(target.AuthenticationMechanismName.MechanismId);
            }
            else if (index == 7)
            {
                //Secret.
                if (GXHelpers.IsAscii(target.Secret))
                {
                    SecretAsciiCb.Checked = true;
                    SecretTB.Text = ASCIIEncoding.ASCII.GetString(target.Secret);
                }
                else
                {
                    SecretTB.Text = GXDLMSTranslator.ToHex(target.Secret);
                }
            }
            else if (index == 9)
            {
                SecuritySetupCb.Items.Clear();
                //security_setup_reference
                if (target.Parent != null)
                {
                    foreach (GXDLMSSecuritySetup it in target.Parent.GetObjects(ObjectType.SecuritySetup))
                    {
                        SecuritySetupCb.Items.Add(it);
                        if (target.SecuritySetupReference == it.LogicalName)
                        {
                            SecuritySetupCb.SelectedIndexChanged -= new System.EventHandler(this.SecuritySetupCb_SelectedIndexChanged);
                            SecuritySetupCb.SelectedItem = it;
                            SecuritySetupCb.SelectedIndexChanged += new System.EventHandler(this.SecuritySetupCb_SelectedIndexChanged);
                        }
                    }
                }
                else
                {
                    GXDLMSSecuritySetup it = new GXDLMSSecuritySetup(target.SecuritySetupReference);
                    SecuritySetupCb.Items.Add(it);
                    SecuritySetupCb.SelectedIndexChanged -= new System.EventHandler(this.SecuritySetupCb_SelectedIndexChanged);
                    SecuritySetupCb.SelectedItem = it;
                    SecuritySetupCb.SelectedIndexChanged += new System.EventHandler(this.SecuritySetupCb_SelectedIndexChanged);
                }
            }
            //user list.
            else if (index == 10)
            {
                List<KeyValuePair<byte, string>> items = target.UserList;
                UsersList.Items.Clear();
                if (items != null)
                {
                    foreach (KeyValuePair<byte, string> it in items)
                    {
                        ListViewItem li = UsersList.Items.Add(it.Key.ToString());
                        li.SubItems.Add(it.Value);
                        li.Tag = it.Key;
                    }
                }
            }
            else if (index == 11) //Current user
            {
                foreach (ListViewItem it in UsersList.Items)
                {
                    if ((byte)it.Tag == target.CurrentUser.Key)
                    {
                        it.Selected = true;
                    }
                    else if (it.Selected)
                    {
                        it.Selected = false;
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 2)
            {
            }
            else if (index == 3)
            {
                ClientSAPTb.ReadOnly = ServerSAPTb.ReadOnly = (access & AccessMode.Write) == 0;
            }
            else if (index == 4)
            {
                // Application context name.
                ApplicationJointISOCTTTb.ReadOnly = ApplicationCountryTb.ReadOnly =
                ApplicationCountryNameTb.ReadOnly = ApplicationIdentifiedOrganizationTb.ReadOnly =
                ApplicationDLMSUATb.ReadOnly = ApplicationContextTb.ReadOnly =
                ApplicationContextIDTb.ReadOnly = (access & AccessMode.Write) == 0;
            }
            else if (index == 5)
            {
                // xDLMS_context_info
                ConformanceTB.ReadOnly = MaxReceivePDUSizeTb.ReadOnly = MaxSendPDUSizeTb.ReadOnly =
                    DLMSVersionNumberTB.ReadOnly = CypheringInfoTb.ReadOnly = (access & AccessMode.Write) == 0;
            }
            else if (index == 6)
            {
                // authentication_mechanism_name
                AuthenticationJointISOCTTTb.ReadOnly = AuthenticationCountryTb.ReadOnly = AuthenticationCountryNameTb.ReadOnly =
                    AuthenticationIdentifiedorganizationTb.ReadOnly = AuthenticationDLMSUATb.ReadOnly =
                    AuthenticationMechanismNameTb.ReadOnly = AuthenticationMechanismIdTb.ReadOnly = (access & AccessMode.Write) == 0;
            }
            else if (index == 7)
            {
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                bool enabled = false;
                if (target.AuthenticationMechanismName.MechanismId == Authentication.Low)
                {
                    enabled = (access & AccessMode.Write) != 0;
                    SecretLbl.Text = "Low Secret:";
                }
                else if (target.AuthenticationMechanismName.MechanismId == Authentication.High)
                {
                    enabled = Target.GetMethodAccess(2) == MethodAccessMode.Access;
                    SecretLbl.Text = "High Secret:";
                }
                else
                {
                    SecretLbl.Text = "Secret:";
                }
                UpdatePwBtn.Enabled = enabled;
                SecretTB.ReadOnly = !enabled;
            }
            else if (index == 9)
            {
                SecuritySetupCb.Enabled = (access & AccessMode.Write) != 0;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        delegate void ShowDialogEventHandler(GXDLMSObject it, GXActionArgs arg);

        void OnShowDialog(GXDLMSObject it, GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowDialogEventHandler(OnShowDialog), it, arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                ListViewItem li = null;
                bool remove = it == null;
                if (remove)
                {
                    if (ObjectsView.SelectedItems.Count == 1)
                    {
                        li = ObjectsView.SelectedItems[0];
                        it = (GXDLMSObject)li.Tag;
                    }
                    else
                    {
                        arg.Handled = true;
                        return;
                    }
                }
                GXDLMSAssociationViewDlg dlg = new GXDLMSAssociationViewDlg(it, true, remove);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    if (remove)
                    {
                        arg.Value = target.RemoveObject(arg.Client, it);
                        li.Remove();
                    }
                    else
                    {
                        it = dlg.GetTarget();
                        li = ObjectsView.Items.Add(it.ObjectType.ToString());
                        li.SubItems.Add(it.Version.ToString());
                        li.SubItems.Add(it.LogicalName);
                        li.SubItems.Add("");
                        li.SubItems.Add("");
                        li.Tag = it;
                        target.ObjectList.Add(it);
                        arg.Value = target.AddObject(arg.Client, it);
                    }
                }
                else
                {
                    arg.Handled = true;
                }
            }
        }

        delegate void ShowUserDialogEventHandler(bool addUser, GXActionArgs arg);

        void OnShowDialog(bool addUser, GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowUserDialogEventHandler(OnShowDialog), addUser, arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                if (addUser)
                {
                    GXUserDlg dlg = new GXUserDlg((byte)target.UserList.Count, "", false);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        ListViewItem li = UsersList.Items.Add(dlg.UserId.ToString());
                        li.SubItems.Add(dlg.UserName);
                        arg.Value = target.AddUser(arg.Client, dlg.UserId, dlg.UserName);
                    }
                    else
                    {
                        arg.Handled = true;
                    }
                }
                else
                {
                    if (UsersList.SelectedItems.Count == 1)
                    {
                        ListViewItem li = UsersList.SelectedItems[0];
                        GXUserDlg dlg = new GXUserDlg(byte.Parse(li.SubItems[0].Text), li.SubItems[1].Text, true);
                        if (dlg.ShowDialog(this) == DialogResult.OK)
                        {
                            arg.Value = target.RemoveUser(arg.Client, dlg.UserId, dlg.UserName);
                            li.Remove();
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
            //Add object to association view.
            if (arg.Index == 3)
            {
                GXDLMSObject it = new GXDLMSData();
                OnShowDialog(it, arg);
            }
            else if (arg.Index == 4)
            {
                // Remove object from association view.
                OnShowDialog(null, arg);
            }
            //Add user to user list.
            else if (arg.Index == 5)
            {
                OnShowDialog(true, arg);
            }
            else if (arg.Index == 6)
            {
                // Remove user from user list.
                OnShowDialog(false, arg);
            }
            if (arg.Action == ActionType.Write && arg.Index == 7)
            {
                DialogResult ret;
                //Update pw.
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.SetPasswordWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    byte[] value;
                    if (SecretAsciiCb.Checked)
                    {
                        value = ASCIIEncoding.ASCII.GetBytes(SecretTB.Text);
                    }
                    else
                    {
                        value = GXDLMSTranslator.HexToBytes(SecretTB.Text);
                    }
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    if (target.AuthenticationMechanismName.MechanismId == Authentication.Low)
                    {
                        arg.Index = 7;
                        arg.Action = ActionType.Write;
                    }
                    else
                    {
                        arg.Action = ActionType.Action;
                        arg.Index = 2;
                    }
                    if (arg.Action == ActionType.Write)
                    {
                        target.Secret = value;
                    }
                    else
                    {
                        GXByteBuffer bb = new GXByteBuffer();
                        bb.SetUInt8((byte)DataType.OctetString);
                        bb.SetUInt8((byte)value.Length);
                        bb.Set(value);
                        arg.Value = bb.Array();
                    }
                }
                arg.Handled = ret != DialogResult.Yes;
            }
            else if (arg.Action == ActionType.Write && arg.Index == 2)
            {
                //Skip write invoke.
                arg.Handled = true;
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            if (arg.Action == ActionType.Action && (arg.Index == 4 || arg.Index == 4))
            {
                arg.Action = ActionType.Read;
                arg.Index = 2;
            }
            else if (arg.Action == ActionType.Action && (arg.Index == 5 || arg.Index == 6))
            {
                arg.Action = ActionType.Read;
                arg.Index = 10;
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

        private void SecretAsciiCb_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (SecretAsciiCb.Checked)
                {
                    byte[] data = GXDLMSTranslator.HexToBytes(SecretTB.Text);
                    if (!GXHelpers.IsAscii(data))
                    {
                        SecretAsciiCb.CheckedChanged -= SecretAsciiCb_CheckedChanged;
                        SecretAsciiCb.Checked = !SecretAsciiCb.Checked;
                        SecretAsciiCb.CheckedChanged += SecretAsciiCb_CheckedChanged;
                        throw new ArgumentOutOfRangeException(Properties.Resources.InvalidASCII);
                    }
                    SecretTB.Text = ASCIIEncoding.ASCII.GetString(data);
                }
                else
                {
                    SecretTB.Text = GXDLMSTranslator.ToHex(ASCIIEncoding.ASCII.GetBytes(SecretTB.Text));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void SecuritySetupCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(SecuritySetupCb, Properties.Resources.ValueChangedTxt);
            Target.UpdateDirty(9, SecuritySetupCb.SelectedItem);
        }
    }
}
