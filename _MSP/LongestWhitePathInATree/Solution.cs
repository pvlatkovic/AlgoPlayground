// You have a tree with black and white nodes in it. 
// The goal is to find the longest white path in a tree.

//TODO: find complexity

namespace org.pv.AlgoPlayground.MSP.LongestWhitePathInATree
{
	public class Solution
	{
		private static int _longest = 0;

		public static int Execute(Node root)
		{
			_longest = 0;
			FindLongest(root);
			return _longest;
		}
		private static int FindLongest(Node node)
		{
			if(node == null)
				return 0;

			if(node.Type == NodeType.White)
			{
				var lmax = 1;
				foreach(var n in node.Children)
				{
					var l = 1 + FindLongest(n);	
					if(l > lmax)
						lmax = l;
					if(_longest < l)
						_longest = l;
				}
				return lmax;
			}
			else
			{
				foreach(var n in node.Children)
				{
					var l = FindLongest(n);	
					if(_longest < l)
						_longest = l;
				}
				return 0;
			}
		}
	}

	
}