// Cracking the coding interview - interview questions 2.1
// remove duplicates from unsorted linked list
using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.RemoveDuplicatesFromUnsortedLinkedList
{
	public class Test
	{

		[Fact]
		public void TestRemoveDuplicatesFromUnsortedLinkedListBruteForce()
		
		{
			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var removedDuplicates = Solution.RemoveDuplicatesBruteForce(testLinkedList);

			//Then - there should be 7 unique elements in removedDuplicates = {4, 6, 1, 9, 10, 5, 11}
			var isUniqueElements = true;
			var root = removedDuplicates;
			while (root != null)
			{	
				var current = root.Next;
				while (current != null)	
				{
					if(root.Value == current.Value)
					{
						isUniqueElements = false;			
						break;
					}
					current = current.Next;
				}
				if(!isUniqueElements)
					break;
				root = root.Next;
			}
			Assert.True(isUniqueElements);
		}
	}
    
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
	}
}