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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using Gurux.DLMS.Enums;
using System;

namespace Gurux.DLMS.UI
{
    public class GXDLMSViewAttribute : Attribute
    {
        /// <summary>
        /// Costructor.
        /// </summary>
        /// <param name="dlmsType">COSEM object that this UI shown.</param>
        public GXDLMSViewAttribute(Type dlmsType)
        {
            DLMSType = dlmsType;
            Versions = new byte[] { 0};
            Standards = new Standard[] { Standard.DLMS };
        }

        /// <summary>
        /// Costructor.
        /// </summary>
        /// <param name="dlmsType">COSEM object that this UI shown.</param>
        /// <param name="version">DLMS version number.</param>
        public GXDLMSViewAttribute(Type dlmsType, byte version)
        {
            DLMSType = dlmsType;
            Versions = new byte[] { version };
            Standards = new Standard[] { Standard.DLMS };
        }

        /// <summary>
        /// Costructor.
        /// </summary>
        /// <param name="dlmsType">COSEM object that this UI shown.</param>
        /// <param name="version">DLMS version number.</param>
        /// <param name="ln">Logical name.</param>
        /// <param name="standard">Used standard.</param>
        public GXDLMSViewAttribute(Type dlmsType, byte version, string ln, Standard standard)
        {
            DLMSType = dlmsType;
            Versions = new byte[] { version };
            LogicalNames = new string[] { ln };
            Standards = new Standard[] { standard };
        }

        /// <summary>
        /// Costructor.
        /// </summary>
        /// <param name="dlmsType">COSEM object that this UI shown.</param>
        /// <param name="versions">DLMS version numbers.</param>
        /// <param name="logicalNames">Logical names.</param>
        /// <param name="standards">Used standards.</param>
        public GXDLMSViewAttribute(Type dlmsType, byte[] versions, string[] logicalNames, Standard[] standards)
        {
            DLMSType = dlmsType;
            Versions = versions;
            LogicalNames = logicalNames;
            Standards = standards;
        }

        public Type DLMSType
        {
            get;
            private set;
        }

        [Obsolete("Use Versions.")]
        public byte Version
        {
            get;
            private set;
        }

        public byte[] Versions
        {
            get;
            private set;
        }

        [Obsolete("Use LogicalNames.")]
        public string LogicalName
        {
            get;
            private set;
        }

        public string[] LogicalNames
        {
            get;
            private set;
        }

        [Obsolete("Use Standards.")]
        public Standard Standard
        {
            get;
            private set;
        }

        public Standard[] Standards
        {
            get;
            private set;
        }
    }
}
