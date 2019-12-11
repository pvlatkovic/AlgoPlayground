// Cracking the coding interview - interview questions 2.2
//find Kth TO last element in a singly linked list

using System;

namespace org.pv.AlgoPlayground.LinkedLists.ReturnKthToLast
{
	public class Solution
	{
		// O(n) solution, reverse list and read first k elements
		// space is duplicated for value types
		// new linked list hold references therefor space is added for reference types
		public static int KToLast(int k, Node<int> linkedList)
		{
			if(k < 0)
				throw new ArgumentException("element index K cannot be less than 0");

			if (linkedList == null)
				throw new ArgumentException("Linked list cannot be null.");

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

		// O(n) again,done just for fun :) O(n) space added due to recursive call stacks 
		public static int KToLastRecursive(int k, Node<int> linkedList)
		{
			if (k < 0)
				throw new ArgumentException("element index K cannot be less than 0");

			if(linkedList == null)
				throw new ArgumentException("Linked list cannot be null.");
				
			var ret = CheckNull(linkedList, k, 0);
			if (ret != null)
				return ret.Value;

			throw new IndexOutOfRangeException("K is larger then number of elements in linked list");
		}

		private static Node<int> CheckNull(Node<int> linkedList, int k, int currentPosition)
		{
			Node<int> ret = null;
			if(linkedList.Next != null)
				ret = CheckNull(linkedList.Next, k, currentPosition+1);

			if(ret != null)
				return ret;

			if(k == currentPosition)
				return linkedList;
			else 
				return null;
		}
	}
}