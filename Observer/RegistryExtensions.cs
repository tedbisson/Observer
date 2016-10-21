using Microsoft.Win32;
using System;

namespace Observer
{
	/// <summary>
	/// Extensions to the Registry class.
	/// </summary>
	public static class RegistryExtensions
	{
		/// <summary>
		/// Opens, and if necessary creates the Registry key path .
		/// </summary>
		/// <returns>Returns the key if successful, opened for writing, null otherwise.</returns>
		public static RegistryKey OpenOrCreateKey(
			this RegistryKey key,
			string keyPath)
		{
			// Split the path into the component parts.
			string[] path = keyPath.Split('\\');

			// Open or create each part in sequence.
			RegistryKey currentKey = key;
			foreach (string part in path)
			{
				RegistryKey childKey = currentKey.OpenSubKey(part, true);
				if (childKey == null)
				{
					childKey = currentKey.CreateSubKey(part);
					if (childKey == null)
						return null;
				}

				currentKey = childKey;
			}

			return currentKey;
		}

		/// <summary>
		/// Returns the int value in the registry, or the default value if there is an issue.
		/// </summary>
		public static int GetIntValue(
			this RegistryKey key,
			string name,
			int defaultValue)
		{
			try
			{
				if (key.GetValueKind(name) == RegistryValueKind.DWord)
				{
					return (int) key.GetValue(name);
				}
			}
			catch (Exception)
			{
			}

			return defaultValue;
		}

		/// <summary>
		/// Sets the int value in the registry.
		/// </summary>
		public static void SetIntValue(
			this RegistryKey key,
			string name,
			int value)
		{
			try
			{
				key.SetValue(name, value, RegistryValueKind.DWord);
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// Returns the long value in the registry, or the default value if there is an issue.
		/// </summary>
		public static long GetLongValue(
			this RegistryKey key,
			string name,
			long defaultValue)
		{
			try
			{
				if (key.GetValueKind(name) == RegistryValueKind.QWord)
				{
					return (long) key.GetValue(name);
				}
			}
			catch (Exception)
			{
			}

			return defaultValue;
		}

		/// <summary>
		/// Sets the long value in the registry.
		/// </summary>
		public static void SetLongValue(
			this RegistryKey key,
			string name,
			long value)
		{
			try
			{
				key.SetValue(name, value, RegistryValueKind.QWord);
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// Returns the string value in the registry, or the default value if there is an issue.
		/// </summary>
		public static string GetStringValue(
			this RegistryKey key,
			string name,
			string defaultValue)
		{
			try
			{
				if (key.GetValueKind(name) == RegistryValueKind.String)
				{
					return (string) key.GetValue(name);
				}
			}
			catch (Exception)
			{
			}

			return defaultValue;
		}

		/// <summary>
		/// Sets the string value in the registry.
		/// </summary>
		public static void SetStringValue(
			this RegistryKey key,
			string name,
			string value)
		{
			try
			{
				key.SetValue(name, value, RegistryValueKind.String);
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// Returns the bool value in the registry, or the default value if there is an issue.
		/// </summary>
		public static bool GetBoolValue(
			this RegistryKey key,
			string name,
			bool defaultValue)
		{
			int defaultIntValue = defaultValue == true? 1 : 0;
			if (GetIntValue(key, name, (defaultValue == true ? 1 : 0)) == 1)
				return true;
			return false;
		}

		/// <summary>
		/// Sets the bool value in the registry.
		/// </summary>
		public static void SetBoolValue(
			this RegistryKey key,
			string name,
			bool value)
		{
			SetIntValue(key, name, (value == true ? 1 : 0));
		}

		/// <summary>
		/// Returns the DateTime value in the registry, or the default value if there is an issue.
		/// </summary>
		public static DateTime GetDateTimeValue(
			this RegistryKey key,
			string name,
			DateTime defaultValue)
		{
			return DateTime.FromBinary(GetLongValue(key, name, defaultValue.Ticks));
		}

		/// <summary>
		/// Sets the DateTime value in the registry.
		/// </summary>
		public static void SetDateTimeValue(
			this RegistryKey key,
			string name,
			DateTime value)
		{
			SetLongValue(key, name, value.Ticks);
		}
	}
}
