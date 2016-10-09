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
	public partial class FormSettings : Form
	{
		public FormSettings()
		{
			InitializeComponent();
		}

		private void c_changePassword_Click(object sender, EventArgs e)
		{
			FormChangePassword dlg = new FormChangePassword();
			dlg.ShowDialog();
		}

		private void c_save_Click(object sender, EventArgs e)
		{
			// Update the daily limit.
			int dailyLimit = 0;
			if (int.TryParse(c_timeLimit.Text, out dailyLimit) == true)
			{
				Settings.DailyLimit = dailyLimit;
			}
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
			c_timeLimit.Text = Settings.DailyLimit.ToString();
		}
	}
}
