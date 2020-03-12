using System;

namespace org.pv.Common
{
	// data structure definition
	public class Queue<T>
	{
		//add, remove, peek, isEmpty
		private Node<T> top;
		private Node<T> bottom;

		public void Add(T item)
		{
			if(top == null)
			{
				top = new Node<T>(item);
				bottom = top;
			}
			else
			{
				bottom.Next = new Node<T>(item);
				bottom = bottom.Next;
			}
		}

		public T Remove()
		{
			if (top == null)
				throw new EmptyQueueException();
			var ret = top.Value;
			top = top.Next;

			return ret;
		}

		public T Peek()
		{
			if (top == null)
				throw new EmptyQueueException();

			return top.Value;
		}

		public bool IsEmpty()
		{
			return top == null;
		}


		public static Queue<T> CreateQueue(T[] items)
		{
			if(items == null || items.Length == 0)
				return null;

			var ret = new Queue<T>();
			foreach(var item in items)
				ret.Add(item);

			return ret;
		}
	}

	public class EmptyQueueException : Exception
	{
		public EmptyQueueException(string message = "Queue is empty") : base(message)
		{
		}
	}
}