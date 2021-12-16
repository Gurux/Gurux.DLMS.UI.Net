//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL$
//
// Version:         $Revision$,
//                  $Date$
//                  $Author$
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
// More information of Gurux products: https://www.gurux.org
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.Enums;
using Gurux.DLMS.ManufacturerSettings;
using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSAssociationViewDlg : Form
    {
        /// <summary>
        /// LN Association Versions 0-2 are using smaller amount of access rights than version 3 and higher.
        /// </summary>
        int version;
        DataGridViewColumn AccessRightsColumn;
        DataGridViewColumn MethodAccessRightsColumn;

        GXDLMSObject Target;
        GXDLMSConverter converter = new GXDLMSConverter();
        BindingSource bindingSource1 = new BindingSource();
        BindingSource bindingSource3 = new BindingSource();
        public GXDLMSObject GetTarget()
        {
            return Target;
        }

        DataGridViewColumn CreateAccessRightColumns(int ver)
        {
            if (ver == 0)
            {
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                column.DataSource = new object[] { AccessMode.NoAccess, AccessMode.Read, AccessMode.Write, AccessMode.ReadWrite };
                column.DataPropertyName = "Access";
                AccessRightsColumn = column;
            }
            else if (ver < 3)
            {
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                column.DataSource = Enum.GetValues(typeof(AccessMode));
                column.DataPropertyName = "Access";
                AccessRightsColumn = column;
            }
            else
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Access3";
                column.ReadOnly = true;
                AccessRightsColumn = column;
            }
            AccessRightsColumn.Name = "Access";
            return AccessRightsColumn;
        }

        DataGridViewColumn CreateMethodAccessRightColumns(int ver)
        {
            if (ver == 0)
            {
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                column.DataSource = new object[] { MethodAccessMode.NoAccess, MethodAccessMode.Access, MethodAccessMode.AuthenticatedAccess };
                column.DataPropertyName = "MethodAccess";
                MethodAccessRightsColumn = column;
            }
            else if (ver < 3)
            {
                DataGridViewComboBoxColumn column = new DataGridViewComboBoxColumn();
                column.DataSource = Enum.GetValues(typeof(MethodAccessMode));
                column.DataPropertyName = "MethodAccess";
                MethodAccessRightsColumn = column;
            }
            else
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "MethodAccess3";
                column.ReadOnly = true;
                MethodAccessRightsColumn = column;
            }
            MethodAccessRightsColumn.Name = "Method access";
            return MethodAccessRightsColumn;
        }

        private void CreateAccessrightsColumns(int ver)
        {
            //Add access right view.
            Accessrights.AutoGenerateColumns = false;
            Accessrights.AutoSize = true;
            Accessrights.Columns.Clear();
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Index";
            column.Name = "Attribute Index";
            column.ReadOnly = true;
            Accessrights.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Description";
            column.ReadOnly = true;
            Accessrights.Columns.Add(column);
            Accessrights.Columns.Add(CreateAccessRightColumns(ver));
            //Add access right view.
            MethodAccessrights.AutoGenerateColumns = false;
            MethodAccessrights.AutoSize = true;
            MethodAccessrights.Columns.Clear();
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Index";
            column.Name = "Attribute Index";
            column.ReadOnly = true;
            MethodAccessrights.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Description";
            column.ReadOnly = true;
            MethodAccessrights.Columns.Add(column);
            MethodAccessrights.Columns.Add(CreateMethodAccessRightColumns(ver));
            MethodAccessrights.AllowUserToAddRows = false;
            MethodAccessrights.AllowUserToDeleteRows = false;
            MethodAccessrights.AutoSize = true;

            AccessRightAllCb.Items.Clear();
            MethodAccessRightAllCb.Items.Clear();
            if (ver == 0)
            {
                AccessRightAllCb.Items.AddRange(new object[] { AccessMode.NoAccess, AccessMode.Read, AccessMode.Write, AccessMode.ReadWrite });
                MethodAccessRightAllCb.Items.AddRange(new object[] { MethodAccessMode.NoAccess, MethodAccessMode.Access, MethodAccessMode.AuthenticatedAccess });
            }
            else if (ver < 3)
            {
                foreach (ValueType it in Enum.GetValues(typeof(AccessMode)))
                {
                    AccessRightAllCb.Items.Add(it);
                }
                MethodAccessRightAllCb.Items.AddRange(new object[] { MethodAccessMode.NoAccess, MethodAccessMode.Access, MethodAccessMode.AuthenticatedAccess });
            }
            else
            {
                foreach (ValueType it in Enum.GetValues(typeof(AccessMode3)))
                {
                    AccessRightAllCb.Items.Add(it);
                }
                foreach (ValueType it in Enum.GetValues(typeof(MethodAccessMode3)))
                {
                    MethodAccessRightAllCb.Items.Add(it);
                }
            }
            AccessRightAllCb.SelectedIndex = 0;
            MethodAccessRightAllCb.SelectedIndex = 0;
        }

        public GXDLMSAssociationViewDlg(object parent, GXDLMSObject target, bool LogicalNameReferencing, bool remove)
        {
            Target = target;
            if (parent is GXDLMSAssociationLogicalName ln)
            {
                version = ln.Version;
            }
            else if (parent is GXDLMSAssociationShortName sn)
            {
                version = sn.Version;
            }
            InitializeComponent();
            CreateAccessrightsColumns(version);
            SortedSet<ObjectType> items = new SortedSet<ObjectType>();
            foreach (KeyValuePair<ObjectType, int> it in GXDLMSClient.GetObjectTypes2())
            {
                if (it.Key != ObjectType.None && !items.Contains(it.Key))
                {
                    items.Add(it.Key);
                    ObjectTypeCb.Items.Add(it.Key);
                }
            }

            ObjectTypeCb.SelectedItem = target.ObjectType;
            LogicalNameTb.Text = target.LogicalName;
            if (LogicalNameReferencing)
            {
                ShortNameTb.Visible = ShortNameLbl.Visible = false;
            }
            else
            {
                ShortNameTb.Text = target.ShortName.ToString();
            }
            ObjectTypeCb.SelectedIndexChanged += new System.EventHandler(this.ObjectTypeCb_SelectedIndexChanged);

            if (remove)
            {
                ShortNameTb.ReadOnly = true;
                ObjectTypeCb.Enabled = LogicalNameTb.Enabled = ObjectTypeCb.Enabled = false;
                DescriptionTb.Text = target.Description;
                VersionCb.SelectedItem = target.Version;
                LogicalNameTb_Leave(null, null);
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string str = converter.GetDescription(LogicalNameTb.Text, (ObjectType)ObjectTypeCb.SelectedItem)[0];
                if (!ShortNameTb.ReadOnly && str.CompareTo("Invalid") == 0)
                {
                    throw new Exception(Properties.Resources.InvalidObisCode);
                }
                if (ObjectTypeCb.SelectedItem == null)
                {
                    throw new Exception(Properties.Resources.InvalidTarget);
                }
                if (string.IsNullOrEmpty(LogicalNameTb.Text))
                {
                    throw new Exception(Properties.Resources.InvalidObisCode);
                }
                if (Target == null || Target.ObjectType != (ObjectType)ObjectTypeCb.SelectedItem)
                {
                    Target = GXDLMSClient.CreateObject((ObjectType)ObjectTypeCb.SelectedItem);
                }
                Target.Version = (int)VersionCb.SelectedItem;
                Target.LogicalName = LogicalNameTb.Text;
                if (ShortNameTb.Visible)
                {
                    Target.ShortName = UInt16.Parse(ShortNameTb.Text);
                }
                //Update access rights.
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAttributes()
        {
            bindingSource1.Clear();
            List<GXDLMSAttributeSettings> list = new List<GXDLMSAttributeSettings>();
            string[] names = (Target as IGXDLMSBase).GetNames();
            for (int pos = 0; pos != (Target as IGXDLMSBase).GetAttributeCount(); ++pos)
            {
                GXDLMSAttributeSettings a = new GXDLMSAttributeSettings() { Index = pos + 1, Name = names[pos] };
                Target.Attributes.Add(a);
                //Logical name is always read-only.
                if (pos == 0)
                {
                    if (version < 3)
                    {
                        a.Access = AccessMode.Read;
                    }
                    else
                    {
                        a.Access3 = AccessMode3.Read;
                    }
                }
                else
                {
                    if (version < 3)
                    {
                        AccessMode mode = Target.GetAccess(1 + pos);
                        a.Access = mode;
                    }
                    else
                    {
                        AccessMode3 mode = Target.GetAccess3(1 + pos);
                        a.Access3 = mode;
                    }

                }
                list.Add(a);
            }
            foreach (var it in list)
            {
                bindingSource1.Add(it);
            }
            Accessrights.DataSource = bindingSource1;
            //Show method access levels of COSEM object.
            bindingSource3.Clear();
            list.Clear();
            //Add all methods.
            names = (Target as IGXDLMSBase).GetMethodNames();
            for (int pos = 0; pos != (Target as IGXDLMSBase).GetMethodCount(); ++pos)
            {
                GXDLMSAttributeSettings a = new GXDLMSAttributeSettings() { Index = pos + 1, Name = names[pos] };
                Target.MethodAttributes.Add(a);
                if (version < 3)
                {
                    MethodAccessMode mode = Target.GetMethodAccess(1 + pos);
                    a.MethodAccess = mode;
                }
                else
                {
                    MethodAccessMode3 mode = Target.GetMethodAccess3(1 + pos);
                    a.MethodAccess3 = mode;
                }
                list.Add(a);
            }
            foreach (var it in list)
            {
                bindingSource3.Add(it);
            }
            MethodAccessrights.DataSource = bindingSource3;
        }

        /// <summary>
        /// Object type has changed.
        /// </summary>
        private void ObjectTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogicalNameTb.Items.Clear();
            bool first = true;
            foreach (KeyValuePair<string, string> it in converter.GetObisCodesByType((ObjectType)ObjectTypeCb.SelectedItem))
            {
                LogicalNameTb.Items.Add(it.Key);
                if (first)
                {
                    LogicalNameTb.Text = it.Key;
                    DescriptionTb.Text = it.Value;
                    first = false;
                }
            }
            //Restore default columns if old target is association LN.
            if (Target is GXDLMSAssociationLogicalName)
            {
                VersionCb.Enabled = true;
                CreateAccessrightsColumns(version);
            }
            if (Target == null || Target.ObjectType != (ObjectType)ObjectTypeCb.SelectedItem)
            {
                Target = GXDLMSClient.CreateObject((ObjectType)ObjectTypeCb.SelectedItem);
            }
            UpdateAttributes();
            //Update max version number.
            VersionCb.Items.Clear();
            for (int pos = 0; pos != 1 + (Target as IGXDLMSBase).GetMaxSupportedVersion(); ++pos)
            {
                VersionCb.Items.Insert(0, pos);
            }
            if (Target is GXDLMSAssociationLogicalName)
            {
                VersionCb.SelectedItem = version;
                VersionCb.Enabled = false;
            }
            else
            {
                VersionCb.SelectedIndex = 0;
            }

        }

        /// <summary>
        /// OBIS code is changed.
        /// </summary>
        private void LogicalNameTb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LogicalNameTb.SelectedIndex != -1)
            {
                try
                {
                    DescriptionTb.Text = "";
                    string str = converter.GetDescription(LogicalNameTb.Text, (ObjectType)ObjectTypeCb.SelectedItem)[0];
                    if (str.CompareTo("Invalid") == 0)
                    {
                        throw new Exception(Properties.Resources.InvalidObisCode);
                    }
                    DescriptionTb.Text = str;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LogicalNameTb_Leave(object sender, EventArgs e)
        {
            try
            {
                if (LogicalNameTb.Text != "")
                {
                    GXDLMSObject.ValidateLogicalName(LogicalNameTb.Text);
                    if (!LogicalNameTb.Items.Contains(LogicalNameTb.Text))
                    {
                        LogicalNameTb.Items.Insert(0, LogicalNameTb.Text);
                        LogicalNameTb.SelectedIndex = 0;
                    }
                    else
                    {
                        LogicalNameTb.SelectedItem = LogicalNameTb.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MethodAccessrights_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        /// <summary>
        /// Apply access rights to selected objects.
        /// </summary>
        private void AccessRightsApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int access = (int)AccessRightAllCb.SelectedItem;
                int ver = version;
                if (Target is GXDLMSAssociationLogicalName)
                {
                    ver = Target.Version;
                }
                foreach (DataGridViewRow it in Accessrights.SelectedRows)
                {
                    //Logical name can't changed.
                    if (it.Index != 0)
                    {
                        if (ver < 3)
                        {
                            ((GXDLMSAttributeSettings)bindingSource1[it.Index]).Access = (AccessMode)access;
                            ((GXDLMSAttributeSettings)bindingSource1[it.Index]).Access3 = 0;
                            Target.SetAccess(it.Index, (AccessMode)access);
                        }
                        else
                        {
                            ((GXDLMSAttributeSettings)bindingSource1[it.Index]).Access = 0;
                            if (access == 0)
                            {
                                ((GXDLMSAttributeSettings)bindingSource1[it.Index]).Access3 = 0;
                            }
                            else
                            {
                                ((GXDLMSAttributeSettings)bindingSource1[it.Index]).Access3 |= (AccessMode3)access;
                            }
                            Target.SetAccess3(1 + it.Index, (AccessMode3)((GXDLMSAttributeSettings)bindingSource1[it.Index]).Access3);
                        }
                        Accessrights.UpdateCellValue(2, it.Index);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Apply method access rights to selected objects.
        /// </summary>
        private void MethodAccessRightsApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int access = (int)MethodAccessRightAllCb.SelectedItem;
                int ver = version;
                if (Target is GXDLMSAssociationLogicalName)
                {
                    ver = Target.Version;
                }
                foreach (DataGridViewRow it in MethodAccessrights.SelectedRows)
                {
                    if (ver < 3)
                    {
                        ((GXDLMSAttributeSettings)bindingSource3[it.Index]).MethodAccess = (MethodAccessMode)access;
                        ((GXDLMSAttributeSettings)bindingSource3[it.Index]).MethodAccess3 = 0;
                        Target.SetMethodAccess(it.Index, (MethodAccessMode)access);
                    }
                    else
                    {
                        ((GXDLMSAttributeSettings)bindingSource3[it.Index]).MethodAccess = 0;
                        if (access == 0)
                        {
                            ((GXDLMSAttributeSettings)bindingSource3[it.Index]).MethodAccess3 = 0;
                        }
                        else
                        {
                            ((GXDLMSAttributeSettings)bindingSource3[it.Index]).MethodAccess3 |= (MethodAccessMode3)access;
                        }
                        Target.SetMethodAccess3(1 + it.Index, (MethodAccessMode3)((GXDLMSAttributeSettings)bindingSource3[it.Index]).MethodAccess3);
                    }
                    MethodAccessrights.UpdateCellValue(2, it.Index);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VersionCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ver = (int)VersionCb.SelectedItem;
            bool changed = Target.Version != ver;
            Target.Version = ver;
            if (changed)
            {
                if (Target is GXDLMSAssociationLogicalName)
                {
                    CreateAccessrightsColumns(ver);
                }
                UpdateAttributes();
            }
        }
    }
}
