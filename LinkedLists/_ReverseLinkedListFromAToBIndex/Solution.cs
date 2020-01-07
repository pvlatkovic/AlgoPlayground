/*
Write a function

void reverseNodes(Node** head, int indexA, int indexB)

which should reverse order of nodes in list, starting from node on position indexA until node on position indexB.
Head node is on position 1.

Examples:

Input a -> c -> x -> q -> e -> 2		
indexA = 2, indexB = 4		
Output a -> q -> x -> c -> e -> 2

Input a -> c -> x -> q -> e -> 2		
indexA = 1, indexB = 3		
Output x -> c -> a -> c -> e -> 2

*/


namespace org.pv.AlgoPlayground.LinkedLists.ReverseLinkedListFromAToBIndex
{
	public class Solution
	{
		public static Node<int> ReverseLinkedListFromAToBIndex(Node<int> linkedList, int a, int b)
		{
			var node = linkedList;
			Node<int> root = null; // root node to start reversion from
			var i = 1; // current possition

			while(node != null)
			{
				if(i != a)
				{
					i++;
					root = node;
					node = node.Next;
				}
				else // start reverse							
				{
					var next = node.Next;
					while (next != null && i < b)
					{
						node.Next = next.Next;
						if(root == null) // case when we start reverse from the beginning of the linked list
						{
							next.Next = linkedList;
							linkedList = next;
						}
						else // standard case, reverse happens in the middle of the list
						{
							next.Next = root.Next;
							root.Next = next;
						}

						next = node.Next;
						i++;

					}
					return linkedList;
				}
			}
			return linkedList;
		}
	}
}