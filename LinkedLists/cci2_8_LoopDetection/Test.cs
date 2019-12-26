using Xunit;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.LinkedLists.LoopDetection
{
	public class Test
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestLoopDetection(int[] testArray, int collisionIndex)
		{
			//Given
			var testLinkedList = Node<int>.CreateLinkedList(testArray);

			Node<int> collisionNode = null;

			if(collisionIndex < 0)
			{
				collisionNode = testLinkedList;
				for (int i = 1; i < collisionIndex; i++)
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
			}

			// Bad brute force, messes original linked list, "Dark side is easy"
			// //When
			// var ret = Solution.DetectLoopBrute(testLinkedList);

			// //Then
			// Assert.True(collisionNode == ret);

			//When
			var retcollisionNode = Solution.DetectLoopRacingPointers(testLinkedList);

			//Then
			Assert.True(collisionNode == retcollisionNode);
		}

		public static IEnumerable<object[]> Data =>
			new List<object[]>
			{
				new object[] { new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 4},
				new object[] { new int[11] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, -1},
				new object[] { new int[1] { 1 }, 1},
				new object[] { new int[7] { 1, 2, 3, 4, 5, 6, 7 }, 7},
			};
	}
}