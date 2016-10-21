namespace Observer
{
	partial class FormSettings
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

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.c_timeLimit = new System.Windows.Forms.TextBox();
			this.c_save = new System.Windows.Forms.Button();
			this.c_changePassword = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.c_timeRemaining = new System.Windows.Forms.TextBox();
			this.c_showLogFile = new System.Windows.Forms.Button();
			this.c_bedTime = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Daily Time Limit (Minutes):";
			// 
			// c_timeLimit
			// 
			this.c_timeLimit.Location = new System.Drawing.Point(146, 12);
			this.c_timeLimit.Name = "c_timeLimit";
			this.c_timeLimit.Size = new System.Drawing.Size(122, 20);
			this.c_timeLimit.TabIndex = 0;
			// 
			// c_save
			// 
			this.c_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.c_save.Location = new System.Drawing.Point(193, 131);
			this.c_save.Name = "c_save";
			this.c_save.Size = new System.Drawing.Size(75, 23);
			this.c_save.TabIndex = 6;
			this.c_save.Text = "Save";
			this.c_save.UseVisualStyleBackColor = true;
			this.c_save.Click += new System.EventHandler(this.c_save_Click);
			// 
			// c_changePassword
			// 
			this.c_changePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.c_changePassword.Location = new System.Drawing.Point(15, 101);
			this.c_changePassword.Name = "c_changePassword";
			this.c_changePassword.Size = new System.Drawing.Size(147, 23);
			this.c_changePassword.TabIndex = 4;
			this.c_changePassword.Text = "Change Admin Password";
			this.c_changePassword.UseVisualStyleBackColor = true;
			this.c_changePassword.Click += new System.EventHandler(this.c_changePassword_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Time Remaining Today:";
			// 
			// c_timeRemaining
			// 
			this.c_timeRemaining.Location = new System.Drawing.Point(146, 38);
			this.c_timeRemaining.Name = "c_timeRemaining";
			this.c_timeRemaining.Size = new System.Drawing.Size(122, 20);
			this.c_timeRemaining.TabIndex = 1;
			// 
			// c_showLogFile
			// 
			this.c_showLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.c_showLogFile.Location = new System.Drawing.Point(15, 131);
			this.c_showLogFile.Name = "c_showLogFile";
			this.c_showLogFile.Size = new System.Drawing.Size(147, 23);
			this.c_showLogFile.TabIndex = 5;
			this.c_showLogFile.Text = "Show Log File";
			this.c_showLogFile.UseVisualStyleBackColor = true;
			this.c_showLogFile.Click += new System.EventHandler(this.c_showLogFile_Click);
			// 
			// c_bedTime
			// 
			this.c_bedTime.Checked = false;
			this.c_bedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.c_bedTime.Location = new System.Drawing.Point(146, 64);
			this.c_bedTime.Name = "c_bedTime";
			this.c_bedTime.ShowCheckBox = true;
			this.c_bedTime.ShowUpDown = true;
			this.c_bedTime.Size = new System.Drawing.Size(122, 20);
			this.c_bedTime.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Use a bedtime cutoff:";
			// 
			// FormSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 171);
			this.ControlBox = false;
			this.Controls.Add(this.c_bedTime);
			this.Controls.Add(this.c_showLogFile);
			this.Controls.Add(this.c_changePassword);
			this.Controls.Add(this.c_save);
			this.Controls.Add(this.c_timeRemaining);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.c_timeLimit);
			this.Controls.Add(this.label3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Observer Settings";
			this.Load += new System.EventHandler(this.FormSettings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox c_timeLimit;
		private System.Windows.Forms.Button c_save;
		private System.Windows.Forms.Button c_changePassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox c_timeRemaining;
		private System.Windows.Forms.Button c_showLogFile;
		private System.Windows.Forms.DateTimePicker c_bedTime;
		private System.Windows.Forms.Label label2;
	}
}