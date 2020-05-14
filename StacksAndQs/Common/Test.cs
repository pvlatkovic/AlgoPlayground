// testing queue and stack data structures

using Xunit;

namespace org.pv.Common
{
	public class TestQueueAndStack
	{
		[Fact]
		public void QueueTest()
		{
			//Given 
			var queueValues = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8};

			//When
			// push values into queue
			var queue = new Queue<int>();
			for(int i = 0; i < queueValues.Length; i++)
				queue.Add(queueValues[i]);
			
			//Then
			//lets check correct order, peek and exceptions

			Assert.False(queue.IsEmpty());

			Assert.True(queue.Peek() == queueValues[0]);

			var index = 0;
			while(!queue.IsEmpty())
			{
				Assert.True(queue.Remove() == queueValues[index++]);
			}

			Assert.Throws<EmptyQueueException>(() => queue.Remove());
		}

		[Fact]
		public void StackTest()
		{
			//Given 
			var stackValues = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8};

			//When
			// push values into queue
			var stack = new Stack<int>();
			for(int i = 0; i < stackValues.Length; i++)
				stack.Push(stackValues[i]);
			
			//Then
			//lets check correct order, peek and exceptions

			Assert.False(stack.IsEmpty());

			var index = stackValues.Length-1;
			Assert.True(stack.Peek() == stackValues[index]);

			while(!stack.IsEmpty())
			{
				Assert.True(stack.Pop() == stackValues[index--]);
			}

			Assert.Throws<EmptyStackException>(() => stack.Pop());
		}
	}
}