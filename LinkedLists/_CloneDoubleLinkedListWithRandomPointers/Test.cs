using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.CloneDoubleLinkedListWithRandomPointers 
{
	public class Test
	{
		[Fact]
		public static void TestCloneDoubleLinkedList()
		{
			//Given
			int[] testArray = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			var linkedList = NodeDouble<int>.CreateDoubleLinkedList(testArray);

			// now lets mess the list a bit, with some random pointers 
			NodeDouble<int>[] testNodes = new NodeDouble<int>[8];
			//put all nodes in to an array so we can access by index
			var nd = linkedList;
			for (int i = 0; i < testArray.Length; i++)
			{
				testNodes[i] = nd;
				nd = nd.Next;
			}

			// reconnect .Previous nodes
			for (int i = 0; i < testNodes.Length; i++)
			{
				if (i == 0)
					testNodes[0].Previous = testNodes[7];
				if (i == 1)
					testNodes[1].Previous = testNodes[0];
				if (i == 2)
					testNodes[2].Previous = testNodes[0];
				if (i == 3)
					testNodes[3].Previous = testNodes[1]; // e.g. connect 3 to 1
				if (i == 4)
					testNodes[4].Previous = testNodes[2];
				if (i == 5)
					testNodes[5].Previous = testNodes[4];
				if (i == 6)
					testNodes[6].Previous = testNodes[6]; // or connect 6 to it self :p
			}

			//When
			var clonedLinkedList = Solution.CloneDoubleLinkedList(linkedList);

			//Then
			var isAllCloned = true;
			var node = linkedList;
			var clonedNode = clonedLinkedList;

			while(node != null)
			{
				// if any of these conditions are true we do not have clone
				if(node.Value != clonedNode.Value 
						|| node == clonedNode 
						|| (node.Previous != null ? node.Previous == clonedNode.Previous : false))
					{
						isAllCloned = false;
						break;
					}

				node = node.Next;
				clonedNode = clonedNode.Next;
			}

			Assert.True(isAllCloned);
		}
	}
}