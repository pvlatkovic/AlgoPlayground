// Cracking coding interview 2.7 
// check if linked lists intersect

namespace org.pv.AlgoPlayground.LinkedLists.Intersection
{
	public class Solution
	{
		public static Node<int> GetIntersectionNodeBrute(Node<int> firstList, Node<int> secondList)
		{
			// brute force solution O(NxM), if n~m => O(N^2)
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
	}
}