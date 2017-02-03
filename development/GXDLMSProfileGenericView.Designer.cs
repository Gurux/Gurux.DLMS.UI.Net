using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;

namespace Gurux.DLMS.UI
{
    public partial class GXDLMSProfileGenericView
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
        private GXValueField LogicalNameTB;
        private Label LogicalNameLbl;
        private GXValueField EntriesTB;
        private GXValueField EntriesInUseTB;
        private Label label1;
        private GroupBox groupBox2;
        private Label DaysLbl;
        private Label ToLbl;
        private DateTimePicker ToPick;
        private DateTimePicker StartPick;
        private RadioButton ReadFromRB;
        private RadioButton ReadLastRB;
        private RadioButton ReadEntryBtn;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView ProfileGenericView;
        private TabPage tabPage2;
        private Label label2;
        private NumericUpDown EndEntry;
        private NumericUpDown StartEntry;
        private NumericUpDown ReadLastTB;
        private GroupBox groupBox3;
        private Label label3;
        private GXValueField SortObjectTB;
        private Label label4;
        private GXValueField SortModeTB;
        private Label label5;
        private GXValueField CapturePeriodTB;
        private ErrorProvider errorProvider1;
        private RadioButton ReadAllRB;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GXDLMSProfileGenericView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CapturePeriodTB = new Gurux.DLMS.UI.GXValueField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SortObjectTB = new Gurux.DLMS.UI.GXValueField();
            this.label4 = new System.Windows.Forms.Label();
            this.SortModeTB = new Gurux.DLMS.UI.GXValueField();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ProfileGenericView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ReadAllRB = new System.Windows.Forms.RadioButton();
            this.ReadLastTB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.EndEntry = new System.Windows.Forms.NumericUpDown();
            this.StartEntry = new System.Windows.Forms.NumericUpDown();
            this.DaysLbl = new System.Windows.Forms.Label();
            this.ToLbl = new System.Windows.Forms.Label();
            this.ToPick = new System.Windows.Forms.DateTimePicker();
            this.StartPick = new System.Windows.Forms.DateTimePicker();
            this.ReadFromRB = new System.Windows.Forms.RadioButton();
            this.ReadLastRB = new System.Windows.Forms.RadioButton();
            this.ReadEntryBtn = new System.Windows.Forms.RadioButton();
            this.EntriesTB = new Gurux.DLMS.UI.GXValueField();
            this.EntriesInUseTB = new Gurux.DLMS.UI.GXValueField();
            this.LogicalNameLbl = new System.Windows.Forms.Label();
            this.LogicalNameTB = new Gurux.DLMS.UI.GXValueField();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfileGenericView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadLastTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CapturePeriodTB);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.EntriesTB);
            this.groupBox1.Controls.Add(this.EntriesInUseTB);
            this.groupBox1.Controls.Add(this.LogicalNameLbl);
            this.groupBox1.Controls.Add(this.LogicalNameTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 572);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile Generic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Period:";
            // 
            // CapturePeriodTB
            // 
            this.CapturePeriodTB.Index = 4;
            this.CapturePeriodTB.Location = new System.Drawing.Point(297, 144);
            this.CapturePeriodTB.Name = "CapturePeriodTB";
            this.CapturePeriodTB.Size = new System.Drawing.Size(185, 20);
            this.CapturePeriodTB.TabIndex = 15;
            this.CapturePeriodTB.TabStop = false;
            this.CapturePeriodTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.SortObjectTB);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.SortModeTB);
            this.groupBox3.Location = new System.Drawing.Point(3, 193);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 49);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Object:";
            // 
            // SortObjectTB
            // 
            this.SortObjectTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortObjectTB.Index = 6;
            this.SortObjectTB.Location = new System.Drawing.Point(294, 18);
            this.SortObjectTB.Name = "SortObjectTB";
            this.SortObjectTB.Size = new System.Drawing.Size(185, 20);
            this.SortObjectTB.TabIndex = 15;
            this.SortObjectTB.TabStop = false;
            this.SortObjectTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mode:";
            // 
            // SortModeTB
            // 
            this.SortModeTB.Index = 5;
            this.SortModeTB.Location = new System.Drawing.Point(94, 18);
            this.SortModeTB.Name = "SortModeTB";
            this.SortModeTB.ReadOnly = true;
            this.SortModeTB.Size = new System.Drawing.Size(134, 20);
            this.SortModeTB.TabIndex = 13;
            this.SortModeTB.TabStop = false;
            this.SortModeTB.Type = Gurux.DLMS.UI.GXValueFieldType.CompoBox;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 249);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 317);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ProfileGenericView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ProfileGenericView
            // 
            this.ProfileGenericView.AllowUserToAddRows = false;
            this.ProfileGenericView.AllowUserToDeleteRows = false;
            this.ProfileGenericView.AllowUserToOrderColumns = true;
            this.ProfileGenericView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfileGenericView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileGenericView.Location = new System.Drawing.Point(3, 3);
            this.ProfileGenericView.Name = "ProfileGenericView";
            this.ProfileGenericView.ReadOnly = true;
            this.ProfileGenericView.ShowCellErrors = false;
            this.ProfileGenericView.ShowRowErrors = false;
            this.ProfileGenericView.Size = new System.Drawing.Size(476, 285);
            this.ProfileGenericView.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ReadAllRB);
            this.groupBox2.Controls.Add(this.ReadLastTB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.EndEntry);
            this.groupBox2.Controls.Add(this.StartEntry);
            this.groupBox2.Controls.Add(this.DaysLbl);
            this.groupBox2.Controls.Add(this.ToLbl);
            this.groupBox2.Controls.Add(this.ToPick);
            this.groupBox2.Controls.Add(this.StartPick);
            this.groupBox2.Controls.Add(this.ReadFromRB);
            this.groupBox2.Controls.Add(this.ReadLastRB);
            this.groupBox2.Controls.Add(this.ReadEntryBtn);
            this.groupBox2.Location = new System.Drawing.Point(5, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reading";
            // 
            // ReadAllRB
            // 
            this.ReadAllRB.Location = new System.Drawing.Point(6, 89);
            this.ReadAllRB.Name = "ReadAllRB";
            this.ReadAllRB.Size = new System.Drawing.Size(80, 16);
            this.ReadAllRB.TabIndex = 9;
            this.ReadAllRB.Text = "All";
            this.ReadAllRB.CheckedChanged += new System.EventHandler(this.ReadAllRB_CheckedChanged);
            // 
            // ReadLastTB
            // 
            this.ReadLastTB.Location = new System.Drawing.Point(94, 45);
            this.ReadLastTB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ReadLastTB.Name = "ReadLastTB";
            this.ReadLastTB.Size = new System.Drawing.Size(114, 20);
            this.ReadLastTB.TabIndex = 12;
            this.ReadLastTB.ValueChanged += new System.EventHandler(this.ReadLastTB_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Count:";
            // 
            // EndEntry
            // 
            this.EndEntry.Location = new System.Drawing.Point(238, 20);
            this.EndEntry.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.EndEntry.Name = "EndEntry";
            this.EndEntry.Size = new System.Drawing.Size(112, 20);
            this.EndEntry.TabIndex = 11;
            this.EndEntry.ValueChanged += new System.EventHandler(this.StartEntry_ValueChanged);
            // 
            // StartEntry
            // 
            this.StartEntry.Location = new System.Drawing.Point(94, 19);
            this.StartEntry.Name = "StartEntry";
            this.StartEntry.Size = new System.Drawing.Size(86, 20);
            this.StartEntry.TabIndex = 10;
            this.StartEntry.ValueChanged += new System.EventHandler(this.StartEntry_ValueChanged);
            // 
            // DaysLbl
            // 
            this.DaysLbl.Location = new System.Drawing.Point(214, 43);
            this.DaysLbl.Name = "DaysLbl";
            this.DaysLbl.Size = new System.Drawing.Size(72, 16);
            this.DaysLbl.TabIndex = 16;
            this.DaysLbl.Text = "Days";
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Location = new System.Drawing.Point(214, 70);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(20, 13);
            this.ToLbl.TabIndex = 15;
            this.ToLbl.Text = "To";
            // 
            // ToPick
            // 
            this.ToPick.Checked = false;
            this.ToPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToPick.Location = new System.Drawing.Point(238, 67);
            this.ToPick.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.ToPick.Name = "ToPick";
            this.ToPick.ShowCheckBox = true;
            this.ToPick.Size = new System.Drawing.Size(112, 20);
            this.ToPick.TabIndex = 14;
            this.ToPick.ValueChanged += new System.EventHandler(this.StartPick_ValueChanged);
            // 
            // StartPick
            // 
            this.StartPick.Checked = false;
            this.StartPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartPick.Location = new System.Drawing.Point(94, 67);
            this.StartPick.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.StartPick.Name = "StartPick";
            this.StartPick.ShowCheckBox = true;
            this.StartPick.Size = new System.Drawing.Size(112, 20);
            this.StartPick.TabIndex = 13;
            this.StartPick.ValueChanged += new System.EventHandler(this.StartPick_ValueChanged);
            // 
            // ReadFromRB
            // 
            this.ReadFromRB.Location = new System.Drawing.Point(6, 67);
            this.ReadFromRB.Name = "ReadFromRB";
            this.ReadFromRB.Size = new System.Drawing.Size(80, 16);
            this.ReadFromRB.TabIndex = 9;
            this.ReadFromRB.Text = "Read From";
            this.ReadFromRB.CheckedChanged += new System.EventHandler(this.ReadFromRB_CheckedChanged);
            // 
            // ReadLastRB
            // 
            this.ReadLastRB.Checked = true;
            this.ReadLastRB.Location = new System.Drawing.Point(6, 43);
            this.ReadLastRB.Name = "ReadLastRB";
            this.ReadLastRB.Size = new System.Drawing.Size(80, 16);
            this.ReadLastRB.TabIndex = 9;
            this.ReadLastRB.TabStop = true;
            this.ReadLastRB.Text = "Read last";
            this.ReadLastRB.CheckedChanged += new System.EventHandler(this.ReadLastRB_CheckedChanged);
            // 
            // ReadEntryBtn
            // 
            this.ReadEntryBtn.Location = new System.Drawing.Point(6, 19);
            this.ReadEntryBtn.Name = "ReadEntryBtn";
            this.ReadEntryBtn.Size = new System.Drawing.Size(80, 16);
            this.ReadEntryBtn.TabIndex = 9;
            this.ReadEntryBtn.Text = "Read Entry:";
            this.ReadEntryBtn.CheckedChanged += new System.EventHandler(this.ReadEntryRB_CheckedChanged);
            // 
            // EntriesTB
            // 
            this.EntriesTB.Index = 8;
            this.EntriesTB.Location = new System.Drawing.Point(186, 167);
            this.EntriesTB.Name = "EntriesTB";
            this.EntriesTB.Size = new System.Drawing.Size(57, 20);
            this.EntriesTB.TabIndex = 7;
            this.EntriesTB.TabStop = false;
            this.EntriesTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // EntriesInUseTB
            // 
            this.EntriesInUseTB.Index = 7;
            this.EntriesInUseTB.Location = new System.Drawing.Point(94, 167);
            this.EntriesInUseTB.Name = "EntriesInUseTB";
            this.EntriesInUseTB.Size = new System.Drawing.Size(66, 20);
            this.EntriesInUseTB.TabIndex = 5;
            this.EntriesInUseTB.TabStop = false;
            this.EntriesInUseTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // LogicalNameLbl
            // 
            this.LogicalNameLbl.AutoSize = true;
            this.LogicalNameLbl.Location = new System.Drawing.Point(10, 144);
            this.LogicalNameLbl.Name = "LogicalNameLbl";
            this.LogicalNameLbl.Size = new System.Drawing.Size(75, 13);
            this.LogicalNameLbl.TabIndex = 0;
            this.LogicalNameLbl.Text = "Logical Name:";
            // 
            // LogicalNameTB
            // 
            this.LogicalNameTB.Index = 1;
            this.LogicalNameTB.Location = new System.Drawing.Point(94, 141);
            this.LogicalNameTB.Name = "LogicalNameTB";
            this.LogicalNameTB.Size = new System.Drawing.Size(140, 20);
            this.LogicalNameTB.TabIndex = 1;
            this.LogicalNameTB.TabStop = false;
            this.LogicalNameTB.Type = Gurux.DLMS.UI.GXValueFieldType.TextBox;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entries:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // GXDLMSProfileGenericView
            // 
            this.ClientSize = new System.Drawing.Size(517, 582);
            this.Controls.Add(this.groupBox1);
            this.Name = "GXDLMSProfileGenericView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfileGenericView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReadLastTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion


    }
}
