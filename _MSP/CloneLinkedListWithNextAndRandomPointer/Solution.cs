using System;

namespace org.pv.AlgoPlayground.MSP.CloneLinkedListWithNextAndRandomPointer
{
	public class Solution
	{
		public static Node<int> Execute(Node<int> list)
		{
			if (list == null)
				throw new ArgumentNullException("cannot clone null linked list");
			//TODO: (0) check edge cases: llist == null...

			// (1) we double all the nodes and put them in between existing ones
			// n1 n2 n3 n4 n5 -> n1 n1c n2 n2c n3 n3c n4 n4c n5 n5c

			var root = list;
			var next = list;

			while (next != null) // O(N)
			{
				var realNext = next.Next;
				next.Next = new Node<int>(next.Value);
				next.Next.Next = realNext;
				next = realNext;
			}

			// (2) recreate random links // O(N)
			next = root;
			while (next != null)
			{
				var n = next.Random;
				// n1 n1c n2 n2c n3 n3c - n1 can be null, therefor we need the check

				if (next.Random != null)
					next.Next.Random = n.Next;

				//skip next in list
				next = next.Next.Next;
			}

			// (3) detach original from cloned list // O(N)
			var clonedRoot = root.Next;
			next = root;
			var nextCloned = clonedRoot;
			while (nextCloned != null)
			{
				// n1 n1c n2 n2c n3 n3c

				if (next.Next != null)
				{
					next.Next = next.Next.Next;
					next = next.Next;
				}
				else
					break;


				if (nextCloned.Next != null)
				{
					nextCloned.Next = nextCloned.Next.Next;
					nextCloned = nextCloned.Next;
				}
				else
					break;
			}

			return clonedRoot;
		}
	}
}