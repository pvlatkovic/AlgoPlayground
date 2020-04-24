// CCI 4.7 Given a list of packages that need to be built and the dependencies 
// for each package, determine a valid order in which to build the packages

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
			 	graph.AddDirectedEdge(new Common.Edge<string, int>(dependencies[i, 0], dependencies[i, 1], 0));

			// find all non visited nodes with no connections to them 
			// and set them to return List, then mark them as visited

			

			throw new NotImplementedException();
		}
	}
}