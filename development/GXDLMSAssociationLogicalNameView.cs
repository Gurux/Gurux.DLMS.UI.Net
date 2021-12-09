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
using Gurux.DLMS.Objects.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSAssociationLogicalName
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSAssociationLogicalName))]
    partial class GXDLMSAssociationLogicalNameView : Form, IGXDLMSView
    {

        class Country
        {
            public string Name = "";
            public byte JointIsoCtt;
            public byte CountryElement;
            public UInt16 CountryName;

            public override string ToString()
            {
                return Name;
            }
        }

        List<Country> Countries = new List<Country>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAssociationLogicalNameView()
        {
            InitializeComponent();
            string[] countries = Properties.Resources.Country.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string it in countries)
            {
                if (!it.StartsWith("#"))
                {
                    Country c = new Country();
                    string[] data = it.Split(new char[] { ';' });
                    c.Name = data[0];
                    string[] items = data[1].Split('.');
                    c.JointIsoCtt = byte.Parse(items[0]);
                    c.CountryElement = byte.Parse(items[1]);
                    c.CountryName = UInt16.Parse(items[2].Substring(3, items[2].Length - 4));
                    Countries.Add(c);
                    ApplicationRegistrationAuthorityCb.Items.Add(c);
                    AuthenticationRegistrationAuthorityCb.Items.Add(c);
                }
            }

            foreach (var it in Enum.GetValues(typeof(Authentication)))
            {
                AuthenticationMechanismIdCb.Items.Add(it);
            }
        }

        #region IGXDLMSView Members

        GXDLMSObject _target;
        public GXDLMSObject Target
        {
            get
            {
                return _target;
            }
            set
            {
                _target = value;
                if (value != null)
                {
                    VersionTb.Text = value.Version.ToString();
                }
                else
                {
                    VersionTb.Text = "";
                }                
            }
        }      

        Country FindCountry(byte jointIsoCtt, byte countryElement, UInt16 countryName)
        {
            foreach (var it in Countries)
            {
                if (it.JointIsoCtt == jointIsoCtt && it.CountryElement == countryElement && it.CountryName == countryName)
                {
                    return it;
                }
            }
            return null;
        }

        private bool Freeze;

        private void ShowConformance(Conformance c)
        {
            Freeze = true;
            GeneralProtectionCB.Checked = (c & Conformance.GeneralProtection) != 0;
            GeneralBlockTransferCB.Checked = (c & Conformance.GeneralBlockTransfer) != 0;
            Attribute0SetReferencingCB.Checked = (c & Conformance.Attribute0SupportedWithSet) != 0;
            PriorityManagementCB.Checked = (c & Conformance.PriorityMgmtSupported) != 0;
            Attribute0GetReferencingCB.Checked = (c & Conformance.Attribute0SupportedWithGet) != 0;
            GetBlockTransferCB.Checked = (c & Conformance.BlockTransferWithGetOrRead) != 0;
            SetBlockTransferCB.Checked = (c & Conformance.BlockTransferWithSetOrWrite) != 0;
            ActionBlockTransferCB.Checked = (c & Conformance.BlockTransferWithAction) != 0;
            MultipleReferencesCB.Checked = (c & Conformance.MultipleReferences) != 0;
            DataNotificationCB.Checked = (c & Conformance.DataNotification) != 0;
            AccessCB.Checked = (c & Conformance.Access) != 0;
            GetCB.Checked = (c & Conformance.Get) != 0;
            SetCB.Checked = (c & Conformance.Set) != 0;
            SelectiveAccessCB.Checked = (c & Conformance.SelectiveAccess) != 0;
            EventNotificationCB.Checked = (c & Conformance.EventNotification) != 0;
            ActionCB.Checked = (c & Conformance.Action) != 0;
            DeltaValueEncodingCb.Checked = (c & Conformance.DeltaValueEncoding) != 0;
            Freeze = false;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
            //object list.
            if (arg.Index == 2)
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
                                if (target.Version < 3)
                                {
                                    AccessMode mode = it.GetAccess(pos);
                                    str += pos.ToString() + " = " + mode;
                                }
                                else
                                {
                                    AccessMode3 mode = it.GetAccess3(pos);
                                    str += pos.ToString() + " = " + mode;
                                }
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
                                if (target.Version < 3)
                                {
                                    MethodAccessMode mode = it.GetMethodAccess(pos);
                                    str += pos.ToString() + " = " + mode;
                                }
                                else
                                {
                                    MethodAccessMode3 mode = it.GetMethodAccess3(pos);
                                    str += pos.ToString() + " = " + mode;
                                }
                            }
                            li.SubItems.Add(str);
                        }
                    }
                }
            }
            //Associated partners ID.
            else if (arg.Index == 3)
            {
                ClientSAPTb.Text = Convert.ToString(target.ClientSAP);
                ServerSAPTb.Text = Convert.ToString(target.ServerSAP);
            }
            else if (arg.Index == 4)
            {
                try
                {
                    this.ApplicationContextIDCb.SelectedIndexChanged -= new System.EventHandler(this.ApplicationContextIDCb_SelectedIndexChanged);
                    ApplicationContextIDCb.Items.Clear();
                    if (target.ApplicationContextName.ContextId == ApplicationContextName.LogicalName ||
                        target.ApplicationContextName.ContextId == ApplicationContextName.LogicalNameWithCiphering)
                    {
                        ApplicationContextIDCb.Items.AddRange(new object[] {
                        ApplicationContextName.LogicalName, ApplicationContextName.LogicalNameWithCiphering});
                    }
                    else
                    {
                        ApplicationContextIDCb.Items.AddRange(new object[] {
                        ApplicationContextName.ShortName, ApplicationContextName.ShortNameWithCiphering});
                    }
                    // Application context name.
                    ApplicationJointISOCTTTb.Text = Convert.ToString(target.ApplicationContextName.JointIsoCtt);
                    ApplicationCountryTb.Text = Convert.ToString(target.ApplicationContextName.Country);
                    ApplicationCountryNameTb.Text = Convert.ToString(target.ApplicationContextName.CountryName);
                    ApplicationIdentifiedOrganizationTb.Text = Convert.ToString(target.ApplicationContextName.IdentifiedOrganization);
                    ApplicationDLMSUATb.Text = Convert.ToString(target.ApplicationContextName.DlmsUA);
                    ApplicationContextTb.Text = Convert.ToString(target.ApplicationContextName.ApplicationContext);
                    ApplicationContextIDCb.SelectedItem = target.ApplicationContextName.ContextId;
                    ApplicationRegistrationAuthorityCb.SelectedItem = FindCountry(target.ApplicationContextName.JointIsoCtt, target.ApplicationContextName.Country, target.ApplicationContextName.CountryName);
                }
                finally
                {
                    ApplicationContextIDCb.SelectedIndexChanged += new System.EventHandler(this.ApplicationContextIDCb_SelectedIndexChanged);
                }
            }
            else if (arg.Index == 5)
            {
                // xDLMS_context_info
                ShowConformance(target.XDLMSContextInfo.Conformance);
                MaxReceivePDUSizeTb.Text = target.XDLMSContextInfo.MaxReceivePduSize.ToString();
                MaxSendPDUSizeTb.Text = target.XDLMSContextInfo.MaxSendPduSize.ToString();
                DLMSVersionNumberTB.Text = target.XDLMSContextInfo.DlmsVersionNumber.ToString();
                CypheringInfoTb.Text = GXDLMSTranslator.ToHex(target.XDLMSContextInfo.CypheringInfo);
            }
            else if (arg.Index == 6)
            {
                Freeze = true;
                // authentication_mechanism_name
                AuthenticationJointISOCTTTb.Text = Convert.ToString(target.AuthenticationMechanismName.JointIsoCtt);
                AuthenticationCountryTb.Text = Convert.ToString(target.AuthenticationMechanismName.Country);
                AuthenticationCountryNameTb.Text = Convert.ToString(target.AuthenticationMechanismName.CountryName);
                AuthenticationIdentifiedorganizationTb.Text = Convert.ToString(target.AuthenticationMechanismName.IdentifiedOrganization);
                AuthenticationDLMSUATb.Text = Convert.ToString(target.AuthenticationMechanismName.DlmsUA);
                AuthenticationMechanismNameTb.Text = Convert.ToString(target.AuthenticationMechanismName.AuthenticationMechanismName);
                AuthenticationMechanismIdCb.Text = Convert.ToString(target.AuthenticationMechanismName.MechanismId);
                AuthenticationRegistrationAuthorityCb.SelectedItem = FindCountry(target.AuthenticationMechanismName.JointIsoCtt, target.AuthenticationMechanismName.Country, target.AuthenticationMechanismName.CountryName);
                Freeze = false;
            }
            else if (arg.Index == 7)
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
            else if (arg.Index == 9)
            {
                SecuritySetupCb.Items.Clear();
                //security_setup_reference
                if (target.Parent != null)
                {
                    SecuritySetupCb.Items.Add("");
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
            //User list.
            else if (arg.Index == 10)
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
            else if (arg.Index == 11) //Current user
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

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            bool writable= arg.Connected && arg.Client.CanWrite(Target, arg.Index);
            if (arg.Index == 2)
            {
            }
            else if (arg.Index == 3)
            {
                ClientSAPTb.ReadOnly = ServerSAPTb.ReadOnly = !writable;
            }
            else if (arg.Index == 4)
            {
                // Application context name.
                ApplicationJointISOCTTTb.ReadOnly = ApplicationCountryTb.ReadOnly =
                ApplicationCountryNameTb.ReadOnly = ApplicationIdentifiedOrganizationTb.ReadOnly =
                ApplicationDLMSUATb.ReadOnly = ApplicationContextTb.ReadOnly = true;
                ApplicationContextIDCb.Enabled = writable;
            }
            else if (arg.Index == 5)
            {
                // xDLMS_context_info
                MaxReceivePDUSizeTb.ReadOnly = MaxSendPDUSizeTb.ReadOnly =
                    DLMSVersionNumberTB.ReadOnly = CypheringInfoTb.ReadOnly = !writable;

                GeneralProtectionCB.Enabled = GeneralBlockTransferCB.Enabled = Attribute0SetReferencingCB.Enabled =
                    PriorityManagementCB.Enabled = Attribute0GetReferencingCB.Enabled = GetBlockTransferCB.Enabled =
                SetBlockTransferCB.Enabled = ActionBlockTransferCB.Enabled = MultipleReferencesCB.Enabled =
                DataNotificationCB.Enabled = AccessCB.Enabled = GetCB.Enabled = SetCB.Enabled =
                SelectiveAccessCB.Enabled = EventNotificationCB.Enabled = ActionCB.Enabled = DeltaValueEncodingCb.Enabled = writable;
            }
            else if (arg.Index == 6)
            {
                // authentication_mechanism_name
                AuthenticationJointISOCTTTb.ReadOnly = AuthenticationCountryTb.ReadOnly = AuthenticationCountryNameTb.ReadOnly =
                    AuthenticationIdentifiedorganizationTb.ReadOnly = AuthenticationDLMSUATb.ReadOnly =
                    AuthenticationMechanismNameTb.ReadOnly = !writable;
                AuthenticationMechanismIdCb.Enabled = writable;
            }
            else if (arg.Index == 9)
            {
                SecuritySetupCb.Enabled = writable;
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
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
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                GXDLMSAssociationViewDlg dlg = new GXDLMSAssociationViewDlg(target, it, true, remove);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
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

        delegate void UpdatePasswordDialogEventHandler(GXActionArgs arg);

        void OnUpdatePassword(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new UpdatePasswordDialogEventHandler(OnUpdatePassword), arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                //Update pw.
                GXTextDlg dlg;
                if (arg.Action == ActionType.Write)
                {
                    dlg = new GXTextDlg("Update Low level password.", "Password", "");
                }
                else
                {
                    dlg = new GXTextDlg("Update High level password.", "Password", "");
                }
                arg.Handled = dlg.ShowDialog(Parent) != DialogResult.OK;
                if (!arg.Handled)
                {
                    byte[] value;
                    if (!dlg.GetValue().StartsWith("0x"))
                    {
                        value = ASCIIEncoding.ASCII.GetBytes(dlg.GetValue());
                    }
                    else
                    {
                        value = GXDLMSTranslator.HexToBytes(dlg.GetValue());
                    }
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
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
            if ((arg.Action == ActionType.Write && arg.Index == 7) ||
                arg.Action == ActionType.Action && arg.Index == 2)
            {
                OnUpdatePassword(arg);
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
            else
            {
                arg.Action = ActionType.None;
            }
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
            try
            {
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                if (SecuritySetupCb.SelectedItem is GXDLMSSecuritySetup)
                {
                    target.SecuritySetupReference = ((GXDLMSSecuritySetup)SecuritySetupCb.SelectedItem).LogicalName;
                }
                else
                {
                    target.SecuritySetupReference = null;
                }
                errorProvider1.SetError(SecuritySetupCb, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(9, SecuritySetupCb.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void ApplicationContextIDCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                target.ApplicationContextName.ContextId = (ApplicationContextName)ApplicationContextIDCb.SelectedItem;
                errorProvider1.SetError(ApplicationContextIDCb, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(4, ApplicationContextIDCb.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void MaxReceivePDUSizeTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (MaxReceivePDUSizeTb.Text != "")
                {
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    UInt16 v;
                    if (UInt16.TryParse(MaxReceivePDUSizeTb.Text, out v) && target.XDLMSContextInfo.MaxReceivePduSize != v)
                    {
                        target.XDLMSContextInfo.MaxReceivePduSize = v;
                        Target.UpdateDirty(5, target.XDLMSContextInfo);
                        errorProvider1.SetError(MaxReceivePDUSizeTb, Properties.Resources.ValueChangedTxt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaxSendPDUSizeTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (MaxSendPDUSizeTb.Text != "")
                {
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    UInt16 v;
                    if (UInt16.TryParse(MaxSendPDUSizeTb.Text, out v) && target.XDLMSContextInfo.MaxSendPduSize != v)
                    {
                        target.XDLMSContextInfo.MaxSendPduSize = v;
                        Target.UpdateDirty(5, target.XDLMSContextInfo);
                        errorProvider1.SetError(MaxSendPDUSizeTb, Properties.Resources.ValueChangedTxt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// User has change client SAP.
        /// </summary>
        private void ClientSAPTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ClientSAPTb.Text != "")
                {
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    byte v;
                    if (byte.TryParse(ClientSAPTb.Text, out v) && target.ClientSAP != v)
                    {
                        if (v > 0x7F)
                        {
                            throw new ArgumentOutOfRangeException("Client SAP must be between 0 to 127");
                        }
                        target.ClientSAP = v;
                        Target.UpdateDirty(3, target.ClientSAP);
                        errorProvider1.SetError(ClientSAPTb, Properties.Resources.ValueChangedTxt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// User has change server SAP.
        /// </summary>
        private void ServerSAPTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ServerSAPTb.Text != "")
                {
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    UInt16 v;
                    if (UInt16.TryParse(ServerSAPTb.Text, out v) && target.ServerSAP != v)
                    {
                        if (v > 0x3FFF)
                        {
                            throw new ArgumentOutOfRangeException("Server SAP must be between 0 to 16383");
                        }
                        target.ServerSAP = v;
                        Target.UpdateDirty(3, target.ServerSAP);
                        errorProvider1.SetError(ServerSAPTb, Properties.Resources.ValueChangedTxt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AuthenticationMechanismIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Freeze)
            {
                try
                {
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    target.AuthenticationMechanismName.MechanismId = (Authentication)AuthenticationMechanismIdCb.SelectedItem;
                    errorProvider1.SetError(AuthenticationMechanismIdCb, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(6, AuthenticationMechanismIdCb.SelectedItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
            }
        }

        private void OnConformanceChange(object sender, EventArgs e)
        {
            if (!Freeze)
            {
                try
                {
                    Conformance c = Conformance.None;
                    if (GeneralProtectionCB.Checked)
                    {
                        c |= Conformance.GeneralProtection;
                    }
                    if (GeneralBlockTransferCB.Checked)
                    {
                        c |= Conformance.GeneralBlockTransfer;
                    }
                    if (Attribute0SetReferencingCB.Checked)
                    {
                        c |= Conformance.Attribute0SupportedWithSet;
                    }
                    if (PriorityManagementCB.Checked)
                    {
                        c |= Conformance.PriorityMgmtSupported;
                    }
                    if (Attribute0GetReferencingCB.Checked)
                    {
                        c |= Conformance.Attribute0SupportedWithGet;
                    }
                    if (GetBlockTransferCB.Checked)
                    {
                        c |= Conformance.BlockTransferWithGetOrRead;
                    }
                    if (SetBlockTransferCB.Checked)
                    {
                        c |= Conformance.BlockTransferWithSetOrWrite;
                    }
                    if (ActionBlockTransferCB.Checked)
                    {
                        c |= Conformance.BlockTransferWithAction;
                    }
                    if (MultipleReferencesCB.Checked)
                    {
                        c |= Conformance.MultipleReferences;
                    }
                    if (DataNotificationCB.Checked)
                    {
                        c |= Conformance.DataNotification;
                    }
                    if (AccessCB.Checked)
                    {
                        c |= Conformance.Access;
                    }
                    if (GetCB.Checked)
                    {
                        c |= Conformance.Get;
                    }
                    if (SetCB.Checked)
                    {
                        c |= Conformance.Set;
                    }
                    if (SelectiveAccessCB.Checked)
                    {
                        c |= Conformance.SelectiveAccess;
                    }
                    if (EventNotificationCB.Checked)
                    {
                        c |= Conformance.EventNotification;
                    }
                    if (ActionCB.Checked)
                    {
                        c |= Conformance.Action;
                    }
                    if (DeltaValueEncodingCb.Checked)
                    {
                        c |= Conformance.DeltaValueEncoding;
                    }
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    target.XDLMSContextInfo.Conformance = c;
                    errorProvider1.SetError(LNSettings, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(5, target.XDLMSContextInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                }
            }
        }
    }
}
