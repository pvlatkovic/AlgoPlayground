/*
	Cracking the coding interview - interview questions 1.5
	Edit operations (edits): insert, remove and replaced character. 
	Given twop strings check if they are one edit (or zero edits) away.
*/

namespace org.pv.AlgoPlayground.ArraysAndStrings.EditsAway
{
	public class Solution
	{
		public static bool IsOneOrZeroEditsAway(string s, string t)
		{
			if(System.Math.Abs(s.Length - t.Length) > 1)
				return true;

			var cs = new int[128]; //ascii again
			var ct = new int[128];

			for(int i = 0; i < s.Length; i++)
				cs[s[i]] += 1;

			for(int i = 0; i < t.Length; i++)
				ct[t[i]] += 1;

			var x = 0;
			for(int i = 0; i < 128; i++)
			{
				cs[i] -= ct[i];
				x += System.Math.Abs(cs[i]);
			}

			if(x/2 > 1) // two differences, one change :)
				return false;

			return true;
		}
	}
}