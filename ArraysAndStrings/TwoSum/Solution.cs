// Given an array A[] and a number x, check for pair in A[] with sum as x

using System.Collections.Generic;

namespace org.pv.AlgoPlayground.ArraysAndStrings.TwoSum
{
	public class Solution
	{
		public static int[] FindTwoSumBrute(int[] array, int target)
		{
			for(int i=0; i < array.Length-1; i++)
			{
				for(int j=i+1; j < array.Length; j++)
					if(array[i] + array[j] == target)
						return new int[] {i, j};
			}
			return new int[] { -1, -1};	
		}

		public static int[] FindTwoSumOpt(int[] array, int target)
		{
			var complements = new Dictionary<int,int>();
			for(int i=0; i < array.Length; i++)
			{
				if(complements.ContainsKey(array[i]))
					return new int[] {complements[array[i]], i};
				var complement = target - array[i];
				complements[complement] = i;
			}
			return new int[] { -1, -1 };
		}
	}
}