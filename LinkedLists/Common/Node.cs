using System;
using System.Text;

// data structure definition
public class Node<T>
{
	public T Value { get; set; }
	public Node<T> Next { get; set; }
	
	public Node(T value)
	{
		Value = value;
		Next = null;
	}

	public static Node<T> CreateLinkedList(T[] input)
	{
		if(input == null || input.Length == 0)
			throw new System.ArgumentException("input cannot ne null or empty");

		Node<T> linkedList = new Node<T>(input[0]);
		var nextNode = linkedList;

		for (int i = 1; i < input.Length; i++)
		{
			nextNode.Next = new Node<T>(input[i]);
			nextNode = nextNode.Next;
		}

		return linkedList;
	}
	
	public override string ToString()
	{
		var node = this;
		var stringBuilder = new StringBuilder();
		while(node != null)
		{
            stringBuilder.Append(node.Value + ", ");
			node = node.Next;
		}

		return stringBuilder.ToString();
	}
}