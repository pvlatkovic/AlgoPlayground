using System;
using System.Collections.Generic;
using System.Text;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.AP.SerializeTreeToFileAndBack
{
	public class Solution
	{
		// string will be returned as a representation of a file

		// ------------- NON RECURSIVE solution, just for fun :) -----------------------
		public static string SerializeBinaryTreeToFileNoRecursion(NodeBinTree<int> tree)  
		{
			// travers with BFS and create an array as a storage (similar to min/max heap)
			var index = 0; 
			var result = new string[100]; //TODO: create EnsureCapacity method

			var stackOfNodes = new Stack<NodeBinTree<int>>();
			var stackOfIndexes = new Stack<int>();

			stackOfNodes.Push(tree);
			stackOfIndexes.Push(index);

			NodeBinTree<int> node;

			while(stackOfNodes.Count > 0)
			{
				node = stackOfNodes.Pop();
				index = stackOfIndexes.Pop();

				if(node != null)
				{
					result[index] = node.Value.ToString();

					// basically, here we flatten tree to an array, if node is placed in i-th place 
					// it's left and right node should be placed in i*2 + 1 and i*2 + 2 respectively
					if(node.Left != null || node.Right != null)
					{
						stackOfNodes.Push(node.Right); stackOfNodes.Push(node.Left); 
						stackOfIndexes.Push(index * 2 + 2); stackOfIndexes.Push(index * 2 +1);  // similarity with minheap implementation
					}
				}
				else
				{
					result[index] = "end";
				}
			}

			var stringResult = new StringBuilder();
			for(var i = 0; i < result.Length; i++)
			{
				if(result[i] == "end") 
					break;

				if(i > 0)
					stringResult.Append(',');

				stringResult.Append(result[i] != null ? result[i].ToString() : "e");
			}

			return stringResult.ToString();
		}

		public static NodeBinTree<int> DeserializeFileToBinaryTree(string serializedTree)
		{
			var arrayTree = serializedTree.Split(',');



			throw new NotImplementedException();
		}

		// ------------------- NON RECURSIVE solution -----------------------


		// ------------- RECURSIVE solution -----------------------
		public static string SerializeBinaryTreeToFileWithRecursion(NodeBinTree<int> tree)
		{
			var result = Serialize(tree);
			return result;
		}

		private static string Serialize(NodeBinTree<int> node)
		{
			if(node == null)
				return "e,";

			//preorder traversal
			var value = node.Value;
			var left = Serialize(node.Left);
			var right = Serialize(node.Right);

			return value + "," + left + right;
		}

		public static NodeBinTree<int> DeserializeFileToBinaryTreeWithRecursion(string serializedTree)
		{
			var q = new Queue<string>();
			var split = serializedTree.Split(',');
			for(int i = 0; i < split.Length; i++)
				q.Enqueue(split[i]);

			return Deserialize(q);
		}

		private static NodeBinTree<int> Deserialize(Queue<string> q)
		{
			var value = q.Dequeue();

			if(string.IsNullOrEmpty(value) || value == "e")
				return null;

			//preorder traversal
			var node = new NodeBinTree<int>(int.Parse(value));
			node.Left = Deserialize(q);
			node.Right = Deserialize(q);
			
			return node;	
		}
	}
}