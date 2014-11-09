﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemEx
{
	public static class StringEx
	{
		public static string format(this string s, params object[] args)
		{
			return string.Format(s, args);
		}

		public static char at(this string s, int i)
		{
			if (i < 0)
				return s[s.Length + i];
			return s[i];
		}

		public static string Join(this string[] s, string separator)
		{
			return string.Join(separator, s);
		}

		public static string Join(this IEnumerable<string> s, string separator)
		{
			return string.Join(separator, s.ToArray());
		}
	}
}
