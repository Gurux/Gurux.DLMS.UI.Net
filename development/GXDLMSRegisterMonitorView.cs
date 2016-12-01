//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSRegisterMonitorView.cs $
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
    [GXDLMSViewAttribute(typeof(GXDLMSRegisterMonitor))]
    partial class GXDLMSRegisterMonitorView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSRegisterMonitorView()
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
            GXDLMSRegisterMonitor target = Target as GXDLMSRegisterMonitor;
            if (index == 2)
            {
                ThresholdsTB.Text = "";
                if (target.Thresholds != null)
                {
                    foreach (object it in target.Thresholds)
                    {
                        ThresholdsTB.Text += it.ToString() + Environment.NewLine;
                    }
                }
            }
            else if (index == 3)
            {
                if (target.MonitoredValue != null)
                {
                    ObjectType type = target.MonitoredValue.ObjectType;
                    ClassIDTB.Text = type.ToString();
                    string ln = target.MonitoredValue.LogicalName;
                    GXDLMSObject item = Target.Parent.FindByLN(type, ln);
                    if (item != null)
                    {
                        ln = item.Description + " " + ln;
                    }
                    MLogicalNameTB.Text = ln;
                    AttributeIndexTB.Text = target.MonitoredValue.AttributeIndex.ToString();
                }
            }
            else if (index == 4)
            {
                ActionsLV.Items.Clear();
                if (target.Actions != null)
                {
                    foreach (GXDLMSActionSet it in target.Actions)
                    {
                        ListViewItem li = ActionsLV.Items.Add(it.ActionUp.LogicalName);
                        li.SubItems.AddRange(new string[] { it.ActionUp.ScriptSelector.ToString(),
                                                        it.ActionDown.LogicalName, it.ActionDown.ScriptSelector.ToString()
                                                      });
                    }
                }
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
                return DescriptionTB.Text;
            }
            set
            {
                DescriptionTB.Text = value;
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {

        }

        #endregion



    }
}
