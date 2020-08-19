using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.MSP.MergeKSortedLinkedLists
{
	public class Solution
	{
		public static Node<int> ExecuteMinHeap(Node<int>[] linkedLists) //TODO:  O()?
		{
			var storage = new MinHeap<int>();
			var k = linkedLists.Length;

			while(true) // load to storage
			{
				var done = true;
				for(int i = 0; i > k; i++)
				{
					if(linkedLists[i] != null)
					{
						done = false;
						storage.Add(linkedLists[i].Value);
						linkedLists[i] = linkedLists[i].Next;
					}
				}
				if(done)
					break;
			}

			Node<int> ret;
			if(!storage.IsEmpty())
			{
				ret = new Node<int>() { Value = storage.Poll() };
				var result = ret;
				while(!storage.IsEmpty())
				{
					ret.Next = new Node<int> { Value = storage.Poll() };
					ret = ret.Next;
				}

				return result;
			}

			return null;
		}
	}
}