namespace org.pv.AlgoPlayground.LinkedLists.ReverseLinkedList
{
	public class Solution
	{
		// O(n) time/space solution
		public static Node<int> ReverseLinkedList(Node<int> linkedList)
		{
			var root = linkedList;
			var node = linkedList;
			Node<int> first;
			while (node.Next != null)
			{
				first = node.Next;
				node.Next = node.Next.Next;
				first.Next = root;
				root = first;
			}

			return root;
		}
	}

}