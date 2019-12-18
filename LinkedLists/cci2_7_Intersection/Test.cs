using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.Intersection
{
	public class Test
	{
		[Fact]
		public void TestIntersection()
		{
			//Given two lists which intersect (share one node)
			// a: 1->2->3->4->5->6->null
			// b: 7->8->^
			var testList = new int[6] { 1, 2, 3, 4, 5, 6};
			var testLinkedList1 = Node<int>.CreateLinkedList(testList);

			// get 3rd node
			Node<int> thirdNode = testLinkedList1; 
			for(int i = 1; i < 3; i++)
			{
				thirdNode = thirdNode.Next;
			}
			var testList2 = new int[3] { 9, 8, 7 };
			var testLinkedList2 = Node<int>.CreateLinkedList(testList2);
			var node = testLinkedList2;
			Node<int> previous = null;
			while (node != null)
			{
				previous = node;
				node = node.Next;
			}
			previous.Next = thirdNode;

			//When 
			var interrsectionNode = Solution.GetIntersectionNodeBrute(testLinkedList1, testLinkedList2);

			//Then
			Assert.True(interrsectionNode != null);

		}
	}
}