// Set of Roman numerals is given (I,V,X,L,C,D,M). You need to form two numbers from these digits

using System.Text;
using org.pv.TreesAndGraphs.Common;

namespace org.pv.AlgoPlayground.MSP.RomanDigitsFormTwoMinSumNumbers
{
	public class Solution
	{
		public static (string, string) Execute(char[] romans)
		{
			//TODO: check edge cases

			var minHeap = new MinHeap<int>();

			for (int i = 0; i < romans.Length; i++)
				minHeap.Add(ConvertRomanToInt(romans[i]));

			var d1 = string.Empty;
			var d2 = string.Empty;

			while (!minHeap.IsEmpty())
			{
				var rd1 = minHeap.Poll();
				var rd2 = 0;
				if (!minHeap.IsEmpty())
					rd2 = minHeap.Poll();

				d1 = ConvertIntToRoman(rd1) + d1; //TODO: optimiye to use char not string
				d2 = ConvertIntToRoman(rd2) + d2;
			}

			d1 = FixRomans(d1);
			d2 = FixRomans(d2);

			return (d1, d2);
		}

		private static string FixRomans(string d) // rotate to mininize 
		{
			/*
				https://www.periodni.com/roman_numerals_converter.html
				Do not subtract a number from one that is more than 10 times greater: 
					I may only precede V and X, X may only precede L and C, and C may only precede D and M.
			*/
			var res = new StringBuilder();

			for (int i = 0; i < d.Length; i = i + 2)
			{
				if (i + 1 == d.Length)
				{
					res.Append(d[i]);
					break;
				}
				if (((d[i] == 'M' || d[i] == 'D') && d[i + 1] == 'C')
						|| ((d[i] == 'L' || d[i] == 'C') && d[i + 1] == 'X')
						|| ((d[i] == 'X' || d[i] == 'V') && d[i + 1] == 'I'))
				{
					res.Append(d[i + 1]); res.Append(d[i]);
				}
				else
				{
					res.Append(d[i]); res.Append(d[i + 1]);
				}
			}

			return res.ToString();
		}

		private static string ConvertIntToRoman(int number)
		{
			switch (number) // (I, V, X, L, C, D, M)
			{
				case 0:
					return "";
				case 1:
					return "I";
				case 5:
					return "V";
				case 10:
					return "X";
				case 50:
					return "L";
				case 100:
					return "C";
				case 500:
					return "D";
				case 1000:
					return "M";
				default:
					throw new System.ArgumentException();
			}
		}

		private static int ConvertRomanToInt(char r)
		{
			switch (r) // (I, V, X, L, C, D, M)
			{
				case 'I':
					return 1;
				case 'V':
					return 5;
				case 'X':
					return 10;
				case 'L':
					return 50;
				case 'C':
					return 100;
				case 'D':
					return 500;
				case 'M':
					return 1000;
				default:
					throw new System.ArgumentException();
			}
		}
	}
}