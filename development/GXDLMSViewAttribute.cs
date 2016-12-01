//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/GXDLMSViewAttribute.cs $
//
// Version:         $Revision: 3125 $,
//                  $Date: 2010-12-14 10:08:50 +0200 (ti, 14 joulu 2010) $
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

namespace Gurux.DLMS.UI
{
    public class GXDLMSViewAttribute : Attribute
    {
        /// <summary>
        /// Costructor.
        /// </summary>
        public GXDLMSViewAttribute(Type dlmsType)
        {
            DLMSType = dlmsType;
        }

        public Type DLMSType
        {
            get;
            private set;
        }
    }
}
