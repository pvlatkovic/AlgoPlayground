/*

Examples:

Input	Output
n = 8		4
a = {2, 5, 3, 4, 2, 5, 3, 4}		
n = 8		8
a = {2, 5, 3, 2, 5, 3, 2, 5}
*/

using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.FindMinimumPeriodLength
{
	public class Test
	{
		[Theory]
		[InlineData(new int[] {2, 5, 3, 4, 2, 5, 3, 4}, 4)]
		[InlineData(new int[] {1, 2, 3, 4, 5, 6, 7, 8}, 8)]
		[InlineData(new int[] {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3}, 3)]
		[InlineData(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, 1)]
		[InlineData(new int[] { 1, 3, 1, 2, 1, 3, 1, 2, 1, 3, 1, 2 }, 4)]
		[InlineData(new int[] { 1, 1, 3, 1, 1, 3, 1, 1, 3, 1, 1, 3 }, 3)]
		public void TestMinPeriod(int[] A, int resultExpected)
		{
			//Given inline data
			
			//When
			var result = Solution.MinPeriod(A, A.Length);
																			
			//Then
			Assert.Equal(resultExpected, result);
		}
	}

}
