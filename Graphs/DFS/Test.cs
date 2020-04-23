using Xunit;

namespace org.pv.AlgoPlayground.Graphs.DFS  
{
	// Demo/Test of Depth First Search for a graph
	// nodes = { a, b, c, d, e, f }
	// dependencies = { {a, d}, {f, b}, {b, d}, {f, a}, {d, c}}

	public class Test
	{
		[Fact]
		public void TestDFS()
		{
			//GIVEN
			var nodes = new string[] { "a", "b", "c", "d", "e", "f" };
			var dependencies = new string[,] { {"a", "d"}, {"f", "b"}, {"b", "d"}, {"f", "a"}, {"d", "c"}};

			//WHEN
			var result = Solution<string, int>.DFS(nodes, dependencies, "a");

			//THEN
			Assert.Equal(4, result);
		}
	}
}