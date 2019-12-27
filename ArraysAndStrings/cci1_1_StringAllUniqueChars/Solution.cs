// Cracking the coding interview - interview questions 1.1
// Check if string contains only unique characters. What if additional datastructure cannot be used?

namespace org.pv.AlgoPlayground.ArraysAndStrings.StringAllUniqueCharacters
{
	public class Solution
	{
		// brute force O(n^2)
		public static bool GetStringAllUniqueCharacters_Brute(string input)
		{
			for(int i=0; i < input.Length-1;i++)
				for(int j=i+1; j<input.Length; j++)
					if(input[i] == input[j])
						return false;
			return true;
		}

		// with additional data structure, O(N)
		public static bool GetStringAllUniqueCharacters_DS(string input)
		{
			// if longer than 128 (standard ascii chars set size) some chars must be repeated; 
			if(input.Length > 128) 
				return false;

			var notch = new bool[128]; // :-) recka // we could use dictionary

			for(int i=0; i < input.Length; i++)
			{
				if(notch[input[i]])
					return false;

				notch[input[i]] = true;
			}
			return true;
		}

	}
}