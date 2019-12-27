using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.TwoStringsArePermutations
{
	public class Test
	{
		[Fact]
		public void TestIfTwoStringsArePermutations()
		{
			//Given
			var s1 = "bulevar";
			var s2 = "levubar";

			//When
			var result = Solution.CheckTwoStringsArePermutations(s1, s2);

			//Then
			Assert.True(result);
		}
	}
}


