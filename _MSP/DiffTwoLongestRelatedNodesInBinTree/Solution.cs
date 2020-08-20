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
// longest distance between two nodes is [9, 8, 4, 2, 5, 7], difference between two end nodes is 9 - 7 = 2

using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.MSP.DiffTwoLongestRelatedNodesInBinTree
{
	public class Solution 
	{
		public static int Execute(NodeBinTree<int> tree)
		{
			// find max left height + max right height + 1
			var max = int.MinValue;
			var maxH = MaxHeight(tree, ref max);

			return max;
		}

		private static int MaxHeight(NodeBinTree<int> root, ref int max)
		{
			if(root == null)
				return 0;

			var maxL = MaxHeight(root.Left, ref max);
			var maxR = MaxHeight(root.Right, ref max);

			var maxC = 1 + maxL + maxR; 

			max = Math.Max(maxC, max);

			return maxC;
		}
	}
}