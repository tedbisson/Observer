namespace Observer
{
	partial class FormPassword
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
			this.c_ok = new System.Windows.Forms.Button();
			this.c_cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.c_password = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// c_ok
			// 
			this.c_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_ok.Location = new System.Drawing.Point(52, 71);
			this.c_ok.Name = "c_ok";
			this.c_ok.Size = new System.Drawing.Size(75, 23);
			this.c_ok.TabIndex = 1;
			this.c_ok.Text = "OK";
			this.c_ok.UseVisualStyleBackColor = true;
			this.c_ok.Click += new System.EventHandler(this.c_ok_Click);
			// 
			// c_cancel
			// 
			this.c_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_cancel.Location = new System.Drawing.Point(135, 71);
			this.c_cancel.Name = "c_cancel";
			this.c_cancel.Size = new System.Drawing.Size(75, 23);
			this.c_cancel.TabIndex = 2;
			this.c_cancel.Text = "Cancel";
			this.c_cancel.UseVisualStyleBackColor = true;
			this.c_cancel.Click += new System.EventHandler(this.c_cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "You must have permission to perform this action, ";
			// 
			// c_password
			// 
			this.c_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_password.Location = new System.Drawing.Point(53, 42);
			this.c_password.Name = "c_password";
			this.c_password.Size = new System.Drawing.Size(157, 20);
			this.c_password.TabIndex = 0;
			this.c_password.UseSystemPasswordChar = true;
			this.c_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.c_password_KeyUp);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "please enter the admin password.";
			// 
			// FormPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 106);
			this.ControlBox = false;
			this.Controls.Add(this.c_password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.c_cancel);
			this.Controls.Add(this.c_ok);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Observer Password";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button c_ok;
		private System.Windows.Forms.Button c_cancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox c_password;
		private System.Windows.Forms.Label label2;
	}
}