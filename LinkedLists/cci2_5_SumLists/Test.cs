using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.SumLists
{
	public class Test
	{
		[Fact]
		public void TestSumLists()
		{
			//Given 
			int[] testLinkedListValues1 = new int[3] { 7, 1, 6 };
			int[] testLinkedListValues2 = new int[3] { 5, 9, 2 };
			var testLinkedList1 = Node<int>.CreateLinkedList(testLinkedListValues1);
			var testLinkedList2 = Node<int>.CreateLinkedList(testLinkedListValues2);

			//When
			var ret = Solution.SumLists(testLinkedList1, testLinkedList2);

			//Then
			Assert.Equal(912, ret);
		}
	}
}