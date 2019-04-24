//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL:$
//
// Version:         $Revision: $,
//                  $Date:  $
//                  $Author: $
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSAutoAnswer
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSGSMDiagnostic))]
    public partial class GXDLMSGSMDiagnosticView : Form, IGXDLMSView
    {
        public GXDLMSGSMDiagnosticView()
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
            GXDLMSGSMDiagnostic target = Target as GXDLMSGSMDiagnostic;
            if (index == 6)
            {
                CellIDTb.Text = target.CellInfo.CellId.ToString(target.Version == 0 ? "X4" : "X8");
                LocationIDTb.Text = target.CellInfo.LocationId.ToString("X4");
                SignalQualityTb.Text = target.CellInfo.SignalQuality.ToString();
                BerTb.Text = target.CellInfo.Ber.ToString();
            }
            else if (index == 7)
            {
                AdjacentCellsLV.Items.Clear();
                if (target.AdjacentCells != null)
                {
                    foreach (var it in target.AdjacentCells)
                    {
                        ListViewItem li = AdjacentCellsLV.Items.Add(it.CellId.ToString(target.Version == 0 ? "X4" : "X8"));
                        li.SubItems.Add(it.SignalQuality.ToString());
                        li.Tag = it;
                    }
                }
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            bool enable = connected && (access & AccessMode.Write) != 0;
            if (index == 6)
            {
                CellIDTb.ReadOnly = LocationIDTb.ReadOnly = SignalQualityTb.ReadOnly = BerTb.ReadOnly = !enable;
            }
            else if (index == 7)
            {
                AdjacentCellsLV.Enabled = enable;
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }

        public void PreAction(GXActionArgs arg)
        {
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
    }
}
