using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer
{
    public partial class FormBedtime : Form
    {
		/// <summary>
		/// Constructor.
		/// </summary>
		public FormBedtime()
        {
            InitializeComponent();
        }

		/// <summary>
		/// Updates the text location when the form size changes.
		/// </summary>
        private void FormBedtime_SizeChanged(
			object sender,
			EventArgs e)
        {
            c_text.Location = new Point((Width - c_text.Width) / 2, (Height / 2) - (c_text.Height * 2));
        }

		/// <summary>
		/// User requests to shut down the computer.
		/// </summary>
        private void c_ok_Click(
			object sender,
			EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
