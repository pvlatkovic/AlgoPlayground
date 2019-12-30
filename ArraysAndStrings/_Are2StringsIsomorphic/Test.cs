using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.Are2StringsIsomorphic
{
	public class Test
	{
		[Theory]
		[InlineData("brain", "space", true)]
		[InlineData("noon", "feet", false)]
		[InlineData("aab", "ccd", true)]
		public void TestAre2StringsIsomorphic(string A, string B, bool resultExpected)
		{
			/*
				A = “brain”, B = “space”		true
				A = “noon”, B = “feet”		false
				A = “aab”, B = “ccd”		true
			*/

			//Given A and B
			
			//When
			var result = Solution.Are2StringsIsomorphic(A, B);

			//Then
			Assert.Equal(resultExpected, result);
		}
	}
}