using Microsoft.Win32;
using System;
using System.Diagnostics;
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
		private static UInt32 m_adminPasswordHash = (UInt32) "".ComputeHash();

		// Timer used to update remaining time.
		private static System.Windows.Forms.Timer m_timer;

		// Flag indicating that the program is shutting down.
		private static bool m_shutdown;

		/// <summary>
		/// Initializes the settings data, must be called once at program start.
		/// </summary>
		public static void Initialize()
		{
			// Set default values.
			m_dailyLimit = 30;
			m_minutesRemaining = m_dailyLimit;
			m_warningTime = 10;
			m_shutdown = false;

			// Load settings from the registry.
			LoadRegistryValues();

			// If we've run out of time already, notify the user.
			if (m_minutesRemaining < 2)
			{
				MessageBox.Show("You have used up your time for today, the computer will shut down in 2 minutes!", "Time's Up", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				m_minutesRemaining = 2;
			}

			// Catch when the application exits to update the registry.
			Application.ApplicationExit += new EventHandler(OnAppExit);

            // Setup the timer to update the time remaining.
			m_timer = new Timer();
			m_timer.Tick += new EventHandler(OnTimer);
			m_timer.Interval = 60 * 1000;
			m_timer.Start();
		}

		/// <summary>
		/// Returns the root registry key for the program.
		/// </summary>
		private static RegistryKey RootRegistryKey
		{
			get
			{
				return Registry.CurrentUser.OpenOrCreateKey("SOFTWARE\\Cirius\\Observer");
			}
		}

		/// <summary>
		/// Loads or initializes the program values using the Windows registry.
		/// </summary>
		private static void LoadRegistryValues()
		{
			// Load the daily limit.
			m_dailyLimit = RootRegistryKey.GetIntValue("DailyLimit", 30);

			// Are we continuing from earlier today?
			if (RootRegistryKey.GetIntValue("LastDay", DateToday()) == DateToday())
			{
				m_minutesRemaining = RootRegistryKey.GetIntValue("TimeLeftToday", m_dailyLimit);
			}
			// New day, new limit.
			else
			{
				m_minutesRemaining = m_dailyLimit;
			}

			// Update the registry from here.
			RootRegistryKey.SetValue("LastDay", DateToday());
			RootRegistryKey.SetValue("TimeLeftToday", m_minutesRemaining);

			// Load the admin password hash.
			int defaultHash = (int) ("".ComputeHash());
			m_adminPasswordHash = (UInt32) RootRegistryKey.GetIntValue("AdminPassword", defaultHash);
		}

		/// <summary>
		/// Helper to format the date used to determine the daily limit.
		/// </summary>
		private static int DateToday()
		{
			return ((DateTime.Now.Year << 16) + (DateTime.Now.Month << 8) + (DateTime.Now.Day));
		}

		/// <summary>
		/// When the application exits we want to record how much time is remaining
		/// so the next time it is started it can resume for the day.
		/// </summary>
		private static void OnAppExit(
			object sender,
			EventArgs e)
		{
			// Store the time remaining for today.
			RootRegistryKey.SetIntValue("TimeLeftToday", m_minutesRemaining);
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

					RootRegistryKey.SetValue("DailyLimit", m_dailyLimit);
				}
			}
		}

		/// <summary>
		/// AdminPasswordHash property, returns the password hash value used to restrict
		/// access to parts of the program, or turn it off.
		/// </summary>
		public static UInt32 AdminPasswordHash
		{
			get { return m_adminPasswordHash; }
		}

		/// <summary>
		/// Updates the administrative password for the program.
		/// </summary>
		public static void SetAdminPassword(string password)
		{
			m_adminPasswordHash = password.ComputeHash();

			// Save the updated password hash value.
			RootRegistryKey.SetIntValue("AdminPassword", (int) m_adminPasswordHash);
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
				ShutdownComputer();
				//MessageBox.Show("This is when we would shut down.");
				//Application.Exit();
			}
		}

		/// <summary>
		/// Triggers a shutdown immediately.
		/// </summary>
		public static void ShutdownComputer()
		{
			Process.Start("shutdown.exe", "/s /f /t 00");
		}
	}
}
