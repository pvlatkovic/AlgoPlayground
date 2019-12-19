// Cracking coding interview 2.6 /9
// check if linked list is palindrome

namespace org.pv.AlgoPlayground.LinkedLists.Palindrome
{
	public class Solution
	{
		// initial solution (O(n) but double space complexity for value types. Space is also added for reference types (nodes and references are doubled)
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

		public static bool IsPalindromIterative(Node<char> linkedList)
		{
			//TODO: add implementation
			return false;
		}

		// could add recursive but space and time complexity would not change anyway
	}
}
