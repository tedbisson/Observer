using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Observer
{
	public class TrayIcon : IDisposable
	{
		private NotifyIcon m_notifyIcon;
		private bool m_showingSettings = false;
		private FormClock m_clockDlg = new FormClock();

		/// <summary>
		/// Constructor.
		/// </summary>
		public TrayIcon()
		{
			m_notifyIcon = new NotifyIcon();
		}

		/// <summary>
		/// Cleans up when the program shuts down.
		/// </summary>
		public void Dispose()
		{
			// Clean up the tray icon now!
			m_notifyIcon.Dispose();
			m_clockDlg.Close();
		}

		/// <summary>
		/// Sets up the tray icon and starts the program.
		/// </summary>
		public void Display()
		{
			// Setup the notify icon control.
			m_notifyIcon.MouseClick += new MouseEventHandler(OnMouseClick);
			m_notifyIcon.Icon        = Icon.FromHandle(Properties.Resources.ObserverImage.GetHicon());
			m_notifyIcon.Text        = "Daddy Observation Tool";
			m_notifyIcon.Visible     = true;

			// Setup the context menu.
			m_notifyIcon.ContextMenuStrip = SetupContextMenu();

			// Show the clock immediately.
			m_clockDlg.Show();
		}

		/// <summary>
		/// Creates the context menu for the tray icon.
		/// </summary>
		/// <returns></returns>
		private ContextMenuStrip SetupContextMenu()
		{
			ContextMenuStrip menu = new ContextMenuStrip();

			ToolStripMenuItem clockItem = new ToolStripMenuItem();
			clockItem.Text   = "Clock";
			clockItem.Click += new System.EventHandler(OnClock);
			clockItem.Image  = Properties.Resources.ClockImage;
			menu.Items.Add(clockItem);

			ToolStripMenuItem settingsItem = new ToolStripMenuItem();
			settingsItem.Text   = "Settings";
			settingsItem.Click += new System.EventHandler(OnSettings);
			settingsItem.Image  = Properties.Resources.SettingsImage;
			menu.Items.Add(settingsItem);

			menu.Items.Add(new ToolStripSeparator());

			ToolStripMenuItem exitItem = new ToolStripMenuItem();
			exitItem.Text   = "Exit";
			exitItem.Click += new System.EventHandler(OnExit);
			exitItem.Image  = Properties.Resources.ExitImage;
			menu.Items.Add(exitItem);

			return menu;
		}

		/// <summary>
		/// Handles the MouseClick event from the NotifyIcon control.
		/// </summary>
		void OnMouseClick(
			object sender,
			MouseEventArgs e)
		{

		}

		/// <summary>
		/// Handles the Clock menu option.
		/// </summary>
		void OnClock(
			object sender,
			EventArgs e)
		{
			m_clockDlg.Show();
		}

		/// <summary>
		/// Handles the Settings menu option.
		/// </summary>
		void OnSettings(
			object sender,
			EventArgs e)
		{
			if (m_showingSettings == false)
			{
				m_showingSettings = true;
				FormSettings dlg = new FormSettings();
				dlg.ShowDialog();
				m_showingSettings = false;
			}
		}
		
		/// <summary>
		/// Handles the Exit menu option.
		/// </summary>
		void OnExit(
			object sender,
			EventArgs e)
		{
			FormPassword password = new FormPassword();
			if (password.ShowDialog() == DialogResult.OK)
			{
				Application.Exit();
			}
		}
	}
}
