// https://www.youtube.com/watch?v=il_t1WVLNxk
// problem Kindle library dependencies

using System;
using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.AP.LibraryDependencies
{
	public class Solution
	{
		//Topological sort
		public static int[] SortDependencies(int[,] dependencies, int numberOfProjects) 
		{
			// dependencies given in form of
			// {1, 2}, {3, 2}, {3, 4}, {2, 5}
			// 2 depends on 1, 2 depends on 3 ...

			// 1 - 3 - 2 - 4 - 5

			// prepare data structure for storing dependencies
			var nodeDep = new Dictionary<int, List<int>>(); 
			for(int i = 0; i < dependencies.GetUpperBound(0) + 1; i++)
			{
				if(!nodeDep.ContainsKey(dependencies[i, 1]))
					nodeDep[dependencies[i, 1]] = new List<int>();

				nodeDep[dependencies[i, 1]].Add(dependencies[i,0]);
			}

			var indexOrdered = 0;
			var visited = new bool[numberOfProjects];

			//DFS with stack
			var stack = new Stack<int>();
			var orderedNodes = new int[numberOfProjects];

			foreach(int node in nodeDep.Keys)
			{
				if(!visited[node])
				{
					stack.Push(node);
					visited[node] = true;

					var visitedNodes = new List<int>();

					while(stack.Count > 0)
					{
						var n = stack.Pop();

						if(nodeDep.ContainsKey(n))
							foreach(var cn in nodeDep[n])
							{
								if(!visited[cn])
								{
									stack.Push(cn);
									visited[cn] = true;
								}
							}

						visitedNodes.Add(n);
					}

					for(int i = visitedNodes.Count - 1 ; i >= 0; i--)
					{
						orderedNodes[indexOrdered] = visitedNodes[i];
						indexOrdered++;
					}
				}
			}

			return orderedNodes;
		}
	}
}