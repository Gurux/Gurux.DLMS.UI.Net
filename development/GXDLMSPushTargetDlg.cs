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
    public partial class GXDLMSPushTargetDlg : Form
    {
        public KeyValuePair<GXDLMSObject, GXDLMSCaptureObject> Target
        {
            get;
            private set;
        }

        public GXDLMSPushTargetDlg(
            KeyValuePair<GXDLMSObject, GXDLMSCaptureObject> target,
            GXDLMSObjectCollection objects)
        {
            Target = target;
            InitializeComponent();
            foreach (GXDLMSObject it in objects)
            {
                TargetCb.Items.Add(it);
            }
            TargetCb.SelectedItem = target.Key;
            if (target.Value != null)
            {
                IndexTB.Text = Convert.ToString(target.Value.AttributeIndex);
            }
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
                Target = new KeyValuePair<GXDLMSObject, GXDLMSCaptureObject>(TargetCb.SelectedItem as GXDLMSObject, new GXDLMSCaptureObject(int.Parse(IndexTB.Text), 0));
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
