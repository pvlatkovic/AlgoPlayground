using Xunit;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.LinkedLists.Palindrome
{
	public class Test
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestIsPalilndrom(char[] testList, bool expected)
		{
			//Given
			var testLinkedList = Node<char>.CreateLinkedList(testList);

			//When 
			var ret = Solution.IsPalindrom(testLinkedList);

			//Then
			Assert.Equal(expected, ret);
		}

		public static IEnumerable<object[]> Data =>
			new List<object[]>
			{
				new object[] { new char[3] { 'a', 'b', 'a' }, true},
				new object[] { new char[3] { 'a', 'b', 'c' }, false},
				new object[] { new char[7] { 'a', 'b', 'c', 'd', 'c', 'b', 'a' }, true},
			};
	}
}