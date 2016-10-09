using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer
{
	public partial class FormClock : Form
	{
		// Timer used to update the time remaining display.
		private System.Windows.Forms.Timer m_timer;

		/// <summary>
		/// Constructor.
		/// </summary>
		public FormClock()
		{
			InitializeComponent();
		}

		/// <summary>
		/// User requests additional time.
		/// </summary>
		private void c_request_Click(
			object sender,
			EventArgs e)
		{
			TrayIcon.Instance.ShowSettingsDlg();
		}

		/// <summary>
		/// On load, initializes the dialog and positions it in the bottom corner of the screen.
		/// </summary>
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
			m_timer.Interval = 10000;
			m_timer.Start();
		}

		/// <summary>
		/// Timer tick, updates the time remaining display.
		/// </summary>
		private void OnTimer(
			object sender,
			EventArgs e)
		{
			// Format the minutes remaining as hours and minutes.
			int time = Settings.MinutesRemaining;
			c_time.Text = String.Format("{0}:{1:0#}", (time / 60), (time % 60));
		}

		/// <summary>
		/// We don't actually close the dialog, just hide it.
		/// </summary>
		private void FormClock_FormClosing(
			object sender,
			FormClosingEventArgs e)
		{
			if (Settings.ShuttingDown == false)
			{
				e.Cancel = true;
				Visible = false;
			}
		}
	}
}
