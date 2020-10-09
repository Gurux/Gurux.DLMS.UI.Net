using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSCreditView
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
        private GXValueField CurrentCreditAmountTb;
        private Label CurrentCreditAmountLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSCreditView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PeriodTb = new Gurux.DLMS.UI.GXValueField();
            this.PeriodLbl = new System.Windows.Forms.Label();
            this.CreditAvailableThresholdTb = new Gurux.DLMS.UI.GXValueField();
            this.CreditAvailableThresholdLbl = new System.Windows.Forms.Label();
            this.PresetCreditAmountTb = new Gurux.DLMS.UI.GXValueField();
            this.PresetCreditAmountLbl = new System.Windows.Forms.Label();
            this.StatusTb = new Gurux.DLMS.UI.GXValueField();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.CreditConfigurationTb = new Gurux.DLMS.UI.GXValueField();
            this.CreditConfigurationLbl = new System.Windows.Forms.Label();
            this.LimitTb = new Gurux.DLMS.UI.GXValueField();
            this.LimitLbl = new System.Windows.Forms.Label();
            this.WarningThresholdTb = new Gurux.DLMS.UI.GXValueField();
            this.WarningThresholdLbl = new System.Windows.Forms.Label();
            this.PriorityTb = new Gurux.DLMS.UI.GXValueField();
            this.PriorityLbl = new System.Windows.Forms.Label();
            this.TypeTb = new Gurux.DLMS.UI.GXValueField();
            this.TypeLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.CurrentCreditAmountTb = new Gurux.DLMS.UI.GXValueField();
            this.CurrentCreditAmountLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.InvokeCreditBtn = new Gurux.DLMS.UI.GXButton();
            this.SetAmountToValueBtn = new Gurux.DLMS.UI.GXButton();
            this.UpdateAmountBtn = new Gurux.DLMS.UI.GXButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UpdateAmountBtn);
            this.groupBox1.Controls.Add(this.SetAmountToValueBtn);
            this.groupBox1.Controls.Add(this.InvokeCreditBtn);
            this.groupBox1.Controls.Add(this.PeriodTb);
            this.groupBox1.Controls.Add(this.PeriodLbl);
            this.groupBox1.Controls.Add(this.CreditAvailableThresholdTb);
            this.groupBox1.Controls.Add(this.CreditAvailableThresholdLbl);
            this.groupBox1.Controls.Add(this.PresetCreditAmountTb);
            this.groupBox1.Controls.Add(this.PresetCreditAmountLbl);
            this.groupBox1.Controls.Add(this.StatusTb);
            this.groupBox1.Controls.Add(this.StatusLbl);
            this.groupBox1.Controls.Add(this.CreditConfigurationTb);
            this.groupBox1.Controls.Add(this.CreditConfigurationLbl);
            this.groupBox1.Controls.Add(this.LimitTb);
            this.groupBox1.Controls.Add(this.LimitLbl);
            this.groupBox1.Controls.Add(this.WarningThresholdTb);
            this.groupBox1.Controls.Add(this.WarningThresholdLbl);
            this.groupBox1.Controls.Add(this.PriorityTb);
            this.groupBox1.Controls.Add(this.PriorityLbl);
            this.groupBox1.Controls.Add(this.TypeTb);
            this.groupBox1.Controls.Add(this.TypeLbl);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.CurrentCreditAmountTb);
            this.groupBox1.Controls.Add(this.CurrentCreditAmountLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit Object";
            // 
            // PeriodTb
            // 
            this.PeriodTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PeriodTb.Index = 11;
            this.PeriodTb.Location = new System.Drawing.Point(145, 377);
            this.PeriodTb.Name = "PeriodTb";
            this.PeriodTb.NotifyChanges = false;
            this.PeriodTb.Size = new System.Drawing.Size(218, 20);
            this.PeriodTb.TabIndex = 12;
            this.PeriodTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PeriodLbl
            // 
            this.PeriodLbl.AutoSize = true;
            this.PeriodLbl.Location = new System.Drawing.Point(6, 380);
            this.PeriodLbl.Name = "PeriodLbl";
            this.PeriodLbl.Size = new System.Drawing.Size(40, 13);
            this.PeriodLbl.TabIndex = 23;
            this.PeriodLbl.Text = "Period:";
            // 
            // CreditAvailableThresholdTb
            // 
            this.CreditAvailableThresholdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditAvailableThresholdTb.Index = 10;
            this.CreditAvailableThresholdTb.Location = new System.Drawing.Point(145, 351);
            this.CreditAvailableThresholdTb.Name = "CreditAvailableThresholdTb";
            this.CreditAvailableThresholdTb.NotifyChanges = false;
            this.CreditAvailableThresholdTb.Size = new System.Drawing.Size(218, 20);
            this.CreditAvailableThresholdTb.TabIndex = 11;
            this.CreditAvailableThresholdTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // CreditAvailableThresholdLbl
            // 
            this.CreditAvailableThresholdLbl.AutoSize = true;
            this.CreditAvailableThresholdLbl.Location = new System.Drawing.Point(6, 354);
            this.CreditAvailableThresholdLbl.Name = "CreditAvailableThresholdLbl";
            this.CreditAvailableThresholdLbl.Size = new System.Drawing.Size(133, 13);
            this.CreditAvailableThresholdLbl.TabIndex = 21;
            this.CreditAvailableThresholdLbl.Text = "Credit Available Threshold:";
            // 
            // PresetCreditAmountTb
            // 
            this.PresetCreditAmountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetCreditAmountTb.Index = 9;
            this.PresetCreditAmountTb.Location = new System.Drawing.Point(145, 325);
            this.PresetCreditAmountTb.Name = "PresetCreditAmountTb";
            this.PresetCreditAmountTb.NotifyChanges = false;
            this.PresetCreditAmountTb.Size = new System.Drawing.Size(218, 20);
            this.PresetCreditAmountTb.TabIndex = 10;
            this.PresetCreditAmountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PresetCreditAmountLbl
            // 
            this.PresetCreditAmountLbl.AutoSize = true;
            this.PresetCreditAmountLbl.Location = new System.Drawing.Point(6, 328);
            this.PresetCreditAmountLbl.Name = "PresetCreditAmountLbl";
            this.PresetCreditAmountLbl.Size = new System.Drawing.Size(109, 13);
            this.PresetCreditAmountLbl.TabIndex = 19;
            this.PresetCreditAmountLbl.Text = "Preset Credit Amount:";
            // 
            // StatusTb
            // 
            this.StatusTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTb.Index = 8;
            this.StatusTb.Location = new System.Drawing.Point(145, 299);
            this.StatusTb.Name = "StatusTb";
            this.StatusTb.NotifyChanges = false;
            this.StatusTb.Size = new System.Drawing.Size(218, 20);
            this.StatusTb.TabIndex = 9;
            this.StatusTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(6, 302);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(40, 13);
            this.StatusLbl.TabIndex = 17;
            this.StatusLbl.Text = "Status:";
            // 
            // CreditConfigurationTb
            // 
            this.CreditConfigurationTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreditConfigurationTb.Index = 7;
            this.CreditConfigurationTb.Location = new System.Drawing.Point(146, 201);
            this.CreditConfigurationTb.Name = "CreditConfigurationTb";
            this.CreditConfigurationTb.NotifyChanges = false;
            this.CreditConfigurationTb.Size = new System.Drawing.Size(218, 92);
            this.CreditConfigurationTb.TabIndex = 8;
            this.CreditConfigurationTb.Type = Gurux.DLMS.Enums.ValueFieldType.CheckedListBox;
            // 
            // CreditConfigurationLbl
            // 
            this.CreditConfigurationLbl.AutoSize = true;
            this.CreditConfigurationLbl.Location = new System.Drawing.Point(7, 204);
            this.CreditConfigurationLbl.Name = "CreditConfigurationLbl";
            this.CreditConfigurationLbl.Size = new System.Drawing.Size(102, 13);
            this.CreditConfigurationLbl.TabIndex = 15;
            this.CreditConfigurationLbl.Text = "Credit Configuration:";
            // 
            // LimitTb
            // 
            this.LimitTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LimitTb.Index = 6;
            this.LimitTb.Location = new System.Drawing.Point(145, 175);
            this.LimitTb.Name = "LimitTb";
            this.LimitTb.NotifyChanges = false;
            this.LimitTb.Size = new System.Drawing.Size(218, 20);
            this.LimitTb.TabIndex = 7;
            this.LimitTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // LimitLbl
            // 
            this.LimitLbl.AutoSize = true;
            this.LimitLbl.Location = new System.Drawing.Point(6, 178);
            this.LimitLbl.Name = "LimitLbl";
            this.LimitLbl.Size = new System.Drawing.Size(31, 13);
            this.LimitLbl.TabIndex = 13;
            this.LimitLbl.Text = "Limit:";
            // 
            // WarningThresholdTb
            // 
            this.WarningThresholdTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WarningThresholdTb.Index = 5;
            this.WarningThresholdTb.Location = new System.Drawing.Point(145, 149);
            this.WarningThresholdTb.Name = "WarningThresholdTb";
            this.WarningThresholdTb.NotifyChanges = false;
            this.WarningThresholdTb.Size = new System.Drawing.Size(218, 20);
            this.WarningThresholdTb.TabIndex = 6;
            this.WarningThresholdTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // WarningThresholdLbl
            // 
            this.WarningThresholdLbl.AutoSize = true;
            this.WarningThresholdLbl.Location = new System.Drawing.Point(6, 152);
            this.WarningThresholdLbl.Name = "WarningThresholdLbl";
            this.WarningThresholdLbl.Size = new System.Drawing.Size(100, 13);
            this.WarningThresholdLbl.TabIndex = 11;
            this.WarningThresholdLbl.Text = "Warning Threshold:";
            // 
            // PriorityTb
            // 
            this.PriorityTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityTb.Index = 4;
            this.PriorityTb.Location = new System.Drawing.Point(145, 123);
            this.PriorityTb.Name = "PriorityTb";
            this.PriorityTb.NotifyChanges = false;
            this.PriorityTb.Size = new System.Drawing.Size(218, 20);
            this.PriorityTb.TabIndex = 5;
            this.PriorityTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // PriorityLbl
            // 
            this.PriorityLbl.AutoSize = true;
            this.PriorityLbl.Location = new System.Drawing.Point(6, 126);
            this.PriorityLbl.Name = "PriorityLbl";
            this.PriorityLbl.Size = new System.Drawing.Size(41, 13);
            this.PriorityLbl.TabIndex = 9;
            this.PriorityLbl.Text = "Priority:";
            // 
            // TypeTb
            // 
            this.TypeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeTb.Index = 3;
            this.TypeTb.Location = new System.Drawing.Point(146, 97);
            this.TypeTb.Name = "TypeTb";
            this.TypeTb.NotifyChanges = false;
            this.TypeTb.Size = new System.Drawing.Size(218, 20);
            this.TypeTb.TabIndex = 4;
            this.TypeTb.Type = Gurux.DLMS.Enums.ValueFieldType.CompoBox;
            // 
            // TypeLbl
            // 
            this.TypeLbl.AutoSize = true;
            this.TypeLbl.Location = new System.Drawing.Point(7, 100);
            this.TypeLbl.Name = "TypeLbl";
            this.TypeLbl.Size = new System.Drawing.Size(34, 13);
            this.TypeLbl.TabIndex = 7;
            this.TypeLbl.Text = "Type:";
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
            this.DescriptionTB.Location = new System.Drawing.Point(145, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(219, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // CurrentCreditAmountTb
            // 
            this.CurrentCreditAmountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentCreditAmountTb.Index = 2;
            this.CurrentCreditAmountTb.Location = new System.Drawing.Point(146, 71);
            this.CurrentCreditAmountTb.Name = "CurrentCreditAmountTb";
            this.CurrentCreditAmountTb.NotifyChanges = false;
            this.CurrentCreditAmountTb.Size = new System.Drawing.Size(218, 20);
            this.CurrentCreditAmountTb.TabIndex = 3;
            this.CurrentCreditAmountTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            this.CurrentCreditAmountTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTB_KeyPress);
            this.CurrentCreditAmountTb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ValueTB_KeyUp);
            // 
            // CurrentCreditAmountLbl
            // 
            this.CurrentCreditAmountLbl.AutoSize = true;
            this.CurrentCreditAmountLbl.Location = new System.Drawing.Point(7, 74);
            this.CurrentCreditAmountLbl.Name = "CurrentCreditAmountLbl";
            this.CurrentCreditAmountLbl.Size = new System.Drawing.Size(113, 13);
            this.CurrentCreditAmountLbl.TabIndex = 2;
            this.CurrentCreditAmountLbl.Text = "Current Credit Amount:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(145, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(218, 20);
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
            // InvokeCreditBtn
            // 
            this.InvokeCreditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InvokeCreditBtn.Index = 3;
            this.InvokeCreditBtn.Location = new System.Drawing.Point(264, 403);
            this.InvokeCreditBtn.Name = "InvokeCreditBtn";
            this.InvokeCreditBtn.Size = new System.Drawing.Size(100, 23);
            this.InvokeCreditBtn.TabIndex = 14;
            this.InvokeCreditBtn.Text = "Invoke Credit...";
            this.InvokeCreditBtn.UseVisualStyleBackColor = true;
            // 
            // SetAmountToValueBtn
            // 
            this.SetAmountToValueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetAmountToValueBtn.Index = 2;
            this.SetAmountToValueBtn.Location = new System.Drawing.Point(158, 403);
            this.SetAmountToValueBtn.Name = "SetAmountToValueBtn";
            this.SetAmountToValueBtn.Size = new System.Drawing.Size(100, 23);
            this.SetAmountToValueBtn.TabIndex = 13;
            this.SetAmountToValueBtn.Text = "Set Amount...";
            this.SetAmountToValueBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateAmountBtn
            // 
            this.UpdateAmountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateAmountBtn.Index = 1;
            this.UpdateAmountBtn.Location = new System.Drawing.Point(52, 403);
            this.UpdateAmountBtn.Name = "UpdateAmountBtn";
            this.UpdateAmountBtn.Size = new System.Drawing.Size(100, 23);
            this.UpdateAmountBtn.TabIndex = 12;
            this.UpdateAmountBtn.Text = "Update Amount...";
            this.UpdateAmountBtn.UseVisualStyleBackColor = true;
            // 
            // GXDLMSCreditView
            // 
            this.ClientSize = new System.Drawing.Size(409, 467);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSCreditView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField PeriodTb;
        private Label PeriodLbl;
        private GXValueField CreditAvailableThresholdTb;
        private Label CreditAvailableThresholdLbl;
        private GXValueField PresetCreditAmountTb;
        private Label PresetCreditAmountLbl;
        private GXValueField StatusTb;
        private Label StatusLbl;
        private GXValueField CreditConfigurationTb;
        private Label CreditConfigurationLbl;
        private GXValueField LimitTb;
        private Label LimitLbl;
        private GXValueField WarningThresholdTb;
        private Label WarningThresholdLbl;
        private GXValueField PriorityTb;
        private Label PriorityLbl;
        private GXValueField TypeTb;
        private Label TypeLbl;
        private GXButton UpdateAmountBtn;
        private GXButton SetAmountToValueBtn;
        private GXButton InvokeCreditBtn;
    }
}
