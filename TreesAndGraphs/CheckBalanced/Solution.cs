// CCI 4.4

using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.CheckBalanced
{
	public class Solution
	{
		public static bool IsTreeBalanced(NodeBinTree<int> tree)
		{
			var height = CheckHeight(tree);

			if(height == int.MinValue)
				return false;

			return true;
		}

		private static int CheckHeight(NodeBinTree<int> tree)
		{
			if (tree == null)
				return -1;

			var leftHeight = CheckHeight(tree.Left);
			if(leftHeight == int.MinValue)
				return int.MinValue;
			var rightHeight = CheckHeight(tree.Right);
			if(rightHeight == int.MinValue)
				return int.MinValue;
			
			if(Math.Abs(leftHeight - rightHeight) > 1)
				return int.MinValue;
			else
				return Math.Max(leftHeight, rightHeight) + 1;
		}
	}
}