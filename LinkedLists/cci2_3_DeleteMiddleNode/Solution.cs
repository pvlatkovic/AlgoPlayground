// Cracking the coding interview - interview questions 2.3
// Delete node in the middle (any node but first and last, not exactly middle)

using System;

namespace org.pv.AlgoPlayground.LinkedLists.DeleteMiddleNode
{
	public class Solution
	{
		public static void DeleteMiddleNode(Node<int> node)
		{
			if(node == null || node.Next == null)
				throw new ArgumentException("Nodel cannot be null or node.Next cannot be null");

			node.Value = node.Next.Value;
			if(node.Next.Next == null)
				node.Next = null;
			else
				node.Next = node.Next.Next;
		}
	}
}