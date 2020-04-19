using System;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.MinimalHeightTree
{
	public static class Solution
	{
		public static NodeBinTree<int> CreateBSTWithMinimalHeight(int[] sortedArray)
		{
			return GetBSTMinHeight(sortedArray, 0, sortedArray.Length - 1);
		}

		private static NodeBinTree<int> GetBSTMinHeight(int[] array, int start, int end)
		{
			if(end < start)
				return null;

			var mid = (start + end)/2;
			NodeBinTree<int> root = new NodeBinTree<int>(array[mid]);

			root.Left = GetBSTMinHeight(array, start, mid - 1);
			root.Right = GetBSTMinHeight(array, mid + 1, end);

			return root;
		}
	}
}