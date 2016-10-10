using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer
{
	public partial class FormChangePassword : Form
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public FormChangePassword()
		{
			InitializeComponent();
		}

		/// <summary>
		/// User is ready to change their password.  If the old password doesn't match, or the
		/// new and confirm password doesn't match, change the color state and alert the user.
		/// </summary>
		private void c_ok_Click(
			object sender,
			EventArgs e)
		{
			// Reset label colors as necessary.
			c_currentLabel.ForeColor = SystemColors.ControlText;
			c_confirmLabel.ForeColor = SystemColors.ControlText;

			// Do the new and confirm passwords match?
			if (c_newPassword.Text != c_confirmPassword.Text)
			{
				c_confirmLabel.ForeColor = Color.Red;
				c_confirmPassword.SelectionStart = 0;
				c_confirmPassword.SelectionLength = c_confirmPassword.Text.Length;
				c_confirmPassword.Focus();
				return;
			}

			// Verify the current password before changing it.
			UInt32 oldPassword = c_oldPassword.Text.ComputeHash();
			if (oldPassword != Settings.AdminPasswordHash)
			{
				c_currentLabel.ForeColor = Color.Red;
				c_oldPassword.SelectionStart = 0;
				c_oldPassword.SelectionLength = c_oldPassword.Text.Length;
				c_oldPassword.Focus();
				return;
			}

			// Set the new password.
			Settings.SetAdminPassword(c_newPassword.Text);
			MessageBox.Show("Password changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
		}

		/// <summary>
		/// User cancelled the password change request.
		/// </summary>
		private void c_cancel_Click(
			object sender,
			EventArgs e)
		{
			Close();
		}
	}
}
