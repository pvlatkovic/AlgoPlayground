// Given a list of points on the 2-D plane and an integer K. 
// The task is to find K closest points to the origin and print them.

using System;
using System.Diagnostics.CodeAnalysis;
using org.pv.TreesAndGraphs.Common;
using Xunit;
using System.Linq;

namespace org.pv.AlgoPlayground.TreesAndGraphs.KClosestPointsToTheOrigin
{
	
	public class Test
	{
		[Fact]
		public void FindKClosestPoints()
		{
			//GIVEN
			var points = new double[,] {{1, 2}, {2, 2}, {-3, 3}, {-0.5, 0.5} };
			var resultExpected = new double[,] {{-0.5, 0.5}, {1, 2}};

			//WHEN
			var result = Solution.FindKClosestPoints(points, 2);

			//THEN
			for(int i = 0; i < result.GetUpperBound(0)+1; i++)
				Assert.True(result[i, 0] == resultExpected[i,0] && result[i, 1] == resultExpected[i,1]);
		}
	}
}