//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSHdlcSetupView.cs $
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
using Gurux.DLMS;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
[GXDLMSViewAttribute(typeof(GXDLMSHdlcSetup))]
partial class GXDLMSHdlcSetupView : Form, IGXDLMSView
{

    /// <summary>
    /// Constructor.
    /// </summary>
    public GXDLMSHdlcSetupView()
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
        throw new IndexOutOfRangeException("index");
    }

    public void OnAccessRightsChange(int index, AccessMode access)
    {
        throw new NotImplementedException();
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
        switch (index)
        {
        case 2:
            errorProvider1.SetError(SpeedTB, Properties.Resources.ValueChangedTxt);
            break;
        case 3:
            errorProvider1.SetError(TransmitWindowSizeTB, Properties.Resources.ValueChangedTxt);
            break;
        case 4:
            errorProvider1.SetError(TransmitMaxLengthTB, Properties.Resources.ValueChangedTxt);
            break;
        case 5:
            errorProvider1.SetError(ReceiveWindowSizeTB, Properties.Resources.ValueChangedTxt);
            break;
        case 6:
            errorProvider1.SetError(ReceiveMaxLengthTB, Properties.Resources.ValueChangedTxt);
            break;
        case 7:
            errorProvider1.SetError(InternalTimeOutLTB, Properties.Resources.ValueChangedTxt);
            break;
        case 8:
            errorProvider1.SetError(InactivityTimeoutTB, Properties.Resources.ValueChangedTxt);
            break;
        case 9:
            errorProvider1.SetError(DeviceAddressTB, Properties.Resources.ValueChangedTxt);
            break;
        default:
            errorProvider1.Clear();
            break;
        }
    }

    #endregion




}
}
