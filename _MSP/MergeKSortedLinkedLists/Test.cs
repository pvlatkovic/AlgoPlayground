using System.Collections.Generic;
using Xunit;

namespace org.pv.AlgoPlayground.MSP.MergeKSortedLinkedLists
{
	public class Test
	{
		[Fact]
		public void TestMergeKSortedLinkedLists()
		{
			//given 
			var ll1 = new Node<int>(1) { Next = new Node<int>(3) { Next = new Node<int>(5) { Next = new Node<int>(7) }}};
			var ll2 = new Node<int>(2) { Next = new Node<int>(4) { Next = new Node<int>(6) { Next = new Node<int>(8) }}};
			var ll3 = new Node<int>(-1) { Next = new Node<int>(0) { Next = new Node<int>(9) { Next = new Node<int>(10) { Next = new Node<int>(11)}}}};
			
			//when 
			var result = Solution.ExecuteMinHeap(new Node<int>[] {ll1, ll2, ll3});

			//then 
			var resultExpected = new Node<int>(0) { Next = 
														new Node<int>(1) { 
															Next = new Node<int>(2) { 
																Next = new Node<int>(3) { 
																	Next = new Node<int>(4) {
																		Next = new Node<int>(5) {
																			Next = new Node<int>(6) {
																				Next = new Node<int>(7) {
																					Next = new Node<int>(8) { 
																						Next = new Node<int>(9) {
																							Next = new Node<int>(10) {
																								Next = new Node<int>(11)}}}}}}}}}}};

			var next = result;																								
			var nextExpected = resultExpected;

			while(next != null)
			{
				Assert.Equal(nextExpected.Value, next.Value);
				next = next.Next;
				nextExpected = nextExpected.Next;
			}
		}
	}
}