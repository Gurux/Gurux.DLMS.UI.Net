using Gurux.DLMS.Objects;
using Gurux.DLMS.Objects.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSNeighbourTableDlg : Form
    {
        GXDLMSNeighbourTable Item;
        public GXDLMSNeighbourTableDlg(GXDLMSNeighbourTable item)
        {
            InitializeComponent();
            ModulationCb.Items.AddRange(new object[] { Modulation.RobustMode, Modulation.DbPsk, Modulation.DqPsk, Modulation.D8Psk, Modulation.Qam16 });
            TxGainResolutionCb.Items.AddRange(new object[] { GainResolution.dB6, GainResolution.dB3 });
            Item = item;
            AddressTb.Text = item.ShortAddress.ToString();
            EnabledCB.Checked = item.Enabled;
            ToneMapTb.Text = item.ToneMap;
            ModulationCb.SelectedItem = item.Modulation;
            TxGainTb.Text = item.TxGain.ToString();
            TxGainResolutionCb.SelectedItem = item.TxRes;
            TransmitterGainTb.Text = item.TxCoeff;
            LinkQualityIndicatorTb.Text = item.Lqi.ToString();
            PhaseDifferenceTb.Text = item.PhaseDifferential.ToString();
            TMRValidTimeTb.Text = item.TMRValidTime.ToString();
            ValidTimeTb.Text = item.NeighbourValidTime.ToString();

        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Item.ShortAddress = UInt16.Parse(AddressTb.Text);
                Item.Enabled = EnabledCB.Checked;
                Item.ToneMap = ToneMapTb.Text;
                Item.Modulation = (Modulation)ModulationCb.SelectedItem;
                Item.TxGain = sbyte.Parse(TxGainTb.Text);
                Item.TxRes = (GainResolution)TxGainResolutionCb.SelectedItem;
                Item.TxCoeff = TransmitterGainTb.Text;
                Item.Lqi = byte.Parse(LinkQualityIndicatorTb.Text);
                Item.PhaseDifferential = sbyte.Parse(PhaseDifferenceTb.Text);
                Item.TMRValidTime = byte.Parse(TMRValidTimeTb.Text);
                Item.NeighbourValidTime = byte.Parse(ValidTimeTb.Text);
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
