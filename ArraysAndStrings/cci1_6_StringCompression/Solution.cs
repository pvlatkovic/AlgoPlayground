/*
	Cracking the coding interview - interview questions 1.6
*/

namespace org.pv.AlgoPlayground.ArraysAndStrings.StringCompression
{
	public class Solution
	{
		public static string Compress(string s)
		{
			string sc = string.Empty;
			var x = s[0]; 
			var c = 1;

			for(int i = 1; i < s.Length; i++)
			{
				if(s[i] == x)
				{
					c += 1;
				}
				else
				{
					sc += x + c.ToString();
					x = s[i];
					c = 1;
				}
			}
			sc += x + c.ToString(); //add last block


			if(sc.Length >= s.Length)
				return s;

			return sc;
		}
	}

}