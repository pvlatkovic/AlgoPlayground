// Find Sets Of Numbers That Add Up To N (target)
// FindSetsOfNumbersThatAddUpToN(int[] array, int N), returns number of sets that can add up to N

using System;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.DynamicProgramming.FindSetsOfNumbersThatAddUpToN
{
	public class Solution
	{
		public static int FindSetsRecursion(int[] v, int target) 
		{
			var index = v.Length - 1;
			return rec(v, index, target);
		}

		private static Dictionary<string, int> cache = new Dictionary<string, int>();

		private static int rec(int[] v, int index, int target)
		{
			var key = index + "_" + target;
			if (cache.ContainsKey(key))
				return cache[key];

			if(target == 0)
			 	return 1;
			
			if(index < 0)
				return 0;

			int res;

			// if commented we assume non positive numbers could be used in the input array
			// if(target < v[index])
			// 	res = rec(v, index-1, target); // skip
			// else
			res = rec(v, index-1, target - v[index]) + rec(v, index-1, target); // check "left" and "right" branch, with or without current value for the index

			cache[key] = res;
			return res;
		}
	}
}
