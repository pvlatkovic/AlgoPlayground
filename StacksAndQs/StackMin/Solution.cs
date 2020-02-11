// Cracking the coding interview - interview questions 3.2
// add function min which returns the minimum element. Push, pop and min should execute in O(1) time

using System;

namespace org.pv.AlgoPlayground.StacksAndQs.StackMin
{
	// data structure definition
	public class StackMin<T> where T : IComparable
	{
		private Node<T> storage;
		private Node<T> storageMins;

		public void Push(T item)
		{
			if(storage == null)	
			{
				storage = new Node<T>(item); 
				
				storageMins = new Node<T>(item);
			}
			else
			{
				var node = new Node<T>(item);
				node.Next = storage;
				storage = node;

				var temp = storageMins;
				if(item.CompareTo(storageMins.Value) < 0)
					storageMins = new Node<T>(item);
				else
					storageMins = new Node<T>(storageMins.Value);
				storageMins.Next = temp;
			}
		}

		public T Pop()
		{
			if(storage == null)
				throw new EmptyStackException();

			var ret = storage.Value;
			storage = storage.Next;
			storageMins = storageMins.Next;
			
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

		public T Min()
		{
			return storageMins.Value;
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
}