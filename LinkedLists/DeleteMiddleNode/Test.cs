using Xunit;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.LinkedLists.DeleteMiddleNode
{
	public class Test 
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestDeleteMiddleNode(int[] testLinkedListValues, Node<int> expected)
		{
			//Given 
			//int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 7, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var ret = Solution.DeleteMiddleNode(testLinkedList);

			//Then
			Node<int> node = ret;

			
			for(int i=0; i < testLinkedListValues.Length / 2; i++)
			{
				node = node.Next;
			}

			Assert.True(expected == node || expected.Value == node.Value);

		}

		public static IEnumerable<object[]> Data =>
		new List<object[]>
		{
			new object[] { new int[11] { 4, 4, 6, 4, 7, 9, 1, 10, 5, 11, 1 }, new Node<int>(1) },
			new object[] { new int[1] { 4 }, null },
			new object[] { new int[2] { 4, 2 }, new Node<int>(4) },
			new object[] { new int[3] { 1, 2, 3 }, new Node<int>(3) },
		};
	}
}