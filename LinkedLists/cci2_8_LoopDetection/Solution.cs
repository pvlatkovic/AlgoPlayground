// Cracking coding interview 2.8 
// given a circular linked list, find the node at the beginning of the loop
// input 1->2->3->4->5->6->3 returns 3

namespace org.pv.AlgoPlayground.LinkedLists.LoopDetection
{
	public class Solution
	{
		// O(N) complexity, double space complexity in terms of references or newly created value types
		 public static Node<int> DetectLoopBrute(Node<int> linkedList)
		 {
			var node = linkedList;

			while (node != null)
			{	
				if(node.Value != -1)
				{
					if(node.Next != null && node.Next.Value == -1)
						return node;
					else
					{
						var newNode = new Node<int>(-1);
						newNode.Next = node.Next;
						node.Next = newNode;
					}
				}
				node = node.Next;
			}

			return null;
		 }

		// O(N) time and space
		public static Node<int> DetectLoopRacingPointers(Node<int> linkedList) 
		{
			// having two pointers moving simultaniously at different speeds (x2). Faster will outrun slower eventualy...
			var nodeSlow = linkedList; 
			var nodeFast = linkedList;

			while (nodeFast != null && nodeFast.Next != null)
			{
				nodeSlow = nodeSlow.Next; // move one possition
				nodeFast = nodeFast.Next.Next; // move two possitions

				if (nodeSlow == nodeFast)
				{
					// Now lets find the start of the loop.
					// Move slow pointer to the beginning of the list, 
					nodeSlow = linkedList;

					// start moving fast and slow at same speed until collide
					while(nodeSlow != nodeFast)
					{
						nodeSlow = nodeSlow.Next;
						nodeFast = nodeFast.Next;
					}
					return nodeSlow;
				}
			}

			// will try to optimize, maybe count nodes and calculate collide possition... 
			/*
			while (nodeSlow != null)
			{
				for (int i = 0; i < 2; i++)
				{
					nodeFast = nodeFast.Next;
					if (nodeFast == null)
						return null;

					if (nodeSlow == nodeFast)
					{
						while (nodeSlow != nodeFast)
						{
							nodeSlow = nodeSlow.Next;
							nodeFast = nodeFast.Next;
						}
						return nodeSlow;
					}
				}

				nodeSlow = nodeSlow.Next;
			}
			*/
			
			return null;
		}
	}
}