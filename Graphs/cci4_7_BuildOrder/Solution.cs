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
		public static string[] GetBuildOrder(string[] projects, string[,] dependencies)
		{
			//TODO: check cycles!
			var graph = new Common.Graph<string, int>();
			 for(int i = 0; i < dependencies.GetUpperBound(0)+1; i++)
			 	graph.AddDirectedEdge(new Common.Edge<string, int>(dependencies[i, 0], dependencies[i, 1], 0));

			var visited = new HashSet<string>();
			var ordering = new string[projects.Length];
			var indexOrdering = projects.Length - 1;

			// find all non visited nodes with no connections to them 
			// and set them to return List, then mark them as visited
			// in short, implement topological sort

			foreach(var project in projects)
			{
				if(!visited.Contains(project))
				{
					// create list of visited nodes starting from 'project' node
					 var visitedNodes = new List<string>();
					 execDFS(project, visited, visitedNodes, graph);
					 foreach(var vn in visitedNodes)
					 {
						 ordering[indexOrdering] = vn;
						 indexOrdering = indexOrdering -1;
					 }
				}
			}

			return ordering;
		}

		private static void execDFS(string project, HashSet<string> visited, List<string> visitedNodes, Common.Graph<string, int> graph)
		{
			visited.Add(project);

			var edges = graph.ContainsKey(project) ? graph[project] : null;

			if(edges != null)
			{
				foreach(var edge in edges)
				{
					if(!visited.Contains(edge.To))
					{
						execDFS(edge.To, visited, visitedNodes, graph);
					}
				}
			}
			visitedNodes.Add(project);
		}
	}
}