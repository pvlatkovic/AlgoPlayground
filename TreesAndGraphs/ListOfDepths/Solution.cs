// CCI 4.3

using System;
using System.Collections.Generic;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.TreesAndGraphs.ListOfDepths
{
	public static class Solution<T>
	{
		public static List<Node<T>> CreateListOfDepths(NodeBinTree<T> tree)
		{
			var listOfDepths = new List<Node<T>>();

			listOfDepths.Add(new Node<T>(tree.Value)); // added to index 0 - first level

			AddToLevel(listOfDepths, tree.Left, 1);
			AddToLevel(listOfDepths, tree.Right, 1);

			return listOfDepths;
		}

		private static void AddToLevel(List<Node<T>> listOfDepths, NodeBinTree<T> node, int addToLevel)
		{
			if(node == null)
				return; 

			var newNode = new Node<T>(node.Value);

			if(listOfDepths.Count-1 >= addToLevel)
			{
				newNode.Next = listOfDepths[addToLevel];
				listOfDepths[addToLevel] = newNode;
			}
			else
				listOfDepths.Add(newNode);

			AddToLevel(listOfDepths, node.Left, addToLevel+1);
			AddToLevel(listOfDepths, node.Right, addToLevel+1);
		}
	}
}