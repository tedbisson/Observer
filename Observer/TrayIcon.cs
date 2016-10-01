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
		}

		/// <summary>
		/// Sets up the tray icon and starts the program.
		/// </summary>
		public void Display()
		{
			// Setup the notify icon control.
			m_notifyIcon.MouseClick += new MouseEventHandler(OnMouseClick);
			m_notifyIcon.Icon        = Icon.FromHandle(Properties.Resources.ObserverIcon.GetHicon());
			m_notifyIcon.Text        = "Daddy Observation Tool";
			m_notifyIcon.Visible     = true;

			// Setup the context menu.
			m_notifyIcon.ContextMenuStrip = SetupContextMenu();
		}

		/// <summary>
		/// Creates the context menu for the tray icon.
		/// </summary>
		/// <returns></returns>
		private ContextMenuStrip SetupContextMenu()
		{
			ContextMenuStrip menu = new ContextMenuStrip();

			ToolStripMenuItem exitItem = new ToolStripMenuItem();
			exitItem.Text = "Exit";
			exitItem.Click += new System.EventHandler(OnExit);
			//exitItem.Image = Properties.Resources.ExitIcon;
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
		/// Handles the Exit menu option.
		/// </summary>
		void OnExit(
			object sender,
			EventArgs e)
		{
			Application.Exit();
		}
	}
}
