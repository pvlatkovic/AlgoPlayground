// CCI 4.7 Given a list of packages that need to be built and the dependencies 
// for each package, determine a valid order in which to build the packages

// Example
// projects = { a, b, c, d, e, f }
// dependencies = { {a, d}, {f, b}, {b, d}, {f, a}, {d, c}}
// output = { f, e, a, b, d, c}

using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace org.pv.AlgoPlayground.Graphs.BuildOrder
{

	public class Test
	{
		[Fact]
		public void TestBuildOrder()
		{
			//GIVEN
			var projects = new string[] { "a", "b", "c", "d", "e", "f" };
			var dependencies = new string[,] { {"a", "d"}, {"f", "b"}, {"b", "d"}, {"f", "a"}, {"d", "c"} };
			var resultExpected = new string[] {"f", "e", "b", "a", "d", "c" };

			//WHEN
			var result = Solution.GetBuildOrder(projects, dependencies);

			//THEN
			Assert.True(result.SequenceEqual(resultExpected));
		}

		[Fact]
		public void TestBuildOrder2()
		{
			//GIVEN
			var projects = new int[] { 1, 2, 3, 4, 5, 6 };
			//						   a  b  c  d  e  f
			var dependencies = new int[,] { { 1, 4 }, { 6, 2 }, { 2, 4 }, { 6, 1 }, { 4, 3 } };
			var resultExpected = new int[] { 6, 5, 2, 1, 4, 3 };

			//WHEN
			//var result = Solution2.GetBuildOrder(projects, dependencies);

			//THEN
			//Assert.True(result.SequenceEqual(resultExpected));
		}
	}
}