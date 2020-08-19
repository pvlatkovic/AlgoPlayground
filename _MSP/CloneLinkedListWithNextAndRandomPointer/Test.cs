using System;
using Xunit;

namespace org.pv.AlgoPlayground.MSP.CloneLinkedListWithNextAndRandomPointer
{
	public class Test
	{
		[Fact]
		public void TestCloneLinkedListWithNextAndRandomPointer()
		{
			//arrange
			var n1 = new Node<int>(1);
			var root = n1;

			var n2 = new Node<int>(2);
			var n3 = new Node<int>(3);
			var n4 = new Node<int>(4);
			var n5 = new Node<int>(5);
			var n6 = new Node<int>(6);

			n1.Next = n2; n1.Random = n6;
			n2.Next = n3; n2.Random = null;
			n3.Next = n4; n3.Random = n2;
			n4.Next = n5; n4.Random = n5;
			n5.Next = n6; n5.Random = n1;
			n6.Next = null; n6.Random = n4;

			//act
			var result = Solution.Execute(root);

			// control set
			n1.Value++; n2.Value++; n3.Value++; n4.Value++; n5.Value++; n6.Value++;

			//assert
			var next = root;
			var nextCloned = result;

			while (next != null)
			{
				Assert.Equal(nextCloned.Value, next.Value - 1);

				if (nextCloned.Random != null)
					Assert.Equal(nextCloned.Random.Value, next.Random.Value - 1);

				next = next.Next;
				nextCloned = nextCloned.Next;
			}
		}
	}
}