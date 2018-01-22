//
// --------------------------------------------------------------------------
//  Gurux Ltd
//
//
//
// Filename:        $HeadURL: svn://mars/Projects/GuruxClub/GXDLMSDirector/Development/Views/GXDLMSImageTransferView.cs $
//
// Version:         $Revision: 5795 $,
//                  $Date: 2012-10-02 13:22:54 +0300 (ti, 02 loka 2012) $
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
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Reflection;
using System.IO;

namespace Gurux.DLMS.UI
{
    [GXDLMSViewAttribute(typeof(GXDLMSImageTransfer))]
    public partial class GXDLMSImageTransferView : Form, IGXDLMSView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSImageTransferView()
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
            GXDLMSImageTransfer target = Target as GXDLMSImageTransfer;
            if (index == 5)
            {
                ImageTransferEnabledCB.CheckedChanged -= new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);
                ImageTransferEnabledCB.Checked = target.ImageTransferEnabled;
                ImageTransferEnabledCB.CheckedChanged += new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);
            }
            else if (index == 7)
            {
                ImagesView.Items.Clear();
                if (target.ImageActivateInfo != null)
                {
                    foreach (GXDLMSImageActivateInfo it in target.ImageActivateInfo)
                    {
                        ListViewItem li = ImagesView.Items.Add(it.Size.ToString());
                        li.SubItems.Add(it.Identification);
                        li.SubItems.Add(it.Signature);
                        li.Tag = it;
                    }
                }
            }
            else if (index != 0)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        string imageIdentifier;
        byte[] image;

        public ActionType PreAction(GXDLMSClient client, ActionType type, ValueEventArgs arg)
        {
            GXDLMSImageTransfer it = Target as GXDLMSImageTransfer;
            if (type == ActionType.Read)
            {
                if (arg.Index == 5)
                {
                    DescriptionList.Items.Clear();
                    GXImageDlg dlg = new GXImageDlg();
                    if (dlg.ShowDialog(this) != DialogResult.OK)
                    {
                        return ActionType.None;
                    }
                    imageIdentifier = dlg.TextTb.Text;
                    image = dlg.Image;
                    DescriptionList.Items.Add("Updating image" + imageIdentifier);
                }
            }
            else if (type == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    //Initiate the Image transfer process.
                    arg.Value = it.ImageTransferInitiate(client, imageIdentifier, image.Length);
                }
                else if (arg.Index == 2)
                {
                    //Start image block transfer.
                    int imageBlockCount;
                    arg.Value = it.ImageBlockTransfer(client, image, out imageBlockCount);
                    DescriptionList.Items.Add("Sending " + imageBlockCount + " blocks.");
                }
                else if (arg.Index == 3)
                {
                    arg.Value = it.ImageVerify(client);
                    DescriptionList.Items.Add("Verify image.");
                }
                else if (arg.Index == 4)
                {
                    arg.Value = it.ImageActivate(client);
                    DescriptionList.Items.Add("Activating image.");
                }
            }
            return type;
        }

        public ActionType PostAction(ActionType type, ValueEventArgs arg)
        {
            GXDLMSImageTransfer it = Target as GXDLMSImageTransfer;
            if (type == ActionType.Read)
            {
                if (arg.Index == 5)
                {
                    if (!it.ImageTransferEnabled)
                    {
                        MessageBox.Show(this, "Image transfer is not enabled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return ActionType.None;
                    }
                    DescriptionList.Items.Add("Image transfer is enabled.");
                    //Get ImageBlockSize. 
                    arg.Index = 2;
                }
                else if (arg.Index == 2)
                {
                    DescriptionList.Items.Add("Image block size:" + it.ImageBlockSize);
                    //Invoke Initiates image transfer. 
                    arg.Index = 1;
                    type = ActionType.Action;
                }
            }
            else if (type == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    DescriptionList.Items.Add("Image transfer initiated.");
                    arg.Index = 2;
                }
                else if (arg.Index == 2)
                {
                    DescriptionList.Items.Add("Image transfered.");
                    arg.Index = 3;
                }
                else if (arg.Index == 3)
                {
                    DescriptionList.Items.Add("Image verified.");
                    arg.Index = 4;
                }
                else if (arg.Index == 4)
                {
                    DescriptionList.Items.Add(Properties.Resources.ImageActivatedTxt);
                    MessageBox.Show(this, Properties.Resources.ImageActivatedTxt, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    type = ActionType.None;
                }
            }
            return type;
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
            if (Dirty && index == 2)
            {
                errorProvider1.SetError(ImageBlockSizeTB, Properties.Resources.ValueChangedTxt);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        public void OnAccessRightsChange(int index, AccessMode access, bool connected)
        {
            if (index == 5)
            {
                ImageTransferEnabledCB.Enabled = connected && (Target.GetAccess(index) & AccessMode.Write) != 0;
            }
            else if (index == 7)
            {
                ImagesView.Enabled = connected && (Target.GetAccess(index) & AccessMode.Write) != 0;
            }
            else
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
            if (index == 1)
            {
                UpdateImageBtn.Enabled = mode != MethodAccessMode.NoAccess;
            }
        }

        #endregion

        private void ValueTB_KeyUp(object sender, KeyEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void ValueTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider1.SetError((Control)sender, Properties.Resources.ValueChangedTxt);
        }

        private void ImageTransferEnabledCB_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ImageTransferEnabledCB.Checked;
            (Target as GXDLMSImageTransfer).ImageTransferEnabled = check;
            Target.UpdateDirty(5, check);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateImageBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
