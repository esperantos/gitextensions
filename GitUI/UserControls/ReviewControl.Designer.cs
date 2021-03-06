﻿namespace GitUI.UserControls
{
	partial class ReviewControl
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
            this.reviewLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.reviewCommentTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.lastChangelabel = new System.Windows.Forms.Label();
            this.statusChangeAuthorLabel = new System.Windows.Forms.Label();
            this.reviewLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewLayoutPanel
            // 
            this.reviewLayoutPanel.AutoSize = true;
            this.reviewLayoutPanel.ColumnCount = 5;
            this.reviewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reviewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reviewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reviewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.reviewLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reviewLayoutPanel.Controls.Add(this.reviewCommentTextBox, 0, 1);
            this.reviewLayoutPanel.Controls.Add(this.statusLabel, 0, 0);
            this.reviewLayoutPanel.Controls.Add(this.statusComboBox, 1, 0);
            this.reviewLayoutPanel.Controls.Add(this.saveButton, 2, 0);
            this.reviewLayoutPanel.Controls.Add(this.lastChangelabel, 3, 0);
            this.reviewLayoutPanel.Controls.Add(this.statusChangeAuthorLabel, 4, 0);
            this.reviewLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.reviewLayoutPanel.Name = "reviewLayoutPanel";
            this.reviewLayoutPanel.RowCount = 2;
            this.reviewLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.reviewLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.reviewLayoutPanel.Size = new System.Drawing.Size(543, 198);
            this.reviewLayoutPanel.TabIndex = 0;
            // 
            // reviewCommentTextBox
            // 
            this.reviewLayoutPanel.SetColumnSpan(this.reviewCommentTextBox, 5);
            this.reviewCommentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reviewCommentTextBox.Location = new System.Drawing.Point(3, 34);
            this.reviewCommentTextBox.Multiline = true;
            this.reviewCommentTextBox.Name = "reviewCommentTextBox";
            this.reviewCommentTextBox.Size = new System.Drawing.Size(537, 161);
            this.reviewCommentTextBox.TabIndex = 0;
            this.reviewCommentTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reviewCommentTextBox_KeyDown);
            this.reviewCommentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reviewCommentTextBox_KeyPress);
            this.reviewCommentTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.reviewCommentTextBox_KeyUp);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(3, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(42, 31);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(51, 3);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 23);
            this.statusComboBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.saveButton.Location = new System.Drawing.Point(178, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(76, 25);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lastChangelabel
            // 
            this.lastChangelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastChangelabel.AutoSize = true;
            this.lastChangelabel.Location = new System.Drawing.Point(260, 8);
            this.lastChangelabel.Name = "lastChangelabel";
            this.lastChangelabel.Size = new System.Drawing.Size(89, 15);
            this.lastChangelabel.TabIndex = 4;
            this.lastChangelabel.Text = "Last change by:";
            // 
            // statusChangeAuthorLabel
            // 
            this.statusChangeAuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusChangeAuthorLabel.AutoSize = true;
            this.statusChangeAuthorLabel.Location = new System.Drawing.Point(355, 8);
            this.statusChangeAuthorLabel.Name = "statusChangeAuthorLabel";
            this.statusChangeAuthorLabel.Size = new System.Drawing.Size(109, 15);
            this.statusChangeAuthorLabel.TabIndex = 5;
            this.statusChangeAuthorLabel.Text = "art_z@skbkontur.ru";
            // 
            // ReviewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reviewLayoutPanel);
            this.Name = "ReviewControl";
            this.Size = new System.Drawing.Size(543, 198);
            this.reviewLayoutPanel.ResumeLayout(false);
            this.reviewLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel reviewLayoutPanel;
		private System.Windows.Forms.TextBox reviewCommentTextBox;
		private System.Windows.Forms.Label statusLabel;
		private System.Windows.Forms.ComboBox statusComboBox;
		private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label lastChangelabel;
        private System.Windows.Forms.Label statusChangeAuthorLabel;
	}
}
