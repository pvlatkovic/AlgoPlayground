using Xunit;

namespace org.pv.AlgoPlayground.StacksAndQs.StackMin
{
	public class Test
	{
		[Fact]
		public void TestStackMinBasic()
		{

			//Given 
			var stackValues = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8};

			//When
			// push values into queue
			var stack = new StackMin<int>();
			for(int i = 0; i < stackValues.Length; i++)
				stack.Push(stackValues[i]);
		
			Assert.Equal(1, stack.Min());
			
			stack.Pop();
			stack.Pop();
			stack.Pop();

			Assert.Equal(1, stack.Min());
		}

		[Fact]
		public void TestStackMinMedium()
		{

			//Given 
			var stackValues = new int[8] { 3, 4, 5, 1, 2, 3, -1, -2};

			//When
			// push values into queue
			var stack = new StackMin<int>();
			for(int i = 0; i < stackValues.Length; i++)
				stack.Push(stackValues[i]);
		
			Assert.Equal(-2, stack.Min());
			
			stack.Pop(); // remove -2
			Assert.Equal(-1, stack.Min());
			stack.Pop(); // remove -1
			Assert.Equal(1, stack.Min());
			stack.Pop(); // remove 3
			Assert.Equal(1, stack.Min());
			stack.Pop(); // remove 2
			Assert.Equal(1, stack.Min());
			stack.Pop(); // remove 1
			Assert.Equal(3, stack.Min());
			stack.Pop(); // remove 5
			Assert.Equal(3, stack.Min());
			stack.Pop(); // remove 4
			Assert.Equal(3, stack.Min());
			stack.Pop(); // remove 3

			stack.Push(1);
			Assert.Equal(1, stack.Min());
		}
	}
}