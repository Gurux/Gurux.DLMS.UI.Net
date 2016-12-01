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
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.ManufacturerSettings;
using Gurux.DLMS;
using Gurux.DLMS.Objects;
using System.Reflection;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.UI
{
    public enum GXValueFieldType
    {
        TextBox = 1,
        CompoBox = 2,
        ListBox = 3,
        CheckedListBox = 4
    }

    delegate void UpdateValueItemsEventHandler(GXDLMSObject target, int index, object value);

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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public GXDLMSObject Target
        {
            get;
            set;
        }
    }

    public partial class GXValueField : UserControl
    {
        bool dirty;
        GXValueFieldType type;
        List<GXObisValueItem> Items;

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXValueField()
        {
            InitializeComponent();
            Type = GXValueFieldType.TextBox;
            comboBox1.Visible = false;
            dirty = false;
        }

        /// <summary>
        /// Attribute index.
        /// </summary>
        public int Index
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
        public bool Dirty
        {
            get
            {
                return dirty;
            }
            set
            {
                if (dirty != value)
                {
                    dirty = value;
                    SetDirty(true, this.Value);
                }
            }
        }


        public GXValueFieldType Type
        {
            get
            {
                return type;
            }
            set
            {
                SetDirty(false, null);
                type = value;
                textBox1.Visible = type == GXValueFieldType.TextBox;
                comboBox1.Visible = type == GXValueFieldType.CompoBox;
                listBox1.Visible = type == GXValueFieldType.ListBox;
                checkedlistBox1.Visible = type == GXValueFieldType.CheckedListBox;
                if (Type == GXValueFieldType.CompoBox)
                {
                    comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
                }
                else if (Type == GXValueFieldType.CheckedListBox)
                {
                    checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                }
            }
        }

        private void CheckedlistBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            SetDirty(true, e);
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetDirty(true, textBox1.Text);
        }

        void SetDirty(bool dirty, object value)
        {
            this.dirty = dirty;
            if (dirty && Index != 0)
            {
                ValueEventArgs v = new ValueEventArgs(Target, Index, 0, null);
                (Target as IGXDLMSBase).SetValue(null, v);
                (this.ParentForm as IGXDLMSView).OnDirtyChange(Index, true);
                Target.UpdateDirty(Index, value);
            }
        }

        object GetValue(object target, int index, List<object> UpdatedObjects)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(target);
            foreach (PropertyDescriptor it in properties)
            {
                GXDLMSAttributeSettings i = it.Attributes[typeof(GXDLMSAttributeSettings)] as GXDLMSAttributeSettings;
                if (i != null && i.Index == index)
                {
                    return it.GetValue(target);
                }
                else if (it.PropertyType.IsClass)
                {
                    if (it.PropertyType == typeof(string))
                    {
                        continue;
                    }
                    //If component is not already searched.
                    if (!UpdatedObjects.Contains(target))
                    {
                        UpdatedObjects.Add(target);
                        GetValue(it.GetValue(target), index, UpdatedObjects);
                    }
                }
            }
            return null;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object value = null;
                if (Items != null)
                {
                    foreach (GXObisValueItem it in Items)
                    {
                        if (it.UIValue == comboBox1.Text)
                        {
                            value = it.Value;
                            break;
                        }
                    }
                }
                else
                {
                    value = comboBox1.SelectedItem;
                }
                SetDirty(true, value);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(this, Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateValueItems(GXDLMSObject target, int index, object value)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new UpdateValueItemsEventHandler(UpdateValueItems), target, index, value);
            }
            else
            {
                GXDLMSAttributeSettings tmp = GXDLMSClient.GetAttributeInfo(target, index);
                if (tmp != null)
                {
                    Items = tmp.Values;
                }
                else
                {
                    Items = null;
                }
                if (this.Type == GXValueFieldType.TextBox)
                {
                    this.Type = Items == null || Items.Count == 0 ? GXValueFieldType.TextBox : GXValueFieldType.CompoBox;
                }
                else if (this.Type == GXValueFieldType.CompoBox)
                {
                    comboBox1.Items.Clear();
                    if (Items != null && Items.Count != 0)
                    {
                        foreach (GXObisValueItem it in Items)
                        {
                            comboBox1.Items.Add(it.UIValue);
                        }
                    }
                    else if (value is Enum)
                    {
                        foreach (var it in Enum.GetValues(value.GetType()))
                        {
                            comboBox1.Items.Add(it);
                        }
                    }
                }
                else if (this.Type == GXValueFieldType.ListBox)
                {
                    listBox1.Items.Clear();
                    if (value is Enum)
                    {
                        foreach (var it in Enum.GetValues(value.GetType()))
                        {
                            listBox1.Items.Add(it);
                        }
                    }
                }
                else if (this.Type == GXValueFieldType.CheckedListBox)
                {
                    checkedlistBox1.Items.Clear();
                    if (value is Enum)
                    {
                        foreach (var it in Enum.GetValues(value.GetType()))
                        {
                            checkedlistBox1.Items.Add(it);
                        }
                    }
                }
                ReadOnly = (target.GetAccess(index) & AccessMode.Write) == 0;
            }
        }

        [Browsable(true), DefaultValue(false)]
        public bool ReadOnly
        {
            get
            {
                if (Type == GXValueFieldType.TextBox)
                {
                    return this.textBox1.ReadOnly;
                }
                else if (Type == GXValueFieldType.CompoBox)
                {
                    return this.comboBox1.Enabled;
                }
                else if (Type == GXValueFieldType.ListBox)
                {
                    return this.listBox1.Enabled;
                }
                else if (Type == GXValueFieldType.CheckedListBox)
                {
                    return this.checkedlistBox1.Enabled;
                }
                throw new InvalidExpressionException("");
            }
            set
            {
                if (Type == GXValueFieldType.TextBox)
                {
                    this.textBox1.ReadOnly = value;
                }
                else if (Type == GXValueFieldType.CompoBox)
                {
                    this.comboBox1.Enabled = !value;
                }
                else if (Type == GXValueFieldType.ListBox)
                {
                    this.listBox1.Enabled = !value;
                }
                else if (Type == GXValueFieldType.CheckedListBox)
                {
                    this.checkedlistBox1.Enabled = !value;
                }
                else
                {
                    throw new InvalidExpressionException();
                }
            }
        }

        delegate void UpdateValueEventHandler(object value);

        void OnUpdateValue(object value)
        {
            string str;
            if (value != null && value.GetType().IsArray)
            {
                str = Convert.ToString(GXHelpers.ConvertFromDLMS(value, DataType.None, DataType.None, true));
            }
            else
            {
                str = GXHelpers.ConvertDLMS2String(value);
            }
            if (Type == GXValueFieldType.TextBox)
            {
                textBox1.TextChanged -= new EventHandler(textBox1_TextChanged);
                this.textBox1.Text = str;
                textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            }
            else if (Type == GXValueFieldType.CompoBox)
            {
                if (comboBox1.Items.Count != 0)
                {
                    if (value != null)
                    {
                        if (Items != null && Items.Count != 0)
                        {
                            foreach (GXObisValueItem it in Items)
                            {
                                if (it.Value.Equals(Convert.ChangeType(value, it.Value.GetType())))
                                {
                                    int pos = comboBox1.Items.IndexOf(it.UIValue);
                                    if (pos != -1)
                                    {
                                        comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
                                        comboBox1.SelectedIndex = pos;
                                        comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
                                        return;
                                    }
                                }
                            }
                        }
                        else if (value is Enum)
                        {
                            comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
                            comboBox1.SelectedItem = value;
                            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
                            return;
                        }
                    }
                    else
                    {
                        comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
                        comboBox1.SelectedIndex = -1;
                        comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
                        return;
                    }
                }
                this.comboBox1.Text = str;
            }
            else if (Type == GXValueFieldType.ListBox)
            {
                if (value is Array)
                {
                    this.listBox1.Items.Clear();
                    foreach (Array it in (Array)value)
                    {
                        List<byte> arr = new List<byte>();
                        foreach (object item in it)
                        {
                            if (item is Array)
                            {
                                foreach (byte b in (Array)item)
                                {
                                    arr.Add(b);
                                }
                            }
                            else
                            {
                                arr.Add((byte)item);
                            }
                        }
                        listBox1.Items.Add(ASCIIEncoding.ASCII.GetString((byte[])arr.ToArray()));
                    }
                }
                else if (value is Enum)
                {
                    listBox1.SelectedItem = value;
                    return;
                }
            }
            else if (Type == GXValueFieldType.CheckedListBox)
            {
                if (value is Enum)
                {
                    checkedlistBox1.ItemCheck -= CheckedlistBox1_ItemCheck;
                    //Uncheck all items.
                    for (int pos = 0; pos != checkedlistBox1.Items.Count; ++pos)
                    {
                        checkedlistBox1.SetItemChecked(pos, false);
                    }

                    foreach (var it in Enum.GetValues(value.GetType()))
                    {
                        if (((int)it & (int)value) != 0 ||
                                ((int)it == (int)value))
                        {
                            checkedlistBox1.SetItemChecked(checkedlistBox1.Items.IndexOf(it), true);
                        }
                    }
                    checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                    return;
                }
            }
            else
            {
                throw new InvalidExpressionException();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public object Value
        {
            get
            {
                if (Type == GXValueFieldType.TextBox)
                {
                    return this.textBox1.Text;
                }
                else if (Type == GXValueFieldType.CompoBox)
                {
                    return this.comboBox1.Text;
                }
                else if (Type == GXValueFieldType.ListBox)
                {
                    return this.listBox1.Text;
                }
                throw new InvalidExpressionException();
            }
            set
            {
                if (InvokeRequired)
                {
                    this.BeginInvoke(new UpdateValueEventHandler(OnUpdateValue), value);
                }
                else
                {
                    try
                    {
                        OnUpdateValue(value);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
