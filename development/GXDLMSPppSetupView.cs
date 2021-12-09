//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSPppSetupView.cs $
//
// Version:         $Revision: 8933 $,
//                  $Date: 2016-11-23 09:20:07 +0200 (ke, 23 marras 2016) $
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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSPppSetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSPppSetup))]
    partial class GXDLMSPppSetupView : Form, IGXDLMSView
    {


        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSPppSetupView()
        {
            InitializeComponent();
        }
        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            if (arg.Index == 5)
            {
                GXDLMSPppSetup target = Target as GXDLMSPppSetup;
                UserNameTB.TextChanged -= new System.EventHandler(this.UserNameTB_TextChanged);
                if (target.UserName != null)
                {
                    UserNameTB.Text = ASCIIEncoding.ASCII.GetString(target.UserName);
                }
                else
                {
                    UserNameTB.Text = "";
                }
                UserNameTB.TextChanged += new System.EventHandler(this.UserNameTB_TextChanged);

                PasswordTB.TextChanged -= new System.EventHandler(this.PasswordTB_TextChanged);
                if (target.Password != null)
                {
                    PasswordTB.Text = ASCIIEncoding.ASCII.GetString(target.Password);
                }
                else
                {
                    PasswordTB.Text = "";
                }
                PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            if (arg.Index == 5)
            {
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
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




        private void DataLinkLayerTB_Load(object sender, EventArgs e)
        {

        }

        private void UserNameTB_Leave(object sender, EventArgs e)
        {

        }

        private void PasswordTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSPppSetup).Password = ASCIIEncoding.ASCII.GetBytes(PasswordTB.Text);
                Target.UpdateDirty(5, (Target as GXDLMSPppSetup).Password);
                errorProvider1.SetError(PasswordTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserNameTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (Target as GXDLMSPppSetup).UserName = ASCIIEncoding.ASCII.GetBytes(UserNameTB.Text);
                Target.UpdateDirty(5, (Target as GXDLMSPppSetup).UserName);
                errorProvider1.SetError(UserNameTB, Properties.Resources.ValueChangedTxt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
