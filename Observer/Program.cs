using System;
using System.Windows.Forms;

namespace Observer
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Initialize the program settings.
			Settings.Initialize();

			// Start the main icon interface in the system tray.
			using (TrayIcon trayIcon = new TrayIcon())
			{
				// Show the system tray icon.
				trayIcon.Display();

				// Run the main loop.
				Application.Run();
			}
		}
	}
}
