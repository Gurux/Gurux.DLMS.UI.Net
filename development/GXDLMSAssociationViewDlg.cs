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
// More information of Gurux products: http://www.gurux.org
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Objects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSAssociationViewDlg : Form
    {
        GXDLMSObject Target;
        GXDLMSConverter converter = new GXDLMSConverter();
        public GXDLMSObject GetTarget()
        {
            return Target;
        }

        public GXDLMSAssociationViewDlg(GXDLMSObject target, bool LogicalNameReferencing)
        {
            Target = target;
            InitializeComponent();
            foreach (ObjectType it in GXDLMSClient.GetObjectTypes2())
            {
                if (it != ObjectType.None)
                {
                    ObjectTypeCb.Items.Add(it);
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
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string str = converter.GetDescription(LogicalNameTb.Text, (ObjectType)ObjectTypeCb.SelectedItem)[0];
                if (str.CompareTo("Invalid") == 0)
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
                Target.LogicalName = LogicalNameTb.Text;
                if (ShortNameTb.Visible)
                {
                    Target.ShortName = UInt16.Parse(ShortNameTb.Text);
                }
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Verify given COSEM object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifyBtn_Click(object sender, EventArgs e)
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

        /// <summary>
        /// Update OBIS code.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        }

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
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
