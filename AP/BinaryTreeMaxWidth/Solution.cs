// https://www.youtube.com/watch?v=il_t1WVLNxk
// problem 2.

using System;
using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.AP.BinaryTreeMaxWidth
{
	public class Solution
	{
		public static int FindMaxWidth(NodeBinTree<int> tree)
		{
			if(tree == null)
				return 0;

			var q = new Queue<NodeBinTree<int>>();
			
			q.Enqueue(tree);
			var max = 1;

			while(q.Count > 0)
			{
				var cnt = q.Count;
				max = Math.Max(max, cnt);
				
				for(int i = 0; i < cnt; i++)
				{
					var n = q.Dequeue();
					if (n.Left != null) q.Enqueue(n.Left); 
					if (n.Right != null) q.Enqueue(n.Right);
				}
			}

			return max;
		}
	}
}