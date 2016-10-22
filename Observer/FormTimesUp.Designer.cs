namespace Observer
{
    partial class FormTimesUp
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
            this.c_shutdown = new System.Windows.Forms.Button();
            this.c_request = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // c_text
            // 
            this.c_text.AutoSize = true;
            this.c_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_text.ForeColor = System.Drawing.Color.White;
            this.c_text.Location = new System.Drawing.Point(154, 176);
            this.c_text.Name = "c_text";
            this.c_text.Size = new System.Drawing.Size(708, 108);
            this.c_text.TabIndex = 0;
            this.c_text.Text = "Your time is up!";
            // 
            // c_shutdown
            // 
            this.c_shutdown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.c_shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_shutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_shutdown.ForeColor = System.Drawing.Color.White;
            this.c_shutdown.Location = new System.Drawing.Point(221, 447);
            this.c_shutdown.Name = "c_shutdown";
            this.c_shutdown.Size = new System.Drawing.Size(252, 57);
            this.c_shutdown.TabIndex = 0;
            this.c_shutdown.Text = "Shutdown";
            this.c_shutdown.UseVisualStyleBackColor = true;
            this.c_shutdown.Click += new System.EventHandler(this.c_shutdown_Click);
            // 
            // c_request
            // 
            this.c_request.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.c_request.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.c_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_request.ForeColor = System.Drawing.Color.White;
            this.c_request.Location = new System.Drawing.Point(543, 447);
            this.c_request.Name = "c_request";
            this.c_request.Size = new System.Drawing.Size(252, 57);
            this.c_request.TabIndex = 1;
            this.c_request.Text = "Request More Time";
            this.c_request.UseVisualStyleBackColor = true;
            this.c_request.Click += new System.EventHandler(this.c_request_Click);
            // 
            // FormTimesUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1016, 701);
            this.ControlBox = false;
            this.Controls.Add(this.c_request);
            this.Controls.Add(this.c_shutdown);
            this.Controls.Add(this.c_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTimesUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTimesUp";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FormTimesUp_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c_text;
        private System.Windows.Forms.Button c_shutdown;
        private System.Windows.Forms.Button c_request;
    }
}