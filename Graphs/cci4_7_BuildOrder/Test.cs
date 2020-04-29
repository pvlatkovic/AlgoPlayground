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
		public void TestBuildOrder() // generic based solution
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
		public void TestIntBuildOrder() // integer based solution
		{
			//GIVEN
			var projects = new int[] { 0, 1, 2, 3, 4, 5 };
			var dependencies = new int[,] { { 0, 3 }, { 5, 1 }, { 1, 3 }, { 5, 0 }, { 3, 2 } }; // indexes of projects
			var resultExpected = new int[] { 5, 4, 1, 0, 3, 2 };

			//WHEN
			var result = SolutionInt.GetBuildOrder(projects, dependencies);

			//THEN
			Assert.True(result.SequenceEqual(resultExpected));
		}

		[Fact]
		public void TestStackBuildOrder() // integer based solution
		{
			//GIVEN
			var projects = new int[] { 0, 1, 2, 3, 4, 5 };
			var dependencies = new int[,] { { 0, 3 }, { 5, 1 }, { 1, 3 }, { 5, 0 }, { 3, 2 } }; // indexes of projects
			var resultExpected = new int[] { 5, 4, 1, 0, 3, 2 };

			//WHEN
			var result = SolutionStack.GetBuildOrder(projects, dependencies);

			//THEN
			Assert.True(result.SequenceEqual(resultExpected));
		}
	}
}