using Xunit;

namespace org.pv.AlgoPlayground.MSP.RomanDigitsFormTwoMinSumNumbers
{
	public class Test
	{
		[Fact]
		public void TestRomanDigitsFormTwoMinSumNumbers()
		{
			// arrange
			var romans = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };

			var d1 = "CMIX".ToCharArray();
			var d2 = "DLV".ToCharArray();

			// act
			var result = Solution.Execute(romans);

			// assert
			Assert.Equal(d1, result.Item1);
			Assert.Equal(d2, result.Item2);
		}
	}
}