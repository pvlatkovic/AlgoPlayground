using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.StringCompression
{
	public class Test
	{
		[Theory]
		[InlineData("aabcccccaaa", "a2b1c5a3")]
		[InlineData("aaaaaaaa", "a8")]
		[InlineData("abc", "abc")]
		public void TestCompression(string s, string resultExpected)
		{
			//Given 

			//When
			var result = Solution.Compress(s);

			//Then
			Assert.Equal(resultExpected, result);
		}
	}
}