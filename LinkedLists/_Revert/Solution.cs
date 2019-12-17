namespace org.pv.AlgoPlayground.LinkedLists.Revert
{
	public class Solution
	{
		public static Node<int> Revert(Node<int> linkedList)
		{
			/*
				take first element, node
				get its next node
				set root points to next node
				set node.Next to point node.Next.Next
				1, 2, 3, 4 ->
					root = 2
					next = 

			*/
			var root = linkedList;
			var node = linkedList;
			while(node.Next != null)
			{
				root = node.Next;
				node.Next = node.Next.Next;
				root.Next = node;
			}

			return root;
		}
	}
}