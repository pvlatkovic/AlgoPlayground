/*
print out the counter clockwise traversal of a binary tree
	
Input:
     1
   /  \
  2    3
 / \  / \
4   5 6  7 
Output: 1 4 5 6 7 3 2

Input:
       1			<- (1)
     /  \
    2    3			<- (3)
   /    / \
  4    5   6		-> (4)
 / \  /   / \
7   8 9  10  11		-> (2)
Output: 1 7 8 9 10 11 3 2 4 5 6

*/


using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;
using System;
using Xunit;

namespace org.pv.AlgoPlayground.MSP.CounterClockwiseBinTree
{
	public class Test 
	{
		[Fact]
		public void TestCounterClockwiseBinTree()
		{
			// arrange
			// create test tree
			// 0 raw
			var tree = new NodeBinTree<int>(1);
			// 1st raw
			tree.Left = new NodeBinTree<int>(2);
			tree.Right = new NodeBinTree<int>(3);
			
			// 2nd raw
			tree.Right.Left = new NodeBinTree<int>(5);
			tree.Right.Right = new NodeBinTree<int>(6);
			tree.Left.Left = new NodeBinTree<int>(4);

			// 3rd raw
			tree.Left.Left.Left = new NodeBinTree<int>(7);
			tree.Left.Left.Right = new NodeBinTree<int>(8);
			tree.Right.Left.Left = new NodeBinTree<int>(9);
			tree.Right.Right.Left = new NodeBinTree<int>(10);
			tree.Right.Right.Right = new NodeBinTree<int>(11);

			var resultExpected = new List<int>() {1, 7, 8, 9, 10, 11, 3, 2, 4, 5, 6 };

			// act
			var result = Solution.Execute(tree);

			// assert
			Assert.Equal(resultExpected.Count, result.Count);
			for(int i = 0; i < result.Count; i++)
			{
				Assert.Equal(resultExpected[i], result[i]);
			}
		}
	}
}