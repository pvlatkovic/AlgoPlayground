using Xunit;

namespace org.pv.AlgoPlayground.DynamicProgramming.LongestCommonSubsequence
{
	public class Test
	{
		
		[Theory]
		[InlineData("AGGTAB", "GXTXAYB", 4)]
		[InlineData("ABCDGH", "AEDFHR", 3)] 
		[InlineData("12345", "23415", 4)] 
		[InlineData("JATAXGPDMYLDXUKDNFTPRRUMBMEMLROWRHWOQNTCLGHLCRORZHGSBAECPLPCCDYVNXMDMFHAOPLQ", "IZKHIQBJTIMITDKXIKSXJECWMKWABHSL", 12)] 
		public void TestLongestCommonSubsequence(string p, string q, int resultExpected)
		{
			//Given p and q from test inline data
			
			//When
			var result = Solution.FindLongestCommonSubsequence(p, q);

			//Then
			Assert.Equal(resultExpected, result);
		}
	}
}