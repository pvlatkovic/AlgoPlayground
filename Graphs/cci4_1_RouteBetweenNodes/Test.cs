// cci 4.1
// Given a directed graph, design an algo to find 
// out whether there is a route between two nodes

using System;
using org.pv.AlgoPlayground.Graphs;
using org.pv.AlgoPlayground.Graphs.Common;
using Xunit;

namespace org.pv.AlgoPlayground.Graphs.RouteBetweenNodes
{
    public class Test
    {
        [Theory]
        [InlineData(4, 3, false)]
        [InlineData(0, 4, false)]
        [InlineData(0, 3, true)]
        [InlineData(4, 6, true)]
        [InlineData(0, 0, true)]
        public void TestIsRouteBetweenTwoNodes(int node1, int node2, bool resultExpected)
        {   
            //GIVEN
            //cci example from page 1-6
            var nodes = new int[] { 0, 1, 2, 3, 4, 5, 6 }; 
			var dependencies = new Edge<int, int>[] { 
				new Edge<int, int>(0, 1, 0), 
				new Edge<int, int>(1, 2, 0), 
				new Edge<int, int>(2, 3, 0),
				new Edge<int, int>(3, 2, 0),
				new Edge<int, int>(2, 0, 0), 
				new Edge<int, int>(4, 6, 0),
				new Edge<int, int>(6, 5, 0),
				new Edge<int, int>(5, 4, 0),
			}; 
            var graph = new Graph<int, int>();
        	for(int i = 0; i < dependencies.Length; i++)
				graph.AddDirectedEdge(dependencies[i]);

            //WHEN
            var result = Solution<int, int>.IsRouteBetweenNodes(nodes, graph, node1, node2);

            //THEN
            Assert.Equal(resultExpected, result);
        }
    }
}
