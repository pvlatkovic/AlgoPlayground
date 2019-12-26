using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.LoopDetection
{
	public class Test
	{
		[Fact]
		public void TestLoopDetection()
		{
			//Given
			var testList = new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
			var testLinkedList = Node<int>.CreateLinkedList(testList);
			
			Node<int> collisionNode = testLinkedList;
			for (int i = 1; i < 4; i++)
			{
				collisionNode = collisionNode.Next;
			}

			// create circular reference
			var node = testLinkedList;
			while (node != null)
			{
				if(node.Next == null)
				{
					node.Next = collisionNode;
					break;
				}
				node = node.Next;
			}

			// //When
			// var ret = Solution.DetectLoopBrute(testLinkedList);

			// //Then
			// Assert.True(collisionNode == ret);

			//When
			var retcollisionNode = Solution.DetectLoopRacingPointers(testLinkedList);

			//Then
			Assert.True(collisionNode == retcollisionNode);
		}
	}
}