using System.Diagnostics;
using Xunit;

namespace org.pv.AlgoPlayground.DynamicProgramming.LongestNonDecreasingSubsequence
{
	public class Test
	{
		[Theory]
		[InlineData(new int[] {3, 2, 6, 4, 5, 1}, 3)]
		[InlineData(new int[] {15, 27, 14, 38, 63, 55, 46, 65, 85}, 6)]
		[InlineData(new int[] {10, 22, 9, 33, 21, 50, 41, 60, 80}, 6)]
		[InlineData(new int[] {1, 2, -1, 0, 6, 5, 4, 3, 2, 1, 1, 1, 1, 1, 1}, 8)]
		[InlineData(new int[] {3, 2, -1, 3, 4, 5, -1, 0, 1, 2, 3, 4, 5, 6}, 9)]
		[InlineData(new int[] {3, 10, 2, 1, 20}, 3)]
		[InlineData(new int[] {50, 3, 10, 7, 40, 80}, 4)]
		public void TestLongestNonDecreasingSubsequenceBrute(int[] a, int expectedResult)
		{
			//Given 
			// a from inline data

			//When 
			var result = Solution.FindLongestNonDecreasingSubsequence(a);
			
			//Then
			Assert.Equal(expectedResult, result);
		}
	}
}
