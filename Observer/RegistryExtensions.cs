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
		/// 
		/// </summary>
		public static int GetIntValue(
			this RegistryKey key,
			string name,
			int defaultValue)
		{
			object theValue = key.GetValue(name);
			if (theValue == null)
				return defaultValue;

			Type type = theValue.GetType();
			if (type != typeof(System.Int32))
				return defaultValue;

			return (int)theValue;
		}

		public static void SetIntValue(
			this RegistryKey key,
			string name,
			int value)
		{
			key.SetValue(name, value);
		}
	}
}
