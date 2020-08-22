/*
Input: arr[]  = { 10, 3, 5, 6, 2 }
Output: prod[]  = { 180, 600, 360, 300, 900 }
*/
using Xunit;

namespace org.pv.AlgoPlayground.MSP.ProductArrayPuzzle
{
	public class Test
	{
		[Fact]
		public void TestProductArrayPuzzle()
		{
			//arrange
			var input = new int[] { 10, 3, 5, 6, 2 };
			var output = new int[] { 180, 600, 360, 300, 900 };

			//act
			var result = Solution.ExecuteLessSpace(input);

			//assert
			for (int i = 0; i < result.Length; i++)
			{
				Assert.Equal(output[i], result[i]);
			}
		}
	}
}