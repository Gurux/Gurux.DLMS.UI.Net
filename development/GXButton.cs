//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: $
//
// Version:         $Revision: $,
//                  $Date:  $
//                  $Author: $
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

using Gurux.DLMS.Objects;
using System.ComponentModel;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public class GXButton : Button
    {
        /// <summary>
        /// Action index.
        /// </summary>
        public int Index
        {
            get;
            set;
        }

        /// <summary>
        /// Is this attribute or action index.
        /// </summary>
        [DefaultValue(ActionType.Action)]
        public ActionType Action
        {
            get;
            set;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public GXDLMSObject Target
        {
            get;
            set;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public IGXDLMSView View
        {
            get;
            set;
        }
    }

    /// <summary>
    /// What kind of action button executes.
    /// </summary>
    public enum ActionType
    {
        /// <summary>
        /// No actions are executed.
        /// </summary>
        None = 0,
        /// <summary>
        /// Action is executed.
        /// </summary>
        Action,
        /// <summary>
        /// Read is executed.
        /// </summary>
        Read,
        /// <summary>
        /// Write is executed.
        /// </summary>
        Write        
    }
}
