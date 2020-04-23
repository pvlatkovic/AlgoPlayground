// CCI 4.3
using Xunit;

using org.pv.TreesAndGraphs.Common;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.TreesAndGraphs.ListOfDepths
{
	public static class Test
	{
		[Fact]
		public static void TestCreateListOfDepths()
		{
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
			//GIVEN binary tree with 5 levels
			#region manual tree creation
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
			#endregion

			//WHEN
			var result = Solution<int>.CreateListOfDepths(tree);

			Assert.True(result.Count == 5);

			Assert.Equal(new List<int>() { 5 }, 			result[0].ToList());
			Assert.Equal(new List<int>() { 8, 3 }, 			result[1].ToList());
			Assert.Equal(new List<int>() { 12, 7, 4, 1 }, 	result[2].ToList());
			Assert.Equal(new List<int>() { 2, -1 }, 		result[3].ToList());
			Assert.Equal(new List<int>() { -3 }, 			result[4].ToList());
		} 
	}

}