namespace org.pv.AlgoPlayground.LinkedLists.ReverseLinkedList
{
	public class Solution
	{
		// O(n) time/space solution
		public static Node<int> ReverseLinkedList(Node<int> testLinkedList)
		{
			var currentNode = testLinkedList;
			var root  = testLinkedList;

			while (currentNode != null)
			{
				var nextNode = currentNode.Next;
				if (nextNode != null)
				{
					currentNode.Next = nextNode.Next;
					nextNode.Next = root; 
					root = nextNode;
				}
				else break;
			}
			
			return root; 
		}
	}

}