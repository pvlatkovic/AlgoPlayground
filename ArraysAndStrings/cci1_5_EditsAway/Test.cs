using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.EditsAway
{
	public class Test
	{
		[Theory]
		[InlineData("pale", "ple", true)]
		[InlineData("pales", "pale", true)]
		[InlineData("pale", "bale", true)]
		[InlineData("pale", "bake", false)]
		public void OneOrZeroEditsAway(string a, string b, bool resultExpected)
		{
			//Given input

			//When
			var result = Solution.IsOneOrZeroEditsAway(a, b);

			//Then
			Assert.Equal(resultExpected, result);
		}
	}
}
