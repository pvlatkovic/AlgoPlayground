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
		[Fact]
		public void TestNQueens()
		{
			//Given N
			var N = 8;

			//When
			var result = Solution.SolveNQuens(N);

			//Then
			Assert.True(result.Count > 0);
		}
	}
}