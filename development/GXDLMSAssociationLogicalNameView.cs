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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
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

        public void OnValueChanged(int index, object value, bool user)
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
        }

        public void OnAccessRightsChange(int index, AccessMode access)
        {
            if (index == 7)
            {
                bool enabled = (access & AccessMode.Write) != 0;
                UpdatePwBtn.Enabled = enabled;
                SecretTB.ReadOnly = !enabled;
            }
            else if (index == 9)
            {
                SecuritySetupCb.Enabled = (access & AccessMode.Write) != 0;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode)
        {
        }

        public ActionType PreAction(GXDLMSClient client, ActionType type, ValueEventArgs arg)
        {
            if (type == ActionType.Write && arg.Index == 7)
            {
                DialogResult ret;
                //Update current time
                ret = MessageBox.Show(this, Properties.Resources.SetPasswordWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
                    if (Target.GetMethodAccess(2) == MethodAccessMode.Access)
                    {
                        type = ActionType.Action;
                        arg.Index = 2;
                    }
                    else
                    {
                        arg.Index = 7;
                    }
                    if (type == ActionType.Write)
                    {
                        GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                        target.Secret = value;
                    }
                    else
                    {
                        GXByteBuffer bb = new GXByteBuffer();
                        bb.SetUInt8((byte) DataType.OctetString);
                        bb.SetUInt8((byte)value.Length);
                        bb.Set(value);
                        arg.Value = bb.Array();
                    }
                }
                arg.Handled = ret != DialogResult.Yes;
            }
            else if (type == ActionType.Write && arg.Index == 2)
            {
                //Skip write invoke.
                arg.Handled = true;
            }
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

        /// <summary>
        /// Add object to association view.
        /// </summary>
        private void ObjectAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                GXDLMSObject it = new GXDLMSData();
                GXDLMSAssociationViewDlg dlg = new GXDLMSAssociationViewDlg(it, true);
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    it = dlg.GetTarget();
                    ListViewItem li = ObjectsView.Items.Add(it.ObjectType.ToString());
                    li.SubItems.Add(it.Version.ToString());
                    li.SubItems.Add(it.LogicalName);
                    li.SubItems.Add("");
                    li.SubItems.Add("");
                    li.Tag = it;
                    target.ObjectList.Add(it);
                }
                errorProvider1.SetError(ObjectsView, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(2, target.ObjectList);
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit object in association view.
        /// </summary>
        private void ObjectEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ObjectsView.SelectedItems.Count == 1)
                {
                    GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                    ListViewItem li = ObjectsView.SelectedItems[0];
                    GXDLMSObject it = (GXDLMSObject)li.Tag;
                    GXDLMSAssociationViewDlg dlg = new GXDLMSAssociationViewDlg(it, true);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        it = dlg.GetTarget();
                        li.SubItems[0].Text = it.ObjectType.ToString();
                        li.SubItems[1].Text = it.Version.ToString();
                        li.SubItems[1].Text = it.LogicalName;
                        errorProvider1.SetError(ObjectsView, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(2, target.ObjectList);
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
        /// Remove object from association view.
        /// </summary>
        private void ObjectRemoveBtn_Click(object sender, EventArgs e)
        {

            try
            {
                GXDLMSObject item;
                GXDLMSAssociationLogicalName target = Target as GXDLMSAssociationLogicalName;
                while (ObjectsView.SelectedItems.Count != 0)
                {
                    ListViewItem li = ObjectsView.SelectedItems[0];
                    item = (GXDLMSObject)li.Tag;
                    ObjectsView.Items.Remove(ObjectsView.SelectedItems[0]);
                    errorProvider1.SetError(ObjectsView, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(2, target.ObjectList);
                    target.ObjectList.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModifyBtn_Click(object sender, EventArgs e)
        {

        }

        private void SecuritySetupCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(SecuritySetupCb, Properties.Resources.ValueChangedTxt);
            Target.UpdateDirty(9, SecuritySetupCb.SelectedItem);
        }
    }
}
