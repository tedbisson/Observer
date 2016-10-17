using System;
using System.IO;
using System.Windows.Forms;

namespace Observer
{
	/// <summary>
	/// Interface used to write to the program log file.
	/// </summary>
	public static class Log
	{
		/// <summary>
		/// Property that returns the path to the log file.  Initialized on first use using the AppData folder.
		/// </summary>
		private static string m_logPath = string.Empty;
		public static string LogPath
		{
			get
			{
				// First time through identify the log path.
				if (m_logPath == string.Empty)
				{
					string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Cirius\\Observer\\logs";
					Directory.CreateDirectory(path);
					m_logPath = path + "\\log.txt";
				}
				return m_logPath;
			}
		}

		/// <summary>
		/// Writes the designated string to the log file.  Prepending the date and time.
		/// </summary>
		public static void Write(string text)
		{
			using (StreamWriter log = File.AppendText(LogPath))
			{
				log.WriteLine(DateTime.Now.ToString("yyyyMMdd-HHmmss") + " - " + text);
			}
		}
	}
}
