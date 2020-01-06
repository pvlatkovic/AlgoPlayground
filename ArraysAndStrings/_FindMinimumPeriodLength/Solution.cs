/*
You are given an array a of length n = 2m. Write a function that finds length of the minimal period T of array a.

int MinPeriod(int * a, int n)

Number T is a period of array a, if repeating first T elements of array a several times gives exactly array a, without any extra elements.

Examples:

Input	Output
n = 8		4
a = {2, 5, 3, 4, 2, 5, 3, 4}		
n = 8		8
a = {2, 5, 3, 2, 5, 3, 2, 5}

*/

namespace org.pv.AlgoPlayground.ArraysAndStrings.FindMinimumPeriodLength
{
	public class Solution
	{
		public static int MinPeriod(int[] A, int n)
		{
			var m = n / 2;
			bool isPeriodBreak;

			for (var t = 1; t <= m; t++)
			{
				if (A[0] == A[t] && n % t == 0) // check if t can be full period and if t-th element is equal to first one
				{
					isPeriodBreak = false;
					for (int k = 0; k < m; k = k + t) // start checking period t
					{
						for (int i = 0; i < t; i++)
						{
							if (A[i] != A[i + k + t])
							{
								isPeriodBreak = true;
								break;
							}
						}
						if (isPeriodBreak)
							break;
					}
					if (!isPeriodBreak)
						return t;
				}
			}

			return n;
		}
	}
}

