using System;
using System.Diagnostics;
using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.TreesAndGraphs.FindHeightBinaryTree
{
	public static class Test
	{
		[Fact]
		public static void TestFindHeightBinaryTree()
		{
			//GIVEN

			// lets construct binary search tree - BST is used just to try, actually task is to find height of any binary tree
			/*
				definition of BST (binary search tree)
				- The left subtree of a node contains only nodes with keys lesser than the node’s key.
				- The right subtree of a node contains only nodes with keys greater than the node’s key.
				- The left and right subtree each must also be a binary search tree.
			
							  5
						   /     \
						  4       8
						 / \     / \
						1   3   7   12
					   / \        
					  -1  2       
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

			//5th level
			leftm1.Left = new NodeBinTree<int>(-3);

			//WHEN
			var result = Solution<int>.FindHeightBinaryTree(tree);

			//THEN
			var resultExpected = 5;
			Assert.Equal(resultExpected, result);
		}
	}
}