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

		private static void Flatten(NodeBinTree<int> node, Node<int> parentNode)
		{
			if(node.Left != null)
			{
				parentNode.Next = new Node<int>() { Value = node.Left.Value};
				Flatten(node.Left, parentNode.Next);
			}
			if(node.Right != null)
			{
				parentNode.Next = new Node<int>() { Value = node.Right.Value};
				Flatten(node.Right, parentNode.Next);
			}
		}
	}
}