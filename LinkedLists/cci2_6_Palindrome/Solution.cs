// Cracking coding interview 2.6 /9
// check if linked list is palindrome

namespace org.pv.AlgoPlayground.LinkedLists.Palindrome
{
	public class Solution
	{
		// initial solution
		public static bool IsPalindrom(Node<char> linkedList)
		{
			// reverse list into new list
			var node 			= linkedList;
			Node<char> termNode = null;

			while (node != null)
			{
				var newNode = new Node<char>(node.Value);
				newNode.Next = termNode;
				termNode = newNode;
				node = node.Next;
			}

			// termNode contains reversed linkedList
			node = linkedList;
			var isPalindrome = true;
			while(node != null)
			{
				if(node.Value != termNode.Value)
				{
					isPalindrome = false;
					break;
				}

				node = node.Next;
				termNode = termNode.Next;
			}


			return isPalindrome;
		}
	}
}
