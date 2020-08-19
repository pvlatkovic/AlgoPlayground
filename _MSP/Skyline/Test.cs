using Xunit;

namespace org.pv.AlgoPlayground.MSP.Skyline
{
	public class Test
	{
		public void TestSkyline()
		{
			// arrange 
			var buildings = new int[][] { new int[] { 2, 9, 10 }, new int[] { 3, 7, 15 }, new int[] { 5, 12, 12 }, new int[] { 15, 20, 10 }, new int[] { 19, 24, 8 } };

			// act 
			var result = Solution.Execute(buildings);
			var resultExpected = new int[][] { new int[] { 2, 10 }, new int[] { 3, 15 }, new int[] { 7, 12 }, new int[] { 12, 0 }, new int[] { 15, 10 }, new int[] { 20, 8 }, new int[] { 24, 0 } };

			// assert
			Assert.Equal(resultExpected, result);
		}
	}
}