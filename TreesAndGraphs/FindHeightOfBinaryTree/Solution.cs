using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.FindHeightBinaryTree
{
	public class Solution<T>
	{
		public static int FindHeightBinaryTree(NodeBinTree<T> tree)
		{
			if(tree == null) throw new ArgumentNullException("tree root cannot be null");

			var leftHeight = GetHeight(tree.Left); 
			var rightHeight = GetHeight(tree.Right);

			if(leftHeight > rightHeight) 
				return 1 + leftHeight;
			else
				return 1 + 	rightHeight;
		}

		private static int GetHeight(NodeBinTree<T> node)
		{
			if(node == null) return 0;

			var leftHeight = GetHeight(node.Left);
			var rightHeight = GetHeight(node.Right);

			if (leftHeight > rightHeight)
				return 1 + leftHeight;
			else
				return 1 + rightHeight;

		}
	}
}