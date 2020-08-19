using Xunit;

namespace org.pv.AlgoPlayground.MSP.CompressString
{
	public class Test
	{
		[Fact]
		public void TestCompressString()
		{
			// Arrange
			var input = "aaaaaaaaaaaaaaaaaaaaabccdddaad".ToCharArray();

			// Act
			var result = Solution.Execute(input);

			// Assert
			for(int i=0; i < result.Item2; i++)
				Assert.Equal("a21bc2d3a2d"[i], result.Item1[i]);
		}
	}
}