// CCI 4.5

using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.ValidateBST  // Binary Search root :-)
{
	public class Solution
	{
		public static bool IsValidBST(NodeBinTree<int> tree)
		{
			//version 1
			//InOrder traverse of BST should return numbers in ascending sorted order 

			var prev = int.MinValue;
			Func<NodeBinTree<int>, bool> compare = (n) => 
			{
				if(prev > n.Value)
					return false;
				prev = n.Value;
				return true;
			};

			return IsValid(tree, compare);
		}

		private static bool IsValid(NodeBinTree<int> root, Func<NodeBinTree<int>, bool> compare)
		{
			if(root == null)
				return true;

			if(!IsValid(root.Left, compare))
				return false;
			
			if(!compare(root))
				return false;

			if(!IsValid(root.Right, compare))
				return false;
			
			return true;
		}
	}
}