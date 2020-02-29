/*
	You are given 2 strings. Return the length of the longest subsequence that the 2 strings share.
*/

using System;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.DynamicProgramming.LongestCommonSubsequence
{
	public class Solution 
	{
		public static int FindLongestCommonSubsequence(string p, string q)
		{
			return Lcs(p, q);
		}

		private static Dictionary<string, int> cache = new Dictionary<string, int>();

		private static int Lcs(string p, string q)
		{
			if(p.Length == 0 || q.Length == 0)
				return 0;

			// comment caching section and watch your CPU dying :) not recommended!
			var key = p + "_" + q;
			if(cache.ContainsKey(key))
				return cache[key];

			var pShort1 = p.Length == 1 ? "" : p.Substring(0, p.Length-1);
			var qShort1 = q.Length == 1 ? "" : q.Substring(0, q.Length-1);

			var l = 0;

			if(p[p.Length-1] == q[q.Length-1]) // last characters are same
				l = 1 + Lcs(pShort1, qShort1);
			else
				l = Max(Lcs(p, qShort1), Lcs(pShort1, q));;

			cache[key] = l;
			return l;
		}

		private static int Max(int a, int b)
		{
			return a > b ? a : b;
		}
	}
}