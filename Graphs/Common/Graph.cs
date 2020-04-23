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
		public void AddDirectedEdge(Edge<T, W> edge)
		{
			if(!this.ContainsKey(edge.From))
				this[edge.From] = new List<Edge<T, W>>();

			this[edge.From].Add(new Edge<T, W>(edge.From, edge.To, edge.Cost));
		}
	}
}