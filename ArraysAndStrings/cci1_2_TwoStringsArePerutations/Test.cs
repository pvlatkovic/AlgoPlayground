using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.TwoStringsArePermutations
{
	public class Test
	{
		[Theory]
		[InlineData("bulevar", "levubar", true)]
		[InlineData("bulevar", "levubac", false)]
		[InlineData("aaaaaaaaa", "aaaaaaaaa", true)]
		public void TestIfTwoStringsArePermutations(string s1, string s2, bool resultExpected)
		{
			//Given s1 and s2

			//When
			var result = Solution.CheckTwoStringsArePermutations(s1, s2);

			//Then
			Assert.Equal(resultExpected, result);
		}
	}
}


