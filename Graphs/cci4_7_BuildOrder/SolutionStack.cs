using System;
using org.pv.Common;
using System.Collections.Generic;


namespace org.pv.AlgoPlayground.Graphs.BuildOrder
{
	public class SolutionStack
	{
		// wil try to make solution without recursion
		public static int[] GetBuildOrder(int[] projects, int[,] dependencies)
		{
			var graph = new Dictionary<int, List<int>>();
			var numberOfPairs = dependencies.GetUpperBound(0) + 1; 
			var orderedProjects = new int[projects.Length];
			var orderedProjectsIndex = projects.Length - 1;

			for(int i = 0; i < numberOfPairs; i++) 
			{
				if(!graph.ContainsKey(dependencies[i,0]))
					graph[dependencies[i, 0]] = new List<int>();
				graph[dependencies[i, 0]].Add(dependencies[i, 1]); // storing indexes of projects 
			}
			
			// lets try with DFS
			
			// we need list of visited nodes 
			var visited = new bool[projects.Length]; // by default all are false
			var stack = new pv.Common.Stack<int>();

			// start from node 0, try to find nodes which are not dependent on any other nodes
			for(int at=0; at < projects.Length; at++)
			{
				if(!visited[at])
				{
					stack.Push(at); // push index of a project to stack
					visited[at] = true;

					var visitedNodes = new List<int>(); // for particular project on index at

					while(!stack.IsEmpty())
					{	
						var projectIndex = stack.Pop();

						// then traverse to its connections and mark visited
						if(graph.ContainsKey(projectIndex))
						{
							for(int j=0; j < graph[projectIndex].Count; j++)
							{
								if(!visited[graph[projectIndex][j]])
								{
									stack.Push(graph[projectIndex][j]);
									visited[graph[projectIndex][j]] = true;
								}
							}
						}
						
						visitedNodes.Add(projectIndex);
					}

					// insert visitedNodes to orderedProjects
					for(int k = visitedNodes.Count - 1; k >= 0; k--)  
					{
						orderedProjects[orderedProjectsIndex] = visitedNodes[k];
						orderedProjectsIndex--;
					}
				}
			}

			return orderedProjects;
		}
	}
}