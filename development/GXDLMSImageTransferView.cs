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
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS;
using Gurux.DLMS.Enums;
using System.Reflection;

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

        public void OnValueChanged(int index, object value, bool user)
        {
            if (index == 5)
            {
                GXDLMSImageTransfer target = Target as GXDLMSImageTransfer;
                ImageTransferEnabledCB.CheckedChanged -= new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);
                this.ImageTransferEnabledCB.Checked = target.ImageTransferEnabled;
                ImageTransferEnabledCB.CheckedChanged += new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);

            }
            else if (index != 0)
            {
                throw new IndexOutOfRangeException("index");
            }
        }


        public void PreAction(ActionType type, ValueEventArgs arg)
        {
            GXDLMSImageTransfer it = Target as GXDLMSImageTransfer;
            MethodInfo clickMethodInfo = typeof(Button).GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
            if (type == ActionType.Read && arg.Index == 5)
            {
                //Do nothing. 
            }
            else
            {
                if (type == ActionType.Action && arg.Index == -1)
                {
                    arg.Handled = true;
                    DescriptionList.Items.Clear();
                    //Show file dlg and imageIdentifier.
                    //Check is image transfer enabled.
                    clickMethodInfo.Invoke(ImageTransferEnabledBtn, new object[] { EventArgs.Empty });
                }
                if (type == ActionType.Action && arg.Index == 1)
                {
                    string imageIdentifier = "gurux";
                    //Initiate the Image transfer process.
                    GXByteBuffer data = new GXByteBuffer();
                    data.SetUInt8((byte)DataType.Structure);
                    data.SetUInt8((byte)2);
                    data.SetUInt8((byte)DataType.OctetString);
                    data.SetUInt8((byte)imageIdentifier.Length);
                    data.Set(ASCIIEncoding.ASCII.GetBytes(imageIdentifier));
                    data.SetUInt8((byte)DataType.UInt32);
                    data.SetUInt32(it.ImageSize);
                    arg.Value = data.Array();
                }
                if (type == ActionType.Action && arg.Index == 2)
                {
                    //Start image block transfer.
                }
            }
        }

        public void PostAction(ActionType type, ValueEventArgs arg)
        {
            GXDLMSImageTransfer it = Target as GXDLMSImageTransfer;
            MethodInfo clickMethodInfo = typeof(Button).GetMethod("OnClick", BindingFlags.NonPublic | BindingFlags.Instance);
            if (type == ActionType.Read && arg.Index == 5)
            {
                if (!it.ImageTransferEnabled)
                {
                    MessageBox.Show(this, "Image transfer is not enabled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DescriptionList.Items.Add("Image transfer is enabled.");
                //Get ImageBlockSize. 
                clickMethodInfo.Invoke(GetImageBlockSizeBtn, new object[] { EventArgs.Empty });
            }
            if (type == ActionType.Read && arg.Index == 2)
            {
                //Invoke Initiates image transfer. 
                clickMethodInfo.Invoke(InitiatesImageTransferBtn, new object[] { EventArgs.Empty });
            }
            if (type == ActionType.Action && arg.Index == 1)
            {
                //Start image block transfer.
                clickMethodInfo.Invoke(TransfersImageBlocksBtn, new object[] { EventArgs.Empty });
            }
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

        public void OnAccessRightsChange(int index, AccessMode access)
        {
            //throw new IndexOutOfRangeException("index");
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode)
        {
            if (index == 1)
            {
               UpdateImageBtn.Enabled = mode != MethodAccessMode.NoAccess;
            }
            UpdateImageBtn.Enabled = false;
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
    }
}
