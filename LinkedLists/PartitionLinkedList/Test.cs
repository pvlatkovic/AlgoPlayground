using Xunit;

namespace org.pv.AlgoPlayground.LinkedLists.PartitionLinkedList
{
	public class Test
	{
		[Fact]
		public void TestPartitionLinkedList()
		{
			//Given 
			int[] testLinkedListValues = new int[7] { 3, 5, 8, 5, 10, 2, 1};
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When
			var partitionValue = 5;
			var ret = Solution.PartitionLinkedList(testLinkedList, partitionValue);

			//Then
			var node = ret;
			var isTurn = false;
			var isValid = true; 
			while(node != null)
			{
				if(node.Value >= partitionValue)
				{
					isTurn = true;
				}
				else if (isTurn)
				{
					isValid = false;
					break;
				}
				node = node.Next;
			}
			Assert.True(isValid);
		}
	}
}