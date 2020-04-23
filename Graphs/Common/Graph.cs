using System.Collections.Generic;

namespace org.pv.AlgoPlayground.Graphs.Common
{
	// W denotes type of graph's edge cost 
	// T denotes type of node/vertex
	public class Graph<T, W> : Dictionary<T, List<Edge<T, W>>> 
	{
		public Graph() : base()
		{
			
		}
		public void AddDirectedEdge(T from, T to, W cost)
		{
			if(!this.ContainsKey(from))
				this[from] = new List<Edge<T, W>>();

			this[from].Add(new Edge<T, W>(from, to, cost));
		}
	}
}