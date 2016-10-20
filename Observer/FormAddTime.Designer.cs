namespace Observer
{
	partial class FormAddTime
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
			this.c_time = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.c_save = new System.Windows.Forms.Button();
			this.c_cancel = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// c_time
			// 
			this.c_time.Location = new System.Drawing.Point(165, 12);
			this.c_time.Name = "c_time";
			this.c_time.Size = new System.Drawing.Size(46, 20);
			this.c_time.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Set the remaining time today to";
			// 
			// c_save
			// 
			this.c_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.c_save.Location = new System.Drawing.Point(100, 51);
			this.c_save.Name = "c_save";
			this.c_save.Size = new System.Drawing.Size(75, 23);
			this.c_save.TabIndex = 1;
			this.c_save.Text = "Save";
			this.c_save.UseVisualStyleBackColor = true;
			this.c_save.Click += new System.EventHandler(this.c_save_Click);
			// 
			// c_cancel
			// 
			this.c_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.c_cancel.Location = new System.Drawing.Point(181, 51);
			this.c_cancel.Name = "c_cancel";
			this.c_cancel.Size = new System.Drawing.Size(75, 23);
			this.c_cancel.TabIndex = 2;
			this.c_cancel.Text = "Cancel";
			this.c_cancel.UseVisualStyleBackColor = true;
			this.c_cancel.Click += new System.EventHandler(this.c_cancel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(213, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "minutes.";
			// 
			// FormAddTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 86);
			this.ControlBox = false;
			this.Controls.Add(this.c_cancel);
			this.Controls.Add(this.c_save);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.c_time);
			this.Name = "FormAddTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Time";
			this.Load += new System.EventHandler(this.FormAddTime_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox c_time;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button c_save;
		private System.Windows.Forms.Button c_cancel;
		private System.Windows.Forms.Label label2;
	}
}