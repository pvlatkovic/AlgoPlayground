/*
Two strings A and B are isomorphic if there exists character mapping which replaces characters from A to get B. Rules for character mapping are:

all occurrences of one character (e.g. ‘x’) must be replaced with the same character (e.g. ‘y’)
no two different characters may map to the same character
a character may map to itself
Write a function that returns true if provided strings are isomorphic, otherwise false:

bool AreStringsIsomorphic(char* a, char* b)

The strings are NULL-terminated, with characters from lower case English alphabet ‘a’ – ‘z’.

Examples:

Input	Output
A = “brain”, B = “space”		true
A = “noon”, B = “feet”		false
A = “aab”, B = “ccd”		true

*/

using System.Linq;

namespace org.pv.AlgoPlayground.ArraysAndStrings.Are2StringsIsomorphic
{
	public class Solution
	{
		//O(N) 
		public static bool Are2StringsIsomorphic(string s1, string s2)
		{
			if(s1.Length != s2.Length)
				return false;
			
			var s1Map = new int[128];
			var s2Map = new int[128];

			for (int i = 0; i < s1.Length; i++)
			{
				s1Map[s1[i]]++;
				s2Map[s2[i]]++;
			}

			var s1L =s1Map.ToList(); // used default sorting, could you any basic sorting algo since we are sorting two arrays with 128 elements (constant number of elements)
			s1L.Sort();
			s1Map = s1L.ToArray<int>();

			var s2L = s2Map.ToList();
			s2L.Sort();
			s2Map = s2L.ToArray<int>();

			// sort s1Map and s1Map, they should match 
			for(int i=0; i < s1Map.Length - 1 ; i++) // we sort two 
			{
				if(s1Map[i] != s2Map[i])
					return false;
			}
			return true;
		}
	}
}