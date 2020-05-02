﻿namespace KeePass.Forms
{
	partial class ColumnsForm
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
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_lblChoose = new System.Windows.Forms.Label();
			this.m_lblReorderHint = new System.Windows.Forms.Label();
			this.m_btnAsterisks = new System.Windows.Forms.Button();
			this.m_lvColumns = new KeePass.UI.CustomListViewEx();
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_lblSortHint = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.SuspendLayout();
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(518, 87);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 0;
			this.m_btnOK.Text = "&OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(518, 116);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 1;
			this.m_btnCancel.Text = "&Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_lblChoose
			// 
			this.m_lblChoose.AutoSize = true;
			this.m_lblChoose.Location = new System.Drawing.Point(9, 70);
			this.m_lblChoose.Name = "m_lblChoose";
			this.m_lblChoose.Size = new System.Drawing.Size(239, 13);
			this.m_lblChoose.TabIndex = 5;
			this.m_lblChoose.Text = "Choose the columns to show in the main window:";
			// 
			// m_lblReorderHint
			// 
			this.m_lblReorderHint.AutoSize = true;
			this.m_lblReorderHint.Location = new System.Drawing.Point(9, 423);
			this.m_lblReorderHint.Name = "m_lblReorderHint";
			this.m_lblReorderHint.Size = new System.Drawing.Size(344, 13);
			this.m_lblReorderHint.TabIndex = 3;
			this.m_lblReorderHint.Text = "To reorder columns, drag&&drop the column headers in the main window.";
			// 
			// m_btnAsterisks
			// 
			this.m_btnAsterisks.Location = new System.Drawing.Point(518, 395);
			this.m_btnAsterisks.Name = "m_btnAsterisks";
			this.m_btnAsterisks.Size = new System.Drawing.Size(75, 23);
			this.m_btnAsterisks.TabIndex = 2;
			this.m_btnAsterisks.Text = "&Asterisks";
			this.m_btnAsterisks.UseVisualStyleBackColor = true;
			this.m_btnAsterisks.Click += new System.EventHandler(this.OnBtnAsterisks);
			// 
			// m_lvColumns
			// 
			this.m_lvColumns.CheckBoxes = true;
			this.m_lvColumns.FullRowSelect = true;
			this.m_lvColumns.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.m_lvColumns.Location = new System.Drawing.Point(13, 88);
			this.m_lvColumns.Name = "m_lvColumns";
			this.m_lvColumns.Size = new System.Drawing.Size(499, 329);
			this.m_lvColumns.TabIndex = 6;
			this.m_lvColumns.UseCompatibleStateImageBehavior = false;
			this.m_lvColumns.View = System.Windows.Forms.View.Details;
			this.m_lvColumns.SelectedIndexChanged += new System.EventHandler(this.OnColumnsSelectedIndexChanged);
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(605, 60);
			this.m_bannerImage.TabIndex = 6;
			this.m_bannerImage.TabStop = false;
			// 
			// m_lblSortHint
			// 
			this.m_lblSortHint.AutoSize = true;
			this.m_lblSortHint.Location = new System.Drawing.Point(9, 440);
			this.m_lblSortHint.Name = "m_lblSortHint";
			this.m_lblSortHint.Size = new System.Drawing.Size(419, 13);
			this.m_lblSortHint.TabIndex = 4;
			this.m_lblSortHint.Text = "To sort entries by a field, click on the corresponding column header in the main " +
				"window.";
			// 
			// ColumnsForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(605, 461);
			this.Controls.Add(this.m_lblSortHint);
			this.Controls.Add(this.m_bannerImage);
			this.Controls.Add(this.m_btnAsterisks);
			this.Controls.Add(this.m_lblReorderHint);
			this.Controls.Add(this.m_lvColumns);
			this.Controls.Add(this.m_lblChoose);
			this.Controls.Add(this.m_btnCancel);
			this.Controls.Add(this.m_btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ColumnsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "<>";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.Label m_lblChoose;
		private KeePass.UI.CustomListViewEx m_lvColumns;
		private System.Windows.Forms.Label m_lblReorderHint;
		private System.Windows.Forms.Button m_btnAsterisks;
		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Label m_lblSortHint;
	}
}