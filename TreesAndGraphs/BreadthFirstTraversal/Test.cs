using System;
using System.Collections.Generic;
using org.pv.Common;
using org.pv.TreesAndGraphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.TreesAndGraphs.BreadthFirstTraversal
{
	public static class Test
	{
		[Fact]
		public static void TestBreadthFirstTraversal()
		{
			//GIVEN

			#region create tree
			// 1st level
			var tree = new NodeBinTree<int>(5);

			// 2nd level
			var left3 = new NodeBinTree<int>(3);
			var right8 = new NodeBinTree<int>(8);
			tree.Left = left3;
			tree.Right = right8;

			// 3rd level
			var left1 = new NodeBinTree<int>(1);
			var right4 = new NodeBinTree<int>(4);
			var left7 = new NodeBinTree<int>(7);
			var right12 = new NodeBinTree<int>(12);

			left3.Left = left1;
			left3.Right = right4;
			right8.Left = left7;
			right8.Right = right12;

			// 4th level
			var leftm1 = new NodeBinTree<int>(-1);
			left1.Left = leftm1;
			left1.Right = new NodeBinTree<int>(2);

			//5th level
			leftm1.Left = new NodeBinTree<int>(-3);
			#endregion

			//WHEN
			var result = new List<int>();
			var doSomething = new Action<int> ((p) => result.Add(p));

			Solution<int>.BreadthFirstTraverse(tree, doSomething);

			//THEN
			var resultExpected = new List<int>() {5, 3, 8, 1, 4, 7, 12, -1, 2, -3};
			var isEqual = true;
			for(int i=0; i < resultExpected.Count; i++)
			{
				if(resultExpected[i] != result[i])
				{
					isEqual = false;
					break;
				}
			}

			Assert.True(isEqual);
		}
	}
}