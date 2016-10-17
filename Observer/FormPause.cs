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
	public partial class FormPause : Form
	{
		public FormPause()
		{
			InitializeComponent();
		}

		private void c_resume_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FormPause_SizeChanged(object sender, EventArgs e)
		{
			c_text.Location = new Point((Width - c_text.Width) / 2, (Height - c_text.Height) / 2);
		}
	}
}
