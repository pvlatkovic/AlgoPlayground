/*
<------  N-Queens Solutions  -----> 
 N:           Total          Unique 
 5:              10               2   
 6:               4               1   
 7:              40               6   
 8:              92              12   
 9:             352              46   
10:             724              92 
11:            2680             341 
12:           14200            1787 
13:           73712            9233 
14:          365596           45752 
15:         2279184          285053 
16:        14772512         1846955 
17:        95815104        11977939 
18:       666090624        83263591 
19:      4968057848       621012754 
20:     39029188884      4878666808 
21:    314666222712     39333324973 
*/

using Xunit;

namespace org.pv.AlgoPlayground.DynamicProgramming.NQueens
{
	public class Test
	{
		[Theory]
		[InlineData(5, 10)]
		[InlineData(6, 4)]
		[InlineData(7, 40)]
		[InlineData(8, 92)]
		[InlineData(9, 352)]
		[InlineData(10, 724)]
		[InlineData(11, 2680)]
		[InlineData(12, 14200)]
		public void TestNQueens(int N, int resultExprected)
		{
			//Given N

			//When
			var result = Solution.SolveNQuens(N);

			//Then
			Assert.True(resultExprected == result.Count);
		}
	}
}