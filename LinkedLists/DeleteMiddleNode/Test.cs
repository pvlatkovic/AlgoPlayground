using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.DeleteMiddleNode
{
	public class Test
	{
		[Fact]
		public void TestDeleteMiddleNode()
		{
			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 7, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			Node<int> testNodeToRemove = testLinkedList;
			for(int i = 1; i < 6; i++) // node with value 9
			{
				testNodeToRemove = testNodeToRemove.Next;
			}

			//When
			Solution.DeleteMiddleNode(testNodeToRemove);

			//Then
			var isFoundMiddleNode = false;
			var node = testLinkedList;
			while(node != null)
			{
				if (node.Value == 9)
				{
					isFoundMiddleNode = true;
					break;
				}
				node = node.Next;
			}

			Assert.False(isFoundMiddleNode);
		}
	}
}