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

    public partial class GXValueField : UserControl
    {
        bool dirty;
        ValueFieldType type;
        List<GXObisValueItem> Items;
        ToolStripMenuItem undo, cut, copy, paste;

        /// <summary>
        /// Default value field type.
        /// </summary>
        internal ValueFieldType DefaultType
        {
            get; set;
        }

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
                else if (Type == ValueFieldType.Xml)
                {
                    dataGridView1.CellValueChanged -= OnCellValueChanged;
                }
                type = value;
                textBox1.Visible = type == ValueFieldType.TextBox;
                comboBox1.Visible = type == ValueFieldType.CompoBox;
                listBox1.Visible = type == ValueFieldType.ListBox;
                bitPanel.Visible = checkedlistBox1.Visible = type == ValueFieldType.CheckedListBox;
                dataGridView1.Visible = type == ValueFieldType.Xml;
                if (Type == ValueFieldType.CompoBox)
                {
                    comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
                }
                else if (Type == ValueFieldType.CheckedListBox)
                {
                    checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                }
                else if (Type == ValueFieldType.Xml)
                {
                    dataGridView1.CellValueChanged += OnCellValueChanged;
                }
            }
        }

        /// <summary>
        /// User adds new row.
        /// </summary>
        private void DataGridView1_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
        {
            if (dataGridView1.DataSource != null && dataGridView1.RowCount != 0)
            {
                OnCellValueChanged(null, new DataGridViewCellEventArgs(0, e.RowIndex));
            }
        }

        /// <summary>
        /// User removes selected rows from the data grid.
        /// </summary>
        private void DataGridView1_RowsRemoved(object sender, System.Windows.Forms.DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                OnCellValueChanged(null, new DataGridViewCellEventArgs(0, e.RowIndex));
            }
        }

        private void DataGridView1_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(this, e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.Cancel = true;
        }


        /// <summary>
        /// User modifies data grid cell.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<Array>");
                //Add new rows.
                bool structure = dataGridView1.Columns.Count > 1;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    if (r.DataBoundItem != null)
                    {
                        DataRow row = ((DataRowView)r.DataBoundItem).Row;
                        if (structure)
                        {
                            sb.AppendLine("<Structure>");
                        }
                        int pos = 0;
                        foreach (object it in row.ItemArray)
                        {
                            DataType type = dataTypes[pos];
                            ++pos;
                            sb.Append("<" + type);
                            if (it is LogicalName)
                            {
                                sb.AppendLine(" Value=\"" + GXDLMSTranslator.ToHex(GXDLMSConverter.LogicalNameToBytes(it.ToString())) + "\" />");
                            }
                            if (it is byte[])
                            {
                                sb.AppendLine(" Value=\"" + GXDLMSTranslator.ToHex((byte[])it) + "\" />");
                            }
                            else
                            {
                                sb.AppendLine(" Value=\"" + it + "\" />");
                            }
                        }
                        if (structure)
                        {
                            sb.AppendLine("</Structure>");
                        }
                    }
                    else if (dataGridView1.Rows.Count == 1)
                    {
                        return;
                    }
                }
                sb.AppendLine("</Array>");
                try
                {
                    SetDirty(true, sb.ToString());

                }
                catch (FormatException)
                {
                    //User has not set all the fields.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckedlistBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int value = 0;
            foreach (object it in checkedlistBox1.Items)
            {
                if (it is GXObisValueItem)
                {
                    if ((it as GXObisValueItem).MaskSize != 0)
                    {
                        value |= Convert.ToInt32(((GXObisValueItem)it).Value);
                    }
                    else
                    {
                        value |= 1 << Convert.ToInt32(((GXObisValueItem)it).Value);
                    }
                }
                else
                {
                    value |= Convert.ToInt32(it);
                }
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
            else if ((original is object[] || original is List<object>) && value is string)
            {
                //If user try to change structure.
                return string.Compare(GXDLMSTranslator.ValueToXml(original), Convert.ToString(value)) == 0;
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
                    else if (dt == DataType.OctetString)
                    {
                        if (value is string)
                        {
                            value = GXDLMSTranslator.HexToBytes((string)value);
                        }
                    }
                    else
                    {
                        value = Convert.ChangeType(value, GXDLMSConverter.GetDataType(dt));
                    }
                }
                dt = Target.GetDataType(Index);
                if (dt != DataType.None && dt != DataType.Enum && dt != DataType.Array && dt != DataType.Structure)
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
                        DataType ui = Target.GetUIDataType(Index);
                        if (value is string && (ui == DataType.OctetString) || ui == DataType.None)
                        {
                            value = GXDLMSTranslator.HexToBytes((string)value);
                        }
                    }
                    else
                    {
                        if (dt != DataType.Structure && dt != DataType.Array && dt != DataType.CompactArray &&
                            dt != DataType.DateTime && dt != DataType.Date && dt != DataType.Time
                            && !(Target is GXDLMSRegister && Index == 2) &&
                                            !(Target is GXDLMSIp4Setup) && !(Target is GXDLMSIp6Setup))
                        {
                            value = Convert.ChangeType(value, GXDLMSConverter.GetDataType(dt));
                        }
                    }
                }
                else if ((dt == DataType.Array || dt == DataType.Structure) && value is string)
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
                    (Target as IGXDLMSBase).SetValue(new GXDLMSSettings(), v);
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
                GXDLMSAttributeSettings att = target.Attributes.Find(index);
                if ((att != null && att.UIValueType == ValueFieldType.TextBox) && Items != null && Items.Count != 0)
                {
                    Type = ValueFieldType.CheckedListBox;
                }
                else
                {
                    if (att != null && DefaultType == ValueFieldType.TextBox)
                    {
                        if (Type != att.UIValueType)
                        {
                            Type = att.UIValueType;
                        }
                    }
                    else
                    {
                        Type = DefaultType;
                    }
                }
                if (type == ValueFieldType.TextBox)
                {
                    //DataGridView
                    if (att != null && !string.IsNullOrEmpty(att.Xml))
                    {
                        this.Type = ValueFieldType.Xml;
                    }
                    else
                    {
                        this.Type = (Items == null || (att != null && att.Type == DataType.BitString) || Items.Count == 0) ? ValueFieldType.TextBox : ValueFieldType.CompoBox;
                        textBox1.Multiline = tmp != null && (tmp.Type == DataType.Array || tmp.Type == DataType.Structure);
                    }
                }
                if (type == ValueFieldType.CompoBox)
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
                else if (type == ValueFieldType.ListBox)
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
                else if (type == ValueFieldType.CheckedListBox)
                {
                    checkedlistBox1.Items.Clear();
                }
                else if (type == ValueFieldType.Xml)
                {
                    if (att == null || string.IsNullOrEmpty(att.Xml))
                    {
                        this.Type = ValueFieldType.TextBox;
                        UpdateValueItems(target, index, value);
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
                    return !this.comboBox1.Enabled;
                }
                else if (Type == ValueFieldType.ListBox)
                {
                    return !this.listBox1.Enabled;
                }
                else if (Type == ValueFieldType.CheckedListBox)
                {
                    return !this.checkedlistBox1.Enabled;
                }
                else if (Type == ValueFieldType.Xml)
                {
                    return this.dataGridView1.ReadOnly;
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
                else if (Type == ValueFieldType.Xml)
                {
                    this.dataGridView1.ReadOnly = value;
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
            string str = "";
            if (Type != ValueFieldType.Xml)
            {
                if (value is GXArray || value is GXStructure)
                {
                    str = GXDLMSTranslator.ValueToXml(value);
                }
                else
                {
                    str = GXHelpers.ConvertDLMS2String(value);
                }
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
                checkedlistBox1.Items.Clear();
                if (value is Enum)
                {
                    bitString.Visible = false;
                    checkedlistBox1.ItemCheck -= CheckedlistBox1_ItemCheck;
                    bool flags = value.GetType().GetCustomAttributes(typeof(FlagsAttribute), true).Length != 0;
                    int v2 = Convert.ToInt32(value);
                    foreach (var it in Enum.GetValues(value.GetType()))
                    {
                        if ((flags && Convert.ToInt32(it) == 0) ||
                            (it is ClockStatus && ((ClockStatus)it) == ClockStatus.Skip))
                        {
                            continue;
                        }
                        int v = Convert.ToInt32(it);
                        int pos = checkedlistBox1.Items.Add(it);
                        if ((v & v2) != 0 || (v == v2))
                        {
                            checkedlistBox1.SetItemChecked(pos, true);
                        }
                    }
                    checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                    return;
                }
                else
                {
                    bitString.Visible = true;
                    //List of bit intexes.
                    Dictionary<int, int> bitIndexes = new Dictionary<int, int>();
                    if (Items != null && Items.Count != 0)
                    {
                        foreach (GXObisValueItem it in Items)
                        {
                            bitIndexes.Add(it.Value, checkedlistBox1.Items.Add(it));
                        }
                    }
                    bitString.Text = "";
                    if (value is GXBitString)
                    {
                        value = value.ToString();
                        bitString.Text = (string)value;
                        int pos;
                        checkedlistBox1.ItemCheck -= CheckedlistBox1_ItemCheck;
                        //Uncheck all items.
                        for (pos = 0; pos != checkedlistBox1.Items.Count; ++pos)
                        {
                            checkedlistBox1.SetItemChecked(pos, false);
                        }
                        int cnt = checkedlistBox1.Items.Count;
                        if (((string)value).Length < cnt)
                        {
                            cnt = ((string)value).Length;
                        }
                        pos = 0;
                        foreach (char it in (string)value)
                        {
                            if (it == '1')
                            {
                                if (bitIndexes.ContainsKey(pos))
                                {
                                    checkedlistBox1.SetItemChecked(bitIndexes[pos], true);
                                }
                            }
                            ++pos;
                        }
                        checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                    }
                    else if (IsNumeric(value))
                    {
                        checkedlistBox1.ItemCheck -= CheckedlistBox1_ItemCheck;
                        //Uncheck all items.
                        int pos = 0;
                        for (pos = 0; pos != checkedlistBox1.Items.Count; ++pos)
                        {
                            checkedlistBox1.SetItemChecked(pos, false);
                        }
                        bool c;
                        long v2 = Convert.ToInt64(value);
                        for (pos = 0; pos != checkedlistBox1.Items.Count; ++pos)
                        {
                            GXObisValueItem it = (GXObisValueItem)checkedlistBox1.Items[pos];
                            c = ((v2 & it.Value) == it.Value);
                            checkedlistBox1.SetItemChecked(pos, c);
                        }
                        checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                        return;
                    }
                    else if (value is byte[])
                    {
                        GXByteBuffer bb = new GXByteBuffer();
                        bb.SetUInt8((byte)(8 * (value as byte[]).Length));
                        bb.Set(value as byte[]);
                        GXBitString bs = (GXBitString)GXDLMSClient.ChangeType(bb, DataType.BitString, false);
                        checkedlistBox1.ItemCheck -= CheckedlistBox1_ItemCheck;
                        //Uncheck all items.
                        int pos = 0;
                        for (pos = 0; pos != checkedlistBox1.Items.Count; ++pos)
                        {
                            checkedlistBox1.SetItemChecked(pos, false);
                        }
                        bool c;
                        for (pos = 0; pos != checkedlistBox1.Items.Count; ++pos)
                        {
                            GXObisValueItem it = (GXObisValueItem)checkedlistBox1.Items[pos];
                            if (it.MaskSize != 0)
                            {
                                string tmp = bs.Value.Substring(it.Shift, it.MaskSize);
                                GXBitString bb2 = new GXBitString(tmp);
                                c = Convert.ToInt32(bb2) == it.Value;
                            }
                            else
                            {
                                c = bs.Value[it.Value] == '1';
                            }
                            checkedlistBox1.SetItemChecked(pos, c);
                        }
                        checkedlistBox1.ItemCheck += CheckedlistBox1_ItemCheck;
                        return;
                    }
                }
            }
            else if (Type == ValueFieldType.Xml)
            {
                this.dataGridView1.RowsRemoved -= DataGridView1_RowsRemoved;
                this.dataGridView1.Columns.Clear();
                this.dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
                this.dataGridView1.RowsAdded -= DataGridView1_RowsAdded;
                string schema = Target.Attributes.Find(Index).Xml;
                dataTypes.Clear();
                if (schema != null)
                {
                    DataTable dt = new DataTable();
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(schema);
                    XmlNodeList list = doc.ChildNodes;
                    if (list.Count != 0)
                    {
                        if (list[0].Name == "Array")
                        {
                            list = list[0].ChildNodes;
                        }
                        //There is only one row.
                        if (list[0].Name == "Structure")
                        {
                            list = list[0].ChildNodes;
                        }
                    }
                    List<object> row = new List<object>();
                    int index = 0;
                    foreach (XmlNode it in list)
                    {
                        XmlNode name = it.Attributes.GetNamedItem("Name");
                        if (name != null)
                        {
                            XmlNode uiType = it.Attributes.GetNamedItem("UIType");
                            DataColumn dc = dt.Columns.Add(index.ToString());
                            DataType t = (DataType)Enum.Parse(typeof(DataType), it.Name);
                            dataTypes.Add(t);
                            if (t == DataType.Enum)
                            {
                                t = DataType.UInt8;
                            }
                            dc.DataType = GXDLMSConverter.GetDataType(t);
                            dc.Caption = name.InnerText;
                            if (uiType != null)
                            {
                                if (string.Compare(uiType.Value, "LogicalName", true) == 0)
                                {
                                    dc.DataType = typeof(LogicalName);
                                    dataGridView1.Columns.Add(index.ToString(), dc.Caption);
                                    dataGridView1.Columns[index].DataPropertyName = index.ToString();
                                }
                                else if (string.Compare(uiType.Value, "Enum", true) == 0)
                                {
                                    dc.DataType = typeof(LogicalName);
                                    dataGridView1.Columns.Add(index.ToString(), dc.Caption);
                                    dataGridView1.Columns[index].DataPropertyName = index.ToString();
                                }
                                else
                                {
                                    Type type = typeof(GXDLMSClient).Assembly.GetType(uiType.Value);
                                    if (type == null)
                                    {
                                        throw new ArgumentOutOfRangeException("Invalid UI type:" + uiType.Value);
                                    }
                                    dc.DataType = type;
                                    dataGridView1.Columns.Add(index.ToString(), dc.Caption);
                                    dataGridView1.Columns[index].DataPropertyName = index.ToString();
                                }
                            }
                            else
                            {
                                dataGridView1.Columns.Add(index.ToString(), dc.Caption);
                                dataGridView1.Columns[index].DataPropertyName = index.ToString();
                            }
                            ++index;
                        }
                    }
                    if (value != null)
                    {
                        value = GXDLMSTranslator.ValueToXml(value);
                        doc.LoadXml((string)value);
                        list = doc.ChildNodes;
                        if (list.Count != 0)
                        {
                            if (list[0].Name == "Array")
                            {
                                foreach (XmlNode r in list[0].ChildNodes)
                                {
                                    if (r.Name == "Structure")
                                    {
                                        row = new List<object>();
                                        index = 0;
                                        foreach (XmlNode it in r.ChildNodes)
                                        {
                                            XmlNode v = it.Attributes.GetNamedItem("Value");
                                            if (v != null)
                                            {
                                                DataColumn dc = dt.Columns[index];
                                                if (dc.DataType == typeof(byte[]))
                                                {
                                                    row.Add(GXDLMSTranslator.HexToBytes(v.InnerText));
                                                }
                                                else if (dc.DataType.IsEnum)
                                                {
                                                    row.Add(Enum.Parse(dc.DataType, v.InnerText));
                                                }
                                                else if (dc.DataType == typeof(LogicalName))
                                                {
                                                    row.Add(new LogicalName(GXDLMSConverter.ToLogicalName(GXDLMSTranslator.HexToBytes(v.InnerText))));
                                                }
                                                else
                                                {
                                                    row.Add(Convert.ChangeType(v.InnerText, dc.DataType));
                                                }
                                            }
                                            else
                                            {
                                                row.Add(null);
                                            }
                                            ++index;
                                        }
                                        dt.LoadDataRow(row.ToArray(), true);
                                    }
                                }
                            }
                            //There is only one row.
                            if (list[0].Name == "Structure")
                            {
                                row = new List<object>();
                                index = 0;
                                foreach (XmlNode it in list[0].ChildNodes)
                                {
                                    XmlNode v = it.Attributes.GetNamedItem("Value");
                                    if (v != null)
                                    {
                                        DataColumn dc = dt.Columns[index];
                                        if (dc.DataType == typeof(byte[]))
                                        {
                                            row.Add(GXDLMSTranslator.HexToBytes(v.InnerText));
                                        }
                                        else if (dc.DataType.IsEnum)
                                        {
                                            row.Add(Enum.Parse(dc.DataType, v.InnerText));
                                        }
                                        else if (dc.DataType == typeof(LogicalName))
                                        {
                                            row.Add(new LogicalName(GXDLMSConverter.ToLogicalName(GXDLMSTranslator.HexToBytes(v.InnerText))));
                                        }
                                        else
                                        {
                                            row.Add(Convert.ChangeType(v.InnerText, dc.DataType));
                                        }
                                    }
                                    else
                                    {
                                        row.Add(null);
                                    }
                                    ++index;
                                }
                                dt.LoadDataRow(row.ToArray(), true);
                            }
                        }
                    }
                    this.dataGridView1.DataSource = dt;
                }
                else
                {
                    this.dataGridView1.DataSource = null;
                }
                this.dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            }
            else
            {
                throw new InvalidExpressionException();
            }
        }

        private static bool IsNumeric(object value)
        {
            if (value == null)
            {
                return false;
            }
            Type tp = value.GetType();
            if (tp == typeof(Int16) ||
                tp == typeof(Int32) ||
                tp == typeof(Int64) ||
                tp == typeof(sbyte) ||
                tp == typeof(UInt16) ||
                tp == typeof(UInt32) ||
                tp == typeof(UInt64) ||
                tp == typeof(byte))
                return true;
            return false;
        }

        List<DataType> dataTypes = new List<DataType>();

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is byte[])
            {
                e.Value = GXDLMSTranslator.ToHex((byte[])e.Value);
                e.FormattingApplied = true;
            }
            else
            {
                e.FormattingApplied = false;
            }
        }

        private void DataGridView1_CellParsing(object sender, System.Windows.Forms.DataGridViewCellParsingEventArgs e)
        {
            try
            {
                if (e.Value is string && e.DesiredType == typeof(byte[]))
                {
                    e.Value = GXDLMSTranslator.HexToBytes((string)e.Value);
                    e.ParsingApplied = true;
                }
                else if (e.Value is string && e.DesiredType == typeof(LogicalName))
                {
                    string tmp = (string)e.Value;
                    e.Value = new LogicalName(tmp);
                    e.ParsingApplied = true;
                    //Verify LN.
                    GXDLMSConverter.LogicalNameToBytes(tmp);
                }
                else
                {
                    e.ParsingApplied = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        DataGridViewComboBoxColumn CreateUITypeColumn(Type type, string name, string caption)
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Enum.GetValues(type);
            combo.DataPropertyName = name;
            combo.Name = caption;
            combo.ValueType = type;
            return combo;
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
                else if (Type == ValueFieldType.Xml)
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
