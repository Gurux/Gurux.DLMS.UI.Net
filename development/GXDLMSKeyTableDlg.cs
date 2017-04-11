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
    public partial class GXDLMSKeyTableDlg : Form
    {
        internal byte id;
        internal byte[] key;

        public GXDLMSKeyTableDlg(GXKeyValuePair<byte, byte[]> item)
        {
            InitializeComponent();
            IdTb.Text = item.Key.ToString();
            KeyTb.Text = GXDLMSTranslator.ToHex(item.Value);
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            try
            {
                id = byte.Parse(IdTb.Text);
                key = GXDLMSTranslator.HexToBytes(KeyTb.Text);
                if (key.Length == 0)
                {
                    throw new ArgumentException("Value is empty.");
                }
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
