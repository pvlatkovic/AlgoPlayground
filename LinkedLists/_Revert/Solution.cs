namespace org.pv.AlgoPlayground.LinkedLists.Revert
{
	public class Solution
	{
		public static Node<int> Revert(Node<int> linkedList)
		{
			var root = linkedList;
			var node = linkedList;
			Node<int> first;
			while(node.Next != null)
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