using Xunit;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.LinkedLists.ReverseLinkedListFromAToBIndex
{
	public class Test
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestReverseLinkedListFromAToBIndex(int[] testList, int indexA, int indexB, int[] testListExpected)
		{
			//Given
			var testLinkedList = Node<int>.CreateLinkedList(testList);

			//When
			var result = Solution.ReverseLinkedListFromAToBIndex(testLinkedList, indexA, indexB);

			//Then 
			var testLinkedListReversed = Node<int>.CreateLinkedList(testListExpected);

			var node = result;
			var nodeR = testLinkedListReversed;

			var isProperlyReversed = testLinkedList != null;
			while (node != null)
			{
				if (node.Value != nodeR.Value)
				{
					isProperlyReversed = false;
					break;
				}
				node = node.Next;
				nodeR = nodeR.Next;
			}

			Assert.True(isProperlyReversed);
		}

		public static IEnumerable<object[]> Data =>
		new List<object[]>
		{
			new object[] { new int[6] { 1, 2, 3, 4, 5, 6 }, 1, 3, new int[6] { 3, 2, 1, 4, 5, 6 } },
			new object[] { new int[6] { 1, 2, 3, 4, 5, 6 }, 2, 4, new int[6] { 1, 4, 3, 2, 5, 6 } },
			new object[] { new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4, 7, new int[8] { 1, 2, 3, 7, 6, 5, 4, 8 } },
			new object[] { new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 }, 5, 9, new int[8] { 1, 2, 3, 4, 8, 7, 6, 5 } },
			new object[] { new int[6] { 1, 2, 3, 4, 5, 6 }, 1, 6, new int[6] { 6, 5, 4, 3, 2, 1 } },
		};
	}
}