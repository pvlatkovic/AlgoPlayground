using Xunit;

namespace org.pv.AlgoPlayground.Base62Hash
{
	public class Test
	{
		[Theory]
		[InlineData(int.MaxValue, "2LKcb1")]
		[InlineData(1, "1")]
		[InlineData(2, "2")]
		[InlineData(10, "A")]
		public void TestValidBase62Hash(int testNumber, string expected)
		{
			//given

			//when 
			var base62Hash = Base62Hash.GetBase62(testNumber);

			//then
			Assert.Equal(expected, base62Hash);
		}
	}
}