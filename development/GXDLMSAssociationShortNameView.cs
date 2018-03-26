//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSAssociationShortNameView.cs $
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
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSAssociationShortName
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSAssociationShortName))]
    partial class GXDLMSAssociationShortNameView : Form, IGXDLMSView
    {

        Dictionary<int, ListViewItem> SNItems = new Dictionary<int, ListViewItem>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSAssociationShortNameView()
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
            GXDLMSAssociationShortName target = Target as GXDLMSAssociationShortName;
            GXDLMSObjectCollection items = target.ObjectList;
            if (index == 2)
            {
                ObjectsView.Items.Clear();
                if (items != null)
                {
                    SNItems.Clear();
                    foreach (GXDLMSObject it in items)
                    {
                        ListViewItem li = ObjectsView.Items.Add(Convert.ToString(it.ShortName, 16));
                        li.SubItems.AddRange(new string[] { it.ObjectType.ToString(), it.Version.ToString(),
                                                        it.LogicalName});
                        //access_rights: access_right
                        StringBuilder str = new StringBuilder();
                        //Show attribute access.
                        int cnt = (it as IGXDLMSBase).GetAttributeCount();
                        for (int pos = 1; pos != cnt + 1; ++pos)
                        {
                            if (str != null)
                            {
                                str.Append(", ");
                            }
                            AccessMode mode = it.GetAccess(pos);
                            str.Append(pos.ToString() + " = " + mode);
                        }
                        li.SubItems.Add(str.ToString());
                        //Show method access.
                        str.Length = 0;
                        cnt = (it as IGXDLMSBase).GetMethodCount();
                        for (int pos = 1; pos != cnt + 1; ++pos)
                        {
                            if (str != null)
                            {
                                str.Append(", ");
                            }
                            MethodAccessMode mode = it.GetMethodAccess(pos);
                            str.Append(pos.ToString() + " = " + mode);
                        }
                        li.SubItems.Add(str.ToString());
                        if (it.ShortName != 0)
                        {
                            SNItems.Add(it.ShortName, li);
                        }
                        li.Tag = it;
                    }
                }
            }
            //Update Access rights.
            if (index == 3)
            {
                //access_rights: access_right
                foreach (GXDLMSObject it in items)
                {
                    ListViewItem li = SNItems[it.ShortName];
                    StringBuilder str = new StringBuilder();
                    //Show attribute access.
                    int cnt = (it as IGXDLMSBase).GetAttributeCount();
                    for (int pos = 1; pos != cnt + 1; ++pos)
                    {
                        if (str != null)
                        {
                            str.Append(", ");
                        }
                        AccessMode mode = it.GetAccess(pos);
                        str.Append(pos.ToString() + " = " + mode);
                    }
                    li.SubItems[4].Text = str.ToString();
                    //Show method access.
                    str.Length = 0;
                    cnt = (it as IGXDLMSBase).GetMethodCount();
                    for (int pos = 1; pos != cnt + 1; ++pos)
                    {
                        if (str != null)
                        {
                            str.Append(", ");
                        }
                        MethodAccessMode mode = it.GetMethodAccess(pos);
                        str.Append(pos.ToString() + " = " + mode);
                    }
                    li.SubItems[5].Text = str.ToString();
                }

            }
            //security_setup_reference
            else if (index == 4)
            {
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

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {

        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
            if (index == 7)
            {
                SecretTB.ReadOnly = mode == MethodAccessMode.NoAccess;
                SecretAsciiCb.Enabled = !SecretTB.ReadOnly;
            }
        }

        public void PreAction(GXActionArgs arg)
        {
            DialogResult ret;
            //Update secret.
            if (arg.Index == 5)
            {
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.SecretSetWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (ret == DialogResult.Yes)
                {
                    if (SecretTB.Text.Length == 0)
                    {
                        throw new ArgumentException("Invalid password.");
                    }
                    if (SecretAsciiCb.Checked)
                    {
                        arg.Value = SecretTB.Text;
                    }
                    else
                    {
                        arg.Value = GXDLMSTranslator.HexToBytes(SecretTB.Text);
                    }
                }
                arg.Handled = ret != DialogResult.Yes;
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

        /// <summary>
        /// Add object to association view.
        /// </summary>
        private void ObjectAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSAssociationShortName target = Target as GXDLMSAssociationShortName;
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
                    GXDLMSAssociationShortName target = Target as GXDLMSAssociationShortName;
                    ListViewItem li = ObjectsView.SelectedItems[0];
                    GXDLMSObject it = (GXDLMSObject)li.Tag;
                    GXDLMSAssociationViewDlg dlg = new GXDLMSAssociationViewDlg(it, false, false);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        it = dlg.GetTarget();
                        li.SubItems[0].Text = it.ShortName.ToString();
                        li.SubItems[1].Text = it.ObjectType.ToString();
                        li.SubItems[2].Text = it.Version.ToString();
                        li.SubItems[3].Text = it.LogicalName;
                        li.Tag = it;
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
                GXDLMSAssociationShortName target = Target as GXDLMSAssociationShortName;
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

        private void SecuritySetupCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(SecuritySetupCb, Properties.Resources.ValueChangedTxt);
            Target.UpdateDirty(4, SecuritySetupCb.SelectedItem);
        }
    }
}
