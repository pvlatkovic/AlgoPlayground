using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.Intersection
{
	public class Test
	{
		public void TestIntersection()
		{
			//Given two lists which intersect (share one node)
			// a: 1->2->3->4->5->6->null
			// b: 7->8->^
			var testList = new int[6] { 1, 2, 3, 4, 5, 6};
			var testLinkedList = Node<int>.CreateLinkedList(testList);

			// get 3rd node
			Node<int> thirdNode = testLinkedList; 
			for(int i = 1; i < 3; i++)
			{
				thirdNode = thirdNode.Next;
			}
			var testList2 = new int[2] { 7, 8 };
			var testLinkedList2 = Node<int>.CreateLinkedList(testList2);
			var node = testLinkedList2;
			while (node != null)
			{
				node = node.Next;
			}
			node.Next = thirdNode;

			//When 
			var interrsectionNode = Solution.GetIntersectionNode(testLinkedList, testLinkedList2);

			//Then

		}
	}
}