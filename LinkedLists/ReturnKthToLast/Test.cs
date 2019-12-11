using Xunit;
using System.Collections.Generic;
using System;

namespace org.pv.AlgoPlayground.LinkedLists.ReturnKthToLast
{
	public class Test
	{
		[Theory]
		[InlineData(5, 9)]
		[InlineData(0, 1)]
		[InlineData(10, 4)]
		public void TestReturnKthToLast(int k, int expected)
		{
			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var KthToLast = Solution.KToLast(k, testLinkedList);

			//Then 
			Assert.Equal(expected, KthToLast);
		}

		[Theory]
		[InlineData(5, 9)]
		[InlineData(0, 1)]
		[InlineData(10, 4)]
		public void TestReturnKthToLastRecursive(int k, int expected)
		{
			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var KthToLast = Solution.KToLastRecursive(k, testLinkedList);

			//Then 
			Assert.Equal(expected, KthToLast);
		}

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

		[Fact]
		public void TestReturnKthToLastRecursiveArgumentException()
		{

			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var isArgumentExceptionThrown = false;
			try
			{
				var KthToLast = Solution.KToLastRecursive(-1, testLinkedList);
			}
			// Then - ArgumentException should be thrown
			catch (ArgumentException)
			{
				isArgumentExceptionThrown = true;
			}

			Assert.True(isArgumentExceptionThrown);
		}

		[Fact]
		public void TestReturnKthToLastRecursiveIndexOutOfRangeException()
		{

			//Given 
			int[] testLinkedListValues = new int[11] { 4, 4, 6, 4, 1, 9, 1, 10, 5, 11, 1 };
			var testLinkedList = Node<int>.CreateLinkedList(testLinkedListValues);

			//When 
			var isIndexOutOfRangeException = false;
			try
			{
				var KthToLast = Solution.KToLastRecursive(200, testLinkedList);
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