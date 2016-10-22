namespace Observer
{
	partial class FormPause
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
			this.c_resume = new System.Windows.Forms.Button();
			this.c_text = new System.Windows.Forms.Label();
			this.c_request = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// c_resume
			// 
			this.c_resume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.c_resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.c_resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_resume.ForeColor = System.Drawing.Color.White;
			this.c_resume.Location = new System.Drawing.Point(152, 271);
			this.c_resume.Name = "c_resume";
			this.c_resume.Size = new System.Drawing.Size(179, 38);
			this.c_resume.TabIndex = 0;
			this.c_resume.Text = "Resume";
			this.c_resume.UseVisualStyleBackColor = true;
			this.c_resume.Click += new System.EventHandler(this.c_resume_Click);
			// 
			// c_text
			// 
			this.c_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.c_text.AutoSize = true;
			this.c_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_text.ForeColor = System.Drawing.Color.White;
			this.c_text.Location = new System.Drawing.Point(105, 155);
			this.c_text.Name = "c_text";
			this.c_text.Size = new System.Drawing.Size(436, 42);
			this.c_text.TabIndex = 1;
			this.c_text.Text = "Your session is paused...";
			// 
			// c_request
			// 
			this.c_request.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.c_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.c_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_request.ForeColor = System.Drawing.Color.White;
			this.c_request.Location = new System.Drawing.Point(362, 271);
			this.c_request.Name = "c_request";
			this.c_request.Size = new System.Drawing.Size(179, 38);
			this.c_request.TabIndex = 1;
			this.c_request.Text = "Request More Time";
			this.c_request.UseVisualStyleBackColor = true;
			this.c_request.Click += new System.EventHandler(this.c_request_Click);
			// 
			// FormPause
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(693, 467);
			this.Controls.Add(this.c_text);
			this.Controls.Add(this.c_request);
			this.Controls.Add(this.c_resume);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormPause";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormPause";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SizeChanged += new System.EventHandler(this.FormPause_SizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button c_resume;
		private System.Windows.Forms.Label c_text;
		private System.Windows.Forms.Button c_request;
	}
}