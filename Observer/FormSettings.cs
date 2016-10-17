using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Observer
{
	public partial class FormSettings : Form
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public FormSettings()
		{
			InitializeComponent();
		}

		/// <summary>
		/// User would like to change the administrator password.
		/// </summary>
		private void c_changePassword_Click(
			object sender,
			EventArgs e)
		{
			FormChangePassword dlg = new FormChangePassword();
			dlg.ShowDialog();
		}

		/// <summary>
		/// User would like to save settings changes.
		/// </summary>
		private void c_save_Click(
			object sender,
			EventArgs e)
		{
			// Update the daily limit.
			int dailyLimit = 0;
			if (int.TryParse(c_timeLimit.Text, out dailyLimit) == true)
			{
				Settings.DailyLimit = dailyLimit;
			}

			// Update the time remaining today.
			int timeRemaining = 0;
			if (int.TryParse(c_timeRemaining.Text, out timeRemaining) == true)
			{
				Settings.MinutesRemaining = timeRemaining;
			}

			// Hide the settings.
			Hide();
		}

		/// <summary>
		/// On form load, fills in the current settings values.
		/// </summary>
		private void FormSettings_Load(
			object sender,
			EventArgs e)
		{
			c_timeLimit.Text = Settings.DailyLimit.ToString();
		}

		/// <summary>
		/// When the form is shown it updates the time remaining text box.
		/// </summary>
		private void FormSettings_Shown(
			object sender,
			EventArgs e)
		{
			c_timeRemaining.Text = Settings.MinutesRemaining.ToString();
		}

		/// <summary>
		/// Instead of destroying the form, we just hide it so we can reuse it later.
		/// </summary>
		private void FormSettings_FormClosing(
			object sender,
			FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		/// <summary>
		/// Opens the log file for the user to view.
		/// </summary>
		private void c_showLogFile_Click(
			object sender,
			EventArgs e)
		{
			Process.Start(Log.LogPath);
		}
	}
}
