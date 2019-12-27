using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.StringAllUniqueCharacters
{
	public class Test
	{
		[Theory]
		[InlineData("beograd", true)]
		[InlineData("Area", true)]
		[InlineData("area", false)]
		public void TestStringAllUniqueCharacters(string input, bool resultExpected)
		{
			//Given 
			// input

			//When
			var result = Solution.GetStringAllUniqueCharacters_Brute(input);

			//Then 
			Assert.Equal(resultExpected, result);


			//When
			result = Solution.GetStringAllUniqueCharacters_DS(input);

			//Then 
			Assert.Equal(resultExpected, result);

		}
	}
}