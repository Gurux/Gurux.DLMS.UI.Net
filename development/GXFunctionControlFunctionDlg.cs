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
using Gurux.DLMS.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXFunctionControlFunctionDlg : Form
    {
        private GXDLMSFunctionControl Target;
        public string TargetName;
        public List<GXDLMSObject> TargetObjects = new List<GXDLMSObject>();
        public bool TargetEnabled;

        public GXFunctionControlFunctionDlg(GXDLMSFunctionControl target,
            string name,
            int index)
        {
            InitializeComponent();
            Target = target;
            NameTb.Text = name;
            if (index == 2)
            {
                Text = "Add Function";
                //Add function.
                NameTb.ReadOnly = false;
                foreach (GXDLMSObject it in target.Parent)
                {
                    TargetTb.Items.Add(it);
                }
            }
            else
            {
                if (index == 1)
                {
                    // Function status.
                    Text = "Update function status";
                    EnabledLbl.Enabled = true;
                    EnabledCB.Enabled = true;
                    EnabledCB.Checked = target.ActivationStatus.Where(w => w.Key == name).SingleOrDefault().Value;
                }
                else if (index == 3)
                {
                    Text = "Remove Function";
                    //Remove function.
                }
                AddBtn.Enabled = false;
                RemoveBtn.Enabled = false;
                TargetTb.Enabled = false;
                foreach (var it in target.FunctionList)
                {
                    if (it.Key == name)
                    {
                        foreach (GXDLMSObject obj in it.Value)
                        {
                            ListViewItem li = new ListViewItem(
                                  new string[] { obj.ObjectType.ToString(),
                                obj.LogicalName, obj.Description
                              });
                            FunctionListView.Items.Add(li);
                        }
                        break;
                    }
                }
            }
        }


        private void OkBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NameTb.Text))
                {
                    throw new Exception("Invalid name.");
                }
                if (!NameTb.ReadOnly && TargetObjects.Count == 0)
                {
                    throw new Exception("Targets are not selected.");
                }
                TargetName = NameTb.Text;
                TargetEnabled = TargetTb.Enabled;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TargetTb.SelectedItem == null)
                {
                    throw new Exception("Target is not selected.");
                }
                GXDLMSObject obj = (GXDLMSObject)TargetTb.SelectedItem;
                TargetObjects.Add(obj);
                ListViewItem li = new ListViewItem(
                               new string[] { obj.ObjectType.ToString(),
                                obj.LogicalName,
                                obj.Description
                           });
                FunctionListView.Items.Add(li);
                //Remove item so it can't be added twice.
                TargetTb.Items.Remove(TargetTb.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FunctionListView.SelectedItems.Count != 1)
                {
                    throw new Exception("Target is not selected.");
                }
                ObjectType ot = (ObjectType)Enum.Parse(typeof(ObjectType), FunctionListView.SelectedItems[0].SubItems[0].Text);
                string ln = FunctionListView.SelectedItems[0].SubItems[1].Text;
                GXDLMSObject obj = Target.Parent.FindByLN(ot, ln);
                TargetObjects.RemoveAll(w => w.ObjectType == ot && w.LogicalName == ln);
                TargetTb.Items.Add(obj);
                FunctionListView.SelectedItems[0].Remove();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
