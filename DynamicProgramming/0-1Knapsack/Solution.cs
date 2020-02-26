/*
	weight 1 2 3 4 5
	value  5 3 5 3 2

	given the capacity of the knapsack maximize total amount of value for carried items. 
	for example: knapsack capacity 10 -> value 16 (items 0, 1, 2, 3)

	- total number of possible solution is 2^n (n number of items) O(2^n)
	- with memoization we can do O(n)
*/

using System;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.DynamicProgramming._01Knapsack
{
	public class Solution
	{
		public static int NaiveRecursion01Knapsack(int[] w, int[] v, int capacity) 
		{
			
			if(w.Length != v.Length)
				throw new ArgumentException("number of weights and values must be equal");
			
			var index = w.Length - 1;
			return rec(w, v, index, capacity);
		}

		private static int rec(int[] w, int[] v, int index, int capacity)
		{
			var key = index.ToString() + "_" + capacity.ToString();

			if(capacity == 0 || index < 0)
			 	return 0;

			int max;

			if(w[index] > capacity)
			{
				max = rec(w, v, index-1, capacity);
			}
			else
			{
				//calculate without the item 
				var m1 = rec(w, v, index-1, capacity);
				//calculate with the item 
				var m2 = v[index] + rec(w, v, index-1, capacity-w[index]);
				// check which is bigger
				max = m1 > m2 ? m1 : m2;
			}

			return max;
		}

		public static int MomoizeRecursion01Knapsack(int[] w, int[] v, int capacity) 
		{
			
			if(w.Length != v.Length)
				throw new ArgumentException("number of weights and values must be equal");
			
			var index = w.Length - 1;
			return recMemo(w, v, index, capacity);
		}
		
		private static Dictionary<string, int> cache = new Dictionary<string, int>();

		private static int recMemo(int[] w, int[] v, int index, int capacity)
		{
			var key = index.ToString() + "_" + capacity.ToString();
			if(cache.ContainsKey(key))
			  	return cache[key];

			if(capacity == 0 || index < 0)
			 	return 0;

			int max;

			if(w[index] > capacity)
			{
				max = recMemo(w, v, index-1, capacity);
			}
			else
			{
				//calculate without the item 
				var m1 = recMemo(w, v, index-1, capacity);
				//calculate with the item 
				var m2 = v[index] + recMemo(w, v, index-1, capacity-w[index]);
				// check which is bigger
				max = m1 > m2 ? m1 : m2;
			}

			// insert to cache and runaway :)
			cache[key] = max;
			return max;
		}
	}
}