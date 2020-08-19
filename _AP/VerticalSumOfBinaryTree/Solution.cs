// https://www.youtube.com/watch?v=il_t1WVLNxk
// problem 1.

using System;
using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.AP.VerticalSumOfBinaryTree
{
	public class Solution
	{
		public static Dictionary<int, int> CalculateVerticalSum(NodeBinTree<int> tree)
		{
			var verticalSums = new Dictionary<int, int>();
			Calc(tree, 0, verticalSums);

			return verticalSums;
		}

		private static void Calc(NodeBinTree<int> node, int hLevel, Dictionary<int, int> verticalSums) // hLeve stands for horizontal level
		{
			if( node == null)
				return;

			if(!verticalSums.ContainsKey(hLevel))
				verticalSums[hLevel] = node.Value;
			else
				verticalSums[hLevel] += node.Value;

			Calc(node.Left, hLevel - 1, verticalSums);
			Calc(node.Right, hLevel + 1, verticalSums);
		}
	}
}