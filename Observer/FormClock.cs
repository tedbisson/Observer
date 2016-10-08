using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
	public partial class FormClock : Form
	{
		private System.Windows.Forms.Timer m_timer;

		public int Time = 100;

		public FormClock()
		{
			InitializeComponent();
		}

		private void c_request_Click(
			object sender,
			EventArgs e)
		{
			FormPassword dlg = new FormPassword();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				MessageBox.Show("Ok, you get more time!");
				Time = 100;
			}
		}

		private void FormClock_Load(
			object sender,
			EventArgs e)
		{
			// Place the window in the bottom right corner by default.
			int x = Screen.PrimaryScreen.WorkingArea.X + Screen.PrimaryScreen.WorkingArea.Width - Size.Width;
			int y = Screen.PrimaryScreen.WorkingArea.Y + Screen.PrimaryScreen.WorkingArea.Height - Size.Height;
			Location = new Point(x, y);

			// Update immediately.
			OnTimer(this, EventArgs.Empty);

			// Start a timer to update the time remaining.
			m_timer = new Timer();
			m_timer.Tick += new EventHandler(OnTimer);
			m_timer.Interval = 1000;
			m_timer.Start();
		}

		private void OnTimer(
			object sender,
			EventArgs e)
		{
			// Format the minutes remaining as hours and minutes.
			c_time.Text = String.Format("{0}:{1:0#}", (Time / 60), (Time % 60));
			--Time;
		}
	}
}
