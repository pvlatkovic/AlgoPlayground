// Cracking the coding interview - interview questions 2.2
//find Kth TO last element in a singly linked list

using System;

namespace org.pv.AlgoPlayground.LinkedLists.ReturnKthToLast
{
	public class Solution
	{
		public static void Main()
		{
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			KToLast(5, testLinkedList);
		}

		public static int KToLast(int k, Node<int> linkedList)
		{
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
			
			Console.WriteLine(reversedLinkedList);

			return -1;
		}
	}
}