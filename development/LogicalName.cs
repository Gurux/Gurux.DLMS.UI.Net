//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXValueField.cs $
//
// Version:         $Revision: 8914 $,
//                  $Date: 2016-11-21 17:40:57 +0200 (ma, 21 marras 2016) $
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
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.ManufacturerSettings;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Collections;
using System.Xml;
using System.Linq;

namespace Gurux.DLMS.UI
{
    internal class LogicalName
    {
        readonly string logicalName;
        public LogicalName(string value)
        {
            logicalName = value;
        }
        public static implicit operator string(LogicalName value)
        {
            return value.logicalName;
        }
        public static implicit operator LogicalName(string value)
        {
            return new LogicalName(value);
        }

        public override string ToString()
        {
            return logicalName;
        }
    }

    delegate void UpdateValueItemsEventHandler(GXDLMSObject target, int index, object value);
}
