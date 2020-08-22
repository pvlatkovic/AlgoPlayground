/*
Given an array arr[] of n integers, construct a Product Array prod[] (of same size) 
such that prod[i] is equal to the product of all the elements of arr[] except arr[i]. 
Solve it without division operator in O(n) time!

I
Input: arr[]  = {10, 3, 5, 6, 2}
Output: prod[]  = {180, 600, 360, 300, 900}

II
Input: arr[]  = {1, 2, 3, 4, 5}
Output: prod[]  = {120, 60, 40, 30, 24 }
*/


namespace org.pv.AlgoPlayground.MSP.ProductArrayPuzzle
{
	public class Solution
	{
		public static int[] ExecuteBrute(int[] a)
		{
			//O(N^2) 
			var product = new int[a.Length];
			for (int i = 0; i < a.Length; i++)
			{
				var p = 1;
				for (int j = 0; j < a.Length; j++)
				{
					if (i != j)
						p *= a[j];
				}
				product[i] = p;
			}

			return product;
		}

		public static int[] Execute(int[] a)
		{
			// O(N) time complexity, O(N) space (more needed + two extra arrays :)
			//  {10, 3, 5, 6, 2} -> { 180, 600, 360, 300, 900 }
			//  A {1, 10, 30, 150, 900} left side miltiplications
			//  B {180, 60, 12, 2, 1} right side multiplications

			var left = new int[a.Length];
			var right = new int[a.Length];

			left[0] = 1;
			right[a.Length - 1] = 1;
			for (int i = 1; i < a.Length; i++)      // { 1, 10, 30, 150, 900}
			{
				left[i] = left[i - 1] * a[i - 1];
				right[a.Length - 1 - i] = right[a.Length - i] * a[a.Length - i];
			}

			var product = new int[a.Length];
			for (int i = 0; i < a.Length; i++) // join A and B
			{
				product[i] = left[i] * right[i];
			}

			return product;
		}

		public static int[] ExecuteLessSpace(int[] a)
		{
			// O(N) time complexity, no extra space required

			var product = new int[a.Length];

			product[0] = 1;
			for (int i = 1; i < a.Length; i++)      // { 1, 10, 30, 150, 900}
			{
				product[i] = product[i - 1] * a[i - 1];
			}

			var t = 1;
			for (int i = a.Length - 1; i >= 0; i--)
			{
				product[i] = product[i] * t;
				t *= a[i];
			}

			return product;
		}
	}
}