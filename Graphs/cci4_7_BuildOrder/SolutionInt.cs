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
	// simpler structure, not using Edge class in solution
	public class SolutionInt
	{
		/*
					var projects = new int[] { 1, 2, 3, 4, 5, 6 };
					//						   a  b  c  d  e  f
					var dependencies = new int[,] { { 1, 4 }, { 6, 2 }, { 2, 4 }, { 6, 1 }, { 4, 3 } };
					var resultExpected = new int[] { 6, 5, 2, 1, 4, 3 };

		*/
		
		public static int[] GetBuildOrder(int[] projects, int[,] dependencies)
		{
			var visited = new bool[projects.Length];
			var graph = new Dictionary<int, List<int>>();
			var ordering = new int[projects.Length];
			var indexOrdering = projects.Length - 1;

			// build dependencies
			for(int i = 0; i < dependencies.GetUpperBound(0)+1; i++)
			{
				if(!graph.ContainsKey(dependencies[i, 0]))
					graph[dependencies[i, 0]] = new List<int>();

				graph[dependencies[i, 0]].Add(dependencies[i, 1]);
			}

			for	(int i=0; i < projects.Length; i++)
			{
				var project = projects[i];
				if(!visited[i])
				{
					var visitedNodes = new List<int>();
					dfs(i, graph, visited, visitedNodes, projects);
					foreach(var vn in visitedNodes)
					{
						ordering[indexOrdering] = vn;
						indexOrdering--;
					}
				}
			}

			return ordering;
		}

		private static void dfs(int nodeIndex, Dictionary<int, List<int>> graph, bool[] visited, List<int> visitedNodes, int[] projects)
		{
			visited[nodeIndex] = true;
			
			if(graph.ContainsKey(projects[nodeIndex]))
			{
				var edges = graph[projects[nodeIndex]];

				foreach(var edge in edges)
				{
					if(!visited[edge])
					{
						dfs(edge, graph, visited, visitedNodes, projects);
					}
				}
			}

			visitedNodes.Add(projects[nodeIndex]);
		}
	}
}
 