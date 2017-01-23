//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSSFSKActiveInitiatorView.cs $
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
[GXDLMSViewAttribute(typeof(GXDLMSSFSKActiveInitiator))]
public partial class GXDLMSSFSKActiveInitiatorView : Form, IGXDLMSView
{
    /// <summary>
    /// Constructor.
    /// </summary>
    public GXDLMSSFSKActiveInitiatorView()
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
            GXDLMSSFSKActiveInitiator target = Target as GXDLMSSFSKActiveInitiator;
            SystemTitleTB.Text = target.SystemTitle;
            MACAddressTB.Text = target.MacAddress.ToString();
            LSAPSelectorTB.Text = target.LSapSelector.ToString();
        }
        else if (index != 0)
        {
            throw new IndexOutOfRangeException("index");
        }
    }

    public void OnAccessRightsChange(int index, AccessMode access)
    {
        if (index == 2)
        {
            SystemTitleTB.ReadOnly = MACAddressTB.ReadOnly = LSAPSelectorTB.ReadOnly = (access & AccessMode.Write) != 0;
        }
        else
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
