//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSProfileGenericView.cs $
//
// Version:         $Revision: 8948 $,
//                  $Date: 2016-11-24 22:10:05 +0200 (to, 24 marras 2016) $
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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects.Enums;
using System.Globalization;
using Gurux.DLMS.ManufacturerSettings;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSProfileGeneric
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSProfileGeneric))]
    partial class GXDLMSProfileGenericView : Form, IGXDLMSView
    {
        /// <summary>
        /// Are there structures in data.
        /// </summary>
        bool structures = false;
        /// <summary>
        /// Target profile generic object.
        /// </summary>
        GXDLMSProfileGeneric target;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSProfileGenericView()
        {
            InitializeComponent();
            ToPick.Format = StartPick.Format = DateTimePickerFormat.Custom;
            ToPick.CustomFormat = StartPick.CustomFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern + " " +
                CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;
        }

        #region IGXDLMSView Members

        delegate void UpdateTargetEventHandler(GXDLMSObject value);

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
            if (structures)
            {
                List<object[]> data = new List<object[]>();
                foreach (object[] r in target.Buffer)
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
                            foreach (byte i in (obj as IGXDLMSBase).GetAttributeIndexToRead(true))
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
                for (int pos = dt.Rows.Count; pos < target.Buffer.Count; ++pos)
                {
                    object[] row = target.Buffer[pos];
                    if (row != null)
                    {
                        for (int col = 0; col != row.Length; ++col)
                        {
                            if (row[col] is byte[])
                            {
                                row[col] = GXDLMSTranslator.ToHex((byte[])row[col], true);
                            }
                            else if (row[col] is Object[])
                            {
                                row[col] = GXDLMSTranslator.ValueToXml(row[col]);
                            }
                            else
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
                        dt.LoadDataRow(row, true);
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

        void OnUpdateTarget(GXDLMSObject value)
        {
            target = (GXDLMSProfileGeneric)value;
            structures = false;
            GXDLMSObject obj;
            if (target != null)
            {
                UpdateCaptureObjects();
            }
            else
            {
                ProfileGenericView.DataSource = null;
            }
            //Set initial values...
            ReadFromRB.Enabled = ReadLastRB.Enabled = ReadEntryBtn.Enabled = target.CaptureObjects.Count != 0;
            ReadFromRB.Checked = ReadLastRB.Checked = ReadEntryBtn.Checked = false;
            StartEntry.Value = Properties.Settings.Default.ProfileGenericIndex;
            EndEntry.Value = Properties.Settings.Default.ProfileGenericCount;
            ReadLastTB.Value = 0;
            DateTime tm;
            if (DateTime.TryParse(Properties.Settings.Default.ProfileGenericStartTime, out tm))
            {
                if (tm != DateTime.MinValue)
                {
                    try
                    {
                        StartPick.Checked = true;
                        StartPick.Value = tm;
                    }
                    catch (Exception)
                    {
                        //It's ok if this fails.
                        StartPick.Checked = false;
                    }
                }
                else
                {
                    StartPick.Checked = false;
                }
            }
            else
            {
                StartPick.Value = DateTime.Now;
            }
            if (DateTime.TryParse(Properties.Settings.Default.ProfileGenericEndTime, out tm))
            {
                if (tm != DateTime.MaxValue)
                {
                    try
                    {
                        ToPick.Checked = true;
                        ToPick.Value = tm;
                    }
                    catch (Exception)
                    {
                        //It's ok if this fails.
                        ToPick.Checked = false;
                    }
                }
                else
                {
                    ToPick.Checked = false;
                }
            }
            else
            {
                ToPick.Value = DateTime.Now;
            }
            if (!ReadFromRB.Enabled)
            {
                return;
            }
            obj = target.CaptureObjects[0].Key;
            if (target.AccessSelector == AccessRange.Entry)
            {
                StartEntry.Value = Convert.ToInt32(target.From);
                EndEntry.Value = Convert.ToInt32(target.To);
                ReadEntryBtn.Checked = true;
            }
            else if (target.AccessSelector == AccessRange.Last)
            {
                TimeSpan diff = (DateTime)target.To - (DateTime)target.From;
                ReadLastTB.Value = diff.Days - 1;
                ReadLastRB.Checked = true;
            }
            else if (target.AccessSelector == AccessRange.Range)
            {
                if ((DateTime)target.From == DateTime.MinValue)
                {
                    StartPick.Checked = false;
                }
                else
                {
                    StartPick.Value = (DateTime)target.From;
                }
                if ((DateTime)target.To == DateTime.MaxValue)
                {
                    ToPick.Checked = false;
                }
                else
                {
                    ToPick.Value = (DateTime)target.To;
                }
                ReadFromRB.Checked = true;
            }
            else //All is checked.
            {
                ReadAllRB.Checked = true;
            }
        }

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

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            if (index == 2)
            {
                if (!user)
                {
                    UpdateCaptureObjects();
                }
                DataTable dt = ProfileGenericView.DataSource as DataTable;
                if (dt != null)
                {
                    dt.Rows.Clear();
                    UpdateData(dt);
                }
                ProfileGenericView.Refresh();
            }
            if (index == 3)
            {
                GXDLMSProfileGeneric target = Target as GXDLMSProfileGeneric;
                CaptureObjectsLv.Items.Clear();
                foreach (var it in target.CaptureObjects)
                {
                    ListViewItem li = CaptureObjectsLv.Items.Add(it.Key.ObjectType.ToString());
                    li.SubItems.Add(it.Key.LogicalName);
                    li.SubItems.Add(it.Value.AttributeIndex.ToString());
                    li.Tag = it;
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enabled = connected && (access & AccessMode.Write) != 0;
            if (index == 3)
            {
                addToolStripMenuItem.Enabled = editToolStripMenuItem.Enabled = removeToolStripMenuItem.Enabled =
                    ColumnAddBtn.Enabled = ColumnEditBtn.Enabled = ColumnRemoveBtn.Enabled = enabled;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
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
            GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        void UpdateView()
        {
            ReadLastTB.ReadOnly = !ReadLastRB.Checked;
            StartPick.Enabled = ToPick.Enabled = ReadFromRB.Checked;
            StartEntry.ReadOnly = EndEntry.ReadOnly = !ReadEntryBtn.Checked;
            if (ReadEntryBtn.Checked)
            {
                target.AccessSelector = AccessRange.Entry;
                StartEntry_ValueChanged(null, null);
            }
            else if (ReadLastRB.Checked)
            {
                target.AccessSelector = AccessRange.Last;
                ReadLastTB_ValueChanged(null, null);
            }
            else if (ReadFromRB.Checked)
            {
                target.AccessSelector = AccessRange.Range;
                StartPick_ValueChanged(null, null);
            }
            else if (ReadAllRB.Checked)
            {
                target.AccessSelector = AccessRange.All;
            }
        }

        private void ReadEntryRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadEntryBtn.Checked)
            {
                ReadLastRB.Checked = ReadAllRB.Checked = ReadFromRB.Checked = false;
                UpdateView();
            }
        }

        private void ReadLastRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadLastRB.Checked)
            {
                ReadEntryBtn.Checked = ReadAllRB.Checked = ReadFromRB.Checked = false;
                UpdateView();
            }
        }
        private void ReadAllRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadAllRB.Checked)
            {
                ReadEntryBtn.Checked = ReadLastRB.Checked = ReadFromRB.Checked = false;
                UpdateView();
            }
        }


        private void ReadFromRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadFromRB.Checked)
            {
                ReadEntryBtn.Checked = ReadLastRB.Checked = ReadAllRB.Checked = false;
                UpdateView();
            }
        }

        private void StartPick_ValueChanged(object sender, EventArgs e)
        {
            if (ReadFromRB.Checked)
            {
                if (StartPick.Checked)
                {
                    target.From = StartPick.Value;
                }
                else
                {
                    target.From = DateTime.MinValue;
                }
                Properties.Settings.Default.ProfileGenericStartTime = target.From.ToString();

                if (ToPick.Checked)
                {
                    target.To = ToPick.Value;
                }
                else
                {
                    target.To = DateTime.MaxValue;
                }
                Properties.Settings.Default.ProfileGenericEndTime = target.To.ToString();
            }
        }

        private void StartEntry_ValueChanged(object sender, EventArgs e)
        {
            if (ReadEntryBtn.Checked)
            {
                target.From = StartEntry.Value;
                target.To = EndEntry.Value;
                Properties.Settings.Default.ProfileGenericIndex = Convert.ToInt32(StartEntry.Value);
                Properties.Settings.Default.ProfileGenericCount = Convert.ToInt32(EndEntry.Value);
            }
        }

        private void ReadLastTB_ValueChanged(object sender, EventArgs e)
        {
            if (ReadLastRB.Checked)
            {
                target.From = DateTime.Now.Date.AddDays(-Convert.ToInt32(ReadLastTB.Value)).Date;
                target.To = DateTime.Now.AddDays(1).Date;
            }
        }

        /// <summary>
        /// Add new capture object.
        /// </summary>
        private void ColumnAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSProfileGeneric target = Target as GXDLMSProfileGeneric;
                GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> it = new GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject>();
                GXDLMSProfileGenericColumnDlg dlg = new GXDLMSProfileGenericColumnDlg(it, target.Parent as GXDLMSObjectCollection);
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
                    GXDLMSProfileGeneric target = Target as GXDLMSProfileGeneric;
                    ListViewItem li = CaptureObjectsLv.SelectedItems[0];
                    GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> it = (GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject>)li.Tag;
                    GXDLMSProfileGenericColumnDlg dlg = new GXDLMSProfileGenericColumnDlg(it, target.Parent as GXDLMSObjectCollection);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        //If user has change target object.
                        if (it.Key != dlg.GetTarget().Key)
                        {
                            int pos = target.CaptureObjects.IndexOf(it);
                            target.CaptureObjects.RemoveAt(pos);
                            it = dlg.GetTarget();
                            target.CaptureObjects.Insert(pos, it);
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
                GXDLMSProfileGeneric target = Target as GXDLMSProfileGeneric;
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
    }
}
