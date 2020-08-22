using Xunit;

namespace org.pv.AlgoPlayground.MSP.LongestPalindromicSubstring
{
	public class Test
	{
		[Fact]
		public void TestLongestPalindromicSubstring()
		{
			// arrange
			var testInput = "abaabbaaforgeeksskeegfor"; //"forgeeksskeegfor";

			// act
			var result = Solution.ExecuteBrute2(testInput);

			// Assert
			Assert.Equal("geeksskeeg", result); // "geeksskeeg"
		}
	}
}