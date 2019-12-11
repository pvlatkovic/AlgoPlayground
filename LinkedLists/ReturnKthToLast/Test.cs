using Xunit;
using System.Collections.Generic;
using System;

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
			var KthToLast = Solution.KToLast(5, testLinkedList);

			//Then - 9 should be returned
			Assert.Equal(KthToLast, 9);
		}

		private static ArgumentException argumentException = new ArgumentException();

		[Fact]
		public void TestReturnKthToLastArgumentException()
		{

			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var isArgumentExceptionThrown = false;
			try
			{
				var KthToLast = Solution.KToLast(-1, testLinkedList);
			}
			// Then - ArgumentException should be thrown
			catch (ArgumentException)
			{
				isArgumentExceptionThrown = true;
			}

			Assert.True(isArgumentExceptionThrown);
		}

		[Fact]
		public void TestReturnKthToLastIndexOutOfRangeException()
		{

			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var isIndexOutOfRangeException = false;
			try
			{
				var KthToLast = Solution.KToLast(200, testLinkedList);
			}
			// Then - ArgumentException should be thrown
			catch (IndexOutOfRangeException)
			{
				isIndexOutOfRangeException = true;
			}

			Assert.True(isIndexOutOfRangeException);
		}
	}
}