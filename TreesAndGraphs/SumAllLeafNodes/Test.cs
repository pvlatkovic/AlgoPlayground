using System;
using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.TreesAndGraphs.SumAllLeafNodes
{
	public static class Test
	{
		[Fact]
		public static void TestSumAllLeafNodes()
		{
			//GIVEN 
			// lets construct tree
			/*
							  5
						   /     \
						  4       3
						 / \    / | \
						1  -6  0  7  -4
					   / \        |
					  2   9       8
			*/
			// 1st level
			var root = new NodeTree<int>(5);

			// 2nd level
			var node4 = new NodeTree<int>(4);
			var node3 = new NodeTree<int>(3);
			root.ChildNodes.Add(node4); root.ChildNodes.Add(node3);

			// 3rd level
			var node1 = new NodeTree<int>(1);
			var nodem6 = new NodeTree<int>(-6);
			var node0 = new NodeTree<int>(0);
			var node7 = new NodeTree<int>(7);
			var nodem4 = new NodeTree<int>(-4);
			node4.ChildNodes.Add(node1); node4.ChildNodes.Add(nodem6);
			node3.ChildNodes.Add(node0); node3.ChildNodes.Add(node7); node3.ChildNodes.Add(nodem4);

			// 4th level
			var node2 = new NodeTree<int>(2);
			var node9 = new NodeTree<int>(9);
			var node8 = new NodeTree<int>(8);
			node1.ChildNodes.Add(node2); node1.ChildNodes.Add(node9);
			node7.ChildNodes.Add(node8);

			//WHEN
			var result = Solution.SumAllLeafNodes(root);

			//THEN
			var resultExpected = 9;
			Assert.Equal(resultExpected, result);
		}
	}
}