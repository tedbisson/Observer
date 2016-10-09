using System;
using System.Windows.Forms;

namespace Observer
{
	/// <summary>
	/// Interface used to manage program settings.  Other parts of the program can access
	/// specific information through this interface, it also controls the mechanism used
	/// to persist the data between program runs.
	/// </summary>
	public static class Settings
	{
		// Time remaining before shutdown, measured in minutes.
		private static int m_minutesRemaining;
		private static int m_dailyLimit;
		private static int m_warningTime;

		// Admin password used to change time allocation.
		private static UInt64 m_adminPasswordHash;

		// Timer used to update remaining time.
		private static System.Windows.Forms.Timer m_timer;

		// Flag indicating that the program is shutting down.
		private static bool m_shutdown;

		/// <summary>
		/// Initializes the settings data, must be called once at program start.
		/// </summary>
		public static void Initialize()
		{
			// Go get values from registry and/or log file.
			m_dailyLimit        = 30;
			m_minutesRemaining  = m_dailyLimit;
			m_warningTime       = 10;
			m_shutdown          = false;
			SetAdminPassword("");

			// Setup the timer to update the time remaining.
			m_timer = new Timer();
			m_timer.Tick += new EventHandler(OnTimer);
			m_timer.Interval = 1000;//60 * 1000;
			m_timer.Start();
		}

		/// <summary>
		/// MinutesRemaining property, indicates how many minutes the user has before
		/// the system will be shut down.
		/// </summary>
		public static int MinutesRemaining
		{
			get { return m_minutesRemaining; }
			set
			{
				m_minutesRemaining = value;

				// Need to update the log file.
			}
		}

		/// <summary>
		/// DailyLimit property, indicates the maximum amount of time available to a
		/// user on a day.  Note that if the limit is changed the currently used time
		/// for that day is adjusted.  If this leads to zero or near zero time left
		/// a small buffer is permitted giving the user time to make further adjustments.
		/// </summary>
		public static int DailyLimit
		{
			get { return m_dailyLimit; }
			set
			{
				if (m_dailyLimit != value)
				{
					int minutesRemaining = value - (m_dailyLimit - m_minutesRemaining);
					if (minutesRemaining < m_warningTime)
					{
						// To avoid shutting down immediately.
						m_minutesRemaining = m_warningTime + 1;
					}
					MinutesRemaining = minutesRemaining;

					m_dailyLimit = value;

					// Need to update the log file.
				}
			}
		}

		/// <summary>
		/// AdminPasswordHash property, returns the password hash value used to restrict
		/// access to parts of the program, or turn it off.
		/// </summary>
		public static UInt64 AdminPasswordHash
		{
			get { return m_adminPasswordHash; }
		}

		/// <summary>
		/// Updates the administrative password for the program.
		/// </summary>
		public static void SetAdminPassword(string password)
		{
			m_adminPasswordHash = password.ComputeHash();

			// Need to update the settings file.
		}

		/// <summary>
		/// ShuttingDown property, used to indicate that the program is now going to
		/// shut down the computer.  This flag signals the program that it should not
		/// further attempt to request permission to end, but it should just stop.
		/// </summary>
		public static bool ShuttingDown
		{
			get { return m_shutdown; }
			set
			{
				m_shutdown = value;
				m_timer.Enabled = false;
			}
		}

		/// <summary>
		/// Timer callback, this tracks how much time the user is allowed.  At an appropriate
		/// interval a warning is issued indicating the program will turn off the computer soon.
		/// And when the time is consumed, it triggers a shutdown ending the users time.
		/// </summary>
		private static void OnTimer(
			object sender,
			EventArgs e)
		{
			--m_minutesRemaining;
			if (m_minutesRemaining == m_warningTime)
			{
				// Offer a warning.
				string warning = String.Format("Time is almost up, you have {0} minutes remaining!  Save your work!", m_minutesRemaining);
				MessageBox.Show(warning, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
			else if (m_minutesRemaining <= 0)
			{
				// That's all folks, shutdown.
				Settings.ShuttingDown = true;
				MessageBox.Show("This is when we would shut down.");
				Application.Exit();
			}
		}
	}
}
