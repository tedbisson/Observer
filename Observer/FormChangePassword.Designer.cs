namespace Observer
{
	partial class FormChangePassword
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
			this.c_oldPassword = new System.Windows.Forms.TextBox();
			this.c_newPassword = new System.Windows.Forms.TextBox();
			this.c_ok = new System.Windows.Forms.Button();
			this.c_cancel = new System.Windows.Forms.Button();
			this.c_currentLabel = new System.Windows.Forms.Label();
			this.c_confirmPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.c_confirmLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// c_oldPassword
			// 
			this.c_oldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.c_oldPassword.Location = new System.Drawing.Point(112, 12);
			this.c_oldPassword.Name = "c_oldPassword";
			this.c_oldPassword.Size = new System.Drawing.Size(205, 20);
			this.c_oldPassword.TabIndex = 0;
			this.c_oldPassword.UseSystemPasswordChar = true;
			// 
			// c_newPassword
			// 
			this.c_newPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.c_newPassword.Location = new System.Drawing.Point(112, 38);
			this.c_newPassword.Name = "c_newPassword";
			this.c_newPassword.Size = new System.Drawing.Size(205, 20);
			this.c_newPassword.TabIndex = 1;
			this.c_newPassword.UseSystemPasswordChar = true;
			// 
			// c_ok
			// 
			this.c_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.c_ok.Location = new System.Drawing.Point(161, 96);
			this.c_ok.Name = "c_ok";
			this.c_ok.Size = new System.Drawing.Size(75, 23);
			this.c_ok.TabIndex = 3;
			this.c_ok.Text = "OK";
			this.c_ok.UseVisualStyleBackColor = true;
			this.c_ok.Click += new System.EventHandler(this.c_ok_Click);
			// 
			// c_cancel
			// 
			this.c_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.c_cancel.Location = new System.Drawing.Point(242, 96);
			this.c_cancel.Name = "c_cancel";
			this.c_cancel.Size = new System.Drawing.Size(75, 23);
			this.c_cancel.TabIndex = 4;
			this.c_cancel.Text = "Cancel";
			this.c_cancel.UseVisualStyleBackColor = true;
			this.c_cancel.Click += new System.EventHandler(this.c_cancel_Click);
			// 
			// c_currentLabel
			// 
			this.c_currentLabel.AutoSize = true;
			this.c_currentLabel.Location = new System.Drawing.Point(13, 15);
			this.c_currentLabel.Name = "c_currentLabel";
			this.c_currentLabel.Size = new System.Drawing.Size(93, 13);
			this.c_currentLabel.TabIndex = 2;
			this.c_currentLabel.Text = "Current Password:";
			// 
			// c_confirmPassword
			// 
			this.c_confirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.c_confirmPassword.Location = new System.Drawing.Point(112, 64);
			this.c_confirmPassword.Name = "c_confirmPassword";
			this.c_confirmPassword.Size = new System.Drawing.Size(205, 20);
			this.c_confirmPassword.TabIndex = 2;
			this.c_confirmPassword.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "New Password:";
			// 
			// c_confirmLabel
			// 
			this.c_confirmLabel.AutoSize = true;
			this.c_confirmLabel.Location = new System.Drawing.Point(12, 67);
			this.c_confirmLabel.Name = "c_confirmLabel";
			this.c_confirmLabel.Size = new System.Drawing.Size(94, 13);
			this.c_confirmLabel.TabIndex = 2;
			this.c_confirmLabel.Text = "Confirm Password:";
			// 
			// FormChangePassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(333, 135);
			this.Controls.Add(this.c_confirmLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.c_currentLabel);
			this.Controls.Add(this.c_cancel);
			this.Controls.Add(this.c_ok);
			this.Controls.Add(this.c_confirmPassword);
			this.Controls.Add(this.c_newPassword);
			this.Controls.Add(this.c_oldPassword);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(349, 174);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(349, 174);
			this.Name = "FormChangePassword";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Change Admin Password";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox c_oldPassword;
		private System.Windows.Forms.TextBox c_newPassword;
		private System.Windows.Forms.Button c_ok;
		private System.Windows.Forms.Button c_cancel;
		private System.Windows.Forms.Label c_currentLabel;
		private System.Windows.Forms.TextBox c_confirmPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label c_confirmLabel;
	}
}