/*
	https://www.geeksforgeeks.org/largest-sum-contiguous-subarray/
	Write an efficient program to find the sum of contiguous subarray within 
	a one-dimensional array of numbers which has the largest sum.	

	int[] A = { -2, -3, 4, -1, -2, 1, 5, -2 } => 7 sum(4, -1, -2, 1, 5)
*/

using System;

namespace org.pv.AlgoPlayground.DynamicProgramming.MaximumSubarray
{
	public class Solution
	{
		public static int FindMaxSubarray(int[] a) // Kadane's algorithm 
		{
			var self = a[0];
			var currentMax = a[0];
			var max = a[0];

			for(int i=1; i < a.Length; i++)
			{
				self = a[i];
				currentMax += self;

				if(self > currentMax)
					currentMax = self;
				
				if(max < currentMax)
					max = currentMax;
			}
			return max;
		}
	}
}