	using System;

	// data structure definition
	namespace org.pv.TreesAndGraphs.Common
{
	public class MinHeap<T> where T : IComparable<T>
	{
		private int _capacity;
		private int _size; // independent of capacity, except size < _capacity
		private const int DEFAULT_CAPACITY = 10;
		private T[] _storage; //will use 

		public MinHeap()
		{
			_capacity 		= DEFAULT_CAPACITY;
			_storage		= new T[_capacity];
		}

		// class' API - Add, Peek, Poll

		public void Add(T value)
		{
			EnsureExtraCapacity();

			// insert as last element (by size)
			// and heapifyUp from bottom to up
			_storage[_size] = value;
			_size++;

			HeapifyUp();
		}

		// only returns value of minimum element
		public T Peek() 
		{
			if(_size == 0) throw new EmptyMinHeapException();

			return _storage[0];
		}

		// Extract minimum element
		public T Poll()
		{
			if(_size == 0) throw new EmptyMinHeapException();

			var ret = _storage[0];

			// take last inserted element and move it to top
			// than heapify down the array, from top to down
			_storage[0] = _storage[_size-1];
			_size--;

			HeapifyDown();

			return ret;
		}

		// initial set of utility methods
		private int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;

		private int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;

		private int GetParentIndex(int childIndex) => (childIndex - 1) / 2;

		private bool HasLeftChild(int index) => GetLeftChildIndex(index) < _size;

		private bool HasRightChild(int index) => GetRightChildIndex(index) < _size;

		private bool HasParent(int index) => GetParentIndex(index) >= 0;

		private void Swap(int indexA, int indexB) 
		{
			T temp = _storage[indexA];  
			_storage[indexA] = _storage[indexB];
			_storage[indexB] = temp;
		}

		private void EnsureExtraCapacity()
		{
			if(_size + 1 == _capacity)
			{
				var tempStorage	= new T[_capacity * 2];
				_storage.CopyTo(tempStorage, 0);
				_storage = tempStorage;
			}
		}

		private void HeapifyDown()
		{
			var currentIndex = 0;
			var leftChildIndex = GetLeftChildIndex(0);
			var rightChildIndex = GetRightChildIndex(0);
			
			while(leftChildIndex < _size && rightChildIndex < _size)
			{
				if(_storage[leftChildIndex].CompareTo(_storage[rightChildIndex]) > 0)
				{
					Swap(rightChildIndex, currentIndex);
					currentIndex = rightChildIndex;
				}
				else
				{
					Swap(leftChildIndex, currentIndex);
					currentIndex = leftChildIndex;
				}

				leftChildIndex = GetLeftChildIndex(currentIndex);
				rightChildIndex = GetRightChildIndex(currentIndex);
			}
		}

		private void HeapifyUp()
		{
			var currentIndex = _size - 1;

			var parentIndex = GetParentIndex(currentIndex);

			while (currentIndex > 0)
			{
				if(_storage[parentIndex].CompareTo(_storage[currentIndex]) > 0)
				{
					Swap(currentIndex, parentIndex);
					currentIndex = parentIndex;
				}
				else
					break;
			}
		}
	}
}