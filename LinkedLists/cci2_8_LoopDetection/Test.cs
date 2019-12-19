using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.LoopDetection
{
	public class Test
	{
		[Fact]
		public void TestLoopDetection()
		{
			//Given
			var testList = new int[6] { 1, 2, 3, 4, 5, 6 };
			var testLinkedList = Node<int>.CreateLinkedList(testList);
			
			Node<int> thirdNode = testLinkedList;
			for (int i = 1; i < 3; i++)
			{
				thirdNode = thirdNode.Next;
			}

			// create circular reference
			var node = testLinkedList;
			while (node != null)
			{
				if(node.Next == null)
				{
					node.Next = thirdNode;
					break;
				}
				node = node.Next;
			}

			//When
			var ret = Solution.DetectLoopBrute(testLinkedList);

			//Then
			Assert.True(thirdNode == ret);
		}
	}
}