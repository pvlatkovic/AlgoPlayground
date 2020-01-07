namespace org.pv.AlgoPlayground.ArraysAndStrings.URLify
{
	public class Solution
	{
		//O(N), no additional space
		public static char[] URLifyString(char[] s)
		{
			var i = s.Length - 1;
			while(s[i] == ' ')
			{
				i--;
			}

			var x = i; var b = s.Length - 1;
			while(x != b)
			{
				s[b] = s[x]; s[x] = ' ';
				b--; x--;
				while(s[x] == ' ') // insert %20 sequence
				{
					s[b] = '0'; b--;
					s[b] = '2'; b--;
					s[b] = '%'; b--;
					x--;
					if(x < 0)
						break;
				}
			}
			return s;
		}
	}
}