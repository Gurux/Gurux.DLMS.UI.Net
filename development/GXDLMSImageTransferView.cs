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
// More information of Gurux DLMS/COSEM Director: https://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2.
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Text;
using System.IO;
using System.Threading;
using Gurux.DLMS.Objects.Enums;
using Gurux.DLMS.ManufacturerSettings;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// https://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSImageTransfer
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSImageTransfer))]
    public partial class GXDLMSImageTransferView : Form, IGXDLMSView
    {
        /// <summary>
        /// Is verify allowed.
        /// </summary>
        bool VerifyAllowed = false;
        /// <summary>
        /// Is activation allowed.
        /// </summary>
        bool ActivationAllowed = false;

        /// <summary>
        /// Constructor.
        /// </summary>
        public GXDLMSImageTransferView()
        {
            InitializeComponent();
            DelayTb.Text = new TimeSpan(Properties.Settings.Default.ImageDelay * 10000000).ToString(@"hh\:mm\:ss");
            ManualBtn.Checked = Properties.Settings.Default.ImageManualUpdate;
        }

        #region IGXDLMSView Members

        public GXDLMSObject Target
        {
            get;
            set;
        }

        public void OnValueChanged(GXDLMSViewArguments arg)
        {
            GXDLMSImageTransfer target = Target as GXDLMSImageTransfer;
            if (arg.Index == 3)
            {
                ImageTransferredBlocksStatusTB.Text = (string)arg.Value;
            }
            else if (arg.Index == 5)
            {
                ImageTransferEnabledCB.CheckedChanged -= new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);
                ImageTransferEnabledCB.Checked = target.ImageTransferEnabled;
                ImageTransferEnabledCB.CheckedChanged += new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);
            }
            else if (arg.Index == 6)
            {
                ImageTransferStatusTb.Text = target.ImageTransferStatus.ToString();
                ManualBtn_CheckedChanged(null, null);
            }
            else if (arg.Index == 7)
            {
                ImagesView.Items.Clear();
                if (target.ImageActivateInfo != null)
                {
                    foreach (GXDLMSImageActivateInfo it in target.ImageActivateInfo)
                    {
                        ListViewItem li = ImagesView.Items.Add(it.Size.ToString());
                        if (GXByteBuffer.IsAsciiString(it.Identification))
                        {
                            li.SubItems.Add(ASCIIEncoding.ASCII.GetString(it.Identification));
                        }
                        else
                        {
                            li.SubItems.Add(GXDLMSTranslator.ToHex(it.Identification));
                        }
                        if (GXByteBuffer.IsAsciiString(it.Signature))
                        {
                            li.SubItems.Add(ASCIIEncoding.ASCII.GetString(it.Signature));
                        }
                        else
                        {
                            li.SubItems.Add(GXDLMSTranslator.ToHex(it.Signature));
                        }
                        li.Tag = it;
                    }
                }
            }
            else if (arg.Index != 0)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        delegate void DescriptionEventHandler(string text);
        delegate void ImageDialogEventHandler(GXImageDlg dlg, GXActionArgs arg);
        delegate void ImageTransferStatusEventHandler(ImageTransferStatus status);
        delegate int GetDelayEventHandler(GXActionArgs arg);


        void OnDescription(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DescriptionEventHandler(OnDescription), text);
            }
            else
            {
                ListViewItem li = DescriptionList.Items.Add(DateTime.Now.ToShortTimeString());
                li.SubItems.Add(text);
                li.EnsureVisible();
            }
        }

        void OnImageTransferStatus(ImageTransferStatus status)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ImageTransferStatusEventHandler(OnImageTransferStatus), status);
            }
            else
            {
                ImageTransferStatusTb.Text = status.ToString();
            }
        }

        int GetDelay(GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new GetDelayEventHandler(GetDelay), arg).AsyncWaitHandle.WaitOne();
                return (int)arg.Value;
            }
            else
            {
                try
                {

                    int value = (int)TimeSpan.Parse(DelayTb.Text).TotalMilliseconds;
                    if (arg != null)
                    {
                        arg.Value = value;
                    }
                    return value;
                }
                catch (Exception ex)
                {
                    arg.Value = 0;
                    arg.Exception = ex;
                    return 0;
                }
            }
        }

        void OnImageDialog(GXImageDlg dlg, GXActionArgs arg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ImageDialogEventHandler(OnImageDialog), dlg, arg).AsyncWaitHandle.WaitOne();
            }
            else
            {
                DescriptionList.Items.Clear();
                if (dlg.ShowDialog(this) != DialogResult.OK)
                {
                    arg.Action = ActionType.None;
                    return;
                }
                GXImageUpdateStatus status = new GXImageUpdateStatus();
                arg.Tag = status;
                status.ImageIdentifier = dlg.GetImageIdentifier();
                arg.Text = "Updating image " + Path.GetFileNameWithoutExtension(dlg.FileNameTb.Text) + "...";
                OnDescription("Updating image " + dlg.FileNameTb.Text);
                status.Image = dlg.Image;
            }
        }

        /// <summary>
        /// In image update following steps are made:
        /// 1. Image_transfer_enabled is read.
        /// 2. Image block size is read.
        /// 3. image_transferred_blocks_status is read to check is image try to update before.
        /// 3. image_transfer_initiate
        /// 4. image_transfer_status is read.
        /// 5. image_block_transfer
        /// 6. image_transfer_status is read.
        /// 7. image_transfer_status is read.
        /// 8. image_verify is called.
        /// 9. image_transfer_status is read.
        /// 10. image_activate is called.
        /// </summary>

        class GXImageUpdateStatus
        {
            /// <summary>
            /// How many times status is try to read.
            /// </summary>
            public int StatusReadCount = 0;
            /// <summary>
            /// Is image transforming in progress.
            /// </summary>
            public bool TransformingImage = false;
            /// <summary>
            /// Image identifier.
            /// </summary>
            public byte[] ImageIdentifier = null;
            /// <summary>
            /// Image to update.
            /// </summary>
            public byte[] Image;
            /// <summary>
            /// Image start index.
            /// </summary>
            public int ImageStartIndex;
        }

        public void PreAction(GXActionArgs arg)
        {
            GXDLMSImageTransfer it = Target as GXDLMSImageTransfer;
            if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    if (arg.Tag is GXImageUpdateStatus status)
                    {
                        //Initiate the Image transfer process.
                        arg.Value = it.ImageTransferInitiate(arg.Client, status.ImageIdentifier, status.Image.Length);
                    }
                    else
                    {
                        //Check that delay is correct and save it.
                        GetDelay(arg);
                        if (arg.Exception != null)
                        {
                            return;
                        }
                        GXManufacturerCollection manufacturers = new GXManufacturerCollection();
                        GXManufacturerCollection.ReadManufacturerSettings(manufacturers);
                        GXManufacturer man = manufacturers.FindByIdentification(arg.Client.ManufacturerId);
                        Properties.Settings.Default.ImageDelay = (int)arg.Value / 1000;
                        GXImageDlg dlg = new GXImageDlg(man.ManucatureSettings, arg.Client);
                        OnImageDialog(dlg, arg);
                        if (arg.Action == ActionType.None)
                        {
                            return;
                        }
                        arg.Index = 5;
                        arg.Action = ActionType.Read;
                        return;
                    }
                }
                else if (arg.Index == 2)
                {
                    //Start image block transfer.
                    GXImageUpdateStatus status = (GXImageUpdateStatus)arg.Tag;
                    int imageBlockCount;
                    arg.Value = it.ImageBlockTransfer(arg.Client, status.Image, status.ImageStartIndex, out imageBlockCount);
                    OnDescription("Sending " + imageBlockCount + " blocks.");
                }
                else if (arg.Index == 3)
                {
                    arg.Value = it.ImageVerify(arg.Client);
                    OnDescription("Verifying image.");
                }
                else if (arg.Index == 4)
                {
                    arg.Value = it.ImageActivate(arg.Client);
                    OnDescription("Activating image.");
                }
            }
        }

        public void PostAction(GXActionArgs arg)
        {
            GXDLMSImageTransfer it = Target as GXDLMSImageTransfer;
            GXImageUpdateStatus status = (GXImageUpdateStatus)arg.Tag;
            if (arg.Action == ActionType.Read)
            {
                if (arg.Index == 5)
                {
                    if (!it.ImageTransferEnabled)
                    {
                        GXHelpers.ShowMessageBox(this, Properties.Resources.ImageTransferDisabled, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        arg.Action = ActionType.None;
                        return;
                    }
                    OnDescription(Properties.Resources.ImageTransferEnabled);
                    //Get ImageBlockSize.
                    arg.Index = 2;
                }
                else if (arg.Index == 2)
                {
                    OnDescription(Properties.Resources.ImageBlockSize + it.ImageBlockSize);
                    //Read image_transferred_blocks_status.
                    arg.Index = 3;
                }
                else if (arg.Index == 3)
                {
                    int index = 0;
                    foreach (char b in it.ImageTransferredBlocksStatus)
                    {
                        if (b == '0')
                        {
                            DialogResult ret = GXHelpers.ShowMessageBox(this, index + " Image blocks already exists. Do you want to overwrite image? " + Environment.NewLine
                                + "Answering No will update missing blocks.", "GXDLMSDirector",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                            if (ret == DialogResult.Cancel)
                            {
                                arg.Action = ActionType.None;
                                return;
                            }
                            if (ret == DialogResult.No)
                            {
                                status.ImageStartIndex = index;
                                arg.Index = 2;
                                arg.Action = ActionType.Action;
                                return;
                            }
                            break;
                        }
                        ++index;
                    }
                    OnDescription(Properties.Resources.ImageBlockSize + it.ImageBlockSize);
                    //Invoke Initiates image transfer.
                    arg.Index = 1;
                    arg.Action = ActionType.Action;
                }
                else if (arg.Index == 6)
                {
                    OnImageTransferStatus(it.ImageTransferStatus);
                    GetDelay(arg);
                    if (arg.Exception != null)
                    {
                        return;
                    }
                    int delay = (int)arg.Value;
                    arg.Value = null;
                    switch (it.ImageTransferStatus)
                    {
                        case ImageTransferStatus.NotInitiated:
                            if (++status.StatusReadCount > 10)
                            {
                                OnDescription("Failed to read Image transfer status after image transfer initiate.");
                                GXHelpers.ShowMessageBox(this, "Failed to read Image transfer status after image transfer initiate.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                arg.Action = ActionType.None;
                                return;
                            }
                            Thread.Sleep(delay);
                            arg.Index = 6;
                            break;
                        case ImageTransferStatus.TransferInitiated:
                            if (!status.TransformingImage)
                            {
                                arg.Action = ActionType.Action;
                                arg.Index = 2;
                                status.TransformingImage = true;
                            }
                            else
                            {
                                if (!Properties.Settings.Default.ImageManualUpdate)
                                {
                                    arg.Action = ActionType.Action;
                                    if (arg.Client.CanInvoke(arg.Target, 3))
                                    {
                                        arg.Index = 3;
                                    }
                                    else if (arg.Client.CanInvoke(arg.Target, 4))
                                    {
                                        arg.Index = 4;
                                    }
                                    else
                                    {
                                        GXHelpers.ShowMessageBox(this, Properties.Resources.ImageTransferedNotActivatedTxt, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        arg.Action = ActionType.None;
                                    }
                                }
                                else
                                {
                                    arg.Action = ActionType.None;
                                    ManualBtn_CheckedChanged(null, null);
                                }
                            }
                            break;
                        case ImageTransferStatus.VerificationInitiated:
                            Thread.Sleep(delay);
                            OnDescription(Properties.Resources.VerificationInitiated);
                            arg.Text = Properties.Resources.VerificationInitiated;
                            arg.Index = 6;
                            break;
                        case ImageTransferStatus.VerificationSuccessful:
                            arg.Index = 4;
                            arg.Action = ActionType.Action;
                            break;
                        case ImageTransferStatus.VerificationFailed:
                            OnDescription(Properties.Resources.VerificationFailed);
                            arg.Text = Properties.Resources.VerificationFailed;
                            arg.Action = ActionType.None;
                            break;
                        case ImageTransferStatus.ActivationInitiated:
                            Thread.Sleep(delay);
                            OnDescription(Properties.Resources.ActivationInitiated);
                            arg.Text = Properties.Resources.ActivationInitiated;
                            break;
                        case ImageTransferStatus.ActivationSuccessful:
                            OnDescription(Properties.Resources.ActivationSuccessful);
                            GXHelpers.ShowMessageBox(this, Properties.Resources.ImageActivatedTxt, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            arg.Action = ActionType.None;
                            break;
                        case ImageTransferStatus.ActivationFailed:
                            OnDescription(Properties.Resources.ActivationFailed);
                            arg.Text = Properties.Resources.ActivationFailed;
                            arg.Action = ActionType.None;
                            break;
                    }
                }
            }
            else if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    OnDescription("Image transfer initiated.");
                    arg.Action = ActionType.Read;
                    arg.Index = 6;
                }
                else if (arg.Index == 2)
                {
                    OnDescription("Image transfered.");
                    arg.Index = 6;
                    arg.Action = ActionType.Read;
                }
                else if (arg.Index == 3)
                {
                    if (arg.Exception is GXDLMSException)
                    {
                        //If meter is activating image.
                        if ((arg.Exception as GXDLMSException).ErrorCode == (int)ErrorCode.TemporaryFailure)
                        {
                            if (!Properties.Settings.Default.ImageManualUpdate)
                            {
                                arg.Exception = null;
                                GetDelay(arg);
                                if (arg.Exception != null)
                                {
                                    return;
                                }
                                int delay = (int)arg.Value;
                                Thread.Sleep(delay);
                                arg.Value = null;
                            }
                            return;
                        }
                    }
                    if (!Properties.Settings.Default.ImageManualUpdate)
                    {
                        arg.Index = 6;
                        arg.Action = ActionType.Read;
                    }
                    else
                    {
                        arg.Action = ActionType.None;
                    }
                }
                else if (arg.Index == 4)
                {
                    if (arg.Exception is GXDLMSException)
                    {
                        //If meter is activating image.
                        if ((arg.Exception as GXDLMSException).ErrorCode == (int)ErrorCode.TemporaryFailure)
                        {
                            if (!Properties.Settings.Default.ImageManualUpdate)
                            {
                                arg.Exception = null;
                                GetDelay(arg);
                                if (arg.Exception != null)
                                {
                                    return;
                                }
                                int delay = (int)arg.Value;
                                Thread.Sleep(delay);
                                arg.Value = null;
                            }
                            return;
                        }
                    }
                    OnDescription(Properties.Resources.ImageActivatedTxt);
                    arg.Action = ActionType.None;
                    arg.Rebooting = true;
                    GXHelpers.ShowMessageBox(this, Properties.Resources.ActionImplemented, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            switch (index)
            {
                case 2:
                    errorProvider1.SetError(ImageBlockSizeTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 3:
                    errorProvider1.SetError(ImageTransferredBlocksStatusTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 4:
                    errorProvider1.SetError(ImageFirstNotTransferredBlockNumberTB, Properties.Resources.ValueChangedTxt);
                    break;
                case 5:
                    errorProvider1.SetError(ImageTransferEnabledCB, Properties.Resources.ValueChangedTxt);
                    break;
                case 6:
                    errorProvider1.SetError(ImageTransferStatusTb, Properties.Resources.ValueChangedTxt);
                    break;
                case 7:
                    errorProvider1.SetError(ImagesView, Properties.Resources.ValueChangedTxt);
                    break;
                default:
                    errorProvider1.Clear();
                    break;
            }
        }

        public void OnAccessRightsChange(GXDLMSViewArguments arg)
        {
            bool enabled = arg.Connected && arg.Client.CanWrite(Target, arg.Index);
            if (arg.Index == 3)
            {
                ImageTransferredBlocksStatusTB.ReadOnly = !enabled;
            }
            else if (arg.Index == 5)
            {
                ImageTransferEnabledCB.Enabled = enabled;
            }
            else if (arg.Index == 7)
            {
                ImagesView.Enabled = enabled;
            }
            else if (arg.Index != 6)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnMethodAccessRightsChange(GXDLMSViewArguments arg)
        {
            VerifyAllowed = arg.Connected && arg.Client.CanInvoke(Target, 3);
            ActivationAllowed = arg.Connected && arg.Client.CanInvoke(Target, 4);

            if (arg.Index == 2)
            {
                GXDLMSImageTransfer target = Target as GXDLMSImageTransfer;
                ManualBtn.Enabled = !arg.Connected;
                VerifyImageBtn.Enabled = VerifyAllowed && Properties.Settings.Default.ImageManualUpdate && (target.ImageTransferStatus == ImageTransferStatus.TransferInitiated || target.ImageTransferStatus == ImageTransferStatus.VerificationFailed);
                ActivateImageBtn.Enabled = ActivationAllowed && Properties.Settings.Default.ImageManualUpdate && target.ImageTransferStatus == ImageTransferStatus.VerificationSuccessful;
                if (ManualBtn.Enabled)
                {
                    ManualBtn_CheckedChanged(null, null);
                }
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
            errorProvider1.SetError(ImageTransferEnabledCB, Properties.Resources.ValueChangedTxt);
        }

        /// <summary>
        /// Is image updated manually.
        /// </summary>
        private void ManualBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler(ManualBtn_CheckedChanged), sender, e);
            }
            else if (Target != null)
            {
                Properties.Settings.Default.ImageManualUpdate = ManualBtn.Checked;
                GXDLMSImageTransfer target = Target as GXDLMSImageTransfer;
                DelayTb.ReadOnly = Properties.Settings.Default.ImageManualUpdate || !ManualBtn.Enabled;
                VerifyImageBtn.Enabled = VerifyAllowed && Properties.Settings.Default.ImageManualUpdate && (target.ImageTransferStatus == ImageTransferStatus.TransferInitiated || target.ImageTransferStatus == ImageTransferStatus.VerificationFailed);
                ActivateImageBtn.Enabled = ActivationAllowed && Properties.Settings.Default.ImageManualUpdate && target.ImageTransferStatus == ImageTransferStatus.VerificationSuccessful;
            }
        }
    }
}
