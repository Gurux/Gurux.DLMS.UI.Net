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
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Defines what fields are not shown on the search dialog.
    /// </summary>
    /// <remarks>
    /// In default all fields are visible.
    /// </remarks>
    [Flags]
    public enum SearchDialogHidden
    {
        /// <summary>
        /// All fields are visible.
        /// </summary>
        None = 0,
        /// <summary>
        /// OBIS code is hidden.
        /// </summary>
        Obis = 1,
        /// <summary>
        /// Text field is hidden.
        /// </summary>
        Text = 2
    }

    public class GXFindParameters
    {
        /// <summary>
        /// OBIS code to search for.
        /// </summary>
        public string ObisCode
        {
            get;
            set;
        }

        /// <summary>
        /// Text to search for.
        /// </summary>
        public string Text
        {
            get;
            set;
        }

        /// <summary>
        /// Hidden fiels.
        /// </summary>
        public SearchDialogHidden Hide
        {
            get;
            set;
        }
    }
}
