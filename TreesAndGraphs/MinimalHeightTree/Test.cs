using System;
using Xunit;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.MinimalHeightTree
{
	public static class Test
	{
		[Fact]
		public static void TestMinimalHeightTree()
		{
			//GIVEN
			var sortedArray = new int[] {1, 2, 3, 4, 5, 6, 7, 8};

			//WHEN
			var result = Solution.CreateBSTWithMinimalHeight(sortedArray);

			//THEN
			var minHeightExpected = 4;
			var minHeight = FindHeightBinaryTree.Solution<int>.FindHeightBinaryTree(result);

			Assert.Equal(minHeightExpected, minHeight);
		}
	}
}