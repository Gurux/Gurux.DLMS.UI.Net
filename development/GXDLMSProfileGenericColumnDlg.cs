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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSProfileGenericColumnDlg : Form
    {
        GXDLMSObjectCollection AllObjects;
        GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> Target;

        public GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> GetTarget()
        {
            return Target;
        }

        public GXDLMSProfileGenericColumnDlg(
            GXKeyValuePair<GXDLMSObject, GXDLMSCaptureObject> target, GXDLMSObjectCollection list, string title)
        {
            if (title != null)
            {
                this.Text = title;
            }
            Target = target;
            AllObjects = new GXDLMSObjectCollection();
            AllObjects.AddRange(list);
            //Remove not needed objects.
            foreach (GXDLMSObject it in list.GetObjects(new ObjectType[] { ObjectType.AssociationLogicalName, ObjectType.AssociationShortName, ObjectType.ProfileGeneric }))
            {
                AllObjects.Remove(it);
            }
            InitializeComponent();
            foreach (GXDLMSObject it in AllObjects)
            {
                TargetCb.Items.Add(it);
            }
            if (Target.Key != null)
            {
                TargetCb.SelectedItem = AllObjects.FindByLN(Target.Key.ObjectType, Target.Key.LogicalName);
            }
            if (Target.Value != null)
            {
                IndexTB.Text = target.Value.AttributeIndex.ToString();
                DataIndexTb.Text = target.Value.DataIndex.ToString();
            }
            else
            {
                IndexTB.Text = "2";
                DataIndexTb.Text = "0";
            }
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TargetCb.SelectedItem == null)
                {
                    throw new Exception(Properties.Resources.InvalidTarget);
                }
                if (IndexTB.Text == "")
                {
                    throw new Exception(Properties.Resources.InvalidIndex);
                }
                Target.Key = TargetCb.SelectedItem as GXDLMSObject;
                if (Target.Value == null)
                {
                    Target.Value = new GXDLMSCaptureObject();
                }
                Target.Value.AttributeIndex = int.Parse(IndexTB.Text);
                Target.Value.DataIndex = int.Parse(DataIndexTb.Text);
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
