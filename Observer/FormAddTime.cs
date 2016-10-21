using System;
using System.Windows.Forms;

namespace Observer
{
	public partial class FormAddTime : Form
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public FormAddTime()
		{
			InitializeComponent();
		}

		/// <summary>
		/// When the form is loaded, initialize the contents.
		/// </summary>
		private void FormAddTime_Load(object sender, EventArgs e)
		{
			c_time.Text = Settings.TimeLeftToday.ToString();
			c_time.SelectionStart = 0;
			c_time.SelectionLength = c_time.Text.Length;
		}

		/// <summary>
		/// OnSave, parse the new time value, set it, and close the dialog.
		/// </summary>
		private void c_save_Click(
			object sender,
			EventArgs e)
		{
			int time = 0;
			if (int.TryParse(c_time.Text, out time) != true || time < 0)
			{
				MessageBox.Show("Unable or invalid time value, please enter 0 or more minutes.", "Invalid Value!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				c_time.SelectionStart = 0;
				c_time.SelectionLength = c_time.Text.Length;
				c_time.Focus();
				return;
			}
		
			Settings.TimeLeftToday = time;
			DialogResult = System.Windows.Forms.DialogResult.OK;
			Close();
		}

		/// <summary>
		/// OnCancel, abort the change and close the dialog.
		/// </summary>
		private void c_cancel_Click(
			object sender,
			EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Close();
		}
	}
}
