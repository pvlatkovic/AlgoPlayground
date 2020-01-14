using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.IsPalindromPermutation
{
	public class Test
	{
		[Theory]
		[InlineData("aba", true)] 
		[InlineData("abab", true)] // abba
		[InlineData("aaaaaabbc", true)] // aaabcbaaa
		[InlineData("tact coa", true)] // tacocat
		[InlineData("a", true)]
		[InlineData("tactcoax", false)]
		public void TestURLifyString(string testString, bool resultExpected)
		{
			//Given testString 

			//When 
			var result = Solution.IsStringPalindromPermutation(testString);

			//Then
			Assert.Equal(resultExpected, result);
		}
	}
}