//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXValueField.Designer.cs $
//
// Version:         $Revision: 3170 $,
//                  $Date: 2011-01-10 14:12:35 +0200 (ma, 10 tammi 2011) $
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

namespace Gurux.DLMS.UI
{
    partial class GXValueField
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bitPanel = new System.Windows.Forms.Panel();
            this.checkedlistBox1 = new System.Windows.Forms.CheckedListBox();
            this.bitString = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(194, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 22);
            this.listBox1.TabIndex = 0;
            this.listBox1.Visible = false;
            // 
            // bitPanel
            // 
            this.bitPanel.Location = new System.Drawing.Point(0, 0);
            this.bitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bitPanel.Name = "bitPanel";
            this.bitPanel.Size = new System.Drawing.Size(194, 20);
            this.bitPanel.TabIndex = 3;

            // 
            // bitstring
            // 
            this.bitString.Location = new System.Drawing.Point(0, 0);
            this.bitString.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bitString.Name = "bitstring";
            this.bitString.Size = new System.Drawing.Size(194, 20);
            this.bitString.TabIndex = 3;
            // 
            // checkedlistBox1
            // 
            this.checkedlistBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedlistBox1.FormattingEnabled = true;
            this.checkedlistBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedlistBox1.Name = "checkedlistBox1";
            this.checkedlistBox1.Size = new System.Drawing.Size(194, 22);
            this.checkedlistBox1.TabIndex = 0;
            this.checkedlistBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(194, 22);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            this.dataGridView1.CellParsing += DataGridView1_CellParsing;
            this.dataGridView1.RowsRemoved += DataGridView1_RowsRemoved;
            this.dataGridView1.RowsAdded += DataGridView1_RowsAdded;
            dataGridView1.DataError += DataGridView1_DataError;

            this.bitPanel.Controls.Add(this.checkedlistBox1);
            this.bitPanel.Controls.Add(this.bitString);
            // 
            // GXValueField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bitPanel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GXValueField";
            this.Size = new System.Drawing.Size(194, 22);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel bitPanel;
        private System.Windows.Forms.Label bitString;
        private System.Windows.Forms.CheckedListBox checkedlistBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
