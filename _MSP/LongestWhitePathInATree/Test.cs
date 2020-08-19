using System.Collections.Generic;
using Xunit;

namespace org.pv.AlgoPlayground.MSP.LongestWhitePathInATree
{
	public class Test
	{
		[Fact]
		public void TestLongestWhitePathInATree()
		{
			//given 
			var node0_1 = new Node();
			node0_1.Type = NodeType.White;
			var node1_1 = new Node() { Type = NodeType.White}; 
			var node1_2 = new Node() { Type = NodeType.Black}; 
			var node1_3 = new Node() { Type = NodeType.White}; 
			node0_1.Children = new List<Node>() { node1_1, node1_2, node1_3};
			
			var node2_1 = new Node() { Type = NodeType.White};
			var node3_1 = new Node() { Type = NodeType.White};
			var node4_1 = new Node() { Type = NodeType.White};

			node1_2.Children.Add(node2_1);
			node2_1.Children.Add(node3_1);
			node3_1.Children.Add(node4_1);

			//when 
			var result = Solution.Execute(node0_1);

			//then 
			var resultExpected = 3;
			Assert.Equal(resultExpected, result);
			
		}
	}
}