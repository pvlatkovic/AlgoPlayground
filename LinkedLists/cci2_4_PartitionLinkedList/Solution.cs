// Cracking codding interview 2.4
// partition linkedList arround a value

using System;

namespace org.pv.AlgoPlayground.LinkedLists.PartitionLinkedList
{
	public class Solution
	{
		public static Node<int> PartitionLinkedList(Node<int> root, int partitionValue)
		{
			var node = root;
			while (node.Next != null)
			{
				if(node.Next.Value < partitionValue)
				{
					var tempRoot = node.Next;
					node.Next = node.Next.Next;
					tempRoot.Next  = root;
					root = tempRoot;
				}
				else
				{
					node = node.Next;
				}
			}

			return root;
		}
	}
}