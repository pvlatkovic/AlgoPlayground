// using System;
// using System.Collections.Generic;
// using org.pv.Common;

// // data structure definition
// public class MaxHeap<T> where T : IComparable<T>
// {
// 	private const int DEFAUL_CAPACITY = 10;
// 	private int _capacity;
// 	private int _size = 0;

// 	private T[] _storage;

// 	public MaxHeap()
// 	{
// 		_capacity = DEFAUL_CAPACITY;
// 		_storage = new T[_capacity];
// 	}

// 	// class' API - Add, Peek, Poll

// 	public void Add(T value)
// 	{
// 		// ensure capacity
// 		EnsureCapacity();
// 		_storage[_size] = value;
// 		_size++;

// 		HeapifyUp();
// 	}

// 	public T Peek()
// 	{
// 		if(_size == 0) throw new EmptyHeapException();

// 		return _storage[0];
// 	}

// 	public T Poll()
// 	{
// 		if(_size == 0) throw new EmptyHeapException();

// 		var ret = _storage[0];

// 		_storage[0] = _storage[_size -1];
// 		_size--;
// 		HeapifyDown();

// 		return ret;
// 	}

// 	private void Swap(int indexA, int indexB)
// 	{
// 		var temp = _storage[indexA];
// 		_storage[indexA] = _storage[indexB];
// 		_storage[indexB] = temp;
// 	}

// 	private void HeapifyDown()
// 	{
// 		var currentIndex = 0;
// 		var leftChild = GetLeftChild(currentIndex);
// 		var rightChild = GetRightChild(currentIndex);
		
// 		while()
// 		{
// 			if(_storage[currentIndex].CompareTo(GetLeftChild(currentIndex))
// 				Swap(currentIndex, )
// 		}
// 		throw new NotImplementedException();
// 	}

// 	private void HeapifyUp()
// 	{
// 		throw new NotImplementedException();
// 	}

// 	private void EnsureCapacity()
// 	{
// 		throw new NotImplementedException();
// 	}

// 	private bool HasParent(int index) => GetParentIndex(index) >= 0;
// 	private bool HasLeftChild(int index) => GetLeftChildIndex(index) < _size;
// 	private bool HasRightChild(int index) => GetRightChildIndex(index) < _size;

// 	private int GetParentIndex(int index) => (index - 1)/2;
// 	private int GetLeftChildIndex(int index) => 2*index + 1;
// 	private int GetRightChildIndex(int index) => 2*index + 2;

// 	private T GetParent(int index) => _storage[GetParentIndex(index)];
// 	private T GetLeftChild(int index) => _storage[GetLeftChildIndex(index)];
// 	private T GetRightChild(int index) => _storage[GetRightChildIndex(index)];
	
	
// }