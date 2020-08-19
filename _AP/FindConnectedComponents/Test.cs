using System.Collections.Generic;
using Xunit;

namespace org.pv.AlgoPlayground.AP.FindConnectedComponents
{
	public class Test
	{
		[Fact]
		public static void TestFindConnectedComponentsBFS()
		{
			//given
			// 0 - 1 - 2 - 3, 4
			// 7 - 5 - 6
			var M = new int[,] { 
				{0, 1, 0, 0, 0, 0, 0, 0},
				{0, 0, 1, 0, 0, 0, 0, 0},
				{0, 0, 0, 1, 1, 0, 0, 0},
				{0, 0, 0, 0, 0, 0, 0, 0},
				{0, 0, 0, 0, 0, 0, 0, 0},
				{0, 0, 0, 0, 0, 0, 1, 1},
				{0, 0, 0, 0, 0, 0, 0, 0},
				{0, 0, 0, 0, 0, 0, 0, 0},
			};

			//when
			var result = Solution.FindConnectedComponentsBFS(M);			

			//then
			var resultExpected = new Dictionary<int, List<int>>();
			resultExpected[0] = new List<int> {1, 2, 3, 4};
			resultExpected[5] = new List<int> { 6, 7 };
			foreach(int v in result.Keys)
			{
				for(int i = 0; i < result[v].Count; i++)
				{
					Assert.True(result[v][i] == resultExpected[v][i]);
				}
			}
		}
	}
}