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
using Gurux.DLMS;
using System.Data;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects.Enums;

namespace Gurux.DLMS.UI
{
    [GXDLMSViewAttribute(typeof(Gurux.DLMS.Objects.GXDLMSProfileGeneric))]
    partial class GXDLMSProfileGenericView : Form, IGXDLMSView
    {
        /// <summary>
        /// Are there structures in data. Acaris is using this.
        /// </summary>
        bool structures = false;
        /// <summary>
        /// Target profile genric object.
        /// </summary>
        GXDLMSProfileGeneric target;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSProfileGenericView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        delegate void UpdateTargetEventHandler(GXDLMSObject value);

        private void GetArrayAsString(StringBuilder sb, object value)
        {
            sb.Append("{");
            foreach (object it in (object[])value)
            {
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
                sb.Append(", ");
            }
            sb.Append("}");
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
                        if (r[index] is object[])
                        {
                            StringBuilder sb = new StringBuilder();
                            GetArrayAsString(sb, r[index]);
                            row.Add(sb.ToString());
                        }
                        else
                        {
                            if (r[index] is byte[])
                            {
                                row.Add(Gurux.DLMS.GXDLMSTranslator.ToHex(r[index] as byte[]));
                            }
                            else if (r[index] is object[])
                            {
                                StringBuilder sb = new StringBuilder();
                                GetArrayAsString(sb, r[index]);
                                row.Add(sb.ToString());
                            }
                            else
                            {
                                row.Add(r[index]);
                            }
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
                    dt.LoadDataRow(row, true);
                }
            }
        }

        void OnUpdateTarget(GXDLMSObject value)
        {
            target = (GXDLMSProfileGeneric)value;
            structures = false;
            GXDLMSObject obj;
            int index = 0;
            if (target != null)
            {
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
                        dc.Caption = str;
                        int pos = ProfileGenericView.Columns.Add(index.ToString(), dc.Caption);
                        ProfileGenericView.Columns[pos].DataPropertyName = index.ToString();
                        ++index;
                    }
                }
                UpdateData(dt);
                ProfileGenericView.DataSource = dt;
            }
            else
            {
                ProfileGenericView.DataSource = null;
            }

            //Set initial values...
            ReadFromRB.Enabled = ReadLastRB.Enabled = ReadEntryBtn.Enabled = target.CaptureObjects.Count != 0;
            ReadFromRB.Checked = ReadLastRB.Checked = ReadEntryBtn.Checked = false;
            StartEntry.Value = 0;
            EndEntry.Value = 1;
            ReadLastTB.Value = 0;
            StartPick.Value = ToPick.Value = DateTime.Now;
            if (!ReadFromRB.Enabled)
            {
                return;
            }
            obj = target.CaptureObjects[0].Key;
            //TODO: Hide other than all if meter is not supporting parameterized access.
            /*
            if (m_Target.Parent.)
            {
                ReadEntryBtn.Enabled = ReadFromRB.Enabled = ReadLastRB.Enabled = false;
                m_Target.AccessSelector = AccessRange.All;
            }
            else
            {
                ReadEntryBtn.Enabled = ReadFromRB.Enabled = ReadLastRB.Enabled = true;
            }
            */
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
                    BeginInvoke(new UpdateTargetEventHandler(OnUpdateTarget), value);
                }
                else
                {
                    OnUpdateTarget(value);
                }
            }
        }

        public void OnValueChanged(int index, object value, bool user)
        {
            if (index == 2)
            {
                DataTable dt = ProfileGenericView.DataSource as DataTable;
                if (target.Buffer.Count < dt.Rows.Count)
                {
                    dt.Rows.Clear();
                }
                UpdateData(dt);
                for (int pos = dt.Rows.Count; pos < target.Buffer.Count; ++pos)
                {
                    object[] row = target.Buffer[pos];
                    dt.LoadDataRow(row, true);
                }
                ProfileGenericView.Refresh();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access)
        {
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
                target.From = Convert.ToInt32(StartEntry.Value);
                target.To = Convert.ToInt32(EndEntry.Value);
                if (StartPick.Checked)
                {
                    target.From = StartPick.Value.Date;
                }
                else
                {
                    target.From = DateTime.MinValue;
                }

                if (ToPick.Checked)
                {
                    if (target.CapturePeriod != 0)
                    {
                        target.To = ToPick.Value.Date.AddDays(1).AddSeconds(-target.CapturePeriod);
                    }
                    else
                    {
                        target.To = ToPick.Value.Date.AddDays(1).AddMinutes(-1);
                    }
                }
                else
                {
                    target.To = DateTime.MaxValue;
                }
            }
        }

        private void StartEntry_ValueChanged(object sender, EventArgs e)
        {
            if (ReadEntryBtn.Checked)
            {
                target.From = StartEntry.Value;
                target.To = EndEntry.Value;
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
    }
}
