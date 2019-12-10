using Xunit;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.LinkedLists.ReturnKthToLast
{
	public class Test
	{
		[Fact]
		public void TestReturnKthToLast()
		{
			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var KthToLast = Solution.KToLast(6, testLinkedList);

			//Then - 9 should be returned
			Assert.Equal(KthToLast, 9);
		}
	}
}