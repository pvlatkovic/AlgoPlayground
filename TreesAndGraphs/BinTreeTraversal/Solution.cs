using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.BinaryTreeTraversal
{
	public static class Solution<T>
	{
		public static void InOrderTraversal(NodeBinTree<T> node, Action<NodeBinTree<T>> visit = null)
		{
			if(node != null)
			{
				InOrderTraversal(node.Left, visit);
				if(visit != null)
					visit(node);
					
				InOrderTraversal(node.Right, visit);	
			}
		}

		public static void PreOrderTraversal(NodeBinTree<T> node, Action<NodeBinTree<T>> visit = null)
		{
			if (node != null)
			{
				if (visit != null)
					visit(node);

				PreOrderTraversal(node.Left, visit);
				PreOrderTraversal(node.Right, visit);
			}
		}

		public static void PostOrderTraversal(NodeBinTree<T> node, Action<NodeBinTree<T>> visit = null)
		{
			if (node != null)
			{
				PostOrderTraversal(node.Left, visit);
				PostOrderTraversal(node.Right, visit);

				if (visit != null)
					visit(node);
			}
		}
	} 
}
