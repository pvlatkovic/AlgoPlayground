using System;

namespace org.pv.TreesAndGraphs.Common
{
	/*
	public class MaxHeap<T> where T: IComparable
	{
		private int _capacity = 0;
		private int DEFAULT_CAPACITY = 10;
		private int _size = 0;

		private T[] _storage; 

		public MaxHeap()
		{
			_storage = new T[DEFAULT_CAPACITY];
			_capacity = DEFAULT_CAPACITY;
		}

		// class' api: insert, peek, poll 
		public void Insert(T value)
		{
			_size++;
			EnsureCapacity();

			
		}

		private void EnsureCapacity()
		{
			if(_size > _capacity)
			{
				var _storageCopy = new T[_size *2];
				_storage.CopyTo(_storageCopy, 0);
				_storage = _storageCopy;
			}
		}

		public T Peek()
		{
			throw new NotImplementedException();
		}

		public T Poll()
		{
			throw new NotImplementedException();
		}
	}
	*/
}