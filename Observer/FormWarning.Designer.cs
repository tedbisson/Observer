namespace Observer
{
    partial class FormWarning
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
			this.c_text = new System.Windows.Forms.Label();
			this.c_ok = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// c_text
			// 
			this.c_text.AutoSize = true;
			this.c_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_text.ForeColor = System.Drawing.Color.White;
			this.c_text.Location = new System.Drawing.Point(44, 114);
			this.c_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.c_text.Name = "c_text";
			this.c_text.Size = new System.Drawing.Size(588, 73);
			this.c_text.TabIndex = 0;
			this.c_text.Text = "10 Minute Warning!";
			// 
			// c_ok
			// 
			this.c_ok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.c_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.c_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_ok.ForeColor = System.Drawing.Color.White;
			this.c_ok.Location = new System.Drawing.Point(254, 291);
			this.c_ok.Margin = new System.Windows.Forms.Padding(2);
			this.c_ok.Name = "c_ok";
			this.c_ok.Size = new System.Drawing.Size(168, 37);
			this.c_ok.TabIndex = 0;
			this.c_ok.Text = "OK";
			this.c_ok.UseVisualStyleBackColor = true;
			this.c_ok.Click += new System.EventHandler(this.c_ok_Click);
			// 
			// FormWarning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOrange;
			this.ClientSize = new System.Drawing.Size(677, 456);
			this.ControlBox = false;
			this.Controls.Add(this.c_ok);
			this.Controls.Add(this.c_text);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "FormWarning";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormTimesUp";
			this.TopMost = true;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.SizeChanged += new System.EventHandler(this.FormWarning_SizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c_text;
        private System.Windows.Forms.Button c_ok;
    }
}