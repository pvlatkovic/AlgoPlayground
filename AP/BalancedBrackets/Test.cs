using System.Collections.Generic;
using Xunit;

namespace org.pv.AlgoPlayground.AP.BalancedBrackets
{
	public class Test
	{
		[Fact]
		public void TestIsBalancedBrackets()
		{
			//given 
			// acvf {} [] {() ([([])])} a qwe
			string testString = "acvf {} [] {() ([([])])} a qwe";

			//when 
			var result = Solution.IsBalancedBrackets(testString);
			
			//then 
			Assert.True(result);
		}
	}
}