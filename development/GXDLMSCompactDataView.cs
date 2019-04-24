//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSCompactDataView.cs $
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
using System.Text;
using System.Data;
using System.Collections.Generic;
using Gurux.DLMS.ManufacturerSettings;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSCompactData
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSCompactData))]
    partial class GXDLMSCompactDataView : Form, IGXDLMSView
    {
        delegate void UpdateTargetEventHandler(GXDLMSObject value);
        /// <summary>
        /// Are there structures in data.
        /// </summary>
        bool structures = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSCompactDataView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        /// <summary>
        /// Target compact data object.
        /// </summary>
        GXDLMSCompactData target;


        public GXDLMSObject Target
        {
            get
            {
                return target;
            }
            set
            {
                if (InvokeRequired)
                {
                    Invoke(new UpdateTargetEventHandler(OnUpdateTarget), value);
                }
                else
                {
                    OnUpdateTarget(value);
                }
            }
        }

        void OnUpdateTarget(GXDLMSObject value)
        {
            target = (GXDLMSCompactData)value;
            if (target != null)
            {
                UpdateCaptureObjects();
            }
            else
            {
                ProfileGenericView.DataSource = null;
            }
        }

        private void GetArrayAsString(StringBuilder sb, object value)
        {
            sb.Append("{");
            bool first = true;
            foreach (object it in (object[])value)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    sb.Append(", ");
                }
                if (it is byte[])
                {
                    sb.Append(Gurux.DLMS.GXDLMSTranslator.ToHex(it as byte[]));
                }
                else if (it is object[])
                {
                    GetArrayAsString(sb, it);
                }
                else
                {
                    sb.Append(Convert.ToString(it));
                }
            }
            sb.Append("}");
        }

        object GetValue(object value)
        {
            if (value is byte[])
            {
                return GXDLMSTranslator.ToHex(value as byte[]);
            }
            else if (value is object[])
            {
                StringBuilder sb = new StringBuilder();
                GetArrayAsString(sb, value);
                return sb.ToString();
            }
            return value;
        }

        void UpdateData(DataTable dt)
        {
            object[] rows = GXDLMSCompactData.GetData(target.TemplateDescription, target.Buffer);
            if (structures)
            {
                List<object[]> data = new List<object[]>();
                foreach (object[] r in rows)
                {
                    List<object> row = new List<object>();
                    int index = 0;
                    foreach (var it in target.CaptureObjects)
                    {
                        //If COSEM object is selected.
                        //Only few meters are supporting this.
                        if (it.Value.AttributeIndex == 0 && r[index] is object[])
                        {
                            //Values must be update to the list because there might be Register Scaler
                            //and it expects that scaler is read before value is updated.
                            GXDLMSObject obj = GXDLMSClient.CreateObject(it.Key.ObjectType);
                            byte i2 = 1;
                            Dictionary<byte, object> list = new Dictionary<byte, object>();
                            foreach (object v in (r[index] as object[]))
                            {
                                list.Add(i2, v);
                                ++i2;
                            }
                            //Update values first.
                            for (byte i = 0; i != (obj as IGXDLMSBase).GetAttributeCount(); ++i)
                            {
                                ValueEventArgs ve = new ValueEventArgs(obj, i, 0, null);
                                ve.Value = list[i];
                                (obj as IGXDLMSBase).SetValue(null, ve);
                            }
                            //Show values.
                            for (byte i = 0; i != (obj as IGXDLMSBase).GetAttributeCount(); ++i)
                            {
                                row.Add(GetValue(obj.GetValues()[i]));
                            }
                        }
                        else
                        {
                            row.Add(GetValue(r[index]));
                        }
                        ++index;
                    }
                    data.Add(row.ToArray());
                }
                for (int pos = dt.Rows.Count; pos < data.Count; ++pos)
                {
                    object[] row = data[pos];
                    dt.LoadDataRow(row, true);
                }
            }
            else
            {
                for (int pos = dt.Rows.Count; pos < rows.Length; ++pos)
                {
                    object[] row = (object[])rows[pos];
                    if (row != null)
                    {
                        for (int col = 0; col != row.Length; ++col)
                        {
                            if (row[col] is byte[])
                            {
                                if (pos < target.CaptureObjects.Count && target.CaptureObjects[col].Key.GetUIDataType(target.CaptureObjects[col].Value.AttributeIndex) == DataType.DateTime)
                                {
                                    row[col] = GXDLMSClient.ChangeType(row[col] as byte[], DataType.DateTime);
                                }
                                else
                                {
                                    row[col] = GXDLMSTranslator.ToHex((byte[])row[col], true);
                                }
                            }
                            else if (row[col] is Object[])
                            {
                                row[col] = GXDLMSTranslator.ValueToXml(row[col]);
                            }
                            else if (row[col] is List<Object>)
                            {
                                row[col] = GXDLMSTranslator.ValueToXml(row[col]);
                            }
                            else if (col < target.CaptureObjects.Count)
                            {
                                GXDLMSAttributeSettings att = target.CaptureObjects[col].Key.Attributes.Find(target.CaptureObjects[col].Value.AttributeIndex);
                                if (att != null && att.Values != null)
                                {
                                    if (att.Type == DataType.BitString && row[col] is string)
                                    {
                                        string str = (string)row[col];
                                        if (str.Length != 0 && (str[0] == '0' || str[0] == '1'))
                                        {
                                            StringBuilder sb = new StringBuilder();
                                            int pos2 = 0;
                                            foreach (char it in str)
                                            {
                                                if (it == '1')
                                                {
                                                    if (sb.Length != 0)
                                                    {
                                                        sb.Append(',');
                                                    }
                                                    sb.Append(att.Values[pos2].UIValue);
                                                }
                                                ++pos2;
                                                if (pos2 == att.Values.Count)
                                                {
                                                    break;
                                                }
                                            }
                                            row[col] = sb.ToString();
                                        }
                                    }
                                    else
                                    {
                                        foreach (GXObisValueItem it in att.Values)
                                        {
                                            if (IsNumber(row[col]) && it.Value == Convert.ToInt32(row[col]))
                                            {
                                                row[col] = it.UIValue;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (dt.Columns.Count != 0)
                        {
                            dt.LoadDataRow(row, true);
                        }
                    }
                }
            }
        }

        public static bool IsNumber(object value)
        {
            return value is sbyte
                    || value is byte
                    || value is short
                    || value is ushort
                    || value is int
                    || value is uint
                    || value is long
                    || value is ulong
                    || value is float
                    || value is double
                    || value is decimal;
        }

        private void UpdateCaptureObjects()
        {
            int index = 0;
            DataTable table = ProfileGenericView.DataSource as DataTable;
            ProfileGenericView.DataSource = null;
            ProfileGenericView.Columns.Clear();
            DataTable dt = new DataTable();
            foreach (var it in target.CaptureObjects)
            {
                string[] columns = ((IGXDLMSBase)it.Key).GetNames();
                if (it.Value.AttributeIndex == 0)
                {
                    structures = true;
                    for (int a = 0; a != ((IGXDLMSBase)it.Key).GetAttributeCount(); ++a)
                    {
                        DataColumn dc = dt.Columns.Add(index.ToString());
                        dc.Caption = it.Key.LogicalName + Environment.NewLine + columns[a];
                        int pos = ProfileGenericView.Columns.Add(index.ToString(), dc.Caption);
                        ProfileGenericView.Columns[pos].DataPropertyName = index.ToString();
                        ++index;
                    }
                }
                else
                {
                    DataColumn dc = dt.Columns.Add(index.ToString());
                    string str = it.Key.LogicalName;
                    if (it.Value.AttributeIndex < columns.Length)
                    {
                        str += Environment.NewLine + columns[it.Value.AttributeIndex - 1];
                    }
                    if (!string.IsNullOrEmpty(it.Key.Description))
                    {
                        str += Environment.NewLine + it.Key.Description;
                    }
                    //In Indian standard register scalers are saved to table.
                    if (it.Key is GXDLMSRegister && it.Value.AttributeIndex == 3)
                    {
                        structures = true;
                    }
                    dc.Caption = str;
                    int pos = ProfileGenericView.Columns.Add(index.ToString(), dc.Caption);
                    ProfileGenericView.Columns[pos].DataPropertyName = index.ToString();
                    ++index;
                }
            }
            UpdateData(dt);
            ProfileGenericView.DataSource = dt;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSCompactData target = Target as GXDLMSCompactData;
            if (index == 2)
            {
                if (!user)
                {
                    UpdateCaptureObjects();
                }
                BufferTb.Text = GXDLMSTranslator.ToHex(target.Buffer);
                DataTable dt = ProfileGenericView.DataSource as DataTable;
                if (dt != null)
                {
                    dt.Rows.Clear();
                    UpdateData(dt);
                }
                ProfileGenericView.Refresh();
            }
            else if (index == 3)
            {
                CaptureObjectsLv.Items.Clear();
                foreach (var it in target.CaptureObjects)
                {
                    ListViewItem li = CaptureObjectsLv.Items.Add(it.Key.ObjectType.ToString());
                    li.SubItems.Add(it.Key.LogicalName);
                    li.SubItems.Add(it.Value.AttributeIndex.ToString());
                    li.Tag = it;
                }
            }
            else if (index == 5)
            {
                object[] types = GXDLMSCompactData.GetDataTypes(target.TemplateDescription);
                StringBuilder sb = new StringBuilder();
                AppendDataType(sb, types);
                TemplateDescriptionTb.Text = sb.ToString();
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        private static bool AppendDataType(StringBuilder sb, IEnumerable<object> types)
        {
            bool empty = true;
            foreach (object it in types)
            {
                empty = false;
                if (it is DataType)
                {
                    sb.Append(it.ToString());
                    sb.Append(", ");
                }
                else
                {
                    sb.Append("[");
                    if (!AppendDataType(sb, (IEnumerable<object>)it))
                    {
                        sb.Length -= 2;
                    }
                    sb.Append("], ");
                }
            }
            if (!empty)
            {
                sb.Length -= 2;
            }
            return !empty;
        }

        public void PreAction(GXActionArgs arg)
        {
            arg.Value = (sbyte)0;
            DialogResult ret;
            if (arg.Index == 1)
            {
                //Reset.
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.ProfileGenericResetWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
            }
            else if (arg.Index == 2)
            {
                //Capture.
                ret = GXHelpers.ShowMessageBox(this, Properties.Resources.ProfileGenericCaptureWarning, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                arg.Handled = ret != DialogResult.Yes;
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
            if (Dirty)
            {
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 2)
            {
                BufferTb.ReadOnly = !enabled;
            }
            else if (index == 3)
            {
                addToolStripMenuItem.Enabled = editToolStripMenuItem.Enabled = removeToolStripMenuItem.Enabled =
                    ColumnAddBtn.Enabled = ColumnEditBtn.Enabled = ColumnRemoveBtn.Enabled = enabled;
            }
            else if (index == 5)
            {
                TemplateDescriptionTb.ReadOnly = !enabled;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
            throw new IndexOutOfRangeException("index");
        }
        #endregion

        /// <summary>
        /// Add new capture object.
        /// </summary>
        private void ColumnAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSCompactData target = Target as GXDLMSCompactData;
                GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> it = new GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject>();
                GXDLMSProfileGenericColumnDlg dlg = new GXDLMSProfileGenericColumnDlg(it, target.Parent as GXDLMSObjectCollection, "Compact data capture object");
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    it = dlg.GetTarget();
                    ListViewItem li = CaptureObjectsLv.Items.Add(it.Key.ObjectType.ToString());
                    li.SubItems.Add(it.Key.LogicalName);
                    li.SubItems.Add(it.Value.AttributeIndex.ToString());
                    li.Tag = it;
                    target.CaptureObjects.Add(it);
                }
                errorProvider1.SetError(CaptureObjectsLv, Properties.Resources.ValueChangedTxt);
                Target.UpdateDirty(3, target.CaptureObjects);
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit capture object.
        /// </summary>
        private void ColumnEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CaptureObjectsLv.SelectedItems.Count == 1)
                {
                    GXDLMSCompactData target = Target as GXDLMSCompactData;
                    ListViewItem li = CaptureObjectsLv.SelectedItems[0];
                    GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> it = (GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject>)li.Tag;
                    GXDLMSProfileGenericColumnDlg dlg = new GXDLMSProfileGenericColumnDlg(it, target.Parent as GXDLMSObjectCollection, "Compact data capture object");
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        //If user has change target object.
                        if (it.Key != dlg.GetTarget().Key)
                        {
                            target.CaptureObjects.Remove(it);
                            it = dlg.GetTarget();
                            target.CaptureObjects.Add(it);
                        }
                        else
                        {
                            it = dlg.GetTarget();
                        }
                        li.SubItems[0].Text = it.Key.ObjectType.ToString();
                        li.SubItems[1].Text = it.Key.LogicalName;
                        li.SubItems[2].Text = it.Value.AttributeIndex.ToString();
                        errorProvider1.SetError(CaptureObjectsLv, Properties.Resources.ValueChangedTxt);
                        li.Tag = it;
                        Target.UpdateDirty(3, target.CaptureObjects);
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
        /// Remove capture object.
        /// </summary>
        private void ColumnRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> item;
                GXDLMSCompactData target = Target as GXDLMSCompactData;
                while (CaptureObjectsLv.SelectedItems.Count != 0)
                {
                    ListViewItem li = CaptureObjectsLv.SelectedItems[0];
                    item = (GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject>)li.Tag;
                    CaptureObjectsLv.Items.Remove(CaptureObjectsLv.SelectedItems[0]);
                    errorProvider1.SetError(CaptureObjectsLv, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(3, target.CaptureObjects);
                    target.CaptureObjects.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BufferTb_Leave(object sender, EventArgs e)
        {
            try
            {
                GXDLMSCompactData target = Target as GXDLMSCompactData;
                byte[] tmp = GXDLMSTranslator.HexToBytes(BufferTb.Text);
                if (GXDLMSTranslator.ToHex(tmp) != GXDLMSTranslator.ToHex(target.Buffer))
                {
                    target.Buffer = tmp;
                    Target.UpdateDirty(2, target.Buffer);
                    errorProvider1.SetError(BufferTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TemplateDescriptionTb_Leave(object sender, EventArgs e)
        {
            try
            {
                DataType v;
                GXByteBuffer bb = new GXByteBuffer();
                GXDLMSCompactData target = Target as GXDLMSCompactData;
                bb.SetUInt8(2);
                bb.SetUInt8(0);
                foreach (string it in TemplateDescriptionTb.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    if (!Enum.TryParse<DataType>(it, out v))
                    {
                        bb.Clear();
                        break;
                    }
                    bb.SetUInt8((byte)v);
                }
                byte[] tmp;
                if (bb.Size != 0)
                {
                    bb.SetUInt8(1, (byte)(bb.Size - 2));
                    tmp = bb.Array();
                }
                else
                {
                    tmp = GXDLMSTranslator.HexToBytes(TemplateDescriptionTb.Text);
                }
                if (GXDLMSTranslator.ToHex(tmp) != GXDLMSTranslator.ToHex(target.TemplateDescription))
                {
                    target.TemplateDescription = tmp;
                    Target.UpdateDirty(5, target.TemplateDescription);
                    errorProvider1.SetError(TemplateDescriptionTb, Properties.Resources.ValueChangedTxt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
