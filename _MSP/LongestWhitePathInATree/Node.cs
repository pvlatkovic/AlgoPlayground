using System.Collections.Generic;

namespace org.pv.AlgoPlayground.MSP.LongestWhitePathInATree
{
	public enum NodeType {Black, White};
	public class Node 
	{
		public Node()
		{
			Children = new List<Node>();
		}
		public NodeType Type { get; set;}
		public List<Node> Children { get; set;}
	}
}