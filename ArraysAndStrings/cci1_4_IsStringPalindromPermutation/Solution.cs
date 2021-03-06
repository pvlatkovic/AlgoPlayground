// Cracking the coding interview - interview questions 1.4
// Check if string is a perumutation of a palindrome (input "tact coa", true)
// character case not ignored e.g. 'c' != 'C'

namespace org.pv.AlgoPlayground.ArraysAndStrings.IsPalindromPermutation
{
	public class Solution
	{
		public static bool IsStringPalindromPermutation(string input)
		{
			var charCounter = new int[128]; // ascii

			for(int i = 0; i < input.Length; i++)
				if(input[i] != ' ') // ignore spaces
					charCounter[input[i]] += 1;
			
			int x = 0;
			for(int i = 0; i < 128; i++)
			{
				x+= charCounter[i] % 2;
				if(x == 2)
					return false;
			}
			return true;
		}
	}
}