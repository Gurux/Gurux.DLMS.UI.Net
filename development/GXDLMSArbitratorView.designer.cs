using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSArbitratorView
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
        private Label LastOutcomeLbl;
        private GXValueField LogicalNameTB;
        private ErrorProvider errorProvider1;
        private Label DescriptionLbl;
        private TextBox DescriptionTB;
        private Label LogicalNameLbl;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSArbitratorView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RequestActionBtn = new Gurux.DLMS.UI.GXButton();
            this.ResetBtn = new Gurux.DLMS.UI.GXButton();
            this.ActionsLbl = new System.Windows.Forms.Label();
            this.LastOutcomeTb = new Gurux.DLMS.UI.GXValueField();
            this.ActionsView = new System.Windows.Forms.ListView();
            this.AScriptCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ASelectorCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllowedCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeightingsCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MostRecentCh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.LastOutcomeLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RequestActionBtn);
            this.groupBox1.Controls.Add(this.ResetBtn);
            this.groupBox1.Controls.Add(this.ActionsLbl);
            this.groupBox1.Controls.Add(this.LastOutcomeTb);
            this.groupBox1.Controls.Add(this.ActionsView);
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Controls.Add(this.DescriptionTB);
            this.groupBox1.Controls.Add(this.LastOutcomeLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(635, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arbitrator Object";
            // 
            // RequestActionBtn
            // 
            this.RequestActionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RequestActionBtn.Index = 1;
            this.RequestActionBtn.Location = new System.Drawing.Point(439, 68);
            this.RequestActionBtn.Name = "RequestActionBtn";
            this.RequestActionBtn.Size = new System.Drawing.Size(94, 23);
            this.RequestActionBtn.TabIndex = 25;
            this.RequestActionBtn.Text = "Request Action";
            this.RequestActionBtn.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Index = 2;
            this.ResetBtn.Location = new System.Drawing.Point(539, 68);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 24;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            // 
            // ActionsLbl
            // 
            this.ActionsLbl.AutoSize = true;
            this.ActionsLbl.Location = new System.Drawing.Point(7, 100);
            this.ActionsLbl.Name = "ActionsLbl";
            this.ActionsLbl.Size = new System.Drawing.Size(45, 13);
            this.ActionsLbl.TabIndex = 23;
            this.ActionsLbl.Text = "Actions:";
            // 
            // LastOutcomeTb
            // 
            this.LastOutcomeTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastOutcomeTb.Index = 6;
            this.LastOutcomeTb.Location = new System.Drawing.Point(103, 71);
            this.LastOutcomeTb.Name = "LastOutcomeTb";
            this.LastOutcomeTb.NotifyChanges = false;
            this.LastOutcomeTb.Size = new System.Drawing.Size(81, 20);
            this.LastOutcomeTb.TabIndex = 22;
            this.LastOutcomeTb.Type = Gurux.DLMS.Enums.ValueFieldType.TextBox;
            // 
            // ActionsView
            // 
            this.ActionsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AScriptCh,
            this.ASelectorCh,
            this.AllowedCh,
            this.WeightingsCh,
            this.MostRecentCh});
            this.ActionsView.FullRowSelect = true;
            this.ActionsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ActionsView.HideSelection = false;
            this.ActionsView.Location = new System.Drawing.Point(103, 97);
            this.ActionsView.Name = "ActionsView";
            this.ActionsView.Size = new System.Drawing.Size(510, 322);
            this.ActionsView.TabIndex = 21;
            this.ActionsView.UseCompatibleStateImageBehavior = false;
            this.ActionsView.View = System.Windows.Forms.View.Details;
            // 
            // AScriptCh
            // 
            this.AScriptCh.Text = "Script";
            this.AScriptCh.Width = 149;
            // 
            // ASelectorCh
            // 
            this.ASelectorCh.Text = "Selector";
            this.ASelectorCh.Width = 62;
            // 
            // AllowedCh
            // 
            this.AllowedCh.Text = "Allowed:";
            // 
            // WeightingsCh
            // 
            this.WeightingsCh.Text = "Weightings:";
            this.WeightingsCh.Width = 140;
            // 
            // MostRecentCh
            // 
            this.MostRecentCh.Text = "Most Recent";
            this.MostRecentCh.Width = 89;
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
            this.DescriptionTB.Location = new System.Drawing.Point(103, 19);
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.ReadOnly = true;
            this.DescriptionTB.Size = new System.Drawing.Size(511, 20);
            this.DescriptionTB.TabIndex = 1;
            // 
            // LastOutcomeLbl
            // 
            this.LastOutcomeLbl.AutoSize = true;
            this.LastOutcomeLbl.Location = new System.Drawing.Point(7, 74);
            this.LastOutcomeLbl.Name = "LastOutcomeLbl";
            this.LastOutcomeLbl.Size = new System.Drawing.Size(76, 13);
            this.LastOutcomeLbl.TabIndex = 2;
            this.LastOutcomeLbl.Text = "Last Outcome:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(103, 45);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.NotifyChanges = false;
            this.LogicalNameTB.Size = new System.Drawing.Size(510, 20);
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
            // GXDLMSArbitratorView
            // 
            this.ClientSize = new System.Drawing.Size(659, 449);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GXDLMSArbitratorView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GXValueField LastOutcomeTb;
        private ColumnHeader AScriptCh;
        private ColumnHeader ASelectorCh;
        private Label ActionsLbl;
        private ColumnHeader AllowedCh;
        private ColumnHeader WeightingsCh;
        private ColumnHeader MostRecentCh;
        private GXButton RequestActionBtn;
        private GXButton ResetBtn;
        private ListView ActionsView;
    }
}
