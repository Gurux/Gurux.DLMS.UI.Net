using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSIEC6205541AttributesView
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
        private GroupBox groupBox1;
        private Label CommodityLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSIEC6205541AttributesView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TokenCarrierTypesTb = new System.Windows.Forms.TextBox();
            this.TokenCarrierTypesLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PanCheckDigitTb = new System.Windows.Forms.TextBox();
            this.PanCheckDigitLbl = new System.Windows.Forms.Label();
            this.DecoderReferenceNumberTb = new System.Windows.Forms.TextBox();
            this.DecoderReferenceNumberLbl = new System.Windows.Forms.Label();
            this.IssuerIDTb = new System.Windows.Forms.TextBox();
            this.IssuerIDLbl = new System.Windows.Forms.Label();
            this.StsCertificateNoTb = new Gurux.DLMS.UI.GXValueField();
            this.StsCertificateNoLbl = new System.Windows.Forms.Label();
            this.NoOfKctSupportedTb = new Gurux.DLMS.UI.GXValueField();
            this.NoOfKctSupportedLbl = new System.Windows.Forms.Label();
            this.KeyExpiryNumberTb = new Gurux.DLMS.UI.GXValueField();
            this.KeyExpiryNumberLbl = new System.Windows.Forms.Label();
            this.KeyTypeTb = new Gurux.DLMS.UI.GXValueField();
            this.KeyTypeLbl = new System.Windows.Forms.Label();
            this.KeyRevisionNumberTb = new Gurux.DLMS.UI.GXValueField();
            this.KeyRevisionNumberLbl = new System.Windows.Forms.Label();
            this.TariffIndexTb = new Gurux.DLMS.UI.GXValueField();
            this.TariffIndexLbl = new System.Windows.Forms.Label();
            this.SupplyGroupCodeTb = new Gurux.DLMS.UI.GXValueField();
            this.SupplyGroupCodeLbl = new System.Windows.Forms.Label();
            this.EncryptionAlgorithmTb = new Gurux.DLMS.UI.GXValueField();
            this.EncryptionAlgorithmLbl = new System.Windows.Forms.Label();
            this.CommodityTb = new Gurux.DLMS.UI.GXValueField();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.CommodityLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TokenCarrierTypesTb);
            this.groupBox1.Controls.Add(this.TokenCarrierTypesLbl);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.StsCertificateNoTb);
            this.groupBox1.Controls.Add(this.StsCertificateNoLbl);
            this.groupBox1.Controls.Add(this.NoOfKctSupportedTb);
            this.groupBox1.Controls.Add(this.NoOfKctSupportedLbl);
            this.groupBox1.Controls.Add(this.KeyExpiryNumberTb);
            this.groupBox1.Controls.Add(this.KeyExpiryNumberLbl);
            this.groupBox1.Controls.Add(this.KeyTypeTb);
            this.groupBox1.Controls.Add(this.KeyTypeLbl);
            this.groupBox1.Controls.Add(this.KeyRevisionNumberTb);
            this.groupBox1.Controls.Add(this.KeyRevisionNumberLbl);
            this.groupBox1.Controls.Add(this.TariffIndexTb);
            this.groupBox1.Controls.Add(this.TariffIndexLbl);
            this.groupBox1.Controls.Add(this.SupplyGroupCodeTb);
            this.groupBox1.Controls.Add(this.SupplyGroupCodeLbl);
            this.groupBox1.Controls.Add(this.EncryptionAlgorithmTb);
            this.groupBox1.Controls.Add(this.EncryptionAlgorithmLbl);
            this.groupBox1.Controls.Add(this.CommodityTb);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.CommodityLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IEC 62055-41 Attributes Object";
            // 
            // TokenCarrierTypesTb
            // 
            this.TokenCarrierTypesTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenCarrierTypesTb.Location = new System.Drawing.Point(157, 201);
            this.TokenCarrierTypesTb.Name = "TokenCarrierTypesTb";
            this.TokenCarrierTypesTb.ReadOnly = true;
            this.TokenCarrierTypesTb.Size = new System.Drawing.Size(286, 20);
            this.TokenCarrierTypesTb.TabIndex = 30;
            // 
            // TokenCarrierTypesLbl
            // 
            this.TokenCarrierTypesLbl.AutoSize = true;
            this.TokenCarrierTypesLbl.Location = new System.Drawing.Point(8, 201);
            this.TokenCarrierTypesLbl.Name = "TokenCarrierTypesLbl";
            this.TokenCarrierTypesLbl.Size = new System.Drawing.Size(106, 13);
            this.TokenCarrierTypesLbl.TabIndex = 31;
            this.TokenCarrierTypesLbl.Text = "Token Carrier Types:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PanCheckDigitTb);
            this.groupBox3.Controls.Add(this.PanCheckDigitLbl);
            this.groupBox3.Controls.Add(this.DecoderReferenceNumberTb);
            this.groupBox3.Controls.Add(this.DecoderReferenceNumberLbl);
            this.groupBox3.Controls.Add(this.IssuerIDTb);
            this.groupBox3.Controls.Add(this.IssuerIDLbl);
            this.groupBox3.Location = new System.Drawing.Point(1, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 99);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meter Primary Account Number";
            // 
            // PanCheckDigitTb
            // 
            this.PanCheckDigitTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanCheckDigitTb.Location = new System.Drawing.Point(157, 71);
            this.PanCheckDigitTb.Name = "PanCheckDigitTb";
            this.PanCheckDigitTb.ReadOnly = true;
            this.PanCheckDigitTb.Size = new System.Drawing.Size(286, 20);
            this.PanCheckDigitTb.TabIndex = 28;
            // 
            // PanCheckDigitLbl
            // 
            this.PanCheckDigitLbl.AutoSize = true;
            this.PanCheckDigitLbl.Location = new System.Drawing.Point(7, 71);
            this.PanCheckDigitLbl.Name = "PanCheckDigitLbl";
            this.PanCheckDigitLbl.Size = new System.Drawing.Size(87, 13);
            this.PanCheckDigitLbl.TabIndex = 29;
            this.PanCheckDigitLbl.Text = "Pan Check Digit:";
            // 
            // DecoderReferenceNumberTb
            // 
            this.DecoderReferenceNumberTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecoderReferenceNumberTb.Location = new System.Drawing.Point(157, 45);
            this.DecoderReferenceNumberTb.Name = "DecoderReferenceNumberTb";
            this.DecoderReferenceNumberTb.ReadOnly = true;
            this.DecoderReferenceNumberTb.Size = new System.Drawing.Size(286, 20);
            this.DecoderReferenceNumberTb.TabIndex = 26;
            // 
            // DecoderReferenceNumberLbl
            // 
            this.DecoderReferenceNumberLbl.AutoSize = true;
            this.DecoderReferenceNumberLbl.Location = new System.Drawing.Point(7, 45);
            this.DecoderReferenceNumberLbl.Name = "DecoderReferenceNumberLbl";
            this.DecoderReferenceNumberLbl.Size = new System.Drawing.Size(144, 13);
            this.DecoderReferenceNumberLbl.TabIndex = 27;
            this.DecoderReferenceNumberLbl.Text = "Decoder Reference Number:";
            // 
            // IssuerIDTb
            // 
            this.IssuerIDTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuerIDTb.Location = new System.Drawing.Point(157, 19);
            this.IssuerIDTb.Name = "IssuerIDTb";
            this.IssuerIDTb.ReadOnly = true;
            this.IssuerIDTb.Size = new System.Drawing.Size(286, 20);
            this.IssuerIDTb.TabIndex = 24;
            // 
            // IssuerIDLbl
            // 
            this.IssuerIDLbl.AutoSize = true;
            this.IssuerIDLbl.Location = new System.Drawing.Point(7, 19);
            this.IssuerIDLbl.Name = "IssuerIDLbl";
            this.IssuerIDLbl.Size = new System.Drawing.Size(52, 13);
            this.IssuerIDLbl.TabIndex = 25;
            this.IssuerIDLbl.Text = "Issuer ID:";
            // 
            // StsCertificateNoTb
            // 
            this.StsCertificateNoTb.Index = 12;
            this.StsCertificateNoTb.Location = new System.Drawing.Point(157, 410);
            this.StsCertificateNoTb.Name = "StsCertificateNoTb";
            this.StsCertificateNoTb.NotifyChanges = false;
            this.StsCertificateNoTb.Size = new System.Drawing.Size(286, 20);
            this.StsCertificateNoTb.TabIndex = 26;
            this.StsCertificateNoTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // StsCertificateNoLbl
            // 
            this.StsCertificateNoLbl.AutoSize = true;
            this.StsCertificateNoLbl.Location = new System.Drawing.Point(8, 412);
            this.StsCertificateNoLbl.Name = "StsCertificateNoLbl";
            this.StsCertificateNoLbl.Size = new System.Drawing.Size(89, 13);
            this.StsCertificateNoLbl.TabIndex = 25;
            this.StsCertificateNoLbl.Text = "Sts certificate no:";
            // 
            // NoOfKctSupportedTb
            // 
            this.NoOfKctSupportedTb.Index = 11;
            this.NoOfKctSupportedTb.Location = new System.Drawing.Point(157, 384);
            this.NoOfKctSupportedTb.Name = "NoOfKctSupportedTb";
            this.NoOfKctSupportedTb.NotifyChanges = false;
            this.NoOfKctSupportedTb.Size = new System.Drawing.Size(286, 20);
            this.NoOfKctSupportedTb.TabIndex = 24;
            this.NoOfKctSupportedTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // NoOfKctSupportedLbl
            // 
            this.NoOfKctSupportedLbl.AutoSize = true;
            this.NoOfKctSupportedLbl.Location = new System.Drawing.Point(8, 386);
            this.NoOfKctSupportedLbl.Name = "NoOfKctSupportedLbl";
            this.NoOfKctSupportedLbl.Size = new System.Drawing.Size(104, 13);
            this.NoOfKctSupportedLbl.TabIndex = 23;
            this.NoOfKctSupportedLbl.Text = "No of kct supported:";
            // 
            // KeyExpiryNumberTb
            // 
            this.KeyExpiryNumberTb.Index = 10;
            this.KeyExpiryNumberTb.Location = new System.Drawing.Point(157, 358);
            this.KeyExpiryNumberTb.Name = "KeyExpiryNumberTb";
            this.KeyExpiryNumberTb.NotifyChanges = false;
            this.KeyExpiryNumberTb.Size = new System.Drawing.Size(286, 20);
            this.KeyExpiryNumberTb.TabIndex = 22;
            this.KeyExpiryNumberTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // KeyExpiryNumberLbl
            // 
            this.KeyExpiryNumberLbl.AutoSize = true;
            this.KeyExpiryNumberLbl.Location = new System.Drawing.Point(8, 360);
            this.KeyExpiryNumberLbl.Name = "KeyExpiryNumberLbl";
            this.KeyExpiryNumberLbl.Size = new System.Drawing.Size(96, 13);
            this.KeyExpiryNumberLbl.TabIndex = 21;
            this.KeyExpiryNumberLbl.Text = "Key expiry number:";
            // 
            // KeyTypeTb
            // 
            this.KeyTypeTb.Index = 9;
            this.KeyTypeTb.Location = new System.Drawing.Point(157, 332);
            this.KeyTypeTb.Name = "KeyTypeTb";
            this.KeyTypeTb.NotifyChanges = false;
            this.KeyTypeTb.Size = new System.Drawing.Size(286, 20);
            this.KeyTypeTb.TabIndex = 20;
            this.KeyTypeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // KeyTypeLbl
            // 
            this.KeyTypeLbl.AutoSize = true;
            this.KeyTypeLbl.Location = new System.Drawing.Point(8, 334);
            this.KeyTypeLbl.Name = "KeyTypeLbl";
            this.KeyTypeLbl.Size = new System.Drawing.Size(51, 13);
            this.KeyTypeLbl.TabIndex = 19;
            this.KeyTypeLbl.Text = "Key type:";
            // 
            // KeyRevisionNumberTb
            // 
            this.KeyRevisionNumberTb.Index = 8;
            this.KeyRevisionNumberTb.Location = new System.Drawing.Point(157, 306);
            this.KeyRevisionNumberTb.Name = "KeyRevisionNumberTb";
            this.KeyRevisionNumberTb.NotifyChanges = false;
            this.KeyRevisionNumberTb.Size = new System.Drawing.Size(286, 20);
            this.KeyRevisionNumberTb.TabIndex = 18;
            this.KeyRevisionNumberTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // KeyRevisionNumberLbl
            // 
            this.KeyRevisionNumberLbl.AutoSize = true;
            this.KeyRevisionNumberLbl.Location = new System.Drawing.Point(8, 308);
            this.KeyRevisionNumberLbl.Name = "KeyRevisionNumberLbl";
            this.KeyRevisionNumberLbl.Size = new System.Drawing.Size(105, 13);
            this.KeyRevisionNumberLbl.TabIndex = 17;
            this.KeyRevisionNumberLbl.Text = "Key revision number:";
            // 
            // TariffIndexTb
            // 
            this.TariffIndexTb.Index = 7;
            this.TariffIndexTb.Location = new System.Drawing.Point(157, 280);
            this.TariffIndexTb.Name = "TariffIndexTb";
            this.TariffIndexTb.NotifyChanges = false;
            this.TariffIndexTb.Size = new System.Drawing.Size(286, 20);
            this.TariffIndexTb.TabIndex = 16;
            this.TariffIndexTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // TariffIndexLbl
            // 
            this.TariffIndexLbl.AutoSize = true;
            this.TariffIndexLbl.Location = new System.Drawing.Point(8, 282);
            this.TariffIndexLbl.Name = "TariffIndexLbl";
            this.TariffIndexLbl.Size = new System.Drawing.Size(62, 13);
            this.TariffIndexLbl.TabIndex = 15;
            this.TariffIndexLbl.Text = "Tariff index:";
            // 
            // SupplyGroupCodeTb
            // 
            this.SupplyGroupCodeTb.Index = 6;
            this.SupplyGroupCodeTb.Location = new System.Drawing.Point(157, 254);
            this.SupplyGroupCodeTb.Name = "SupplyGroupCodeTb";
            this.SupplyGroupCodeTb.NotifyChanges = false;
            this.SupplyGroupCodeTb.Size = new System.Drawing.Size(286, 20);
            this.SupplyGroupCodeTb.TabIndex = 14;
            this.SupplyGroupCodeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // SupplyGroupCodeLbl
            // 
            this.SupplyGroupCodeLbl.AutoSize = true;
            this.SupplyGroupCodeLbl.Location = new System.Drawing.Point(8, 256);
            this.SupplyGroupCodeLbl.Name = "SupplyGroupCodeLbl";
            this.SupplyGroupCodeLbl.Size = new System.Drawing.Size(99, 13);
            this.SupplyGroupCodeLbl.TabIndex = 13;
            this.SupplyGroupCodeLbl.Text = "Supply group code:";
            // 
            // EncryptionAlgorithmTb
            // 
            this.EncryptionAlgorithmTb.Index = 5;
            this.EncryptionAlgorithmTb.Location = new System.Drawing.Point(157, 228);
            this.EncryptionAlgorithmTb.Name = "EncryptionAlgorithmTb";
            this.EncryptionAlgorithmTb.NotifyChanges = false;
            this.EncryptionAlgorithmTb.Size = new System.Drawing.Size(286, 20);
            this.EncryptionAlgorithmTb.TabIndex = 12;
            this.EncryptionAlgorithmTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // EncryptionAlgorithmLbl
            // 
            this.EncryptionAlgorithmLbl.AutoSize = true;
            this.EncryptionAlgorithmLbl.Location = new System.Drawing.Point(8, 230);
            this.EncryptionAlgorithmLbl.Name = "EncryptionAlgorithmLbl";
            this.EncryptionAlgorithmLbl.Size = new System.Drawing.Size(105, 13);
            this.EncryptionAlgorithmLbl.TabIndex = 11;
            this.EncryptionAlgorithmLbl.Text = "Encryption algorithm:";
            // 
            // CommodityTb
            // 
            this.CommodityTb.Index = 3;
            this.CommodityTb.Location = new System.Drawing.Point(157, 175);
            this.CommodityTb.Name = "CommodityTb";
            this.CommodityTb.NotifyChanges = false;
            this.CommodityTb.Size = new System.Drawing.Size(286, 20);
            this.CommodityTb.TabIndex = 10;
            this.CommodityTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(7, 22);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLbl.TabIndex = 5;
            this.DescriptionLbl.Text = "Description:";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTB.Location = new System.Drawing.Point(157, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(286, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // CommodityLbl
            // 
            this.CommodityLbl.AutoSize = true;
            this.CommodityLbl.Location = new System.Drawing.Point(7, 177);
            this.CommodityLbl.Name = "CommodityLbl";
            this.CommodityLbl.Size = new System.Drawing.Size(61, 13);
            this.CommodityLbl.TabIndex = 2;
            this.CommodityLbl.Text = "Commodity:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(157, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(286, 20);
            this.LogicalNameTB.TabIndex = 2;
            this.LogicalNameTB.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(7, 48);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 0;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // GXDLMSIEC6205541AttributesView
            // 
            this.ClientSize = new System.Drawing.Size(488, 475);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSIEC6205541AttributesView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField CommodityTb;
        private GXValueField KeyTypeTb;
        private Label KeyTypeLbl;
        private GXValueField KeyRevisionNumberTb;
        private Label KeyRevisionNumberLbl;
        private GXValueField TariffIndexTb;
        private GXValueField SupplyGroupCodeTb;
        private Label SupplyGroupCodeLbl;
        private GXValueField EncryptionAlgorithmTb;
        private Label EncryptionAlgorithmLbl;
        private Label TariffIndexLbl;
        private GXValueField StsCertificateNoTb;
        private Label StsCertificateNoLbl;
        private GXValueField NoOfKctSupportedTb;
        private Label NoOfKctSupportedLbl;
        private GXValueField KeyExpiryNumberTb;
        private Label KeyExpiryNumberLbl;
        private GroupBox groupBox3;
        private TextBox PanCheckDigitTb;
        private Label PanCheckDigitLbl;
        private TextBox DecoderReferenceNumberTb;
        private Label DecoderReferenceNumberLbl;
        private TextBox IssuerIDTb;
        private Label IssuerIDLbl;
        private TextBox TokenCarrierTypesTb;
        private Label TokenCarrierTypesLbl;
    }
}
