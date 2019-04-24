﻿//
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

using Gurux.DLMS.Objects;
using System;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSTargetObjectDlg : Form
    {
        public GXDLMSObject Target
        {
            get;
            set;
        }

        public byte Index
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="caption">Window caption.</param>
        /// <param name="target">Selected objects.</param>
        /// <param name="objects">List of COSEM objects.</param>
        public GXDLMSTargetObjectDlg(string caption, GXDLMSObject target, GXDLMSObjectCollection objects)
        {
            Target = target;
            InitializeComponent();
            Text = caption;
            if (objects == null)
            {
                TargetCb.Enabled = false;
                Target = target;
            }
            else
            {
                foreach (GXDLMSObject it in objects)
                {
                    TargetCb.Items.Add(it);
                    if (it == target)
                    {
                        TargetCb.SelectedItem = target;
                    }
                }
            }
            IndexLbl.Visible = IndexTB.Visible = false;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="caption">Window caption.</param>
        /// <param name="target">Selected objects.</param>
        /// <param name="index">Attribute index.</param>
        /// <param name="objects">List of COSEM objects.</param>
        public GXDLMSTargetObjectDlg(string caption, GXDLMSObject target, int index, GXDLMSObjectCollection objects)
        {
            Target = target;
            InitializeComponent();
            Text = caption;
            if (objects == null)
            {
                TargetCb.Enabled = false;
                Target = target;
                IndexTB.Enabled = false;
            }
            else
            {
                foreach (GXDLMSObject it in objects)
                {
                    TargetCb.Items.Add(it);
                    if (it == target)
                    {
                        TargetCb.SelectedItem = target;
                    }
                }
                IndexTB.Text = index.ToString();
            }
        }

        private void GXDLMSTargetObjectDlg_Load(object sender, EventArgs e)
        {
            if(!TargetCb.Enabled)
            {
                TargetCb.Items.Add(Target);
                TargetCb.SelectedIndex = 0;
                IndexTB.Text = Index.ToString();
            }
        }


        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TargetCb.Enabled)
                {
                    if (TargetCb.SelectedItem == null)
                    {
                        throw new Exception("Target is not selected.");
                    }
                    Target = TargetCb.SelectedItem as GXDLMSObject;
                }
                if (IndexTB.Visible)
                {
                    if (IndexTB.Text == "")
                    {
                        throw new Exception("Invalid index.");
                    }
                    Index = byte.Parse(IndexTB.Text);
                    if (Index == 0)
                    {
                        throw new Exception("Invalid index.");
                    }
                }
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
