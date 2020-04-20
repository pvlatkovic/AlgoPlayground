using System;
using org.pv.Common;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.BreadthFirstTraversal
{
	public static class Solution<T>
	{
		public static void BreadthFirstTraverse(NodeBinTree<T> tree, Action<T> doSomething)
		{
			var Q = new Queue<NodeBinTree<T>>();

			Q.Add(tree);

			while(Q.Count > 0)
			{
				var current = Q.Remove();

				if(current == null)
					continue;

				Q.Add(current.Left); 
				Q.Add(current.Right);

				if(doSomething != null)
					doSomething(current.Value);
			}
		}
	}
}