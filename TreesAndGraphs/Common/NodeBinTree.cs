using System;

// data structure definition 
namespace org.pv.TreesAndGraphs.Common
{
	// binary tree I ll implement with an array this is just for test/play purposes
	public class NodeBinTree<T>
	{

		public T Value { get; set; }
		public NodeBinTree<T> Left { get; set; }
		public NodeBinTree<T> Right { get; set; }

		public NodeBinTree()
		{
		}
		public NodeBinTree(T value)
		{
			Value = value;
		}

	}
}