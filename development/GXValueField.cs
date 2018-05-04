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
using System.Data;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.ManufacturerSettings;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Collections;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// How value is shown.
    /// </summary>
    public enum ValueFieldType
    {
        /// <summary>
        /// Value is shown as text box.
        /// </summary>
        TextBox = 1,
        /// <summary>
        /// Value is shown as compo box.
        /// </summary>
        CompoBox = 2,
        /// <summary>
        /// Value is shown as list box.
        /// </summary>
        ListBox = 3,
        /// <summary>
        /// Value is shown as checked list box.
        /// </summary>
        CheckedListBox = 4
    }

    delegate void UpdateValueItemsEventHandler(GXDLMSObject target, int index, object value);


    public partial class GXValueField : UserControl
    {
        bool dirty;
        ValueFieldType type;
        List<GXObisValueItem> Items;
        ToolStripMenuItem undo, cut, copy, paste;
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXValueField()
        {
            InitializeComponent();
            Type = ValueFieldType.TextBox;
            comboBox1.Visible = false;
            dirty = false;
            textBox1.KeyUp += TextBox1_KeyUp;
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Name = "menu";
            undo = new ToolStripMenuItem();
            undo.Name = "Undo";
            undo.Text = "Undo";
            undo.Click += Undo_Click;
            cut = new ToolStripMenuItem();
            cut.Name = "Cut";
            cut.Text = "Cut";
            cut.Click += Cut_Click;
            copy = new ToolStripMenuItem();
            copy.Name = "Copy";
            copy.Text = "Copy";
            copy.Click += Copy_Click;
            paste = new ToolStripMenuItem();
            paste.Name = "Paste";
            paste.Text = "Paste";
            paste.Click += Paste_Click;
            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                undo,
                new ToolStripSeparator(){ Name = "separator"},
                cut,
                copy,
                paste
            });
            menu.SuspendLayout();
            menu.Opening += Menu_Opening;
            textBox1.ContextMenuStrip = menu;
        }

        /// <summary>
        /// Accept changes when user press enter.
        /// </summary>
        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1_LostFocus(null, null);
            }
        }

        private void Menu_Opening(object sender, CancelEventArgs e)
        {
            if (Type != ValueFieldType.TextBox)
            {
                cut.Enabled = false;
                copy.Enabled = false;
                paste.Enabled = false;
            }
            else
            {
                undo.Enabled = cut.Enabled = paste.Enabled = !textBox1.ReadOnly;
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            try
            {
                OnUpdateValue(Target.GetValues()[Index - 1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Clipboard.GetText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    Clipboard.SetText(textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Attribute index.
        /// </summary>
        public int Index
        {
            get;
            set;
        }

        /// <summary>
        /// Are changes notified.
        /// </summary>
        /// <remarks>
        /// This can be used if UI needs to change when value or access rights change.
        /// </remarks>
        public bool NotifyChanges
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


        public ValueFieldType Type
        {
            get
            {
                return type;
            }
            set
            {
                SetDirty(false, null);
                if (Type == ValueFieldType.CompoBox)
                {
                    comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
                }
                else if (Type == ValueFieldType.CheckedListBox)
                {
                    checkedlistBox1.ItemCheck -= CheckedlistBox1_ItemCheck;
                }
                type = value;
                textBox1.Visible = type == ValueFieldType.TextBox;
                comboBox1.Visible = type == ValueFieldType.CompoBox;
                listBox1.Visible = type == ValueFieldType.ListBox;
                checkedlistBox1.Visible = type == ValueFieldType.CheckedListBox;
                if (Type == ValueFieldType.CompoBox)
                {
                    comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
                }
                else if (Type == ValueFieldType.CheckedListBox)
                {
                    checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                }
            }
        }

        private void CheckedlistBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int value = 0;
            foreach (var it in checkedlistBox1.Items)
            {
                value |= Convert.ToInt32(it);
            }
            SetDirty(true, value);
        }
        bool Compare(object original, object value)
        {
            if (original is byte[])
            {
                if (value is byte[])
                {
                    return ((IStructuralEquatable)original).Equals(value, StructuralComparisons.StructuralEqualityComparer);
                }
                if (value is string)
                {
                    return ((IStructuralEquatable)original).Equals(GXDLMSTranslator.HexToBytes((string)value), StructuralComparisons.StructuralEqualityComparer);
                }
            }
            else if (original is object[] && value is string)
            {
                //If user try to change structure.
                return string.Compare(GXHelpers.GetArrayAsString(original), Convert.ToString(value)) == 0;
            }
            else if ((original is GXDateTime || original is GXDate || original is GXDate) && value is string)
            {
                //If user try to change structure.
                return string.Compare((original as GXDateTime).ToFormatString(), Convert.ToString(value)) == 0;
            }
            return string.Compare(Convert.ToString(original), Convert.ToString(value)) == 0;
        }

        void textBox1_LostFocus(object sender, EventArgs e)
        {
            try
            {
                if (!ReadOnly && Target != null && !Compare(Target.GetValues()[Index - 1], textBox1.Text))
                {
                    SetDirty(true, textBox1.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SetDirty(bool dirty, object value)
        {
            this.dirty = dirty;
            if (dirty && Index != 0)
            {
                ValueEventArgs v = new ValueEventArgs(Target, Index, 0, null);
                v.User = true;
                DataType dt = Target.GetUIDataType(Index);
                if (dt != DataType.None && dt != DataType.Enum)
                {
                    if (dt == DataType.DateTime)
                    {
                        if (value is string)
                        {
                            value = new GXDateTime((string)value);
                        }
                    }
                    else if (dt == DataType.Date)
                    {
                        if (value is string)
                        {
                            value = new GXDate((string)value);
                        }

                    }
                    else if (dt == DataType.Time)
                    {
                        if (value is string)
                        {
                            value = new GXTime((string)value);
                        }
                    }
                    else
                    {
                        value = Convert.ChangeType(value, GXDLMSConverter.GetDataType(dt));
                    }
                }

                dt = Target.GetDataType(Index);
                if (dt != DataType.None && dt != DataType.Enum && dt != DataType.Array)
                {
                    if (dt == DataType.DateTime && value is string)
                    {
                        value = new GXDateTime((string)value);
                    }
                    else if (dt == DataType.Date && value is string)
                    {
                        value = new GXDate((string)value);
                    }
                    else if (dt == DataType.Time && value is string)
                    {
                        value = new GXTime((string)value);
                    }
                    else if (dt == DataType.OctetString)
                    {
                        if (value is string && Target.GetUIDataType(Index) == DataType.OctetString)
                        {
                            value = GXDLMSTranslator.HexToBytes((string)value);
                        }
                    }
                    else
                    {
                        if (dt != DataType.Structure && dt != DataType.Array && dt != DataType.CompactArray
                            && !(Target is GXDLMSRegister && Index == 2))
                        {
                            value = Convert.ChangeType(value, GXDLMSConverter.GetDataType(dt));
                        }
                    }
                }
                else if (dt == DataType.Array && value is string)
                {
                    value = GXDLMSTranslator.XmlToValue((string)value);
                }
                v.Value = value;
                if (Target.Parent.Parent is GXDLMSClient)
                {
                    (Target as IGXDLMSBase).SetValue((Target.Parent.Parent as GXDLMSClient).Settings, v);
                }
                else if (Target.Parent.Parent is GXDLMSServer)
                {
                    (Target as IGXDLMSBase).SetValue((Target.Parent.Parent as GXDLMSServer).Settings, v);
                }
                else
                {
                    throw new ArgumentNullException("Client or server is not set.");
                }
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
                if (Items != null && Items.Count != 0)
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
                if (this.Type == ValueFieldType.TextBox)
                {
                    this.Type = Items == null || Items.Count == 0 ? ValueFieldType.TextBox : ValueFieldType.CompoBox;
                    textBox1.Multiline = tmp != null && tmp.Type == DataType.Array;
                }
                else if (this.Type == ValueFieldType.CompoBox)
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
                    else if (value is IEnumerable)
                    {
                        foreach (var it in value as IEnumerable)
                        {
                            comboBox1.Items.Add(it);
                        }
                    }
                }
                else if (this.Type == ValueFieldType.ListBox)
                {
                    listBox1.Items.Clear();
                    if (value is Enum)
                    {
                        foreach (var it in Enum.GetValues(value.GetType()))
                        {
                            listBox1.Items.Add(it);
                        }
                    }
                    else if (value is IEnumerable)
                    {
                        foreach (var it in value as IEnumerable)
                        {
                            listBox1.Items.Add(it);
                        }
                    }
                }
                else if (this.Type == ValueFieldType.CheckedListBox)
                {
                    checkedlistBox1.Items.Clear();
                    if (value is Enum)
                    {
                        bool flags = value.GetType().GetCustomAttributes(typeof(FlagsAttribute), true).Length != 0;
                        foreach (var it in Enum.GetValues(value.GetType()))
                        {
                            if ((flags && Convert.ToInt32(it) == 0) ||
                                (it is ClockStatus && ((ClockStatus)it) == ClockStatus.Skip))
                            {
                                continue;
                            }
                            checkedlistBox1.Items.Add(it);
                        }
                    }
                }
            }
        }

        [Browsable(true), DefaultValue(false)]
        public bool ReadOnly
        {
            get
            {
                if (Type == ValueFieldType.TextBox)
                {
                    return this.textBox1.ReadOnly;
                }
                else if (Type == ValueFieldType.CompoBox)
                {
                    return this.comboBox1.Enabled;
                }
                else if (Type == ValueFieldType.ListBox)
                {
                    return this.listBox1.Enabled;
                }
                else if (Type == ValueFieldType.CheckedListBox)
                {
                    return this.checkedlistBox1.Enabled;
                }
                throw new InvalidExpressionException("");
            }
            set
            {
                if (Type == ValueFieldType.TextBox)
                {
                    this.textBox1.ReadOnly = value;
                }
                else if (Type == ValueFieldType.CompoBox)
                {
                    this.comboBox1.Enabled = !value;
                }
                else if (Type == ValueFieldType.ListBox)
                {
                    this.listBox1.Enabled = !value;
                }
                else if (Type == ValueFieldType.CheckedListBox)
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
            if (value != null && !(value is byte[]) && value.GetType().IsArray)
            {
                str = GXDLMSTranslator.ValueToXml(value);
            }
            else
            {
                str = GXHelpers.ConvertDLMS2String(value);
            }
            if (Type == ValueFieldType.TextBox)
            {
                textBox1.LostFocus -= new EventHandler(textBox1_LostFocus);
                this.textBox1.Text = str;
                textBox1.LostFocus += new EventHandler(textBox1_LostFocus);
            }
            else if (Type == ValueFieldType.CompoBox)
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
                        else if (value is IEnumerable)
                        {
                            comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
                            comboBox1.SelectedItem = value;
                            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
                            return;
                        }
                        else
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
            else if (Type == ValueFieldType.ListBox)
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
            else if (Type == ValueFieldType.CheckedListBox)
            {
                if (value is Enum)
                {
                    checkedlistBox1.ItemCheck -= CheckedlistBox1_ItemCheck;
                    //Uncheck all items.
                    for (int pos = 0; pos != checkedlistBox1.Items.Count; ++pos)
                    {
                        checkedlistBox1.SetItemChecked(pos, false);
                    }
                    int v2 = Convert.ToInt32(value);
                    foreach (var it in Enum.GetValues(value.GetType()))
                    {
                        int v = Convert.ToInt32(it);
                        if ((v & v2) != 0 || (v == v2))
                        {
                            int pos = checkedlistBox1.Items.IndexOf(it);
                            if (pos != -1)
                            {
                                checkedlistBox1.SetItemChecked(pos, true);
                            }
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
                if (Type == ValueFieldType.TextBox)
                {
                    return this.textBox1.Text;
                }
                else if (Type == ValueFieldType.CompoBox)
                {
                    return this.comboBox1.SelectedItem;
                }
                else if (Type == ValueFieldType.ListBox)
                {
                    return this.listBox1.Text;
                }
                throw new InvalidExpressionException();
            }
            set
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new UpdateValueEventHandler(OnUpdateValue), value);
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
