// Cracking coding interview 2.7 
// check if linked lists intersect

namespace org.pv.AlgoPlayground.LinkedLists.Intersection
{
	public class Solution
	{
		public static Node<int> GetIntersectionNode(Node<int> linkedList1, Node<int> linkedList2)
		{
			var linkedList1Revert = ReverseLinkedList.Solution.ReverseLinkedList(linkedList1);
			var linkedList2Revert = ReverseLinkedList.Solution.ReverseLinkedList(linkedList2);

			var node1 = linkedList1Revert;
			var node2 = linkedList2Revert;
			Node<int> previous = null;

			while(node1 !=null)
			{
				if (node1 != node2)
					break;
				else
				{
					previous = node1;
					node1 = node1.Next;
					node2 = node2.Next;
				}
			}

			return previous;
		}
	}
}