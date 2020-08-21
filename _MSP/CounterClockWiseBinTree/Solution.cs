/*
print out the counter clockwise traversal of a binary tree
	
Input:
     1
   /  \
  2    3
 / \  / \
4   5 6  7 
Output: 1 4 5 6 7 3 2

Input:
       1			<- (1)
     /  \
    2    3			<- (3)
   /    / \
  4    5   6		-> (4)
 / \  /   / \
7   8 9  10  11		-> (2)
Output: 1 7 8 9 10 11 3 2 4 5 6

*/


using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;
using System;
using System.Diagnostics;

namespace org.pv.AlgoPlayground.MSP.CounterClockwiseBinTree
{
	public class Solution
	{
		public static List<int> Execute(NodeBinTree<int> binTree)
		{
			if (binTree == null)
				throw new ArgumentException();

			var ret = new List<int>();
			var h = GetHeight(binTree);

			var a = 0; var b = h - 1;
			while (a <= b)
			{
				AddLevel(binTree, a, true, ret);
				if (a != b)
					AddLevel(binTree, b, false, ret);
				a++; b--;
			}

			return ret;
		}

		private static void AddLevel(NodeBinTree<int> root, int level, bool isRevert, List<int> ret)
		{
			if (root == null)
				return;
			if (level == 0)
				ret.Add(root.Value);
			if (level > 0)
			{
				if (isRevert)
				{
					AddLevel(root.Right, level - 1, isRevert, ret);
					AddLevel(root.Left, level - 1, isRevert, ret);
				}
				else
				{
					AddLevel(root.Left, level - 1, isRevert, ret);
					AddLevel(root.Right, level - 1, isRevert, ret);
				}
			}
		}

		private static int GetHeight(NodeBinTree<int> root)
		{
			if (root != null)
			{
				return 1 + Math.Max(GetHeight(root.Left), GetHeight(root.Right));
			}
			return 0;
		}
	}
}


/*		
// read each raw for the start
var ret = new List<int>();

var q = new Queue<NodeBinTree<int>>();
q.Enqueue(binTree);

while(q.Count > 0)
{
	var node = q.Dequeue();
	ret.Add(node.Value);

	if(node.Left != null)
		q.Enqueue(node.Left);
	if(node.Right != null)
		q.Enqueue(node.Right);
}
*/