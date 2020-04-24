// Given an array A[] and a number x, check for pair in A[] with sum as x

using System.Linq;
using Xunit;

namespace org.pv.AlgoPlayground.ArraysAndStrings.TwoSum
{
	public class Test
	{
		[Fact]
		public void TestTwoSumBrute()
		{
			//given an array
			var a = new int[] { 1 , 4, -1, 7, 6, 3};
			var target = 7;

			//when 
			var result = Solution.FindTwoSumBrute(a, target);

			//then
			Assert.True(result.SequenceEqual(new int[] { 0, 4}));

			// given 
			target = 50;
			//when 
			var result2 = Solution.FindTwoSumBrute(a, target);
			//then
			Assert.True(result2.SequenceEqual(new int[] { -1, -1 }));

			// given 
			target = 4;
			a = new int[] {};
			//when 
			var result3 = Solution.FindTwoSumBrute(a, target);
			//then
			Assert.True(result3.SequenceEqual(new int[] { -1, -1 }));
		}

		[Fact]
		public void TestTwoSumOpt()
		{
			//given an array
			var a = new int[] { 1, 4, -1, 7, 6, 3 };
			var target = 7;

			//when 
			var result = Solution.FindTwoSumOpt(a, target);

			//then
			Assert.True(result.SequenceEqual(new int[] { 0, 4 }));

			// given 
			target = 50;
			//when 
			var result2 = Solution.FindTwoSumOpt(a, target);
			//then
			Assert.True(result2.SequenceEqual(new int[] { -1, -1 }));

			// given 
			target = 4;
			a = new int[] { };
			//when 
			var result3 = Solution.FindTwoSumOpt(a, target);
			//then
			Assert.True(result3.SequenceEqual(new int[] { -1, -1 }));
		}
	}
}