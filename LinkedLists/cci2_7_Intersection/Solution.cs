// Cracking coding interview 2.7 
// check if linked lists intersect

namespace org.pv.AlgoPlayground.LinkedLists.Intersection
{
	public class Solution
	{
		// brute force solution O(NxM), if n~m => O(N^2)
		public static Node<int> GetIntersectionNodeBrute(Node<int> firstList, Node<int> secondList)
		{
			 var rootSecondList = secondList;
			 var a = firstList;
			 while (a != null)
			 {
				 var b = rootSecondList;
				 while(b != null)
				 {
					if(a == b)
						return a;

					b = b.Next;
				 }
				 a = a.Next;
			 }
			 return null;
		}

		// O(N) solution
		public static Node<int> GetIntersectionNode(Node<int> firstList, Node<int> secondList)
		{
			var firstListLenght = GetLength(firstList);
			var secondListLenght = GetLength(secondList);

			Node<int> shorter, longer;
			int shorterLength, longerLength;

			if(firstListLenght > secondListLenght)
			{
				longer = firstList;
				shorter = secondList;
				longerLength = firstListLenght;
				shorterLength = secondListLenght;
			}
			else 
			{
				longer = secondList;
				shorter = firstList;
				longerLength = secondListLenght;
				shorterLength = firstListLenght;
			}

			var skip = longerLength - shorterLength;

			// skip longer part
			var nodeL = longer;
			for(int i=0; i<skip; i++)
			{
				nodeL = nodeL.Next;
			}

			// move together until the end of the lists
			var nodeS = shorter;
			while(nodeL != null)
			{
				if(nodeL == nodeS)
					return nodeL;
				
				nodeL = nodeL.Next;
				nodeS = nodeS.Next;
			}

			return null;
		}

		private static int GetLength(Node<int> linkedList)
		{
			var counter = 0;
			if(linkedList != null)
			{
				var node = linkedList;
				while(node != null)
				{
					counter++;
					node = node.Next;
				}
				return counter;
			}
			return 0;
		}
	}
}