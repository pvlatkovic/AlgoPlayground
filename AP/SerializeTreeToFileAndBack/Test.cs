using System.Text;
using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.AP.SerializeTreeToFileAndBack
{
	public class Test
	{
		[Fact]
		public void TestSerializeBinaryTreeToFileNoRecursion()
		{
			//GIVEN tree
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
			var result = Solution.SerializeBinaryTreeToFileNoRecursion(tree);
			var resultExpected = "5,3,8,1,4,7,12,-1,2,e,e,e,e,e,e,-3";

			//THEN
			Assert.Equal(resultExpected, result); 
		}

		[Fact]
		public void TestSerializeBinaryTreeToFileWithRecursion()
		{
			//GIVEN tree
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
			var result = Solution.SerializeBinaryTreeToFileWithRecursion(tree);
			var resultExpected = "5,3,1,-1,-3,e,e,e,2,e,e,4,e,e,8,7,e,e,12,e,e,";	

			//THEN
			Assert.Equal(resultExpected, result);
		}

		[Fact]
		public void TestDeserializeFileToBinaryTreeWithRecursion()
		{
			//given 
			var serializedString = "5,3,1,-1,-3,e,e,e,2,e,e,4,e,e,8,7,e,e,12,e,e,";

			//when 
			var result = Solution.DeserializeFileToBinaryTreeWithRecursion(serializedString);
			var resultSerializedToString = Solution.SerializeBinaryTreeToFileWithRecursion(result);

			//then
			Assert.Equal(resultSerializedToString, serializedString);
		}
	}
}