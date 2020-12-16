//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSIecTwistedPairSetupView.cs $
//
// Version:         $Revision: 8933 $,
//                  $Date: 2016-11-23 09:20:07 +0200 (ke, 23 marras 2016) $
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
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Collections.Generic;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSIecTwistedPairSetup
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSIecTwistedPairSetup))]
    partial class GXDLMSIecTwistedPairSetupView : Form, IGXDLMSView
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSIecTwistedPairSetupView()
        {
            InitializeComponent();
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSIecTwistedPairSetup target = Target as GXDLMSIecTwistedPairSetup;
            if (index == 4)
            {
                PrimaryAddressesList.Items.Clear();
                if (target.PrimaryAddresses != null)
                {
                    foreach (byte it in target.PrimaryAddresses)
                    {
                        PrimaryAddressesList.Items.Add(it.ToString());
                    }
                }
            }
            else if (index == 5)
            {
                TabisList.Items.Clear();
                if (target.Tabis != null)
                {
                    foreach (byte it in target.Tabis)
                    {
                        TabisList.Items.Add(it.ToString());
                    }
                }
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void PreAction(GXActionArgs arg)
        {
        }

        public void PostAction(GXActionArgs arg)
        {
            arg.Action = ActionType.None;
        }

        public System.Windows.Forms.ErrorProvider ErrorProvider
        {
            get
            {
                return errorProvider1;
            }
        }

        public string Description
        {
            get
            {
                return DescriptionTB.Text;
            }
            set
            {
                DescriptionTB.Text = value;
            }
        }

        public void OnDirtyChange(int index, bool Dirty)
        {
            if (Dirty && index == 4)
            {
                errorProvider1.SetError(PrimaryAddressesList, Properties.Resources.ValueChangedTxt);
            }
            else if (Dirty && index == 5)
            {
                errorProvider1.SetError(TabisList, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index != 4 && index != 5)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
        }
        #endregion

        /// <summary>
        /// Add primary addresses.
        /// </summary>
        private void PrimaryAddressesAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIecTwistedPairSetup target = Target as GXDLMSIecTwistedPairSetup;
                List<byte> addresses = new List<byte>();
                if (target.PrimaryAddresses != null)
                {
                    addresses.AddRange(target.PrimaryAddresses);
                }
                GXTextDlg dlg = new GXTextDlg("Primary Address", "Primary Address", "", typeof(byte));
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    byte tmp = byte.Parse(dlg.GetValue());
                    ListViewItem li = PrimaryAddressesList.Items.Add(tmp.ToString());
                    addresses.Add(tmp);
                    errorProvider1.SetError(PrimaryAddressesList, Properties.Resources.ValueChangedTxt);
                    target.PrimaryAddresses = addresses.ToArray();
                    Target.UpdateDirty(4, target.PrimaryAddresses);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit primary addresses.
        /// </summary>
        private void PrimaryAddressesEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (PrimaryAddressesList.SelectedItems.Count == 1)
                {
                    GXDLMSIecTwistedPairSetup target = Target as GXDLMSIecTwistedPairSetup;
                    List<string> entries = new List<string>();
                    List<byte> addresses = new List<byte>();
                    if (target.PrimaryAddresses != null)
                    {
                        addresses.AddRange(target.PrimaryAddresses);
                    }
                    ListViewItem li = PrimaryAddressesList.SelectedItems[0];
                    GXTextDlg dlg = new GXTextDlg("Primary Address", "Primary Address", li.Text, typeof(byte));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        string tmp = dlg.GetValue();
                        int pos = PrimaryAddressesList.SelectedIndices[0];
                        li.SubItems[0].Text = tmp;
                        entries.RemoveAt(pos);
                        entries.Insert(pos, tmp);
                        errorProvider1.SetError(PrimaryAddressesList, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(4, target.PrimaryAddresses);
                        target.PrimaryAddresses = addresses.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove primary addresses.
        /// </summary>
        private void PrimaryAddressesRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIecTwistedPairSetup target = Target as GXDLMSIecTwistedPairSetup;
                List<byte> addresses = new List<byte>();
                if (target.PrimaryAddresses != null)
                {
                    addresses.AddRange(target.PrimaryAddresses);
                }
                while (PrimaryAddressesList.SelectedItems.Count != 0)
                {
                    string item = PrimaryAddressesList.SelectedItems[0].Text;
                    PrimaryAddressesList.Items.Remove(PrimaryAddressesList.SelectedItems[0]);
                    errorProvider1.SetError(PrimaryAddressesList, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(4, target.PrimaryAddresses);
                    addresses.Remove(byte.Parse(item));
                }
                target.PrimaryAddresses = addresses.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Add TAB(i).
        /// </summary>
        private void TabisAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIecTwistedPairSetup target = Target as GXDLMSIecTwistedPairSetup;
                List<sbyte> tabis = new List<sbyte>();
                if (target.Tabis != null)
                {
                    tabis.AddRange(target.Tabis);
                }
                GXTextDlg dlg = new GXTextDlg("TAB(i)", "TAB(i)", "", typeof(sbyte));
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    string tmp = dlg.GetValue();
                    ListViewItem li = TabisList.Items.Add(tmp);
                    tabis.Add(sbyte.Parse(tmp));
                    errorProvider1.SetError(TabisList, Properties.Resources.ValueChangedTxt);
                    target.Tabis = tabis.ToArray();
                    Target.UpdateDirty(5, target.Tabis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Edit TAB(i).
        /// </summary>
        private void TabisEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TabisList.SelectedItems.Count == 1)
                {
                    GXDLMSIecTwistedPairSetup target = Target as GXDLMSIecTwistedPairSetup;
                    List<sbyte> tabis = new List<sbyte>();
                    if (target.Tabis != null)
                    {
                        tabis.AddRange(target.Tabis);
                    }
                    ListViewItem li = TabisList.SelectedItems[0];
                    GXTextDlg dlg = new GXTextDlg("TAB(i)", "TAB(i)", li.Text, typeof(sbyte));
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        string tmp = dlg.GetValue();
                        int pos = TabisList.SelectedIndices[0];
                        li.SubItems[0].Text = tmp;
                        tabis.RemoveAt(pos);
                        tabis.Insert(pos, sbyte.Parse(tmp));
                        errorProvider1.SetError(TabisList, Properties.Resources.ValueChangedTxt);
                        Target.UpdateDirty(5, target.Tabis);
                        target.Tabis = tabis.ToArray();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remove TAB(i).
        /// </summary>
        private void TabisRemoveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                GXDLMSIecTwistedPairSetup target = Target as GXDLMSIecTwistedPairSetup;
                List<sbyte> tabis = new List<sbyte>();
                if (target.Tabis != null)
                {
                    tabis.AddRange(target.Tabis);
                }
                while (TabisList.SelectedItems.Count != 0)
                {
                    string item = TabisList.SelectedItems[0].Text;
                    TabisList.Items.Remove(TabisList.SelectedItems[0]);
                    errorProvider1.SetError(TabisList, Properties.Resources.ValueChangedTxt);
                    Target.UpdateDirty(5, target.Tabis);
                    tabis.Remove(sbyte.Parse(item));
                }
                target.Tabis = tabis.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
