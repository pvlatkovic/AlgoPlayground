// Cracking the coding interview - interview questions 2.2
//find Kth TO last element in a singly linked list

using System;

namespace org.pv.AlgoPlayground.LinkedLists.ReturnKthToLast
{
	public class Solution
	{
		public static int KToLast(int k, Node<int> linkedList)
		{
			if(k < 0)
				throw new ArgumentException("element index K cannot be less than 0");

			var currentNode = linkedList;
			var reversedLinkedList = new Node<int>(currentNode.Value);
						
			currentNode = currentNode.Next;
			while(currentNode != null)
			{
				var tempNode = new Node<int>(currentNode.Value);
				tempNode.Next = reversedLinkedList;

				reversedLinkedList = tempNode;
				currentNode = currentNode.Next;
			}

			for(int i = 0; i < k; i++)
			{
				if(reversedLinkedList == null)
					throw new IndexOutOfRangeException("K is larger then number of elements in linked list");
				reversedLinkedList = reversedLinkedList.Next;

			}

			return reversedLinkedList.Value;
		}
	}
}