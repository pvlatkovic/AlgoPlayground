using System;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.Graphs.BuildOrder
{
	public class SolutionInt
	{
		public static List<int> GetBuildOrder(int[,] dependencies, int[] projects)
		{
			var graph = new Dictionary<int, List<int>>();
			var numberOfPairs = dependencies.GetUpperBound(0) + 1; 
			for(int i = 0; i < numberOfPairs; i++)
			{
				if(!graph.ContainsKey(dependencies[i,0]))
				{
					graph[dependencies[i, 0]] = new List<int>();
				}
				graph[dependencies[i, 0]].Add(dependencies[i, 1]);
			}
			
			// lets try with DFS
			
			// we need list of visited nodes 
			var visited = new bool[projects.Length]; // by default all are false
			var stack = new Stack<int>();

			// start from node 0, try to find nodes which are not dependent on any other nodes
			for(int at=0; at < projects.Length; at++)
			{
				stack.Push(at); // push index of a project to stack
				visited[at] = true;

				// then traverse to its connections and mark visited
				if(graph.ContainsKey(projects[at]))
				{
					for(int j=0; j < graph[projects[at]].Count; j++)
					{
						
					}
				}
			}


			throw new NotImplementedException();
		}
	}
}