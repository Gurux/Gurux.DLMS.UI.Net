//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
//
// Version:         $Revision: 9442 $,
//                  $Date: 2017-05-23 15:21:03 +0300 (ti, 23 touko 2017) $
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

namespace Gurux.DLMS.UI
{
    partial class GXSecuritySetupKeyDlg
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXSecuritySetupKeyDlg));
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.KeyAsciiCb = new System.Windows.Forms.CheckBox();
            this.KeyTb = new System.Windows.Forms.TextBox();
            this.SecurityPolicyLbl = new System.Windows.Forms.Label();
            this.SecurityPolicyTB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KekTb = new System.Windows.Forms.TextBox();
            this.KekAsciiCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OKBtn
            // 
            this.OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(205, 95);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 4;
            this.OKBtn.Text = "&OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(286, 95);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // KeyAsciiCb
            // 
            this.KeyAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyAsciiCb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KeyAsciiCb.Location = new System.Drawing.Point(306, 29);
            this.KeyAsciiCb.Name = "KeyAsciiCb";
            this.KeyAsciiCb.Size = new System.Drawing.Size(63, 24);
            this.KeyAsciiCb.TabIndex = 3;
            this.KeyAsciiCb.Text = "ASCII";
            // 
            // KeyTb
            // 
            this.KeyTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyTb.Location = new System.Drawing.Point(75, 31);
            this.KeyTb.Name = "KeyTb";
            this.KeyTb.Size = new System.Drawing.Size(225, 20);
            this.KeyTb.TabIndex = 2;
            // 
            // SecurityPolicyLbl
            // 
            this.SecurityPolicyLbl.AutoSize = true;
            this.SecurityPolicyLbl.Location = new System.Drawing.Point(12, 7);
            this.SecurityPolicyLbl.Name = "SecurityPolicyLbl";
            this.SecurityPolicyLbl.Size = new System.Drawing.Size(34, 13);
            this.SecurityPolicyLbl.TabIndex = 26;
            this.SecurityPolicyLbl.Text = "Type:";
            // 
            // SecurityPolicyTB
            // 
            this.SecurityPolicyTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecurityPolicyTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecurityPolicyTB.FormattingEnabled = true;
            this.SecurityPolicyTB.Location = new System.Drawing.Point(75, 4);
            this.SecurityPolicyTB.Name = "SecurityPolicyTB";
            this.SecurityPolicyTB.Size = new System.Drawing.Size(225, 21);
            this.SecurityPolicyTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "KEK:";
            // 
            // KekTb
            // 
            this.KekTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KekTb.Location = new System.Drawing.Point(75, 57);
            this.KekTb.Name = "KekTb";
            this.KekTb.Size = new System.Drawing.Size(225, 20);
            this.KekTb.TabIndex = 28;
            this.KekTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // KekAsciiCb
            // 
            this.KekAsciiCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.KekAsciiCb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.KekAsciiCb.Location = new System.Drawing.Point(306, 55);
            this.KekAsciiCb.Name = "KekAsciiCb";
            this.KekAsciiCb.Size = new System.Drawing.Size(63, 24);
            this.KekAsciiCb.TabIndex = 29;
            this.KekAsciiCb.Text = "ASCII";
            // 
            // GXSecuritySetupKeyDlg
            // 
            this.AcceptButton = this.OKBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(373, 130);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KekTb);
            this.Controls.Add(this.KekAsciiCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecurityPolicyTB);
            this.Controls.Add(this.SecurityPolicyLbl);
            this.Controls.Add(this.KeyTb);
            this.Controls.Add(this.KeyAsciiCb);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GXSecuritySetupKeyDlg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Global key editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckBox KeyAsciiCb;
        private System.Windows.Forms.TextBox KeyTb;
        private System.Windows.Forms.Label SecurityPolicyLbl;
        private System.Windows.Forms.ComboBox SecurityPolicyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KekTb;
        private System.Windows.Forms.CheckBox KekAsciiCb;
    }
}