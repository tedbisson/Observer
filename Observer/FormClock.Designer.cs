namespace Observer
{
	partial class FormClock
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
			this.c_time = new System.Windows.Forms.Label();
			this.c_request = new System.Windows.Forms.Button();
			this.c_pause = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// c_time
			// 
			this.c_time.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_time.Location = new System.Drawing.Point(0, 0);
			this.c_time.Name = "c_time";
			this.c_time.Size = new System.Drawing.Size(244, 121);
			this.c_time.TabIndex = 2;
			this.c_time.Text = "4:58";
			this.c_time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// c_request
			// 
			this.c_request.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.c_request.Location = new System.Drawing.Point(126, 86);
			this.c_request.Name = "c_request";
			this.c_request.Size = new System.Drawing.Size(106, 23);
			this.c_request.TabIndex = 1;
			this.c_request.Text = "Request More Time";
			this.c_request.UseVisualStyleBackColor = true;
			this.c_request.Click += new System.EventHandler(this.c_request_Click);
			// 
			// c_pause
			// 
			this.c_pause.Location = new System.Drawing.Point(12, 86);
			this.c_pause.Name = "c_pause";
			this.c_pause.Size = new System.Drawing.Size(106, 23);
			this.c_pause.TabIndex = 0;
			this.c_pause.Text = "Pause";
			this.c_pause.UseVisualStyleBackColor = true;
			this.c_pause.Click += new System.EventHandler(this.c_pause_Click);
			// 
			// FormClock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 121);
			this.Controls.Add(this.c_pause);
			this.Controls.Add(this.c_request);
			this.Controls.Add(this.c_time);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(260, 160);
			this.Name = "FormClock";
			this.ShowIcon = false;
			this.Text = "Time Remaining";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClock_FormClosing);
			this.Load += new System.EventHandler(this.FormClock_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label c_time;
		private System.Windows.Forms.Button c_request;
		private System.Windows.Forms.Button c_pause;
	}
}