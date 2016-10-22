using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer
{
    public partial class FormTimesUp : Form
    {
        public FormTimesUp()
        {
            InitializeComponent();
        }

        private void FormTimesUp_SizeChanged(object sender, EventArgs e)
        {
            c_text.Location = new Point((Width - c_text.Width) / 2, (Height - c_text.Height) / 2);
        }

        private void c_shutdown_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void c_request_Click(object sender, EventArgs e)
        {
            FormPassword passwordDlg = new FormPassword();
            if (passwordDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FormAddTime addTimeDlg = new FormAddTime();
                addTimeDlg.ShowDialog();
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                Close();
            }
        }
    }
}
