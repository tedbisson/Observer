﻿using System;

namespace Observer
{
	/// <summary>
	/// Extensions to the string class.
	/// </summary>
	public static class StringExtensions
	{
		/// <summary>
		/// Computes a hash value for the string provided.  This is a simple algorithm, but it will remain stable
		/// across .Net versions, something not guaranteed by the API otherwise.  (Although alternatives exist.)
		/// </summary>
		public static int ComputeHash(this string str)
		{
			int hash = 42;
			foreach (char c in str)
			{
				hash = ((hash << 5) + hash) + (int) c;
			}

			return hash;
		}
	}
}
