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
using Gurux.DLMS.Objects.Enums;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSScriptActionDlg : Form
    {
        GXDLMSScriptAction action;
        GXDLMSObjectCollection targets;
        public GXDLMSScriptActionDlg(
            GXDLMSScriptAction a,
            GXDLMSObjectCollection objects)
        {
            action = a;
            targets = objects;
            InitializeComponent();
            foreach (DataType it in Enum.GetValues(typeof(DataType)))
            {
                if (it != DataType.None && it != DataType.Array && it != DataType.Structure)
                {
                    ParameterTypeTb.Items.Add(it);
                }
            }
            TypeCb.Items.Add(ScriptActionType.Write);
            TypeCb.Items.Add(ScriptActionType.Execute);
            if (a.Type == ScriptActionType.None)
            {
                a.Type = ScriptActionType.Write;
            }
            TypeCb.SelectedItem = a.Type;
            foreach (GXDLMSObject it in objects)
            {
                TargetCb.Items.Add(it);
            }
            TargetCb.SelectedItem = a.Target;
            IndexTB.Text = action.Index.ToString();
            ParameterTb.Text = Convert.ToString(action.Parameter);
            ParameterTypeTb.SelectedItem = action.ParameterDataType;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TargetCb.SelectedItem == null)
                {
                    throw new Exception("Target is not selected.");
                }
                if (IndexTB.Text == "")
                {
                    throw new Exception("Invalid index.");
                }

                action.Type = (ScriptActionType)TypeCb.SelectedItem;
                action.Target = TargetCb.SelectedItem as GXDLMSObject;
                action.Index = int.Parse(IndexTB.Text);
                action.ParameterDataType = (DataType) ParameterTypeTb.SelectedItem;
                action.Parameter = GXDLMSConverter.ChangeType(ParameterTb.Text, action.ParameterDataType, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
    }
}
