// before implementing DeleteMiddleNode problem I tried this :)

using System;

namespace org.pv.AlgoPlayground.LinkedLists.DeleteNodeInTheMiddle
{
	public class Solution
	{
		public static Node<int> DeleteNodeInTheMiddle(Node<int> linkedList)
		{
			if (linkedList == null)
				throw new ArgumentException("Linked list cannot be null.");

			var currentNode = linkedList;
			var count = 0;
			while (currentNode != null)
			{
				
				count++;
				currentNode = currentNode.Next;
			}

			int middleIndex = count / 2;
			if(middleIndex == 0)
				return null;

			Node<int> previous = null;
			currentNode = linkedList;
			for(int i=0; i < middleIndex; i++)
			{
				previous = currentNode;
				currentNode = currentNode.Next;
			}
			previous.Next = currentNode.Next;

			return linkedList;
		}
	}
}