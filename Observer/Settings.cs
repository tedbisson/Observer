﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
	public static class Settings
	{
		// Time remaining before shutdown, measured in minutes.
		private static int m_minutesRemaining;

		// Admin password used to change time allocation.
		private static string m_adminPassword;

		// Timer used to update remaining time.
		private static System.Windows.Forms.Timer m_timer;

		// Flag indicating that the program is shutting down.
		private static bool m_shutdown;

		public static void Initialize()
		{
			// Go get values from registry and/or log file.
			m_minutesRemaining = 30;
			m_adminPassword    = "";
			m_shutdown         = false;

			// Setup the timer to update the time remaining.
			m_timer = new Timer();
			m_timer.Tick += new EventHandler(OnTimer);
			m_timer.Interval = 1000;//60 * 1000;
			m_timer.Start();
		}

		public static int MinutesRemaining
		{
			get { return m_minutesRemaining; }
			set
			{
				m_minutesRemaining = value;

				// Need to update the log file.
			}
		}

		public static string AdminPassword
		{
			get { return m_adminPassword; }
			set
			{
				m_adminPassword = value;

				// Need to update the registry.
			}
		}

		public static bool ShuttingDown
		{
			get { return m_shutdown; }
			set
			{
				m_shutdown = value;
				m_timer.Enabled = false;
			}
		}

		private static void OnTimer(
			object sender,
			EventArgs e)
		{
			--m_minutesRemaining;
			if (m_minutesRemaining == 10)
			{
				// Offer a warning.
				MessageBox.Show("Your time is up in 10 minutes, save your work!");
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
