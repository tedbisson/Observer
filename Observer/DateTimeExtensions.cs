using System;

namespace Observer
{
	/// <summary>
	/// Extensions to the date time class
	/// </summary>
	public static class DateTimeExtensions
	{
		/// <summary>
		/// Generates a simple 32-bit value to represent the date.  YYYYMMDD
		/// </summary>
		public static int DateOnly(this DateTime dateTime)
		{
			return ((dateTime.Year << 16) + (dateTime.Month << 8) + (dateTime.Day));
		}
	}
}
