/*
	Find longest non decreasing subsequence of an array
*/

using System;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.DynamicProgramming.LongestNonDecreasingSubsequence
{
	public class Solution 
	{
		public static int FindLongestNonDecreasingSubsequence(int[] a)
		{
			var l = new int[a.Length]; 
			l[0] = 1;
			var max = l[0];

			for(int i = 1; i < a.Length; i++)
			{
				l[i] = 1;
				for(int j = 0; j < i; j++)
				{
					if(a[j] <= a[i])
					{
						if(l[i] < l[j] + 1)
							l[i] = l[j] + 1;
					}
				}
				if(max < l[i])
					max = l[i];
			}
			return max;
		}
	}
}