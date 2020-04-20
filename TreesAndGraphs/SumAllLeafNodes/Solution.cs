using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.SumAllLeafNodes
{
	public class Solution
	{
		public static int SumAllLeafNodes(NodeTree<int> tree)
		{
			var sum = 0;
			if(IsLeaf(tree))
				return sum + tree.Value;
			else
			{
				foreach(var node in tree.ChildNodes)
				{
					sum += SumAllLeafNodes(node);
				}
				return sum;
			}
		}

		private static bool IsLeaf(NodeTree<int> tree)
		{
			if(tree.ChildNodes != null && tree.ChildNodes.Count > 0)
				return false;
			return true;
		}
	}
}