using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
