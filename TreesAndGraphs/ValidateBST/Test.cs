// CCI 4.4

using Xunit;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.ValidateBST  // Binary Search tree :-)
{
	public class Test
	{
		[Fact]
		public void TestValidBST()
		{
			//GIVEN 
			/*
							  5
						   /     \
						  3       8
						 / \     / \
						1   4   7   12
					   / \        
					  -1  2     
					 /
					-3  
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
			// by adding this node we make tree unbalanced
			leftm1.Left = new NodeBinTree<int>(-3); 

			//WHEN 
			var result = Solution.IsValidBST(tree);
			
			//THEN 
			Assert.True(result);
		}
	}
}