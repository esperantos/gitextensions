namespace GitUI.UserControls
{
    partial class ReviewStatisticControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.collapseLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.collapseLabel = new System.Windows.Forms.Label();
            this.statisticsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.notReviewedCountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notReviewedLabel = new System.Windows.Forms.Label();
            this.declinedCountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.declinedLabel = new System.Windows.Forms.Label();
            this.careLabel = new System.Windows.Forms.Label();
            this.correctedCountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.correctedLabel = new System.Windows.Forms.Label();
            this.newCountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newLabel = new System.Windows.Forms.Label();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.forComboBox = new System.Windows.Forms.ComboBox();
            this.forLabel = new System.Windows.Forms.Label();
            this.notReviewedCheckBox = new System.Windows.Forms.CheckBox();
            this.declinedCheckBox = new System.Windows.Forms.CheckBox();
            this.correctedCheckBox = new System.Windows.Forms.CheckBox();
            this.newCheckBox = new System.Windows.Forms.CheckBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.collapseLayoutPanel.SuspendLayout();
            this.statisticsLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // collapseLayoutPanel
            // 
            this.collapseLayoutPanel.AutoSize = true;
            this.collapseLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.collapseLayoutPanel.ColumnCount = 2;
            this.collapseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.collapseLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.collapseLayoutPanel.Controls.Add(this.collapseLabel, 0, 0);
            this.collapseLayoutPanel.Controls.Add(this.statisticsLayoutPanel, 1, 0);
            this.collapseLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapseLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.collapseLayoutPanel.Name = "collapseLayoutPanel";
            this.collapseLayoutPanel.RowCount = 1;
            this.collapseLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.collapseLayoutPanel.Size = new System.Drawing.Size(351, 271);
            this.collapseLayoutPanel.TabIndex = 0;
            // 
            // collapseLabel
            // 
            this.collapseLabel.AutoSize = true;
            this.collapseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collapseLabel.Location = new System.Drawing.Point(0, 0);
            this.collapseLabel.Margin = new System.Windows.Forms.Padding(0);
            this.collapseLabel.Name = "collapseLabel";
            this.collapseLabel.Size = new System.Drawing.Size(15, 271);
            this.collapseLabel.TabIndex = 0;
            this.collapseLabel.Text = ">";
            this.collapseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.collapseLabel.Click += new System.EventHandler(this.collapseLabel_Click);
            // 
            // statisticsLayoutPanel
            // 
            this.statisticsLayoutPanel.AutoSize = true;
            this.statisticsLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.statisticsLayoutPanel.ColumnCount = 3;
            this.statisticsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.statisticsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.statisticsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.statisticsLayoutPanel.Controls.Add(this.mainLabel, 0, 0);
            this.statisticsLayoutPanel.Controls.Add(this.notReviewedCountLinkLabel, 2, 8);
            this.statisticsLayoutPanel.Controls.Add(this.notReviewedLabel, 1, 8);
            this.statisticsLayoutPanel.Controls.Add(this.declinedCountLinkLabel, 2, 7);
            this.statisticsLayoutPanel.Controls.Add(this.declinedLabel, 1, 7);
            this.statisticsLayoutPanel.Controls.Add(this.careLabel, 1, 6);
            this.statisticsLayoutPanel.Controls.Add(this.correctedCountLinkLabel, 2, 5);
            this.statisticsLayoutPanel.Controls.Add(this.correctedLabel, 1, 5);
            this.statisticsLayoutPanel.Controls.Add(this.newCountLinkLabel, 2, 4);
            this.statisticsLayoutPanel.Controls.Add(this.newLabel, 1, 4);
            this.statisticsLayoutPanel.Controls.Add(this.reviewLabel, 1, 3);
            this.statisticsLayoutPanel.Controls.Add(this.forComboBox, 2, 1);
            this.statisticsLayoutPanel.Controls.Add(this.forLabel, 1, 1);
            this.statisticsLayoutPanel.Controls.Add(this.notReviewedCheckBox, 0, 8);
            this.statisticsLayoutPanel.Controls.Add(this.declinedCheckBox, 0, 7);
            this.statisticsLayoutPanel.Controls.Add(this.correctedCheckBox, 0, 5);
            this.statisticsLayoutPanel.Controls.Add(this.newCheckBox, 0, 4);
            this.statisticsLayoutPanel.Controls.Add(this.fromLabel, 1, 2);
            this.statisticsLayoutPanel.Controls.Add(this.fromDatePicker, 2, 2);
            this.statisticsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsLayoutPanel.Location = new System.Drawing.Point(18, 3);
            this.statisticsLayoutPanel.Name = "statisticsLayoutPanel";
            this.statisticsLayoutPanel.RowCount = 10;
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.statisticsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.statisticsLayoutPanel.Size = new System.Drawing.Size(330, 265);
            this.statisticsLayoutPanel.TabIndex = 1;
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.statisticsLayoutPanel.SetColumnSpan(this.mainLabel, 2);
            this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mainLabel.Location = new System.Drawing.Point(3, 3);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(118, 20);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Review Statistics";
            // 
            // notReviewedCountLinkLabel
            // 
            this.notReviewedCountLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.notReviewedCountLinkLabel.AutoSize = true;
            this.notReviewedCountLinkLabel.Location = new System.Drawing.Point(127, 227);
            this.notReviewedCountLinkLabel.Name = "notReviewedCountLinkLabel";
            this.notReviewedCountLinkLabel.Size = new System.Drawing.Size(13, 15);
            this.notReviewedCountLinkLabel.TabIndex = 12;
            this.notReviewedCountLinkLabel.TabStop = true;
            this.notReviewedCountLinkLabel.Text = "5";
            this.notReviewedCountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FilterLinkLabel_LinkClicked);
            // 
            // notReviewedLabel
            // 
            this.notReviewedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.notReviewedLabel.AutoSize = true;
            this.notReviewedLabel.Location = new System.Drawing.Point(24, 227);
            this.notReviewedLabel.Name = "notReviewedLabel";
            this.notReviewedLabel.Size = new System.Drawing.Size(80, 15);
            this.notReviewedLabel.TabIndex = 11;
            this.notReviewedLabel.Text = "Not reviewed:";
            // 
            // declinedCountLinkLabel
            // 
            this.declinedCountLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.declinedCountLinkLabel.AutoSize = true;
            this.declinedCountLinkLabel.Location = new System.Drawing.Point(127, 207);
            this.declinedCountLinkLabel.Name = "declinedCountLinkLabel";
            this.declinedCountLinkLabel.Size = new System.Drawing.Size(19, 15);
            this.declinedCountLinkLabel.TabIndex = 10;
            this.declinedCountLinkLabel.TabStop = true;
            this.declinedCountLinkLabel.Text = "10";
            this.declinedCountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FilterLinkLabel_LinkClicked);
            // 
            // declinedLabel
            // 
            this.declinedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.declinedLabel.AutoSize = true;
            this.declinedLabel.Location = new System.Drawing.Point(24, 207);
            this.declinedLabel.Name = "declinedLabel";
            this.declinedLabel.Size = new System.Drawing.Size(56, 15);
            this.declinedLabel.TabIndex = 9;
            this.declinedLabel.Text = "Declined:";
            // 
            // careLabel
            // 
            this.careLabel.AutoSize = true;
            this.statisticsLayoutPanel.SetColumnSpan(this.careLabel, 2);
            this.careLabel.Location = new System.Drawing.Point(24, 187);
            this.careLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.careLabel.Name = "careLabel";
            this.careLabel.Size = new System.Drawing.Size(97, 15);
            this.careLabel.TabIndex = 8;
            this.careLabel.Text = "Commits of art_z";
            // 
            // correctedCountLinkLabel
            // 
            this.correctedCountLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.correctedCountLinkLabel.AutoSize = true;
            this.correctedCountLinkLabel.Location = new System.Drawing.Point(127, 154);
            this.correctedCountLinkLabel.Name = "correctedCountLinkLabel";
            this.correctedCountLinkLabel.Size = new System.Drawing.Size(19, 15);
            this.correctedCountLinkLabel.TabIndex = 7;
            this.correctedCountLinkLabel.TabStop = true;
            this.correctedCountLinkLabel.Text = "15";
            this.correctedCountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FilterLinkLabel_LinkClicked);
            // 
            // correctedLabel
            // 
            this.correctedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.correctedLabel.AutoSize = true;
            this.correctedLabel.Location = new System.Drawing.Point(24, 154);
            this.correctedLabel.Name = "correctedLabel";
            this.correctedLabel.Size = new System.Drawing.Size(62, 15);
            this.correctedLabel.TabIndex = 6;
            this.correctedLabel.Text = "Corrected:";
            // 
            // newCountLinkLabel
            // 
            this.newCountLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newCountLinkLabel.AutoSize = true;
            this.newCountLinkLabel.Location = new System.Drawing.Point(127, 134);
            this.newCountLinkLabel.Name = "newCountLinkLabel";
            this.newCountLinkLabel.Size = new System.Drawing.Size(19, 15);
            this.newCountLinkLabel.TabIndex = 5;
            this.newCountLinkLabel.TabStop = true;
            this.newCountLinkLabel.Text = "20";
            this.newCountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FilterLinkLabel_LinkClicked);
            // 
            // newLabel
            // 
            this.newLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newLabel.AutoSize = true;
            this.newLabel.Location = new System.Drawing.Point(24, 134);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(34, 15);
            this.newLabel.TabIndex = 4;
            this.newLabel.Text = "New:";
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.statisticsLayoutPanel.SetColumnSpan(this.reviewLabel, 2);
            this.reviewLabel.Location = new System.Drawing.Point(24, 114);
            this.reviewLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(107, 15);
            this.reviewLabel.TabIndex = 3;
            this.reviewLabel.Text = "Commits to review";
            // 
            // forComboBox
            // 
            this.forComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.forComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.forComboBox.FormattingEnabled = true;
            this.forComboBox.Location = new System.Drawing.Point(127, 46);
            this.forComboBox.Name = "forComboBox";
            this.forComboBox.Size = new System.Drawing.Size(200, 23);
            this.forComboBox.TabIndex = 2;
            this.forComboBox.SelectedIndexChanged += new System.EventHandler(this.forComboBox_SelectedIndexChanged);
            // 
            // forLabel
            // 
            this.forLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.forLabel.AutoSize = true;
            this.forLabel.Location = new System.Drawing.Point(24, 49);
            this.forLabel.Name = "forLabel";
            this.forLabel.Size = new System.Drawing.Size(27, 15);
            this.forLabel.TabIndex = 1;
            this.forLabel.Text = "For:";
            this.forLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // notReviewedCheckBox
            // 
            this.notReviewedCheckBox.AutoSize = true;
            this.notReviewedCheckBox.Location = new System.Drawing.Point(3, 228);
            this.notReviewedCheckBox.Name = "notReviewedCheckBox";
            this.notReviewedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.notReviewedCheckBox.TabIndex = 13;
            this.notReviewedCheckBox.UseVisualStyleBackColor = true;
            this.notReviewedCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // declinedCheckBox
            // 
            this.declinedCheckBox.AutoSize = true;
            this.declinedCheckBox.Location = new System.Drawing.Point(3, 208);
            this.declinedCheckBox.Name = "declinedCheckBox";
            this.declinedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.declinedCheckBox.TabIndex = 14;
            this.declinedCheckBox.UseVisualStyleBackColor = true;
            this.declinedCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // correctedCheckBox
            // 
            this.correctedCheckBox.AutoSize = true;
            this.correctedCheckBox.Location = new System.Drawing.Point(3, 155);
            this.correctedCheckBox.Name = "correctedCheckBox";
            this.correctedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.correctedCheckBox.TabIndex = 15;
            this.correctedCheckBox.UseVisualStyleBackColor = true;
            this.correctedCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // newCheckBox
            // 
            this.newCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newCheckBox.AutoSize = true;
            this.newCheckBox.Location = new System.Drawing.Point(3, 135);
            this.newCheckBox.Name = "newCheckBox";
            this.newCheckBox.Size = new System.Drawing.Size(15, 14);
            this.newCheckBox.TabIndex = 16;
            this.newCheckBox.UseVisualStyleBackColor = true;
            this.newCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(24, 77);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(38, 15);
            this.fromLabel.TabIndex = 17;
            this.fromLabel.Text = "From:";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(127, 73);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(200, 23);
            this.fromDatePicker.TabIndex = 18;
            this.fromDatePicker.Value = new System.DateTime(2014, 3, 24, 0, 0, 0, 0);
            this.fromDatePicker.ValueChanged += new System.EventHandler(this.fromDatePicker_ValueChanged);
            // 
            // ReviewStatisticControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.collapseLayoutPanel);
            this.Name = "ReviewStatisticControl";
            this.Size = new System.Drawing.Size(351, 271);
            this.collapseLayoutPanel.ResumeLayout(false);
            this.collapseLayoutPanel.PerformLayout();
            this.statisticsLayoutPanel.ResumeLayout(false);
            this.statisticsLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel collapseLayoutPanel;
        private System.Windows.Forms.Label collapseLabel;
        private System.Windows.Forms.TableLayoutPanel statisticsLayoutPanel;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label forLabel;
        private System.Windows.Forms.ComboBox forComboBox;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.LinkLabel newCountLinkLabel;
        private System.Windows.Forms.Label correctedLabel;
        private System.Windows.Forms.LinkLabel correctedCountLinkLabel;
        private System.Windows.Forms.Label careLabel;
        private System.Windows.Forms.Label declinedLabel;
        private System.Windows.Forms.LinkLabel declinedCountLinkLabel;
        private System.Windows.Forms.Label notReviewedLabel;
        private System.Windows.Forms.LinkLabel notReviewedCountLinkLabel;
        private System.Windows.Forms.CheckBox notReviewedCheckBox;
        private System.Windows.Forms.CheckBox declinedCheckBox;
        private System.Windows.Forms.CheckBox correctedCheckBox;
        private System.Windows.Forms.CheckBox newCheckBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromDatePicker;
    }
}
