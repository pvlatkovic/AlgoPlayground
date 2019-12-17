using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.ReverseLinkedList
{
	public class Test
	{
		[Fact]
		public void TestReverseLinkedList()
		{
			//Given
			var testList = new int[6] { 1, 2, 3, 4, 5, 6};
			var testLinkedList = Node<int>.CreateLinkedList(testList);

			//When
			var ret = Solution.ReverseLinkedList(testLinkedList);

			//Then
			var testListReversed = new int[6] { 6, 5, 4, 3, 2, 1}; // test reverted list
			var testLinkedListReversed = Node<int>.CreateLinkedList(testListReversed);

			var node = ret;
			var nodeR = testLinkedListReversed;

			var isProperlyReversed = ret != null;
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
	}
}