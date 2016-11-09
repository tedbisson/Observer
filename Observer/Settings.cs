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
		// Timer used to update remaining time.
		private static System.Windows.Forms.Timer m_timer;

		// Program flags to signal current states.
		private static bool m_shutdown = false;
		public  static bool Paused = false;

		/// <summary>
		/// Initializes the settings data, must be called once at program start.
		/// </summary>
		public static void Initialize()
		{
			// New day? Reset the limit!
			if (RootRegistryKey.GetIntValue("LastDay", (DateTime.Now.DateOnly() - 1)) != DateTime.Now.DateOnly())
			{
				TimeLeftToday = DailyLimit;
			}
			RootRegistryKey.SetValue("LastDay", DateTime.Now.DateOnly());

			// Bedtime check!
			if (UseBedTime == true)
			{
				int minutesToBedTime = (int) (BedTime - DateTime.Now).TotalMinutes;
				if (minutesToBedTime < TimeLeftToday)
				{
					TimeLeftToday = minutesToBedTime;
					MessageBox.Show("Bedtime approaches, you will run out of time soon!", "Bedtime!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			// Debug helper, reset the remaining time on startup.
			if (RootRegistryKey.GetIntValue("Debug_ForceTimeResetOnStart", 0) == 1)
			{
				TimeLeftToday = DailyLimit;
			}

			// If we've run out of time already, notify the user.
			if (TimeLeftToday <= 0)
			{
				FormTimesUp timesUpDlg = new FormTimesUp();
				if (timesUpDlg.ShowDialog() == DialogResult.OK)
				{
					ShutdownComputer();
				}
			}

            // Setup the timer to update the time remaining.
			m_timer = new Timer();
			m_timer.Tick += new EventHandler(OnTimer);
			m_timer.Interval = RootRegistryKey.GetIntValue("Debug_MinuteLength", 60 * 1000);
			m_timer.Start();

			// Log that the program has started.
			Log.Write(String.Format("Observer started with {0} of {1} minutes.", TimeLeftToday, DailyLimit));
		}

		/// <summary>
		/// Returns the root registry key for the program.
		/// </summary>
		public static RegistryKey RootRegistryKey
		{
			get
			{
				return Registry.CurrentUser.OpenOrCreateKey("SOFTWARE\\Cirius\\Observer");
			}
		}

		/// <summary>
		/// MinutesRemaining property, indicates how many minutes the user has before
		/// the system will be shut down.
		/// </summary>
		public static int TimeLeftToday
		{
			get { return RootRegistryKey.GetIntValue("TimeLeftToday", DailyLimit); }
			set { RootRegistryKey.SetIntValue("TimeLeftToday", value); }
		}

		/// <summary>
		/// DailyLimit property, indicates the maximum amount of time available to a
		/// user on a day.  Note that if the limit is changed the currently used time
		/// for that day is adjusted.  If this leads to zero or near zero time left
		/// a small buffer is permitted giving the user time to make further adjustments.
		/// </summary>
		public static int DailyLimit
		{
			get { return RootRegistryKey.GetIntValue("DailyLimit", 30); }
			set
			{
				if (DailyLimit != value)
				{
					int minutesRemaining = value - (DailyLimit - TimeLeftToday);
					if (minutesRemaining < WarningTime)
					{
						// To avoid shutting down immediately.
						minutesRemaining = Math.Max(WarningTime, 1);
					}
					TimeLeftToday = minutesRemaining;

					RootRegistryKey.SetIntValue("DailyLimit", value);
				}
			}
		}

		/// <summary>
		/// WarningTime property, indicates how many minutes before the time expires
		/// to warn the user.
		/// </summary>
		public static int WarningTime
		{
			get { return RootRegistryKey.GetIntValue("WarningTime", 10); }
			set { RootRegistryKey.SetIntValue("WarningTime", value); }
		}

		/// <summary>
		/// Default password hash property, used as the default password.
		/// </summary>
		private static int m_defaultPasswordHash = "".ComputeHash();
		public static int DefaultPasswordHash
		{
			get { return m_defaultPasswordHash; }
		}

		/// <summary>
		/// AdminPasswordHash property, returns the password hash value used to restrict
		/// access to parts of the program, or turn it off.
		/// </summary>
		public static int AdminPasswordHash
		{
			get { return RootRegistryKey.GetIntValue("AdminPassword", DefaultPasswordHash); }
			set { RootRegistryKey.SetIntValue("AdminPassword", value); }
		}

		/// <summary>
		/// UseBedTime property, indicates that the program should expire all time at
		/// the designated bedtime.
		/// </summary>
		public static bool UseBedTime
		{
			get { return RootRegistryKey.GetBoolValue("UseBedTime", false); }
			set { RootRegistryKey.SetBoolValue("UseBedTime", value); }
		}

		/// <summary>
		/// BedTime property, indicates what time bedtime takes place.  Bedtime is stored in the
		/// registry in an integer value of the format 0xHHHHMMMM.
		/// </summary>
		public static DateTime BedTime
		{
			get
			{
				int bedTime = RootRegistryKey.GetIntValue("BedTime", (21 << 16)); // 9pm by default
				return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (bedTime >> 16), (bedTime & 0x0000FFFF), 0);
			}
			set
			{
				RootRegistryKey.SetIntValue("BedTime", (value.Hour << 16) + value.Minute);
			}
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
			if (Paused == false)
			{
				TimeLeftToday = TimeLeftToday - 1;
				if (TimeLeftToday == WarningTime)
				{
					// Offer a warning.
					string warning = String.Format("Time is almost up, you have {0} minutes remaining!  Save your work!", TimeLeftToday);
					MessageBox.Show(warning, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				}
				else if (TimeLeftToday <= 0)
				{
					// That's all folks, shutdown.
					TimeLeftToday = 0;
					Paused = true;
					FormTimesUp timesUpDlg = new FormTimesUp();
					if (timesUpDlg.ShowDialog() == DialogResult.OK)
					{
						ShutdownComputer();
					}
					Paused = false;
				}
			}
		}

		/// <summary>
		/// Triggers a shutdown immediately.
		/// </summary>
		public static void ShutdownComputer()
		{
			// For debugging, we don't actually want to shut down the computer.
			if (RootRegistryKey.GetIntValue("Debug_DontShutDown", 0) == 1)
			{
				MessageBox.Show("This is when we would shut down.");
				Application.Exit();
			}
			else
			{
				// Actually shut down.
				Process.Start("shutdown.exe", "/s /f /t 00");
			}
		}
	}
}
