namespace org.pv.AlgoPlayground.Graphs
{
	public class Edge<T,W>
	{
		public Edge(T from, T to, W cost)
		{
			this.From 	= from;
			this.To 	= to;	
			this.Cost	= cost;
		}
		public T From { get; set; }
		public T To { get; set; }
		public W Cost { get; set; }
	}
}