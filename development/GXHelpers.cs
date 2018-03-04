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
using System.Text;
using Gurux.DLMS.Enums;
using Gurux.DLMS.Objects;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    class GXHelpers
    {
        static public object ConvertFromDLMS(object data, DataType from, DataType type, bool arrayAsString)
        {
            if (type == DataType.Array)
            {
                return data;
            }
            if (type == DataType.None)
            {
                if (arrayAsString && data != null && data.GetType().IsArray)
                {
                    data = GXHelpers.GetArrayAsString(data);
                }
                return data;
            }
            //Show Octet string...
            if (from == DataType.OctetString && type == DataType.OctetString)
            {
                if (data is byte[])
                {
                    string str = "";
                    byte[] arr = (byte[])data;
                    if (arr.Length == 0)
                    {
                        data = string.Empty;
                    }
                    else
                    {
                        foreach (byte it in arr)
                        {
                            str += it.ToString() + ".";
                        }
                        data = str.Substring(0, str.Length - 1);
                    }
                }
            }
            //Convert DLMS octect string to Windows string.
            else if (from == DataType.OctetString && type == DataType.String)
            {
                if (data is string)
                {
                    return data;
                }
                else if (data is byte[])
                {
                    byte[] arr = (byte[])data;
                    data = System.Text.Encoding.ASCII.GetString(arr);
                }
            }
            //Convert DLMS date time to Windows Time.
            else if (type == DataType.DateTime)
            {
                if (data is byte[])
                {
                    if (((byte[])data).Length == 5)
                    {
                        return GXDLMSClient.ChangeType((byte[])data, DataType.Date);
                    }
                    return GXDLMSClient.ChangeType((byte[])data, DataType.DateTime);
                }
                return data;
            }
            //Convert DLMS date time to Windows Date.
            else if (type == DataType.Date)
            {
                if (data is DateTime)
                {
                    return data;
                }
                if (data is string)
                {
                    return data;
                }
                if (!data.GetType().IsArray || ((Array)data).Length < 5)
                {
                    throw new Exception("DateTime conversion failed. Invalid DLMS format.");
                }
                return GXDLMSClient.ChangeType((byte[])data, DataType.Date);
            }
            //Convert DLMS date time to Windows Time.
            else if (type == DataType.Time)
            {
                if (data is byte[])
                {
                    return GXDLMSClient.ChangeType((byte[])data, type);
                }
                return data;
            }
            else if (data is byte[])
            {
                if (type == DataType.String)
                {
                    data = System.Text.Encoding.ASCII.GetString((byte[])data);
                }
                else
                {
                    data = GXDLMSTranslator.ToHex((byte[])data);
                }
            }
            else if (data is Array)
            {
                data = ArrayToString(data);
            }
            return data;
        }

        /// <summary>
        /// Converts string to byte[].
        /// format: AB ba 01 1
        /// </summary>
        /// <param name="hexString">Hex string to convert.</param>
        /// <returns>Byte array.</returns>
        public static byte[] StringToByteArray(string hexString)
        {
            //if hex string is octect string.
            bool isOctetString = hexString.Contains(".");
            if (string.IsNullOrEmpty(hexString))
            {
                return null;
            }
            string[] splitted = hexString.Split(isOctetString ? '.' : ' ');
            byte[] retVal = new byte[splitted.Length];
            int i = -1;
            foreach (string hexStr in splitted)
            {
                retVal[++i] = Convert.ToByte(hexStr, isOctetString ? 10 : 16);
            }
            return retVal;
        }

        static string ArrayToString(object data)
        {
            string str = "";
            if (data is Array)
            {
                Array arr = (Array)data;
                for (long pos = 0; pos != arr.Length; ++pos)
                {
                    object tmp = arr.GetValue(pos);
                    if (tmp is Array)
                    {
                        str += "{ " + ArrayToString(tmp) + " }";
                    }
                    else
                    {
                        str += "{ " + Convert.ToString(tmp) + " }";
                    }
                }
            }
            return str;
        }

        static public string GetArrayAsString(object data)
        {
            if (data is byte[])
            {
                return GXDLMSTranslator.ToHex((byte[])data);
            }
            Array arr = (Array)data;
            string str = null;
            foreach (object it in arr)
            {
                if (str == null)
                {
                    str = "{";
                }
                else
                {
                    str += ", ";
                }
                if (it != null && it.GetType().IsArray)
                {
                    str += GetArrayAsString(it);
                }
                else
                {
                    str += Convert.ToString(it);
                }
            }
            if (str == null)
            {
                str = "";
            }
            else
            {
                str += "}";
            }
            return str;
        }

        static public string ConvertDLMS2String(object data)
        {
            if (data is DateTime)
            {
                DateTime dt = (DateTime)data;
                if (dt == DateTime.MinValue)
                {
                    return "";
                }
                return dt.ToString();
            }
            if (data is GXDateTime)
            {
                GXDateTime dt = (GXDateTime)data;
                return dt.ToFormatString();
            }
            if (data is byte[])
            {
                return BitConverter.ToString((byte[])data).Replace("-", " ");
            }
            return Convert.ToString(data);
        }

        static public bool IsNumeric(DataType type)
        {
            switch (type)
            {
                case DataType.Float32:
                case DataType.Float64:
                case DataType.Int16:
                case DataType.Int32:
                case DataType.Int64:
                case DataType.Int8:
                case DataType.String:
                case DataType.UInt16:
                case DataType.UInt32:
                case DataType.UInt64:
                case DataType.UInt8:
                    return true;
            }
            return false;
        }

        static public GXDLMSSettings GetSettings(GXDLMSObject target)
        {
            if (target.Parent.Parent is GXDLMSClient)
            {
                return (target.Parent.Parent as GXDLMSClient).Settings;
            }
            return (target.Parent.Parent as GXDLMSServer).Settings;
        }

        public static bool IsAscii(byte[] value)
        {
            if (value == null)
            {
                return false;
            }
            foreach (byte it in value)
            {
                if (it < 0x20 || it > 0x7E)
                {
                    return false;
                }
            }
            return true;
        }

        public static string GetString(byte[] value)
        {
            string str;
            if (value == null)
            {
                str = "";
            }
            if (IsAscii(value))
            {
                str = ASCIIEncoding.ASCII.GetString(value);
            }
            else
            {
                str = GXDLMSTranslator.ToHex(value);
            }
            return str;
        }

        /// <summary>
        /// Convert string to structure. 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="value"></param>
        static public object ChangeStringToStructure(string str, object[] structure)
        {
            if (str.StartsWith("{") && str.EndsWith("}"))
            {
                string[] list = str.Substring(1, str.Length - 2).Split(new char[] { ',' });
                if (list.Length == structure.Length)
                {
                    object[] values = new object[list.Length];
                    for (int pos = 0; pos != list.Length; ++pos)
                    {
                        if (structure[pos] == null)
                        {
                            break;
                        }
                        DataType dt = GXDLMSConverter.GetDLMSDataType(structure[pos]);
                        values[pos] = Convert.ChangeType(list[pos].Trim(), GXDLMSConverter.GetDataType(dt));
                    }
                    return values;
                }
            }
            return str;
        }

        public class MessageBoxResult
        {
            public DialogResult Result
            {
                get;
                set;
            }
        }

        delegate void ShowMessageBoxEventHandler(MessageBoxResult ret, Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon);
        static public void OnShowMessageBox(MessageBoxResult ret, Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            ret.Result = MessageBox.Show(owner, text, caption, buttons, icon);
        }

        static public DialogResult ShowMessageBox(Form owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            if (owner.InvokeRequired)
            {
                MessageBoxResult ret = new MessageBoxResult();
                owner.BeginInvoke(new ShowMessageBoxEventHandler(OnShowMessageBox), ret, owner, text, caption, buttons, icon).AsyncWaitHandle.WaitOne();
                return ret.Result;
            }
            else
            {
                return MessageBox.Show(owner, text, caption, buttons, icon);
            }
        }
    }
}
