using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.Common.TestTreesAndGraphs
{
	public class TestMinMaxHeap
	{
		[Fact]
		public void TestMinHeap()
		{
			//Given
			var testData = new int[] {4, 5, 3, 2, 5, 10, 11, 1};

			//When we construct and fill the MinHeap
			var testMinHeap = new MinHeap<int>();
			for(int i = 0; i < testData.Length; i++)
				testMinHeap.Add(testData[i]);

			//Then check peek and pop will always return smallest  

			Assert.Equal(1, testMinHeap.Peek());
			Assert.Equal(1, testMinHeap.Poll());

			Assert.Equal(2, testMinHeap.Peek());
			Assert.Equal(2, testMinHeap.Poll());

			Assert.Equal(3, testMinHeap.Peek());
			Assert.Equal(3, testMinHeap.Poll());
		}
	}
}