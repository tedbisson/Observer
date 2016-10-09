using System;
using System.Drawing;
using System.Windows.Forms;

namespace Observer
{
	/// <summary>
	/// Manages the tray icon, which is the primary interface for this program.
	/// </summary>
	public class TrayIcon : IDisposable
	{
		private NotifyIcon   m_notifyIcon;
		private FormClock    m_clockDlg;
		private FormSettings m_settingsDlg;

		/// <summary>
		/// Accessor for components to get back to this main program controller,
		/// which is not a form.  Otherwise we could use standard Owner/Parent
		/// properties.
		/// </summary>
		private static TrayIcon m_trayIcon = null;
		public static TrayIcon Instance
		{
			get { return m_trayIcon; }
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		public TrayIcon()
		{
			// The one and only TrayIcon program.
			m_trayIcon = this;

			// Setup components.
			m_notifyIcon  = new NotifyIcon();
			m_clockDlg    = new FormClock();
			m_settingsDlg = new FormSettings();
		}

		/// <summary>
		/// Cleans up when the program shuts down.
		/// </summary>
		public void Dispose()
		{
			// Clean up the tray icon now!
			m_notifyIcon.Dispose();
			m_clockDlg.Close();
			m_settingsDlg.Close();
		}

		/// <summary>
		/// Sets up the tray icon and starts the program.
		/// </summary>
		public void Display()
		{
			// Setup the notify icon control.
			m_notifyIcon.Icon    = Icon.FromHandle(Properties.Resources.ObserverImage.GetHicon());
			m_notifyIcon.Text    = "Daddy Observation Tool";
			m_notifyIcon.Visible = true;

			// Setup the context menu.
			m_notifyIcon.ContextMenuStrip = SetupContextMenu();

			// Show the clock immediately.
			m_clockDlg.Show();
		}

		/// <summary>
		/// Creates the context menu for the tray icon.
		/// </summary>
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
		/// Handles the Clock menu option.
		/// </summary>
		private void OnClock(
			object sender,
			EventArgs e)
		{
			m_clockDlg.Show();
		}

		/// <summary>
		/// Handles the Settings menu option.
		/// </summary>
		private void OnSettings(
			object sender,
			EventArgs e)
		{
			ShowSettingsDlg();
		}

		/// <summary>
		/// Verifies the admin password, then displays the settings dialog.
		/// </summary>
		public void ShowSettingsDlg()
		{
			// If it's visible, we're done.
			if (m_settingsDlg.Visible == true)
				return;

			// Admin password required.
			FormPassword password = new FormPassword();
			if (password.ShowDialog() != DialogResult.OK)
				return;

			// Show the settings dialog.
			m_settingsDlg.Show();
		}
		
		/// <summary>
		/// Handles the Exit menu option.
		/// </summary>
		private void OnExit(
			object sender,
			EventArgs e)
		{
			FormPassword password = new FormPassword();
			if (password.ShowDialog() == DialogResult.OK)
			{
				Settings.ShuttingDown = true;
				Application.Exit();
			}
		}
	}
}
