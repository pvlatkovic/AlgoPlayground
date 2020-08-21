// binary tree ... 
//           1 
//         /   \      
//        2     3 
//      /   \    
//     4     5 
//      \   / \  
//       8 6   7 
//      /       \
//     9        10
// longest distance between two nodes is [9, 8, 4, 2, 5, 7, 10], difference between two end nodes is |9 - 10| = 1

using System;
using System.Diagnostics;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.MSP.DiffTwoLongestRelatedNodesInBinTree
{
	public class Solution
	{
		public static int Execute(NodeBinTree<int> tree)
		{
			// find max left height + max right height + 1
			var max = 0;
			var maxDiametarNode = tree;
			Diametar(tree, ref max, ref maxDiametarNode);

			var leftH = Height(maxDiametarNode.Left);
			var rightH = Height(maxDiametarNode.Right);

			int a = int.MinValue;
			int b = int.MinValue;

			GetNthElement(maxDiametarNode.Left, leftH - 1, ref a);
			GetNthElement(maxDiametarNode.Right, rightH - 1, ref b);

			return Math.Abs(a - b);
		}

		private static void GetNthElement(NodeBinTree<int> node, int level, ref int nth)
		{
			if (node == null)
				return;
			if (level == 0)
				nth = node.Value;
			else
			{
				GetNthElement(node.Left, level - 1, ref nth);
				GetNthElement(node.Right, level - 1, ref nth);
			}
		}

		private static void Diametar(NodeBinTree<int> node, ref int maxd, ref NodeBinTree<int> maxDiametarNode)
		{
			if (node == null)
				return;

			var d = 1 + Height(node.Left) + Height(node.Right);

			if (d > maxd)
			{
				maxd = d;
				maxDiametarNode = node;
			}

			Diametar(node.Left, ref maxd, ref maxDiametarNode);
			Diametar(node.Right, ref maxd, ref maxDiametarNode);
		}

		private static int Height(NodeBinTree<int> node)
		{
			if (node == null)
				return 0;

			var leftHeight = Height(node.Left);
			var rightHeigt = Height(node.Right);

			return 1 + Math.Max(leftHeight, rightHeigt);
		}


	}
}