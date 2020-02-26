using Xunit;

namespace org.pv.AlgoPlayground.DynamicProgramming.MaximumSubarray
{
	public class Test
	{
		[Theory]
		[InlineData(new int[5] {1, -3, 2, 1, -1}, 3)]
		[InlineData(new int[8] { -2, -3, 4, -1, -2, 1, 5, -2 }, 7)]
		[InlineData(new int[9] { -2, -3, 4, -1, -1, 1, 5, 10, -2 }, 18)]
		public void TestMaximumSubarray(int[] A, int resultExpected)
		{
			//Given A 
			
			//When
			var result = Solution.FindMaxSubarray(A);

			//Then
			Assert.Equal(resultExpected, result);
		}
	}
}