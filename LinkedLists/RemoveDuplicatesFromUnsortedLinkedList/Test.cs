using Xunit;
using System.Collections.Generic;

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
					if (root.Value == current.Value)
					{
						isUniqueElements = false;
						break;
					}
					current = current.Next;
				}
				if (!isUniqueElements)
					break;
				root = root.Next;
			}
			Assert.True(isUniqueElements);
		}

		[Fact]
		public void TestRemoveDuplicatesFromUnsortedLinkedListTemporaryBuffer()
		{
			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var removedDuplicates = Solution.RemoveDuplicatesTemporaryBuffer(testLinkedList);

			//Then - there should be 7 unique elements in removedDuplicates = {4, 6, 1, 9, 10, 5, 11}
			var isUniqueElements = true;
			var root = removedDuplicates;
			while (root != null)
			{
				var current = root.Next;
				while (current != null)
				{
					if (root.Value == current.Value)
					{
						isUniqueElements = false;
						break;
					}
					current = current.Next;
				}
				if (!isUniqueElements)
					break;
				root = root.Next;
			}
			Assert.True(isUniqueElements);
		}
	}
}