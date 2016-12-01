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


        GXDLMSProfileGeneric m_Target;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSProfileGenericView()
        {
            InitializeComponent();
            this.ReadFromRB.CheckedChanged += new System.EventHandler(this.ReadFromRB_CheckedChanged);
            this.ReadLastRB.CheckedChanged += new System.EventHandler(this.ReadLastRB_CheckedChanged);
            this.ReadEntryBtn.CheckedChanged += new System.EventHandler(this.ReadEntryRB_CheckedChanged);
            this.ReadAllRB.CheckedChanged += new System.EventHandler(this.ReadAllRB_CheckedChanged);
        }

        #region IGXDLMSView Members

        delegate void UpdateTargetEventHandler(GXDLMSObject value);

        void OnUpdateTarget(GXDLMSObject value)
        {
            m_Target = (GXDLMSProfileGeneric)value;
            GXDLMSObject obj;
            int index = 0;
            if (m_Target != null)
            {
                DataTable table = ProfileGenericView.DataSource as DataTable;
                ProfileGenericView.DataSource = null;
                ProfileGenericView.Columns.Clear();
                DataTable dt = new DataTable();
                foreach (var it in m_Target.CaptureObjects)
                {
                    DataColumn dc = dt.Columns.Add(index.ToString());
                    dc.Caption = it.Key.Description;
                    int pos = ProfileGenericView.Columns.Add(index.ToString(), it.Key.Description);
                    ProfileGenericView.Columns[pos].DataPropertyName = index.ToString();
                    ++index;
                }
                foreach (object[] it in m_Target.Buffer)
                {
                    dt.LoadDataRow(it, true);
                }

                ProfileGenericView.DataSource = dt;
            }
            else
            {
                ProfileGenericView.DataSource = null;
            }

            //Set initial values...
            ReadFromRB.Enabled = ReadLastRB.Enabled = ReadEntryBtn.Enabled = m_Target.CaptureObjects.Count != 0;
            ReadFromRB.Checked = ReadLastRB.Checked = ReadEntryBtn.Checked = false;
            StartEntry.Value = 0;
            EndEntry.Value = 1;
            ReadLastTB.Value = 0;
            StartPick.Value = ToPick.Value = DateTime.Now;
            if (!ReadFromRB.Enabled)
            {
                return;
            }
            index = m_Target.CaptureObjects[0].Value.AttributeIndex;
            obj = m_Target.CaptureObjects[0].Key;
            if (index != 0 &&
                    obj.GetUIDataType(index) != DataType.DateTime)
            {
                ReadFromRB.Enabled = ReadLastRB.Enabled = false;
                m_Target.AccessSelector = AccessRange.Entry;
                m_Target.From = 0;
                m_Target.To = 1;
            }
            else
            {
                ReadFromRB.Enabled = ReadLastRB.Enabled = true;
            }
            if (m_Target.AccessSelector == AccessRange.Entry)
            {
                StartEntry.Value = Convert.ToInt32(m_Target.From);
                EndEntry.Value = Convert.ToInt32(m_Target.To);
                ReadEntryBtn.Checked = true;
            }
            else if (m_Target.AccessSelector == AccessRange.Last)
            {
                TimeSpan diff = (DateTime)m_Target.To - (DateTime)m_Target.From;
                ReadLastTB.Value = diff.Days - 1;
                ReadLastRB.Checked = true;
            }
            else if (m_Target.AccessSelector == AccessRange.Range)
            {
                if ((DateTime)m_Target.From == DateTime.MinValue)
                {
                    StartPick.Checked = false;
                }
                else
                {
                    StartPick.Value = (DateTime)m_Target.From;
                }
                if ((DateTime)m_Target.To == DateTime.MaxValue)
                {
                    ToPick.Checked = false;
                }
                else
                {
                    ToPick.Value = (DateTime)m_Target.To;
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
                return m_Target;
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
                if (m_Target.Buffer.Count < dt.Rows.Count)
                {
                    dt.Rows.Clear();
                }
                for (int pos = dt.Rows.Count; pos < m_Target.Buffer.Count; ++pos)
                {
                    object[] row = m_Target.Buffer[pos];
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
                m_Target.AccessSelector = AccessRange.Entry;
                StartEntry_ValueChanged(null, null);
            }
            else if (ReadLastRB.Checked)
            {
                m_Target.AccessSelector = AccessRange.Last;
                ReadLastTB_ValueChanged(null, null);
            }
            else if (ReadFromRB.Checked)
            {
                m_Target.AccessSelector = AccessRange.Range;
                StartPick_ValueChanged(null, null);
            }
            else if (ReadAllRB.Checked)
            {
                m_Target.AccessSelector = AccessRange.All;
            }
        }

        private void ReadEntryRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadEntryBtn.Checked)
            {
                UpdateView();
            }
        }

        private void ReadLastRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadLastRB.Checked)
            {
                UpdateView();
            }
        }
        private void ReadAllRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadAllRB.Checked)
            {
                UpdateView();
            }
        }


        private void ReadFromRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ReadFromRB.Checked)
            {
                UpdateView();
            }
        }

        private void StartPick_ValueChanged(object sender, EventArgs e)
        {
            if (ReadFromRB.Checked)
            {
                m_Target.From = Convert.ToInt32(StartEntry.Value);
                m_Target.To = Convert.ToInt32(EndEntry.Value);
                if (StartPick.Checked)
                {
                    m_Target.From = StartPick.Value.Date;
                }
                else
                {
                    m_Target.From = DateTime.MinValue;
                }

                if (ToPick.Checked)
                {
                    if (m_Target.CapturePeriod != 0)
                    {
                        m_Target.To = ToPick.Value.Date.AddDays(1).AddSeconds(-m_Target.CapturePeriod);
                    }
                    else
                    {
                        m_Target.To = ToPick.Value.Date.AddDays(1).AddMinutes(-1);
                    }
                }
                else
                {
                    m_Target.To = DateTime.MaxValue;
                }
            }
        }

        private void StartEntry_ValueChanged(object sender, EventArgs e)
        {
            if (ReadEntryBtn.Checked)
            {
                m_Target.From = StartEntry.Value;
                m_Target.To = EndEntry.Value;
            }
        }

        private void ReadLastTB_ValueChanged(object sender, EventArgs e)
        {
            if (ReadLastRB.Checked)
            {
                m_Target.From = DateTime.Now.Date.AddDays(-Convert.ToInt32(ReadLastTB.Value)).Date;
                m_Target.To = DateTime.Now.AddDays(1).Date;
            }
        }
    }
}
