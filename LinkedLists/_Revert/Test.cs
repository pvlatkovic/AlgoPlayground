using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.Revert
{
	public class test
	{
		[Fact]
		public void TestRevertLinkedList()
		{
			//given 
			int[] testLinkedListValues = new int[6] { 1, 2, 3, 4, 5, 6 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//when 
			var ret = Solution.Revert(testLinkedList);

			//then

			int[] testLinkedListValuesRevert = new int[6] { 6, 5, 4, 3, 2, 1 };
			var testLinkedListRevert = Node<int>.CreateLinkedList(testLinkedListValuesRevert);

			var node = ret;
			var nodeR = testLinkedListRevert;
			var isRevertedProperly = node != null;
			while(node != null)
			{
				if(node.Value != nodeR.Value)
				{
					isRevertedProperly = false;
					break;
				}

				node = node.Next;
			}

			Assert.True(isRevertedProperly);
		}
	}
}