// https://www.youtube.com/watch?v=il_t1WVLNxk
// problem 1.

using System;
using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.AP.VerticalSumOfBinaryTree
{
	public class Test
	{
		[Fact]
		public void TestCalculateVerticalSum()
		{
			//GIVEN a binary tree
			// lets construct binary search tree - BST is used just to try, actually task is to find height of any binary tree
			/*
				definition of BST (binary search tree)
				- The left subtree of a node contains only nodes with keys lesser than the node’s key.
				- The right subtree of a node contains only nodes with keys greater than the node’s key.
				- The left and right subtree each must also be a binary search tree.

							 5
						  /     \
						 3       8
						/ \     / \
						1   4   7   12
					  / \          /
					-1   2        6
					/
					-3  
				-3 + () 
			*/

			// 1st level
			var tree = new NodeBinTree<int>(5);

			// 2nd level
			var left3 = new NodeBinTree<int>(3);
			var right8 = new NodeBinTree<int>(8);
			tree.Left = left3;
			tree.Right = right8;

			// 3rd level
			var left1 = new NodeBinTree<int>(1);
			var right4 = new NodeBinTree<int>(4);
			var left7 = new NodeBinTree<int>(7);
			var right12 = new NodeBinTree<int>(12);

			left3.Left = left1;
			left3.Right = right4;
			right8.Left = left7;
			right8.Right = right12;

			// 4th level
			var leftm1 = new NodeBinTree<int>(-1);
			left1.Left = leftm1;
			left1.Right = new NodeBinTree<int>(2);
			right12.Left = new NodeBinTree<int>(6);

			//5th level
			leftm1.Left = new NodeBinTree<int>(-3);

			//WHEN
			var result = Solution.CalculateVerticalSum(tree);

			// THEN
			Assert.True(result[-4] == -3);
			Assert.True(result[-3] == -1);
			Assert.True(result[-2] == 1);
			Assert.True(result[-1] == 5);
			Assert.True(result[0] == 16);
			Assert.True(result[1] == 14);
			Assert.True(result[2] == 12);
		}
	}
}