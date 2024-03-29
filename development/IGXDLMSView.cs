//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/IGXDLMSView.cs $
//
// Version:         $Revision: 8063 $,
//                  $Date: 2016-01-20 14:17:03 +0200 (ke, 20 tammi 2016) $
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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    public class GXDLMSViewArguments
    {
        /// <summary>
        /// DLMS Client.
        /// </summary>
        public GXDLMSClient Client;
        /// <summary>
        /// Attribute or method index.
        /// </summary>
        public int Index;
        /// <summary>
        /// Is connection established to the meter.
        /// </summary>
        public bool Connected;
        /// <summary>
        /// New value is used with OnValueChanged.
        /// </summary>
        public object Value;
        /// <summary>
        /// True, if user has updated the value.
        /// This is used with OnValueChanged.
        /// </summary>
        public bool User;
    }

    public interface IGXDLMSView
    {
        /// <summary>
        /// Selected COSEM object.
        /// </summary>
        GXDLMSObject Target
        {
            get;
            set;
        }

        /// <summary>
        /// Called after value has changed and if attribute index is not set to GXValueField.
        /// </summary>
        /// <param name="arg">UI Arguments.</param>
        void OnValueChanged(GXDLMSViewArguments arg);

        /// <summary>
        /// Called after access rights changed and if  Attribute ID is not set to GXValueField.
        /// </summary>
        /// <param name="arg">UI Arguments.</param>
        void OnAccessRightsChange(GXDLMSViewArguments arg);

        /// <summary>
        /// Called after action access rights changed and if Attribute ID is not set to GXButton.
        /// </summary>
        /// <param name="arg">UI Arguments.</param>
        void OnMethodAccessRightsChange(GXDLMSViewArguments arg);

        /// <summary>
        /// Called to update UI after value has change.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="Dirty"></param>
        void OnDirtyChange(int index, bool Dirty);

        /// <summary>
        /// Called before action executed.
        /// </summary>
        /// <param name="client">DLMS client.</param>
        /// <param name="type">Action type.</param>
        /// <param name="arg">Value event argument.</param>
        /// <returns>Next action type to execute.</returns>
        void PreAction(GXActionArgs arg);

        /// <summary>
        /// Called after action executed.
        /// </summary>
        /// <param name="type">Action type.</param>
        /// <param name="arg">Value event argument.</param>
        /// <returns>Next action type to execute.</returns>
        void PostAction(GXActionArgs arg);

        System.Windows.Forms.ErrorProvider ErrorProvider
        {
            get;
        }

        /// <summary>
        /// Update Desctiption.
        /// </summary>
        string Description
        {
            get;
            set;
        }
    }
}
