/*
Binary tree to linked list

Input : 
          1
        /   \
       2     5
      / \     \
     3   4     6

Output :
    1 - 2 - 3 - 4 - 5 - 6

Input :
        1
       / \
      3   4
         /
        2
         \
          5
Output :
     1 - 3 - 4 - 2 - 5
*/

using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.MSP.BinaryTreeToLinkedList
{
	public class Solution
	{
		public static Node<int> Execute(NodeBinTree<int> tree)
		{
			var start = new Node<int>() { Value = tree.Value };
			Flatten(tree, start);

			return start;
		}

		private static Node<int> Flatten(NodeBinTree<int> node, Node<int> parentNode)
		{
			var lastNode = parentNode;
			if (node.Left != null)
			{
				parentNode.Next = new Node<int>() { Value = node.Left.Value };
				lastNode = Flatten(node.Left, parentNode.Next);
			}
			if (node.Right != null)
			{
				lastNode.Next = new Node<int>() { Value = node.Right.Value };
				lastNode = Flatten(node.Right, lastNode.Next);
			}

			return lastNode;
		}
	}
}