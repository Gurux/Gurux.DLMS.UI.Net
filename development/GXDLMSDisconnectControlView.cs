//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSDisconnectControlView.cs $
//
// Version:         $Revision: 5795 $,
//                  $Date: 2012-10-02 13:22:54 +0300 (ti, 02 loka 2012) $
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
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
[GXDLMSViewAttribute(typeof(GXDLMSDisconnectControl))]
partial class GXDLMSDisconnectControlView : Form, IGXDLMSView
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public GXDLMSDisconnectControlView()
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
        if (index == 2)
        {
            GXDLMSDisconnectControl target = Target as GXDLMSDisconnectControl;
            this.OutputStateCB.Checked = target.OutputState;
        }
        else if (index != 0)
        {
            throw new IndexOutOfRangeException("index");
        }
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
        if (Dirty && index == 2)
        {
            errorProvider1.SetError(ControlStateCB, Properties.Resources.ValueChangedTxt);
        }
        else
        {
            errorProvider1.Clear();
        }
    }

    public void OnAccessRightsChange(int index, AccessMode access)
    {
    }

    #endregion




    private void ValueTB_KeyUp(object sender, KeyEventArgs e)
    {
        errorProvider1.SetError((Control)sender, "Value changed.");
    }

    private void ValueTB_KeyPress(object sender, KeyPressEventArgs e)
    {
        errorProvider1.SetError((Control)sender, "Value changed.");
    }
}
}
