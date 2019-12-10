//find Kth to last element in a singly linked list

namespace org.pv.AlgoPlayground.LinkedLists.ReturnKthToLast
{
	public class Solution
	{
		public static Node<int> KToLast(int k, Node<int> linkedList)
		{
			var node = linkedList;
			var index = 1;
			while (node != null)
			{
				if (k == index++)
					return node;
				node = node.Next;
			}
			return null;
		}
	}
}