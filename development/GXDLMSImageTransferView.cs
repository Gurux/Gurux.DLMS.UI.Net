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
using System.Windows.Forms;
using Gurux.DLMS.Objects;
using Gurux.DLMS.Enums;
using System.Text;
using System.IO;
using System.Threading;
using Gurux.DLMS.Objects.Enums;

namespace Gurux.DLMS.UI
{
    /// <summary>
    /// Online help:
    /// http://www.gurux.fi/Gurux.DLMS.Objects.GXDLMSImageTransfer
    /// </summary>
    [GXDLMSViewAttribute(typeof(GXDLMSImageTransfer))]
    public partial class GXDLMSImageTransferView : Form, IGXDLMSView
    {
        byte[] imageIdentifier = null;
        byte[] image;

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

        public void OnValueChanged(int index, object value, bool user, bool connected)
        {
            GXDLMSImageTransfer target = Target as GXDLMSImageTransfer;
            if (index == 3)
            {
                ImageTransferredBlocksStatusTB.Text = (string) value;
            }
            else if (index == 5)
            {
                ImageTransferEnabledCB.CheckedChanged -= new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);
                ImageTransferEnabledCB.Checked = target.ImageTransferEnabled;
                ImageTransferEnabledCB.CheckedChanged += new System.EventHandler(ImageTransferEnabledCB_CheckedChanged);
            }
            else if (index == 6)
            {
                ImageTransferStatusTb.Text = target.ImageTransferStatus.ToString();
                ManualBtn_CheckedChanged(null, null);
            }
            else if (index == 7)
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
            else if (index != 0)
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
                    imageIdentifier = null;
                    arg.Action = ActionType.None;
                    return;
                }
                if (dlg.IsAscii)
                {
                    imageIdentifier = ASCIIEncoding.ASCII.GetBytes(dlg.TextTb.Text);
                }
                else
                {
                    imageIdentifier = GXDLMSTranslator.HexToBytes(dlg.TextTb.Text);
                }
                arg.Text = "Updating image " + Path.GetFileNameWithoutExtension(dlg.FileNameTb.Text) + "...";
                OnDescription("Updating image " + dlg.FileNameTb.Text);
                image = dlg.Image;
            }
        }

        int statusReadCount = 0;
        bool updatingImage = false;
        bool transformingImage = false;
        public void PreAction(GXActionArgs arg)
        {
            GXDLMSImageTransfer it = Target as GXDLMSImageTransfer;
            if (arg.Action == ActionType.Action)
            {
                if (arg.Index == 1)
                {
                    if (!updatingImage)
                    {
                        //Check that delay is correct and save it.
                        GetDelay(arg);
                        if (arg.Exception != null)
                        {
                            return;
                        }
                        Properties.Settings.Default.ImageDelay = (int)arg.Value / 1000;
                        GXImageDlg dlg = new GXImageDlg();
                        OnImageDialog(dlg, arg);
                        if (arg.Action == ActionType.None)
                        {
                            return;
                        }
                        arg.Index = 5;
                        arg.Action = ActionType.Read;
                        transformingImage = false;
                        updatingImage = true;
                        return;
                    }
                    //Initiate the Image transfer process.
                    arg.Value = it.ImageTransferInitiate(arg.Client, imageIdentifier, image.Length);
                    imageIdentifier = null;
                    updatingImage = false;
                    statusReadCount = 0;
                }
                else if (arg.Index == 2)
                {
                    //Start image block transfer.
                    int imageBlockCount;
                    arg.Value = it.ImageBlockTransfer(arg.Client, image, out imageBlockCount);
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
            if (arg.Action == ActionType.Read)
            {
                if (arg.Index == 5)
                {
                    if (!it.ImageTransferEnabled)
                    {
                        updatingImage = false;
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
                            if (++statusReadCount > 10)
                            {
                                OnDescription("Failed to read Image transfer status after image transfer initiate.");
                                GXHelpers.ShowMessageBox(this, "Failed to read Image transfer status after image transfer initiate.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                arg.Action = ActionType.None;
                                updatingImage = false;
                                return;
                            }
                            Thread.Sleep(delay);
                            arg.Index = 6;
                            break;
                        case ImageTransferStatus.TransferInitiated:
                            if (!transformingImage)
                            {
                                arg.Action = ActionType.Action;
                                arg.Index = 2;
                                transformingImage = true;
                            }
                            else
                            {
                                if (!Properties.Settings.Default.ImageManualUpdate)
                                {
                                    arg.Index = 3;
                                    arg.Action = ActionType.Action;
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
            if (index == 3)
            {
                ImageTransferredBlocksStatusTB.ReadOnly = !(connected && (Target.GetAccess(index) & AccessMode.Write) != 0);
            }
            else if (index == 5)
            {
                ImageTransferEnabledCB.Enabled = connected && (Target.GetAccess(index) & AccessMode.Write) != 0;
            }
            else if (index == 7)
            {
                ImagesView.Enabled = connected && (Target.GetAccess(index) & AccessMode.Write) != 0;
            }
            else if (index != 6)
            {
                throw new IndexOutOfRangeException("index");
            }
        }

        public void OnAccessRightsChange(int index, MethodAccessMode mode, bool connected)
        {
            if (index == 2)
            {
                ManualBtn.Enabled = DelayTb.Enabled = ActivateImageBtn.Enabled = VerifyImageBtn.Enabled = UpdateImageBtn.Enabled && connected && mode != MethodAccessMode.NoAccess;
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
                DelayTb.ReadOnly = Properties.Settings.Default.ImageManualUpdate;
                VerifyImageBtn.Enabled = Properties.Settings.Default.ImageManualUpdate && (target.ImageTransferStatus == ImageTransferStatus.TransferInitiated || target.ImageTransferStatus == ImageTransferStatus.VerificationFailed);
                ActivateImageBtn.Enabled = Properties.Settings.Default.ImageManualUpdate && target.ImageTransferStatus == ImageTransferStatus.VerificationSuccessful;
            }
        }
    }
}
