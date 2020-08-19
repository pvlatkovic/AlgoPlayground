/*
Binary tree to linked list

Input : 
          1
        /   \
       2     5
      / \     \
     3   4     6

Output :
    1 - 2 - 3 - 4 - 5 - 6

Input :
        1
       / \
      3   4
         /
        2
         \
          5
Output :
     1 - 3 - 4 - 2 - 5
*/

using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.MSP.BinaryTreeToLinkedList
{
	public class Test
	{
		[Fact]
		public void TestBinaryTreeToLinkedList()
		{
			// arrange, create test bin tree
			var tree = new NodeBinTree<int>() { Value = 1};
			tree.Left = new NodeBinTree<int>() { Value = 2};
			tree.Right = new NodeBinTree<int>() { Value = 5};

			tree.Left.Left = new NodeBinTree<int>() { Value = 3};
			tree.Left.Right = new NodeBinTree<int>() { Value = 4};

			tree.Right.Right = new NodeBinTree<int>() { Value = 6};

			// act

			var result = Solution.Execute(tree);

			// assert
			var resultExpected = new Node<int>(1) { Next = new Node<int>(2) { 
													Next = new Node<int>(3) { 
													Next = new Node<int>(4) { 
													Next = new Node<int>(5) { 
													Next = new Node<int>(6)} }}}};

			var next = result;
			var nextExpected = resultExpected;
			while (next != null)
			{
				Assert.Equal(nextExpected.Value, next.Value);
				next = next.Next;
				nextExpected = nextExpected.Next;
			}
		}
	}
}


