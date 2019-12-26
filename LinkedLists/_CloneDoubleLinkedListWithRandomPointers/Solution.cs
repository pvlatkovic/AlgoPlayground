// Clone double linked list with random pointers

using System;
namespace org.pv.AlgoPlayground.LinkedLists.CloneDoubleLinkedListWithRandomPointers
{
	public class Solution
	{
		public static NodeDouble<int> CloneDoubleLinkedList(NodeDouble<int> linkedList)
		{
			var current = linkedList;

			// insert cloned nodes after each orriginal node
			while (current != null)
			{
				var cloneCurrent = new NodeDouble<int>(current.Value);
				// connecting - cloneCurrent.Next to current.Next and current to cloneCurrent
				cloneCurrent.Next = current.Next;
				current.Next = cloneCurrent;

				current = cloneCurrent.Next;
			}

			// connecting .Previous clones
			current = linkedList;
			while (current != null)
			{
				if (current.Previous != null)
				{
					var cloneOfThePrevious = current.Previous.Next;
					var cloneOfTheCurrent = current.Next;
					if (cloneOfTheCurrent != null)
						cloneOfTheCurrent.Previous = cloneOfThePrevious;

					current = cloneOfTheCurrent.Next;
				}
				else
				{
					current = current.Next.Next;
				}
			}

			// razdvajanje u dve liste
			current = linkedList;
			var linkedListClone = current.Next;

			while (current != null)
			{
				var tempPointer = current.Next;
				if (current.Next != null)
					current.Next = current.Next.Next;

				current = tempPointer;
			}

			return linkedListClone;
		}
	}
}