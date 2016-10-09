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
	public partial class FormChangePassword : Form
	{
		public FormChangePassword()
		{
			InitializeComponent();
		}

		private void c_ok_Click(object sender, EventArgs e)
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
			UInt64 oldPassword = c_oldPassword.Text.ComputeHash();
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

		private void c_cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
