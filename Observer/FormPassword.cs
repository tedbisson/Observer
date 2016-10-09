using System;
using System.Windows.Forms;

namespace Observer
{
	public partial class FormPassword : Form
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public FormPassword()
		{
			InitializeComponent();
		}

		/// <summary>
		/// User is ready to proceed with password verification.
		/// </summary>
		private void c_ok_Click(
			object sender,
			EventArgs e)
		{
			if (c_password.Text.ComputeHash() == Settings.AdminPasswordHash)
			{
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show("The password is not correct!", "Incorrect Password!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}

		/// <summary>
		/// User decided not to change the password.
		/// </summary>
		private void c_cancel_Click(
			object sender,
			EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		/// <summary>
		/// Catches the enter key when the user is typing the password.
		/// </summary>
		private void c_password_KeyUp(
			object sender,
			KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				c_ok_Click(sender, e);
			}
		}
	}
}
