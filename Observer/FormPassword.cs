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
	public partial class FormPassword : Form
	{
		public FormPassword()
		{
			InitializeComponent();
		}

		private void c_ok_Click(object sender, EventArgs e)
		{
			if (c_password.Text == Settings.AdminPassword)
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

		private void c_cancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

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
