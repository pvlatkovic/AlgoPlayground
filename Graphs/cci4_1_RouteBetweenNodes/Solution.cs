// cci 4.1

using System;
using System.Collections.Generic;
using org.pv.Common;
using org.pv.AlgoPlayground.Graphs.Common;

namespace org.pv.AlgoPlayground.Graphs.RouteBetweenNodes
{
    public static class Solution<T, W> where T:IComparable
    {
        public static bool IsRouteBetweenNodes(T[] nodes, Graph<T, W> graph, T node1, T node2)
        {
            // we can use both DFS or BFS
            // try DFS first

            //first case
            if(node1.CompareTo(node2) == 0)
                return true;

            // we need list of visited nodes
            var visited = new Dictionary<T, bool>(); 
            // init visited map
            foreach(var node in nodes)
                visited[node] = false;

            // we need a stack here 
            var stack = new pv.Common.Stack<T>();
            stack.Push(node1);
            visited[node1] = true;
            
            while(!stack.IsEmpty())
            {
                var node = stack.Pop();

                if(graph.ContainsKey(node))
                {
                    foreach(var ne in graph[node])
                    {
                        if(!visited[ne.To])
                        {
                            if(ne.To.CompareTo(node2) == 0)
                                return true;

                            stack.Push(ne.To);
                            visited[ne.To] = true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
