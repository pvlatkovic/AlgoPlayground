using System.Collections.Generic;

namespace org.pv.AlgoPlayground.AP.BalancedBrackets
{
	public class Solution
	{

		// solution for ( { [ 
		public static bool IsBalancedBrackets(string input)  
		{
			// check string validity
			if(string.IsNullOrEmpty(input))
				return true;

			var stack = new Stack<char>();

			foreach(char c in input)
			{
				if(c == '(' || c == '[' || c == '{')
					stack.Push(c);
				else
				{				
					if(c == ')' || c == ']' || c == '}')
					{
						if(stack.Count == 0)
							return false;

						var cp = stack.Peek();
						if((c == ')' && cp == '(') || (c == ']' && cp == '[') || (c == '}' && cp == '{') )
							stack.Pop();
						else
							return false;
					}
				}
			}

			if(stack.Count > 0)
				return false;

			return true;
		}
	}
}