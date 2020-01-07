namespace org.pv.AlgoPlayground.ArraysAndStrings.TwoStringsArePermutations
{
	public class Solution
	{
		// O(N)
		public static bool CheckTwoStringsArePermutations(string s1, string s2) 
		{
			if (s1.Length != s2.Length)
				return false;

			var charCountS1 = new int[128]; // used 128 size array, since I assume ascii chars will be used
			var charCountS2 = new int[128];

			for(int i = 0; i < s1.Length; i++)
			{
				charCountS1[s1[i]]++;
				charCountS2[s2[i]]++;
			}

			for(int i=0; i < charCountS1.Length; i++)
			{
				if(charCountS1[i] != charCountS2[i])
					return false;
			}

			return true;
		}
	}
}
