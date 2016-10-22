using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer
{
	public partial class FormPause : Form
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public FormPause()
		{
			InitializeComponent();
		}

		/// <summary>
		/// OnResume, close the dialog and resume the countdown.
		/// </summary>
		private void c_resume_Click(
			object sender,
			EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// When the form size changes, recenter the text.
		/// </summary>
		private void FormPause_SizeChanged(
			object sender,
			EventArgs e)
		{
			c_text.Location = new Point((Width - c_text.Width) / 2, (Height - c_text.Height) / 2);
		}

		/// <summary>
		/// OnRequest, the user has requested additional time.
		/// </summary>
		private void c_request_Click(
			object sender,
			EventArgs e)
		{
			FormPassword passwordDlg = new FormPassword();
			if (passwordDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				FormAddTime addTimeDlg = new FormAddTime();
				addTimeDlg.ShowDialog();
			}
		}
	}
}
