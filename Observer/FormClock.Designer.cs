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
			this.c_pause = new System.Windows.Forms.Button();
			this.c_close = new System.Windows.Forms.Button();
			this.c_addTime = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// c_time
			// 
			this.c_time.BackColor = System.Drawing.Color.Black;
			this.c_time.Dock = System.Windows.Forms.DockStyle.Top;
			this.c_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_time.ForeColor = System.Drawing.Color.White;
			this.c_time.Location = new System.Drawing.Point(0, 0);
			this.c_time.Name = "c_time";
			this.c_time.Size = new System.Drawing.Size(183, 80);
			this.c_time.TabIndex = 2;
			this.c_time.Text = "4:58";
			this.c_time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// c_pause
			// 
			this.c_pause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.c_pause.BackColor = System.Drawing.Color.Black;
			this.c_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.c_pause.Image = global::Observer.Properties.Resources.ClockPause;
			this.c_pause.Location = new System.Drawing.Point(25, 80);
			this.c_pause.Name = "c_pause";
			this.c_pause.Size = new System.Drawing.Size(32, 32);
			this.c_pause.TabIndex = 0;
			this.c_pause.UseVisualStyleBackColor = false;
			this.c_pause.Click += new System.EventHandler(this.c_pause_Click);
			// 
			// c_close
			// 
			this.c_close.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.c_close.BackColor = System.Drawing.Color.Black;
			this.c_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.c_close.Image = global::Observer.Properties.Resources.ClockClose;
			this.c_close.Location = new System.Drawing.Point(125, 80);
			this.c_close.Name = "c_close";
			this.c_close.Size = new System.Drawing.Size(32, 32);
			this.c_close.TabIndex = 2;
			this.c_close.UseVisualStyleBackColor = false;
			this.c_close.Click += new System.EventHandler(this.c_close_Click);
			// 
			// c_addTime
			// 
			this.c_addTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.c_addTime.BackColor = System.Drawing.Color.Black;
			this.c_addTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.c_addTime.Image = global::Observer.Properties.Resources.ClockAdd;
			this.c_addTime.Location = new System.Drawing.Point(75, 80);
			this.c_addTime.Name = "c_addTime";
			this.c_addTime.Size = new System.Drawing.Size(32, 32);
			this.c_addTime.TabIndex = 1;
			this.c_addTime.UseVisualStyleBackColor = false;
			this.c_addTime.Click += new System.EventHandler(this.c_addTime_Click);
			// 
			// FormClock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(183, 116);
			this.Controls.Add(this.c_pause);
			this.Controls.Add(this.c_close);
			this.Controls.Add(this.c_addTime);
			this.Controls.Add(this.c_time);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
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
		private System.Windows.Forms.Button c_addTime;
		private System.Windows.Forms.Button c_close;
		private System.Windows.Forms.Button c_pause;
	}
}