using Xunit;

namespace org.pv.AlgoPlayground.AP.MultiplyGigantic
{
	public class Test
	{
		[Fact]
		public void TestMultiply()
		{
			//given
			string n = "719";
			int m = 81;

			//when
			var result = Solution.Multiply(n, m);
			var resultExpected = "58239‬";

			//then
			Assert.True(resultExpected.CompareTo(result) == 0);
		}
	}
}