using System;
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
	}
}
