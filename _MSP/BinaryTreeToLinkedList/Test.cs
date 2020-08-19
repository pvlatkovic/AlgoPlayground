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

using System;
using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.MSP.BinaryTreeToLinkedList
{
	public class Test
	{
		[Theory]
		[MemberData(nameof(Data))]
		public void TestBinaryTreeToLinkedList(NodeBinTree<int> tree, Node<int> resultExpected)
		{
			// arrange, create test bin tree

			// act

			var result = Solution.Execute(tree);

			// assert

			var next = result;
			var nextExpected = resultExpected;
			while (next != null)
			{
				Assert.Equal(nextExpected.Value, next.Value);
				next = next.Next;
				nextExpected = nextExpected.Next;
			}
		}


		public static IEnumerable<object[]> Data => new List<object[]>()
		{
			new object[] // test case 1 (see example above)
					{
						new NodeBinTree<int>()
						{
							Value = 1,
							Left = new NodeBinTree<int>()
								{ Value = 2,
									Left = new NodeBinTree<int>() { Value = 3 },
									Right = new NodeBinTree<int>() { Value = 4 } },
							Right = new NodeBinTree<int>()
								{ Value = 5,
									Right = new NodeBinTree<int>() { Value = 6 } }
						},

						new Node<int>(1)
						{
							Next = new Node<int>(2)
							{ Next = new Node<int>(3)
								{ Next = new Node<int>(4)
									{ Next = new Node<int>(5)
										{ Next = new Node<int>(6)}
									}
								}
							}
						}
					},
			new object[] // test case 2 (see example above)
					{
						new NodeBinTree<int>()
						{
							Value = 1,
							Left = new NodeBinTree<int>(3),
							Right = new NodeBinTree<int>(4)
							{
								Left = new NodeBinTree<int>(2)
								{
									Right = new NodeBinTree<int>(5)
								}
							}
						},

						new Node<int>(1)
						{ Next = new Node<int>(3)
							{ Next = new Node<int>(4)
								{ Next = new Node<int>(2)
									{ Next = new Node<int>(5) }
								}
							}
						}


					}
		};
	}
}

/* 
new object[]
					{
						new NodeBinTree<int>()
						{
							Value = 1,
							Left = new NodeBinTree<int>()
								{ Value = 2,
									Left = new NodeBinTree<int>() { Value = 3 },
									Right = new NodeBinTree<int>() { Value = 4 } },
							Right = new NodeBinTree<int>()
								{ Value = 5,
									Right = new NodeBinTree<int>() { Value = 6 } }
						},

						new Node<int>(1)
						{
							Next = new Node<int>(2)
							{ Next = new Node<int>(3)
								{ Next = new Node<int>(4)
									{ Next = new Node<int>(5)
										{ Next = new Node<int>(6) }
									}
								}
							}
						}
					}
*/