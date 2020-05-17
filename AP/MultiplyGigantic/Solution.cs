using System;
using System.Collections.Generic;

namespace org.pv.AlgoPlayground.AP.MultiplyGigantic
{
	public class Solution
	{	
		public static string Multiply(string n, int m) // n x m
		{
			var mLen = (int)(Math.Log10(m) + 1);

			var allLocalMultiplys = new string[mLen];
			var allLocalMultiplysIndex = 0;
			var maxLength = 0;

			for(int i = mLen-1; i >= 0; i--)
			{
				var rightDigit = m % 10;
				m = m / 10;

				var localMultiply = DigitMultiply(n, rightDigit, allLocalMultiplysIndex); // allLocalMultiplysIndex adds number of sufix zeros
				allLocalMultiplys[allLocalMultiplysIndex++] = localMultiply;
				maxLength = Math.Max(maxLength, localMultiply.Length);
			}

			var result = "";
			var carry = 0;

			for(int i = 0 ; i < maxLength; i++)
			{
				var localResult = 0;
				foreach(string s in allLocalMultiplys)
				{
					if (s.Length > i)
						localResult += int.Parse(s.Substring(i,1));
				}
				localResult += carry;

				result = (localResult % 10).ToString() + result;
				carry = localResult / 10;
			}

			if (carry > 0)
				result = carry + result;

			return result;
		}

		private static string DigitMultiply(string n, int mDigit, int level)
		{
			var result = ""; 
			var carry = 0;

			for(int i= n.Length-1; i > -1; i--)
			{
				var digit = int.Parse(n.Substring(i, 1));
				var multiplyDigit = digit * mDigit;
				
				result  = result + ((multiplyDigit + carry) % 10).ToString();
				carry = (multiplyDigit + carry) / 10;
			}
			if(carry > 0)
				result = result + carry;

			return new string('0', level) +  result;
		}
	}
}