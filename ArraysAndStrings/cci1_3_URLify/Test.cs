using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.URLify
{
	public class Test
	{
		[Theory]
		[InlineData("Mr John Smith    ", "Mr%20John%20Smith")]
		[InlineData(" Mr John Smith      ", "%20Mr%20John%20Smith")]
		[InlineData(" Mr  John Smith        ", "%20Mr%20%20John%20Smith")]
		public void TestURLifyString(string testString, string resultExpected)
		{
			//Given string 
			// var testString = "Mr John Smith    ";
			// var resultExpected = "Mr%20John%20Smith";

			//When 
			var result = Solution.URLifyString(testString.ToCharArray());
			var resultString = new string(result);

			//Then
			Assert.Equal(resultExpected, resultString);
		}
	}
}