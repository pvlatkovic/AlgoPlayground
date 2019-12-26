// I know I could inherit from Node :p 
// this is not engineering bu algo example :)

using System.Text;

public class NodeDouble<T>
{
	public T Value { get; set; }
	public NodeDouble<T> Next { get; set; }
	public NodeDouble<T> Previous { get; set; }

	public NodeDouble(T value)
	{
		Value = value;
		Next = null;
		Previous = null;
	}

	public static NodeDouble<T> CreateDoubleLinkedList(T[] input)
	{
		if (input == null || input.Length == 0)
			throw new System.ArgumentException("input cannot ne null or empty");

		NodeDouble<T> linkedList = new NodeDouble<T>(input[0]);
		var nextNode = linkedList;

		for (int i = 1; i < input.Length; i++)
		{
			nextNode.Next = new NodeDouble<T>(input[i]);
			nextNode.Next.Previous = nextNode;
			nextNode = nextNode.Next;
		}

		return linkedList;
	}

	public override string ToString()
	{
		var node = this;
		var stringBuilder = new StringBuilder();
		while (node != null)
		{
			stringBuilder.Append(node.Value + ", ");
			node = node.Next;
		}

		return stringBuilder.ToString();
	}
}