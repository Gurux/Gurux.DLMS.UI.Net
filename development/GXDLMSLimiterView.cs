//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSLimiterView.cs $
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
[GXDLMSViewAttribute(typeof(GXDLMSLimiter))]
partial class GXDLMSLimiterView : Form, IGXDLMSView
{

    /// <summary>
    /// Constructor.
    /// </summary>
    public GXDLMSLimiterView()
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
            MonitoredValueTB.Text = Convert.ToString(((GXDLMSLimiter)Target).MonitoredValue);
            MonitoredIndexTB.Text = ((GXDLMSLimiter)Target).MonitoredAttributeIndex.ToString();
        }
        else if (index == 10)
        {
            EmergencyProfileActiveCB.Checked = (bool)value;
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
            errorProvider1.SetError(MonitoredValueTB, Properties.Resources.ValueChangedTxt);
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



}
}
