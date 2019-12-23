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

		public static Node<int> DetectLoopRacingPointers(Node<int> linkedList)
		{
			// having two pointers moving simultaniously at different speeds. Faster will outrun slower eventualy...
			var nodeSlow = linkedList;
			var nodeFast = linkedList;

			int nodeSlowCount = 0, nodeFastCount = 0;

			while (nodeSlow != null)
			{
				nodeSlowCount++;
				for(int i=0; i < 2; i++)
				{
					nodeFastCount++;
					nodeFast = nodeFast.Next;
					if(nodeFast == null)
						return null;
					if(nodeSlow == nodeFast)
					{
						// now count number of elements in the circle (e.g. 1-2-3-4-1 is a circle)
						var startCircleNode = nodeSlow; 
						var node = nodeSlow.Next;

						var circleCount = 1;

						while(node != startCircleNode)
						{
							circleCount++;
							node = node.Next;
						}
						//now what? :)
						// we have number of "slow" nodes until collision 
						// as well as number of "fast" nodes and size of "circle"


					}
				}

				nodeSlow = nodeSlow.Next;				
			}
			
			return null;
		}
	}
}