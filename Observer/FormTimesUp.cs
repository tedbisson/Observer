using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer
{
    public partial class FormTimesUp : Form
    {
		// Timer used to update remaining time.
		private static System.Windows.Forms.Timer m_timer;
		
		// Shutdown time counter.
		private int m_minutesToShutdown;

		/// <summary>
		/// Constructor.
		/// </summary>
		public FormTimesUp()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Updates the text location when the form size changes.
		/// </summary>
        private void FormTimesUp_SizeChanged(
			object sender,
			EventArgs e)
        {
            c_text.Location = new Point((Width - c_text.Width) / 2, (Height / 2) - (c_text.Height * 2));
            c_timeText.Location = new Point((Width - c_timeText.Width) / 2, (Height / 2));
        }

		/// <summary>
		/// User requests to shut down the computer.
		/// </summary>
        private void c_shutdown_Click(
			object sender,
			EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

		/// <summary>
		/// User requests additional time.
		/// </summary>
        private void c_request_Click(
			object sender,
			EventArgs e)
        {
            FormPassword passwordDlg = new FormPassword();
            if (passwordDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FormAddTime addTimeDlg = new FormAddTime();
                addTimeDlg.ShowDialog();
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Close();
            }
        }

		/// <summary>
		/// Setup when the form is loaded.
		/// </summary>
		private void FormTimesUp_Load(
			object sender,
			EventArgs e)
		{
			// 10 minutes until shutdown.
			m_minutesToShutdown = Settings.RootRegistryKey.GetIntValue("Debug_ShutdownDelay", 10 * 60);

			// Setup the timer if the user doesn't respond for 10 minutes, we'll shut down automatically.
			m_timer = new Timer();
			m_timer.Tick += new EventHandler(OnTimer);
			m_timer.Interval = 1000;
			m_timer.Start();
		}

		/// <summary>
		/// OnTimer, automatically shuts down the computer if the user doesn't respond for a period of time.
		/// </summary>
		private void OnTimer(
			object sender,
			EventArgs e)
		{
			// Decrement the countdown.
			--m_minutesToShutdown;
			if (m_minutesToShutdown <= 0)
			{
				// Stop the timer.
				m_timer.Enabled = false;

				// Signal to shutdown the computer.
				DialogResult = System.Windows.Forms.DialogResult.OK;
				Close();
				return;
			}

			// Update the time remaining text.
			c_timeText.Text = String.Format("Automatic shutdown in {0}:{1:0#}", (m_minutesToShutdown / 60), (m_minutesToShutdown % 60));
			c_timeText.Location = new Point((Width - c_timeText.Width) / 2, (Height / 2));
		}
    }
}
