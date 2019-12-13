// Cracking codig interview 2.5
// SumLists, List1(7 -> 1 -> 6) + List2(5 -> 9 -> 2) = 617 + 295 = 912


namespace org.pv.AlgoPlayground.LinkedLists.SumLists
{
	public class Solution
	{
		public static int SumLists (Node<int> linkedList1, Node<int> linkedList2)
		{
			return SumList(linkedList1) + SumList(linkedList2);
		}

		public static int SumList(Node<int> linkedList)
		{
			var node 	= linkedList;
			var mc 		= 1; // multiplication coef
			var sum 	= 0;

			while (node != null)
			{
				sum += node.Value * mc;
				mc *= 10;
				node = node.Next;
			}

			return sum;
		}
	}
}