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
			var nodes = new int[] { 0, 1, 2, 3, 4 };
			var dependencies = new Edge<int, int>[] { 
				new Edge<int, int>(0, 1, 0), 
				new Edge<int, int>(0, 2, 0), 
				new Edge<int, int>(1, 2, 0),
				new Edge<int, int>(1, 3, 0),
				new Edge<int, int>(2, 3, 0), 
				new Edge<int, int>(2, 2, 0) // 2, 2 is self loop
			}; 

			//WHEN
			var result = Solution<int, int>.DFS(nodes, dependencies, 0);

			//THEN
			Assert.Equal(4, result);


			//WHEN
			var result2 = Solution<int, int>.DFS(nodes, dependencies, 0);

			//THEN
			Assert.Equal(4, result2);
		}
	}
}


			/*
			//GIVEN
			// var nodes = new string[] { "a", "b", "c", "d", "e", "f" };
			// var dependencies = new string[,] { {"a", "d"}, {"f", "b"}, {"b", "d"}, {"f", "a"}, {"d", "c"}};

			//WHEN
			var result = Solution<string, int>.DFS(nodes, dependencies, "a");
			*/