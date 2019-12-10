// Cracking the coding interview - interview questions 2.1
// remove duplicates from unsorted linked list
using Xunit;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.LinkedLists.RemoveDuplicatesFromUnsortedLinkedList
{
    public class Solution
    {
		// O(n^2), 
		// number of loops, n + (n-1) + (n-2) + ... + 1 = n(n+1)/2 => (n^2)/2 + n/2 => disregard non-significant part n/2 and remove constant 2 => O(n^2)
        public static Node<int> RemoveDuplicatesBruteForce(Node<int> linkedList)
        {
            // without using temporary buffer
            var root = linkedList;
            while (root != null)
            {
                var previous = root;
                var current = root.Next;
                while (current != null)
                {
                    if (root.Value == current.Value)
                    {
                        previous.Next = current.Next;
                        current = current.Next;
                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                    }
                }
                root = root.Next;
            }

            return linkedList;
		}

		// O(n),
		public static Node<int> RemoveDuplicatesTemporaryBuffer(Node<int> linkedList)
		{
			var mapCount = new Dictionary<int, int>();
			var node = linkedList;

			// create map of element count 
			while (node != null)
			{
				if (mapCount.ContainsKey(node.Value))
					mapCount[node.Value] += 1;
				else
					mapCount[node.Value] = 1;
				node = node.Next;
			}

			node = linkedList;
			Node<int> previous = null;
			while (node != null)
			{
				if (mapCount[node.Value] > 1)
				{
					if (previous != null)
					{
						previous.Next = node.Next;
						mapCount[node.Value] -= 1;
					}
					else
						previous = node;
				}
				else
					previous = node;

				node = node.Next;
			}

			return linkedList;
		}
	}
}