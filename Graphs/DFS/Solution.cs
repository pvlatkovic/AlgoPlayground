using System;
using System.Collections.Generic;
using org.pv.Common;

namespace org.pv.AlgoPlayground.Graphs.DFS  
{
	//Demo of Depth First Search
	public class Solution<T, W>
	{
		// Perform a depth first search on a graph with n nodes.
		// This impl returns number of connected nodes starting from firstNode
		public static int DFS(T[] nodes, T[,] dependencies, T firstNode)
		{
			// Example
			// nodes = { a, b, c, d, e, f }
			// dependencies = { {a, d}, {f, b}, {b, d}, {f, a}, {d, c}}

			// DFS(params, a).Count == 5 // connected to 5 other nodes
			// DFS(params, e).Count == 1 // not connected to any other nodes

			var graph = new Common.Graph<T, W>();
			for(int i = 0; i < dependencies.GetUpperBound(0)+1; i++)
				graph.AddDirectedEdge(dependencies[i, 0], dependencies[i, 1], default(W));

			var numberOfNodes = nodes.Length;

			// initialize visited list/map
			var visited = new Dictionary<T, bool>();
			foreach(var p in nodes)
				visited[p] = false;

			var count = 0;

			// non recursive solution, here we use Stack
			
			var stack = new pv.Common.Stack<T>(); // lets use homemade stack
			stack.Push(firstNode);
			visited[firstNode] = true;

			while(!stack.IsEmpty())
			{
				var node = stack.Pop();
				// famous doSomething :) e.g. count++
				count++;
				
				if(graph.ContainsKey(node))
				{
					foreach(var edge in graph[node])
					{
						if(!visited[edge.To])
						{
							stack.Push(edge.To);
							visited[edge.To] = true;
						}
					}
				}
			}

			return count;
		}
	}
}