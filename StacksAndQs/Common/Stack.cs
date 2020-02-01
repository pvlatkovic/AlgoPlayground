using System;

// data structure definition
public class Stack<T>
{
	private Node<T> storage;

	public void Push(T item)
	{
		if(storage == null)	
			storage = new Node<T>(item); 
		else
		{
			var node = new Node<T>(item);
			node.Next = storage;
			storage = node;
		}
	}

	public T Pop()
	{
		if(storage == null)
			throw new EmptyStackException();

		var ret = storage.Value;
		storage = storage.Next;
		return ret;
	}

	public T Peek()
	{
		if(storage == null)
			throw new EmptyStackException();
		
		return storage.Value;
	}

	public bool IsEmpty()
	{
		return storage == null;
	}

	public static Stack<T> CreateStack(T[] items)
	{
		if(items == null || items.Length == 0)
			return null;

		var ret = new Stack<T>();
		foreach(var item in items)
			ret.Push(item);

		return ret;
	}
}


public class EmptyStackException : Exception
{
	public EmptyStackException(string message = "Stack is empty") : base(message)
	{
	}
}