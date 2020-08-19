namespace org.pv.AlgoPlayground.MSP.CloneLinkedListWithNextAndRandomPointer
{
	public class Node<T>
	{
		public Node(T value)
		{
			Value = value;
		}

		public Node<T> Next { get; set; }
		public T Value;
		public Node<T> Random { get; set; }
	}
}