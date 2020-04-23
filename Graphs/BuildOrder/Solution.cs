// CCI 4.7

// Example
// projects = { a, b, c, d, e, f }
// dependencies = { {a, d}, {f, b}, {b, d}, {f, a}, {d, c}}
// output = { f, e, a, b, d, c}

using System;
using System.Collections.Generic;


namespace org.pv.AlgoPlayground.Graphs.BuildOrder  
{
	public class Solution
	{
		public static List<string> GetBuildOrder(string[] projects, string[,] dependencies)
		{
			var graph = new Common.Graph<string, int>();
			for(int i = 0; i < dependencies.Length; i++)
				graph.AddDirectedEdge(dependencies[i, 0], dependencies[i, 1], 0);

			var numberOfNodes = projects.Length;

			

			throw new NotImplementedException();
		}
	}
}