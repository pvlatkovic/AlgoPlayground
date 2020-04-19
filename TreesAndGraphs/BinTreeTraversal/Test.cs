using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.TreesAndGraphs.BinaryTreeTraversal
{
	public static class Test
	{
		[Fact]
		public static void TestOrderTraversal()
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
						  3       8
						 / \     / \
						1   4   7   12
					   / \        
					  -1  2     
					 /
					-3  

					post order = { -3, -1, 2, 1, 4, 3, 7, 12, 8, 5 };
					pre order = { 5, 3, 1, -1, -3, 2, 4, 8, 7, 12}
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
			var resultInOrderTraversal = new List<int>();
			Solution<int>.InOrderTraversal(tree, (NodeBinTree<int> p) => resultInOrderTraversal.Add(p.Value));

			//THEN must return in order list
			var isInOrder = true;
			for(int i=0; i < resultInOrderTraversal.Count-1; i++)
			{
				if(resultInOrderTraversal[i] > resultInOrderTraversal[i+1])
				{
					isInOrder = false;
				}
			}

			Assert.True(isInOrder);

			//WHEN
			var resultPreOrderTraversal = new List<int>();
			Solution<int>.PreOrderTraversal(tree, (NodeBinTree<int> p) => resultPreOrderTraversal.Add(p.Value));

			//THEN must return preorder list
			var isPreOrder = true;
			var resultExpectedPreOrderTraversal = new List<int>() { 5, 3, 1, -1, -3, 2, 4, 8, 7, 12};
			for (int i = 0; i < resultPreOrderTraversal.Count; i++)
			{
				if(resultPreOrderTraversal[i] != resultExpectedPreOrderTraversal[i])
				{
					isPreOrder = false;
					break;
				}
			}

			Assert.True(isPreOrder);

			//WHEN
			var resultPostOrderTraversal = new List<int>();
			Solution<int>.PostOrderTraversal(tree, (NodeBinTree<int> p) => resultPostOrderTraversal.Add(p.Value));

			//THEN must return preorder list
			var isPostOrder = true;
			var resultExpectedPostOrderTraversal = new List<int>() { -3, -1, 2, 1, 4, 3, 7, 12, 8, 5 };
			for (int i = 0; i < resultPostOrderTraversal.Count; i++)
			{
				if (resultPostOrderTraversal[i] != resultExpectedPostOrderTraversal[i])
				{
					isPreOrder = false;
					break;
				}
			}

				Assert.True(isPostOrder);
		}
	}
}