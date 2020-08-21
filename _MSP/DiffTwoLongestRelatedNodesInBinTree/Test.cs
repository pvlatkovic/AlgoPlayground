// binary tree ... 
//           1 
//         /   \      
//        2     3 
//      /   \    
//     4     5 
//      \   / \  
//       8 6   7 
//      / 
//     9 

using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.MSP.DiffTwoLongestRelatedNodesInBinTree
{

	public class Test
	{
		[Fact]
		public void TestDiffTwoLongestRelatedNodesInBinTree()
		{
			// arrange
			var tree = new NodeBinTree<int>(1);

			tree.Left = new NodeBinTree<int>(2);
			tree.Right = new NodeBinTree<int>(3);

			tree.Left.Left = new NodeBinTree<int>(4);
			tree.Left.Right = new NodeBinTree<int>(5);

			tree.Left.Left.Right = new NodeBinTree<int>(8);
			tree.Left.Right.Left = new NodeBinTree<int>(6);
			tree.Left.Right.Right = new NodeBinTree<int>(7);
			tree.Left.Right.Right.Right = new NodeBinTree<int>(10);

			tree.Left.Left.Right.Left = new NodeBinTree<int>(9);

			// act
			var result = Solution.Execute(tree);

			// assert
			Assert.Equal(1, result);
		}
	}
}