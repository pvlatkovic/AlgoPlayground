using System.Collections.Generic;

namespace org.pv.AlgoPlayground.AP.FindConnectedComponents
{
	public class Solution
	{
		public static Dictionary<int, List<int>> FindConnectedComponentsBFS(int[,] M) // n x n
		{
			// conver matrix to Adjacency list

			var n = M.GetUpperBound(1) + 1;

			var adjList = new Dictionary<int, List<int>>();

			for(var i = 0; i < n; i++)
			{
				for(var j = 0; j < n; j++)
				{
					if(!adjList.ContainsKey(i))
						adjList[i] = new List<int>();
					if(M[i,j] == 1) 
						adjList[i].Add(j);
				}
			}

			var visited = new bool[n];
			var result = new Dictionary<int, List<int>>();
			var Q = new Queue<int>();

			for(int i = 0; i < n; i++)
			{
				if(visited[i]) continue;

				Q.Enqueue(i);

				if(!result.ContainsKey(i)) result[i] = new List<int>();

				while(Q.Count > 0)
				{
					var vertex = Q.Dequeue();
					visited[vertex] = true;

					foreach(var vc in adjList[vertex])
					{
						if(!visited[vc])
						{
							Q.Enqueue(vc);
							result[i].Add(vc);
						}
					}
				}
			}

			return result;
		}
	}
}