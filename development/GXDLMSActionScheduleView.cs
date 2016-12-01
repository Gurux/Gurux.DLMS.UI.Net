//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/Views/GXDLMSActionScheduleView.cs $
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
    [GXDLMSViewAttribute(typeof(GXDLMSActionSchedule))]
    partial class GXDLMSActionScheduleView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSActionScheduleView()
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
            GXDLMSActionSchedule schedule = Target as GXDLMSActionSchedule;
            if (index == 2)
            {
                if (schedule.Target != null)
                {
                    ScriptNameTB.Text = schedule.Target.LogicalName;
                }
                else
                {
                    ScriptNameTB.Text = schedule.ExecutedScriptLogicalName;
                }

                ScriptSelectorTB.Text = schedule.ExecutedScriptSelector.ToString();
            }
            else if (index == 3)
            {
                ScriptTypeTB.Text = schedule.Type.ToString();
            }
            else if (index == 4)
            {
                CallingWindowLV.Items.Clear();
                if (schedule.ExecutionTime != null)
                {
                    foreach (GXDateTime it in schedule.ExecutionTime)
                    {
                        ListViewItem li = CallingWindowLV.Items.Add(it.ToString());
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
