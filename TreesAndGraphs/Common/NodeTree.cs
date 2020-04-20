using System;
using System.Collections.Generic;

// data structure definition
namespace org.pv.TreesAndGraphs.Common
{
	public class NodeTree<T>
	{

		public T Value { get; set; }
		public List<NodeTree<T>> ChildNodes { get; set; }

		public NodeTree()
		{
			ChildNodes = new List<NodeTree<T>>();
		}
		public NodeTree(T value)
		{
			Value = value;
			ChildNodes = new List<NodeTree<T>>();
		}
	
	}
}