using Xunit;

namespace org.pv.AlgoPlayground.DynamicProgramming.FindSetsOfNumbersThatAddUpToN
{
	public class Test
	{
		[Fact]
		public void TestNaiveRecursionFindSets()	
		{
			//Given 
			var a = new int[5] {9, 4, 6, 11, -2};
			var target = 15;

			//When
			int result = Solution.FindSetsRecursion(a, target);

			//Then
			Assert.Equal(3, result);
		}
	}
}