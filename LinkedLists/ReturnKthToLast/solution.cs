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
			if (ret.Item1 != null)
				return ret.Item1.Value;

			throw new IndexOutOfRangeException("K is larger then number of elements in linked list");
		}

		private static (Node<int>, int) CheckNull(Node<int> linkedList, int k, int currentPosition) // tuple fun :)
		{
			(Node<int>, int) ret = (null, 0);
			if(linkedList.Next != null)
				ret = CheckNull(linkedList.Next, k, currentPosition+1);

			var countBack = ret.Item2;
			if(ret.Item1 != null)
				return (ret.Item1, k);

			if(k == countBack)
				return (linkedList, k);
			else 
				return (null, countBack+1);
		}
	}
}